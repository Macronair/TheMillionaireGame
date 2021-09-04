Imports System.Drawing

Public Class LifelineSwitch
    Dim act As Integer = 0
    Public Sub LifelineUse1()
        If act = 0 Then
            TVControlPnl.picSwitch.Visible = True
            TVControlPnl.grpATA.Visible = False
            ControlPanel.intSound += 1

            With ControlPanel.snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(9, False, 1000)
            End With
            HostScreen.lblSwitchUsed.ForeColor = Color.Cyan
            HostScreen.pnlAnswer.BackColor = Color.LightGray
            act = 1
        ElseIf act = 1 Then
            TVControlPnl.tmrFlash.Start()
            If ControlPanel.lblAnswer.Text = "A" Then
                ControlPanel.txtA.BackColor = Color.Green
                HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
                GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                ControlPanel.txtB.BackColor = Color.Green
                HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
                GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                ControlPanel.txtC.BackColor = Color.Green
                HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
                GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                ControlPanel.txtD.BackColor = Color.Green
                HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
                HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
            End If
            act = 2
        ElseIf act = 2 Then
            ControlPanel.intSound += 1

            With ControlPanel.snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(10, False, 1000)
            End With
            TVControlPnl.grpATA.Visible = False
            TVControlPnl.pnlQuestion.Visible = False
            TVControlPnl.tmrFlash.Stop()
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
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
            ControlPanel.btnSwitch.Enabled = False
            act = 0
            Question.act = 0
            reset()
        End If
    End Sub

    Public Sub reset()
        TVControlPnl.picSwitch.Visible = False
        act = 0
        HostScreen.picSW.Image = My.Resources.lifeline_2_used
        GuestScreen.picSW.Image = My.Resources.lifeline_2_used
        TVControlPnl.picSW.Image = My.Resources.lifeline_2_used
        ControlPanel.chkSwitch.Checked = False
        ControlPanel.btnSwitch.Enabled = False
    End Sub

End Class
