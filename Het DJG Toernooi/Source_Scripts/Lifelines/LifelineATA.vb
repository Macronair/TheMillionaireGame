Public Class LifelineATA
    Dim snd As New SOUND
    Dim act As Integer = 0
    Dim amountA As Integer
    Dim amountB As Integer
    Dim amountC As Integer
    Dim amountD As Integer
    Dim perA As String
    Dim perB As String
    Dim perC As String
    Dim perD As String
    Dim amountTotal As Integer


    Public Sub LifelineUse1()
        Select Case act
            Case 0
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_Start
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("question", 100))
                stopaudio.Start()

                Question.useMusic = False
                HostScreen.lblVoteUsed.ForeColor = Color.Cyan
                act = 1
            Case 1
                With Sounds.sndLifeline2
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_Voting
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("lifeline1", 100))
                stopaudio.Start()

                act = 2
                TVControlPnl.tmrRandomizer.Start()
                TVControlPnl.grpATA.Visible = True
                Dim random As New Random()
                If Game.level < 5 Then
                    If ControlPanel.lblAnswer.Text = "A" Then
                        amountA = random.Next(40, 60)
                        amountB = random.Next(1, 10)
                        amountC = random.Next(1, 10)
                        amountD = random.Next(1, 10)
                    ElseIf ControlPanel.lblAnswer.Text = "B" Then
                        amountB = random.Next(40, 60)
                        amountC = random.Next(1, 10)
                        amountD = random.Next(1, 10)
                        amountA = random.Next(1, 10)
                    ElseIf ControlPanel.lblAnswer.Text = "C" Then
                        amountC = random.Next(40, 60)
                        amountD = random.Next(1, 10)
                        amountA = random.Next(1, 10)
                        amountB = random.Next(1, 10)
                    ElseIf ControlPanel.lblAnswer.Text = "D" Then
                        amountD = random.Next(40, 60)
                        amountA = random.Next(1, 10)
                        amountB = random.Next(1, 10)
                        amountC = random.Next(1, 10)
                    End If
                ElseIf Game.level >= 5 And Game.level <= 9 Then
                    If ControlPanel.lblAnswer.Text = "A" Then
                        amountA = random.Next(20, 60)
                        amountB = random.Next(5, 22)
                        amountC = random.Next(5, 22)
                        amountD = random.Next(5, 22)
                    ElseIf ControlPanel.lblAnswer.Text = "B" Then
                        amountB = random.Next(20, 60)
                        amountC = random.Next(5, 22)
                        amountD = random.Next(5, 22)
                        amountA = random.Next(5, 22)
                    ElseIf ControlPanel.lblAnswer.Text = "C" Then
                        amountC = random.Next(20, 60)
                        amountD = random.Next(5, 22)
                        amountA = random.Next(5, 22)
                        amountB = random.Next(5, 22)
                    ElseIf ControlPanel.lblAnswer.Text = "D" Then
                        amountD = random.Next(20, 60)
                        amountA = random.Next(5, 22)
                        amountB = random.Next(5, 22)
                        amountC = random.Next(5, 22)
                    End If
                ElseIf Game.level >= 10 Then
                    If ControlPanel.lblAnswer.Text = "A" Then
                        amountA = random.Next(33, 65)
                        amountB = random.Next(20, 35)
                        amountC = random.Next(20, 35)
                        amountD = random.Next(20, 35)
                    ElseIf ControlPanel.lblAnswer.Text = "B" Then
                        amountB = random.Next(33, 65)
                        amountC = random.Next(20, 35)
                        amountD = random.Next(20, 35)
                        amountA = random.Next(20, 35)
                    ElseIf ControlPanel.lblAnswer.Text = "C" Then
                        amountC = random.Next(33, 65)
                        amountD = random.Next(20, 35)
                        amountA = random.Next(20, 35)
                        amountB = random.Next(20, 35)
                    ElseIf ControlPanel.lblAnswer.Text = "D" Then
                        amountD = random.Next(33, 65)
                        amountA = random.Next(20, 35)
                        amountB = random.Next(20, 35)
                        amountC = random.Next(20, 35)
                    End If
                End If

                If ControlPanel.txtA.Text = "" Then
                    amountA = 0
                End If
                If ControlPanel.txtB.Text = "" Then
                    amountB = 0
                End If
                If ControlPanel.txtC.Text = "" Then
                    amountC = 0
                End If
                If ControlPanel.txtD.Text = "" Then
                    amountD = 0
                End If

                ControlPanel.lblATA_A.Text = amountA
                ControlPanel.lblATA_B.Text = amountB
                ControlPanel.lblATA_C.Text = amountC
                ControlPanel.lblATA_D.Text = amountD

                amountTotal = amountA + amountB + amountC + amountD
                perA = Fix((amountA / amountTotal * 100) + 0.5)
                perB = Fix((amountB / amountTotal * 100) + 0.5)
                perC = Fix((amountC / amountTotal * 100) + 0.5)
                perD = Fix((amountD / amountTotal * 100) + 0.5)
            Case 2
                TVControlPnl.tmrRandomizer.Stop()
                With Sounds.sndLifeline2
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_End
                    .controls.play()
                End With
                Sounds.sndLifeline1.controls.stop()
                TVControlPnl.lblATA_A.Text = "A: " + perA + "%"
                TVControlPnl.lblATA_B.Text = "B: " + perB + "%"
                TVControlPnl.lblATA_C.Text = "C: " + perC + "%"
                TVControlPnl.lblATA_D.Text = "D: " + perD + "%"
                HostScreen.txtATAa.Text = "A= " + perA + "%"
                HostScreen.txtATAb.Text = "B= " + perB + "%"
                HostScreen.txtATAc.Text = "C= " + perC + "%"
                HostScreen.txtATAd.Text = "D= " + perD + "%"
                GuestScreen.txtATAa.Text = "A= " + perA + "%"
                GuestScreen.txtATAb.Text = "B= " + perB + "%"
                GuestScreen.txtATAc.Text = "C= " + perC + "%"
                GuestScreen.txtATAd.Text = "D= " + perD + "%"

                Question.PlayQuestionCue()

                ControlPanel.btnVote.Enabled = False
                ControlPanel.chkVote.Checked = False
                HostScreen.picVO.Image = My.Resources.ll_audience_used
                GuestScreen.picVO.Image = My.Resources.ll_audience_used
                TVControlPnl.picVO.Image = My.Resources.ll_audience_used
                act = 0
        End Select

    End Sub

    Public Sub blankSub()

    End Sub

End Class
