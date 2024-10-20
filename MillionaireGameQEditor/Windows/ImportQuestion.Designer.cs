namespace Millionaire.Windows.Question_Editor
{
    partial class frmQuestionImport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionImport));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtCorrect = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.trkQuestionLevel = new System.Windows.Forms.TrackBar();
            this.lblQuestionLevelText = new System.Windows.Forms.Label();
            this.lblQuestionLevel = new System.Windows.Forms.Label();
            this.grpQuestionType = new System.Windows.Forms.GroupBox();
            this.radFastestFinger = new System.Windows.Forms.RadioButton();
            this.radRegularQuestion = new System.Windows.Forms.RadioButton();
            this.tbDatabases = new System.Windows.Forms.TabControl();
            this.tbOldDatabase = new System.Windows.Forms.TabPage();
            this.dataOldDatabase = new System.Windows.Forms.DataGridView();
            this.tbNewDatabase = new System.Windows.Forms.TabPage();
            this.dataNewDatabase = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnSaveAndNext = new System.Windows.Forms.Button();
            this.btnSkipAndNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFFFAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuestionLevel)).BeginInit();
            this.grpQuestionType.SuspendLayout();
            this.tbDatabases.SuspendLayout();
            this.tbOldDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOldDatabase)).BeginInit();
            this.tbNewDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNewDatabase)).BeginInit();
            this.pnlD.SuspendLayout();
            this.pnlB.SuspendLayout();
            this.pnlC.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.picQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(264, 10);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(368, 53);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(264, 66);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(368, 22);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(264, 91);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(368, 22);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(263, 116);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(368, 22);
            this.txtC.TabIndex = 3;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(264, 141);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(368, 22);
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
            this.txtCorrect.Location = new System.Drawing.Point(592, 209);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(39, 26);
            this.txtCorrect.TabIndex = 5;
            this.txtCorrect.Text = "A";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "D:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Correct:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 25);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear Fields";
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
            this.pnlFFFAnswer.Location = new System.Drawing.Point(1094, 1);
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
            this.txtNote.Location = new System.Drawing.Point(264, 166);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(319, 69);
            this.txtNote.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Explanation:";
            // 
            // trkQuestionLevel
            // 
            this.trkQuestionLevel.Location = new System.Drawing.Point(645, 22);
            this.trkQuestionLevel.Maximum = 15;
            this.trkQuestionLevel.Minimum = 1;
            this.trkQuestionLevel.Name = "trkQuestionLevel";
            this.trkQuestionLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkQuestionLevel.Size = new System.Drawing.Size(45, 219);
            this.trkQuestionLevel.TabIndex = 94;
            this.trkQuestionLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkQuestionLevel.Value = 1;
            this.trkQuestionLevel.Scroll += new System.EventHandler(this.trkQuestionLevel_Scroll);
            // 
            // lblQuestionLevelText
            // 
            this.lblQuestionLevelText.AutoSize = true;
            this.lblQuestionLevelText.Location = new System.Drawing.Point(648, 10);
            this.lblQuestionLevelText.Name = "lblQuestionLevelText";
            this.lblQuestionLevelText.Size = new System.Drawing.Size(81, 13);
            this.lblQuestionLevelText.TabIndex = 95;
            this.lblQuestionLevelText.Text = "Question Level:";
            // 
            // lblQuestionLevel
            // 
            this.lblQuestionLevel.AutoSize = true;
            this.lblQuestionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionLevel.Location = new System.Drawing.Point(735, 7);
            this.lblQuestionLevel.Name = "lblQuestionLevel";
            this.lblQuestionLevel.Size = new System.Drawing.Size(18, 20);
            this.lblQuestionLevel.TabIndex = 96;
            this.lblQuestionLevel.Text = "1";
            this.lblQuestionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpQuestionType
            // 
            this.grpQuestionType.Controls.Add(this.radFastestFinger);
            this.grpQuestionType.Controls.Add(this.radRegularQuestion);
            this.grpQuestionType.Location = new System.Drawing.Point(1094, 92);
            this.grpQuestionType.Name = "grpQuestionType";
            this.grpQuestionType.Size = new System.Drawing.Size(173, 66);
            this.grpQuestionType.TabIndex = 97;
            this.grpQuestionType.TabStop = false;
            this.grpQuestionType.Text = "Question type";
            this.grpQuestionType.Visible = false;
            // 
            // radFastestFinger
            // 
            this.radFastestFinger.AutoSize = true;
            this.radFastestFinger.Location = new System.Drawing.Point(10, 42);
            this.radFastestFinger.Name = "radFastestFinger";
            this.radFastestFinger.Size = new System.Drawing.Size(136, 17);
            this.radFastestFinger.TabIndex = 1;
            this.radFastestFinger.Text = "Fastest Finger Question";
            this.radFastestFinger.UseVisualStyleBackColor = true;
            this.radFastestFinger.CheckedChanged += new System.EventHandler(this.radFastestFinger_CheckedChanged);
            // 
            // radRegularQuestion
            // 
            this.radRegularQuestion.AutoSize = true;
            this.radRegularQuestion.Checked = true;
            this.radRegularQuestion.Location = new System.Drawing.Point(10, 19);
            this.radRegularQuestion.Name = "radRegularQuestion";
            this.radRegularQuestion.Size = new System.Drawing.Size(107, 17);
            this.radRegularQuestion.TabIndex = 0;
            this.radRegularQuestion.TabStop = true;
            this.radRegularQuestion.Text = "Regular Question";
            this.radRegularQuestion.UseVisualStyleBackColor = true;
            this.radRegularQuestion.CheckedChanged += new System.EventHandler(this.radRegularQuestion_CheckedChanged);
            // 
            // tbDatabases
            // 
            this.tbDatabases.Controls.Add(this.tbOldDatabase);
            this.tbDatabases.Controls.Add(this.tbNewDatabase);
            this.tbDatabases.Location = new System.Drawing.Point(12, 471);
            this.tbDatabases.Name = "tbDatabases";
            this.tbDatabases.SelectedIndex = 0;
            this.tbDatabases.Size = new System.Drawing.Size(1257, 391);
            this.tbDatabases.TabIndex = 98;
            // 
            // tbOldDatabase
            // 
            this.tbOldDatabase.Controls.Add(this.dataOldDatabase);
            this.tbOldDatabase.Location = new System.Drawing.Point(4, 22);
            this.tbOldDatabase.Name = "tbOldDatabase";
            this.tbOldDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tbOldDatabase.Size = new System.Drawing.Size(1249, 365);
            this.tbOldDatabase.TabIndex = 0;
            this.tbOldDatabase.Text = "Old Database";
            this.tbOldDatabase.UseVisualStyleBackColor = true;
            // 
            // dataOldDatabase
            // 
            this.dataOldDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOldDatabase.Location = new System.Drawing.Point(3, 6);
            this.dataOldDatabase.Name = "dataOldDatabase";
            this.dataOldDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOldDatabase.Size = new System.Drawing.Size(1240, 355);
            this.dataOldDatabase.TabIndex = 0;
            this.dataOldDatabase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOldDatabase_CellDoubleClick);
            // 
            // tbNewDatabase
            // 
            this.tbNewDatabase.Controls.Add(this.dataNewDatabase);
            this.tbNewDatabase.Location = new System.Drawing.Point(4, 22);
            this.tbNewDatabase.Name = "tbNewDatabase";
            this.tbNewDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tbNewDatabase.Size = new System.Drawing.Size(1249, 365);
            this.tbNewDatabase.TabIndex = 1;
            this.tbNewDatabase.Text = "Imported Questions";
            this.tbNewDatabase.UseVisualStyleBackColor = true;
            // 
            // dataNewDatabase
            // 
            this.dataNewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNewDatabase.Location = new System.Drawing.Point(3, 6);
            this.dataNewDatabase.Name = "dataNewDatabase";
            this.dataNewDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNewDatabase.Size = new System.Drawing.Size(1237, 354);
            this.dataNewDatabase.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1207, 235);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 99;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(1248, 235);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(21, 13);
            this.lblLevel.TabIndex = 100;
            this.lblLevel.Text = "Lvl";
            this.lblLevel.Visible = false;
            // 
            // btnSaveAndNext
            // 
            this.btnSaveAndNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveAndNext.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.saveandnext;
            this.btnSaveAndNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveAndNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNext.Location = new System.Drawing.Point(12, 75);
            this.btnSaveAndNext.Name = "btnSaveAndNext";
            this.btnSaveAndNext.Size = new System.Drawing.Size(176, 35);
            this.btnSaveAndNext.TabIndex = 101;
            this.toolTip.SetToolTip(this.btnSaveAndNext, "Import and Load Next");
            this.btnSaveAndNext.UseVisualStyleBackColor = false;
            this.btnSaveAndNext.Click += new System.EventHandler(this.btnSaveAndNext_Click);
            // 
            // btnSkipAndNext
            // 
            this.btnSkipAndNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSkipAndNext.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.skipandnext;
            this.btnSkipAndNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSkipAndNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipAndNext.Location = new System.Drawing.Point(12, 149);
            this.btnSkipAndNext.Name = "btnSkipAndNext";
            this.btnSkipAndNext.Size = new System.Drawing.Size(176, 35);
            this.btnSkipAndNext.TabIndex = 102;
            this.toolTip.SetToolTip(this.btnSkipAndNext, "Skip and Load Next");
            this.btnSkipAndNext.UseVisualStyleBackColor = false;
            this.btnSkipAndNext.Click += new System.EventHandler(this.btnSkipAndNext_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSkip.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.skip;
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(12, 116);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(176, 35);
            this.btnSkip.TabIndex = 103;
            this.toolTip.SetToolTip(this.btnSkip, "Skip");
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(692, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 104;
            this.label7.Text = "> Q15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(692, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "> Q10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(692, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "> Q5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(692, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 107;
            this.label11.Text = "Q4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(692, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 108;
            this.label12.Text = "Q3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(692, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "Q2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(692, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 110;
            this.label14.Text = "Q1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(692, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 111;
            this.label15.Text = "Q9";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(692, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 112;
            this.label16.Text = "Q8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(692, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 113;
            this.label17.Text = "Q7";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(692, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 115;
            this.label19.Text = "Q6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(692, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 116;
            this.label18.Text = "Q14";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(692, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 117;
            this.label20.Text = "Q13";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(692, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 118;
            this.label21.Text = "Q12";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(692, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Q11";
            // 
            // pnlD
            // 
            this.pnlD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlD.BackgroundImage")));
            this.pnlD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlD.Controls.Add(this.lblD);
            this.pnlD.Location = new System.Drawing.Point(640, 412);
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
            this.pnlB.Location = new System.Drawing.Point(640, 353);
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
            this.pnlC.Location = new System.Drawing.Point(0, 412);
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
            this.pnlA.Location = new System.Drawing.Point(0, 353);
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
            this.picQuestion.Location = new System.Drawing.Point(0, 253);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 35);
            this.btnSave.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnSave, "Import");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNext.BackgroundImage = global::MillionaireGameQEditor.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Location = new System.Drawing.Point(12, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(176, 33);
            this.btnNext.TabIndex = 120;
            this.toolTip.SetToolTip(this.btnNext, "Load Next");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmQuestionImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1281, 874);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSkipAndNext);
            this.Controls.Add(this.btnSaveAndNext);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbDatabases);
            this.Controls.Add(this.grpQuestionType);
            this.Controls.Add(this.lblQuestionLevel);
            this.Controls.Add(this.lblQuestionLevelText);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.pnlB);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.picQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pnlFFFAnswer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.trkQuestionLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestionImport";
            this.Text = "Import question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuestionImport_FormClosing);
            this.Load += new System.EventHandler(this.frmQuestionAdd_Load);
            this.pnlFFFAnswer.ResumeLayout(false);
            this.pnlFFFAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuestionLevel)).EndInit();
            this.grpQuestionType.ResumeLayout(false);
            this.grpQuestionType.PerformLayout();
            this.tbDatabases.ResumeLayout(false);
            this.tbOldDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOldDatabase)).EndInit();
            this.tbNewDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNewDatabase)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TrackBar trkQuestionLevel;
        private System.Windows.Forms.Label lblQuestionLevelText;
        private System.Windows.Forms.Label lblQuestionLevel;
        private System.Windows.Forms.GroupBox grpQuestionType;
        private System.Windows.Forms.RadioButton radFastestFinger;
        private System.Windows.Forms.RadioButton radRegularQuestion;
        private System.Windows.Forms.TabControl tbDatabases;
        private System.Windows.Forms.TabPage tbOldDatabase;
        private System.Windows.Forms.TabPage tbNewDatabase;
        private System.Windows.Forms.DataGridView dataOldDatabase;
        private System.Windows.Forms.DataGridView dataNewDatabase;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnSaveAndNext;
        private System.Windows.Forms.Button btnSkipAndNext;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolTip toolTip;
    }
}