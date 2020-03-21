Public Class Form1
    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        Dim namaHari As String
        Dim ke As String = txtHari.Text

        namaHari = IIf(ke = "1", "SENIN", IIf(ke = "2", "SELASA", IIf(ke = "3", "RABU",
                    IIf(ke = "4", "KAMIS", IIf(ke = "5", "JUM'AT", IIf(ke = "6", "SABTU", "MINGGU"))))))
        txtNamaHari.Text = namaHari
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub
End Class
