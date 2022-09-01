Public Class FrmGame2
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub FrmGame2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)
        Frm_Menu.Close()
        Me.Show()
    End Sub
End Class