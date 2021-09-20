Imports System.Runtime.InteropServices

Public Class CoreConsole

    Public Shared isRunning As Boolean = False

    Private Sub CoreConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Version info
        LogMsg(String.Format("The Millionaire Game [Version {0}].", Application.ProductVersion))
        LogMsg(String.Format("Created by Marco (Maerciezz). Compatible with Microsoft SQL!"))
        LogMsg("")

        Me.Enabled = True
        tmrLoad.Start()
    End Sub

    Private Sub StartSeq()
        LogMsgDate("Checking database...")
        Data.CreateDatabase()
        LogMsgDate("Lauching controller...")

        isRunning = True
        ControlPanel.Show()
        Me.Hide()
        tmrRuntime.Start()
    End Sub

    Private Sub OpenGame()
        ControlPanel.Show()
    End Sub

    Public Shared Sub LogMsg(ByVal msg As String)
        CoreConsole.txtConsole.AppendText(msg + Environment.NewLine)
    End Sub

    Public Shared Sub LogMsgDate(ByVal msg As String)
        CoreConsole.txtConsole.AppendText(DateTime.Now + " : " + msg + Environment.NewLine)
    End Sub

    Public Shared Sub LogMsgLine(ByVal msg As String)
        CoreConsole.txtConsole.AppendText(msg)
    End Sub

    Private Sub CoreConsole_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged

    End Sub

    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        StartSeq()
        tmrLoad.Stop()
    End Sub

    Private Sub tmrRuntime_Tick(sender As Object, e As EventArgs) Handles tmrRuntime.Tick
        If isRunning = False Then
            tmrRuntime.Stop()
            Me.Close()
        End If
    End Sub
End Class