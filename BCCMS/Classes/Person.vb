Public Class Person
    Inherits Database
    Public Shared ReadOnly CAT_CARRIER = "Carrier"
    Public Shared ReadOnly CAT_CONTACT_TRACE = "Contact Trace"

    Public Property ID As Integer
    Public Property Category As String
    Public Property Firstname As String
    Public Property Middlename As String
    Public Property Lastname As String
    Public Property Purok As String
    Public Property Barangay As String
    Public Property City As String
    Public Property Province As String
    Public Property Birthdate As Date
    Public ReadOnly Property Age() As Integer
        Get
            If Now.Year > Birthdate.Year Then
                If Now.Month >= Birthdate.Month And Now.Day >= Birthdate.Day Then
                    Return Now.Year - Birthdate.Year
                Else
                    Return Now.Year - Birthdate.Year - 1
                End If
            End If
            Return 0
        End Get
    End Property
    Public Property Phone As String
    Public Property Illnesses As String
    Public Property Temperature As String
    Public Property Remarks As String

    Public ReadOnly Property Fullname() As String
        Get
            Return Firstname & " " & Middlename & " " & Lastname
        End Get
    End Property

    Public Property Status As String

    Public Sub Insert()
        Dim sql = "INSERT INTO Person(category, firstname, middlename, lastname, purok, barangay, city, province, birthdate, phone, illnesses, temperature, remarks, status) " &
                          "VALUES(@category, @firstname, @middlename, @lastname, @purok, @barangay, @city, @province, @birthdate, @phone, @illnesses, @temperature, @remarks, @status)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@category", Category)
            com.Parameters.AddWithValue("@firstname", Firstname)
            com.Parameters.AddWithValue("@middlename", Middlename)
            com.Parameters.AddWithValue("@lastname", Lastname)
            com.Parameters.AddWithValue("@purok", Purok)
            com.Parameters.AddWithValue("@barangay", Barangay)
            com.Parameters.AddWithValue("@city", City)
            com.Parameters.AddWithValue("@province", Province)
            com.Parameters.AddWithValue("@birthdate", Birthdate)
            com.Parameters.AddWithValue("@phone", Phone)
            com.Parameters.AddWithValue("@illnesses", Illnesses)
            com.Parameters.AddWithValue("@temperature", Temperature)
            com.Parameters.AddWithValue("@remarks", Remarks)
            com.Parameters.AddWithValue("@status", Status)

            Console.WriteLine(Remarks)

            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Sub Update(searchID As String)
        Dim sql = "UPDATE Person set category = @category, firstname = @firstname, middlename = @middlename, lastname = @lastname, purok = @purok, barangay = @barangay, city = @city, province = @province, birthdate = @birthdate, phone = @phone, illnesses = @illnesses, temperature = @temperature, remarks = @remarks, status = @status " &
                          "WHERE p_id = @p_id"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@category", Category)
            com.Parameters.AddWithValue("@firstname", Firstname)
            com.Parameters.AddWithValue("@middlename", Middlename)
            com.Parameters.AddWithValue("@lastname", Lastname)
            com.Parameters.AddWithValue("@purok", Purok)
            com.Parameters.AddWithValue("@barangay", Barangay)
            com.Parameters.AddWithValue("@city", City)
            com.Parameters.AddWithValue("@province", Province)
            com.Parameters.AddWithValue("@birthdate", Birthdate)
            com.Parameters.AddWithValue("@phone", Phone)
            com.Parameters.AddWithValue("@illnesses", Illnesses)
            com.Parameters.AddWithValue("@temperature", Temperature)
            com.Parameters.AddWithValue("@remarks", Remarks)
            com.Parameters.AddWithValue("@status", Status)
            com.Parameters.AddWithValue("@p_id", searchID)
            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Shared Sub Delete(ID As Integer)
        Dim sql = "DELETE FROM Person WHERE p_id = @ID"

        Dim person As New Person
        Dim connection As OleDb.OleDbConnection = person.connection

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@ID", ID)

            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Shared Function Search(dt As cmsDataSet.PersonDataTable, category As String, searchPerson As String)
        Dim sql = "SELECT p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status 
                    FROM Person
                    WHERE category = @category AND (firstname & ' ' & middlename & ' ' & lastname) like @search"

        Dim person As New Person
        Dim connection As OleDb.OleDbConnection = person.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
            .Connection = connection,
            .CommandType = CommandType.Text,
            .CommandText = sql
        }

            com.Parameters.AddWithValue("@category", category)
            com.Parameters.AddWithValue("@search", "%" & searchPerson & "%")

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            dt.Clear()
            show.Fill(dt)

            Console.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function GetByID(dt As cmsDataSet.PersonDataTable, category As String, ID As String)
        Dim sql = "SELECT p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status 
                    FROM Person
                    WHERE p_id = @ID AND category = @category"

        Dim person As New Person
        Dim connection As OleDb.OleDbConnection = person.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@category", category)
            com.Parameters.AddWithValue("@ID", ID)

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            dt.Clear()
            show.Fill(dt)

            Console.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function GetByName(category As String, Name As String) As cmsDataSet.PersonRow
        Dim sql = "SELECT p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status 
                    FROM Person
                    WHERE category = @category AND firstname & ' ' & middlename & ' ' & lastname = @fullname
                    ORDER BY p_id desc"

        Dim person As New Person
        Dim connection As OleDb.OleDbConnection = person.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@category", category)
            com.Parameters.AddWithValue("@fullname", Name)

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            Dim dt As New cmsDataSet.PersonDataTable
            dt.Clear()
            show.Fill(dt)

            If dt.Rows.Count Then
                Return dt.Rows(0)
            End If

            'Console.WriteLine("COUNT: " & personRow.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function List(dt As cmsDataSet.PersonDataTable)
        Dim sql = "SELECT p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status 
                    FROM Person"

        Dim person As New Person
        Dim connection As OleDb.OleDbConnection = person.connection

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

            Console.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function ListByCategory(dt As cmsDataSet.PersonDataTable, category As String) As cmsDataSet.PersonDataTable
        Return Search(dt, category, "")
    End Function

    Public Shared Function ListByRemarks(dt As cmsDataSet.PersonDataTable, remarks As String) As cmsDataSet.PersonDataTable
        Dim sql = "SELECT Person.p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status, DateDiff('yyyy',[birthdate], Date()) as age, [_date] as d 
                    FROM Person
                    INNER JOIN [" & remarks & "] ON [" & remarks & "].p_id = Person.p_id
                    WHERE remarks = @remarks "

        Dim person As New Person
        Dim connection As OleDb.OleDbConnection = person.connection

        Console.WriteLine(sql)

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
            .Connection = connection,
            .CommandType = CommandType.Text,
            .CommandText = sql
        }

            'com.Parameters.AddWithValue("@category", Person.CAT_CARRIER)
            com.Parameters.AddWithValue("@remarks", remarks)

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
