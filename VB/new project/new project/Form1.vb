Public Class Form1




    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles convert.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)

        Dim russian As Decimal
        russian = Dollars * 60.88
        russian.Text = russian.ToString("n2")



    End Sub
End Class
