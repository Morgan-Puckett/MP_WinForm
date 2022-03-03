Public Class MP_WinFormForm
    Private Sub MP_WinFormForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActionButton.Enabled = False
        Label1.Text = "Check One if youre a silly goose"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click

        Me.Text = NameTextBox.Text
    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub



    'Renames the test name as the key that is selected 
    Private Sub ActionButton_KeyDown(sender As Object, e As KeyEventArgs) Handles ActionButton.KeyDown
        Me.Text = e.KeyCode.ToString

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Select Case True
            Case RadioButton1.Checked
                ActionButton.Enabled = True
            Case RadioButton2.Checked
                ActionButton.Enabled = False
            Case Else
                MsgBox("Whoa what happened")

        End Select
        MsgBox("I changed")
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class
