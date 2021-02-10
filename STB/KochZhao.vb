Public Class KochZhao
    Dim marque As String
    Dim pathgen As String
    Dim path As String
    Dim file, file1 As System.IO.StreamWriter
    Dim Matlab As Object
    Dim Result As String
    Dim fileReader1 As String

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            BunifuPictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        Matlab = SplashScreen.Matlab
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        Result = Matlab.Execute("cd " + pathgen + "\Matlabcode")
        Result = Matlab.Execute("ZhaoExtract")
        fileReader1 = My.Computer.FileSystem.ReadAllText(pathgen + "\Matlabcode\outputs.txt")
        marqueR.Text = fileReader1
        PictureBox1.ImageLocation = pathgen + "\Matlabcode\stegoma.png"
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Matlab = SplashScreen.Matlab
        pathgen = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
        file = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\inputs.txt", False)
        file1 = My.Computer.FileSystem.OpenTextFileWriter(pathgen + "\Matlabcode\filepath.txt", False)
        marque = marqueS.Text
        marqueR.Text = ""

        path = OpenFileDialog1.FileName.ToString

        If marque = "" Or path = "OpenFileDialog1" Then
            FailedBox.Show()
        Else
            file.Write(marque)
            file1.Write(path)
            file.Close()
            file1.Close()
            Display.Enabled = True
            ProgresBar.Show()
            Result = Matlab.Execute("cd " + pathgen + "\Matlabcode")
            Result = Matlab.Execute("ZhaoInsert")
            ProgresBar.Close()
            successDialog.Show()
        End If


    End Sub
End Class