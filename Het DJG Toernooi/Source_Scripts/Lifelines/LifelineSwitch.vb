Public Class LifelineSwitch
    Private Shared act As Integer = 0
    Public Shared Sub LifelineUse1()
        If act = 0 Then
            With Sounds.sndLifeline1
                .URL = Sounds.SoundsPath + Profile.Options.snd_Switch0_Activate
                .controls.play()
            End With

            TVControlPnl.picLifelineUse.Image = My.Resources.Resources.ll_switch
            TVControlPnl.picLifelineUse.Visible = True
            TVControlPnl.grpATA.Visible = False
            HostScreen.pnlAnswer.BackColor = Color.LightGray
            act = 1

            ControlPanel.txtHostMessages.AppendText("SWITCH ACTIVATED." + Environment.NewLine)
            HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "SWITCH ACTIVATED."
        ElseIf act = 1 Then
            Dim cor_seq As New WMPLib.WindowsMediaPlayer
            cor_seq.URL = Sounds.SoundsPath + Profile.Options.snd_Switch0_ShowCorrect
            cor_seq.controls.play()

            TVControlPnl.tmrFlash.Start()
            If ControlPanel.lblAnswer.Text = "A" Then
                ControlPanel.txtA.BackColor = Color.Green
                HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
                GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                ControlPanel.txtB.BackColor = Color.Green
                HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
                GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                ControlPanel.txtC.BackColor = Color.Green
                HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
                GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                ControlPanel.txtD.BackColor = Color.Green
                HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
                HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
            End If
            act = 2
        ElseIf act = 2 Then
            With Sounds.sndLifeline2
                .URL = Sounds.SoundsPath + Profile.Options.snd_Switch0_Clear
                .controls.play()
            End With

            TVControlPnl.grpATA.Visible = False
            ControlPanel.chkShowQuestion.Checked = False
            TVControlPnl.tmrFlash.Stop()
            TVControlPnl.picA.BackgroundImage = QuestionStrap.GetTexture(2)
            TVControlPnl.picB.BackgroundImage = QuestionStrap.GetTexture(3)
            TVControlPnl.picC.BackgroundImage = QuestionStrap.GetTexture(2)
            TVControlPnl.picD.BackgroundImage = QuestionStrap.GetTexture(3)
            GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
            GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
            GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
            GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
            HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
            HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
            HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
            HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
            ControlPanel.txtQuestion.Text = ""
            ControlPanel.txtA.Text = ""
            ControlPanel.txtB.Text = ""
            ControlPanel.txtC.Text = ""
            ControlPanel.txtD.Text = ""
            HostScreen.txtQuestion.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            GuestScreen.txtQuestion.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""
            ControlPanel.txtA.BackColor = SystemColors.Control
            ControlPanel.txtB.BackColor = SystemColors.Control
            ControlPanel.txtC.BackColor = SystemColors.Control
            ControlPanel.txtD.BackColor = SystemColors.Control
            ControlPanel.btnLifeline4.Enabled = False
            act = 0
            Question.act = 0
            reset()
        End If
    End Sub

    Private Shared Sub reset()
        TVControlPnl.picLifelineUse.Visible = False
        act = 0

        LifelineManager.EnableLifeline(LifelineManager.CurrentActive, False)
    End Sub

End Class
