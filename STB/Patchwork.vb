Public Class Patchwork

    Dim Matlab As Object
    Dim file As System.IO.StreamWriter
    Dim file1 As System.IO.StreamWriter
    Dim fileReader As String
    Dim fileReader1 As String
    Dim msgSecretv As String
    Dim path As String
    Dim Result As String
    Dim pathgen As String
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnUpload_Click_1(sender As Object, e As EventArgs) Handles btnUpload.Click
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        Matlab = SplashScreen.Matlab

        'file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\zinou\source\repos\STB\STB\Matlabcode\inputs.txt", False)
        file = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\inputs.txt", False)
        file1 = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\filepath.txt", False)


        msgSecretv = ""
        msgSecretv = msgSecret.Text
        msgReceived.Text = ""

        path = OpenFileDialog1.FileName.ToString

        file.Write(msgSecretv)
        file1.Write(path)

        file.Close()
        file1.Close()



        If msgSecretv = "" Or path = "OpenFileDialog1" Then

            FailedBox.Show()

        Else


            ProgresBar.Show()


            Result = Matlab.Execute("cd " + pathgen + "\Matlabcode")
            Result = Matlab.Execute("PacthInsert")

            Display.Enabled = True
            successDialog.Show()
            ProgresBar.Hide()

        End If


    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        ProgresBar.Show()
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        BunifuPictureBox2.ImageLocation = BunifuPictureBox1.ImageLocation
        'Result = Matlab.Execute("cd C:\Users\zinou\source\repos\STB\STB\Matlabcode")
        Result = Matlab.Execute("cd" + pathgen + "\Matlabcode")
        Result = Matlab.Execute("PatchExtrac")
        fileReader1 = My.Computer.FileSystem.ReadAllText(pathgen + "\Matlabcode\outputs.txt")
        msgReceived.Text = fileReader1
        ProgresBar.Hide()
        successDialog.Show()
    End Sub
End Class