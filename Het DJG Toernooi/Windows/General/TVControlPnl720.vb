Public Class TVControlPnl720

    Public Sub ChangeTreeLevel(ByVal level As Integer)
        lblTree_n01.ForeColor = Color.Gold
        lblTree_n02.ForeColor = Color.Gold
        lblTree_n03.ForeColor = Color.Gold
        lblTree_n04.ForeColor = Color.Gold
        lblTree_n05.ForeColor = Color.White
        lblTree_n06.ForeColor = Color.Gold
        lblTree_n07.ForeColor = Color.Gold
        lblTree_n08.ForeColor = Color.Gold
        lblTree_n09.ForeColor = Color.Gold
        lblTree_n10.ForeColor = Color.White
        lblTree_n11.ForeColor = Color.Gold
        lblTree_n12.ForeColor = Color.Gold
        lblTree_n13.ForeColor = Color.Gold
        lblTree_n14.ForeColor = Color.Gold
        lblTree_n15.ForeColor = Color.White

        lblTree_q01.ForeColor = Color.Gold
        lblTree_q02.ForeColor = Color.Gold
        lblTree_q03.ForeColor = Color.Gold
        lblTree_q04.ForeColor = Color.Gold
        lblTree_q05.ForeColor = Color.White
        lblTree_q06.ForeColor = Color.Gold
        lblTree_q07.ForeColor = Color.Gold
        lblTree_q08.ForeColor = Color.Gold
        lblTree_q09.ForeColor = Color.Gold
        lblTree_q10.ForeColor = Color.White
        lblTree_q11.ForeColor = Color.Gold
        lblTree_q12.ForeColor = Color.Gold
        lblTree_q13.ForeColor = Color.Gold
        lblTree_q14.ForeColor = Color.Gold
        lblTree_q15.ForeColor = Color.White

        Select Case level
            Case 0
                pnlTree.BackgroundImage = My.Resources.mg_tree_00
            Case 1
                pnlTree.BackgroundImage = My.Resources.mg_tree_01
                lblTree_n01.ForeColor = Color.Black
                lblTree_q01.ForeColor = Color.Black
            Case 2
                pnlTree.BackgroundImage = My.Resources.mg_tree_02
                lblTree_n02.ForeColor = Color.Black
                lblTree_q02.ForeColor = Color.Black
            Case 3
                pnlTree.BackgroundImage = My.Resources.mg_tree_03
                lblTree_n03.ForeColor = Color.Black
                lblTree_q03.ForeColor = Color.Black
            Case 4
                pnlTree.BackgroundImage = My.Resources.mg_tree_04
                lblTree_n04.ForeColor = Color.Black
                lblTree_q04.ForeColor = Color.Black
            Case 5
                pnlTree.BackgroundImage = My.Resources.mg_tree_05
                lblTree_n05.ForeColor = Color.Black
                lblTree_q05.ForeColor = Color.Black
            Case 6
                pnlTree.BackgroundImage = My.Resources.mg_tree_06
                lblTree_n06.ForeColor = Color.Black
                lblTree_q06.ForeColor = Color.Black
            Case 7
                pnlTree.BackgroundImage = My.Resources.mg_tree_07
                lblTree_n07.ForeColor = Color.Black
                lblTree_q07.ForeColor = Color.Black
            Case 8
                pnlTree.BackgroundImage = My.Resources.mg_tree_08
                lblTree_n08.ForeColor = Color.Black
                lblTree_q08.ForeColor = Color.Black
            Case 9
                pnlTree.BackgroundImage = My.Resources.mg_tree_09
                lblTree_n09.ForeColor = Color.Black
                lblTree_q09.ForeColor = Color.Black
            Case 10
                pnlTree.BackgroundImage = My.Resources.mg_tree_10
                lblTree_n10.ForeColor = Color.Black
                lblTree_q10.ForeColor = Color.Black
            Case 11
                pnlTree.BackgroundImage = My.Resources.mg_tree_11
                lblTree_n11.ForeColor = Color.Black
                lblTree_q11.ForeColor = Color.Black
            Case 12
                pnlTree.BackgroundImage = My.Resources.mg_tree_12
                lblTree_n12.ForeColor = Color.Black
                lblTree_q12.ForeColor = Color.Black
            Case 13
                pnlTree.BackgroundImage = My.Resources.mg_tree_13
                lblTree_n13.ForeColor = Color.Black
                lblTree_q13.ForeColor = Color.Black
            Case 14
                pnlTree.BackgroundImage = My.Resources.mg_tree_14
                lblTree_n14.ForeColor = Color.Black
                lblTree_q14.ForeColor = Color.Black
            Case 15
                pnlTree.BackgroundImage = My.Resources.mg_tree_15
                lblTree_n15.ForeColor = Color.Black
                lblTree_q15.ForeColor = Color.Black
        End Select
    End Sub

End Class