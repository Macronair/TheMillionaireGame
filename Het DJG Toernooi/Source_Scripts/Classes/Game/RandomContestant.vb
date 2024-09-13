Public Class RandomContestant

    Shared activeplayers As New List(Of Integer)
    Shared random As New Random()
    Public Shared PickingRandomContestant As Boolean = False
    Public Shared pickedContestant As Integer

    Shared action As Integer = 1

    Public Shared Sub Sequence()
        Select Case action
            Case 1
                TVControlPnl.txtPL1_Name.ForeColor = Color.White
                TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL2_Name.ForeColor = Color.White
                TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL3_Name.ForeColor = Color.White
                TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL4_Name.ForeColor = Color.White
                TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL5_Name.ForeColor = Color.White
                TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL6_Name.ForeColor = Color.White
                TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL7_Name.ForeColor = Color.White
                TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL8_Name.ForeColor = Color.White
                TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_idle_new

                activeplayers = New List(Of Integer)

                PickingRandomContestant = True

                If FFFServer.chkPL1_Active.Checked = True Then
                    activeplayers.Add(1)
                End If
                If FFFServer.chkPL2_Active.Checked = True Then
                    activeplayers.Add(2)
                End If
                If FFFServer.chkPL3_Active.Checked = True Then
                    activeplayers.Add(3)
                End If
                If FFFServer.chkPL4_Active.Checked = True Then
                    activeplayers.Add(4)
                End If
                If FFFServer.chkPL5_Active.Checked = True Then
                    activeplayers.Add(5)
                End If
                If FFFServer.chkPL6_Active.Checked = True Then
                    activeplayers.Add(6)
                End If
                If FFFServer.chkPL7_Active.Checked = True Then
                    activeplayers.Add(7)
                End If
                If FFFServer.chkPL8_Active.Checked = True Then
                    activeplayers.Add(8)
                End If

                TVControlPnl.pnlFFFPlayers.Visible = True
                action = 2
            Case 2
                With Sounds.fff_st1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_RandomContestantPicking
                    .controls.play()
                End With
                FFFServer.tmr_RND_RollTime.Start()
                FFFServer.tmr_RND_Roll.Start()
                FFFServer.btnPickRandomContestant.Enabled = False
                action = 3
            Case 3
                With Sounds.fff_st2
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_Winner
                    .controls.play()
                End With
                Select Case pickedContestant
                    Case 1
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL1_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 2
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL2_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 3
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL3_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 4
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL4_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 5
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL5_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 6
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL6_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 7
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL7_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                    Case 8
                        TVControlPnl.lblFFFWinnerName.Text = FFFServer.txtPL8_Name.Text
                        TVControlPnl.lblFFFWinnerPoints.Text = ""
                End Select
                TVControlPnl.pnlFFFWinner.Visible = True
                action = 4
            Case 4
                FFFServer.tmrFastestPlayer.Stop()
                TVControlPnl.pnlFFFPlayers.Visible = False
                action = 5
            Case 5
                TVControlPnl.pnlFFFWinner.Visible = False
                If FFFServer.chkDisableWinnerAuto.Checked = True Then
                    Select Case pickedContestant
                        Case 1
                            FFFServer.txtPL1_Name.Text = ""
                            FFFServer.txtPL1_Points.Text = ""
                            FFFServer.txtPL1_Answer.Text = ""
                            FFFServer.chkPL1_Active.Checked = False
                        Case 2
                            FFFServer.txtPL2_Name.Text = ""
                            FFFServer.txtPL2_Points.Text = ""
                            FFFServer.txtPL2_Answer.Text = ""
                            FFFServer.chkPL2_Active.Checked = False
                        Case 3
                            FFFServer.txtPL3_Name.Text = ""
                            FFFServer.txtPL3_Points.Text = ""
                            FFFServer.txtPL3_Answer.Text = ""
                            FFFServer.chkPL3_Active.Checked = False
                        Case 4
                            FFFServer.txtPL4_Name.Text = ""
                            FFFServer.txtPL4_Points.Text = ""
                            FFFServer.txtPL4_Answer.Text = ""
                            FFFServer.chkPL4_Active.Checked = False
                        Case 5
                            FFFServer.txtPL5_Name.Text = ""
                            FFFServer.txtPL5_Points.Text = ""
                            FFFServer.txtPL5_Answer.Text = ""
                            FFFServer.chkPL5_Active.Checked = False
                        Case 6
                            FFFServer.txtPL6_Name.Text = ""
                            FFFServer.txtPL6_Points.Text = ""
                            FFFServer.txtPL6_Answer.Text = ""
                            FFFServer.chkPL6_Active.Checked = False
                        Case 7
                            FFFServer.txtPL7_Name.Text = ""
                            FFFServer.txtPL7_Points.Text = ""
                            FFFServer.txtPL7_Answer.Text = ""
                            FFFServer.chkPL7_Active.Checked = False
                        Case 8
                            FFFServer.txtPL8_Name.Text = ""
                            FFFServer.txtPL8_Points.Text = ""
                            FFFServer.txtPL8_Answer.Text = ""
                            FFFServer.chkPL8_Active.Checked = False
                    End Select
                End If
                action = 1
                PickingRandomContestant = False
        End Select
    End Sub

    Public Shared Sub Roll()
        Dim rollindex As Integer = random.Next(0, activeplayers.Count)
        Dim randomplayer As Integer = activeplayers(rollindex)

        TVControlPnl.txtPL1_Name.ForeColor = Color.White
        TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL2_Name.ForeColor = Color.White
        TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL3_Name.ForeColor = Color.White
        TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL4_Name.ForeColor = Color.White
        TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL5_Name.ForeColor = Color.White
        TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL6_Name.ForeColor = Color.White
        TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL7_Name.ForeColor = Color.White
        TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL8_Name.ForeColor = Color.White
        TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_idle_new

        Select Case randomplayer
            Case 1
                TVControlPnl.txtPL1_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_fastest_new
            Case 2
                TVControlPnl.txtPL2_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_fastest_new
            Case 3
                TVControlPnl.txtPL3_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_fastest_new
            Case 4
                TVControlPnl.txtPL4_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_fastest_new
            Case 5
                TVControlPnl.txtPL5_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_fastest_new
            Case 6
                TVControlPnl.txtPL6_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_fastest_new
            Case 7
                TVControlPnl.txtPL7_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_fastest_new
            Case 8
                TVControlPnl.txtPL8_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_fastest_new
        End Select
    End Sub

    Public Shared Sub SelectContestant()
        Dim rollindex As Integer = random.Next(0, activeplayers.Count)
        pickedContestant = activeplayers(rollindex)

        TVControlPnl.txtPL1_Name.ForeColor = Color.White
        TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL2_Name.ForeColor = Color.White
        TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL3_Name.ForeColor = Color.White
        TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL4_Name.ForeColor = Color.White
        TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL5_Name.ForeColor = Color.White
        TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL6_Name.ForeColor = Color.White
        TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL7_Name.ForeColor = Color.White
        TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_idle_new
        TVControlPnl.txtPL8_Name.ForeColor = Color.White
        TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_idle_new

        Select Case pickedContestant
            Case 1
                TVControlPnl.txtPL1_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_fastest_new
            Case 2
                TVControlPnl.txtPL2_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_fastest_new
            Case 3
                TVControlPnl.txtPL3_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_fastest_new
            Case 4
                TVControlPnl.txtPL4_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_fastest_new
            Case 5
                TVControlPnl.txtPL5_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_fastest_new
            Case 6
                TVControlPnl.txtPL6_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_fastest_new
            Case 7
                TVControlPnl.txtPL7_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_fastest_new
            Case 8
                TVControlPnl.txtPL8_Name.ForeColor = Color.Black
                TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_fastest_new
        End Select

        FFFServer.tmrFastestPlayer.Start()
    End Sub

End Class
