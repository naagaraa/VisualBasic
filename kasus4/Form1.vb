Public Class Form1
    Public jari, luas, keliling As Single

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("yakin mau keluar?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub
    'nama Eka Jaya Nagara
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        jariJari.Text = ""
        kelilingLingkaran.Text = ""
        luasLingkaran.Text = ""
    End Sub

    Private Sub jariJari_keydown(sender As Object, e As KeyPressEventArgs) Handles jariJari.KeyPress

        If Not ((e.KeyChar >= "0" And (e.KeyChar <= "9") Or e.KeyChar = vbBack)) Then
            e.Handled = True
        End If

        If (e.KeyChar = Chr(13)) Then
            jari = jariJari.Text
            'hitung
            Const phi = 3.14
            luas = phi * jari * jari
            keliling = 2 * phi * jari
            luasLingkaran.Text = luas
            kelilingLingkaran.Text = keliling
        End If
    End Sub
End Class
