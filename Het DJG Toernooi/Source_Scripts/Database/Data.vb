Imports System.Data.SqlClient
Imports System.IO

Public Class Data

    Public Shared connectionString As New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30"))

    Public Shared Sub CreateDatabase()

        Dim dbPath As String = Application.StartupPath

        Dim nameToCreate As String = "dbMillionaire"

        CoreConsole.LogMsgDate("Database location: " + dbPath + "\" + nameToCreate + ".mdf")

        If File.Exists(dbPath + "\" + nameToCreate + ".mdf") = False Then
            connectionString.Open()
            CoreConsole.LogMsgDate("Database not found. Trying to create new file...")
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

            connectionString = New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", dbPath, nameToCreate))

            Try
                connectionString.Open()

                'Dropping Level 1
                Dim drop As String = "DROP TABLE questions_Level1;"
                Dim dropcmd As SqlCommand = New SqlCommand(drop, connectionString)
                Try
                    dropcmd.ExecuteNonQuery()
                Catch ex As Exception
                    CoreConsole.LogMsgDate("Level 1 table doesn't exist (yet).")
                End Try

                'Dropping Level 2
                drop = "DROP TABLE questions_Level2;"
                dropcmd = New SqlCommand(drop, connectionString)
                Try
                    dropcmd.ExecuteNonQuery()
                Catch ex As Exception
                    CoreConsole.LogMsgDate("Level 2 table doesn't exist (yet).")
                End Try

                'Dropping Level 3
                drop = "DROP TABLE questions_Level3;"
                dropcmd = New SqlCommand(drop, connectionString)
                Try
                    dropcmd.ExecuteNonQuery()
                Catch ex As Exception
                    CoreConsole.LogMsgDate("Level 3 table doesn't exist (yet).")
                End Try

                'Dropping Level 4 (Million question)
                drop = "DROP TABLE questions_Level4;"
                dropcmd = New SqlCommand(drop, connectionString)
                Try
                    dropcmd.ExecuteNonQuery()
                Catch ex As Exception
                    CoreConsole.LogMsgDate("Level 4 table doesn't exist (yet).")
                End Try

                'Dropping Level 0 (FFF)
                drop = "DROP TABLE questions_Level0;"
                dropcmd = New SqlCommand(drop, connectionString)
                Try
                    dropcmd.ExecuteNonQuery()
                Catch ex As Exception
                    CoreConsole.LogMsgDate("Level 0 table doesn't exist (yet).")
                End Try

                Dim tbLevel1 As String = "CREATE TABLE [dbo].[questions_Level1] (" +
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

                Dim tbLevel2 As String = "CREATE TABLE [dbo].[questions_Level2] (" +
                        "[Id] INT IDENTITY (1,1) NOT NULL," +
                        "[Question] TEXT NOT NULL," +
                        "[A] VARCHAR (50) NOT NULL," +
                        "[B] VARCHAR (50) NOT NULL," +
                        "[C] VARCHAR (50) NOT NULL," +
                        "[D] VARCHAR (50) NOT NULL," +
                        "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                        "[Type] VARCHAR (50) DEFAULT ('Lvl2') NOT NULL," +
                        "[Used] BIT NOT NULL DEFAULT 0," +
                        "[Note] TEXT NULL," +
                        "PRIMARY KEY CLUSTERED ([Id] ASC))"

                Dim tbLevel3 As String = "CREATE TABLE [dbo].[questions_Level3] (" +
                        "[Id] INT IDENTITY (1,1) NOT NULL," +
                        "[Question] TEXT NOT NULL," +
                        "[A] VARCHAR (50) NOT NULL," +
                        "[B] VARCHAR (50) NOT NULL," +
                        "[C] VARCHAR (50) NOT NULL," +
                        "[D] VARCHAR (50) NOT NULL," +
                        "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                        "[Type] VARCHAR (50) DEFAULT ('Lvl3') NOT NULL," +
                        "[Used] BIT NOT NULL DEFAULT 0," +
                        "[Note] TEXT NULL," +
                        "PRIMARY KEY CLUSTERED ([Id] ASC))"

                Dim tbLevel4 As String = "CREATE TABLE [dbo].[questions_Level4] (" +
                        "[Id] INT IDENTITY (1,1) NOT NULL," +
                        "[Question] TEXT NOT NULL," +
                        "[A] VARCHAR (50) NOT NULL," +
                        "[B] VARCHAR (50) NOT NULL," +
                        "[C] VARCHAR (50) NOT NULL," +
                        "[D] VARCHAR (50) NOT NULL," +
                        "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                        "[Type] VARCHAR (50) DEFAULT ('Lvl4') NOT NULL," +
                        "[Used] BIT NOT NULL DEFAULT 0," +
                        "[Note] TEXT NULL," +
                        "PRIMARY KEY CLUSTERED ([Id] ASC))"

                Dim tbLevel0 As String = "CREATE TABLE [dbo].[questions_Level0] (" +
                        "[Id] INT IDENTITY (1,1) NOT NULL," +
                        "[Question] TEXT NOT NULL," +
                        "[A] VARCHAR (50) NOT NULL," +
                        "[B] VARCHAR (50) NOT NULL," +
                        "[C] VARCHAR (50) NOT NULL," +
                        "[D] VARCHAR (50) NOT NULL," +
                        "[CorrectAnswer] VARCHAR (50) NOT NULL," +
                        "[Type] VARCHAR (50) DEFAULT ('Lvl0') NOT NULL," +
                        "[Used] BIT NOT NULL DEFAULT 0," +
                        "[Note] TEXT NULL," +
                        "PRIMARY KEY CLUSTERED ([Id] ASC))"

                Dim cmdLevel1 As SqlCommand = New SqlCommand(tbLevel1, connectionString)
                cmdLevel1.ExecuteNonQuery()
                Dim cmdLevel2 As SqlCommand = New SqlCommand(tbLevel2, connectionString)
                cmdLevel2.ExecuteNonQuery()
                Dim cmdLevel3 As SqlCommand = New SqlCommand(tbLevel3, connectionString)
                cmdLevel3.ExecuteNonQuery()
                Dim cmdLevel4 As SqlCommand = New SqlCommand(tbLevel4, connectionString)
                cmdLevel4.ExecuteNonQuery()
                Dim cmdLevel0 As SqlCommand = New SqlCommand(tbLevel0, connectionString)
                cmdLevel0.ExecuteNonQuery()

                CoreConsole.LogMsgDate("Tables in database " + nameToCreate + " created succesfully.")

            Catch ex As Exception
                CoreConsole.LogMsgDate("Error when creating tables in database:")
                CoreConsole.LogMsg(ex.Message)
            Finally
                connectionString.Close()
            End Try
        Else
            connectionString = New SqlConnection(String.Format("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\{1}.mdf;Integrated Security=True;Connect Timeout=30", dbPath, nameToCreate))

            Try
                connectionString.Open()
                CoreConsole.LogMsgDate("Succesfully connected to local database.")
            Catch ex As Exception
                CoreConsole.LogMsgDate("Error when connecting to database:")
                CoreConsole.LogMsg(ex.Message)
            Finally
                connectionString.Close()
            End Try
        End If

    End Sub

End Class
