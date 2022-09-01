Public Class FrmPastResults
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Frm_Menu.Show()
        Me.Close()

    End Sub

    Private Sub FrmPastResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        txtDisplay.Text = System.IO.File.ReadAllText("..\Results\" & filedetails) 'displays the chosen file from file location quotes on textbox

    End Sub
End Class