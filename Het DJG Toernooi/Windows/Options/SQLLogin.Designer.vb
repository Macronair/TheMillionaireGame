<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpSQLRemote = New System.Windows.Forms.GroupBox()
        Me.txtSQLR_Password = New System.Windows.Forms.TextBox()
        Me.txtSQLR_Username = New System.Windows.Forms.TextBox()
        Me.txtSQLR_Database = New System.Windows.Forms.TextBox()
        Me.txtSQLR_Port = New System.Windows.Forms.NumericUpDown()
        Me.txtSQLR_ServerInstance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radSQLLocal = New System.Windows.Forms.RadioButton()
        Me.radSQLRemote = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkHideAtStart = New System.Windows.Forms.CheckBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSQLRemote.SuspendLayout()
        CType(Me.txtSQLR_Port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 85)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The Millionaire Game"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-21, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Connect to a SQL server in order to use this application."
        '
        'grpSQLRemote
        '
        Me.grpSQLRemote.Controls.Add(Me.txtSQLR_Password)
        Me.grpSQLRemote.Controls.Add(Me.txtSQLR_Username)
        Me.grpSQLRemote.Controls.Add(Me.txtSQLR_Database)
        Me.grpSQLRemote.Controls.Add(Me.txtSQLR_Port)
        Me.grpSQLRemote.Controls.Add(Me.txtSQLR_ServerInstance)
        Me.grpSQLRemote.Controls.Add(Me.Label7)
        Me.grpSQLRemote.Controls.Add(Me.Label6)
        Me.grpSQLRemote.Controls.Add(Me.Label5)
        Me.grpSQLRemote.Controls.Add(Me.Label4)
        Me.grpSQLRemote.Controls.Add(Me.Label3)
        Me.grpSQLRemote.Enabled = False
        Me.grpSQLRemote.Location = New System.Drawing.Point(45, 165)
        Me.grpSQLRemote.Name = "grpSQLRemote"
        Me.grpSQLRemote.Size = New System.Drawing.Size(379, 162)
        Me.grpSQLRemote.TabIndex = 2
        Me.grpSQLRemote.TabStop = False
        Me.grpSQLRemote.Text = "Remote server info"
        '
        'txtSQLR_Password
        '
        Me.txtSQLR_Password.Location = New System.Drawing.Point(106, 126)
        Me.txtSQLR_Password.Name = "txtSQLR_Password"
        Me.txtSQLR_Password.Size = New System.Drawing.Size(191, 20)
        Me.txtSQLR_Password.TabIndex = 9
        Me.txtSQLR_Password.UseSystemPasswordChar = True
        '
        'txtSQLR_Username
        '
        Me.txtSQLR_Username.Location = New System.Drawing.Point(106, 100)
        Me.txtSQLR_Username.Name = "txtSQLR_Username"
        Me.txtSQLR_Username.Size = New System.Drawing.Size(191, 20)
        Me.txtSQLR_Username.TabIndex = 8
        '
        'txtSQLR_Database
        '
        Me.txtSQLR_Database.Location = New System.Drawing.Point(106, 74)
        Me.txtSQLR_Database.Name = "txtSQLR_Database"
        Me.txtSQLR_Database.Size = New System.Drawing.Size(191, 20)
        Me.txtSQLR_Database.TabIndex = 7
        '
        'txtSQLR_Port
        '
        Me.txtSQLR_Port.Location = New System.Drawing.Point(106, 48)
        Me.txtSQLR_Port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txtSQLR_Port.Name = "txtSQLR_Port"
        Me.txtSQLR_Port.Size = New System.Drawing.Size(89, 20)
        Me.txtSQLR_Port.TabIndex = 6
        Me.txtSQLR_Port.Value = New Decimal(New Integer() {1433, 0, 0, 0})
        '
        'txtSQLR_ServerInstance
        '
        Me.txtSQLR_ServerInstance.Location = New System.Drawing.Point(106, 22)
        Me.txtSQLR_ServerInstance.Name = "txtSQLR_ServerInstance"
        Me.txtSQLR_ServerInstance.Size = New System.Drawing.Size(191, 20)
        Me.txtSQLR_ServerInstance.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Database:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Server\Instance"
        '
        'radSQLLocal
        '
        Me.radSQLLocal.AutoSize = True
        Me.radSQLLocal.Location = New System.Drawing.Point(30, 119)
        Me.radSQLLocal.Name = "radSQLLocal"
        Me.radSQLLocal.Size = New System.Drawing.Size(51, 17)
        Me.radSQLLocal.TabIndex = 3
        Me.radSQLLocal.TabStop = True
        Me.radSQLLocal.Text = "Local"
        Me.radSQLLocal.UseVisualStyleBackColor = True
        '
        'radSQLRemote
        '
        Me.radSQLRemote.AutoSize = True
        Me.radSQLRemote.Location = New System.Drawing.Point(30, 142)
        Me.radSQLRemote.Name = "radSQLRemote"
        Me.radSQLRemote.Size = New System.Drawing.Size(118, 17)
        Me.radSQLRemote.TabIndex = 4
        Me.radSQLRemote.TabStop = True
        Me.radSQLRemote.Text = "Remote SQL server"
        Me.radSQLRemote.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(401, 357)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(320, 357)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkHideAtStart
        '
        Me.chkHideAtStart.AutoSize = True
        Me.chkHideAtStart.Location = New System.Drawing.Point(45, 333)
        Me.chkHideAtStart.Name = "chkHideAtStart"
        Me.chkHideAtStart.Size = New System.Drawing.Size(197, 17)
        Me.chkHideAtStart.TabIndex = 7
        Me.chkHideAtStart.Text = "Do not show this window on startup."
        Me.chkHideAtStart.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(12, 357)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'SQLLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 386)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.chkHideAtStart)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.radSQLRemote)
        Me.Controls.Add(Me.radSQLLocal)
        Me.Controls.Add(Me.grpSQLRemote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SQLLogin"
        Me.Text = "Connect to a SQL Database"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSQLRemote.ResumeLayout(False)
        Me.grpSQLRemote.PerformLayout()
        CType(Me.txtSQLR_Port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpSQLRemote As GroupBox
    Friend WithEvents radSQLLocal As RadioButton
    Friend WithEvents radSQLRemote As RadioButton
    Friend WithEvents txtSQLR_Password As TextBox
    Friend WithEvents txtSQLR_Username As TextBox
    Friend WithEvents txtSQLR_Database As TextBox
    Friend WithEvents txtSQLR_Port As NumericUpDown
    Friend WithEvents txtSQLR_ServerInstance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkHideAtStart As CheckBox
    Friend WithEvents btnTest As Button
End Class
