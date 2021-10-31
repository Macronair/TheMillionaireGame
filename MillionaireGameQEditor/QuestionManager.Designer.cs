namespace Millionaire
{
    partial class QEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QEditor));
            this.tbLevel = new System.Windows.Forms.TabControl();
            this.tbLevel1 = new System.Windows.Forms.TabPage();
            this.dtLevel1 = new System.Windows.Forms.DataGridView();
            this.tbLevel2 = new System.Windows.Forms.TabPage();
            this.dtLevel2 = new System.Windows.Forms.DataGridView();
            this.tbLevel3 = new System.Windows.Forms.TabPage();
            this.dtLevel3 = new System.Windows.Forms.DataGridView();
            this.tbLevel4 = new System.Windows.Forms.TabPage();
            this.dtLevel4 = new System.Windows.Forms.DataGridView();
            this.tbLevel0 = new System.Windows.Forms.TabPage();
            this.dtLevel0 = new System.Windows.Forms.DataGridView();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsRemove = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsChangeLevel = new System.Windows.Forms.ToolStripButton();
            this.sts = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblId = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmenuEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestionCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestionRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuActionsResetAllQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel1UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel2UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel3UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevel4UsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFastestFingerUsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuControls = new System.Windows.Forms.MenuStrip();
            this.tbLevel.SuspendLayout();
            this.tbLevel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel1)).BeginInit();
            this.tbLevel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel2)).BeginInit();
            this.tbLevel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel3)).BeginInit();
            this.tbLevel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel4)).BeginInit();
            this.tbLevel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel0)).BeginInit();
            this.tsTools.SuspendLayout();
            this.sts.SuspendLayout();
            this.menuControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLevel
            // 
            this.tbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLevel.Controls.Add(this.tbLevel1);
            this.tbLevel.Controls.Add(this.tbLevel2);
            this.tbLevel.Controls.Add(this.tbLevel3);
            this.tbLevel.Controls.Add(this.tbLevel4);
            this.tbLevel.Controls.Add(this.tbLevel0);
            this.tbLevel.Location = new System.Drawing.Point(0, 50);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.SelectedIndex = 0;
            this.tbLevel.Size = new System.Drawing.Size(1452, 689);
            this.tbLevel.TabIndex = 22;
            // 
            // tbLevel1
            // 
            this.tbLevel1.Controls.Add(this.dtLevel1);
            this.tbLevel1.Location = new System.Drawing.Point(4, 22);
            this.tbLevel1.Name = "tbLevel1";
            this.tbLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel1.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel1.TabIndex = 0;
            this.tbLevel1.Text = "Level 1";
            this.tbLevel1.UseVisualStyleBackColor = true;
            // 
            // dtLevel1
            // 
            this.dtLevel1.AllowUserToAddRows = false;
            this.dtLevel1.AllowUserToDeleteRows = false;
            this.dtLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel1.Location = new System.Drawing.Point(6, 6);
            this.dtLevel1.Name = "dtLevel1";
            this.dtLevel1.ReadOnly = true;
            this.dtLevel1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel1.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel1.TabIndex = 14;
            this.dtLevel1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel1_CellDoubleClick);
            this.dtLevel1.SelectionChanged += new System.EventHandler(this.dtLevel1_SelectionChanged);
            // 
            // tbLevel2
            // 
            this.tbLevel2.Controls.Add(this.dtLevel2);
            this.tbLevel2.Location = new System.Drawing.Point(4, 22);
            this.tbLevel2.Name = "tbLevel2";
            this.tbLevel2.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel2.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel2.TabIndex = 1;
            this.tbLevel2.Text = "Level 2";
            this.tbLevel2.UseVisualStyleBackColor = true;
            // 
            // dtLevel2
            // 
            this.dtLevel2.AllowUserToAddRows = false;
            this.dtLevel2.AllowUserToDeleteRows = false;
            this.dtLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel2.Location = new System.Drawing.Point(6, 6);
            this.dtLevel2.Name = "dtLevel2";
            this.dtLevel2.ReadOnly = true;
            this.dtLevel2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel2.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel2.TabIndex = 15;
            this.dtLevel2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel2_CellDoubleClick);
            this.dtLevel2.SelectionChanged += new System.EventHandler(this.dtLevel2_SelectionChanged);
            // 
            // tbLevel3
            // 
            this.tbLevel3.Controls.Add(this.dtLevel3);
            this.tbLevel3.Location = new System.Drawing.Point(4, 22);
            this.tbLevel3.Name = "tbLevel3";
            this.tbLevel3.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel3.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel3.TabIndex = 2;
            this.tbLevel3.Text = "Level 3";
            this.tbLevel3.UseVisualStyleBackColor = true;
            // 
            // dtLevel3
            // 
            this.dtLevel3.AllowUserToAddRows = false;
            this.dtLevel3.AllowUserToDeleteRows = false;
            this.dtLevel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel3.Location = new System.Drawing.Point(6, 6);
            this.dtLevel3.Name = "dtLevel3";
            this.dtLevel3.ReadOnly = true;
            this.dtLevel3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel3.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel3.TabIndex = 15;
            this.dtLevel3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel3_CellDoubleClick);
            this.dtLevel3.SelectionChanged += new System.EventHandler(this.dtLevel3_SelectionChanged);
            // 
            // tbLevel4
            // 
            this.tbLevel4.Controls.Add(this.dtLevel4);
            this.tbLevel4.Location = new System.Drawing.Point(4, 22);
            this.tbLevel4.Name = "tbLevel4";
            this.tbLevel4.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel4.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel4.TabIndex = 3;
            this.tbLevel4.Text = "Level 4";
            this.tbLevel4.UseVisualStyleBackColor = true;
            // 
            // dtLevel4
            // 
            this.dtLevel4.AllowUserToAddRows = false;
            this.dtLevel4.AllowUserToDeleteRows = false;
            this.dtLevel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel4.Location = new System.Drawing.Point(6, 6);
            this.dtLevel4.Name = "dtLevel4";
            this.dtLevel4.ReadOnly = true;
            this.dtLevel4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel4.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel4.TabIndex = 15;
            this.dtLevel4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel4_CellDoubleClick);
            this.dtLevel4.SelectionChanged += new System.EventHandler(this.dtLevel4_SelectionChanged);
            // 
            // tbLevel0
            // 
            this.tbLevel0.Controls.Add(this.dtLevel0);
            this.tbLevel0.Location = new System.Drawing.Point(4, 22);
            this.tbLevel0.Name = "tbLevel0";
            this.tbLevel0.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel0.TabIndex = 4;
            this.tbLevel0.Text = "Fastest Finger";
            this.tbLevel0.UseVisualStyleBackColor = true;
            // 
            // dtLevel0
            // 
            this.dtLevel0.AllowUserToAddRows = false;
            this.dtLevel0.AllowUserToDeleteRows = false;
            this.dtLevel0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtLevel0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLevel0.Location = new System.Drawing.Point(6, 6);
            this.dtLevel0.Name = "dtLevel0";
            this.dtLevel0.ReadOnly = true;
            this.dtLevel0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel0.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel0.TabIndex = 16;
            this.dtLevel0.SelectionChanged += new System.EventHandler(this.dtLevel0_SelectionChanged);
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsRemove,
            this.tsEdit,
            this.toolStripSeparator1,
            this.tsRefresh,
            this.toolStripSeparator2,
            this.tsChangeLevel});
            this.tsTools.Location = new System.Drawing.Point(0, 24);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(1452, 25);
            this.tsTools.TabIndex = 23;
            this.tsTools.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsAdd.Image")));
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(49, 22);
            this.tsAdd.Text = "Add";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsRemove
            // 
            this.tsRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsRemove.Image")));
            this.tsRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(70, 22);
            this.tsRemove.Text = "Remove";
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsEdit.Image")));
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(47, 22);
            this.tsEdit.Text = "Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsRefresh
            // 
            this.tsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Image")));
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsChangeLevel
            // 
            this.tsChangeLevel.Image = global::MillionaireGameQEditor.Properties.Resources.move_icon;
            this.tsChangeLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChangeLevel.Name = "tsChangeLevel";
            this.tsChangeLevel.Size = new System.Drawing.Size(98, 22);
            this.tsChangeLevel.Text = "Change Level";
            this.tsChangeLevel.Click += new System.EventHandler(this.tsChangeLevel_Click);
            // 
            // sts
            // 
            this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.stlblId,
            this.stLevel});
            this.sts.Location = new System.Drawing.Point(0, 742);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(1452, 22);
            this.sts.TabIndex = 25;
            this.sts.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // stlblId
            // 
            this.stlblId.ForeColor = System.Drawing.Color.Blue;
            this.stlblId.Name = "stlblId";
            this.stlblId.Size = new System.Drawing.Size(13, 17);
            this.stlblId.Text = "0";
            // 
            // stLevel
            // 
            this.stLevel.ForeColor = System.Drawing.Color.Fuchsia;
            this.stLevel.Name = "stLevel";
            this.stLevel.Size = new System.Drawing.Size(73, 17);
            this.stLevel.Text = "Not selected";
            // 
            // tsmenuEditor
            // 
            this.tsmenuEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuQuestion});
            this.tsmenuEditor.Name = "tsmenuEditor";
            this.tsmenuEditor.Size = new System.Drawing.Size(50, 20);
            this.tsmenuEditor.Text = "Editor";
            // 
            // tsmenuQuestion
            // 
            this.tsmenuQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuQuestionCreate,
            this.tsmenuQuestionEdit,
            this.tsmenuQuestionRemove,
            this.toolStripMenuItem1,
            this.changeLevelToolStripMenuItem});
            this.tsmenuQuestion.Name = "tsmenuQuestion";
            this.tsmenuQuestion.Size = new System.Drawing.Size(180, 22);
            this.tsmenuQuestion.Text = "Question";
            // 
            // tsmenuQuestionCreate
            // 
            this.tsmenuQuestionCreate.Image = global::MillionaireGameQEditor.Properties.Resources.add;
            this.tsmenuQuestionCreate.Name = "tsmenuQuestionCreate";
            this.tsmenuQuestionCreate.Size = new System.Drawing.Size(145, 22);
            this.tsmenuQuestionCreate.Text = "Create";
            // 
            // tsmenuQuestionEdit
            // 
            this.tsmenuQuestionEdit.Image = global::MillionaireGameQEditor.Properties.Resources.edit;
            this.tsmenuQuestionEdit.Name = "tsmenuQuestionEdit";
            this.tsmenuQuestionEdit.Size = new System.Drawing.Size(145, 22);
            this.tsmenuQuestionEdit.Text = "Edit";
            // 
            // tsmenuQuestionRemove
            // 
            this.tsmenuQuestionRemove.Image = global::MillionaireGameQEditor.Properties.Resources.remove;
            this.tsmenuQuestionRemove.Name = "tsmenuQuestionRemove";
            this.tsmenuQuestionRemove.Size = new System.Drawing.Size(145, 22);
            this.tsmenuQuestionRemove.Text = "Remove";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // changeLevelToolStripMenuItem
            // 
            this.changeLevelToolStripMenuItem.Image = global::MillionaireGameQEditor.Properties.Resources.move_icon;
            this.changeLevelToolStripMenuItem.Name = "changeLevelToolStripMenuItem";
            this.changeLevelToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.changeLevelToolStripMenuItem.Text = "Change Level";
            this.changeLevelToolStripMenuItem.Click += new System.EventHandler(this.changeLevelToolStripMenuItem_Click);
            // 
            // tsmenuActions
            // 
            this.tsmenuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUsedQuestionsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.tsmenuActions.Name = "tsmenuActions";
            this.tsmenuActions.Size = new System.Drawing.Size(59, 20);
            this.tsmenuActions.Text = "Actions";
            // 
            // resetUsedQuestionsToolStripMenuItem
            // 
            this.resetUsedQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuActionsResetAllQuestions,
            this.resetLevel1UsedQuestionsToolStripMenuItem,
            this.resetLevel2UsedQuestionsToolStripMenuItem,
            this.resetLevel3UsedQuestionsToolStripMenuItem,
            this.resetLevel4UsedQuestionsToolStripMenuItem,
            this.resetFastestFingerUsedQuestionsToolStripMenuItem});
            this.resetUsedQuestionsToolStripMenuItem.Name = "resetUsedQuestionsToolStripMenuItem";
            this.resetUsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.resetUsedQuestionsToolStripMenuItem.Text = "Reset Used Questions";
            // 
            // tsmenuActionsResetAllQuestions
            // 
            this.tsmenuActionsResetAllQuestions.Name = "tsmenuActionsResetAllQuestions";
            this.tsmenuActionsResetAllQuestions.Size = new System.Drawing.Size(180, 22);
            this.tsmenuActionsResetAllQuestions.Text = "All";
            this.tsmenuActionsResetAllQuestions.Click += new System.EventHandler(this.tsmenuActionsResetAllQuestions_Click_1);
            // 
            // resetLevel1UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel1UsedQuestionsToolStripMenuItem.Name = "resetLevel1UsedQuestionsToolStripMenuItem";
            this.resetLevel1UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel1UsedQuestionsToolStripMenuItem.Text = "Level 1 only";
            this.resetLevel1UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel1UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel2UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel2UsedQuestionsToolStripMenuItem.Name = "resetLevel2UsedQuestionsToolStripMenuItem";
            this.resetLevel2UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel2UsedQuestionsToolStripMenuItem.Text = "Level 2 only";
            this.resetLevel2UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel2UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel3UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel3UsedQuestionsToolStripMenuItem.Name = "resetLevel3UsedQuestionsToolStripMenuItem";
            this.resetLevel3UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel3UsedQuestionsToolStripMenuItem.Text = "Level 3 only";
            this.resetLevel3UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel3UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetLevel4UsedQuestionsToolStripMenuItem
            // 
            this.resetLevel4UsedQuestionsToolStripMenuItem.Name = "resetLevel4UsedQuestionsToolStripMenuItem";
            this.resetLevel4UsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLevel4UsedQuestionsToolStripMenuItem.Text = "Level 4 only";
            this.resetLevel4UsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetLevel4UsedQuestionsToolStripMenuItem_Click_1);
            // 
            // resetFastestFingerUsedQuestionsToolStripMenuItem
            // 
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Name = "resetFastestFingerUsedQuestionsToolStripMenuItem";
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Text = "Fastest Finger only";
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetFastestFingerUsedQuestionsToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // menuControls
            // 
            this.menuControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuEditor,
            this.tsmenuActions});
            this.menuControls.Location = new System.Drawing.Point(0, 0);
            this.menuControls.Name = "menuControls";
            this.menuControls.Size = new System.Drawing.Size(1452, 24);
            this.menuControls.TabIndex = 24;
            this.menuControls.Text = "menuStrip1";
            // 
            // QEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 764);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.menuControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuControls;
            this.Name = "QEditor";
            this.Text = "Question Editor - The Millionaire Game";
            this.Load += new System.EventHandler(this.QEditor_Load);
            this.tbLevel.ResumeLayout(false);
            this.tbLevel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel1)).EndInit();
            this.tbLevel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel2)).EndInit();
            this.tbLevel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel3)).EndInit();
            this.tbLevel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel4)).EndInit();
            this.tbLevel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel0)).EndInit();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.sts.ResumeLayout(false);
            this.sts.PerformLayout();
            this.menuControls.ResumeLayout(false);
            this.menuControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbLevel;
        private System.Windows.Forms.TabPage tbLevel1;
        public System.Windows.Forms.DataGridView dtLevel1;
        private System.Windows.Forms.TabPage tbLevel2;
        public System.Windows.Forms.DataGridView dtLevel2;
        private System.Windows.Forms.TabPage tbLevel3;
        public System.Windows.Forms.DataGridView dtLevel3;
        private System.Windows.Forms.TabPage tbLevel4;
        public System.Windows.Forms.DataGridView dtLevel4;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsRemove;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel stlblId;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripStatusLabel stLevel;
        private System.Windows.Forms.TabPage tbLevel0;
        public System.Windows.Forms.DataGridView dtLevel0;
        private System.Windows.Forms.ToolStripMenuItem tsmenuEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuestion;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuestionCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuestionEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmenuQuestionRemove;
        private System.Windows.Forms.ToolStripMenuItem tsmenuActions;
        private System.Windows.Forms.MenuStrip menuControls;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsChangeLevel;
        private System.Windows.Forms.ToolStripMenuItem resetUsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmenuActionsResetAllQuestions;
        private System.Windows.Forms.ToolStripMenuItem resetLevel1UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevel2UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevel3UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevel4UsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFastestFingerUsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}