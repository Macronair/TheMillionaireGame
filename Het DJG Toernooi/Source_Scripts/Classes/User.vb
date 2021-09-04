Public Class User

    Public Shared a As Integer = 0
    Shared snd As New SOUND

    Public Shared Sub NewUser()
        If a = 0 Then
            ControlPanel.firstuse = True
            Game.level = 0
            ControlPanel.nmrLevel.Value = 0
            Game.SetValues()
            ControlPanel.walkaway = False

            ControlPanel.txtQuestion.Text = ""
            ControlPanel.txtA.Text = ""
            ControlPanel.txtB.Text = ""
            ControlPanel.txtC.Text = ""
            ControlPanel.txtD.Text = ""

            HostScreen.lblVoteUsed.ForeColor = Color.Black
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

            HostScreen.txtWinnings.Text = ""

            TVControlPnl.pic50.Visible = True
            TVControlPnl.picVO.Visible = True
            TVControlPnl.picPO.Visible = True

            HostScreen.pic50.Image = My.Resources.lifeline_1
            HostScreen.picSW.Image = My.Resources.lifeline_2
            HostScreen.picPO.Image = My.Resources.lifeline_3
            HostScreen.picVO.Image = My.Resources.lifeline_4
            HostScreen.picSW.Visible = False
            GuestScreen.pic50.Image = My.Resources.lifeline_1
            GuestScreen.picSW.Image = My.Resources.lifeline_2
            GuestScreen.picPO.Image = My.Resources.lifeline_3
            GuestScreen.picVO.Image = My.Resources.lifeline_4
            GuestScreen.picSW.Visible = False
            TVControlPnl.picSW.Visible = False
            ControlPanel.chk5050.Checked = True
            ControlPanel.chkPlusOne.Checked = True
            ControlPanel.chkSwitch.Checked = True
            ControlPanel.chkVote.Checked = True

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
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.lbl5050Used.ForeColor = Color.Black
            HostScreen.lblSwitchUsed.ForeColor = Color.Black
            HostScreen.lblPlusOneUsed.ForeColor = Color.Black
            HostScreen.txtExplain.ForeColor = Color.Black

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
            HostScreen.lblWalkedAway.ForeColor = Color.Black

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

            Game.ChangeMode(0)

            Question.act = 0
            My.Computer.Audio.Play(My.Resources.hello_long, AudioPlayMode.Background)
            ControlPanel.walkaway = False
            a = 1
        ElseIf a = 1 Then
            ControlPanel.intSound += 1

            With snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(6, False, 1000)
            End With
            ControlPanel.Timer1.Start()
            a = 0
        End If
    End Sub

End Class
