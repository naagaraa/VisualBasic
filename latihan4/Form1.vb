Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alasSegitiga.Focus()
    End Sub
    Public Structure angka
        Dim alas, tinggi As String
        Dim luas As Single
    End Structure
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim data As angka
        If IsNumeric(alasSegitiga.Text) And IsNumeric(tinggi.Text) Then
            data.alas = CSng(alasSegitiga.Text)
            data.tinggi = CSng(tinggi.Text)

            data.luas = data.alas * data.tinggi

            hasil.Text = data.luas

            'nama Eka Jaya Nagara

        Else
            MsgBox("yang kamu masukan bukan angka", vbInformation, "warning")
            alasSegitiga.Text = ""
            tinggi.Text = ""
            hasil.Text = ""
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim pesan As String = MsgBox("yakin kamu mau keluar?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub
End Class
