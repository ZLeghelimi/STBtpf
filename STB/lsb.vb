Public Class lsb

    Dim Matlab As Object
    Dim Result As String
    Dim msgSecretv As String
    Dim path As String
    Dim file As System.IO.StreamWriter
    Dim file1 As System.IO.StreamWriter
    Dim fileReader As String
    Dim pathgen As String


    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        file = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\inputs.txt", False)
        'file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\zinou\source\repos\STB\STB\Matlabcode\inputs.txt", False)
        'file1 = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\zinou\source\repos\STB\STB\Matlabcode\filepath.txt", False)
        file1 = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\filepath.txt", False)
        msgSecretv = msgSecret.Text
        msgReceived.Text = ""
        path = OpenFileDialog1.FileName.ToString
        If msgSecretv = "" Or path = "OpenFileDialog1" Then
            FailedBox.Show()
        Else
            file.Write(msgSecretv)
            file1.Write(path)
            Display.Enabled = True

            successDialog.Show()
        End If

        file.Close()
        file1.Close()

    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        Matlab = SplashScreen.Matlab
        'Result = Matlab.Execute("cd C:\Users\zinou\source\repos\STB\STB\Matlabcode")
        Result = Matlab.Execute("cd " + pathgen + "\Matlabcode")
        Result = Matlab.Execute("lsbmain")
        BunifuPictureBox2.ImageLocation = pathgen + "\Matlabcode\stego.png"

        fileReader = My.Computer.FileSystem.ReadAllText(pathgen + "\Matlabcode\outputs.txt")

        msgReceived.Text = fileReader
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click


        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub
End Class