Public Class form
    Public nilaiKehadiran, nilaiTugas, nilaiUts, nilaiUas As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        nimMhs.Focus()
    End Sub
    Private Sub nimMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nimMhs.KeyPress
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
            namaMhs.Focus()
        End If
    End Sub

    Private Sub namaMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaMhs.KeyPress
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
            jurusanMhs.Focus()
        End If
    End Sub

    Private Sub jurusanMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jurusanMhs.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar = Convert.ToChar(13)) Then
            nilaiKehadiranMhs.Focus()
        End If
    End Sub

    Private Sub nilaiKehadiranMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiKehadiranMhs.KeyPress
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
            nilaiKehadiran = CInt(nilaiKehadiranMhs.Text)
            nilaiTugasMhs.Focus()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        nimMhs.ResetText()
        namaMhs.ResetText()
        jurusanMhs.ResetText()
        nilaiKehadiranMhs.ResetText()
        nilaiTugasMhs.ResetText()
        nilaiUtsMhs.ResetText()
        nilaiUasMhs.ResetText()
        nilaiAkhirMhs.ResetText()
        gradeMhs.ResetText()
        keterangan.ResetText()
    End Sub

    Private Sub nulaiUtsMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiUtsMhs.KeyPress
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
            nilaiUts = CInt(nilaiUtsMhs.Text)
            nilaiUasMhs.Focus()
        End If
    End Sub

    Private Sub nilaiTugasMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiTugasMhs.KeyPress
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
            nilaiTugas = CInt(nilaiTugasMhs.Text)
            nilaiUtsMhs.Focus()
        End If
    End Sub

    Private Sub nilaiUasMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiUasMhs.KeyPress
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
            nilaiUas = CInt(nilaiUasMhs.Text)

            Dim hasil As Double
            hasil = 0.2 * nilaiKehadiran + 0.25 * nilaiTugas + 0.25 * nilaiUts + 0.3 * nilaiUas

            nilaiAkhirMhs.Text = hasil

            If hasil >= 84 And hasil <= 100 Then
                'grade and ket
                gradeMhs.Text = "A"
                keterangan.Text = "Memuaskan"
            ElseIf hasil >= 64 And hasil <= 83 Then
                'grede and ket
                gradeMhs.Text = "B"
                keterangan.Text = "Baik"
            ElseIf hasil >= 50 And hasil <= 63 Then
                'grede and ket
                gradeMhs.Text = "C"
                keterangan.Text = "Cukup"
            Else
                'grade and ket
                gradeMhs.Text = "D"
                keterangan.Text = "Gagal"
            End If

        End If
    End Sub


End Class
