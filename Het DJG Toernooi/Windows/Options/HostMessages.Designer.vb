<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HostMessages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HostMessages))
        Me.txtNewMessage = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDeleteMessage = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dtMessages = New System.Windows.Forms.DataGridView()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewMessage
        '
        Me.txtNewMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewMessage.Location = New System.Drawing.Point(12, 13)
        Me.txtNewMessage.Name = "txtNewMessage"
        Me.txtNewMessage.Size = New System.Drawing.Size(487, 26)
        Me.txtNewMessage.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(505, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDeleteMessage
        '
        Me.btnDeleteMessage.BackgroundImage = CType(resources.GetObject("btnDeleteMessage.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteMessage.Location = New System.Drawing.Point(12, 361)
        Me.btnDeleteMessage.Name = "btnDeleteMessage"
        Me.btnDeleteMessage.Size = New System.Drawing.Size(34, 31)
        Me.btnDeleteMessage.TabIndex = 3
        Me.btnDeleteMessage.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(505, 369)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'dtMessages
        '
        Me.dtMessages.AllowUserToAddRows = False
        Me.dtMessages.AllowUserToDeleteRows = False
        Me.dtMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtMessages.ColumnHeadersVisible = False
        Me.dtMessages.Location = New System.Drawing.Point(12, 45)
        Me.dtMessages.Name = "dtMessages"
        Me.dtMessages.ReadOnly = True
        Me.dtMessages.RowHeadersVisible = False
        Me.dtMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtMessages.Size = New System.Drawing.Size(568, 310)
        Me.dtMessages.TabIndex = 5
        '
        'HostMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 401)
        Me.Controls.Add(Me.dtMessages)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnDeleteMessage)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNewMessage)
        Me.Name = "HostMessages"
        Me.ShowIcon = False
        Me.Text = "Default Host Messages"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewMessage As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDeleteMessage As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents dtMessages As DataGridView
End Class
