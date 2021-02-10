Public Class Home


    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        Panel1.BackColor = Color.FromArgb(255, Color.White)
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.Transparent
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter
        Panel3.BackColor = Color.FromArgb(255, Color.White)
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = Color.Transparent
    End Sub

    Private Sub Panel7_MouseEnter(sender As Object, e As EventArgs) Handles Panel7.MouseEnter
        Panel7.BackColor = Color.FromArgb(255, Color.White)
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave
        Panel7.BackColor = Color.Transparent
    End Sub

    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        Panel5.BackColor = Color.FromArgb(255, Color.White)
    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave
        Panel5.BackColor = Color.Transparent
    End Sub
End Class