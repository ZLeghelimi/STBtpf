Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cryptography.Click
        Hashing.Close()
        Symetrique.Close()
        Asymeetric.Close()
        About.Close()
        KochZhao.Close()
        Form2.Close()
        crypto.Close()
        Biometric.Close()
        Patchwork.Close()
        lsb.Close()
        lsbimg.Close()
        textHeader.Text = "Home"
        Home.TopLevel = False
        Home.TopMost = True
        Me.pnlContainer.Controls.Add(Home)
        Home.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Hashing.Close()
        Asymeetric.Close()
        Biometric.Close()
        Symetrique.Close()
        About.Close()
        Form2.Close()
        lsbimg.Close()
        Home.Close()
        lsb.Close()
        Patchwork.Close()
        Biometric.Close()
        lsbimg.Close()
        textHeader.Text = "Cryptography"
        crypto.TopLevel = False
        crypto.TopMost = True
        Me.pnlContainer.Controls.Add(crypto)
        crypto.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hashing.Close()
        Asymeetric.Close()
        Symetrique.Close()
        About.Close()
        crypto.Close()
        KochZhao.Close()
        Home.Close()
        lsb.Close()
        Patchwork.Close()
        Biometric.Close()
        lsbimg.Close()
        textHeader.Text = "Steganography"
        Form2.TopLevel = False
        Form2.TopMost = True
        Me.pnlContainer.Controls.Add(Form2)
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hashing.Close()
        Asymeetric.Close()
        Symetrique.Close()
        crypto.Close()
        Home.Close()
        lsb.Close()
        Patchwork.Close()
        lsbimg.Close()
        Form2.Close()
        About.Close()
        Biometric.Close()
        textHeader.Text = "Watermarking - Koch and Zhao"
        KochZhao.TopLevel = False
        KochZhao.TopMost = True
        Me.pnlContainer.Controls.Add(KochZhao)
        KochZhao.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BunifuPictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.TopLevel = False
        Home.TopMost = True
        Me.pnlContainer.Controls.Add(Home)
        Home.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hashing.Close()
        Asymeetric.Close()
        Symetrique.Close()
        crypto.Close()
        KochZhao.Close()
        Home.Close()
        lsb.Close()
        Patchwork.Close()
        lsbimg.Close()
        Form2.Close()
        Biometric.Close()
        textHeader.Text = "About"
        About.TopLevel = False
        About.TopMost = True
        Me.pnlContainer.Controls.Add(About)
        About.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hashing.Close()
        Asymeetric.Close()
        About.Close()
        Symetrique.Close()
        crypto.Close()
        KochZhao.Close()
        Home.Close()
        lsb.Close()
        Patchwork.Close()
        lsbimg.Close()
        Form2.Close()
        textHeader.Text = "Biometrics"
        Biometric.TopLevel = False
        Biometric.TopMost = True
        Me.pnlContainer.Controls.Add(Biometric)
        Biometric.Show()
    End Sub
End Class
