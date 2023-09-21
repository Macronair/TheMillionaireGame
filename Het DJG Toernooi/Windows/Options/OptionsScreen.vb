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

    Private Sub txtSndOpening_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndOpening.MouseDoubleClick
        txtSndOpening.Text = GetSoundFile(txtSndOpening.Text)
    End Sub

    Private Sub txtSndCommercialIn_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndCommercialIn.MouseDoubleClick
        txtSndCommercialIn.Text = GetSoundFile(txtSndCommercialIn.Text)
    End Sub

    Private Sub txtSndCommercialOut_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndCommercialOut.MouseDoubleClick
        txtSndCommercialOut.Text = GetSoundFile(txtSndCommercialOut.Text)
    End Sub

    Private Sub txtSndClosing_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndClosing.MouseDoubleClick
        txtSndClosing.Text = GetSoundFile(txtSndClosing.Text)
    End Sub

    Private Sub txtSndLifeline1Ping_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndLifeline1Ping.MouseDoubleClick
        txtSndLifeline1Ping.Text = GetSoundFile(txtSndLifeline1Ping.Text)
    End Sub

    Private Sub txtSndLifeline2Ping_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndLifeline2Ping.MouseDoubleClick
        txtSndLifeline2Ping.Text = GetSoundFile(txtSndLifeline2Ping.Text)
    End Sub

    Private Sub txtSndLifeline3Ping_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndLifeline3Ping.MouseDoubleClick
        txtSndLifeline3Ping.Text = GetSoundFile(txtSndLifeline3Ping.Text)
    End Sub

    Private Sub txtSndLifeline4Ping_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndLifeline4Ping.MouseDoubleClick
        txtSndLifeline4Ping.Text = GetSoundFile(txtSndLifeline4Ping.Text)
    End Sub

    Private Sub txtSndExplainRules_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndExplainRules.MouseDoubleClick
        txtSndExplainRules.Text = GetSoundFile(txtSndExplainRules.Text)
    End Sub

    Private Sub txtSndToHotSeat_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndToHotSeat.MouseDoubleClick
        txtSndToHotSeat.Text = GetSoundFile(txtSndToHotSeat.Text)
    End Sub

    Private Sub txtSndToHotSeatLD_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndToHotSeatLD.MouseDoubleClick
        txtSndToHotSeatLD.Text = GetSoundFile(txtSndToHotSeatLD.Text)
    End Sub

    Private Sub txtSndRiskModeActivate_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndRiskModeActivate.MouseDoubleClick
        txtSndRiskModeActivate.Text = GetSoundFile(txtSndRiskModeActivate.Text)
    End Sub

    Private Sub txtSndWalkAway1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndWalkAway1.MouseDoubleClick
        txtSndWalkAway1.Text = GetSoundFile(txtSndWalkAway1.Text)
    End Sub

    Private Sub txtSndWalkAway2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndWalkAway2.MouseDoubleClick
        txtSndWalkAway2.Text = GetSoundFile(txtSndWalkAway2.Text)
    End Sub

    Private Sub txtSndGameOver_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndGameOver.MouseDoubleClick
        txtSndLifeline4Ping.Text = GetSoundFile(txtSndLifeline4Ping.Text)
    End Sub

    Private Sub txtSndFMeet2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet2.MouseDoubleClick
        txtSndFMeet2.Text = GetSoundFile(txtSndFMeet2.Text)
    End Sub

    Private Sub txtSndFMeet3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet3.MouseDoubleClick
        txtSndFMeet3.Text = GetSoundFile(txtSndFMeet3.Text)
    End Sub

    Private Sub txtSndFMeet4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet4.MouseDoubleClick
        txtSndFMeet4.Text = GetSoundFile(txtSndFMeet4.Text)
    End Sub

    Private Sub txtSndFMeet5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet5.MouseDoubleClick
        txtSndFMeet5.Text = GetSoundFile(txtSndFMeet5.Text)
    End Sub

    Private Sub txtSndFMeet6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet6.MouseDoubleClick
        txtSndFMeet6.Text = GetSoundFile(txtSndFMeet6.Text)
    End Sub

    Private Sub txtSndFMeet7_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet7.MouseDoubleClick
        txtSndFMeet7.Text = GetSoundFile(txtSndFMeet7.Text)
    End Sub

    Private Sub txtSndFMeet8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFMeet8.MouseDoubleClick
        txtSndFMeet8.Text = GetSoundFile(txtSndFMeet8.Text)
    End Sub

    Private Sub txtSndFReadQuestion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFReadQuestion.MouseDoubleClick
        txtSndFReadQuestion.Text = GetSoundFile(txtSndFReadQuestion.Text)
    End Sub

    Private Sub txtSndFThreeNotes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFThreeNotes.MouseDoubleClick
        txtSndFThreeNotes.Text = GetSoundFile(txtSndFThreeNotes.Text)
    End Sub

    Private Sub txtSndFThinking_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFThinking.MouseDoubleClick
        txtSndFThinking.Text = GetSoundFile(txtSndFThinking.Text)
    End Sub

    Private Sub txtSndFReadCorrectOrder_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFReadCorrectOrder.MouseDoubleClick
        txtSndFReadCorrectOrder.Text = GetSoundFile(txtSndFReadCorrectOrder.Text)
    End Sub

    Private Sub txtSndFOrder1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFOrder1.MouseDoubleClick
        txtSndFOrder1.Text = GetSoundFile(txtSndFOrder1.Text)
    End Sub

    Private Sub txtSndFOrder2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFOrder2.MouseDoubleClick
        txtSndFOrder2.Text = GetSoundFile(txtSndFOrder2.Text)
    End Sub

    Private Sub txtSndFOrder3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFOrder3.MouseDoubleClick
        txtSndFOrder3.Text = GetSoundFile(txtSndFOrder3.Text)
    End Sub

    Private Sub txtSndFOrder4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFOrder4.MouseDoubleClick
        txtSndFOrder4.Text = GetSoundFile(txtSndFOrder4.Text)
    End Sub

    Private Sub txtSndFWhoWasCorrect_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFWhoWasCorrect.MouseDoubleClick
        txtSndFWhoWasCorrect.Text = GetSoundFile(txtSndFWhoWasCorrect.Text)
    End Sub

    Private Sub txtSndFWinner_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndFWinner.MouseDoubleClick
        txtSndFWinner.Text = GetSoundFile(txtSndFWinner.Text)
    End Sub

    Private Sub txtSndATAStart_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndATAStart.MouseDoubleClick
        txtSndATAStart.Text = GetSoundFile(txtSndATAStart.Text)
    End Sub

    Private Sub txtSndATAVoting_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndATAVoting.MouseDoubleClick
        txtSndATAVoting.Text = GetSoundFile(txtSndATAVoting.Text)
    End Sub

    Private Sub txtSndATAEnd_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndATAEnd.MouseDoubleClick
        txtSndATAEnd.Text = GetSoundFile(txtSndATAEnd.Text)
    End Sub

    Private Sub txtSndP1Start_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndP1Start.MouseDoubleClick
        txtSndP1Start.Text = GetSoundFile(txtSndP1Start.Text)
    End Sub

    Private Sub txtSndP1Clock_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndP1Clock.MouseDoubleClick
        txtSndP1Clock.Text = GetSoundFile(txtSndP1Clock.Text)
    End Sub

    Private Sub txtSndP1EndEarly_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndP1EndEarly.MouseDoubleClick
        txtSndP1EndEarly.Text = GetSoundFile(txtSndP1EndEarly.Text)
    End Sub

    Private Sub txtSndSwitchActivate_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndSwitchActivate.MouseDoubleClick
        txtSndSwitchActivate.Text = GetSoundFile(txtSndSwitchActivate.Text)
    End Sub

    Private Sub txtSndSwitchShowCorrect_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndSwitchShowCorrect.MouseDoubleClick
        txtSndSwitchShowCorrect.Text = GetSoundFile(txtSndSwitchShowCorrect.Text)
    End Sub

    Private Sub txtSndSwitchClear_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSndSwitchClear.MouseDoubleClick
        txtSndSwitchClear.Text = GetSoundFile(txtSndSwitchClear.Text)
    End Sub

    Private Sub txtSnd5050Use_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtSnd5050Use.MouseDoubleClick
        txtSnd5050Use.Text = GetSoundFile(txtSnd5050Use.Text)
    End Sub
End Class