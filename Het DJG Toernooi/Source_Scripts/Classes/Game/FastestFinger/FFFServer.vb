Imports System.IO
Imports System.Net
Imports System.Net.Sockets

'Server Side
Public Class FFFServer

    Dim Listening As TcpListener
    Dim Allclient As TcpClient
    Dim clientList As New List(Of ClientClass)
    Dim pReader As StreamReader
    Dim pClient As ClientClass

    'Game instances
    Dim options As New Game
    Public Shared snd As New SOUND

    'General game info
    Dim fff_think As Boolean = False                            'Time is started to give the right answer.
    Public fff_points As Integer = 0                            'General point counter for the game.
    Dim fff_timemax As Double = Double.MaxValue             'The max value of points that somebody reached
    Public Shared fff_timemin As Double = Double.MinValue   'The min value of points that somebody reached
    Public correctAnswer As String                              'The correct answer on the current question

    ' Game state variables (not relevant for the FFF results)
    Public act As Integer
    Public i As Integer = 0
    Public a As Integer = 0
    Dim q As Integer = 0

    'Timer
    Private Shared stopwatch As New Stopwatch
    Private Shared tmr As System.Timers.Timer
    Private Shared time As String

    Public Shared firstMan As Boolean = True    'Checks if the person with the right answer is the first one. If so, this will be set from True to False.

    Public Shared totalContestants As Integer = 8

    'Player 1 Info
    Dim pl1_online As Boolean       'Online?
    Dim pl1_name As String          'Name
    Dim pl1_answer As String        'Answer
    Public Shared pl1_time As Double = 9999

    'Player 2 Info
    Dim pl2_online As Boolean       'Online?
    Dim pl2_name As String          'Name
    Dim pl2_answer As String        'Answer
    Public Shared pl2_time As Double = 9999

    'Player 3 Info
    Dim pl3_online As Boolean       'Online?
    Dim pl3_name As String          'Name
    Dim pl3_answer As String        'Answer
    Public Shared pl3_time As Double = 9999

    'Player 4 Info
    Dim pl4_online As Boolean       'Online?
    Dim pl4_name As String          'Name
    Dim pl4_answer As String        'Answer
    Public Shared pl4_time As Double = 9999

    'Player 5 Info
    Dim pl5_online As Boolean       'Online?
    Dim pl5_name As String          'Name
    Dim pl5_answer As String        'Answer
    Public Shared pl5_time As Double = 9999

    'Player 6 Info
    Dim pl6_online As Boolean       'Online?
    Dim pl6_name As String          'Name
    Dim pl6_answer As String        'Answer
    Public Shared pl6_time As Double = 9999

    'Player 7 Info
    Dim pl7_online As Boolean       'Online?
    Dim pl7_name As String          'Name
    Dim pl7_answer As String        'Answer
    Public Shared pl7_time As Double = 9999

    'Player 8 Info
    Dim pl8_online As Boolean       'Online?
    Dim pl8_name As String          'Name
    Dim pl8_answer As String        'Answer
    Public Shared pl8_time As Double = 9999

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listening = New TcpListener(IPAddress.Any, Profile.Options.FFF_Port)
        Try
            Listening.Start()
            Listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listening)
        Catch ex As Exception
            CoreConsole.LogMsgDate("Socket already open.")
        End Try

        UpdateList("Server started!", False)

    End Sub

    Delegate Sub _cUpdate(ByVal str As String, ByVal relay As Boolean)
    Sub UpdateList(ByVal str As String, ByVal relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _cUpdate(AddressOf UpdateList), str, relay)
        Else
            txtReceive.Text = str
            If relay Then
                Send(str)
            End If
        End If
    End Sub

    Sub Send(ByVal str As String)
        For x As Integer = 0 To clientList.Count - 1
            Try
                clientList(x).Send(str)
            Catch ex As Exception
                clientList.RemoveAt(x)
            End Try
        Next
    End Sub

    Sub AcceptClient(ByVal ar As IAsyncResult)
        pClient = New ClientClass(Listening.EndAcceptTcpClient(ar))
        AddHandler(pClient.getMessage), AddressOf MessageReceived
        AddHandler(pClient.clientLogout), AddressOf ClientExited
        clientList.Add(pClient)
        UpdateList("New Client Joined!", True)
        Listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listening)
    End Sub
    Sub MessageReceived(ByVal str As String)
        UpdateList(str, True)
    End Sub
    Sub ClientExited(ByVal client As ClientClass)
        clientList.Remove(client)
        UpdateList("Client Exited!", True)
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateList(TextBox2.Text, True)
            TextBox2.Clear()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateList(TextBox2.Text, True)
        TextBox2.Clear()
    End Sub

    Private Sub txtReceive_TextChanged(sender As Object, e As EventArgs) Handles txtReceive.TextChanged
        If fff_think = True Then
            Dim rcv As String = txtReceive.Text
            Dim rcvList() As String = rcv.Split("-")
            Select Case rcvList(0)
                Case 1                                          ' Checks Player 1 answer + score
                    If chkPL1_Active.Checked = True Then
                        txtPL1_Answer.Text = rcvList(1)
                    End If
                    If txtPL1_Answer.Text = correctAnswer Then
                        pl1_time = time
                        txtPL1_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 2                                          ' Checks Player 2 answer + score
                    If chkPL2_Active.Checked = True Then
                        txtPL2_Answer.Text = rcvList(1)
                    End If
                    If txtPL2_Answer.Text = correctAnswer Then
                        pl2_time = time
                        txtPL2_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 3                                          ' Checks Player 3 answer + score
                    If chkPL3_Active.Checked = True Then
                        txtPL3_Answer.Text = rcvList(1)
                    End If
                    If txtPL3_Answer.Text = correctAnswer Then
                        pl3_time = time
                        txtPL3_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 4                                          ' Checks Player 4 answer + score
                    If chkPL4_Active.Checked = True Then
                        txtPL4_Answer.Text = rcvList(1)
                    End If
                    If txtPL4_Answer.Text = correctAnswer Then
                        pl4_time = time
                        txtPL4_Points.Text = lblTime.Text
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 5                                          ' Checks Player 5 answer + score
                    If chkPL5_Active.Checked = True Then
                        txtPL5_Answer.Text = rcvList(1)
                    End If
                    If txtPL5_Answer.Text = correctAnswer Then
                        pl5_time = time
                        txtPL5_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 6                                          ' Checks Player 6 answer + score
                    If chkPL6_Active.Checked = True Then
                        txtPL6_Answer.Text = rcvList(1)
                    End If
                    If txtPL6_Answer.Text = correctAnswer Then
                        pl6_time = time
                        txtPL6_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 7                                          ' Checks Player 7 answer + score
                    If chkPL7_Active.Checked = True Then
                        txtPL7_Answer.Text = rcvList(1)
                    End If
                    If txtPL7_Answer.Text = correctAnswer Then
                        pl7_time = time
                        txtPL7_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
                Case 8                                          ' Checks Player 8 answer + score
                    If chkPL8_Active.Checked = True Then
                        txtPL8_Answer.Text = rcvList(1)
                    End If
                    If txtPL8_Answer.Text = correctAnswer Then
                        pl8_time = time
                        txtPL8_Points.Text = time
                        If firstMan = True Then
                            fff_timemin = time
                            firstMan = False
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub btnGenQuestion_Click(sender As Object, e As EventArgs) Handles btnGenQuestion.Click
        If q = 0 Then
            FFFQuestion.GetQuestion(0)
            q = 1
        ElseIf q = 1 Then
            FFFQuestion.GetQuestion(1)
        End If
    End Sub

    Private Sub btnStartTime_Click(sender As Object, e As EventArgs) Handles btnStartTime.Click
        With Sounds.fff_st1
            .URL = Sounds.SoundsPath + Profile.Options.snd_F_ThreeNotes
            .controls.play()
        End With

        Sounds.fff_question.controls.stop()

        HostScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
        GuestScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
        TVControlPnl.txtA.Text = "A: " & ControlPanel.txtA.Text
        TVControlPnl.txtA.Visible = True
        HostScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
        GuestScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
        TVControlPnl.txtB.Text = "B: " & ControlPanel.txtB.Text
        TVControlPnl.txtB.Visible = True
        HostScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
        GuestScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
        TVControlPnl.txtC.Text = "C: " & ControlPanel.txtC.Text
        TVControlPnl.txtC.Visible = True
        HostScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
        GuestScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
        TVControlPnl.txtD.Text = "D: " & ControlPanel.txtD.Text
        TVControlPnl.txtD.Visible = True

        tmrThreeNotes.Start()
    End Sub

    Private Sub tmrThreeNotes_Tick(sender As Object, e As EventArgs) Handles tmrThreeNotes.Tick
        tmr = New System.Timers.Timer(1)
        AddHandler tmr.Elapsed, AddressOf Handler

        FFFQuestion.Fill()
        PlayerCheck.Randomizer()
        txtReceive.Clear()
        fff_think = True

        tmrThink.Start()

        tmrSendAnswers.Start()

        stopwatch.Start()
        tmr.Start()

        With Sounds.fff_st2
            .URL = Sounds.SoundsPath + Profile.Options.snd_F_Thinking
            .controls.play()
        End With

        UpdateList("/unlock", True)
        tmrPoints.Start()
        tmrThreeNotes.Stop()
    End Sub

    Private Sub tmrThink_Tick(sender As Object, e As EventArgs) Handles tmrThink.Tick
        fff_think = False
        PlayerCheck.Tiebreaker()
        q = 0
        UpdateList("/lock", True)

        tmrThink.Stop()
        tmrPoints.Stop()

        tmr.Stop()
        stopwatch.Stop()
        stopwatch.Reset()
        time = "0.00"

        lblTime.Text = time
    End Sub

    Private Sub tmrPoints_Tick(sender As Object, e As EventArgs) Handles tmrPoints.Tick
        fff_points += 1
        lblPoints.Text = fff_points
        lblTime.Text = time
    End Sub

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        Select Case i
            Case 0
                ControlPanel.chkShowQuestion.Checked = False
                i = i + 1
            Case 1
                With Sounds.fff_st1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_ReadCorrectOrder
                    .settings.setMode("Loop", True)
                    .controls.play()
                End With
                i = i + 1
            Case 2
                TVControlPnl.picTree.BackgroundImage = My.Resources.tree_0
                TVControlPnl.lblFFFQuestion.Visible = True
                TVControlPnl.picLifeline3.Visible = False
                TVControlPnl.picLifeline1.Visible = False
                TVControlPnl.picLifeline2.Visible = False
                TVControlPnl.picLifeline4.Visible = False
                TVControlPnl.picTree.Visible = True
                i = i + 1
            Case 3
                TVControlPnl.pnlFFFOrder1.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order1
                    .controls.play()
                End With
                i = i + 1
            Case 4
                TVControlPnl.pnlFFFOrder2.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order2
                    .controls.play()
                End With
                i = i + 1
            Case 5
                TVControlPnl.pnlFFFOrder3.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order3
                    .controls.play()
                End With
                i = i + 1
            Case 6
                TVControlPnl.pnlFFFOrder4.Visible = True
                Dim order As New WMPLib.WindowsMediaPlayer
                With order
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Order4
                    .controls.play()
                End With
                i = i + 1
        End Select

    End Sub

    Private Sub btnShowCorrectPlayers_Click(sender As Object, e As EventArgs) Handles btnShowCorrectPlayers.Click
        If a = 0 Then
            TVControlPnl.pnlFFFPlayers.Visible = True
            TVControlPnl.picTree.Visible = False
            a = a + 1
        ElseIf a = 1 Then
            TVControlPnl.lblFFFQuestion.Visible = False
            TVControlPnl.pnlFFFOrder1.Visible = False
            TVControlPnl.pnlFFFOrder2.Visible = False
            TVControlPnl.pnlFFFOrder3.Visible = False
            TVControlPnl.pnlFFFOrder4.Visible = False
            TVControlPnl.picLifeline3.Visible = False
            TVControlPnl.picLifeline1.Visible = False
            TVControlPnl.picLifeline2.Visible = False
            TVControlPnl.picLifeline4.Visible = False
            tmrRevealPlayers.Start()
            If Game.level = -1 Then
                With Sounds.fff_st1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_WhoWasCorrect
                    .settings.setMode("Loop", False)
                    .controls.play()
                End With
                Sounds.fff_st2.controls.stop()
            End If
            a = a + 1
        ElseIf a = 2 Then

            If fff_timemin < 9999 Then

                If PlayerCheck.tie = 1 Then
                    With Sounds.fff_st2
                        .URL = Sounds.SoundsPath + Profile.Options.snd_F_Winner
                        .controls.play()
                    End With
                    Select Case fff_timemin
                        Case pl1_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL1_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl1_time
                        Case pl2_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL2_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl2_time
                        Case pl3_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL3_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl3_time
                        Case pl4_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL4_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl4_time
                        Case pl5_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL5_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl5_time
                        Case pl6_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL6_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl6_time
                        Case pl7_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL7_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl7_time
                        Case pl8_time
                            TVControlPnl.lblFFFWinnerName.Text = txtPL8_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl8_time
                    End Select
                    TVControlPnl.pnlFFFWinner.Visible = True
                End If
            Else
                TVControlPnl.pnlFFFPlayers.Visible = False
                TVControlPnl.pnlFFFWinner.Visible = False
            End If
            a = a + 1
        ElseIf a = 3 Then
            tmrFastestPlayer.Stop()
            TVControlPnl.pnlFFFPlayers.Visible = False
            a = 4
        ElseIf a = 4 Then
            TVControlPnl.pnlFFFWinner.Visible = False
            If chkDisableWinnerAuto.Checked = True Then
                Select Case fff_timemin
                    Case pl1_time
                        txtPL1_Name.Text = ""
                        txtPL1_Points.Text = ""
                        txtPL1_Answer.Text = ""
                        chkPL1_Active.Checked = False
                    Case pl2_time
                        txtPL2_Name.Text = ""
                        txtPL2_Points.Text = ""
                        txtPL2_Answer.Text = ""
                        chkPL2_Active.Checked = False
                    Case pl3_time
                        txtPL3_Name.Text = ""
                        txtPL3_Points.Text = ""
                        txtPL3_Answer.Text = ""
                        chkPL3_Active.Checked = False
                    Case pl4_time
                        txtPL4_Name.Text = ""
                        txtPL4_Points.Text = ""
                        txtPL4_Answer.Text = ""
                        chkPL4_Active.Checked = False
                    Case pl5_time
                        txtPL5_Name.Text = ""
                        txtPL5_Points.Text = ""
                        txtPL5_Answer.Text = ""
                        chkPL5_Active.Checked = False
                    Case pl6_time
                        txtPL6_Name.Text = ""
                        txtPL6_Points.Text = ""
                        txtPL6_Answer.Text = ""
                        chkPL6_Active.Checked = False
                    Case pl7_time
                        txtPL7_Name.Text = ""
                        txtPL7_Points.Text = ""
                        txtPL7_Answer.Text = ""
                        chkPL7_Active.Checked = False
                    Case pl8_time
                        txtPL8_Name.Text = ""
                        txtPL8_Points.Text = ""
                        txtPL8_Answer.Text = ""
                        chkPL8_Active.Checked = False
                End Select
            End If
        End If
    End Sub

    Private Sub tmrRevealPlayers_Tick(sender As Object, e As EventArgs) Handles tmrRevealPlayers.Tick

        Select Case act
            Case 0
                If txtPL1_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL1_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL1_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL1_Points.Text = txtPL1_Points.Text
                    TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 1
                If txtPL2_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL2_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL2_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL2_Points.Text = txtPL2_Points.Text
                    TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 2
                If txtPL3_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL3_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL3_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL3_Points.Text = txtPL3_Points.Text
                    TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 3
                If txtPL4_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL4_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL4_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL4_Points.Text = txtPL4_Points.Text
                    TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 4
                If txtPL5_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL5_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL5_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL5_Points.Text = txtPL5_Points.Text
                    TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 5
                If txtPL6_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL6_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL6_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL6_Points.Text = txtPL6_Points.Text
                    TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 6
                If txtPL7_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL7_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL7_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL7_Points.Text = txtPL7_Points.Text
                    TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 7
                If txtPL8_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL8_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL8_Points.ForeColor = Color.Black
                    TVControlPnl.txtPL8_Points.Text = txtPL8_Points.Text
                    TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_correct_new
                End If
            Case 8
                If fff_timemin < 9999 Then
                    tmrFastestPlayer.Start()
                End If
                tmrRevealPlayers.Stop()
        End Select
        act = act + 1
    End Sub

    Dim flash As Integer = 0

    Private Sub tmrFastestPlayer_Tick(sender As Object, e As EventArgs) Handles tmrFastestPlayer.Tick
        Select Case flash
            Case 0
                If pl1_time = fff_timemin Then
                    TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL1_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL1_Points.ForeColor = Color.Black
                End If
                If pl2_time = fff_timemin Then
                    TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL2_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL2_Points.ForeColor = Color.Black
                End If
                If pl3_time = fff_timemin Then
                    TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL3_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL3_Points.ForeColor = Color.Black
                End If
                If pl4_time = fff_timemin Then
                    TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL4_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL4_Points.ForeColor = Color.Black
                End If
                If pl5_time = fff_timemin Then
                    TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL5_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL5_Points.ForeColor = Color.Black
                End If
                If pl6_time = fff_timemin Then
                    TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL6_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL6_Points.ForeColor = Color.Black
                End If
                If pl7_time = fff_timemin Then
                    TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL7_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL6_Points.ForeColor = Color.Black
                End If
                If pl8_time = fff_timemin Then
                    TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_fastest_new
                    TVControlPnl.txtPL8_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL8_Points.ForeColor = Color.Black
                End If
                flash = 1
            Case 1
                If pl1_time = fff_timemin Then
                    TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL1_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL1_Points.ForeColor = Color.Black
                End If
                If pl2_time = fff_timemin Then
                    TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL2_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL2_Points.ForeColor = Color.Black
                End If
                If pl3_time = fff_timemin Then
                    TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL3_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL3_Points.ForeColor = Color.Black
                End If
                If pl4_time = fff_timemin Then
                    TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL4_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL4_Points.ForeColor = Color.Black
                End If
                If pl5_time = fff_timemin Then
                    TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL5_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL5_Points.ForeColor = Color.Black
                End If
                If pl6_time = fff_timemin Then
                    TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL6_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL6_Points.ForeColor = Color.Black
                End If
                If pl7_time = fff_timemin Then
                    TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL7_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL6_Points.ForeColor = Color.Black
                End If
                If pl8_time = fff_timemin Then
                    TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_correct_new
                    TVControlPnl.txtPL8_Name.ForeColor = Color.Black
                    TVControlPnl.txtPL8_Points.ForeColor = Color.Black
                End If
                flash = 0
        End Select

    End Sub

    Private Sub tmrSendAnswers_Tick(sender As Object, e As EventArgs) Handles tmrSendAnswers.Tick
        UpdateList("/q2#" + ControlPanel.txtA.Text + "#" + ControlPanel.txtB.Text + "#" + ControlPanel.txtC.Text + "#" + ControlPanel.txtD.Text, True)
        tmrSendAnswers.Stop()
    End Sub

    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        PlayerCheck.Randomizer()
    End Sub

    Private Sub chkAllVirtual_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllVirtual.CheckedChanged
        If chkAllVirtual.Checked = True Then
            chkPL1.Checked = True
            chkPL2.Checked = True
            chkPL3.Checked = True
            chkPL4.Checked = True
            chkPL5.Checked = True
            chkPL6.Checked = True
            chkPL7.Checked = True
            chkPL8.Checked = True
        Else
            chkPL1.Checked = False
            chkPL2.Checked = False
            chkPL3.Checked = False
            chkPL4.Checked = False
            chkPL5.Checked = False
            chkPL6.Checked = False
            chkPL7.Checked = False
            chkPL8.Checked = False
        End If
    End Sub

    Private Sub btnMeetContestants_Click(sender As Object, e As EventArgs) Handles btnMeetContestants.Click
        PlayerCheck.MeetContestants()
    End Sub

    Private Sub nmrTotalContestants_ValueChanged(sender As Object, e As EventArgs) Handles nmrTotalContestants.ValueChanged
        totalContestants = nmrTotalContestants.Value
        Select Case nmrTotalContestants.Value
            Case 2
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = False
                pnlPlayer4.Visible = False
                pnlPlayer5.Visible = False
                pnlPlayer6.Visible = False
                pnlPlayer7.Visible = False
                pnlPlayer8.Visible = False
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = False
                TVControlPnl.pnlPL4.Visible = False
                TVControlPnl.pnlPL5.Visible = False
                TVControlPnl.pnlPL6.Visible = False
                TVControlPnl.pnlPL7.Visible = False
                TVControlPnl.pnlPL8.Visible = False
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = False
                chkPL4_Active.Checked = False
                chkPL5_Active.Checked = False
                chkPL6_Active.Checked = False
                chkPL7_Active.Checked = False
                chkPL8_Active.Checked = False
            Case 3
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = True
                pnlPlayer4.Visible = False
                pnlPlayer5.Visible = False
                pnlPlayer6.Visible = False
                pnlPlayer7.Visible = False
                pnlPlayer8.Visible = False
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = True
                TVControlPnl.pnlPL4.Visible = False
                TVControlPnl.pnlPL5.Visible = False
                TVControlPnl.pnlPL6.Visible = False
                TVControlPnl.pnlPL7.Visible = False
                TVControlPnl.pnlPL8.Visible = False
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = True
                chkPL4_Active.Checked = False
                chkPL5_Active.Checked = False
                chkPL6_Active.Checked = False
                chkPL7_Active.Checked = False
                chkPL8_Active.Checked = False
            Case 4
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = True
                pnlPlayer4.Visible = True
                pnlPlayer5.Visible = False
                pnlPlayer6.Visible = False
                pnlPlayer7.Visible = False
                pnlPlayer8.Visible = False
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = True
                TVControlPnl.pnlPL4.Visible = True
                TVControlPnl.pnlPL5.Visible = False
                TVControlPnl.pnlPL6.Visible = False
                TVControlPnl.pnlPL7.Visible = False
                TVControlPnl.pnlPL8.Visible = False
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = True
                chkPL4_Active.Checked = True
                chkPL5_Active.Checked = False
                chkPL6_Active.Checked = False
                chkPL7_Active.Checked = False
                chkPL8_Active.Checked = False
            Case 5
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = True
                pnlPlayer4.Visible = True
                pnlPlayer5.Visible = True
                pnlPlayer6.Visible = False
                pnlPlayer7.Visible = False
                pnlPlayer8.Visible = False
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = True
                TVControlPnl.pnlPL4.Visible = True
                TVControlPnl.pnlPL5.Visible = True
                TVControlPnl.pnlPL6.Visible = False
                TVControlPnl.pnlPL7.Visible = False
                TVControlPnl.pnlPL8.Visible = False
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = True
                chkPL4_Active.Checked = True
                chkPL5_Active.Checked = True
                chkPL6_Active.Checked = False
                chkPL7_Active.Checked = False
                chkPL8_Active.Checked = False
            Case 6
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = True
                pnlPlayer4.Visible = True
                pnlPlayer5.Visible = True
                pnlPlayer6.Visible = True
                pnlPlayer7.Visible = False
                pnlPlayer8.Visible = False
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = True
                TVControlPnl.pnlPL4.Visible = True
                TVControlPnl.pnlPL5.Visible = True
                TVControlPnl.pnlPL6.Visible = True
                TVControlPnl.pnlPL7.Visible = False
                TVControlPnl.pnlPL8.Visible = False
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = True
                chkPL4_Active.Checked = True
                chkPL5_Active.Checked = True
                chkPL6_Active.Checked = True
                chkPL7_Active.Checked = False
                chkPL8_Active.Checked = False
            Case 7
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = True
                pnlPlayer4.Visible = True
                pnlPlayer5.Visible = True
                pnlPlayer6.Visible = True
                pnlPlayer7.Visible = True
                pnlPlayer8.Visible = False
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = True
                TVControlPnl.pnlPL4.Visible = True
                TVControlPnl.pnlPL5.Visible = True
                TVControlPnl.pnlPL6.Visible = True
                TVControlPnl.pnlPL7.Visible = True
                TVControlPnl.pnlPL8.Visible = False
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = True
                chkPL4_Active.Checked = True
                chkPL5_Active.Checked = True
                chkPL6_Active.Checked = True
                chkPL7_Active.Checked = True
                chkPL8_Active.Checked = False
            Case 8
                pnlPlayer2.Visible = True
                pnlPlayer3.Visible = True
                pnlPlayer4.Visible = True
                pnlPlayer5.Visible = True
                pnlPlayer6.Visible = True
                pnlPlayer7.Visible = True
                pnlPlayer8.Visible = True
                TVControlPnl.pnlPL2.Visible = True
                TVControlPnl.pnlPL3.Visible = True
                TVControlPnl.pnlPL4.Visible = True
                TVControlPnl.pnlPL5.Visible = True
                TVControlPnl.pnlPL6.Visible = True
                TVControlPnl.pnlPL7.Visible = True
                TVControlPnl.pnlPL8.Visible = True
                chkPL2_Active.Checked = True
                chkPL3_Active.Checked = True
                chkPL4_Active.Checked = True
                chkPL5_Active.Checked = True
                chkPL6_Active.Checked = True
                chkPL7_Active.Checked = True
                chkPL8_Active.Checked = True
        End Select
    End Sub

    Private Sub chkPL1_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL1_Active.CheckedChanged
        If chkPL1_Active.Checked = True Then
            TVControlPnl.txtPL1_Name.Visible = True
            TVControlPnl.txtPL1_Points.Visible = True
            txtPL1_Name.Visible = True
            txtPL1_Answer.Visible = True
            txtPL1_Points.Visible = True
        ElseIf chkPL1_Active.Checked = False Then
            TVControlPnl.txtPL1_Name.Visible = False
            TVControlPnl.txtPL1_Points.Visible = False
            txtPL1_Name.Visible = False
            txtPL1_Answer.Visible = False
            txtPL1_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL2_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL2_Active.CheckedChanged
        If chkPL2_Active.Checked = True Then
            TVControlPnl.txtPL2_Name.Visible = True
            TVControlPnl.txtPL2_Points.Visible = True
            txtPL2_Name.Visible = True
            txtPL2_Answer.Visible = True
            txtPL2_Points.Visible = True
        ElseIf chkPL2_Active.Checked = False Then
            TVControlPnl.txtPL2_Name.Visible = False
            TVControlPnl.txtPL2_Points.Visible = False
            txtPL2_Name.Visible = False
            txtPL2_Answer.Visible = False
            txtPL2_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL3_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL3_Active.CheckedChanged
        If chkPL3_Active.Checked = True Then
            TVControlPnl.txtPL3_Name.Visible = True
            TVControlPnl.txtPL3_Points.Visible = True
            txtPL3_Name.Visible = True
            txtPL3_Answer.Visible = True
            txtPL3_Points.Visible = True
        ElseIf chkPL3_Active.Checked = False Then
            TVControlPnl.txtPL3_Name.Visible = False
            TVControlPnl.txtPL3_Points.Visible = False
            txtPL3_Name.Visible = False
            txtPL3_Answer.Visible = False
            txtPL3_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL4_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL4_Active.CheckedChanged
        If chkPL4_Active.Checked = True Then
            TVControlPnl.txtPL4_Name.Visible = True
            TVControlPnl.txtPL4_Points.Visible = True
            txtPL4_Name.Visible = True
            txtPL4_Answer.Visible = True
            txtPL4_Points.Visible = True
        ElseIf chkPL4_Active.Checked = False Then
            TVControlPnl.txtPL4_Name.Visible = False
            TVControlPnl.txtPL4_Points.Visible = False
            txtPL4_Name.Visible = False
            txtPL4_Answer.Visible = False
            txtPL4_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL5_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL5_Active.CheckedChanged
        If chkPL5_Active.Checked = True Then
            TVControlPnl.txtPL5_Name.Visible = True
            TVControlPnl.txtPL5_Points.Visible = True
            txtPL5_Name.Visible = True
            txtPL5_Answer.Visible = True
            txtPL5_Points.Visible = True
        ElseIf chkPL5_Active.Checked = False Then
            TVControlPnl.txtPL5_Name.Visible = False
            TVControlPnl.txtPL5_Points.Visible = False
            txtPL5_Name.Visible = False
            txtPL5_Answer.Visible = False
            txtPL5_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL6_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL6_Active.CheckedChanged
        If chkPL6_Active.Checked = True Then
            TVControlPnl.txtPL6_Name.Visible = True
            TVControlPnl.txtPL6_Points.Visible = True
            txtPL6_Name.Visible = True
            txtPL6_Answer.Visible = True
            txtPL6_Points.Visible = True
        ElseIf chkPL6_Active.Checked = False Then
            TVControlPnl.txtPL6_Name.Visible = False
            TVControlPnl.txtPL6_Points.Visible = False
            txtPL6_Name.Visible = False
            txtPL6_Answer.Visible = False
            txtPL6_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL7_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL7_Active.CheckedChanged
        If chkPL7_Active.Checked = True Then
            TVControlPnl.txtPL7_Name.Visible = True
            TVControlPnl.txtPL6_Points.Visible = True
            txtPL7_Name.Visible = True
            txtPL7_Answer.Visible = True
            txtPL7_Points.Visible = True
        ElseIf chkPL7_Active.Checked = False Then
            TVControlPnl.txtPL7_Name.Visible = False
            TVControlPnl.txtPL6_Points.Visible = False
            txtPL7_Name.Visible = False
            txtPL7_Answer.Visible = False
            txtPL7_Points.Visible = False
        End If
    End Sub

    Private Sub chkPL8_Active_CheckedChanged(sender As Object, e As EventArgs) Handles chkPL8_Active.CheckedChanged
        If chkPL8_Active.Checked = True Then
            TVControlPnl.txtPL8_Name.Visible = True
            TVControlPnl.txtPL8_Points.Visible = True
            txtPL8_Name.Visible = True
            txtPL8_Answer.Visible = True
            txtPL8_Points.Visible = True
        ElseIf chkPL8_Active.Checked = False Then
            TVControlPnl.txtPL8_Name.Visible = False
            TVControlPnl.txtPL8_Points.Visible = False
            txtPL8_Name.Visible = False
            txtPL8_Answer.Visible = False
            txtPL8_Points.Visible = False
        End If
    End Sub

    Private Sub chkShowPointsInServerConsole_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPointsInServerConsole.CheckedChanged
        If chkShowPointsInServerConsole.Checked = True Then
            txtPL1_Answer.ForeColor = Color.White
            txtPL2_Answer.ForeColor = Color.White
            txtPL3_Answer.ForeColor = Color.White
            txtPL4_Answer.ForeColor = Color.White
            txtPL5_Answer.ForeColor = Color.White
            txtPL6_Answer.ForeColor = Color.White
            txtPL7_Answer.ForeColor = Color.White
            txtPL8_Answer.ForeColor = Color.White
            txtPL1_Points.ForeColor = Color.White
            txtPL2_Points.ForeColor = Color.White
            txtPL3_Points.ForeColor = Color.White
            txtPL4_Points.ForeColor = Color.White
            txtPL5_Points.ForeColor = Color.White
            txtPL6_Points.ForeColor = Color.White
            txtPL7_Points.ForeColor = Color.White
            txtPL8_Points.ForeColor = Color.White
        ElseIf chkShowPointsInServerConsole.Checked = False Then
            txtPL1_Answer.ForeColor = Color.Black
            txtPL2_Answer.ForeColor = Color.Black
            txtPL3_Answer.ForeColor = Color.Black
            txtPL4_Answer.ForeColor = Color.Black
            txtPL5_Answer.ForeColor = Color.Black
            txtPL6_Answer.ForeColor = Color.Black
            txtPL7_Answer.ForeColor = Color.Black
            txtPL8_Answer.ForeColor = Color.Black
            txtPL1_Points.ForeColor = Color.Black
            txtPL2_Points.ForeColor = Color.Black
            txtPL3_Points.ForeColor = Color.Black
            txtPL4_Points.ForeColor = Color.Black
            txtPL5_Points.ForeColor = Color.Black
            txtPL6_Points.ForeColor = Color.Black
            txtPL7_Points.ForeColor = Color.Black
            txtPL8_Points.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Handler()
        Dim elapsed As TimeSpan = stopwatch.Elapsed

        time = String.Format("{0:00},{1:00}", elapsed.ToString("%s"), CInt(Math.Round(elapsed.Milliseconds / 10)))
    End Sub

    Private Sub FFFServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True     ' Cancel the event if the user has done that.
        Else
            e.Cancel = False    ' If the user hasn't closed the form, then the event won't be canceled.
        End If
    End Sub
End Class
