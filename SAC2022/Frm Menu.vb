Public Class Frm_Menu


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If GlobalVariables.Username = "admin" Then
            btnPastResults.Enabled = True
            btnPlayGames.Enabled = True
            btnRecentResults.Enabled = True
        End If

        If GlobalVariables.Username = "teacher" Then
            btnPastResults.Enabled = True
            btnPlayGames.Enabled = False
            btnRecentResults.Enabled = True
            btnTeacher.Enabled = False
        End If

        If GlobalVariables.Username = "student" Then
            btnPastResults.Enabled = False
            btnPlayGames.Enabled = True
            btnRecentResults.Enabled = False
            btnTeacher.Enabled = True
        End If

        If GlobalVariables.Username = "Guest" Then
            btnPastResults.Enabled = False
            btnPlayGames.Enabled = True
            btnRecentResults.Enabled = False
        End If

    End Sub

    Private Sub btnPlayGames_Click(sender As Object, e As EventArgs) Handles btnPlayGames.Click
        FrmGame.Show()
        Me.Close()
    End Sub

    Private Sub btnPastResults_Click(sender As Object, e As EventArgs) Handles btnPastResults.Click
        FrmPastResults.Show()
        Me.Close()
    End Sub

    Private Sub btnRecentResults_Click(sender As Object, e As EventArgs) Handles btnRecentResults.Click
        FrmRecentResults.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        FrmGame2.Show()
        Me.Close()
    End Sub
End Class

