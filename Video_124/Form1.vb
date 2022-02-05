Imports System.IO
Public Class Form1

    Private myWriter As New StreamWriter("D:\myFile.txt")

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        myWriter.WriteLine(txtToWrite.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        myWriter.Close()
    End Sub
End Class
