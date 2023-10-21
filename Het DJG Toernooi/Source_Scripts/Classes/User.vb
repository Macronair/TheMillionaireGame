Public Class User

    Public Shared a As Integer = 0
    Shared snd As New SOUND

    Public Shared Sub NewUser()
        If a = 0 Then
            Game.firstQuestion = True
            Game.level = 0
            ControlPanel.nmrLevel.Value = 0
            Game.SetValues()
            Game.walkaway = False
            LifelineManager.Lifeline1_Used = False
            LifelineManager.Lifeline2_Used = False
            LifelineManager.Lifeline3_Used = False
            LifelineManager.Lifeline4_Used = False

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

            TVControlPnl.picLifeline3.Visible = True
            TVControlPnl.picLifeline1.Visible = True
            TVControlPnl.picLifeline2.Visible = True

            HostScreen.picLifeline4.Image = My.Resources.ll_5050
            HostScreen.picLifeline1.Image = My.Resources.ll_switch
            HostScreen.picLifeline3.Image = My.Resources.ll_phone
            HostScreen.picLifeline2.Image = My.Resources.ll_audience
            HostScreen.picLifeline1.Visible = False
            GuestScreen.picLifeline4.Image = My.Resources.ll_5050
            GuestScreen.picLifeline1.Image = My.Resources.ll_switch
            GuestScreen.picLifeline3.Image = My.Resources.ll_phone
            GuestScreen.picLifeline2.Image = My.Resources.ll_audience
            GuestScreen.picLifeline1.Visible = False
            TVControlPnl.picLifeline4.Visible = False
            ControlPanel.chkLifeline3Unused.Checked = True
            ControlPanel.chkLifeline2Unused.Checked = True
            ControlPanel.chkLifeline4Unused.Checked = True
            ControlPanel.chkLifeline1Unused.Checked = True

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
            HostScreen.pnlA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            GuestScreen.txtA.ForeColor = Color.White
            GuestScreen.txtB.ForeColor = Color.White
            GuestScreen.txtC.ForeColor = Color.White
            GuestScreen.txtD.ForeColor = Color.White
            GuestScreen.pnlA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
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
            Game.walkaway = False
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
