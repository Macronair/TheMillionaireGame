Public Class WinningStrap

    Public Shared Function GetTexture(Optional ByVal texture As Integer = -1)
        If texture = -1 Then
            Select Case Profile.Options.WinningStrapTexture
                Case 0      ' Yellow/Gold (Default)
                    Return My.Resources.WinStrap_01
                Case 1      ' Black (White borders)
                    Return My.Resources.WinStrap_02
                Case 2      ' Black (Gold borders)
                    Return My.Resources.WinStrap_03
                Case 3      ' US 2020
                    Return My.Resources.WinStrap_04
                Case 4      ' Blue
                    Return My.Resources.WinStrap_05
                Case 5      ' Purple
                    Return My.Resources.WinStrap_06
                Case 6      ' Millionaire Original (1998)
                    Return My.Resources.WinStrap_07
                Case Else
                    Return My.Resources.WinStrap_02
            End Select
        Else
            Select Case texture
                Case 0      ' Yellow/Gold (Default)
                    Return My.Resources.WinStrap_01
                Case 1      ' Black (White borders)
                    Return My.Resources.WinStrap_02
                Case 2      ' Black (Gold borders)
                    Return My.Resources.WinStrap_03
                Case 3      ' US 2020
                    Return My.Resources.WinStrap_04
                Case 4      ' Blue
                    Return My.Resources.WinStrap_05
                Case 5      ' Purple
                    Return My.Resources.WinStrap_06
                Case 6      ' Millionaire Original (1998)
                    Return My.Resources.WinStrap_07
                Case Else
                    Return My.Resources.WinStrap_02
            End Select
        End If
    End Function

    Public Shared Function GetTextureFontColor(Optional ByVal texture As Integer = -1)
        If texture = -1 Then
            Select Case Profile.Options.WinningStrapTexture
                Case 0      ' Yellow/Gold (Default)
                    Return System.Drawing.Color.Black
                Case 1      ' Black (White borders)
                    Return System.Drawing.Color.White
                Case 2      ' Black (Gold borders)
                    Return System.Drawing.Color.Goldenrod
                Case 3      ' US 2020
                    Return System.Drawing.Color.White
                Case 4      ' Blue
                    Return System.Drawing.Color.White
                Case 5      ' Purple
                    Return System.Drawing.Color.White
                Case 6      ' Millionaire Original (1998)
                    Return System.Drawing.Color.Gold
                Case Else
                    Return System.Drawing.Color.White
            End Select
        Else
            Select Case texture
                Case 0      ' Yellow/Gold (Default)
                    Return System.Drawing.Color.Black
                Case 1      ' Black (White borders)
                    Return System.Drawing.Color.White
                Case 2      ' Black (Gold borders)
                    Return System.Drawing.Color.Goldenrod
                Case 3      ' US 2020
                    Return System.Drawing.Color.White
                Case 4      ' Blue
                    Return System.Drawing.Color.White
                Case 5      ' Purple
                    Return System.Drawing.Color.White
                Case 6      ' Millionaire Original (1998)
                    Return System.Drawing.Color.Gold
                Case Else
                    Return System.Drawing.Color.White
            End Select
        End If
    End Function

End Class
