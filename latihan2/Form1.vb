Public Class Form1
    Public Structure mobil
        Dim merk, warna, besarSilinder As String
        Dim jumlah As Byte
    End Structure


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataMobil As mobil
        dataMobil.merk = "Toyota Avanza"
        dataMobil.warna = "merah"
        dataMobil.jumlah = 4
        dataMobil.besarSilinder = 2.2

        merkMobil.Text = dataMobil.merk
        warnaMobil.Text = dataMobil.warna
        Jumlah.Text = dataMobil.jumlah
        besarSilinder.Text = dataMobil.besarSilinder
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        merkMobil.Text = ""
        warnaMobil.Text = ""
        Jumlah.Text = ""
        besarSilinder.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Mau Keluar ?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub
End Class
