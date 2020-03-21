Public Class Form1
    Public merek, ukuran As String
    Public harga, total, beli, diskonan, tagihan, bayar, kembalian As Double
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        namaPembeli.ResetText()
        merekBaju.ResetText()
        ukuranBaju.ResetText()
        hargaBaju.ResetText()
        jumlahBeli.ResetText()
        subTotal.ResetText()
        diskon.ResetText()
        uangBayar.ResetText()
        totalTagihan.ResetText()
        uangKembalian.ResetText()

    End Sub

    Private Sub namaPembeli_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaPembeli.KeyPress
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
            merekBaju.Focus()
        End If
    End Sub
    Private Sub merekBaju_TextChanged(sender As Object, e As KeyPressEventArgs) Handles merekBaju.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            merek = merekBaju.Text
            ukuranBaju.Focus()
        End If
    End Sub

    Private Sub ukuranBaju_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ukuranBaju.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            ukuran = ukuranBaju.Text

            Select Case merek
                Case "IMP"
                    Select Case ukuran
                        Case "XL"
                            harga = 250000
                            hargaBaju.Text = harga
                        Case "L"
                            harga = 240000
                            hargaBaju.Text = harga
                        Case "M"
                            harga = 230000
                            hargaBaju.Text = harga
                    End Select
                Case "Prada"
                    Select Case ukuran
                        Case "XL"
                            harga = 170000
                            hargaBaju.Text = harga
                        Case "L"
                            harga = 160000
                            hargaBaju.Text = harga
                        Case "M"
                            harga = 150000
                            hargaBaju.Text = harga
                    End Select
                Case "Gucci"
                    Select Case ukuran
                        Case "XL"
                            harga = 280000
                            hargaBaju.Text = harga
                        Case "L"
                            harga = 270000
                            hargaBaju.Text = harga
                        Case "M"
                            harga = 260000
                            hargaBaju.Text = harga
                    End Select
                Case "Loius"
                    Select Case ukuran
                        Case "XL"
                            harga = 360000
                            hargaBaju.Text = harga
                        Case "L"
                            harga = 350000
                            hargaBaju.Text = harga
                        Case "M"
                            harga = 340000
                            hargaBaju.Text = harga
                    End Select
                Case "Denim"
                    Select Case ukuran
                        Case "XL"
                            harga = 130000
                            hargaBaju.Text = harga
                        Case "L"
                            harga = 120000
                            hargaBaju.Text = harga
                        Case "M"
                            harga = 110000
                            hargaBaju.Text = harga
                    End Select
            End Select
            jumlahBeli.Focus()
        End If
    End Sub

    Private Sub jmlBeli_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jumlahBeli.KeyPress
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
            beli = jumlahBeli.Text
            total = harga * beli
            subTotal.Text = total

            If beli >= 10 Then
                diskonan = 0.5 * total
                diskon.Text = diskonan
            ElseIf beli >= 5 Then
                diskonan = 0.25 * total
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
            bayar = uangBayar.Text
            kembalian = bayar - tagihan
            uangKembalian.Text = kembalian
        End If
    End Sub
End Class
