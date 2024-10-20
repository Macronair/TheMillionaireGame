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
            Dim sql = New SqlCommand("SELECT TOP 1 * FROM fff_questions WHERE Used = 'False' ORDER BY NEWID()", Data.connectionString)
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

                    sqlupdate = "UPDATE fff_questions SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
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

        If Game.level >= 0 Then
            Dim ds As New DataSet
            Dim sqlupdate As String

            Dim rangelevel As String
            If Game.level >= 1 And Game.level <= 5 Then
                rangelevel = "Lvl1"
            ElseIf Game.level >= 6 And Game.level <= 10 Then
                rangelevel = "Lvl2"
            ElseIf Game.level >= 11 And Game.level <= 14 Then
                rangelevel = "Lvl3"
            ElseIf Game.level = 15 Then
                rangelevel = "Lvl4"
            End If
            sql = $"
SELECT TOP 1 * FROM
(
	SELECT Id,Question,A,B,C,D,CorrectAnswer,Difficulty_Type,Level,LevelRange,Note,Used FROM questions WHERE Used = 'False' AND Level = {Game.level + 1} AND Difficulty_Type = 'Specific'
	UNION ALL
	SELECT Id,Question,A,B,C,D,CorrectAnswer,Difficulty_Type,Level,LevelRange,Note,Used FROM questions WHERE Used = 'False' AND LevelRange = '{rangelevel}' AND Difficulty_Type = 'Range'
) A ORDER BY NEWID()"

            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "question")
            MaxRows = ds.Tables("question").Rows.Count

            If MaxRows > 0 Then
                ControlPanel.chkUsed.Checked = ds.Tables("question").Rows(0).Item(11)
                If ControlPanel.chkUsed.Checked = True Then
                    newQuestion()
                Else
                    ControlPanel.txtQuestion.Text = ds.Tables("question").Rows(0).Item(1)
                    ControlPanel.txtA.Text = ds.Tables("question").Rows(0).Item(2)
                    ControlPanel.txtB.Text = ds.Tables("question").Rows(0).Item(3)
                    ControlPanel.txtC.Text = ds.Tables("question").Rows(0).Item(4)
                    ControlPanel.txtD.Text = ds.Tables("question").Rows(0).Item(5)
                    ControlPanel.lblAnswer.Text = ds.Tables("question").Rows(0).Item(6)
                    ControlPanel.txtID.Text = ds.Tables("question").Rows(0).Item(0)
                    ControlPanel.txtExplain.Text = ds.Tables("question").Rows(0).Item(10).ToString()

                    sqlupdate = "UPDATE questions SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
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
