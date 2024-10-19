Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class TreeInfo
    Public Property SafeNet_01 As Integer
    Public Property SafeNet_02 As Integer
    Public Property SafeNet_Risk As Integer
    Public Property SafeNet_FreeMode As Boolean

    Public Property Currency As String
    Public Property CurrencyAtSuffix As Boolean

    Public Property Level_01_Value As Integer
    Public Property Level_02_Value As Integer
    Public Property Level_03_Value As Integer
    Public Property Level_04_Value As Integer
    Public Property Level_05_Value As Integer
    Public Property Level_06_Value As Integer
    Public Property Level_07_Value As Integer
    Public Property Level_08_Value As Integer
    Public Property Level_09_Value As Integer
    Public Property Level_10_Value As Integer
    Public Property Level_11_Value As Integer
    Public Property Level_12_Value As Integer
    Public Property Level_13_Value As Integer
    Public Property Level_14_Value As Integer
    Public Property Level_15_Value As Integer
End Class

Public Class MoneyTreeSettings

    Dim filePath As String = "tree.xml"
    Public Shared TreeData As New TreeInfo

    Public Sub LoadSettings()
        If Not File.Exists(filePath) Then
            System.Threading.Thread.Sleep(100)
            SaveDefaultSettings()
        End If

        Dim loadedvalues As TreeInfo = DeserializeFromXml(filePath)

        If loadedvalues IsNot Nothing Then
            TreeData.SafeNet_01 = loadedvalues.SafeNet_01
            TreeData.SafeNet_02 = loadedvalues.SafeNet_02
            TreeData.SafeNet_Risk = loadedvalues.SafeNet_Risk
            TreeData.SafeNet_FreeMode = loadedvalues.SafeNet_FreeMode

            TreeData.Currency = loadedvalues.Currency
            TreeData.CurrencyAtSuffix = loadedvalues.CurrencyAtSuffix

            TreeData.Level_01_Value = loadedvalues.Level_01_Value
            TreeData.Level_02_Value = loadedvalues.Level_02_Value
            TreeData.Level_03_Value = loadedvalues.Level_03_Value
            TreeData.Level_04_Value = loadedvalues.Level_04_Value
            TreeData.Level_05_Value = loadedvalues.Level_05_Value
            TreeData.Level_06_Value = loadedvalues.Level_06_Value
            TreeData.Level_07_Value = loadedvalues.Level_07_Value
            TreeData.Level_08_Value = loadedvalues.Level_08_Value
            TreeData.Level_09_Value = loadedvalues.Level_09_Value
            TreeData.Level_10_Value = loadedvalues.Level_10_Value
            TreeData.Level_11_Value = loadedvalues.Level_11_Value
            TreeData.Level_12_Value = loadedvalues.Level_12_Value
            TreeData.Level_13_Value = loadedvalues.Level_13_Value
            TreeData.Level_14_Value = loadedvalues.Level_14_Value
            TreeData.Level_15_Value = loadedvalues.Level_15_Value
        Else

        End If

        Select Case TreeData.SafeNet_FreeMode
            Case True
                ControlPanel.btnSet2ndSafeNet.Visible = True
                ControlPanel.btnActivateRiskMode.Visible = False
            Case False
                ControlPanel.btnSet2ndSafeNet.Visible = False
                ControlPanel.btnActivateRiskMode.Visible = True
        End Select
    End Sub

    Public Sub SaveSettings()
        TreeData.SafeNet_01 = OptionsScreen.trk_TRs1.Value
        TreeData.SafeNet_02 = OptionsScreen.trk_TRs2.Value
        If OptionsScreen.rad_TRr1.Checked Then
            TreeData.SafeNet_Risk = 1
        ElseIf OptionsScreen.rad_TRr2.Checked Then
            TreeData.SafeNet_Risk = 2
        End If
        TreeData.SafeNet_FreeMode = OptionsScreen.chkOwnSafetyNet.Checked
        If OptionsScreen.radCPosLeft.Checked Then
            TreeData.CurrencyAtSuffix = False
        ElseIf OptionsScreen.radCPosRight.Created Then
            TreeData.CurrencyAtSuffix = True
        End If

        If OptionsScreen.rad_CUR_Euro.Checked Then
            TreeData.Currency = "€"
        ElseIf OptionsScreen.rad_CUR_Dollar.Checked Then
            TreeData.Currency = "$"
        ElseIf OptionsScreen.rad_CUR_Pound.Checked Then
            TreeData.Currency = "£"
        ElseIf OptionsScreen.rad_CUR_Yen.Checked Then
            TreeData.Currency = "¥"
        ElseIf OptionsScreen.rad_CUR_Other.Checked Then
            TreeData.Currency = OptionsScreen.txt_CUR_Other.Text
        End If

        TreeData.Level_01_Value = OptionsScreen.nmr_TR_01.Value
        TreeData.Level_02_Value = OptionsScreen.nmr_TR_02.Value
        TreeData.Level_03_Value = OptionsScreen.nmr_TR_03.Value
        TreeData.Level_04_Value = OptionsScreen.nmr_TR_04.Value
        TreeData.Level_05_Value = OptionsScreen.nmr_TR_05.Value
        TreeData.Level_06_Value = OptionsScreen.nmr_TR_06.Value
        TreeData.Level_07_Value = OptionsScreen.nmr_TR_07.Value
        TreeData.Level_08_Value = OptionsScreen.nmr_TR_08.Value
        TreeData.Level_09_Value = OptionsScreen.nmr_TR_09.Value
        TreeData.Level_10_Value = OptionsScreen.nmr_TR_10.Value
        TreeData.Level_11_Value = OptionsScreen.nmr_TR_11.Value
        TreeData.Level_12_Value = OptionsScreen.nmr_TR_12.Value
        TreeData.Level_13_Value = OptionsScreen.nmr_TR_13.Value
        TreeData.Level_14_Value = OptionsScreen.nmr_TR_14.Value
        TreeData.Level_15_Value = OptionsScreen.nmr_TR_15.Value

        SerializeToXml(TreeData, filePath)
    End Sub

    Private Sub SaveDefaultSettings()
        TreeData.SafeNet_01 = 5
        TreeData.SafeNet_02 = 10
        TreeData.SafeNet_Risk = 2
        TreeData.SafeNet_FreeMode = False

        TreeData.Currency = ""
        TreeData.CurrencyAtSuffix = False

        TreeData.Level_01_Value = 100
        TreeData.Level_02_Value = 200
        TreeData.Level_03_Value = 300
        TreeData.Level_04_Value = 500
        TreeData.Level_05_Value = 1000
        TreeData.Level_06_Value = 2000
        TreeData.Level_07_Value = 4000
        TreeData.Level_08_Value = 8000
        TreeData.Level_09_Value = 16000
        TreeData.Level_10_Value = 32000
        TreeData.Level_11_Value = 64000
        TreeData.Level_12_Value = 125000
        TreeData.Level_13_Value = 250000
        TreeData.Level_14_Value = 500000
        TreeData.Level_15_Value = 1000000

        SerializeToXml(TreeData, filePath)
    End Sub

    Sub SerializeToXml(settings As TreeInfo, filePath As String)
        ' Maak een XmlTextWriter om naar het bestand te schrijven
        Using writer As New XmlTextWriter(filePath, Nothing)
            ' Zorg voor nette opmaak van de XML
            writer.Formatting = Formatting.Indented

            ' Maak een XmlSerializer voor de AppSettings-klasse
            Dim serializer As New XmlSerializer(GetType(TreeInfo))

            ' Schrijf de instellingen naar het bestand
            serializer.Serialize(writer, settings)
        End Using
    End Sub

    Function DeserializeFromXml(filePath As String) As TreeInfo
        Try
            ' Maak een XmlTextReader om het bestand te lezen
            Using reader As New XmlTextReader(filePath)
                ' Maak een XmlSerializer voor de AppSettings-klasse
                Dim serializer As New XmlSerializer(GetType(TreeInfo))

                ' Deserialiseer de instellingen uit het bestand
                Dim settings As TreeInfo = DirectCast(serializer.Deserialize(reader), TreeInfo)

                Return settings
            End Using
        Catch ex As Exception
            ' Behandel fouten hier (bijv. bestand niet gevonden, ongeldige XML, etc.)
            Return Nothing
        End Try
    End Function
End Class
