Imports System.Data.SqlClient

Public Class OptionsScreen

    Public Shared Lifeline1_availableAt As Integer
    Public Shared Lifeline2_availableAt As Integer
    Public Shared Lifeline3_availableAt As Integer
    Public Shared Lifeline4_availableAt As Integer
    Public Shared WinningStrapTexture As Integer
    Public Shared QuestionTexture As Integer

    Private Sub OptionsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFullScrHostScreen.DataSource = New List(Of String)(Monitor.ConnectedScreens)
        cmbFullScrGuestScreen.DataSource = New List(Of String)(Monitor.ConnectedScreens)
        cmbFullScrTVScreen.DataSource = New List(Of String)(Monitor.ConnectedScreens)
        Lifeline1_availableAt = Profile.Options.Lifeline1_available
        Lifeline2_availableAt = Profile.Options.Lifeline2_available
        Lifeline3_availableAt = Profile.Options.Lifeline3_available
        Lifeline4_availableAt = Profile.Options.Lifeline4_available

        nmrTotalLifelines.Value = Profile.Options.TotalLifelines
        cmbLifeline1.Text = Profile.Options.Lifeline1
        cmbLifeline2.Text = Profile.Options.Lifeline2
        cmbLifeline3.Text = Profile.Options.Lifeline3
        cmbLifeline4.Text = Profile.Options.Lifeline4

        Select Case Lifeline1_availableAt
            Case 0
                radL1Always.Checked = True
            Case 1
                radL1AfterQ5.Checked = True
            Case 2
                radL1AfterQ10.Checked = True
            Case 3
                radL1RiskMode.Checked = True
        End Select
        Select Case Lifeline2_availableAt
            Case 0
                radL2Always.Checked = True
            Case 1
                radL2AfterQ5.Checked = True
            Case 2
                radL2AfterQ10.Checked = True
            Case 3
                radL2RiskMode.Checked = True
        End Select
        Select Case Lifeline3_availableAt
            Case 0
                radL3Always.Checked = True
            Case 1
                radL3AfterQ5.Checked = True
            Case 2
                radL3AfterQ10.Checked = True
            Case 3
                radL3RiskMode.Checked = True
        End Select
        Select Case Lifeline4_availableAt
            Case 0
                radL4Always.Checked = True
            Case 1
                radL4AfterQ5.Checked = True
            Case 2
                radL4AfterQ10.Checked = True
            Case 3
                radL4RiskMode.Checked = True
        End Select

        picWinningStrapTexture.BackgroundImage = WinningStrap.GetTexture()
        lblWinningStrapTexture.ForeColor = WinningStrap.GetTextureFontColor()
        Select Case Profile.Options.WinningStrapTexture
            Case 0
                radStrapYellow.Checked = True
                WinningStrapTexture = 0
            Case 1
                radStrapGreen.Checked = True
                WinningStrapTexture = 1
            Case 2
                radStrapBlack.Checked = True
                WinningStrapTexture = 2
        End Select

        UpdateHostMessagesList()

        cmbResHostScreen.Text = Profile.Options.Resolution_HostScreen
        cmbResGuestScreen.Text = Profile.Options.Resolution_GuestScreen
        cmbResTVScreen.Text = Profile.Options.Resolution_TVScreen
        chkAutoShowHostScreen.Checked = Profile.Options.AutoShow_HostScreen
        chkAutoShowGuestScreen.Checked = Profile.Options.AutoShow_GuestScreen
        chkAutoShowTVScreen.Checked = Profile.Options.AutoShow_TVScreen
        chkFullScrHostScreen.Checked = Profile.Options.FullScreen_HostScreen_Enable
        chkFullScrGuestScreen.Checked = Profile.Options.FullScreen_GuestScreen_Enable
        chkFullScrTVScreen.Checked = Profile.Options.FullScreen_TVScreen_Enable
        cmbFullScrHostScreen.Text = Profile.Options.FullScreen_HostScreen_Monitor
        cmbFullScrGuestScreen.Text = Profile.Options.FullScreen_GuestScreen_Monitor
        cmbFullScrTVScreen.Text = Profile.Options.FullScreen_TVScreen_Monitor

        chkClearHostMessages.Checked = Profile.Options.S_ClearHostMessagesAtNewQuestion
        chkShowAnswerOnlyAtFinal.Checked = Profile.Options.S_ShowAnswerOnlyOnHostScreenAtFinal
        chkAutoHideQuestionAtPlusOne.Checked = Profile.Options.S_AutoHideQuestionAtPlusOne
        chkAutoShowTotalWinnings.Checked = Profile.Options.S_AutoShowTotalWinnings
        chkAutoHideQuestionAtWalkAway.Checked = Profile.Options.S_AutoHideQuestionAtWalkAway

        nmrFFFPortNumber.Value = Profile.Options.FFF_Port

        txtSndOpening.Text = Profile.Options.snd_Opening
        txtSndCommercialIn.Text = Profile.Options.snd_CommIn
        txtSndCommercialOut.Text = Profile.Options.snd_CommOut
        txtSndClosing.Text = Profile.Options.snd_Closing

        txtSndLifeline1Ping.Text = Profile.Options.snd_Lifeline1Ping
        txtSndLifeline2Ping.Text = Profile.Options.snd_Lifeline2Ping
        txtSndLifeline3Ping.Text = Profile.Options.snd_Lifeline3Ping
        txtSndLifeline4Ping.Text = Profile.Options.snd_Lifeline4Ping

        txtSndExplainRules.Text = Profile.Options.snd_ExplainRules

        txtSndToHotSeat.Text = Profile.Options.snd_ToHotSeat
        txtSndToHotSeatLD.Text = Profile.Options.snd_ToHotSeat_LD
        txtSndRiskModeActivate.Text = Profile.Options.snd_RiskModeActive
        txtSndWalkAway1.Text = Profile.Options.snd_WalkAway1
        txtSndWalkAway2.Text = Profile.Options.snd_WalkAway2
        txtSndGameOver.Text = Profile.Options.snd_GameOver

        txtSndFMeet2.Text = Profile.Options.snd_F_Meet2
        txtSndFMeet3.Text = Profile.Options.snd_F_Meet3
        txtSndFMeet4.Text = Profile.Options.snd_F_Meet4
        txtSndFMeet5.Text = Profile.Options.snd_F_Meet5
        txtSndFMeet6.Text = Profile.Options.snd_F_Meet6
        txtSndFMeet7.Text = Profile.Options.snd_F_Meet7
        txtSndFMeet8.Text = Profile.Options.snd_F_Meet8
        txtSndFReadQuestion.Text = Profile.Options.snd_F_ReadQuestion
        txtSndFThreeNotes.Text = Profile.Options.snd_F_ThreeNotes
        txtSndFThinking.Text = Profile.Options.snd_F_Thinking
        txtSndFReadCorrectOrder.Text = Profile.Options.snd_F_ReadCorrectOrder
        txtSndFOrder1.Text = Profile.Options.snd_F_Order1
        txtSndFOrder2.Text = Profile.Options.snd_F_Order2
        txtSndFOrder3.Text = Profile.Options.snd_F_Order3
        txtSndFOrder4.Text = Profile.Options.snd_F_Order4
        txtSndFWhoWasCorrect.Text = Profile.Options.snd_F_WhoWasCorrect
        txtSndFWinner.Text = Profile.Options.snd_F_Winner

        txtSndATAStart.Text = Profile.Options.snd_ATA_Start
        txtSndATAVoting.Text = Profile.Options.snd_ATA_Voting
        txtSndATAEnd.Text = Profile.Options.snd_ATA_End

        txtSndP1Start.Text = Profile.Options.snd_P1_Start
        txtSndP1Clock.Text = Profile.Options.snd_P1_Clock
        txtSndP1EndEarly.Text = Profile.Options.snd_P1_EndEarly

        txtSndDD1stAnswer.Text = Profile.Options.snd_Double_1stAnswer
        txtSndDD1stFinal.Text = Profile.Options.snd_Double_1stFinal
        txtSndDD2ndAnswer.Text = Profile.Options.snd_Double_2ndAnswer
        txtSndDD2ndFinal.Text = Profile.Options.snd_Double_2ndFinal

        txtSndSwitchActivate.Text = Profile.Options.snd_Switch0_Activate
        txtSndSwitchShowCorrect.Text = Profile.Options.snd_Switch0_ShowCorrect
        txtSndSwitchClear.Text = Profile.Options.snd_Switch0_Clear

        txtSnd5050Use.Text = Profile.Options.snd_5050

        txtSndHostStart.Text = Profile.Options.snd_Host_Start
        txtSndHostEnd.Text = Profile.Options.snd_Host_End

        txtSndQ1to5LD.Text = Profile.Options.snd_Q1to5LightsDown
        txtSndQ6LD.Text = Profile.Options.snd_Q6LightsDown
        txtSndQ7LD.Text = Profile.Options.snd_Q7LightsDown
        txtSndQ8LD.Text = Profile.Options.snd_Q8LightsDown
        txtSndQ9LD.Text = Profile.Options.snd_Q9LightsDown
        txtSndQ10LD.Text = Profile.Options.snd_Q10LightsDown
        txtSndQ11LD.Text = Profile.Options.snd_Q11LightsDown
        txtSndQ12LD.Text = Profile.Options.snd_Q12LightsDown
        txtSndQ13LD.Text = Profile.Options.snd_Q13LightsDown
        txtSndQ14LD.Text = Profile.Options.snd_Q14LightsDown
        txtSndQ15LD.Text = Profile.Options.snd_Q15LightsDown

        chkSndStopQ1to5LD.Checked = Profile.Options.snd_Q1to5LightsDown_Stop
        chkSndStopQ6LD.Checked = Profile.Options.snd_Q6LightsDown_Stop
        chkSndStopQ7LD.Checked = Profile.Options.snd_Q7LightsDown_Stop
        chkSndStopQ8LD.Checked = Profile.Options.snd_Q8LightsDown_Stop
        chkSndStopQ9LD.Checked = Profile.Options.snd_Q9LightsDown_Stop
        chkSndStopQ10LD.Checked = Profile.Options.snd_Q10LightsDown_Stop
        chkSndStopQ11LD.Checked = Profile.Options.snd_Q11LightsDown_Stop
        chkSndStopQ12LD.Checked = Profile.Options.snd_Q12LightsDown_Stop
        chkSndStopQ13LD.Checked = Profile.Options.snd_Q13LightsDown_Stop
        chkSndStopQ14LD.Checked = Profile.Options.snd_Q14LightsDown_Stop
        chkSndStopQ15LD.Checked = Profile.Options.snd_Q15LightsDown_Stop

        txtSndQ1to5Bed.Text = Profile.Options.snd_Q1to5Bed
        txtSndQ6Bed.Text = Profile.Options.snd_Q6Bed
        txtSndQ7Bed.Text = Profile.Options.snd_Q7Bed
        txtSndQ8Bed.Text = Profile.Options.snd_Q8Bed
        txtSndQ9Bed.Text = Profile.Options.snd_Q9Bed
        txtSndQ10Bed.Text = Profile.Options.snd_Q10Bed
        txtSndQ11Bed.Text = Profile.Options.snd_Q11Bed
        txtSndQ12Bed.Text = Profile.Options.snd_Q12Bed
        txtSndQ13Bed.Text = Profile.Options.snd_Q13Bed
        txtSndQ14Bed.Text = Profile.Options.snd_Q14Bed
        txtSndQ15Bed.Text = Profile.Options.snd_Q15Bed

        txtSndQ1Final.Text = Profile.Options.snd_Q1Final
        txtSndQ2Final.Text = Profile.Options.snd_Q2Final
        txtSndQ3Final.Text = Profile.Options.snd_Q3Final
        txtSndQ4Final.Text = Profile.Options.snd_Q4Final
        txtSndQ5Final.Text = Profile.Options.snd_Q5Final
        txtSndQ6Final.Text = Profile.Options.snd_Q6Final
        txtSndQ7Final.Text = Profile.Options.snd_Q7Final
        txtSndQ8Final.Text = Profile.Options.snd_Q8Final
        txtSndQ9Final.Text = Profile.Options.snd_Q9Final
        txtSndQ10Final.Text = Profile.Options.snd_Q10Final
        txtSndQ11Final.Text = Profile.Options.snd_Q11Final
        txtSndQ12Final.Text = Profile.Options.snd_Q12Final
        txtSndQ13Final.Text = Profile.Options.snd_Q13Final
        txtSndQ14Final.Text = Profile.Options.snd_Q14Final
        txtSndQ15Final.Text = Profile.Options.snd_Q15Final

        txtSndQ1to4Correct.Text = Profile.Options.snd_Q1to4Correct
        txtSndQ5Correct.Text = Profile.Options.snd_Q5Correct
        txtSndQ6Correct.Text = Profile.Options.snd_Q6Correct
        txtSndQ7Correct.Text = Profile.Options.snd_Q7Correct
        txtSndQ8Correct.Text = Profile.Options.snd_Q8Correct
        txtSndQ9Correct.Text = Profile.Options.snd_Q9Correct
        txtSndQ10Correct.Text = Profile.Options.snd_Q10Correct
        txtSndQ10RCorrect.Text = Profile.Options.snd_Q10Correct_R
        txtSndQ11Correct.Text = Profile.Options.snd_Q11Correct
        txtSndQ12Correct.Text = Profile.Options.snd_Q12Correct
        txtSndQ13Correct.Text = Profile.Options.snd_Q13Correct
        txtSndQ14Correct.Text = Profile.Options.snd_Q14Correct
        txtSndQ15Correct.Text = Profile.Options.snd_Q15Correct

        txtSndQ1to5Wrong.Text = Profile.Options.snd_Q1to5Wrong
        txtSndQ6Wrong.Text = Profile.Options.snd_Q6Wrong
        txtSndQ7Wrong.Text = Profile.Options.snd_Q7Wrong
        txtSndQ8Wrong.Text = Profile.Options.snd_Q8Wrong
        txtSndQ9Wrong.Text = Profile.Options.snd_Q9Wrong
        txtSndQ10Wrong.Text = Profile.Options.snd_Q10Wrong
        txtSndQ11Wrong.Text = Profile.Options.snd_Q11Wrong
        txtSndQ12Wrong.Text = Profile.Options.snd_Q12Wrong
        txtSndQ13Wrong.Text = Profile.Options.snd_Q13Wrong
        txtSndQ14Wrong.Text = Profile.Options.snd_Q14Wrong
        txtSndQ15Wrong.Text = Profile.Options.snd_Q15Wrong
    End Sub

#Region "Sounds"
    Private Function GetSoundFile(ByVal currentFile As String) As String
        Dim soundfile = New OptionsSelectSound

        If soundfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim newfile As String = soundfile.txtSelectedFile.Text
            Return newfile
        Else
            Return currentFile
        End If
    End Function

    Private Sub txtSndQ15LD_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndQ9Wrong.MouseDoubleClick, txtSndQ9LD.MouseDoubleClick,
    txtSndQ9Final.MouseDoubleClick, txtSndQ9Correct.MouseDoubleClick, txtSndQ9Bed.MouseDoubleClick, txtSndQ8Wrong.MouseDoubleClick, txtSndQ8LD.MouseDoubleClick,
    txtSndQ8Final.MouseDoubleClick, txtSndQ8Correct.MouseDoubleClick, txtSndQ8Bed.MouseDoubleClick, txtSndQ7Wrong.MouseDoubleClick, txtSndQ7LD.MouseDoubleClick,
    txtSndQ7Final.MouseDoubleClick, txtSndQ7Correct.MouseDoubleClick, txtSndQ7Bed.MouseDoubleClick, txtSndQ6Wrong.MouseDoubleClick, txtSndQ6LD.MouseDoubleClick,
    txtSndQ6Final.MouseDoubleClick, txtSndQ6Correct.MouseDoubleClick, txtSndQ6Bed.MouseDoubleClick, txtSndQ5Final.MouseDoubleClick, txtSndQ5Correct.MouseDoubleClick,
    txtSndQ4Final.MouseDoubleClick, txtSndQ3Final.MouseDoubleClick, txtSndQ2Final.MouseDoubleClick, txtSndQ1to5Wrong.MouseDoubleClick, txtSndQ1to5LD.MouseDoubleClick,
    txtSndQ1to5Bed.MouseDoubleClick, txtSndQ1to4Correct.MouseDoubleClick, txtSndQ1Final.MouseDoubleClick, txtSndQ15Wrong.MouseDoubleClick, txtSndQ15LD.MouseDoubleClick,
    txtSndQ15Final.MouseDoubleClick, txtSndQ15Correct.MouseDoubleClick, txtSndQ15Bed.MouseDoubleClick, txtSndQ14Wrong.MouseDoubleClick, txtSndQ14LD.MouseDoubleClick,
    txtSndQ14Final.MouseDoubleClick, txtSndQ14Correct.MouseDoubleClick, txtSndQ14Bed.MouseDoubleClick, txtSndQ13Wrong.MouseDoubleClick, txtSndQ13LD.MouseDoubleClick,
    txtSndQ13Final.MouseDoubleClick, txtSndQ13Correct.MouseDoubleClick, txtSndQ13Bed.MouseDoubleClick, txtSndQ12Wrong.MouseDoubleClick, txtSndQ12LD.MouseDoubleClick,
    txtSndQ12Final.MouseDoubleClick, txtSndQ12Correct.MouseDoubleClick, txtSndQ12Bed.MouseDoubleClick, txtSndQ11Wrong.MouseDoubleClick, txtSndQ11LD.MouseDoubleClick,
    txtSndQ11Final.MouseDoubleClick, txtSndQ11Correct.MouseDoubleClick, txtSndQ11Bed.MouseDoubleClick, txtSndQ10Wrong.MouseDoubleClick, txtSndQ10RCorrect.MouseDoubleClick,
    txtSndQ10LD.MouseDoubleClick, txtSndQ10Final.MouseDoubleClick, txtSndQ10Correct.MouseDoubleClick, txtSndQ10Bed.MouseDoubleClick, txtSndWalkAway2.MouseDoubleClick,
    txtSndWalkAway1.MouseDoubleClick, txtSndToHotSeatLD.MouseDoubleClick, txtSndToHotSeat.MouseDoubleClick, txtSndSwitchShowCorrect.MouseDoubleClick,
    txtSndSwitchClear.MouseDoubleClick, txtSndSwitchActivate.MouseDoubleClick, txtSndRiskModeActivate.MouseDoubleClick, txtSndP1Start.MouseDoubleClick,
    txtSndP1EndEarly.MouseDoubleClick, txtSndP1Clock.MouseDoubleClick, txtSndOpening.MouseDoubleClick, txtSndLifeline4Ping.MouseDoubleClick,
    txtSndLifeline3Ping.MouseDoubleClick, txtSndLifeline2Ping.MouseDoubleClick, txtSndLifeline1Ping.MouseDoubleClick, txtSndGameOver.MouseDoubleClick,
    txtSndFWinner.MouseDoubleClick, txtSndFWhoWasCorrect.MouseDoubleClick, txtSndFThreeNotes.MouseDoubleClick, txtSndFThinking.MouseDoubleClick,
    txtSndFReadQuestion.MouseDoubleClick, txtSndFReadCorrectOrder.MouseDoubleClick, txtSndFOrder4.MouseDoubleClick, txtSndFOrder3.MouseDoubleClick,
    txtSndFOrder2.MouseDoubleClick, txtSndFOrder1.MouseDoubleClick, txtSndFMeet8.MouseDoubleClick, txtSndFMeet7.MouseDoubleClick, txtSndFMeet6.MouseDoubleClick,
    txtSndFMeet5.MouseDoubleClick, txtSndFMeet4.MouseDoubleClick, txtSndFMeet3.MouseDoubleClick, txtSndFMeet2.MouseDoubleClick, txtSndExplainRules.MouseDoubleClick,
    txtSndCommercialOut.MouseDoubleClick, txtSndCommercialIn.MouseDoubleClick, txtSndClosing.MouseDoubleClick, txtSndATAVoting.MouseDoubleClick, txtSndATAStart.MouseDoubleClick,
    txtSndATAEnd.MouseDoubleClick, txtSnd5050Use.MouseDoubleClick, txtSndDD1stAnswer.MouseDoubleClick, txtSndDD1stFinal.MouseDoubleClick, txtSndDD2ndAnswer.MouseDoubleClick, txtSndDD2ndFinal.MouseDoubleClick

        Dim t As TextBox = DirectCast(sender, TextBox)
        t.Text = GetSoundFile(t.Text)

    End Sub

    Private Sub txtSndQ5Final_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSndQ5Final.MouseClick,
        txtSndQ4Final.MouseClick, txtSndQ3Final.MouseClick, txtSndQ2Final.MouseClick, txtSndQ1Final.MouseClick

        If My.Computer.Keyboard.CtrlKeyDown Then
            Dim t As TextBox = DirectCast(sender, TextBox)
            t.Text = ""
        End If
    End Sub
#End Region

#Region "Save Settings"
    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Game.CurrentProfile.SaveSettings()
        Game.CurrentProfile.LoadSettings()

        TVControlPnl.pnlStrap.BackgroundImage = WinningStrap.GetTexture()
        TVControlPnl.lblAmount.ForeColor = WinningStrap.GetTextureFontColor()

        LifelineManager.UnlockLifeline(1)
        LifelineManager.UnlockLifeline(2)
        LifelineManager.UnlockLifeline(3)
        LifelineManager.UnlockLifeline(4)

        Monitor.ApplyScreenSettings()
        Monitor.ApplyScreenSettings()

        ControlPanel.drpNextHostMessage.Items.Clear()
        ControlPanel.drpNextHostMessage.Items.AddRange(ControlPanel.GetHostMessages().ToArray())

        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Game.CurrentProfile.SaveSettings()
        Game.CurrentProfile.LoadSettings()

        TVControlPnl.pnlStrap.BackgroundImage = WinningStrap.GetTexture()
        TVControlPnl.lblAmount.ForeColor = WinningStrap.GetTextureFontColor()

        LifelineManager.UnlockLifeline(1)
        LifelineManager.UnlockLifeline(2)
        LifelineManager.UnlockLifeline(3)
        LifelineManager.UnlockLifeline(4)

        Monitor.ApplyScreenSettings()
        Monitor.ApplyScreenSettings()

        ControlPanel.drpNextHostMessage.Items.Clear()
        ControlPanel.drpNextHostMessage.Items.AddRange(ControlPanel.GetHostMessages().ToArray())

        MessageBox.Show("Settings saved succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "Screen Settings"
    Private Sub btnIdentifyMonitors_Click(sender As Object, e As EventArgs) Handles btnIdentifyMonitors.Click
        Monitor.Identify()
        btnIdentifyMonitors.Enabled = False
        tmrEnableIdentifyButton.Start()
    End Sub

    Private Sub tmrEnableIdentifyButton_Tick(sender As Object, e As EventArgs) Handles tmrEnableIdentifyButton.Tick
        btnIdentifyMonitors.Enabled = True
        tmrEnableIdentifyButton.Stop()
    End Sub

    Private Sub chkFullScrHostScreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullScrHostScreen.CheckedChanged
        If chkFullScrHostScreen.Checked Then
            cmbFullScrHostScreen.Enabled = True
        Else
            cmbFullScrHostScreen.Enabled = False
        End If
    End Sub

    Private Sub chkFullScrGuestScreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullScrGuestScreen.CheckedChanged
        If chkFullScrGuestScreen.Checked Then
            cmbFullScrGuestScreen.Enabled = True
        Else
            cmbFullScrGuestScreen.Enabled = False
        End If
    End Sub

    Private Sub chkFullScrTVScreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullScrTVScreen.CheckedChanged
        If chkFullScrTVScreen.Checked Then
            cmbFullScrTVScreen.Enabled = True
        Else
            cmbFullScrTVScreen.Enabled = False
        End If
    End Sub
#End Region

#Region "Lifeline Settings"
    Private Sub nmrTotalLifelines_ValueChanged(sender As Object, e As EventArgs) Handles nmrTotalLifelines.ValueChanged
        Select Case nmrTotalLifelines.Value
            Case 4
                grpLifeline1.Visible = True
                grpLifeline2.Visible = True
                grpLifeline3.Visible = True
                grpLifeline4.Visible = True
            Case 3
                grpLifeline1.Visible = True
                grpLifeline2.Visible = True
                grpLifeline3.Visible = True
                grpLifeline4.Visible = False
            Case 2
                grpLifeline1.Visible = True
                grpLifeline2.Visible = True
                grpLifeline3.Visible = False
                grpLifeline4.Visible = False
            Case 1
                grpLifeline1.Visible = True
                grpLifeline2.Visible = False
                grpLifeline3.Visible = False
                grpLifeline4.Visible = False
        End Select
    End Sub

    Private Sub cmbLifeline1_TextChanged(sender As Object, e As EventArgs) Handles cmbLifeline1.TextChanged
        Select Case cmbLifeline1.Text
            Case "ask_audience"
                picLifeline1.BackgroundImage = My.Resources.ll_audience
            Case "50_50"
                picLifeline1.BackgroundImage = My.Resources.ll_5050
            Case "plus_one"
                picLifeline1.BackgroundImage = My.Resources.ll_plusone
            Case "switch"
                picLifeline1.BackgroundImage = My.Resources.ll_switch
            Case "double_dip"
                picLifeline1.BackgroundImage = My.Resources.ll_double
            Case "ask_host"
                picLifeline1.BackgroundImage = My.Resources.ll_host
        End Select
    End Sub

    Private Sub cmbLifeline2_TextChanged(sender As Object, e As EventArgs) Handles cmbLifeline2.TextChanged
        Select Case cmbLifeline2.Text
            Case "ask_audience"
                picLifeline2.BackgroundImage = My.Resources.ll_audience
            Case "50_50"
                picLifeline2.BackgroundImage = My.Resources.ll_5050
            Case "plus_one"
                picLifeline2.BackgroundImage = My.Resources.ll_plusone
            Case "switch"
                picLifeline2.BackgroundImage = My.Resources.ll_switch
            Case "double_dip"
                picLifeline2.BackgroundImage = My.Resources.ll_double
            Case "ask_host"
                picLifeline2.BackgroundImage = My.Resources.ll_host
        End Select
    End Sub

    Private Sub cmbLifeline3_TextChanged(sender As Object, e As EventArgs) Handles cmbLifeline3.TextChanged
        Select Case cmbLifeline3.Text
            Case "ask_audience"
                picLifeline3.BackgroundImage = My.Resources.ll_audience
            Case "50_50"
                picLifeline3.BackgroundImage = My.Resources.ll_5050
            Case "plus_one"
                picLifeline3.BackgroundImage = My.Resources.ll_plusone
            Case "switch"
                picLifeline3.BackgroundImage = My.Resources.ll_switch
            Case "double_dip"
                picLifeline3.BackgroundImage = My.Resources.ll_double
            Case "ask_host"
                picLifeline3.BackgroundImage = My.Resources.ll_host
        End Select
    End Sub

    Private Sub cmbLifeline4_TextChanged(sender As Object, e As EventArgs) Handles cmbLifeline4.TextChanged
        Select Case cmbLifeline4.Text
            Case "ask_audience"
                picLifeline4.BackgroundImage = My.Resources.ll_audience
            Case "50_50"
                picLifeline4.BackgroundImage = My.Resources.ll_5050
            Case "plus_one"
                picLifeline4.BackgroundImage = My.Resources.ll_plusone
            Case "switch"
                picLifeline4.BackgroundImage = My.Resources.ll_switch
            Case "double_dip"
                picLifeline4.BackgroundImage = My.Resources.ll_double
            Case "ask_host"
                picLifeline4.BackgroundImage = My.Resources.ll_host
        End Select
    End Sub

    Private Sub LL1_CheckedChanged(sender As Object, e As EventArgs) Handles radL1Always.CheckedChanged, radL1AfterQ5.CheckedChanged, radL1AfterQ10.CheckedChanged, radL1RiskMode.CheckedChanged
        If radL1Always.Checked Then
            OptionsScreen.Lifeline1_availableAt = 0
        ElseIf radL1AfterQ5.Checked Then
            OptionsScreen.Lifeline1_availableAt = 1
        ElseIf radL1AfterQ10.Checked Then
            OptionsScreen.Lifeline1_availableAt = 2
        ElseIf radL1RiskMode.Checked Then
            OptionsScreen.Lifeline1_availableAt = 3
        End If
    End Sub

    Private Sub LL2_CheckedChanged(sender As Object, e As EventArgs) Handles radL2Always.CheckedChanged, radL2AfterQ5.CheckedChanged, radL2AfterQ10.CheckedChanged, radL2RiskMode.CheckedChanged
        If radL2Always.Checked Then
            OptionsScreen.Lifeline2_availableAt = 0
        ElseIf radL2AfterQ5.Checked Then
            OptionsScreen.Lifeline2_availableAt = 1
        ElseIf radL2AfterQ10.Checked Then
            OptionsScreen.Lifeline2_availableAt = 2
        ElseIf radL2RiskMode.Checked Then
            OptionsScreen.Lifeline2_availableAt = 3
        End If
    End Sub

    Private Sub LL3_CheckedChanged(sender As Object, e As EventArgs) Handles radL3Always.CheckedChanged, radL3AfterQ5.CheckedChanged, radL3AfterQ10.CheckedChanged, radL3RiskMode.CheckedChanged
        If radL3Always.Checked Then
            OptionsScreen.Lifeline3_availableAt = 0
        ElseIf radL3AfterQ5.Checked Then
            OptionsScreen.Lifeline3_availableAt = 1
        ElseIf radL3AfterQ10.Checked Then
            OptionsScreen.Lifeline3_availableAt = 2
        ElseIf radL3RiskMode.Checked Then
            OptionsScreen.Lifeline3_availableAt = 3
        End If
    End Sub

    Private Sub LL4_CheckedChanged(sender As Object, e As EventArgs) Handles radL4Always.CheckedChanged, radL4AfterQ5.CheckedChanged, radL4AfterQ10.CheckedChanged, radL4RiskMode.CheckedChanged
        If radL4Always.Checked Then
            OptionsScreen.Lifeline4_availableAt = 0
        ElseIf radL4AfterQ5.Checked Then
            OptionsScreen.Lifeline4_availableAt = 1
        ElseIf radL4AfterQ10.Checked Then
            OptionsScreen.Lifeline4_availableAt = 2
        ElseIf radL4RiskMode.Checked Then
            OptionsScreen.Lifeline4_availableAt = 3
        End If
    End Sub
#End Region

#Region "Winning Strap Texture"
    Private Sub radStrapYellow_CheckedChanged(sender As Object, e As EventArgs) Handles radStrapYellow.CheckedChanged
        If radStrapYellow.Checked Then
            WinningStrapTexture = 0
            picWinningStrapTexture.BackgroundImage = WinningStrap.GetTexture(WinningStrapTexture)
            lblWinningStrapTexture.ForeColor = WinningStrap.GetTextureFontColor(WinningStrapTexture)
        End If
    End Sub

    Private Sub radStrapGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radStrapGreen.CheckedChanged
        If radStrapGreen.Checked Then
            WinningStrapTexture = 1
            picWinningStrapTexture.BackgroundImage = WinningStrap.GetTexture(WinningStrapTexture)
            lblWinningStrapTexture.ForeColor = WinningStrap.GetTextureFontColor(WinningStrapTexture)
        End If
    End Sub

    Private Sub radStrapBlack_CheckedChanged(sender As Object, e As EventArgs) Handles radStrapBlack.CheckedChanged
        If radStrapBlack.Checked Then
            WinningStrapTexture = 2
            picWinningStrapTexture.BackgroundImage = WinningStrap.GetTexture(WinningStrapTexture)
            lblWinningStrapTexture.ForeColor = WinningStrap.GetTextureFontColor(WinningStrapTexture)
        End If
    End Sub
#End Region

#Region "Database Settings"
    Private Sub btnResetQuestionsAll_Click(sender As Object, e As EventArgs) Handles btnResetQuestionsAll.Click
        Dim result As DialogResult =
            MessageBox.Show("Are you sure you want to reset all used Regular questions?" + vbNewLine + "CAUTION: You can not undo this action!",
                            "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Dim cmd As String = "UPDATE questions SET Used='False'"
            Dim sql As SqlClient.SqlCommand = New SqlClient.SqlCommand(cmd, Data.connectionString)

            Try
                Data.connectionString.Open()
                sql.ExecuteNonQuery()
                MessageBox.Show("Questions are succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error when executing: " + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Data.connectionString.Close()
            End Try
        End If
    End Sub

    Private Sub btnResetQuestionsFFF_Click(sender As Object, e As EventArgs) Handles btnResetQuestionsFFF.Click
        Dim result As DialogResult =
            MessageBox.Show("Are you sure you want to reset all used Fastest Finger questions?" + vbNewLine + "CAUTION: You can not undo this action!",
                            "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Dim cmd As String = "UPDATE fff_questions SET Used='False'"
            Dim sql As SqlClient.SqlCommand = New SqlClient.SqlCommand(cmd, Data.connectionString)

            Try
                Data.connectionString.Open()
                sql.ExecuteNonQuery()
                MessageBox.Show("Questions are succesfully reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error when executing: " + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Data.connectionString.Close()
            End Try
        End If
    End Sub

    Private Sub btnRemoveAllHostMessages_Click(sender As Object, e As EventArgs) Handles btnRemoveAllHostMessages.Click
        Dim result As DialogResult =
            MessageBox.Show("Are you sure you want to remove all host messages?" + vbNewLine + "CAUTION: You can not undo this action!",
                            "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Dim cmd As String = "DELETE FROM settings_HostMessages"
            Dim sql As SqlClient.SqlCommand = New SqlClient.SqlCommand(cmd, Data.connectionString)

            Try
                Data.connectionString.Open()
                sql.ExecuteNonQuery()
                MessageBox.Show("Host Messages are succesfully removed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error when executing: " + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Data.connectionString.Close()
            End Try
        End If
        UpdateHostMessagesList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Data.connectionString.Open()
        Dim com As String = "INSERT INTO settings_HostMessages (Message) VALUES (@Message)"
        Dim cmd As SqlCommand = New SqlCommand(com, Data.connectionString)
        cmd.Parameters.AddWithValue("@Message", txtNewHostMessage.Text.ToUpper)
        cmd.ExecuteNonQuery()
        Data.connectionString.Close()
        UpdateHostMessagesList()
    End Sub

    Private Sub btnDeleteMessage_Click(sender As Object, e As EventArgs) Handles btnDeleteMessage.Click
        Data.connectionString.Open()
        Dim com As String = "DELETE FROM settings_HostMessages WHERE Id = @Id"
        Dim cmd As SqlCommand = New SqlCommand(com, Data.connectionString)
        cmd.Parameters.AddWithValue("@Id", dtMessages.CurrentRow.Cells(0).Value)
        cmd.ExecuteNonQuery()
        Data.connectionString.Close()
        UpdateHostMessagesList()
    End Sub

    Private Overloads Sub UpdateHostMessagesList()
        Data.connectionString.Open()
        Dim com As String = "SELECT * FROM settings_HostMessages"
        Dim Adpt As New SqlDataAdapter(com, Data.connectionString)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Messages")
        dtMessages.DataSource = ds.Tables(0)
        dtMessages.Columns("Id").Visible = False
        dtMessages.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Data.connectionString.Close()
    End Sub
#End Region
End Class