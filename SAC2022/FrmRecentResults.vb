Public Class FrmRecentResults
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub FrmRecentResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstMenu.Items.Clear()
        txtDisplay.Text = ""

        Dim di As New IO.DirectoryInfo("..\Results\") 'sets directory path gets information it needs from path 
        Dim Filelist As IO.FileInfo() = di.GetFiles()  'gets individual files from directory path 
        Dim Files As IO.FileInfo  'declares files and file information


        For Each Files In Filelist
            lstMenu.Items.Add(Files)
        Next
    End Sub

    Private Sub lstMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMenu.SelectedIndexChanged
        Dim filedetails As String

        filedetails = lstMenu.SelectedItem.ToString 'when u click on the file u want to view it converts to string 

        txtDisplay.Text = System.IO.File.ReadAllText("..\Results\" & filedetails)
    End Sub

    Private Sub btnViewRecent_Click(sender As Object, e As EventArgs) Handles btnViewRecent.Click
        Dim x As Integer = lstMenu.Items.Count()
        lstMenu.SelectedIndex = x - 1
    End Sub
End Class