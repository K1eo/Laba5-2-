<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAdd
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
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB4 = New System.Windows.Forms.TextBox()
        Me.TB5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Add2 = New System.Windows.Forms.Button()
        Me.Remove2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(123, 17)
        Me.TB1.MaxLength = 2
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(159, 20)
        Me.TB1.TabIndex = 0
        '
        'TB4
        '
        Me.TB4.Location = New System.Drawing.Point(123, 101)
        Me.TB4.MaxLength = 20
        Me.TB4.Name = "TB4"
        Me.TB4.Size = New System.Drawing.Size(159, 20)
        Me.TB4.TabIndex = 1
        '
        'TB5
        '
        Me.TB5.Location = New System.Drawing.Point(123, 137)
        Me.TB5.MaxLength = 15
        Me.TB5.Name = "TB5"
        Me.TB5.Size = New System.Drawing.Size(159, 20)
        Me.TB5.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Coefficients_A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Color"
        '
        'Add2
        '
        Me.Add2.BackColor = System.Drawing.Color.Black
        Me.Add2.Enabled = False
        Me.Add2.ForeColor = System.Drawing.Color.Transparent
        Me.Add2.Location = New System.Drawing.Point(10, 182)
        Me.Add2.Name = "Add2"
        Me.Add2.Size = New System.Drawing.Size(126, 33)
        Me.Add2.TabIndex = 12
        Me.Add2.Text = "Add"
        Me.Add2.UseVisualStyleBackColor = False
        '
        'Remove2
        '
        Me.Remove2.BackColor = System.Drawing.Color.Black
        Me.Remove2.ForeColor = System.Drawing.Color.White
        Me.Remove2.Location = New System.Drawing.Point(156, 182)
        Me.Remove2.Name = "Remove2"
        Me.Remove2.Size = New System.Drawing.Size(126, 33)
        Me.Remove2.TabIndex = 12
        Me.Remove2.Text = "Отмена"
        Me.Remove2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Coefficients_B"
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(123, 43)
        Me.TB2.MaxLength = 2
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(159, 20)
        Me.TB2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Coefficients_C"
        '
        'TB3
        '
        Me.TB3.Location = New System.Drawing.Point(123, 69)
        Me.TB3.MaxLength = 2
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(159, 20)
        Me.TB3.TabIndex = 17
        '
        'FAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(290, 240)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.Remove2)
        Me.Controls.Add(Me.Add2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB5)
        Me.Controls.Add(Me.TB4)
        Me.Controls.Add(Me.TB1)
        Me.KeyPreview = True
        Me.Name = "FAdd"
        Me.Text = "FAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB4 As TextBox
    Friend WithEvents TB5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Add2 As Button
    Friend WithEvents Remove2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TB2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB3 As TextBox
End Class
