Public Class Form1

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        'declaring variables for the inputs
        Dim location As String = txtLocation.Text
        Dim windSpeed As Integer = Val(txtWindSpeed.Text)

        'adding the inputs into the listbox
        lstWeather.Items.Add(location & vbTab & windSpeed)

        ' textbox for location and wind speed will be automatically cleared
        txtLocation.Clear()
        txtWindSpeed.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'both location and wind speed textboxes will empty
        txtLocation.Clear()
        txtWindSpeed.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim weatherFile As System.IO.StreamWriter
        weatherFile = New System.IO.StreamWriter("C:\Users\Lenovo\source\repos\Week_9_Lab-1-Part2\Week_9_Lab-1-Part2\week9-part2.txt")
        weatherFile.WriteLine(lstWeather)
        weatherFile.Close()

    End Sub
End Class
