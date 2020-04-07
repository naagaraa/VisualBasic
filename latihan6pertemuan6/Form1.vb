Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isian.Text = tampilkanPesan()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        isian.Text = tampilkanpesan("selamat datang")
    End Sub

    Public Function tampilkanpesan(Optional ByVal pesan As String = "") As String
        If pesan = "" Then
            Return "tidak ada pesan"
        Else

            Return "isi pesan adalah" & pesan
        End If
    End Function
End Class
