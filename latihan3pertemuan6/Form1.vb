Public Class Form1
    Private Sub UbahPesan(Optional ByVal Pesan As String = "")
        If Pesan = "" Then
            MsgBox("tidak ada pesan")
        Else
            MsgBox(Pesan)
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub

    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        Call UbahPesan()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Call UbahPesan("selamat datang")
    End Sub
End Class
