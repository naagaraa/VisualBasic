Public Class Form1
    Public merek, ukuran As String
    Public harga, jml, bayar, kembalian, tagihan, total, diskonan As Double

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        namaPembeli.ResetText()
        merkBaju.ResetText()
        ukuranBaju.ResetText()
        hargaBaju.ResetText()
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

    Private Sub namaPembeli_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaPembeli.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[A-Z,a-z]" OrElse
            KeyAscii = Keys.Back OrElse
            KeyAscii = Keys.Return OrElse
            KeyAscii = Keys.Space OrElse
            KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)


        If (e.KeyChar = Convert.ToChar(13)) Then
            merkBaju.Focus()
        End If
    End Sub

    Private Sub merekBaju_TextChanged(sender As Object, e As KeyPressEventArgs) Handles merkBaju.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            merek = merkBaju.Text
            ukuranBaju.Focus()
        End If
    End Sub

    Private Sub ukuranBaju_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ukuranBaju.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            ukuran = ukuranBaju.Text

            If merek = "IMP" Then
                'cek ukuran
                If ukuran = "XL" Then
                    harga = 250000
                    hargaBaju.Text = harga
                ElseIf ukuran = "L" Then
                    harga = 24000
                    hargaBaju.Text = harga
                ElseIf ukuran = "M" Then
                    harga = 23000
                    hargaBaju.Text = harga
                End If
            ElseIf merek = "Prada" Then
                'cek ukuran
                If ukuran = "XL" Then
                    harga = 170000
                    hargaBaju.Text = harga
                ElseIf ukuran = "L" Then
                    harga = 160000
                    hargaBaju.Text = harga
                ElseIf ukuran = "M" Then
                    harga = 150000
                    hargaBaju.Text = harga
                End If
            ElseIf merek = "Gucci" Then
                'cek ukuran
                If ukuran = "XL" Then
                    harga = 280000
                    hargaBaju.Text = harga
                ElseIf ukuran = "L" Then
                    harga = 270000
                    hargaBaju.Text = harga
                ElseIf ukuran = "M" Then
                    harga = 260000
                    hargaBaju.Text = harga
                End If
            ElseIf merek = "Loius" Then
                'cek ukuran
                If ukuran = "XL" Then
                    harga = 360000
                    hargaBaju.Text = harga
                ElseIf ukuran = "L" Then
                    harga = 350000
                    hargaBaju.Text = harga
                ElseIf ukuran = "M" Then
                    harga = 340000
                    hargaBaju.Text = harga
                End If
            ElseIf merek = "Denim" Then
                'cek ukuran
                If ukuran = "XL" Then
                    harga = 130000
                    hargaBaju.Text = harga
                ElseIf ukuran = "L" Then
                    harga = 120000
                    hargaBaju.Text = harga
                ElseIf ukuran = "M" Then
                    harga = 110000
                    hargaBaju.Text = harga
                End If
            End If

            jmlBeli.Focus()
        End If
    End Sub
    Private Sub jumlahBeli_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jmlBeli.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse
            KeyAscii = Keys.Back OrElse
            KeyAscii = Keys.Return OrElse
            KeyAscii = Keys.Space OrElse
            KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            jml = CDbl(jmlBeli.Text)
            total = jml * harga
            subTotal.Text = total
            If jml >= 10 Then
                diskonan = 0.2 * total
                diskon.Text = diskonan
            ElseIf jml >= 5 Then
                diskonan = 0.1 * total
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
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse
            KeyAscii = Keys.Back OrElse
            KeyAscii = Keys.Return OrElse
            KeyAscii = Keys.Space OrElse
            KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            bayar = CDbl(uangBayar.Text)
            kembalian = bayar - tagihan
            uangKembalian.Text = kembalian
        End If
    End Sub

End Class
