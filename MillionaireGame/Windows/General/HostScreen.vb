Public Class HostScreen
    Private Sub lblHostMsg_TextChanged(sender As Object, e As EventArgs) Handles lblHostMsg.TextChanged
        Dim l As Integer = lblHostMsg.Text.Length
        lblHostMsg.SelectionStart = l
        lblHostMsg.ScrollToCaret()

        Dim n As Integer = ControlPanel.txtHostMessages.Text.Length
        ControlPanel.txtHostMessages.SelectionStart = n
        ControlPanel.txtHostMessages.ScrollToCaret()
    End Sub
End Class