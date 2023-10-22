Imports System.Data.SqlClient

Public Class ControlPanel
    Dim debug As Boolean = False

    Public Shared intSound As Integer = 0
    Public Shared snd As New SOUND
    Public Shared doublell As Integer = 0

    Dim btnLightsDownFA As Boolean = True

    Public Sub HaltSound()
        For X = 0 To intSound
            snd.Kill("SOUND" & X)
        Next
    End Sub

    Public Sub blanksub()

    End Sub

    Public Shared Function GetHostMessages() As List(Of String)
        Using cmd As New SqlCommand("SELECT Message FROM settings_HostMessages", Data.connectionString)
            Dim messages As New List(Of String)
            cmd.CommandType = CommandType.Text
            Data.connectionString.Open()
            Using sdr As SqlDataReader = cmd.ExecuteReader()
                While sdr.Read()
                    messages.Add(sdr.GetString(0))
                End While
            End Using
            Data.connectionString.Close()
            Return messages
        End Using
    End Function

    Private Sub nmrLevel_ValueChanged(sender As Object, e As EventArgs) Handles nmrLevel.ValueChanged
        Game.ChangeLevel(nmrLevel.Value)
    End Sub

    Private Sub btnNewQuestion_Click(sender As Object, e As EventArgs) Handles btnNewQuestion.Click
        Dim q As New Question
        q.Generate()
    End Sub

    Private Sub ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TVControlPnl.pnlTotal.Visible = False
        drpNextHostMessage.Items.AddRange(GetHostMessages().ToArray())
        'Me.Show()
    End Sub

    Public Shared answer As String
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Question.UndoAnswer(False)
        answer = "A"
        HostScreen.txtExplain.ForeColor = Color.White
        txtA.BackColor = Color.Yellow
        HostScreen.pnlA.BackgroundImage = My.Resources._0_Final_Answer_Fill_l
        HostScreen.txtA.ForeColor = Color.Black
        TVControlPnl.picA.BackgroundImage = My.Resources._0_Final_Answer_Fill_l
        TVControlPnl.txtA.ForeColor = Color.Black
        GuestScreen.pnlA.BackgroundImage = My.Resources._0_Final_Answer_Fill_l
        GuestScreen.txtA.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            Question.PlayFinalAnswerCue()
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Dim q As New Question
        Question.UndoAnswer(False)
        answer = "B"
        HostScreen.txtExplain.ForeColor = Color.White
        txtB.BackColor = Color.Yellow
        HostScreen.pnlB.BackgroundImage = My.Resources._0_Final_Answer_Fill_r
        HostScreen.txtB.ForeColor = Color.Black
        TVControlPnl.picB.BackgroundImage = My.Resources._0_Final_Answer_Fill_r
        TVControlPnl.txtB.ForeColor = Color.Black
        GuestScreen.pnlB.BackgroundImage = My.Resources._0_Final_Answer_Fill_r
        GuestScreen.txtB.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            Question.PlayFinalAnswerCue()
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim q As New Question
        Question.UndoAnswer(False)
        answer = "C"
        HostScreen.txtExplain.ForeColor = Color.White
        txtC.BackColor = Color.Yellow
        HostScreen.pnlC.BackgroundImage = My.Resources._0_Final_Answer_Fill_l
        HostScreen.txtC.ForeColor = Color.Black
        TVControlPnl.picC.BackgroundImage = My.Resources._0_Final_Answer_Fill_l
        TVControlPnl.txtC.ForeColor = Color.Black
        GuestScreen.pnlC.BackgroundImage = My.Resources._0_Final_Answer_Fill_l
        GuestScreen.txtC.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            Question.PlayFinalAnswerCue()
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim q As New Question
        Question.UndoAnswer(False)
        answer = "D"
        HostScreen.txtExplain.ForeColor = Color.White
        txtD.BackColor = Color.Yellow
        HostScreen.pnlD.BackgroundImage = My.Resources._0_Final_Answer_Fill_r
        HostScreen.txtD.ForeColor = Color.Black
        TVControlPnl.picD.BackgroundImage = My.Resources._0_Final_Answer_Fill_r
        TVControlPnl.txtD.ForeColor = Color.Black
        GuestScreen.pnlD.BackgroundImage = My.Resources._0_Final_Answer_Fill_r
        GuestScreen.txtD.ForeColor = Color.Black
        If answer = lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Lime
        ElseIf answer IsNot lblAnswer.Text Then
            HostScreen.pnlAnswer.BackColor = Color.Red
        End If
        If LifeLineDouble.active = True Then
            LifeLineDouble.FinalAnswer()
        Else
            Question.PlayFinalAnswerCue()
        End If
    End Sub

    Public Shared i As Integer = 0

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        If i = 0 Then
            HostScreen.txtExplain.ForeColor = Color.White
            If HostScreen.pnlAnswer.BackColor = Color.Lime Then
                If Game.walkaway = False Then
                    TVControlPnl.tmrStrap.Start()
                End If
                Question.PlayAnswerRevealCue(True)
            End If
            If HostScreen.pnlAnswer.BackColor = Color.Red Or HostScreen.pnlAnswer.BackColor = Color.LightGray Then
                Question.PlayAnswerRevealCue(False)
            End If
            i = 1
        ElseIf i = 1 Then
            chkShowQuestion.Checked = False
            TVControlPnl.txtA.BackColor = Color.Transparent
            TVControlPnl.txtB.BackColor = Color.Transparent
            TVControlPnl.txtC.BackColor = Color.Transparent
            TVControlPnl.txtD.BackColor = Color.Transparent
            TVControlPnl.txtA.ForeColor = Color.White
            TVControlPnl.txtB.ForeColor = Color.White
            TVControlPnl.txtC.ForeColor = Color.White
            TVControlPnl.txtD.ForeColor = Color.White
            TVControlPnl.picA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            TVControlPnl.pnlQuestion.Visible = False
            TVControlPnl.pnlStrap.Visible = False
            TVControlPnl.tmrFlash.Stop()
            i = 2
        ElseIf i = 2 Then
            HostScreen.pnlStrap.Visible = False
            GuestScreen.pnlStrap.Visible = False
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.txtQuestion.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            HostScreen.pnlA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            GuestScreen.txtQuestion.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""
            GuestScreen.pnlA.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources._0_Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources._0_Normal_Answer_Fill_r
            i = 0
        End If
    End Sub

    Private Sub btnSndOpening_Click(sender As Object, e As EventArgs) Handles btnSndOpening.Click
        With Sounds.sndGeneral
            .URL = Sounds.SoundsPath + Profile.Options.snd_Opening
            .controls.play()
        End With
    End Sub

    Private Sub btnCommercial_Click(sender As Object, e As EventArgs) Handles btnCommercial.Click
        Select Case Game.intoCommercials
            Case False
                With Sounds.sndGeneral
                    .URL = Sounds.SoundsPath + Profile.Options.snd_CommIn
                    .controls.play()
                End With
                Game.intoCommercials = True
            Case True
                With Sounds.sndGeneral
                    .URL = Sounds.SoundsPath + Profile.Options.snd_CommOut
                    .controls.play()
                End With
                Game.intoCommercials = False
        End Select

        Timer1.Start()
    End Sub

    Private Sub btnClosing_Click(sender As Object, e As EventArgs) Handles btnClosing.Click
        With Sounds.sndGeneral
            .URL = Sounds.SoundsPath + Profile.Options.snd_Closing
            .controls.play()
        End With
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStopPC.Click
        My.Computer.Audio.Stop()
        HaltSound()
    End Sub

    Private Sub btnLightsDown_Click(sender As Object, e As EventArgs) Handles btnLightsDown.Click
        TVControlPnl.picTree.Visible = False
        Question.PlayLightsDownCue()
        Timer1.Start()
        HostScreen.lblExplainRules.ForeColor = Color.Black
    End Sub

    Private Sub btnWalk_Click(sender As Object, e As EventArgs) Handles btnWalk.Click
        HostScreen.txtExplain.ForeColor = Color.White
        Timer1.Start()
        HostScreen.pnlAnswer.BackColor = Color.LightGray
        Game.walkaway = True
        HostScreen.txtWinnings.Text = "Totale Score: " + Game.varCurrent
        TVControlPnl.grpATA.Visible = False

        Select Case Game.level
            Case < 11
                With Sounds.sndGeneral
                    .URL = Sounds.SoundsPath + Profile.Options.snd_WalkAway1
                    .options.play()
                End With
            Case >= 11
                With Sounds.sndGeneral
                    .URL = Sounds.SoundsPath + Profile.Options.snd_WalkAway2
                    .options.play()
                End With
        End Select

        HostScreen.lblWalkedAway.ForeColor = Color.White
        TVControlPnl.lblAmount.Text = "" & Game.varCurrent
        TVControlPnl.pnlQuestion.Visible = False
        TVControlPnl.grpATA.Visible = False
    End Sub

    Private Sub btnLifeline1_Click(sender As Object, e As EventArgs) Handles btnLifeline1.Click
        LifelineManager.Use(1)
    End Sub

    Private Sub btnLifeline2_Click(sender As Object, e As EventArgs) Handles btnLifeline2.Click
        LifelineManager.Use(2)
    End Sub

    Private Sub btnLifeline3_Click(sender As Object, e As EventArgs) Handles btnLifeline3.Click
        LifelineManager.Use(3)
    End Sub

    Private Sub btnLifeline4_Click(sender As Object, e As EventArgs) Handles btnLifeline4.Click
        LifelineManager.Use(4)
    End Sub

    Private Sub chkLifeline1_CheckedChanged(sender As Object, e As EventArgs) Handles chkLifeline1Unused.Click
        If chkLifeline1Unused.Checked = True Then
            btnLifeline1.Enabled = True
            LifelineManager.EnableLifeline(1, True)
        End If
        If chkLifeline1Unused.Checked = False Then
            btnLifeline1.Enabled = False
            LifelineManager.EnableLifeline(1, False)
        End If
    End Sub

    Private Sub chkLifeline3_CheckedChanged(sender As Object, e As EventArgs) Handles chkLifeline3Unused.Click
        If chkLifeline3Unused.Checked = True Then
            btnLifeline3.Enabled = True
            LifelineManager.EnableLifeline(3, True)
        End If
        If chkLifeline3Unused.Checked = False Then
            btnLifeline3.Enabled = False
            LifelineManager.EnableLifeline(3, False)
        End If
    End Sub

    Private Sub chkLifeline4_CheckedChanged(sender As Object, e As EventArgs) Handles chkLifeline4Unused.Click
        If chkLifeline4Unused.Checked = True Then
            btnLifeline4.Enabled = True
            LifelineManager.EnableLifeline(4, True)
        End If
        If chkLifeline4Unused.Checked = False Then
            btnLifeline4.Enabled = False
            LifelineManager.EnableLifeline(4, False)
        End If
    End Sub

    Private Sub chkLifeline2_CheckedChanged(sender As Object, e As EventArgs) Handles chkLifeline2Unused.Click
        If chkLifeline2Unused.Checked = True Then
            btnLifeline2.Enabled = True
            LifelineManager.EnableLifeline(2, True)
        End If
        If chkLifeline2Unused.Checked = False Then
            btnLifeline2.Enabled = False
            LifelineManager.EnableLifeline(2, False)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        User.NewUser()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        If lblAnswer.Text = "A" Then
            HostScreen.txtA.BackColor = Color.Green
            GuestScreen.txtA.BackColor = Color.Green
            txtA.BackColor = Color.Green
        End If
        If lblAnswer.Text = "B" Then
            HostScreen.txtB.BackColor = Color.Green
            GuestScreen.txtB.BackColor = Color.Green
            txtB.BackColor = Color.Green
        End If
        If lblAnswer.Text = "C" Then
            HostScreen.txtC.BackColor = Color.Green
            GuestScreen.txtC.BackColor = Color.Green
            txtC.BackColor = Color.Green
        End If
        If lblAnswer.Text = "D" Then
            HostScreen.txtD.BackColor = Color.Green
            GuestScreen.txtD.BackColor = Color.Green
            txtD.BackColor = Color.Green
        End If
    End Sub

    Dim wa As Integer = 0
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        If wa = 0 Then
            User.a = 0
            wa = 1
            TVControlPnl.pnlTotal.Visible = True
            TVControlPnl.pnlStrap.Visible = True
            TVControlPnl.pnlQuestion.Visible = False
            intSound += 1

            With Sounds.sndGeneral
                .URL = Sounds.SoundsPath + Profile.Options.snd_GameOver
                .controls.play()
            End With
        ElseIf wa = 1 Then
            wa = 0
            TVControlPnl.pnlTotal.Visible = False
            TVControlPnl.pnlStrap.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Computer.Audio.Stop()
        Timer1.Stop()
        Question.useMusic = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkCorrectAnswer.CheckedChanged
        If chkCorrectAnswer.Checked = True Then
            lblAnswer.Visible = True
        End If
        If chkCorrectAnswer.Checked = False Then
            lblAnswer.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        HaltSound()
        Timer2.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        HaltSound()
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        HostScreen.lblTime.Text = HostScreen.lblTime.Text - 1
        GuestScreen.lblTime.Text = GuestScreen.lblTime.Text - 1
        TVControlPnl.lblTime.Text = TVControlPnl.lblTime.Text - 1
        lblTime.Text = lblTime.Text - 1
        If lblTime.Text = 0 Then
            HostScreen.lblTime.Visible = False
            GuestScreen.lblTime.Visible = False
            lblTime.Visible = False
            tmrTime.Stop()
            LifelinePO.plusone = 0
            tmrResume.Start()
            chkLifeline2Unused.Checked = False
            HostScreen.picLifeline3.Image = My.Resources.ll_phone_used
            GuestScreen.picLifeline3.Image = My.Resources.ll_phone_used
            TVControlPnl.picLifeline2.Image = My.Resources.ll_phone_used
            btnLifeline2.Enabled = False
        End If
    End Sub

    Private Sub tmrResume_Tick(sender As Object, e As EventArgs) Handles tmrResume.Tick
        Question.PlayQuestionCue()
        TVControlPnl.lblTime.Visible = True
        TVControlPnl.lblTime.Text = "30"
        lblTime.Text = "30"
        GuestScreen.lblTime.Text = "30"
        HostScreen.lblTime.Text = "30"
        TVControlPnl.pnlTime.Visible = False
        tmrResume.Stop()
    End Sub

    Private Sub tmrRules_Tick(sender As Object, e As EventArgs) Handles tmrRules.Tick
        Game.SetValues()
        Game.level = Game.level + 1
        If Game.level > 15 Then
            tmrRules.Stop()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        With Sounds.sndGeneralBed
            .URL = Sounds.SoundsPath + Profile.Options.snd_ExplainRules
            .controls.play()
        End With
        HostScreen.lblExplainRules.ForeColor = Color.Blue
    End Sub

    Private Sub btnLL1_Click(sender As Object, e As EventArgs) Handles btnLL1.Click
        btnLifeline1.BackgroundImage = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline1)
        HostScreen.picLifeline1.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline1)
        GuestScreen.picLifeline1.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline1)
        TVControlPnl.picLifeline1.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline1)
        tmrLifelineBling.Start()

        Dim ping As New WMPLib.WindowsMediaPlayer
        With ping
            .URL = Sounds.SoundsPath + Profile.Options.snd_Lifeline1Ping
            .controls.play()
        End With
    End Sub

    Private Sub btnLL2_Click(sender As Object, e As EventArgs) Handles btnLL2.Click
        btnLifeline2.BackgroundImage = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline2)
        HostScreen.picLifeline2.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline2)
        GuestScreen.picLifeline2.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline2)
        TVControlPnl.picLifeline2.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline2)
        tmrLifelineBling.Start()

        Dim ping As New WMPLib.WindowsMediaPlayer
        With ping
            .URL = Sounds.SoundsPath + Profile.Options.snd_Lifeline2Ping
            .controls.play()
        End With
    End Sub

    Private Sub btnLL3_Click(sender As Object, e As EventArgs) Handles btnLL3.Click
        btnLifeline3.BackgroundImage = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline3)
        HostScreen.picLifeline3.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline3)
        GuestScreen.picLifeline3.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline3)
        TVControlPnl.picLifeline3.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline3)
        tmrLifelineBling.Start()

        Dim ping As New WMPLib.WindowsMediaPlayer
        With ping
            .URL = Sounds.SoundsPath + Profile.Options.snd_Lifeline3Ping
            .controls.play()
        End With
    End Sub

    Private Sub btnLL4_Click(sender As Object, e As EventArgs) Handles btnLL4.Click
        btnLifeline4.BackgroundImage = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline4)
        HostScreen.picLifeline4.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline4)
        GuestScreen.picLifeline4.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline4)
        TVControlPnl.picLifeline4.Image = LifelineManager.GetLifelineBlingImage(Profile.Options.Lifeline4)
        tmrLifelineBling.Start()

        Dim ping As New WMPLib.WindowsMediaPlayer
        With ping
            .URL = Sounds.SoundsPath + Profile.Options.snd_Lifeline4Ping
            .controls.play()
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnTreePr.Click
        tmrRules.Start()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnTreeReset.Click
        Game.level = 0
        Game.SetValues()
    End Sub

    Private Sub btnShowTree_Click(sender As Object, e As EventArgs) Handles btnShowTree.Click
        TVControlPnl.picTree.Visible = True
        TVControlPnl.pnlQuestion.Visible = False
        TVControlPnl.pnlStrap.Visible = False
    End Sub

    Private Sub btnHideTree_Click(sender As Object, e As EventArgs) Handles btnHideTree.Click
        TVControlPnl.picTree.Visible = False
    End Sub

    Private Sub chkShowQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowQuestion.CheckedChanged
        If chkShowQuestion.Checked = True Then
            TVControlPnl.pnlQuestion.Visible = True
        End If
        If chkShowQuestion.Checked = False Then
            TVControlPnl.pnlQuestion.Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        clrBGColor.ShowDialog()
        TVControlPnl.BackColor = clrBGColor.Color
    End Sub

    Private Sub ResetAllUsedQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim reset As New QDatabase
        reset.resetDB()
    End Sub

    Private Sub TVScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TVScreenToolStripMenuItem.Click
        TVControlPnl.Show()
    End Sub

    Private Sub HostScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostScreenToolStripMenuItem.Click
        HostScreen.Show()
    End Sub

    Private Sub GuestScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestScreenToolStripMenuItem.Click
        GuestScreen.Show()
    End Sub

    Private Sub btnUnlockSwitch_Click(sender As Object, e As EventArgs) Handles btnUnlockSwitch.Click
        Select Case Game.gamemode
            Case 0
                Game.ChangeMode(1)
            Case 1
                Game.ChangeMode(0)
        End Select
    End Sub

    Private Sub tmrLifelineBling_Tick(sender As Object, e As EventArgs) Handles tmrLifelineBling.Tick
        btnLifeline1.BackgroundImage = LifelineManager.GetLifelineImage(Profile.Options.Lifeline1)
        HostScreen.picLifeline1.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline1)
        GuestScreen.picLifeline1.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline1)
        TVControlPnl.picLifeline1.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline1)

        btnLifeline2.BackgroundImage = LifelineManager.GetLifelineImage(Profile.Options.Lifeline2)
        HostScreen.picLifeline2.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline2)
        GuestScreen.picLifeline2.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline2)
        TVControlPnl.picLifeline2.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline2)

        btnLifeline3.BackgroundImage = LifelineManager.GetLifelineImage(Profile.Options.Lifeline3)
        HostScreen.picLifeline3.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline3)
        GuestScreen.picLifeline3.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline3)
        TVControlPnl.picLifeline3.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline3)

        btnLifeline4.BackgroundImage = LifelineManager.GetLifelineImage(Profile.Options.Lifeline4)
        HostScreen.picLifeline4.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline4)
        GuestScreen.picLifeline4.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline4)
        TVControlPnl.picLifeline4.Image = LifelineManager.GetLifelineImage(Profile.Options.Lifeline4)
        tmrLifelineBling.Stop()
    End Sub

    Private Sub btnFFF_Click(sender As Object, e As EventArgs) Handles btnFFF.Click
        FFFServer.Show()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Question.UndoAnswer(True)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ChangeMoneyStrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeMoneyStrapToolStripMenuItem.Click
        ChangeMoneyStrap.ShowDialog()
    End Sub

    Private Sub ControlPanel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CoreConsole.isRunning = False
    End Sub

    Private Sub QuestionsEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestionsEditorToolStripMenuItem.Click
        Try
            Process.Start("qedit.exe")
        Catch ex As Exception
            MessageBox.Show("An error occured while opening: " + Environment.NewLine + ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CoreConsole.LogMsgDate("An error occured while opening:")
            CoreConsole.LogMsg(ex.Message())
        End Try
    End Sub

    Private Sub HostMessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostMessagesToolStripMenuItem.Click
        HostMessages.Show()
    End Sub

    Private Sub btnSendToHost_Click(sender As Object, e As EventArgs) Handles btnSendToHost.Click
        txtHostMessages.AppendText(drpNextHostMessage.Text.ToUpper() + Environment.NewLine)
        HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + drpNextHostMessage.Text.ToUpper()
    End Sub

    Private Sub btnClearHostMessages_Click(sender As Object, e As EventArgs) Handles btnClearHostMessages.Click
        txtHostMessages.Clear()
        HostScreen.lblHostMsg.Text = ""
    End Sub

    Private Sub drpNextHostMessage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles drpNextHostMessage.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the Button1_Click Event
            btnSendToHost.PerformClick()
        End If
    End Sub

    Private Sub btnTestLifeline_Click(sender As Object, e As EventArgs)
        LifeLineDouble.LifelineUse1()
    End Sub

    Private Sub ChangeBackgroundColorTVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackgroundColorTVToolStripMenuItem.Click
        clrBGColor.ShowDialog()
        TVControlPnl.BackColor = clrBGColor.Color
    End Sub

    Private Sub X10801080pToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X10801080pToolStripMenuItem.Click
        GameResolution.ChangeTo1080()
        GameResolution.ChangeTo1080()
    End Sub

    Private Sub X720720pToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X720720pToolStripMenuItem.Click
        GameResolution.ChangeTo720()
        GameResolution.ChangeTo720()
    End Sub

    Private Sub ShowOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowOptionsToolStripMenuItem.Click
        OptionsScreen.Show()
    End Sub

    Private Sub ShowConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowConsoleToolStripMenuItem.Click
        CoreConsole.Show()
    End Sub
End Class
