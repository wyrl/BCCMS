Public Class Quarantine
    Inherits Database

    Public Property MId As Integer
    Public Property IId As Integer
    Public Property StartDate As Date
    Public Property EndDate As Date
    Public Property Remarks As String

    'Public Sub Save()
    '    If Not IsExists() Then
    '        Insert()
    '    Else
    '        Update()
    '    End If
    'End Sub



    Public Sub Insert()
        Dim sql = "INSERT INTO Quarantine(m_id, i_id, start_date, end_date, remarks) values(@m_id, @i_id,@start_date, @end_date, @remarks)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@m_id", MId)
            com.Parameters.AddWithValue("@i_id", IId)
            com.Parameters.AddWithValue("@start_date", StartDate.ToString("yyyy-MM-dd"))
            com.Parameters.AddWithValue("@end_date", EndDate.ToString("yyyy-MM-dd"))
            com.Parameters.AddWithValue("@remarks", Remarks)
            com.ExecuteNonQuery()

            Console.WriteLine("Start Date: " & StartDate.ToString("yyyy-MM-dd"))
            Console.WriteLine("End Date: " & EndDate.ToString("yyyy-MM-dd"))

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    'Public Sub Update()
    '    Dim sql = "UPDATE Quarantine SET start_date = @start_date, end_date = @end_date
    '               WHERE p_id = @p_id"

    '    Try
    '        connection.Open()
    '        Dim com As New OleDb.OleDbCommand
    '        com.Connection = connection
    '        com.CommandType = CommandType.Text
    '        com.CommandText = sql
    '        com.Parameters.AddWithValue("@start_date", StartDate.ToString("yyyy-MM-dd"))
    '        com.Parameters.AddWithValue("@end_date", EndDate.ToString("yyyy-MM-dd"))
    '        com.Parameters.AddWithValue("@p_id", PersonID)

    '        com.ExecuteNonQuery()


    '        Console.WriteLine("Update: ")
    '        Console.WriteLine("ID: " & PersonID)
    '        Console.WriteLine("Start Date --> " & StartDate.ToString("yyyy-MM-dd"))
    '        Console.WriteLine("End Date --> " & EndDate.ToString("yyyy-MM-dd"))
    '        connection.Close()
    '    Catch ex As Exception
    '        Debug.WriteLine(ex.Message)
    '        Debug.WriteLine(sql)
    '        connection.Close()
    '    End Try
    'End Sub


    'Public Function IsExists()
    '    Dim sql = "SELECT p_id FROM Quarantine WHERE p_id = @p_id"

    '    Try

    '        connection.Open()
    '        Dim com As New OleDb.OleDbCommand With {
    '        .Connection = connection,
    '        .CommandType = CommandType.Text,
    '        .CommandText = sql
    '    }

    '        com.Parameters.AddWithValue("@p_id", PersonID)

    '        Dim show As New OleDb.OleDbDataAdapter
    '        Dim d As New DataTable

    '        show.SelectCommand = com
    '        d.Clear()
    '        show.Fill(d)

    '        connection.Close()
    '        Return d.Rows.Count > 0

    '        'Console.WriteLine("COUNT: " & dt.Rows.Count)

    '    Catch ex As Exception
    '        Console.WriteLine("Error: " & ex.Message)
    '    End Try

    '    Return False
    'End Function

    Public Shared Function Search(dt As DataTable, searchPerson As String)
        Dim sql = "SELECT Patient.firstname & ' ' & Patient.middlename & ' ' & Patient.lastname AS fullname, stat.*
                    FROM Patient
                    INNER JOIN (SELECT stat.p_id,q.start_date, q.end_date, q.Remarks FROM Patient_status stat INNER JOIN Quarantine as q ON q.m_id = stat.m_id WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status GROUP BY p_id) ) as stat ON stat.p_id = Patient.p_id
                   WHERE (firstname & ' ' & middlename & ' ' & lastname) like @search"

        Dim quarantine As New Quarantine
        Dim connection As OleDb.OleDbConnection = quarantine.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@search", "%" & searchPerson & "%")

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            dt.Clear()
            show.Fill(dt)

            'Console.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function


End Class
