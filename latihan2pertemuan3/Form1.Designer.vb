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
        Me.clear = New System.Windows.Forms.Button()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.tujuan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maskapai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.keluar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maskapai"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(87, 220)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 1
        Me.clear.Text = "Bersihkan"
        Me.clear.UseVisualStyleBackColor = True
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(176, 167)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(121, 20)
        Me.harga.TabIndex = 2
        '
        'tujuan
        '
        Me.tujuan.FormattingEnabled = True
        Me.tujuan.Items.AddRange(New Object() {"Medan-Padang", "Medan-Jakarta", "Medan-Bali"})
        Me.tujuan.Location = New System.Drawing.Point(176, 140)
        Me.tujuan.Name = "tujuan"
        Me.tujuan.Size = New System.Drawing.Size(121, 21)
        Me.tujuan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tujuan"
        '
        'maskapai
        '
        Me.maskapai.FormattingEnabled = True
        Me.maskapai.Items.AddRange(New Object() {"Garuda", "Lion", "Sriwijaya"})
        Me.maskapai.Location = New System.Drawing.Point(176, 113)
        Me.maskapai.Name = "maskapai"
        Me.maskapai.Size = New System.Drawing.Size(121, 21)
        Me.maskapai.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Harga"
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(222, 220)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 1
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Controls.Add(Me.maskapai)
        Me.Controls.Add(Me.tujuan)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents clear As Button
    Friend WithEvents harga As TextBox
    Friend WithEvents tujuan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maskapai As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents keluar As Button
    Friend WithEvents Label4 As Label
End Class
