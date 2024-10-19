Public Class SQLLogin
    Private Sub SQLLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQLSettings.SQLInfo.UseRemoteServer = False Then
            radSQLLocal.Checked = True
            radSQLRemote.Checked = False
        ElseIf SQLSettings.SQLInfo.UseRemoteServer = True Then
            radSQLLocal.Checked = False
            radSQLRemote.Checked = True
        End If

        txtSQLR_ServerInstance.Text = SQLSettings.SQLInfo.rSQL_Server
        txtSQLR_Port.Value = SQLSettings.SQLInfo.rSQL_Port
        txtSQLR_Database.Text = SQLSettings.SQLInfo.rSQL_Database
        txtSQLR_Username.Text = SQLSettings.SQLInfo.rSQL_Login
        txtSQLR_Password.Text = SQLSettings.SQLInfo.rSQL_Password

        btnOK.DialogResult = DialogResult.OK
        btnCancel.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub radSQLRemote_CheckedChanged(sender As Object, e As EventArgs) Handles radSQLRemote.CheckedChanged
        If radSQLRemote.Checked = True Then
            grpSQLRemote.Enabled = True
        Else
            grpSQLRemote.Enabled = False
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Game.CurrentDatabase.SaveSettings()
        Game.CurrentDatabase.LoadSettings()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SQLLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub
End Class