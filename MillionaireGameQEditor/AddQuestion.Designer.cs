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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionAdd));
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlD = new System.Windows.Forms.Panel();
            this.lblD = new System.Windows.Forms.Label();
            this.pnlB = new System.Windows.Forms.Panel();
            this.lblB = new System.Windows.Forms.Label();
            this.pnlC = new System.Windows.Forms.Panel();
            this.lblC = new System.Windows.Forms.Label();
            this.pnlA = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.picQuestion = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlFFFAnswer.SuspendLayout();
            this.pnlD.SuspendLayout();
            this.pnlB.SuspendLayout();
            this.pnlC.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.picQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(68, 36);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(368, 53);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(68, 91);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(368, 24);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(68, 116);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(368, 24);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(68, 141);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(368, 24);
            this.txtC.TabIndex = 3;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(68, 166);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(368, 24);
            this.txtD.TabIndex = 4;
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
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
            this.txtCorrect.Location = new System.Drawing.Point(492, 12);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(80, 26);
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
            this.txtLevel.Location = new System.Drawing.Point(484, 143);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(136, 26);
            this.txtLevel.TabIndex = 6;
            this.txtLevel.SelectedIndexChanged += new System.EventHandler(this.txtLevel_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(640, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(640, 69);
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
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "D:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correct:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Level:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(640, 43);
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
            this.pnlFFFAnswer.Location = new System.Drawing.Point(445, 44);
            this.pnlFFFAnswer.Name = "pnlFFFAnswer";
            this.pnlFFFAnswer.Size = new System.Drawing.Size(175, 85);
            this.pnlFFFAnswer.TabIndex = 17;
            this.pnlFFFAnswer.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 55);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(12, 16);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "*";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(116, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFFFD
            // 
            this.btnFFFD.Location = new System.Drawing.Point(127, 7);
            this.btnFFFD.Name = "btnFFFD";
            this.btnFFFD.Size = new System.Drawing.Size(42, 43);
            this.btnFFFD.TabIndex = 4;
            this.btnFFFD.Text = "D";
            this.btnFFFD.UseVisualStyleBackColor = true;
            this.btnFFFD.Click += new System.EventHandler(this.btnFFFD_Click);
            // 
            // btnFFFC
            // 
            this.btnFFFC.Location = new System.Drawing.Point(85, 7);
            this.btnFFFC.Name = "btnFFFC";
            this.btnFFFC.Size = new System.Drawing.Size(42, 43);
            this.btnFFFC.TabIndex = 3;
            this.btnFFFC.Text = "C";
            this.btnFFFC.UseVisualStyleBackColor = true;
            this.btnFFFC.Click += new System.EventHandler(this.btnFFFC_Click);
            // 
            // btnFFFB
            // 
            this.btnFFFB.Location = new System.Drawing.Point(44, 7);
            this.btnFFFB.Name = "btnFFFB";
            this.btnFFFB.Size = new System.Drawing.Size(42, 43);
            this.btnFFFB.TabIndex = 2;
            this.btnFFFB.Text = "B";
            this.btnFFFB.UseVisualStyleBackColor = true;
            this.btnFFFB.Click += new System.EventHandler(this.btnFFFB_Click);
            // 
            // btnFFFA
            // 
            this.btnFFFA.Location = new System.Drawing.Point(3, 7);
            this.btnFFFA.Name = "btnFFFA";
            this.btnFFFA.Size = new System.Drawing.Size(42, 43);
            this.btnFFFA.TabIndex = 1;
            this.btnFFFA.Text = "A";
            this.btnFFFA.UseVisualStyleBackColor = true;
            this.btnFFFA.Click += new System.EventHandler(this.btnFFFA_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(155, 199);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(281, 60);
            this.txtNote.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Explanation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Q Value:";
            this.label9.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(484, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 21;
            this.textBox2.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 93;
            this.label15.Text = "Preview:";
            // 
            // pnlD
            // 
            this.pnlD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlD.BackgroundImage")));
            this.pnlD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlD.Controls.Add(this.lblD);
            this.pnlD.Location = new System.Drawing.Point(640, 444);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(641, 57);
            this.pnlD.TabIndex = 91;
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.White;
            this.lblD.Location = new System.Drawing.Point(41, 5);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(476, 46);
            this.lblD.TabIndex = 19;
            this.lblD.Text = "D:";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlB
            // 
            this.pnlB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlB.BackgroundImage")));
            this.pnlB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlB.Controls.Add(this.lblB);
            this.pnlB.Location = new System.Drawing.Point(640, 385);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(641, 57);
            this.pnlB.TabIndex = 90;
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.White;
            this.lblB.Location = new System.Drawing.Point(41, 6);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(476, 45);
            this.lblB.TabIndex = 19;
            this.lblB.Text = "B:";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlC
            // 
            this.pnlC.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.Normal_Answer_Fill_l;
            this.pnlC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlC.Controls.Add(this.lblC);
            this.pnlC.Location = new System.Drawing.Point(0, 444);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(641, 57);
            this.pnlC.TabIndex = 89;
            // 
            // lblC
            // 
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(122, 5);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(476, 46);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "C:";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlA
            // 
            this.pnlA.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.Normal_Answer_Fill_l;
            this.pnlA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlA.Controls.Add(this.lblA);
            this.pnlA.Location = new System.Drawing.Point(0, 385);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(641, 57);
            this.pnlA.TabIndex = 88;
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(123, 6);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(476, 45);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "A:";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picQuestion
            // 
            this.picQuestion.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.Large_Strap_Fill;
            this.picQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQuestion.Controls.Add(this.lblQuestion);
            this.picQuestion.Location = new System.Drawing.Point(0, 285);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(1280, 93);
            this.picQuestion.TabIndex = 92;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(132, 12);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1016, 69);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 513);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.pnlB);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.picQuestion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNote);
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
            this.Text = "Add question";
            this.Load += new System.EventHandler(this.frmQuestionAdd_Load);
            this.pnlFFFAnswer.ResumeLayout(false);
            this.pnlFFFAnswer.PerformLayout();
            this.pnlD.ResumeLayout(false);
            this.pnlB.ResumeLayout(false);
            this.pnlC.ResumeLayout(false);
            this.pnlA.ResumeLayout(false);
            this.picQuestion.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Panel pnlD;
        internal System.Windows.Forms.Label lblD;
        internal System.Windows.Forms.Panel pnlB;
        internal System.Windows.Forms.Label lblB;
        internal System.Windows.Forms.Panel pnlC;
        internal System.Windows.Forms.Label lblC;
        internal System.Windows.Forms.Panel pnlA;
        internal System.Windows.Forms.Label lblA;
        internal System.Windows.Forms.Panel picQuestion;
        internal System.Windows.Forms.Label lblQuestion;
    }
}