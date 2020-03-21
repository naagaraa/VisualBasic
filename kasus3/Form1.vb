Public Class Form1

    Public Structure mahasiswa
        Dim nama, jenisKelamin, jurusan, alamat, nim As String
    End Structure

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim data As mahasiswa
        data.nim = nim.Text
        data.nama = namaMhs.Text
        data.jenisKelamin = jenisKelamin.Text
        data.jurusan = jurusan.Text
        data.alamat = alamat.Text

        fieldNim.Text = data.nim
        fieldNama.Text = data.nama
        fieldJenisKelamin.Text = data.jenisKelamin
        fieldJurusan.Text = data.jurusan
        fieldAlamat.Text = data.alamat

    End Sub

    'nama Eka Jaya Nagara
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        nim.Text = ""
        namaMhs.Text = ""
        jenisKelamin.Text = ""
        jurusan.Text = ""
        alamat.Text = ""


        fieldNim.Text = ""
        fieldNama.Text = ""
        fieldJenisKelamin.Text = ""
        fieldJurusan.Text = ""
        fieldAlamat.Text = ""

        nim.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim pesan As String

        pesan = MsgBox("Yakin anda mau keluar ?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub nim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nim.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            namaMhs.Focus()
        End If
    End Sub

    Private Sub namaMhs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles namaMhs.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            jenisKelamin.Focus()
        End If
    End Sub

    Private Sub jenisKelamin_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles jenisKelamin.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            jurusan.Focus()
        End If
    End Sub

    Private Sub jurusan_SelectedIndexChanged(sender As Object, e As KeyPressEventArgs) Handles jurusan.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            alamat.Focus()
        End If
    End Sub


End Class
