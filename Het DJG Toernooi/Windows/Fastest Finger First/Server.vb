Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class Server

    'Server info
    Dim ServerStatus As Boolean = False
    Dim ServerTrying As Boolean = False
    Dim Server As TcpListener
    Dim Clients As New List(Of TcpClient)

    'Game instances
    Dim newQ As New QDatabase
    Dim options As New settingsVar
    Public Shared snd As New SOUND

    'Game info
    Dim fff_think As Boolean = False
    Dim fff_points As Integer = 0
    Dim fff_pointsmax As Integer = Integer.MaxValue
    Dim fff_pointsmin As Integer = Integer.MinValue
    Dim correctAnswer As String

    'Player 1 Info
    Dim pl1_name As String          'Name
    Dim pl1_answer As String        'Answer
    Dim pl1_points As Integer = 9999

    'Player 2 Info
    Dim pl2_name As String          'Name
    Dim pl2_answer As String        'Answer
    Dim pl2_points As Integer = 9999

    'Player 3 Info
    Dim pl3_name As String          'Name
    Dim pl3_answer As String        'Answer
    Dim pl3_points As Integer = 9999

    'Player 4 Info
    Dim pl4_name As String          'Name
    Dim pl4_answer As String        'Answer
    Dim pl4_points As Integer = 9999

    'Player 5 Info
    Dim pl5_name As String          'Name
    Dim pl5_answer As String        'Answer
    Dim pl5_points As Integer = 9999

    'Player 6 Info
    Dim pl6_name As String          'Name
    Dim pl6_answer As String        'Answer
    Dim pl6_points As Integer = 9999

    'Player 7 Info
    Dim pl7_name As String          'Name
    Dim pl7_answer As String        'Answer
    Dim pl7_points As Integer = 9999

    'Player 8 Info
    Dim pl8_name As String          'Name
    Dim pl8_answer As String        'Answer
    Dim pl8_points As Integer = 9999

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        StartServer()
    End Sub

    Private Sub btnStartServer_Click(sender As Object, e As EventArgs) Handles btnStartServer.Click
        StartServer()
    End Sub

    Private Sub btnStopServer_Click(sender As Object, e As EventArgs) Handles btnStopServer.Click
        StopServer()
    End Sub

    Function StartServer()
        If ServerStatus = False Then
            ServerTrying = True
            Try
                Server = New TcpListener(IPAddress.Any, 1200)
                Server.Start()
                ServerStatus = True
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                MsgBox("Server started!")
            Catch ex As Exception
                ServerStatus = False
                MsgBox(ex.Message)
            End Try
            ServerTrying = False
        End If
        Return True
    End Function

    Function StopServer()
        If ServerStatus = True Then
            ServerTrying = True
            txtSend.Text = "/close"
            Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, txtSend.Text)
            Try
                For Each Client As TcpClient In Clients
                    Client.Close()
                Next
                Server.Stop()
                ServerStatus = False
            Catch ex As Exception
                StopServer()
            End Try
        End If
        Return True
    End Function

    Function Handler_Client(ByVal state As Object)
        Dim TempClient As TcpClient

        Try
            Using Client As TcpClient = Server.AcceptTcpClient
                If ServerTrying = False Then
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                End If
                Clients.Add(Client)
                TempClient = Client
                Dim TX As New StreamWriter(Client.GetStream)
                Dim RX As New StreamReader(Client.GetStream)
                If RX.BaseStream.CanRead = True Then
                    While RX.BaseStream.CanRead = True
                        Dim RawData As String = RX.ReadLine
                        'txtReceive.Text = Client.Client.RemoteEndPoint.ToString + RawData
                        txtReceive.Text = RawData
                    End While
                End If

                If RX.BaseStream.CanRead = False Then
                    Client.Close()
                    Clients.Remove(Client)
                End If
            End Using
            If TempClient.GetStream.CanRead = False Then
                TempClient.Close()
                Clients.Remove(TempClient)
            End If
        Catch ex As Exception
            Try
                If TempClient.GetStream.CanRead = False Then
                    TempClient.Close()
                    Clients.Remove(TempClient)
                End If
            Catch ex2 As Exception
                TempClient.Close()
                Clients.Remove(TempClient)
            End Try
        End Try
        Return True
    End Function

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, txtSend.Text)
    End Sub

    Function SendToClients(ByVal Data As String)
        If ServerStatus = True Then
            If Clients.Count > 0 Then
                Try
                    For Each Client As TcpClient In Clients
                        Dim TX1 As New StreamWriter(Client.GetStream)
                        'Dim RX1 As New StreamReader(Client.GetStream)
                        TX1.WriteLine(Data)
                        TX1.Flush()
                    Next
                Catch ex As Exception
                    SendToClients(Data)
                End Try
            End If
        End If
        Return True
    End Function

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
                    End If
                Case 2
                    txtPL2_Answer.Text = rcvList(1)
                    If txtPL2_Answer.Text = correctAnswer Then
                        pl2_points = fff_points
                        txtPL2_Points.Text = fff_points
                    End If
                Case 3
                    txtPL3_Answer.Text = rcvList(1)
                    If txtPL3_Answer.Text = correctAnswer Then
                        pl3_points = fff_points
                        txtPL3_Points.Text = fff_points
                    End If
                Case 4
                    txtPL4_Answer.Text = rcvList(1)
                    If txtPL4_Answer.Text = correctAnswer Then
                        pl4_points = fff_points
                        txtPL4_Points.Text = fff_points
                    End If
                Case 5
                    txtPL5_Answer.Text = rcvList(1)
                    If txtPL5_Answer.Text = correctAnswer Then
                        pl5_points = fff_points
                        txtPL5_Points.Text = fff_points
                    End If
                Case 6
                    txtPL6_Answer.Text = rcvList(1)
                    If txtPL6_Answer.Text = correctAnswer Then
                        pl6_points = fff_points
                        txtPL6_Points.Text = fff_points
                    End If
                Case 7
                    txtPL7_Answer.Text = rcvList(1)
                    If txtPL7_Answer.Text = correctAnswer Then
                        pl7_points = fff_points
                        txtPL7_Points.Text = fff_points
                    End If
                Case 8
                    txtPL8_Answer.Text = rcvList(1)
                    If txtPL8_Answer.Text = correctAnswer Then
                        pl8_points = fff_points
                        txtPL8_Points.Text = fff_points
                    End If
            End Select
        End If
    End Sub

    Private Sub btnGenQuestion_Click(sender As Object, e As EventArgs) Handles btnGenQuestion.Click
        settingsVar.level = -1

        i = 0
        a = 0
        act = 0
        fff_points = 0
        fff_pointsmax = 0
        fff_pointsmin = 0

        pl1_points = 9999
        pl2_points = 9999
        pl3_points = 9999
        pl4_points = 9999
        pl5_points = 9999
        pl6_points = 9999
        pl7_points = 9999
        pl8_points = 9999
        txtReceive.Clear()

        lblPoints.Text = "0"

        txtPL1_Answer.Clear()
        txtPL1_Points.Clear()
        txtPL2_Answer.Clear()
        txtPL2_Points.Clear()
        txtPL3_Answer.Clear()
        txtPL3_Points.Clear()
        txtPL4_Answer.Clear()
        txtPL4_Points.Clear()
        txtPL5_Answer.Clear()
        txtPL5_Points.Clear()
        txtPL6_Answer.Clear()
        txtPL6_Points.Clear()
        txtPL7_Answer.Clear()
        txtPL7_Points.Clear()
        txtPL8_Answer.Clear()
        txtPL8_Points.Clear()

        HostScreen.pnlAnswer.BackColor = Color.Black
        HostScreen.lbl5050Used.ForeColor = Color.Black
        HostScreen.lblSwitchUsed.ForeColor = Color.Black
        HostScreen.lblPlusOneUsed.ForeColor = Color.Black
        HostScreen.lblVoteUsed.ForeColor = Color.Black
        ControlPanel.txtA.BackColor = SystemColors.Control
        ControlPanel.txtB.BackColor = SystemColors.Control
        ControlPanel.txtC.BackColor = SystemColors.Control
        ControlPanel.txtD.BackColor = SystemColors.Control

        HostScreen.txtA.ForeColor = Color.White
        HostScreen.txtB.ForeColor = Color.White
        HostScreen.txtC.ForeColor = Color.White
        HostScreen.txtD.ForeColor = Color.White
        HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill
        HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill
        HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill
        HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill
        GuestScreen.txtA.ForeColor = Color.White
        GuestScreen.txtB.ForeColor = Color.White
        GuestScreen.txtC.ForeColor = Color.White
        GuestScreen.txtD.ForeColor = Color.White
        GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill
        GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill
        GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill
        GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill
        TVControlPnl.txtA.ForeColor = Color.White
        TVControlPnl.txtB.ForeColor = Color.White
        TVControlPnl.txtC.ForeColor = Color.White
        TVControlPnl.txtD.ForeColor = Color.White
        HostScreen.txtATAa.ForeColor = Color.White
        HostScreen.txtATAb.ForeColor = Color.White
        HostScreen.txtATAc.ForeColor = Color.White
        HostScreen.txtATAd.ForeColor = Color.White
        GuestScreen.txtATAa.ForeColor = Color.White
        GuestScreen.txtATAb.ForeColor = Color.White
        GuestScreen.txtATAc.ForeColor = Color.White
        GuestScreen.txtATAd.ForeColor = Color.White

        HostScreen.txtATAa.Text = ""
        HostScreen.txtATAb.Text = ""
        HostScreen.txtATAc.Text = ""
        HostScreen.txtATAd.Text = ""
        GuestScreen.txtATAa.Text = ""
        GuestScreen.txtATAb.Text = ""
        GuestScreen.txtATAc.Text = ""
        GuestScreen.txtATAd.Text = ""
        TVControlPnl.txtA.Text = ""
        TVControlPnl.txtB.Text = ""
        TVControlPnl.txtC.Text = ""
        TVControlPnl.txtD.Text = ""
        HostScreen.txtA.Text = ""
        HostScreen.txtB.Text = ""
        HostScreen.txtC.Text = ""
        HostScreen.txtD.Text = ""
        GuestScreen.txtA.Text = ""
        GuestScreen.txtB.Text = ""
        GuestScreen.txtC.Text = ""
        GuestScreen.txtD.Text = ""


        TVControlPnl.txtA.Visible = False
        TVControlPnl.txtB.Visible = False
        TVControlPnl.txtC.Visible = False
        TVControlPnl.txtD.Visible = False
        TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill
        TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill
        TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill
        TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill
        TVControlPnl.tmrFlash.Stop()

        newQ.newQuestion()
        correctAnswer = ControlPanel.lblAnswer.Text

        HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
        TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
        GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
        HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
        HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text
        My.Computer.Audio.Play(My.Resources.fastest_finger_read_question, AudioPlayMode.Background)
        TVControlPnl.pnlQuestion.Visible = True
    End Sub

    Private Sub btnStartTime_Click(sender As Object, e As EventArgs) Handles btnStartTime.Click
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

        tmrPoints.Start()

        txtSend.Text = "/unlock"
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, txtSend.Text)
    End Sub

    Private Sub tmrStopSnd1_Tick(sender As Object, e As EventArgs) Handles tmrStopSnd1.Tick
        My.Computer.Audio.Stop()
        tmrStopSnd1.Stop()
    End Sub

    Private Sub tmrThink_Tick(sender As Object, e As EventArgs) Handles tmrThink.Tick
        txtSend.Text = "/lock"
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, txtSend.Text)
        fff_think = False
        HostScreen.pnlAnswer.BackColor = Color.LightGray

        fff_pointsmin = pl1_points
        If pl2_points < fff_pointsmin Then
            fff_pointsmin = pl2_points
        End If
        If pl3_points < fff_pointsmin Then
            fff_pointsmin = pl3_points
        End If
        If pl4_points < fff_pointsmin Then
            fff_pointsmin = pl4_points
        End If
        If pl5_points < fff_pointsmin Then
            fff_pointsmin = pl5_points
        End If
        If pl6_points < fff_pointsmin Then
            fff_pointsmin = pl6_points
        End If
        If pl7_points < fff_pointsmin Then
            fff_pointsmin = pl7_points
        End If
        If pl8_points < fff_pointsmin Then
            fff_pointsmin = pl8_points
        End If

        'MsgBox("The smallest score is: " + Convert.ToString(fff_pointsmin) +
        '       vbNewLine +
        '       Convert.ToString(pl1_points) + " + " +
        '       Convert.ToString(pl2_points) + " + " +
        '       Convert.ToString(pl3_points) + " + " +
        '       Convert.ToString(pl4_points) + " + " +
        '       Convert.ToString(pl5_points) + " + " +
        '       Convert.ToString(pl6_points) + " + " +
        '       Convert.ToString(pl7_points) + " + " +
        '       Convert.ToString(pl8_points))
        tmrThink.Stop()
        tmrPoints.Stop()
    End Sub

    Private Sub tmrPoints_Tick(sender As Object, e As EventArgs) Handles tmrPoints.Tick
        fff_points += 1
        lblPoints.Text = fff_points
    End Sub

    Dim i As Integer = 0

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        If i = 0 Then
            HostScreen.pnlAnswer.BackColor = Color.LightGray
            If ControlPanel.lblAnswer.Text = "A" Then
                HostScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill
                GuestScreen.pnlA.BackgroundImage = My.Resources.Correct_Answer_Fill
                ControlPanel.txtA.BackColor = Color.Green
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                HostScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill
                GuestScreen.pnlB.BackgroundImage = My.Resources.Correct_Answer_Fill
                ControlPanel.txtB.BackColor = Color.Green
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                HostScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill
                GuestScreen.pnlC.BackgroundImage = My.Resources.Correct_Answer_Fill
                ControlPanel.txtC.BackColor = Color.Green
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                HostScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill
                GuestScreen.pnlD.BackgroundImage = My.Resources.Correct_Answer_Fill
                ControlPanel.txtD.BackColor = Color.Green
            End If
            If settingsVar.level = -1 Then
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(32, False, 1000)
                End With
            End If
            i = i + 1
            TVControlPnl.tmrFlash.Start()
        Else
            TVControlPnl.txtA.BackColor = Color.Transparent
            TVControlPnl.txtB.BackColor = Color.Transparent
            TVControlPnl.txtC.BackColor = Color.Transparent
            TVControlPnl.txtD.BackColor = Color.Transparent
            TVControlPnl.txtA.ForeColor = Color.White
            TVControlPnl.txtB.ForeColor = Color.White
            TVControlPnl.txtC.ForeColor = Color.White
            TVControlPnl.txtD.ForeColor = Color.White
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill
            TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill
            TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill
            TVControlPnl.pnlQuestion.Visible = False
            TVControlPnl.pnlStrap.Visible = False
            TVControlPnl.tmrFlash.Stop()
        End If
    End Sub

    Dim a As Integer = 0
    Private Sub btnShowCorrectPlayers_Click(sender As Object, e As EventArgs) Handles btnShowCorrectPlayers.Click
        If a = 0 Then
            TVControlPnl.txtPL1_Name.Text = txtPL1_Name.Text
            TVControlPnl.txtPL1_Name.BackColor = Color.Black
            TVControlPnl.txtPL1_Points.BackColor = Color.Black
            TVControlPnl.txtPL1_Points.Clear()
            TVControlPnl.txtPL2_Name.Text = txtPL2_Name.Text
            TVControlPnl.txtPL2_Name.BackColor = Color.Black
            TVControlPnl.txtPL2_Points.BackColor = Color.Black
            TVControlPnl.txtPL2_Points.Clear()
            TVControlPnl.txtPL3_Name.Text = txtPL3_Name.Text
            TVControlPnl.txtPL3_Name.BackColor = Color.Black
            TVControlPnl.txtPL3_Points.BackColor = Color.Black
            TVControlPnl.txtPL3_Points.Clear()
            TVControlPnl.txtPL4_Name.Text = txtPL4_Name.Text
            TVControlPnl.txtPL4_Name.BackColor = Color.Black
            TVControlPnl.txtPL4_Points.BackColor = Color.Black
            TVControlPnl.txtPL4_Points.Clear()
            TVControlPnl.txtPL5_Name.Text = txtPL5_Name.Text
            TVControlPnl.txtPL5_Name.BackColor = Color.Black
            TVControlPnl.txtPL5_Points.BackColor = Color.Black
            TVControlPnl.txtPL5_Points.Clear()
            TVControlPnl.txtPL6_Name.Text = txtPL6_Name.Text
            TVControlPnl.txtPL6_Name.BackColor = Color.Black
            TVControlPnl.txtPL6_Points.BackColor = Color.Black
            TVControlPnl.txtPL6_Points.Clear()
            TVControlPnl.txtPL7_Name.Text = txtPL7_Name.Text
            TVControlPnl.txtPL7_Name.BackColor = Color.Black
            TVControlPnl.txtPL7_Points.BackColor = Color.Black
            TVControlPnl.txtPL7_Points.Clear()
            TVControlPnl.txtPL8_Name.Text = txtPL8_Name.Text
            TVControlPnl.txtPL8_Name.BackColor = Color.Black
            TVControlPnl.txtPL8_Points.BackColor = Color.Black
            TVControlPnl.txtPL1_Points.Clear()
            TVControlPnl.pnlFFFPlayers.Visible = True

            a = a + 1
        ElseIf a = 1 Then
            tmrRevealPlayers.Start()
            If settingsVar.level = -1 Then
                ControlPanel.intSound += 1

                With snd
                    .Name = "SOUND" & ControlPanel.intSound
                    .Play(35, False, 1000)
                End With
            End If
            a = a + 1
        ElseIf a = 2 Then
            tmrFastestPlayer.Start()
            ControlPanel.intSound += 1

            With snd
                .Name = "SOUND" & ControlPanel.intSound
                .Play(31, False, 1000)
            End With
            a = a + 1
        ElseIf a = 3 Then
            tmrFastestPlayer.Stop()
            TVControlPnl.pnlFFFPlayers.Visible = False
        End If
    End Sub

    Dim act As Integer

    Private Sub tmrRevealPlayers_Tick(sender As Object, e As EventArgs) Handles tmrRevealPlayers.Tick

        Select Case act
            Case 0
                If txtPL1_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL1_Name.BackColor = Color.Green
                    TVControlPnl.txtPL1_Points.BackColor = Color.Green
                    TVControlPnl.txtPL1_Points.Text = txtPL1_Points.Text
                End If
            Case 1
                If txtPL2_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL2_Name.BackColor = Color.Green
                    TVControlPnl.txtPL2_Points.BackColor = Color.Green
                    TVControlPnl.txtPL2_Points.Text = txtPL2_Points.Text
                End If
            Case 2
                If txtPL3_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL3_Name.BackColor = Color.Green
                    TVControlPnl.txtPL3_Points.BackColor = Color.Green
                    TVControlPnl.txtPL3_Points.Text = txtPL3_Points.Text
                End If
            Case 3
                If txtPL4_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL4_Name.BackColor = Color.Green
                    TVControlPnl.txtPL4_Points.BackColor = Color.Green
                    TVControlPnl.txtPL4_Points.Text = txtPL4_Points.Text
                End If
            Case 4
                If txtPL5_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL5_Name.BackColor = Color.Green
                    TVControlPnl.txtPL5_Points.BackColor = Color.Green
                    TVControlPnl.txtPL5_Points.Text = txtPL5_Points.Text
                End If
            Case 5
                If txtPL6_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL6_Name.BackColor = Color.Green
                    TVControlPnl.txtPL6_Points.BackColor = Color.Green
                    TVControlPnl.txtPL6_Points.Text = txtPL6_Points.Text
                End If
            Case 6
                If txtPL7_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL7_Name.BackColor = Color.Green
                    TVControlPnl.txtPL7_Points.BackColor = Color.Green
                    TVControlPnl.txtPL7_Points.Text = txtPL7_Points.Text
                End If
            Case 7
                If txtPL8_Answer.Text = ControlPanel.lblAnswer.Text Then
                    TVControlPnl.txtPL8_Name.BackColor = Color.Green
                    TVControlPnl.txtPL8_Points.BackColor = Color.Green
                    TVControlPnl.txtPL8_Points.Text = txtPL8_Points.Text
                End If
            Case 8
                tmrRevealPlayers.Stop()

        End Select
        act = act + 1
    End Sub

    Dim flash As Integer = 0

    Private Sub tmrFastestPlayer_Tick(sender As Object, e As EventArgs) Handles tmrFastestPlayer.Tick
        Select Case flash
            Case 0
                If pl1_points = fff_pointsmin And TVControlPnl.txtPL1_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL1_Name.BackColor = Color.Black
                    TVControlPnl.txtPL1_Points.BackColor = Color.Black
                ElseIf pl2_points = fff_pointsmin And TVControlPnl.txtPL2_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL2_Name.BackColor = Color.Black
                    TVControlPnl.txtPL2_Points.BackColor = Color.Black
                ElseIf pl3_points = fff_pointsmin And TVControlPnl.txtPL3_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL3_Name.BackColor = Color.Black
                    TVControlPnl.txtPL3_Points.BackColor = Color.Black
                ElseIf pl4_points = fff_pointsmin And TVControlPnl.txtPL4_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL4_Name.BackColor = Color.Black
                    TVControlPnl.txtPL4_Points.BackColor = Color.Black
                ElseIf pl5_points = fff_pointsmin And TVControlPnl.txtPL5_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL5_Name.BackColor = Color.Black
                    TVControlPnl.txtPL5_Points.BackColor = Color.Black
                ElseIf pl6_points = fff_pointsmin And TVControlPnl.txtPL6_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL6_Name.BackColor = Color.Black
                    TVControlPnl.txtPL6_Points.BackColor = Color.Black
                ElseIf pl7_points = fff_pointsmin And TVControlPnl.txtPL7_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL7_Name.BackColor = Color.Black
                    TVControlPnl.txtPL7_Points.BackColor = Color.Black
                ElseIf pl8_points = fff_pointsmin And TVControlPnl.txtPL8_Name.BackColor = Color.Green Then
                    TVControlPnl.txtPL8_Name.BackColor = Color.Black
                    TVControlPnl.txtPL8_Points.BackColor = Color.Black
                End If
                flash = 1
            Case 1
                If pl1_points = fff_pointsmin Then
                    TVControlPnl.txtPL1_Name.BackColor = Color.Green
                    TVControlPnl.txtPL1_Points.BackColor = Color.Green
                ElseIf pl2_points = fff_pointsmin Then
                    TVControlPnl.txtPL2_Name.BackColor = Color.Green
                    TVControlPnl.txtPL2_Points.BackColor = Color.Green
                ElseIf pl3_points = fff_pointsmin Then
                    TVControlPnl.txtPL3_Name.BackColor = Color.Green
                    TVControlPnl.txtPL3_Points.BackColor = Color.Green
                ElseIf pl4_points = fff_pointsmin Then
                    TVControlPnl.txtPL4_Name.BackColor = Color.Green
                    TVControlPnl.txtPL4_Points.BackColor = Color.Green
                ElseIf pl5_points = fff_pointsmin Then
                    TVControlPnl.txtPL5_Name.BackColor = Color.Green
                    TVControlPnl.txtPL5_Points.BackColor = Color.Green
                ElseIf pl6_points = fff_pointsmin Then
                    TVControlPnl.txtPL6_Name.BackColor = Color.Green
                    TVControlPnl.txtPL6_Points.BackColor = Color.Green
                ElseIf pl7_points = fff_pointsmin Then
                    TVControlPnl.txtPL7_Name.BackColor = Color.Green
                    TVControlPnl.txtPL7_Points.BackColor = Color.Green
                ElseIf pl8_points = fff_pointsmin Then
                    TVControlPnl.txtPL8_Name.BackColor = Color.Green
                    TVControlPnl.txtPL8_Points.BackColor = Color.Green
                End If
                flash = 0
        End Select

    End Sub
End Class
