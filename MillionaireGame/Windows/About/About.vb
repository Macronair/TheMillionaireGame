Public Class About
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = Application.ProductVersion
    End Sub
End Class