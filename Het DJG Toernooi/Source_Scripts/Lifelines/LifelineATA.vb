Public Class LifelineATA
    Dim snd As New SOUND
    Dim act As Integer = 0
    Dim amountA As Integer
    Dim amountB As Integer
    Dim amountC As Integer
    Dim amountD As Integer
    Dim perA As String
    Dim perB As String
    Dim perC As String
    Dim perD As String
    Dim amountTotal As Integer


    Public Sub LifelineUse1()
        If act = 0 Then
            My.Computer.Audio.Play(My.Resources.ata_start, AudioPlayMode.Background)
            Question.useMusic = False
            HostScreen.lblVoteUsed.ForeColor = Color.Cyan
            act = 1
            blankSub()
        ElseIf act = 1 Then
            My.Computer.Audio.Play(My.Resources.ata_vote, AudioPlayMode.Background)
            act = 2
            TVControlPnl.tmrRandomizer.Start()
            TVControlPnl.grpATA.Visible = True
            Dim random As New Random()
            If Game.level < 5 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 50)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 50)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)
                    amountA = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 50)
                    amountD = random.Next(1, 10)
                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 50)
                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                End If
            ElseIf Game.level >= 5 And Game.level <= 9 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(40, 50)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(40, 50)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)
                    amountA = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(40, 50)
                    amountD = random.Next(5, 20)
                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(40, 50)
                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                End If
            ElseIf Game.level >= 10 Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    amountA = random.Next(30, 50)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "B" Then
                    amountB = random.Next(30, 50)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)
                    amountA = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "C" Then
                    amountC = random.Next(30, 50)
                    amountD = random.Next(20, 35)
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                ElseIf ControlPanel.lblAnswer.Text = "D" Then
                    amountD = random.Next(30, 50)
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                End If
            End If

            ControlPanel.lblATA_A.Text = amountA
            ControlPanel.lblATA_B.Text = amountB
            ControlPanel.lblATA_C.Text = amountC
            ControlPanel.lblATA_D.Text = amountD

            amountTotal = amountA + amountB + amountC + amountD
            perA = Fix((amountA / amountTotal * 100) + 0.5)
            perB = Fix((amountB / amountTotal * 100) + 0.5)
            perC = Fix((amountC / amountTotal * 100) + 0.5)
            perD = Fix((amountD / amountTotal * 100) + 0.5)

            blankSub()
        ElseIf act = 2 Then
            TVControlPnl.tmrRandomizer.Stop()
            My.Computer.Audio.Play(My.Resources.ata_end, AudioPlayMode.Background)
            TVControlPnl.lblATA_A.Text = "A: " + perA + "%"
            TVControlPnl.lblATA_B.Text = "B: " + perB + "%"
            TVControlPnl.lblATA_C.Text = "C: " + perC + "%"
            TVControlPnl.lblATA_D.Text = "D: " + perD + "%"
            HostScreen.txtATAa.Text = "A= " + perA + "%"
            HostScreen.txtATAb.Text = "B= " + perB + "%"
            HostScreen.txtATAc.Text = "C= " + perC + "%"
            HostScreen.txtATAd.Text = "D= " + perD + "%"
            GuestScreen.txtATAa.Text = "A= " + perA + "%"
            GuestScreen.txtATAb.Text = "B= " + perB + "%"
            GuestScreen.txtATAc.Text = "C= " + perC + "%"
            GuestScreen.txtATAd.Text = "D= " + perD + "%"

            ControlPanel.tmrResume.Start()
            ControlPanel.btnVote.Enabled = False
            ControlPanel.chkVote.Checked = False
            HostScreen.picVO.Image = My.Resources.lifeline_4_used
            GuestScreen.picVO.Image = My.Resources.lifeline_4_used
            TVControlPnl.picVO.Image = My.Resources.lifeline_4_used
            act = 0
            blankSub()
        End If


        'Dim ff As New Lifeline5050
        'Dim sw As New LifelineSwitch
        'Dim po As New LifelinePO
        'If ControlPanel.doublell = 1 Then
        '    ff.LifelineUse1()
        '    ControlPanel.btnVote.Enabled = False
        '    ControlPanel.chkVote.Checked = False
        '    HostScreen.picVO.Image = My.Resources.lifeline_1_used
        '    GuestScreen.picVO.Image = My.Resources.lifeline_1_used
        '    TVControlPnl.picVO.Image = My.Resources.lifeline_1_used
        '    ControlPanel.intSound += 1

        '    With ControlPanel.snd
        '        .Name = "SOUND" & ControlPanel.intSound
        '        .Play(27, False, 500)
        '    End With
        'ElseIf ControlPanel.doublell = 2 Then
        '    sw.LifelineUse1()
        '    ControlPanel.btnSwitch.Enabled = True
        '    ControlPanel.btnVote.Enabled = False
        '    ControlPanel.chkVote.Checked = False
        '    HostScreen.picVO.Image = My.Resources.lifeline_2_used
        '    GuestScreen.picVO.Image = My.Resources.lifeline_2_used
        '    TVControlPnl.picVO.Image = My.Resources.lifeline_2_used
        'ElseIf ControlPanel.doublell = 3 Then
        '    po.LifelineUse1()
        '    ControlPanel.btnPlusOne.Enabled = True
        '    ControlPanel.btnVote.Enabled = False
        '    ControlPanel.chkVote.Checked = False
        '    HostScreen.picVO.Image = My.Resources.lifeline_3_used
        '    GuestScreen.picVO.Image = My.Resources.lifeline_3_used
        '    TVControlPnl.picVO.Image = My.Resources.lifeline_3_used
        'End If
    End Sub

    Public Sub blankSub()

    End Sub

End Class
