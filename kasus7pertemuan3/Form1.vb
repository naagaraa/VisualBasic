Public Class Form1
    Public jabatan As String
    Public gaji, total, bersih, tunjangan, potongan As Integer
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        namaPegawai.ResetText()
        jkLaki_laki.Select()
        jabatanPegawai.ResetText()
        gajiPokokPegawai.ResetText()
        tunjanganPegawai.ResetText()
        totalGaji.ResetText()
        potonganGaji.ResetText()
        gajiBersih.ResetText()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
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
            jkLaki_laki.Focus()
        End If
    End Sub

    Private Sub jk_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jkLaki_laki.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            jabatanPegawai.Focus()
        End If
    End Sub

    Private Sub jabatan_TextChanged(sender As Object, e As KeyPressEventArgs) Handles jabatanPegawai.KeyPress
        If (e.KeyChar = Convert.ToChar(13)) Then
            jabatan = jabatanPegawai.Text

            gaji = IIf(jabatan = "Manager", 5000000,
                       IIf(jabatan = "Supervisor", 2500000,
                       IIf(jabatan = "Operasional", 1000000, 0)))
            gajiPokokPegawai.Text = gaji
            tunjanganPegawai.Focus()
        End If
    End Sub

    Private Sub tunjangan_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tunjanganPegawai.KeyPress
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
            tunjangan = tunjanganPegawai.Text
            total = tunjangan + gaji
            totalGaji.Text = total
            potonganGaji.Focus()
        End If
    End Sub

    Private Sub potongan_TextChanged(sender As Object, e As KeyPressEventArgs) Handles potonganGaji.KeyPress
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
            potongan = potonganGaji.Text
            bersih = total - potongan
            gajiBersih.Text = bersih
        End If
    End Sub
End Class
