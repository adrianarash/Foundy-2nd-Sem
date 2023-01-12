Public Class Form1
    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        Dim weatherFile As System.IO.StreamReader
        weatherFile = New System.IO.StreamReader("C:\Users\Lenovo\source\repos\Week_9_Lab-1\Week_9_Lab-1\week9.txt")
        Do While weatherFile.Peek <> -1
            lstWeather.Items.Add(weatherFile.ReadLine)
        Loop
        weatherFile.Close()
    End Sub
End Class
