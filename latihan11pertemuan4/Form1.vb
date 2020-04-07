Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim i As Integer = 1
        cbbox.Items.Clear()
        Do Until i > 10
            cbbox.Items.Add(i)
            i += 1
        Loop
    End Sub
End Class
