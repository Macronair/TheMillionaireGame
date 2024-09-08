Imports System.Reflection

Public Class MoneyTreeCore

    Public Shared tree_img(15) As Bitmap
    Public Shared lifelines(5) As Bitmap
    Shared ll(3) As Image

    Dim bg_pos_X As Integer
    Dim bg_pos_Y As Integer
    Dim bg_size_X As Integer
    Dim bg_size_Y As Integer

    Dim tree_pos_X As Integer
    Dim tree_pos_Y As Integer
    Dim tree_size_X As Integer
    Dim tree_size_Y As Integer

    Shared ll_size As Integer() = New Integer() {75, 50}
    Shared lltree_loc As Integer() = New Integer() {860, 30}
    Shared ll1_loc As Integer() = New Integer() {0, 0}
    Shared ll2_loc As Integer() = New Integer() {80, 0}
    Shared ll3_loc As Integer() = New Integer() {160, 0}
    Shared ll4_loc As Integer() = New Integer() {240, 0}

    Shared money_pos_X As Integer
    Shared money_pos_Y As Integer()
    Shared qno_pos_X As Integer()

    Public Shared Sub GenerateImages()
        SetPositionsAndSizes()

        Dim bg As Image = GetTreeImage()

        Dim bg_pos_x As Integer = 0
        Dim bg_pos_y As Integer = 0
        Dim bg_size_x As Integer = 1280
        Dim bg_size_y As Integer = 720

        Dim lvl_pos_x As Integer = 815
        Dim lvl_pos_y As Integer = 100
        Dim lvl_size_x As Integer = 399
        Dim lvl_size_y As Integer = 599

        Dim level As Integer = 0
        Dim position As Integer = 1

        ' Generate the actual images
        Do
            Dim lvl As Image = GetPosImage(level)
            tree_img(level) = New Bitmap(1280, 720)
            Dim g As Graphics = Graphics.FromImage(tree_img(level))

            g.DrawImage(bg, bg_pos_x, bg_pos_y, bg_size_x, bg_size_y)
            If lvl Is Nothing Then

            Else
                g.DrawImage(lvl, lvl_pos_x, lvl_pos_y, lvl_size_x, lvl_size_y)
            End If

            ' Generate money values in images
            Do
                Dim font As New Font("Copperplate Gothic Bold", 24, FontStyle.Bold)
                Dim textColor As Brush

                If IsSafetyNet(position) = True Then
                    textColor = Brushes.White
                Else
                    textColor = Brushes.Gold
                End If

                If position = 15 Then
                    textColor = Brushes.White
                End If

                If level = position Then
                    textColor = Brushes.Black
                End If

                g.DrawString(position, font, textColor, qno_pos_X(position), money_pos_Y(position))
                g.DrawString(MoneyTreeSettings.TreeData.Currency & GetMoneyValue(position), font, textColor, money_pos_X, money_pos_Y(position))
                position = position + 1
            Loop Until position = 16

            position = 1
            level = level + 1
        Loop Until level = 16
        level = 0
    End Sub

    Private Shared Sub SetPositionsAndSizes()
        money_pos_X = 910
        money_pos_Y = New Integer() {0, 662, 622, 582, 542, 502, 462, 422, 382, 342, 302, 262, 222, 182, 142, 102}
        qno_pos_X = New Integer() {0, 855, 855, 855, 855, 855, 855, 855, 855, 855, 832, 832, 832, 832, 832, 832}

        ll_size = New Integer() {75, 50}
        ll1_loc = New Integer() {860, 30}
        ll2_loc = New Integer() {940, 30}
        ll3_loc = New Integer() {1020, 30}
        ll4_loc = New Integer() {1100, 30}
    End Sub

    Public Shared Function GetTreeImage() As Image
        Select Case Profile.Options.QuestionsTexture
            Case 0
                Return My.Resources._01_Tree
            Case 1
                Return My.Resources._02_Tree
            Case 2
                Return My.Resources._01_Tree
            Case 3
                Return My.Resources._02_Tree
            Case 4
                Return My.Resources._03_Tree
        End Select
    End Function

    Private Shared Function GetPosImage(Optional ByVal index As Integer = Nothing) As Image
        Dim selectImage As Integer
        If index = Nothing Then
            selectImage = Game.level
        Else
            selectImage = index
        End If

        Select Case selectImage
            Case 1
                Return My.Resources._999_Tree_01
            Case 2
                Return My.Resources._999_Tree_02
            Case 3
                Return My.Resources._999_Tree_03
            Case 4
                Return My.Resources._999_Tree_04
            Case 5
                Return My.Resources._999_Tree_05
            Case 6
                Return My.Resources._999_Tree_06
            Case 7
                Return My.Resources._999_Tree_07
            Case 8
                Return My.Resources._999_Tree_08
            Case 9
                Return My.Resources._999_Tree_09
            Case 10
                Return My.Resources._999_Tree_10
            Case 11
                Return My.Resources._999_Tree_11
            Case 12
                Return My.Resources._999_Tree_12
            Case 13
                Return My.Resources._999_Tree_13
            Case 14
                Return My.Resources._999_Tree_14
            Case 15
                Return My.Resources._999_Tree_15
            Case 99
                Return My.Resources._999_Tree_All
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function GetMoneyValue(ByVal level As Integer) As String
        Select Case level
            Case 1
                Return MoneyTreeSettings.TreeData.Level_01_Value.ToString("N0")
            Case 2
                Return MoneyTreeSettings.TreeData.Level_02_Value.ToString("N0")
            Case 3
                Return MoneyTreeSettings.TreeData.Level_03_Value.ToString("N0")
            Case 4
                Return MoneyTreeSettings.TreeData.Level_04_Value.ToString("N0")
            Case 5
                Return MoneyTreeSettings.TreeData.Level_05_Value.ToString("N0")
            Case 6
                Return MoneyTreeSettings.TreeData.Level_06_Value.ToString("N0")
            Case 7
                Return MoneyTreeSettings.TreeData.Level_07_Value.ToString("N0")
            Case 8
                Return MoneyTreeSettings.TreeData.Level_08_Value.ToString("N0")
            Case 9
                Return MoneyTreeSettings.TreeData.Level_09_Value.ToString("N0")
            Case 10
                Return MoneyTreeSettings.TreeData.Level_10_Value.ToString("N0")
            Case 11
                Return MoneyTreeSettings.TreeData.Level_11_Value.ToString("N0")
            Case 12
                Return MoneyTreeSettings.TreeData.Level_12_Value.ToString("N0")
            Case 13
                Return MoneyTreeSettings.TreeData.Level_13_Value.ToString("N0")
            Case 14
                Return MoneyTreeSettings.TreeData.Level_14_Value.ToString("N0")
            Case 15
                Return MoneyTreeSettings.TreeData.Level_15_Value.ToString("N0")
            Case Else
                Return "0"
        End Select
    End Function

    Private Shared Function IsSafetyNet(ByVal level As Integer) As Boolean
        If level = MoneyTreeSettings.TreeData.SafeNet_01 Or level = MoneyTreeSettings.TreeData.SafeNet_02 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
