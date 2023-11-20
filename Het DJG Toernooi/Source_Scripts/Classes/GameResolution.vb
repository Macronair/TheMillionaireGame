Public Class GameResolution

    Public Shared CurrentRes As Integer = 720

    Public Shared Sub ChangeTo720(ByVal screen As Integer)
        CurrentRes = 720

        Select Case screen
            Case 1
#Region "TV"
                ' Window size
                TVControlPnl.Size = New Size(1296, 759)

                ' Fastest Finger First
                TVControlPnl.pnlPL1.Location = New Point(0, 129)
                TVControlPnl.pnlPL2.Location = New Point(0, 182)
                TVControlPnl.pnlPL3.Location = New Point(0, 235)
                TVControlPnl.pnlPL4.Location = New Point(0, 288)
                TVControlPnl.pnlPL5.Location = New Point(0, 341)
                TVControlPnl.pnlPL6.Location = New Point(0, 394)
                TVControlPnl.pnlPL7.Location = New Point(0, 447)
                TVControlPnl.pnlPL8.Location = New Point(0, 500)
                TVControlPnl.txtPL1_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL2_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL3_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL4_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL5_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL6_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL7_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL8_Name.Location = New Point(379, 8)
                TVControlPnl.txtPL1_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL2_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL3_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL4_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL5_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL6_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL7_Points.Location = New Point(783, 8)
                TVControlPnl.txtPL8_Points.Location = New Point(783, 8)
                TVControlPnl.pnlFFFPlayers.Location = New Point(0, 0)

                TVControlPnl.pnlPL1.Size = New Size(1280, 51)
                TVControlPnl.pnlPL2.Size = New Size(1280, 51)
                TVControlPnl.pnlPL3.Size = New Size(1280, 51)
                TVControlPnl.pnlPL4.Size = New Size(1280, 51)
                TVControlPnl.pnlPL5.Size = New Size(1280, 51)
                TVControlPnl.pnlPL6.Size = New Size(1280, 51)
                TVControlPnl.pnlPL7.Size = New Size(1280, 51)
                TVControlPnl.pnlPL8.Size = New Size(1280, 51)
                TVControlPnl.txtPL1_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL2_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL3_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL4_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL5_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL6_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL7_Points.Size = New Size(105, 33)
                TVControlPnl.txtPL8_Points.Size = New Size(105, 33)
                TVControlPnl.pnlFFFPlayers.Size = New Size(1280, 720)

                TVControlPnl.txtPL1_Name.Font = New Font(TVControlPnl.txtPL1_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL2_Name.Font = New Font(TVControlPnl.txtPL2_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL3_Name.Font = New Font(TVControlPnl.txtPL3_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL4_Name.Font = New Font(TVControlPnl.txtPL4_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL5_Name.Font = New Font(TVControlPnl.txtPL5_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL6_Name.Font = New Font(TVControlPnl.txtPL6_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL7_Name.Font = New Font(TVControlPnl.txtPL7_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL8_Name.Font = New Font(TVControlPnl.txtPL8_Name.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL1_Points.Font = New Font(TVControlPnl.txtPL1_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL2_Points.Font = New Font(TVControlPnl.txtPL2_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL3_Points.Font = New Font(TVControlPnl.txtPL3_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL4_Points.Font = New Font(TVControlPnl.txtPL4_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL5_Points.Font = New Font(TVControlPnl.txtPL5_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL6_Points.Font = New Font(TVControlPnl.txtPL6_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL7_Points.Font = New Font(TVControlPnl.txtPL7_Points.Font.FontFamily, 20, FontStyle.Bold)
                TVControlPnl.txtPL8_Points.Font = New Font(TVControlPnl.txtPL8_Points.Font.FontFamily, 20, FontStyle.Bold)

                ' Question
                TVControlPnl.pnlQuestion.Location = New Point(0, 470)
                TVControlPnl.picQuestion.Location = New Point(0, 9)
                TVControlPnl.txtQuestion.Location = New Point(132, 4)
                TVControlPnl.picA.Location = New Point(0, 109)
                TVControlPnl.picB.Location = New Point(642, 109)
                TVControlPnl.picC.Location = New Point(0, 168)
                TVControlPnl.picD.Location = New Point(642, 168)
                TVControlPnl.txtA.Location = New Point(122, 5)
                TVControlPnl.txtB.Location = New Point(40, 5)
                TVControlPnl.txtC.Location = New Point(122, 5)
                TVControlPnl.txtD.Location = New Point(40, 5)

                TVControlPnl.pnlQuestion.Size = New Size(1280, 229)
                TVControlPnl.picQuestion.Size = New Size(1280, 93)
                TVControlPnl.txtQuestion.Size = New Size(1016, 82)
                TVControlPnl.picA.Size = New Size(641, 57)
                TVControlPnl.picB.Size = New Size(641, 57)
                TVControlPnl.picC.Size = New Size(641, 57)
                TVControlPnl.picD.Size = New Size(641, 57)
                TVControlPnl.txtA.Size = New Size(476, 46)
                TVControlPnl.txtB.Size = New Size(476, 46)
                TVControlPnl.txtC.Size = New Size(476, 46)
                TVControlPnl.txtD.Size = New Size(476, 46)

                TVControlPnl.txtQuestion.Font = New Font(TVControlPnl.txtQuestion.Font.FontFamily, 20)
                TVControlPnl.txtA.Font = New Font(TVControlPnl.txtA.Font.FontFamily, 24)
                TVControlPnl.txtB.Font = New Font(TVControlPnl.txtB.Font.FontFamily, 24)
                TVControlPnl.txtC.Font = New Font(TVControlPnl.txtC.Font.FontFamily, 24)
                TVControlPnl.txtD.Font = New Font(TVControlPnl.txtD.Font.FontFamily, 24)

                ' Money Tree / FFF Answers
                TVControlPnl.picTree.Location = New Point(48, -28)
                TVControlPnl.pnlFFFOrder1.Location = New Point(689, 409)
                TVControlPnl.pnlFFFOrder2.Location = New Point(689, 463)
                TVControlPnl.pnlFFFOrder3.Location = New Point(689, 517)
                TVControlPnl.pnlFFFOrder4.Location = New Point(689, 571)
                TVControlPnl.txtFFFOrder1.Location = New Point(33, 0)
                TVControlPnl.txtFFFOrder2.Location = New Point(33, 0)
                TVControlPnl.txtFFFOrder3.Location = New Point(33, 0)
                TVControlPnl.txtFFFOrder4.Location = New Point(33, 0)
                TVControlPnl.lblFFFQuestion.Location = New Point(831, 98)
                TVControlPnl.picLifeline1.Location = New Point(846, 67)
                TVControlPnl.picLifeline2.Location = New Point(926, 67)
                TVControlPnl.picLifeline3.Location = New Point(1006, 67)
                TVControlPnl.picLifeline4.Location = New Point(1086, 67)

                TVControlPnl.picTree.Size = New Size(1232, 748)
                TVControlPnl.pnlFFFOrder1.Size = New Size(580, 48)
                TVControlPnl.pnlFFFOrder2.Size = New Size(580, 48)
                TVControlPnl.pnlFFFOrder3.Size = New Size(580, 48)
                TVControlPnl.pnlFFFOrder4.Size = New Size(580, 48)
                TVControlPnl.txtFFFOrder1.Size = New Size(438, 48)
                TVControlPnl.txtFFFOrder2.Size = New Size(438, 48)
                TVControlPnl.txtFFFOrder3.Size = New Size(438, 48)
                TVControlPnl.txtFFFOrder4.Size = New Size(438, 48)
                TVControlPnl.lblFFFQuestion.Size = New Size(367, 272)
                TVControlPnl.picLifeline1.Size = New Size(74, 48)
                TVControlPnl.picLifeline2.Size = New Size(74, 48)
                TVControlPnl.picLifeline3.Size = New Size(74, 48)
                TVControlPnl.picLifeline4.Size = New Size(74, 48)

                TVControlPnl.txtFFFOrder1.Font = New Font(TVControlPnl.txtFFFOrder1.Font.FontFamily, 22)
                TVControlPnl.txtFFFOrder2.Font = New Font(TVControlPnl.txtFFFOrder2.Font.FontFamily, 22)
                TVControlPnl.txtFFFOrder3.Font = New Font(TVControlPnl.txtFFFOrder3.Font.FontFamily, 22)
                TVControlPnl.txtFFFOrder4.Font = New Font(TVControlPnl.txtFFFOrder4.Font.FontFamily, 22)
                TVControlPnl.lblFFFQuestion.Font = New Font(TVControlPnl.lblFFFQuestion.Font.FontFamily, 24)

                ' Lifeline icon above question
                TVControlPnl.picLifelineUse.Location = New Point(606, 418)
                TVControlPnl.picLifelineUse.Size = New Size(68, 48)

                ' Phone a Friend
                TVControlPnl.pnlTime.Location = New Point(25, 274)
                TVControlPnl.lblTime.Location = New Point(74, -3)
                TVControlPnl.PictureBox1.Location = New Point(13, 13)

                TVControlPnl.pnlTime.Size = New Size(204, 63)
                TVControlPnl.lblTime.Size = New Size(159, 71)
                TVControlPnl.PictureBox1.Size = New Size(62, 39)

                TVControlPnl.lblTime.Font = New Font(TVControlPnl.lblTime.Font.FontFamily, 48)

                ' Ask the Audience
                TVControlPnl.grpATA.Location = New Point(25, 51)
                TVControlPnl.PictureBox2.Location = New Point(13, 62)
                TVControlPnl.lblATA_A.Location = New Point(81, 15)
                TVControlPnl.lblATA_B.Location = New Point(81, 48)
                TVControlPnl.lblATA_C.Location = New Point(81, 80)
                TVControlPnl.lblATA_D.Location = New Point(81, 112)

                TVControlPnl.grpATA.Size = New Size(233, 165)
                TVControlPnl.PictureBox2.Size = New Size(64, 43)

                TVControlPnl.lblATA_A.Font = New Font(TVControlPnl.lblATA_A.Font.FontFamily, 24)
                TVControlPnl.lblATA_B.Font = New Font(TVControlPnl.lblATA_B.Font.FontFamily, 24)
                TVControlPnl.lblATA_C.Font = New Font(TVControlPnl.lblATA_C.Font.FontFamily, 24)
                TVControlPnl.lblATA_D.Font = New Font(TVControlPnl.lblATA_D.Font.FontFamily, 24)

                ' Winning Strap
                TVControlPnl.pnlStrap.Location = New Point(0, 573)
                TVControlPnl.lblAmount.Location = New Point(476, 5)
                TVControlPnl.pnlTotal.Location = New Point(0, 506)
                TVControlPnl.Label1.Location = New Point(473, 6)

                TVControlPnl.pnlStrap.Size = New Size(1280, 83)
                TVControlPnl.lblAmount.Size = New Size(328, 75)
                TVControlPnl.pnlTotal.Size = New Size(1280, 62)
                TVControlPnl.Label1.Size = New Size(335, 53)

                TVControlPnl.lblAmount.Font = New Font(TVControlPnl.lblAmount.Font.FontFamily, 36)
                TVControlPnl.Label1.Font = New Font(TVControlPnl.Label1.Font.FontFamily, 27, FontStyle.Bold)

                ' FFF Winner
                TVControlPnl.pnlFFFWinner.Location = New Point(0, 569)
                TVControlPnl.lblFFFWinnerName.Location = New Point(381, 10)
                TVControlPnl.lblFFFWinnerPoints.Location = New Point(789, 10)

                TVControlPnl.pnlFFFWinner.Size = New Size(1280, 57)
                TVControlPnl.lblFFFWinnerPoints.Size = New Size(111, 36)

                TVControlPnl.lblFFFWinnerName.Font = New Font(TVControlPnl.lblFFFWinnerName.Font.FontFamily, 22, FontStyle.Bold)
                TVControlPnl.lblFFFWinnerPoints.Font = New Font(TVControlPnl.lblFFFWinnerPoints.Font.FontFamily, 22, FontStyle.Bold)
#End Region
            Case 2
#Region "Host Screen"
                HostScreen.Size = New Size(1296, 759)

                'Question
                HostScreen.picQuestion.Location = New Point(0, 492)
                HostScreen.txtQuestion.Location = New Point(132, 11)
                HostScreen.pnlA.Location = New Point(0, 592)
                HostScreen.pnlB.Location = New Point(640, 592)
                HostScreen.pnlC.Location = New Point(0, 651)
                HostScreen.pnlD.Location = New Point(640, 651)
                HostScreen.txtA.Location = New Point(122, 5)
                HostScreen.txtB.Location = New Point(41, 5)
                HostScreen.txtC.Location = New Point(122, 5)
                HostScreen.txtD.Location = New Point(41, 5)

                HostScreen.txtQuestion.Font = New Font(HostScreen.txtQuestion.Font.FontFamily, 20)
                HostScreen.txtA.Font = New Font(HostScreen.txtA.Font.FontFamily, 24)
                HostScreen.txtB.Font = New Font(HostScreen.txtB.Font.FontFamily, 24)
                HostScreen.txtC.Font = New Font(HostScreen.txtC.Font.FontFamily, 24)
                HostScreen.txtD.Font = New Font(HostScreen.txtD.Font.FontFamily, 24)

                HostScreen.picQuestion.Size = New Size(1280, 93)
                HostScreen.txtQuestion.Size = New Size(1016, 69)
                HostScreen.pnlA.Size = New Size(641, 57)
                HostScreen.pnlB.Size = New Size(641, 57)
                HostScreen.pnlC.Size = New Size(641, 57)
                HostScreen.pnlD.Size = New Size(641, 57)
                HostScreen.txtA.Size = New Size(476, 46)
                HostScreen.txtB.Size = New Size(476, 46)
                HostScreen.txtC.Size = New Size(476, 46)
                HostScreen.txtD.Size = New Size(476, 46)

                'Tree
                HostScreen.picTree.Location = New Point(367, -51)
                HostScreen.picLifeline1.Location = New Point(580, 9)
                HostScreen.picLifeline2.Location = New Point(680, 9)
                HostScreen.picLifeline3.Location = New Point(780, 9)
                HostScreen.picLifeline4.Location = New Point(880, 9)

                HostScreen.picTree.Size = New Size(921, 540)
                HostScreen.picLifeline1.Size = New Size(94, 65)
                HostScreen.picLifeline2.Size = New Size(94, 65)
                HostScreen.picLifeline3.Size = New Size(94, 65)
                HostScreen.picLifeline4.Size = New Size(94, 65)

                'Answer
                HostScreen.pnlAnswer.Location = New Point(924, 442)
                HostScreen.lblAnswer.Location = New Point(12, 11)

                HostScreen.lblAnswer.Font = New Font(HostScreen.lblAnswer.Font.FontFamily, 16)

                HostScreen.pnlAnswer.Size = New Size(47, 46)

                'Ask the Audience
                HostScreen.txtATAa.Location = New Point(776, 78)
                HostScreen.txtATAb.Location = New Point(776, 120)
                HostScreen.txtATAc.Location = New Point(776, 162)
                HostScreen.txtATAd.Location = New Point(776, 204)

                HostScreen.txtATAa.Font = New Font(HostScreen.txtATAa.Font.FontFamily, 24)
                HostScreen.txtATAb.Font = New Font(HostScreen.txtATAb.Font.FontFamily, 24)
                HostScreen.txtATAc.Font = New Font(HostScreen.txtATAc.Font.FontFamily, 24)
                HostScreen.txtATAd.Font = New Font(HostScreen.txtATAd.Font.FontFamily, 24)

                HostScreen.txtATAa.Size = New Size(182, 36)
                HostScreen.txtATAb.Size = New Size(182, 36)
                HostScreen.txtATAc.Size = New Size(182, 36)
                HostScreen.txtATAd.Size = New Size(182, 36)

                'Plus One
                HostScreen.lblTime.Location = New Point(793, 284)
                HostScreen.lblTime.Font = New Font(HostScreen.lblTime.Font.FontFamily, 72)

                'Host Panels
                HostScreen.pnlCorrect.Location = New Point(9, 4)
                HostScreen.pnlWrong.Location = New Point(9, 59)
                HostScreen.pnlCurrent.Location = New Point(206, 4)
                HostScreen.pnlDrop.Location = New Point(9, 114)
                HostScreen.pnlQLeft.Location = New Point(206, 59)
                HostScreen.lblCorrect.Location = New Point(9, 12)
                HostScreen.lblWrong.Location = New Point(9, 12)
                HostScreen.lblCurrent.Location = New Point(9, 12)
                HostScreen.lblDrop.Location = New Point(9, 12)
                HostScreen.lblQLeft.Location = New Point(9, 12)
                HostScreen.picCorrect.Location = New Point(153, 9)
                HostScreen.picWrong.Location = New Point(153, 9)
                HostScreen.picCurrent.Location = New Point(153, 9)
                HostScreen.picQLeft.Location = New Point(153, 9)

                HostScreen.lblCorrect.Font = New Font(HostScreen.lblCorrect.Font.FontFamily, 16)
                HostScreen.lblWrong.Font = New Font(HostScreen.lblWrong.Font.FontFamily, 16)
                HostScreen.lblCurrent.Font = New Font(HostScreen.lblCurrent.Font.FontFamily, 16)
                HostScreen.lblDrop.Font = New Font(HostScreen.lblDrop.Font.FontFamily, 16)
                HostScreen.lblQLeft.Font = New Font(HostScreen.lblQLeft.Font.FontFamily, 16)

                HostScreen.pnlCorrect.Size = New Size(191, 49)
                HostScreen.pnlWrong.Size = New Size(191, 49)
                HostScreen.pnlCurrent.Size = New Size(191, 49)
                HostScreen.pnlDrop.Size = New Size(191, 49)
                HostScreen.pnlQLeft.Size = New Size(191, 49)
                HostScreen.picCorrect.Size = New Size(31, 31)
                HostScreen.picWrong.Size = New Size(31, 31)
                HostScreen.picCurrent.Size = New Size(31, 31)
                HostScreen.picQLeft.Size = New Size(31, 31)

                'Host Info
                HostScreen.lblHostMsg.Location = New Point(12, 169)
                HostScreen.txtExplain.Location = New Point(12, 333)

                HostScreen.lblHostMsg.Font = New Font(HostScreen.lblHostMsg.Font.FontFamily, 16)
                HostScreen.txtExplain.Font = New Font(HostScreen.txtExplain.Font.FontFamily, 14)

                HostScreen.lblHostMsg.Size = New Size(746, 161)
                HostScreen.txtExplain.Size = New Size(746, 155)

                'General
                HostScreen.lblExplainRules.Location = New Point(400, 17)
                HostScreen.lblWalkedAway.Location = New Point(400, 35)

                HostScreen.lblExplainRules.Font = New Font(HostScreen.lblExplainRules.Font.FontFamily, 12)
                HostScreen.lblWalkedAway.Font = New Font(HostScreen.lblWalkedAway.Font.FontFamily, 12)

                'Total Winnings
                HostScreen.txtWinnings.Location = New Point(206, 115)

                HostScreen.txtWinnings.Font = New Font(HostScreen.txtWinnings.Font.FontFamily, 18)

                HostScreen.txtWinnings.Size = New Size(288, 46)
#End Region
            Case 3
#Region "Guest Screen"
                GuestScreen.Size = New Size(1296, 759)

                'Question
                GuestScreen.picQuestion.Location = New Point(0, 492)
                GuestScreen.txtQuestion.Location = New Point(132, 11)
                GuestScreen.pnlA.Location = New Point(0, 592)
                GuestScreen.pnlB.Location = New Point(640, 592)
                GuestScreen.pnlC.Location = New Point(0, 651)
                GuestScreen.pnlD.Location = New Point(640, 651)
                GuestScreen.txtA.Location = New Point(122, 5)
                GuestScreen.txtB.Location = New Point(41, 5)
                GuestScreen.txtC.Location = New Point(122, 5)
                GuestScreen.txtD.Location = New Point(41, 5)

                GuestScreen.txtQuestion.Font = New Font(GuestScreen.txtQuestion.Font.FontFamily, 20)
                GuestScreen.txtA.Font = New Font(GuestScreen.txtA.Font.FontFamily, 24)
                GuestScreen.txtB.Font = New Font(GuestScreen.txtB.Font.FontFamily, 24)
                GuestScreen.txtC.Font = New Font(GuestScreen.txtC.Font.FontFamily, 24)
                GuestScreen.txtD.Font = New Font(GuestScreen.txtD.Font.FontFamily, 24)

                GuestScreen.picQuestion.Size = New Size(1280, 93)
                GuestScreen.txtQuestion.Size = New Size(1016, 69)
                GuestScreen.pnlA.Size = New Size(641, 57)
                GuestScreen.pnlB.Size = New Size(641, 57)
                GuestScreen.pnlC.Size = New Size(641, 57)
                GuestScreen.pnlD.Size = New Size(641, 57)
                GuestScreen.txtA.Size = New Size(476, 46)
                GuestScreen.txtB.Size = New Size(476, 46)
                GuestScreen.txtC.Size = New Size(476, 46)
                GuestScreen.txtD.Size = New Size(476, 46)

                'Tree
                GuestScreen.picTree.Location = New Point(367, -51)
                GuestScreen.picLifeline1.Location = New Point(580, 9)
                GuestScreen.picLifeline2.Location = New Point(680, 9)
                GuestScreen.picLifeline3.Location = New Point(780, 9)
                GuestScreen.picLifeline4.Location = New Point(880, 9)

                GuestScreen.picTree.Size = New Size(921, 540)
                GuestScreen.picLifeline1.Size = New Size(94, 65)
                GuestScreen.picLifeline2.Size = New Size(94, 65)
                GuestScreen.picLifeline3.Size = New Size(94, 65)
                GuestScreen.picLifeline4.Size = New Size(94, 65)

                'Ask the Audience
                GuestScreen.txtATAa.Location = New Point(776, 78)
                GuestScreen.txtATAb.Location = New Point(776, 120)
                GuestScreen.txtATAc.Location = New Point(776, 162)
                GuestScreen.txtATAd.Location = New Point(776, 204)

                GuestScreen.txtATAa.Font = New Font(GuestScreen.txtATAa.Font.FontFamily, 24)
                GuestScreen.txtATAb.Font = New Font(GuestScreen.txtATAb.Font.FontFamily, 24)
                GuestScreen.txtATAc.Font = New Font(GuestScreen.txtATAc.Font.FontFamily, 24)
                GuestScreen.txtATAd.Font = New Font(GuestScreen.txtATAd.Font.FontFamily, 24)

                GuestScreen.txtATAa.Size = New Size(182, 36)
                GuestScreen.txtATAb.Size = New Size(182, 36)
                GuestScreen.txtATAc.Size = New Size(182, 36)
                GuestScreen.txtATAd.Size = New Size(182, 36)

                'Plus One
                GuestScreen.lblTime.Location = New Point(793, 284)
                GuestScreen.lblTime.Font = New Font(GuestScreen.lblTime.Font.FontFamily, 72)
#End Region
        End Select
    End Sub

    Public Shared Sub ChangeTo1080(ByVal screen As Integer)
        CurrentRes = 1080

        Select Case screen
            Case 1
#Region "TV"
                ' Window size
                TVControlPnl.Size = New Size(1936, 1100)

                ' Fastest Finger First
                TVControlPnl.pnlPL1.Location = New Point(0, 217)
                TVControlPnl.pnlPL2.Location = New Point(0, 298)
                TVControlPnl.pnlPL3.Location = New Point(0, 379)
                TVControlPnl.pnlPL4.Location = New Point(0, 460)
                TVControlPnl.pnlPL5.Location = New Point(0, 541)
                TVControlPnl.pnlPL6.Location = New Point(0, 622)
                TVControlPnl.pnlPL7.Location = New Point(0, 703)
                TVControlPnl.pnlPL8.Location = New Point(0, 784)
                TVControlPnl.txtPL1_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL2_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL3_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL4_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL5_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL6_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL7_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL8_Name.Location = New Point(570, 15)
                TVControlPnl.txtPL1_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL2_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL3_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL4_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL5_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL6_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL7_Points.Location = New Point(1237, 15)
                TVControlPnl.txtPL8_Points.Location = New Point(1237, 15)
                TVControlPnl.pnlFFFPlayers.Location = New Point(0, 0)

                TVControlPnl.pnlPL1.Size = New Size(1920, 80)
                TVControlPnl.pnlPL2.Size = New Size(1920, 80)
                TVControlPnl.pnlPL3.Size = New Size(1920, 80)
                TVControlPnl.pnlPL4.Size = New Size(1920, 80)
                TVControlPnl.pnlPL5.Size = New Size(1920, 80)
                TVControlPnl.pnlPL6.Size = New Size(1920, 80)
                TVControlPnl.pnlPL7.Size = New Size(1920, 80)
                TVControlPnl.pnlPL8.Size = New Size(1920, 80)
                TVControlPnl.txtPL1_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL2_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL3_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL4_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL5_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL6_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL7_Points.Size = New Size(114, 49)
                TVControlPnl.txtPL8_Points.Size = New Size(114, 49)
                TVControlPnl.pnlFFFPlayers.Size = New Size(1920, 1080)

                TVControlPnl.txtPL1_Name.Font = New Font(TVControlPnl.txtPL1_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL2_Name.Font = New Font(TVControlPnl.txtPL2_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL3_Name.Font = New Font(TVControlPnl.txtPL3_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL4_Name.Font = New Font(TVControlPnl.txtPL4_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL5_Name.Font = New Font(TVControlPnl.txtPL5_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL6_Name.Font = New Font(TVControlPnl.txtPL6_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL7_Name.Font = New Font(TVControlPnl.txtPL7_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL8_Name.Font = New Font(TVControlPnl.txtPL8_Name.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL1_Points.Font = New Font(TVControlPnl.txtPL1_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL2_Points.Font = New Font(TVControlPnl.txtPL2_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL3_Points.Font = New Font(TVControlPnl.txtPL3_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL4_Points.Font = New Font(TVControlPnl.txtPL4_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL5_Points.Font = New Font(TVControlPnl.txtPL5_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL6_Points.Font = New Font(TVControlPnl.txtPL6_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL7_Points.Font = New Font(TVControlPnl.txtPL7_Points.Font.FontFamily, 30, FontStyle.Bold)
                TVControlPnl.txtPL8_Points.Font = New Font(TVControlPnl.txtPL8_Points.Font.FontFamily, 30, FontStyle.Bold)

                ' Question
                TVControlPnl.pnlQuestion.Location = New Point(0, 710)
                TVControlPnl.picQuestion.Location = New Point(0, 9)
                TVControlPnl.txtQuestion.Location = New Point(198, 7)
                TVControlPnl.picA.Location = New Point(0, 153)
                TVControlPnl.picB.Location = New Point(963, 153)
                TVControlPnl.picC.Location = New Point(0, 239)
                TVControlPnl.picD.Location = New Point(963, 239)
                TVControlPnl.txtA.Location = New Point(185, 7)
                TVControlPnl.txtB.Location = New Point(60, 7)
                TVControlPnl.txtC.Location = New Point(185, 7)
                TVControlPnl.txtD.Location = New Point(60, 7)

                TVControlPnl.pnlQuestion.Size = New Size(1920, 345)
                TVControlPnl.picQuestion.Size = New Size(1920, 141)
                TVControlPnl.txtQuestion.Size = New Size(1524, 123)
                TVControlPnl.picA.Size = New Size(963, 87)
                TVControlPnl.picB.Size = New Size(963, 87)
                TVControlPnl.picC.Size = New Size(963, 87)
                TVControlPnl.picD.Size = New Size(963, 87)
                TVControlPnl.txtA.Size = New Size(714, 69)
                TVControlPnl.txtB.Size = New Size(714, 69)
                TVControlPnl.txtC.Size = New Size(714, 69)
                TVControlPnl.txtD.Size = New Size(714, 69)

                TVControlPnl.txtQuestion.Font = New Font(TVControlPnl.txtQuestion.Font.FontFamily, 32)
                TVControlPnl.txtA.Font = New Font(TVControlPnl.txtA.Font.FontFamily, 34)
                TVControlPnl.txtB.Font = New Font(TVControlPnl.txtB.Font.FontFamily, 34)
                TVControlPnl.txtC.Font = New Font(TVControlPnl.txtC.Font.FontFamily, 34)
                TVControlPnl.txtD.Font = New Font(TVControlPnl.txtD.Font.FontFamily, 34)

                ' Money Tree / FFF Answers
                TVControlPnl.picTree.Location = New Point(73, 0)
                TVControlPnl.pnlFFFOrder1.Location = New Point(978, 560)
                TVControlPnl.pnlFFFOrder2.Location = New Point(978, 635)
                TVControlPnl.pnlFFFOrder3.Location = New Point(978, 710)
                TVControlPnl.pnlFFFOrder4.Location = New Point(978, 785)
                TVControlPnl.txtFFFOrder1.Location = New Point(33, 0)
                TVControlPnl.txtFFFOrder2.Location = New Point(33, 0)
                TVControlPnl.txtFFFOrder3.Location = New Point(33, 0)
                TVControlPnl.txtFFFOrder4.Location = New Point(33, 0)
                TVControlPnl.lblFFFQuestion.Location = New Point(1265, 135)
                TVControlPnl.picLifeline1.Location = New Point(1320, 85)
                TVControlPnl.picLifeline2.Location = New Point(1437, 85)
                TVControlPnl.picLifeline3.Location = New Point(1554, 85)
                TVControlPnl.picLifeline4.Location = New Point(1671, 85)

                TVControlPnl.picTree.Size = New Size(1848, 1080)
                TVControlPnl.pnlFFFOrder1.Size = New Size(870, 72)
                TVControlPnl.pnlFFFOrder2.Size = New Size(870, 72)
                TVControlPnl.pnlFFFOrder3.Size = New Size(870, 72)
                TVControlPnl.pnlFFFOrder4.Size = New Size(870, 72)
                TVControlPnl.txtFFFOrder1.Size = New Size(657, 72)
                TVControlPnl.txtFFFOrder2.Size = New Size(657, 72)
                TVControlPnl.txtFFFOrder3.Size = New Size(657, 72)
                TVControlPnl.txtFFFOrder4.Size = New Size(657, 72)
                TVControlPnl.lblFFFQuestion.Size = New Size(552, 408)
                TVControlPnl.picLifeline1.Size = New Size(111, 72)
                TVControlPnl.picLifeline2.Size = New Size(111, 72)
                TVControlPnl.picLifeline3.Size = New Size(111, 72)
                TVControlPnl.picLifeline4.Size = New Size(111, 72)

                TVControlPnl.txtFFFOrder1.Font = New Font(TVControlPnl.txtFFFOrder1.Font.FontFamily, 30)
                TVControlPnl.txtFFFOrder2.Font = New Font(TVControlPnl.txtFFFOrder2.Font.FontFamily, 30)
                TVControlPnl.txtFFFOrder3.Font = New Font(TVControlPnl.txtFFFOrder3.Font.FontFamily, 30)
                TVControlPnl.txtFFFOrder4.Font = New Font(TVControlPnl.txtFFFOrder4.Font.FontFamily, 30)
                TVControlPnl.lblFFFQuestion.Font = New Font(TVControlPnl.lblFFFQuestion.Font.FontFamily, 34, FontStyle.Bold)

                ' Lifeline icon above question
                TVControlPnl.picLifelineUse.Location = New Point(909, 638)
                TVControlPnl.picLifelineUse.Size = New Size(102, 72)

                ' Phone a Friend
                TVControlPnl.pnlTime.Location = New Point(75, 365)
                TVControlPnl.lblTime.Location = New Point(105, -6)
                TVControlPnl.PictureBox1.Location = New Point(13, 18)

                TVControlPnl.pnlTime.Size = New Size(306, 96)
                TVControlPnl.lblTime.Size = New Size(240, 105)
                TVControlPnl.PictureBox1.Size = New Size(93, 60)

                TVControlPnl.lblTime.Font = New Font(TVControlPnl.lblTime.Font.FontFamily, 72)

                ' Ask the Audience
                TVControlPnl.grpATA.Location = New Point(75, 84)
                TVControlPnl.PictureBox2.Location = New Point(13, 91)
                TVControlPnl.lblATA_A.Location = New Point(119, 6)
                TVControlPnl.lblATA_B.Location = New Point(119, 65)
                TVControlPnl.lblATA_C.Location = New Point(119, 124)
                TVControlPnl.lblATA_D.Location = New Point(119, 183)

                TVControlPnl.grpATA.Size = New Size(351, 249)
                TVControlPnl.PictureBox2.Size = New Size(96, 66)
                TVControlPnl.lblATA_A.Size = New Size(84, 59)
                TVControlPnl.lblATA_B.Size = New Size(84, 59)
                TVControlPnl.lblATA_C.Size = New Size(84, 59)
                TVControlPnl.lblATA_D.Size = New Size(84, 59)

                TVControlPnl.lblATA_A.Font = New Font(TVControlPnl.lblATA_A.Font.FontFamily, 36, FontStyle.Bold)
                TVControlPnl.lblATA_B.Font = New Font(TVControlPnl.lblATA_A.Font.FontFamily, 36, FontStyle.Bold)
                TVControlPnl.lblATA_C.Font = New Font(TVControlPnl.lblATA_A.Font.FontFamily, 36, FontStyle.Bold)
                TVControlPnl.lblATA_D.Font = New Font(TVControlPnl.lblATA_A.Font.FontFamily, 36, FontStyle.Bold)

                ' Winning Strap
                TVControlPnl.pnlStrap.Location = New Point(0, 862)
                TVControlPnl.lblAmount.Location = New Point(714, 5)
                TVControlPnl.pnlTotal.Location = New Point(0, 783)
                TVControlPnl.Label1.Location = New Point(708, 2)

                TVControlPnl.pnlStrap.Size = New Size(1920, 126)
                TVControlPnl.lblAmount.Size = New Size(492, 114)
                TVControlPnl.pnlTotal.Size = New Size(1920, 81)
                TVControlPnl.Label1.Size = New Size(504, 81)

                TVControlPnl.lblAmount.Font = New Font(TVControlPnl.lblAmount.Font.FontFamily, 54)
                TVControlPnl.Label1.Font = New Font(TVControlPnl.Label1.Font.FontFamily, 42, FontStyle.Bold)

                ' FFF Winner
                TVControlPnl.pnlFFFWinner.Location = New Point(0, 832)
                TVControlPnl.lblFFFWinnerName.Location = New Point(568, 16)
                TVControlPnl.lblFFFWinnerPoints.Location = New Point(1184, 16)

                TVControlPnl.pnlFFFWinner.Size = New Size(1920, 87)
                TVControlPnl.lblFFFWinnerPoints.Size = New Size(168, 54)

                TVControlPnl.lblFFFWinnerName.Font = New Font(TVControlPnl.lblFFFWinnerName.Font.FontFamily, 32, FontStyle.Bold)
                TVControlPnl.lblFFFWinnerPoints.Font = New Font(TVControlPnl.lblFFFWinnerPoints.Font.FontFamily, 32, FontStyle.Bold)
#End Region
            Case 2
#Region "Host Screen"
                HostScreen.Size = New Size(1936, 1100)

                'Question
                HostScreen.picQuestion.Location = New Point(0, 712)
                HostScreen.txtQuestion.Location = New Point(198, 8)
                HostScreen.pnlA.Location = New Point(0, 856)
                HostScreen.pnlB.Location = New Point(963, 856)
                HostScreen.pnlC.Location = New Point(0, 942)
                HostScreen.pnlD.Location = New Point(963, 942)
                HostScreen.txtA.Location = New Point(185, 7)
                HostScreen.txtB.Location = New Point(60, 7)
                HostScreen.txtC.Location = New Point(185, 7)
                HostScreen.txtD.Location = New Point(60, 7)

                HostScreen.txtQuestion.Font = New Font(HostScreen.txtQuestion.Font.FontFamily, 32)
                HostScreen.txtA.Font = New Font(HostScreen.txtA.Font.FontFamily, 36)
                HostScreen.txtB.Font = New Font(HostScreen.txtB.Font.FontFamily, 36)
                HostScreen.txtC.Font = New Font(HostScreen.txtC.Font.FontFamily, 36)
                HostScreen.txtD.Font = New Font(HostScreen.txtD.Font.FontFamily, 36)

                HostScreen.picQuestion.Size = New Size(1920, 141)
                HostScreen.txtQuestion.Size = New Size(1524, 123)
                HostScreen.pnlA.Size = New Size(963, 87)
                HostScreen.pnlB.Size = New Size(963, 87)
                HostScreen.pnlC.Size = New Size(963, 87)
                HostScreen.pnlD.Size = New Size(963, 87)
                HostScreen.txtA.Size = New Size(714, 69)
                HostScreen.txtB.Size = New Size(714, 69)
                HostScreen.txtC.Size = New Size(714, 69)
                HostScreen.txtD.Size = New Size(714, 69)

                'Tree
                HostScreen.picTree.Location = New Point(537, -97)
                HostScreen.picLifeline1.Location = New Point(864, 12)
                HostScreen.picLifeline2.Location = New Point(1011, 12)
                HostScreen.picLifeline3.Location = New Point(1158, 12)
                HostScreen.picLifeline4.Location = New Point(1305, 12)

                HostScreen.picTree.Size = New Size(1383, 810)
                HostScreen.picLifeline1.Size = New Size(141, 99)
                HostScreen.picLifeline2.Size = New Size(141, 99)
                HostScreen.picLifeline3.Size = New Size(141, 99)
                HostScreen.picLifeline4.Size = New Size(141, 99)

                'Answer
                HostScreen.pnlAnswer.Location = New Point(1377, 637)
                HostScreen.lblAnswer.Location = New Point(15, 12)

                HostScreen.lblAnswer.Font = New Font(HostScreen.lblAnswer.Font.FontFamily, 28, FontStyle.Bold)

                HostScreen.pnlAnswer.Size = New Size(69, 69)

                'Ask the Audience
                HostScreen.txtATAa.Location = New Point(1173, 117)
                HostScreen.txtATAb.Location = New Point(1173, 177)
                HostScreen.txtATAc.Location = New Point(1173, 237)
                HostScreen.txtATAd.Location = New Point(1173, 297)

                HostScreen.txtATAa.Font = New Font(HostScreen.txtATAa.Font.FontFamily, 36)
                HostScreen.txtATAb.Font = New Font(HostScreen.txtATAb.Font.FontFamily, 36)
                HostScreen.txtATAc.Font = New Font(HostScreen.txtATAc.Font.FontFamily, 36)
                HostScreen.txtATAd.Font = New Font(HostScreen.txtATAd.Font.FontFamily, 36)

                HostScreen.txtATAa.Size = New Size(273, 54)
                HostScreen.txtATAb.Size = New Size(273, 54)
                HostScreen.txtATAc.Size = New Size(273, 54)
                HostScreen.txtATAd.Size = New Size(273, 54)

                'Plus One
                HostScreen.lblTime.Location = New Point(1171, 474)
                HostScreen.lblTime.Font = New Font(HostScreen.lblTime.Font.FontFamily, 108)

                'Host Panels
                HostScreen.pnlCorrect.Location = New Point(12, 12)
                HostScreen.pnlWrong.Location = New Point(12, 93)
                HostScreen.pnlCurrent.Location = New Point(306, 12)
                HostScreen.pnlDrop.Location = New Point(12, 174)
                HostScreen.pnlQLeft.Location = New Point(306, 93)
                HostScreen.lblCorrect.Location = New Point(14, 19)
                HostScreen.lblWrong.Location = New Point(14, 19)
                HostScreen.lblCurrent.Location = New Point(14, 19)
                HostScreen.lblDrop.Location = New Point(14, 19)
                HostScreen.lblQLeft.Location = New Point(14, 19)
                HostScreen.picCorrect.Location = New Point(227, 15)
                HostScreen.picWrong.Location = New Point(227, 15)
                HostScreen.picCurrent.Location = New Point(227, 15)
                HostScreen.picQLeft.Location = New Point(227, 15)

                HostScreen.lblCorrect.Font = New Font(HostScreen.lblCorrect.Font.FontFamily, 24, FontStyle.Bold)
                HostScreen.lblWrong.Font = New Font(HostScreen.lblWrong.Font.FontFamily, 24, FontStyle.Bold)
                HostScreen.lblCurrent.Font = New Font(HostScreen.lblCurrent.Font.FontFamily, 24, FontStyle.Bold)
                HostScreen.lblDrop.Font = New Font(HostScreen.lblDrop.Font.FontFamily, 24, FontStyle.Bold)
                HostScreen.lblQLeft.Font = New Font(HostScreen.lblQLeft.Font.FontFamily, 24, FontStyle.Bold)

                HostScreen.pnlCorrect.Size = New Size(288, 75)
                HostScreen.pnlWrong.Size = New Size(288, 75)
                HostScreen.pnlCurrent.Size = New Size(288, 75)
                HostScreen.pnlDrop.Size = New Size(288, 75)
                HostScreen.pnlQLeft.Size = New Size(288, 75)
                HostScreen.picCorrect.Size = New Size(45, 45)
                HostScreen.picWrong.Size = New Size(45, 45)
                HostScreen.picCurrent.Size = New Size(45, 45)
                HostScreen.picQLeft.Size = New Size(45, 45)

                'Host Info
                HostScreen.lblHostMsg.Location = New Point(12, 255)
                HostScreen.txtExplain.Location = New Point(12, 501)

                HostScreen.lblHostMsg.Font = New Font(HostScreen.lblHostMsg.Font.FontFamily, 26, FontStyle.Bold)
                HostScreen.txtExplain.Font = New Font(HostScreen.txtExplain.Font.FontFamily, 22, FontStyle.Bold)

                HostScreen.lblHostMsg.Size = New Size(1119, 243)
                HostScreen.txtExplain.Size = New Size(1119, 205)

                'General
                HostScreen.lblExplainRules.Location = New Point(600, 12)
                HostScreen.lblWalkedAway.Location = New Point(600, 12)

                HostScreen.lblExplainRules.Font = New Font(HostScreen.lblExplainRules.Font.FontFamily, 18)
                HostScreen.lblWalkedAway.Font = New Font(HostScreen.lblWalkedAway.Font.FontFamily, 18)

                'Total Winnings
                HostScreen.txtWinnings.Location = New Point(306, 174)

                HostScreen.txtWinnings.Font = New Font(HostScreen.txtWinnings.Font.FontFamily, 27, FontStyle.Bold)

                HostScreen.txtWinnings.Size = New Size(420, 69)
#End Region
            Case 3
#Region "Guest Screen"
                GuestScreen.Size = New Size(1936, 1100)

                'Question
                GuestScreen.picQuestion.Location = New Point(0, 712)
                GuestScreen.txtQuestion.Location = New Point(198, 8)
                GuestScreen.pnlA.Location = New Point(0, 856)
                GuestScreen.pnlB.Location = New Point(963, 856)
                GuestScreen.pnlC.Location = New Point(0, 942)
                GuestScreen.pnlD.Location = New Point(963, 942)
                GuestScreen.txtA.Location = New Point(185, 7)
                GuestScreen.txtB.Location = New Point(60, 7)
                GuestScreen.txtC.Location = New Point(185, 7)
                GuestScreen.txtD.Location = New Point(60, 7)

                GuestScreen.txtQuestion.Font = New Font(GuestScreen.txtQuestion.Font.FontFamily, 32)
                GuestScreen.txtA.Font = New Font(GuestScreen.txtA.Font.FontFamily, 36)
                GuestScreen.txtB.Font = New Font(GuestScreen.txtB.Font.FontFamily, 36)
                GuestScreen.txtC.Font = New Font(GuestScreen.txtC.Font.FontFamily, 36)
                GuestScreen.txtD.Font = New Font(GuestScreen.txtD.Font.FontFamily, 36)

                GuestScreen.picQuestion.Size = New Size(1920, 141)
                GuestScreen.txtQuestion.Size = New Size(1524, 123)
                GuestScreen.pnlA.Size = New Size(963, 87)
                GuestScreen.pnlB.Size = New Size(963, 87)
                GuestScreen.pnlC.Size = New Size(963, 87)
                GuestScreen.pnlD.Size = New Size(963, 87)
                GuestScreen.txtA.Size = New Size(714, 69)
                GuestScreen.txtB.Size = New Size(714, 69)
                GuestScreen.txtC.Size = New Size(714, 69)
                GuestScreen.txtD.Size = New Size(714, 69)

                'Tree
                GuestScreen.picTree.Location = New Point(537, -97)
                GuestScreen.picLifeline1.Location = New Point(864, 12)
                GuestScreen.picLifeline2.Location = New Point(1011, 12)
                GuestScreen.picLifeline3.Location = New Point(1158, 12)
                GuestScreen.picLifeline4.Location = New Point(1305, 12)

                GuestScreen.picTree.Size = New Size(1383, 810)
                GuestScreen.picLifeline1.Size = New Size(141, 99)
                GuestScreen.picLifeline2.Size = New Size(141, 99)
                GuestScreen.picLifeline3.Size = New Size(141, 99)
                GuestScreen.picLifeline4.Size = New Size(141, 99)

                'Ask the Audience
                GuestScreen.txtATAa.Location = New Point(1173, 117)
                GuestScreen.txtATAb.Location = New Point(1173, 177)
                GuestScreen.txtATAc.Location = New Point(1173, 237)
                GuestScreen.txtATAd.Location = New Point(1173, 297)

                GuestScreen.txtATAa.Font = New Font(GuestScreen.txtATAa.Font.FontFamily, 36)
                GuestScreen.txtATAb.Font = New Font(GuestScreen.txtATAb.Font.FontFamily, 36)
                GuestScreen.txtATAc.Font = New Font(GuestScreen.txtATAc.Font.FontFamily, 36)
                GuestScreen.txtATAd.Font = New Font(GuestScreen.txtATAd.Font.FontFamily, 36)

                GuestScreen.txtATAa.Size = New Size(273, 54)
                GuestScreen.txtATAb.Size = New Size(273, 54)
                GuestScreen.txtATAc.Size = New Size(273, 54)
                GuestScreen.txtATAd.Size = New Size(273, 54)

                'Plus One
                GuestScreen.lblTime.Location = New Point(1171, 474)
                GuestScreen.lblTime.Font = New Font(GuestScreen.lblTime.Font.FontFamily, 108)
#End Region
        End Select
    End Sub

End Class
