Public Class SplashScreen
    Public Matlab As Object
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width = Panel2.Width + 3


        If (Panel2.Width >= 599) Then
            Timer1.Stop()
            Me.Hide()
            Login.Show()
        End If

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Matlab = CreateObject("Matlab.Application")
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click

    End Sub

    Private Sub BunifuPictureBox2_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox2.Click

    End Sub
End Class