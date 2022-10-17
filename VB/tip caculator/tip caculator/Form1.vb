Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tip As Decimal
        Dim amount As Decimal
        Decimal.TryParse(TextBox1.Text, amount)
        Dim total As Decimal
        If RadioButton1.Checked Then
            tip = 1.1
        End If
        If RadioButton2.Checked Then
            Dim TextBox2 As 1.15

        End If
        total = amount * tip
        TextBox2.Text = total

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
