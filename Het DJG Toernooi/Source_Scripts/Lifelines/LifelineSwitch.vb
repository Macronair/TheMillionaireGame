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
            HostScreen.lblSwitchUsed.ForeColor = Color.Cyan
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
                HostScreen.pnlA.BackgroundImage = My.Resources._0_Correct_Answer_Fill_l
                GuestScreen.pnlA.BackgroundImage = My.Resources._0_Correct_Answer_Fill_l
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                ControlPanel.txtB.BackColor = Color.Green
                HostScreen.pnlB.BackgroundImage = My.Resources._0_Correct_Answer_Fill_r
                GuestScreen.pnlB.BackgroundImage = My.Resources._0_Correct_Answer_Fill_r
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                ControlPanel.txtC.BackColor = Color.Green
                HostScreen.pnlC.BackgroundImage = My.Resources._0_Correct_Answer_Fill_l
                GuestScreen.pnlC.BackgroundImage = My.Resources._0_Correct_Answer_Fill_l
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                ControlPanel.txtD.BackColor = Color.Green
                HostScreen.pnlD.BackgroundImage = My.Resources._0_Correct_Answer_Fill_r
                HostScreen.pnlD.BackgroundImage = My.Resources._0_Correct_Answer_Fill_r
            End If
            act = 2
        ElseIf act = 2 Then
            With Sounds.sndLifeline2
                .URL = Sounds.SoundsPath + Profile.Options.snd_Switch0_Clear
                .controls.play()
            End With

            TVControlPnl.grpATA.Visible = False
            TVControlPnl.pnlQuestion.Visible = False
            TVControlPnl.tmrFlash.Stop()
            TVControlPnl.picA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            GuestScreen.pnlA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            HostScreen.pnlA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
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
        Select Case LifelineManager.CurrentActive
            Case 1
                ControlPanel.chkLifeline1Unused.Checked = False
            Case 2
                ControlPanel.chkLifeline2Unused.Checked = False
            Case 3
                ControlPanel.chkLifeline3Unused.Checked = False
            Case 4
                ControlPanel.chkLifeline4Unused.Checked = False
        End Select
    End Sub

End Class
