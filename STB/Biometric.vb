Public Class Biometric
    Dim Matlab As Object
    Dim Result As String
    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        Matlab = SplashScreen.Matlab
        Result = Matlab.Execute("cd C:\Users\zinou\source\repos\STB\STB\Matlabcode\")
        Result = Matlab.Execute("USBWebcamMATLABOnline")
        Result = Matlab.Execute("imwrite(img,'C:\Users\zinou\source\repos\STB\STB\Matlabcode\hhh.png');")

    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Matlab = SplashScreen.Matlab
        Result = Matlab.Execute("cd C:\Users\zinou\source\repos\STB\STB\Matlabcode\")
        Result = Matlab.Execute("clear;")
    End Sub
End Class