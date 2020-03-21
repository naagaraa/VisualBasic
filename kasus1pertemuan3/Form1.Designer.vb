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
        Me.uangKembali = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namaBuku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hargaBuku = New System.Windows.Forms.TextBox()
        Me.jumlahBuku = New System.Windows.Forms.TextBox()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.diskon = New System.Windows.Forms.TextBox()
        Me.totalTagihan = New System.Windows.Forms.TextBox()
        Me.uangBayar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.group1 = New System.Windows.Forms.GroupBox()
        Me.kategoriBuku = New System.Windows.Forms.ComboBox()
        Me.kodeBuku = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.group1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'uangKembali
        '
        Me.uangKembali.Location = New System.Drawing.Point(133, 262)
        Me.uangKembali.Name = "uangKembali"
        Me.uangKembali.Size = New System.Drawing.Size(121, 20)
        Me.uangKembali.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Buku"
        '
        'namaBuku
        '
        Me.namaBuku.Location = New System.Drawing.Point(133, 48)
        Me.namaBuku.Name = "namaBuku"
        Me.namaBuku.Size = New System.Drawing.Size(121, 20)
        Me.namaBuku.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Kategori  Buku"
        '
        'hargaBuku
        '
        Me.hargaBuku.Location = New System.Drawing.Point(133, 101)
        Me.hargaBuku.Name = "hargaBuku"
        Me.hargaBuku.Size = New System.Drawing.Size(121, 20)
        Me.hargaBuku.TabIndex = 0
        '
        'jumlahBuku
        '
        Me.jumlahBuku.Location = New System.Drawing.Point(133, 127)
        Me.jumlahBuku.Name = "jumlahBuku"
        Me.jumlahBuku.Size = New System.Drawing.Size(121, 20)
        Me.jumlahBuku.TabIndex = 0
        '
        'subTotal
        '
        Me.subTotal.Location = New System.Drawing.Point(133, 153)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(121, 20)
        Me.subTotal.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Harga Buku"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Jumlah Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sub Total"
        '
        'diskon
        '
        Me.diskon.Location = New System.Drawing.Point(133, 181)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(121, 20)
        Me.diskon.TabIndex = 0
        '
        'totalTagihan
        '
        Me.totalTagihan.Location = New System.Drawing.Point(133, 207)
        Me.totalTagihan.Name = "totalTagihan"
        Me.totalTagihan.Size = New System.Drawing.Size(121, 20)
        Me.totalTagihan.TabIndex = 0
        '
        'uangBayar
        '
        Me.uangBayar.Location = New System.Drawing.Point(133, 233)
        Me.uangBayar.Name = "uangBayar"
        Me.uangBayar.Size = New System.Drawing.Size(121, 20)
        Me.uangBayar.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Total Tagihan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Uang Bayar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Uang Kembali"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(45, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(158, 31)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'group1
        '
        Me.group1.Controls.Add(Me.kategoriBuku)
        Me.group1.Controls.Add(Me.kodeBuku)
        Me.group1.Controls.Add(Me.uangKembali)
        Me.group1.Controls.Add(Me.namaBuku)
        Me.group1.Controls.Add(Me.Label10)
        Me.group1.Controls.Add(Me.hargaBuku)
        Me.group1.Controls.Add(Me.Label9)
        Me.group1.Controls.Add(Me.Label6)
        Me.group1.Controls.Add(Me.diskon)
        Me.group1.Controls.Add(Me.Label3)
        Me.group1.Controls.Add(Me.jumlahBuku)
        Me.group1.Controls.Add(Me.Label8)
        Me.group1.Controls.Add(Me.subTotal)
        Me.group1.Controls.Add(Me.Label5)
        Me.group1.Controls.Add(Me.totalTagihan)
        Me.group1.Controls.Add(Me.Label2)
        Me.group1.Controls.Add(Me.uangBayar)
        Me.group1.Controls.Add(Me.Label7)
        Me.group1.Controls.Add(Me.Label1)
        Me.group1.Controls.Add(Me.Label4)
        Me.group1.Location = New System.Drawing.Point(83, 40)
        Me.group1.Name = "group1"
        Me.group1.Size = New System.Drawing.Size(288, 298)
        Me.group1.TabIndex = 3
        Me.group1.TabStop = False
        Me.group1.Text = "Data Transaksi"
        '
        'kategoriBuku
        '
        Me.kategoriBuku.FormattingEnabled = True
        Me.kategoriBuku.Location = New System.Drawing.Point(133, 74)
        Me.kategoriBuku.Name = "kategoriBuku"
        Me.kategoriBuku.Size = New System.Drawing.Size(121, 21)
        Me.kategoriBuku.TabIndex = 2
        '
        'kodeBuku
        '
        Me.kodeBuku.Location = New System.Drawing.Point(133, 22)
        Me.kodeBuku.Name = "kodeBuku"
        Me.kodeBuku.Size = New System.Drawing.Size(121, 20)
        Me.kodeBuku.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnKeluar)
        Me.GroupBox2.Location = New System.Drawing.Point(83, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 60)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "TOKO BUKU GUNUNG AGUNG"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.group1.ResumeLayout(False)
        Me.group1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uangKembali As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents namaBuku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hargaBuku As TextBox
    Friend WithEvents jumlahBuku As TextBox
    Friend WithEvents subTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents diskon As TextBox
    Friend WithEvents totalTagihan As TextBox
    Friend WithEvents uangBayar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents group1 As GroupBox
    Friend WithEvents kategoriBuku As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents kodeBuku As TextBox
End Class
