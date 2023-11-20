Public Class Monitor

    Private Shared primaryScreen = Screen.PrimaryScreen
    Private Shared allScreens = Screen.AllScreens
    Public Shared ConnectedScreens As New List(Of String)

    Public Shared Sub Detect()
        For i As Integer = 0 To Screen.AllScreens.Count - 1
            Dim scr = Screen.AllScreens(i)
            Dim device As Integer = i

            ConnectedScreens.Add(device.ToString)
        Next
    End Sub

    Public Shared Sub Identify()
        For i As Integer = 0 To Screen.AllScreens.Count - 1
            Dim scr = Screen.AllScreens(i)
            Dim location = Point.Add(scr.Bounds.Location, New Size(100, 100))

            Dim identifyScreen As New MonitorIdentifier
            identifyScreen.lblMonitorNumber.Text = Convert.ToString(i)
            identifyScreen.Location = location
            identifyScreen.StartPosition = FormStartPosition.Manual
            identifyScreen.Show()
        Next
    End Sub

    Public Shared Sub ApplyScreenSettings()
        ' Resolutions
        Select Case Profile.Options.Resolution_HostScreen
            Case "1280x720"
                GameResolution.ChangeTo720(2)
            Case "1920x1080"
                GameResolution.ChangeTo1080(2)
        End Select

        Select Case Profile.Options.Resolution_GuestScreen
            Case "1280x720"
                GameResolution.ChangeTo720(3)
            Case "1920x1080"
                GameResolution.ChangeTo1080(3)
        End Select

        Select Case Profile.Options.Resolution_TVScreen
            Case "1280x720"
                GameResolution.ChangeTo720(1)
            Case "1920x1080"
                GameResolution.ChangeTo1080(1)
        End Select

        ' Full Screen?
        If Profile.Options.FullScreen_HostScreen_Enable = True Then
            Dim scr = Screen.AllScreens(Profile.Options.FullScreen_HostScreen_Monitor)

            HostScreen.FormBorderStyle = FormBorderStyle.None
            HostScreen.Location = Point.Add(scr.Bounds.Location, New Size(0, 0))
            HostScreen.WindowState = FormWindowState.Maximized
        Else
            HostScreen.FormBorderStyle = FormBorderStyle.FixedDialog
            HostScreen.WindowState = FormWindowState.Normal
        End If

        If Profile.Options.FullScreen_GuestScreen_Enable = True Then
            Dim scr = Screen.AllScreens(Profile.Options.FullScreen_GuestScreen_Monitor)

            GuestScreen.FormBorderStyle = FormBorderStyle.None
            GuestScreen.Location = Point.Add(scr.Bounds.Location, New Size(0, 0))
            GuestScreen.WindowState = FormWindowState.Maximized
        Else
            GuestScreen.FormBorderStyle = FormBorderStyle.FixedDialog
            GuestScreen.WindowState = FormWindowState.Normal
        End If

        If Profile.Options.FullScreen_TVScreen_Enable = True Then
            Dim scr = Screen.AllScreens(Profile.Options.FullScreen_TVScreen_Monitor)

            TVControlPnl.FormBorderStyle = FormBorderStyle.None
            TVControlPnl.Location = Point.Add(scr.Bounds.Location, New Size(0, 0))
            TVControlPnl.WindowState = FormWindowState.Maximized
        Else
            TVControlPnl.FormBorderStyle = FormBorderStyle.FixedDialog
            TVControlPnl.WindowState = FormWindowState.Normal
        End If
    End Sub

    Public Shared Function Find(ByVal number As Integer)
        Dim result = ConnectedScreens.Where(Function(s) number)
        Return result
    End Function

End Class
