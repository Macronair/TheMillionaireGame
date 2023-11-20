Imports System.IO

Public Class OptionsSelectSound

    Dim Icons As New ImageList()

    Private Sub OptionsSelectSound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icons.ImageSize = New Size(16, 16)
        Icons.Images.Add("Folder", My.Resources.folder)
        Icons.Images.Add("Sound", My.Resources.sound)
        Icons.Images.Add("Triangle", My.Resources.triangle)

        treeSelectSound.ImageList = Icons

        ' Stel het pad in naar de map waarvan je de inhoud wilt weergeven in de TreeView.
        Dim subdir As String = "Sounds"
        Dim rootPath As String = Application.StartupPath + "\" + subdir

        ' Voeg de rootmap toe aan de TreeView.
        Dim rootNode As TreeNode = New TreeNode(subdir)
        rootNode.ImageIndex = 0
        treeSelectSound.Nodes.Add(rootNode)

        ' Roep een hulpprogramma aan om de inhoud van de map toe te voegen aan de TreeView.
        AddDirectoriesAndFiles(rootNode, rootPath)
    End Sub

    Private Sub AddDirectoriesAndFiles(parentNode As TreeNode, loc As String)
        Try
            ' Scannen van mappen in het huidige pad.
            Dim directories As String() = Directory.GetDirectories(loc)
            For Each directory As String In directories
                ' Voeg de map toe aan de TreeView en roep deze methode opnieuw aan voor submappen.
                Dim directoryNode As TreeNode = New TreeNode(Path.GetFileName(directory))
                directoryNode.ImageIndex = 0
                parentNode.Nodes.Add(directoryNode)
                AddDirectoriesAndFiles(directoryNode, directory)
            Next

            ' Scannen van bestanden in het huidige pad.
            Dim files As String() = Directory.GetFiles(loc)
            For Each file As String In files
                ' Voeg het bestand toe aan de TreeView.
                If file.Contains(".mp3") Or file.Contains(".wav") Then
                    Dim fileNode As TreeNode = New TreeNode(Path.GetFileName(file))
                    fileNode.ImageIndex = 1
                    parentNode.Nodes.Add(fileNode)
                End If
            Next
        Catch ex As Exception
            ' Handel eventuele uitzonderingen af die kunnen optreden tijdens het scannen van mappen en bestanden.
            MessageBox.Show("Er is een fout opgetreden: " & ex.Message)
        End Try
    End Sub

    Private Sub treeSelectSound_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeSelectSound.AfterSelect
        Dim path As String
        path = treeSelectSound.SelectedNode.FullPath
        path = path.Replace("Sounds\", "")

        txtSelectedFile.Text = path
        treeSelectSound.SelectedImageIndex = 2
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtSelectedFile.Text.EndsWith(".mp3") Or txtSelectedFile.Text.EndsWith(".wav") Or txtSelectedFile.Text.EndsWith(".mpeg") Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Please select a valid .mp3 or .wav file.", "Cannot use this type.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub treeSelectSound_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles treeSelectSound.MouseDoubleClick
        If txtSelectedFile.Text.EndsWith(".mp3") Or txtSelectedFile.Text.EndsWith(".wav") Or txtSelectedFile.Text.EndsWith(".mpeg") Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Please select a valid .mp3 or .wav file.", "Cannot use this type.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class