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
        Me.nimMhs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kelasMhs = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.namaMhs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.biayaSks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jumlahSks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalTagihan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.uangBayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uangKembali = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.jurusanMhs = New System.Windows.Forms.ComboBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nimMhs
        '
        Me.nimMhs.Location = New System.Drawing.Point(172, 22)
        Me.nimMhs.Name = "nimMhs"
        Me.nimMhs.Size = New System.Drawing.Size(121, 20)
        Me.nimMhs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nomo Induk Mahasiswa"
        '
        'kelasMhs
        '
        Me.kelasMhs.FormattingEnabled = True
        Me.kelasMhs.Items.AddRange(New Object() {"Reguler", "Karyawan"})
        Me.kelasMhs.Location = New System.Drawing.Point(172, 74)
        Me.kelasMhs.Name = "kelasMhs"
        Me.kelasMhs.Size = New System.Drawing.Size(121, 21)
        Me.kelasMhs.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(107, 361)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'namaMhs
        '
        Me.namaMhs.Location = New System.Drawing.Point(172, 48)
        Me.namaMhs.Name = "namaMhs"
        Me.namaMhs.Size = New System.Drawing.Size(121, 20)
        Me.namaMhs.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pilihan Kelas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jurusan Mahasiswa"
        '
        'biayaSks
        '
        Me.biayaSks.Location = New System.Drawing.Point(172, 127)
        Me.biayaSks.Name = "biayaSks"
        Me.biayaSks.Size = New System.Drawing.Size(121, 20)
        Me.biayaSks.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Biasya/sks"
        '
        'jumlahSks
        '
        Me.jumlahSks.Location = New System.Drawing.Point(172, 153)
        Me.jumlahSks.Name = "jumlahSks"
        Me.jumlahSks.Size = New System.Drawing.Size(121, 20)
        Me.jumlahSks.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Jumlah Sks"
        '
        'totalTagihan
        '
        Me.totalTagihan.Location = New System.Drawing.Point(169, 20)
        Me.totalTagihan.Name = "totalTagihan"
        Me.totalTagihan.Size = New System.Drawing.Size(121, 20)
        Me.totalTagihan.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total Tagihan"
        '
        'uangBayar
        '
        Me.uangBayar.Location = New System.Drawing.Point(169, 46)
        Me.uangBayar.Name = "uangBayar"
        Me.uangBayar.Size = New System.Drawing.Size(121, 20)
        Me.uangBayar.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Uang Bayar"
        '
        'uangKembali
        '
        Me.uangKembali.Location = New System.Drawing.Point(169, 72)
        Me.uangKembali.Name = "uangKembali"
        Me.uangKembali.Size = New System.Drawing.Size(121, 20)
        Me.uangKembali.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Uang Kembali"
        '
        'jurusanMhs
        '
        Me.jurusanMhs.FormattingEnabled = True
        Me.jurusanMhs.Items.AddRange(New Object() {"Akuntansi", "Manajemen", "Teknik Informatika", "Sistem Informasi", ""})
        Me.jurusanMhs.Location = New System.Drawing.Point(172, 101)
        Me.jurusanMhs.Name = "jurusanMhs"
        Me.jurusanMhs.Size = New System.Drawing.Size(121, 21)
        Me.jurusanMhs.TabIndex = 2
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(295, 361)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(132, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "KARTU RENCANA STUDI MAHASISWA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.jumlahSks)
        Me.GroupBox1.Controls.Add(Me.nimMhs)
        Me.GroupBox1.Controls.Add(Me.namaMhs)
        Me.GroupBox1.Controls.Add(Me.jurusanMhs)
        Me.GroupBox1.Controls.Add(Me.biayaSks)
        Me.GroupBox1.Controls.Add(Me.kelasMhs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 191)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.uangKembali)
        Me.GroupBox2.Controls.Add(Me.totalTagihan)
        Me.GroupBox2.Controls.Add(Me.uangBayar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(80, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nimMhs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents kelasMhs As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents namaMhs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents biayaSks As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jumlahSks As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents totalTagihan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents uangBayar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents uangKembali As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents jurusanMhs As ComboBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
