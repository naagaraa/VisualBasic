Public Class Form1

    Public satuan As String
    Public harga, beli, total, diskonan, tagihan, bayar, kembalian As Double
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kodeObat.ResetText()
        namaObat.ResetText()
        satuanObat.ResetText()
        hargaObat.ResetText()
        jumlahObat.ResetText()
        subTotalObat.ResetText()
        diskonaObat.ResetText()
        uangTagihan.ResetText()
        uangBayar.ResetText()
        uangKembali.ResetText()
    End Sub

    Private Sub kodeObat_TextChanged(sender As Object, e As KeyPressEventArgs) Handles kodeObat.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse
            keyAscii = Keys.Back OrElse
            keyAscii = Keys.Space OrElse
            keyAscii = Keys.Return OrElse
            keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            namaObat.Focus()
        End If
    End Sub

    Private Sub namaObat_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaObat.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[A-Z,a-z]" OrElse
            keyAscii = Keys.Back OrElse
            keyAscii = Keys.Space OrElse
            keyAscii = Keys.Return OrElse
            keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then

            satuanObat.Focus()
        End If
    End Sub

    Private Sub satuan_TextChanged(sender As Object, e As KeyPressEventArgs) Handles satuanObat.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            satuan = satuanObat.Text
            'conditional
            Select Case satuan
                Case "Dus"
                    harga = 100000
                    hargaObat.Text = harga
                Case "Box"
                    harga = 30000
                    hargaObat.Text = harga
                Case "Botol"
                    harga = 15000
                    hargaObat.Text = harga
                Case "Kaplet"
                    harga = 5000
                    hargaObat.Text = harga
            End Select
            jumlahObat.Focus()
        End If
    End Sub

    Private Sub jmlbeli_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jumlahObat.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse
            keyAscii = Keys.Back OrElse
            keyAscii = Keys.Space OrElse
            keyAscii = Keys.Return OrElse
            keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            beli = jumlahObat.Text
            total = beli * harga
            subTotalObat.Text = total

            Select Case beli
                Case >= 100
                    diskonan = 0.1 * total
                    diskonaObat.Text = diskonan
                Case 50 To 100
                    diskonan = 0.07 * total
                    diskonaObat.Text = diskonan
                Case 20 To 49
                    diskonan = 0.04 * total
                    diskonaObat.Text = diskonan
                Case 8 To 19
                    diskonan = 0.01 * total
                    diskonaObat.Text = diskonan
                Case Else
                    diskonan = 0
                    diskonaObat.Text = diskonan
            End Select
            tagihan = total - diskonan
            uangTagihan.Text = tagihan
            uangBayar.Focus()
        End If
    End Sub

    Private Sub uangBayar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles uangBayar.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse
            keyAscii = Keys.Back OrElse
            keyAscii = Keys.Space OrElse
            keyAscii = Keys.Return OrElse
            keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            bayar = uangBayar.Text
            kembalian = bayar - tagihan
            uangKembali.Text = kembalian
        End If
    End Sub
End Class
