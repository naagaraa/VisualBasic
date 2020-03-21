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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kodeBuku = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namaBuku = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hargaBuku = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jmlBeli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uangBayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uangKembali = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.kategoriBuku = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'kodeBuku
        '
        Me.kodeBuku.Location = New System.Drawing.Point(120, 27)
        Me.kodeBuku.Name = "kodeBuku"
        Me.kodeBuku.Size = New System.Drawing.Size(121, 20)
        Me.kodeBuku.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(34, 20)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Buku"
        '
        'namaBuku
        '
        Me.namaBuku.Location = New System.Drawing.Point(120, 53)
        Me.namaBuku.Name = "namaBuku"
        Me.namaBuku.Size = New System.Drawing.Size(121, 20)
        Me.namaBuku.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kategori Buku"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Harga Buku"
        '
        'hargaBuku
        '
        Me.hargaBuku.Enabled = False
        Me.hargaBuku.Location = New System.Drawing.Point(120, 105)
        Me.hargaBuku.Name = "hargaBuku"
        Me.hargaBuku.Size = New System.Drawing.Size(121, 20)
        Me.hargaBuku.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jumlah Beli"
        '
        'jmlBeli
        '
        Me.jmlBeli.Location = New System.Drawing.Point(120, 131)
        Me.jmlBeli.Name = "jmlBeli"
        Me.jmlBeli.Size = New System.Drawing.Size(121, 20)
        Me.jmlBeli.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sub Total"
        '
        'subTotal
        '
        Me.subTotal.Enabled = False
        Me.subTotal.Location = New System.Drawing.Point(120, 157)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(121, 20)
        Me.subTotal.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Uang Bayar"
        '
        'uangBayar
        '
        Me.uangBayar.Location = New System.Drawing.Point(120, 183)
        Me.uangBayar.Name = "uangBayar"
        Me.uangBayar.Size = New System.Drawing.Size(121, 20)
        Me.uangBayar.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Uang Kembali"
        '
        'uangKembali
        '
        Me.uangKembali.Enabled = False
        Me.uangKembali.Location = New System.Drawing.Point(120, 209)
        Me.uangKembali.Name = "uangKembali"
        Me.uangKembali.Size = New System.Drawing.Size(121, 20)
        Me.uangKembali.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(147, 20)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'kategoriBuku
        '
        Me.kategoriBuku.FormattingEnabled = True
        Me.kategoriBuku.Items.AddRange(New Object() {"Komik", "Koran", "Majalah"})
        Me.kategoriBuku.Location = New System.Drawing.Point(120, 78)
        Me.kategoriBuku.Name = "kategoriBuku"
        Me.kategoriBuku.Size = New System.Drawing.Size(121, 21)
        Me.kategoriBuku.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.kategoriBuku)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.kodeBuku)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.uangKembali)
        Me.GroupBox1.Controls.Add(Me.namaBuku)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.uangBayar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.hargaBuku)
        Me.GroupBox1.Controls.Add(Me.subTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.jmlBeli)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 246)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Transaksi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKeluar)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Location = New System.Drawing.Point(84, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 51)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents kodeBuku As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents namaBuku As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents hargaBuku As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jmlBeli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents subTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents uangBayar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents uangKembali As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents kategoriBuku As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
