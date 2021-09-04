<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoreConsole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRuntime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.LightGray
        Me.txtConsole.Location = New System.Drawing.Point(1, 1)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(925, 442)
        Me.txtConsole.TabIndex = 0
        '
        'tmrLoad
        '
        Me.tmrLoad.Interval = 400
        '
        'tmrRuntime
        '
        Me.tmrRuntime.Interval = 500
        '
        'CoreConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(927, 443)
        Me.Controls.Add(Me.txtConsole)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CoreConsole"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "CoreConsole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConsole As TextBox
    Friend WithEvents tmrLoad As Timer
    Friend WithEvents tmrRuntime As Timer
End Class
