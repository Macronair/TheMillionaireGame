Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class AppSettings
    Public Property RiskMode As Boolean
    Public Property Lifeline1 As Integer
    Public Property Lifeline2 As Integer
    Public Property Lifeline3 As Integer
    Public Property Lifeline4 As Integer
    Public Property WinningStrapTexture As Integer
    Public Property QuestionTexture As Integer

    Public Property FFF_Port As Integer

    Public Property FFF_Player1_Name As String
    Public Property FFF_Player2_Name As String
    Public Property FFF_Player3_Name As String
    Public Property FFF_Player4_Name As String
    Public Property FFF_Player5_Name As String
    Public Property FFF_Player6_Name As String
    Public Property FFF_Player7_Name As String
    Public Property FFF_Player8_Name As String

    Public Property snd_Opening As String
    Public Property snd_CommIn As String
    Public Property snd_CommOut As String
    Public Property snd_Closing As String
    Public Property snd_Lifeline1Ping As String
    Public Property snd_Lifeline2Ping As String
    Public Property snd_Lifeline3Ping As String
    Public Property snd_Lifeline4Ping As String
    Public Property snd_RiskModeActive As String
    Public Property snd_ExplainRules As String
    Public Property snd_ToHotSeat As String
    Public Property snd_ToHotSeat_LD As String
    Public Property snd_WalkAway1 As String
    Public Property snd_WalkAway2 As String
    Public Property snd_GameOver As String
    Public Property snd_F_Meet2 As String
    Public Property snd_F_Meet3 As String
    Public Property snd_F_Meet4 As String
    Public Property snd_F_Meet5 As String
    Public Property snd_F_Meet6 As String
    Public Property snd_F_Meet7 As String
    Public Property snd_F_Meet8 As String
    Public Property snd_F_ReadQuestion As String
    Public Property snd_F_ThreeNotes As String
    Public Property snd_F_Thinking As String
    Public Property snd_F_ReadCorrectOrder As String
    Public Property snd_F_Order1 As String
    Public Property snd_F_Order2 As String
    Public Property snd_F_Order3 As String
    Public Property snd_F_Order4 As String
    Public Property snd_F_WhoWasCorrect As String
    Public Property snd_F_Winner As String
    Public Property snd_ATA_Start As String
    Public Property snd_ATA_Voting As String
    Public Property snd_ATA_End As String
    Public Property snd_P1_Start As String
    Public Property snd_P1_Clock As String
    Public Property snd_P1_EndEarly As String
    Public Property snd_Switch0_Activate As String
    Public Property snd_Switch0_ShowCorrect As String
    Public Property snd_Switch0_Clear As String
    Public Property snd_5050 As String

    Public Property snd_Q1to5LightsDown As String
    Public Property snd_Q6LightsDown As String
    Public Property snd_Q7LightsDown As String
    Public Property snd_Q8LightsDown As String
    Public Property snd_Q9LightsDown As String
    Public Property snd_Q10LightsDown As String
    Public Property snd_Q11LightsDown As String
    Public Property snd_Q12LightsDown As String
    Public Property snd_Q13LightsDown As String
    Public Property snd_Q14LightsDown As String
    Public Property snd_Q15LightsDown As String

    Public Property snd_Q1to5Bed As String
    Public Property snd_Q6Bed As String
    Public Property snd_Q7Bed As String
    Public Property snd_Q8Bed As String
    Public Property snd_Q9Bed As String
    Public Property snd_Q10Bed As String
    Public Property snd_Q11Bed As String
    Public Property snd_Q12Bed As String
    Public Property snd_Q13Bed As String
    Public Property snd_Q14Bed As String
    Public Property snd_Q15Bed As String

    Public Property snd_Q1Final As String
    Public Property snd_Q2Final As String
    Public Property snd_Q3Final As String
    Public Property snd_Q4Final As String
    Public Property snd_Q5Final As String
    Public Property snd_Q6Final As String
    Public Property snd_Q7Final As String
    Public Property snd_Q8Final As String
    Public Property snd_Q9Final As String
    Public Property snd_Q10Final As String
    Public Property snd_Q11Final As String
    Public Property snd_Q12Final As String
    Public Property snd_Q13Final As String
    Public Property snd_Q14Final As String
    Public Property snd_Q15Final As String

    Public Property snd_Q1to4Correct As String
    Public Property snd_Q5Correct As String
    Public Property snd_Q6Correct As String
    Public Property snd_Q7Correct As String
    Public Property snd_Q8Correct As String
    Public Property snd_Q9Correct As String
    Public Property snd_Q10Correct As String
    Public Property snd_Q10Correct_R As String
    Public Property snd_Q11Correct As String
    Public Property snd_Q12Correct As String
    Public Property snd_Q13Correct As String
    Public Property snd_Q14Correct As String
    Public Property snd_Q15Correct As String

    Public Property snd_Q1to5Wrong As String
    Public Property snd_Q6Wrong As String
    Public Property snd_Q7Wrong As String
    Public Property snd_Q8Wrong As String
    Public Property snd_Q9Wrong As String
    Public Property snd_Q10Wrong As String
    Public Property snd_Q11Wrong As String
    Public Property snd_Q12Wrong As String
    Public Property snd_Q13Wrong As String
    Public Property snd_Q14Wrong As String
    Public Property snd_Q15Wrong As String
End Class

Public Class Profile

    Dim filePath As String = "config.xml"
    Public Shared Options As New AppSettings

    Public Sub LoadSettings()
        If Not File.Exists(filePath) Then
            System.Threading.Thread.Sleep(100)
            SaveFefaultSettings()
        End If

        Dim loadedvalues As AppSettings = DeserializeFromXml(filePath)

        If loadedvalues IsNot Nothing Then
            Options.snd_Opening = loadedvalues.snd_Opening
            Options.snd_CommIn = loadedvalues.snd_CommIn
            Options.snd_CommOut = loadedvalues.snd_CommOut
            Options.snd_Closing = loadedvalues.snd_Closing
            Options.snd_Lifeline1Ping = loadedvalues.snd_Lifeline1Ping
            Options.snd_Lifeline2Ping = loadedvalues.snd_Lifeline2Ping
            Options.snd_Lifeline3Ping = loadedvalues.snd_Lifeline3Ping
            Options.snd_Lifeline4Ping = loadedvalues.snd_Lifeline4Ping
            Options.snd_RiskModeActive = loadedvalues.snd_RiskModeActive
            Options.snd_ExplainRules = loadedvalues.snd_ExplainRules
            Options.snd_ToHotSeat = loadedvalues.snd_ToHotSeat
            Options.snd_ToHotSeat_LD = loadedvalues.snd_ToHotSeat_LD
            Options.snd_WalkAway1 = loadedvalues.snd_WalkAway1
            Options.snd_WalkAway2 = loadedvalues.snd_WalkAway2
            Options.snd_GameOver = loadedvalues.snd_GameOver
            Options.snd_F_Meet2 = loadedvalues.snd_F_Meet2
            Options.snd_F_Meet3 = loadedvalues.snd_F_Meet3
            Options.snd_F_Meet4 = loadedvalues.snd_F_Meet4
            Options.snd_F_Meet5 = loadedvalues.snd_F_Meet5
            Options.snd_F_Meet6 = loadedvalues.snd_F_Meet6
            Options.snd_F_Meet7 = loadedvalues.snd_F_Meet7
            Options.snd_F_Meet8 = loadedvalues.snd_F_Meet8
            Options.snd_F_ReadQuestion = loadedvalues.snd_F_ReadQuestion
            Options.snd_F_ThreeNotes = loadedvalues.snd_F_ThreeNotes
            Options.snd_F_Thinking = loadedvalues.snd_F_Thinking
            Options.snd_F_ReadCorrectOrder = loadedvalues.snd_F_ReadCorrectOrder
            Options.snd_F_Order1 = loadedvalues.snd_F_Order1
            Options.snd_F_Order2 = loadedvalues.snd_F_Order2
            Options.snd_F_Order3 = loadedvalues.snd_F_Order3
            Options.snd_F_Order4 = loadedvalues.snd_F_Order4
            Options.snd_F_WhoWasCorrect = loadedvalues.snd_F_WhoWasCorrect
            Options.snd_F_Winner = loadedvalues.snd_F_Winner
            Options.snd_ATA_Start = loadedvalues.snd_ATA_Start
            Options.snd_ATA_Voting = loadedvalues.snd_ATA_Voting
            Options.snd_ATA_End = loadedvalues.snd_ATA_End
            Options.snd_P1_Start = loadedvalues.snd_P1_Start
            Options.snd_P1_Clock = loadedvalues.snd_P1_Clock
            Options.snd_P1_EndEarly = loadedvalues.snd_P1_EndEarly
            Options.snd_Switch0_Activate = loadedvalues.snd_Switch0_Activate
            Options.snd_Switch0_ShowCorrect = loadedvalues.snd_Switch0_ShowCorrect
            Options.snd_Switch0_Clear = loadedvalues.snd_Switch0_Clear
            Options.snd_5050 = loadedvalues.snd_5050
        Else

        End If

    End Sub

    Private Sub SaveFefaultSettings()
        Options.snd_Opening = "host_entrance.mp3"
        Options.snd_CommIn = "commercial_in.mp3"
        Options.snd_CommOut = "commercial_out.mp3"
        Options.snd_Closing = "close_theme.mp3"
        Options.snd_Lifeline1Ping = "lifeline_1_on.mp3"
        Options.snd_Lifeline2Ping = "lifeline_2_on.mp3"
        Options.snd_Lifeline3Ping = "lifeline_3_on.mp3"
        Options.snd_Lifeline4Ping = "lifeline_4_on.mp3"
        Options.snd_RiskModeActive = "lifeline_4_on.mp3"
        Options.snd_ExplainRules = "game_resume.mp3"
        Options.snd_ToHotSeat = "hello_long.mp3"
        Options.snd_ToHotSeat_LD = "lights_down_classic.mp3"
        Options.snd_F_Meet2 = "fastest_finger_contestants_2.mp3"
        Options.snd_F_Meet3 = "fastest_finger_contestants_3.mp3"
        Options.snd_F_Meet4 = "fastest_finger_contestants_4.mp3"
        Options.snd_F_Meet5 = "fastest_finger_contestants_5.mp3"
        Options.snd_F_Meet6 = "fastest_finger_contestants_6.mp3"
        Options.snd_F_Meet7 = "fastest_finger_contestants_7.mp3"
        Options.snd_F_Meet8 = "fastest_finger_contestants_8.mp3"
        Options.snd_F_ReadQuestion = "fastest_finger_read_question.mp3"
        Options.snd_F_ThreeNotes = "fastest_finger_3_stabs.mp3"
        Options.snd_F_Thinking = "fastest_finger_read_think.mp3"
        Options.snd_F_ReadCorrectOrder = "fastest_finger_read_answer_order.mp3"
        Options.snd_F_Order1 = "fastest_finger_answer_correct_1.mp3"
        Options.snd_F_Order2 = "fastest_finger_answer_correct_2.mp3"
        Options.snd_F_Order3 = "fastest_finger_answer_correct_3.mp3"
        Options.snd_F_Order4 = "fastest_finger_answer_correct_4.mp3"
        Options.snd_F_WhoWasCorrect = "fastest_finger_reveal_times.mp3"
        Options.snd_F_Winner = "fastest_finger_winner.mp3"
        Options.snd_ATA_Start = "ata_start.mp3"
        Options.snd_ATA_Voting = "ata_vote.mp3"
        Options.snd_ATA_End = "ata_end.mp3"
        Options.snd_P1_Start = "paf_start.mp3"
        Options.snd_P1_Clock = "pad_clock.mp3"
        Options.snd_P1_EndEarly = "paf_end_call_early.mp3"
        Options.snd_Switch0_Activate = "lifeline_4_on.mp3"
        Options.snd_Switch0_ShowCorrect = "stq_reveal_correct_answer.mp3"
        Options.snd_Switch0_Clear = "stq_new_question_flip.mp3"
        Options.snd_5050 = "fifty_fifty.mp3"

        SerializeToXml(Options, filePath)

    End Sub

    Sub SerializeToXml(settings As AppSettings, filePath As String)
        ' Maak een XmlTextWriter om naar het bestand te schrijven
        Using writer As New XmlTextWriter(filePath, Nothing)
            ' Zorg voor nette opmaak van de XML
            writer.Formatting = Formatting.Indented

            ' Maak een XmlSerializer voor de AppSettings-klasse
            Dim serializer As New XmlSerializer(GetType(AppSettings))

            ' Schrijf de instellingen naar het bestand
            serializer.Serialize(writer, settings)
        End Using
    End Sub

    Function DeserializeFromXml(filePath As String) As AppSettings
        Try
            ' Maak een XmlTextReader om het bestand te lezen
            Using reader As New XmlTextReader(filePath)
                ' Maak een XmlSerializer voor de AppSettings-klasse
                Dim serializer As New XmlSerializer(GetType(AppSettings))

                ' Deserialiseer de instellingen uit het bestand
                Dim settings As AppSettings = DirectCast(serializer.Deserialize(reader), AppSettings)

                Return settings
            End Using
        Catch ex As Exception
            ' Behandel fouten hier (bijv. bestand niet gevonden, ongeldige XML, etc.)
            Return Nothing
        End Try
    End Function

End Class
