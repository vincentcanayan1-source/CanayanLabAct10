Imports System.Diagnostics.Eventing
Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt"
    Private Sub Write_Click(sender As Object, e As EventArgs) Handles Write.Click
        Dim input As Integer
        If Integer.TryParse(TextBox1.Text, input) Then

            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(input)
            End Using

            MessageBox.Show("Number saved to file.")
            TextBox1.Clear()

        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

    Private Sub Read_Click(sender As Object, e As EventArgs) Handles Read.Click
        ListBox1.Items.Clear()
        Using reader As New StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()
            While (line IsNot Nothing)
                ListBox1.Items.Add(line)
                line = reader.ReadLine()
            End While
        End Using

    End Sub

    Private Sub Sort_Click(sender As Object, e As EventArgs) Handles Sort.Click

    End Sub
End Class
