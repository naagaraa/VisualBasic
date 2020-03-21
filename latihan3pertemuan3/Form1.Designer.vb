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
        Me.txtNamaHari = New System.Windows.Forms.TextBox()
        Me.txtHari = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.proses = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hari"
        '
        'txtNamaHari
        '
        Me.txtNamaHari.Location = New System.Drawing.Point(162, 155)
        Me.txtNamaHari.Name = "txtNamaHari"
        Me.txtNamaHari.Size = New System.Drawing.Size(121, 20)
        Me.txtNamaHari.TabIndex = 1
        '
        'txtHari
        '
        Me.txtHari.FormattingEnabled = True
        Me.txtHari.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.txtHari.Location = New System.Drawing.Point(162, 123)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.Size = New System.Drawing.Size(121, 21)
        Me.txtHari.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Hari"
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(77, 206)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(75, 23)
        Me.proses.TabIndex = 3
        Me.proses.Text = "Proses"
        Me.proses.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(208, 206)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 3
        Me.keluar.Text = "keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 450)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.proses)
        Me.Controls.Add(Me.txtHari)
        Me.Controls.Add(Me.txtNamaHari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaHari As TextBox
    Friend WithEvents txtHari As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents proses As Button
    Friend WithEvents keluar As Button
End Class
