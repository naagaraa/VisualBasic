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
        Me.keluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(446, 194)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 0
        Me.keluar.Text = "keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROSEDUR PARAMETER OPTIONAL"
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(348, 194)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 0
        Me.btnUbah.Text = "Ubah Pesan"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'proses
        '
        Me.proses.Location = New System.Drawing.Point(240, 194)
        Me.proses.Name = "proses"
        Me.proses.Size = New System.Drawing.Size(75, 23)
        Me.proses.TabIndex = 0
        Me.proses.Text = "Proses"
        Me.proses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.proses)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.keluar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents keluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUbah As Button
    Friend WithEvents proses As Button
End Class
