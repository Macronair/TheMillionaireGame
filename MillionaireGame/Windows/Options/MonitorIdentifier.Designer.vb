<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorIdentifier
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
        Me.lblMonitorNumber = New System.Windows.Forms.Label()
        Me.tmrToCloseForm = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblMonitorNumber
        '
        Me.lblMonitorNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorNumber.ForeColor = System.Drawing.Color.White
        Me.lblMonitorNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblMonitorNumber.Name = "lblMonitorNumber"
        Me.lblMonitorNumber.Size = New System.Drawing.Size(176, 182)
        Me.lblMonitorNumber.TabIndex = 0
        Me.lblMonitorNumber.Text = "1"
        Me.lblMonitorNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrToCloseForm
        '
        Me.tmrToCloseForm.Interval = 3000
        '
        'MonitorIdentifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.Controls.Add(Me.lblMonitorNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MonitorIdentifier"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MonitorIdentifier"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMonitorNumber As Label
    Friend WithEvents tmrToCloseForm As Timer
End Class
