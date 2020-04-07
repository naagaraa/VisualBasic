<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.namaPelanggan = New System.Windows.Forms.TextBox()
        Me.namaBarang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listView = New System.Windows.Forms.ListView()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'namaPelanggan
        '
        Me.namaPelanggan.Location = New System.Drawing.Point(144, 56)
        Me.namaPelanggan.Name = "namaPelanggan"
        Me.namaPelanggan.Size = New System.Drawing.Size(121, 20)
        Me.namaPelanggan.TabIndex = 0
        '
        'namaBarang
        '
        Me.namaBarang.FormattingEnabled = True
        Me.namaBarang.Items.AddRange(New Object() {"Nasi Goreng", "Ayam Goreng", "Nasi Rames", "Gado Gado"})
        Me.namaBarang.Location = New System.Drawing.Point(144, 94)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(121, 21)
        Me.namaBarang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang "
        '
        'listView
        '
        Me.listView.HideSelection = False
        Me.listView.Location = New System.Drawing.Point(52, 143)
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(594, 168)
        Me.listView.TabIndex = 3
        Me.listView.UseCompatibleStateImageBehavior = False
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(296, 56)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(95, 32)
        Me.btnProses.TabIndex = 4
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(296, 97)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 32)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mesin Pesanan Rumah Makan Padang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(470, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Eka Jaya Nagara"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.listView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.namaBarang)
        Me.Controls.Add(Me.namaPelanggan)
        Me.Name = "Form1"
        Me.Text = "t"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namaPelanggan As TextBox
    Friend WithEvents namaBarang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listView As ListView
    Friend WithEvents btnProses As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
