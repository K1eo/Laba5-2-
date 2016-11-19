<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lain1 = New System.Windows.Forms.TextBox()
        Me.Ad = New System.Windows.Forms.Button()
        Me.Dl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lain1
        '
        Me.lain1.Location = New System.Drawing.Point(3, 12)
        Me.lain1.MaxLength = 5
        Me.lain1.Name = "lain1"
        Me.lain1.Size = New System.Drawing.Size(198, 20)
        Me.lain1.TabIndex = 0
        '
        'Ad
        '
        Me.Ad.BackColor = System.Drawing.Color.Black
        Me.Ad.ForeColor = System.Drawing.Color.White
        Me.Ad.Location = New System.Drawing.Point(3, 38)
        Me.Ad.Name = "Ad"
        Me.Ad.Size = New System.Drawing.Size(71, 23)
        Me.Ad.TabIndex = 1
        Me.Ad.Text = "Add"
        Me.Ad.UseVisualStyleBackColor = False
        '
        'Dl
        '
        Me.Dl.BackColor = System.Drawing.Color.Black
        Me.Dl.ForeColor = System.Drawing.Color.White
        Me.Dl.Location = New System.Drawing.Point(91, 38)
        Me.Dl.Name = "Dl"
        Me.Dl.Size = New System.Drawing.Size(71, 23)
        Me.Dl.TabIndex = 2
        Me.Dl.Text = "Delete"
        Me.Dl.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 37)
        Me.Controls.Add(Me.Dl)
        Me.Controls.Add(Me.Ad)
        Me.Controls.Add(Me.lain1)
        Me.Name = "search"
        Me.Text = "search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lain1 As TextBox
    Friend WithEvents Ad As Button
    Friend WithEvents Dl As Button
End Class
