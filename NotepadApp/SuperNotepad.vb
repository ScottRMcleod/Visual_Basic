' This application creates a Simple Text Editor which enables users to 
' Create, Save, Open and edit text files stored localy on thier machine
' Target Audience : New Computer Users

Public Class frmMain
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        richTxtbox1.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'This Subroutine creates a local variable of typoe OpenFileDialog which passes strings 
        ' See https://msdn.microsoft.com/en-us/library/y1kh29w3(v=vs.110).aspx?appId=Dev14IDEF1&l=EN-US&k=k(System.Windows.Forms.OpenFileDialog)%3bk(TargetFrameworkMoniker-.NETFramework,Version%3dv4.6)%3bk(DevLang-VB)&rd=true&cs-save-lang=1&cs-lang=vb#code-snippet-2 
        ' for examples on how to use this class

        Try
            Dim dlg1 As OpenFileDialog = New OpenFileDialog
            dlg1.Title = "Open"
            dlg1.Filter = " Text Files(*.txt) |*.txt"
            If dlg1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                richTxtbox1.LoadFile(dlg1.FileName)
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'See
        'https://msdn.microsoft.com/en-us/library/9tah40xd(v=vs.110).aspx?appId=Dev14IDEF1&l=EN-US&k=k(System.Windows.Forms.SaveFileDialog)%3bk(TargetFrameworkMoniker-.NETFramework,Version%3dv4.6)%3bk(DevLang-VB)&rd=true&cs-save-lang=1&cs-lang=vb#code-snippet-2
        'for example on how to use this class
        Try
            Dim dlg1 As SaveFileDialog = New SaveFileDialog
            dlg1.Title = "Save"
            dlg1.Filter = "Text Files(*.txt)|*.txt"
            If dlg1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                richTxtbox1.SaveFile(dlg1.FileName, RichTextBoxStreamType.PlainText)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        richTxtbox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        richTxtbox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        richTxtbox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        richTxtbox1.Copy()
    End Sub

    Private Sub PastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click
        richTxtbox1.Paste()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        richTxtbox1.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        richTxtbox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg1 As FontDialog = New FontDialog
            dlg1.Font = richTxtbox1.Font
            If dlg1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                richTxtbox1.Font = dlg1.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'See
        'https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Windows.Forms.ColorDialog);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6);k(DevLang-VB)&rd=true
        ' for examples on how this class can be referenced 
        ' this is a try catch block created to change the colour of the text in the 
        'Rich text box property so a user can change thier font colour.  
        Try
            Dim dlg1 As ColorDialog = New ColorDialog

            'This sets the forgrond colour of your text located in the Richtext Box
            'for more information on this function check out the following link
            'https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Drawing.Color);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6);k(DevLang-VB)&rd=true

            dlg1.Color = richTxtbox1.ForeColor
            If dlg1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                richTxtbox1.ForeColor = dlg1.Color
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
