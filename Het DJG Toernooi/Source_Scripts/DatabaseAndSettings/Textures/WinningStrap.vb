Public Class WinningStrap

    Public Shared Function GetTexture(Optional ByVal texture As Integer = -1)
        If texture = -1 Then
            Select Case Profile.Options.WinningStrapTexture
                Case 0      ' Yellow/Gold (Default)
                    Return My.Resources.winning_0
                Case 1      ' Green
                    Return My.Resources.winning_1
                Case 2      ' Black
                    Return My.Resources.winning_2
                Case Else   ' Everything else
                    Return My.Resources.winning_0
            End Select
        Else
            Select Case texture
                Case 0
                    Return My.Resources.winning_0
                Case 1
                    Return My.Resources.winning_1
                Case 2
                    Return My.Resources.winning_2
                Case Else
                    Return My.Resources.winning_0
            End Select
        End If
    End Function

    Public Shared Function GetTextureFontColor(Optional ByVal texture As Integer = -1)
        If texture = -1 Then
            Select Case Profile.Options.WinningStrapTexture
                Case 0      ' Yellow/Gold (Default)
                    Return System.Drawing.Color.Black
                Case 1      ' Green
                    Return System.Drawing.Color.Black
                Case 2      ' Black
                    Return System.Drawing.Color.White
                Case Else   ' Everything else
                    Return System.Drawing.Color.Black
            End Select
        Else
            Select Case texture
                Case 0
                    Return System.Drawing.Color.Black
                Case 1
                    Return System.Drawing.Color.Black
                Case 2
                    Return System.Drawing.Color.White
                Case Else
                    Return System.Drawing.Color.Black
            End Select
        End If
    End Function

End Class
