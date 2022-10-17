Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
        TextBox1.Text = hat * 8.99 + jacket * 74.99 + pants * 49.99 + nikeb * 139.99 + dodgers * 220
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.ShowDialog()
        TextBox1.Text = hat * 8.99 + jacket * 74.99 + pants * 49.99 + nikeb * 139.99 + dodgers * 220
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
