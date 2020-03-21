Public Class Form1
    Public jabatan, anak As String
    Public gajiPokok, tunjanganJa, tunjanganKe, total, pphPegawai, gaji As Double
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        namaPegawai.ResetText()
        jenisKelaminPegawai.ResetText()
        jabatanPegawai.ResetText()
        gajiPokokPegawai.ResetText()
        tunjanganKeluarga.ResetText()
        jumlahAnak.ResetText()
        tunjanganKeluarga.ResetText()
        totalGaji.ResetText()
        pph.ResetText()
        gajiBersih.ResetText()
    End Sub

    Private Sub namaPegawai_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaPegawai.KeyPress
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
            jenisKelaminPegawai.Focus()
        End If
    End Sub

    Private Sub jenisKelamin_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jenisKelaminPegawai.KeyPress
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
            jabatanPegawai.Focus()
        End If
    End Sub

    Private Sub jabatanPegawai_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jabatanPegawai.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            jabatan = jabatanPegawai.Text
            'conditional
            Select Case jabatan
                Case "Manager"
                    gajiPokok = 3000000
                    tunjanganJa = 2000000
                    gajiPokokPegawai.Text = gajiPokok
                    tunjanganPegawai.Text = tunjanganJa
                Case "Supervisor"
                    gajiPokok = 1500000
                    tunjanganJa = 1000000
                    gajiPokokPegawai.Text = gajiPokok
                    tunjanganPegawai.Text = tunjanganJa
                Case "Operasional"
                    gajiPokok = 1000000
                    tunjanganJa = 500000
                    gajiPokokPegawai.Text = gajiPokok
                    tunjanganPegawai.Text = tunjanganJa
            End Select
            jumlahAnak.Focus()
        End If
    End Sub

    Private Sub jumlahAnak_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jumlahAnak.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            anak = jumlahAnak.Text
            Select Case anak
                Case "2"
                    tunjanganKe = 500000
                    tunjanganKeluarga.Text = tunjanganKe
                Case "1"
                    tunjanganKe = 300000
                    tunjanganKeluarga.Text = tunjanganKe
                Case "0"
                    tunjanganKe = 100000
                    tunjanganKeluarga.Text = tunjanganKe
            End Select

            total = gajiPokok + tunjanganJa + tunjanganKe
            totalGaji.Text = total

            pphPegawai = 0.25 * total
            pph.Text = pphPegawai

            gaji = total - pphPegawai
            gajiBersih.Text = gaji
        End If
    End Sub


End Class
