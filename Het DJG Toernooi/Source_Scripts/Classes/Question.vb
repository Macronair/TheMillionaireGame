Imports System.Threading

Public Class Question

    Public Shared act As Integer
    Public Shared useMusic As Boolean = False

    Dim newQ As New QDatabase

    Public Sub Generate()
        ControlPanel.i = 0

        HostScreen.txtExplain.ForeColor = Color.Black
        ControlPanel.lblATA_A.Text = "A: 0"
        ControlPanel.lblATA_B.Text = "B: 0"
        ControlPanel.lblATA_C.Text = "C: 0"
        ControlPanel.lblATA_D.Text = "D: 0"
        TVControlPnl.lblATA_A.Text = "0%"
        TVControlPnl.lblATA_B.Text = "0%"
        TVControlPnl.lblATA_C.Text = "0%"
        TVControlPnl.lblATA_D.Text = "0%"
        HostScreen.txtATAa.Text = ""
        HostScreen.txtATAb.Text = ""
        HostScreen.txtATAc.Text = ""
        HostScreen.txtATAd.Text = ""
        GuestScreen.txtATAa.Text = ""
        GuestScreen.txtATAb.Text = ""
        GuestScreen.txtATAc.Text = ""
        GuestScreen.txtATAd.Text = ""
        PlayQuestionCue()
        If act = 5 Then
            HostScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
            GuestScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
            TVControlPnl.txtD.Text = "D: " & ControlPanel.txtD.Text
            TVControlPnl.txtD.Visible = True
            act = 5
        End If
        If act = 4 Then
            HostScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
            GuestScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
            TVControlPnl.txtC.Text = "C: " & ControlPanel.txtC.Text
            TVControlPnl.txtC.Visible = True
            act = 5
        End If
        If act = 3 Then
            HostScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
            GuestScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
            TVControlPnl.txtB.Text = "B: " & ControlPanel.txtB.Text
            TVControlPnl.txtB.Visible = True
            act = 4
        End If
        If act = 2 Then
            HostScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
            GuestScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
            TVControlPnl.txtA.Text = "A: " & ControlPanel.txtA.Text
            TVControlPnl.txtA.Visible = True
            act = 3
        End If
        If act = 1 Then
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picTree.Visible = False
            TVControlPnl.pnlStrap.Visible = False
            HostScreen.pnlStrap.Visible = False
            GuestScreen.pnlStrap.Visible = False
            TVControlPnl.pnlQuestion.Visible = True
            act = 2
        End If
        If act = 0 Then
            act = 1
            newQ.newQuestion()
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.lbl5050Used.ForeColor = Color.Black
            HostScreen.lblSwitchUsed.ForeColor = Color.Black
            HostScreen.lblPlusOneUsed.ForeColor = Color.Black
            HostScreen.lblVoteUsed.ForeColor = Color.Black
            ControlPanel.txtA.BackColor = Color.Silver
            ControlPanel.txtB.BackColor = Color.Silver
            ControlPanel.txtC.BackColor = Color.Silver
            ControlPanel.txtD.BackColor = Color.Silver
            HostScreen.txtA.ForeColor = Color.White
            HostScreen.txtB.ForeColor = Color.White
            HostScreen.txtC.ForeColor = Color.White
            HostScreen.txtD.ForeColor = Color.White
            HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.txtA.ForeColor = Color.White
            GuestScreen.txtB.ForeColor = Color.White
            GuestScreen.txtC.ForeColor = Color.White
            GuestScreen.txtD.ForeColor = Color.White
            GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.txtA.ForeColor = Color.White
            TVControlPnl.txtB.ForeColor = Color.White
            TVControlPnl.txtC.ForeColor = Color.White
            TVControlPnl.txtD.ForeColor = Color.White
            HostScreen.txtATAa.ForeColor = Color.White
            HostScreen.txtATAb.ForeColor = Color.White
            HostScreen.txtATAc.ForeColor = Color.White
            HostScreen.txtATAd.ForeColor = Color.White
            GuestScreen.txtATAa.ForeColor = Color.White
            GuestScreen.txtATAb.ForeColor = Color.White
            GuestScreen.txtATAc.ForeColor = Color.White
            GuestScreen.txtATAd.ForeColor = Color.White
            HostScreen.txtATAa.Text = ""
            HostScreen.txtATAb.Text = ""
            HostScreen.txtATAc.Text = ""
            HostScreen.txtATAd.Text = ""
            GuestScreen.txtATAa.Text = ""
            GuestScreen.txtATAb.Text = ""
            GuestScreen.txtATAc.Text = ""
            GuestScreen.txtATAd.Text = ""
            TVControlPnl.txtA.Text = ""
            TVControlPnl.txtB.Text = ""
            TVControlPnl.txtC.Text = ""
            TVControlPnl.txtD.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""
            TVControlPnl.txtA.Visible = False
            TVControlPnl.txtB.Visible = False
            TVControlPnl.txtC.Visible = False
            TVControlPnl.txtD.Visible = False
            HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
            TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
            GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
            HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
            HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text
        End If
    End Sub

    Public Shared Sub PlayLightsDownCue()
        If Game.firstQuestion = True Then
            With Sounds.sndLightsDown
                .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5LightsDown
                .controls.play()
            End With
            Game.firstQuestion = False
        Else
            Select Case Game.level
                Case < 5
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5LightsDown
                        .controls.play()
                    End With
                Case 5
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q6LightsDown
                        .controls.play()
                    End With
                Case 6
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q7LightsDown
                        .controls.play()
                    End With
                Case 7
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q8LightsDown
                        .controls.play()
                    End With
                Case 8
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q9LightsDown
                        .controls.play()
                    End With
                Case 9
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q10LightsDown
                        .controls.play()
                    End With
                Case 10
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q11LightsDown
                        .controls.play()
                    End With
                Case 11
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q12LightsDown
                        .controls.play()
                    End With
                Case 12
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q13LightsDown
                        .controls.play()
                    End With
                Case 13
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q14LightsDown
                        .controls.play()
                    End With
                Case 14
                    With Sounds.sndLightsDown
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q15LightsDown
                        .controls.play()
                    End With
            End Select
        End If
        Dim stopaudio As New Thread(Sub() Sounds.StopAudio("for_lightsdown", 400))
        stopaudio.Start()
    End Sub

    Public Shared Sub PlayQuestionCue()
        If useMusic = False Then
            useMusic = True

            If Game.firstQuestion = True Or Game.level > 10 Then
                ControlPanel.Timer2.Start()
            End If

            Select Case Game.level
                Case 0
                    If Profile.Options.snd_Q1to5LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 1
                    If Profile.Options.snd_Q1to5LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 2
                    If Profile.Options.snd_Q1to5LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 3
                    If Profile.Options.snd_Q1to5LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 4
                    If Profile.Options.snd_Q1to5LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 5
                    If Profile.Options.snd_Q6LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q6Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 6
                    If Profile.Options.snd_Q7LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q7Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 7
                    If Profile.Options.snd_Q8LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q8Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 8
                    If Profile.Options.snd_Q9LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q9Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 9
                    If Profile.Options.snd_Q10LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q10Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 10
                    If Profile.Options.snd_Q11LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q11Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 11
                    If Profile.Options.snd_Q12LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q12Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 12
                    If Profile.Options.snd_Q13LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q13Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 13
                    If Profile.Options.snd_Q14LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q14Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
                Case 14
                    If Profile.Options.snd_Q15LightsDown_Stop = True Then
                        Dim stopmusic As New Thread(Sub() Sounds.StopAudio("lights", 200))
                        stopmusic.Start()
                    End If
                    With Sounds.sndQuestion
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q15Bed
                        .settings.setMode("Loop", True)
                        .controls.play()
                    End With
            End Select
        End If
    End Sub

    Public Shared Sub PlayFinalAnswerCue()
        If Game.walkaway = False Then
            If Game.level > 4 Then
                Dim stopmusic As New Thread(Sub() Sounds.StopAudio("question", 150))
                stopmusic.Start()
            End If

            Select Case Game.level
                Case 0
                    If Profile.Options.snd_Q1Final IsNot "" Then
                        With Sounds.sndFinal
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1Final
                            .controls.play()
                        End With
                    End If
                Case 1
                    If Profile.Options.snd_Q1Final IsNot "" Then
                        With Sounds.sndFinal
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q2Final
                            .controls.play()
                        End With
                    End If
                Case 2
                    If Profile.Options.snd_Q1Final IsNot "" Then
                        With Sounds.sndFinal
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q3Final
                            .controls.play()
                        End With
                    End If
                Case 3
                    If Profile.Options.snd_Q1Final IsNot "" Then
                        With Sounds.sndFinal
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q4Final
                            .controls.play()
                        End With
                    End If
                Case 4
                    If Profile.Options.snd_Q1Final IsNot "" Then
                        With Sounds.sndFinal
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q5Final
                            .controls.play()
                        End With
                    End If
                Case 5
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q6Final
                        .controls.play()
                    End With
                Case 6
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q7Final
                        .controls.play()
                    End With
                Case 7
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q8Final
                        .controls.play()
                    End With
                Case 8
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q9Final
                        .controls.play()
                    End With
                Case 9
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q10Final
                        .controls.play()
                    End With
                Case 10
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q11Final
                        .controls.play()
                    End With
                Case 11
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q12Final
                        .controls.play()
                    End With
                Case 12
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q13Final
                        .controls.play()
                    End With
                Case 13
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q14Final
                        .controls.play()
                    End With
                Case 14
                    With Sounds.sndFinal
                        .URL = Sounds.SoundsPath + Profile.Options.snd_Q15Final
                        .controls.play()
                    End With
            End Select
        End If
    End Sub

    Public Shared Sub PlayAnswerRevealCue(ByVal IsItCorrect As Boolean)
        If Game.walkaway = False Then
            If IsItCorrect = True Then
                Select Case Game.level
                    Case 0
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to4Correct
                            .controls.play()
                        End With
                    Case 1
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to4Correct
                            .controls.play()
                        End With
                    Case 2
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to4Correct
                            .controls.play()
                        End With
                    Case 3
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to4Correct
                            .controls.play()
                        End With
                    Case 4
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q5Correct
                            .controls.play()
                        End With
                    Case 5
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q6Correct
                            .controls.play()
                        End With
                    Case 6
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q7Correct
                            .controls.play()
                        End With
                    Case 7
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q8Correct
                            .controls.play()
                        End With
                    Case 8
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q9Correct
                            .controls.play()
                        End With
                    Case 9
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q10Correct
                            .controls.play()
                        End With
                    Case 10
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q11Correct
                            .controls.play()
                        End With
                    Case 11
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q12Correct
                            .controls.play()
                        End With
                    Case 12
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q13Correct
                            .controls.play()
                        End With
                    Case 13
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q14Correct
                            .controls.play()
                        End With
                    Case 14
                        Sounds.sndQuestion.controls.stop()
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q15Correct
                            .controls.play()
                        End With
                End Select
                If Game.level > 4 Then
                    Dim stopaudio As New Thread(Sub() Sounds.StopAudio("final", 100))
                    stopaudio.Start()
                ElseIf Game.level = 4 Then
                    Dim stopaudio As New Thread(Sub() Sounds.StopAudio("question", 600))
                    stopaudio.Start()
                End If
            Else
                Select Case Game.level
                    Case 0
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Wrong
                            .controls.play()
                        End With
                    Case 1
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Wrong
                            .controls.play()
                        End With
                    Case 2
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Wrong
                            .controls.play()
                        End With
                    Case 3
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Wrong
                            .controls.play()
                        End With
                    Case 4
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q1to5Wrong
                            .controls.play()
                        End With
                    Case 5
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q6Wrong
                            .controls.play()
                        End With
                    Case 6
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q7Wrong
                            .controls.play()
                        End With
                    Case 7
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q8Wrong
                            .controls.play()
                        End With
                    Case 8
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q9Wrong
                            .controls.play()
                        End With
                    Case 9
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q10Wrong
                            .controls.play()
                        End With
                    Case 10
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q11Wrong
                            .controls.play()
                        End With
                    Case 11
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q12Wrong
                            .controls.play()
                        End With
                    Case 12
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q13Wrong
                            .controls.play()
                        End With
                    Case 13
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q14Wrong
                            .controls.play()
                        End With
                    Case 14
                        With Sounds.sndAnswer
                            .URL = Sounds.SoundsPath + Profile.Options.snd_Q15Wrong
                            .controls.play()
                        End With
                End Select
                If Game.level < 5 Then
                    Dim stopaudio As New Thread(Sub() Sounds.StopAudio("question", 300))
                    stopaudio.Start()
                ElseIf Game.level >= 5 Then
                    Dim stopaudio As New Thread(Sub() Sounds.StopAudio("final", 100))
                    stopaudio.Start()
                End If
            End If
        End If

        If IsItCorrect = True Then  'On a right answer

            TVControlPnl.tmrFlash.Start()
            LifeLineDouble.chance = 2
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
            If Game.walkaway = False Then
                If Game.level = 14 Then
                    HostScreen.txtWinnings.Text = "Total Score: " + Game.varCorrect
                End If
            End If

            TVControlPnl.grpATA.Visible = False
            TVControlPnl.picLifelineUse.Visible = False

            Dim trStopDD As Threading.Thread = New Threading.Thread(AddressOf LifeLineDouble.StopCue2)
            trStopDD.Start()

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

        Else        ' On a wrong answer

            If LifeLineDouble.active = True Then
                LifeLineDouble.SecondChance()
                If ControlPanel.answer = "A" Then
                    TVControlPnl.txtA.Text = ""
                    TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                    HostScreen.txtA.Text = ""
                    HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                    GuestScreen.txtA.Text = ""
                    GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                    ControlPanel.txtA.Text = ""
                    ControlPanel.txtA.BackColor = Color.Silver
                End If
                If ControlPanel.answer = "B" Then
                    TVControlPnl.txtB.Text = ""
                    TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                    HostScreen.txtB.Text = ""
                    HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                    GuestScreen.txtB.Text = ""
                    GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                    ControlPanel.txtB.Text = ""
                    ControlPanel.txtB.BackColor = Color.Silver
                End If
                If ControlPanel.answer = "C" Then
                    TVControlPnl.txtC.Text = ""
                    TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                    HostScreen.txtC.Text = ""
                    HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                    GuestScreen.txtC.Text = ""
                    GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
                    ControlPanel.txtC.Text = ""
                    ControlPanel.txtC.BackColor = Color.Silver
                End If
                If ControlPanel.answer = "D" Then
                    TVControlPnl.txtD.Text = ""
                    TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                    HostScreen.txtD.Text = ""
                    HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                    GuestScreen.txtD.Text = ""
                    GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
                    ControlPanel.txtD.Text = ""
                    ControlPanel.txtD.BackColor = Color.Silver
                End If
                ControlPanel.Timer2.Stop()
            Else
                LifeLineDouble.chance = 2
                TVControlPnl.tmrFlash.Start()
                TVControlPnl.grpATA.Visible = False
                TVControlPnl.picLifelineUse.Visible = False
                Dim trStopDD As Threading.Thread = New Threading.Thread(AddressOf LifeLineDouble.StopCue2)
                trStopDD.Start()
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
                If Game.walkaway = False Then
                    TVControlPnl.lblAmount.Text = "" & Game.varWrong
                    HostScreen.txtWinnings.Text = "Total Score: " + Game.varWrong
                Else
                    ControlPanel.Timer2.Start()
                    TVControlPnl.lblAmount.Text = "" & Game.varCurrent
                End If
            End If

        End If
    End Sub

    Public Sub UndoAnswer(ByVal music As Boolean)
        ControlPanel.HaltSound()
        If music = True Then
            PlayQuestionCue()
        End If
        ControlPanel.i = 0
        ControlPanel.txtA.BackColor = Color.Silver
        ControlPanel.txtB.BackColor = Color.Silver
        ControlPanel.txtC.BackColor = Color.Silver
        ControlPanel.txtD.BackColor = Color.Silver

        HostScreen.txtExplain.BackColor = Color.Black
        HostScreen.pnlAnswer.BackColor = Color.Black
        HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        HostScreen.txtA.ForeColor = Color.White
        HostScreen.txtB.ForeColor = Color.White
        HostScreen.txtC.ForeColor = Color.White
        HostScreen.txtD.ForeColor = Color.White

        GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        GuestScreen.txtA.ForeColor = Color.White
        GuestScreen.txtB.ForeColor = Color.White
        GuestScreen.txtC.ForeColor = Color.White
        GuestScreen.txtD.ForeColor = Color.White

        TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        TVControlPnl.txtA.ForeColor = Color.White
        TVControlPnl.txtB.ForeColor = Color.White
        TVControlPnl.txtC.ForeColor = Color.White
        TVControlPnl.txtD.ForeColor = Color.White

    End Sub

End Class
