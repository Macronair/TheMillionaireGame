Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class QDatabase
    Dim sql As String
    Dim da As SqlDataAdapter
    Dim rnd As New Random
    Dim rndint As Integer

    Public Sub newQuestion()

        If Data.connectionString.State = ConnectionState.Closed Then
            Data.connectionString.Open()
        End If

        Dim MaxRows As Integer

        If Game.level = -1 Then
            Dim ds As New DataSet
            Dim sqlupdate As String
            Dim sql = New SqlCommand("SELECT TOP 1 * FROM questions_Level0 Used = 'False' ORDER BY NEWID()", Data.connectionString)
            Try
                Dim reader As SqlDataReader = sql.ExecuteReader
                If reader.HasRows Then
                    While reader.Read()
                        ControlPanel.chkUsed.Checked = reader.GetBoolean(8)

                        If ControlPanel.chkUsed.Checked = True Then
                            newQuestion()
                        Else
                            ControlPanel.txtQuestion.Text = reader.GetString(1)
                            ControlPanel.txtA.Text = reader.GetString(2)
                            ControlPanel.txtB.Text = reader.GetString(3)
                            ControlPanel.txtC.Text = reader.GetString(4)
                            ControlPanel.txtD.Text = reader.GetString(5)
                            ControlPanel.lblAnswer.Text = reader.GetString(6)
                            ControlPanel.txtID.Text = reader.GetInt32(0)
                        End If
                    End While
                    reader.Close()

                    sqlupdate = "UPDATE questions_Level0 SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
                    Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Catch ex As Exception
                MessageBox.Show("Error when loading FFF question: " + Environment.NewLine + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Question.act = 0
                ControlPanel.i = 0
                My.Computer.Audio.Stop()
                Question.useMusic = False
            End Try


        End If

        'Haalt een vraag uit de database (100 - 1.000 pt)
        If Game.level >= 0 And Game.level < 5 Then
            Dim ds As New DataSet
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level1 WHERE Used = 'False' ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel1")
            MaxRows = ds.Tables("qLevel1").Rows.Count

            If MaxRows > 0 Then
                ControlPanel.chkUsed.Checked = ds.Tables("qLevel1").Rows(0).Item(8)
                If ControlPanel.chkUsed.Checked = True Then
                    newQuestion()
                Else
                    ControlPanel.txtQuestion.Text = ds.Tables("qLevel1").Rows(0).Item(1)
                    ControlPanel.txtA.Text = ds.Tables("qLevel1").Rows(0).Item(2)
                    ControlPanel.txtB.Text = ds.Tables("qLevel1").Rows(0).Item(3)
                    ControlPanel.txtC.Text = ds.Tables("qLevel1").Rows(0).Item(4)
                    ControlPanel.txtD.Text = ds.Tables("qLevel1").Rows(0).Item(5)
                    ControlPanel.lblAnswer.Text = ds.Tables("qLevel1").Rows(0).Item(6)
                    ControlPanel.txtID.Text = ds.Tables("qLevel1").Rows(0).Item(0)

                    sqlupdate = "UPDATE questions_Level1 SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
                    Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                MessageBox.Show("There are no questions available", "Failed to load question", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Question.act = 0
                My.Computer.Audio.Stop()
                Question.useMusic = False
            End If
        End If

        'Haalt een vraag uit de database (2.000 - 32.000 pt)
        If Game.level >= 5 And Game.level < 10 Then
            Dim ds As New DataSet
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level2 Used = 'False' ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel2")
            MaxRows = ds.Tables("qLevel2").Rows.Count

            If MaxRows > 0 Then
                ControlPanel.chkUsed.Checked = ds.Tables("qLevel2").Rows(0).Item(8)
                If ControlPanel.chkUsed.Checked = True Then
                    newQuestion()
                Else
                    ControlPanel.txtQuestion.Text = ds.Tables("qLevel2").Rows(0).Item(1)
                    ControlPanel.txtA.Text = ds.Tables("qLevel2").Rows(0).Item(2)
                    ControlPanel.txtB.Text = ds.Tables("qLevel2").Rows(0).Item(3)
                    ControlPanel.txtC.Text = ds.Tables("qLevel2").Rows(0).Item(4)
                    ControlPanel.txtD.Text = ds.Tables("qLevel2").Rows(0).Item(5)
                    ControlPanel.lblAnswer.Text = ds.Tables("qLevel2").Rows(0).Item(6)
                    ControlPanel.txtID.Text = ds.Tables("qLevel2").Rows(0).Item(0)

                    sqlupdate = "UPDATE questions_Level2 SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
                    Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                MessageBox.Show("There are no questions available", "Failed to load question", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Question.act = 0
                My.Computer.Audio.Stop()
                Question.useMusic = False
            End If
        End If

        'Haalt een vraag uit de database (64.000 - 500.000 pt)
        If Game.level >= 10 And Game.level < 15 Then
            Dim ds As New DataSet
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level3 Used = 'False' ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel3")
            MaxRows = ds.Tables("qLevel3").Rows.Count

            If MaxRows > 0 Then
                ControlPanel.chkUsed.Checked = ds.Tables("qLevel3").Rows(0).Item(8)
                If ControlPanel.chkUsed.Checked = True Then
                    newQuestion()
                Else
                    ControlPanel.txtQuestion.Text = ds.Tables("qLevel3").Rows(0).Item(1)
                    ControlPanel.txtA.Text = ds.Tables("qLevel3").Rows(0).Item(2)
                    ControlPanel.txtB.Text = ds.Tables("qLevel3").Rows(0).Item(3)
                    ControlPanel.txtC.Text = ds.Tables("qLevel3").Rows(0).Item(4)
                    ControlPanel.txtD.Text = ds.Tables("qLevel3").Rows(0).Item(5)
                    ControlPanel.lblAnswer.Text = ds.Tables("qLevel3").Rows(0).Item(6)
                    ControlPanel.txtID.Text = ds.Tables("qLevel3").Rows(0).Item(0)

                    sqlupdate = "UPDATE questions_Level3 SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
                    Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                MessageBox.Show("There are no questions available.", "Failed to load question", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Question.act = 0
                My.Computer.Audio.Stop()
                Question.useMusic = False
            End If
        End If

        'Haalt een vraag uit de database (1.000.000 pt)
        If Game.level = 15 Then
            Dim ds As New DataSet
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level4 Used = 'False' ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel4")
            MaxRows = ds.Tables("qLevel4").Rows.Count

            If MaxRows > 0 Then
                ControlPanel.chkUsed.Checked = ds.Tables("qLevel4").Rows(0).Item(8)
                If ControlPanel.chkUsed.Checked = True Then
                    newQuestion()
                Else
                    ControlPanel.txtQuestion.Text = ds.Tables("qLevel4").Rows(0).Item(1)
                    ControlPanel.txtA.Text = ds.Tables("qLevel4").Rows(0).Item(2)
                    ControlPanel.txtB.Text = ds.Tables("qLevel4").Rows(0).Item(3)
                    ControlPanel.txtC.Text = ds.Tables("qLevel4").Rows(0).Item(4)
                    ControlPanel.txtD.Text = ds.Tables("qLevel4").Rows(0).Item(5)
                    ControlPanel.lblAnswer.Text = ds.Tables("qLevel4").Rows(0).Item(6)
                    ControlPanel.txtID.Text = ds.Tables("qLevel4").Rows(0).Item(0)

                    sqlupdate = "UPDATE questions_Level4 SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
                    Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Else
                MessageBox.Show("There are no questions available", "Failed to load question", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Question.act = 0
                My.Computer.Audio.Stop()
                Question.useMusic = False
            End If
        End If

        Data.connectionString.Close()

    End Sub

    Public Sub resetDB()

        MessageBox.Show("This feature is replaced to the Questions Editor.", "Questions Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
