Public Class lsbimg
    Dim Matlab As Object
    Dim file As System.IO.StreamWriter
    Dim file1 As System.IO.StreamWriter
    Dim Result As String
    Dim s1h As String
    Dim s1w As String
    Dim s2h As String
    Dim s2w As String
    Dim pic1 As System.Drawing.Image
    Dim pic2 As System.Drawing.Image
    Dim width1 As Integer
    Dim height1 As Integer
    Dim width2 As Integer
    Dim height2 As Integer
    Dim fileReader As String
    Dim pathgen As String



    Private Sub btnUpld_Click(sender As Object, e As EventArgs) Handles btnUpld.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            BunifuPictureBox2.ImageLocation = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")


        Matlab = SplashScreen.Matlab

        'file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\zinou\source\repos\STB\STB\Matlabcode\inputs.txt", False)
        file = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\inputs.txt", False)

        'file1 = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\zinou\source\repos\STB\STB\Matlabcode\filepath.txt", False)
        file1 = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\filepath.txt", False)

        pic1 = System.Drawing.Image.FromFile(BunifuPictureBox1.ImageLocation)
        pic2 = System.Drawing.Image.FromFile(BunifuPictureBox2.ImageLocation)

        file.Write(BunifuPictureBox1.ImageLocation)
        file1.Write(BunifuPictureBox2.ImageLocation)

        file.Close()
        file1.Close()



        width1 = pic1.Width
        height1 = pic1.Height
        width2 = pic2.Width
        height2 = pic2.Height


        If width1 = width2 And height1 = height2 Then
            ProgresBar.Show()
            'Result = Matlab.Execute("cd C:\Users\zinou\source\repos\STB\STB\Matlabcode")
            Result = Matlab.Execute("cd " + pathgen + "\Matlabcode")
            Result = Matlab.Execute("lsbImgIns")
            BunifuButton3.Enabled = True
            BunifuButton4.Enabled = True

            ProgresBar.Hide()
            successDialog.Show()
        Else
            FailedBox.BunifuLabel1.Text = "Size Mismatched"
            FailedBox.Show()
        End If

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        ProgresBar.Show()
        Matlab = SplashScreen.Matlab
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        'PictureBox1.ImageLocation = "C:\Users\zinou\source\repos\STB\STB\Matlabcode\stego.png"
        ' PictureBox1.ImageLocation = "C:\Users\zinou\source\repos\STB\STB\Matlabcode\stego.png"
        PictureBox1.ImageLocation = pathgen + "\Matlabcode\stego.png"
        Result = Matlab.Execute("lsbImgExt")
        'PictureBox2.ImageLocation = "C:\Users\zinou\source\repos\STB\STB\Matlabcode\out.png"
        PictureBox2.ImageLocation = pathgen + "\Matlabcode\out.png"
        ProgresBar.Hide()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click

        Matlab = SplashScreen.Matlab
        'Result = Matlab.Execute("cd C:\Users\zinou\source\repos\STB\STB\Matlabcode")
        Result = Matlab.Execute("cd " + pathgen + "\Matlabcode")
        Result = Matlab.Execute("deg")

        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\zinou\source\repos\STB\STB\Matlabcode\mse.txt")
        ' fileReader = My.Computer.FileSystem.ReadAllText(pathgen + "\Matlabcode\mse.txt")
        Estimation.mse.Text = Matlab.Execute("disp(mse)")

        ' fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\zinou\source\repos\STB\STB\Matlabcode\psnr.txt")
        Estimation.psnr.Text = Matlab.Execute("disp(psnr)")

        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\zinou\source\repos\STB\STB\Matlabcode\h.txt")
        Estimation.h.Text = Matlab.Execute("disp(h)")

        Estimation.Show()
    End Sub
End Class