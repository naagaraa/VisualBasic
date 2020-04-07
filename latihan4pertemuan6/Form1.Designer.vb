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
        Me.hitung = New System.Windows.Forms.Button()
        Me.field = New System.Windows.Forms.TextBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(214, 113)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(75, 23)
        Me.hitung.TabIndex = 0
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'field
        '
        Me.field.Location = New System.Drawing.Point(314, 116)
        Me.field.Name = "field"
        Me.field.Size = New System.Drawing.Size(176, 20)
        Me.field.TabIndex = 1
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(314, 160)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 0
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.field)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hitung)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hitung As Button
    Friend WithEvents field As TextBox
    Friend WithEvents keluar As Button
End Class
