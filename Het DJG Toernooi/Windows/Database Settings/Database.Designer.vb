<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAllUsedQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level1Questionsq15ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level2Questionsq610ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level3Questionsq1114ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level4Questionsq15ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastestFingerQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1021, 567)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetAllUsedQuestionsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FileToolStripMenuItem.Text = "Database"
        '
        'ResetAllUsedQuestionsToolStripMenuItem
        '
        Me.ResetAllUsedQuestionsToolStripMenuItem.Name = "ResetAllUsedQuestionsToolStripMenuItem"
        Me.ResetAllUsedQuestionsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ResetAllUsedQuestionsToolStripMenuItem.Text = "Reset all used questions"
        '
        'RecordToolStripMenuItem
        '
        Me.RecordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddQuestionToolStripMenuItem, Me.EditQuestionToolStripMenuItem, Me.DeleteQuestionToolStripMenuItem})
        Me.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem"
        Me.RecordToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RecordToolStripMenuItem.Text = "Record"
        '
        'AddQuestionToolStripMenuItem
        '
        Me.AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem"
        Me.AddQuestionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddQuestionToolStripMenuItem.Text = "Add Question"
        '
        'EditQuestionToolStripMenuItem
        '
        Me.EditQuestionToolStripMenuItem.Name = "EditQuestionToolStripMenuItem"
        Me.EditQuestionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditQuestionToolStripMenuItem.Text = "Edit Question"
        '
        'DeleteQuestionToolStripMenuItem
        '
        Me.DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem"
        Me.DeleteQuestionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteQuestionToolStripMenuItem.Text = "Delete Question"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Level1Questionsq15ToolStripMenuItem, Me.Level2Questionsq610ToolStripMenuItem, Me.Level3Questionsq1114ToolStripMenuItem, Me.Level4Questionsq15ToolStripMenuItem, Me.FastestFingerQuestionsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'Level1Questionsq15ToolStripMenuItem
        '
        Me.Level1Questionsq15ToolStripMenuItem.Name = "Level1Questionsq15ToolStripMenuItem"
        Me.Level1Questionsq15ToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.Level1Questionsq15ToolStripMenuItem.Text = "Level 1 questions (q1-5)"
        '
        'Level2Questionsq610ToolStripMenuItem
        '
        Me.Level2Questionsq610ToolStripMenuItem.Name = "Level2Questionsq610ToolStripMenuItem"
        Me.Level2Questionsq610ToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.Level2Questionsq610ToolStripMenuItem.Text = "Level 2 questions (q6-10)"
        '
        'Level3Questionsq1114ToolStripMenuItem
        '
        Me.Level3Questionsq1114ToolStripMenuItem.Name = "Level3Questionsq1114ToolStripMenuItem"
        Me.Level3Questionsq1114ToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.Level3Questionsq1114ToolStripMenuItem.Text = "Level 3 questions (q11-14)"
        '
        'Level4Questionsq15ToolStripMenuItem
        '
        Me.Level4Questionsq15ToolStripMenuItem.Name = "Level4Questionsq15ToolStripMenuItem"
        Me.Level4Questionsq15ToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.Level4Questionsq15ToolStripMenuItem.Text = "Level 4 questions (q15)"
        '
        'FastestFingerQuestionsToolStripMenuItem
        '
        Me.FastestFingerQuestionsToolStripMenuItem.Name = "FastestFingerQuestionsToolStripMenuItem"
        Me.FastestFingerQuestionsToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.FastestFingerQuestionsToolStripMenuItem.Text = "Fastest Finger questions"
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 606)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Database"
        Me.Text = "Database Masnager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetAllUsedQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level1Questionsq15ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level2Questionsq610ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level3Questionsq1114ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Level4Questionsq15ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastestFingerQuestionsToolStripMenuItem As ToolStripMenuItem
End Class
