Imports System.Data.OleDb
Imports System.IO
Imports System
Imports Label3_Access


Interface IMyInterface

    Sub Виведення_таблиці_у_файл(ByVal f As String)

    Function Отримання_елемента_з_масиву_структур(ByVal index As Byte) As String

    Sub Читання_таблиці_БД_у_масив_структур(ByVal f As String)
    Sub Добавлення_елемента_з_форми_у_масив_структур(ByVal Name As String, ByVal v As Byte)

    ReadOnly Property Кількість_елементів_масиву() As Integer

    ReadOnly Property Таблиця() As DataTable

End Interface

Public Class AccessStraight : Implements IMyInterface

    Public Structure straight
        Dim index, A, B, C As Integer
        Dim Name, color_straight As String
    End Structure



    Dim names As New List(Of straight)




    ' вивід бази даних у txt файл
    Public Sub Виведення_таблиці_у_файл(ByVal f As String)

        Dim lain As String
        Dim i, index As Integer
        i = 0
        index = 1
        conn = New OleDbConnection
        outFille()
        Dim coefficients As New OleDbCommand("select i,coefficients_ABC,Name,color_straight from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
        Dim file As New StreamWriter(f, False, System.Text.Encoding.GetEncoding(1251))
        While (dr_coefficient.Read)
            lain = dr_coefficient.Item("i").ToString + ") " + dr_coefficient.Item("coefficients_ABC").ToString + " " + dr_coefficient.Item("Name").ToString + " " + dr_coefficient.Item("color_straight")
            file.WriteLine(lain)
        End While
        file.Close()
    End Sub


    ' повертає стрічку деякого рядка бази даних
    Function Отримання_елемента_з_масиву_структур(ByVal index As Byte) As String
        Dim stringg As String
        stringg = ""
        Dim int As Integer
        int = 1
        Dim c As New OleDbCommand
        c.Connection = conn
        outFille()
        Dim coefficients As New OleDbCommand("select i,coefficients_ABC,Name,color_straight from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
        While dr_coefficient.Read
            If int = index Then
                stringg = dr_coefficient.Item("coefficients_ABC").ToString + "_" + dr_coefficient.Item("Name").ToString + "_" + dr_coefficient.Item("color_straight").ToString
            End If
            int += 1
        End While
        Return stringg
    End Function



    Sub Читання_таблиці_БД_у_масив_структур(ByVal f As String)

        Dim ins As Integer
        Dim str As String
        Dim split1() As String
        ins = 1
        names.RemoveRange(0, names.Count)
        Dim n As New List(Of straight)
        Dim r As New straight

        conn = New OleDbConnection
        Try
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & f & ";Persist Security Info=False;" 'задаємо параметри і адрес до бази даних
            conn.Open()                 'зчитуємо з бази даних
        Catch ex As Exception
            Console.WriteLine("База даних не знайдена")
        End Try
        Dim coefficients As New OleDbCommand("select i,coefficients_ABC,Name,color_straight from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
        While (dr_coefficient.Read)
            Try
                r.index = ins
                str = dr_coefficient.Item("coefficients_ABC")
                split1 = Split(str, " ")
                r.A = split1(0)
                r.B = split1(1)
                r.C = split1(2)
                r.Name = dr_coefficient.Item("Name")
                r.color_straight = dr_coefficient.Item("color_straight")
                ins += 1
                names.Add(r)
            Catch ex As Exception
            End Try
        End While
    End Sub


    Sub Добавлення_елемента_з_форми_у_масив_структур(ByVal Name As String, ByVal v As Byte)

        Dim split1(), Str As String
        Dim r As New straight
        Dim i As Integer
        i = 1

        Dim c As New OleDbCommand
        c.Connection = conn

        outFille()
        Dim coefficients As New OleDbCommand("select i,coefficients_ABC,Name,color_straight from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader


        If names.Count < v Then
            While (dr_coefficient.Read)
                If i = v Then
                    r.index = i
                    Str = dr_coefficient.Item("coefficients_ABC")
                    split1 = Split(Str, " ")
                    r.A = split1(0)
                    r.B = split1(1)
                    r.C = split1(2)
                    r.Name = dr_coefficient.Item("Name")
                    r.color_straight = dr_coefficient.Item("color_straight")
                    names.Add(r)
                    MsgBox("Елемент додано")
                    Exit Sub
                End If
                i += 1
            End While
        End If
        MsgBox("Елемент не додано")


    End Sub



    Public ReadOnly Property Кількість_елементів_масиву As Integer Implements IMyInterface.Кількість_елементів_масиву
        Get
            Return names.Count
        End Get
    End Property

    Public ReadOnly Property Таблиця As DataTable Implements IMyInterface.Таблиця
        Get
            Dim A As New search

            Dim stringg As String
            search.lain1.Text = ""
            Dim MyTable As New DataTable
            Dim iRow As DataRow
            search.ShowDialog()
            stringg = search.lain1.Text

            MyTable.Columns.Add("i")
            MyTable.Columns.Add("coefficients_ABC")
            MyTable.Columns.Add("Name")
            MyTable.Columns.Add("color_straight")

            Dim coefficients As New OleDbCommand("select i,coefficients_ABC,Name,color_straight from Пряма_у_просторі", conn)
            Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
            While (dr_coefficient.Read)
                If dr_coefficient.Item("Name") = stringg Then
                    iRow = MyTable.NewRow
                    iRow("i") = dr_coefficient.Item("i")
                    iRow("coefficients_ABC") = dr_coefficient.Item("coefficients_ABC")
                    iRow("Name") = dr_coefficient.Item("Name")
                    iRow("color_straight") = dr_coefficient("color_straight")
                    MyTable.Rows.Add(iRow)
                End If
            End While

            Return MyTable
        End Get
    End Property


    Public Sub Gridd(ByVal MyTable As DataTable)

        Dim ind As Integer
        Dim iRows As DataRow
        iRows = MyTable.NewRow
        ind = MyTable.Columns.Count
        ind = 0
        While (ind < Grid.DGV1.Rows.Count)
            Grid.DGV1.Rows.Remove(Grid.DGV1.Rows.Item(ind))
        End While
        ind = 0
        While (ind < MyTable.Rows.Count)
            iRows = MyTable.Rows.Item(ind)
            Grid.DGV1.Rows.Add(iRows("i"), iRows("coefficients_ABC"), iRows("Name"), iRows("color_straight"))
            ind += 1
        End While
    End Sub



    Public Sub Input()
        Dim ins As Integer
        Dim str As String
        Dim split1() As String
        ins = 1
        names.RemoveRange(0, names.Count)
        Dim n As New List(Of straight)
        Dim r As New straight

        outFille()
        Dim coefficients As New OleDbCommand("select i,coefficients_ABC,Name,color_straight from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
        While (dr_coefficient.Read)
            Try
                r.index = ins
                str = dr_coefficient.Item("coefficients_ABC")
                split1 = Split(str, " ")
                r.A = split1(0)
                r.B = split1(1)
                r.C = split1(2)
                r.Name = dr_coefficient.Item("Name")
                r.color_straight = dr_coefficient.Item("color_straight")
                ins += 1
                names.Add(r)
            Catch ex As Exception
            End Try
        End While

    End Sub


    'додавання в Access базу даних
    Public Sub AddTable()

        Dim lain As String
        Dim i, index As Integer
        i = 0
        index = 1
        Dim coefficients As New OleDbCommand("select i from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
        RemovTable()
        While i < names.Count
            Dim c As New OleDbCommand
            c.Connection = conn
            lain = Convert.ToString(names(i).A) + " " + Convert.ToString(names(i).B) + " " + Convert.ToString(names(i).C)
            c.CommandText = "insert into Пряма_у_просторі (i,coefficients_ABC,Name,color_straight) values('" & index & "','" & lain & "','" & names(i).Name & "', '" & names(i).color_straight & "')"
            c.ExecuteNonQuery()
            i += 1
            index += 1
        End While

    End Sub


    ' видалення усієї бази даних Access
    Public Sub RemovTable()
        Dim c As New OleDbCommand
        c.Connection = conn
        Dim coefficients As New OleDbCommand("select i from Пряма_у_просторі", conn)
        Dim dr_coefficient As OleDbDataReader = coefficients.ExecuteReader
        While dr_coefficient.Read
            c.CommandText = "delete from Пряма_у_просторі where i = " & dr_coefficient.Item("i")
            c.ExecuteNonQuery()
        End While
    End Sub


    ' сорутвання бульбашкою =)
    Public Sub bubbleSort()

        Dim n As New straight
        Dim i, j, flag As Integer
        flag = 1
        Console.WriteLine(names.Count)
        While flag > 0
            flag = 0

            For j = 1 To names.Count - 1
                If names(j - 1).Name > names(j).Name Then
                    n.index = names(j - 1).index
                    n.A = names(j - 1).A
                    n.B = names(j - 1).B
                    n.C = names(j - 1).C
                    n.Name = names(j - 1).Name
                    n.color_straight = names(j - 1).color_straight
                    names(j - 1) = names(j)
                    names(j) = n
                    flag = 1
                End If

            Next

        End While
    End Sub

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


    ' оновлення на формі БАЗИ ДАНИХ
    Public Sub refGrip()
        Dim c As New OleDbCommand
        c.Connection = conn                                  ' зєднуємось з базою даних
        c.CommandText = "select * from Пряма_у_просторі"      ' задаєм з якої таблиці в базі даних будемо зчитувати інформацію


        Dim ds As New DataSet                                 ' обєкт який хранить n-кількість таблиці в цей обєкт ми занисим певну таблицю яку вказали в ConnetcionText
        Dim da As New OleDbDataAdapter(c)                     '
        da.Fill(ds, "Пряма_у_просторі")
        Access.DataGrid1.DataSource = ds
        Access.DataGrid1.DataMember = "Пряма_у_просторі"

    End Sub

    Public Sub print()
        Dim i As Integer
        i = 0
        While i < names.Count
            MsgBox(names(i).index & ") " & names(i).A & " " & names(i).B & " " & names(i).C & " " & names(i).Name & " " & names(i).color_straight)
            i += 1
        End While
    End Sub

    Private Sub IMyInterface_Виведення_таблиці_у_файл(f As String) Implements IMyInterface.Виведення_таблиці_у_файл
        Throw New NotImplementedException()
    End Sub

    Private Function IMyInterface_Отримання_елемента_з_масиву_структур(index As Byte) As String Implements IMyInterface.Отримання_елемента_з_масиву_структур
        Throw New NotImplementedException()
    End Function

    Private Sub IMyInterface_Читання_таблиці_БД_у_масив_структур(f As String) Implements IMyInterface.Читання_таблиці_БД_у_масив_структур
        Throw New NotImplementedException()
    End Sub

    Private Sub IMyInterface_Добавлення_елемента_з_форми_у_масив_структур(Name As String, v As Byte) Implements IMyInterface.Добавлення_елемента_з_форми_у_масив_структур
        Throw New NotImplementedException()
    End Sub

End Class
