Public Class Form1

    Private Sub TampilkanPeringatan(ByVal pesan As String, judul As String)
        MessageBox.Show(pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub

    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        TampilkanPeringatan("isi data sesuai dengan format", "Peringatan")
    End Sub
End Class
