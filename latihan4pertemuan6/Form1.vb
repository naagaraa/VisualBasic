Public Class Form1
    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        field.Text = BagiDua(5)
    End Sub

    Function BagiDua(ByVal nilai As Single) As Single
        Return nilai / 2
    End Function
End Class
