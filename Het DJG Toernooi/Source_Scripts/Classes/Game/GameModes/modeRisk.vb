Public Class modeRisk

    Public Shared Sub getInfo()
        If Game.level = 0 Then
            Game.varCurrent = "0"
            Game.varCorrect = "100"
            Game.varWrong = "0"
            Game.varDrop = "0"
            Game.varQLeft = "15"
            HostScreen.picTree.Image = My.Resources._1_tree_0
            GuestScreen.picTree.Image = My.Resources._1_tree_0
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_0
        End If
        If Game.level = 1 Then
            Game.varCurrent = "100"
            Game.varCorrect = "250"
            Game.varWrong = "0"
            Game.varDrop = "100"
            Game.varQLeft = "14"
            HostScreen.picTree.Image = My.Resources._1_tree_1
            GuestScreen.picTree.Image = My.Resources._1_tree_1
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_1
        End If
        If Game.level = 2 Then
            Game.varCurrent = "250"
            Game.varCorrect = "500"
            Game.varWrong = "0"
            Game.varDrop = "250"
            Game.varQLeft = "13"
            HostScreen.picTree.Image = My.Resources._1_tree_2
            GuestScreen.picTree.Image = My.Resources._1_tree_2
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_2
        End If
        If Game.level = 3 Then
            Game.varCurrent = "500"
            Game.varCorrect = "750"
            Game.varWrong = "0"
            Game.varDrop = "500"
            Game.varQLeft = "12"
            HostScreen.picTree.Image = My.Resources._1_tree_3
            GuestScreen.picTree.Image = My.Resources._1_tree_3
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_3
        End If
        If Game.level = 4 Then
            Game.varCurrent = "750"
            Game.varCorrect = "1.000"
            Game.varWrong = "0"
            Game.varDrop = "750"
            Game.varQLeft = "11"
            HostScreen.picTree.Image = My.Resources._1_tree_4
            GuestScreen.picTree.Image = My.Resources._1_tree_4
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_4
        End If
        If Game.level = 5 Then
            Game.varCurrent = "1.000"
            Game.varCorrect = "2.000"
            Game.varWrong = "1.000"
            Game.varDrop = "0"
            Game.varQLeft = "10"
            HostScreen.picTree.Image = My.Resources._1_tree_5
            GuestScreen.picTree.Image = My.Resources._1_tree_5
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_5
        End If
        If Game.level = 6 Then
            Game.varCurrent = "2.000"
            Game.varCorrect = "4.000"
            Game.varWrong = "1.000"
            Game.varDrop = "1.000"
            Game.varQLeft = "9"
            HostScreen.picTree.Image = My.Resources._1_tree_6
            GuestScreen.picTree.Image = My.Resources._1_tree_6
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_6
        End If
        If Game.level = 7 Then
            Game.varCurrent = "4.000"
            Game.varCorrect = "8.000"
            Game.varWrong = "1.000"
            Game.varDrop = "3.000"
            Game.varQLeft = "8"
            HostScreen.picTree.Image = My.Resources._1_tree_7
            GuestScreen.picTree.Image = My.Resources._1_tree_7
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_7
        End If
        If Game.level = 8 Then
            Game.varCurrent = "8.000"
            Game.varCorrect = "16.000"
            Game.varWrong = "1.000"
            Game.varDrop = "7.000"
            Game.varQLeft = "7"
            HostScreen.picTree.Image = My.Resources._1_tree_8
            GuestScreen.picTree.Image = My.Resources._1_tree_8
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_8
        End If
        If Game.level = 9 Then
            Game.varCurrent = "16.000"
            Game.varCorrect = "32.000"
            Game.varWrong = "1.000"
            Game.varDrop = "15.000"
            Game.varQLeft = "6"
            HostScreen.picTree.Image = My.Resources._1_tree_9
            GuestScreen.picTree.Image = My.Resources._1_tree_9
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_9
        End If
        If Game.level = 10 Then
            Game.varCurrent = "32.000"
            Game.varCorrect = "64.000"
            Game.varWrong = "1.000"
            Game.varDrop = "31.000"
            Game.varQLeft = "5"
            HostScreen.picTree.Image = My.Resources._1_tree_10
            GuestScreen.picTree.Image = My.Resources._1_tree_10
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_10
        End If
        If Game.level = 11 Then
            Game.varCurrent = "64.000"
            Game.varCorrect = "125.000"
            Game.varWrong = "1.000"
            Game.varDrop = "63.000"
            Game.varQLeft = "4"
            HostScreen.picTree.Image = My.Resources._1_tree_11
            GuestScreen.picTree.Image = My.Resources._1_tree_11
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_11
        End If
        If Game.level = 12 Then
            Game.varCurrent = "125.000"
            Game.varCorrect = "250.000"
            Game.varWrong = "1.000"
            Game.varDrop = "124.000"
            Game.varQLeft = "3"
            HostScreen.picTree.Image = My.Resources._1_tree_12
            GuestScreen.picTree.Image = My.Resources._1_tree_12
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_12
        End If
        If Game.level = 13 Then
            Game.varCurrent = "250.000"
            Game.varCorrect = "500.000"
            Game.varWrong = "1.000"
            Game.varDrop = "249.000"
            Game.varQLeft = "2"
            HostScreen.picTree.Image = My.Resources._1_tree_13
            GuestScreen.picTree.Image = My.Resources._1_tree_13
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_13
        End If
        If Game.level = 14 Then
            Game.varCurrent = "500.000"
            Game.varCorrect = "1.000.000"
            Game.varWrong = "1.000"
            Game.varDrop = "499.000"
            Game.varQLeft = "1"
            HostScreen.picTree.Image = My.Resources._1_tree_14
            GuestScreen.picTree.Image = My.Resources._1_tree_14
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_14
        End If
        If Game.level = 15 Then
            Game.varCurrent = "1.000.000"
            Game.varCorrect = "1.000.000"
            Game.varWrong = "1.000.000"
            Game.varDrop = "0"
            Game.varQLeft = "0"
            HostScreen.picTree.Image = My.Resources._1_tree_15
            GuestScreen.picTree.Image = My.Resources._1_tree_15
            TVControlPnl.picTree.BackgroundImage = My.Resources._1_tree_15
        End If
    End Sub

End Class
