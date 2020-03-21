Public Class Form1
    Public kelas, jurusan As String
    Public jumlah, biayaKuliah, tagihan, bayar As Integer
    Private Sub nimMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles nimMhs.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse
                keyAscii = Keys.Back OrElse
                keyAscii = Keys.Return OrElse
                keyAscii = Keys.Space OrElse
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
                keyAscii = Keys.Return OrElse
                keyAscii = Keys.Space OrElse
                keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
        If (e.KeyChar = Convert.ToChar(13)) Then
            kelasMhs.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub kelasMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles kelasMhs.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            kelas = kelasMhs.Text
            Console.WriteLine(kelas)
            jurusanMhs.Focus()
        End If
    End Sub

    Private Sub jurusanMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jurusanMhs.KeyPress

        If (e.KeyChar = Convert.ToChar(13)) Then
            jurusan = jurusanMhs.Text
            'cek kelas
            If kelas = "Reguler" Then
                'cek jurusan 
                If jurusan = "Akuntansi" Then
                    biayaKuliah = "450000"
                    biayaSks.Text = biayaKuliah
                ElseIf jurusan = "Manajemen" Then
                    biayaKuliah = 400000
                    biayaSks.Text = biayaKuliah
                ElseIf jurusan = "Teknik Informatika" Then
                    biayaKuliah = 350000
                    biayaSks.Text = biayaKuliah
                ElseIf jurusan = "Sistem Informasi" Then
                    biayaKuliah = 330000
                    biayaSks.Text = biayaKuliah
                End If

            ElseIf kelas = "Karyawan" Then
                'cek jurusan
                If jurusan = "Akutansi" Then
                    biayaKuliah = 500000
                    biayaSks.Text = biayaKuliah
                ElseIf jurusan = "Manajemen" Then
                    biayaKuliah = 450000
                    biayaSks.Text = biayaKuliah
                ElseIf jurusan = "Teknik Informatika" Then
                    biayaKuliah = 400000
                    biayaSks.Text = biayaKuliah
                ElseIf jurusan = "Sistem Informasi" Then
                    biayaKuliah = 480000
                    biayaSks.Text = biayaKuliah
                End If
            End If
            jumlahSks.Focus()
        End If
    End Sub

    Private Sub jumlahsksMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jumlahSks.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse
                keyAscii = Keys.Back OrElse
                keyAscii = Keys.Return OrElse
                keyAscii = Keys.Space OrElse
                keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)
        If (e.KeyChar = Convert.ToChar(13)) Then
            jumlah = jumlahSks.Text
            tagihan = CDbl(biayaSks.Text) * jumlah
            totalTagihan.Text = tagihan
            uangBayar.Focus()
        End If
    End Sub

    Private Sub uangBayarMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles uangBayar.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse
                keyAscii = Keys.Back OrElse
                keyAscii = Keys.Return OrElse
                keyAscii = Keys.Space OrElse
                keyAscii = Keys.Delete) Then
            keyAscii = 0
        End If
        e.Handled = CBool(keyAscii)

        If (e.KeyChar = Convert.ToChar(13)) Then
            bayar = CDbl(uangBayar.Text)
            uangKembali.Text = bayar - tagihan
        End If
    End Sub
End Class
