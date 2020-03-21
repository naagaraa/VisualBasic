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
        Me.namaSaya = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.textField = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukan Nama Anda"
        '
        'namaSaya
        '
        Me.namaSaya.Location = New System.Drawing.Point(415, 100)
        Me.namaSaya.Name = "namaSaya"
        Me.namaSaya.Size = New System.Drawing.Size(238, 20)
        Me.namaSaya.TabIndex = 1
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(199, 154)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(454, 23)
        Me.OK.TabIndex = 2
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'textField
        '
        Me.textField.Location = New System.Drawing.Point(199, 205)
        Me.textField.Name = "textField"
        Me.textField.Size = New System.Drawing.Size(454, 20)
        Me.textField.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.textField)
        Me.Controls.Add(Me.namaSaya)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Type Data dan Variabel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents namaSaya As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents textField As TextBox
End Class
