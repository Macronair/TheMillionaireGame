Public Class Question

    Public Shared act As Integer
    Public Shared useMusic As Boolean = False

    Dim newQ As New QDatabase

    Public Sub Generate()
        ControlPanel.i = 0

        HostScreen.txtExplain.ForeColor = Color.Black
        ControlPanel.lblATA_A.Text = "A: 0"
        ControlPanel.lblATA_B.Text = "B: 0"
        ControlPanel.lblATA_C.Text = "C: 0"
        ControlPanel.lblATA_D.Text = "D: 0"
        TVControlPnl.lblATA_A.Text = "0%"
        TVControlPnl.lblATA_B.Text = "0%"
        TVControlPnl.lblATA_C.Text = "0%"
        TVControlPnl.lblATA_D.Text = "0%"
        HostScreen.txtATAa.Text = ""
        HostScreen.txtATAb.Text = ""
        HostScreen.txtATAc.Text = ""
        HostScreen.txtATAd.Text = ""
        GuestScreen.txtATAa.Text = ""
        GuestScreen.txtATAb.Text = ""
        GuestScreen.txtATAc.Text = ""
        GuestScreen.txtATAd.Text = ""
        PlayCue()
        If act = 5 Then
            HostScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
            GuestScreen.txtD.Text = "D: " & ControlPanel.txtD.Text
            TVControlPnl.txtD.Text = "D: " & ControlPanel.txtD.Text
            TVControlPnl.txtD.Visible = True
            act = 5
        End If
        If act = 4 Then
            HostScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
            GuestScreen.txtC.Text = "C: " & ControlPanel.txtC.Text
            TVControlPnl.txtC.Text = "C: " & ControlPanel.txtC.Text
            TVControlPnl.txtC.Visible = True
            act = 5
        End If
        If act = 3 Then
            HostScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
            GuestScreen.txtB.Text = "B: " & ControlPanel.txtB.Text
            TVControlPnl.txtB.Text = "B: " & ControlPanel.txtB.Text
            TVControlPnl.txtB.Visible = True
            act = 4
        End If
        If act = 2 Then
            HostScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
            GuestScreen.txtA.Text = "A: " & ControlPanel.txtA.Text
            TVControlPnl.txtA.Text = "A: " & ControlPanel.txtA.Text
            TVControlPnl.txtA.Visible = True
            act = 3
        End If
        If act = 1 Then
            TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.picTree.Visible = False
            TVControlPnl.pnlStrap.Visible = False
            HostScreen.pnlStrap.Visible = False
            GuestScreen.pnlStrap.Visible = False
            TVControlPnl.pnlQuestion.Visible = True
            act = 2
        End If
        If act = 0 Then
            newQ.newQuestion()
            HostScreen.pnlAnswer.BackColor = Color.Black
            HostScreen.lbl5050Used.ForeColor = Color.Black
            HostScreen.lblSwitchUsed.ForeColor = Color.Black
            HostScreen.lblPlusOneUsed.ForeColor = Color.Black
            HostScreen.lblVoteUsed.ForeColor = Color.Black
            ControlPanel.txtA.BackColor = Color.Silver
            ControlPanel.txtB.BackColor = Color.Silver
            ControlPanel.txtC.BackColor = Color.Silver
            ControlPanel.txtD.BackColor = Color.Silver
            HostScreen.txtA.ForeColor = Color.White
            HostScreen.txtB.ForeColor = Color.White
            HostScreen.txtC.ForeColor = Color.White
            HostScreen.txtD.ForeColor = Color.White
            HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.txtA.ForeColor = Color.White
            GuestScreen.txtB.ForeColor = Color.White
            GuestScreen.txtC.ForeColor = Color.White
            GuestScreen.txtD.ForeColor = Color.White
            GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
            GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
            TVControlPnl.txtA.ForeColor = Color.White
            TVControlPnl.txtB.ForeColor = Color.White
            TVControlPnl.txtC.ForeColor = Color.White
            TVControlPnl.txtD.ForeColor = Color.White
            HostScreen.txtATAa.ForeColor = Color.White
            HostScreen.txtATAb.ForeColor = Color.White
            HostScreen.txtATAc.ForeColor = Color.White
            HostScreen.txtATAd.ForeColor = Color.White
            GuestScreen.txtATAa.ForeColor = Color.White
            GuestScreen.txtATAb.ForeColor = Color.White
            GuestScreen.txtATAc.ForeColor = Color.White
            GuestScreen.txtATAd.ForeColor = Color.White
            HostScreen.txtATAa.Text = ""
            HostScreen.txtATAb.Text = ""
            HostScreen.txtATAc.Text = ""
            HostScreen.txtATAd.Text = ""
            GuestScreen.txtATAa.Text = ""
            GuestScreen.txtATAb.Text = ""
            GuestScreen.txtATAc.Text = ""
            GuestScreen.txtATAd.Text = ""
            TVControlPnl.txtA.Text = ""
            TVControlPnl.txtB.Text = ""
            TVControlPnl.txtC.Text = ""
            TVControlPnl.txtD.Text = ""
            HostScreen.txtA.Text = ""
            HostScreen.txtB.Text = ""
            HostScreen.txtC.Text = ""
            HostScreen.txtD.Text = ""
            GuestScreen.txtA.Text = ""
            GuestScreen.txtB.Text = ""
            GuestScreen.txtC.Text = ""
            GuestScreen.txtD.Text = ""
            TVControlPnl.txtA.Visible = False
            TVControlPnl.txtB.Visible = False
            TVControlPnl.txtC.Visible = False
            TVControlPnl.txtD.Visible = False
            HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
            TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
            GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
            HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
            HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text
            act = 1
        End If
    End Sub

    Public Sub PlayCue()
        If useMusic = False Then
            useMusic = True

            If ControlPanel.firstuse = True Or Game.level > 10 Then
                ControlPanel.Timer2.Start()
            End If

            If Game.level = 0 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 1 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 2 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 3 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 4 Then
                My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 5 Then
                My.Computer.Audio.Play(My.Resources.q6_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 6 Then
                My.Computer.Audio.Play(My.Resources.q7_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 7 Then
                My.Computer.Audio.Play(My.Resources.q8_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 8 Then
                My.Computer.Audio.Play(My.Resources.q9_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 9 Then
                My.Computer.Audio.Play(My.Resources.q10_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 10 Then
                My.Computer.Audio.Play(My.Resources.q11_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 11 Then
                My.Computer.Audio.Play(My.Resources.q12_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 12 Then
                My.Computer.Audio.Play(My.Resources.q13_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 13 Then
                My.Computer.Audio.Play(My.Resources.q14_bed, AudioPlayMode.BackgroundLoop)
            End If
            If Game.level = 14 Then
                My.Computer.Audio.Play(My.Resources.q15_bed, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub

    Public Sub UndoAnswer(ByVal music As Boolean)
        ControlPanel.HaltSound()
        If music = True Then
            PlayCue()
        End If
        'If useMusic = False Then
        '    useMusic = True
        '    If Game.level = 0 Then
        '        My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
        '    End If
        '    If Game.level = 1 Then
        '        My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
        '    End If
        '    If Game.level = 2 Then
        '        My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
        '    End If
        '    If Game.level = 3 Then
        '        My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
        '    End If
        '    If Game.level = 4 Then
        '        My.Computer.Audio.Play(My.Resources.q1_to_q5_bed, AudioPlayMode.BackgroundLoop)
        '    End If
        '    If Game.level = 5 Then
        '        My.Computer.Audio.Play(My.Resources.q6_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 6 Then
        '        My.Computer.Audio.Play(My.Resources.q7_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 7 Then
        '        My.Computer.Audio.Play(My.Resources.q8_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 8 Then
        '        My.Computer.Audio.Play(My.Resources.q9_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 9 Then
        '        My.Computer.Audio.Play(My.Resources.q10_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 10 Then
        '        My.Computer.Audio.Play(My.Resources.q11_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 11 Then
        '        My.Computer.Audio.Play(My.Resources.q12_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 12 Then
        '        My.Computer.Audio.Play(My.Resources.q13_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 13 Then
        '        My.Computer.Audio.Play(My.Resources.q14_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        '    If Game.level = 14 Then
        '        My.Computer.Audio.Play(My.Resources.q15_bed, AudioPlayMode.BackgroundLoop)
        '        ControlPanel.Timer2.Start()
        '    End If
        'End If

        ControlPanel.txtA.BackColor = Color.Silver
        ControlPanel.txtB.BackColor = Color.Silver
        ControlPanel.txtC.BackColor = Color.Silver
        ControlPanel.txtD.BackColor = Color.Silver

        HostScreen.txtExplain.BackColor = Color.Black
        HostScreen.pnlAnswer.BackColor = Color.Black
        HostScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        HostScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        HostScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        HostScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        HostScreen.txtA.ForeColor = Color.White
        HostScreen.txtB.ForeColor = Color.White
        HostScreen.txtC.ForeColor = Color.White
        HostScreen.txtD.ForeColor = Color.White

        GuestScreen.pnlA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        GuestScreen.pnlB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        GuestScreen.pnlC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        GuestScreen.pnlD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        GuestScreen.txtA.ForeColor = Color.White
        GuestScreen.txtB.ForeColor = Color.White
        GuestScreen.txtC.ForeColor = Color.White
        GuestScreen.txtD.ForeColor = Color.White

        TVControlPnl.picA.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        TVControlPnl.picB.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        TVControlPnl.picC.BackgroundImage = My.Resources.Normal_Answer_Fill_l
        TVControlPnl.picD.BackgroundImage = My.Resources.Normal_Answer_Fill_r
        TVControlPnl.txtA.ForeColor = Color.White
        TVControlPnl.txtB.ForeColor = Color.White
        TVControlPnl.txtC.ForeColor = Color.White
        TVControlPnl.txtD.ForeColor = Color.White

    End Sub

End Class
