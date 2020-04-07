Public Class Form1
    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        field.Text = BagiDua(7, 2)
    End Sub

    Private Function BagiDua(ByVal nilai1 As Single, ByVal nilai2 As Single) As Single
        Return nilai1 / nilai2
    End Function

End Class
