Public Class MPanel
    Inherits Panel
    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        ' Prevent flickering by drawing the background image directly
        If Me.BackgroundImage IsNot Nothing Then
            e.Graphics.DrawImage(Me.BackgroundImage, Me.ClientRectangle)
        Else
            MyBase.OnPaintBackground(e)
        End If
    End Sub
End Class
