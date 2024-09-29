Public Class modeFree
    Public Shared Sub getInfo()
        Dim passednet As Integer

        If Game.freeSafetyNetSet = False Then
            If Game.level >= 5 Then
                MoneyTreeCore.GeneratePossibleSafeNetImage(Game.level)
            End If

            If TVControlPnl.tmrAnimateFreeSafeNet.Enabled = False Then
                TVControlPnl.tmrAnimateFreeSafeNet.Start()
            End If

            If Game.level < 5 Then
                If TVControlPnl.tmrAnimateFreeSafeNet.Enabled = True Then
                    TVControlPnl.tmrAnimateFreeSafeNet.Stop()
                End If
            End If
        End If

        If Game.level >= 5 Then
            ControlPanel.btnSet2ndSafeNet.Enabled = True
        Else
            ControlPanel.btnSet2ndSafeNet.Enabled = False
        End If

        If Game.level + 1 > MoneyTreeSettings.TreeData.SafeNet_01 Then
            passednet = MoneyTreeSettings.TreeData.SafeNet_01
        End If

        If Game.freeSafetyNetAt > 5 Then
            passednet = Game.freeSafetyNetAt
        End If

        Dim drop As Integer = MoneyTreeCore.GetMoneyValue(Game.level) - MoneyTreeCore.GetMoneyValue(passednet)

        Game.varCurrent = MoneyTreeCore.GetMoneyValue(Game.level)
        Game.varCorrect = MoneyTreeCore.GetMoneyValue(Game.level + 1)
        Game.varWrong = MoneyTreeCore.GetMoneyValue(passednet)
        Game.varDrop = drop.ToString("N0")

        If Game.freeSafetyNetSet = False Then
            TVControlPnl.picTree.BackgroundImage = MoneyTreeCore.tree_imgrisk(Game.level)
            If Game.level < 5 Then
                HostScreen.picTree.Image = MoneyTreeCore.tree_imgrisk(Game.level)
                GuestScreen.picTree.Image = MoneyTreeCore.tree_imgrisk(Game.level)
            Else
                HostScreen.picTree.Image = MoneyTreeCore.tree_imgnet2
                GuestScreen.picTree.Image = MoneyTreeCore.tree_imgnet2
            End If
        Else
            TVControlPnl.picTree.BackgroundImage = MoneyTreeCore.tree_img(Game.level)
            HostScreen.picTree.Image = MoneyTreeCore.tree_img(Game.level)
            GuestScreen.picTree.Image = MoneyTreeCore.tree_img(Game.level)
        End If

        If Game.level = 0 Then
            Game.varQLeft = "15"
        End If
        If Game.level = 1 Then
            Game.varQLeft = "14"
        End If
        If Game.level = 2 Then
            Game.varQLeft = "13"
        End If
        If Game.level = 3 Then
            Game.varQLeft = "12"
        End If
        If Game.level = 4 Then
            Game.varQLeft = "11"
        End If
        If Game.level = 5 Then
            Game.varQLeft = "10"
        End If
        If Game.level = 6 Then
            Game.varQLeft = "9"
        End If
        If Game.level = 7 Then
            Game.varQLeft = "8"
        End If
        If Game.level = 8 Then
            Game.varQLeft = "7"
        End If
        If Game.level = 9 Then
            Game.varQLeft = "6"
        End If
        If Game.level = 10 Then
            Game.varQLeft = "5"
        End If
        If Game.level = 11 Then
            Game.varQLeft = "4"
        End If
        If Game.level = 12 Then
            Game.varQLeft = "3"
        End If
        If Game.level = 13 Then
            Game.varQLeft = "2"
        End If
        If Game.level = 14 Then
            Game.varQLeft = "1"
        End If
        If Game.level = 15 Then
            Game.varQLeft = "0"
        End If
    End Sub
End Class
