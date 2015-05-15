namespace Simbirsoft_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDictionaryPath = new System.Windows.Forms.TextBox();
            this.tbTextPath = new System.Windows.Forms.TextBox();
            this.btnTextFD = new System.Windows.Forms.Button();
            this.btnDictionaryFD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateHTML = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDictionary = new System.Windows.Forms.OpenFileDialog();
            this.tbMaximumLines = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDictionaryPath
            // 
            this.tbDictionaryPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbDictionaryPath.Location = new System.Drawing.Point(6, 46);
            this.tbDictionaryPath.Name = "tbDictionaryPath";
            this.tbDictionaryPath.ReadOnly = true;
            this.tbDictionaryPath.Size = new System.Drawing.Size(276, 20);
            this.tbDictionaryPath.TabIndex = 0;
            this.tbDictionaryPath.Text = "Dictionary file";
            this.tbDictionaryPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDictionaryPath.DoubleClick += new System.EventHandler(this.btnDictionaryFD_Click);
            // 
            // tbTextPath
            // 
            this.tbTextPath.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbTextPath.Location = new System.Drawing.Point(6, 19);
            this.tbTextPath.Name = "tbTextPath";
            this.tbTextPath.ReadOnly = true;
            this.tbTextPath.Size = new System.Drawing.Size(276, 20);
            this.tbTextPath.TabIndex = 1;
            this.tbTextPath.Text = "Text file";
            this.tbTextPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTextPath.DoubleClick += new System.EventHandler(this.btnTextFD_Click);
            // 
            // btnTextFD
            // 
            this.btnTextFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTextFD.Location = new System.Drawing.Point(288, 19);
            this.btnTextFD.Name = "btnTextFD";
            this.btnTextFD.Size = new System.Drawing.Size(54, 20);
            this.btnTextFD.TabIndex = 2;
            this.btnTextFD.Text = "...";
            this.btnTextFD.UseVisualStyleBackColor = true;
            this.btnTextFD.Click += new System.EventHandler(this.btnTextFD_Click);
            // 
            // btnDictionaryFD
            // 
            this.btnDictionaryFD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDictionaryFD.Location = new System.Drawing.Point(288, 45);
            this.btnDictionaryFD.Name = "btnDictionaryFD";
            this.btnDictionaryFD.Size = new System.Drawing.Size(54, 20);
            this.btnDictionaryFD.TabIndex = 3;
            this.btnDictionaryFD.Text = "...";
            this.btnDictionaryFD.UseVisualStyleBackColor = true;
            this.btnDictionaryFD.Click += new System.EventHandler(this.btnDictionaryFD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTextPath);
            this.groupBox1.Controls.Add(this.btnDictionaryFD);
            this.groupBox1.Controls.Add(this.tbDictionaryPath);
            this.groupBox1.Controls.Add(this.btnTextFD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select files";
            // 
            // btnCreateHTML
            // 
            this.btnCreateHTML.Enabled = false;
            this.btnCreateHTML.Location = new System.Drawing.Point(168, 94);
            this.btnCreateHTML.Name = "btnCreateHTML";
            this.btnCreateHTML.Size = new System.Drawing.Size(100, 31);
            this.btnCreateHTML.TabIndex = 5;
            this.btnCreateHTML.Text = "Create HTML";
            this.btnCreateHTML.UseVisualStyleBackColor = true;
            this.btnCreateHTML.Click += new System.EventHandler(this.btnCreateHTML_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 94);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.FileName = "openFileDialog1";
            this.openFileDialogText.Filter = "Текстовые файлы|*.txt";
            this.openFileDialogText.Title = "Choose file";
            // 
            // openFileDialogDictionary
            // 
            this.openFileDialogDictionary.FileName = "openFileDialog1";
            this.openFileDialogDictionary.Filter = "Текстовые файлы|*.txt";
            // 
            // tbMaximumLines
            // 
            this.tbMaximumLines.Location = new System.Drawing.Point(6, 17);
            this.tbMaximumLines.Name = "tbMaximumLines";
            this.tbMaximumLines.Size = new System.Drawing.Size(138, 20);
            this.tbMaximumLines.TabIndex = 7;
            this.tbMaximumLines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMaximumLines_KeyDown);
            this.tbMaximumLines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaximumLines_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMaximumLines);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 43);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maximum lines";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Choose HtmlFile destination folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 139);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateHTML);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simbirsoft_Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDictionaryPath;
        private System.Windows.Forms.TextBox tbTextPath;
        private System.Windows.Forms.Button btnTextFD;
        private System.Windows.Forms.Button btnDictionaryFD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateHTML;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.OpenFileDialog openFileDialogDictionary;
        private System.Windows.Forms.TextBox tbMaximumLines;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

