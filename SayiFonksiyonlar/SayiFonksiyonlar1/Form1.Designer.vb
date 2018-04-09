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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sayi1TextBox = New System.Windows.Forms.TextBox()
        Me.Sayi2TextBox = New System.Windows.Forms.TextBox()
        Me.MutlakDegerButton = New System.Windows.Forms.Button()
        Me.YukariYuvarlaButton = New System.Windows.Forms.Button()
        Me.AsagiYuvarlaButton = New System.Windows.Forms.Button()
        Me.YuvarlaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sayı 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sayı 2"
        '
        'Sayi1TextBox
        '
        Me.Sayi1TextBox.Location = New System.Drawing.Point(65, 37)
        Me.Sayi1TextBox.Name = "Sayi1TextBox"
        Me.Sayi1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sayi1TextBox.TabIndex = 2
        '
        'Sayi2TextBox
        '
        Me.Sayi2TextBox.Location = New System.Drawing.Point(65, 63)
        Me.Sayi2TextBox.Name = "Sayi2TextBox"
        Me.Sayi2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sayi2TextBox.TabIndex = 3
        '
        'MutlakDegerButton
        '
        Me.MutlakDegerButton.Location = New System.Drawing.Point(15, 89)
        Me.MutlakDegerButton.Name = "MutlakDegerButton"
        Me.MutlakDegerButton.Size = New System.Drawing.Size(150, 41)
        Me.MutlakDegerButton.TabIndex = 4
        Me.MutlakDegerButton.Text = "Mutlak Değer"
        Me.MutlakDegerButton.UseVisualStyleBackColor = True
        '
        'YukariYuvarlaButton
        '
        Me.YukariYuvarlaButton.Location = New System.Drawing.Point(15, 136)
        Me.YukariYuvarlaButton.Name = "YukariYuvarlaButton"
        Me.YukariYuvarlaButton.Size = New System.Drawing.Size(150, 41)
        Me.YukariYuvarlaButton.TabIndex = 5
        Me.YukariYuvarlaButton.Text = "Yukarı Yuvarla"
        Me.YukariYuvarlaButton.UseVisualStyleBackColor = True
        '
        'AsagiYuvarlaButton
        '
        Me.AsagiYuvarlaButton.Location = New System.Drawing.Point(15, 183)
        Me.AsagiYuvarlaButton.Name = "AsagiYuvarlaButton"
        Me.AsagiYuvarlaButton.Size = New System.Drawing.Size(150, 41)
        Me.AsagiYuvarlaButton.TabIndex = 6
        Me.AsagiYuvarlaButton.Text = "Aşağı Yuvarla"
        Me.AsagiYuvarlaButton.UseVisualStyleBackColor = True
        '
        'YuvarlaButton
        '
        Me.YuvarlaButton.Location = New System.Drawing.Point(15, 230)
        Me.YuvarlaButton.Name = "YuvarlaButton"
        Me.YuvarlaButton.Size = New System.Drawing.Size(150, 41)
        Me.YuvarlaButton.TabIndex = 7
        Me.YuvarlaButton.Text = "Yuvarla"
        Me.YuvarlaButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 281)
        Me.Controls.Add(Me.YuvarlaButton)
        Me.Controls.Add(Me.AsagiYuvarlaButton)
        Me.Controls.Add(Me.YukariYuvarlaButton)
        Me.Controls.Add(Me.MutlakDegerButton)
        Me.Controls.Add(Me.Sayi2TextBox)
        Me.Controls.Add(Me.Sayi1TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sayi1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sayi2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MutlakDegerButton As System.Windows.Forms.Button
    Friend WithEvents YukariYuvarlaButton As System.Windows.Forms.Button
    Friend WithEvents AsagiYuvarlaButton As System.Windows.Forms.Button
    Friend WithEvents YuvarlaButton As System.Windows.Forms.Button

End Class
