Imports System.Data.SqlClient
Imports System.IO

Public Class Data

    Public Shared connectionString As New SqlConnection(String.Format(""))

    Public Shared OldTablesPresent = False              ' This will switch to True if there is an old tablename found.
    Public Shared AutoTransferQuestions As Boolean = False        ' If the user chooses to open the Question Editor after creating new database tables after detecting old tables.
    Private Shared MoveFFFToNewTB As Boolean = False    ' Will be switched to true when old tables are detected and the new tables are not created yet.

    Public Shared scanOldTables As Boolean = True

    Public Shared Sub OpenSettings()
        If SQLSettings.SQLInfo.HideAtStart = True Then
            CheckDatabase()
        Else
            Select Case SQLLogin.ShowDialog()
                Case DialogResult.OK
                    CheckDatabase()
                Case DialogResult.Cancel
                    Application.Exit()
            End Select
        End If
    End Sub

    Public Shared Sub CheckDatabase()

        If SQLSettings.SQLInfo.UseRemoteServer = True Then
            CoreConsole.LogMsgDate("SQL Mode = Remote")
            connectionString = New SqlConnection(String.Format("Server={0},{1};User Id={2};Password={3}",
                                                               SQLSettings.SQLInfo.rSQL_Server, SQLSettings.SQLInfo.rSQL_Port,
                                                               SQLSettings.SQLInfo.rSQL_Login, SQLSettings.SQLInfo.rSQL_Password))
        ElseIf SQLSettings.SQLInfo.UseRemoteServer = False Then
            CoreConsole.LogMsgDate("SQL Mode = Local")
            connectionString = New SqlConnection(String.Format("Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true"))
        End If

        Dim dbPath As String = Application.StartupPath

        Dim nameToCreate As String = "dbMillionaire"        ' Name of the database

        If SQLSettings.SQLInfo.UseRemoteServer = True Then
#Region "Remote SQL Databases"
            CoreConsole.LogMsgDate($"Connecting to {SQLSettings.SQLInfo.rSQL_Server} | Port {SQLSettings.SQLInfo.rSQL_Port} ...")
            Try
                connectionString.Open()
            Catch ex As Exception
                MessageBox.Show("Error when connecting to database." + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End Try

            ' Check if database file exists
            Dim cmdCheckDB As String = "SELECT * FROM master.dbo.sysdatabases where name='" + nameToCreate + "'"
            Dim DoesDBExist As Boolean = False
            Using sqlCmd As SqlCommand = New SqlCommand(cmdCheckDB, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    DoesDBExist = reader.HasRows
                End Using
            End Using

            Select Case DoesDBExist
                Case False
                    Try
                        Dim str1 As String = "DROP DATABASE " + nameToCreate

                        Dim str2 As String = "CREATE DATABASE " + nameToCreate

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

                    ' Change the connection string to the newly created database
                    connectionString = New SqlConnection(String.Format("Server={0},{1};Database={2};User Id={3};Password={4}",
                                                                       SQLSettings.SQLInfo.rSQL_Server, SQLSettings.SQLInfo.rSQL_Port, SQLSettings.SQLInfo.rSQL_Database,
                                                                       SQLSettings.SQLInfo.rSQL_Login, SQLSettings.SQLInfo.rSQL_Password))
                    connectionString.Open()

                    'CheckTables()
                    DropTables("fff_questions")
                    DropTables("questions")
                    DropTables("settings_HostMessages")

                    CreateTables(0)
                    CreateTables(1)
                    CreateTables(101)

                    connectionString.Close()
                Case True
                    connectionString = New SqlConnection(String.Format("Server={0},{1};Database={2};User Id={3};Password={4}",
                                                                       SQLSettings.SQLInfo.rSQL_Server, SQLSettings.SQLInfo.rSQL_Port, SQLSettings.SQLInfo.rSQL_Database,
                                                                       SQLSettings.SQLInfo.rSQL_Login, SQLSettings.SQLInfo.rSQL_Password))

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
            End Select
#End Region
        Else
#Region "Local SQL Databases"
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
#End Region
        End If
    End Sub

    Public Shared Sub CheckTables()
        'SQL Commands for checks
        Dim cmd_s_HostMessages As String = "SELECT * FROM sys.tables WHERE name = 'settings_HostMessages'"
        Dim cmd_s_Contestants As String = "SELECT * FROM sys.tables WHERE name = 'settings_Contestants'"
        Dim cmd_q_fffquestions As String = "SELECT * FROM sys.tables WHERE name = 'fff_questions'"
        Dim cmd_q_questions As String = "SELECT * FROM sys.tables WHERE name = 'questions'"

        Dim te_s_HostMessages As Boolean = False
        Dim te_s_Contestants As Boolean = False
        Dim te_q_Level0 As Boolean = False
        Dim te_q_Level1 As Boolean = False

        UpgradeTables()

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
            CoreConsole.LogMsgDate("Checking table 'settings_Contestants'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_s_Contestants, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_s_Contestants = reader.HasRows
                End Using
            End Using
            If te_s_Contestants = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(102)
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

                If MoveFFFToNewTB = True Then
                    Dim transferdata As SqlCommand =
                    New SqlCommand("INSERT INTO fff_questions (Question,A,B,C,D,CorrectAnswer,Used,Note) SELECT Question,A,B,C,D,CorrectAnswer,Used,Note FROM questions_Level0", connectionString)
                    transferdata.ExecuteNonQuery()
                End If
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

                If AutoTransferQuestions = True Then
                    Dim transferdata As SqlCommand =
                    New SqlCommand("INSERT INTO questions (Question,A,B,C,D,CorrectAnswer,Used,Level,Note,Difficulty_Type,LevelRange) SELECT Question,A,B,C,D,CorrectAnswer,Used,'1',Note,'Range',Type FROM questions_Level1", connectionString)
                    transferdata.ExecuteNonQuery()

                    transferdata = New SqlCommand("INSERT INTO questions (Question,A,B,C,D,CorrectAnswer,Used,Level,Note,Difficulty_Type,LevelRange) SELECT Question,A,B,C,D,CorrectAnswer,Used,'1',Note,'Range',Type FROM questions_Level2", connectionString)
                    transferdata.ExecuteNonQuery()

                    transferdata = New SqlCommand("INSERT INTO questions (Question,A,B,C,D,CorrectAnswer,Used,Level,Note,Difficulty_Type,LevelRange) SELECT Question,A,B,C,D,CorrectAnswer,Used,'1',Note,'Range',Type FROM questions_Level3", connectionString)
                    transferdata.ExecuteNonQuery()

                    transferdata = New SqlCommand("INSERT INTO questions (Question,A,B,C,D,CorrectAnswer,Used,Level,Note,Difficulty_Type,LevelRange) SELECT Question,A,B,C,D,CorrectAnswer,Used,'1',Note,'Range',Type FROM questions_Level4", connectionString)
                    transferdata.ExecuteNonQuery()
                End If
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table < questions >: " + Environment.NewLine + ex.Message)
        End Try

        If te_q_Level1 = True Then
            UpdateTables()
        End If

        CoreConsole.LogMsg("")
        CoreConsole.LogMsgDate("=========== Check Results ===========")
        CoreConsole.LogMsgDate("> Fastest Finger Questions = " + te_q_Level0.ToString())
        CoreConsole.LogMsgDate("> Regular Questions        = " + te_q_Level1.ToString())
        CoreConsole.LogMsgDate("> Host Messages            = " + te_s_HostMessages.ToString())
        CoreConsole.LogMsgDate("> Contestants              = " + te_s_Contestants.ToString())
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
                            "[Level] INT DEFAULT ('1') NULL CHECK(Level BETWEEN 1 AND 15)," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] NTEXT NULL," +
                            "[Difficulty_Type] VARCHAR (50) NOT NULL," +
                            "[LevelRange] VARCHAR (50) NULL," +
                            "[Custom_FiftyFifty] BIT NOT NULL DEFAULT 0," +
                            "[FiftyFifty_1] VARCHAR (50) NULL," +
                            "[FiftyFifty_2] VARCHAR (50) NULL," +
                            "[Custom_ATA] BIT NOT NULL DEFAULT 0," +
                            "[ATA_A] INT NULL," +
                            "[ATA_B] INT NULL," +
                            "[ATA_C] INT NULL," +
                            "[ATA_D] INT NULL," +
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
            Case 102
                CoreConsole.LogMsgLineDate("Creating table 'settings_Contestants'...")
                table = "CREATE TABLE [dbo].[settings_Contestants] 
([Id] INT IDENTITY (1,1) NOT NULL, 
[FirstName] NVARCHAR(255) NOT NULL,
[LastName] NVARCHAR(255) NOT NULL, 
[DisplayName] NVARCHAR(255) NOT NULL, 
[City] NVARCHAR(255) NULL, 
[DateOfBirth] DATE NULL, 
[JobTitle] NVARCHAR(255) NULL, 
[Interests] NVARCHAR(MAX) NULL, 
[Family] NVARCHAR(MAX) NULL, 
[Picture] NVARCHAR(MAX) NULL, 
PRIMARY KEY CLUSTERED ([Id] ASC))"
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

    Private Shared Sub UpgradeTables()
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

                'Are these old tables present in the database
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

                'If the tables are - again - present in the db...
                If OldTablesPresent = True Then
                    Dim sqlCmd As New SqlCommand("SELECT * FROM sys.tables WHERE name = 'questions' OR name = 'fff_questions'", connectionString)
                    Using reader As SqlDataReader = sqlCmd.ExecuteReader
                        If reader.HasRows Then  ' When the new tables are already present.

                        Else    ' Let user know that new tables has not yet been created.
                            Dim msgNewTB As DialogResult =
                            MessageBox.Show($"The current tables in your database are not compatible with version 1.1 or higher.{vbNewLine}
For the new features (such as questions per money level), the old table design is unfortunately not suitable for this change
The new tables will be automatically created for you (if this isn't executed yet).
Questions that are created in the old versions can be transfered to the new database tables. But there is also an option to import these questions manually.{vbNewLine}
Do you want to import the questions automatically? Click 'No' to manually import it later. Or 'Cancel' to exit (no tables and other changes will be made)", "INFO: Major Database Change!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                            Select Case msgNewTB
                                Case DialogResult.Yes
                                    AutoTransferQuestions = True
                                Case DialogResult.No
                                    AutoTransferQuestions = False
                                Case DialogResult.Cancel
                                    Environment.Exit(0)
                            End Select

                            MoveFFFToNewTB = True
                        End If
                    End Using

                    Try
                        Dim addColumn As SqlCommand
                        addColumn = New SqlCommand("ALTER TABLE questions_Level1 ADD Imported BIT NOT NULL DEFAULT 0", connectionString)
                        addColumn.ExecuteNonQuery()
                        addColumn = New SqlCommand("ALTER TABLE questions_Level2 ADD Imported BIT NOT NULL DEFAULT 0", connectionString)
                        addColumn.ExecuteNonQuery()
                        addColumn = New SqlCommand("ALTER TABLE questions_Level3 ADD Imported BIT NOT NULL DEFAULT 0", connectionString)
                        addColumn.ExecuteNonQuery()
                        addColumn = New SqlCommand("ALTER TABLE questions_Level4 ADD Imported BIT NOT NULL DEFAULT 0", connectionString)
                        addColumn.ExecuteNonQuery()
                    Catch

                    End Try
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Shared Sub UpdateTables()
        Dim updatetables As SqlCommand
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','Difficulty_Type') IS NULL ALTER TABLE questions ADD Difficulty_Type VARCHAR(50) NOT NULL DEFAULT 'Specific';", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','LevelRange') IS NULL ALTER TABLE questions ADD LevelRange VARCHAR(50) NULL;", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','Custom_FiftyFifty') IS NULL ALTER TABLE questions ADD Custom_FiftyFifty BIT NOT NULL DEFAULT 0;", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','FiftyFifty_1') IS NULL ALTER TABLE questions ADD FiftyFifty_1 VARCHAR(50);", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','FiftyFifty_2') IS NULL ALTER TABLE questions ADD FiftyFifty_2 VARCHAR(50);", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','Custom_ATA') IS NULL ALTER TABLE questions ADD Custom_ATA BIT NOT NULL DEFAULT 0;", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','ATA_a') IS NULL ALTER TABLE questions ADD ATA_a VARCHAR(50);", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','ATA_b') IS NULL ALTER TABLE questions ADD ATA_b VARCHAR(50);", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','ATA_c') IS NULL ALTER TABLE questions ADD ATA_c VARCHAR(50);", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
        Try
            updatetables = New SqlCommand("IF COL_LENGTH('questions','ATA_d') IS NULL ALTER TABLE questions ADD ATA_d VARCHAR(50);", connectionString)
            updatetables.ExecuteNonQuery()
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when updating table: " + Environment.NewLine + ex.Message)
        End Try
    End Sub

End Class
