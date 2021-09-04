<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpAnswers = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.Label()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.grpSlot = New System.Windows.Forms.GroupBox()
        Me.nmrSlot = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpAnswers.SuspendLayout()
        Me.grpSlot.SuspendLayout()
        CType(Me.nmrSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "localhost"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(116, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtReceive
        '
        Me.txtReceive.Location = New System.Drawing.Point(12, 78)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceive.Size = New System.Drawing.Size(229, 20)
        Me.txtReceive.TabIndex = 3
        Me.txtReceive.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(145, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'grpAnswers
        '
        Me.grpAnswers.Controls.Add(Me.btnClear)
        Me.grpAnswers.Controls.Add(Me.btnD)
        Me.grpAnswers.Controls.Add(Me.txtAnswer)
        Me.grpAnswers.Controls.Add(Me.btnC)
        Me.grpAnswers.Controls.Add(Me.btnB)
        Me.grpAnswers.Controls.Add(Me.txtQuestion)
        Me.grpAnswers.Controls.Add(Me.btnFinal)
        Me.grpAnswers.Controls.Add(Me.btnA)
        Me.grpAnswers.Enabled = False
        Me.grpAnswers.Location = New System.Drawing.Point(14, 131)
        Me.grpAnswers.Name = "grpAnswers"
        Me.grpAnswers.Size = New System.Drawing.Size(753, 285)
        Me.grpAnswers.TabIndex = 10
        Me.grpAnswers.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.BackgroundImage = Global.FFF_Guest.My.Resources.Resources.cross_icon
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(379, 181)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 42)
        Me.btnClear.TabIndex = 17
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.Transparent
        Me.btnD.BackgroundImage = Global.FFF_Guest.My.Resources.Resources.Normal_Answer_Fill
        Me.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnD.FlatAppearance.BorderSize = 0
        Me.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.ForeColor = System.Drawing.Color.White
        Me.btnD.Location = New System.Drawing.Point(379, 131)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(358, 44)
        Me.btnD.TabIndex = 16
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(265, 229)
        Me.txtAnswer.MaxLength = 4
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(223, 40)
        Me.txtAnswer.TabIndex = 12
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Transparent
        Me.btnC.BackgroundImage = Global.FFF_Guest.My.Resources.Resources.Normal_Answer_Fill
        Me.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnC.FlatAppearance.BorderSize = 0
        Me.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.White
        Me.btnC.Location = New System.Drawing.Point(15, 131)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(358, 44)
        Me.btnC.TabIndex = 15
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.Transparent
        Me.btnB.BackgroundImage = Global.FFF_Guest.My.Resources.Resources.Normal_Answer_Fill
        Me.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnB.FlatAppearance.BorderSize = 0
        Me.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.ForeColor = System.Drawing.Color.White
        Me.btnB.Location = New System.Drawing.Point(379, 81)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(358, 44)
        Me.btnB.TabIndex = 14
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'txtQuestion
        '
        Me.txtQuestion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(15, 14)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(722, 64)
        Me.txtQuestion.TabIndex = 13
        Me.txtQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFinal
        '
        Me.btnFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFinal.BackgroundImage = Global.FFF_Guest.My.Resources.Resources.check_icon
        Me.btnFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinal.Location = New System.Drawing.Point(241, 181)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(132, 42)
        Me.btnFinal.TabIndex = 12
        Me.btnFinal.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.Transparent
        Me.btnA.BackgroundImage = Global.FFF_Guest.My.Resources.Resources.Normal_Answer_Fill
        Me.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnA.FlatAppearance.BorderSize = 0
        Me.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.ForeColor = System.Drawing.Color.White
        Me.btnA.Location = New System.Drawing.Point(15, 81)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(358, 44)
        Me.btnA.TabIndex = 6
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'grpSlot
        '
        Me.grpSlot.Controls.Add(Me.nmrSlot)
        Me.grpSlot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpSlot.Location = New System.Drawing.Point(12, 13)
        Me.grpSlot.Name = "grpSlot"
        Me.grpSlot.Size = New System.Drawing.Size(98, 59)
        Me.grpSlot.TabIndex = 13
        Me.grpSlot.TabStop = False
        Me.grpSlot.Text = "Select Slot:"
        '
        'nmrSlot
        '
        Me.nmrSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrSlot.Location = New System.Drawing.Point(18, 20)
        Me.nmrSlot.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nmrSlot.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrSlot.Name = "nmrSlot"
        Me.nmrSlot.Size = New System.Drawing.Size(59, 29)
        Me.nmrSlot.TabIndex = 0
        Me.nmrSlot.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(294, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "<< Server IP here."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpSlot)
        Me.Controls.Add(Me.grpAnswers)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.Text = "Fastest Finger First - Client Panel"
        Me.grpAnswers.ResumeLayout(False)
        Me.grpAnswers.PerformLayout()
        Me.grpSlot.ResumeLayout(False)
        CType(Me.nmrSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtReceive As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnA As Button
    Friend WithEvents grpAnswers As GroupBox
    Friend WithEvents btnFinal As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents grpSlot As GroupBox
    Friend WithEvents nmrSlot As NumericUpDown
    Friend WithEvents txtQuestion As Label
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
End Class
