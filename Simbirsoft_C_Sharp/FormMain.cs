using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Simbirsoft_C_Sharp
{
    public partial class FormMain : Form
    {
        bool isTextFileChosen = false;
        bool isDictionaryFileChosen = false;
        int maximumLines;
        FileStream fs;

        Dictionary<int, string> dictionary; // Will work good!
        List<string> list; // Will work fine, but not as good as Dictionary
        Stack<string> stack; //Will work, but we need 2 stacks at the same time, or refilling stack everytime. Not good!
        Queue<string> queue; //Same minuses as Stack, not good too.
        string[] array; //Will work slowly than Dictionary and List, not good!
        Array Array; //Same as below
        Hashtable hashtable; //Not good to use in the current context.

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking this button will close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clicking this button will open file dialog to choose Text file
        /// </summary>
        private void btnTextFD_Click(object sender, EventArgs e)
        {
            while (openFileDialogText.ShowDialog() != DialogResult.OK)
                return;
            FileInfo FI = new FileInfo(openFileDialogText.FileName);
            tbTextPath.Text = openFileDialogText.FileName;

            // Enabling "Create HTML" button
            isTextFileChosen = true;
            if (isDictionaryFileChosen)
                btnCreateHTML.Enabled = true;
        }

        /// <summary>
        /// Clicking this button will open file dialog to choose Dictionary file
        /// </summary>
        private void btnDictionaryFD_Click(object sender, EventArgs e)
        { 
            if (openFileDialogDictionary.ShowDialog() != DialogResult.OK)
                return;
            FileInfo FI = new FileInfo(openFileDialogDictionary.FileName);
            tbDictionaryPath.Text = openFileDialogDictionary.FileName;

            // Enabling "Create HTML" button
            isDictionaryFileChosen = true;
            if (isTextFileChosen)
                btnCreateHTML.Enabled = true;
        }

        /// <summary>
        /// Clicking this button will create html file with changed text
        /// </summary>
        private void btnCreateHTML_Click(object sender, EventArgs e)
        {
            if (!MaximumLinesCorrect())
                return;
            CreateHTML();
            ReadDictionary();
            FillHTML();
            MessageBox.Show("Html file created successfully!");
        }

        /// <summary>
        ///  To let user write only digital numbers in maximumLines textbox
        /// </summary>
        bool nonNumberEntered = false;
        private void tbMaximumLines_KeyDown(object sender, KeyEventArgs e)
        {
            {
                nonNumberEntered = false;

                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        if (e.KeyCode != Keys.Back)
                        {
                            nonNumberEntered = true;
                        }
                    }
                }
            }
        }
        private void tbMaximumLines_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Create html-file after choosing it's folder 
        /// </summary>
        private void CreateHTML()
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fs = new FileStream(folderBrowserDialog.SelectedPath + @"\HtmlFile.html", FileMode.Create);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                File.Delete(folderBrowserDialog.SelectedPath + @"\HtmlFile.html");
                fs = new FileStream(folderBrowserDialog.SelectedPath + @"\HtmlFile.html", FileMode.Create);
            }
            fs.Close();
        }

        /// <summary>
        /// Read and save dictionary from dictionary file
        /// </summary>
        private void ReadDictionary()
        {
            StreamReader dictReader = new StreamReader(openFileDialogDictionary.FileName, Encoding.GetEncoding(1251));
            dictionary = new Dictionary<int, string>();
            int dictKey = 0; // Dictionary Key
            while (!dictReader.EndOfStream)
            {
                dictionary.Add(dictKey, dictReader.ReadLine());
                ++dictKey;
            }
        }

        /// <summary>
        /// Changing and saving lines in html document
        /// </summary>
        private void FillHTML()
        {
            string line; //Work line
            string changedWord; // to add html tags to word
            int lineCount = 1; // To check number of lines in end file
            int numberOfFile = 1; // To add new files if lines more than needed
            StreamReader textReader = new StreamReader(openFileDialogText.FileName, Encoding.GetEncoding(1251));
            StreamWriter htmlWriter = new StreamWriter(fs.Name, true, Encoding.GetEncoding(1251));
            while (!textReader.EndOfStream)
            {
                line = textReader.ReadLine();
                // For every word in dictionary
                for (int i = 0; i < dictionary.Count; i++)
                {
                    // if line less than word in dictionary
                    if (line.Length < dictionary[i].Length)
                    {
                        continue;
                    }
                    // if contains - replace
                    if (line.Contains(dictionary[i]))
                    {
                        changedWord = "<b><i>" + dictionary[i] + "</i></b>";
                        line = line.Replace(dictionary[i], changedWord);
                    }
                }
                if (lineCount <= maximumLines)
                    htmlWriter.WriteLine(line + "<br>");
                // If need to create new file
                else
                {
                    htmlWriter.Close();
                    lineCount = 1;
                    fs = new FileStream(folderBrowserDialog.SelectedPath + @"\HtmlFile" + Convert.ToString(numberOfFile) + ".html", FileMode.Create);
                    fs.Close();
                    ++numberOfFile;
                    htmlWriter = new StreamWriter(fs.Name, true, Encoding.GetEncoding(1251));
                    htmlWriter.WriteLine(line + "<br>");
                }
                ++lineCount;
            }
            htmlWriter.Close();
        }

        /// <summary>
        /// We have to check entered maximum of the lines first
        /// </summary>
        /// <returns></returns>
        private bool MaximumLinesCorrect()
        {
            if (tbMaximumLines.Text == "")
            {
                maximumLines = 100000;
                return true;
            }
            else if (Convert.ToInt32(tbMaximumLines.Text) >= 10 && Convert.ToInt32(tbMaximumLines.Text) <= 100000)
            {
                maximumLines = Convert.ToInt32(tbMaximumLines.Text);
                return true;
            }
            else
            {
                MessageBox.Show("Maximum lines should be more than 10 and less than 100000");
                tbMaximumLines.Text = "";
                return false;
            }
        }
    }
}
