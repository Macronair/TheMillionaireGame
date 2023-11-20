Public Class MonitorIdentifier
    Private Sub tmrToCloseForm_Tick(sender As Object, e As EventArgs) Handles tmrToCloseForm.Tick
        Me.Close()
    End Sub

    Private Sub MonitorIdentifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrToCloseForm.Start()
    End Sub
End Class