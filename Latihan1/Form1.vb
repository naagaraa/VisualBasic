Public Class Form1
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim nama As String

        nama = namaSaya.Text

        textField.Text = "Nama saya adalah " + nama

    End Sub
End Class
