Public Class Form1
    Public kelas, jurusan As String
    Public biaya, jumlah, tagihan, bayar, kembalian As Double
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        nimMhs.ResetText()
        namaMhs.ResetText()
        kelasMhs.ResetText()
        jurusanMhs.ResetText()
        biayaSksMhs.ResetText()
        jumlahSksMhs.ResetText()
        totalTaguhanMhs.ResetText()
        uangBayarMhs.ResetText()
        uangKembaliMhs.ResetText()
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
            kelasMhs.Focus()
        End If
    End Sub

    Private Sub kelasMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles kelasMhs.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            kelas = kelasMhs.Text
            jurusanMhs.Focus()
        End If
    End Sub

    Private Sub jurusanMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jurusanMhs.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            jurusan = jurusanMhs.Text
            'conditional 
            Select Case kelas
                Case "Reguler"

                    Select Case jurusan
                        Case "Akutansi"
                            biaya = 450000
                            biayaSksMhs.Text = biaya
                        Case "Manajemen"
                            biaya = 400000
                            biayaSksMhs.Text = biaya
                        Case "Teknik Informatika"
                            biaya = 350000
                            biayaSksMhs.Text = biaya
                        Case "Sistem Informasi"
                            biaya = 330000
                            biayaSksMhs.Text = biaya
                    End Select

                Case "Karyawan"
                    Select Case jurusan
                        Case "Akutansi"
                            biaya = 500000
                            biayaSksMhs.Text = biaya
                        Case "Manajemen"
                            biaya = 450000
                            biayaSksMhs.Text = biaya
                        Case "Teknik Informatika"
                            biaya = 400000
                            biayaSksMhs.Text = biaya
                        Case "Sistem Informasi"
                            biaya = 380000
                            biayaSksMhs.Text = biaya
                    End Select
            End Select
            jumlahSksMhs.Focus()
        End If
    End Sub

    Private Sub jumlahSksMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jumlahSksMhs.KeyPress
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
            jumlah = jumlahSksMhs.Text
            tagihan = biaya * jumlah
            totalTaguhanMhs.Text = tagihan

            uangBayarMhs.Focus()
        End If
    End Sub

    Private Sub uangBayarMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles uangBayarMhs.KeyPress
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
            bayar = uangBayarMhs.Text
            kembalian = bayar - tagihan
            uangKembaliMhs.Text = kembalian
        End If
    End Sub
End Class
