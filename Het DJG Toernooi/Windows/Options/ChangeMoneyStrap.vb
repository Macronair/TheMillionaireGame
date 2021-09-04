Public Class ChangeMoneyStrap
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If chkGold.Checked = True Then
            TVControlPnl.pnlStrap.BackgroundImage = My.Resources.winning_strap_1
            TVControlPnl.lblAmount.ForeColor = Color.Black
        ElseIf chkGreen.Checked = True Then
            TVControlPnl.pnlStrap.BackgroundImage = My.Resources.winning_strap_2
            TVControlPnl.lblAmount.ForeColor = Color.Black
        ElseIf chkDark.Checked = True Then
            TVControlPnl.pnlStrap.BackgroundImage = My.Resources.winning_strap_3
            TVControlPnl.lblAmount.ForeColor = Color.White
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class