Public Class LifelinePO

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
            HostScreen.lblPlusOneUsed.ForeColor = Color.Cyan
            TVControlPnl.pnlQuestion.Visible = False
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
            HostScreen.lblTime.Visible = True
            GuestScreen.lblTime.Visible = True
            TVControlPnl.pnlTime.Visible = True
            ControlPanel.lblTime.Visible = True
            TVControlPnl.pnlQuestion.Visible = True
            plusone = 2
            ControlPanel.Timer2.Start()
            ControlPanel.tmrTime.Start()
        ElseIf plusone = 2 Then
            With Sounds.sndLifeline1
                .URL = Sounds.SoundsPath + Profile.Options.snd_P1_EndEarly
                .controls.play()
            End With
            Sounds.sndLifeline2.controls.stop()

            Dim continueaudio As New Threading.Thread(Sub() OffsetBeforeCue())
            continueaudio.Start()

            HostScreen.lblTime.Visible = False
            GuestScreen.lblTime.Visible = False
            ControlPanel.lblTime.Visible = False
            ControlPanel.tmrTime.Stop()
            plusone = 0
            TVControlPnl.lblTime.Visible = False
            ControlPanel.chkLifeline2Unused.Checked = False
            HostScreen.picLifeline3.Image = My.Resources.ll_phone_used
            GuestScreen.picLifeline3.Image = My.Resources.ll_phone_used
            TVControlPnl.picLifeline2.Image = My.Resources.ll_phone_used
            ControlPanel.btnLifeline2.Enabled = False
        End If
    End Sub

    Shared Sub OffsetBeforeCue()
        Threading.Thread.Sleep(1000)
        Question.PlayQuestionCue()
    End Sub

End Class
