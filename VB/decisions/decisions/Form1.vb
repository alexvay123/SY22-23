Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Integer.TryParse(TextBox1.Text, age)
        Label1.Text = age
        If age > 17 Then
            Label1.Text = "you can vote"
            Me.BackColor = Color.Green
        Else Label1.Text = "you cant vote"
            Me.BackColor = Color.Maroon
        End If
        If CheckBox1.Checked Then
            Me.BackColor = Color.DarkBlue

        End If
        If CheckBox1.Checked And CheckBox2.Checked Then
            Me.BackColor = Color.Purple

        End If
    End Sub
End Class
