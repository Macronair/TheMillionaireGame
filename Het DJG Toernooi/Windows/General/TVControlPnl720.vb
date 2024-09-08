Public Class TVControlPnl720

    Private Sub TVControlPnl720_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
        Me.Update()
    End Sub

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
                picTreePosition.BackgroundImage = Nothing
            Case 1
                picTreePosition.BackgroundImage = My.Resources._999_Tree_01
                lblTree_n01.ForeColor = Color.Black
                lblTree_q01.ForeColor = Color.Black
            Case 2
                picTreePosition.BackgroundImage = My.Resources._999_Tree_02
                lblTree_n02.ForeColor = Color.Black
                lblTree_q02.ForeColor = Color.Black
            Case 3
                picTreePosition.BackgroundImage = My.Resources._999_Tree_03
                lblTree_n03.ForeColor = Color.Black
                lblTree_q03.ForeColor = Color.Black
            Case 4
                picTreePosition.BackgroundImage = My.Resources._999_Tree_04
                lblTree_n04.ForeColor = Color.Black
                lblTree_q04.ForeColor = Color.Black
            Case 5
                picTreePosition.BackgroundImage = My.Resources._999_Tree_05
                lblTree_n05.ForeColor = Color.Black
                lblTree_q05.ForeColor = Color.Black
            Case 6
                picTreePosition.BackgroundImage = My.Resources._999_Tree_06
                lblTree_n06.ForeColor = Color.Black
                lblTree_q06.ForeColor = Color.Black
            Case 7
                picTreePosition.BackgroundImage = My.Resources._999_Tree_07
                lblTree_n07.ForeColor = Color.Black
                lblTree_q07.ForeColor = Color.Black
            Case 8
                picTreePosition.BackgroundImage = My.Resources._999_Tree_08
                lblTree_n08.ForeColor = Color.Black
                lblTree_q08.ForeColor = Color.Black
            Case 9
                picTreePosition.BackgroundImage = My.Resources._999_Tree_09
                lblTree_n09.ForeColor = Color.Black
                lblTree_q09.ForeColor = Color.Black
            Case 10
                picTreePosition.BackgroundImage = My.Resources._999_Tree_10
                lblTree_n10.ForeColor = Color.Black
                lblTree_q10.ForeColor = Color.Black
            Case 11
                picTreePosition.BackgroundImage = My.Resources._999_Tree_11
                lblTree_n11.ForeColor = Color.Black
                lblTree_q11.ForeColor = Color.Black
            Case 12
                picTreePosition.BackgroundImage = My.Resources._999_Tree_12
                lblTree_n12.ForeColor = Color.Black
                lblTree_q12.ForeColor = Color.Black
            Case 13
                picTreePosition.BackgroundImage = My.Resources._999_Tree_13
                lblTree_n13.ForeColor = Color.Black
                lblTree_q13.ForeColor = Color.Black
            Case 14
                picTreePosition.BackgroundImage = My.Resources._999_Tree_14
                lblTree_n14.ForeColor = Color.Black
                lblTree_q14.ForeColor = Color.Black
            Case 15
                picTreePosition.BackgroundImage = My.Resources._999_Tree_15
                lblTree_n15.ForeColor = Color.Black
                lblTree_q15.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub pnlTree_Paint(sender As Object, e As PaintEventArgs) Handles pnlTree.Paint
        Using TextBrush As SolidBrush = New SolidBrush(Me.ForeColor)
            e.Graphics.DrawString("BITS Registration ID", Me.Font, TextBrush, New Point(95, 562))
        End Using
    End Sub
End Class