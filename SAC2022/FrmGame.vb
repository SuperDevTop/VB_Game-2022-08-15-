'Mr wallace ask About txtUserName.Focus() on form load instead of focus on Answer??

Public Class FrmGame
    Dim totalQuestions As Integer
    Dim CorrectAnswers As Integer
    Dim IncorrectAnswers As Integer
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        GenerateNumbers()


    End Sub

    Private Sub chkDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplay.CheckedChanged

        If chkDisplay.Checked = True Then
            GroupBox4.Visible = True
        Else
            GroupBox4.Visible = False

        End If
    End Sub

    Sub GenerateNumbers()
        totalQuestions = totalQuestions + 1

        Dim largest As Integer
        TextBox3.Visible = False
        Label8.Visible = False

        If rbnEasy.Checked Then
            largest = 10
        ElseIf rbnMedium.Checked Then
            largest = 100
        ElseIf rbnHard.Checked Then
            largest = 1000
        End If

        'Randomize()
        Dim a As Integer = CInt(Int((largest * Rnd()) + 1))
        Dim b As Integer = CInt(Int((largest * Rnd()) + 1))
        Dim c As Integer = CInt(Int((4 * Rnd())))

        Select Case c
            Case 0
                Label3.Text = "+"
            Case 1
                Label3.Text = "-"
            Case 2
                Label3.Text = "*"
            Case 3
                Label3.Text = "/"
                TextBox3.Visible = True
                Label8.Visible = True
                TextBox3.Text = ""
        End Select


        'MsgBox("A is: " & a)
        'MsgBox("B is: " & b)

        'a = r.Next(0, largest)
        'b = r.Next(0, largest)
        txtName.Text = a
        txtq2.Text = b




    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim a As Integer
        Dim b As Integer
        Integer.TryParse(txtName.Text, a)
        Integer.TryParse(txtq2.Text, b)
        Dim answer As Integer

        If Integer.TryParse(txtAnswer.Text, answer) = False Then
            MessageBox.Show("The answer must be a number")
            txtAnswer.Focus()
            txtAnswer.SelectAll()
            Return
        End If

        If TextBox3.Text = "" Then
            TextBox3.Text = 0
        End If

        If Label3.Text = "+" Then
            If answer = a + b Then
                CorrectAnswers = CorrectAnswers + 1
            Else
                IncorrectAnswers = IncorrectAnswers + 1
            End If
        ElseIf Label3.Text = "-" Then
            If answer = a - b Then
                CorrectAnswers = CorrectAnswers + 1
            Else
                IncorrectAnswers = IncorrectAnswers + 1
            End If
        ElseIf Label3.Text = "*" Then
            If answer = a * b Then
                CorrectAnswers = CorrectAnswers + 1
            Else
                IncorrectAnswers = IncorrectAnswers + 1
            End If
        ElseIf Label3.Text = "/" Then
            If answer = Math.Floor(a / b) And Integer.Parse(TextBox3.Text) = a Mod b Then
                CorrectAnswers = CorrectAnswers + 1
            Else
                IncorrectAnswers = IncorrectAnswers + 1
            End If
        End If



        TextBox1.Text = CorrectAnswers
        TextBox2.Text = IncorrectAnswers
        TextBox4.Text = String.Format("{0:0.00}", CorrectAnswers / (CorrectAnswers + IncorrectAnswers) * 100)

        GenerateNumbers()
        txtAnswer.Clear()
        txtAnswer.Focus()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Dim choice As Integer = 0

        choice = MsgBox("Are you sure you want to reset quiz?", MsgBoxStyle.YesNo, "Warning")
        If choice = MsgBoxResult.Yes Then
            CorrectAnswers = 0
            IncorrectAnswers = 0
            TextBox1.Text = 0
            TextBox2.Text = 0
            TextBox4.Text = 0
            txtUserName.Text = ""
            GenerateNumbers()
            MsgBox("Please Enter New Player Name")
            txtUserName.Focus()
            'txtAnswer.Focus()


        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveyn As Integer

        Dim deets As String = "Name: " & txtUserName.Text & vbCrLf & "Correct: " & TextBox1.Text & vbCrLf & "Incorrect: " & TextBox2.Text & "Correct(%): " & TextBox4.Text

        saveyn = MsgBox("Are your finito amigo?" & vbCrLf & deets, MsgBoxStyle.YesNo)

        My.Computer.FileSystem.WriteAllText("Temp.txt", deets, False) 'creats temp file with info

        Dim FormReader As New System.IO.StreamReader("Temp.txt") 'defines formreader as temp file location

        FormReader.Close()


        If saveyn = MsgBoxResult.Yes Then
            'MsgBox("Tyler make the file save")

            System.IO.File.Delete("Temp.txt")

            Dim counter = My.Computer.FileSystem.GetFiles("..\Results\")

            Dim prefix As Integer = CStr(counter.Count) + 1
            My.Computer.FileSystem.WriteAllText("..\Results\" & prefix & "_ChosenResult.txt", deets, True)
            MsgBox("File Saved")
            txtAnswer.Focus()


        End If


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub
End Class
