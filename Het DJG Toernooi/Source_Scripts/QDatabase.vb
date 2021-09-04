Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class QDatabase
    Dim sql As String
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim rnd As New Random
    Dim rndint As Integer

    Public Sub newQuestion()

        Data.connectionString.Open()
        Dim MaxRows As Integer

        If Game.level = -1 Then
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level0 ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel0")
            MaxRows = ds.Tables("qLevel0").Rows.Count

            ControlPanel.chkUsed.Checked = ds.Tables("qLevel0").Rows(0).Item(8)
            If ControlPanel.chkUsed.Checked = True Then
                newQuestion()
            Else
                ControlPanel.txtQuestion.Text = ds.Tables("qLevel0").Rows(0).Item(1)
                ControlPanel.txtA.Text = ds.Tables("qLevel0").Rows(0).Item(2)
                ControlPanel.txtB.Text = ds.Tables("qLevel0").Rows(0).Item(3)
                ControlPanel.txtC.Text = ds.Tables("qLevel0").Rows(0).Item(4)
                ControlPanel.txtD.Text = ds.Tables("qLevel0").Rows(0).Item(5)
                ControlPanel.lblAnswer.Text = ds.Tables("qLevel0").Rows(0).Item(6)
                ControlPanel.txtID.Text = ds.Tables("qLevel0").Rows(0).Item(0)

                sqlupdate = "UPDATE questions_Level0 SET Used='True' WHERE Id = " & ControlPanel.txtID.Text
                Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        End If

        'Haalt een vraag uit de database (100 - 1.000 pt)
        If Game.level >= 0 And Game.level < 5 Then
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level1 ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel1")
            MaxRows = ds.Tables("qLevel1").Rows.Count

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
        End If

        'Haalt een vraag uit de database (2.000 - 32.000 pt)
        If Game.level >= 5 And Game.level < 10 Then
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level2 ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel2")
            MaxRows = ds.Tables("qLevel2").Rows.Count

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
        End If

        'Haalt een vraag uit de database (64.000 - 500.000 pt)
        If Game.level >= 10 And Game.level < 15 Then
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level3 ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel3")
            MaxRows = ds.Tables("qLevel3").Rows.Count

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
        End If

        'Haalt een vraag uit de database (1.000.000 pt)
        If Game.level = 15 Then
            Dim sqlupdate As String
            sql = "SELECT TOP 1 * FROM questions_Level4 ORDER BY NEWID()"
            da = New SqlDataAdapter(sql, Data.connectionString)
            da.Fill(ds, "qLevel4")
            MaxRows = ds.Tables("qLevel4").Rows.Count

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
        End If

        Data.connectionString.Close()

    End Sub

    Public Sub resetDB()
        'Dim con As New OleDbConnection
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=djgt.accdb;"
        'con.Open()

        'Dim sqlupdate As String
        'sqlupdate = "UPDATE qFFF SET used = false"
        'Dim cmd As SqlCommand = New SqlCommand(sqlupdate, Data.connectionString)

        'Try
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'Catch ex As Exception
        '    MsgBox("Oops! Something went wrong:" + ex.Message)
        'End Try

        'sqlupdate = "UPDATE qLevel1 SET used = false"
        'cmd = New SqlCommand(sqlupdate, Data.connectionString)

        'Try
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'Catch ex As Exception
        '    MsgBox("Oops! Something went wrong:" + ex.Message)
        'End Try

        'sqlupdate = "UPDATE qLevel2 SET used = false"
        'cmd = New SqlCommand(sqlupdate, Data.connectionString)

        'Try
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'Catch ex As Exception
        '    MsgBox("Oops! Something went wrong:" + ex.Message)
        'End Try

        'sqlupdate = "UPDATE qLevel3 SET used = false"
        'cmd = New SqlCommand(sqlupdate, Data.connectionString)

        'Try
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        'Catch ex As Exception
        '    MsgBox("Oops! Something went wrong:" + ex.Message)
        'End Try

        'sqlupdate = "UPDATE qMillion SET used = false"
        'cmd = New SqlCommand(sqlupdate, Data.connectionString)

        'Try
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        '    MsgBox("Reset succesfully executed!")
        'Catch ex As Exception
        '    MsgBox("Oops! Something went wrong:" + ex.Message)
        'End Try
        'con.Close()

        MessageBox.Show("This feature is replaced to the Questions Editor.", "Questions Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
