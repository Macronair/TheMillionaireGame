Imports System.Text.Json
Imports System.Windows.Documents
Imports Microsoft.AspNetCore.SignalR.Client

Public Class AudienceVoteUpdate
    Public Property QuestionId As Integer
    Public Property Counts As Dictionary(Of String, Integer)
End Class

Public Class LifelineATA
    Private Shared act As Integer = 0
    Private Shared amountA As Integer
    Private Shared amountB As Integer
    Private Shared amountC As Integer
    Private Shared amountD As Integer
    Private Shared perA As String
    Private Shared perB As String
    Private Shared perC As String
    Private Shared perD As String
    Private Shared amountTotal As Integer

    Private Shared ATAColumns As New Dictionary(Of String, Panel)
    Private Shared ATABars As New Dictionary(Of String, Panel)
    Private Shared ATAPercentLabels As New Dictionary(Of String, Label)
    Private Shared ATALetterLabels As New Dictionary(Of String, Label)

    Public Shared Sub LifelineUse1(Optional ByVal abortLifeline As Boolean = False)
        If abortLifeline = True Then
            If ATAAnimate.slidingIn = True Then
                act = 3
            Else
                Return
            End If
        End If

        Select Case act
            Case 0
                With Sounds.sndLifeline1
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_Start
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("question", 100))
                stopaudio.Start()

                Questions.useMusic = False
                act = 1

                ControlPanel.txtHostMessages.AppendText("AUDIENCE ACTIVATED." + Environment.NewLine)
                HostScreen.lblHostMsg.Text = HostScreen.lblHostMsg.Text + Environment.NewLine + "AUDIENCE ACTIVATED."
            Case 1
                With Sounds.sndLifeline2
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_Voting
                    .controls.play()
                End With
                Dim stopaudio As New Threading.Thread(Sub() Sounds.StopAudio("lifeline1", 100))
                stopaudio.Start()

                act = 2
                TVControlPnl.tmrRandomizer.Start()
                TVControlPnl.grpATA.Visible = False
                ATAAnimate.SlideIn()

                Dim random As New Random()
                If Game.level < 5 Then

                    amountA = random.Next(1, 10)
                    amountB = random.Next(1, 10)
                    amountC = random.Next(1, 10)
                    amountD = random.Next(1, 10)

                    Dim choosewronganswer As Boolean = False

                    If Profile.Options.S_ATAisAlwaysCorrect = True Then
                        If random.Next(1, 31) <= 4 Then
                            choosewronganswer = True
                        End If
                    End If

                    If choosewronganswer = True Then
                        Dim fakeanswer As Integer = random.Next(1, 5)
                        Select Case fakeanswer
                            Case 1
                                amountA = random.Next(40, 60)
                            Case 2
                                amountB = random.Next(40, 60)
                            Case 3
                                amountC = random.Next(40, 60)
                            Case 4
                                amountD = random.Next(40, 60)
                        End Select
                    Else
                        If ControlPanel.lblAnswer.Text = "A" Then
                            amountA = random.Next(40, 60)
                        ElseIf ControlPanel.lblAnswer.Text = "B" Then
                            amountB = random.Next(40, 60)
                        ElseIf ControlPanel.lblAnswer.Text = "C" Then
                            amountC = random.Next(40, 60)
                        ElseIf ControlPanel.lblAnswer.Text = "D" Then
                            amountD = random.Next(40, 60)
                        End If
                    End If

                ElseIf Game.level >= 5 And Game.level <= 9 Then

                    amountA = random.Next(5, 20)
                    amountB = random.Next(5, 20)
                    amountC = random.Next(5, 20)
                    amountD = random.Next(5, 20)

                    Dim choosewronganswer As Boolean = False

                    If Profile.Options.S_ATAisAlwaysCorrect = True Then
                        If random.Next(1, 31) <= 8 Then
                            choosewronganswer = True
                        End If
                    End If

                    If choosewronganswer = True Then
                        Dim fakeanswer As Integer = random.Next(1, 5)
                        Select Case fakeanswer
                            Case 1
                                amountA = random.Next(25, 65)
                            Case 2
                                amountB = random.Next(25, 65)
                            Case 3
                                amountC = random.Next(25, 65)
                            Case 4
                                amountD = random.Next(25, 65)
                        End Select
                    Else
                        If ControlPanel.lblAnswer.Text = "A" Then
                            amountA = random.Next(23, 65)
                        ElseIf ControlPanel.lblAnswer.Text = "B" Then
                            amountB = random.Next(23, 65)
                        ElseIf ControlPanel.lblAnswer.Text = "C" Then
                            amountC = random.Next(23, 65)
                        ElseIf ControlPanel.lblAnswer.Text = "D" Then
                            amountD = random.Next(23, 65)
                        End If
                    End If

                ElseIf Game.level >= 10 Then
                    amountA = random.Next(20, 35)
                    amountB = random.Next(20, 35)
                    amountC = random.Next(20, 35)
                    amountD = random.Next(20, 35)

                    Dim choosewronganswer As Boolean = False

                    If Profile.Options.S_ATAisAlwaysCorrect = True Then
                        If random.Next(1, 31) <= 10 Then
                            choosewronganswer = True
                        End If
                    End If

                    If choosewronganswer = True Then
                        Dim fakeanswer As Integer = random.Next(1, 5)
                        Select Case fakeanswer
                            Case 1
                                amountA = random.Next(30, 70)
                            Case 2
                                amountB = random.Next(30, 70)
                            Case 3
                                amountC = random.Next(30, 70)
                            Case 4
                                amountD = random.Next(30, 70)
                        End Select
                    Else
                        If ControlPanel.lblAnswer.Text = "A" Then
                            amountA = random.Next(30, 70)
                        ElseIf ControlPanel.lblAnswer.Text = "B" Then
                            amountB = random.Next(30, 70)
                        ElseIf ControlPanel.lblAnswer.Text = "C" Then
                            amountC = random.Next(30, 70)
                        ElseIf ControlPanel.lblAnswer.Text = "D" Then
                            amountD = random.Next(30, 70)
                        End If
                    End If

                End If

                If ControlPanel.txtA.Text = "" Then
                    amountA = 0
                End If
                If ControlPanel.txtB.Text = "" Then
                    amountB = 0
                End If
                If ControlPanel.txtC.Text = "" Then
                    amountC = 0
                End If
                If ControlPanel.txtD.Text = "" Then
                    amountD = 0
                End If

                ControlPanel.lblATA_A.Text = amountA
                ControlPanel.lblATA_B.Text = amountB
                ControlPanel.lblATA_C.Text = amountC
                ControlPanel.lblATA_D.Text = amountD

                amountTotal = amountA + amountB + amountC + amountD
                perA = Fix((amountA / amountTotal * 100) + 0.5)
                perB = Fix((amountB / amountTotal * 100) + 0.5)
                perC = Fix((amountC / amountTotal * 100) + 0.5)
                perD = Fix((amountD / amountTotal * 100) + 0.5)
            Case 2
                TVControlPnl.tmrRandomizer.Stop()
                With Sounds.sndLifeline2
                    .URL = Sounds.SoundsPath + Profile.Options.snd_ATA_End
                    .controls.play()
                End With
                Sounds.sndLifeline1.controls.stop()
                TVControlPnl.lblATA_A.Text = "A: " + perA + "%"
                TVControlPnl.lblATA_B.Text = "B: " + perB + "%"
                TVControlPnl.lblATA_C.Text = "C: " + perC + "%"
                TVControlPnl.lblATA_D.Text = "D: " + perD + "%"
                HostScreen.txtATAa.Text = "A= " + perA + "%"
                HostScreen.txtATAb.Text = "B= " + perB + "%"
                HostScreen.txtATAc.Text = "C= " + perC + "%"
                HostScreen.txtATAd.Text = "D= " + perD + "%"
                GuestScreen.txtATAa.Text = "A= " + perA + "%"
                GuestScreen.txtATAb.Text = "B= " + perB + "%"
                GuestScreen.txtATAc.Text = "C= " + perC + "%"
                GuestScreen.txtATAd.Text = "D= " + perD + "%"

                NetHub.ATA_CloseVoting()
                UpdateAudienceChart(New Dictionary(Of String, Integer) From {
                    {"A", perA},
                    {"B", perB},
                    {"C", perC},
                    {"D", perD}
                })

                Questions.PlayQuestionCue()
                act = 3
            Case 3
                ATAAnimate.SlideOut()
                LifelineManager.EnableLifeline(LifelineManager.CurrentActive, False)
                act = 0
        End Select

    End Sub

    Public Shared Sub InitializeAudienceChart()
        TVControlPnl.pnlATAGraph.Controls.Clear()

        Dim table As New TableLayoutPanel
        table.Dock = DockStyle.Fill
        table.ColumnCount = 4
        table.RowCount = 1
        table.BackColor = Color.Transparent

        For i = 1 To 4
            table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25))
        Next

        TVControlPnl.pnlATAGraph.Controls.Add(table)

        Dim letters = {"A", "B", "C", "D"}

        For Each letter In letters

            Dim columnPanel As New Panel
            columnPanel.Dock = DockStyle.Fill
            columnPanel.Padding = New Padding(10)
            columnPanel.BackColor = Color.Transparent

            ' Percentage label (boven)
            Dim lblPercent As New Label
            lblPercent.Dock = DockStyle.Top
            lblPercent.Height = 40
            lblPercent.TextAlign = ContentAlignment.MiddleCenter
            lblPercent.Font = New Font("Calibri", 14, FontStyle.Bold)
            lblPercent.ForeColor = Color.White
            lblPercent.Text = "0%"
            lblPercent.AutoSize = False
            lblPercent.Width = columnPanel.Width
            lblPercent.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

            ' Letter label (onder)
            Dim lblLetter As New Label
            lblLetter.Dock = DockStyle.Bottom
            lblLetter.Height = 40
            lblLetter.TextAlign = ContentAlignment.MiddleCenter
            lblLetter.Font = New Font("Calibri", 18, FontStyle.Regular)
            lblLetter.ForeColor = Color.LightGray
            lblLetter.Text = letter

            ' Balk (midden)
            Dim pnlBar As New Panel
            pnlBar.Dock = DockStyle.Bottom
            pnlBar.Height = 0
            pnlBar.BackColor = Color.White
            pnlBar.Visible = False

            columnPanel.Controls.Add(pnlBar)
            columnPanel.Controls.Add(lblLetter)
            columnPanel.Controls.Add(lblPercent)

            table.Controls.Add(columnPanel)

            ATAColumns(letter) = columnPanel
            ATABars(letter) = pnlBar
            ATAPercentLabels(letter) = lblPercent
            ATALetterLabels(letter) = lblLetter

            AddHandler columnPanel.Resize,
                Sub()
                    lblPercent.Width = columnPanel.Width
                End Sub
        Next
    End Sub

    Public Shared Sub UpdateAudienceChart(votes As Dictionary(Of String, Integer))
        If votes Is Nothing OrElse votes.Count = 0 Then
            ResetAudienceChart()
            Return
        End If

        Dim total = votes.Values.Sum()

        For Each letter In {"A", "B", "C", "D"}

            Dim percent As Integer = 0

            If total > 0 Then
                percent = CInt((votes(letter) / total) * 100)
            End If

            ATAPercentLabels(letter).Text = percent.ToString() & "%"

            Dim column = ATAColumns(letter)
            Dim bar = ATABars(letter)

            If percent = 0 Then
                bar.Visible = False
            Else
                bar.Visible = True

                Dim maxHeight =
                column.Height -
                ATAPercentLabels(letter).Height -
                ATALetterLabels(letter).Height -
                20

                If maxHeight < 0 Then maxHeight = 0

                bar.Height = CInt((percent / 100.0) * maxHeight)
            End If
        Next
    End Sub

    Public Shared Sub ResetAudienceChart()
        Try
            For Each letter In {"A", "B", "C", "D"}
                ATAPercentLabels(letter).Text = "0%"
                ATABars(letter).Visible = False
                ATABars(letter).Height = 0
            Next
        Catch ex As Exception
            CoreConsole.LogMsgDate("[ATA] An error occured: ")
            CoreConsole.LogMsg(ex.Message)
        End Try
    End Sub

    Public Shared Sub UpdateAudienceLayout()
        Dim marginRight As Integer = CInt(TVControlPnl.ClientSize.Width * ATAAnimate.marginRightPercent)
        Dim marginTop As Integer = CInt(TVControlPnl.ClientSize.Height * ATAAnimate.marginTopPercent)
        Dim marginBottom As Integer = CInt(TVControlPnl.ClientSize.Height * ATAAnimate.marginBottomPercent)

        ' Hoogte van het panel aanpassen
        TVControlPnl.pnlATAGraph.Height = TVControlPnl.ClientSize.Height - marginTop - marginBottom

        ' Verticale positie
        TVControlPnl.pnlATAGraph.Top = marginTop

        ' Horizontale target positie
        ATAAnimate.targetX = TVControlPnl.ClientSize.Width - TVControlPnl.pnlATAGraph.Width - marginRight
    End Sub

    Public Shared Sub ResizeATAGraph()
        Dim graphHeight As Integer = TVControlPnl.pnlATAGraph.Height
        Dim graphWidth As Integer = TVControlPnl.pnlATAGraph.Width

        For Each letter In {"A", "B", "C", "D"}

            Dim column = ATAColumns(letter)
            Dim bar = ATABars(letter)
            Dim lblPercent = ATAPercentLabels(letter)
            Dim lblLetter = ATALetterLabels(letter)

            ' === FONT SCHAALT MEE MET HOOGTE ===
            Dim percentFontSize As Single = graphHeight * 0.04F
            Dim letterFontSize As Single = graphHeight * 0.05F

            lblPercent.Font = New Font("Calibri", percentFontSize, FontStyle.Bold)
            lblLetter.Font = New Font("Calibri", letterFontSize, FontStyle.Bold)

            ' === PERCENT LABEL HOOGTE ===
            lblPercent.Height = CInt(graphHeight * 0.12)

            ' === LETTER LABEL HOOGTE ===
            lblLetter.Height = CInt(graphHeight * 0.12)

        Next
    End Sub


    Public Sub blankSub()

    End Sub

End Class
