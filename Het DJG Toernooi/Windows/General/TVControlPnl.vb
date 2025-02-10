Public Class TVControlPnl

    Dim i As Integer = 0
    Dim strstep As Integer = 0

    Private Sub tmrFlash_Tick(sender As Object, e As EventArgs) Handles tmrFlash.Tick
        If strstep <= 3 Then
            If ControlPanel.answer = ControlPanel.lblAnswer.Text Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    If i = 0 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(6)
                        i = 1
                    ElseIf i = 1 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(4)
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "B" Then
                    If i = 0 Then
                        picB.BackgroundImage = QuestionStrap.GetTexture(7)
                        i = 1
                    ElseIf i = 1 Then
                        picB.BackgroundImage = QuestionStrap.GetTexture(5)
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "C" Then
                    If i = 0 Then
                        picC.BackgroundImage = QuestionStrap.GetTexture(6)
                        i = 1
                    ElseIf i = 1 Then
                        picC.BackgroundImage = QuestionStrap.GetTexture(4)
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "D" Then
                    If i = 0 Then
                        picD.BackgroundImage = QuestionStrap.GetTexture(7)
                        i = 1
                    ElseIf i = 1 Then
                        picD.BackgroundImage = QuestionStrap.GetTexture(5)
                        i = 0
                    End If
                End If
            Else
                If ControlPanel.lblAnswer.Text = "A" Then
                    If i = 0 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(6)
                        txtA.ForeColor = Color.Black
                        i = 1
                    ElseIf i = 1 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(2)
                        txtA.ForeColor = Color.White
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "B" Then
                    If i = 0 Then
                        i = 1
                        picB.BackgroundImage = QuestionStrap.GetTexture(7)
                        txtB.ForeColor = Color.Black
                    ElseIf i = 1 Then
                        picB.BackgroundImage = QuestionStrap.GetTexture(3)
                        txtB.ForeColor = Color.White
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "C" Then
                    If i = 0 Then
                        i = 1
                        picC.BackgroundImage = QuestionStrap.GetTexture(6)
                        txtC.ForeColor = Color.Black
                    ElseIf i = 1 Then
                        picC.BackgroundImage = QuestionStrap.GetTexture(2)
                        txtC.ForeColor = Color.White
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "D" Then
                    If i = 0 Then
                        i = 1
                        picD.BackgroundImage = QuestionStrap.GetTexture(7)
                        txtD.ForeColor = Color.Black
                    ElseIf i = 1 Then
                        picD.BackgroundImage = QuestionStrap.GetTexture(3)
                        txtD.ForeColor = Color.White
                        i = 0
                    End If
                End If
            End If
            strstep = strstep + 1
        Else
            If ControlPanel.lblAnswer.Text = "A" Then
                txtA.ForeColor = Color.Black
                picA.BackgroundImage = QuestionStrap.GetTexture(6)
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                txtB.ForeColor = Color.Black
                picB.BackgroundImage = QuestionStrap.GetTexture(7)
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                txtC.ForeColor = Color.Black
                picC.BackgroundImage = QuestionStrap.GetTexture(6)
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                txtD.ForeColor = Color.Black
                picD.BackgroundImage = QuestionStrap.GetTexture(7)
            End If
            strstep = 0
            tmrFlash.Stop()
        End If

    End Sub

    Private Sub tmrStrap_Tick(sender As Object, e As EventArgs) Handles tmrStrap.Tick
        i = 0
        strstep = 0

        Game.ChangeLevel(Game.level)
        If MoneyTreeSettings.TreeData.CurrencyAtSuffix = True Then
            lblAmount.Text = Game.varCurrent + MoneyTreeSettings.TreeData.Currency
        Else
            lblAmount.Text = MoneyTreeSettings.TreeData.Currency + Game.varCurrent
        End If

        HostScreen.txtWinningStrap.Text = lblAmount.Text
        GuestScreen.txtWinningStrap.Text = lblAmount.Text

        ControlPanel.chkShowQuestion.Checked = False
        pnlStrap.Visible = True
        txtA.ForeColor = Color.White
        picA.BackgroundImage = QuestionStrap.GetTexture(2)
        txtB.ForeColor = Color.White
        picB.BackgroundImage = QuestionStrap.GetTexture(3)
        txtC.ForeColor = Color.White
        picC.BackgroundImage = QuestionStrap.GetTexture(2)
        txtD.ForeColor = Color.White
        picD.BackgroundImage = QuestionStrap.GetTexture(3)

        ControlPanel.tmrLifelineUpdate.Start()

        tmrStrap.Stop()
        tmrFlash.Stop()
    End Sub

    Private Sub tmrRandomizer_Tick(sender As Object, e As EventArgs) Handles tmrRandomizer.Tick
        Dim rnd1 As New Random

        lblATA_A.Text = "A: " & rnd1.Next(5, 100) & "%"
        lblATA_B.Text = "B: " & rnd1.Next(5, 100) & "%"
        lblATA_C.Text = "C: " & rnd1.Next(5, 100) & "%"
        lblATA_D.Text = "D: " & rnd1.Next(5, 100) & "%"
    End Sub

    Private Sub TVControlPnl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlStrap.BackgroundImage = WinningStrap.GetTexture()
        lblAmount.ForeColor = WinningStrap.GetTextureFontColor()
    End Sub

    Dim fna As Integer = 1
    Private Sub tmrAnimateFreeSafeNet_Tick(sender As Object, e As EventArgs) Handles tmrAnimateFreeSafeNet.Tick
        Select Case fna
            Case 1
                picTree.BackgroundImage = MoneyTreeCore.tree_imgrisk(Game.level)
                fna = 2
            Case 2
                picTree.BackgroundImage = MoneyTreeCore.tree_imgnet2
                fna = 1
        End Select
    End Sub
End Class