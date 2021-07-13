Public Class PersonDetails
    Inherits Database

    Public Shared ReadOnly Property DETAILS_PUM As String = "PUM_details"
    Public Shared ReadOnly Property DETAILS_PUI As String = "PUI_details"
    Public Shared ReadOnly Property DETAILS_RECOVERED As String = "Recovered"
    Public Shared ReadOnly Property DETAILS_POSITIVE As String = "Positive"
    Public Shared ReadOnly Property DETAILS_NEGATIVE As String = "Negative"
    Public Shared ReadOnly Property DETAILS_DEATH As String = "Death"

    Private TABLE As String
    Public Property PersonID As String
    'Public Property DateRecord As DateTime

    Public Sub New(NameOfDetails As String)
        TABLE = NameOfDetails
    End Sub


    Public Sub Insert()
        Dim sql = "INSERT INTO " & TABLE & "([p_id], [_date]) " &
                          "VALUES(@p_id, @_date)"
        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@p_id", PersonID)
            com.Parameters.AddWithValue("@_date", Now.ToString("yyyy-MM-dd"))
            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub


    Public Function List(dt As DataTable) As DataTable
        Dim sql = "SELECT DISTINCT [_date], 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, phone, illnesses, temperature, remarks, status,firstname & ' ' & middlename & ' ' & lastname AS fullname
                    FROM " & TABLE & " INNER JOIN Person ON Person.p_id = " & TABLE & ".p_id
                    ORDER BY " & TABLE & ".[_date] DESC"
        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
            .Connection = connection,
            .CommandType = CommandType.Text,
            .CommandText = sql
        }

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            dt.Clear()
            show.Fill(dt)

            'Console.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.WriteLine(sql)
        End Try

        Return dt

    End Function

    Public Function ListByDate(dt As DataTable, DateRecord As Date) As DataTable
        Dim sql = "SELECT TOP(1) *,firstname & ' ' & middlename & ' ' & lastname AS fullname, DateDiff('yyyy',[birthdate], Date()) as age, [_date] as d FROM " & TABLE & " 
                    INNER JOIN Person ON Person.p_id = " & TABLE & ".p_id
                   WHERE Format([_date], ""yyyy/mm/dd"") = Format(@_date, ""yyyy/mm/dd"") "
        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }
            com.Parameters.AddWithValue("@_date", DateRecord.ToString("yyyy-MM-dd"))

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


    Public Function ListByYear(dt As DataTable, year As String) As DataTable
        Dim sql = "SELECT DISTINCT purok, barangay, city, province,firstname & ' ' & middlename & ' ' & lastname AS fullname, DateDiff('yyyy',[birthdate], Date()) as age, [_date] as d FROM " & TABLE & " 
                    INNER JOIN Person ON Person.p_id = " & TABLE & ".p_id
                   WHERE Format([_date], ""yyyy"") = @year 
                   ORDER BY [_date] DESC"
        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }
            com.Parameters.AddWithValue("@year", year)

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
