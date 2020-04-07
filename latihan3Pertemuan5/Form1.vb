Public Class Form1
    'NAMA : EKAJAYANAGARA
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'menampilkan GRI/Garis tabel untuk listview
        listMhs.GridLines = True
        listMhs.View = View.Details
        'menambahkan header untuk kolom listView
        listMhs.Columns.Add("Nim", 115)
        listMhs.Columns.Add("Nama", 150)
        listMhs.Columns.Add("Alamat", 200)
        txtNim.Text = 1
        txtNim.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(3) As String

        arr(1) = txtNim.Text
        arr(2) = txtNama.Text
        arr(3) = txtAlamat.Text

        'membuat listview item
        Dim list_item As ListViewItem
        list_item = New ListViewItem
        list_item = listMhs.Items.Add(arr(1))
        list_item.SubItems.Add(arr(2))
        list_item.SubItems.Add(arr(3))
        txtNim.Text = txtNim.Text + 1
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtNim.Focus()
    End Sub
End Class
