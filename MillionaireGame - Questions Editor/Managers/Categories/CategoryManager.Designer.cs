namespace MillionaireGame.QEdit.Managers
{
    partial class frmCategoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryManager));
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsRemove = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtCategories = new System.Windows.Forms.DataGridView();
            this.tsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategories)).BeginInit();
            this.SuspendLayout();
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
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(800, 25);
            this.tsTools.TabIndex = 24;
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dtCategories
            // 
            this.dtCategories.AllowUserToAddRows = false;
            this.dtCategories.AllowUserToDeleteRows = false;
            this.dtCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategories.Location = new System.Drawing.Point(0, 25);
            this.dtCategories.MultiSelect = false;
            this.dtCategories.Name = "dtCategories";
            this.dtCategories.ReadOnly = true;
            this.dtCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCategories.Size = new System.Drawing.Size(800, 428);
            this.dtCategories.TabIndex = 25;
            this.dtCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCategories_CellClick);
            this.dtCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCategories_CellDoubleClick);
            // 
            // frmCategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtCategories);
            this.Controls.Add(this.tsTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategoryManager";
            this.Text = "Category Manager - The Millionaire Game";
            this.Load += new System.EventHandler(this.frmCategoryManager_Load);
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsRemove;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.DataGridView dtCategories;
    }
}