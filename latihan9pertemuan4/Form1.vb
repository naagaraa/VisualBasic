Public Class Form1
    Private Sub cbbilanganIndexChanged(sender As Object, e As EventArgs) Handles cbbilangam.SelectedIndexChanged
        Dim halaman As Byte
        halaman = 1
        Do While halaman <= 10
            cbpangkat.Items.Add(halaman)
            halaman += 1
        Loop
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub cbpangkatIndexChanged(sender As Object, e As EventArgs) Handles cbpangkat.SelectedIndexChanged
        Dim xhasil As Double = CDbl(cbbilangam.Text)
        For i = 1 To CInt(cbpangkat.Text)
            xhasil = xhasil * CInt(cbbilangam.Text)
            'Console.WriteLine(xhasil)
            Console.WriteLine(xhasil * CInt(cbbilangam.Text))
        Next

        hasil.Text = xhasil
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim halaman As Byte
        halaman = 1
        Do While halaman <= 10
            cbbilangam.Items.Add(halaman)
            halaman += 1
        Loop
    End Sub
End Class
