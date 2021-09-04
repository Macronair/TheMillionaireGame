Imports System.Net
Imports System.IO
Imports System.Net.Sockets

'Client Side
Public Class frmMain

    Dim client As TcpClient
    Dim sWriter As StreamWriter
    Dim NIckFrefix As Integer = 1
    Sub xLoad() Handles Me.Load
        Me.Text &= " " & NIckFrefix
    End Sub
    Delegate Sub _xUpdate(ByVal str As String)
    Sub xUpdate(ByVal str As String)
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            txtReceive.Text = str
        End If
    End Sub

    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(client.GetStream).ReadLine)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)
        Catch ex As Exception
            xUpdate("You are disconnected from the server.")
            Exit Sub
        End Try
    End Sub

    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("You're not server")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Button1.Text
            Case "Connect"
                Try
                    client = New TcpClient(TextBox1.Text, 3818)
                    client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
                    Button1.Text = "Disconnect"
                    grpSlot.Enabled = False
                Catch ex As Exception
                    xUpdate("Can't connect to the server!")
                End Try
            Case "Disconnect"
                client.Client.Close()
                client = Nothing
                Button1.Text = "Connect"
                grpSlot.Enabled = True
        End Select
    End Sub
    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            send(NIckFrefix & " - " & TextBox4.Text)
            TextBox4.Clear()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        send(NIckFrefix & " - " & TextBox4.Text)
        TextBox4.Clear()
    End Sub

    Dim splits As String()
    Dim question As String
    Dim ansA As String
    Dim ansB As String
    Dim ansC As String
    Dim ansD As String

    Private Sub txtReceive_TextChanged(sender As Object, e As EventArgs) Handles txtReceive.TextChanged
        Dim cmd As String
        cmd = txtReceive.Text

        If cmd = "/unlock" Then
            grpAnswers.Enabled = True
            btnA.Text = "A"
            btnB.Text = "B"
            btnC.Text = "C"
            btnD.Text = "D"
        ElseIf cmd = "/lock" Then
            grpAnswers.Enabled = False
        ElseIf cmd = "/clear" Then
            btnA.Text = "A"
            btnB.Text = "B"
            btnC.Text = "C"
            btnD.Text = "D"
            txtAnswer.Text = ""
        ElseIf cmd.Contains("/q1#") Then
            Dim question() As String = cmd.Split("#")
            txtQuestion.Text = question(1)
        ElseIf cmd.Contains("/q2#") Then
            Dim question() As String = cmd.Split("#")
            btnA.Text = "A: " + question(1)
            btnB.Text = "B: " + question(2)
            btnC.Text = "C: " + question(3)
            btnD.Text = "D: " + question(4)
        End If
    End Sub

    Private Sub btnFinal_Click(sender As Object, e As EventArgs) Handles btnFinal.Click
        send(Convert.ToString(nmrSlot.Value) + "-" + txtAnswer.Text)
        txtAnswer.AppendText(" - OK")
        grpAnswers.Enabled = False
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If txtAnswer.TextLength < 4 Then
            txtAnswer.AppendText("A")
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If txtAnswer.TextLength < 4 Then
            txtAnswer.AppendText("B")
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If txtAnswer.TextLength < 4 Then
            txtAnswer.AppendText("C")
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        If txtAnswer.TextLength < 4 Then
            txtAnswer.AppendText("D")
        End If
    End Sub

    Private Sub btnA_MouseEnter(sender As Object, e As EventArgs) Handles btnA.MouseEnter
        btnA.BackgroundImage = My.Resources.Final_Answer_Fill
    End Sub

    Private Sub btnB_MouseEnter(sender As Object, e As EventArgs) Handles btnB.MouseEnter
        btnB.BackgroundImage = My.Resources.Final_Answer_Fill
    End Sub

    Private Sub btnC_MouseEnter(sender As Object, e As EventArgs) Handles btnC.MouseEnter
        btnC.BackgroundImage = My.Resources.Final_Answer_Fill
    End Sub

    Private Sub btnD_MouseEnter(sender As Object, e As EventArgs) Handles btnD.MouseEnter
        btnD.BackgroundImage = My.Resources.Final_Answer_Fill
    End Sub

    Private Sub btnA_MouseLeave(sender As Object, e As EventArgs) Handles btnA.MouseLeave
        btnA.BackgroundImage = My.Resources.Normal_Answer_Fill
    End Sub

    Private Sub btnB_MouseLeave(sender As Object, e As EventArgs) Handles btnB.MouseLeave
        btnB.BackgroundImage = My.Resources.Normal_Answer_Fill
    End Sub

    Private Sub btnC_MouseLeave(sender As Object, e As EventArgs) Handles btnC.MouseLeave
        btnC.BackgroundImage = My.Resources.Normal_Answer_Fill
    End Sub

    Private Sub btnD_MouseLeave(sender As Object, e As EventArgs) Handles btnD.MouseLeave
        btnD.BackgroundImage = My.Resources.Normal_Answer_Fill
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnswer.Clear()
    End Sub
End Class
