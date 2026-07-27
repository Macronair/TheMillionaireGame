Public Class ATAAnimate

    Public Shared targetX As Integer
    Public Shared slideSpeed As Integer = 20
    Public Shared slidingIn As Boolean
    Public Shared marginRightPercent As Double = TVControlPnl.ClientSize.Width * 0.1 ' 10% of the panel width
    Public Shared marginTopPercent As Double = 0.1     ' 10% up
    Public Shared marginBottomPercent As Double = 0.4  ' 20% below

    Public Shared Sub SlideIn()
        TVControlPnl.pnlATAGraph.Visible = True
        targetX = TVControlPnl.ClientSize.Width - TVControlPnl.pnlATAGraph.Width - 100
        slidingIn = True
        TVControlPnl.tmr_Anim_ATA.Start()
    End Sub

    Public Shared Sub SlideOut()
        targetX = TVControlPnl.ClientSize.Width
        slidingIn = False
        TVControlPnl.tmr_Anim_ATA.Start()
    End Sub

End Class
