namespace MillionaireGame.QEdit.Managers.Categories
{
    partial class frmCategoryAddEdit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.pnlCategoryColor = new System.Windows.Forms.Panel();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.btnClearColor = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCategoryColor = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(277, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(103, 10);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(263, 22);
            this.txtCategoryName.TabIndex = 2;
            // 
            // pnlCategoryColor
            // 
            this.pnlCategoryColor.Location = new System.Drawing.Point(164, 38);
            this.pnlCategoryColor.Name = "pnlCategoryColor";
            this.pnlCategoryColor.Size = new System.Drawing.Size(46, 21);
            this.pnlCategoryColor.TabIndex = 3;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(216, 38);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(89, 21);
            this.btnSetColor.TabIndex = 4;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // btnClearColor
            // 
            this.btnClearColor.Location = new System.Drawing.Point(304, 38);
            this.btnClearColor.Name = "btnClearColor";
            this.btnClearColor.Size = new System.Drawing.Size(62, 21);
            this.btnClearColor.TabIndex = 5;
            this.btnClearColor.Text = "Clear";
            this.btnClearColor.UseVisualStyleBackColor = true;
            this.btnClearColor.Click += new System.EventHandler(this.btnClearColor_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(103, 65);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(263, 22);
            this.txtCategoryDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // lblCategoryColor
            // 
            this.lblCategoryColor.AutoSize = true;
            this.lblCategoryColor.Location = new System.Drawing.Point(100, 42);
            this.lblCategoryColor.Name = "lblCategoryColor";
            this.lblCategoryColor.Size = new System.Drawing.Size(44, 13);
            this.lblCategoryColor.TabIndex = 10;
            this.lblCategoryColor.Text = "#00000";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(3, 117);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(52, 13);
            this.lblCategoryId.TabIndex = 11;
            this.lblCategoryId.Text = "Id = 0000";
            this.lblCategoryId.Visible = false;
            // 
            // frmCategoryAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 130);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.lblCategoryColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.btnClearColor);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.pnlCategoryColor);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCategoryAddEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit category";
            this.Load += new System.EventHandler(this.frmCategoryAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtCategoryName;
        public System.Windows.Forms.Panel pnlCategoryColor;
        public System.Windows.Forms.Button btnSetColor;
        public System.Windows.Forms.Button btnClearColor;
        public System.Windows.Forms.TextBox txtCategoryDescription;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblCategoryColor;
        public System.Windows.Forms.Label lblCategoryId;
    }
}