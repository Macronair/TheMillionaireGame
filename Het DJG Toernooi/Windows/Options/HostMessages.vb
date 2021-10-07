Imports System.Data.SqlClient

Public Class HostMessages

    Private Sub HostMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update()
    End Sub

    Private Overloads Sub Update()
        Data.connectionString.Open()
        Dim com As String = "SELECT * FROM settings_HostMessages"
        Dim Adpt As New SqlDataAdapter(com, Data.connectionString)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "Messages")
        dtMessages.DataSource = ds.Tables(0)
        dtMessages.Columns("Id").Visible = False
        dtMessages.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Data.connectionString.Close()
    End Sub

    Private Sub btnDeleteMessage_Click(sender As Object, e As EventArgs) Handles btnDeleteMessage.Click
        Data.connectionString.Open()
        Dim com As String = "DELETE FROM settings_HostMessages WHERE Id = @Id"
        Dim cmd As SqlCommand = New SqlCommand(com, Data.connectionString)
        cmd.Parameters.AddWithValue("@Id", dtMessages.CurrentRow.Cells(0).Value)
        cmd.ExecuteNonQuery()
        Data.connectionString.Close()
        Update()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Data.connectionString.Open()
        Dim com As String = "INSERT INTO settings_HostMessages (Message) VALUES (@Message)"
        Dim cmd As SqlCommand = New SqlCommand(com, Data.connectionString)
        cmd.Parameters.AddWithValue("@Message", txtNewMessage.Text)
        cmd.ExecuteNonQuery()
        Data.connectionString.Close()
        Update()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub HostMessages_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ControlPanel.drpNextHostMessage.Items.Clear()
        ControlPanel.drpNextHostMessage.Items.AddRange(ControlPanel.GetHostMessages().ToArray())
    End Sub
End Class