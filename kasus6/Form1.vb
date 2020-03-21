Public Class Form1
    Public kode, nama, kategori, harga, jml, total, subTotalBuku, bayar, kembali As String

    Private Sub kodeBuku_keyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBuku.KeyPress

        If (e.KeyChar = Chr(13)) Then
            namaBuku.Focus()
        End If

    End Sub
    'nama Eka Jaya Nagara
    Private Sub namaBuku_keyPress(sender As Object, e As KeyPressEventArgs) Handles namaBuku.KeyPress

        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[A-Z,a-z]" OrElse
            keyAscii = Keys.Back OrElse
            keyAscii = Keys.Space OrElse
            keyAscii = Keys.Return OrElse
            keyAscii = Keys.Delete) Then

            keyAscii = 0
        End If

        e.Handled = CBool(keyAscii)
        If (e.KeyChar = Chr(13)) Then
            kategoriBuku.Focus()
        End If

    End Sub

    Private Sub kategoriBuku_keyPress(sender As Object, e As KeyPressEventArgs) Handles kategoriBuku.KeyPress

        Dim nilai As String
        nilai = kategoriBuku.Text

        If nilai = "Komik" Then
            hargaBuku.Text = 50000
        ElseIf nilai = "Koran" Then
            hargaBuku.Text = 20000
        ElseIf nilai = "Majalah" Then
            hargaBuku.Text = 10000
        End If

        If (e.KeyChar = Chr(13)) Then
            jmlBeli.Focus()
        End If

    End Sub

    'Private Sub hargaBuku_keyPress(sender As Object, e As KeyPressEventArgs) Handles hargaBuku.KeyPress

    'If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
    '   e.Handled = True
    'End If

    ' If (e.KeyChar = Chr(13)) Then
    '     jmlBeli.Focus()
    ' End If

    'End Sub

    Private Sub jumlahBeli_keyPress(sender As Object, e As KeyPressEventArgs) Handles jmlBeli.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If (e.KeyChar = Chr(13)) Then
            'hitung total
            harga = CInt(hargaBuku.Text)
            jml = CInt(jmlBeli.Text)
            total = harga * jml
            subTotal.Text = total

            uangBayar.Focus()
        End If

    End Sub

    Private Sub bayarBuku_keyPress(sender As Object, e As KeyPressEventArgs) Handles uangBayar.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If (e.KeyChar = Chr(13)) Then
            'hitung kembalian
            subTotalBuku = CInt(subTotal.Text)
            bayar = CInt(uangBayar.Text)
            kembali = bayar - subTotalBuku

            uangKembali.Text = kembali
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kodeBuku.Text = ""
        namaBuku.Text = ""
        kategoriBuku.Text = ""
        hargaBuku.Text = ""
        hargaBuku.Text = ""
        jmlBeli.Text = ""
        subTotal.Text = ""
        uangBayar.Text = ""
        uangKembali.Text = ""
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("yakin mau keluar?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub
End Class
