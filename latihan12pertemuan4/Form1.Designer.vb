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
        Me.txtAngka = New System.Windows.Forms.TextBox()
        Me.hasil = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.keliapatan2 = New System.Windows.Forms.Button()
        Me.keliapatan3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGRAM KELIPATAN 2 DAN 3"
        '
        'txtAngka
        '
        Me.txtAngka.Location = New System.Drawing.Point(353, 83)
        Me.txtAngka.Name = "txtAngka"
        Me.txtAngka.Size = New System.Drawing.Size(216, 20)
        Me.txtAngka.TabIndex = 1
        '
        'hasil
        '
        Me.hasil.FormattingEnabled = True
        Me.hasil.Location = New System.Drawing.Point(353, 110)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(216, 147)
        Me.hasil.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(353, 276)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 35)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(353, 317)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(120, 35)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'keliapatan2
        '
        Me.keliapatan2.Location = New System.Drawing.Point(215, 276)
        Me.keliapatan2.Name = "keliapatan2"
        Me.keliapatan2.Size = New System.Drawing.Size(120, 35)
        Me.keliapatan2.TabIndex = 3
        Me.keliapatan2.Text = "Kelipatan 2"
        Me.keliapatan2.UseVisualStyleBackColor = True
        '
        'keliapatan3
        '
        Me.keliapatan3.Location = New System.Drawing.Point(215, 317)
        Me.keliapatan3.Name = "keliapatan3"
        Me.keliapatan3.Size = New System.Drawing.Size(120, 35)
        Me.keliapatan3.TabIndex = 3
        Me.keliapatan3.Text = "Kelipatan 3"
        Me.keliapatan3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Masukan Angka"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasil"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.keliapatan3)
        Me.Controls.Add(Me.keliapatan2)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.hasil)
        Me.Controls.Add(Me.txtAngka)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAngka As TextBox
    Friend WithEvents hasil As ListBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents keliapatan2 As Button
    Friend WithEvents keliapatan3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
