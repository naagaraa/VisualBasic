Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim nama(0) As String
        nama(0) = textNama.Text

        Dim list As New ListViewItem
        list = listNama.Items.Add(nama(0))

        textNama.Text = ""
        textNama.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listNama.View = View.Details
        listNama.GridLines = True
        listNama.Columns.Add("nama", 115)
    End Sub

    'nama Eka Jaya Nagara
End Class
