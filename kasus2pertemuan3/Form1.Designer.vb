<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Me.nimMhs = New System.Windows.Forms.TextBox()
        Me.jurusanMhs = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namaMhs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nilaiKehadiranMhs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nilaiTugasMhs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nilaiUtsMhs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nilaiUasMhs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nilaiAkhirMhs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gradeMhs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.keterangan = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Induk Mahasiswa"
        '
        'nimMhs
        '
        Me.nimMhs.Location = New System.Drawing.Point(168, 24)
        Me.nimMhs.Name = "nimMhs"
        Me.nimMhs.Size = New System.Drawing.Size(121, 20)
        Me.nimMhs.TabIndex = 1
        '
        'jurusanMhs
        '
        Me.jurusanMhs.FormattingEnabled = True
        Me.jurusanMhs.Items.AddRange(New Object() {"Teknik Informatika", "Teknik Industri", "Teknik Mesin"})
        Me.jurusanMhs.Location = New System.Drawing.Point(168, 72)
        Me.jurusanMhs.Name = "jurusanMhs"
        Me.jurusanMhs.Size = New System.Drawing.Size(121, 21)
        Me.jurusanMhs.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(58, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'namaMhs
        '
        Me.namaMhs.Location = New System.Drawing.Point(168, 47)
        Me.namaMhs.Name = "namaMhs"
        Me.namaMhs.Size = New System.Drawing.Size(121, 20)
        Me.namaMhs.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jurusan Mahasiswa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nilai Kehadiran"
        '
        'nilaiKehadiranMhs
        '
        Me.nilaiKehadiranMhs.Location = New System.Drawing.Point(168, 99)
        Me.nilaiKehadiranMhs.Name = "nilaiKehadiranMhs"
        Me.nilaiKehadiranMhs.Size = New System.Drawing.Size(121, 20)
        Me.nilaiKehadiranMhs.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nilai tugas"
        '
        'nilaiTugasMhs
        '
        Me.nilaiTugasMhs.Location = New System.Drawing.Point(168, 125)
        Me.nilaiTugasMhs.Name = "nilaiTugasMhs"
        Me.nilaiTugasMhs.Size = New System.Drawing.Size(121, 20)
        Me.nilaiTugasMhs.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nilai UTS"
        '
        'nilaiUtsMhs
        '
        Me.nilaiUtsMhs.Location = New System.Drawing.Point(168, 151)
        Me.nilaiUtsMhs.Name = "nilaiUtsMhs"
        Me.nilaiUtsMhs.Size = New System.Drawing.Size(121, 20)
        Me.nilaiUtsMhs.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nilai UAS"
        '
        'nilaiUasMhs
        '
        Me.nilaiUasMhs.Location = New System.Drawing.Point(168, 177)
        Me.nilaiUasMhs.Name = "nilaiUasMhs"
        Me.nilaiUasMhs.Size = New System.Drawing.Size(121, 20)
        Me.nilaiUasMhs.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nilai Akhir"
        '
        'nilaiAkhirMhs
        '
        Me.nilaiAkhirMhs.Enabled = False
        Me.nilaiAkhirMhs.Location = New System.Drawing.Point(168, 29)
        Me.nilaiAkhirMhs.Name = "nilaiAkhirMhs"
        Me.nilaiAkhirMhs.Size = New System.Drawing.Size(115, 20)
        Me.nilaiAkhirMhs.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Grade"
        '
        'gradeMhs
        '
        Me.gradeMhs.Enabled = False
        Me.gradeMhs.Location = New System.Drawing.Point(168, 55)
        Me.gradeMhs.Name = "gradeMhs"
        Me.gradeMhs.Size = New System.Drawing.Size(115, 20)
        Me.gradeMhs.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Keterangan"
        '
        'keterangan
        '
        Me.keterangan.Enabled = False
        Me.keterangan.Location = New System.Drawing.Point(168, 81)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(115, 20)
        Me.keterangan.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(215, 389)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nilaiUasMhs)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nimMhs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.jurusanMhs)
        Me.GroupBox1.Controls.Add(Me.namaMhs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nilaiKehadiranMhs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nilaiTugasMhs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.nilaiUtsMhs)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 213)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.keterangan)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.nilaiAkhirMhs)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.gradeMhs)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 121)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "DATA NILAI MAHASISWA"
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "form"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nimMhs As TextBox
    Friend WithEvents jurusanMhs As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents namaMhs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nilaiKehadiranMhs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nilaiTugasMhs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nilaiUtsMhs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nilaiUasMhs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nilaiAkhirMhs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gradeMhs As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents keterangan As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
End Class
