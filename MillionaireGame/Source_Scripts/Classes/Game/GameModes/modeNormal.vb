Public Class modeNormal

    Public Shared Sub getInfo()
        Dim passednet As Integer
        If Game.level + 1 > MoneyTreeSettings.TreeData.SafeNet_02 Then
            passednet = MoneyTreeSettings.TreeData.SafeNet_02
        ElseIf Game.level + 1 > MoneyTreeSettings.TreeData.SafeNet_01 Then
            passednet = MoneyTreeSettings.TreeData.SafeNet_01
        End If

        Dim drop As Integer = MoneyTreeCore.GetMoneyValue(Game.level) - MoneyTreeCore.GetMoneyValue(passednet)

        Game.varCurrent = MoneyTreeCore.GetMoneyValue(Game.level)
        Game.varCorrect = MoneyTreeCore.GetMoneyValue(Game.level + 1)
        Game.varWrong = MoneyTreeCore.GetMoneyValue(passednet)
        Game.varDrop = drop.ToString("N0")

        TVControlPnl.picTree.BackgroundImage = MoneyTreeCore.tree_img(Game.level)
        HostScreen.picTree.Image = MoneyTreeCore.tree_img(Game.level)
        GuestScreen.picTree.Image = MoneyTreeCore.tree_img(Game.level)

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
            Game.varCurrent = MoneyTreeCore.GetMoneyValue(Game.level)
            Game.varCorrect = MoneyTreeCore.GetMoneyValue(Game.level)
            Game.varWrong = MoneyTreeCore.GetMoneyValue(Game.level)
            Game.varDrop = "0"
            Game.varQLeft = "0"
        End If
    End Sub

End Class
