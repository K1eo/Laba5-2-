Public Class search
    Private stringg As String


    Public Property stringg_ As String
        Get
            Return stringg
        End Get
        Set(value As String)
            stringg = value
        End Set
    End Property


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ad.Click
        Me.DialogResult = DialogResult.OK
        Dim str, str1, str2 As String
        str = lain1.Text
        str1 = str.Substring(0, 1) ' беремо першу букву так як вони всі з регістром (ToUpper) 
        str2 = str.Substring(1, lain1.Text.Length - 1).ToLower 'беремо всі крім першої і роюимо маленькими за допомогою (ToLower)
        lain1.Text = str1 + str2
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Dl.Click
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Ad
        Me.CancelButton = Dl
    End Sub

    Private Sub LainKeyPres(sender As Object, e As KeyPressEventArgs) Handles lain1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        e.KeyChar = e.KeyChar.ToString.ToUpper
        If Not (e.KeyChar Like "[A-ZA-ЯЇІЄ’]") Then
            e.Handled = True
            Beep()
        End If
    End Sub
End Class