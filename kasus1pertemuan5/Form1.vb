Public Class Form1
    Public hargaBarang As String
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click



        Dim arr(3) As String
        arr(1) = namaPelanggan.Text
        arr(2) = namaBarang.Text

        If namaBarang.Text = "Nasi Goreng" Then
            hargaBarang = "10000"
        ElseIf namaBarang.Text = "Ayam Goreng" Then
            hargaBarang = "12000"
        ElseIf namaBarang.Text = "Nasi Rames" Then
            hargaBarang = "15000"
        ElseIf namaBarang.Text = "Gado Gado" Then
            hargaBarang = "8000"
        End If

        arr(3) = hargaBarang
        'membuat list view item

        Dim listitems As ListViewItem
        listitems = New ListViewItem

        listitems = listView.Items.Add(arr(1))
        listitems.SubItems.Add(arr(2))
        listitems.SubItems.Add(arr(3))

        namaPelanggan.ResetText()
        namaBarang.ResetText()
        namaPelanggan.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Menampilkan Grid/Garis Tabel untuk listview
        listView.GridLines = True
        listView.View = View.Details

        'menambahkan Header Untuk Kolom ListView
        listView.Columns.Add("Nama Pelanggan", 200)
        listView.Columns.Add("Nama Barang", 200)
        listView.Columns.Add("Harga Barang", 200)
    End Sub
End Class
