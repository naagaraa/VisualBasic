Public Class Form1
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Application.Exit()
    End Sub

    Private Sub GantiTeks(ByVal teksBaru As String)
        textaja.Text = teksBaru
    End Sub
    'nama Eka Jaya Nagara
    Private Sub btnpilih_Click(sender As Object, e As EventArgs) Handles btnpilih.Click
        GantiTeks("unsada")
    End Sub
End Class
