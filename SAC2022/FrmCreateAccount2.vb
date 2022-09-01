Public Class FrmCreateAccount2
    Private Sub FrmCreateAccount2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Answer As Integer
        Dim Logjob As String = "Username: " & txtUsername.Text & vbCrLf & "Password: " & txtConfirmPassword.Text & vbCrLf

        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please ensure all fields are filled") 'line 10/11 ensure all fields are filled by the user before they can submit their answer 
        ElseIf Not txtPassword.Text = txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match, Please Confirm Password")
            txtConfirmPassword.Text = ""
            txtPassword.Text = ""
            txtPassword.Focus()

        Else
            Dim counter = My.Computer.FileSystem.GetFiles("..\Users\")

            Dim Prefix As Integer = CStr(counter.Count) + 1

            My.Computer.FileSystem.WriteAllText("..\Users\" & "Users.txt", Logjob, True) 'Writes the informatino to file 
            MessageBox.Show("Welcome New User, Please Login on the Next Page")
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class