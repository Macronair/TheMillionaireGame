Imports System.IO
Imports System.Threading

Public Class CoreConsole

    '============[ The Millionaire Game ]============
    '  >>>>>>>>>>>>>>> Source Code <<<<<<<<<<<<<<<
    ' Project started:      June 2017
    ' Open Source since:    2021
    ' Author:               Marco (Macronair)
    ' Program is mostly written in VB.NET. But small bits of code are in C#.
    ' Based on the real-life television program Who Wants To Be A Millionaire?.

    Public Shared isRunning As Boolean = False  ' Check if the main program is running next to the core script.

    ' This sub below checks at a specific interval if the boolean above is still true.
    Private Sub tmrRuntime_Tick(sender As Object, e As EventArgs) Handles tmrRuntime.Tick
        If isRunning = False Then   ' When Control Panel is closed, then do the following:
            tmrRuntime.Stop()       ' - Stops this timer.
            Me.Close()              ' - Kill application completely.
        End If
    End Sub

    ' Start the whole 
    Private Sub CoreConsole_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StartSeq()
    End Sub

    ' The beginning of the application.
    Private Sub StartSeq()
        Me.Enabled = True       ' Enable.. Me? (Not sure anymore why this is added. ;D)

        '' APPLICATION, VERSION, CREATOR INFO ''
        LogMsg(String.Format("The Millionaire Game [Version {0}].", Application.ProductVersion))
        LogMsg(String.Format("Created by Marco (Macronair). Compatible with Microsoft SQL!"))
        LogMsg("")

        Thread.Sleep(500)   ' Little pause for 0,5 seconds.

        '' LOADING OF THE CONFIG.YML FILE ''
        LogMsgDate("Loading configuration...")
        Game.CurrentProfile.LoadSettings()      ' Load values of the config.yml file

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

        '' THE DATABASE ''
        LogMsgDate("Checking database...")
        Try
            Data.CheckDatabase()                    ' Check if all required conditions for the database are met. If not, correct it. (more info in Data.vb class)
        Catch ex As Exception           ' OOPS! Something is wrong.
            tmrRuntime.Stop()                       ' Just to be sure, stop the Runtime check timer.
            Me.Hide()                               ' Hide the console window.
            ' And finally... the message.
            MessageBox.Show("Error when starting application: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
        Thread.Sleep(600)

        '' FINALLY LAUNCHING APPLICATION ''
        LogMsgDate("Lauching controller...")

        Monitor.ApplyScreenSettings()   ' Apply current screen settings
        Monitor.ApplyScreenSettings()   ' Apply this again... otherwise some fonts will be glitched out for some reason.

        isRunning = True                ' Change main control panel running state to True.
        Me.Hide()                       ' Hide this console window.
        ControlPanel.Show()             ' Show main control panel.

        ' When existing 1.0 users move to the new 1.1 version, then all the questions must be imported with a valid question level.
        ' Otherwise they'll end up with a new clean database (except for the FFF questions which will be imported one on one).
        ' The if statement below will open the Question Editor with the import tool automatically if the user said yes on the prompt they got
        ' when loading the application for the first time.
        If Data.OpenQEditor = True Then
            Dim qedit As Thread = New Thread(New ThreadStart(AddressOf OpenQEditor))
            qedit.Start()
            LogMsgDate("Starting Question Editor...")
        End If

        tmrRuntime.Start()              ' Start the runtime timer (see code at the top).
    End Sub

    Private Sub OpenQEditor()
        Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QEDIT.EXE"))
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
        If isRunning = True Then
            ' Then check if the form is closed by the user.
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = True     ' Cancel the event if the user has done that.
            Else
                e.Cancel = False    ' If the user hasn't closed the form, then the event won't be canceled.
            End If
        End If
    End Sub
End Class