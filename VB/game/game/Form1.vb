Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
    End Sub

    Public Player = Me.P
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.W
                P.Location += New Point(0, -10)
            Case Keys.S
                P.Location += New Point(0, 10)
            Case Keys.A
                P.Location += New Point(-10, 0)
            Case Keys.D
                P.Location += New Point(10, 0)

        End Select
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class