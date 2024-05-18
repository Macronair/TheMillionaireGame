Public Class Hotkey
    Public Shared Sub Press(ByVal key As Keys, ByVal ctrl As Boolean, ByVal alt As Boolean)
        Select Case key
            Case Keys.F5
                ControlPanel.btnNewQuestion.PerformClick()
            Case Keys.F1
                ControlPanel.btnA.PerformClick()
            Case Keys.F2
                ControlPanel.btnB.PerformClick()
            Case Keys.F3
                ControlPanel.btnC.PerformClick()
            Case Keys.F4
                ControlPanel.btnD.PerformClick()
            Case Keys.F7
                ControlPanel.btnLightsDown.PerformClick()
            Case Keys.D1
                If ctrl = True And ControlPanel.btnLL1.Enabled = True Then
                    ControlPanel.btnLL1.PerformClick()
                ElseIf ControlPanel.btnLL1.Enabled = True Then
                    ControlPanel.btnLifeline1.PerformClick()
                End If
            Case Keys.D2
                If ctrl = True And ControlPanel.btnLL2.Enabled = True Then
                    ControlPanel.btnLL2.PerformClick()
                ElseIf ControlPanel.btnLL2.Enabled = True Then
                    ControlPanel.btnLifeline2.PerformClick()
                End If
            Case Keys.D3
                If ctrl = True And ControlPanel.btnLL3.Enabled = True Then
                    ControlPanel.btnLL3.PerformClick()
                ElseIf ControlPanel.btnLL3.Enabled = True Then
                    ControlPanel.btnLifeline3.PerformClick()
                End If
            Case Keys.D4
                If ctrl = True And ControlPanel.btnLL4.Enabled = True Then
                    ControlPanel.btnLL4.PerformClick()
                ElseIf ControlPanel.btnLL4.Enabled = True Then
                    ControlPanel.btnLifeline4.PerformClick()
                End If
            Case Keys.End
                ControlPanel.btnWalk.PerformClick()
            Case Keys.Back
                ControlPanel.btnUndo.PerformClick()
            Case Keys.F6
                ControlPanel.btnReveal.PerformClick()
            Case Keys.Insert
                ControlPanel.btnToHotSeat.PerformClick()
            Case Keys.Delete
                ControlPanel.btnResetGame.PerformClick()
            Case Keys.R
                ControlPanel.btnUnlockSwitch.PerformClick()
            Case Keys.Home
                If TVControlPnl.picTree.Visible = True Then
                    ControlPanel.btnHideTree.PerformClick()
                ElseIf TVControlPnl.picTree.Visible = False Then
                    ControlPanel.btnShowTree.PerformClick()
                End If
            Case Keys.Tab
                If ControlPanel.chkShowQuestion.Checked = True Then
                    ControlPanel.chkShowQuestion.Checked = False
                ElseIf ControlPanel.chkShowQuestion.Checked = False Then
                    ControlPanel.chkShowQuestion.Checked = True
                End If
            Case Keys.PageUp
                If Game.level < 15 Then
                    ControlPanel.nmrLevel.Value += 1
                End If
            Case Keys.PageDown
                If Game.level > 1 Then
                    ControlPanel.nmrLevel.Value -= 1
                End If
        End Select
    End Sub
End Class
