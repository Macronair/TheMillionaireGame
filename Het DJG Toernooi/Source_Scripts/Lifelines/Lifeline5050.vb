Public Class Lifeline5050

    Public Sub LifelineUse1()

        ControlPanel.txtA.BackColor = Color.Red
        ControlPanel.txtB.BackColor = Color.Red
        ControlPanel.txtC.BackColor = Color.Red
        ControlPanel.txtD.BackColor = Color.Red
        HostScreen.txtA.Text = ""
        HostScreen.txtB.Text = ""
        HostScreen.txtC.Text = ""
        HostScreen.txtD.Text = ""
        GuestScreen.txtA.Text = ""
        GuestScreen.txtB.Text = ""
        GuestScreen.txtC.Text = ""
        GuestScreen.txtD.Text = ""
        TVControlPnl.txtA.Text = ""
        TVControlPnl.txtB.Text = ""
        TVControlPnl.txtC.Text = ""
        TVControlPnl.txtD.Text = ""
        HostScreen.lbl5050Used.ForeColor = Color.Cyan

        TVControlPnl.pic50.Image = My.Resources.ll_5050_used
        HostScreen.pic50.Image = My.Resources.ll_5050_used
        GuestScreen.pic50.Image = My.Resources.ll_5050_used
        ControlPanel.btn5050.Enabled = False
        ControlPanel.chk5050.Checked = False

        If ControlPanel.lblAnswer.Text = "A" Then
            Dim rnd As New Random
            Dim rndint As Integer
            ControlPanel.txtA.BackColor = SystemColors.Control
            HostScreen.txtA.Text = "A: " + ControlPanel.txtA.Text
            TVControlPnl.txtA.Text = "A: " + ControlPanel.txtA.Text
            GuestScreen.txtA.Text = "A: " + ControlPanel.txtA.Text
            rndint = rnd.Next(0, 2)
            If rndint = 0 Then
                ControlPanel.txtB.BackColor = SystemColors.Control
                TVControlPnl.txtB.Text = "B: " + ControlPanel.txtB.Text
                HostScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
                GuestScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
            End If
            If rndint = 1 Then
                ControlPanel.txtC.BackColor = SystemColors.Control
                TVControlPnl.txtC.Text = "C: " + ControlPanel.txtC.Text
                HostScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
                GuestScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
            End If
            If rndint = 2 Then
                ControlPanel.txtD.BackColor = SystemColors.Control
                TVControlPnl.txtD.Text = "D: " + ControlPanel.txtD.Text
                HostScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
                GuestScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
            End If
        End If
        If ControlPanel.lblAnswer.Text = "B" Then
            Dim rnd As New Random
            Dim rndint As Integer
            ControlPanel.txtB.BackColor = SystemColors.Control
            HostScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
            TVControlPnl.txtB.Text = "B: " + ControlPanel.txtB.Text
            GuestScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
            rndint = rnd.Next(0, 2)
            If rndint = 0 Then
                ControlPanel.txtA.BackColor = SystemColors.Control
                TVControlPnl.txtA.Text = "A: " + ControlPanel.txtA.Text
                HostScreen.txtA.Text = "A: " + ControlPanel.txtA.Text
                GuestScreen.txtA.Text = "A: " + ControlPanel.txtA.Text
            End If
            If rndint = 1 Then
                ControlPanel.txtC.BackColor = SystemColors.Control
                TVControlPnl.txtC.Text = "C: " + ControlPanel.txtC.Text
                HostScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
                GuestScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
            End If
            If rndint = 2 Then
                ControlPanel.txtD.BackColor = SystemColors.Control
                TVControlPnl.txtD.Text = "D: " + ControlPanel.txtD.Text
                HostScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
                GuestScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
            End If
        End If
        If ControlPanel.lblAnswer.Text = "C" Then
            Dim rnd As New Random
            Dim rndint As Integer
            ControlPanel.txtC.BackColor = SystemColors.Control
            HostScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
            TVControlPnl.txtC.Text = "C: " + ControlPanel.txtC.Text
            GuestScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
            rndint = rnd.Next(0, 2)
            If rndint = 0 Then
                ControlPanel.txtA.BackColor = SystemColors.Control
                TVControlPnl.txtA.Text = "A: " + ControlPanel.txtA.Text
                HostScreen.txtA.Text = "A: " + ControlPanel.txtA.Text
                GuestScreen.txtA.Text = "A: " + ControlPanel.txtA.Text
            End If
            If rndint = 1 Then
                ControlPanel.txtB.BackColor = SystemColors.Control
                TVControlPnl.txtB.Text = "B: " + ControlPanel.txtB.Text
                HostScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
                GuestScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
            End If
            If rndint = 2 Then
                ControlPanel.txtD.BackColor = SystemColors.Control
                TVControlPnl.txtD.Text = "D: " + ControlPanel.txtD.Text
                HostScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
                GuestScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
            End If
        End If
        If ControlPanel.lblAnswer.Text = "D" Then
            Dim rnd As New Random
            Dim rndint As Integer
            ControlPanel.txtD.BackColor = SystemColors.Control
            HostScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
            TVControlPnl.txtD.Text = "D: " + ControlPanel.txtD.Text
            GuestScreen.txtD.Text = "D: " + ControlPanel.txtD.Text
            rndint = rnd.Next(0, 2)
            If rndint = 0 Then
                ControlPanel.txtB.BackColor = SystemColors.Control
                TVControlPnl.txtB.Text = "B: " + ControlPanel.txtB.Text
                HostScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
                GuestScreen.txtB.Text = "B: " + ControlPanel.txtB.Text
            End If
            If rndint = 1 Then
                ControlPanel.txtC.BackColor = SystemColors.Control
                TVControlPnl.txtC.Text = "C: " + ControlPanel.txtC.Text
                HostScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
                GuestScreen.txtC.Text = "C: " + ControlPanel.txtC.Text
            End If
            If rndint = 2 Then
                ControlPanel.txtA.BackColor = SystemColors.Control
                TVControlPnl.txtA.Text = "D: " + ControlPanel.txtA.Text
                HostScreen.txtA.Text = "D: " + ControlPanel.txtA.Text
                GuestScreen.txtA.Text = "D: " + ControlPanel.txtA.Text
            End If
        End If

        If ControlPanel.txtA.BackColor = Color.Red Then
            ControlPanel.txtA.Text = ""
            ControlPanel.txtA.BackColor = SystemColors.Control
        End If
        If ControlPanel.txtB.BackColor = Color.Red Then
            ControlPanel.txtB.Text = ""
            ControlPanel.txtB.BackColor = SystemColors.Control
        End If
        If ControlPanel.txtC.BackColor = Color.Red Then
            ControlPanel.txtC.Text = ""
            ControlPanel.txtC.BackColor = SystemColors.Control
        End If
        If ControlPanel.txtD.BackColor = Color.Red Then
            ControlPanel.txtD.Text = ""
            ControlPanel.txtD.BackColor = SystemColors.Control
        End If

        With Sounds.sndLifeline1
            .URL = Sounds.SoundsPath + Profile.Options.snd_5050
            .controls.play()
        End With
    End Sub
End Class
