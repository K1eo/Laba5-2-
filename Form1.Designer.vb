<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Access
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
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.Add1 = New System.Windows.Forms.Button()
        Me.Delete1 = New System.Windows.Forms.Button()
        Me.Open1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToAddRows = False
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(19, 12)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(445, 208)
        Me.DataGrid1.TabIndex = 0
        '
        'Add1
        '
        Me.Add1.BackColor = System.Drawing.Color.Black
        Me.Add1.ForeColor = System.Drawing.Color.White
        Me.Add1.Location = New System.Drawing.Point(250, 230)
        Me.Add1.Name = "Add1"
        Me.Add1.Size = New System.Drawing.Size(94, 31)
        Me.Add1.TabIndex = 1
        Me.Add1.Text = "Add"
        Me.Add1.UseVisualStyleBackColor = False
        '
        'Delete1
        '
        Me.Delete1.BackColor = System.Drawing.Color.Black
        Me.Delete1.ForeColor = System.Drawing.Color.White
        Me.Delete1.Location = New System.Drawing.Point(364, 230)
        Me.Delete1.Name = "Delete1"
        Me.Delete1.Size = New System.Drawing.Size(94, 31)
        Me.Delete1.TabIndex = 2
        Me.Delete1.Text = "Delete"
        Me.Delete1.UseVisualStyleBackColor = False
        '
        'Open1
        '
        Me.Open1.BackColor = System.Drawing.Color.Black
        Me.Open1.ForeColor = System.Drawing.Color.White
        Me.Open1.Location = New System.Drawing.Point(134, 230)
        Me.Open1.Name = "Open1"
        Me.Open1.Size = New System.Drawing.Size(94, 31)
        Me.Open1.TabIndex = 3
        Me.Open1.Text = "Open"
        Me.Open1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(24, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Sort"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(470, 191)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 29)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Add Element To Array"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(470, 156)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 29)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Count Element ToArray"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(470, 121)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 29)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Get Element From ArrayList"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(470, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 29)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Show Alt ArrayList"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(470, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 29)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Write ToFile"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(470, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 29)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Read From File"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Access
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(616, 289)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Open1)
        Me.Controls.Add(Me.Delete1)
        Me.Controls.Add(Me.Add1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Access"
        Me.Text = " "
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid1 As DataGridView
    Friend WithEvents Add1 As Button
    Friend WithEvents Delete1 As Button
    Friend WithEvents Open1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
