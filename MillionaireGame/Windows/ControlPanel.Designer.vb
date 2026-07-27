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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.chkLifeline3Unused = New System.Windows.Forms.CheckBox()
        Me.chkLifeline2Unused = New System.Windows.Forms.CheckBox()
        Me.chkLifeline4Unused = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkUsed = New System.Windows.Forms.CheckBox()
        Me.btnToHotSeat = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.chkCorrectAnswer = New System.Windows.Forms.CheckBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRules = New System.Windows.Forms.Timer(Me.components)
        Me.grpRules = New System.Windows.Forms.GroupBox()
        Me.btnHideTree = New System.Windows.Forms.Button()
        Me.btnShowTree = New System.Windows.Forms.Button()
        Me.btnTreeReset = New System.Windows.Forms.Button()
        Me.btnTreePr = New System.Windows.Forms.Button()
        Me.btnActivateRiskMode = New System.Windows.Forms.Button()
        Me.btnSet2ndSafeNet = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnLL4 = New System.Windows.Forms.Button()
        Me.btnLL3 = New System.Windows.Forms.Button()
        Me.btnLL2 = New System.Windows.Forms.Button()
        Me.btnLL1 = New System.Windows.Forms.Button()
        Me.chkShowQuestion = New System.Windows.Forms.CheckBox()
        Me.clrBGColor = New System.Windows.Forms.ColorDialog()
        Me.txtExplain = New System.Windows.Forms.TextBox()
        Me.chkLifeline1Unused = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastestFingerFirstNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastestFingerFirstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AskTheAudienceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionsEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProfileEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TVScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackgroundColorTVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeQuestionFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X720720pToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X10801080pToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpLifelines = New System.Windows.Forms.GroupBox()
        Me.grpATANETinfo = New System.Windows.Forms.GroupBox()
        Me.lblATANET_D = New System.Windows.Forms.Label()
        Me.lblATANET_C = New System.Windows.Forms.Label()
        Me.lblATANET_B = New System.Windows.Forms.Label()
        Me.lblATANET_A = New System.Windows.Forms.Label()
        Me.btnLifeline3 = New System.Windows.Forms.Button()
        Me.btnLifeline2 = New System.Windows.Forms.Button()
        Me.btnLifeline1 = New System.Windows.Forms.Button()
        Me.grpATAInfo = New System.Windows.Forms.GroupBox()
        Me.lblATA_D = New System.Windows.Forms.Label()
        Me.lblATA_C = New System.Windows.Forms.Label()
        Me.lblATA_B = New System.Windows.Forms.Label()
        Me.lblATA_A = New System.Windows.Forms.Label()
        Me.btnLifeline4 = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.grpTV = New System.Windows.Forms.GroupBox()
        Me.chkShowPlayerList = New System.Windows.Forms.CheckBox()
        Me.chkShowTotalScore = New System.Windows.Forms.CheckBox()
        Me.tmrLifelineBling = New System.Windows.Forms.Timer(Me.components)
        Me.txtHostMessages = New System.Windows.Forms.RichTextBox()
        Me.btnSendToHost = New System.Windows.Forms.Button()
        Me.grpHostMessages = New System.Windows.Forms.GroupBox()
        Me.drpNextHostMessage = New System.Windows.Forms.ComboBox()
        Me.btnClearHostMessages = New System.Windows.Forms.Button()
        Me.btnResetGame = New System.Windows.Forms.Button()
        Me.btnStopAudio = New System.Windows.Forms.Button()
        Me.tmrLifelineUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnGenerateNewStack = New System.Windows.Forms.Button()
        Me.tmrUpdateATAInfo = New System.Windows.Forms.Timer(Me.components)
        Me.btnDrawAudienceChart = New System.Windows.Forms.Button()
        Me.btnShowHideAudienceChart = New System.Windows.Forms.Button()
        Me.tmrLightsDownTrigger = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.listQuestionStack = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnToggleOverlay = New System.Windows.Forms.Button()
        CType(Me.nmrLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRules.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grpLifelines.SuspendLayout()
        Me.grpATANETinfo.SuspendLayout()
        Me.grpATAInfo.SuspendLayout()
        Me.grpTV.SuspendLayout()
        Me.grpHostMessages.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Black
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(39, 636)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(739, 63)
        Me.txtQuestion.TabIndex = 36
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.Black
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.ForeColor = System.Drawing.Color.White
        Me.txtA.Location = New System.Drawing.Point(69, 705)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(334, 36)
        Me.txtA.TabIndex = 38
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.Black
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtC.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.ForeColor = System.Drawing.Color.White
        Me.txtC.Location = New System.Drawing.Point(69, 747)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(334, 36)
        Me.txtC.TabIndex = 42
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.Black
        Me.txtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtD.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.ForeColor = System.Drawing.Color.White
        Me.txtD.Location = New System.Drawing.Point(446, 747)
        Me.txtD.Name = "txtD"
        Me.txtD.ReadOnly = True
        Me.txtD.Size = New System.Drawing.Size(332, 36)
        Me.txtD.TabIndex = 44
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.Black
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.ForeColor = System.Drawing.Color.White
        Me.txtB.Location = New System.Drawing.Point(446, 705)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(332, 36)
        Me.txtB.TabIndex = 40
        '
        'btnSndOpening
        '
        Me.btnSndOpening.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSndOpening.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSndOpening.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSndOpening.ForeColor = System.Drawing.Color.White
        Me.btnSndOpening.Location = New System.Drawing.Point(12, 34)
        Me.btnSndOpening.Name = "btnSndOpening"
        Me.btnSndOpening.Size = New System.Drawing.Size(86, 31)
        Me.btnSndOpening.TabIndex = 1
        Me.btnSndOpening.Text = "Opening"
        Me.btnSndOpening.UseVisualStyleBackColor = False
        '
        'btnLightsDown
        '
        Me.btnLightsDown.BackColor = System.Drawing.Color.Black
        Me.btnLightsDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLightsDown.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLightsDown.ForeColor = System.Drawing.Color.White
        Me.btnLightsDown.Location = New System.Drawing.Point(12, 524)
        Me.btnLightsDown.Name = "btnLightsDown"
        Me.btnLightsDown.Size = New System.Drawing.Size(119, 71)
        Me.btnLightsDown.TabIndex = 28
        Me.btnLightsDown.Text = "Lights Down"
        Me.btnLightsDown.UseVisualStyleBackColor = False
        '
        'btnNewQuestion
        '
        Me.btnNewQuestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewQuestion.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewQuestion.ForeColor = System.Drawing.Color.White
        Me.btnNewQuestion.Location = New System.Drawing.Point(138, 524)
        Me.btnNewQuestion.Name = "btnNewQuestion"
        Me.btnNewQuestion.Size = New System.Drawing.Size(122, 71)
        Me.btnNewQuestion.TabIndex = 30
        Me.btnNewQuestion.Text = "Next Question"
        Me.btnNewQuestion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(858, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Current Level"
        '
        'nmrLevel
        '
        Me.nmrLevel.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nmrLevel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrLevel.ForeColor = System.Drawing.Color.White
        Me.nmrLevel.Location = New System.Drawing.Point(970, 34)
        Me.nmrLevel.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nmrLevel.Name = "nmrLevel"
        Me.nmrLevel.Size = New System.Drawing.Size(54, 30)
        Me.nmrLevel.TabIndex = 32
        '
        'btnReveal
        '
        Me.btnReveal.BackColor = System.Drawing.Color.Green
        Me.btnReveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReveal.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReveal.ForeColor = System.Drawing.Color.White
        Me.btnReveal.Location = New System.Drawing.Point(629, 524)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(111, 71)
        Me.btnReveal.TabIndex = 29
        Me.btnReveal.Text = "Reveal Answer"
        Me.btnReveal.UseVisualStyleBackColor = False
        '
        'btnWalk
        '
        Me.btnWalk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWalk.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWalk.ForeColor = System.Drawing.Color.White
        Me.btnWalk.Location = New System.Drawing.Point(784, 601)
        Me.btnWalk.Name = "btnWalk"
        Me.btnWalk.Size = New System.Drawing.Size(110, 29)
        Me.btnWalk.TabIndex = 33
        Me.btnWalk.Text = "Walk Away"
        Me.btnWalk.UseVisualStyleBackColor = False
        '
        'btnCommercial
        '
        Me.btnCommercial.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCommercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommercial.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommercial.ForeColor = System.Drawing.Color.White
        Me.btnCommercial.Location = New System.Drawing.Point(205, 34)
        Me.btnCommercial.Name = "btnCommercial"
        Me.btnCommercial.Size = New System.Drawing.Size(83, 31)
        Me.btnCommercial.TabIndex = 2
        Me.btnCommercial.Text = "BREAK"
        Me.btnCommercial.UseVisualStyleBackColor = False
        '
        'btnClosing
        '
        Me.btnClosing.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosing.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosing.ForeColor = System.Drawing.Color.White
        Me.btnClosing.Location = New System.Drawing.Point(107, 34)
        Me.btnClosing.Name = "btnClosing"
        Me.btnClosing.Size = New System.Drawing.Size(86, 31)
        Me.btnClosing.TabIndex = 3
        Me.btnClosing.Text = "Closing"
        Me.btnClosing.UseVisualStyleBackColor = False
        '
        'txtCorrect
        '
        Me.txtCorrect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorrect.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrect.Location = New System.Drawing.Point(39, 601)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.ReadOnly = True
        Me.txtCorrect.Size = New System.Drawing.Size(121, 29)
        Me.txtCorrect.TabIndex = 0
        Me.txtCorrect.Text = "100"
        '
        'txtWrong
        '
        Me.txtWrong.BackColor = System.Drawing.Color.Red
        Me.txtWrong.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWrong.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWrong.ForeColor = System.Drawing.Color.White
        Me.txtWrong.Location = New System.Drawing.Point(194, 601)
        Me.txtWrong.Name = "txtWrong"
        Me.txtWrong.ReadOnly = True
        Me.txtWrong.Size = New System.Drawing.Size(121, 29)
        Me.txtWrong.TabIndex = 0
        Me.txtWrong.Text = "0"
        '
        'txtCurrent
        '
        Me.txtCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrent.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrent.Location = New System.Drawing.Point(348, 601)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.ReadOnly = True
        Me.txtCurrent.Size = New System.Drawing.Size(121, 29)
        Me.txtCurrent.TabIndex = 0
        Me.txtCurrent.Text = "0"
        '
        'txtDrop
        '
        Me.txtDrop.BackColor = System.Drawing.Color.Aqua
        Me.txtDrop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDrop.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrop.Location = New System.Drawing.Point(502, 601)
        Me.txtDrop.Name = "txtDrop"
        Me.txtDrop.ReadOnly = True
        Me.txtDrop.Size = New System.Drawing.Size(121, 29)
        Me.txtDrop.TabIndex = 0
        Me.txtDrop.Text = "0"
        '
        'txtQLeft
        '
        Me.txtQLeft.BackColor = System.Drawing.Color.Blue
        Me.txtQLeft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQLeft.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQLeft.ForeColor = System.Drawing.Color.White
        Me.txtQLeft.Location = New System.Drawing.Point(657, 601)
        Me.txtQLeft.Name = "txtQLeft"
        Me.txtQLeft.ReadOnly = True
        Me.txtQLeft.Size = New System.Drawing.Size(121, 29)
        Me.txtQLeft.TabIndex = 0
        Me.txtQLeft.Text = "15"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(890, 675)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(36, 24)
        Me.lblAnswer.TabIndex = 33
        Me.lblAnswer.Text = "n/a"
        Me.lblAnswer.Visible = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.Gold
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Font = New System.Drawing.Font("Bahnschrift", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.ForeColor = System.Drawing.Color.Black
        Me.btnA.Location = New System.Drawing.Point(266, 524)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(85, 71)
        Me.btnA.TabIndex = 37
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.Gold
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Font = New System.Drawing.Font("Bahnschrift", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.ForeColor = System.Drawing.Color.Black
        Me.btnB.Location = New System.Drawing.Point(357, 524)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(85, 71)
        Me.btnB.TabIndex = 39
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Gold
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Bahnschrift", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.Black
        Me.btnC.Location = New System.Drawing.Point(448, 524)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(85, 71)
        Me.btnC.TabIndex = 41
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.Gold
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Font = New System.Drawing.Font("Bahnschrift", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.ForeColor = System.Drawing.Color.Black
        Me.btnD.Location = New System.Drawing.Point(538, 524)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(85, 71)
        Me.btnD.TabIndex = 43
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'chkLifeline3Unused
        '
        Me.chkLifeline3Unused.AutoSize = True
        Me.chkLifeline3Unused.Checked = True
        Me.chkLifeline3Unused.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLifeline3Unused.Location = New System.Drawing.Point(6, 195)
        Me.chkLifeline3Unused.Name = "chkLifeline3Unused"
        Me.chkLifeline3Unused.Size = New System.Drawing.Size(148, 23)
        Me.chkLifeline3Unused.TabIndex = 23
        Me.chkLifeline3Unused.Text = "Unused/Enabled"
        Me.chkLifeline3Unused.UseVisualStyleBackColor = True
        '
        'chkLifeline2Unused
        '
        Me.chkLifeline2Unused.AutoSize = True
        Me.chkLifeline2Unused.Checked = True
        Me.chkLifeline2Unused.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLifeline2Unused.Location = New System.Drawing.Point(6, 131)
        Me.chkLifeline2Unused.Name = "chkLifeline2Unused"
        Me.chkLifeline2Unused.Size = New System.Drawing.Size(148, 23)
        Me.chkLifeline2Unused.TabIndex = 22
        Me.chkLifeline2Unused.Text = "Unused/Enabled"
        Me.chkLifeline2Unused.UseVisualStyleBackColor = True
        '
        'chkLifeline4Unused
        '
        Me.chkLifeline4Unused.AutoSize = True
        Me.chkLifeline4Unused.Checked = True
        Me.chkLifeline4Unused.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLifeline4Unused.Location = New System.Drawing.Point(6, 259)
        Me.chkLifeline4Unused.Name = "chkLifeline4Unused"
        Me.chkLifeline4Unused.Size = New System.Drawing.Size(148, 23)
        Me.chkLifeline4Unused.TabIndex = 24
        Me.chkLifeline4Unused.Text = "Unused/Enabled"
        Me.chkLifeline4Unused.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(816, 73)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(28, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.Visible = False
        '
        'chkUsed
        '
        Me.chkUsed.AutoSize = True
        Me.chkUsed.Enabled = False
        Me.chkUsed.Location = New System.Drawing.Point(795, 76)
        Me.chkUsed.Name = "chkUsed"
        Me.chkUsed.Size = New System.Drawing.Size(15, 14)
        Me.chkUsed.TabIndex = 0
        Me.chkUsed.UseVisualStyleBackColor = True
        Me.chkUsed.Visible = False
        '
        'btnToHotSeat
        '
        Me.btnToHotSeat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnToHotSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToHotSeat.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToHotSeat.ForeColor = System.Drawing.Color.White
        Me.btnToHotSeat.Location = New System.Drawing.Point(612, 34)
        Me.btnToHotSeat.Name = "btnToHotSeat"
        Me.btnToHotSeat.Size = New System.Drawing.Size(93, 31)
        Me.btnToHotSeat.TabIndex = 5
        Me.btnToHotSeat.Text = "To Hot Seat"
        Me.btnToHotSeat.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(489, 34)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(117, 31)
        Me.btnQuit.TabIndex = 34
        Me.btnQuit.Text = "Cont. Leave Cue"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'chkCorrectAnswer
        '
        Me.chkCorrectAnswer.AutoSize = True
        Me.chkCorrectAnswer.Location = New System.Drawing.Point(784, 682)
        Me.chkCorrectAnswer.Name = "chkCorrectAnswer"
        Me.chkCorrectAnswer.Size = New System.Drawing.Size(90, 17)
        Me.chkCorrectAnswer.TabIndex = 31
        Me.chkCorrectAnswer.Text = "Show Correct"
        Me.chkCorrectAnswer.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(108, 329)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 26)
        Me.lblTime.TabIndex = 26
        Me.lblTime.Text = "30"
        Me.lblTime.Visible = False
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'tmrRules
        '
        Me.tmrRules.Interval = 200
        '
        'grpRules
        '
        Me.grpRules.BackColor = System.Drawing.Color.Transparent
        Me.grpRules.Controls.Add(Me.btnHideTree)
        Me.grpRules.Controls.Add(Me.btnShowTree)
        Me.grpRules.Controls.Add(Me.btnTreeReset)
        Me.grpRules.Controls.Add(Me.btnTreePr)
        Me.grpRules.Controls.Add(Me.btnActivateRiskMode)
        Me.grpRules.Controls.Add(Me.btnSet2ndSafeNet)
        Me.grpRules.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRules.ForeColor = System.Drawing.Color.White
        Me.grpRules.Location = New System.Drawing.Point(1026, 66)
        Me.grpRules.Name = "grpRules"
        Me.grpRules.Size = New System.Drawing.Size(351, 397)
        Me.grpRules.TabIndex = 8
        Me.grpRules.TabStop = False
        Me.grpRules.Text = "Money Tree"
        '
        'btnHideTree
        '
        Me.btnHideTree.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHideTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideTree.ForeColor = System.Drawing.Color.White
        Me.btnHideTree.Location = New System.Drawing.Point(83, 26)
        Me.btnHideTree.Name = "btnHideTree"
        Me.btnHideTree.Size = New System.Drawing.Size(69, 31)
        Me.btnHideTree.TabIndex = 9
        Me.btnHideTree.Text = "Hide"
        Me.btnHideTree.UseVisualStyleBackColor = False
        '
        'btnShowTree
        '
        Me.btnShowTree.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnShowTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowTree.ForeColor = System.Drawing.Color.White
        Me.btnShowTree.Location = New System.Drawing.Point(8, 26)
        Me.btnShowTree.Name = "btnShowTree"
        Me.btnShowTree.Size = New System.Drawing.Size(69, 31)
        Me.btnShowTree.TabIndex = 8
        Me.btnShowTree.Text = "Show"
        Me.btnShowTree.UseVisualStyleBackColor = False
        '
        'btnTreeReset
        '
        Me.btnTreeReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTreeReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreeReset.ForeColor = System.Drawing.Color.White
        Me.btnTreeReset.Location = New System.Drawing.Point(130, 63)
        Me.btnTreeReset.Name = "btnTreeReset"
        Me.btnTreeReset.Size = New System.Drawing.Size(116, 32)
        Me.btnTreeReset.TabIndex = 16
        Me.btnTreeReset.Text = "2. Reset Tree"
        Me.btnTreeReset.UseVisualStyleBackColor = False
        '
        'btnTreePr
        '
        Me.btnTreePr.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTreePr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreePr.ForeColor = System.Drawing.Color.White
        Me.btnTreePr.Location = New System.Drawing.Point(8, 63)
        Me.btnTreePr.Name = "btnTreePr"
        Me.btnTreePr.Size = New System.Drawing.Size(116, 32)
        Me.btnTreePr.TabIndex = 15
        Me.btnTreePr.Text = "1. Climb"
        Me.btnTreePr.UseVisualStyleBackColor = False
        '
        'btnActivateRiskMode
        '
        Me.btnActivateRiskMode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnActivateRiskMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivateRiskMode.ForeColor = System.Drawing.Color.White
        Me.btnActivateRiskMode.Location = New System.Drawing.Point(158, 26)
        Me.btnActivateRiskMode.Name = "btnActivateRiskMode"
        Me.btnActivateRiskMode.Size = New System.Drawing.Size(147, 31)
        Me.btnActivateRiskMode.TabIndex = 6
        Me.btnActivateRiskMode.Text = "Toggle Risk Mode"
        Me.btnActivateRiskMode.UseVisualStyleBackColor = False
        '
        'btnSet2ndSafeNet
        '
        Me.btnSet2ndSafeNet.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSet2ndSafeNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet2ndSafeNet.ForeColor = System.Drawing.Color.White
        Me.btnSet2ndSafeNet.Location = New System.Drawing.Point(158, 26)
        Me.btnSet2ndSafeNet.Name = "btnSet2ndSafeNet"
        Me.btnSet2ndSafeNet.Size = New System.Drawing.Size(147, 31)
        Me.btnSet2ndSafeNet.TabIndex = 7
        Me.btnSet2ndSafeNet.Text = "Set Safety Net"
        Me.btnSet2ndSafeNet.UseVisualStyleBackColor = False
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules.ForeColor = System.Drawing.Color.White
        Me.btnRules.Location = New System.Drawing.Point(711, 34)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(133, 31)
        Me.btnRules.TabIndex = 14
        Me.btnRules.Text = "Snd. Explain Rules"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'btnLL4
        '
        Me.btnLL4.BackColor = System.Drawing.Color.DimGray
        Me.btnLL4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLL4.ForeColor = System.Drawing.Color.White
        Me.btnLL4.Location = New System.Drawing.Point(89, 230)
        Me.btnLL4.Name = "btnLL4"
        Me.btnLL4.Size = New System.Drawing.Size(65, 24)
        Me.btnLL4.TabIndex = 13
        Me.btnLL4.Text = "PING"
        Me.btnLL4.UseVisualStyleBackColor = False
        '
        'btnLL3
        '
        Me.btnLL3.BackColor = System.Drawing.Color.DimGray
        Me.btnLL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLL3.ForeColor = System.Drawing.Color.White
        Me.btnLL3.Location = New System.Drawing.Point(89, 165)
        Me.btnLL3.Name = "btnLL3"
        Me.btnLL3.Size = New System.Drawing.Size(65, 24)
        Me.btnLL3.TabIndex = 12
        Me.btnLL3.Text = "PING"
        Me.btnLL3.UseVisualStyleBackColor = False
        '
        'btnLL2
        '
        Me.btnLL2.BackColor = System.Drawing.Color.DimGray
        Me.btnLL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLL2.ForeColor = System.Drawing.Color.White
        Me.btnLL2.Location = New System.Drawing.Point(89, 101)
        Me.btnLL2.Name = "btnLL2"
        Me.btnLL2.Size = New System.Drawing.Size(65, 24)
        Me.btnLL2.TabIndex = 11
        Me.btnLL2.Text = "PING"
        Me.btnLL2.UseVisualStyleBackColor = False
        '
        'btnLL1
        '
        Me.btnLL1.BackColor = System.Drawing.Color.DimGray
        Me.btnLL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLL1.ForeColor = System.Drawing.Color.White
        Me.btnLL1.Location = New System.Drawing.Point(89, 37)
        Me.btnLL1.Name = "btnLL1"
        Me.btnLL1.Size = New System.Drawing.Size(65, 24)
        Me.btnLL1.TabIndex = 10
        Me.btnLL1.Text = "PING"
        Me.btnLL1.UseVisualStyleBackColor = False
        '
        'chkShowQuestion
        '
        Me.chkShowQuestion.AutoSize = True
        Me.chkShowQuestion.Location = New System.Drawing.Point(16, 23)
        Me.chkShowQuestion.Name = "chkShowQuestion"
        Me.chkShowQuestion.Size = New System.Drawing.Size(92, 23)
        Me.chkShowQuestion.TabIndex = 47
        Me.chkShowQuestion.Text = "Question"
        Me.chkShowQuestion.UseVisualStyleBackColor = True
        '
        'txtExplain
        '
        Me.txtExplain.BackColor = System.Drawing.Color.White
        Me.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExplain.ForeColor = System.Drawing.Color.White
        Me.txtExplain.Location = New System.Drawing.Point(784, 710)
        Me.txtExplain.Multiline = True
        Me.txtExplain.Name = "txtExplain"
        Me.txtExplain.ReadOnly = True
        Me.txtExplain.Size = New System.Drawing.Size(364, 73)
        Me.txtExplain.TabIndex = 0
        '
        'chkLifeline1Unused
        '
        Me.chkLifeline1Unused.AutoSize = True
        Me.chkLifeline1Unused.Checked = True
        Me.chkLifeline1Unused.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLifeline1Unused.Location = New System.Drawing.Point(6, 67)
        Me.chkLifeline1Unused.Name = "chkLifeline1Unused"
        Me.chkLifeline1Unused.Size = New System.Drawing.Size(148, 23)
        Me.chkLifeline1Unused.TabIndex = 21
        Me.chkLifeline1Unused.Text = "Unused/Enabled"
        Me.chkLifeline1Unused.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseToolStripMenuItem, Me.GameToolStripMenuItem, Me.ViewToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1404, 31)
        Me.MenuStrip1.TabIndex = 73
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FastestFingerFirstNewToolStripMenuItem, Me.FastestFingerFirstToolStripMenuItem, Me.AskTheAudienceToolStripMenuItem, Me.ToolStripMenuItem4, Me.ShowOptionsToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatabaseToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(68, 27)
        Me.DatabaseToolStripMenuItem.Text = " Main"
        '
        'FastestFingerFirstNewToolStripMenuItem
        '
        Me.FastestFingerFirstNewToolStripMenuItem.Image = CType(resources.GetObject("FastestFingerFirstNewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FastestFingerFirstNewToolStripMenuItem.Name = "FastestFingerFirstNewToolStripMenuItem"
        Me.FastestFingerFirstNewToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.FastestFingerFirstNewToolStripMenuItem.Text = "Fastest Finger First (New)"
        '
        'FastestFingerFirstToolStripMenuItem
        '
        Me.FastestFingerFirstToolStripMenuItem.Image = CType(resources.GetObject("FastestFingerFirstToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FastestFingerFirstToolStripMenuItem.Name = "FastestFingerFirstToolStripMenuItem"
        Me.FastestFingerFirstToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.FastestFingerFirstToolStripMenuItem.Text = "Fastest Finger First"
        '
        'AskTheAudienceToolStripMenuItem
        '
        Me.AskTheAudienceToolStripMenuItem.Name = "AskTheAudienceToolStripMenuItem"
        Me.AskTheAudienceToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.AskTheAudienceToolStripMenuItem.Text = "Ask The Audience"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(300, 6)
        '
        'ShowOptionsToolStripMenuItem
        '
        Me.ShowOptionsToolStripMenuItem.Image = CType(resources.GetObject("ShowOptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowOptionsToolStripMenuItem.Name = "ShowOptionsToolStripMenuItem"
        Me.ShowOptionsToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.ShowOptionsToolStripMenuItem.Text = "Options"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuestionsEditorToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProfileEditorToolStripMenuItem})
        Me.GameToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(70, 27)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'QuestionsEditorToolStripMenuItem
        '
        Me.QuestionsEditorToolStripMenuItem.Image = CType(resources.GetObject("QuestionsEditorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuestionsEditorToolStripMenuItem.Name = "QuestionsEditorToolStripMenuItem"
        Me.QuestionsEditorToolStripMenuItem.Size = New System.Drawing.Size(220, 28)
        Me.QuestionsEditorToolStripMenuItem.Text = "Questions Editor"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(217, 6)
        Me.ToolStripMenuItem1.Visible = False
        '
        'ProfileEditorToolStripMenuItem
        '
        Me.ProfileEditorToolStripMenuItem.Name = "ProfileEditorToolStripMenuItem"
        Me.ProfileEditorToolStripMenuItem.Size = New System.Drawing.Size(220, 28)
        Me.ProfileEditorToolStripMenuItem.Text = "Profile Editor"
        Me.ProfileEditorToolStripMenuItem.Visible = False
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostScreenToolStripMenuItem, Me.GuestScreenToolStripMenuItem, Me.ToolStripMenuItem2, Me.TVScreenToolStripMenuItem, Me.ChangeBackgroundColorTVToolStripMenuItem, Me.ChangeQuestionFontToolStripMenuItem})
        Me.ViewToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(63, 27)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HostScreenToolStripMenuItem
        '
        Me.HostScreenToolStripMenuItem.Image = CType(resources.GetObject("HostScreenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HostScreenToolStripMenuItem.Name = "HostScreenToolStripMenuItem"
        Me.HostScreenToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.HostScreenToolStripMenuItem.Text = "Host Screen"
        '
        'GuestScreenToolStripMenuItem
        '
        Me.GuestScreenToolStripMenuItem.Image = CType(resources.GetObject("GuestScreenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuestScreenToolStripMenuItem.Name = "GuestScreenToolStripMenuItem"
        Me.GuestScreenToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.GuestScreenToolStripMenuItem.Text = "Guest Screen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(331, 6)
        '
        'TVScreenToolStripMenuItem
        '
        Me.TVScreenToolStripMenuItem.Image = CType(resources.GetObject("TVScreenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TVScreenToolStripMenuItem.Name = "TVScreenToolStripMenuItem"
        Me.TVScreenToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.TVScreenToolStripMenuItem.Text = "TV Screen"
        '
        'ChangeBackgroundColorTVToolStripMenuItem
        '
        Me.ChangeBackgroundColorTVToolStripMenuItem.Image = CType(resources.GetObject("ChangeBackgroundColorTVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeBackgroundColorTVToolStripMenuItem.Name = "ChangeBackgroundColorTVToolStripMenuItem"
        Me.ChangeBackgroundColorTVToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.ChangeBackgroundColorTVToolStripMenuItem.Text = "Change background color (TV)"
        '
        'ChangeQuestionFontToolStripMenuItem
        '
        Me.ChangeQuestionFontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X720720pToolStripMenuItem, Me.X10801080pToolStripMenuItem})
        Me.ChangeQuestionFontToolStripMenuItem.Name = "ChangeQuestionFontToolStripMenuItem"
        Me.ChangeQuestionFontToolStripMenuItem.Size = New System.Drawing.Size(334, 28)
        Me.ChangeQuestionFontToolStripMenuItem.Text = "Change resolutions"
        Me.ChangeQuestionFontToolStripMenuItem.Visible = False
        '
        'X720720pToolStripMenuItem
        '
        Me.X720720pToolStripMenuItem.Name = "X720720pToolStripMenuItem"
        Me.X720720pToolStripMenuItem.Size = New System.Drawing.Size(237, 28)
        Me.X720720pToolStripMenuItem.Text = "1280 x 720 (720p)"
        '
        'X10801080pToolStripMenuItem
        '
        Me.X10801080pToolStripMenuItem.Name = "X10801080pToolStripMenuItem"
        Me.X10801080pToolStripMenuItem.Size = New System.Drawing.Size(237, 28)
        Me.X10801080pToolStripMenuItem.Text = "1920 x 1080 (1080p)"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowConsoleToolStripMenuItem, Me.ToolStripMenuItem3, Me.AboutToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(54, 27)
        Me.OptionsToolStripMenuItem.Text = "Info"
        '
        'ShowConsoleToolStripMenuItem
        '
        Me.ShowConsoleToolStripMenuItem.Image = Global.MillionaireGame.My.Resources.Resources.triangle
        Me.ShowConsoleToolStripMenuItem.Name = "ShowConsoleToolStripMenuItem"
        Me.ShowConsoleToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.ShowConsoleToolStripMenuItem.Text = "Show Console"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(199, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'grpLifelines
        '
        Me.grpLifelines.BackColor = System.Drawing.Color.Transparent
        Me.grpLifelines.Controls.Add(Me.btnLL4)
        Me.grpLifelines.Controls.Add(Me.grpATANETinfo)
        Me.grpLifelines.Controls.Add(Me.btnLifeline3)
        Me.grpLifelines.Controls.Add(Me.btnLifeline2)
        Me.grpLifelines.Controls.Add(Me.btnLL3)
        Me.grpLifelines.Controls.Add(Me.btnLifeline1)
        Me.grpLifelines.Controls.Add(Me.btnLL2)
        Me.grpLifelines.Controls.Add(Me.grpATAInfo)
        Me.grpLifelines.Controls.Add(Me.btnLL1)
        Me.grpLifelines.Controls.Add(Me.btnLifeline4)
        Me.grpLifelines.Controls.Add(Me.chkLifeline3Unused)
        Me.grpLifelines.Controls.Add(Me.chkLifeline2Unused)
        Me.grpLifelines.Controls.Add(Me.chkLifeline4Unused)
        Me.grpLifelines.Controls.Add(Me.lblTime)
        Me.grpLifelines.Controls.Add(Me.chkLifeline1Unused)
        Me.grpLifelines.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLifelines.ForeColor = System.Drawing.Color.White
        Me.grpLifelines.Location = New System.Drawing.Point(855, 164)
        Me.grpLifelines.Name = "grpLifelines"
        Me.grpLifelines.Size = New System.Drawing.Size(165, 399)
        Me.grpLifelines.TabIndex = 75
        Me.grpLifelines.TabStop = False
        Me.grpLifelines.Text = "Lifelines"
        '
        'grpATANETinfo
        '
        Me.grpATANETinfo.Controls.Add(Me.lblATANET_D)
        Me.grpATANETinfo.Controls.Add(Me.lblATANET_C)
        Me.grpATANETinfo.Controls.Add(Me.lblATANET_B)
        Me.grpATANETinfo.Controls.Add(Me.lblATANET_A)
        Me.grpATANETinfo.ForeColor = System.Drawing.Color.White
        Me.grpATANETinfo.Location = New System.Drawing.Point(6, 342)
        Me.grpATANETinfo.Name = "grpATANETinfo"
        Me.grpATANETinfo.Size = New System.Drawing.Size(104, 48)
        Me.grpATANETinfo.TabIndex = 26
        Me.grpATANETinfo.TabStop = False
        Me.grpATANETinfo.Text = "ATA NET"
        '
        'lblATANET_D
        '
        Me.lblATANET_D.AutoSize = True
        Me.lblATANET_D.Location = New System.Drawing.Point(52, 27)
        Me.lblATANET_D.Name = "lblATANET_D"
        Me.lblATANET_D.Size = New System.Drawing.Size(48, 19)
        Me.lblATANET_D.TabIndex = 3
        Me.lblATANET_D.Text = "D: 0%"
        '
        'lblATANET_C
        '
        Me.lblATANET_C.AutoSize = True
        Me.lblATANET_C.Location = New System.Drawing.Point(13, 27)
        Me.lblATANET_C.Name = "lblATANET_C"
        Me.lblATANET_C.Size = New System.Drawing.Size(47, 19)
        Me.lblATANET_C.TabIndex = 2
        Me.lblATANET_C.Text = "C: 0%"
        '
        'lblATANET_B
        '
        Me.lblATANET_B.AutoSize = True
        Me.lblATANET_B.Location = New System.Drawing.Point(52, 14)
        Me.lblATANET_B.Name = "lblATANET_B"
        Me.lblATANET_B.Size = New System.Drawing.Size(47, 19)
        Me.lblATANET_B.TabIndex = 1
        Me.lblATANET_B.Text = "B: 0%"
        '
        'lblATANET_A
        '
        Me.lblATANET_A.AutoSize = True
        Me.lblATANET_A.Location = New System.Drawing.Point(11, 14)
        Me.lblATANET_A.Name = "lblATANET_A"
        Me.lblATANET_A.Size = New System.Drawing.Size(47, 19)
        Me.lblATANET_A.TabIndex = 0
        Me.lblATANET_A.Text = "A: 0%"
        '
        'btnLifeline3
        '
        Me.btnLifeline3.BackColor = System.Drawing.Color.Black
        Me.btnLifeline3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLifeline3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLifeline3.Location = New System.Drawing.Point(6, 154)
        Me.btnLifeline3.Name = "btnLifeline3"
        Me.btnLifeline3.Size = New System.Drawing.Size(65, 42)
        Me.btnLifeline3.TabIndex = 19
        Me.btnLifeline3.UseVisualStyleBackColor = False
        '
        'btnLifeline2
        '
        Me.btnLifeline2.BackColor = System.Drawing.Color.Black
        Me.btnLifeline2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLifeline2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLifeline2.Location = New System.Drawing.Point(6, 90)
        Me.btnLifeline2.Name = "btnLifeline2"
        Me.btnLifeline2.Size = New System.Drawing.Size(65, 42)
        Me.btnLifeline2.TabIndex = 18
        Me.btnLifeline2.UseVisualStyleBackColor = False
        '
        'btnLifeline1
        '
        Me.btnLifeline1.BackColor = System.Drawing.Color.Black
        Me.btnLifeline1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLifeline1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLifeline1.Location = New System.Drawing.Point(6, 26)
        Me.btnLifeline1.Name = "btnLifeline1"
        Me.btnLifeline1.Size = New System.Drawing.Size(65, 42)
        Me.btnLifeline1.TabIndex = 17
        Me.btnLifeline1.UseVisualStyleBackColor = False
        '
        'grpATAInfo
        '
        Me.grpATAInfo.Controls.Add(Me.lblATA_D)
        Me.grpATAInfo.Controls.Add(Me.lblATA_C)
        Me.grpATAInfo.Controls.Add(Me.lblATA_B)
        Me.grpATAInfo.Controls.Add(Me.lblATA_A)
        Me.grpATAInfo.ForeColor = System.Drawing.Color.White
        Me.grpATAInfo.Location = New System.Drawing.Point(6, 288)
        Me.grpATAInfo.Name = "grpATAInfo"
        Me.grpATAInfo.Size = New System.Drawing.Size(104, 48)
        Me.grpATAInfo.TabIndex = 25
        Me.grpATAInfo.TabStop = False
        Me.grpATAInfo.Text = "ATA"
        '
        'lblATA_D
        '
        Me.lblATA_D.AutoSize = True
        Me.lblATA_D.Location = New System.Drawing.Point(52, 27)
        Me.lblATA_D.Name = "lblATA_D"
        Me.lblATA_D.Size = New System.Drawing.Size(37, 19)
        Me.lblATA_D.TabIndex = 3
        Me.lblATA_D.Text = "D: 0"
        '
        'lblATA_C
        '
        Me.lblATA_C.AutoSize = True
        Me.lblATA_C.Location = New System.Drawing.Point(13, 27)
        Me.lblATA_C.Name = "lblATA_C"
        Me.lblATA_C.Size = New System.Drawing.Size(36, 19)
        Me.lblATA_C.TabIndex = 2
        Me.lblATA_C.Text = "C: 0"
        '
        'lblATA_B
        '
        Me.lblATA_B.AutoSize = True
        Me.lblATA_B.Location = New System.Drawing.Point(52, 14)
        Me.lblATA_B.Name = "lblATA_B"
        Me.lblATA_B.Size = New System.Drawing.Size(36, 19)
        Me.lblATA_B.TabIndex = 1
        Me.lblATA_B.Text = "B: 0"
        '
        'lblATA_A
        '
        Me.lblATA_A.AutoSize = True
        Me.lblATA_A.Location = New System.Drawing.Point(11, 14)
        Me.lblATA_A.Name = "lblATA_A"
        Me.lblATA_A.Size = New System.Drawing.Size(36, 19)
        Me.lblATA_A.TabIndex = 0
        Me.lblATA_A.Text = "A: 0"
        '
        'btnLifeline4
        '
        Me.btnLifeline4.BackColor = System.Drawing.Color.Black
        Me.btnLifeline4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLifeline4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLifeline4.Location = New System.Drawing.Point(6, 219)
        Me.btnLifeline4.Name = "btnLifeline4"
        Me.btnLifeline4.Size = New System.Drawing.Size(65, 42)
        Me.btnLifeline4.TabIndex = 20
        Me.btnLifeline4.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUndo.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._36973
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUndo.Location = New System.Drawing.Point(784, 566)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(110, 29)
        Me.btnUndo.TabIndex = 35
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'grpTV
        '
        Me.grpTV.BackColor = System.Drawing.Color.Transparent
        Me.grpTV.Controls.Add(Me.chkShowPlayerList)
        Me.grpTV.Controls.Add(Me.chkShowTotalScore)
        Me.grpTV.Controls.Add(Me.chkShowQuestion)
        Me.grpTV.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTV.ForeColor = System.Drawing.Color.White
        Me.grpTV.Location = New System.Drawing.Point(855, 66)
        Me.grpTV.Name = "grpTV"
        Me.grpTV.Size = New System.Drawing.Size(165, 99)
        Me.grpTV.TabIndex = 78
        Me.grpTV.TabStop = False
        Me.grpTV.Text = "Show on TV Screen"
        '
        'chkShowPlayerList
        '
        Me.chkShowPlayerList.AutoSize = True
        Me.chkShowPlayerList.Location = New System.Drawing.Point(16, 44)
        Me.chkShowPlayerList.Name = "chkShowPlayerList"
        Me.chkShowPlayerList.Size = New System.Drawing.Size(114, 23)
        Me.chkShowPlayerList.TabIndex = 48
        Me.chkShowPlayerList.Text = "Contestants"
        Me.chkShowPlayerList.UseVisualStyleBackColor = True
        '
        'chkShowTotalScore
        '
        Me.chkShowTotalScore.AutoSize = True
        Me.chkShowTotalScore.Location = New System.Drawing.Point(16, 65)
        Me.chkShowTotalScore.Name = "chkShowTotalScore"
        Me.chkShowTotalScore.Size = New System.Drawing.Size(110, 23)
        Me.chkShowTotalScore.TabIndex = 49
        Me.chkShowTotalScore.Text = "Total Score"
        Me.chkShowTotalScore.UseVisualStyleBackColor = True
        '
        'tmrLifelineBling
        '
        Me.tmrLifelineBling.Interval = 300
        '
        'txtHostMessages
        '
        Me.txtHostMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtHostMessages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHostMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostMessages.Location = New System.Drawing.Point(6, 22)
        Me.txtHostMessages.Name = "txtHostMessages"
        Me.txtHostMessages.ReadOnly = True
        Me.txtHostMessages.Size = New System.Drawing.Size(339, 126)
        Me.txtHostMessages.TabIndex = 0
        Me.txtHostMessages.Text = ""
        '
        'btnSendToHost
        '
        Me.btnSendToHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendToHost.Location = New System.Drawing.Point(281, 155)
        Me.btnSendToHost.Name = "btnSendToHost"
        Me.btnSendToHost.Size = New System.Drawing.Size(64, 35)
        Me.btnSendToHost.TabIndex = 45
        Me.btnSendToHost.Text = "Send"
        Me.btnSendToHost.UseVisualStyleBackColor = True
        '
        'grpHostMessages
        '
        Me.grpHostMessages.BackColor = System.Drawing.Color.Transparent
        Me.grpHostMessages.Controls.Add(Me.drpNextHostMessage)
        Me.grpHostMessages.Controls.Add(Me.btnClearHostMessages)
        Me.grpHostMessages.Controls.Add(Me.txtHostMessages)
        Me.grpHostMessages.Controls.Add(Me.btnSendToHost)
        Me.grpHostMessages.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHostMessages.ForeColor = System.Drawing.Color.White
        Me.grpHostMessages.Location = New System.Drawing.Point(1025, 462)
        Me.grpHostMessages.Name = "grpHostMessages"
        Me.grpHostMessages.Size = New System.Drawing.Size(351, 235)
        Me.grpHostMessages.TabIndex = 85
        Me.grpHostMessages.TabStop = False
        Me.grpHostMessages.Text = "Host Chat"
        '
        'drpNextHostMessage
        '
        Me.drpNextHostMessage.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.drpNextHostMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drpNextHostMessage.FormattingEnabled = True
        Me.drpNextHostMessage.Location = New System.Drawing.Point(8, 160)
        Me.drpNextHostMessage.Name = "drpNextHostMessage"
        Me.drpNextHostMessage.Size = New System.Drawing.Size(269, 27)
        Me.drpNextHostMessage.TabIndex = 44
        '
        'btnClearHostMessages
        '
        Me.btnClearHostMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearHostMessages.Location = New System.Drawing.Point(216, 196)
        Me.btnClearHostMessages.Name = "btnClearHostMessages"
        Me.btnClearHostMessages.Size = New System.Drawing.Size(129, 32)
        Me.btnClearHostMessages.TabIndex = 46
        Me.btnClearHostMessages.Text = "Clear History"
        Me.btnClearHostMessages.UseVisualStyleBackColor = True
        '
        'btnResetGame
        '
        Me.btnResetGame.BackColor = System.Drawing.Color.OrangeRed
        Me.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetGame.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetGame.ForeColor = System.Drawing.Color.White
        Me.btnResetGame.Location = New System.Drawing.Point(1295, 34)
        Me.btnResetGame.Name = "btnResetGame"
        Me.btnResetGame.Size = New System.Drawing.Size(82, 31)
        Me.btnResetGame.TabIndex = 4
        Me.btnResetGame.Text = "RESET ALL"
        Me.btnResetGame.UseVisualStyleBackColor = False
        '
        'btnStopAudio
        '
        Me.btnStopAudio.BackColor = System.Drawing.Color.Red
        Me.btnStopAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopAudio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopAudio.ForeColor = System.Drawing.Color.White
        Me.btnStopAudio.Location = New System.Drawing.Point(1190, 34)
        Me.btnStopAudio.Name = "btnStopAudio"
        Me.btnStopAudio.Size = New System.Drawing.Size(99, 31)
        Me.btnStopAudio.TabIndex = 50
        Me.btnStopAudio.Text = "STOP AUDIO"
        Me.btnStopAudio.UseVisualStyleBackColor = False
        '
        'tmrLifelineUpdate
        '
        Me.tmrLifelineUpdate.Interval = 500
        '
        'btnGenerateNewStack
        '
        Me.btnGenerateNewStack.Location = New System.Drawing.Point(1154, 760)
        Me.btnGenerateNewStack.Name = "btnGenerateNewStack"
        Me.btnGenerateNewStack.Size = New System.Drawing.Size(163, 23)
        Me.btnGenerateNewStack.TabIndex = 87
        Me.btnGenerateNewStack.Text = "Generate new stack"
        Me.btnGenerateNewStack.UseVisualStyleBackColor = True
        '
        'tmrUpdateATAInfo
        '
        Me.tmrUpdateATAInfo.Interval = 500
        '
        'btnDrawAudienceChart
        '
        Me.btnDrawAudienceChart.Location = New System.Drawing.Point(1154, 735)
        Me.btnDrawAudienceChart.Name = "btnDrawAudienceChart"
        Me.btnDrawAudienceChart.Size = New System.Drawing.Size(163, 23)
        Me.btnDrawAudienceChart.TabIndex = 88
        Me.btnDrawAudienceChart.Text = "Draw Audience Chart"
        Me.btnDrawAudienceChart.UseVisualStyleBackColor = True
        '
        'btnShowHideAudienceChart
        '
        Me.btnShowHideAudienceChart.Location = New System.Drawing.Point(1154, 710)
        Me.btnShowHideAudienceChart.Name = "btnShowHideAudienceChart"
        Me.btnShowHideAudienceChart.Size = New System.Drawing.Size(163, 23)
        Me.btnShowHideAudienceChart.TabIndex = 89
        Me.btnShowHideAudienceChart.Text = "Show/Hide Audience Chart"
        Me.btnShowHideAudienceChart.UseVisualStyleBackColor = True
        '
        'tmrLightsDownTrigger
        '
        Me.tmrLightsDownTrigger.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(9, 601)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(164, 601)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(320, 601)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox3.TabIndex = 92
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(475, 601)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox4.TabIndex = 93
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(629, 601)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox5.TabIndex = 94
        Me.PictureBox5.TabStop = False
        '
        'listQuestionStack
        '
        Me.listQuestionStack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listQuestionStack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listQuestionStack.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listQuestionStack.ForeColor = System.Drawing.Color.LightGray
        Me.listQuestionStack.HideSelection = False
        Me.listQuestionStack.Location = New System.Drawing.Point(12, 70)
        Me.listQuestionStack.Name = "listQuestionStack"
        Me.listQuestionStack.Size = New System.Drawing.Size(832, 450)
        Me.listQuestionStack.TabIndex = 95
        Me.listQuestionStack.UseCompatibleStateImageBehavior = False
        Me.listQuestionStack.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(34, 707)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 29)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(409, 707)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 29)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(34, 749)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 29)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "C:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(409, 749)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 29)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "D:"
        '
        'btnToggleOverlay
        '
        Me.btnToggleOverlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnToggleOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleOverlay.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleOverlay.ForeColor = System.Drawing.Color.White
        Me.btnToggleOverlay.Location = New System.Drawing.Point(305, 34)
        Me.btnToggleOverlay.Name = "btnToggleOverlay"
        Me.btnToggleOverlay.Size = New System.Drawing.Size(83, 31)
        Me.btnToggleOverlay.TabIndex = 100
        Me.btnToggleOverlay.Text = "OVERLAY"
        Me.btnToggleOverlay.UseVisualStyleBackColor = False
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1404, 796)
        Me.Controls.Add(Me.btnToggleOverlay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listQuestionStack)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.chkCorrectAnswer)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmrLevel)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnWalk)
        Me.Controls.Add(Me.btnLightsDown)
        Me.Controls.Add(Me.btnShowHideAudienceChart)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.btnDrawAudienceChart)
        Me.Controls.Add(Me.btnReveal)
        Me.Controls.Add(Me.btnGenerateNewStack)
        Me.Controls.Add(Me.grpHostMessages)
        Me.Controls.Add(Me.btnStopAudio)
        Me.Controls.Add(Me.btnNewQuestion)
        Me.Controls.Add(Me.btnResetGame)
        Me.Controls.Add(Me.btnToHotSeat)
        Me.Controls.Add(Me.grpLifelines)
        Me.Controls.Add(Me.grpTV)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.txtExplain)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.chkUsed)
        Me.Controls.Add(Me.txtQLeft)
        Me.Controls.Add(Me.txtDrop)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.txtWrong)
        Me.Controls.Add(Me.txtCorrect)
        Me.Controls.Add(Me.btnClosing)
        Me.Controls.Add(Me.btnCommercial)
        Me.Controls.Add(Me.btnSndOpening)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpRules)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ControlPanel"
        Me.Text = "g"
        CType(Me.nmrLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRules.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpLifelines.ResumeLayout(False)
        Me.grpLifelines.PerformLayout()
        Me.grpATANETinfo.ResumeLayout(False)
        Me.grpATANETinfo.PerformLayout()
        Me.grpATAInfo.ResumeLayout(False)
        Me.grpATAInfo.PerformLayout()
        Me.grpTV.ResumeLayout(False)
        Me.grpTV.PerformLayout()
        Me.grpHostMessages.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents chkLifeline3Unused As CheckBox
    Friend WithEvents chkLifeline2Unused As CheckBox
    Friend WithEvents chkLifeline4Unused As CheckBox
    Friend WithEvents btnLifeline3 As Button
    Friend WithEvents btnLifeline4 As Button
    Friend WithEvents btnLifeline2 As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkUsed As CheckBox
    Friend WithEvents btnToHotSeat As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents chkCorrectAnswer As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrTime As Timer
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
    Friend WithEvents txtExplain As TextBox
    Friend WithEvents btnLifeline1 As Button
    Friend WithEvents chkLifeline1Unused As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HostScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuestScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TVScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpLifelines As GroupBox
    Friend WithEvents grpTV As GroupBox
    Friend WithEvents btnLL4 As Button
    Friend WithEvents btnActivateRiskMode As Button
    Friend WithEvents grpATAInfo As GroupBox
    Friend WithEvents lblATA_D As Label
    Friend WithEvents lblATA_C As Label
    Friend WithEvents lblATA_B As Label
    Friend WithEvents lblATA_A As Label
    Friend WithEvents tmrLifelineBling As Timer
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUndo As Button
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuestionsEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ProfileEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtHostMessages As RichTextBox
    Friend WithEvents btnSendToHost As Button
    Friend WithEvents grpHostMessages As GroupBox
    Friend WithEvents drpNextHostMessage As ComboBox
    Friend WithEvents btnClearHostMessages As Button
    Friend WithEvents ChangeBackgroundColorTVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeQuestionFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X720720pToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X10801080pToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents btnResetGame As Button
    Friend WithEvents chkShowTotalScore As CheckBox
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastestFingerFirstToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStopAudio As Button
    Friend WithEvents tmrLifelineUpdate As Timer
    Friend WithEvents btnSet2ndSafeNet As Button
    Friend WithEvents chkShowPlayerList As CheckBox
    Friend WithEvents btnGenerateNewStack As Button
    Friend WithEvents FastestFingerFirstNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AskTheAudienceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpATANETinfo As GroupBox
    Friend WithEvents lblATANET_D As Label
    Friend WithEvents lblATANET_C As Label
    Friend WithEvents lblATANET_B As Label
    Friend WithEvents lblATANET_A As Label
    Friend WithEvents tmrUpdateATAInfo As Timer
    Friend WithEvents btnDrawAudienceChart As Button
    Friend WithEvents btnShowHideAudienceChart As Button
    Friend WithEvents tmrLightsDownTrigger As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents listQuestionStack As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnToggleOverlay As Button
End Class
