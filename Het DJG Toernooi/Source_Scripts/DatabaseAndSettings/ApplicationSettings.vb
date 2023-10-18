Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class AppSettings
    Public Property TotalLifelines As Integer
    Public Property Lifeline1 As String
    Public Property Lifeline2 As String
    Public Property Lifeline3 As String
    Public Property Lifeline4 As String
    Public Property Lifeline1_available As Integer
    Public Property Lifeline2_available As Integer
    Public Property Lifeline3_available As Integer
    Public Property Lifeline4_available As Integer

    Public Property WinningStrapTexture As Integer

    Public Property Resolution_HostScreen As String
    Public Property Resolution_GuestScreen As String
    Public Property Resolution_TVScreen As String
    Public Property FullScreen_HostScreen_Enable As Boolean
    Public Property FullScreen_HostScreen_Monitor As Integer
    Public Property FullScreen_GuestScreen_Enable As Boolean
    Public Property FullScreen_GuestScreen_Monitor As Integer
    Public Property FullScreen_TVScreen_Enable As Boolean
    Public Property FullScreen_TVScreen_Monitor As Integer

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
    Public Property snd_Double_1stAnswer As String
    Public Property snd_Double_1stFinal As String
    Public Property snd_Double_2ndAnswer As String
    Public Property snd_Double_2ndFinal As String
    Public Property snd_Switch0_Activate As String
    Public Property snd_Switch0_ShowCorrect As String
    Public Property snd_Switch0_Clear As String
    Public Property snd_5050 As String

    Public Property snd_Q1to5LightsDown As String
    Public Property snd_Q1to5LightsDown_Stop As Boolean
    Public Property snd_Q6LightsDown As String
    Public Property snd_Q6LightsDown_Stop As Boolean
    Public Property snd_Q7LightsDown As String
    Public Property snd_Q7LightsDown_Stop As Boolean
    Public Property snd_Q8LightsDown As String
    Public Property snd_Q8LightsDown_Stop As Boolean
    Public Property snd_Q9LightsDown As String
    Public Property snd_Q9LightsDown_Stop As Boolean
    Public Property snd_Q10LightsDown As String
    Public Property snd_Q10LightsDown_Stop As Boolean
    Public Property snd_Q11LightsDown As String
    Public Property snd_Q11LightsDown_Stop As Boolean
    Public Property snd_Q12LightsDown As String
    Public Property snd_Q12LightsDown_Stop As Boolean
    Public Property snd_Q13LightsDown As String
    Public Property snd_Q13LightsDown_Stop As Boolean
    Public Property snd_Q14LightsDown As String
    Public Property snd_Q14LightsDown_Stop As Boolean
    Public Property snd_Q15LightsDown As String
    Public Property snd_Q15LightsDown_Stop As Boolean

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
            Options.TotalLifelines = loadedvalues.TotalLifelines
            Options.Lifeline1 = loadedvalues.Lifeline1
            Options.Lifeline2 = loadedvalues.Lifeline2
            Options.Lifeline3 = loadedvalues.Lifeline3
            Options.Lifeline4 = loadedvalues.Lifeline4
            Options.Lifeline1_available = loadedvalues.Lifeline1_available
            Options.Lifeline2_available = loadedvalues.Lifeline2_available
            Options.Lifeline3_available = loadedvalues.Lifeline3_available
            Options.Lifeline4_available = loadedvalues.Lifeline4_available

            Options.WinningStrapTexture = loadedvalues.WinningStrapTexture

            Options.Resolution_HostScreen = loadedvalues.Resolution_HostScreen
            Options.Resolution_GuestScreen = loadedvalues.Resolution_GuestScreen
            Options.Resolution_TVScreen = loadedvalues.Resolution_TVScreen
            Options.FullScreen_HostScreen_Enable = loadedvalues.FullScreen_HostScreen_Enable
            Options.FullScreen_HostScreen_Monitor = loadedvalues.FullScreen_HostScreen_Monitor
            Options.FullScreen_GuestScreen_Enable = loadedvalues.FullScreen_GuestScreen_Enable
            Options.FullScreen_GuestScreen_Monitor = loadedvalues.FullScreen_GuestScreen_Monitor
            Options.FullScreen_TVScreen_Enable = loadedvalues.FullScreen_TVScreen_Enable
            Options.FullScreen_TVScreen_Monitor = loadedvalues.FullScreen_TVScreen_Monitor

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
            Options.snd_Double_1stAnswer = loadedvalues.snd_Double_1stAnswer
            Options.snd_Double_1stFinal = loadedvalues.snd_Double_1stFinal
            Options.snd_Double_2ndAnswer = loadedvalues.snd_Double_2ndAnswer
            Options.snd_Double_2ndFinal = loadedvalues.snd_Double_2ndFinal
            Options.snd_Switch0_Activate = loadedvalues.snd_Switch0_Activate
            Options.snd_Switch0_ShowCorrect = loadedvalues.snd_Switch0_ShowCorrect
            Options.snd_Switch0_Clear = loadedvalues.snd_Switch0_Clear
            Options.snd_5050 = loadedvalues.snd_5050

            Options.snd_Q1to5LightsDown = loadedvalues.snd_Q1to5LightsDown
            Options.snd_Q6LightsDown = loadedvalues.snd_Q6LightsDown
            Options.snd_Q7LightsDown = loadedvalues.snd_Q7LightsDown
            Options.snd_Q8LightsDown = loadedvalues.snd_Q8LightsDown
            Options.snd_Q9LightsDown = loadedvalues.snd_Q9LightsDown
            Options.snd_Q10LightsDown = loadedvalues.snd_Q10LightsDown
            Options.snd_Q11LightsDown = loadedvalues.snd_Q11LightsDown
            Options.snd_Q12LightsDown = loadedvalues.snd_Q12LightsDown
            Options.snd_Q13LightsDown = loadedvalues.snd_Q13LightsDown
            Options.snd_Q14LightsDown = loadedvalues.snd_Q14LightsDown
            Options.snd_Q15LightsDown = loadedvalues.snd_Q15LightsDown

            Options.snd_Q1to5LightsDown_Stop = loadedvalues.snd_Q1to5LightsDown_Stop
            Options.snd_Q6LightsDown_Stop = loadedvalues.snd_Q6LightsDown_Stop
            Options.snd_Q7LightsDown_Stop = loadedvalues.snd_Q7LightsDown_Stop
            Options.snd_Q8LightsDown_Stop = loadedvalues.snd_Q8LightsDown_Stop
            Options.snd_Q9LightsDown_Stop = loadedvalues.snd_Q9LightsDown_Stop
            Options.snd_Q10LightsDown_Stop = loadedvalues.snd_Q10LightsDown_Stop
            Options.snd_Q11LightsDown_Stop = loadedvalues.snd_Q11LightsDown_Stop
            Options.snd_Q12LightsDown_Stop = loadedvalues.snd_Q12LightsDown_Stop
            Options.snd_Q13LightsDown_Stop = loadedvalues.snd_Q13LightsDown_Stop
            Options.snd_Q14LightsDown_Stop = loadedvalues.snd_Q14LightsDown_Stop
            Options.snd_Q15LightsDown_Stop = loadedvalues.snd_Q15LightsDown_Stop

            Options.snd_Q1to5Bed = loadedvalues.snd_Q1to5Bed
            Options.snd_Q6Bed = loadedvalues.snd_Q6Bed
            Options.snd_Q7Bed = loadedvalues.snd_Q7Bed
            Options.snd_Q8Bed = loadedvalues.snd_Q8Bed
            Options.snd_Q9Bed = loadedvalues.snd_Q9Bed
            Options.snd_Q10Bed = loadedvalues.snd_Q10Bed
            Options.snd_Q11Bed = loadedvalues.snd_Q11Bed
            Options.snd_Q12Bed = loadedvalues.snd_Q12Bed
            Options.snd_Q13Bed = loadedvalues.snd_Q13Bed
            Options.snd_Q14Bed = loadedvalues.snd_Q14Bed
            Options.snd_Q15Bed = loadedvalues.snd_Q15Bed

            Options.snd_Q1Final = loadedvalues.snd_Q1Final
            Options.snd_Q2Final = loadedvalues.snd_Q2Final
            Options.snd_Q3Final = loadedvalues.snd_Q3Final
            Options.snd_Q4Final = loadedvalues.snd_Q4Final
            Options.snd_Q5Final = loadedvalues.snd_Q5Final
            Options.snd_Q6Final = loadedvalues.snd_Q6Final
            Options.snd_Q7Final = loadedvalues.snd_Q7Final
            Options.snd_Q8Final = loadedvalues.snd_Q8Final
            Options.snd_Q9Final = loadedvalues.snd_Q9Final
            Options.snd_Q10Final = loadedvalues.snd_Q10Final
            Options.snd_Q11Final = loadedvalues.snd_Q11Final
            Options.snd_Q12Final = loadedvalues.snd_Q12Final
            Options.snd_Q13Final = loadedvalues.snd_Q13Final
            Options.snd_Q14Final = loadedvalues.snd_Q14Final
            Options.snd_Q15Final = loadedvalues.snd_Q15Final

            Options.snd_Q1to4Correct = loadedvalues.snd_Q1to4Correct
            Options.snd_Q5Correct = loadedvalues.snd_Q5Correct
            Options.snd_Q6Correct = loadedvalues.snd_Q6Correct
            Options.snd_Q7Correct = loadedvalues.snd_Q7Correct
            Options.snd_Q8Correct = loadedvalues.snd_Q8Correct
            Options.snd_Q9Correct = loadedvalues.snd_Q9Correct
            Options.snd_Q10Correct = loadedvalues.snd_Q10Correct
            Options.snd_Q10Correct_R = loadedvalues.snd_Q10Correct_R
            Options.snd_Q11Correct = loadedvalues.snd_Q11Correct
            Options.snd_Q12Correct = loadedvalues.snd_Q12Correct
            Options.snd_Q13Correct = loadedvalues.snd_Q13Correct
            Options.snd_Q14Correct = loadedvalues.snd_Q14Correct
            Options.snd_Q15Correct = loadedvalues.snd_Q15Correct

            Options.snd_Q1to5Wrong = loadedvalues.snd_Q1to5Wrong
            Options.snd_Q6Wrong = loadedvalues.snd_Q6Wrong
            Options.snd_Q7Wrong = loadedvalues.snd_Q7Wrong
            Options.snd_Q8Wrong = loadedvalues.snd_Q8Wrong
            Options.snd_Q9Wrong = loadedvalues.snd_Q9Wrong
            Options.snd_Q10Wrong = loadedvalues.snd_Q10Wrong
            Options.snd_Q11Wrong = loadedvalues.snd_Q11Wrong
            Options.snd_Q12Wrong = loadedvalues.snd_Q12Wrong
            Options.snd_Q13Wrong = loadedvalues.snd_Q13Wrong
            Options.snd_Q14Wrong = loadedvalues.snd_Q14Wrong
            Options.snd_Q15Wrong = loadedvalues.snd_Q15Wrong
        Else

        End If

    End Sub

    Private Sub SaveFefaultSettings()
        Options.TotalLifelines = 4
        Options.Lifeline1 = "ask_audience"
        Options.Lifeline2 = "50_50"
        Options.Lifeline3 = "switch"
        Options.Lifeline4 = "ask_host"
        Options.Lifeline1_available = 0
        Options.Lifeline2_available = 0
        Options.Lifeline3_available = 0
        Options.Lifeline4_available = 3

        Options.WinningStrapTexture = 0

        Options.Resolution_HostScreen = "1280x720"
        Options.Resolution_GuestScreen = "1280x720"
        Options.Resolution_TVScreen = "1280x720"
        Options.FullScreen_HostScreen_Enable = False
        Options.FullScreen_HostScreen_Monitor = 0
        Options.FullScreen_GuestScreen_Enable = False
        Options.FullScreen_GuestScreen_Monitor = 0
        Options.FullScreen_TVScreen_Enable = False
        Options.FullScreen_TVScreen_Monitor = 0

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
        Options.snd_WalkAway1 = "quit_small.mp3"
        Options.snd_WalkAway2 = "quit_large.mp3"
        Options.snd_GameOver = "walk_away_small.mp3"
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
        Options.snd_Double_1stAnswer = "doubledip_start.mp3"
        Options.snd_Double_1stFinal = "doubledip_final1.mp3"
        Options.snd_Double_2ndAnswer = "doubledip_wrong.mp3"
        Options.snd_Double_2ndFinal = "doubledip_final1.mp3"
        Options.snd_Switch0_Activate = "lifeline_4_on.mp3"
        Options.snd_Switch0_ShowCorrect = "stq_reveal_correct_answer.mp3"
        Options.snd_Switch0_Clear = "stq_new_question_flip.mp3"
        Options.snd_5050 = "fifty_fifty.mp3"

        Options.snd_Q1to5LightsDown = "q1_to_q5_lights_down.mp3"
        Options.snd_Q6LightsDown = "lights_down_classic.mp3"
        Options.snd_Q7LightsDown = "lights_down_2.mp3"
        Options.snd_Q8LightsDown = "lights_down_3.mp3"
        Options.snd_Q9LightsDown = "lights_down_4.mp3"
        Options.snd_Q10LightsDown = "lights_down_5.mp3"
        Options.snd_Q11LightsDown = "lights_down_classic.mp3"
        Options.snd_Q12LightsDown = "lights_down_2.mp3"
        Options.snd_Q13LightsDown = "lights_down_3.mp3"
        Options.snd_Q14LightsDown = "lights_down_4.mp3"
        Options.snd_Q15LightsDown = "lights_down_5.mp3"
        Options.snd_Q1to5LightsDown_Stop = False
        Options.snd_Q6LightsDown_Stop = False
        Options.snd_Q7LightsDown_Stop = True
        Options.snd_Q8LightsDown_Stop = True
        Options.snd_Q9LightsDown_Stop = True
        Options.snd_Q10LightsDown_Stop = True
        Options.snd_Q11LightsDown_Stop = False
        Options.snd_Q12LightsDown_Stop = True
        Options.snd_Q13LightsDown_Stop = True
        Options.snd_Q14LightsDown_Stop = True
        Options.snd_Q15LightsDown_Stop = True

        Options.snd_Q1to5Bed = "q1_to_q5_bed.mp3"
        Options.snd_Q6Bed = "q6_bed.mp3"
        Options.snd_Q7Bed = "q7_bed.mp3"
        Options.snd_Q8Bed = "q8_bed.mp3"
        Options.snd_Q9Bed = "q9_bed.mp3"
        Options.snd_Q10Bed = "q10_bed.mp3"
        Options.snd_Q11Bed = "q11_bed.mp3"
        Options.snd_Q12Bed = "q12_bed.mp3"
        Options.snd_Q13Bed = "q13_bed.mp3"
        Options.snd_Q14Bed = "q14_bed.mp3"
        Options.snd_Q15Bed = "q15_bed.mp3"

        Options.snd_Q1Final = ""
        Options.snd_Q2Final = ""
        Options.snd_Q3Final = ""
        Options.snd_Q4Final = ""
        Options.snd_Q5Final = ""
        Options.snd_Q6Final = "final_answer_1.mp3"
        Options.snd_Q7Final = "final_answer_2.mp3"
        Options.snd_Q8Final = "final_answer_3.mp3"
        Options.snd_Q9Final = "final_answer_4.mp3"
        Options.snd_Q10Final = "final_answer_5.mp3"
        Options.snd_Q11Final = "final_answer_1.mp3"
        Options.snd_Q12Final = "final_answer_2.mp3"
        Options.snd_Q13Final = "final_answer_3.mp3"
        Options.snd_Q14Final = "final_answer_4.mp3"
        Options.snd_Q15Final = "final_answer_5.mp3"

        Options.snd_Q1to4Correct = "q1_to_q4_correct.mp3"
        Options.snd_Q5Correct = "q5_correct.mp3"
        Options.snd_Q6Correct = "q6_correct.mp3"
        Options.snd_Q7Correct = "q7_correct.mp3"
        Options.snd_Q8Correct = "q8_correct.mp3"
        Options.snd_Q9Correct = "q9_correct.mp3"
        Options.snd_Q10Correct = "q10_correct.mp3"
        Options.snd_Q10Correct_R = "q10_correct_2.mp3"
        Options.snd_Q11Correct = "q11_correct.mp3"
        Options.snd_Q12Correct = "q12_correct.mp3"
        Options.snd_Q13Correct = "q13_correct.mp3"
        Options.snd_Q14Correct = "q14_correct.mp3"
        Options.snd_Q15Correct = "q15_correct.mp3"

        Options.snd_Q1to5Wrong = "q1_to_q5_lose.mp3"
        Options.snd_Q6Wrong = "q6_lose.mp3"
        Options.snd_Q7Wrong = "q7_lose.mp3"
        Options.snd_Q8Wrong = "q8_lose.mp3"
        Options.snd_Q9Wrong = "q9_lose.mp3"
        Options.snd_Q10Wrong = "q10_lose.mp3"
        Options.snd_Q11Wrong = "q11_lose.mp3"
        Options.snd_Q12Wrong = "q12_lose.mp3"
        Options.snd_Q13Wrong = "q13_lose.mp3"
        Options.snd_Q14Wrong = "q14_lose.mp3"
        Options.snd_Q15Wrong = "q15_lose.mp3"

        SerializeToXml(Options, filePath)

    End Sub

    Public Sub SaveSettings()
        Options.TotalLifelines = OptionsScreen.nmrTotalLifelines.Text
        Options.Lifeline1 = OptionsScreen.cmbLifeline1.Text
        Options.Lifeline2 = OptionsScreen.cmbLifeline2.Text
        Options.Lifeline3 = OptionsScreen.cmbLifeline3.Text
        Options.Lifeline4 = OptionsScreen.cmbLifeline4.Text
        Options.Lifeline1_available = OptionsScreen.Lifeline1_availableAt
        Options.Lifeline2_available = OptionsScreen.Lifeline2_availableAt
        Options.Lifeline3_available = OptionsScreen.Lifeline3_availableAt
        Options.Lifeline4_available = OptionsScreen.Lifeline4_availableAt

        Options.WinningStrapTexture = OptionsScreen.WinningStrapTexture

        Options.Resolution_HostScreen = OptionsScreen.cmbResHostScreen.Text
        Options.Resolution_GuestScreen = OptionsScreen.cmbResGuestScreen.Text
        Options.Resolution_TVScreen = OptionsScreen.cmbResTVScreen.Text
        Options.FullScreen_HostScreen_Enable = OptionsScreen.chkFullScrHostScreen.Checked
        Options.FullScreen_GuestScreen_Enable = OptionsScreen.chkFullScrGuestScreen.Checked
        Options.FullScreen_TVScreen_Enable = OptionsScreen.chkFullScrTVScreen.Checked
        Options.FullScreen_HostScreen_Monitor = Convert.ToInt32(OptionsScreen.cmbFullScrHostScreen.Text.First)
        Options.FullScreen_GuestScreen_Monitor = Convert.ToInt32(OptionsScreen.cmbFullScrHostScreen.Text.First)
        Options.FullScreen_TVScreen_Monitor = Convert.ToInt32(OptionsScreen.cmbFullScrHostScreen.Text.First)

        Options.snd_Opening = OptionsScreen.txtSndOpening.Text
        Options.snd_CommIn = OptionsScreen.txtSndCommercialIn.Text
        Options.snd_CommOut = OptionsScreen.txtSndCommercialOut.Text
        Options.snd_Closing = OptionsScreen.txtSndClosing.Text
        Options.snd_Lifeline1Ping = OptionsScreen.txtSndLifeline1Ping.Text
        Options.snd_Lifeline2Ping = OptionsScreen.txtSndLifeline2Ping.Text
        Options.snd_Lifeline3Ping = OptionsScreen.txtSndLifeline3Ping.Text
        Options.snd_Lifeline4Ping = OptionsScreen.txtSndLifeline4Ping.Text
        Options.snd_RiskModeActive = OptionsScreen.txtSndRiskModeActivate.Text
        Options.snd_ExplainRules = OptionsScreen.txtSndExplainRules.Text
        Options.snd_ToHotSeat = OptionsScreen.txtSndToHotSeat.Text
        Options.snd_ToHotSeat_LD = OptionsScreen.txtSndToHotSeatLD.Text
        Options.snd_WalkAway1 = OptionsScreen.txtSndWalkAway1.Text
        Options.snd_WalkAway2 = OptionsScreen.txtSndWalkAway2.Text
        Options.snd_GameOver = OptionsScreen.txtSndGameOver.Text
        Options.snd_F_Meet2 = OptionsScreen.txtSndFMeet2.Text
        Options.snd_F_Meet3 = OptionsScreen.txtSndFMeet3.Text
        Options.snd_F_Meet4 = OptionsScreen.txtSndFMeet4.Text
        Options.snd_F_Meet5 = OptionsScreen.txtSndFMeet5.Text
        Options.snd_F_Meet6 = OptionsScreen.txtSndFMeet6.Text
        Options.snd_F_Meet7 = OptionsScreen.txtSndFMeet7.Text
        Options.snd_F_Meet8 = OptionsScreen.txtSndFMeet8.Text
        Options.snd_F_ReadQuestion = OptionsScreen.txtSndFReadQuestion.Text
        Options.snd_F_ThreeNotes = OptionsScreen.txtSndFThreeNotes.Text
        Options.snd_F_Thinking = OptionsScreen.txtSndFThinking.Text
        Options.snd_F_ReadCorrectOrder = OptionsScreen.txtSndFReadCorrectOrder.Text
        Options.snd_F_Order1 = OptionsScreen.txtSndFOrder1.Text
        Options.snd_F_Order2 = OptionsScreen.txtSndFOrder2.Text
        Options.snd_F_Order3 = OptionsScreen.txtSndFOrder3.Text
        Options.snd_F_Order4 = OptionsScreen.txtSndFOrder4.Text
        Options.snd_F_WhoWasCorrect = OptionsScreen.txtSndFWhoWasCorrect.Text
        Options.snd_F_Winner = OptionsScreen.txtSndFWinner.Text
        Options.snd_ATA_Start = OptionsScreen.txtSndATAStart.Text
        Options.snd_ATA_Voting = OptionsScreen.txtSndATAVoting.Text
        Options.snd_ATA_End = OptionsScreen.txtSndATAEnd.Text
        Options.snd_P1_Start = OptionsScreen.txtSndP1Start.Text
        Options.snd_P1_Clock = OptionsScreen.txtSndP1Clock.Text
        Options.snd_P1_EndEarly = OptionsScreen.txtSndP1EndEarly.Text
        Options.snd_Double_1stAnswer = OptionsScreen.txtSndDD1stAnswer.Text
        Options.snd_Double_1stFinal = OptionsScreen.txtSndDD1stFinal.Text
        Options.snd_Double_2ndAnswer = OptionsScreen.txtSndDD2ndAnswer.Text
        Options.snd_Double_2ndFinal = OptionsScreen.txtSndDD2ndFinal.Text
        Options.snd_Switch0_Activate = OptionsScreen.txtSndSwitchActivate.Text
        Options.snd_Switch0_ShowCorrect = OptionsScreen.txtSndSwitchShowCorrect.Text
        Options.snd_Switch0_Clear = OptionsScreen.txtSndSwitchClear.Text
        Options.snd_5050 = OptionsScreen.txtSnd5050Use.Text

        Options.snd_Q1to5LightsDown = OptionsScreen.txtSndQ1to5LD.Text
        Options.snd_Q6LightsDown = OptionsScreen.txtSndQ6LD.Text
        Options.snd_Q7LightsDown = OptionsScreen.txtSndQ7LD.Text
        Options.snd_Q8LightsDown = OptionsScreen.txtSndQ8LD.Text
        Options.snd_Q9LightsDown = OptionsScreen.txtSndQ9LD.Text
        Options.snd_Q10LightsDown = OptionsScreen.txtSndQ10LD.Text
        Options.snd_Q11LightsDown = OptionsScreen.txtSndQ11LD.Text
        Options.snd_Q12LightsDown = OptionsScreen.txtSndQ12LD.Text
        Options.snd_Q13LightsDown = OptionsScreen.txtSndQ13LD.Text
        Options.snd_Q14LightsDown = OptionsScreen.txtSndQ14LD.Text
        Options.snd_Q15LightsDown = OptionsScreen.txtSndQ15LD.Text

        Options.snd_Q1to5LightsDown_Stop = OptionsScreen.chkSndStopQ1to5LD.Checked
        Options.snd_Q6LightsDown_Stop = OptionsScreen.chkSndStopQ6LD.Checked
        Options.snd_Q7LightsDown_Stop = OptionsScreen.chkSndStopQ7LD.Checked
        Options.snd_Q8LightsDown_Stop = OptionsScreen.chkSndStopQ8LD.Checked
        Options.snd_Q9LightsDown_Stop = OptionsScreen.chkSndStopQ9LD.Checked
        Options.snd_Q10LightsDown_Stop = OptionsScreen.chkSndStopQ10LD.Checked
        Options.snd_Q11LightsDown_Stop = OptionsScreen.chkSndStopQ11LD.Checked
        Options.snd_Q12LightsDown_Stop = OptionsScreen.chkSndStopQ12LD.Checked
        Options.snd_Q13LightsDown_Stop = OptionsScreen.chkSndStopQ13LD.Checked
        Options.snd_Q14LightsDown_Stop = OptionsScreen.chkSndStopQ14LD.Checked
        Options.snd_Q15LightsDown_Stop = OptionsScreen.chkSndStopQ15LD.Checked

        Options.snd_Q1to5Bed = OptionsScreen.txtSndQ1to5Bed.Text
        Options.snd_Q6Bed = OptionsScreen.txtSndQ6Bed.Text
        Options.snd_Q7Bed = OptionsScreen.txtSndQ7Bed.Text
        Options.snd_Q8Bed = OptionsScreen.txtSndQ8Bed.Text
        Options.snd_Q9Bed = OptionsScreen.txtSndQ9Bed.Text
        Options.snd_Q10Bed = OptionsScreen.txtSndQ10Bed.Text
        Options.snd_Q11Bed = OptionsScreen.txtSndQ11Bed.Text
        Options.snd_Q12Bed = OptionsScreen.txtSndQ12Bed.Text
        Options.snd_Q13Bed = OptionsScreen.txtSndQ13Bed.Text
        Options.snd_Q14Bed = OptionsScreen.txtSndQ14Bed.Text
        Options.snd_Q15Bed = OptionsScreen.txtSndQ15Bed.Text

        Options.snd_Q1Final = OptionsScreen.txtSndQ1Final.Text
        Options.snd_Q2Final = OptionsScreen.txtSndQ2Final.Text
        Options.snd_Q3Final = OptionsScreen.txtSndQ3Final.Text
        Options.snd_Q4Final = OptionsScreen.txtSndQ4Final.Text
        Options.snd_Q5Final = OptionsScreen.txtSndQ5Final.Text
        Options.snd_Q6Final = OptionsScreen.txtSndQ6Final.Text
        Options.snd_Q7Final = OptionsScreen.txtSndQ7Final.Text
        Options.snd_Q8Final = OptionsScreen.txtSndQ8Final.Text
        Options.snd_Q9Final = OptionsScreen.txtSndQ9Final.Text
        Options.snd_Q10Final = OptionsScreen.txtSndQ10Final.Text
        Options.snd_Q11Final = OptionsScreen.txtSndQ11Final.Text
        Options.snd_Q12Final = OptionsScreen.txtSndQ12Final.Text
        Options.snd_Q13Final = OptionsScreen.txtSndQ13Final.Text
        Options.snd_Q14Final = OptionsScreen.txtSndQ14Final.Text
        Options.snd_Q15Final = OptionsScreen.txtSndQ15Final.Text

        Options.snd_Q1to4Correct = OptionsScreen.txtSndQ1to4Correct.Text
        Options.snd_Q5Correct = OptionsScreen.txtSndQ5Correct.Text
        Options.snd_Q6Correct = OptionsScreen.txtSndQ6Correct.Text
        Options.snd_Q7Correct = OptionsScreen.txtSndQ7Correct.Text
        Options.snd_Q8Correct = OptionsScreen.txtSndQ8Correct.Text
        Options.snd_Q9Correct = OptionsScreen.txtSndQ9Correct.Text
        Options.snd_Q10Correct = OptionsScreen.txtSndQ10Correct.Text
        Options.snd_Q10Correct_R = OptionsScreen.txtSndQ10RCorrect.Text
        Options.snd_Q11Correct = OptionsScreen.txtSndQ11Correct.Text
        Options.snd_Q12Correct = OptionsScreen.txtSndQ12Correct.Text
        Options.snd_Q13Correct = OptionsScreen.txtSndQ13Correct.Text
        Options.snd_Q14Correct = OptionsScreen.txtSndQ14Correct.Text
        Options.snd_Q15Correct = OptionsScreen.txtSndQ15Correct.Text

        Options.snd_Q1to5Wrong = OptionsScreen.txtSndQ1to5Wrong.Text
        Options.snd_Q6Wrong = OptionsScreen.txtSndQ6Wrong.Text
        Options.snd_Q7Wrong = OptionsScreen.txtSndQ7Wrong.Text
        Options.snd_Q8Wrong = OptionsScreen.txtSndQ8Wrong.Text
        Options.snd_Q9Wrong = OptionsScreen.txtSndQ9Wrong.Text
        Options.snd_Q10Wrong = OptionsScreen.txtSndQ10Wrong.Text
        Options.snd_Q11Wrong = OptionsScreen.txtSndQ11Wrong.Text
        Options.snd_Q12Wrong = OptionsScreen.txtSndQ12Wrong.Text
        Options.snd_Q13Wrong = OptionsScreen.txtSndQ13Wrong.Text
        Options.snd_Q14Wrong = OptionsScreen.txtSndQ14Wrong.Text
        Options.snd_Q15Wrong = OptionsScreen.txtSndQ15Wrong.Text
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
