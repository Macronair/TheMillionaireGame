Public Class correct

    Dim controlp As ControlPanel
    Dim options As New Game

    Public Sub correctRun()
        If ControlPanel.answer = "A" Then
            ControlPanel.txtA.BackColor = Color.Green
            HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            HostScreen.txtA.ForeColor = Color.Black
            GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            GuestScreen.txtA.ForeColor = Color.Black
        End If
        If ControlPanel.answer = "B" Then
            ControlPanel.txtB.BackColor = Color.Green
            HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            HostScreen.txtB.ForeColor = Color.Black
            GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            GuestScreen.txtB.ForeColor = Color.Black
        End If
        If ControlPanel.answer = "C" Then
            HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            HostScreen.txtC.ForeColor = Color.Black
            GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            GuestScreen.txtC.ForeColor = Color.Black
            ControlPanel.txtC.BackColor = Color.Green
        End If
        If ControlPanel.answer = "D" Then
            HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            HostScreen.txtD.ForeColor = Color.Black
            GuestScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            GuestScreen.txtD.ForeColor = Color.Black
            ControlPanel.txtD.BackColor = Color.Green
        End If
        If ControlPanel.walkaway = False Then
            If Game.level = 0 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(12, False, 700)
                End With
            End If
            If Game.level = 1 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(12, False, 700)
                End With
            End If
            If Game.level = 2 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(12, False, 700)
                End With
            End If
            If Game.level = 3 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(12, False, 700)
                End With
            End If
            If Game.level = 4 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(18, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 5 Then
                My.Computer.Audio.Play(My.Resources.q6_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 6 Then
                My.Computer.Audio.Play(My.Resources.q7_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 7 Then
                My.Computer.Audio.Play(My.Resources.q8_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 8 Then
                My.Computer.Audio.Play(My.Resources.q9_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 9 Then
                Select Case Game.gamemode
                    Case 0
                        My.Computer.Audio.Play(My.Resources.q10_correct, AudioPlayMode.Background)
                    Case 1
                        My.Computer.Audio.Play(My.Resources.q10_correct_2, AudioPlayMode.Background)
                End Select

                ControlPanel.Timer2.Start()
            End If
            If Game.level = 10 Then
                My.Computer.Audio.Play(My.Resources.q11_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 11 Then
                My.Computer.Audio.Play(My.Resources.q12_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 12 Then
                My.Computer.Audio.Play(My.Resources.q13_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 13 Then
                My.Computer.Audio.Play(My.Resources.q14_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 14 Then
                My.Computer.Audio.Play(My.Resources.q15_correct, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
                HostScreen.txtWinnings.Text = "Total Score: " + Game.varCorrect
            End If
        End If

        TVControlPnl.grpATA.Visible = False

        If Game.level >= 15 Then

        Else
            Game.level = Game.level + 1
            Game.ChangeLevel(Game.level)
            ControlPanel.txtCorrect.Text = Game.varCorrect
            ControlPanel.txtCurrent.Text = Game.varCurrent
            ControlPanel.txtDrop.Text = Game.varDrop
            ControlPanel.txtQLeft.Text = Game.varQLeft
            ControlPanel.txtWrong.Text = Game.varWrong
            HostScreen.lblCorrect.Text = Game.varCorrect
            HostScreen.lblCurrent.Text = Game.varCurrent
            HostScreen.lblDrop.Text = Game.varDrop
            HostScreen.lblQLeft.Text = Game.varQLeft
            HostScreen.lblWrong.Text = Game.varWrong
            Question.act = 0
        End If
    End Sub
    Public Sub wrongRun()
        If ControlPanel.lblAnswer.Text = "A" Then
            HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            HostScreen.txtA.ForeColor = Color.Black
            GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            GuestScreen.txtA.ForeColor = Color.Black
            ControlPanel.txtA.BackColor = Color.Green
        End If
        If ControlPanel.lblAnswer.Text = "B" Then
            HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            HostScreen.txtB.ForeColor = Color.Black
            GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            GuestScreen.txtB.ForeColor = Color.Black
            ControlPanel.txtB.BackColor = Color.Green
        End If
        If ControlPanel.lblAnswer.Text = "C" Then
            HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            HostScreen.txtC.ForeColor = Color.Black
            GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            GuestScreen.txtC.ForeColor = Color.Black
            ControlPanel.txtC.BackColor = Color.Green
        End If
        If ControlPanel.lblAnswer.Text = "D" Then
            HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            HostScreen.txtC.ForeColor = Color.Black
            GuestScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            GuestScreen.txtD.ForeColor = Color.Black
            ControlPanel.txtD.BackColor = Color.Green
        End If
        If ControlPanel.walkaway = False Then
            If Game.level = 0 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(19, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 1 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(19, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 2 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(19, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 3 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(19, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 4 Then
                ControlPanel.intSound += 1

                With ControlPanel.snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(19, False, 700)
                End With
                ControlPanel.Timer1.Start()
            End If
            If Game.level = 5 Then
                My.Computer.Audio.Play(My.Resources.q6_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 6 Then
                My.Computer.Audio.Play(My.Resources.q7_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 7 Then
                My.Computer.Audio.Play(My.Resources.q8_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 8 Then
                My.Computer.Audio.Play(My.Resources.q9_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 9 Then
                My.Computer.Audio.Play(My.Resources.q10_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 10 Then
                My.Computer.Audio.Play(My.Resources.q11_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 11 Then
                My.Computer.Audio.Play(My.Resources.q12_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 12 Then
                My.Computer.Audio.Play(My.Resources.q13_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 13 Then
                My.Computer.Audio.Play(My.Resources.q14_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            If Game.level = 14 Then
                My.Computer.Audio.Play(My.Resources.q15_lose, AudioPlayMode.Background)
                ControlPanel.Timer2.Start()
            End If
            TVControlPnl.lblAmount.Text = "" & Game.varWrong
            HostScreen.txtWinnings.Text = "Total Score: " + Game.varWrong
        Else
            ControlPanel.Timer2.Start()
            TVControlPnl.lblAmount.Text = "" & Game.varCurrent
        End If

    End Sub
End Class
