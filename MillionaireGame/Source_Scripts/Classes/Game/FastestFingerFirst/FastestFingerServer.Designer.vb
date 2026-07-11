<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FastestFingerServer
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlblLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnPlayQuestion = New System.Windows.Forms.Button()
        Me.btnStartTImerShowAnswers = New System.Windows.Forms.Button()
        Me.btnStopTimerLockAnswers = New System.Windows.Forms.Button()
        Me.btnClearReset = New System.Windows.Forms.Button()
        Me.lstLogging = New System.Windows.Forms.ListBox()
        Me.tmrPlayAfterThreeNotes = New System.Windows.Forms.Timer(Me.components)
        Me.tmrThinking = New System.Windows.Forms.Timer(Me.components)
        Me.lstWaiting = New System.Windows.Forms.ListBox()
        Me.txtSlot1 = New System.Windows.Forms.TextBox()
        Me.txtSlot2 = New System.Windows.Forms.TextBox()
        Me.txtSlot3 = New System.Windows.Forms.TextBox()
        Me.txtSlot4 = New System.Windows.Forms.TextBox()
        Me.txtSlot5 = New System.Windows.Forms.TextBox()
        Me.txtSlot6 = New System.Windows.Forms.TextBox()
        Me.txtSlot7 = New System.Windows.Forms.TextBox()
        Me.btnAssign1 = New System.Windows.Forms.Button()
        Me.btnAssign2 = New System.Windows.Forms.Button()
        Me.btnAssign3 = New System.Windows.Forms.Button()
        Me.btnAssign4 = New System.Windows.Forms.Button()
        Me.btnAssign5 = New System.Windows.Forms.Button()
        Me.btnAssign6 = New System.Windows.Forms.Button()
        Me.btnAssign7 = New System.Windows.Forms.Button()
        Me.btnClear7 = New System.Windows.Forms.Button()
        Me.btnClear6 = New System.Windows.Forms.Button()
        Me.btnClear5 = New System.Windows.Forms.Button()
        Me.btnClear4 = New System.Windows.Forms.Button()
        Me.btnClear3 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.btnClear8 = New System.Windows.Forms.Button()
        Me.btnAssign8 = New System.Windows.Forms.Button()
        Me.txtSlot8 = New System.Windows.Forms.TextBox()
        Me.btnForce1 = New System.Windows.Forms.Button()
        Me.btnForce2 = New System.Windows.Forms.Button()
        Me.btnForce3 = New System.Windows.Forms.Button()
        Me.btnForce4 = New System.Windows.Forms.Button()
        Me.btnForce5 = New System.Windows.Forms.Button()
        Me.btnForce6 = New System.Windows.Forms.Button()
        Me.btnForce7 = New System.Windows.Forms.Button()
        Me.btnForce8 = New System.Windows.Forms.Button()
        Me.txtAnswer1 = New System.Windows.Forms.TextBox()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer3 = New System.Windows.Forms.TextBox()
        Me.txtAnswer4 = New System.Windows.Forms.TextBox()
        Me.txtAnswer5 = New System.Windows.Forms.TextBox()
        Me.txtAnswer6 = New System.Windows.Forms.TextBox()
        Me.txtAnswer7 = New System.Windows.Forms.TextBox()
        Me.txtAnswer8 = New System.Windows.Forms.TextBox()
        Me.txtTime8 = New System.Windows.Forms.TextBox()
        Me.txtTime7 = New System.Windows.Forms.TextBox()
        Me.txtTime6 = New System.Windows.Forms.TextBox()
        Me.txtTime5 = New System.Windows.Forms.TextBox()
        Me.txtTime4 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnCorrectOrderSequence = New System.Windows.Forms.Button()
        Me.btnWhoWasCorrect = New System.Windows.Forms.Button()
        Me.tmrShowCorrectPlayersOnList = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShowFastestPlayerOnList = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlblLabelStatus, Me.tlblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1013, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlblLabelStatus
        '
        Me.tlblLabelStatus.Name = "tlblLabelStatus"
        Me.tlblLabelStatus.Size = New System.Drawing.Size(42, 17)
        Me.tlblLabelStatus.Text = "Status:"
        '
        'tlblStatus
        '
        Me.tlblStatus.Name = "tlblStatus"
        Me.tlblStatus.Size = New System.Drawing.Size(23, 17)
        Me.tlblStatus.Text = "<>"
        '
        'btnPlayQuestion
        '
        Me.btnPlayQuestion.Location = New System.Drawing.Point(12, 74)
        Me.btnPlayQuestion.Name = "btnPlayQuestion"
        Me.btnPlayQuestion.Size = New System.Drawing.Size(219, 33)
        Me.btnPlayQuestion.TabIndex = 1
        Me.btnPlayQuestion.Text = "Play Question"
        Me.btnPlayQuestion.UseVisualStyleBackColor = True
        '
        'btnStartTImerShowAnswers
        '
        Me.btnStartTImerShowAnswers.Location = New System.Drawing.Point(12, 113)
        Me.btnStartTImerShowAnswers.Name = "btnStartTImerShowAnswers"
        Me.btnStartTImerShowAnswers.Size = New System.Drawing.Size(219, 33)
        Me.btnStartTImerShowAnswers.TabIndex = 2
        Me.btnStartTImerShowAnswers.Text = "Start Timer + Show Answers"
        Me.btnStartTImerShowAnswers.UseVisualStyleBackColor = True
        '
        'btnStopTimerLockAnswers
        '
        Me.btnStopTimerLockAnswers.Location = New System.Drawing.Point(12, 152)
        Me.btnStopTimerLockAnswers.Name = "btnStopTimerLockAnswers"
        Me.btnStopTimerLockAnswers.Size = New System.Drawing.Size(219, 33)
        Me.btnStopTimerLockAnswers.TabIndex = 3
        Me.btnStopTimerLockAnswers.Text = "Stop Timer + Lock Answers"
        Me.btnStopTimerLockAnswers.UseVisualStyleBackColor = True
        '
        'btnClearReset
        '
        Me.btnClearReset.Location = New System.Drawing.Point(12, 22)
        Me.btnClearReset.Name = "btnClearReset"
        Me.btnClearReset.Size = New System.Drawing.Size(219, 33)
        Me.btnClearReset.TabIndex = 4
        Me.btnClearReset.Text = "Clear / Reset"
        Me.btnClearReset.UseVisualStyleBackColor = True
        '
        'lstLogging
        '
        Me.lstLogging.FormattingEnabled = True
        Me.lstLogging.Location = New System.Drawing.Point(675, 242)
        Me.lstLogging.Name = "lstLogging"
        Me.lstLogging.Size = New System.Drawing.Size(309, 121)
        Me.lstLogging.TabIndex = 5
        '
        'tmrPlayAfterThreeNotes
        '
        Me.tmrPlayAfterThreeNotes.Interval = 1000
        '
        'tmrThinking
        '
        Me.tmrThinking.Interval = 1000
        '
        'lstWaiting
        '
        Me.lstWaiting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstWaiting.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.ItemHeight = 23
        Me.lstWaiting.Location = New System.Drawing.Point(237, 23)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(195, 232)
        Me.lstWaiting.TabIndex = 6
        '
        'txtSlot1
        '
        Me.txtSlot1.Location = New System.Drawing.Point(675, 35)
        Me.txtSlot1.Name = "txtSlot1"
        Me.txtSlot1.ReadOnly = True
        Me.txtSlot1.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot1.TabIndex = 7
        '
        'txtSlot2
        '
        Me.txtSlot2.Location = New System.Drawing.Point(675, 61)
        Me.txtSlot2.Name = "txtSlot2"
        Me.txtSlot2.ReadOnly = True
        Me.txtSlot2.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot2.TabIndex = 8
        '
        'txtSlot3
        '
        Me.txtSlot3.Location = New System.Drawing.Point(675, 87)
        Me.txtSlot3.Name = "txtSlot3"
        Me.txtSlot3.ReadOnly = True
        Me.txtSlot3.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot3.TabIndex = 9
        '
        'txtSlot4
        '
        Me.txtSlot4.Location = New System.Drawing.Point(675, 113)
        Me.txtSlot4.Name = "txtSlot4"
        Me.txtSlot4.ReadOnly = True
        Me.txtSlot4.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot4.TabIndex = 10
        '
        'txtSlot5
        '
        Me.txtSlot5.Location = New System.Drawing.Point(675, 139)
        Me.txtSlot5.Name = "txtSlot5"
        Me.txtSlot5.ReadOnly = True
        Me.txtSlot5.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot5.TabIndex = 11
        '
        'txtSlot6
        '
        Me.txtSlot6.Location = New System.Drawing.Point(675, 165)
        Me.txtSlot6.Name = "txtSlot6"
        Me.txtSlot6.ReadOnly = True
        Me.txtSlot6.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot6.TabIndex = 12
        '
        'txtSlot7
        '
        Me.txtSlot7.Location = New System.Drawing.Point(675, 191)
        Me.txtSlot7.Name = "txtSlot7"
        Me.txtSlot7.ReadOnly = True
        Me.txtSlot7.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot7.TabIndex = 13
        '
        'btnAssign1
        '
        Me.btnAssign1.Location = New System.Drawing.Point(437, 33)
        Me.btnAssign1.Name = "btnAssign1"
        Me.btnAssign1.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign1.TabIndex = 14
        Me.btnAssign1.Text = "Assign"
        Me.btnAssign1.UseVisualStyleBackColor = True
        '
        'btnAssign2
        '
        Me.btnAssign2.Location = New System.Drawing.Point(437, 59)
        Me.btnAssign2.Name = "btnAssign2"
        Me.btnAssign2.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign2.TabIndex = 15
        Me.btnAssign2.Text = "Assign"
        Me.btnAssign2.UseVisualStyleBackColor = True
        '
        'btnAssign3
        '
        Me.btnAssign3.Location = New System.Drawing.Point(437, 85)
        Me.btnAssign3.Name = "btnAssign3"
        Me.btnAssign3.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign3.TabIndex = 16
        Me.btnAssign3.Text = "Assign"
        Me.btnAssign3.UseVisualStyleBackColor = True
        '
        'btnAssign4
        '
        Me.btnAssign4.Location = New System.Drawing.Point(437, 111)
        Me.btnAssign4.Name = "btnAssign4"
        Me.btnAssign4.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign4.TabIndex = 17
        Me.btnAssign4.Text = "Assign"
        Me.btnAssign4.UseVisualStyleBackColor = True
        '
        'btnAssign5
        '
        Me.btnAssign5.Location = New System.Drawing.Point(437, 137)
        Me.btnAssign5.Name = "btnAssign5"
        Me.btnAssign5.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign5.TabIndex = 18
        Me.btnAssign5.Text = "Assign"
        Me.btnAssign5.UseVisualStyleBackColor = True
        '
        'btnAssign6
        '
        Me.btnAssign6.Location = New System.Drawing.Point(437, 163)
        Me.btnAssign6.Name = "btnAssign6"
        Me.btnAssign6.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign6.TabIndex = 19
        Me.btnAssign6.Text = "Assign"
        Me.btnAssign6.UseVisualStyleBackColor = True
        '
        'btnAssign7
        '
        Me.btnAssign7.Location = New System.Drawing.Point(437, 189)
        Me.btnAssign7.Name = "btnAssign7"
        Me.btnAssign7.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign7.TabIndex = 20
        Me.btnAssign7.Text = "Assign"
        Me.btnAssign7.UseVisualStyleBackColor = True
        '
        'btnClear7
        '
        Me.btnClear7.Location = New System.Drawing.Point(513, 189)
        Me.btnClear7.Name = "btnClear7"
        Me.btnClear7.Size = New System.Drawing.Size(75, 23)
        Me.btnClear7.TabIndex = 27
        Me.btnClear7.Text = "Unassign"
        Me.btnClear7.UseVisualStyleBackColor = True
        '
        'btnClear6
        '
        Me.btnClear6.Location = New System.Drawing.Point(513, 163)
        Me.btnClear6.Name = "btnClear6"
        Me.btnClear6.Size = New System.Drawing.Size(75, 23)
        Me.btnClear6.TabIndex = 26
        Me.btnClear6.Text = "Unassign"
        Me.btnClear6.UseVisualStyleBackColor = True
        '
        'btnClear5
        '
        Me.btnClear5.Location = New System.Drawing.Point(513, 137)
        Me.btnClear5.Name = "btnClear5"
        Me.btnClear5.Size = New System.Drawing.Size(75, 23)
        Me.btnClear5.TabIndex = 25
        Me.btnClear5.Text = "Unassign"
        Me.btnClear5.UseVisualStyleBackColor = True
        '
        'btnClear4
        '
        Me.btnClear4.Location = New System.Drawing.Point(513, 111)
        Me.btnClear4.Name = "btnClear4"
        Me.btnClear4.Size = New System.Drawing.Size(75, 23)
        Me.btnClear4.TabIndex = 24
        Me.btnClear4.Text = "Unassign"
        Me.btnClear4.UseVisualStyleBackColor = True
        '
        'btnClear3
        '
        Me.btnClear3.Location = New System.Drawing.Point(513, 85)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(75, 23)
        Me.btnClear3.TabIndex = 23
        Me.btnClear3.Text = "Unassign"
        Me.btnClear3.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.Location = New System.Drawing.Point(513, 59)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(75, 23)
        Me.btnClear2.TabIndex = 22
        Me.btnClear2.Text = "Unassign"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnClear1
        '
        Me.btnClear1.Location = New System.Drawing.Point(513, 33)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(75, 23)
        Me.btnClear1.TabIndex = 21
        Me.btnClear1.Text = "Unassign"
        Me.btnClear1.UseVisualStyleBackColor = True
        '
        'btnClear8
        '
        Me.btnClear8.Location = New System.Drawing.Point(513, 214)
        Me.btnClear8.Name = "btnClear8"
        Me.btnClear8.Size = New System.Drawing.Size(75, 23)
        Me.btnClear8.TabIndex = 30
        Me.btnClear8.Text = "Unassign"
        Me.btnClear8.UseVisualStyleBackColor = True
        '
        'btnAssign8
        '
        Me.btnAssign8.Location = New System.Drawing.Point(437, 214)
        Me.btnAssign8.Name = "btnAssign8"
        Me.btnAssign8.Size = New System.Drawing.Size(75, 23)
        Me.btnAssign8.TabIndex = 29
        Me.btnAssign8.Text = "Assign"
        Me.btnAssign8.UseVisualStyleBackColor = True
        '
        'txtSlot8
        '
        Me.txtSlot8.Location = New System.Drawing.Point(675, 216)
        Me.txtSlot8.Name = "txtSlot8"
        Me.txtSlot8.ReadOnly = True
        Me.txtSlot8.Size = New System.Drawing.Size(167, 20)
        Me.txtSlot8.TabIndex = 28
        '
        'btnForce1
        '
        Me.btnForce1.Location = New System.Drawing.Point(594, 33)
        Me.btnForce1.Name = "btnForce1"
        Me.btnForce1.Size = New System.Drawing.Size(75, 23)
        Me.btnForce1.TabIndex = 31
        Me.btnForce1.Text = "Force"
        Me.btnForce1.UseVisualStyleBackColor = True
        '
        'btnForce2
        '
        Me.btnForce2.Location = New System.Drawing.Point(594, 59)
        Me.btnForce2.Name = "btnForce2"
        Me.btnForce2.Size = New System.Drawing.Size(75, 23)
        Me.btnForce2.TabIndex = 32
        Me.btnForce2.Text = "Force"
        Me.btnForce2.UseVisualStyleBackColor = True
        '
        'btnForce3
        '
        Me.btnForce3.Location = New System.Drawing.Point(594, 85)
        Me.btnForce3.Name = "btnForce3"
        Me.btnForce3.Size = New System.Drawing.Size(75, 23)
        Me.btnForce3.TabIndex = 33
        Me.btnForce3.Text = "Force"
        Me.btnForce3.UseVisualStyleBackColor = True
        '
        'btnForce4
        '
        Me.btnForce4.Location = New System.Drawing.Point(594, 111)
        Me.btnForce4.Name = "btnForce4"
        Me.btnForce4.Size = New System.Drawing.Size(75, 23)
        Me.btnForce4.TabIndex = 34
        Me.btnForce4.Text = "Force"
        Me.btnForce4.UseVisualStyleBackColor = True
        '
        'btnForce5
        '
        Me.btnForce5.Location = New System.Drawing.Point(594, 137)
        Me.btnForce5.Name = "btnForce5"
        Me.btnForce5.Size = New System.Drawing.Size(75, 23)
        Me.btnForce5.TabIndex = 35
        Me.btnForce5.Text = "Force"
        Me.btnForce5.UseVisualStyleBackColor = True
        '
        'btnForce6
        '
        Me.btnForce6.Location = New System.Drawing.Point(594, 163)
        Me.btnForce6.Name = "btnForce6"
        Me.btnForce6.Size = New System.Drawing.Size(75, 23)
        Me.btnForce6.TabIndex = 36
        Me.btnForce6.Text = "Force"
        Me.btnForce6.UseVisualStyleBackColor = True
        '
        'btnForce7
        '
        Me.btnForce7.Location = New System.Drawing.Point(594, 189)
        Me.btnForce7.Name = "btnForce7"
        Me.btnForce7.Size = New System.Drawing.Size(75, 23)
        Me.btnForce7.TabIndex = 37
        Me.btnForce7.Text = "Force"
        Me.btnForce7.UseVisualStyleBackColor = True
        '
        'btnForce8
        '
        Me.btnForce8.Location = New System.Drawing.Point(594, 214)
        Me.btnForce8.Name = "btnForce8"
        Me.btnForce8.Size = New System.Drawing.Size(75, 23)
        Me.btnForce8.TabIndex = 38
        Me.btnForce8.Text = "Force"
        Me.btnForce8.UseVisualStyleBackColor = True
        '
        'txtAnswer1
        '
        Me.txtAnswer1.Location = New System.Drawing.Point(848, 35)
        Me.txtAnswer1.Name = "txtAnswer1"
        Me.txtAnswer1.ReadOnly = True
        Me.txtAnswer1.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer1.TabIndex = 39
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Location = New System.Drawing.Point(848, 61)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.ReadOnly = True
        Me.txtAnswer2.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer2.TabIndex = 40
        '
        'txtAnswer3
        '
        Me.txtAnswer3.Location = New System.Drawing.Point(848, 87)
        Me.txtAnswer3.Name = "txtAnswer3"
        Me.txtAnswer3.ReadOnly = True
        Me.txtAnswer3.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer3.TabIndex = 41
        '
        'txtAnswer4
        '
        Me.txtAnswer4.Location = New System.Drawing.Point(848, 113)
        Me.txtAnswer4.Name = "txtAnswer4"
        Me.txtAnswer4.ReadOnly = True
        Me.txtAnswer4.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer4.TabIndex = 42
        '
        'txtAnswer5
        '
        Me.txtAnswer5.Location = New System.Drawing.Point(848, 139)
        Me.txtAnswer5.Name = "txtAnswer5"
        Me.txtAnswer5.ReadOnly = True
        Me.txtAnswer5.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer5.TabIndex = 43
        '
        'txtAnswer6
        '
        Me.txtAnswer6.Location = New System.Drawing.Point(848, 165)
        Me.txtAnswer6.Name = "txtAnswer6"
        Me.txtAnswer6.ReadOnly = True
        Me.txtAnswer6.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer6.TabIndex = 44
        '
        'txtAnswer7
        '
        Me.txtAnswer7.Location = New System.Drawing.Point(848, 191)
        Me.txtAnswer7.Name = "txtAnswer7"
        Me.txtAnswer7.ReadOnly = True
        Me.txtAnswer7.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer7.TabIndex = 45
        '
        'txtAnswer8
        '
        Me.txtAnswer8.Location = New System.Drawing.Point(848, 216)
        Me.txtAnswer8.Name = "txtAnswer8"
        Me.txtAnswer8.ReadOnly = True
        Me.txtAnswer8.Size = New System.Drawing.Size(65, 20)
        Me.txtAnswer8.TabIndex = 46
        '
        'txtTime8
        '
        Me.txtTime8.Location = New System.Drawing.Point(919, 216)
        Me.txtTime8.Name = "txtTime8"
        Me.txtTime8.ReadOnly = True
        Me.txtTime8.Size = New System.Drawing.Size(65, 20)
        Me.txtTime8.TabIndex = 54
        '
        'txtTime7
        '
        Me.txtTime7.Location = New System.Drawing.Point(919, 191)
        Me.txtTime7.Name = "txtTime7"
        Me.txtTime7.ReadOnly = True
        Me.txtTime7.Size = New System.Drawing.Size(65, 20)
        Me.txtTime7.TabIndex = 53
        '
        'txtTime6
        '
        Me.txtTime6.Location = New System.Drawing.Point(919, 165)
        Me.txtTime6.Name = "txtTime6"
        Me.txtTime6.ReadOnly = True
        Me.txtTime6.Size = New System.Drawing.Size(65, 20)
        Me.txtTime6.TabIndex = 52
        '
        'txtTime5
        '
        Me.txtTime5.Location = New System.Drawing.Point(919, 139)
        Me.txtTime5.Name = "txtTime5"
        Me.txtTime5.ReadOnly = True
        Me.txtTime5.Size = New System.Drawing.Size(65, 20)
        Me.txtTime5.TabIndex = 51
        '
        'txtTime4
        '
        Me.txtTime4.Location = New System.Drawing.Point(919, 113)
        Me.txtTime4.Name = "txtTime4"
        Me.txtTime4.ReadOnly = True
        Me.txtTime4.Size = New System.Drawing.Size(65, 20)
        Me.txtTime4.TabIndex = 50
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(919, 87)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.ReadOnly = True
        Me.txtTime3.Size = New System.Drawing.Size(65, 20)
        Me.txtTime3.TabIndex = 49
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(919, 61)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.ReadOnly = True
        Me.txtTime2.Size = New System.Drawing.Size(65, 20)
        Me.txtTime2.TabIndex = 48
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(919, 35)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.ReadOnly = True
        Me.txtTime1.Size = New System.Drawing.Size(65, 20)
        Me.txtTime1.TabIndex = 47
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(9, 350)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(53, 13)
        Me.lblWinner.TabIndex = 55
        Me.lblWinner.Text = "Winner = "
        '
        'btnCorrectOrderSequence
        '
        Me.btnCorrectOrderSequence.Location = New System.Drawing.Point(12, 214)
        Me.btnCorrectOrderSequence.Name = "btnCorrectOrderSequence"
        Me.btnCorrectOrderSequence.Size = New System.Drawing.Size(219, 33)
        Me.btnCorrectOrderSequence.TabIndex = 56
        Me.btnCorrectOrderSequence.Text = "Correct Order Sequence"
        Me.btnCorrectOrderSequence.UseVisualStyleBackColor = True
        '
        'btnWhoWasCorrect
        '
        Me.btnWhoWasCorrect.Location = New System.Drawing.Point(12, 253)
        Me.btnWhoWasCorrect.Name = "btnWhoWasCorrect"
        Me.btnWhoWasCorrect.Size = New System.Drawing.Size(219, 33)
        Me.btnWhoWasCorrect.TabIndex = 57
        Me.btnWhoWasCorrect.Text = "Who Whas Correct?"
        Me.btnWhoWasCorrect.UseVisualStyleBackColor = True
        '
        'tmrShowCorrectPlayersOnList
        '
        Me.tmrShowCorrectPlayersOnList.Interval = 200
        '
        'tmrShowFastestPlayerOnList
        '
        Me.tmrShowFastestPlayerOnList.Interval = 350
        '
        'FastestFingerServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 390)
        Me.Controls.Add(Me.btnWhoWasCorrect)
        Me.Controls.Add(Me.btnCorrectOrderSequence)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.txtTime8)
        Me.Controls.Add(Me.txtTime7)
        Me.Controls.Add(Me.txtTime6)
        Me.Controls.Add(Me.txtTime5)
        Me.Controls.Add(Me.txtTime4)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtAnswer8)
        Me.Controls.Add(Me.txtAnswer7)
        Me.Controls.Add(Me.txtAnswer6)
        Me.Controls.Add(Me.txtAnswer5)
        Me.Controls.Add(Me.txtAnswer4)
        Me.Controls.Add(Me.txtAnswer3)
        Me.Controls.Add(Me.txtAnswer2)
        Me.Controls.Add(Me.txtAnswer1)
        Me.Controls.Add(Me.btnForce8)
        Me.Controls.Add(Me.btnForce7)
        Me.Controls.Add(Me.btnForce6)
        Me.Controls.Add(Me.btnForce5)
        Me.Controls.Add(Me.btnForce4)
        Me.Controls.Add(Me.btnForce3)
        Me.Controls.Add(Me.btnForce2)
        Me.Controls.Add(Me.btnForce1)
        Me.Controls.Add(Me.btnClear8)
        Me.Controls.Add(Me.btnAssign8)
        Me.Controls.Add(Me.txtSlot8)
        Me.Controls.Add(Me.btnClear7)
        Me.Controls.Add(Me.btnClear6)
        Me.Controls.Add(Me.btnClear5)
        Me.Controls.Add(Me.btnClear4)
        Me.Controls.Add(Me.btnClear3)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnClear1)
        Me.Controls.Add(Me.btnAssign7)
        Me.Controls.Add(Me.btnAssign6)
        Me.Controls.Add(Me.btnAssign5)
        Me.Controls.Add(Me.btnAssign4)
        Me.Controls.Add(Me.btnAssign3)
        Me.Controls.Add(Me.btnAssign2)
        Me.Controls.Add(Me.btnAssign1)
        Me.Controls.Add(Me.txtSlot7)
        Me.Controls.Add(Me.txtSlot6)
        Me.Controls.Add(Me.txtSlot5)
        Me.Controls.Add(Me.txtSlot4)
        Me.Controls.Add(Me.txtSlot3)
        Me.Controls.Add(Me.txtSlot2)
        Me.Controls.Add(Me.txtSlot1)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.lstLogging)
        Me.Controls.Add(Me.btnClearReset)
        Me.Controls.Add(Me.btnStopTimerLockAnswers)
        Me.Controls.Add(Me.btnStartTImerShowAnswers)
        Me.Controls.Add(Me.btnPlayQuestion)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FastestFingerServer"
        Me.Text = "FastestFingerServer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnPlayQuestion As Button
    Friend WithEvents btnStartTImerShowAnswers As Button
    Friend WithEvents btnStopTimerLockAnswers As Button
    Friend WithEvents btnClearReset As Button
    Friend WithEvents lstLogging As ListBox
    Friend WithEvents tlblLabelStatus As ToolStripStatusLabel
    Friend WithEvents tlblStatus As ToolStripStatusLabel
    Friend WithEvents tmrPlayAfterThreeNotes As Timer
    Friend WithEvents tmrThinking As Timer
    Friend WithEvents lstWaiting As ListBox
    Friend WithEvents txtSlot1 As TextBox
    Friend WithEvents txtSlot2 As TextBox
    Friend WithEvents txtSlot3 As TextBox
    Friend WithEvents txtSlot4 As TextBox
    Friend WithEvents txtSlot5 As TextBox
    Friend WithEvents txtSlot6 As TextBox
    Friend WithEvents txtSlot7 As TextBox
    Friend WithEvents btnAssign1 As Button
    Friend WithEvents btnAssign2 As Button
    Friend WithEvents btnAssign3 As Button
    Friend WithEvents btnAssign4 As Button
    Friend WithEvents btnAssign5 As Button
    Friend WithEvents btnAssign6 As Button
    Friend WithEvents btnAssign7 As Button
    Friend WithEvents btnClear7 As Button
    Friend WithEvents btnClear6 As Button
    Friend WithEvents btnClear5 As Button
    Friend WithEvents btnClear4 As Button
    Friend WithEvents btnClear3 As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnClear1 As Button
    Friend WithEvents btnClear8 As Button
    Friend WithEvents btnAssign8 As Button
    Friend WithEvents txtSlot8 As TextBox
    Friend WithEvents btnForce1 As Button
    Friend WithEvents btnForce2 As Button
    Friend WithEvents btnForce3 As Button
    Friend WithEvents btnForce4 As Button
    Friend WithEvents btnForce5 As Button
    Friend WithEvents btnForce6 As Button
    Friend WithEvents btnForce7 As Button
    Friend WithEvents btnForce8 As Button
    Friend WithEvents txtAnswer1 As TextBox
    Friend WithEvents txtAnswer2 As TextBox
    Friend WithEvents txtAnswer3 As TextBox
    Friend WithEvents txtAnswer4 As TextBox
    Friend WithEvents txtAnswer5 As TextBox
    Friend WithEvents txtAnswer6 As TextBox
    Friend WithEvents txtAnswer7 As TextBox
    Friend WithEvents txtAnswer8 As TextBox
    Friend WithEvents txtTime8 As TextBox
    Friend WithEvents txtTime7 As TextBox
    Friend WithEvents txtTime6 As TextBox
    Friend WithEvents txtTime5 As TextBox
    Friend WithEvents txtTime4 As TextBox
    Friend WithEvents txtTime3 As TextBox
    Friend WithEvents txtTime2 As TextBox
    Friend WithEvents txtTime1 As TextBox
    Friend WithEvents lblWinner As Label
    Friend WithEvents btnCorrectOrderSequence As Button
    Friend WithEvents btnWhoWasCorrect As Button
    Friend WithEvents tmrShowCorrectPlayersOnList As Timer
    Friend WithEvents tmrShowFastestPlayerOnList As Timer
End Class
