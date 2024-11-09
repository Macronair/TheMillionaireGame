namespace Millionaire.Windows.Question_Editor
{
    partial class frmEditQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtCorrect = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlFFFAnswer = new System.Windows.Forms.Panel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFFFD = new System.Windows.Forms.Button();
            this.btnFFFC = new System.Windows.Forms.Button();
            this.btnFFFB = new System.Windows.Forms.Button();
            this.btnFFFA = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
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
            this.chkQuestionUsed = new System.Windows.Forms.CheckBox();
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.cmbQuestionRange = new System.Windows.Forms.ComboBox();
            this.radDiffRange = new System.Windows.Forms.RadioButton();
            this.lblQuestionLevelText = new System.Windows.Forms.Label();
            this.lblQuestionLevel = new System.Windows.Forms.Label();
            this.radDiffSpecific = new System.Windows.Forms.RadioButton();
            this.trkQuestionLevel = new System.Windows.Forms.TrackBar();
            this.pnlFFFAnswer.SuspendLayout();
            this.pnlD.SuspendLayout();
            this.pnlB.SuspendLayout();
            this.pnlC.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.picQuestion.SuspendLayout();
            this.grpDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuestionLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correct";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(67, 57);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(357, 53);
            this.txtQuestion.TabIndex = 6;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(67, 114);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(357, 24);
            this.txtA.TabIndex = 7;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(67, 139);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(357, 24);
            this.txtB.TabIndex = 8;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(67, 164);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(357, 24);
            this.txtC.TabIndex = 9;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(67, 189);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(357, 24);
            this.txtD.TabIndex = 10;
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
            this.txtCorrect.Location = new System.Drawing.Point(477, 57);
            this.txtCorrect.MaxLength = 1;
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(80, 26);
            this.txtCorrect.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(203, 7);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(59, 20);
            this.txtId.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Id";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 47);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.skip;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(81, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 47);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(203, 28);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(59, 20);
            this.txtLevel.TabIndex = 16;
            this.txtLevel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Level";
            this.label8.Visible = false;
            // 
            // pnlFFFAnswer
            // 
            this.pnlFFFAnswer.Controls.Add(this.lblAnswer);
            this.pnlFFFAnswer.Controls.Add(this.btnReset);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFD);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFC);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFB);
            this.pnlFFFAnswer.Controls.Add(this.btnFFFA);
            this.pnlFFFAnswer.Location = new System.Drawing.Point(433, 89);
            this.pnlFFFAnswer.Name = "pnlFFFAnswer";
            this.pnlFFFAnswer.Size = new System.Drawing.Size(175, 85);
            this.pnlFFFAnswer.TabIndex = 18;
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
            this.btnReset.Location = new System.Drawing.Point(114, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFFFD
            // 
            this.btnFFFD.Enabled = false;
            this.btnFFFD.Location = new System.Drawing.Point(128, 7);
            this.btnFFFD.Name = "btnFFFD";
            this.btnFFFD.Size = new System.Drawing.Size(42, 43);
            this.btnFFFD.TabIndex = 4;
            this.btnFFFD.Text = "D";
            this.btnFFFD.UseVisualStyleBackColor = true;
            this.btnFFFD.Click += new System.EventHandler(this.btnFFFD_Click_1);
            // 
            // btnFFFC
            // 
            this.btnFFFC.Enabled = false;
            this.btnFFFC.Location = new System.Drawing.Point(87, 7);
            this.btnFFFC.Name = "btnFFFC";
            this.btnFFFC.Size = new System.Drawing.Size(42, 43);
            this.btnFFFC.TabIndex = 3;
            this.btnFFFC.Text = "C";
            this.btnFFFC.UseVisualStyleBackColor = true;
            this.btnFFFC.Click += new System.EventHandler(this.btnFFFC_Click_1);
            // 
            // btnFFFB
            // 
            this.btnFFFB.Enabled = false;
            this.btnFFFB.Location = new System.Drawing.Point(46, 7);
            this.btnFFFB.Name = "btnFFFB";
            this.btnFFFB.Size = new System.Drawing.Size(42, 43);
            this.btnFFFB.TabIndex = 2;
            this.btnFFFB.Text = "B";
            this.btnFFFB.UseVisualStyleBackColor = true;
            this.btnFFFB.Click += new System.EventHandler(this.btnFFFB_Click_1);
            // 
            // btnFFFA
            // 
            this.btnFFFA.Enabled = false;
            this.btnFFFA.Location = new System.Drawing.Point(5, 7);
            this.btnFFFA.Name = "btnFFFA";
            this.btnFFFA.Size = new System.Drawing.Size(42, 43);
            this.btnFFFA.TabIndex = 1;
            this.btnFFFA.Text = "A";
            this.btnFFFA.UseVisualStyleBackColor = true;
            this.btnFFFA.Click += new System.EventHandler(this.btnFFFA_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Explanation:";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(135, 219);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(289, 60);
            this.txtNote.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(115, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 87;
            this.label15.Text = "Preview:";
            // 
            // pnlD
            // 
            this.pnlD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlD.BackgroundImage")));
            this.pnlD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlD.Controls.Add(this.lblD);
            this.pnlD.Location = new System.Drawing.Point(640, 459);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(641, 57);
            this.pnlD.TabIndex = 85;
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
            this.pnlB.Location = new System.Drawing.Point(640, 400);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(641, 57);
            this.pnlB.TabIndex = 84;
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
            this.pnlC.Location = new System.Drawing.Point(0, 459);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(641, 57);
            this.pnlC.TabIndex = 83;
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
            this.pnlA.Location = new System.Drawing.Point(0, 400);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(641, 57);
            this.pnlA.TabIndex = 82;
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
            this.picQuestion.Location = new System.Drawing.Point(0, 300);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(1280, 93);
            this.picQuestion.TabIndex = 86;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(132, 2);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1016, 86);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkQuestionUsed
            // 
            this.chkQuestionUsed.AutoSize = true;
            this.chkQuestionUsed.Location = new System.Drawing.Point(433, 180);
            this.chkQuestionUsed.Name = "chkQuestionUsed";
            this.chkQuestionUsed.Size = new System.Drawing.Size(104, 17);
            this.chkQuestionUsed.TabIndex = 100;
            this.chkQuestionUsed.Text = "Question is used";
            this.chkQuestionUsed.UseVisualStyleBackColor = true;
            // 
            // grpDifficulty
            // 
            this.grpDifficulty.Controls.Add(this.cmbQuestionRange);
            this.grpDifficulty.Controls.Add(this.radDiffRange);
            this.grpDifficulty.Controls.Add(this.lblQuestionLevelText);
            this.grpDifficulty.Controls.Add(this.lblQuestionLevel);
            this.grpDifficulty.Controls.Add(this.radDiffSpecific);
            this.grpDifficulty.Controls.Add(this.trkQuestionLevel);
            this.grpDifficulty.Location = new System.Drawing.Point(614, 57);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(184, 237);
            this.grpDifficulty.TabIndex = 101;
            this.grpDifficulty.TabStop = false;
            this.grpDifficulty.Text = "Difficulty";
            // 
            // cmbQuestionRange
            // 
            this.cmbQuestionRange.Enabled = false;
            this.cmbQuestionRange.FormattingEnabled = true;
            this.cmbQuestionRange.Items.AddRange(new object[] {
            "Lvl1: Question 1 - 5",
            "Lvl2: Question 6 - 10",
            "Lvl3: Question 11 - 14",
            "Lvl4: Question 15"});
            this.cmbQuestionRange.Location = new System.Drawing.Point(6, 65);
            this.cmbQuestionRange.Name = "cmbQuestionRange";
            this.cmbQuestionRange.Size = new System.Drawing.Size(121, 21);
            this.cmbQuestionRange.TabIndex = 2;
            // 
            // radDiffRange
            // 
            this.radDiffRange.AutoSize = true;
            this.radDiffRange.Location = new System.Drawing.Point(6, 42);
            this.radDiffRange.Name = "radDiffRange";
            this.radDiffRange.Size = new System.Drawing.Size(57, 17);
            this.radDiffRange.TabIndex = 1;
            this.radDiffRange.Text = "Range";
            this.radDiffRange.UseVisualStyleBackColor = true;
            this.radDiffRange.CheckedChanged += new System.EventHandler(this.radDiffRange_CheckedChanged);
            // 
            // lblQuestionLevelText
            // 
            this.lblQuestionLevelText.AutoSize = true;
            this.lblQuestionLevelText.Location = new System.Drawing.Point(46, 189);
            this.lblQuestionLevelText.Name = "lblQuestionLevelText";
            this.lblQuestionLevelText.Size = new System.Drawing.Size(81, 13);
            this.lblQuestionLevelText.TabIndex = 95;
            this.lblQuestionLevelText.Text = "Question Level:";
            // 
            // lblQuestionLevel
            // 
            this.lblQuestionLevel.AutoSize = true;
            this.lblQuestionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionLevel.Location = new System.Drawing.Point(109, 202);
            this.lblQuestionLevel.Name = "lblQuestionLevel";
            this.lblQuestionLevel.Size = new System.Drawing.Size(18, 20);
            this.lblQuestionLevel.TabIndex = 96;
            this.lblQuestionLevel.Text = "1";
            this.lblQuestionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radDiffSpecific
            // 
            this.radDiffSpecific.AutoSize = true;
            this.radDiffSpecific.Checked = true;
            this.radDiffSpecific.Location = new System.Drawing.Point(6, 19);
            this.radDiffSpecific.Name = "radDiffSpecific";
            this.radDiffSpecific.Size = new System.Drawing.Size(63, 17);
            this.radDiffSpecific.TabIndex = 0;
            this.radDiffSpecific.TabStop = true;
            this.radDiffSpecific.Text = "Specific";
            this.radDiffSpecific.UseVisualStyleBackColor = true;
            this.radDiffSpecific.CheckedChanged += new System.EventHandler(this.radDiffSpecific_CheckedChanged);
            // 
            // trkQuestionLevel
            // 
            this.trkQuestionLevel.Location = new System.Drawing.Point(133, 7);
            this.trkQuestionLevel.Maximum = 15;
            this.trkQuestionLevel.Minimum = 1;
            this.trkQuestionLevel.Name = "trkQuestionLevel";
            this.trkQuestionLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkQuestionLevel.Size = new System.Drawing.Size(45, 224);
            this.trkQuestionLevel.TabIndex = 94;
            this.trkQuestionLevel.Value = 1;
            this.trkQuestionLevel.Scroll += new System.EventHandler(this.trkQuestionLevel_Scroll);
            // 
            // frmEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 528);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.chkQuestionUsed);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.pnlB);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.picQuestion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pnlFFFAnswer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditQuestion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit question";
            this.Load += new System.EventHandler(this.frmEditQuestion_Load);
            this.pnlFFFAnswer.ResumeLayout(false);
            this.pnlFFFAnswer.PerformLayout();
            this.pnlD.ResumeLayout(false);
            this.pnlB.ResumeLayout(false);
            this.pnlC.ResumeLayout(false);
            this.pnlA.ResumeLayout(false);
            this.picQuestion.ResumeLayout(false);
            this.grpDifficulty.ResumeLayout(false);
            this.grpDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuestionLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtQuestion;
        public System.Windows.Forms.TextBox txtA;
        public System.Windows.Forms.TextBox txtB;
        public System.Windows.Forms.TextBox txtC;
        public System.Windows.Forms.TextBox txtD;
        public System.Windows.Forms.ComboBox txtCorrect;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Panel pnlFFFAnswer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFFFD;
        private System.Windows.Forms.Button btnFFFC;
        private System.Windows.Forms.Button btnFFFB;
        private System.Windows.Forms.Button btnFFFA;
        public System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNote;
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
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.CheckBox chkQuestionUsed;
        private System.Windows.Forms.GroupBox grpDifficulty;
        public System.Windows.Forms.Label lblQuestionLevelText;
        public System.Windows.Forms.Label lblQuestionLevel;
        public System.Windows.Forms.TrackBar trkQuestionLevel;
        public System.Windows.Forms.ComboBox cmbQuestionRange;
        public System.Windows.Forms.RadioButton radDiffRange;
        public System.Windows.Forms.RadioButton radDiffSpecific;
    }
}