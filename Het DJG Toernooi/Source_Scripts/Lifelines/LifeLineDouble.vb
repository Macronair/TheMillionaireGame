Imports System.Threading

Public Class LifeLineDouble
    Public Shared dd_Start As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
    Public Shared dd_Final As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
    Public Shared dd_Wrong As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer

    Public Shared active As Boolean = False
    Public Shared chance As Integer = 2

    Public Shared Sub LifelineUse1()
        active = True
        ControlPanel.Timer1.Start()
        ControlPanel.Timer2.Start()
        dd_Start.URL = Sounds.SoundsPath + Profile.Options.snd_Double_1stAnswer
        TVControlPnl.picLifelineUse.Image = My.Resources.ll_double
        TVControlPnl.picLifelineUse.Visible = True
        dd_Start.controls.play()

        Dim stopaudio As New Thread(Sub() Sounds.StopAudio("question", 150))
        stopaudio.Start()

        ControlPanel.txtHostMessages.AppendText("DOUBLE DIP ACTIVATED. (NO WALK AWAY)" + Environment.NewLine)
        HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "DOUBLE DIP ACTIVATED. (NO WALK AWAY)"
        ControlPanel.txtHostMessages.AppendText("WHAT IS THE FIRST ANSWER?" + Environment.NewLine)
        HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "WHAT IS THE FIRST ANSWER?"

        LifelineManager.EnableLifeline(LifelineManager.CurrentActive, False)
    End Sub

    Public Shared Sub FinalAnswer()
        Dim stopmusic1 As Thread = New Thread(AddressOf StopCue1)
        stopmusic1.Start()
        Select Case chance
            Case 2
                If ControlPanel.answer = ControlPanel.lblAnswer.Text Then
                    HostScreen.lblAnswer.Visible = True
                Else
                    HostScreen.lblAnswer.Visible = False
                End If
                dd_Final.URL = Sounds.SoundsPath + Profile.Options.snd_Double_1stFinal
                chance = 1
            Case 1
                HostScreen.lblAnswer.Visible = True
                dd_Final.URL = Sounds.SoundsPath + Profile.Options.snd_Double_2ndFinal
                chance = 0
        End Select
        dd_Final.controls.play()
        Question.PlayFinalAnswerCue()
    End Sub

    Public Shared Sub SecondChance()
        Dim stopmusic1 As Thread = New Thread(AddressOf StopCue2)
        StopCue2()
        dd_Wrong.URL = Sounds.SoundsPath + Profile.Options.snd_Double_2ndAnswer
        dd_Wrong.controls.play()
        chance = 1
        ControlPanel.txtHostMessages.AppendText("WHAT IS THE SECOND/LAST ANSWER?" + Environment.NewLine)
        HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "WHAT IS THE SECOND/LAST ANSWER?"
    End Sub

    Public Shared Sub StopCue1()
        Threading.Thread.Sleep(50)
        Try
            dd_Start.controls.stop()
        Catch

        End Try
        Try
            dd_Wrong.controls.stop()
        Catch

        End Try
    End Sub

    Public Shared Sub StopCue2()
        Threading.Thread.Sleep(400)
        dd_Final.controls.stop()
    End Sub
End Class
