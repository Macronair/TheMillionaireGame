Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class SQLInfo
    Public Property UseRemoteServer As Boolean
    Public Property UseLocalDB As Boolean
    Public Property lSQL_Instance As String
    Public Property rSQL_Server As String
    Public Property rSQL_Port As Integer
    Public Property rSQL_Database As String
    Public Property rSQL_Login As String
    Public Property rSQL_Password As String
    Public Property HideAtStart As Boolean
End Class

Public Class SQLSettings

    Dim filePath As String = "sql.xml"
    Public Shared SQLInfo As New SQLInfo

    Public Sub LoadSettings()
        If Not File.Exists(filePath) Then
            System.Threading.Thread.Sleep(100)
            SaveDefaultSettings()
        End If

        Dim loadedvalues As SQLInfo = DeserializeFromXml(filePath)

        If loadedvalues IsNot Nothing Then
            SQLInfo.UseRemoteServer = loadedvalues.UseRemoteServer
            SQLInfo.UseLocalDB = loadedvalues.UseLocalDB
            SQLInfo.lSQL_Instance = loadedvalues.lSQL_Instance
            SQLInfo.rSQL_Server = loadedvalues.rSQL_Server
            SQLInfo.rSQL_Port = loadedvalues.rSQL_Port
            SQLInfo.rSQL_Database = loadedvalues.rSQL_Database
            SQLInfo.rSQL_Login = loadedvalues.rSQL_Login
            SQLInfo.rSQL_Password = loadedvalues.rSQL_Password
            SQLInfo.HideAtStart = loadedvalues.HideAtStart
        Else

        End If
    End Sub

    Public Sub SaveSettings()
        If SQLLogin.radSQLLocal.Checked Then
            SQLInfo.UseRemoteServer = False
        ElseIf SQLLogin.radSQLRemote.Checked Then
            SQLInfo.UseRemoteServer = True
        End If

        If SQLLogin.chkUseLocalDB.Checked = True Then
            SQLInfo.UseLocalDB = True
        Else
            SQLInfo.UseLocalDB = False
        End If

        SQLInfo.lSQL_Instance = SQLInfo.lSQL_Instance
        SQLInfo.rSQL_Server = SQLLogin.txtSQLR_ServerInstance.Text
        SQLInfo.rSQL_Port = SQLLogin.txtSQLR_Port.Value
        SQLInfo.rSQL_Database = SQLLogin.txtSQLR_Database.Text
        SQLInfo.rSQL_Login = SQLLogin.txtSQLR_Username.Text
        SQLInfo.rSQL_Password = SQLLogin.txtSQLR_Password.Text

        SQLInfo.HideAtStart = SQLLogin.chkHideAtStart.Checked

        SerializeToXml(SQLInfo, filePath)
    End Sub

    Private Sub SaveDefaultSettings()
        SQLInfo.UseRemoteServer = False
        SQLInfo.UseLocalDB = False
        SQLInfo.lSQL_Instance = "SQLEXPRESS"

        SQLInfo.rSQL_Server = ""
        SQLInfo.rSQL_Port = 3306
        SQLInfo.rSQL_Database = ""
        SQLInfo.rSQL_Login = ""
        SQLInfo.rSQL_Password = ""

        SQLInfo.HideAtStart = False

        SerializeToXml(SQLInfo, filePath)
    End Sub

    Sub SerializeToXml(settings As SQLInfo, filePath As String)
        ' Maak een XmlTextWriter om naar het bestand te schrijven
        Using writer As New XmlTextWriter(filePath, Nothing)
            ' Zorg voor nette opmaak van de XML
            writer.Formatting = Formatting.Indented

            ' Maak een XmlSerializer voor de AppSettings-klasse
            Dim serializer As New XmlSerializer(GetType(SQLInfo))

            ' Schrijf de instellingen naar het bestand
            serializer.Serialize(writer, settings)
        End Using
    End Sub

    Function DeserializeFromXml(filePath As String) As SQLInfo
        Try
            ' Maak een XmlTextReader om het bestand te lezen
            Using reader As New XmlTextReader(filePath)
                ' Maak een XmlSerializer voor de AppSettings-klasse
                Dim serializer As New XmlSerializer(GetType(SQLInfo))

                ' Deserialiseer de instellingen uit het bestand
                Dim settings As SQLInfo = DirectCast(serializer.Deserialize(reader), SQLInfo)

                Return settings
            End Using
        Catch ex As Exception
            ' Behandel fouten hier (bijv. bestand niet gevonden, ongeldige XML, etc.)
            Return Nothing
        End Try
    End Function

End Class
