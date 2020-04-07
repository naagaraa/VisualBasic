Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        hasil.Items.Clear()
        txtAngka.ResetText()
    End Sub

    Private Sub keliapatan2_Click(sender As Object, e As EventArgs) Handles keliapatan2.Click
        Dim x As Byte = 0
        Do
            Call ulang(x)
            x = x + 2
        Loop Until x > val(txtAngka.Text)
    End Sub

    Private Sub keliapatan3_Click(sender As Object, e As EventArgs) Handles keliapatan3.Click
        Dim x As Byte = 0
        Do
            Call ulang_cetak(x)
            x = x + 3
        Loop Until x > val(txtAngka.Text)
    End Sub

    Sub ulang_cetak(ByVal angka As Byte)
        If angka > 0 Then
            hasil.Items.Add("*" & angka & "*")
        End If
    End Sub
    Sub ulang(ByVal angka As Byte)
        If angka > 0 Then
            hasil.Items.Add("*" & angka & "*")
        End If
    End Sub
End Class
