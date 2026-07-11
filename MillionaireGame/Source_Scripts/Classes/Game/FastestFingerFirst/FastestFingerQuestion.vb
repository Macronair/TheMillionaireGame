Public Class FastestFingerQuestion
    ' Nothing here yet

    Public Shared Sub FillAnswers()
        Dim answer As String
        Try
            answer = FastestFingerServer.correctOrder
        Catch ex As Exception
            answer = ControlPanel.lblAnswer.Text
            CoreConsole.LogMsgDate("[FFF] Cannot get correct order from main source. Using secondary.")
        End Try

        Dim order1 As String
        Dim order2 As String
        Dim order3 As String
        Dim order4 As String

        Select Case answer.Chars(0)
            Case "A"
                order1 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order1 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order1 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order1 = "D: " + ControlPanel.txtD.Text
        End Select

        Select Case answer.Chars(1)
            Case "A"
                order2 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order2 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order2 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order2 = "D: " + ControlPanel.txtD.Text
        End Select

        Select Case answer.Chars(2)
            Case "A"
                order3 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order3 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order3 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order3 = "D: " + ControlPanel.txtD.Text
        End Select

        Select Case answer.Chars(3)
            Case "A"
                order4 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order4 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order4 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order4 = "D: " + ControlPanel.txtD.Text
        End Select

        TVControlPnl.lblFFFQuestion.Text = ControlPanel.txtQuestion.Text
        TVControlPnl.txtFFFOrder1.Text = order1
        TVControlPnl.txtFFFOrder2.Text = order2
        TVControlPnl.txtFFFOrder3.Text = order3
        TVControlPnl.txtFFFOrder4.Text = order4
    End Sub
End Class
