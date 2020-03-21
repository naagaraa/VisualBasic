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
        Me.kodeObat = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.satuanObat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namaObat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hargaObat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jumlahObat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.subTotalObat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.diskonaObat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uangTagihan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.uangBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.uangKembali = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Obat"
        '
        'kodeObat
        '
        Me.kodeObat.Location = New System.Drawing.Point(114, 20)
        Me.kodeObat.Name = "kodeObat"
        Me.kodeObat.Size = New System.Drawing.Size(119, 20)
        Me.kodeObat.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(36, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'satuanObat
        '
        Me.satuanObat.FormattingEnabled = True
        Me.satuanObat.Items.AddRange(New Object() {"Dus", "Box", "Botol", "Kaplet"})
        Me.satuanObat.Location = New System.Drawing.Point(114, 71)
        Me.satuanObat.Name = "satuanObat"
        Me.satuanObat.Size = New System.Drawing.Size(119, 21)
        Me.satuanObat.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Obat"
        '
        'namaObat
        '
        Me.namaObat.Location = New System.Drawing.Point(114, 46)
        Me.namaObat.Name = "namaObat"
        Me.namaObat.Size = New System.Drawing.Size(119, 20)
        Me.namaObat.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Harga Satuan"
        '
        'hargaObat
        '
        Me.hargaObat.Location = New System.Drawing.Point(114, 98)
        Me.hargaObat.Name = "hargaObat"
        Me.hargaObat.Size = New System.Drawing.Size(119, 20)
        Me.hargaObat.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jumlah Beli"
        '
        'jumlahObat
        '
        Me.jumlahObat.Location = New System.Drawing.Point(114, 124)
        Me.jumlahObat.Name = "jumlahObat"
        Me.jumlahObat.Size = New System.Drawing.Size(119, 20)
        Me.jumlahObat.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sub Total"
        '
        'subTotalObat
        '
        Me.subTotalObat.Location = New System.Drawing.Point(114, 26)
        Me.subTotalObat.Name = "subTotalObat"
        Me.subTotalObat.Size = New System.Drawing.Size(119, 20)
        Me.subTotalObat.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Diskon"
        '
        'diskonaObat
        '
        Me.diskonaObat.Location = New System.Drawing.Point(114, 52)
        Me.diskonaObat.Name = "diskonaObat"
        Me.diskonaObat.Size = New System.Drawing.Size(119, 20)
        Me.diskonaObat.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Tagihan"
        '
        'uangTagihan
        '
        Me.uangTagihan.Location = New System.Drawing.Point(114, 78)
        Me.uangTagihan.Name = "uangTagihan"
        Me.uangTagihan.Size = New System.Drawing.Size(119, 20)
        Me.uangTagihan.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Uang Bayar"
        '
        'uangBayar
        '
        Me.uangBayar.Location = New System.Drawing.Point(114, 104)
        Me.uangBayar.Name = "uangBayar"
        Me.uangBayar.Size = New System.Drawing.Size(119, 20)
        Me.uangBayar.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Uang Kembali"
        '
        'uangKembali
        '
        Me.uangKembali.Location = New System.Drawing.Point(114, 130)
        Me.uangKembali.Name = "uangKembali"
        Me.uangKembali.Size = New System.Drawing.Size(119, 20)
        Me.uangKembali.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(135, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.jumlahObat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.satuanObat)
        Me.GroupBox1.Controls.Add(Me.kodeObat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.namaObat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.hargaObat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 150)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Obat"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(211, 375)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.uangKembali)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.subTotalObat)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.diskonaObat)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.uangBayar)
        Me.GroupBox2.Controls.Add(Me.uangTagihan)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 162)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 450)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents kodeObat As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents satuanObat As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents namaObat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents hargaObat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jumlahObat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents subTotalObat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents diskonaObat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents uangTagihan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents uangBayar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents uangKembali As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
