Imports System.Threading

Public Class LifelineHost
    Public Shared act As Integer = 0
    Public Shared used As Boolean = False

    Public Shared Sub LifelineUse1()
        Select Case act
            Case 0
                Question.useMusic = False
                TVControlPnl.picLifelineUse.Image = My.Resources.ll_host
                TVControlPnl.picLifelineUse.Visible = True
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_Host_Start
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("question", 100))
                stopaudio.Start()
                act = act + 1

                ControlPanel.txtHostMessages.AppendText("ASK THE HOST ACTIVATED." + Environment.NewLine)
                HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "ASK THE HOST ACTIVATED."

                used = True
            Case 1
                TVControlPnl.picLifelineUse.Visible = False
                TVControlPnl.picLifelineUse.Image = My.Resources.ll_switch
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_Host_End
                    .controls.play()
                End With

                Dim pc As Thread = New Thread(New ThreadStart(AddressOf PlayCue))
                pc.Start()

                LifelineManager.EnableLifeline(LifelineManager.CurrentActive, False)
                act = 0
        End Select
    End Sub

    Shared Sub PlayCue()
        Thread.Sleep(500)
        Question.PlayQuestionCue()
    End Sub

End Class
