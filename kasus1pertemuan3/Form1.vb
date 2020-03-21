Public Class Form1
    Public harga, jml, bayar As String
    Public diskonan, total, kembalian As Double
    Private Sub kodeBuku_TextChanged(sender As Object, e As KeyPressEventArgs) Handles kodeBuku.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyAscii = Keys.Back) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            namaBuku.Focus()
        End If
    End Sub

    Private Sub namaBuku_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaBuku.KeyPress
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
            kategoriBuku.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        kodeBuku.ResetText()
        namaBuku.ResetText()
        kategoriBuku.ResetText()
        hargaBuku.ResetText()
        jumlahBuku.ResetText()
        subTotal.ResetText()
        diskon.ResetText()
        totalTagihan.ResetText()
        uangBayar.ResetText()
        uangKembali.ResetText()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub kategoriBuku_TextChanged(sender As Object, e As KeyPressEventArgs) Handles kategoriBuku.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            hargaBuku.Focus()
        End If
    End Sub

    Private Sub hargaBuku_TextChanged(sender As Object, e As KeyPressEventArgs) Handles hargaBuku.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyAscii = Keys.Back) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            harga = CDbl(hargaBuku.Text)
            jumlahBuku.Focus()
        End If

    End Sub

    Private Sub jumlahBuku_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jumlahBuku.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyAscii = Keys.Back) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)


        If (e.KeyChar = Convert.ToChar(13)) Then

            jml = CDbl(jumlahBuku.Text)
            total = harga * jml
            subTotal.Text = total

            If total >= 100000 Then
                diskonan = 0.05 * total
                diskon.Text = diskonan
            Else
                diskonan = 0
                diskon.Text = diskonan
            End If

            totalTagihan.Text = (total - diskonan)
            uangBayar.Focus()
        End If
    End Sub

    Private Sub uangBayar_TextChanged(sender As Object, e As KeyPressEventArgs) Handles uangBayar.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)

        If (e.KeyChar Like "[0-9]" OrElse keyAscii = Keys.Back) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            'code
            bayar = uangBayar.Text
            kembalian = CDbl(bayar) - total
            uangKembali.Text = kembalian
        End If
    End Sub

End Class
