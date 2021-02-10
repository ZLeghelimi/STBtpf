Public Class crypto
    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Me.Hide()
        Form1.textHeader.Text = "Cryptography Asymmetric - RSA"
        Asymeetric.TopLevel = False
        Asymeetric.TopMost = True
        Form1.pnlContainer.Controls.Add(Asymeetric)
        Asymeetric.Show()
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.textHeader.Text = "Cryptography Symmetric - DES"
        Symetrique.TopLevel = False
        Symetrique.TopMost = True
        Form1.pnlContainer.Controls.Add(Symetrique)
        Symetrique.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        Me.Hide()
        Form1.textHeader.Text = "Hashing"
        Hashing.TopLevel = False
        Hashing.TopMost = True
        Form1.pnlContainer.Controls.Add(Hashing)
        Hashing.Show()
    End Sub
End Class