Imports System.Threading

Public Class LifeLineDouble
    Shared dd_Start As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
    Shared dd_Final As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
    Shared dd_Wrong As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer

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
    End Sub

    Public Shared Sub FinalAnswer()
        Dim stopmusic1 As Thread = New Thread(AddressOf StopCue1)
        stopmusic1.Start()
        If chance = 2 Then
            dd_Final.URL = Sounds.SoundsPath + Profile.Options.snd_Double_1stFinal
        ElseIf chance = 1 Then
            dd_Final.URL = Sounds.SoundsPath + Profile.Options.snd_Double_2ndFinal
            chance = 0
            active = False
        End If
        dd_Final.controls.play()
    End Sub

    Public Shared Sub SecondChance()
        Dim stopmusic1 As Thread = New Thread(AddressOf StopCue2)
        StopCue2()
        dd_Wrong.URL = Sounds.SoundsPath + Profile.Options.snd_Double_2ndAnswer
        dd_Wrong.controls.play()
        chance = 1
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
        Threading.Thread.Sleep(150)
        dd_Final.controls.stop()
    End Sub
End Class
