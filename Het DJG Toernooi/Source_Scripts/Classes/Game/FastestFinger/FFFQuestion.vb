﻿Public Class FFFQuestion

    Public Shared Sub GetQuestion(ByVal int As Integer)
        Select Case int
            Case 0
                Game.level = -1
                FFFServer.i = 0
                FFFServer.a = 0
                FFFServer.act = 0
                FFFServer.fff_points = 0
                FFFServer.fff_timemin = 0
                FFFServer.firstMan = True
                PlayerCheck.tie = 0
                FFFServer.lblSmallestScore.Text = "Smallest Score: 0"

                FFFServer.pl1_time = 9999
                FFFServer.pl2_time = 9999
                FFFServer.pl3_time = 9999
                FFFServer.pl4_time = 9999
                FFFServer.pl5_time = 9999
                FFFServer.pl6_time = 9999
                FFFServer.pl7_time = 9999
                FFFServer.pl8_time = 9999
                FFFServer.txtReceive.Clear()

                FFFServer.lblPoints.Text = "0"

                FFFServer.txtPL1_Answer.Clear()
                FFFServer.txtPL1_Points.Clear()
                FFFServer.txtPL2_Answer.Clear()
                FFFServer.txtPL2_Points.Clear()
                FFFServer.txtPL3_Answer.Clear()
                FFFServer.txtPL3_Points.Clear()
                FFFServer.txtPL4_Answer.Clear()
                FFFServer.txtPL4_Points.Clear()
                FFFServer.txtPL5_Answer.Clear()
                FFFServer.txtPL5_Points.Clear()
                FFFServer.txtPL6_Answer.Clear()
                FFFServer.txtPL6_Points.Clear()
                FFFServer.txtPL7_Answer.Clear()
                FFFServer.txtPL7_Points.Clear()
                FFFServer.txtPL8_Answer.Clear()
                FFFServer.txtPL8_Points.Clear()

                HostScreen.pnlAnswer.BackColor = Color.Black
                ControlPanel.txtA.BackColor = SystemColors.Control
                ControlPanel.txtB.BackColor = SystemColors.Control
                ControlPanel.txtC.BackColor = SystemColors.Control
                ControlPanel.txtD.BackColor = SystemColors.Control

                HostScreen.txtA.ForeColor = Color.White
                HostScreen.txtB.ForeColor = Color.White
                HostScreen.txtC.ForeColor = Color.White
                HostScreen.txtD.ForeColor = Color.White
                HostScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
                HostScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
                HostScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
                HostScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
                GuestScreen.txtA.ForeColor = Color.White
                GuestScreen.txtB.ForeColor = Color.White
                GuestScreen.txtC.ForeColor = Color.White
                GuestScreen.txtD.ForeColor = Color.White
                GuestScreen.pnlA.BackgroundImage = QuestionStrap.GetTexture(2)
                GuestScreen.pnlB.BackgroundImage = QuestionStrap.GetTexture(3)
                GuestScreen.pnlC.BackgroundImage = QuestionStrap.GetTexture(2)
                GuestScreen.pnlD.BackgroundImage = QuestionStrap.GetTexture(3)
                TVControlPnl.txtA.ForeColor = Color.White
                TVControlPnl.txtB.ForeColor = Color.White
                TVControlPnl.txtC.ForeColor = Color.White
                TVControlPnl.txtD.ForeColor = Color.White
                HostScreen.txtATAa.ForeColor = Color.White
                HostScreen.txtATAb.ForeColor = Color.White
                HostScreen.txtATAc.ForeColor = Color.White
                HostScreen.txtATAd.ForeColor = Color.White
                GuestScreen.txtATAa.ForeColor = Color.White
                GuestScreen.txtATAb.ForeColor = Color.White
                GuestScreen.txtATAc.ForeColor = Color.White
                GuestScreen.txtATAd.ForeColor = Color.White

                HostScreen.txtATAa.Text = ""
                HostScreen.txtATAb.Text = ""
                HostScreen.txtATAc.Text = ""
                HostScreen.txtATAd.Text = ""
                GuestScreen.txtATAa.Text = ""
                GuestScreen.txtATAb.Text = ""
                GuestScreen.txtATAc.Text = ""
                GuestScreen.txtATAd.Text = ""
                TVControlPnl.txtA.Text = ""
                TVControlPnl.txtB.Text = ""
                TVControlPnl.txtC.Text = ""
                TVControlPnl.txtD.Text = ""
                HostScreen.txtA.Text = ""
                HostScreen.txtB.Text = ""
                HostScreen.txtC.Text = ""
                HostScreen.txtD.Text = ""
                GuestScreen.txtA.Text = ""
                GuestScreen.txtB.Text = ""
                GuestScreen.txtC.Text = ""
                GuestScreen.txtD.Text = ""

                TVControlPnl.picTree.BackgroundImage = MoneyTreeCore.GetTreeImage()
                TVControlPnl.picLifeline1.Visible = False
                TVControlPnl.picLifeline2.Visible = False
                TVControlPnl.picLifeline3.Visible = False
                TVControlPnl.picLifeline4.Visible = False

                TVControlPnl.txtPL1_Name.Text = FFFServer.txtPL1_Name.Text
                TVControlPnl.txtPL1_Points.Text = ""
                TVControlPnl.pnlPL1.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL1_Name.ForeColor = Color.White
                TVControlPnl.txtPL1_Points.ForeColor = Color.White

                TVControlPnl.txtPL2_Name.Text = FFFServer.txtPL2_Name.Text
                TVControlPnl.txtPL2_Points.Text = ""
                TVControlPnl.pnlPL2.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL2_Name.ForeColor = Color.White
                TVControlPnl.txtPL2_Points.ForeColor = Color.White

                TVControlPnl.txtPL3_Name.Text = FFFServer.txtPL3_Name.Text
                TVControlPnl.txtPL3_Points.Text = ""
                TVControlPnl.pnlPL3.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL3_Name.ForeColor = Color.White
                TVControlPnl.txtPL3_Points.ForeColor = Color.White

                TVControlPnl.txtPL4_Name.Text = FFFServer.txtPL4_Name.Text
                TVControlPnl.txtPL4_Points.Text = ""
                TVControlPnl.pnlPL4.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL4_Name.ForeColor = Color.White
                TVControlPnl.txtPL4_Points.ForeColor = Color.White

                TVControlPnl.txtPL5_Name.Text = FFFServer.txtPL5_Name.Text
                TVControlPnl.txtPL5_Points.Text = ""
                TVControlPnl.pnlPL5.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL5_Name.ForeColor = Color.White
                TVControlPnl.txtPL5_Points.ForeColor = Color.White

                TVControlPnl.txtPL6_Name.Text = FFFServer.txtPL6_Name.Text
                TVControlPnl.txtPL6_Points.Text = ""
                TVControlPnl.pnlPL6.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL6_Name.ForeColor = Color.White
                TVControlPnl.txtPL6_Points.ForeColor = Color.White

                TVControlPnl.txtPL7_Name.Text = FFFServer.txtPL7_Name.Text
                TVControlPnl.txtPL6_Points.Text = ""
                TVControlPnl.pnlPL7.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL7_Name.ForeColor = Color.White
                TVControlPnl.txtPL6_Points.ForeColor = Color.White

                TVControlPnl.txtPL8_Name.Text = FFFServer.txtPL8_Name.Text
                TVControlPnl.txtPL8_Points.Text = ""
                TVControlPnl.pnlPL8.BackgroundImage = My.Resources.fff_idle_new
                TVControlPnl.txtPL8_Name.ForeColor = Color.White
                TVControlPnl.txtPL8_Points.ForeColor = Color.White

                TVControlPnl.picA.BackgroundImage = QuestionStrap.GetTexture(2)
                TVControlPnl.picB.BackgroundImage = QuestionStrap.GetTexture(3)
                TVControlPnl.picC.BackgroundImage = QuestionStrap.GetTexture(2)
                TVControlPnl.picD.BackgroundImage = QuestionStrap.GetTexture(3)
                TVControlPnl.tmrFlash.Stop()
                Dim q As New QDatabase
                q.newQuestion()

                With Sounds.fff_question
                    .URL = Sounds.SoundsPath + Profile.Options.snd_F_ReadQuestion
                    .controls.play()
                End With

                FFFServer.UpdateList("/clear", True)
            Case 1
                FFFServer.correctAnswer = ControlPanel.lblAnswer.Text

                HostScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
                TVControlPnl.txtQuestion.Text = ControlPanel.txtQuestion.Text
                GuestScreen.txtQuestion.Text = ControlPanel.txtQuestion.Text
                HostScreen.lblAnswer.Text = ControlPanel.lblAnswer.Text
                HostScreen.txtExplain.Text = ControlPanel.txtExplain.Text
                ControlPanel.chkShowQuestion.Checked = True
                FFFServer.UpdateList("/q1#" + ControlPanel.txtQuestion.Text, True)
        End Select
    End Sub

    Public Shared Sub Fill()
        Dim answer As String
        Try
            answer = FFFServer.correctAnswer
        Catch ex As Exception
            answer = ControlPanel.lblAnswer.Text
            CoreConsole.LogMsgDate("[FFF] Cannot get correct order from main source. Using secondary.")
        End Try

        Dim order1 As String
        Dim order2 As String
        Dim order3 As String
        Dim order4 As String

        Select Case answer.Chars(0)
            Case "A"
                order1 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order1 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order1 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order1 = "D: " + ControlPanel.txtD.Text
        End Select

        Select Case answer.Chars(1)
            Case "A"
                order2 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order2 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order2 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order2 = "D: " + ControlPanel.txtD.Text
        End Select

        Select Case answer.Chars(2)
            Case "A"
                order3 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order3 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order3 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order3 = "D: " + ControlPanel.txtD.Text
        End Select

        Select Case answer.Chars(3)
            Case "A"
                order4 = "A: " + ControlPanel.txtA.Text
            Case "B"
                order4 = "B: " + ControlPanel.txtB.Text
            Case "C"
                order4 = "C: " + ControlPanel.txtC.Text
            Case "D"
                order4 = "D: " + ControlPanel.txtD.Text
        End Select

        TVControlPnl.lblFFFQuestion.Text = ControlPanel.txtQuestion.Text
        TVControlPnl.txtFFFOrder1.Text = order1
        TVControlPnl.txtFFFOrder2.Text = order2
        TVControlPnl.txtFFFOrder3.Text = order3
        TVControlPnl.txtFFFOrder4.Text = order4
    End Sub

End Class
