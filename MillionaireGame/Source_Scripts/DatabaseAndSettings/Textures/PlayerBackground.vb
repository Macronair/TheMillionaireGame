Public Class PlayerBackground

    Public Shared Function GetTexture(Optional ByVal texture As Integer = -1)
        If texture = -1 Then
            Select Case Profile.Options.QuestionsTexture
                Case 0      ' Default (White)
                    Return My.Resources._01_FFF
                Case 1      ' Default (Blue / US 2020)
                    Return My.Resources._02_FFF
                Case 2      ' Default (Gold)
                    Return My.Resources._04_FFF
                Case 3      ' Blue
                    Return My.Resources._02_FFF
                Case 4      ' Purple
                    Return My.Resources._05_FFF
            End Select
        Else
            Select Case texture
                Case 0      ' Default (White)
                    Return My.Resources._01_FFF
                Case 1      ' Default (Blue / US 2020)
                    Return My.Resources._02_FFF
                Case 2      ' Default (Gold)
                    Return My.Resources._04_FFF
                Case 3      ' Blue
                    Return My.Resources._02_FFF
                Case 4      ' Purple
                    Return My.Resources._05_FFF
            End Select
        End If
    End Function

End Class
