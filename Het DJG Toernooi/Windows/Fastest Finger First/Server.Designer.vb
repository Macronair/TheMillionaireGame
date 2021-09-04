<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Server
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
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.btnStopServer = New System.Windows.Forms.Button()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.txtPL1_Name = New System.Windows.Forms.TextBox()
        Me.txtPL1_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL2_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL2_Name = New System.Windows.Forms.TextBox()
        Me.txtPL3_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL3_Name = New System.Windows.Forms.TextBox()
        Me.txtPL4_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL4_Name = New System.Windows.Forms.TextBox()
        Me.lblPL_Player = New System.Windows.Forms.Label()
        Me.lblPL_Answer = New System.Windows.Forms.Label()
        Me.lblPL_1 = New System.Windows.Forms.Label()
        Me.lblPL_2 = New System.Windows.Forms.Label()
        Me.lblPL_3 = New System.Windows.Forms.Label()
        Me.lblPL_4 = New System.Windows.Forms.Label()
        Me.btnGenQuestion = New System.Windows.Forms.Button()
        Me.btnStartTime = New System.Windows.Forms.Button()
        Me.btnReveal = New System.Windows.Forms.Button()
        Me.btnShowCorrectPlayers = New System.Windows.Forms.Button()
        Me.tmrStopSnd1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrThink = New System.Windows.Forms.Timer(Me.components)
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.tmrPoints = New System.Windows.Forms.Timer(Me.components)
        Me.txtPL4_Points = New System.Windows.Forms.TextBox()
        Me.txtPL3_Points = New System.Windows.Forms.TextBox()
        Me.txtPL2_Points = New System.Windows.Forms.TextBox()
        Me.txtPL1_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_Points = New System.Windows.Forms.Label()
        Me.tmrRevealPlayers = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFastestPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.txtPL5_Name = New System.Windows.Forms.TextBox()
        Me.txtPL5_Answer = New System.Windows.Forms.TextBox()
        Me.lblPL_5 = New System.Windows.Forms.Label()
        Me.txtPL5_Points = New System.Windows.Forms.TextBox()
        Me.txtPL6_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_6 = New System.Windows.Forms.Label()
        Me.txtPL6_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL6_Name = New System.Windows.Forms.TextBox()
        Me.txtPL7_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_7 = New System.Windows.Forms.Label()
        Me.txtPL7_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL7_Name = New System.Windows.Forms.TextBox()
        Me.txtPL8_Points = New System.Windows.Forms.TextBox()
        Me.lblPL_8 = New System.Windows.Forms.Label()
        Me.txtPL8_Answer = New System.Windows.Forms.TextBox()
        Me.txtPL8_Name = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStartServer
        '
        Me.btnStartServer.Location = New System.Drawing.Point(12, 12)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(75, 23)
        Me.btnStartServer.TabIndex = 0
        Me.btnStartServer.Text = "Start"
        Me.btnStartServer.UseVisualStyleBackColor = True
        '
        'btnStopServer
        '
        Me.btnStopServer.Location = New System.Drawing.Point(93, 12)
        Me.btnStopServer.Name = "btnStopServer"
        Me.btnStopServer.Size = New System.Drawing.Size(75, 23)
        Me.btnStopServer.TabIndex = 1
        Me.btnStopServer.Text = "Stop"
        Me.btnStopServer.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(300, 14)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(39, 20)
        Me.txtSend.TabIndex = 3
        Me.txtSend.Visible = False
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(228, 12)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(60, 23)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Button1"
        Me.btnSend.UseVisualStyleBackColor = True
        Me.btnSend.Visible = False
        '
        'txtReceive
        '
        Me.txtReceive.Location = New System.Drawing.Point(183, 14)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(39, 20)
        Me.txtReceive.TabIndex = 5
        Me.txtReceive.Visible = False
        '
        'txtPL1_Name
        '
        Me.txtPL1_Name.Location = New System.Drawing.Point(36, 90)
        Me.txtPL1_Name.Name = "txtPL1_Name"
        Me.txtPL1_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL1_Name.TabIndex = 6
        Me.txtPL1_Name.Text = "Player 1"
        '
        'txtPL1_Answer
        '
        Me.txtPL1_Answer.Location = New System.Drawing.Point(287, 90)
        Me.txtPL1_Answer.Name = "txtPL1_Answer"
        Me.txtPL1_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL1_Answer.TabIndex = 7
        '
        'txtPL2_Answer
        '
        Me.txtPL2_Answer.Location = New System.Drawing.Point(287, 116)
        Me.txtPL2_Answer.Name = "txtPL2_Answer"
        Me.txtPL2_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL2_Answer.TabIndex = 9
        '
        'txtPL2_Name
        '
        Me.txtPL2_Name.Location = New System.Drawing.Point(36, 116)
        Me.txtPL2_Name.Name = "txtPL2_Name"
        Me.txtPL2_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL2_Name.TabIndex = 8
        Me.txtPL2_Name.Text = "Player 2"
        '
        'txtPL3_Answer
        '
        Me.txtPL3_Answer.Location = New System.Drawing.Point(287, 142)
        Me.txtPL3_Answer.Name = "txtPL3_Answer"
        Me.txtPL3_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL3_Answer.TabIndex = 11
        '
        'txtPL3_Name
        '
        Me.txtPL3_Name.Location = New System.Drawing.Point(36, 142)
        Me.txtPL3_Name.Name = "txtPL3_Name"
        Me.txtPL3_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL3_Name.TabIndex = 10
        Me.txtPL3_Name.Text = "Player 3"
        '
        'txtPL4_Answer
        '
        Me.txtPL4_Answer.Location = New System.Drawing.Point(287, 168)
        Me.txtPL4_Answer.Name = "txtPL4_Answer"
        Me.txtPL4_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL4_Answer.TabIndex = 13
        '
        'txtPL4_Name
        '
        Me.txtPL4_Name.Location = New System.Drawing.Point(36, 168)
        Me.txtPL4_Name.Name = "txtPL4_Name"
        Me.txtPL4_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL4_Name.TabIndex = 12
        Me.txtPL4_Name.Text = "Player 4"
        '
        'lblPL_Player
        '
        Me.lblPL_Player.AutoSize = True
        Me.lblPL_Player.Location = New System.Drawing.Point(33, 74)
        Me.lblPL_Player.Name = "lblPL_Player"
        Me.lblPL_Player.Size = New System.Drawing.Size(36, 13)
        Me.lblPL_Player.TabIndex = 14
        Me.lblPL_Player.Text = "Player"
        '
        'lblPL_Answer
        '
        Me.lblPL_Answer.AutoSize = True
        Me.lblPL_Answer.Location = New System.Drawing.Point(284, 74)
        Me.lblPL_Answer.Name = "lblPL_Answer"
        Me.lblPL_Answer.Size = New System.Drawing.Size(42, 13)
        Me.lblPL_Answer.TabIndex = 15
        Me.lblPL_Answer.Text = "Answer"
        '
        'lblPL_1
        '
        Me.lblPL_1.AutoSize = True
        Me.lblPL_1.Location = New System.Drawing.Point(14, 93)
        Me.lblPL_1.Name = "lblPL_1"
        Me.lblPL_1.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_1.TabIndex = 16
        Me.lblPL_1.Text = "1:"
        '
        'lblPL_2
        '
        Me.lblPL_2.AutoSize = True
        Me.lblPL_2.Location = New System.Drawing.Point(14, 119)
        Me.lblPL_2.Name = "lblPL_2"
        Me.lblPL_2.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_2.TabIndex = 17
        Me.lblPL_2.Text = "2:"
        '
        'lblPL_3
        '
        Me.lblPL_3.AutoSize = True
        Me.lblPL_3.Location = New System.Drawing.Point(14, 145)
        Me.lblPL_3.Name = "lblPL_3"
        Me.lblPL_3.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_3.TabIndex = 18
        Me.lblPL_3.Text = "3:"
        '
        'lblPL_4
        '
        Me.lblPL_4.AutoSize = True
        Me.lblPL_4.Location = New System.Drawing.Point(14, 171)
        Me.lblPL_4.Name = "lblPL_4"
        Me.lblPL_4.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_4.TabIndex = 19
        Me.lblPL_4.Text = "4:"
        '
        'btnGenQuestion
        '
        Me.btnGenQuestion.Location = New System.Drawing.Point(17, 307)
        Me.btnGenQuestion.Name = "btnGenQuestion"
        Me.btnGenQuestion.Size = New System.Drawing.Size(75, 39)
        Me.btnGenQuestion.TabIndex = 25
        Me.btnGenQuestion.Text = "Generate Question"
        Me.btnGenQuestion.UseVisualStyleBackColor = True
        '
        'btnStartTime
        '
        Me.btnStartTime.Location = New System.Drawing.Point(98, 307)
        Me.btnStartTime.Name = "btnStartTime"
        Me.btnStartTime.Size = New System.Drawing.Size(75, 39)
        Me.btnStartTime.TabIndex = 26
        Me.btnStartTime.Text = "Start Time"
        Me.btnStartTime.UseVisualStyleBackColor = True
        '
        'btnReveal
        '
        Me.btnReveal.Location = New System.Drawing.Point(196, 307)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(75, 39)
        Me.btnReveal.TabIndex = 27
        Me.btnReveal.Text = "Reveal"
        Me.btnReveal.UseVisualStyleBackColor = True
        '
        'btnShowCorrectPlayers
        '
        Me.btnShowCorrectPlayers.Location = New System.Drawing.Point(277, 307)
        Me.btnShowCorrectPlayers.Name = "btnShowCorrectPlayers"
        Me.btnShowCorrectPlayers.Size = New System.Drawing.Size(75, 39)
        Me.btnShowCorrectPlayers.TabIndex = 28
        Me.btnShowCorrectPlayers.Text = "Show Players"
        Me.btnShowCorrectPlayers.UseVisualStyleBackColor = True
        '
        'tmrStopSnd1
        '
        '
        'tmrThink
        '
        Me.tmrThink.Interval = 20000
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(12, 40)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(24, 25)
        Me.lblPoints.TabIndex = 29
        Me.lblPoints.Text = "0"
        '
        'tmrPoints
        '
        Me.tmrPoints.Interval = 1
        '
        'txtPL4_Points
        '
        Me.txtPL4_Points.Location = New System.Drawing.Point(345, 168)
        Me.txtPL4_Points.Name = "txtPL4_Points"
        Me.txtPL4_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL4_Points.TabIndex = 33
        '
        'txtPL3_Points
        '
        Me.txtPL3_Points.Location = New System.Drawing.Point(345, 142)
        Me.txtPL3_Points.Name = "txtPL3_Points"
        Me.txtPL3_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL3_Points.TabIndex = 32
        '
        'txtPL2_Points
        '
        Me.txtPL2_Points.Location = New System.Drawing.Point(345, 116)
        Me.txtPL2_Points.Name = "txtPL2_Points"
        Me.txtPL2_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL2_Points.TabIndex = 31
        '
        'txtPL1_Points
        '
        Me.txtPL1_Points.Location = New System.Drawing.Point(345, 90)
        Me.txtPL1_Points.Name = "txtPL1_Points"
        Me.txtPL1_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL1_Points.TabIndex = 30
        '
        'lblPL_Points
        '
        Me.lblPL_Points.AutoSize = True
        Me.lblPL_Points.Location = New System.Drawing.Point(342, 74)
        Me.lblPL_Points.Name = "lblPL_Points"
        Me.lblPL_Points.Size = New System.Drawing.Size(36, 13)
        Me.lblPL_Points.TabIndex = 34
        Me.lblPL_Points.Text = "Points"
        '
        'tmrRevealPlayers
        '
        Me.tmrRevealPlayers.Interval = 75
        '
        'tmrFastestPlayer
        '
        '
        'txtPL5_Name
        '
        Me.txtPL5_Name.Location = New System.Drawing.Point(36, 194)
        Me.txtPL5_Name.Name = "txtPL5_Name"
        Me.txtPL5_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL5_Name.TabIndex = 35
        Me.txtPL5_Name.Text = "Player 5"
        '
        'txtPL5_Answer
        '
        Me.txtPL5_Answer.Location = New System.Drawing.Point(287, 194)
        Me.txtPL5_Answer.Name = "txtPL5_Answer"
        Me.txtPL5_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL5_Answer.TabIndex = 36
        '
        'lblPL_5
        '
        Me.lblPL_5.AutoSize = True
        Me.lblPL_5.Location = New System.Drawing.Point(14, 197)
        Me.lblPL_5.Name = "lblPL_5"
        Me.lblPL_5.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_5.TabIndex = 37
        Me.lblPL_5.Text = "5:"
        '
        'txtPL5_Points
        '
        Me.txtPL5_Points.Location = New System.Drawing.Point(345, 194)
        Me.txtPL5_Points.Name = "txtPL5_Points"
        Me.txtPL5_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL5_Points.TabIndex = 38
        '
        'txtPL6_Points
        '
        Me.txtPL6_Points.Location = New System.Drawing.Point(345, 220)
        Me.txtPL6_Points.Name = "txtPL6_Points"
        Me.txtPL6_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL6_Points.TabIndex = 42
        '
        'lblPL_6
        '
        Me.lblPL_6.AutoSize = True
        Me.lblPL_6.Location = New System.Drawing.Point(14, 223)
        Me.lblPL_6.Name = "lblPL_6"
        Me.lblPL_6.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_6.TabIndex = 41
        Me.lblPL_6.Text = "6:"
        '
        'txtPL6_Answer
        '
        Me.txtPL6_Answer.Location = New System.Drawing.Point(287, 220)
        Me.txtPL6_Answer.Name = "txtPL6_Answer"
        Me.txtPL6_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL6_Answer.TabIndex = 40
        '
        'txtPL6_Name
        '
        Me.txtPL6_Name.Location = New System.Drawing.Point(36, 220)
        Me.txtPL6_Name.Name = "txtPL6_Name"
        Me.txtPL6_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL6_Name.TabIndex = 39
        Me.txtPL6_Name.Text = "Player 6"
        '
        'txtPL7_Points
        '
        Me.txtPL7_Points.Location = New System.Drawing.Point(345, 246)
        Me.txtPL7_Points.Name = "txtPL7_Points"
        Me.txtPL7_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL7_Points.TabIndex = 46
        '
        'lblPL_7
        '
        Me.lblPL_7.AutoSize = True
        Me.lblPL_7.Location = New System.Drawing.Point(14, 249)
        Me.lblPL_7.Name = "lblPL_7"
        Me.lblPL_7.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_7.TabIndex = 45
        Me.lblPL_7.Text = "7:"
        '
        'txtPL7_Answer
        '
        Me.txtPL7_Answer.Location = New System.Drawing.Point(287, 246)
        Me.txtPL7_Answer.Name = "txtPL7_Answer"
        Me.txtPL7_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL7_Answer.TabIndex = 44
        '
        'txtPL7_Name
        '
        Me.txtPL7_Name.Location = New System.Drawing.Point(36, 246)
        Me.txtPL7_Name.Name = "txtPL7_Name"
        Me.txtPL7_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL7_Name.TabIndex = 43
        Me.txtPL7_Name.Text = "Player 7"
        '
        'txtPL8_Points
        '
        Me.txtPL8_Points.Location = New System.Drawing.Point(345, 272)
        Me.txtPL8_Points.Name = "txtPL8_Points"
        Me.txtPL8_Points.Size = New System.Drawing.Size(52, 20)
        Me.txtPL8_Points.TabIndex = 50
        '
        'lblPL_8
        '
        Me.lblPL_8.AutoSize = True
        Me.lblPL_8.Location = New System.Drawing.Point(14, 275)
        Me.lblPL_8.Name = "lblPL_8"
        Me.lblPL_8.Size = New System.Drawing.Size(16, 13)
        Me.lblPL_8.TabIndex = 49
        Me.lblPL_8.Text = "8:"
        '
        'txtPL8_Answer
        '
        Me.txtPL8_Answer.Location = New System.Drawing.Point(287, 272)
        Me.txtPL8_Answer.Name = "txtPL8_Answer"
        Me.txtPL8_Answer.Size = New System.Drawing.Size(52, 20)
        Me.txtPL8_Answer.TabIndex = 48
        '
        'txtPL8_Name
        '
        Me.txtPL8_Name.Location = New System.Drawing.Point(36, 272)
        Me.txtPL8_Name.Name = "txtPL8_Name"
        Me.txtPL8_Name.Size = New System.Drawing.Size(245, 20)
        Me.txtPL8_Name.TabIndex = 47
        Me.txtPL8_Name.Text = "Player 8"
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(368, 14)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.ReadOnly = True
        Me.lblAnswer.Size = New System.Drawing.Size(29, 20)
        Me.lblAnswer.TabIndex = 51
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 358)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtPL8_Points)
        Me.Controls.Add(Me.lblPL_8)
        Me.Controls.Add(Me.txtPL8_Answer)
        Me.Controls.Add(Me.txtPL8_Name)
        Me.Controls.Add(Me.txtPL7_Points)
        Me.Controls.Add(Me.lblPL_7)
        Me.Controls.Add(Me.txtPL7_Answer)
        Me.Controls.Add(Me.txtPL7_Name)
        Me.Controls.Add(Me.txtPL6_Points)
        Me.Controls.Add(Me.lblPL_6)
        Me.Controls.Add(Me.txtPL6_Answer)
        Me.Controls.Add(Me.txtPL6_Name)
        Me.Controls.Add(Me.txtPL5_Points)
        Me.Controls.Add(Me.lblPL_5)
        Me.Controls.Add(Me.txtPL5_Answer)
        Me.Controls.Add(Me.txtPL5_Name)
        Me.Controls.Add(Me.lblPL_Points)
        Me.Controls.Add(Me.txtPL4_Points)
        Me.Controls.Add(Me.txtPL3_Points)
        Me.Controls.Add(Me.txtPL2_Points)
        Me.Controls.Add(Me.txtPL1_Points)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnShowCorrectPlayers)
        Me.Controls.Add(Me.btnReveal)
        Me.Controls.Add(Me.btnStartTime)
        Me.Controls.Add(Me.btnGenQuestion)
        Me.Controls.Add(Me.lblPL_4)
        Me.Controls.Add(Me.lblPL_3)
        Me.Controls.Add(Me.lblPL_2)
        Me.Controls.Add(Me.lblPL_1)
        Me.Controls.Add(Me.lblPL_Answer)
        Me.Controls.Add(Me.lblPL_Player)
        Me.Controls.Add(Me.txtPL4_Answer)
        Me.Controls.Add(Me.txtPL4_Name)
        Me.Controls.Add(Me.txtPL3_Answer)
        Me.Controls.Add(Me.txtPL3_Name)
        Me.Controls.Add(Me.txtPL2_Answer)
        Me.Controls.Add(Me.txtPL2_Name)
        Me.Controls.Add(Me.txtPL1_Answer)
        Me.Controls.Add(Me.txtPL1_Name)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.btnStopServer)
        Me.Controls.Add(Me.btnStartServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Server"
        Me.Text = "Vlugge Ronde - Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartServer As Button
    Friend WithEvents btnStopServer As Button
    Friend WithEvents txtSend As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtReceive As TextBox
    Friend WithEvents txtPL1_Name As TextBox
    Friend WithEvents txtPL1_Answer As TextBox
    Friend WithEvents txtPL2_Answer As TextBox
    Friend WithEvents txtPL2_Name As TextBox
    Friend WithEvents txtPL3_Answer As TextBox
    Friend WithEvents txtPL3_Name As TextBox
    Friend WithEvents txtPL4_Answer As TextBox
    Friend WithEvents txtPL4_Name As TextBox
    Friend WithEvents lblPL_Player As Label
    Friend WithEvents lblPL_Answer As Label
    Friend WithEvents lblPL_1 As Label
    Friend WithEvents lblPL_2 As Label
    Friend WithEvents lblPL_3 As Label
    Friend WithEvents lblPL_4 As Label
    Friend WithEvents btnGenQuestion As Button
    Friend WithEvents btnStartTime As Button
    Friend WithEvents btnReveal As Button
    Friend WithEvents btnShowCorrectPlayers As Button
    Friend WithEvents tmrStopSnd1 As Timer
    Friend WithEvents tmrThink As Timer
    Friend WithEvents lblPoints As Label
    Friend WithEvents tmrPoints As Timer
    Friend WithEvents txtPL4_Points As TextBox
    Friend WithEvents txtPL3_Points As TextBox
    Friend WithEvents txtPL2_Points As TextBox
    Friend WithEvents txtPL1_Points As TextBox
    Friend WithEvents lblPL_Points As Label
    Friend WithEvents tmrRevealPlayers As Timer
    Friend WithEvents tmrFastestPlayer As Timer
    Friend WithEvents txtPL5_Name As TextBox
    Friend WithEvents txtPL5_Answer As TextBox
    Friend WithEvents lblPL_5 As Label
    Friend WithEvents txtPL5_Points As TextBox
    Friend WithEvents txtPL6_Points As TextBox
    Friend WithEvents lblPL_6 As Label
    Friend WithEvents txtPL6_Answer As TextBox
    Friend WithEvents txtPL6_Name As TextBox
    Friend WithEvents txtPL7_Points As TextBox
    Friend WithEvents lblPL_7 As Label
    Friend WithEvents txtPL7_Answer As TextBox
    Friend WithEvents txtPL7_Name As TextBox
    Friend WithEvents txtPL8_Points As TextBox
    Friend WithEvents lblPL_8 As Label
    Friend WithEvents txtPL8_Answer As TextBox
    Friend WithEvents txtPL8_Name As TextBox
    Friend WithEvents lblAnswer As TextBox
End Class
