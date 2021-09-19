namespace Millionaire.Windows.Question_Editor
{
    partial class frmQuestionAdd
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtCorrect = new System.Windows.Forms.ComboBox();
            this.txtLevel = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlFFFAnswer = new System.Windows.Forms.Panel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFFFD = new System.Windows.Forms.Button();
            this.btnFFFC = new System.Windows.Forms.Button();
            this.btnFFFB = new System.Windows.Forms.Button();
            this.btnFFFA = new System.Windows.Forms.Button();
            this.pnlFFFAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(71, 12);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(349, 73);
            this.txtQuestion.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(71, 91);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(259, 24);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(71, 117);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(259, 24);
            this.txtB.TabIndex = 2;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(71, 143);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(259, 24);
            this.txtC.TabIndex = 3;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(71, 169);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(259, 24);
            this.txtD.TabIndex = 4;
            // 
            // txtCorrect
            // 
            this.txtCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrect.FormattingEnabled = true;
            this.txtCorrect.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.txtCorrect.Location = new System.Drawing.Point(71, 231);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(44, 26);
            this.txtCorrect.TabIndex = 5;
            this.txtCorrect.Text = "A";
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.FormattingEnabled = true;
            this.txtLevel.Items.AddRange(new object[] {
            "Level 1 (q1-5)",
            "Level 2 (q6-10)",
            "Level 3 (q11-14)",
            "Level 4 (q15)",
            "Fastest Finger Round"});
            this.txtLevel.Location = new System.Drawing.Point(71, 199);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(136, 26);
            this.txtLevel.TabIndex = 6;
            this.txtLevel.SelectedIndexChanged += new System.EventHandler(this.txtLevel_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(122, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "D:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correct:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Level:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 25);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlFFFAnswer
            // 
            this.pnlFFFAnswer.Controls.Add(this.lblAnswer);
            this.pnlFFFAnswer.Controls.Add(this.btnReset);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFD);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFC);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFB);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFA);
            this.pnlFFFAnswer.Location = new System.Drawing.Point(121, 231);
            this.pnlFFFAnswer.Name = "pnlFFFAnswer";
            this.pnlFFFAnswer.Size = new System.Drawing.Size(228, 85);
            this.pnlFFFAnswer.TabIndex = 17;
            this.pnlFFFAnswer.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 55);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(13, 16);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "*";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(126, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFFFD
            // 
            this.btnFFFD.Location = new System.Drawing.Point(159, 7);
            this.btnFFFD.Name = "btnFFFD";
            this.btnFFFD.Size = new System.Drawing.Size(42, 43);
            this.btnFFFD.TabIndex = 4;
            this.btnFFFD.Text = "D";
            this.btnFFFD.UseVisualStyleBackColor = true;
            this.btnFFFD.Click += new System.EventHandler(this.btnFFFD_Click);
            // 
            // btnFFFC
            // 
            this.btnFFFC.Location = new System.Drawing.Point(111, 7);
            this.btnFFFC.Name = "btnFFFC";
            this.btnFFFC.Size = new System.Drawing.Size(42, 43);
            this.btnFFFC.TabIndex = 3;
            this.btnFFFC.Text = "C";
            this.btnFFFC.UseVisualStyleBackColor = true;
            this.btnFFFC.Click += new System.EventHandler(this.btnFFFC_Click);
            // 
            // btnFFFB
            // 
            this.btnFFFB.Location = new System.Drawing.Point(63, 7);
            this.btnFFFB.Name = "btnFFFB";
            this.btnFFFB.Size = new System.Drawing.Size(42, 43);
            this.btnFFFB.TabIndex = 2;
            this.btnFFFB.Text = "B";
            this.btnFFFB.UseVisualStyleBackColor = true;
            this.btnFFFB.Click += new System.EventHandler(this.btnFFFB_Click);
            // 
            // btnFFFA
            // 
            this.btnFFFA.Location = new System.Drawing.Point(15, 7);
            this.btnFFFA.Name = "btnFFFA";
            this.btnFFFA.Size = new System.Drawing.Size(42, 43);
            this.btnFFFA.TabIndex = 1;
            this.btnFFFA.Text = "A";
            this.btnFFFA.UseVisualStyleBackColor = true;
            this.btnFFFA.Click += new System.EventHandler(this.btnFFFA_Click);
            // 
            // frmQuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 358);
            this.Controls.Add(this.pnlFFFAnswer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestionAdd";
            this.Text = "Add new question";
            this.Load += new System.EventHandler(this.frmQuestionAdd_Load);
            this.pnlFFFAnswer.ResumeLayout(false);
            this.pnlFFFAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.ComboBox txtCorrect;
        private System.Windows.Forms.ComboBox txtLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlFFFAnswer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFFFD;
        private System.Windows.Forms.Button btnFFFC;
        private System.Windows.Forms.Button btnFFFB;
        private System.Windows.Forms.Button btnFFFA;
        public System.Windows.Forms.Label lblAnswer;
    }
}