Public Class Monitor

    Private Shared primaryScreen = Screen.PrimaryScreen
    Private Shared allScreens = Screen.AllScreens
    Public Shared ConnectedScreens As New List(Of String)

    Public Shared Sub Detect()
        For i As Integer = 0 To Screen.AllScreens.Count - 1
            Dim scr = Screen.AllScreens(i)
            Dim device As String = $"{i} | "
            device = device + $"{scr.Bounds.Location.X}, {scr.Bounds.Location.Y}"

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

    Public Shared Function Find(ByVal number As Integer)

    End Function

End Class
