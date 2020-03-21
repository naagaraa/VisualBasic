Public Class Form1
    Public Structure buku
        Dim kode, nama, isbnbuku, kategori, harga As String
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kodeBuku.Focus()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim data As buku
        data.kode = kodeBuku.Text
        data.nama = namaBuku.Text
        data.kategori = kategoriBuku.Text
        data.isbnbuku = isbn.Text
        data.harga = hargaBuku.Text

        'nama Eka Jaya Nagara

        fieldKodeBuku.Text = data.kode
        fieldNamaBuku.Text = data.nama
        fieldKategoriBuku.Text = data.kategori
        fieldISBN.Text = data.isbnbuku
        fieldHargaBuku.Text = data.harga
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kodeBuku.Text = ""
        namaBuku.Text = ""
        kategoriBuku.Text = ""
        isbn.Text = ""
        hargaBuku.Text = ""

        fieldKodeBuku.Text = ""
        fieldNamaBuku.Text = ""
        fieldKategoriBuku.Text = ""
        fieldISBN.Text = ""
        fieldHargaBuku.Text = ""

        kodeBuku.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim pesan As String
        pesan = MsgBox("apakah anda yakin ?", vbYesNo, "pesan konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub


    Private Sub kodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBuku.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            namaBuku.Focus()
        End If
    End Sub

    Private Sub namaBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaBuku.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            isbn.Focus()
        End If
    End Sub

    Private Sub isbnBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles isbn.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            kategoriBuku.Focus()
        End If
    End Sub

    Private Sub kategoriBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kategoriBuku.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            hargaBuku.Focus()
        End If
    End Sub


End Class
