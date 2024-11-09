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
            this.tbLevel0 = new System.Windows.Forms.TabPage();
            this.dtLevel0 = new System.Windows.Forms.DataGridView();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsRemove = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sts = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblId = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmenuEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestionCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuQuestionRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuActionsResetAllQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFastestFingerUsedQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.importQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromOldDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControls = new System.Windows.Forms.MenuStrip();
            this.tbLevel.SuspendLayout();
            this.tbLevel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLevel1)).BeginInit();
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
            this.tbLevel.Controls.Add(this.tbLevel0);
            this.tbLevel.Location = new System.Drawing.Point(0, 50);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.SelectedIndex = 0;
            this.tbLevel.Size = new System.Drawing.Size(1452, 689);
            this.tbLevel.TabIndex = 22;
            this.tbLevel.SelectedIndexChanged += new System.EventHandler(this.tbLevel_SelectedIndexChanged);
            // 
            // tbLevel1
            // 
            this.tbLevel1.Controls.Add(this.dtLevel1);
            this.tbLevel1.Location = new System.Drawing.Point(4, 22);
            this.tbLevel1.Name = "tbLevel1";
            this.tbLevel1.Padding = new System.Windows.Forms.Padding(3);
            this.tbLevel1.Size = new System.Drawing.Size(1444, 663);
            this.tbLevel1.TabIndex = 0;
            this.tbLevel1.Text = "Regular";
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
            this.dtLevel1.MultiSelect = false;
            this.dtLevel1.Name = "dtLevel1";
            this.dtLevel1.ReadOnly = true;
            this.dtLevel1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel1.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel1.TabIndex = 14;
            this.dtLevel1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel1_CellClick);
            this.dtLevel1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel1_CellDoubleClick);
            this.dtLevel1.SelectionChanged += new System.EventHandler(this.dtLevel1_SelectionChanged);
            this.dtLevel1.Sorted += new System.EventHandler(this.dtLevel1_Sorted);
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
            this.dtLevel0.MultiSelect = false;
            this.dtLevel0.Name = "dtLevel0";
            this.dtLevel0.ReadOnly = true;
            this.dtLevel0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLevel0.Size = new System.Drawing.Size(1432, 651);
            this.dtLevel0.TabIndex = 16;
            this.dtLevel0.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel0_CellClick);
            this.dtLevel0.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLevel0_CellDoubleClick);
            this.dtLevel0.SelectionChanged += new System.EventHandler(this.dtLevel0_SelectionChanged);
            this.dtLevel0.Sorted += new System.EventHandler(this.dtLevel0_Sorted);
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsRemove,
            this.tsEdit,
            this.toolStripSeparator1,
            this.tsRefresh,
            this.toolStripSeparator2});
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
            this.tsmenuQuestionRemove});
            this.tsmenuQuestion.Name = "tsmenuQuestion";
            this.tsmenuQuestion.Size = new System.Drawing.Size(122, 22);
            this.tsmenuQuestion.Text = "Question";
            // 
            // tsmenuQuestionCreate
            // 
            this.tsmenuQuestionCreate.Image = global::MillionaireGameQEditor.Properties.Resources.add;
            this.tsmenuQuestionCreate.Name = "tsmenuQuestionCreate";
            this.tsmenuQuestionCreate.Size = new System.Drawing.Size(117, 22);
            this.tsmenuQuestionCreate.Text = "Add";
            this.tsmenuQuestionCreate.Click += new System.EventHandler(this.tsmenuQuestionCreate_Click);
            // 
            // tsmenuQuestionEdit
            // 
            this.tsmenuQuestionEdit.Image = global::MillionaireGameQEditor.Properties.Resources.edit;
            this.tsmenuQuestionEdit.Name = "tsmenuQuestionEdit";
            this.tsmenuQuestionEdit.Size = new System.Drawing.Size(117, 22);
            this.tsmenuQuestionEdit.Text = "Edit";
            this.tsmenuQuestionEdit.Click += new System.EventHandler(this.tsmenuQuestionEdit_Click);
            // 
            // tsmenuQuestionRemove
            // 
            this.tsmenuQuestionRemove.Image = global::MillionaireGameQEditor.Properties.Resources.remove;
            this.tsmenuQuestionRemove.Name = "tsmenuQuestionRemove";
            this.tsmenuQuestionRemove.Size = new System.Drawing.Size(117, 22);
            this.tsmenuQuestionRemove.Text = "Remove";
            this.tsmenuQuestionRemove.Click += new System.EventHandler(this.tsmenuQuestionRemove_Click);
            // 
            // tsmenuActions
            // 
            this.tsmenuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUsedQuestionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.importQuestionsToolStripMenuItem,
            this.exportQuestionsToolStripMenuItem});
            this.tsmenuActions.Name = "tsmenuActions";
            this.tsmenuActions.Size = new System.Drawing.Size(59, 20);
            this.tsmenuActions.Text = "Actions";
            // 
            // resetUsedQuestionsToolStripMenuItem
            // 
            this.resetUsedQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuActionsResetAllQuestions,
            this.resetFastestFingerUsedQuestionsToolStripMenuItem,
            this.atLevelToolStripMenuItem});
            this.resetUsedQuestionsToolStripMenuItem.Name = "resetUsedQuestionsToolStripMenuItem";
            this.resetUsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.resetUsedQuestionsToolStripMenuItem.Text = "Reset Used Questions";
            // 
            // tsmenuActionsResetAllQuestions
            // 
            this.tsmenuActionsResetAllQuestions.Name = "tsmenuActionsResetAllQuestions";
            this.tsmenuActionsResetAllQuestions.Size = new System.Drawing.Size(202, 22);
            this.tsmenuActionsResetAllQuestions.Text = "All";
            this.tsmenuActionsResetAllQuestions.Click += new System.EventHandler(this.tsmenuActionsResetAllQuestions_Click_1);
            // 
            // resetFastestFingerUsedQuestionsToolStripMenuItem
            // 
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Name = "resetFastestFingerUsedQuestionsToolStripMenuItem";
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Text = "Fastest Finger Questions";
            this.resetFastestFingerUsedQuestionsToolStripMenuItem.Click += new System.EventHandler(this.resetFastestFingerUsedQuestionsToolStripMenuItem_Click_1);
            // 
            // atLevelToolStripMenuItem
            // 
            this.atLevelToolStripMenuItem.Name = "atLevelToolStripMenuItem";
            this.atLevelToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.atLevelToolStripMenuItem.Text = "At Level...";
            this.atLevelToolStripMenuItem.Click += new System.EventHandler(this.atLevelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // importQuestionsToolStripMenuItem
            // 
            this.importQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromOldDatabaseToolStripMenuItem,
            this.fromCSVToolStripMenuItem});
            this.importQuestionsToolStripMenuItem.Name = "importQuestionsToolStripMenuItem";
            this.importQuestionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importQuestionsToolStripMenuItem.Text = "Import Questions";
            // 
            // fromOldDatabaseToolStripMenuItem
            // 
            this.fromOldDatabaseToolStripMenuItem.Name = "fromOldDatabaseToolStripMenuItem";
            this.fromOldDatabaseToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fromOldDatabaseToolStripMenuItem.Text = "From old database...";
            this.fromOldDatabaseToolStripMenuItem.Click += new System.EventHandler(this.fromOldDatabaseToolStripMenuItem_Click);
            // 
            // fromCSVToolStripMenuItem
            // 
            this.fromCSVToolStripMenuItem.Name = "fromCSVToolStripMenuItem";
            this.fromCSVToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fromCSVToolStripMenuItem.Text = "From CSV...";
            this.fromCSVToolStripMenuItem.Click += new System.EventHandler(this.fromCSVToolStripMenuItem_Click);
            // 
            // exportQuestionsToolStripMenuItem
            // 
            this.exportQuestionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toCSVToolStripMenuItem});
            this.exportQuestionsToolStripMenuItem.Name = "exportQuestionsToolStripMenuItem";
            this.exportQuestionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportQuestionsToolStripMenuItem.Text = "Export Questions";
            // 
            // toCSVToolStripMenuItem
            // 
            this.toCSVToolStripMenuItem.Name = "toCSVToolStripMenuItem";
            this.toCSVToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.toCSVToolStripMenuItem.Text = "To CSV...";
            this.toCSVToolStripMenuItem.Click += new System.EventHandler(this.toCSVToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetUsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmenuActionsResetAllQuestions;
        private System.Windows.Forms.ToolStripMenuItem resetFastestFingerUsedQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromOldDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCSVToolStripMenuItem;
    }
}