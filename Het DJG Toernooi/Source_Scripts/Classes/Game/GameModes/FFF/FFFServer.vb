Imports System.Net
Imports System.IO
Imports System.Net.Sockets

'Server Side
Public Class FFFServer

    Dim Listening As TcpListener
    Dim Allclient As TcpClient
    Dim clientList As New List(Of ClientClass)
    Dim pReader As StreamReader
    Dim pClient As ClientClass

    'Game instances
    Public newQ As New QDatabase
    Dim options As New Game
    Public Shared snd As New SOUND

    'Game info
    Dim fff_think As Boolean = False
    Public fff_points As Integer = 0
    Dim fff_pointsmax As Integer = Integer.MaxValue
    Public Shared fff_pointsmin As Integer = Integer.MinValue
    Public correctAnswer As String

    Public act As Integer
    Public i As Integer = 0
    Public a As Integer = 0
    Dim q As Integer = 0

    Public Shared firstMan As Boolean = True

    'Player 1 Info
    Dim pl1_name As String          'Name
    Dim pl1_answer As String        'Answer
    Public Shared pl1_points As Integer = 9999

    'Player 2 Info
    Dim pl2_name As String          'Name
    Dim pl2_answer As String        'Answer
    Public Shared pl2_points As Integer = 9999

    'Player 3 Info
    Dim pl3_name As String          'Name
    Dim pl3_answer As String        'Answer
    Public Shared pl3_points As Integer = 9999

    'Player 4 Info
    Dim pl4_name As String          'Name
    Dim pl4_answer As String        'Answer
    Public Shared pl4_points As Integer = 9999

    'Player 5 Info
    Dim pl5_name As String          'Name
    Dim pl5_answer As String        'Answer
    Public Shared pl5_points As Integer = 9999

    'Player 6 Info
    Dim pl6_name As String          'Name
    Dim pl6_answer As String        'Answer
    Public Shared pl6_points As Integer = 9999

    'Player 7 Info
    Dim pl7_name As String          'Name
    Dim pl7_answer As String        'Answer
    Public Shared pl7_points As Integer = 9999

    'Player 8 Info
    Dim pl8_name As String          'Name
    Dim pl8_answer As String        'Answer
    Public Shared pl8_points As Integer = 9999

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listening = New TcpListener(IPAddress.Any, 3818)
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
                send(str)
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
                Case 1
                    txtPL1_Answer.Text = rcvList(1)
                    If txtPL1_Answer.Text = correctAnswer Then
                        pl1_points = fff_points
                        txtPL1_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 2
                    txtPL2_Answer.Text = rcvList(1)
                    If txtPL2_Answer.Text = correctAnswer Then
                        pl2_points = fff_points
                        txtPL2_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 3
                    txtPL3_Answer.Text = rcvList(1)
                    If txtPL3_Answer.Text = correctAnswer Then
                        pl3_points = fff_points
                        txtPL3_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 4
                    txtPL4_Answer.Text = rcvList(1)
                    If txtPL4_Answer.Text = correctAnswer Then
                        pl4_points = fff_points
                        txtPL4_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 5
                    txtPL5_Answer.Text = rcvList(1)
                    If txtPL5_Answer.Text = correctAnswer Then
                        pl5_points = fff_points
                        txtPL5_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 6
                    txtPL6_Answer.Text = rcvList(1)
                    If txtPL6_Answer.Text = correctAnswer Then
                        pl6_points = fff_points
                        txtPL6_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 7
                    txtPL7_Answer.Text = rcvList(1)
                    If txtPL7_Answer.Text = correctAnswer Then
                        pl7_points = fff_points
                        txtPL7_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
                            firstMan = False
                        End If
                    End If
                Case 8
                    txtPL8_Answer.Text = rcvList(1)
                    If txtPL8_Answer.Text = correctAnswer Then
                        pl8_points = fff_points
                        txtPL8_Points.Text = fff_points
                        If firstMan = True Then
                            fff_pointsmin = fff_points
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
        FFFQuestion.Fill()
        PlayerCheck.Randomizer()
        txtReceive.Clear()
        fff_think = True
        tmrStopSnd1.Start()
        tmrThink.Start()
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
        tmrSendAnswers.Start()

        ControlPanel.intSound += 1

        With snd
            .Name = "SOUND" & ControlPanel.intSound
            .Play(43, False, 1000)
        End With
        ControlPanel.intSound += 1

        With snd
            .Name = "SOUND" & ControlPanel.intSound
            .Play(37, False, 1000)
        End With

        UpdateList("/unlock", True)
        tmrPoints.Start()
    End Sub

    Private Sub tmrStopSnd1_Tick(sender As Object, e As EventArgs) Handles tmrStopSnd1.Tick
        My.Computer.Audio.Stop()
        tmrStopSnd1.Stop()
    End Sub

    Private Sub tmrThink_Tick(sender As Object, e As EventArgs) Handles tmrThink.Tick
        fff_think = False
        PlayerCheck.Tiebreaker()
        q = 0
        UpdateList("/lock", True)

        tmrThink.Stop()
        tmrPoints.Stop()
    End Sub

    Private Sub tmrPoints_Tick(sender As Object, e As EventArgs) Handles tmrPoints.Tick
        fff_points += 1
        lblPoints.Text = fff_points
    End Sub

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click

        Select Case i
            Case 0
                TVControlPnl.pnlQuestion.Visible = False
                i = i + 1
            Case 1
                My.Computer.Audio.Play(My.Resources.fastest_finger_read_answer_order, AudioPlayMode.Background)
                i = i + 1
            Case 2
                TVControlPnl.picTree.BackgroundImage = My.Resources.tree_0
                TVControlPnl.lblFFFQuestion.Visible = True
                TVControlPnl.pic50.Visible = False
                TVControlPnl.picVO.Visible = False
                TVControlPnl.picPO.Visible = False
                TVControlPnl.picSW.Visible = False
                TVControlPnl.picTree.Visible = True
                i = i + 1
            Case 3
                TVControlPnl.pnlFFFOrder1.Visible = True
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(31, False, 1000)
                End With
                i = i + 1
            Case 4
                TVControlPnl.pnlFFFOrder2.Visible = True
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(32, False, 1000)
                End With
                i = i + 1
            Case 5
                TVControlPnl.pnlFFFOrder3.Visible = True
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(33, False, 1000)
                End With
                i = i + 1
            Case 6
                TVControlPnl.pnlFFFOrder4.Visible = True
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(34, False, 1000)
                End With
                i = i + 1
        End Select

        'If i = 0 Then
        '    HostScreen.pnlAnswer.BackColor = Color.LightGray
        '    If ControlPanel.lblAnswer.Text = "A" Then
        '        HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
        '        GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill_l
        '        ControlPanel.txtA.BackColor = Color.Green
        '    End If
        '    If ControlPanel.lblAnswer.Text = "B" Then
        '        HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
        '        GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill_r
        '        ControlPanel.txtB.BackColor = Color.Green
        '    End If
        '    If ControlPanel.lblAnswer.Text = "C" Then
        '        HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
        '        GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill_l
        '        ControlPanel.txtC.BackColor = Color.Green
        '    End If
        '    If ControlPanel.lblAnswer.Text = "D" Then
        '        HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
        '        GuestScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill_r
        '        ControlPanel.txtD.BackColor = Color.Green
        '    End If
        '    If settingsVar.level = -1 Then
        '        ControlPanel.intSound += 1

        '        With snd
        '            .Name = "SOUND" & ControlPanel.intSound
        '            .Play(32, False, 1000)
        '        End With
        '    End If
        '    i = i + 1
        '    TVControlPnl.tmrFlash.Start()
        'Else
        '    TVControlPnl.txtA.BackColor = Color.Transparent
        '    TVControlPnl.txtB.BackColor = Color.Transparent
        '    TVControlPnl.txtC.BackColor = Color.Transparent
        '    TVControlPnl.txtD.BackColor = Color.Transparent
        '    TVControlPnl.txtA.ForeColor = Color.White
        '    TVControlPnl.txtB.ForeColor = Color.White
        '    TVControlPnl.txtC.ForeColor = Color.White
        '    TVControlPnl.txtD.ForeColor = Color.White
        '    TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        '    TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        '    TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        '    TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        '    TVControlPnl.pnlQuestion.Visible = False
        '    TVControlPnl.pnlStrap.Visible = False
        '    TVControlPnl.tmrFlash.Stop()
        'End If
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
            TVControlPnl.pic50.Visible = False
            TVControlPnl.picVO.Visible = False
            TVControlPnl.picPO.Visible = False
            TVControlPnl.picSW.Visible = False
            tmrRevealPlayers.Start()
            If Game.level = -1 Then
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(35, False, 1000)
                End With
            End If
            ControlPanel.Timer1.Start()
            a = a + 1
        ElseIf a = 2 Then

            If fff_pointsmin < 9999 Then

                If PlayerCheck.tie = 1 Then
                    ControlPanel.intSound += 1
                    With snd
                        .Name = "SOUND" & ControlPanel.intSound
                        .Play(44, False, 1000)
                    End With
                    Select Case fff_pointsmin
                        Case pl1_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL1_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl1_points
                        Case pl2_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL2_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl2_points
                        Case pl3_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL3_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl3_points
                        Case pl4_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL4_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl4_points
                        Case pl5_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL5_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl5_points
                        Case pl6_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL6_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl6_points
                        Case pl7_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL7_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl7_points
                        Case pl8_points
                            TVControlPnl.lblFFFWinnerName.Text = txtPL8_Name.Text
                            TVControlPnl.lblFFFWinnerPoints.Text = pl8_points
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
        End If
    End Sub

    Private Sub tmrRevealPlayers_Tick(sender As Object, e As EventArgs) Handles tmrRevealPlayers.Tick

        Select Case act
            Case 0
                If txtPL1_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL1_Name.ForeColor = Color.White
                    TVControlPnl.txtPL1_Points.ForeColor = Color.White
                    TVControlPnl.txtPL1_Points.Text = txtPL1_Points.Text
                    TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_correct
                End If
            Case 1
                If txtPL2_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL2_Name.ForeColor = Color.White
                    TVControlPnl.txtPL2_Points.ForeColor = Color.White
                    TVControlPnl.txtPL2_Points.Text = txtPL2_Points.Text
                    TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_correct
                End If
            Case 2
                If txtPL3_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL3_Name.ForeColor = Color.White
                    TVControlPnl.txtPL3_Points.ForeColor = Color.White
                    TVControlPnl.txtPL3_Points.Text = txtPL3_Points.Text
                    TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_correct
                End If
            Case 3
                If txtPL4_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL4_Name.ForeColor = Color.White
                    TVControlPnl.txtPL4_Points.ForeColor = Color.White
                    TVControlPnl.txtPL4_Points.Text = txtPL4_Points.Text
                    TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_correct
                End If
            Case 4
                If txtPL5_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL5_Name.ForeColor = Color.White
                    TVControlPnl.txtPL5_Points.ForeColor = Color.White
                    TVControlPnl.txtPL5_Points.Text = txtPL5_Points.Text
                    TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_correct
                End If
            Case 5
                If txtPL6_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL6_Name.ForeColor = Color.White
                    TVControlPnl.txtPL6_Points.ForeColor = Color.White
                    TVControlPnl.txtPL6_Points.Text = txtPL6_Points.Text
                    TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_correct
                End If
            Case 6
                If txtPL7_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL7_Name.ForeColor = Color.White
                    TVControlPnl.txtPL7_Points.ForeColor = Color.White
                    TVControlPnl.txtPL7_Points.Text = txtPL7_Points.Text
                    TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_correct
                End If
            Case 7
                If txtPL8_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL8_Name.ForeColor = Color.White
                    TVControlPnl.txtPL8_Points.ForeColor = Color.White
                    TVControlPnl.txtPL8_Points.Text = txtPL8_Points.Text
                    TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_correct
                End If
            Case 8
                If fff_pointsmin < 9999 Then
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
                If pl1_points = fff_pointsmin Then
                    TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL1_Name.ForeColor = Color.White
                    TVControlPnl.txtPL1_Points.ForeColor = Color.White
                End If
                If pl2_points = fff_pointsmin Then
                    TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL2_Name.ForeColor = Color.White
                    TVControlPnl.txtPL2_Points.ForeColor = Color.White
                End If
                If pl3_points = fff_pointsmin Then
                    TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL3_Name.ForeColor = Color.White
                    TVControlPnl.txtPL3_Points.ForeColor = Color.White
                End If
                If pl4_points = fff_pointsmin Then
                    TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL4_Name.ForeColor = Color.White
                    TVControlPnl.txtPL4_Points.ForeColor = Color.White
                End If
                If pl5_points = fff_pointsmin Then
                    TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL5_Name.ForeColor = Color.White
                    TVControlPnl.txtPL5_Points.ForeColor = Color.White
                End If
                If pl6_points = fff_pointsmin Then
                    TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL6_Name.ForeColor = Color.White
                    TVControlPnl.txtPL6_Points.ForeColor = Color.White
                End If
                If pl7_points = fff_pointsmin Then
                    TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL7_Name.ForeColor = Color.White
                    TVControlPnl.txtPL7_Points.ForeColor = Color.White
                End If
                If pl8_points = fff_pointsmin Then
                    TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_idle
                    TVControlPnl.txtPL8_Name.ForeColor = Color.White
                    TVControlPnl.txtPL8_Points.ForeColor = Color.White
                End If
                flash = 1
            Case 1
                If pl1_points = fff_pointsmin Then
                    TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL1_Name.ForeColor = Color.White
                    TVControlPnl.txtPL1_Points.ForeColor = Color.White
                End If
                If pl2_points = fff_pointsmin Then
                    TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL2_Name.ForeColor = Color.White
                    TVControlPnl.txtPL2_Points.ForeColor = Color.White
                End If
                If pl3_points = fff_pointsmin Then
                    TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL3_Name.ForeColor = Color.White
                    TVControlPnl.txtPL3_Points.ForeColor = Color.White
                End If
                If pl4_points = fff_pointsmin Then
                    TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL4_Name.ForeColor = Color.White
                    TVControlPnl.txtPL4_Points.ForeColor = Color.White
                End If
                If pl5_points = fff_pointsmin Then
                    TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL5_Name.ForeColor = Color.White
                    TVControlPnl.txtPL5_Points.ForeColor = Color.White
                End If
                If pl6_points = fff_pointsmin Then
                    TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL6_Name.ForeColor = Color.White
                    TVControlPnl.txtPL6_Points.ForeColor = Color.White
                End If
                If pl7_points = fff_pointsmin Then
                    TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL7_Name.ForeColor = Color.White
                    TVControlPnl.txtPL7_Points.ForeColor = Color.White
                End If
                If pl8_points = fff_pointsmin Then
                    TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_correct
                    TVControlPnl.txtPL8_Name.ForeColor = Color.White
                    TVControlPnl.txtPL8_Points.ForeColor = Color.White
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

    Public Shared totalContestants As Integer = 8

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
        End Select
    End Sub
End Class
