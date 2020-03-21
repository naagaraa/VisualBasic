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
        Me.namaPegawai = New System.Windows.Forms.TextBox()
        Me.jkLaki_laki = New System.Windows.Forms.RadioButton()
        Me.jabatanPegawai = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.jk_perempuan = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gajiPokokPegawai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tunjanganPegawai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalGaji = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.potonganGaji = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gajiBersih = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PEGAWAI PT.SAMUDRA INDONESIA"
        '
        'namaPegawai
        '
        Me.namaPegawai.Location = New System.Drawing.Point(130, 27)
        Me.namaPegawai.Name = "namaPegawai"
        Me.namaPegawai.Size = New System.Drawing.Size(186, 20)
        Me.namaPegawai.TabIndex = 1
        '
        'jkLaki_laki
        '
        Me.jkLaki_laki.AutoSize = True
        Me.jkLaki_laki.Location = New System.Drawing.Point(130, 53)
        Me.jkLaki_laki.Name = "jkLaki_laki"
        Me.jkLaki_laki.Size = New System.Drawing.Size(68, 17)
        Me.jkLaki_laki.TabIndex = 2
        Me.jkLaki_laki.TabStop = True
        Me.jkLaki_laki.Text = "Laki-Laki"
        Me.jkLaki_laki.UseVisualStyleBackColor = True
        '
        'jabatanPegawai
        '
        Me.jabatanPegawai.FormattingEnabled = True
        Me.jabatanPegawai.Items.AddRange(New Object() {"Manager", "Supervisor", "Operasional"})
        Me.jabatanPegawai.Location = New System.Drawing.Point(130, 76)
        Me.jabatanPegawai.Name = "jabatanPegawai"
        Me.jabatanPegawai.Size = New System.Drawing.Size(186, 21)
        Me.jabatanPegawai.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(112, 311)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'jk_perempuan
        '
        Me.jk_perempuan.AutoSize = True
        Me.jk_perempuan.Location = New System.Drawing.Point(226, 53)
        Me.jk_perempuan.Name = "jk_perempuan"
        Me.jk_perempuan.Size = New System.Drawing.Size(79, 17)
        Me.jk_perempuan.TabIndex = 2
        Me.jk_perempuan.TabStop = True
        Me.jk_perempuan.Text = "Perempuan"
        Me.jk_perempuan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Gaji Pokok"
        '
        'gajiPokokPegawai
        '
        Me.gajiPokokPegawai.Location = New System.Drawing.Point(130, 103)
        Me.gajiPokokPegawai.Name = "gajiPokokPegawai"
        Me.gajiPokokPegawai.Size = New System.Drawing.Size(186, 20)
        Me.gajiPokokPegawai.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tunjangan"
        '
        'tunjanganPegawai
        '
        Me.tunjanganPegawai.Location = New System.Drawing.Point(130, 129)
        Me.tunjanganPegawai.Name = "tunjanganPegawai"
        Me.tunjanganPegawai.Size = New System.Drawing.Size(186, 20)
        Me.tunjanganPegawai.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Gaji"
        '
        'totalGaji
        '
        Me.totalGaji.Location = New System.Drawing.Point(130, 155)
        Me.totalGaji.Name = "totalGaji"
        Me.totalGaji.Size = New System.Drawing.Size(186, 20)
        Me.totalGaji.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Potongan"
        '
        'potonganGaji
        '
        Me.potonganGaji.Location = New System.Drawing.Point(130, 181)
        Me.potonganGaji.Name = "potonganGaji"
        Me.potonganGaji.Size = New System.Drawing.Size(186, 20)
        Me.potonganGaji.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gaji Bersih"
        '
        'gajiBersih
        '
        Me.gajiBersih.Location = New System.Drawing.Point(130, 207)
        Me.gajiBersih.Name = "gajiBersih"
        Me.gajiBersih.Size = New System.Drawing.Size(186, 20)
        Me.gajiBersih.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(301, 311)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nama Pegawai"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gajiBersih)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.jabatanPegawai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.jk_perempuan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.jkLaki_laki)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.namaPegawai)
        Me.GroupBox1.Controls.Add(Me.potonganGaji)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.totalGaji)
        Me.GroupBox1.Controls.Add(Me.gajiPokokPegawai)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tunjanganPegawai)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 253)
        Me.GroupBox1.TabIndex = 5
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents namaPegawai As TextBox
    Friend WithEvents jkLaki_laki As RadioButton
    Friend WithEvents jabatanPegawai As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents jk_perempuan As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gajiPokokPegawai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tunjanganPegawai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents totalGaji As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents potonganGaji As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents gajiBersih As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
