Public Class Form1
    Public harga, jml, total, diskonan, tagihan, bayar, kembalian As Double
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kodeObat.ResetText()
        namaObat.ResetText()
        satuanObat.ResetText()
        hargaSatuan.ResetText()
        jmlBeli.ResetText()
        subTotal.ResetText()
        diskon.ResetText()
        totalTagihan.ResetText()
        uangBayar.ResetText()
        uangKembalian.ResetText()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
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

    Private Sub satuanObat_TextChanged(sender As Object, e As KeyPressEventArgs) Handles satuanObat.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            hargaSatuan.Focus()
        End If
    End Sub

    Private Sub hargaSatuan_TextChanged(sender As Object, e As KeyPressEventArgs) Handles hargaSatuan.KeyPress
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
            harga = CDbl(hargaSatuan.Text)
            jmlBeli.Focus()
        End If
    End Sub

    Private Sub jumlBeliObat_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jmlBeli.KeyPress
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
            jml = CDbl(jmlBeli.Text)


            total = harga * jml
            subTotal.Text = total

            If jml >= 100 Then
                diskonan = 0.1 * total
                diskon.Text = diskonan
            ElseIf jml >= 50 Then
                diskonan = 0.07 * total
                diskon.Text = diskonan
            ElseIf jml >= 20 Then
                diskonan = 0.04 * total
                diskon.Text = diskonan
            Else
                diskonan = 0
                diskon.Text = diskonan
            End If

            tagihan = total - diskonan
            totalTagihan.Text = tagihan
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
            bayar = CDbl(uangBayar.Text)
            'code
            kembalian = bayar - tagihan
            uangKembalian.Text = kembalian
        End If
    End Sub
End Class
