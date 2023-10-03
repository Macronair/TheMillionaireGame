Public Class OptionsScreen

    Private Sub OptionsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        txtSndSwitchActivate.Text = Profile.Options.snd_Switch0_Activate
        txtSndSwitchShowCorrect.Text = Profile.Options.snd_Switch0_ShowCorrect
        txtSndSwitchClear.Text = Profile.Options.snd_Switch0_Clear

        txtSnd5050Use.Text = Profile.Options.snd_5050

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
    txtSndATAEnd.MouseDoubleClick, txtSnd5050Use.MouseDoubleClick, TabPage2.MouseDoubleClick

        Dim t As TextBox = DirectCast(sender, TextBox)
        t.Text = GetSoundFile(t.Text)

    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Game.CurrentProfile.SaveSettings()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Game.CurrentProfile.SaveSettings()
        MessageBox.Show("Settings saved succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class