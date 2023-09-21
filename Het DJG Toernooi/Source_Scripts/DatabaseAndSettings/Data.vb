Imports System.Data.SqlClient
Imports System.IO

Public Class Data

    Public Shared connectionString As New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30"))

    Public Shared Sub CreateDatabase()

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
            DropTables("questions_Level0")
            DropTables("questions_Level1")
            DropTables("questions_Level2")
            DropTables("questions_Level3")
            DropTables("questions_Level4")
            DropTables("settings_HostMessages")

            CreateTables(0)
            CreateTables(1)
            CreateTables(2)
            CreateTables(3)
            CreateTables(4)
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
        Dim cmd_s_Profiles As String = "SELECT * FROM sys.tables WHERE name = 'settings_Profiles'"
        Dim cmd_q_Level0 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level0'"
        Dim cmd_q_Level1 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level1'"
        Dim cmd_q_Level2 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level2'"
        Dim cmd_q_Level3 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level3'"
        Dim cmd_q_Level4 As String = "SELECT * FROM sys.tables WHERE name = 'questions_Level4'"

        Dim te_s_HostMessages As Boolean
        Dim te_s_Profiles As Boolean
        Dim te_q_Level0 As Boolean
        Dim te_q_Level1 As Boolean
        Dim te_q_Level2 As Boolean
        Dim te_q_Level3 As Boolean
        Dim te_q_Level4 As Boolean

        'Check the Settings tables

        'Settings
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
            CoreConsole.LogMsgDate("Error when checking database: " + Environment.NewLine + ex.Message)
        End Try

        'Profiles                   <-- Coming soon in future builds
        'Using sqlCmd As SqlCommand = New SqlCommand(cmd_s_HostMessages, connectionString)
        '    Using reader As SqlDataReader = sqlCmd.ExecuteReader
        '        te_s_Profiles = reader.HasRows
        '    End Using
        'End Using

        'Check the Question tables
        Try
            CoreConsole.LogMsgDate("Checking table 'questions_Level0'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Level0, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level0 = reader.HasRows
                End Using
            End Using
            If te_q_Level0 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(0)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table questions_Level0: " + Environment.NewLine + ex.Message)
        End Try
        Try
            CoreConsole.LogMsgDate("Checking table 'questions_Level1'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Level1, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level1 = reader.HasRows
                End Using
            End Using
            If te_q_Level1 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(1)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table questions_Level1: " + Environment.NewLine + ex.Message)
        End Try
        Try
            CoreConsole.LogMsgDate("Checking table 'questions_Level2'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Level2, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level2 = reader.HasRows
                End Using
            End Using
            If te_q_Level2 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(2)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table questions_Level2: " + Environment.NewLine + ex.Message)
        End Try
        Try
            CoreConsole.LogMsgDate("Checking table 'questions_Level3'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Level3, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level3 = reader.HasRows
                End Using
            End Using
            If te_q_Level3 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(3)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table questions_Level3: " + Environment.NewLine + ex.Message)
        End Try
        Try
            CoreConsole.LogMsgDate("Checking table 'questions_Level4'...")
            Using sqlCmd As SqlCommand = New SqlCommand(cmd_q_Level4, connectionString)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    te_q_Level4 = reader.HasRows
                End Using
            End Using
            If te_q_Level4 = False Then
                CoreConsole.LogMsgDate("Table cannot be found.")
                CreateTables(4)
            End If
        Catch ex As Exception
            CoreConsole.LogMsgDate("Error when checking table questions_Level4: " + Environment.NewLine + ex.Message)
        End Try

        CoreConsole.LogMsg("")
        CoreConsole.LogMsgDate("=========== Check Results ===========")
        CoreConsole.LogMsgDate("> Fastest Finger Questions = " + te_q_Level0.ToString())
        CoreConsole.LogMsgDate("> Level 1 Questions        = " + te_q_Level1.ToString())
        CoreConsole.LogMsgDate("> Level 2 Questions        = " + te_q_Level2.ToString())
        CoreConsole.LogMsgDate("> Level 3 Questions        = " + te_q_Level3.ToString())
        CoreConsole.LogMsgDate("> Level 4 Questions        = " + te_q_Level4.ToString())
        CoreConsole.LogMsgDate("> Host Messages            = " + te_s_HostMessages.ToString())
        CoreConsole.LogMsgDate("> Profiles                 = " + te_s_Profiles.ToString())
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
                CoreConsole.LogMsgLineDate("Creating table 'questions_Level0'...")
                table = "CREATE TABLE [dbo].[questions_Level0] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] TEXT NOT NULL," +
                            "[A] VARCHAR (50) NOT NULL," +
                            "[B] VARCHAR (50) NOT NULL," +
                            "[C] VARCHAR (50) NOT NULL," +
                            "[D] VARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Type] VARCHAR (50) DEFAULT ('Lvl1') NOT NULL," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] TEXT NULL," +
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
                CoreConsole.LogMsgLineDate("Creating table 'questions_Level1'...")
                table = "CREATE TABLE [dbo].[questions_Level1] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] TEXT NOT NULL," +
                            "[A] VARCHAR (50) NOT NULL," +
                            "[B] VARCHAR (50) NOT NULL," +
                            "[C] VARCHAR (50) NOT NULL," +
                            "[D] VARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Type] VARCHAR (50) DEFAULT ('Lvl1') NOT NULL," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] TEXT NULL," +
                            "PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try
            Case 2
                CoreConsole.LogMsgLineDate("Creating table 'questions_Level2'...")
                table = "CREATE TABLE [dbo].[questions_Level2] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] TEXT NOT NULL," +
                            "[A] VARCHAR (50) NOT NULL," +
                            "[B] VARCHAR (50) NOT NULL," +
                            "[C] VARCHAR (50) NOT NULL," +
                            "[D] VARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Type] VARCHAR (50) DEFAULT ('Lvl1') NOT NULL," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] TEXT NULL," +
                            "PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try
            Case 3
                CoreConsole.LogMsgLineDate("Creating table 'questions_Level3'...")
                table = "CREATE TABLE [dbo].[questions_Level3] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] TEXT NOT NULL," +
                            "[A] VARCHAR (50) NOT NULL," +
                            "[B] VARCHAR (50) NOT NULL," +
                            "[C] VARCHAR (50) NOT NULL," +
                            "[D] VARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Type] VARCHAR (50) DEFAULT ('Lvl1') NOT NULL," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] TEXT NULL," +
                            "PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try
            Case 4
                CoreConsole.LogMsgLineDate("Creating table 'questions_Level4'...")
                table = "CREATE TABLE [dbo].[questions_Level4] (" +
                            "[Id] INT IDENTITY (1,1) NOT NULL," +
                            "[Question] TEXT NOT NULL," +
                            "[A] VARCHAR (50) NOT NULL," +
                            "[B] VARCHAR (50) NOT NULL," +
                            "[C] VARCHAR (50) NOT NULL," +
                            "[D] VARCHAR (50) NOT NULL," +
                            "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                            "[Type] VARCHAR (50) DEFAULT ('Lvl1') NOT NULL," +
                            "[Used] BIT NOT NULL DEFAULT 0," +
                            "[Note] TEXT NULL," +
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
                table = "CREATE TABLE [dbo].[settings_HostMessages] ([Id] INT IDENTITY (1,1) NOT NULL, [Message] VARCHAR(MAX) NOT NULL, PRIMARY KEY CLUSTERED ([Id] ASC))"
                Dim cmd As SqlCommand = New SqlCommand(table, connectionString)
                Try
                    cmd.ExecuteNonQuery()
                    CoreConsole.LogMsg("Success!")
                Catch ex As Exception
                    CoreConsole.LogMsg("<")
                    CoreConsole.LogMsgDate("Error when creating table: " + Environment.NewLine + ex.Message)
                End Try
            Case 100
                CoreConsole.LogMsgLineDate("Creating table 'settings_HostMessages'...")
                table = "CREATE TABLE [dbo].[settings_Profiles] ([Id] INT IDENTITY (1,1) NOT NULL, [ProfileName] VARCHAR(MAX) NOT NULL, [ProfileLocation] VARCHAR(MAX) NOT NULL, PRIMARY KEY CLUSTERED ([Id] ASC))"
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
