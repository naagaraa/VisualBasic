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
        Me.namaPegawai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jenisKelaminPegawai = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jabatanPegawai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gajiPokokPegawai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tunjanganPegawai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tunjanganKeluarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalGaji = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pph = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gajiBersih = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.jumlahAnak = New System.Windows.Forms.ComboBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'namaPegawai
        '
        Me.namaPegawai.Location = New System.Drawing.Point(133, 25)
        Me.namaPegawai.Name = "namaPegawai"
        Me.namaPegawai.Size = New System.Drawing.Size(121, 20)
        Me.namaPegawai.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Pegawai"
        '
        'jenisKelaminPegawai
        '
        Me.jenisKelaminPegawai.FormattingEnabled = True
        Me.jenisKelaminPegawai.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.jenisKelaminPegawai.Location = New System.Drawing.Point(133, 51)
        Me.jenisKelaminPegawai.Name = "jenisKelaminPegawai"
        Me.jenisKelaminPegawai.Size = New System.Drawing.Size(121, 21)
        Me.jenisKelaminPegawai.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(106, 344)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATA PEGAWAI  PT SAMPOERNA"
        '
        'jabatanPegawai
        '
        Me.jabatanPegawai.FormattingEnabled = True
        Me.jabatanPegawai.Items.AddRange(New Object() {"Manager", "Supervisor", "Operasional"})
        Me.jabatanPegawai.Location = New System.Drawing.Point(133, 78)
        Me.jabatanPegawai.Name = "jabatanPegawai"
        Me.jabatanPegawai.Size = New System.Drawing.Size(121, 21)
        Me.jabatanPegawai.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jabatan"
        '
        'gajiPokokPegawai
        '
        Me.gajiPokokPegawai.Location = New System.Drawing.Point(133, 105)
        Me.gajiPokokPegawai.Name = "gajiPokokPegawai"
        Me.gajiPokokPegawai.Size = New System.Drawing.Size(121, 20)
        Me.gajiPokokPegawai.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Gaji Pokok"
        '
        'tunjanganPegawai
        '
        Me.tunjanganPegawai.Location = New System.Drawing.Point(133, 131)
        Me.tunjanganPegawai.Name = "tunjanganPegawai"
        Me.tunjanganPegawai.Size = New System.Drawing.Size(121, 20)
        Me.tunjanganPegawai.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tunjangan Jabatan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Jumlah Anak"
        '
        'tunjanganKeluarga
        '
        Me.tunjanganKeluarga.Location = New System.Drawing.Point(133, 183)
        Me.tunjanganKeluarga.Name = "tunjanganKeluarga"
        Me.tunjanganKeluarga.Size = New System.Drawing.Size(121, 20)
        Me.tunjanganKeluarga.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Tunjangan Keluarga"
        '
        'totalGaji
        '
        Me.totalGaji.Location = New System.Drawing.Point(133, 209)
        Me.totalGaji.Name = "totalGaji"
        Me.totalGaji.Size = New System.Drawing.Size(121, 20)
        Me.totalGaji.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Gaji"
        '
        'pph
        '
        Me.pph.Location = New System.Drawing.Point(133, 235)
        Me.pph.Name = "pph"
        Me.pph.Size = New System.Drawing.Size(121, 20)
        Me.pph.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "PPh"
        '
        'gajiBersih
        '
        Me.gajiBersih.Location = New System.Drawing.Point(133, 261)
        Me.gajiBersih.Name = "gajiBersih"
        Me.gajiBersih.Size = New System.Drawing.Size(121, 20)
        Me.gajiBersih.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Gaji Bersih"
        '
        'jumlahAnak
        '
        Me.jumlahAnak.FormattingEnabled = True
        Me.jumlahAnak.Items.AddRange(New Object() {"2", "1", "0"})
        Me.jumlahAnak.Location = New System.Drawing.Point(133, 156)
        Me.jumlahAnak.Name = "jumlahAnak"
        Me.jumlahAnak.Size = New System.Drawing.Size(121, 21)
        Me.jumlahAnak.TabIndex = 2
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(300, 344)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gajiBersih)
        Me.GroupBox1.Controls.Add(Me.namaPegawai)
        Me.GroupBox1.Controls.Add(Me.gajiPokokPegawai)
        Me.GroupBox1.Controls.Add(Me.jumlahAnak)
        Me.GroupBox1.Controls.Add(Me.tunjanganPegawai)
        Me.GroupBox1.Controls.Add(Me.jabatanPegawai)
        Me.GroupBox1.Controls.Add(Me.tunjanganKeluarga)
        Me.GroupBox1.Controls.Add(Me.jenisKelaminPegawai)
        Me.GroupBox1.Controls.Add(Me.totalGaji)
        Me.GroupBox1.Controls.Add(Me.pph)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 303)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pegawai"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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

    Friend WithEvents namaPegawai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents jenisKelaminPegawai As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents jabatanPegawai As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gajiPokokPegawai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tunjanganPegawai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tunjanganKeluarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents totalGaji As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pph As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents gajiBersih As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents jumlahAnak As ComboBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
