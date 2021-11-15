<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FFFServer
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
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPL8_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_8 = New System.Windows.Forms.Label()
        Me.txtPL8_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL8_Name = New System.Windows.Forms.TextBox()
        Me.txtPL7_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_7 = New System.Windows.Forms.Label()
        Me.txtPL7_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL7_Name = New System.Windows.Forms.TextBox()
        Me.txtPL6_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_6 = New System.Windows.Forms.Label()
        Me.txtPL6_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL6_Name = New System.Windows.Forms.TextBox()
        Me.txtPL5_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_5 = New System.Windows.Forms.Label()
        Me.txtPL5_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL5_Name = New System.Windows.Forms.TextBox()
        Me.lblPL_Points = New System.Windows.Forms.Label()
        Me.txtPL4_Points = New System.Windows.Forms.TextBox()
        Me.txtPL3_Points = New System.Windows.Forms.TextBox()
        Me.txtPL2_Points = New System.Windows.Forms.TextBox()
        Me.txtPL1_Points = New System.Windows.Forms.TextBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnShowCorrectPlayers = New System.Windows.Forms.Button()
        Me.btnReveal = New System.Windows.Forms.Button()
        Me.btnStartTime = New System.Windows.Forms.Button()
        Me.btnGenQuestion = New System.Windows.Forms.Button()
        Me.lblPL_4 = New System.Windows.Forms.Label()
        Me.lblPL_3 = New System.Windows.Forms.Label()
        Me.lblPL_2 = New System.Windows.Forms.Label()
        Me.lblPL_1 = New System.Windows.Forms.Label()
        Me.lblPL_Answer = New System.Windows.Forms.Label()
        Me.lblPL_Player = New System.Windows.Forms.Label()
        Me.txtPL4_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL4_Name = New System.Windows.Forms.TextBox()
        Me.txtPL3_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL3_Name = New System.Windows.Forms.TextBox()
        Me.txtPL2_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL2_Name = New System.Windows.Forms.TextBox()
        Me.txtPL1_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL1_Name = New System.Windows.Forms.TextBox()
        Me.tmrStopSnd1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrThink = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPoints = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRevealPlayers = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFastestPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSendAnswers = New System.Windows.Forms.Timer(Me.components)
        Me.chkPL1 = New System.Windows.Forms.CheckBox()
        Me.chkPL2 = New System.Windows.Forms.CheckBox()
        Me.chkPL3 = New System.Windows.Forms.CheckBox()
        Me.chkPL4 = New System.Windows.Forms.CheckBox()
        Me.chkPL5 = New System.Windows.Forms.CheckBox()
        Me.chkPL6 = New System.Windows.Forms.CheckBox()
        Me.chkPL7 = New System.Windows.Forms.CheckBox()
        Me.chkPL8 = New System.Windows.Forms.CheckBox()
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.lblSmallestScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAllVirtual = New System.Windows.Forms.CheckBox()
        Me.btnMeetContestants = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nmrTotalContestants = New System.Windows.Forms.NumericUpDown()
        Me.pnlPlayer1 = New System.Windows.Forms.Panel()
        Me.chkPL1_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer2 = New System.Windows.Forms.Panel()
        Me.chkPL2_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer3 = New System.Windows.Forms.Panel()
        Me.chkPL3_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer4 = New System.Windows.Forms.Panel()
        Me.chkPL4_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer5 = New System.Windows.Forms.Panel()
        Me.chkPL5_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer6 = New System.Windows.Forms.Panel()
        Me.chkPL6_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer7 = New System.Windows.Forms.Panel()
        Me.chkPL7_Active = New System.Windows.Forms.CheckBox()
        Me.pnlPlayer8 = New System.Windows.Forms.Panel()
        Me.chkPL8_Active = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkDisableWinnerAuto = New System.Windows.Forms.CheckBox()
        Me.chkShowPointsInServerConsole = New System.Windows.Forms.CheckBox()
        Me.lblTimeElapsed = New System.Windows.Forms.Label()
        CType(Me.nmrTotalContestants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPlayer1.SuspendLayout()
        Me.pnlPlayer2.SuspendLayout()
        Me.pnlPlayer3.SuspendLayout()
        Me.pnlPlayer4.SuspendLayout()
        Me.pnlPlayer5.SuspendLayout()
        Me.pnlPlayer6.SuspendLayout()
        Me.pnlPlayer7.SuspendLayout()
        Me.pnlPlayer8.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtReceive
        '
        Me.txtReceive.Location = New System.Drawing.Point(12, 530)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceive.Size = New System.Drawing.Size(227, 20)
        Me.txtReceive.TabIndex = 0
        Me.txtReceive.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 556)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(208, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtPL8_Points
        '
        Me.txtPL8_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL8_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL8_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL8_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL8_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL8_Points.Name = "txtPL8_Points"
        Me.txtPL8_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL8_Points.TabIndex = 90
        '
        'lblPL_8
        '
        Me.lblPL_8.AutoSize = True
        Me.lblPL_8.ForeColor = System.Drawing.Color.Black
        Me.lblPL_8.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_8.Name = "lblPL_8"
        Me.lblPL_8.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_8.TabIndex = 89
        Me.lblPL_8.Text = "8:"
        '
        'txtPL8_Answer
        '
        Me.txtPL8_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL8_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL8_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL8_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL8_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL8_Answer.Name = "txtPL8_Answer"
        Me.txtPL8_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL8_Answer.TabIndex = 88
        '
        'txtPL8_Name
        '
        Me.txtPL8_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL8_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL8_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL8_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL8_Name.Name = "txtPL8_Name"
        Me.txtPL8_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL8_Name.TabIndex = 87
        Me.txtPL8_Name.Text = "Player 8"
        '
        'txtPL7_Points
        '
        Me.txtPL7_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL7_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL7_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL7_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL7_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL7_Points.Name = "txtPL7_Points"
        Me.txtPL7_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL7_Points.TabIndex = 86
        '
        'lblPL_7
        '
        Me.lblPL_7.AutoSize = True
        Me.lblPL_7.ForeColor = System.Drawing.Color.Black
        Me.lblPL_7.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_7.Name = "lblPL_7"
        Me.lblPL_7.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_7.TabIndex = 85
        Me.lblPL_7.Text = "7:"
        '
        'txtPL7_Answer
        '
        Me.txtPL7_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL7_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL7_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL7_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL7_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL7_Answer.Name = "txtPL7_Answer"
        Me.txtPL7_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL7_Answer.TabIndex = 84
        '
        'txtPL7_Name
        '
        Me.txtPL7_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL7_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL7_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL7_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL7_Name.Name = "txtPL7_Name"
        Me.txtPL7_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL7_Name.TabIndex = 83
        Me.txtPL7_Name.Text = "Player 7"
        '
        'txtPL6_Points
        '
        Me.txtPL6_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL6_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL6_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL6_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL6_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL6_Points.Name = "txtPL6_Points"
        Me.txtPL6_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL6_Points.TabIndex = 82
        '
        'lblPL_6
        '
        Me.lblPL_6.AutoSize = True
        Me.lblPL_6.ForeColor = System.Drawing.Color.Black
        Me.lblPL_6.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_6.Name = "lblPL_6"
        Me.lblPL_6.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_6.TabIndex = 81
        Me.lblPL_6.Text = "6:"
        '
        'txtPL6_Answer
        '
        Me.txtPL6_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL6_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL6_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL6_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL6_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL6_Answer.Name = "txtPL6_Answer"
        Me.txtPL6_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL6_Answer.TabIndex = 80
        '
        'txtPL6_Name
        '
        Me.txtPL6_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL6_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL6_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL6_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL6_Name.Name = "txtPL6_Name"
        Me.txtPL6_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL6_Name.TabIndex = 79
        Me.txtPL6_Name.Text = "Player 6"
        '
        'txtPL5_Points
        '
        Me.txtPL5_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL5_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL5_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL5_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL5_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL5_Points.Name = "txtPL5_Points"
        Me.txtPL5_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL5_Points.TabIndex = 78
        '
        'lblPL_5
        '
        Me.lblPL_5.AutoSize = True
        Me.lblPL_5.ForeColor = System.Drawing.Color.Black
        Me.lblPL_5.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_5.Name = "lblPL_5"
        Me.lblPL_5.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_5.TabIndex = 77
        Me.lblPL_5.Text = "5:"
        '
        'txtPL5_Answer
        '
        Me.txtPL5_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL5_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL5_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL5_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL5_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL5_Answer.Name = "txtPL5_Answer"
        Me.txtPL5_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL5_Answer.TabIndex = 76
        '
        'txtPL5_Name
        '
        Me.txtPL5_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL5_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL5_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL5_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL5_Name.Name = "txtPL5_Name"
        Me.txtPL5_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL5_Name.TabIndex = 75
        Me.txtPL5_Name.Text = "Player 5"
        '
        'lblPL_Points
        '
        Me.lblPL_Points.AutoSize = True
        Me.lblPL_Points.ForeColor = System.Drawing.Color.Black
        Me.lblPL_Points.Location = New System.Drawing.Point(338, 47)
        Me.lblPL_Points.Name = "lblPL_Points"
        Me.lblPL_Points.Size = New System.Drawing.Size(36, 13)
        Me.lblPL_Points.TabIndex = 74
        Me.lblPL_Points.Text = "Points"
        '
        'txtPL4_Points
        '
        Me.txtPL4_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL4_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL4_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL4_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL4_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL4_Points.Name = "txtPL4_Points"
        Me.txtPL4_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL4_Points.TabIndex = 73
        '
        'txtPL3_Points
        '
        Me.txtPL3_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL3_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL3_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL3_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL3_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL3_Points.Name = "txtPL3_Points"
        Me.txtPL3_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL3_Points.TabIndex = 72
        '
        'txtPL2_Points
        '
        Me.txtPL2_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL2_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL2_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL2_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL2_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL2_Points.Name = "txtPL2_Points"
        Me.txtPL2_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL2_Points.TabIndex = 71
        '
        'txtPL1_Points
        '
        Me.txtPL1_Points.BackColor = System.Drawing.Color.Black
        Me.txtPL1_Points.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL1_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL1_Points.ForeColor = System.Drawing.Color.White
        Me.txtPL1_Points.Location = New System.Drawing.Point(333, 0)
        Me.txtPL1_Points.Name = "txtPL1_Points"
        Me.txtPL1_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL1_Points.TabIndex = 70
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.Black
        Me.lblPoints.Location = New System.Drawing.Point(277, 5)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(24, 25)
        Me.lblPoints.TabIndex = 69
        Me.lblPoints.Text = "0"
        Me.lblPoints.Visible = False
        '
        'btnShowCorrectPlayers
        '
        Me.btnShowCorrectPlayers.BackColor = System.Drawing.Color.LightGreen
        Me.btnShowCorrectPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowCorrectPlayers.ForeColor = System.Drawing.Color.Black
        Me.btnShowCorrectPlayers.Location = New System.Drawing.Point(133, 316)
        Me.btnShowCorrectPlayers.Name = "btnShowCorrectPlayers"
        Me.btnShowCorrectPlayers.Size = New System.Drawing.Size(95, 50)
        Me.btnShowCorrectPlayers.TabIndex = 68
        Me.btnShowCorrectPlayers.Text = "Who is Correct? + Fastest Sequence"
        Me.btnShowCorrectPlayers.UseVisualStyleBackColor = False
        '
        'btnReveal
        '
        Me.btnReveal.BackColor = System.Drawing.Color.Lime
        Me.btnReveal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReveal.Location = New System.Drawing.Point(32, 316)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(95, 50)
        Me.btnReveal.TabIndex = 67
        Me.btnReveal.Text = "Hide Question + Correct Order Sequence"
        Me.btnReveal.UseVisualStyleBackColor = False
        '
        'btnStartTime
        '
        Me.btnStartTime.BackColor = System.Drawing.Color.Navy
        Me.btnStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartTime.ForeColor = System.Drawing.Color.White
        Me.btnStartTime.Location = New System.Drawing.Point(133, 271)
        Me.btnStartTime.Name = "btnStartTime"
        Me.btnStartTime.Size = New System.Drawing.Size(95, 39)
        Me.btnStartTime.TabIndex = 66
        Me.btnStartTime.Text = "Start Time"
        Me.btnStartTime.UseVisualStyleBackColor = False
        '
        'btnGenQuestion
        '
        Me.btnGenQuestion.BackColor = System.Drawing.Color.Navy
        Me.btnGenQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenQuestion.ForeColor = System.Drawing.Color.White
        Me.btnGenQuestion.Location = New System.Drawing.Point(32, 271)
        Me.btnGenQuestion.Name = "btnGenQuestion"
        Me.btnGenQuestion.Size = New System.Drawing.Size(95, 39)
        Me.btnGenQuestion.TabIndex = 65
        Me.btnGenQuestion.Text = "Generate/Show Question"
        Me.btnGenQuestion.UseVisualStyleBackColor = False
        '
        'lblPL_4
        '
        Me.lblPL_4.AutoSize = True
        Me.lblPL_4.ForeColor = System.Drawing.Color.Black
        Me.lblPL_4.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_4.Name = "lblPL_4"
        Me.lblPL_4.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_4.TabIndex = 64
        Me.lblPL_4.Text = "4:"
        '
        'lblPL_3
        '
        Me.lblPL_3.AutoSize = True
        Me.lblPL_3.ForeColor = System.Drawing.Color.Black
        Me.lblPL_3.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_3.Name = "lblPL_3"
        Me.lblPL_3.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_3.TabIndex = 63
        Me.lblPL_3.Text = "3:"
        '
        'lblPL_2
        '
        Me.lblPL_2.AutoSize = True
        Me.lblPL_2.ForeColor = System.Drawing.Color.Black
        Me.lblPL_2.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_2.Name = "lblPL_2"
        Me.lblPL_2.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_2.TabIndex = 62
        Me.lblPL_2.Text = "2:"
        '
        'lblPL_1
        '
        Me.lblPL_1.AutoSize = True
        Me.lblPL_1.ForeColor = System.Drawing.Color.Black
        Me.lblPL_1.Location = New System.Drawing.Point(2, 3)
        Me.lblPL_1.Name = "lblPL_1"
        Me.lblPL_1.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_1.TabIndex = 61
        Me.lblPL_1.Text = "1:"
        '
        'lblPL_Answer
        '
        Me.lblPL_Answer.AutoSize = True
        Me.lblPL_Answer.ForeColor = System.Drawing.Color.Black
        Me.lblPL_Answer.Location = New System.Drawing.Point(280, 47)
        Me.lblPL_Answer.Name = "lblPL_Answer"
        Me.lblPL_Answer.Size = New System.Drawing.Size(42, 13)
        Me.lblPL_Answer.TabIndex = 60
        Me.lblPL_Answer.Text = "Answer"
        '
        'lblPL_Player
        '
        Me.lblPL_Player.AutoSize = True
        Me.lblPL_Player.ForeColor = System.Drawing.Color.Black
        Me.lblPL_Player.Location = New System.Drawing.Point(29, 47)
        Me.lblPL_Player.Name = "lblPL_Player"
        Me.lblPL_Player.Size = New System.Drawing.Size(36, 13)
        Me.lblPL_Player.TabIndex = 59
        Me.lblPL_Player.Text = "Player"
        '
        'txtPL4_Answer
        '
        Me.txtPL4_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL4_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL4_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL4_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL4_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL4_Answer.Name = "txtPL4_Answer"
        Me.txtPL4_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL4_Answer.TabIndex = 58
        '
        'txtPL4_Name
        '
        Me.txtPL4_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL4_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL4_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL4_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL4_Name.Name = "txtPL4_Name"
        Me.txtPL4_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL4_Name.TabIndex = 57
        Me.txtPL4_Name.Text = "Player 4"
        '
        'txtPL3_Answer
        '
        Me.txtPL3_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL3_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL3_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL3_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL3_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL3_Answer.Name = "txtPL3_Answer"
        Me.txtPL3_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL3_Answer.TabIndex = 56
        '
        'txtPL3_Name
        '
        Me.txtPL3_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL3_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL3_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL3_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL3_Name.Name = "txtPL3_Name"
        Me.txtPL3_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL3_Name.TabIndex = 55
        Me.txtPL3_Name.Text = "Player 3"
        '
        'txtPL2_Answer
        '
        Me.txtPL2_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL2_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL2_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL2_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL2_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL2_Answer.Name = "txtPL2_Answer"
        Me.txtPL2_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL2_Answer.TabIndex = 54
        '
        'txtPL2_Name
        '
        Me.txtPL2_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL2_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL2_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL2_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL2_Name.Name = "txtPL2_Name"
        Me.txtPL2_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL2_Name.TabIndex = 53
        Me.txtPL2_Name.Text = "Player 2"
        '
        'txtPL1_Answer
        '
        Me.txtPL1_Answer.BackColor = System.Drawing.Color.Black
        Me.txtPL1_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL1_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPL1_Answer.ForeColor = System.Drawing.Color.White
        Me.txtPL1_Answer.Location = New System.Drawing.Point(275, 0)
        Me.txtPL1_Answer.Name = "txtPL1_Answer"
        Me.txtPL1_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL1_Answer.TabIndex = 52
        '
        'txtPL1_Name
        '
        Me.txtPL1_Name.BackColor = System.Drawing.Color.DimGray
        Me.txtPL1_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPL1_Name.ForeColor = System.Drawing.Color.White
        Me.txtPL1_Name.Location = New System.Drawing.Point(24, 0)
        Me.txtPL1_Name.Name = "txtPL1_Name"
        Me.txtPL1_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL1_Name.TabIndex = 51
        Me.txtPL1_Name.Text = "Player 1"
        '
        'tmrStopSnd1
        '
        '
        'tmrThink
        '
        Me.tmrThink.Interval = 20100
        '
        'tmrPoints
        '
        Me.tmrPoints.Interval = 10
        '
        'tmrRevealPlayers
        '
        Me.tmrRevealPlayers.Interval = 50
        '
        'tmrFastestPlayer
        '
        Me.tmrFastestPlayer.Interval = 250
        '
        'tmrSendAnswers
        '
        Me.tmrSendAnswers.Interval = 10
        '
        'chkPL1
        '
        Me.chkPL1.AutoSize = True
        Me.chkPL1.Checked = True
        Me.chkPL1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL1.Location = New System.Drawing.Point(391, 3)
        Me.chkPL1.Name = "chkPL1"
        Me.chkPL1.Size = New System.Drawing.Size(15, 14)
        Me.chkPL1.TabIndex = 91
        Me.chkPL1.UseVisualStyleBackColor = True
        '
        'chkPL2
        '
        Me.chkPL2.AutoSize = True
        Me.chkPL2.Checked = True
        Me.chkPL2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL2.Location = New System.Drawing.Point(391, 3)
        Me.chkPL2.Name = "chkPL2"
        Me.chkPL2.Size = New System.Drawing.Size(15, 14)
        Me.chkPL2.TabIndex = 92
        Me.chkPL2.UseVisualStyleBackColor = True
        '
        'chkPL3
        '
        Me.chkPL3.AutoSize = True
        Me.chkPL3.Checked = True
        Me.chkPL3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL3.Location = New System.Drawing.Point(391, 3)
        Me.chkPL3.Name = "chkPL3"
        Me.chkPL3.Size = New System.Drawing.Size(15, 14)
        Me.chkPL3.TabIndex = 93
        Me.chkPL3.UseVisualStyleBackColor = True
        '
        'chkPL4
        '
        Me.chkPL4.AutoSize = True
        Me.chkPL4.Checked = True
        Me.chkPL4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL4.Location = New System.Drawing.Point(391, 3)
        Me.chkPL4.Name = "chkPL4"
        Me.chkPL4.Size = New System.Drawing.Size(15, 14)
        Me.chkPL4.TabIndex = 94
        Me.chkPL4.UseVisualStyleBackColor = True
        '
        'chkPL5
        '
        Me.chkPL5.AutoSize = True
        Me.chkPL5.Checked = True
        Me.chkPL5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL5.Location = New System.Drawing.Point(391, 3)
        Me.chkPL5.Name = "chkPL5"
        Me.chkPL5.Size = New System.Drawing.Size(15, 14)
        Me.chkPL5.TabIndex = 95
        Me.chkPL5.UseVisualStyleBackColor = True
        '
        'chkPL6
        '
        Me.chkPL6.AutoSize = True
        Me.chkPL6.Checked = True
        Me.chkPL6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL6.Location = New System.Drawing.Point(391, 3)
        Me.chkPL6.Name = "chkPL6"
        Me.chkPL6.Size = New System.Drawing.Size(15, 14)
        Me.chkPL6.TabIndex = 96
        Me.chkPL6.UseVisualStyleBackColor = True
        '
        'chkPL7
        '
        Me.chkPL7.AutoSize = True
        Me.chkPL7.Checked = True
        Me.chkPL7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL7.Location = New System.Drawing.Point(391, 3)
        Me.chkPL7.Name = "chkPL7"
        Me.chkPL7.Size = New System.Drawing.Size(15, 14)
        Me.chkPL7.TabIndex = 97
        Me.chkPL7.UseVisualStyleBackColor = True
        '
        'chkPL8
        '
        Me.chkPL8.AutoSize = True
        Me.chkPL8.Checked = True
        Me.chkPL8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL8.Location = New System.Drawing.Point(391, 3)
        Me.chkPL8.Name = "chkPL8"
        Me.chkPL8.Size = New System.Drawing.Size(15, 14)
        Me.chkPL8.TabIndex = 98
        Me.chkPL8.UseVisualStyleBackColor = True
        '
        'btnRandomize
        '
        Me.btnRandomize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandomize.Location = New System.Drawing.Point(234, 271)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(110, 27)
        Me.btnRandomize.TabIndex = 99
        Me.btnRandomize.Text = "Randomize Points"
        Me.btnRandomize.UseVisualStyleBackColor = False
        '
        'lblSmallestScore
        '
        Me.lblSmallestScore.AutoSize = True
        Me.lblSmallestScore.ForeColor = System.Drawing.Color.Black
        Me.lblSmallestScore.Location = New System.Drawing.Point(280, 30)
        Me.lblSmallestScore.Name = "lblSmallestScore"
        Me.lblSmallestScore.Size = New System.Drawing.Size(89, 13)
        Me.lblSmallestScore.TabIndex = 100
        Me.lblSmallestScore.Text = "Smallest Score: 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Virtual Mode"
        '
        'chkAllVirtual
        '
        Me.chkAllVirtual.AutoSize = True
        Me.chkAllVirtual.Checked = True
        Me.chkAllVirtual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllVirtual.Location = New System.Drawing.Point(398, 271)
        Me.chkAllVirtual.Name = "chkAllVirtual"
        Me.chkAllVirtual.Size = New System.Drawing.Size(70, 17)
        Me.chkAllVirtual.TabIndex = 102
        Me.chkAllVirtual.Text = "Select All"
        Me.chkAllVirtual.UseVisualStyleBackColor = True
        '
        'btnMeetContestants
        '
        Me.btnMeetContestants.BackColor = System.Drawing.Color.Yellow
        Me.btnMeetContestants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeetContestants.Location = New System.Drawing.Point(167, 11)
        Me.btnMeetContestants.Name = "btnMeetContestants"
        Me.btnMeetContestants.Size = New System.Drawing.Size(93, 38)
        Me.btnMeetContestants.TabIndex = 103
        Me.btnMeetContestants.Text = "Meet contestants"
        Me.btnMeetContestants.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Total Contestants:"
        '
        'nmrTotalContestants
        '
        Me.nmrTotalContestants.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrTotalContestants.Location = New System.Drawing.Point(111, 17)
        Me.nmrTotalContestants.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nmrTotalContestants.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nmrTotalContestants.Name = "nmrTotalContestants"
        Me.nmrTotalContestants.Size = New System.Drawing.Size(50, 26)
        Me.nmrTotalContestants.TabIndex = 105
        Me.nmrTotalContestants.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'pnlPlayer1
        '
        Me.pnlPlayer1.Controls.Add(Me.chkPL1_Active)
        Me.pnlPlayer1.Controls.Add(Me.txtPL1_Name)
        Me.pnlPlayer1.Controls.Add(Me.txtPL1_Answer)
        Me.pnlPlayer1.Controls.Add(Me.lblPL_1)
        Me.pnlPlayer1.Controls.Add(Me.txtPL1_Points)
        Me.pnlPlayer1.Controls.Add(Me.chkPL1)
        Me.pnlPlayer1.Location = New System.Drawing.Point(7, 63)
        Me.pnlPlayer1.Name = "pnlPlayer1"
        Me.pnlPlayer1.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer1.TabIndex = 106
        '
        'chkPL1_Active
        '
        Me.chkPL1_Active.AutoSize = True
        Me.chkPL1_Active.Checked = True
        Me.chkPL1_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL1_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL1_Active.Name = "chkPL1_Active"
        Me.chkPL1_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL1_Active.TabIndex = 92
        Me.chkPL1_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer2
        '
        Me.pnlPlayer2.Controls.Add(Me.chkPL2_Active)
        Me.pnlPlayer2.Controls.Add(Me.txtPL2_Name)
        Me.pnlPlayer2.Controls.Add(Me.txtPL2_Answer)
        Me.pnlPlayer2.Controls.Add(Me.lblPL_2)
        Me.pnlPlayer2.Controls.Add(Me.txtPL2_Points)
        Me.pnlPlayer2.Controls.Add(Me.chkPL2)
        Me.pnlPlayer2.Location = New System.Drawing.Point(7, 89)
        Me.pnlPlayer2.Name = "pnlPlayer2"
        Me.pnlPlayer2.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer2.TabIndex = 107
        '
        'chkPL2_Active
        '
        Me.chkPL2_Active.AutoSize = True
        Me.chkPL2_Active.Checked = True
        Me.chkPL2_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL2_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL2_Active.Name = "chkPL2_Active"
        Me.chkPL2_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL2_Active.TabIndex = 93
        Me.chkPL2_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer3
        '
        Me.pnlPlayer3.Controls.Add(Me.chkPL3_Active)
        Me.pnlPlayer3.Controls.Add(Me.txtPL3_Name)
        Me.pnlPlayer3.Controls.Add(Me.txtPL3_Answer)
        Me.pnlPlayer3.Controls.Add(Me.lblPL_3)
        Me.pnlPlayer3.Controls.Add(Me.txtPL3_Points)
        Me.pnlPlayer3.Controls.Add(Me.chkPL3)
        Me.pnlPlayer3.Location = New System.Drawing.Point(7, 115)
        Me.pnlPlayer3.Name = "pnlPlayer3"
        Me.pnlPlayer3.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer3.TabIndex = 107
        '
        'chkPL3_Active
        '
        Me.chkPL3_Active.AutoSize = True
        Me.chkPL3_Active.Checked = True
        Me.chkPL3_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL3_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL3_Active.Name = "chkPL3_Active"
        Me.chkPL3_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL3_Active.TabIndex = 94
        Me.chkPL3_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer4
        '
        Me.pnlPlayer4.Controls.Add(Me.chkPL4_Active)
        Me.pnlPlayer4.Controls.Add(Me.txtPL4_Name)
        Me.pnlPlayer4.Controls.Add(Me.txtPL4_Answer)
        Me.pnlPlayer4.Controls.Add(Me.lblPL_4)
        Me.pnlPlayer4.Controls.Add(Me.txtPL4_Points)
        Me.pnlPlayer4.Controls.Add(Me.chkPL4)
        Me.pnlPlayer4.Location = New System.Drawing.Point(7, 141)
        Me.pnlPlayer4.Name = "pnlPlayer4"
        Me.pnlPlayer4.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer4.TabIndex = 107
        '
        'chkPL4_Active
        '
        Me.chkPL4_Active.AutoSize = True
        Me.chkPL4_Active.Checked = True
        Me.chkPL4_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL4_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL4_Active.Name = "chkPL4_Active"
        Me.chkPL4_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL4_Active.TabIndex = 95
        Me.chkPL4_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer5
        '
        Me.pnlPlayer5.Controls.Add(Me.chkPL5_Active)
        Me.pnlPlayer5.Controls.Add(Me.txtPL5_Name)
        Me.pnlPlayer5.Controls.Add(Me.txtPL5_Answer)
        Me.pnlPlayer5.Controls.Add(Me.lblPL_5)
        Me.pnlPlayer5.Controls.Add(Me.txtPL5_Points)
        Me.pnlPlayer5.Controls.Add(Me.chkPL5)
        Me.pnlPlayer5.Location = New System.Drawing.Point(7, 167)
        Me.pnlPlayer5.Name = "pnlPlayer5"
        Me.pnlPlayer5.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer5.TabIndex = 107
        '
        'chkPL5_Active
        '
        Me.chkPL5_Active.AutoSize = True
        Me.chkPL5_Active.Checked = True
        Me.chkPL5_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL5_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL5_Active.Name = "chkPL5_Active"
        Me.chkPL5_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL5_Active.TabIndex = 96
        Me.chkPL5_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer6
        '
        Me.pnlPlayer6.Controls.Add(Me.chkPL6_Active)
        Me.pnlPlayer6.Controls.Add(Me.txtPL6_Name)
        Me.pnlPlayer6.Controls.Add(Me.txtPL6_Answer)
        Me.pnlPlayer6.Controls.Add(Me.lblPL_6)
        Me.pnlPlayer6.Controls.Add(Me.txtPL6_Points)
        Me.pnlPlayer6.Controls.Add(Me.chkPL6)
        Me.pnlPlayer6.Location = New System.Drawing.Point(7, 193)
        Me.pnlPlayer6.Name = "pnlPlayer6"
        Me.pnlPlayer6.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer6.TabIndex = 107
        '
        'chkPL6_Active
        '
        Me.chkPL6_Active.AutoSize = True
        Me.chkPL6_Active.Checked = True
        Me.chkPL6_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL6_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL6_Active.Name = "chkPL6_Active"
        Me.chkPL6_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL6_Active.TabIndex = 97
        Me.chkPL6_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer7
        '
        Me.pnlPlayer7.Controls.Add(Me.chkPL7_Active)
        Me.pnlPlayer7.Controls.Add(Me.txtPL7_Name)
        Me.pnlPlayer7.Controls.Add(Me.txtPL7_Answer)
        Me.pnlPlayer7.Controls.Add(Me.lblPL_7)
        Me.pnlPlayer7.Controls.Add(Me.txtPL7_Points)
        Me.pnlPlayer7.Controls.Add(Me.chkPL7)
        Me.pnlPlayer7.Location = New System.Drawing.Point(7, 219)
        Me.pnlPlayer7.Name = "pnlPlayer7"
        Me.pnlPlayer7.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer7.TabIndex = 107
        '
        'chkPL7_Active
        '
        Me.chkPL7_Active.AutoSize = True
        Me.chkPL7_Active.Checked = True
        Me.chkPL7_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL7_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL7_Active.Name = "chkPL7_Active"
        Me.chkPL7_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL7_Active.TabIndex = 98
        Me.chkPL7_Active.UseVisualStyleBackColor = True
        '
        'pnlPlayer8
        '
        Me.pnlPlayer8.Controls.Add(Me.chkPL8_Active)
        Me.pnlPlayer8.Controls.Add(Me.txtPL8_Name)
        Me.pnlPlayer8.Controls.Add(Me.txtPL8_Answer)
        Me.pnlPlayer8.Controls.Add(Me.lblPL_8)
        Me.pnlPlayer8.Controls.Add(Me.txtPL8_Points)
        Me.pnlPlayer8.Controls.Add(Me.chkPL8)
        Me.pnlPlayer8.Location = New System.Drawing.Point(7, 245)
        Me.pnlPlayer8.Name = "pnlPlayer8"
        Me.pnlPlayer8.Size = New System.Drawing.Size(504, 20)
        Me.pnlPlayer8.TabIndex = 107
        '
        'chkPL8_Active
        '
        Me.chkPL8_Active.AutoSize = True
        Me.chkPL8_Active.Checked = True
        Me.chkPL8_Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPL8_Active.Location = New System.Drawing.Point(455, 3)
        Me.chkPL8_Active.Name = "chkPL8_Active"
        Me.chkPL8_Active.Size = New System.Drawing.Size(15, 14)
        Me.chkPL8_Active.TabIndex = 99
        Me.chkPL8_Active.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(459, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Active"
        '
        'chkDisableWinnerAuto
        '
        Me.chkDisableWinnerAuto.AutoSize = True
        Me.chkDisableWinnerAuto.Checked = True
        Me.chkDisableWinnerAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisableWinnerAuto.Location = New System.Drawing.Point(234, 316)
        Me.chkDisableWinnerAuto.Name = "chkDisableWinnerAuto"
        Me.chkDisableWinnerAuto.Size = New System.Drawing.Size(199, 17)
        Me.chkDisableWinnerAuto.TabIndex = 109
        Me.chkDisableWinnerAuto.Text = "Disable Winning Player automatically"
        Me.chkDisableWinnerAuto.UseVisualStyleBackColor = True
        '
        'chkShowPointsInServerConsole
        '
        Me.chkShowPointsInServerConsole.AutoSize = True
        Me.chkShowPointsInServerConsole.Checked = True
        Me.chkShowPointsInServerConsole.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPointsInServerConsole.Location = New System.Drawing.Point(234, 334)
        Me.chkShowPointsInServerConsole.Name = "chkShowPointsInServerConsole"
        Me.chkShowPointsInServerConsole.Size = New System.Drawing.Size(167, 17)
        Me.chkShowPointsInServerConsole.TabIndex = 110
        Me.chkShowPointsInServerConsole.Text = "Show points in server console"
        Me.chkShowPointsInServerConsole.UseVisualStyleBackColor = True
        '
        'lblTimeElapsed
        '
        Me.lblTimeElapsed.AutoSize = True
        Me.lblTimeElapsed.Location = New System.Drawing.Point(455, 355)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(28, 13)
        Me.lblTimeElapsed.TabIndex = 111
        Me.lblTimeElapsed.Text = "0,00"
        '
        'FFFServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(523, 377)
        Me.Controls.Add(Me.lblTimeElapsed)
        Me.Controls.Add(Me.chkShowPointsInServerConsole)
        Me.Controls.Add(Me.chkDisableWinnerAuto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlPlayer8)
        Me.Controls.Add(Me.pnlPlayer7)
        Me.Controls.Add(Me.pnlPlayer6)
        Me.Controls.Add(Me.pnlPlayer5)
        Me.Controls.Add(Me.pnlPlayer4)
        Me.Controls.Add(Me.pnlPlayer3)
        Me.Controls.Add(Me.pnlPlayer2)
        Me.Controls.Add(Me.pnlPlayer1)
        Me.Controls.Add(Me.nmrTotalContestants)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMeetContestants)
        Me.Controls.Add(Me.chkAllVirtual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSmallestScore)
        Me.Controls.Add(Me.btnRandomize)
        Me.Controls.Add(Me.lblPL_Points)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnShowCorrectPlayers)
        Me.Controls.Add(Me.btnReveal)
        Me.Controls.Add(Me.btnStartTime)
        Me.Controls.Add(Me.btnGenQuestion)
        Me.Controls.Add(Me.lblPL_Answer)
        Me.Controls.Add(Me.lblPL_Player)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtReceive)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FFFServer"
        Me.Text = "Fastest Finger: Server"
        CType(Me.nmrTotalContestants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPlayer1.ResumeLayout(False)
        Me.pnlPlayer1.PerformLayout()
        Me.pnlPlayer2.ResumeLayout(False)
        Me.pnlPlayer2.PerformLayout()
        Me.pnlPlayer3.ResumeLayout(False)
        Me.pnlPlayer3.PerformLayout()
        Me.pnlPlayer4.ResumeLayout(False)
        Me.pnlPlayer4.PerformLayout()
        Me.pnlPlayer5.ResumeLayout(False)
        Me.pnlPlayer5.PerformLayout()
        Me.pnlPlayer6.ResumeLayout(False)
        Me.pnlPlayer6.PerformLayout()
        Me.pnlPlayer7.ResumeLayout(False)
        Me.pnlPlayer7.PerformLayout()
        Me.pnlPlayer8.ResumeLayout(False)
        Me.pnlPlayer8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceive As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPL8_Points As TextBox
    Friend WithEvents lblPL_8 As Label
    Friend WithEvents txtPL8_Answer As TextBox
    Friend WithEvents txtPL8_Name As TextBox
    Friend WithEvents txtPL7_Points As TextBox
    Friend WithEvents lblPL_7 As Label
    Friend WithEvents txtPL7_Answer As TextBox
    Friend WithEvents txtPL7_Name As TextBox
    Friend WithEvents txtPL6_Points As TextBox
    Friend WithEvents lblPL_6 As Label
    Friend WithEvents txtPL6_Answer As TextBox
    Friend WithEvents txtPL6_Name As TextBox
    Friend WithEvents txtPL5_Points As TextBox
    Friend WithEvents lblPL_5 As Label
    Friend WithEvents txtPL5_Answer As TextBox
    Friend WithEvents txtPL5_Name As TextBox
    Friend WithEvents lblPL_Points As Label
    Friend WithEvents txtPL4_Points As TextBox
    Friend WithEvents txtPL3_Points As TextBox
    Friend WithEvents txtPL2_Points As TextBox
    Friend WithEvents txtPL1_Points As TextBox
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnShowCorrectPlayers As Button
    Friend WithEvents btnReveal As Button
    Friend WithEvents btnStartTime As Button
    Friend WithEvents btnGenQuestion As Button
    Friend WithEvents lblPL_4 As Label
    Friend WithEvents lblPL_3 As Label
    Friend WithEvents lblPL_2 As Label
    Friend WithEvents lblPL_1 As Label
    Friend WithEvents lblPL_Answer As Label
    Friend WithEvents lblPL_Player As Label
    Friend WithEvents txtPL4_Answer As TextBox
    Friend WithEvents txtPL4_Name As TextBox
    Friend WithEvents txtPL3_Answer As TextBox
    Friend WithEvents txtPL3_Name As TextBox
    Friend WithEvents txtPL2_Answer As TextBox
    Friend WithEvents txtPL2_Name As TextBox
    Friend WithEvents txtPL1_Answer As TextBox
    Friend WithEvents txtPL1_Name As TextBox
    Friend WithEvents tmrStopSnd1 As Timer
    Friend WithEvents tmrThink As Timer
    Friend WithEvents tmrPoints As Timer
    Friend WithEvents tmrRevealPlayers As Timer
    Friend WithEvents tmrFastestPlayer As Timer
    Friend WithEvents tmrSendAnswers As Timer
    Friend WithEvents chkPL1 As CheckBox
    Friend WithEvents chkPL2 As CheckBox
    Friend WithEvents chkPL3 As CheckBox
    Friend WithEvents chkPL4 As CheckBox
    Friend WithEvents chkPL5 As CheckBox
    Friend WithEvents chkPL6 As CheckBox
    Friend WithEvents chkPL7 As CheckBox
    Friend WithEvents chkPL8 As CheckBox
    Friend WithEvents lblSmallestScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAllVirtual As CheckBox
    Friend WithEvents btnMeetContestants As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents nmrTotalContestants As NumericUpDown
    Friend WithEvents pnlPlayer1 As Panel
    Friend WithEvents pnlPlayer2 As Panel
    Friend WithEvents pnlPlayer3 As Panel
    Friend WithEvents pnlPlayer4 As Panel
    Friend WithEvents pnlPlayer5 As Panel
    Friend WithEvents pnlPlayer6 As Panel
    Friend WithEvents pnlPlayer7 As Panel
    Friend WithEvents pnlPlayer8 As Panel
    Friend WithEvents btnRandomize As Button
    Friend WithEvents chkPL1_Active As CheckBox
    Friend WithEvents chkPL2_Active As CheckBox
    Friend WithEvents chkPL3_Active As CheckBox
    Friend WithEvents chkPL4_Active As CheckBox
    Friend WithEvents chkPL5_Active As CheckBox
    Friend WithEvents chkPL6_Active As CheckBox
    Friend WithEvents chkPL7_Active As CheckBox
    Friend WithEvents chkPL8_Active As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkDisableWinnerAuto As CheckBox
    Friend WithEvents chkShowPointsInServerConsole As CheckBox
    Friend WithEvents lblTimeElapsed As Label
End Class
