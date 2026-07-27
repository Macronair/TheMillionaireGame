Imports System.IO
Imports System.Security.Cryptography
Imports System.Threading

Public Class CoreConsole

    '============[ The Millionaire Game ]============
    '  >>>>>>>>>>>>>>> Source Code <<<<<<<<<<<<<<<
    ' Project started:      June 2017
    ' Open Source since:    2021
    ' Author:               Marco (Macronair)
    ' Program is mostly written in VB.NET. But small bits of code are in C#.
    ' Based on the real-life television program Who Wants To Be A Millionaire?.

    Public Shared ControlPanelRunning As Boolean = False  ' Check if the main program is running next to the core script.
    Public Shared WebServicePID As Integer = 0 ' The Process ID of the WebService. Used to check if the service is still running or not.
    Public Shared WebServiceRunning As Boolean = False ' Check if the WebService process is still running or not.

    ' This sub below checks at a specific interval if the boolean above is still true.
    Private Sub tmrRuntime_Tick(sender As Object, e As EventArgs) Handles tmrRuntime.Tick
        Dim p As Process = Nothing

        ' Check if the WebService process is still running. If not, then restart it.
        Try
            p = Process.GetProcessById(WebServicePID)

            If p.HasExited Then
                WebServiceRunning = False
            End If

        Catch ex As ArgumentException
            ' Process does not exist, so it is not running.
            WebServiceRunning = False
        End Try

        If Not WebServiceRunning Then
            RunWebService()
        End If

        If ControlPanelRunning = False Then   ' When Control Panel is closed, then do the following:
            LogMsgDate("[INFO] Main console has been closed by the user.")
            tmrRuntime.Stop()       ' - Stops this timer.
            Me.Show()   ' Show the console window again, because the control panel is closed.

            ' Kill the WebService process if it is still running.
            Dim procToKill As Process = Process.GetProcessById(WebServicePID)
            Try
                procToKill.Kill()
                LogMsgDate("[INFO] WebService process has been terminated.")
            Catch ex As Exception
                LogMsgDate("[ERROR] Could not terminate WebService: " + ex.Message)
            End Try

            Me.Close()              ' - Kill application completely.
        End If
    End Sub

    ' Start the whole 
    Private Sub CoreConsole_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StartSeq()
    End Sub

    ' The beginning of the application.
    Private Sub StartSeq()

        Me.Hide()                       ' Hide this console window.
        SplashScreen.Show()             ' Show the splash screen window.

        '' APPLICATION, VERSION, CREATOR INFO ''
        LogMsg(String.Format("The Millionaire Game [Version {0}].", Application.ProductVersion))
        LogMsg(String.Format("Created by Marco (Macronair). Compatible with Microsoft SQL!"))
        LogMsg("")

        Thread.Sleep(500)   ' Little pause for 0,5 seconds.

        '' LOADING OF THE CONFIG.YML FILE ''
        LogMsgDate("Loading configuration...")
        Game.CurrentProfile.LoadSettings()      ' Load values of the config.yml file
        Game.CurrentTree.LoadSettings()         ' Load values of the tree.yml file
        Game.CurrentDatabase.LoadSettings()     ' Load values of the sql.xml file

        Monitor.Detect()                        ' Detect all available monitors on the machine. Used for the Options menu.

        ' Check and load the total available lifelines.
        Game.TotalLifelines = Profile.Options.TotalLifelines
        If Game.TotalLifelines > 4 Then             ' If the value is above 4 (Which isn't possible in game)...
            ' Set total to 4 active lifelines.
            Game.TotalLifelines = 4
            Profile.Options.TotalLifelines = 4
        ElseIf Game.TotalLifelines < 0 Then         ' If the value is below 0 (Which also isn't possible in game)...
            ' Set total to 0 active lifelines.
            Game.TotalLifelines = 0
            Profile.Options.TotalLifelines = 0
        End If
        LifelineManager.UnlockLifeline(1)           ' Activate Lifeline 1 (if enabled).
        LifelineManager.UnlockLifeline(2)           ' Activate Lifeline 2 (if enabled).
        LifelineManager.UnlockLifeline(3)           ' Activate Lifeline 3 (if enabled).
        LifelineManager.UnlockLifeline(4)           ' Activate Lifeline 4 (if enabled).

        Thread.Sleep(250)   ' Again... a short break.

        LogMsgDate("Loading textures...")
        QuestionStrap.LoadTextures()
        MoneyTreeCore.GenerateImages()

        '' THE DATABASE ''
        LogMsgDate("Loading database settings...")
        Try
            Data.OpenSettings()                    ' Check if all required conditions for the database are met. If not, correct it. (more info in Data.vb class)
        Catch ex As Exception           ' OOPS! Something is wrong.
            tmrRuntime.Stop()                       ' Just to be sure, stop the Runtime check timer.
            Me.Hide()                               ' Hide the console window.
            ' And finally... the message.
            MessageBox.Show("Error when starting application: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        Thread.Sleep(600)

        LogMsgDate("Building NetHubs...")
        NetHub.BuildConnection()                 ' Build the connection for the Ask The Audience lifeline.
        LogMsgDate("Starting WebService...")
        RunWebService()                          ' Start the WebService process.

        '' FINALLY LAUNCHING APPLICATION ''
        LogMsgDate("Lauching controller...")

        Monitor.ApplyScreenSettings()   ' Apply current screen settings

        ControlPanelRunning = True                ' Change main control panel running state to True.
        ControlPanel.Show()             ' Show main control panel.

        SplashScreen.Close()
        tmrRuntime.Start()              ' Start the runtime timer (see code at the top).
    End Sub

    Private Sub RunQEditor()
        Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QEDIT.EXE"))
    End Sub

    Private Sub RunWebService()
        Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory

        ' WebService staat in dezelfde map als de hoofdapp, in submap "WebService"
        Dim exePath As String = Path.Combine(baseDir, "WebService", "The Millionaire Game - WebService.exe")

        If Not File.Exists(exePath) Then
            Throw New FileNotFoundException("WebService EXE niet gevonden op: " & exePath)
        End If

        Dim startInfo As New ProcessStartInfo(exePath)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.WorkingDirectory = Path.Combine(baseDir, "WebService") ' Set working directory to the WebService folder

        Dim p As Process = Process.Start(startInfo)

        ' Read & Store PID of the WebService process
        WebServicePID = p.Id

        ' Log message with PID of WebService process
        CoreConsole.LogMsgDate("WebService (re)started with ID: " & WebServicePID)
        WebServiceRunning = True
    End Sub

    '' LOGGING SUBS  (Not quite interesting) ''
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

    Private Sub CoreConsole_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()   ' Hide the form always when the X is clicked.

        ' If the main control panel is still running, then do NOT close the form completely.
        ' Or else the whole program closes nevertheless.
        If ControlPanelRunning = True Then
            ' Then check if the form is closed by the user.
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = True     ' Cancel the event if the user has done that.
            Else
                e.Cancel = False    ' If the user hasn't closed the form, then the event won't be canceled.
            End If
        End If
    End Sub

    Private Sub CoreConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class