Imports System.Threading

Public Class PlayerCheck

    Public Shared tie As Integer = 0
    Public Shared rnd As New Random()

    Public Shared Sub Tiebreaker()
        If FFFServer.pl1_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl2_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl3_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl4_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl5_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl6_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl7_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
        If FFFServer.pl8_time = FFFServer.fff_timemin Then
            tie = tie + 1
        End If
    End Sub

    Public Shared Sub Randomizer()
        Dim points As Double
        Dim answer As Integer

        If FFFServer.chkPL1.Checked = True And FFFServer.chkPL1_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL1_Answer.Clear()
            FFFServer.txtPL1_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL1_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL1_Points.Text = points
                FFFServer.pl1_time = points
            Else
                FFFServer.pl1_time = 9999
            End If
        End If

        If FFFServer.chkPL2.Checked = True And FFFServer.chkPL2_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL2_Answer.Clear()
            FFFServer.txtPL2_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL2_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL2_Points.Text = points
                FFFServer.pl2_time = points
            Else
                FFFServer.pl2_time = 9999
            End If
        End If

        If FFFServer.chkPL3.Checked = True And FFFServer.pnlPlayer3.Visible = True And FFFServer.chkPL3_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL3_Answer.Clear()
            FFFServer.txtPL3_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL3_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL3_Points.Text = points
                FFFServer.pl3_time = points
            Else
                FFFServer.pl3_time = 9999
            End If
        End If

        If FFFServer.chkPL4.Checked = True And FFFServer.pnlPlayer4.Visible = True And FFFServer.chkPL4_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL4_Answer.Clear()
            FFFServer.txtPL4_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL4_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL4_Points.Text = points
                FFFServer.pl4_time = points
            Else
                FFFServer.pl4_time = 9999
            End If
        End If

        If FFFServer.chkPL5.Checked = True And FFFServer.pnlPlayer5.Visible = True And FFFServer.chkPL5_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL5_Answer.Clear()
            FFFServer.txtPL5_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL5_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL5_Points.Text = points
                FFFServer.pl5_time = points
            Else
                FFFServer.pl5_time = 9999
            End If
        End If

        If FFFServer.chkPL6.Checked = True And FFFServer.pnlPlayer6.Visible = True And FFFServer.chkPL6_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL6_Answer.Clear()
            FFFServer.txtPL6_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL6_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL6_Points.Text = points
                FFFServer.pl6_time = points
            Else
                FFFServer.pl6_time = 9999
            End If
        End If

        If FFFServer.chkPL7.Checked = True And FFFServer.pnlPlayer7.Visible = True And FFFServer.chkPL7_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL7_Answer.Clear()
            FFFServer.txtPL7_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL7_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL7_Points.Text = points
                FFFServer.pl7_time = points
            Else
                FFFServer.pl7_time = 9999
            End If
        End If

        If FFFServer.chkPL8.Checked = True And FFFServer.pnlPlayer8.Visible = True And FFFServer.chkPL8_Active.Checked = True Then
            points = RandomTime()
            answer = Rnd.Next(0, 2)
            FFFServer.txtPL8_Answer.Clear()
            FFFServer.txtPL8_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL8_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL8_Points.Text = points
                FFFServer.pl8_time = points
            Else
                FFFServer.pl8_time = 9999
            End If
        End If
        getSmallestScore()
    End Sub

    Private Shared Function RandomTime() As Double
        Return rnd.Next(250, 1400) / 100
    End Function

    Private Shared Sub getSmallestScore()

        FFFServer.fff_timemin = FFFServer.pl1_time
        If FFFServer.pl2_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl2_time
        End If
        If FFFServer.pl3_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl3_time
        End If
        If FFFServer.pl4_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl4_time
        End If
        If FFFServer.pl5_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl5_time
        End If
        If FFFServer.pl6_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl6_time
        End If
        If FFFServer.pl7_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl7_time
        End If
        If FFFServer.pl8_time < FFFServer.fff_timemin Then
            FFFServer.fff_timemin = FFFServer.pl8_time
        End If

        FFFServer.lblSmallestScore.Text = "Smallest Score: " + FFFServer.fff_timemin.ToString

    End Sub

    Shared intmeet As Integer = 0
    Public Shared Sub MeetContestants()
        Select Case intmeet
            Case 0
                Dim audio As New Thread(AddressOf MeetContestantAudioSeq)
                audio.Start()
                If GameResolution.CurrentRes = 720 Then
                    TVControlPnl.lblAmount.Font = New Font("Calibri", 26, FontStyle.Bold)
                ElseIf GameResolution.CurrentRes = 1080 Then
                    TVControlPnl.lblAmount.Font = New Font("Calibri", 39, FontStyle.Bold)
                Else
                    TVControlPnl.lblAmount.Font = New Font("Calibri", 26, FontStyle.Bold)
                End If

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
