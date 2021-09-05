<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPanel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPanel))
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnSndOpening = New System.Windows.Forms.Button()
        Me.btnLightsDown = New System.Windows.Forms.Button()
        Me.btnNewQuestion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmrLevel = New System.Windows.Forms.NumericUpDown()
        Me.btnReveal = New System.Windows.Forms.Button()
        Me.btnWalk = New System.Windows.Forms.Button()
        Me.btnCommercial = New System.Windows.Forms.Button()
        Me.btnClosing = New System.Windows.Forms.Button()
        Me.txtCorrect = New System.Windows.Forms.TextBox()
        Me.txtWrong = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.txtDrop = New System.Windows.Forms.TextBox()
        Me.txtQLeft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnStopPC = New System.Windows.Forms.Button()
        Me.chk5050 = New System.Windows.Forms.CheckBox()
        Me.chkPlusOne = New System.Windows.Forms.CheckBox()
        Me.chkSwitch = New System.Windows.Forms.CheckBox()
        Me.chkBreak = New System.Windows.Forms.CheckBox()
        Me.chkOutOfTime = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkUsed = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkCorrectAnswer = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrResume = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRules = New System.Windows.Forms.Timer(Me.components)
        Me.grpRules = New System.Windows.Forms.GroupBox()
        Me.btnLL4 = New System.Windows.Forms.Button()
        Me.btnUnlockSwitch = New System.Windows.Forms.Button()
        Me.btnHideTree = New System.Windows.Forms.Button()
        Me.btnShowTree = New System.Windows.Forms.Button()
        Me.btnTreeReset = New System.Windows.Forms.Button()
        Me.btnLL3 = New System.Windows.Forms.Button()
        Me.btnLL2 = New System.Windows.Forms.Button()
        Me.btnLL1 = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnTreePr = New System.Windows.Forms.Button()
        Me.chkShowQuestion = New System.Windows.Forms.CheckBox()
        Me.clrBGColor = New System.Windows.Forms.ColorDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtExplain = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkVote = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeMoneyStrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionsEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TVScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpLifelines = New System.Windows.Forms.GroupBox()
        Me.btn5050 = New System.Windows.Forms.Button()
        Me.btnPlusOne = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.grpHost = New System.Windows.Forms.GroupBox()
        Me.grpTV = New System.Windows.Forms.GroupBox()
        Me.grpATAInfo = New System.Windows.Forms.GroupBox()
        Me.lblATA_D = New System.Windows.Forms.Label()
        Me.lblATA_C = New System.Windows.Forms.Label()
        Me.lblATA_B = New System.Windows.Forms.Label()
        Me.lblATA_A = New System.Windows.Forms.Label()
        Me.tmrLifelineBling = New System.Windows.Forms.Timer(Me.components)
        Me.btnFFF = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        CType(Me.nmrLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpRules.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grpLifelines.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.grpHost.SuspendLayout()
        Me.grpTV.SuspendLayout()
        Me.grpATAInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Silver
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.Black
        Me.txtQuestion.Location = New System.Drawing.Point(20, 242)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(598, 47)
        Me.txtQuestion.TabIndex = 1
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.Silver
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.ForeColor = System.Drawing.Color.Black
        Me.txtA.Location = New System.Drawing.Point(97, 294)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(219, 26)
        Me.txtA.TabIndex = 2
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.Silver
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.ForeColor = System.Drawing.Color.Black
        Me.txtC.Location = New System.Drawing.Point(97, 326)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(219, 26)
        Me.txtC.TabIndex = 4
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.Silver
        Me.txtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.ForeColor = System.Drawing.Color.Black
        Me.txtD.Location = New System.Drawing.Point(322, 326)
        Me.txtD.Name = "txtD"
        Me.txtD.ReadOnly = True
        Me.txtD.Size = New System.Drawing.Size(219, 26)
        Me.txtD.TabIndex = 5
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.Silver
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.ForeColor = System.Drawing.Color.Black
        Me.txtB.Location = New System.Drawing.Point(322, 294)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(219, 26)
        Me.txtB.TabIndex = 2
        '
        'btnSndOpening
        '
        Me.btnSndOpening.Location = New System.Drawing.Point(9, 29)
        Me.btnSndOpening.Name = "btnSndOpening"
        Me.btnSndOpening.Size = New System.Drawing.Size(75, 28)
        Me.btnSndOpening.TabIndex = 10
        Me.btnSndOpening.Text = "Opening"
        Me.btnSndOpening.UseVisualStyleBackColor = True
        '
        'btnLightsDown
        '
        Me.btnLightsDown.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnLightsDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLightsDown.ForeColor = System.Drawing.Color.Black
        Me.btnLightsDown.Location = New System.Drawing.Point(11, 15)
        Me.btnLightsDown.Name = "btnLightsDown"
        Me.btnLightsDown.Size = New System.Drawing.Size(78, 27)
        Me.btnLightsDown.TabIndex = 13
        Me.btnLightsDown.Text = "Lights Down"
        Me.btnLightsDown.UseVisualStyleBackColor = False
        '
        'btnNewQuestion
        '
        Me.btnNewQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewQuestion.ForeColor = System.Drawing.Color.Black
        Me.btnNewQuestion.Location = New System.Drawing.Point(11, 46)
        Me.btnNewQuestion.Name = "btnNewQuestion"
        Me.btnNewQuestion.Size = New System.Drawing.Size(158, 27)
        Me.btnNewQuestion.TabIndex = 14
        Me.btnNewQuestion.Text = "Question"
        Me.btnNewQuestion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(460, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Current Level"
        '
        'nmrLevel
        '
        Me.nmrLevel.Location = New System.Drawing.Point(533, 412)
        Me.nmrLevel.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nmrLevel.Name = "nmrLevel"
        Me.nmrLevel.Size = New System.Drawing.Size(39, 20)
        Me.nmrLevel.TabIndex = 16
        '
        'btnReveal
        '
        Me.btnReveal.BackColor = System.Drawing.Color.Turquoise
        Me.btnReveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReveal.Location = New System.Drawing.Point(91, 15)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(78, 27)
        Me.btnReveal.TabIndex = 17
        Me.btnReveal.Text = "Reveal"
        Me.btnReveal.UseVisualStyleBackColor = False
        '
        'btnWalk
        '
        Me.btnWalk.BackColor = System.Drawing.Color.LimeGreen
        Me.btnWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWalk.ForeColor = System.Drawing.Color.Black
        Me.btnWalk.Location = New System.Drawing.Point(11, 78)
        Me.btnWalk.Name = "btnWalk"
        Me.btnWalk.Size = New System.Drawing.Size(78, 27)
        Me.btnWalk.TabIndex = 18
        Me.btnWalk.Text = "Walk Away"
        Me.btnWalk.UseVisualStyleBackColor = False
        '
        'btnCommercial
        '
        Me.btnCommercial.Location = New System.Drawing.Point(87, 29)
        Me.btnCommercial.Name = "btnCommercial"
        Me.btnCommercial.Size = New System.Drawing.Size(75, 28)
        Me.btnCommercial.TabIndex = 19
        Me.btnCommercial.Text = "Commercial"
        Me.btnCommercial.UseVisualStyleBackColor = True
        '
        'btnClosing
        '
        Me.btnClosing.Location = New System.Drawing.Point(165, 29)
        Me.btnClosing.Name = "btnClosing"
        Me.btnClosing.Size = New System.Drawing.Size(75, 28)
        Me.btnClosing.TabIndex = 21
        Me.btnClosing.Text = "Closing"
        Me.btnClosing.UseVisualStyleBackColor = True
        '
        'txtCorrect
        '
        Me.txtCorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrect.Location = New System.Drawing.Point(364, 359)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.ReadOnly = True
        Me.txtCorrect.Size = New System.Drawing.Size(75, 20)
        Me.txtCorrect.TabIndex = 22
        Me.txtCorrect.Text = "100"
        '
        'txtWrong
        '
        Me.txtWrong.BackColor = System.Drawing.Color.Red
        Me.txtWrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWrong.ForeColor = System.Drawing.Color.White
        Me.txtWrong.Location = New System.Drawing.Point(364, 385)
        Me.txtWrong.Name = "txtWrong"
        Me.txtWrong.ReadOnly = True
        Me.txtWrong.Size = New System.Drawing.Size(75, 20)
        Me.txtWrong.TabIndex = 23
        Me.txtWrong.Text = "0"
        '
        'txtCurrent
        '
        Me.txtCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(364, 411)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.ReadOnly = True
        Me.txtCurrent.Size = New System.Drawing.Size(75, 20)
        Me.txtCurrent.TabIndex = 24
        Me.txtCurrent.Text = "0"
        '
        'txtDrop
        '
        Me.txtDrop.BackColor = System.Drawing.Color.Aqua
        Me.txtDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrop.Location = New System.Drawing.Point(497, 359)
        Me.txtDrop.Name = "txtDrop"
        Me.txtDrop.ReadOnly = True
        Me.txtDrop.Size = New System.Drawing.Size(75, 20)
        Me.txtDrop.TabIndex = 25
        Me.txtDrop.Text = "0"
        '
        'txtQLeft
        '
        Me.txtQLeft.BackColor = System.Drawing.Color.Blue
        Me.txtQLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQLeft.ForeColor = System.Drawing.Color.White
        Me.txtQLeft.Location = New System.Drawing.Point(497, 385)
        Me.txtQLeft.Name = "txtQLeft"
        Me.txtQLeft.ReadOnly = True
        Me.txtQLeft.Size = New System.Drawing.Size(75, 20)
        Me.txtQLeft.TabIndex = 26
        Me.txtQLeft.Text = "15"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Drop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "QLeft"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Correct"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Wrong"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Current"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(3, 3)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(24, 13)
        Me.lblAnswer.TabIndex = 33
        Me.lblAnswer.Text = "n/a"
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.Black
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.ForeColor = System.Drawing.Color.White
        Me.btnA.Location = New System.Drawing.Point(20, 294)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(71, 26)
        Me.btnA.TabIndex = 34
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.Black
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.ForeColor = System.Drawing.Color.White
        Me.btnB.Location = New System.Drawing.Point(547, 294)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(71, 26)
        Me.btnB.TabIndex = 35
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Black
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.ForeColor = System.Drawing.Color.White
        Me.btnC.Location = New System.Drawing.Point(20, 326)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(71, 26)
        Me.btnC.TabIndex = 36
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.Black
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.ForeColor = System.Drawing.Color.White
        Me.btnD.Location = New System.Drawing.Point(547, 326)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(71, 26)
        Me.btnD.TabIndex = 37
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'btnStopPC
        '
        Me.btnStopPC.BackColor = System.Drawing.Color.Red
        Me.btnStopPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopPC.ForeColor = System.Drawing.Color.White
        Me.btnStopPC.Location = New System.Drawing.Point(567, 137)
        Me.btnStopPC.Name = "btnStopPC"
        Me.btnStopPC.Size = New System.Drawing.Size(54, 25)
        Me.btnStopPC.TabIndex = 38
        Me.btnStopPC.Text = "HALT"
        Me.btnStopPC.UseVisualStyleBackColor = False
        '
        'chk5050
        '
        Me.chk5050.AutoSize = True
        Me.chk5050.Checked = True
        Me.chk5050.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk5050.Location = New System.Drawing.Point(150, 61)
        Me.chk5050.Name = "chk5050"
        Me.chk5050.Size = New System.Drawing.Size(59, 17)
        Me.chk5050.TabIndex = 39
        Me.chk5050.Text = "Enable"
        Me.chk5050.UseVisualStyleBackColor = True
        '
        'chkPlusOne
        '
        Me.chkPlusOne.AutoSize = True
        Me.chkPlusOne.Checked = True
        Me.chkPlusOne.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPlusOne.Location = New System.Drawing.Point(80, 61)
        Me.chkPlusOne.Name = "chkPlusOne"
        Me.chkPlusOne.Size = New System.Drawing.Size(59, 17)
        Me.chkPlusOne.TabIndex = 40
        Me.chkPlusOne.Text = "Enable"
        Me.chkPlusOne.UseVisualStyleBackColor = True
        '
        'chkSwitch
        '
        Me.chkSwitch.AutoSize = True
        Me.chkSwitch.Checked = True
        Me.chkSwitch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSwitch.Enabled = False
        Me.chkSwitch.Location = New System.Drawing.Point(218, 61)
        Me.chkSwitch.Name = "chkSwitch"
        Me.chkSwitch.Size = New System.Drawing.Size(59, 17)
        Me.chkSwitch.TabIndex = 41
        Me.chkSwitch.Text = "Enable"
        Me.chkSwitch.UseVisualStyleBackColor = True
        '
        'chkBreak
        '
        Me.chkBreak.AutoSize = True
        Me.chkBreak.Location = New System.Drawing.Point(6, 13)
        Me.chkBreak.Name = "chkBreak"
        Me.chkBreak.Size = New System.Drawing.Size(62, 17)
        Me.chkBreak.TabIndex = 45
        Me.chkBreak.Text = "BREAK"
        Me.chkBreak.UseVisualStyleBackColor = True
        '
        'chkOutOfTime
        '
        Me.chkOutOfTime.AutoSize = True
        Me.chkOutOfTime.Location = New System.Drawing.Point(74, 13)
        Me.chkOutOfTime.Name = "chkOutOfTime"
        Me.chkOutOfTime.Size = New System.Drawing.Size(95, 17)
        Me.chkOutOfTime.TabIndex = 46
        Me.chkOutOfTime.Text = "OUT OF TIME"
        Me.chkOutOfTime.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(568, 114)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(28, 20)
        Me.txtID.TabIndex = 47
        '
        'chkUsed
        '
        Me.chkUsed.AutoSize = True
        Me.chkUsed.Enabled = False
        Me.chkUsed.Location = New System.Drawing.Point(602, 117)
        Me.chkUsed.Name = "chkUsed"
        Me.chkUsed.Size = New System.Drawing.Size(15, 14)
        Me.chkUsed.TabIndex = 48
        Me.chkUsed.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(9, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 24)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "New Guest"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(91, 78)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(78, 27)
        Me.btnQuit.TabIndex = 50
        Me.btnQuit.Text = "Bye Bye"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'chkCorrectAnswer
        '
        Me.chkCorrectAnswer.AutoSize = True
        Me.chkCorrectAnswer.Location = New System.Drawing.Point(11, 108)
        Me.chkCorrectAnswer.Name = "chkCorrectAnswer"
        Me.chkCorrectAnswer.Size = New System.Drawing.Size(90, 17)
        Me.chkCorrectAnswer.TabIndex = 52
        Me.chkCorrectAnswer.Text = "Show Correct"
        Me.chkCorrectAnswer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblAnswer)
        Me.Panel1.Location = New System.Drawing.Point(107, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(62, 20)
        Me.Panel1.TabIndex = 53
        Me.Panel1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(489, 208)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 26)
        Me.lblTime.TabIndex = 56
        Me.lblTime.Text = "30"
        Me.lblTime.Visible = False
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'tmrResume
        '
        Me.tmrResume.Interval = 900
        '
        'tmrRules
        '
        Me.tmrRules.Interval = 200
        '
        'grpRules
        '
        Me.grpRules.Controls.Add(Me.btnLL4)
        Me.grpRules.Controls.Add(Me.btnUnlockSwitch)
        Me.grpRules.Controls.Add(Me.btnHideTree)
        Me.grpRules.Controls.Add(Me.btnShowTree)
        Me.grpRules.Controls.Add(Me.btnTreeReset)
        Me.grpRules.Controls.Add(Me.btnLL3)
        Me.grpRules.Controls.Add(Me.btnLL2)
        Me.grpRules.Controls.Add(Me.btnLL1)
        Me.grpRules.Controls.Add(Me.btnRules)
        Me.grpRules.Controls.Add(Me.btnTreePr)
        Me.grpRules.Location = New System.Drawing.Point(251, 27)
        Me.grpRules.Name = "grpRules"
        Me.grpRules.Size = New System.Drawing.Size(367, 85)
        Me.grpRules.TabIndex = 57
        Me.grpRules.TabStop = False
        Me.grpRules.Text = "Money Tree"
        '
        'btnLL4
        '
        Me.btnLL4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLL4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL4.Location = New System.Drawing.Point(317, 16)
        Me.btnLL4.Name = "btnLL4"
        Me.btnLL4.Size = New System.Drawing.Size(31, 24)
        Me.btnLL4.TabIndex = 9
        Me.btnLL4.Text = "J4"
        Me.btnLL4.UseVisualStyleBackColor = False
        '
        'btnUnlockSwitch
        '
        Me.btnUnlockSwitch.BackColor = System.Drawing.Color.Orange
        Me.btnUnlockSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnlockSwitch.ForeColor = System.Drawing.Color.Black
        Me.btnUnlockSwitch.Location = New System.Drawing.Point(221, 49)
        Me.btnUnlockSwitch.Name = "btnUnlockSwitch"
        Me.btnUnlockSwitch.Size = New System.Drawing.Size(127, 24)
        Me.btnUnlockSwitch.TabIndex = 8
        Me.btnUnlockSwitch.Text = "RISK MODE OFF"
        Me.btnUnlockSwitch.UseVisualStyleBackColor = False
        '
        'btnHideTree
        '
        Me.btnHideTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHideTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideTree.Location = New System.Drawing.Point(62, 16)
        Me.btnHideTree.Name = "btnHideTree"
        Me.btnHideTree.Size = New System.Drawing.Size(54, 32)
        Me.btnHideTree.TabIndex = 7
        Me.btnHideTree.Text = "Hide"
        Me.btnHideTree.UseVisualStyleBackColor = False
        '
        'btnShowTree
        '
        Me.btnShowTree.BackColor = System.Drawing.Color.Lime
        Me.btnShowTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowTree.Location = New System.Drawing.Point(6, 16)
        Me.btnShowTree.Name = "btnShowTree"
        Me.btnShowTree.Size = New System.Drawing.Size(54, 32)
        Me.btnShowTree.TabIndex = 6
        Me.btnShowTree.Text = "Show"
        Me.btnShowTree.UseVisualStyleBackColor = False
        '
        'btnTreeReset
        '
        Me.btnTreeReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTreeReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreeReset.Location = New System.Drawing.Point(122, 49)
        Me.btnTreeReset.Name = "btnTreeReset"
        Me.btnTreeReset.Size = New System.Drawing.Size(88, 24)
        Me.btnTreeReset.TabIndex = 5
        Me.btnTreeReset.Text = "RESET TREE"
        Me.btnTreeReset.UseVisualStyleBackColor = False
        '
        'btnLL3
        '
        Me.btnLL3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL3.Location = New System.Drawing.Point(285, 16)
        Me.btnLL3.Name = "btnLL3"
        Me.btnLL3.Size = New System.Drawing.Size(31, 24)
        Me.btnLL3.TabIndex = 4
        Me.btnLL3.Text = "J3"
        Me.btnLL3.UseVisualStyleBackColor = False
        '
        'btnLL2
        '
        Me.btnLL2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL2.Location = New System.Drawing.Point(253, 16)
        Me.btnLL2.Name = "btnLL2"
        Me.btnLL2.Size = New System.Drawing.Size(31, 24)
        Me.btnLL2.TabIndex = 3
        Me.btnLL2.Text = "J2"
        Me.btnLL2.UseVisualStyleBackColor = False
        '
        'btnLL1
        '
        Me.btnLL1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL1.Location = New System.Drawing.Point(221, 16)
        Me.btnLL1.Name = "btnLL1"
        Me.btnLL1.Size = New System.Drawing.Size(31, 24)
        Me.btnLL1.TabIndex = 2
        Me.btnLL1.Text = "J1"
        Me.btnLL1.UseVisualStyleBackColor = False
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Location = New System.Drawing.Point(6, 50)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(88, 23)
        Me.btnRules.TabIndex = 1
        Me.btnRules.Text = "Explain Rules"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'btnTreePr
        '
        Me.btnTreePr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTreePr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreePr.Location = New System.Drawing.Point(122, 16)
        Me.btnTreePr.Name = "btnTreePr"
        Me.btnTreePr.Size = New System.Drawing.Size(88, 24)
        Me.btnTreePr.TabIndex = 0
        Me.btnTreePr.Text = "PROG. ANIM"
        Me.btnTreePr.UseVisualStyleBackColor = False
        '
        'chkShowQuestion
        '
        Me.chkShowQuestion.AutoSize = True
        Me.chkShowQuestion.Location = New System.Drawing.Point(6, 12)
        Me.chkShowQuestion.Name = "chkShowQuestion"
        Me.chkShowQuestion.Size = New System.Drawing.Size(121, 17)
        Me.chkShowQuestion.TabIndex = 0
        Me.chkShowQuestion.Text = "Show Question (TV)"
        Me.chkShowQuestion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 21)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Change Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtExplain
        '
        Me.txtExplain.BackColor = System.Drawing.Color.DarkGray
        Me.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExplain.ForeColor = System.Drawing.Color.White
        Me.txtExplain.Location = New System.Drawing.Point(85, 357)
        Me.txtExplain.Multiline = True
        Me.txtExplain.Name = "txtExplain"
        Me.txtExplain.Size = New System.Drawing.Size(229, 83)
        Me.txtExplain.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Question info"
        '
        'chkVote
        '
        Me.chkVote.AutoSize = True
        Me.chkVote.Checked = True
        Me.chkVote.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVote.Location = New System.Drawing.Point(10, 61)
        Me.chkVote.Name = "chkVote"
        Me.chkVote.Size = New System.Drawing.Size(59, 17)
        Me.chkVote.TabIndex = 71
        Me.chkVote.Text = "Enable"
        Me.chkVote.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.GameToolStripMenuItem, Me.ViewToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 24)
        Me.MenuStrip1.TabIndex = 73
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeMoneyStrapToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DatabaseToolStripMenuItem.Text = "Options"
        '
        'ChangeMoneyStrapToolStripMenuItem
        '
        Me.ChangeMoneyStrapToolStripMenuItem.Name = "ChangeMoneyStrapToolStripMenuItem"
        Me.ChangeMoneyStrapToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ChangeMoneyStrapToolStripMenuItem.Text = "Change Money strap"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuestionsEditorToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'QuestionsEditorToolStripMenuItem
        '
        Me.QuestionsEditorToolStripMenuItem.Name = "QuestionsEditorToolStripMenuItem"
        Me.QuestionsEditorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuestionsEditorToolStripMenuItem.Text = "Questions Editor"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostScreenToolStripMenuItem, Me.GuestScreenToolStripMenuItem, Me.ToolStripMenuItem2, Me.TVScreenToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HostScreenToolStripMenuItem
        '
        Me.HostScreenToolStripMenuItem.Name = "HostScreenToolStripMenuItem"
        Me.HostScreenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HostScreenToolStripMenuItem.Text = "Host Screen"
        '
        'GuestScreenToolStripMenuItem
        '
        Me.GuestScreenToolStripMenuItem.Name = "GuestScreenToolStripMenuItem"
        Me.GuestScreenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GuestScreenToolStripMenuItem.Text = "Guest Screen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'TVScreenToolStripMenuItem
        '
        Me.TVScreenToolStripMenuItem.Name = "TVScreenToolStripMenuItem"
        Me.TVScreenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TVScreenToolStripMenuItem.Text = "TV Screen"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.OptionsToolStripMenuItem.Text = "Info"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'grpLifelines
        '
        Me.grpLifelines.Controls.Add(Me.btn5050)
        Me.grpLifelines.Controls.Add(Me.btnPlusOne)
        Me.grpLifelines.Controls.Add(Me.chkVote)
        Me.grpLifelines.Controls.Add(Me.btnVote)
        Me.grpLifelines.Controls.Add(Me.btnSwitch)
        Me.grpLifelines.Controls.Add(Me.chk5050)
        Me.grpLifelines.Controls.Add(Me.chkPlusOne)
        Me.grpLifelines.Controls.Add(Me.chkSwitch)
        Me.grpLifelines.Location = New System.Drawing.Point(11, 158)
        Me.grpLifelines.Name = "grpLifelines"
        Me.grpLifelines.Size = New System.Drawing.Size(293, 81)
        Me.grpLifelines.TabIndex = 75
        Me.grpLifelines.TabStop = False
        Me.grpLifelines.Text = "Lifelines"
        '
        'btn5050
        '
        Me.btn5050.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn5050.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.lifeline_1
        Me.btn5050.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5050.Location = New System.Drawing.Point(150, 19)
        Me.btn5050.Name = "btn5050"
        Me.btn5050.Size = New System.Drawing.Size(65, 42)
        Me.btn5050.TabIndex = 42
        Me.btn5050.Text = "50 / 50"
        Me.btn5050.UseVisualStyleBackColor = False
        '
        'btnPlusOne
        '
        Me.btnPlusOne.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPlusOne.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.lifeline_3
        Me.btnPlusOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlusOne.Location = New System.Drawing.Point(80, 19)
        Me.btnPlusOne.Name = "btnPlusOne"
        Me.btnPlusOne.Size = New System.Drawing.Size(65, 42)
        Me.btnPlusOne.TabIndex = 44
        Me.btnPlusOne.Text = "+1"
        Me.btnPlusOne.UseVisualStyleBackColor = False
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnVote.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.lifeline_4
        Me.btnVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVote.Location = New System.Drawing.Point(10, 19)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(65, 42)
        Me.btnVote.TabIndex = 72
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'btnSwitch
        '
        Me.btnSwitch.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSwitch.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.lifeline_2
        Me.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSwitch.Enabled = False
        Me.btnSwitch.Location = New System.Drawing.Point(219, 19)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(65, 42)
        Me.btnSwitch.TabIndex = 43
        Me.btnSwitch.Text = "Switch"
        Me.btnSwitch.UseVisualStyleBackColor = False
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnLightsDown)
        Me.grpMain.Controls.Add(Me.btnWalk)
        Me.grpMain.Controls.Add(Me.btnQuit)
        Me.grpMain.Controls.Add(Me.btnReveal)
        Me.grpMain.Controls.Add(Me.btnNewQuestion)
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.chkCorrectAnswer)
        Me.grpMain.Location = New System.Drawing.Point(299, 106)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(182, 133)
        Me.grpMain.TabIndex = 76
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Main"
        '
        'grpHost
        '
        Me.grpHost.Controls.Add(Me.chkBreak)
        Me.grpHost.Controls.Add(Me.chkOutOfTime)
        Me.grpHost.Location = New System.Drawing.Point(11, 122)
        Me.grpHost.Name = "grpHost"
        Me.grpHost.Size = New System.Drawing.Size(282, 36)
        Me.grpHost.TabIndex = 77
        Me.grpHost.TabStop = False
        Me.grpHost.Text = "Host"
        '
        'grpTV
        '
        Me.grpTV.Controls.Add(Me.chkShowQuestion)
        Me.grpTV.Controls.Add(Me.Button1)
        Me.grpTV.Location = New System.Drawing.Point(11, 87)
        Me.grpTV.Name = "grpTV"
        Me.grpTV.Size = New System.Drawing.Size(234, 35)
        Me.grpTV.TabIndex = 78
        Me.grpTV.TabStop = False
        Me.grpTV.Text = "TV"
        '
        'grpATAInfo
        '
        Me.grpATAInfo.Controls.Add(Me.lblATA_D)
        Me.grpATAInfo.Controls.Add(Me.lblATA_C)
        Me.grpATAInfo.Controls.Add(Me.lblATA_B)
        Me.grpATAInfo.Controls.Add(Me.lblATA_A)
        Me.grpATAInfo.Location = New System.Drawing.Point(489, 114)
        Me.grpATAInfo.Name = "grpATAInfo"
        Me.grpATAInfo.Size = New System.Drawing.Size(57, 91)
        Me.grpATAInfo.TabIndex = 79
        Me.grpATAInfo.TabStop = False
        Me.grpATAInfo.Text = "ATA"
        '
        'lblATA_D
        '
        Me.lblATA_D.AutoSize = True
        Me.lblATA_D.Location = New System.Drawing.Point(10, 65)
        Me.lblATA_D.Name = "lblATA_D"
        Me.lblATA_D.Size = New System.Drawing.Size(27, 13)
        Me.lblATA_D.TabIndex = 3
        Me.lblATA_D.Text = "D: 0"
        '
        'lblATA_C
        '
        Me.lblATA_C.AutoSize = True
        Me.lblATA_C.Location = New System.Drawing.Point(11, 51)
        Me.lblATA_C.Name = "lblATA_C"
        Me.lblATA_C.Size = New System.Drawing.Size(26, 13)
        Me.lblATA_C.TabIndex = 2
        Me.lblATA_C.Text = "C: 0"
        '
        'lblATA_B
        '
        Me.lblATA_B.AutoSize = True
        Me.lblATA_B.Location = New System.Drawing.Point(11, 36)
        Me.lblATA_B.Name = "lblATA_B"
        Me.lblATA_B.Size = New System.Drawing.Size(26, 13)
        Me.lblATA_B.TabIndex = 1
        Me.lblATA_B.Text = "B: 0"
        '
        'lblATA_A
        '
        Me.lblATA_A.AutoSize = True
        Me.lblATA_A.Location = New System.Drawing.Point(11, 21)
        Me.lblATA_A.Name = "lblATA_A"
        Me.lblATA_A.Size = New System.Drawing.Size(26, 13)
        Me.lblATA_A.TabIndex = 0
        Me.lblATA_A.Text = "A: 0"
        '
        'tmrLifelineBling
        '
        Me.tmrLifelineBling.Interval = 300
        '
        'btnFFF
        '
        Me.btnFFF.BackColor = System.Drawing.Color.LightCoral
        Me.btnFFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFFF.Location = New System.Drawing.Point(93, 59)
        Me.btnFFF.Name = "btnFFF"
        Me.btnFFF.Size = New System.Drawing.Size(80, 23)
        Me.btnFFF.TabIndex = 80
        Me.btnFFF.Text = "FFF Server"
        Me.btnFFF.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUndo.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._36973
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUndo.Location = New System.Drawing.Point(559, 208)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(40, 26)
        Me.btnUndo.TabIndex = 81
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(633, 448)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnFFF)
        Me.Controls.Add(Me.grpATAInfo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grpTV)
        Me.Controls.Add(Me.grpHost)
        Me.Controls.Add(Me.grpLifelines)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.txtExplain)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.chkUsed)
        Me.Controls.Add(Me.btnStopPC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQLeft)
        Me.Controls.Add(Me.txtDrop)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.txtWrong)
        Me.Controls.Add(Me.txtCorrect)
        Me.Controls.Add(Me.btnClosing)
        Me.Controls.Add(Me.btnCommercial)
        Me.Controls.Add(Me.nmrLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSndOpening)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.grpRules)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ControlPanel"
        Me.Text = "The Millionaire Game"
        CType(Me.nmrLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpRules.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpLifelines.ResumeLayout(False)
        Me.grpLifelines.PerformLayout()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.grpHost.ResumeLayout(False)
        Me.grpHost.PerformLayout()
        Me.grpTV.ResumeLayout(False)
        Me.grpTV.PerformLayout()
        Me.grpATAInfo.ResumeLayout(False)
        Me.grpATAInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnSndOpening As Button
    Friend WithEvents btnLightsDown As Button
    Friend WithEvents btnNewQuestion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nmrLevel As NumericUpDown
    Friend WithEvents btnReveal As Button
    Friend WithEvents btnWalk As Button
    Friend WithEvents btnCommercial As Button
    Friend WithEvents btnClosing As Button
    Friend WithEvents txtCorrect As TextBox
    Friend WithEvents txtWrong As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents txtDrop As TextBox
    Friend WithEvents txtQLeft As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnStopPC As Button
    Friend WithEvents chk5050 As CheckBox
    Friend WithEvents chkPlusOne As CheckBox
    Friend WithEvents chkSwitch As CheckBox
    Friend WithEvents btn5050 As Button
    Friend WithEvents btnSwitch As Button
    Friend WithEvents btnPlusOne As Button
    Friend WithEvents chkBreak As CheckBox
    Friend WithEvents chkOutOfTime As CheckBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkUsed As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkCorrectAnswer As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrTime As Timer
    Friend WithEvents tmrResume As Timer
    Friend WithEvents tmrRules As Timer
    Friend WithEvents grpRules As GroupBox
    Friend WithEvents btnRules As Button
    Friend WithEvents btnTreePr As Button
    Friend WithEvents btnLL3 As Button
    Friend WithEvents btnLL2 As Button
    Friend WithEvents btnLL1 As Button
    Friend WithEvents btnTreeReset As Button
    Friend WithEvents btnHideTree As Button
    Friend WithEvents btnShowTree As Button
    Friend WithEvents chkShowQuestion As CheckBox
    Friend WithEvents clrBGColor As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents txtExplain As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnVote As Button
    Friend WithEvents chkVote As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HostScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuestScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TVScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpLifelines As GroupBox
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents grpHost As GroupBox
    Friend WithEvents grpTV As GroupBox
    Friend WithEvents btnLL4 As Button
    Friend WithEvents btnUnlockSwitch As Button
    Friend WithEvents grpATAInfo As GroupBox
    Friend WithEvents lblATA_D As Label
    Friend WithEvents lblATA_C As Label
    Friend WithEvents lblATA_B As Label
    Friend WithEvents lblATA_A As Label
    Friend WithEvents tmrLifelineBling As Timer
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnFFF As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeMoneyStrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuestionsEditorToolStripMenuItem As ToolStripMenuItem
End Class
