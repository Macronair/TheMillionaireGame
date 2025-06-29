Public Class LifelinePhone

    Public Shared plusone As Integer

    Public Shared Sub LifelineUse1()
        If plusone = 0 Then
            Question.useMusic = False
            With Sounds.sndLifeline1
                .URL = Sounds.SoundsPath + Profile.Options.snd_P1_Start
                .controls.play()
            End With
            Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("question", 120))
            stopaudio.Start()

            plusone = plusone + 1

            TVControlPnl.grpATA.Visible = False
            If Profile.Options.S_AutoHideQuestionAtPlusOne = True Then
                ControlPanel.chkShowQuestion.Checked = False
            End If

            ControlPanel.txtHostMessages.AppendText("PHONE A FRIEND ACTIVATED." + Environment.NewLine)
            HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "PHONE A FRIEND ACTIVATED."
        ElseIf plusone = 1 Then
            With Sounds.sndLifeline2
                .URL = Sounds.SoundsPath + Profile.Options.snd_P1_Clock
                .controls.play()
            End With
            Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("lifeline1", 50))
            stopaudio.Start()

            HostScreen.lblTime.Text = "30"
            GuestScreen.lblTime.Text = "30"
            ControlPanel.lblTime.Text = "30"
            TVControlPnl.lblTime.Text = "30"
            HostScreen.lblTime.Visible = True
            GuestScreen.lblTime.Visible = True
            TVControlPnl.pnlTime.Visible = True
            ControlPanel.lblTime.Visible = True
            ControlPanel.chkShowQuestion.Checked = True
            plusone = 2
            ControlPanel.tmrTime.Start()
        ElseIf plusone = 2 Then
            With Sounds.sndLifeline1
                .URL = Sounds.SoundsPath + Profile.Options.snd_P1_EndEarly
                .controls.play()
            End With
            Sounds.sndLifeline2.controls.stop()
            Dim continueaudio As New Threading.Thread(Sub() OffsetBeforeCue())
            continueaudio.Start()

            TVControlPnl.pnlTime.Visible = False
            HostScreen.lblTime.Visible = False
            GuestScreen.lblTime.Visible = False
            ControlPanel.lblTime.Visible = False

            ControlPanel.tmrTime.Stop()
            plusone = 0

            LifelineManager.EnableLifeline(LifelineManager.CurrentActive, False)
        End If
    End Sub

    Public Shared Sub OffsetBeforeCue()
        Threading.Thread.Sleep(1000)
        Question.PlayQuestionCue()
    End Sub

End Class

