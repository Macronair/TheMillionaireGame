Imports System.IO
Imports System.Threading

Public Class CoreConsole

    Public Shared isRunning As Boolean = False

    Private Sub CoreConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StartSeq()
        Me.Enabled = True
        'Version info
        LogMsg(String.Format("The Millionaire Game [Version {0}].", Application.ProductVersion))
        LogMsg(String.Format("Created by Marco (Macronair). Compatible with Microsoft SQL!"))
        LogMsg("")
        Thread.Sleep(500)

        LogMsgDate("Loading configuration...")
        Game.CurrentProfile.LoadSettings()
        Thread.Sleep(250)

        LogMsgDate("Checking database...")
        Try
            Data.CheckDatabase()
        Catch ex As Exception
            tmrRuntime.Stop()
            tmrLoad.Stop()
            Me.Hide()
            MessageBox.Show("Error when starting application: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        Thread.Sleep(600)

        LogMsgDate("Lauching controller...")

        isRunning = True
        Me.Hide()
        ControlPanel.Show()
        If Data.openQEditor = True Then
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QEDIT.EXE"))
        End If
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
    Public Shared Sub LogMsgLineDate(ByVal msg As String)
        CoreConsole.txtConsole.AppendText(DateTime.Now + " : " + msg)
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

    Private Sub CoreConsole_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StartSeq()
    End Sub

    Private Sub CoreConsole_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()

        If isRunning = True Then
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub
End Class