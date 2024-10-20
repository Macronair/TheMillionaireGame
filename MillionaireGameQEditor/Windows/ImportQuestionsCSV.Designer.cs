namespace MillionaireGameQEditor.Windows
{
    partial class frmQuestionsImportCSV
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
            this.chkFFFQuestions = new System.Windows.Forms.CheckBox();
            this.chkRegularQuestions = new System.Windows.Forms.CheckBox();
            this.grpFFFQuestions = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFFFQuestionsFileLoc = new System.Windows.Forms.TextBox();
            this.btnFFFQuestionsBrowse = new System.Windows.Forms.Button();
            this.grpRegularQuestions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegularQuestionsFileLoc = new System.Windows.Forms.TextBox();
            this.btnRegularQuestionsBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.grpFFFQuestions.SuspendLayout();
            this.grpRegularQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFFFQuestions
            // 
            this.chkFFFQuestions.AutoSize = true;
            this.chkFFFQuestions.Location = new System.Drawing.Point(12, 127);
            this.chkFFFQuestions.Name = "chkFFFQuestions";
            this.chkFFFQuestions.Size = new System.Drawing.Size(164, 17);
            this.chkFFFQuestions.TabIndex = 7;
            this.chkFFFQuestions.Text = "Fastest Finger First Questions";
            this.chkFFFQuestions.UseVisualStyleBackColor = true;
            this.chkFFFQuestions.CheckedChanged += new System.EventHandler(this.chkFFFQuestions_CheckedChanged);
            // 
            // chkRegularQuestions
            // 
            this.chkRegularQuestions.AutoSize = true;
            this.chkRegularQuestions.Location = new System.Drawing.Point(12, 12);
            this.chkRegularQuestions.Name = "chkRegularQuestions";
            this.chkRegularQuestions.Size = new System.Drawing.Size(113, 17);
            this.chkRegularQuestions.TabIndex = 6;
            this.chkRegularQuestions.Text = "Regular Questions";
            this.chkRegularQuestions.UseVisualStyleBackColor = true;
            this.chkRegularQuestions.CheckedChanged += new System.EventHandler(this.chkRegularQuestions_CheckedChanged);
            // 
            // grpFFFQuestions
            // 
            this.grpFFFQuestions.Controls.Add(this.label2);
            this.grpFFFQuestions.Controls.Add(this.txtFFFQuestionsFileLoc);
            this.grpFFFQuestions.Controls.Add(this.btnFFFQuestionsBrowse);
            this.grpFFFQuestions.Enabled = false;
            this.grpFFFQuestions.Location = new System.Drawing.Point(12, 150);
            this.grpFFFQuestions.Name = "grpFFFQuestions";
            this.grpFFFQuestions.Size = new System.Drawing.Size(449, 83);
            this.grpFFFQuestions.TabIndex = 5;
            this.grpFFFQuestions.TabStop = false;
            this.grpFFFQuestions.Text = "Fastest Finger First Questions - Export Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File location:";
            // 
            // txtFFFQuestionsFileLoc
            // 
            this.txtFFFQuestionsFileLoc.Location = new System.Drawing.Point(92, 21);
            this.txtFFFQuestionsFileLoc.Name = "txtFFFQuestionsFileLoc";
            this.txtFFFQuestionsFileLoc.Size = new System.Drawing.Size(270, 20);
            this.txtFFFQuestionsFileLoc.TabIndex = 2;
            // 
            // btnFFFQuestionsBrowse
            // 
            this.btnFFFQuestionsBrowse.Location = new System.Drawing.Point(368, 19);
            this.btnFFFQuestionsBrowse.Name = "btnFFFQuestionsBrowse";
            this.btnFFFQuestionsBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnFFFQuestionsBrowse.TabIndex = 1;
            this.btnFFFQuestionsBrowse.Text = "Browse...";
            this.btnFFFQuestionsBrowse.UseVisualStyleBackColor = true;
            this.btnFFFQuestionsBrowse.Click += new System.EventHandler(this.btnFFFQuestionsBrowse_Click);
            // 
            // grpRegularQuestions
            // 
            this.grpRegularQuestions.Controls.Add(this.label1);
            this.grpRegularQuestions.Controls.Add(this.txtRegularQuestionsFileLoc);
            this.grpRegularQuestions.Controls.Add(this.btnRegularQuestionsBrowse);
            this.grpRegularQuestions.Enabled = false;
            this.grpRegularQuestions.Location = new System.Drawing.Point(12, 37);
            this.grpRegularQuestions.Name = "grpRegularQuestions";
            this.grpRegularQuestions.Size = new System.Drawing.Size(449, 83);
            this.grpRegularQuestions.TabIndex = 4;
            this.grpRegularQuestions.TabStop = false;
            this.grpRegularQuestions.Text = "Regular Questions - Export Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File location:";
            // 
            // txtRegularQuestionsFileLoc
            // 
            this.txtRegularQuestionsFileLoc.Location = new System.Drawing.Point(92, 21);
            this.txtRegularQuestionsFileLoc.Name = "txtRegularQuestionsFileLoc";
            this.txtRegularQuestionsFileLoc.Size = new System.Drawing.Size(270, 20);
            this.txtRegularQuestionsFileLoc.TabIndex = 1;
            // 
            // btnRegularQuestionsBrowse
            // 
            this.btnRegularQuestionsBrowse.Location = new System.Drawing.Point(368, 19);
            this.btnRegularQuestionsBrowse.Name = "btnRegularQuestionsBrowse";
            this.btnRegularQuestionsBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnRegularQuestionsBrowse.TabIndex = 0;
            this.btnRegularQuestionsBrowse.Text = "Browse...";
            this.btnRegularQuestionsBrowse.UseVisualStyleBackColor = true;
            this.btnRegularQuestionsBrowse.Click += new System.EventHandler(this.btnRegularQuestionsBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(386, 239);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmQuestionsImportCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.chkFFFQuestions);
            this.Controls.Add(this.chkRegularQuestions);
            this.Controls.Add(this.grpFFFQuestions);
            this.Controls.Add(this.grpRegularQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestionsImportCSV";
            this.Text = "Import questions from CSV file";
            this.Load += new System.EventHandler(this.frmQuestionsImportCSV_Load);
            this.grpFFFQuestions.ResumeLayout(false);
            this.grpFFFQuestions.PerformLayout();
            this.grpRegularQuestions.ResumeLayout(false);
            this.grpRegularQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFFFQuestions;
        private System.Windows.Forms.CheckBox chkRegularQuestions;
        private System.Windows.Forms.GroupBox grpFFFQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFFFQuestionsFileLoc;
        private System.Windows.Forms.Button btnFFFQuestionsBrowse;
        private System.Windows.Forms.GroupBox grpRegularQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegularQuestionsFileLoc;
        private System.Windows.Forms.Button btnRegularQuestionsBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
    }
}