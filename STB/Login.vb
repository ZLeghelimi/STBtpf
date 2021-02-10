Public Class Login
    Dim User As String
    Dim Pass As String
    Public Matlab As Object
    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Matlab = CreateObject("Matlab.Application")
        User = Username.Text
        Pass = Password.Text
        If (User = "zleghelimi" And Pass = "11031998") Or (User = "alechkheb" And Pass = "18111996") Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub



    Private Sub Username_MouseEnter(sender As Object, e As EventArgs) Handles Username.MouseEnter
        If Username.Text = "Username" Then
            Username.Text = ""
        End If
    End Sub

    Private Sub Username_MouseLeave(sender As Object, e As EventArgs) Handles Username.MouseLeave
        If Username.Text = "" Then
            Username.Text = "Username"
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_MouseEnter(sender As Object, e As EventArgs) Handles Password.MouseEnter
        If Password.Text = "Password" Then
            Password.Text = ""
        End If
    End Sub

    Private Sub Password_MouseLeave(sender As Object, e As EventArgs) Handles Password.MouseLeave
        If Password.Text = "" Then
            Password.Text = "Password"
        End If
    End Sub
End Class