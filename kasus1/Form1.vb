Public Class Form1
    Public Structure Karyawan
        Dim nama, jabatan, alamat As String
        Dim nik As String
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataKaryawan As Karyawan
        dataKaryawan.nama = namaKaryawan.Text
        dataKaryawan.jabatan = jabatan.Text
        dataKaryawan.nik = nik.Text
        dataKaryawan.alamat = alamat.Text

        fieldNama.Text = dataKaryawan.nama
        fieldNIK.Text = dataKaryawan.nik
        fieldAlamat.Text = dataKaryawan.alamat
        fieldJabatan.Text = dataKaryawan.alamat

        'nama Eka Jaya Nagara
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        namaKaryawan.Text = ""
        nik.Text = ""
        alamat.Text = ""
        jabatan.Text = ""

        fieldNama.Text = ""
        fieldNIK.Text = ""
        fieldAlamat.Text = ""
        fieldJabatan.Text = ""

        nik.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Mau Keluar ?", MsgBoxStyle.YesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub

    Private Sub nik_Keypress(sender As Object, e As KeyPressEventArgs) Handles nik.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            namaKaryawan.Focus()
        End If
    End Sub

    Private Sub namaKaryawan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaKaryawan.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            jabatan.Focus()
        End If
    End Sub

    Private Sub jabatan_Keypress(sender As Object, e As KeyPressEventArgs) Handles jabatan.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            alamat.Focus()
        End If
    End Sub

End Class
