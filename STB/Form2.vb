Public Class Form2
    Dim Matlab As Object
    Dim Result As String

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.textHeader.Text = "Least significant bit - Text in Image"
        lsb.TopLevel = False
        lsb.TopMost = True
        Form1.pnlContainer.Controls.Add(lsb)
        lsb.Show()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Me.Hide()
        Form1.textHeader.Text = "Least significant bit - Image in Image"
        Patchwork.Close()
        lsbimg.TopLevel = False
        lsbimg.TopMost = True
        Form1.pnlContainer.Controls.Add(lsbimg)
        lsbimg.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Me.Hide()
        Form1.textHeader.Text = "Patchwork"
        Patchwork.TopLevel = False
        Patchwork.TopMost = True
        Form1.pnlContainer.Controls.Add(Patchwork)
        Patchwork.Show()
    End Sub
End Class