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
        Me.nim = New System.Windows.Forms.TextBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.namaMhs = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.jenisKelamin = New System.Windows.Forms.ComboBox()
        Me.jurusan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fieldAlamat = New System.Windows.Forms.TextBox()
        Me.fieldNim = New System.Windows.Forms.TextBox()
        Me.fieldJurusan = New System.Windows.Forms.TextBox()
        Me.fieldJenisKelamin = New System.Windows.Forms.TextBox()
        Me.fieldNama = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.labeljudul = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor induk Mahasiswa"
        '
        'nim
        '
        Me.nim.Location = New System.Drawing.Point(157, 24)
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(121, 20)
        Me.nim.TabIndex = 1
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(77, 258)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 2
        Me.btnProses.Text = "Proces"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jurusan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat Mahasiswa"
        '
        'namaMhs
        '
        Me.namaMhs.Location = New System.Drawing.Point(157, 51)
        Me.namaMhs.Name = "namaMhs"
        Me.namaMhs.Size = New System.Drawing.Size(121, 20)
        Me.namaMhs.TabIndex = 1
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(157, 131)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(121, 20)
        Me.alamat.TabIndex = 1
        '
        'jenisKelamin
        '
        Me.jenisKelamin.FormattingEnabled = True
        Me.jenisKelamin.Items.AddRange(New Object() {"Pria", "Perempuan"})
        Me.jenisKelamin.Location = New System.Drawing.Point(157, 77)
        Me.jenisKelamin.Name = "jenisKelamin"
        Me.jenisKelamin.Size = New System.Drawing.Size(121, 21)
        Me.jenisKelamin.TabIndex = 3
        '
        'jurusan
        '
        Me.jurusan.FormattingEnabled = True
        Me.jurusan.Items.AddRange(New Object() {"Teknik Informatika", "Teknik Industri", "Teknik Mesin", "Teknik Sistem Informasi "})
        Me.jurusan.Location = New System.Drawing.Point(157, 104)
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Size = New System.Drawing.Size(121, 21)
        Me.jurusan.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.jurusan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.jenisKelamin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.namaMhs)
        Me.GroupBox1.Controls.Add(Me.nim)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 176)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Mahasiswa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.fieldAlamat)
        Me.GroupBox2.Controls.Add(Me.fieldNim)
        Me.GroupBox2.Controls.Add(Me.fieldJurusan)
        Me.GroupBox2.Controls.Add(Me.fieldJenisKelamin)
        Me.GroupBox2.Controls.Add(Me.fieldNama)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 180)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Data Mahasiswa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Alamat Mahasiswa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nomor induk Mahasiswa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nama Mahasiswa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Jurusan"
        '
        'fieldAlamat
        '
        Me.fieldAlamat.Location = New System.Drawing.Point(165, 141)
        Me.fieldAlamat.Name = "fieldAlamat"
        Me.fieldAlamat.Size = New System.Drawing.Size(121, 20)
        Me.fieldAlamat.TabIndex = 1
        '
        'fieldNim
        '
        Me.fieldNim.Location = New System.Drawing.Point(165, 34)
        Me.fieldNim.Name = "fieldNim"
        Me.fieldNim.Size = New System.Drawing.Size(121, 20)
        Me.fieldNim.TabIndex = 1
        '
        'fieldJurusan
        '
        Me.fieldJurusan.Location = New System.Drawing.Point(165, 112)
        Me.fieldJurusan.Name = "fieldJurusan"
        Me.fieldJurusan.Size = New System.Drawing.Size(121, 20)
        Me.fieldJurusan.TabIndex = 1
        '
        'fieldJenisKelamin
        '
        Me.fieldJenisKelamin.Location = New System.Drawing.Point(165, 86)
        Me.fieldJenisKelamin.Name = "fieldJenisKelamin"
        Me.fieldJenisKelamin.Size = New System.Drawing.Size(121, 20)
        Me.fieldJenisKelamin.TabIndex = 1
        '
        'fieldNama
        '
        Me.fieldNama.Location = New System.Drawing.Point(165, 61)
        Me.fieldNama.Name = "fieldNama"
        Me.fieldNama.Size = New System.Drawing.Size(121, 20)
        Me.fieldNama.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(171, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(269, 258)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'labeljudul
        '
        Me.labeljudul.AutoSize = True
        Me.labeljudul.Location = New System.Drawing.Point(74, 22)
        Me.labeljudul.Name = "labeljudul"
        Me.labeljudul.Size = New System.Drawing.Size(201, 13)
        Me.labeljudul.TabIndex = 5
        Me.labeljudul.Text = "Data Mahasiswa IBII Kwik Kian Gie 2020"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labeljudul)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProses)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nim As TextBox
    Friend WithEvents btnProses As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents namaMhs As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents jenisKelamin As ComboBox
    Friend WithEvents jurusan As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fieldAlamat As TextBox
    Friend WithEvents fieldNim As TextBox
    Friend WithEvents fieldJurusan As TextBox
    Friend WithEvents fieldJenisKelamin As TextBox
    Friend WithEvents fieldNama As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents labeljudul As Label
End Class
