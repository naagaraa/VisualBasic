Public Class Form1

    Public Structure penerbangan
        Dim maskapai, tujuan As String
    End Structure
    Private Sub maskapai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maskapai.SelectedIndexChanged
        Dim data As penerbangan
        data.maskapai = maskapai.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maskapai.Focus()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        maskapai.Text = ""
        tujuan.Text = ""
        harga.Text = ""
    End Sub

    Private Sub tujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tujuan.SelectedIndexChanged
        Dim data As penerbangan
        data.maskapai = maskapai.Text
        data.tujuan = tujuan.Text
        If Data.maskapai = "Garuda" Then
            'code
            If data.tujuan = "Medan-Padang" Then
                'code
                harga.Text = 50000
            ElseIf data.tujuan = "Medan-Jakarta" Then
                'code
                harga.Text = 10000000
            ElseIf data.tujuan = "Medan-Bali" Then
                'code
                harga.Text = 1500000
            End If
        ElseIf Data.maskapai = "Lion" Then
            'code
            If data.tujuan = "Medan-Padang" Then
                'code
                harga.Text = 300000
            ElseIf data.tujuan = "Medan-Jakarta" Then
                'code
                harga.Text = 600000
            ElseIf data.tujuan = "Medan-Bali" Then
                'code
                harga.Text = 800000
            End If
        ElseIf Data.maskapai = "Sriwijaya" Then
            'code
            If data.tujuan = "Medan-Padang" Then
                'code
                harga.Text = 400000
            ElseIf data.tujuan = "Medan-Jakarta" Then
                'code
                harga.Text = 800000
            ElseIf data.tujuan = "Medan-Bali" Then
                'code
                harga.Text = 1000000
            End If
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Dim pesan As String = MsgBox("yakin keluar?", vbYes, "konfirmasi")
        If pesan = vbYesNo Then
            Close()
            End
        End If
    End Sub
End Class
