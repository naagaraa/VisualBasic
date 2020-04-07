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
        Me.btnpilih = New System.Windows.Forms.Button()
        Me.textaja = New System.Windows.Forms.TextBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpilih
        '
        Me.btnpilih.Location = New System.Drawing.Point(217, 130)
        Me.btnpilih.Name = "btnpilih"
        Me.btnpilih.Size = New System.Drawing.Size(75, 23)
        Me.btnpilih.TabIndex = 0
        Me.btnpilih.Text = "Pilih"
        Me.btnpilih.UseVisualStyleBackColor = True
        '
        'textaja
        '
        Me.textaja.Location = New System.Drawing.Point(315, 133)
        Me.textaja.Name = "textaja"
        Me.textaja.Size = New System.Drawing.Size(208, 20)
        Me.textaja.TabIndex = 1
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(315, 190)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 0
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.textaja)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnpilih)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpilih As Button
    Friend WithEvents textaja As TextBox
    Friend WithEvents btnkeluar As Button
End Class
