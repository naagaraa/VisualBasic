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
        Me.kodeBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hargaSatuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jmlBeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.satuanBarang = New System.Windows.Forms.ComboBox()
        Me.totalHarga = New System.Windows.Forms.TextBox()
        Me.uangBayar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uangKembalian = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'kodeBarang
        '
        Me.kodeBarang.Location = New System.Drawing.Point(122, 31)
        Me.kodeBarang.Name = "kodeBarang"
        Me.kodeBarang.Size = New System.Drawing.Size(121, 20)
        Me.kodeBarang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode barang"
        '
        'namaBarang
        '
        Me.namaBarang.Location = New System.Drawing.Point(122, 57)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(121, 20)
        Me.namaBarang.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Satuan"
        '
        'hargaSatuan
        '
        Me.hargaSatuan.Enabled = False
        Me.hargaSatuan.Location = New System.Drawing.Point(122, 109)
        Me.hargaSatuan.Name = "hargaSatuan"
        Me.hargaSatuan.Size = New System.Drawing.Size(121, 20)
        Me.hargaSatuan.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Harga satuan"
        '
        'jmlBeli
        '
        Me.jmlBeli.Location = New System.Drawing.Point(122, 135)
        Me.jmlBeli.Name = "jmlBeli"
        Me.jmlBeli.Size = New System.Drawing.Size(121, 20)
        Me.jmlBeli.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Jumlah Beli"
        '
        'satuanBarang
        '
        Me.satuanBarang.FormattingEnabled = True
        Me.satuanBarang.Items.AddRange(New Object() {"Lusin", "Kodi"})
        Me.satuanBarang.Location = New System.Drawing.Point(122, 82)
        Me.satuanBarang.Name = "satuanBarang"
        Me.satuanBarang.Size = New System.Drawing.Size(121, 21)
        Me.satuanBarang.TabIndex = 2
        '
        'totalHarga
        '
        Me.totalHarga.Enabled = False
        Me.totalHarga.Location = New System.Drawing.Point(107, 23)
        Me.totalHarga.Name = "totalHarga"
        Me.totalHarga.Size = New System.Drawing.Size(121, 20)
        Me.totalHarga.TabIndex = 0
        '
        'uangBayar
        '
        Me.uangBayar.Location = New System.Drawing.Point(107, 49)
        Me.uangBayar.Name = "uangBayar"
        Me.uangBayar.Size = New System.Drawing.Size(121, 20)
        Me.uangBayar.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Uang Bayar"
        '
        'uangKembalian
        '
        Me.uangKembalian.Enabled = False
        Me.uangKembalian.Location = New System.Drawing.Point(107, 74)
        Me.uangKembalian.Name = "uangKembalian"
        Me.uangKembalian.Size = New System.Drawing.Size(121, 20)
        Me.uangKembalian.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Uang Kembalian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(314, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Toko Serba Ada ""Terlengkap"""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.kodeBarang)
        Me.GroupBox1.Controls.Add(Me.namaBarang)
        Me.GroupBox1.Controls.Add(Me.satuanBarang)
        Me.GroupBox1.Controls.Add(Me.hargaSatuan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.jmlBeli)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 161)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.uangKembalian)
        Me.GroupBox2.Controls.Add(Me.totalHarga)
        Me.GroupBox2.Controls.Add(Me.uangBayar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 111)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents kodeBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents namaBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hargaSatuan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents jmlBeli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents satuanBarang As ComboBox
    Friend WithEvents totalHarga As TextBox
    Friend WithEvents uangBayar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents uangKembalian As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
