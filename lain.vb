Public Class lain
    Public stringgg As String


    Public Property stringg_ As String
        Get
            Return stringgg
        End Get
        Set(value As String)
            stringgg = value
        End Set
    End Property
    Private Sub TB1_Click(sender As Object, e As EventArgs) Handles Add.Click
        Me.DialogResult = DialogResult.OK
        stringg_ = index.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Dellet.Click
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub lain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Add
        Me.CancelButton = Dellet
    End Sub

    Private Sub indexKeyPress(sender As Object, e As KeyPressEventArgs) Handles index.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If e.KeyChar < "1" Or e.KeyChar > "9" Then e.Handled = True
    End Sub
End Class