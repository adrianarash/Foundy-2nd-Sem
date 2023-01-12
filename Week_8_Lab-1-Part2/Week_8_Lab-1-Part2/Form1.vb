Public Class Form1
    'FUNCTION FOR WRONG ANSWER
    Sub sorry()
        MsgBox("Sorry wrong answer", MsgBoxStyle.Exclamation, "WRONG")
    End Sub
    'FUNCTION FOR CORRECT ANSWER
    Sub correct()
        MsgBox(UCase(TextBox1.Text), MsgBoxStyle.Information, "CORRECT")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call sorry()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call sorry()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call sorry()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call sorry()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call correct()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call sorry()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call correct()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call sorry()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call sorry()
    End Sub
End Class
