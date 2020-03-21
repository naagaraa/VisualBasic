Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namaDepan.Focus()
    End Sub
    Public Structure keterangan
        Dim namaDepan, namaBelakang As String
    End Structure
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim data As keterangan
        'nama Eka Jaya Nagara
        If Not IsNumeric(namaDepan.Text) And Not IsNumeric(namaBelakang.Text) Then
            data.namaDepan = namaDepan.Text
            data.namaBelakang = namaBelakang.Text
            If namaDepan.Text = "" And namaBelakang.Text = "" Then
                MessageBox.Show("data belum di isi")
            ElseIf namaDepan.Text = "" Or namaBelakang.Text = "" Then
                MessageBox.Show("data belum lengkap")
            Else
                MessageBox.Show("nama anda adalah : " + data.namaDepan + " " + data.namaBelakang)
                namaDepan.Text = ""
                namaBelakang.Text = ""
            End If
        Else
            MsgBox("yang kamu masukan bukan huruf", vbInformation, "konfirmasi")
            namaDepan.Text = ""
            namaBelakang.Text = ""
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim pesan As String = MsgBox("yaki mau keluar", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
        End If
    End Sub
End Class
