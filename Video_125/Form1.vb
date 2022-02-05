Imports System.IO
Public Class Form1

    Private fileToLoad As New StreamReader("D:\myFile.txt")

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        TextBox1.Text = fileToLoad.ReadToEnd()
    End Sub
End Class
