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
        Me.namaPembeli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.merekBaju = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ukuranBaju = New System.Windows.Forms.ComboBox()
        Me.hargaBaju = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jumlahBeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.diskon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalTagihan = New System.Windows.Forms.TextBox()
        Me.uangBayar = New System.Windows.Forms.TextBox()
        Me.uangKembalian = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'namaPembeli
        '
        Me.namaPembeli.Location = New System.Drawing.Point(129, 23)
        Me.namaPembeli.Name = "namaPembeli"
        Me.namaPembeli.Size = New System.Drawing.Size(121, 20)
        Me.namaPembeli.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Pembeli"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(95, 415)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'merekBaju
        '
        Me.merekBaju.FormattingEnabled = True
        Me.merekBaju.Items.AddRange(New Object() {"IMP", "Prada", "Gucci", "Loius", "Denim"})
        Me.merekBaju.Location = New System.Drawing.Point(129, 49)
        Me.merekBaju.Name = "merekBaju"
        Me.merekBaju.Size = New System.Drawing.Size(121, 21)
        Me.merekBaju.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Merk Baju"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(204, 415)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ukuran"
        '
        'ukuranBaju
        '
        Me.ukuranBaju.FormattingEnabled = True
        Me.ukuranBaju.Items.AddRange(New Object() {"XL", "L", "M"})
        Me.ukuranBaju.Location = New System.Drawing.Point(129, 76)
        Me.ukuranBaju.Name = "ukuranBaju"
        Me.ukuranBaju.Size = New System.Drawing.Size(121, 21)
        Me.ukuranBaju.TabIndex = 3
        '
        'hargaBaju
        '
        Me.hargaBaju.Location = New System.Drawing.Point(129, 103)
        Me.hargaBaju.Name = "hargaBaju"
        Me.hargaBaju.Size = New System.Drawing.Size(121, 20)
        Me.hargaBaju.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Harga"
        '
        'jumlahBeli
        '
        Me.jumlahBeli.Location = New System.Drawing.Point(129, 129)
        Me.jumlahBeli.Name = "jumlahBeli"
        Me.jumlahBeli.Size = New System.Drawing.Size(121, 20)
        Me.jumlahBeli.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Jumlah Beli"
        '
        'subTotal
        '
        Me.subTotal.Location = New System.Drawing.Point(129, 35)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(121, 20)
        Me.subTotal.TabIndex = 0
        '
        'diskon
        '
        Me.diskon.Location = New System.Drawing.Point(129, 61)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(121, 20)
        Me.diskon.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sub Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Diskon"
        '
        'totalTagihan
        '
        Me.totalTagihan.Location = New System.Drawing.Point(129, 87)
        Me.totalTagihan.Name = "totalTagihan"
        Me.totalTagihan.Size = New System.Drawing.Size(121, 20)
        Me.totalTagihan.TabIndex = 0
        '
        'uangBayar
        '
        Me.uangBayar.Location = New System.Drawing.Point(129, 113)
        Me.uangBayar.Name = "uangBayar"
        Me.uangBayar.Size = New System.Drawing.Size(121, 20)
        Me.uangBayar.TabIndex = 0
        '
        'uangKembalian
        '
        Me.uangKembalian.Location = New System.Drawing.Point(129, 139)
        Me.uangKembalian.Name = "uangKembalian"
        Me.uangKembalian.Size = New System.Drawing.Size(121, 20)
        Me.uangKembalian.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Uang Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Tagihan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Uang Kembalian"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(92, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "TOKO BAJU ""AYODYA FASHON"""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.jumlahBeli)
        Me.GroupBox1.Controls.Add(Me.namaPembeli)
        Me.GroupBox1.Controls.Add(Me.ukuranBaju)
        Me.GroupBox1.Controls.Add(Me.hargaBaju)
        Me.GroupBox1.Controls.Add(Me.merekBaju)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 164)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Baju"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.uangKembalian)
        Me.GroupBox2.Controls.Add(Me.subTotal)
        Me.GroupBox2.Controls.Add(Me.totalTagihan)
        Me.GroupBox2.Controls.Add(Me.diskon)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.uangBayar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 178)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namaPembeli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents merekBaju As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ukuranBaju As ComboBox
    Friend WithEvents hargaBaju As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents jumlahBeli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents subTotal As TextBox
    Friend WithEvents diskon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents totalTagihan As TextBox
    Friend WithEvents uangBayar As TextBox
    Friend WithEvents uangKembalian As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
