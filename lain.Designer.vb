<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lain
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
        Me.Add = New System.Windows.Forms.Button()
        Me.Dellet = New System.Windows.Forms.Button()
        Me.index = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.Color.Black
        Me.Add.ForeColor = System.Drawing.Color.White
        Me.Add.Location = New System.Drawing.Point(12, 51)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 0
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'Dellet
        '
        Me.Dellet.BackColor = System.Drawing.Color.Black
        Me.Dellet.ForeColor = System.Drawing.Color.White
        Me.Dellet.Location = New System.Drawing.Point(105, 50)
        Me.Dellet.Name = "Dellet"
        Me.Dellet.Size = New System.Drawing.Size(75, 23)
        Me.Dellet.TabIndex = 1
        Me.Dellet.Text = "Delete"
        Me.Dellet.UseVisualStyleBackColor = False
        '
        'index
        '
        Me.index.Location = New System.Drawing.Point(12, 8)
        Me.index.MaxLength = 5
        Me.index.Name = "index"
        Me.index.Size = New System.Drawing.Size(168, 20)
        Me.index.TabIndex = 2
        '
        'lain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 36)
        Me.Controls.Add(Me.index)
        Me.Controls.Add(Me.Dellet)
        Me.Controls.Add(Me.Add)
        Me.Name = "lain"
        Me.Text = "lain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add As Button
    Friend WithEvents Dellet As Button
    Friend WithEvents index As TextBox
End Class
