Public Class TVControlPnl

    Dim i As Integer = 0
    Dim strstep As Integer = 0

    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H80000 ' WS_EX_LAYERED
    '        Return cp
    '    End Get
    'End Property

    Private Sub tmrFlash_Tick(sender As Object, e As EventArgs) Handles tmrFlash.Tick
        If strstep <= 3 Then
            If ControlPanel.answer = ControlPanel.lblAnswer.Text Then
                If ControlPanel.lblAnswer.Text = "A" Then
                    If i = 0 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(6)
                        HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
                        GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
                        i = 1
                    ElseIf i = 1 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(4)
                        HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(4)
                        GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(4)
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "B" Then
                    If i = 0 Then
                        picB.BackgroundImage = QuestionStrap.GetTexture(7)
                        HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
                        GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
                        i = 1
                    ElseIf i = 1 Then
                        picB.BackgroundImage = QuestionStrap.GetTexture(5)
                        HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(5)
                        GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(5)
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "C" Then
                    If i = 0 Then
                        picC.BackgroundImage = QuestionStrap.GetTexture(6)
                        HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
                        GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
                        i = 1
                    ElseIf i = 1 Then
                        picC.BackgroundImage = QuestionStrap.GetTexture(4)
                        HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(4)
                        GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(4)
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "D" Then
                    If i = 0 Then
                        picD.BackgroundImage = QuestionStrap.GetTexture(7)
                        HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
                        GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
                        i = 1
                    ElseIf i = 1 Then
                        picD.BackgroundImage = QuestionStrap.GetTexture(5)
                        HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(5)
                        GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(5)
                        i = 0
                    End If
                End If
            Else
                If ControlPanel.lblAnswer.Text = "A" Then
                    If i = 0 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(6)
                        HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
                        GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
                        txtA.ForeColor = Color.Black
                        HostScreen.txtA.ForeColor = Color.Black
                        GuestScreen.txtA.ForeColor = Color.Black
                        i = 1
                    ElseIf i = 1 Then
                        picA.BackgroundImage = QuestionStrap.GetTexture(2)
                        HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
                        GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
                        txtA.ForeColor = Color.White
                        HostScreen.txtA.ForeColor = Color.White
                        GuestScreen.txtA.ForeColor = Color.White
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "B" Then
                    If i = 0 Then
                        i = 1
                        picB.BackgroundImage = QuestionStrap.GetTexture(7)
                        HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
                        GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
                        txtB.ForeColor = Color.Black
                        HostScreen.txtB.ForeColor = Color.Black
                        GuestScreen.txtB.ForeColor = Color.Black
                    ElseIf i = 1 Then
                        picB.BackgroundImage = QuestionStrap.GetTexture(3)
                        HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
                        GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
                        txtB.ForeColor = Color.White
                        HostScreen.txtB.ForeColor = Color.White
                        GuestScreen.txtB.ForeColor = Color.White
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "C" Then
                    If i = 0 Then
                        i = 1
                        picC.BackgroundImage = QuestionStrap.GetTexture(6)
                        HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
                        GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
                        txtC.ForeColor = Color.Black
                        HostScreen.txtC.ForeColor = Color.Black
                        GuestScreen.txtC.ForeColor = Color.Black
                    ElseIf i = 1 Then
                        picC.BackgroundImage = QuestionStrap.GetTexture(2)
                        HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
                        GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
                        txtC.ForeColor = Color.White
                        HostScreen.txtC.ForeColor = Color.White
                        GuestScreen.txtC.ForeColor = Color.White
                        i = 0
                    End If
                End If
                If ControlPanel.lblAnswer.Text = "D" Then
                    If i = 0 Then
                        i = 1
                        picD.BackgroundImage = QuestionStrap.GetTexture(7)
                        HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
                        GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
                        txtD.ForeColor = Color.Black
                        HostScreen.txtD.ForeColor = Color.Black
                        GuestScreen.txtD.ForeColor = Color.Black
                    ElseIf i = 1 Then
                        picD.BackgroundImage = QuestionStrap.GetTexture(3)
                        HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
                        GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
                        txtD.ForeColor = Color.White
                        HostScreen.txtD.ForeColor = Color.White
                        GuestScreen.txtD.ForeColor = Color.White
                        i = 0
                    End If
                End If
            End If
            strstep = strstep + 1
        Else
            If ControlPanel.lblAnswer.Text = "A" Then
                txtA.ForeColor = Color.Black
                HostScreen.txtA.ForeColor = Color.Black
                GuestScreen.txtA.ForeColor = Color.Black
                picA.BackgroundImage = QuestionStrap.GetTexture(6)
                HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
                GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(6)
            End If
            If ControlPanel.lblAnswer.Text = "B" Then
                txtB.ForeColor = Color.Black
                HostScreen.txtB.ForeColor = Color.Black
                GuestScreen.txtB.ForeColor = Color.Black
                picB.BackgroundImage = QuestionStrap.GetTexture(7)
                HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
                GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(7)
            End If
            If ControlPanel.lblAnswer.Text = "C" Then
                txtC.ForeColor = Color.Black
                HostScreen.txtC.ForeColor = Color.Black
                GuestScreen.txtC.ForeColor = Color.Black
                picC.BackgroundImage = QuestionStrap.GetTexture(6)
                HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
                GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(6)
            End If
            If ControlPanel.lblAnswer.Text = "D" Then
                txtD.ForeColor = Color.Black
                HostScreen.txtD.ForeColor = Color.Black
                GuestScreen.txtD.ForeColor = Color.Black
                picD.BackgroundImage = QuestionStrap.GetTexture(7)
                HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
                GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(7)
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
        'Me.TopMost = True
        'Me.AllowTransparency = True
        Me.BackColor = Color.Black
        'Me.Opacity = 1 ' Voor globale transparantie

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()

        pnlStrap.BackgroundImage = WinningStrap.GetTexture()
        lblAmount.ForeColor = WinningStrap.GetTextureFontColor()

        LifelineATA.InitializeAudienceChart()
        LifelineATA.ResizeATAGraph()
        LifelineATA.UpdateAudienceLayout()
        pnlATAGraph.Left = Me.ClientSize.Width ' Start outside the form
    End Sub

    Dim fna As Integer = 1
    Private Sub tmrAnimateFreeSafeNet_Tick(sender As Object, e As EventArgs) Handles tmrAnimateFreeSafeNet.Tick
        Select Case fna
            Case 1
                Try
                    picTree.BackgroundImage = MoneyTreeCore.tree_imgrisk(Game.level)
                Catch ex As Exception

                End Try
                fna = 2
            Case 2
                picTree.BackgroundImage = MoneyTreeCore.tree_imgnet2
                fna = 1
        End Select
    End Sub

    Private Sub tmr_Anim_ATA_Tick(sender As Object, e As EventArgs) Handles tmr_Anim_ATA.Tick
        If ATAAnimate.slidingIn Then
            pnlATAGraph.Left -= ATAAnimate.slideSpeed
            If pnlATAGraph.Left <= ATAAnimate.targetX Then
                pnlATAGraph.Left = ATAAnimate.targetX
                tmr_Anim_ATA.Stop()
            End If
        Else
            pnlATAGraph.Left += ATAAnimate.slideSpeed
            If pnlATAGraph.Left >= ATAAnimate.targetX Then
                pnlATAGraph.Left = ATAAnimate.targetX
                tmr_Anim_ATA.Stop()
            End If
        End If
    End Sub
End Class