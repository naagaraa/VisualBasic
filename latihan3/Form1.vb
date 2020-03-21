Public Class Form1

    Public data As String
    Public bilangan As Integer
    Public hasil As String
    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click

        If IsNumeric(dataAwal.Text) Then
            data = dataAwal.Text
            bilangan = CInt(data)

            hasil = CInt(bilangan * 40)
            dataKonversi.Text = hasil
            Console.WriteLine(bilangan)
        Else
            MsgBox("ini bukan angka!", vbInformation, "informasi")
            dataAwal.Text = ""
        End If
    End Sub

End Class
