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

    Public Shared Function Find(ByVal number As Integer)
        Dim result = ConnectedScreens.Where(Function(s) number)
    End Function

End Class
