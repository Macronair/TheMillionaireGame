namespace MillionaireGameQEditor.Windows
{
    partial class frmQuestionsExportCSV
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
            this.grpRegularQuestions = new System.Windows.Forms.GroupBox();
            this.grpFFFQuestions = new System.Windows.Forms.GroupBox();
            this.chkRegularQuestions = new System.Windows.Forms.CheckBox();
            this.chkFFFQuestions = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegularQuestionsBrowse = new System.Windows.Forms.Button();
            this.btnFFFQuestionsBrowse = new System.Windows.Forms.Button();
            this.txtRegularQuestionsFileLoc = new System.Windows.Forms.TextBox();
            this.txtFFFQuestionsFileLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRegularQuestions.SuspendLayout();
            this.grpFFFQuestions.SuspendLayout();
            this.SuspendLayout();
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
            this.grpRegularQuestions.TabIndex = 0;
            this.grpRegularQuestions.TabStop = false;
            this.grpRegularQuestions.Text = "Regular Questions - Export Settings";
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
            this.grpFFFQuestions.TabIndex = 1;
            this.grpFFFQuestions.TabStop = false;
            this.grpFFFQuestions.Text = "Fastest Finger First Questions - Export Settings";
            // 
            // chkRegularQuestions
            // 
            this.chkRegularQuestions.AutoSize = true;
            this.chkRegularQuestions.Location = new System.Drawing.Point(12, 12);
            this.chkRegularQuestions.Name = "chkRegularQuestions";
            this.chkRegularQuestions.Size = new System.Drawing.Size(113, 17);
            this.chkRegularQuestions.TabIndex = 2;
            this.chkRegularQuestions.Text = "Regular Questions";
            this.chkRegularQuestions.UseVisualStyleBackColor = true;
            this.chkRegularQuestions.CheckedChanged += new System.EventHandler(this.chkRegularQuestions_CheckedChanged);
            // 
            // chkFFFQuestions
            // 
            this.chkFFFQuestions.AutoSize = true;
            this.chkFFFQuestions.Location = new System.Drawing.Point(12, 127);
            this.chkFFFQuestions.Name = "chkFFFQuestions";
            this.chkFFFQuestions.Size = new System.Drawing.Size(164, 17);
            this.chkFFFQuestions.TabIndex = 3;
            this.chkFFFQuestions.Text = "Fastest Finger First Questions";
            this.chkFFFQuestions.UseVisualStyleBackColor = true;
            this.chkFFFQuestions.CheckedChanged += new System.EventHandler(this.chkFFFQuestions_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(386, 239);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // txtRegularQuestionsFileLoc
            // 
            this.txtRegularQuestionsFileLoc.Location = new System.Drawing.Point(92, 21);
            this.txtRegularQuestionsFileLoc.Name = "txtRegularQuestionsFileLoc";
            this.txtRegularQuestionsFileLoc.Size = new System.Drawing.Size(270, 20);
            this.txtRegularQuestionsFileLoc.TabIndex = 1;
            // 
            // txtFFFQuestionsFileLoc
            // 
            this.txtFFFQuestionsFileLoc.Location = new System.Drawing.Point(92, 21);
            this.txtFFFQuestionsFileLoc.Name = "txtFFFQuestionsFileLoc";
            this.txtFFFQuestionsFileLoc.Size = new System.Drawing.Size(270, 20);
            this.txtFFFQuestionsFileLoc.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File location:";
            // 
            // frmQuestionsExportCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chkFFFQuestions);
            this.Controls.Add(this.chkRegularQuestions);
            this.Controls.Add(this.grpFFFQuestions);
            this.Controls.Add(this.grpRegularQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestionsExportCSV";
            this.Text = "Export questions to CSV file";
            this.Load += new System.EventHandler(this.ExportQuestionsCSV_Load);
            this.grpRegularQuestions.ResumeLayout(false);
            this.grpRegularQuestions.PerformLayout();
            this.grpFFFQuestions.ResumeLayout(false);
            this.grpFFFQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegularQuestions;
        private System.Windows.Forms.GroupBox grpFFFQuestions;
        private System.Windows.Forms.CheckBox chkRegularQuestions;
        private System.Windows.Forms.CheckBox chkFFFQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegularQuestionsFileLoc;
        private System.Windows.Forms.Button btnRegularQuestionsBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFFFQuestionsFileLoc;
        private System.Windows.Forms.Button btnFFFQuestionsBrowse;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
    }
}