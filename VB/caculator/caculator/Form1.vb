Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim opper As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button16.Click, Button1.Click
        displaytextbox.Text = displaytextbox.Text + sender.text

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Decimal.TryParse(displaytextbox.Text, first)
        displaytextbox.Clear()
        opper = sender.text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click


        If opper = "+" Then
            Decimal.TryParse(displaytextbox.Text, second)
            displaytextbox.Text = first + second
        End Sub

    Private Sub displaytextbox_TextChanged(sender As Object, e As EventArgs) Handles displaytextbox.TextChanged

    End Sub
    End If

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        displaytextbox.Text = Math.PI
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Decimal.TryParse(displaytextbox.Text, mem)
    End Sub-