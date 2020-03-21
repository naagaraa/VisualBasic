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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kelasMhs = New System.Windows.Forms.ComboBox()
        Me.namaMhs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.biayaSksMhs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jumlahSksMhs = New System.Windows.Forms.TextBox()
        Me.totalTaguhanMhs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.uangBayarMhs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.uangKembaliMhs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.jurusanMhs = New System.Windows.Forms.ComboBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nimMhs
        '
        Me.nimMhs.Location = New System.Drawing.Point(161, 27)
        Me.nimMhs.Name = "nimMhs"
        Me.nimMhs.Size = New System.Drawing.Size(100, 20)
        Me.nimMhs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nomor Infuk Mahasiswa"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(42, 324)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Bersih"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KARTU RENCANA STUDI"
        '
        'kelasMhs
        '
        Me.kelasMhs.FormattingEnabled = True
        Me.kelasMhs.Items.AddRange(New Object() {"Reguler", "Karyawan"})
        Me.kelasMhs.Location = New System.Drawing.Point(161, 80)
        Me.kelasMhs.Name = "kelasMhs"
        Me.kelasMhs.Size = New System.Drawing.Size(100, 21)
        Me.kelasMhs.TabIndex = 3
        '
        'namaMhs
        '
        Me.namaMhs.Location = New System.Drawing.Point(161, 53)
        Me.namaMhs.Name = "namaMhs"
        Me.namaMhs.Size = New System.Drawing.Size(100, 20)
        Me.namaMhs.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Mahasiswa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pilihan Kelas"
        '
        'biayaSksMhs
        '
        Me.biayaSksMhs.Location = New System.Drawing.Point(161, 133)
        Me.biayaSksMhs.Name = "biayaSksMhs"
        Me.biayaSksMhs.Size = New System.Drawing.Size(100, 20)
        Me.biayaSksMhs.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Jurusan Mahasiswa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Biaya / Sks"
        '
        'jumlahSksMhs
        '
        Me.jumlahSksMhs.Location = New System.Drawing.Point(161, 159)
        Me.jumlahSksMhs.Name = "jumlahSksMhs"
        Me.jumlahSksMhs.Size = New System.Drawing.Size(100, 20)
        Me.jumlahSksMhs.TabIndex = 0
        '
        'totalTaguhanMhs
        '
        Me.totalTaguhanMhs.Location = New System.Drawing.Point(161, 185)
        Me.totalTaguhanMhs.Name = "totalTaguhanMhs"
        Me.totalTaguhanMhs.Size = New System.Drawing.Size(100, 20)
        Me.totalTaguhanMhs.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Jumlah / Sks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Tootal Tagihan"
        '
        'uangBayarMhs
        '
        Me.uangBayarMhs.Location = New System.Drawing.Point(161, 211)
        Me.uangBayarMhs.Name = "uangBayarMhs"
        Me.uangBayarMhs.Size = New System.Drawing.Size(100, 20)
        Me.uangBayarMhs.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Uang Bayar"
        '
        'uangKembaliMhs
        '
        Me.uangKembaliMhs.Location = New System.Drawing.Point(161, 238)
        Me.uangKembaliMhs.Name = "uangKembaliMhs"
        Me.uangKembaliMhs.Size = New System.Drawing.Size(100, 20)
        Me.uangKembaliMhs.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Uang Kembali"
        '
        'jurusanMhs
        '
        Me.jurusanMhs.FormattingEnabled = True
        Me.jurusanMhs.Items.AddRange(New Object() {"Akuntansi", "Manajement", "Teknik Informatika", "Sistem Informasi"})
        Me.jurusanMhs.Location = New System.Drawing.Point(161, 106)
        Me.jurusanMhs.Name = "jurusanMhs"
        Me.jurusanMhs.Size = New System.Drawing.Size(100, 21)
        Me.jurusanMhs.TabIndex = 3
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(197, 324)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.uangKembaliMhs)
        Me.GroupBox1.Controls.Add(Me.jurusanMhs)
        Me.GroupBox1.Controls.Add(Me.nimMhs)
        Me.GroupBox1.Controls.Add(Me.kelasMhs)
        Me.GroupBox1.Controls.Add(Me.namaMhs)
        Me.GroupBox1.Controls.Add(Me.biayaSksMhs)
        Me.GroupBox1.Controls.Add(Me.jumlahSksMhs)
        Me.GroupBox1.Controls.Add(Me.totalTaguhanMhs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.uangBayarMhs)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 273)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nimMhs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents kelasMhs As ComboBox
    Friend WithEvents namaMhs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents biayaSksMhs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents jumlahSksMhs As TextBox
    Friend WithEvents totalTaguhanMhs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents uangBayarMhs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents uangKembaliMhs As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents jurusanMhs As ComboBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
