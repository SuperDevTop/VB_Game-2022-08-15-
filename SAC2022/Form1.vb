Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = My.Settings.Username AndAlso txtPassword.Text = My.Settings.Password Then
            MsgBox("Welcome user")
            Me.Hide()
            Frm_Menu.Show()

        ElseIf txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            GlobalVariables.Username = "admin"
            MsgBox("Welcome Admin")
            Frm_Menu.Show()
            Me.Close()


        ElseIf txtUsername.Text = "teacher" And txtPassword.Text = "teacher" Then
            GlobalVariables.Username = "teacher"
            MsgBox("Welome Teacher")
            Frm_Menu.Show()
            Me.Close()

        ElseIf txtUsername.Text = "student" And txtPassword.Text = "student" Then
            GlobalVariables.Username = "student"
            MsgBox("Welome Student")
            Frm_Menu.Show()
            Me.Close()

        Else

            MsgBox("Wrong Username or Password Buster") 'if the username input is not one of the predifened usernames or passwords above a message box will display Wrong Username or Password Buster 
            txtUsername.Clear() 'and clear all written texts 
            txtPassword.Clear()
            txtUsername.Focus() 'then placing the user on the username txtbox

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmCreateAccount.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtGuest.Click


        GlobalVariables.Username = "Guest"
        MsgBox("Welcome Guest, Thank you for trialling the game")
        Frm_Menu.Show()
        Me.Close()


        Frm_Menu.Show()
        Me.Close()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstUsername.Visible = False 'hides list boxes containing user details 
        lstPassword.Visible = False

        Dim Username
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCreateAccount2.Show()
        Me.Close()

    End Sub
End Class

Public Class GlobalVariables

    Public Shared Username As String = ""

End Class
