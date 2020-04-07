Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim makanan(3) As String
        makanan(0) = "Nasi Goreng"
        makanan(1) = "Ayam Goreng"
        makanan(2) = "Nasi Remes"
        makanan(3) = "Gado-Gado"

        For Each element As String In makanan
            cbmakanan.Items.Add(element)
        Next

        cbmakanan.Text = "Menu Makanan"
    End Sub

    'Nama : Eka Jaya Nagara
End Class
