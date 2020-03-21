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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nik = New System.Windows.Forms.TextBox()
        Me.jabatan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.namaKaryawan = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fieldAlamat = New System.Windows.Forms.TextBox()
        Me.fieldJabatan = New System.Windows.Forms.TextBox()
        Me.fieldNama = New System.Windows.Forms.TextBox()
        Me.fieldNIK = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Biodata Pegawai"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Prosess"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nik
        '
        Me.nik.Location = New System.Drawing.Point(235, 115)
        Me.nik.Name = "nik"
        Me.nik.Size = New System.Drawing.Size(140, 20)
        Me.nik.TabIndex = 2
        '
        'jabatan
        '
        Me.jabatan.FormattingEnabled = True
        Me.jabatan.Items.AddRange(New Object() {"Manager", "SuperVisor", "Staff"})
        Me.jabatan.Location = New System.Drawing.Point(235, 192)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(140, 21)
        Me.jabatan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor Induk Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat"
        '
        'namaKaryawan
        '
        Me.namaKaryawan.Location = New System.Drawing.Point(235, 152)
        Me.namaKaryawan.Name = "namaKaryawan"
        Me.namaKaryawan.Size = New System.Drawing.Size(140, 20)
        Me.namaKaryawan.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fieldAlamat)
        Me.GroupBox1.Controls.Add(Me.fieldJabatan)
        Me.GroupBox1.Controls.Add(Me.fieldNama)
        Me.GroupBox1.Controls.Add(Me.fieldNIK)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(417, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 184)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Biodata Karyawan"
        '
        'fieldAlamat
        '
        Me.fieldAlamat.Location = New System.Drawing.Point(175, 138)
        Me.fieldAlamat.Name = "fieldAlamat"
        Me.fieldAlamat.Size = New System.Drawing.Size(172, 20)
        Me.fieldAlamat.TabIndex = 2
        '
        'fieldJabatan
        '
        Me.fieldJabatan.Location = New System.Drawing.Point(175, 100)
        Me.fieldJabatan.Name = "fieldJabatan"
        Me.fieldJabatan.Size = New System.Drawing.Size(172, 20)
        Me.fieldJabatan.TabIndex = 2
        '
        'fieldNama
        '
        Me.fieldNama.Location = New System.Drawing.Point(175, 60)
        Me.fieldNama.Name = "fieldNama"
        Me.fieldNama.Size = New System.Drawing.Size(172, 20)
        Me.fieldNama.TabIndex = 2
        '
        'fieldNIK
        '
        Me.fieldNIK.Location = New System.Drawing.Point(175, 26)
        Me.fieldNIK.Name = "fieldNIK"
        Me.fieldNIK.Size = New System.Drawing.Size(172, 20)
        Me.fieldNIK.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nomor Induk Karyawan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nama Karyawan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jabatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Alamat"
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(235, 230)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(140, 20)
        Me.alamat.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(321, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.jabatan)
        Me.Controls.Add(Me.namaKaryawan)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nik)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents nik As TextBox
    Friend WithEvents jabatan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents namaKaryawan As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fieldAlamat As TextBox
    Friend WithEvents fieldJabatan As TextBox
    Friend WithEvents fieldNama As TextBox
    Friend WithEvents fieldNIK As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents alamat As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
