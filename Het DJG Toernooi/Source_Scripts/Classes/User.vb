﻿Imports System.Threading

Public Class User

    Public Shared a As Integer = 0
    Shared snd As New SOUND
    Shared generateimg As Windows.Forms.Timer

    Public Sub New()

    End Sub

    Shared Sub GenerateIMG_Tick()
        MoneyTreeCore.GenerateImages()

        LifelineManager.CurrentActive = 0
        LifelineManager.EnableLifeline(1, True)
        LifelineManager.EnableLifeline(2, True)
        LifelineManager.EnableLifeline(3, True)
        LifelineManager.EnableLifeline(4, True)

        LifelineManager.UnlockLifeline(1)
        LifelineManager.UnlockLifeline(2)
        LifelineManager.UnlockLifeline(3)
        LifelineManager.UnlockLifeline(4)

        LifelineHost.used = False

        If MoneyTreeSettings.TreeData.SafeNet_FreeMode = False Then
            Game.ChangeMode(0)
        End If

        Game.ChangeLevel(0)
        generateimg.Stop()
    End Sub

    Public Shared Sub ToHotSeat()
        If a = 0 Then
            ResetGame()

            With Sounds.sndGeneral
                .URL = Sounds.SoundsPath + Profile.Options.snd_ToHotSeat
                .controls.play()
            End With

            a = 1
        ElseIf a = 1 Then
            With Sounds.sndLightsDown
                .URL = Sounds.SoundsPath + Profile.Options.snd_ToHotSeat_LD
                .controls.play()
            End With

            Dim stopmusic As New Thread(Sub() Sounds.StopAudio("for_lightsdown", 720))
            stopmusic.Start()
            a = 0
        End If
    End Sub

    Public Shared Sub ResetGame()
        generateimg = New Windows.Forms.Timer()
        generateimg.Interval = 500 'Timer will trigger one second after start
        AddHandler generateimg.Tick, AddressOf GenerateIMG_Tick 'Timer will call this sub when done
        generateimg.Start()

        Game.firstQuestion = True
        ControlPanel.nmrLevel.Value = 0
        Game.SetValues()
        Question.useMusic = False
        Game.walkaway = False
        Game.freeSafetyNetSet = False
        Game.freeSafetyNetAt = 0

        ControlPanel.chkShowQuestion.Checked = False
        ControlPanel.chkShowTotalScore.Checked = False

        HostScreen.lblAnswer.Visible = True

        ControlPanel.txtQuestion.Text = ""
        ControlPanel.txtA.Text = ""
        ControlPanel.txtB.Text = ""
        ControlPanel.txtC.Text = ""
        ControlPanel.txtD.Text = ""

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
        HostScreen.txtExplain.ForeColor = Color.Black

        ControlPanel.txtA.BackColor = Color.Silver
        ControlPanel.txtB.BackColor = Color.Silver
        ControlPanel.txtC.BackColor = Color.Silver
        ControlPanel.txtD.BackColor = Color.Silver
        HostScreen.txtA.ForeColor = Color.White
        HostScreen.txtB.ForeColor = Color.White
        HostScreen.txtC.ForeColor = Color.White
        HostScreen.txtD.ForeColor = Color.White
        HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
        HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
        HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
        HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
        GuestScreen.txtA.ForeColor = Color.White
        GuestScreen.txtB.ForeColor = Color.White
        GuestScreen.txtC.ForeColor = Color.White
        GuestScreen.txtD.ForeColor = Color.White
        GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
        GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
        GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
        GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
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
        Game.walkaway = False
        Question.act = 0
    End Sub
End Class
