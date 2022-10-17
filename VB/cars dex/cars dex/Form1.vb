Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displaypicturebox.Image = bmw.Image
        namelabel.Text = "bmw m3 e30"
        yearlabel.Text = "1982"
        mphlabel.Text = "142"
        costlabel.Text = "67.633"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        displaypicturebox.Image = bmw2000.Image
        namelabel.Text = "bmw 2000 3 series"
        yearlabel.Text = "2000"
        mphlabel.Text = "155"
        costlabel.Text = "26.00"
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub bmw_Click(sender As Object, e As EventArgs) Handles bmw.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles mphlabel.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles namelabel.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles ford.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles costlabel.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        displaypicturebox.Image = ford.Image
        namelabel.Text = "ford carpi"
        yearlabel.Text = "1968"
        mphlabel.Text = "130"
        costlabel.Text = "4.070"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        displaypicturebox.Image = subaru.Image
        namelabel.Text = "subaru lenon"
        yearlabel.Text = "1984"
        mphlabel.Text = "106"
        costlabel.Text = "6,137"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        displaypicturebox.Image = toyota.Image
        namelabel.Text = "toyota cleicia"
        yearlabel.Text = "1990"
        mphlabel.Text = "120"
        costlabel.Text = "$3,867"
    End Sub
End Class