Public Class LifelinePO

    Public Shared plusone As Integer

    Public Sub LifelineUse1()
        If plusone = 0 Then
            TVControlPnl.grpATA.Visible = False
            ControlPanel.intSound += 1

            With ControlPanel.snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(20, False, 750)
            End With
            plusone = plusone + 1
            HostScreen.lblPlusOneUsed.ForeColor = Color.Cyan
            TVControlPnl.pnlQuestion.Visible = False
            ControlPanel.Timer1.Start()
        ElseIf plusone = 1 Then
            My.Computer.Audio.Play(My.Resources.paf_countdown, AudioPlayMode.Background)
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
            ControlPanel.intSound += 1

            With ControlPanel.snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(22, False, 750)
            End With
            ControlPanel.Timer1.Start()
            HostScreen.lblTime.Visible = False
            GuestScreen.lblTime.Visible = False
            ControlPanel.lblTime.Visible = False
            ControlPanel.tmrTime.Stop()
            plusone = 0
            TVControlPnl.lblTime.Visible = False
            ControlPanel.tmrResume.Start()
            ControlPanel.chkPlusOne.Checked = False
            HostScreen.picPO.Image = My.Resources.lifeline_3_used
            GuestScreen.picPO.Image = My.Resources.lifeline_3_used
            TVControlPnl.picPO.Image = My.Resources.lifeline_3_used
            ControlPanel.btnPlusOne.Enabled = False
        End If
    End Sub

End Class
