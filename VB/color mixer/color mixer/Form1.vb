Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declare variables
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer

        'assing input to variables
        Integer.TryParse(redtextbox.Text, inputRed)
        Integer.TryParse(greentextbox.Text, inputRed)
        Integer.TryParse(bluetextbox.Text, inputBlue)

        'change color
        PictureBox1.BackColor =
            Color.FromArgb(inputRed, inputGreen, inputBlue)
    End Sub
End Class
