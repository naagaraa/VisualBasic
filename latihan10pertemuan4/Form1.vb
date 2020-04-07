Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAngka.ResetText()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim x%
        x = txtAngka.Text
        Do
            x = x Mod 2
            If x = 0 Then
                MsgBox("Bilangan Genap")
                Exit Do
            Else
                MsgBox("Bilangan Ganjil")
                Exit Do
            End If
        Loop While Not x
    End Sub
End Class
