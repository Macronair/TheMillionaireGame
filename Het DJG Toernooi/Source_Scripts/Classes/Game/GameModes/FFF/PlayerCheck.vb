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

        If FFFServer.chkPL1.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL1_Answer.Clear()
            FFFServer.txtPL1_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL1_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL1_Points.Text = points
                FFFServer.pl1_points = points
            End If
        End If

        If FFFServer.chkPL2.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL2_Answer.Clear()
            FFFServer.txtPL2_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL2_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL2_Points.Text = points
                FFFServer.pl2_points = points
            End If
        End If

        If FFFServer.chkPL3.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL3_Answer.Clear()
            FFFServer.txtPL3_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL3_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL3_Points.Text = points
                FFFServer.pl3_points = points
            End If
        End If

        If FFFServer.chkPL4.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL4_Answer.Clear()
            FFFServer.txtPL4_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL4_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL4_Points.Text = points
                FFFServer.pl4_points = points
            End If
        End If

        If FFFServer.chkPL5.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL5_Answer.Clear()
            FFFServer.txtPL5_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL5_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL5_Points.Text = points
                FFFServer.pl5_points = points
            End If
        End If

        If FFFServer.chkPL6.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL6_Answer.Clear()
            FFFServer.txtPL6_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL6_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL6_Points.Text = points
                FFFServer.pl6_points = points
            End If
        End If

        If FFFServer.chkPL7.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL7_Answer.Clear()
            FFFServer.txtPL7_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL7_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL7_Points.Text = points
                FFFServer.pl7_points = points
            End If
        End If

        If FFFServer.chkPL8.Checked = True Then
            points = rnd.Next(400, 1190)
            answer = rnd.Next(0, 2)
            FFFServer.txtPL8_Answer.Clear()
            FFFServer.txtPL8_Points.Clear()
            If answer = 0 Then
                FFFServer.txtPL8_Answer.Text = FFFServer.correctAnswer
                FFFServer.txtPL8_Points.Text = points
                FFFServer.pl8_points = points
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

End Class
