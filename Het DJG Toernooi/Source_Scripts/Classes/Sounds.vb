Imports System.Threading
Imports WMPLib

Public Class Sounds

    Public Shared SoundsPath As String = Application.StartupPath + "\Sounds\"

    Public Shared sndGeneral As New WindowsMediaPlayer()
    Public Shared sndGeneralBed As New WindowsMediaPlayer()
    Public Shared sndLightsDown As New WindowsMediaPlayer()
    Public Shared sndQuestion As New WindowsMediaPlayer()
    Public Shared sndFinal As New WindowsMediaPlayer()
    Public Shared sndAnswer As New WindowsMediaPlayer()

    Public Shared sndLifeline1 As New WindowsMediaPlayer()
    Public Shared sndLifeline2 As New WindowsMediaPlayer()

    Public Shared Sub StopAudio(ByVal source As String, ByVal delayInMiliseconds As Integer)
        If delayInMiliseconds > 0 Then
            Thread.Sleep(delayInMiliseconds)
        End If
        Select Case source
            Case "all"
                sndGeneral.controls.stop()
                sndQuestion.controls.stop()
                sndFinal.controls.stop()
                sndAnswer.controls.stop()
                sndLightsDown.controls.stop()
                sndGeneralBed.controls.stop()
                sndLifeline1.controls.stop()
                sndLifeline2.controls.stop()
            Case "to_commercial"
                sndQuestion.controls.stop()
                sndFinal.controls.stop()
                sndAnswer.controls.stop()
                sndLightsDown.controls.stop()
            Case "question"
                sndQuestion.controls.stop()
            Case "final"
                sndFinal.controls.stop()
            Case "answer"
                sndAnswer.controls.stop()
            Case "lightsdown"
                sndLightsDown.controls.stop()
            Case "lights_fade"
                LightsDownFade()
            Case "for_lightsdown"
                sndQuestion.controls.stop()
                sndFinal.controls.stop()
                sndAnswer.controls.stop()
                sndGeneralBed.controls.stop()
            Case "lifeline1"
                sndLifeline1.controls.stop()
            Case "lifeline2"
                sndLifeline2.controls.stop()
        End Select
    End Sub

    Private Shared Sub LightsDownFade()
        Dim volume As Integer = 100

        While volume >= 0

            If volume = 0 Then
                sndLightsDown.controls.stop()
                sndLightsDown.settings.volume = 100
                Exit While
            Else
                volume = volume - 1
                sndLightsDown.settings.volume = volume
            End If

            Thread.Sleep(1)
        End While
    End Sub

End Class
