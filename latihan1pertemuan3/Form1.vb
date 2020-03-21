Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan As String = MsgBox("apakah anda yakin keluar?", vbYesNo, "konfirmasi")
        If pesan = vbYes Then
            Close()
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ket As String
        If CInt(nilaiAkhir.Text) >= 60 Then
            ket = "LULUS"
        Else
            ket = "TIDAK LULUS"
        End If
        keterangan.Text = ket
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nilaiAkhir.Focus()
    End Sub
End Class
