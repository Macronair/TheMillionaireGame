Public Class LifelineATA
    Private Shared act As Integer = 0
    Private Shared amountA As Integer
    Private Shared amountB As Integer
    Private Shared amountC As Integer
    Private Shared amountD As Integer
    Private Shared perA As String
    Private Shared perB As String
    Private Shared perC As String
    Private Shared perD As String
    Private Shared amountTotal As Integer


    Public Shared Sub LifelineUse1()
        Select Case act
            Case 0
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_Start
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("question", 100))
                stopaudio.Start()

                Question.useMusic = False
                act = 1

                ControlPanel.txtHostMessages.AppendText("AUDIENCE ACTIVATED." + Environment.NewLine)
                HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "AUDIENCE ACTIVATED."
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

                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)

                    Dim choosewronganswer As Boolean = False

                    If Profile.Options.S_ATAisAlwaysCorrect = True Then
                        If random.Next(1, 31) <= 4 Then
                            choosewronganswer = True
                        End If
                    End If

                    If choosewronganswer = True Then
                            Dim fakeanswer As Integer = random.Next(1, 5)
                            Select Case fakeanswer
                                Case 1
                                    amountA = random.Next(40, 60)
                                Case 2
                                    amountB = random.Next(40, 60)
                                Case 3
                                    amountC = random.Next(40, 60)
                                Case 4
                                    amountD = random.Next(40, 60)
                            End Select
                        Else
                            If ControlPanel.lblAnswer.Text = "A" Then
                                amountA = random.Next(40, 60)
                            ElseIf ControlPanel.lblAnswer.Text = "B" Then
                                amountB = random.Next(40, 60)
                            ElseIf ControlPanel.lblAnswer.Text = "C" Then
                                amountC = random.Next(40, 60)
                            ElseIf ControlPanel.lblAnswer.Text = "D" Then
                                amountD = random.Next(40, 60)
                            End If
                        End If

                    ElseIf Game.level >= 5 And Game.level <= 9 Then

                        amountA = random.Next(5, 20)
                        amountB = random.Next(5, 20)
                        amountC = random.Next(5, 20)
                        amountD = random.Next(5, 20)

                        Dim choosewronganswer As Boolean = False

                    If Profile.Options.S_ATAisAlwaysCorrect = True Then
                        If random.Next(1, 31) <= 8 Then
                            choosewronganswer = True
                        End If
                    End If

                    If choosewronganswer = True Then
                            Dim fakeanswer As Integer = random.Next(1, 5)
                            Select Case fakeanswer
                                Case 1
                                    amountA = random.Next(25, 65)
                                Case 2
                                    amountB = random.Next(25, 65)
                                Case 3
                                    amountC = random.Next(25, 65)
                                Case 4
                                    amountD = random.Next(25, 65)
                            End Select
                        Else
                            If ControlPanel.lblAnswer.Text = "A" Then
                                amountA = random.Next(23, 65)
                            ElseIf ControlPanel.lblAnswer.Text = "B" Then
                                amountB = random.Next(23, 65)
                            ElseIf ControlPanel.lblAnswer.Text = "C" Then
                                amountC = random.Next(23, 65)
                            ElseIf ControlPanel.lblAnswer.Text = "D" Then
                                amountD = random.Next(23, 65)
                            End If
                        End If

                    ElseIf Game.level >= 10 Then
                        amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)

                    Dim choosewronganswer As Boolean = False

                    If Profile.Options.S_ATAisAlwaysCorrect = True Then
                        If random.Next(1, 31) <= 10 Then
                            choosewronganswer = True
                        End If
                    End If

                    If choosewronganswer = True Then
                        Dim fakeanswer As Integer = random.Next(1, 5)
                        Select Case fakeanswer
                            Case 1
                                amountA = random.Next(30, 70)
                            Case 2
                                amountB = random.Next(30, 70)
                            Case 3
                                amountC = random.Next(30, 70)
                            Case 4
                                amountD = random.Next(30, 70)
                        End Select
                    Else
                        If ControlPanel.lblAnswer.Text = "A" Then
                            amountA = random.Next(30, 70)
                        ElseIf ControlPanel.lblAnswer.Text = "B" Then
                            amountB = random.Next(30, 70)
                        ElseIf ControlPanel.lblAnswer.Text = "C" Then
                            amountC = random.Next(30, 70)
                        ElseIf ControlPanel.lblAnswer.Text = "D" Then
                            amountD = random.Next(30, 70)
                        End If
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

                LifelineManager.EnableLifeline(LifelineManager.CurrentActive, False)

                Question.PlayQuestionCue()
                act = 0
        End Select

    End Sub

    Public Sub blankSub()

    End Sub

End Class
