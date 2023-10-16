Imports System.Data.SqlClient
Imports System.IO

Public Class Data

    Public Shared connectionString As New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30"))
    Public Shared OldTablesPresent = False    ' This will switch to True if there is an old tablename found.

    Public Shared openQEditor As Boolean = False
    Public Shared scanOldTables As Boolean = True

    Public Shared Sub CheckDatabase()

        Dim dbPath As String = Application.StartupPath

        Dim nameToCreate As String = "dbMillionaire"        ' Name of the database

        ' Message to the console to show the database location
        CoreConsole.LogMsgDate("Database location: " + dbPath + "\" + nameToCreate + ".mdf")

        ' Check if database file exists
        If File.Exists(dbPath + "\" + nameToCreate + ".mdf") = False Then   ' If file does not exist, then create it.
            CoreConsole.LogMsgDate("Database not found. Trying to create new file...")      ' Letting the user know.

            ' Open SQL Connection
            connectionString.Open()

            Try
                Dim str1 As String = "DROP DATABASE " + nameToCreate

                Dim str2 As String = "CREATE DATABASE " + nameToCreate + " ON PRIMARY " +
                            "(NAME = " + nameToCreate + "_Data, " +
                            "FILENAME = '" + dbPath + "\\" + nameToCreate + ".mdf', " +
                            "SIZE = 4MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                            "LOG ON (NAME = " + nameToCreate + "_Log, " +
                            "FILENAME = '" + dbPath + "\\" + nameToCreate + ".ldf', " +
                            "SIZE = 1MB, " +
                            "MAXSIZE = 5MB, " +
                            "FILEGROWTH = 10%)"

                Dim cmdRemove As New SqlCommand(str1, connectionString)
                Dim cmdCreate As New SqlCommand(str2, connectionString)

                Try
                    cmdRemove.ExecuteNonQuery()
                Catch ex As Exception
                    CoreConsole.LogMsgDate("Unable to remove database, because it probably doesn't exist. Resuming with database creation.")
                Finally
                    cmdCreate.ExecuteNonQuery()
                    CoreConsole.LogMsgDate("Database '" + nameToCreate + "' was created successfully")
                End Try

            Catch ex As Exception
                CoreConsole.LogMsgDate("Error when creating database:")
                CoreConsole.LogMsg(ex.Message)
            Finally
                connectionString.Close()
            End Try

            ' Change the connection string to the newly created file
            connectionString = New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", dbPath, nameToCreate))

            connectionString.Open()
            DropTables("fff_questions")
            DropTables("questions")
            DropTables("settings_HostMessages")

            CreateTables(0)
            CreateTables(1)
            CreateTables(101)

            'CheckTables()
            connectionString.Close()

        Else
            connectionString = New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", dbPath, nameToCreate))

            Try
                connectionString.Open()
                CoreConsole.LogMsgDate("Succesfully connected to local database.")
                CoreConsole.LogMsgDate("Starting Database table check.")
                CheckTables()
            Catch ex As Exception
                CoreConsole.LogMsgDate("An error occured while loading the database:")
                CoreConsole.LogMsg(ex.Message)
            Finally
                connectionString.Close()
            End Try
        End If
    End Sub

    Public Shared Sub CheckTables()
        'SQL Commands for checks
        Dim cmd_s_HostMessages As String = "SELECT * FROM sys.tables WHERE name = 'settings_HostMessages'"
        Dim cmd_q_fffquestions As String = "SELECT * FROM sys.tables WHERE name = 'fff_questions'"
        Dim cmd_q_questions As String = "SELECT * FROM sys.tables WHERE name = 'questions'"

        Dim te_s_HostMessages As Boolean
        Dim te_q_Level0 As Boolean
        Dim te_q_Level1 As Boolean

        'Since October 2023, there is a new database design which invole less tables and other names.
        'When this method is called, the code below would be run to create the new tables within the existing database (if they aren't created yet).
        'The user will also be informed about this.
        If scanOldTables = True Then    ' You can turn off scanning at the top of this class/file. Change it there to False.
            Try
                'Tables to look out for.
                Dim cmd_q_Lvl0 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level0'"
                Dim cmd_q_Lvl1 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level1'"
                Dim cmd_q_Lvl2 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level2'"
                Dim cmd_q_Lvl3 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level3'"
                Dim cmd_q_Lvl4 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level4'"



                Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Lvl0, connectionString)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader
                        If reader.HasRows Then
                            OldTablesPresent = True
                        End If
                    End Using
                End Using
                Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Lvl1, connectionString)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader
                        If reader.HasRows Then
                            OldTablesPresent = True
                        End If
                    End Using
                End Using
                Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Lvl2, connectionString)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader
                        If reader.HasRows Then
                            OldTablesPresent = True
                        End If
                    End Using
                End Using
                Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Lvl3, connectionString)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader
                        If reader.HasRows Then
                            OldTablesPresent = True
                        End If
                    End Using
                End Using
                Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Lvl4, connectionString)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader
                        If reader.HasRows Then
                            OldTablesPresent = True
                        End If
                    End Using
                End Using

                If OldTablesPresent = True Then
                    Dim msgNewTB As DialogResult =
                    MessageBox.Show($"The current tables in your database are not compatible with version 1.1 or higher.{vbNewLine}
For the new features (such as questions per money level), the old table design is unfortunately not suitable for this change
The new tables will be automatically created for you (if this isn't executed yet).
If you had used some older versions, there is a new import tool in the Questions Editor you can use where you can set the desired difficulty/money level to each question.{vbNewLine}
Do you want to run the Questions Editor first? Click 'No' to continue loading the main program. Or 'Cancel' to exit (no tables will be made){vbNewLine}
(You can disable this message at startup in the Options window under the Database tab)", "INFO: Major Database Change!",
MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    Select Case msgNewTB
                        Case DialogResult.Yes
                            openQEditor = True
                        Case DialogResult.No
                            openQEditor = False
                        Case DialogResult.Cancel
                            Environment.Exit(0)
                    End Select

                    Dim addColumn As SqlCommand
                    addColumn = New SqlCommand("ALTER TABLE questions_Level1 ADD Imported BIT DEFAULT 'False'", connectionString)
                    addColumn.ExecuteNonQuery()
                    addColumn = New SqlCommand("ALTER TABLE questions_Level2 ADD Imported BIT DEFAULT 'False'", connectionString)
                    addColumn.ExecuteNonQuery()
                    addColumn = New SqlCommand("ALTER TABLE questions_Level3 ADD Imported BIT DEFAULT 'False'", connectionString)
                    addColumn.ExecuteNonQuery()
                    addColumn = New SqlCommand("ALTER TABLE questions_Level4 ADD Imported BIT DEFAULT 'False'", connectionString)
                    addColumn.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Try
            CoreConsole.LogMsgDate("Checking table 'settings_HostMessages'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_s_HostMessages, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_s_HostMessages = reader.HasRows
                End Using
            End Using
            If te_s_HostMessages = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(101)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking database < settings_HostMessages >: " + Environment.NewLine + ex.Message)
        End Try
        Try
            CoreConsole.LogMsgDate("Checking table 'fff_questions'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_fffquestions, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level0 = reader.HasRows
                End Using
            End Using
            If te_q_Level0 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(0)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table < fff_questions >: " + Environment.NewLine + ex.Message)
        End Try
        Try
            CoreConsole.LogMsgDate("Checking table 'questions'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_questions, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level1 = reader.HasRows
                End Using
            End Using
            If te_q_Level1 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(1)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table < questions >: " + Environment.NewLine + ex.Message)
        End Try

        CoreConsole.LogMsg("")
        CoreConsole.LogMsgDate("=========== Check Results ===========")
        CoreConsole.LogMsgDate("> Fastest Finger Questions = " + te_q_Level0.ToString())
        CoreConsole.LogMsgDate("> Regular Questions        = " + te_q_Level1.ToString())
        CoreConsole.LogMsgDate("> Host Messages            = " + te_s_HostMessages.ToString())
        CoreConsole.LogMsgDate("=====================================")
        CoreConsole.LogMsg("")

    End Sub

    Public Shared Sub DropTables(ByVal tablename As String)
        Dim drop As String = "DROP TABLE " + tablename + ";"
        Dim dropcmd As SqlCommand = New SqlCommand(drop, connectionString)
        Try
            dropcmd.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Table with name " + tablename + " doesn't exist.")
        End Try
    End Sub

    Public Shared Sub CreateTables(ByVal tablename As Integer)
        Dim table As String

        Select Case tablename
            Case 0
                CoreConsole.LogMsgLineDate("Creating table 'fff_questions'...")
                table = "CREATE TABLE [dbo].[fff_questions] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] NTEXT NOT NULL," +
                            "[A] NVARCHAR (50) NOT NULL," +
                            "[B] NVARCHAR (50) NOT NULL," +
                            "[C] NVARCHAR (50) NOT NULL," +
                            "[D] NVARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Level] INT DEFAULT ('0') NOT NULL," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] NTEXT NULL," +
                            "PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try

                If OldTablesPresent = True Then
                    Dim da As New SqlDataAdapter("SELECT Question,A,B,C,D,CorrectAnswer,Used,Note FROM questions_Level0", connectionString)
                    da.InsertCommand = New SqlCommand("INSERT INTO fff_questions (Question,A,B,C,D,CorrectAnswer,Level,Used,Note) VALUES (@Question,@A,@B,@C,@D,@CorrectAnswer,0,@Used,@Note)")
                    da.InsertCommand.Parameters.Add("@Question", SqlDbType.NText, 0, "Question")
                    da.InsertCommand.Parameters.Add("@A", SqlDbType.NVarChar, 50, "A")
                    da.InsertCommand.Parameters.Add("@B", SqlDbType.NVarChar, 50, "B")
                    da.InsertCommand.Parameters.Add("@C", SqlDbType.NVarChar, 50, "C")
                    da.InsertCommand.Parameters.Add("@D", SqlDbType.NVarChar, 50, "D")
                    da.InsertCommand.Parameters.Add("@CorrectAnswer", SqlDbType.NVarChar, 50, "CorrectAnswer")
                    da.InsertCommand.Parameters.Add("@Used", SqlDbType.Bit, 0, "Used")
                    da.InsertCommand.Parameters.Add("@Note", SqlDbType.NText, 50, "Note")

                    da.AcceptChangesDuringFill = False

                    Dim dt As New DataTable
                    da.Fill(dt)
                    da.Update(dt)
                End If
            Case 1
                CoreConsole.LogMsgLineDate("Creating table 'questions'...")
                table = "CREATE TABLE [dbo].[questions] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] NTEXT NOT NULL," +
                            "[A] NVARCHAR (50) NOT NULL," +
                            "[B] NVARCHAR (50) NOT NULL," +
                            "[C] NVARCHAR (50) NOT NULL," +
                            "[D] NVARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Level] INT DEFAULT ('1') NOT NULL CHECK(Level BETWEEN 1 AND 15)," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] NTEXT NULL," +
                            "PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try
            Case 101
                CoreConsole.LogMsgLineDate("Creating table 'settings_HostMessages'...")
                table = "CREATE TABLE [dbo].[settings_HostMessages] ([Id] INT IDENTITY (1,1) NOT NULL, [Message] NVARCHAR(MAX) NOT NULL, PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try
        End Select
    End Sub

End Class
