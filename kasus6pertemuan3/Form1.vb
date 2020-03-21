Public Class Form1
    Public grade As String
    Public kehadiran, tugas, uts, uas, akhir As Double
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
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
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
        If (e.KeyChar = Convert.ToChar(13)) Then
            nilaiKehadiranMhs.Focus()
        End If
    End Sub

    Private Sub nilaiKehadiran_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiKehadiranMhs.KeyPress
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
            kehadiran = CDbl(nilaiKehadiranMhs.Text)
            nilaiTugasMhs.Focus()
        End If
    End Sub

    Private Sub nilaiTugas_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiTugasMhs.KeyPress
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
            tugas = CDbl(nilaiTugasMhs.Text)
            nilaiUtsMhs.Focus()
        End If
    End Sub

    Private Sub nilaiUts_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiUtsMhs.KeyPress
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
            uts = CDbl(nilaiUtsMhs.Text)
            nilaiUasMhs.Focus()
        End If
    End Sub

    Private Sub nilaiUas_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nilaiUasMhs.KeyPress
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
            uas = CDbl(nilaiUasMhs.Text)

            akhir = (0.2 * kehadiran) + (0.25 * tugas) + (0.25 * uts) + (0.3 * uas)
            nilaiAkhirMhs.Text = akhir

            grade = IIf(akhir >= 86 And akhir <= 100, "A",
                       IIf(akhir >= 74 And akhir <= 85, "B",
                       IIf(akhir >= 60 And akhir <= 73, "C",
                       IIf(akhir >= 46 And akhir <= 59, "D", "E"))))

            gradeMhs.Text = grade
        End If
    End Sub
End Class
