Public Class SOUND
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private oName As String = Nothing

    Public Property Name As String
        Set(value As String)
            oName = value
        End Set
        Get
            Return oName
        End Get
    End Property

    Public Sub Play(ByVal id As Integer, ByVal repeat As Boolean, Optional vol As Integer = 1000)
        If repeat = True Then
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat", CStr(0), 0, 0)
        Else
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName, CStr(0), 0, 0)
        End If
        mciSendString("setaudio " & oName & " volume to " & vol, CStr(0), 0, 0)
    End Sub

    Public Sub Kill(ByVal song As String)
        mciSendString("close " & song, CStr(0), 0, 0)
        oName = Nothing
    End Sub

    Public Sub StopS(ByVal song As String)
        mciSendString("stop " & oName, CStr(0), 0, 0)
        oName = Nothing
    End Sub

    Private Function GetFile(ByVal Id As Integer) As String
        Dim path As String

        Select Case Id
            Case 0
                path = Application.StartupPath + "\Sounds\host_entrance.mp3"
            Case 1
                path = Application.StartupPath + "\Sounds\close_theme.mp3"
            Case 2
                path = Application.StartupPath + "\Sounds\hello_long.mp3"
            Case 3
                path = Application.StartupPath + "\Sounds\quit_small.mp3"
            Case 4
                path = Application.StartupPath + "\Sounds\quit_large.mp3"
            Case 5
                path = Application.StartupPath + "\Sounds\q1_to_q5_lights_down.mp3"
            Case 6
                path = Application.StartupPath + "\Sounds\lights_down_classic.mp3"
            Case 7
                path = Application.StartupPath + "\Sounds\lights_down_1.mp3"
            Case 8
                path = Application.StartupPath + "\Sounds\lights_down_2.mp3"
            Case 9
                path = Application.StartupPath + "\Sounds\lifeline_4_on.mp3"
            Case 10
                path = Application.StartupPath + "\Sounds\stq_new_question_flip.mp3"
            Case 12
                path = Application.StartupPath + "\Sounds\q1_to_q4_correct.mp3"
            Case 13
                path = Application.StartupPath + "\Sounds\final_answer_1.mp3"
            Case 14
                path = Application.StartupPath + "\Sounds\final_answer_2.mp3"
            Case 15
                path = Application.StartupPath + "\Sounds\final_answer_3.mp3"
            Case 16
                path = Application.StartupPath + "\Sounds\final_answer_4.mp3"
            Case 17
                path = Application.StartupPath + "\Sounds\final_answer_5.mp3"
            Case 18
                path = Application.StartupPath + "\Sounds\q5_correct.mp3"
            Case 19
                path = Application.StartupPath + "\Sounds\q1_to_q5_lose.mp3"
            Case 20
                path = Application.StartupPath + "\Sounds\paf_start.mp3"
            Case 21
                path = Application.StartupPath + "\Sounds\paf_countdown.mp3"
            Case 22
                path = Application.StartupPath + "\Sounds\paf_end_call_early.mp3"
            Case 23
                path = Application.StartupPath + "\Sounds\lifeline_1_on.mp3"
            Case 24
                path = Application.StartupPath + "\Sounds\lifeline_2_on.mp3"
            Case 25
                path = Application.StartupPath + "\Sounds\lifeline_3_on.mp3"
            Case 27
                path = Application.StartupPath + "\Sounds\fifty_fifty.mp3"
            Case 28
                path = Application.StartupPath + "\Sounds\walk_away_small.mp3"
            Case 29
                path = Application.StartupPath + "\Sounds\fastest_finger_contestants.mp3"
            Case 30
                path = Application.StartupPath + "\Sounds\fastest_finger_read_question.mp3"
            Case 31
                path = Application.StartupPath + "\Sounds\fastest_finger_answer_correct_1.mp3"
            Case 32
                path = Application.StartupPath + "\Sounds\fastest_finger_answer_correct_2.mp3"
            Case 33
                path = Application.StartupPath + "\Sounds\fastest_finger_answer_correct_3.mp3"
            Case 34
                path = Application.StartupPath + "\Sounds\fastest_finger_answer_correct_4.mp3"
            Case 35
                path = Application.StartupPath + "\Sounds\fastest_finger_reveal_times.mp3"
            Case 36
                path = Application.StartupPath + "\Sounds\q5_correct.mp3"
            Case 37
                path = Application.StartupPath + "\Sounds\fastest_finger_3_stabs.mp3"
            Case 38
                path = Application.StartupPath + "\Sounds\lights_down_3.mp3"
            Case 39
                path = Application.StartupPath + "\Sounds\lights_down_4.mp3"
            Case 40
                path = Application.StartupPath + "\Sounds\lights_down_5.mp3"
            Case 41
                path = Application.StartupPath + "\Sounds\ata_start.mp3"
            Case 42
                path = Application.StartupPath + "\Sounds\ata_end.mp3"
            Case 43
                path = Application.StartupPath + "\Sounds\fastest_finger_think.mp3"
            Case 44
                path = Application.StartupPath + "\Sounds\host_entrance_short.mp3"
        End Select

        path = Chr(34) & path & Chr(34)

        Return path
    End Function
End Class

