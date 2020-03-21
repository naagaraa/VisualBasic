Public Class Form1
    Public kode, nama, harga, satuan, jml, bayar As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String
        pesan = MsgBox("yakin ingin keluar", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub
    'nama Eka Jaya Nagara
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kodeBarang.Text = ""
        namaBarang.Text = ""
        satuanBarang.Text = ""
        hargaSatuan.Text = ""
        jmlBeli.Text = ""
        totalHarga.Text = ""
        uangBayar.Text = ""
        uangKembalian.Text = ""
    End Sub

    Private Sub kodeBarang_keyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBarang.KeyPress
        If (e.KeyChar = Chr(13)) Then
            namaBarang.Focus()
        End If
    End Sub

    Private Sub namaBarang_keyPress(sender As Object, e As KeyPressEventArgs) Handles namaBarang.KeyPress
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
            satuanBarang.Focus()
        End If
    End Sub

    Private Sub SatuanBarang_keyPress(sender As Object, e As KeyPressEventArgs) Handles satuanBarang.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Dim satuanHargabarang As String = satuanBarang.Text

            If satuanHargabarang = "Lusin" Then
                hargaSatuan.Text = 100000
            ElseIf satuanHargabarang = "Kodi" Then
                hargaSatuan.Text = 150000
            End If
            jmlBeli.Focus()
        End If
    End Sub

    'Private Sub hargaSatuan_keyPress(sender As Object, e As KeyPressEventArgs) Handles hargaSatuan.KeyPress

    'If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
    '      e.Handled = True
    '   End If

    'If (e.KeyChar = Chr(13)) Then
    '       jmlBeli.Focus()
    'End If
    'End Sub

    Private Sub jumlahBeli_keyPress(sender As Object, e As KeyPressEventArgs) Handles jmlBeli.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If (e.KeyChar = Chr(13)) Then
            satuan = CInt(hargaSatuan.Text)
            jml = CInt(jmlBeli.Text)

            Dim total As Integer
            total = satuan * jml
            totalHarga.Text = total

            uangBayar.Focus()
        End If
    End Sub

    Private Sub uangBayar_keyPress(sender As Object, e As KeyPressEventArgs) Handles uangBayar.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If (e.KeyChar = Chr(13)) Then
            harga = CInt(totalHarga.Text)
            bayar = CInt(uangBayar.Text)

            Dim total As Integer
            total = bayar - harga
            uangKembalian.Text = total
        End If
    End Sub
End Class
