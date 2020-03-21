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
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namaBuku = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hargaBuku = New System.Windows.Forms.TextBox()
        Me.kategoriBuku = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fieldKodeBuku = New System.Windows.Forms.TextBox()
        Me.fieldHargaBuku = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fieldNamaBuku = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fieldKategoriBuku = New System.Windows.Forms.TextBox()
        Me.fieldISBN = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOKO BUKU GUNUNG AGUNG"
        '
        'kodeBuku
        '
        Me.kodeBuku.Location = New System.Drawing.Point(127, 32)
        Me.kodeBuku.Name = "kodeBuku"
        Me.kodeBuku.Size = New System.Drawing.Size(121, 20)
        Me.kodeBuku.TabIndex = 1
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(118, 290)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 23)
        Me.btnProses.TabIndex = 2
        Me.btnProses.Text = "Prosess"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Buku"
        '
        'namaBuku
        '
        Me.namaBuku.Location = New System.Drawing.Point(127, 58)
        Me.namaBuku.Name = "namaBuku"
        Me.namaBuku.Size = New System.Drawing.Size(121, 20)
        Me.namaBuku.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ISBN"
        '
        'isbn
        '
        Me.isbn.Location = New System.Drawing.Point(127, 84)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(121, 20)
        Me.isbn.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kategori Buku"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Harga Buku"
        '
        'hargaBuku
        '
        Me.hargaBuku.Location = New System.Drawing.Point(127, 136)
        Me.hargaBuku.Name = "hargaBuku"
        Me.hargaBuku.Size = New System.Drawing.Size(121, 20)
        Me.hargaBuku.TabIndex = 1
        '
        'kategoriBuku
        '
        Me.kategoriBuku.FormattingEnabled = True
        Me.kategoriBuku.Items.AddRange(New Object() {"Ekonomi", "Hukum", "Sosial", "Pendidikan", "Komputer", "Politik"})
        Me.kategoriBuku.Location = New System.Drawing.Point(127, 110)
        Me.kategoriBuku.Name = "kategoriBuku"
        Me.kategoriBuku.Size = New System.Drawing.Size(121, 21)
        Me.kategoriBuku.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.fieldKodeBuku)
        Me.GroupBox1.Controls.Add(Me.fieldHargaBuku)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.fieldNamaBuku)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.fieldKategoriBuku)
        Me.GroupBox1.Controls.Add(Me.fieldISBN)
        Me.GroupBox1.Location = New System.Drawing.Point(424, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 186)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Harga Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kode Buku"
        '
        'fieldKodeBuku
        '
        Me.fieldKodeBuku.Location = New System.Drawing.Point(141, 35)
        Me.fieldKodeBuku.Name = "fieldKodeBuku"
        Me.fieldKodeBuku.Size = New System.Drawing.Size(121, 20)
        Me.fieldKodeBuku.TabIndex = 1
        '
        'fieldHargaBuku
        '
        Me.fieldHargaBuku.Location = New System.Drawing.Point(141, 139)
        Me.fieldHargaBuku.Name = "fieldHargaBuku"
        Me.fieldHargaBuku.Size = New System.Drawing.Size(121, 20)
        Me.fieldHargaBuku.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nama Buku"
        '
        'fieldNamaBuku
        '
        Me.fieldNamaBuku.Location = New System.Drawing.Point(141, 61)
        Me.fieldNamaBuku.Name = "fieldNamaBuku"
        Me.fieldNamaBuku.Size = New System.Drawing.Size(121, 20)
        Me.fieldNamaBuku.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Kategori Buku"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ISBN"
        '
        'fieldKategoriBuku
        '
        Me.fieldKategoriBuku.Location = New System.Drawing.Point(141, 113)
        Me.fieldKategoriBuku.Name = "fieldKategoriBuku"
        Me.fieldKategoriBuku.Size = New System.Drawing.Size(121, 20)
        Me.fieldKategoriBuku.TabIndex = 1
        '
        'fieldISBN
        '
        Me.fieldISBN.Location = New System.Drawing.Point(141, 87)
        Me.fieldISBN.Name = "fieldISBN"
        Me.fieldISBN.Size = New System.Drawing.Size(121, 20)
        Me.fieldISBN.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.kategoriBuku)
        Me.GroupBox2.Controls.Add(Me.kodeBuku)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.hargaBuku)
        Me.GroupBox2.Controls.Add(Me.namaBuku)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.isbn)
        Me.GroupBox2.Location = New System.Drawing.Point(109, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 186)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Data"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(208, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(304, 290)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents kodeBuku As TextBox
    Friend WithEvents btnProses As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namaBuku As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents isbn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents hargaBuku As TextBox
    Friend WithEvents kategoriBuku As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents fieldKodeBuku As TextBox
    Friend WithEvents fieldHargaBuku As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents fieldNamaBuku As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fieldKategoriBuku As TextBox
    Friend WithEvents fieldISBN As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
