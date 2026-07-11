Imports Microsoft.AspNetCore.SignalR.Client

Public Class NetHub
    ' This class will be used to handle all the network communication for the game.
    ' It will be responsible for sending and receiving data from the server, as well as managing the connection.
    ' The NetHub will use a TCP client to connect to the server and will have methods for sending and receiving data.
    ' The NetHub will also have events that can be subscribed to in order to receive updates on the connection status and incoming data.

    Private Shared fff_connection As HubConnection
    Private Shared ata_connection As HubConnection

    Public Shared Sub BuildConnection()
        'fff_connection = New HubConnectionBuilder().
        'WithUrl("http://localhost:5000/fastestfingerhub").
        'WithAutomaticReconnect().
        'Build()

        ata_connection = New HubConnectionBuilder().
        WithUrl("http://localhost:5000/audiencehub").
        WithAutomaticReconnect().
        Build()
    End Sub

#Region "Ask The Audience"
    Public Shared Async Function ATA_Connect() As Task
        ATA_Register_VoteUpdate()
        Try
            Await ata_connection.StartAsync()
            CoreConsole.LogMsgDate("[INFO] ATA hub connection succesful (ID: " & ata_connection.ConnectionId & ")")
        Catch ex As Exception
            CoreConsole.LogMsgDate("[INFO] ATA hub connection failed. Reason: " & ex.Message)
        End Try
    End Function

    Private Shared Sub ATA_Register_VoteUpdate()
        ata_connection.On(Of Dictionary(Of String, Integer))(
        "VoteUpdated",
        Sub(votes)

            Game.CurrentVotes = votes

        End Sub)
    End Sub

    Public Shared Async Sub ATA_SendData()
        ATA_ResetVotes()

        Await ata_connection.InvokeAsync(
            "SendQuestion",
            1,
            ControlPanel.txtQuestion.Text,
            New List(Of String) From {
                ControlPanel.txtA.Text,
                ControlPanel.txtB.Text,
                ControlPanel.txtC.Text,
                ControlPanel.txtD.Text
            }
        )
    End Sub

    Public Shared Async Sub ATA_SendDataQuestionOnly()
        Await ata_connection.InvokeAsync(
            "SendQuestionOnly",
            1,
            ControlPanel.txtQuestion.Text
        )
    End Sub

    Public Shared Async Sub ATA_SendDataAnswersOnly()
        Await ata_connection.InvokeAsync(
            "ShowAnswers",
            New List(Of String) From {
                ControlPanel.txtA.Text,
                ControlPanel.txtB.Text,
                ControlPanel.txtC.Text,
                ControlPanel.txtD.Text
            }
        )
    End Sub

    Public Shared Sub ATA_UpdateVotes()
        Dim total = Game.CurrentVotes.Values.Sum()

        If total > 0 Then
            ControlPanel.lblATANET_A.Text = "A: " & ((Game.CurrentVotes("A") / total * 100).ToString("0") & "%")
            ControlPanel.lblATANET_B.Text = "B: " & ((Game.CurrentVotes("B") / total * 100).ToString("0") & "%")
            ControlPanel.lblATANET_C.Text = "C: " & ((Game.CurrentVotes("C") / total * 100).ToString("0") & "%")
            ControlPanel.lblATANET_D.Text = "D: " & ((Game.CurrentVotes("D") / total * 100).ToString("0") & "%")
        Else
            ControlPanel.lblATANET_A.Text = "A: 0%"
            ControlPanel.lblATANET_B.Text = "B: 0%"
            ControlPanel.lblATANET_C.Text = "C: 0%"
            ControlPanel.lblATANET_D.Text = "D: 0%"
        End If
    End Sub

    Public Shared Async Sub ATA_CloseVoting()
        Await ata_connection.InvokeAsync("CloseVoting")
    End Sub

    Public Shared Async Sub ATA_ResetVotes()
        Game.CurrentVotes = New Dictionary(Of String, Integer) From {
                {"A", 0},
                {"B", 0},
                {"C", 0},
                {"D", 0}
            }
        Await ata_connection.InvokeAsync("ResetVotes")
        ATA_UpdateVotes()
    End Sub
#End Region

#Region "Fastest Finger First"
    Public Sub ConnectToFFF()
        fff_connection.StartAsync()
    End Sub
#End Region

End Class
