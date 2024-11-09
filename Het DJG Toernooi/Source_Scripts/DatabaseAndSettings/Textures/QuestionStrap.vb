Public Class QuestionStrap

    ' Manual '
    '
    ' First attribute: ELEMENT
    ' 1 = Question
    ' 2 = Answers L
    ' 3 = Answers R
    ' 4 = Answers L Final
    ' 5 = Answers R Final
    ' 6 = Answers L Correct
    ' 7 = Answers R Correct

    ' Second attribute: TEXTURES
    ' 0 = Default (White border)
    ' 1 = Default (Blue border / US 2020)
    ' 2 = Default (Gold border)
    ' 3 = Blue
    ' 4 = Purple
    ' 5 = Dutch 1999

    Public Shared Sub LoadTextures()
        TVControlPnl.picQuestion.BackgroundImage = GetTexture(1)
        TVControlPnl.picA.BackgroundImage = GetTexture(2)
        TVControlPnl.picB.BackgroundImage = GetTexture(3)
        TVControlPnl.picC.BackgroundImage = GetTexture(2)
        TVControlPnl.picD.BackgroundImage = GetTexture(3)

        HostScreen.picQuestion.BackgroundImage = GetTexture(1)
        HostScreen.pnlA.BackgroundImage = GetTexture(2)
        HostScreen.pnlB.BackgroundImage = GetTexture(3)
        HostScreen.pnlC.BackgroundImage = GetTexture(2)
        HostScreen.pnlD.BackgroundImage = GetTexture(3)

        GuestScreen.picQuestion.BackgroundImage = GetTexture(1)
        GuestScreen.pnlA.BackgroundImage = GetTexture(2)
        GuestScreen.pnlB.BackgroundImage = GetTexture(3)
        GuestScreen.pnlC.BackgroundImage = GetTexture(2)
        GuestScreen.pnlD.BackgroundImage = GetTexture(3)
    End Sub

    Public Shared Function GetTexture(ByVal element As Integer, Optional ByVal texture As Integer = 99) As Bitmap
        Dim textureset As Integer
        If texture < 99 Then
            textureset = texture
        Else
            textureset = Profile.Options.QuestionsTexture
        End If

        Select Case element
            Case 1
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Question_Strap
                    Case 1
                        Return My.Resources._02_Question_Strap
                    Case 2
                        Return My.Resources._03_Question_Strap
                    Case 3
                        Return My.Resources._04_Question_Strap
                    Case 4
                        Return My.Resources._05_Question_Strap
                End Select
            Case 2
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Answer_L_Normal
                    Case 1
                        Return My.Resources._02_Answer_L_Normal
                    Case 2
                        Return My.Resources._03_Answer_L_Normal
                    Case 3
                        Return My.Resources._04_Answer_L_Normal
                    Case 4
                        Return My.Resources._05_Answer_L_Normal
                End Select
            Case 3
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Answer_R_Normal
                    Case 1
                        Return My.Resources._02_Answer_R_Normal
                    Case 2
                        Return My.Resources._03_Answer_R_Normal
                    Case 3
                        Return My.Resources._04_Answer_R_Normal
                    Case 4
                        Return My.Resources._05_Answer_R_Normal
                End Select
            Case 4
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Answer_L_Final
                    Case 1
                        Return My.Resources._02_Answer_L_Final
                    Case 2
                        Return My.Resources._03_Answer_L_Final
                    Case 3
                        Return My.Resources._04_Answer_L_Final
                    Case 4
                        Return My.Resources._05_Answer_L_Final
                End Select
            Case 5
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Answer_R_Final
                    Case 1
                        Return My.Resources._02_Answer_R_Final
                    Case 2
                        Return My.Resources._03_Answer_R_Final
                    Case 3
                        Return My.Resources._04_Answer_R_Final
                    Case 4
                        Return My.Resources._05_Answer_R_Final
                End Select
            Case 6
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Answer_L_Correct
                    Case 1
                        Return My.Resources._02_Answer_L_Correct
                    Case 2
                        Return My.Resources._03_Answer_L_Correct
                    Case 3
                        Return My.Resources._04_Answer_L_Correct
                    Case 4
                        Return My.Resources._05_Answer_L_Correct
                End Select
            Case 7
                Select Case textureset
                    Case 0
                        Return My.Resources._01_Answer_R_Correct
                    Case 1
                        Return My.Resources._02_Answer_R_Correct
                    Case 2
                        Return My.Resources._03_Answer_R_Correct
                    Case 3
                        Return My.Resources._04_Answer_R_Correct
                    Case 4
                        Return My.Resources._05_Answer_R_Correct
                End Select
            Case Else
                Return Nothing
        End Select
    End Function

End Class
