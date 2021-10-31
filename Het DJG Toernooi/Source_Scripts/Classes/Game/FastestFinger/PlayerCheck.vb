Imports System.Threading

Public Class PlayerCheck

    Public Shared tie As Integer = 0

    Public Shared Sub Tiebreaker()
        If FFFServer.pl1_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl2_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl3_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl4_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl5_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl6_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl7_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
        If FFFServer.pl8_points = FFFServer.fff_pointsmin Then
            tie = tie + 1
        End If
    End Sub

    Public Shared Sub Randomizer()
        Dim rnd As New Random()
        Dim points As Integer
        Dim answer As Integer

        If FFFServer.chkPL1.Checked = True And FFFServer.chkPL1_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL1_Answer.Clear()
            FFFServer.txtPL1_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL1_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL1_Points.Text = points
                FFFServer.pl1_points = points
            Else
                FFFServer.pl1_points = 9999
            End If
        End If

        If FFFServer.chkPL2.Checked = True And FFFServer.chkPL2_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL2_Answer.Clear()
            FFFServer.txtPL2_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL2_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL2_Points.Text = points
                FFFServer.pl2_points = points
            Else
                FFFServer.pl2_points = 9999
            End If
        End If

        If FFFServer.chkPL3.Checked = True And FFFServer.pnlPlayer3.Visible = True And FFFServer.chkPL3_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL3_Answer.Clear()
            FFFServer.txtPL3_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL3_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL3_Points.Text = points
                FFFServer.pl3_points = points
            Else
                FFFServer.pl3_points = 9999
            End If
        End If

        If FFFServer.chkPL4.Checked = True And FFFServer.pnlPlayer4.Visible = True And FFFServer.chkPL4_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL4_Answer.Clear()
            FFFServer.txtPL4_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL4_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL4_Points.Text = points
                FFFServer.pl4_points = points
            Else
                FFFServer.pl4_points = 9999
            End If
        End If

        If FFFServer.chkPL5.Checked = True And FFFServer.pnlPlayer5.Visible = True And FFFServer.chkPL5_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL5_Answer.Clear()
            FFFServer.txtPL5_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL5_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL5_Points.Text = points
                FFFServer.pl5_points = points
            Else
                FFFServer.pl5_points = 9999
            End If
        End If

        If FFFServer.chkPL6.Checked = True And FFFServer.pnlPlayer6.Visible = True And FFFServer.chkPL6_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL6_Answer.Clear()
            FFFServer.txtPL6_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL6_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL6_Points.Text = points
                FFFServer.pl6_points = points
            Else
                FFFServer.pl6_points = 9999
            End If
        End If

        If FFFServer.chkPL7.Checked = True And FFFServer.pnlPlayer7.Visible = True And FFFServer.chkPL7_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL7_Answer.Clear()
            FFFServer.txtPL7_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL7_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL7_Points.Text = points
                FFFServer.pl7_points = points
            Else
                FFFServer.pl7_points = 9999
            End If
        End If

        If FFFServer.chkPL8.Checked = True And FFFServer.pnlPlayer8.Visible = True And FFFServer.chkPL8_Active.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL8_Answer.Clear()
            FFFServer.txtPL8_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL8_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL8_Points.Text = points
                FFFServer.pl8_points = points
            Else
                FFFServer.pl8_points = 9999
            End If
        End If
        getSmallestScore()
    End Sub

    Private Shared Sub getSmallestScore()

        FFFServer.fff_pointsmin = FFFServer.pl1_points
        If FFFServer.pl2_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl2_points
        End If
        If FFFServer.pl3_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl3_points
        End If
        If FFFServer.pl4_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl4_points
        End If
        If FFFServer.pl5_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl5_points
        End If
        If FFFServer.pl6_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl6_points
        End If
        If FFFServer.pl7_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl7_points
        End If
        If FFFServer.pl8_points < FFFServer.fff_pointsmin Then
            FFFServer.fff_pointsmin = FFFServer.pl8_points
        End If

        FFFServer.lblSmallestScore.Text = "Smallest Score: " + FFFServer.fff_pointsmin.ToString

    End Sub

    Shared intmeet As Integer = 0
    Public Shared Sub MeetContestants()
        Select Case intmeet
            Case 0
                Dim audio As New Thread(AddressOf MeetContestantAudioSeq)
                audio.Start()
                TVControlPnl.lblAmount.Font = New Font("Calibri", 26, FontStyle.Bold)

                TVControlPnl.lblAmount.Text = FFFServer.txtPL1_Name.Text
                TVControlPnl.pnlStrap.Visible = True
                intmeet = intmeet + 1
            Case 1
                TVControlPnl.lblAmount.Text = FFFServer.txtPL2_Name.Text
                intmeet = intmeet + 1
            Case 2
                If FFFServer.pnlPlayer3.Visible = True Then
                    TVControlPnl.lblAmount.Text = FFFServer.txtPL3_Name.Text
                    intmeet = intmeet + 1
                Else
                    intmeet = 0
                    TVControlPnl.pnlStrap.Visible = False
                    TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                    TVControlPnl.lblAmount.Text = "0"
                End If
            Case 3
                If FFFServer.pnlPlayer4.Visible = True Then
                    TVControlPnl.lblAmount.Text = FFFServer.txtPL4_Name.Text
                    intmeet = intmeet + 1
                Else
                    intmeet = 0
                    TVControlPnl.pnlStrap.Visible = False
                    TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                    TVControlPnl.lblAmount.Text = "0"
                End If
            Case 4
                If FFFServer.pnlPlayer5.Visible = True Then
                    TVControlPnl.lblAmount.Text = FFFServer.txtPL5_Name.Text
                    intmeet = intmeet + 1
                Else
                    intmeet = 0
                    TVControlPnl.pnlStrap.Visible = False
                    TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                    TVControlPnl.lblAmount.Text = "0"
                End If
            Case 5
                If FFFServer.pnlPlayer6.Visible = True Then
                    TVControlPnl.lblAmount.Text = FFFServer.txtPL6_Name.Text
                    intmeet = intmeet + 1
                Else
                    intmeet = 0
                    TVControlPnl.pnlStrap.Visible = False
                    TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                    TVControlPnl.lblAmount.Text = "0"
                End If
            Case 6
                If FFFServer.pnlPlayer7.Visible = True Then
                    TVControlPnl.lblAmount.Text = FFFServer.txtPL7_Name.Text
                    intmeet = intmeet + 1
                Else
                    intmeet = 0
                    TVControlPnl.pnlStrap.Visible = False
                    TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                    TVControlPnl.lblAmount.Text = "0"
                End If
            Case 7
                If FFFServer.pnlPlayer8.Visible = True Then
                    TVControlPnl.lblAmount.Text = FFFServer.txtPL8_Name.Text
                    intmeet = intmeet + 1
                Else
                    intmeet = 0
                    TVControlPnl.pnlStrap.Visible = False
                    TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                    TVControlPnl.lblAmount.Text = "0"
                End If
            Case 8
                intmeet = 0
                TVControlPnl.pnlStrap.Visible = False
                TVControlPnl.lblAmount.Font = New Font("Copperplate Gothic Bold", 36)
                TVControlPnl.lblAmount.Text = "0"
        End Select

    End Sub

    Private Shared Sub MeetContestantAudioSeq()
        Dim meet As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
        Select Case FFFServer.totalContestants
            Case 2
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_2.mp3"
            Case 3
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_3.mp3"
            Case 4
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_4.mp3"
            Case 5
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_5.mp3"
            Case 6
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_6.mp3"
            Case 7
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_7.mp3"
            Case 8
                meet.URL = Application.StartupPath + "\Sounds\fastest_finger_contestants_8.mp3"
        End Select
        meet.controls.play()
    End Sub

End Class
