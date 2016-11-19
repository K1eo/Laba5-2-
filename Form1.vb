Imports System.Data.OleDb


Public Class Access
    Dim A As New AccessStraight
    Private Sub Add1_Click(sender As Object, e As EventArgs) Handles Add1.Click

        FAdd.ShowDialog()
        Dim lain As String
        Dim name, color, count As String
        count = 1
        Dim A1, B1, C1 As Integer
        Dim res As DialogResult
        Try
            A1 = FAdd.TB1.Text
            B1 = FAdd.TB2.Text
            C1 = FAdd.TB3.Text
            name = FAdd.TB4.Text
            color = FAdd.TB5.Text
            res = FAdd.DialogResult
            FAdd.Close()

            If res <> DialogResult.OK Then
                Exit Sub
            End If

            Dim c As New OleDbCommand
            c.Connection = conn
            Dim coefficients As New OleDbCommand("select i from Пряма_у_просторі", conn)
            Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
            While dr_coefficient.Read
                count += 1
            End While
            lain = Convert.ToString(A1) + " " + Convert.ToString(B1) + " " + Convert.ToString(C1)
            c.CommandText = "insert into Пряма_у_просторі (coefficients_ABC,Name,color_straight,i) values('" & lain & "','" & name & "','" & color & "', '" & count & "')"
            c.ExecuteNonQuery()

            A.refGrip()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Open1_Click(sender As Object, e As EventArgs) Handles Open1.Click
        A.refGrip()
    End Sub
    ' оновлення на формі БАЗИ ДАНИХ

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Валентин\Documents\BazaStraight.accdb;Persist Security Info=False;" 'задаємо параметри і адрес до бази даних
        conn.Open()                 'зчитуємо з бази даних

        '   DataGrid1.Rows.Add()
        '  conn = New OleDbConnection
        ' conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Валентин\Documents\BazaStraight.accdb;Persist Security Info=False;" 'задаємо параметри і адрес до бази даних
        'conn.Open()                 'зчитуємо з бази даних
    End Sub

    Private Sub Delete1_Click(sender As Object, e As EventArgs) Handles Delete1.Click

        Dim index As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        Try
            index = DataGrid1.CurrentRow.Cells("i").Value
            c.CommandText = "delete from Пряма_у_просторі where i = " & index

        Catch ex As Exception

        End Try
        c.ExecuteNonQuery()
        A.refGrip()
    End Sub

    ' Sort ///////////////////////////////////////////////////////////////////

    ' файл для відкривання Access і занесення бази даних в conn
    Public Sub outFille()
        conn = New OleDbConnection
        Dim c As New OleDbCommand
        Try
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Валентин\Documents\BazaStraight.accdb;Persist Security Info=False;" 'задаємо параметри і адрес до бази даних
            conn.Open()                 'зчитуємо з бази даних
        Catch ex As Exception
            Console.WriteLine("База даних не знайдена")
        End Try
    End Sub



    ' Sort //////////////////////////////////////////////////////////////////////////

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A.bubbleSort()
        A.AddTable()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stringg As String
        stringg = "C:Text.txt"
        A.Виведення_таблиці_у_файл(stringg)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lain.ShowDialog()
        Try
            MsgBox(A.Отримання_елемента_з_масиву_структур(lain.index.Text))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim stringg As String
        stringg = "C:\Users\Валентин\Documents\BazaStraight.accdb"
        'A.print()
        A.Читання_таблиці_БД_у_масив_структур(stringg)
        'A.print()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim index As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        Try
            index = DataGrid1.CurrentRow.Cells("i").Value
            A.Добавлення_елемента_з_форми_у_масив_структур("Name", index)
        Catch ex As Exception
            MsgBox("елементiв немає")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox(A.Кількість_елементів_масиву())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        A.Gridd(A.Таблиця())
        Grid.ShowDialog()
    End Sub
End Class
