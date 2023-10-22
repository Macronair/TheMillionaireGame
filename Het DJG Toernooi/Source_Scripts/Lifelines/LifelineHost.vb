Public Class LifelineHost
    Public Shared act As Integer = 0
    Shared tmr As Timer


    Public Shared Sub LifelineUse1()
        Select Case act
            Case 0
                TVControlPnl.picLifelineUse.Image = My.Resources.ll_host
                TVControlPnl.picLifelineUse.Visible = True
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_Host_Start
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("question", 100))
                stopaudio.Start()
                act = act + 1
            Case 1
                tmr = New Timer
                tmr.Interval = 500
                AddHandler tmr.Tick, AddressOf PlayCue
                TVControlPnl.picLifelineUse.Visible = False
                TVControlPnl.picLifelineUse.Image = My.Resources.ll_switch
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_Host_End
                    .controls.play()
                End With
                tmr.Start()

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
                act = 0
        End Select
    End Sub

    Shared Sub PlayCue()
        Question.PlayQuestionCue()
        tmr.Stop()
    End Sub

End Class
