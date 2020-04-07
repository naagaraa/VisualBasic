Public Class Form1
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim i As Integer = 0
        Do While i <= 10
            ListBox1.Items.Add("Perulangan  dengan Do while ke " & i)
            i += 1
        Loop

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("yakin mau keluar?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
