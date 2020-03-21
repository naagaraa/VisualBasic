Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim bil As Integer = txtNilai.Text
        Select Case bil
            Case 80 To 100
                txtGrade.Text = "A"
            Case 65 To 79
                txtGrade.Text = "B"
            Case 47 To 64
                txtGrade.Text = "C"
            Case 26 To 46
                txtGrade.Text = "D"
            Case Else
                txtGrade.Text = "E"
        End Select
    End Sub
End Class
