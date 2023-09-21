Imports System.IO

Public Class OptionsSelectSound
    Private Sub OptionsSelectSound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Stel het pad in naar de map waarvan je de inhoud wilt weergeven in de TreeView.
        Dim subdir As String = "Sounds"
        Dim rootPath As String = Application.StartupPath + "\" + subdir

        ' Voeg de rootmap toe aan de TreeView.
        Dim rootNode As TreeNode = New TreeNode(subdir)
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
                Dim directoryNode As TreeNode = New TreeNode(Path.GetDirectoryName(directory))
                parentNode.Nodes.Add(directoryNode)
                AddDirectoriesAndFiles(directoryNode, directory)
            Next

            ' Scannen van bestanden in het huidige pad.
            Dim files As String() = Directory.GetFiles(loc)
            For Each file As String In files
                ' Voeg het bestand toe aan de TreeView.
                If file.Contains(".mp3") Or file.Contains(".wav") Then
                    Dim fileNode As TreeNode = New TreeNode(Path.GetFileName(file))
                    parentNode.Nodes.Add(fileNode)
                End If
            Next
        Catch ex As Exception
            ' Handel eventuele uitzonderingen af die kunnen optreden tijdens het scannen van mappen en bestanden.
            MessageBox.Show("Er is een fout opgetreden: " & ex.Message)
        End Try
    End Sub

    Private Sub treeSelectSound_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeSelectSound.AfterSelect
        txtSelectedFile.Text = treeSelectSound.SelectedNode.Text
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class