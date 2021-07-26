Public Class Patient
    Inherits Database
    Public Shared ReadOnly CAT_CARRIER = "Carrier"
    Public Shared ReadOnly CAT_CONTACT_TRACE = "Contact Trace"
    Private Shared _lastId As Integer = -1

    Private Shared ReadOnly TABLE = "Patient"
    Private Shared ReadOnly SELECT_COLUMNS = "Patient.p_id, Patient.category, Patient.firstname, Patient.middlename, Patient.lastname, Patient.firstname & ' ' & Patient.middlename & ' ' & Patient.lastname AS fullname, Patient.gender, Patient.h_id, stat.i_id,Patient.purok, Patient.barangay, 
                            Patient.city, Patient.province, 'Purok ' & Patient.purok & ', Barangay  ' & Patient.barangay & ', ' & Patient.city & ', ' & Patient.province AS address, Patient.birthdate, DateDiff('yyyy',[birthdate], Date()) as age,Patient.phone, stat.illnesses, stat.temp, stat.remarks,stat.status, stat.findings, stat.[_date], stat.[_date] as d"

    Public ReadOnly Property LastId() As Integer
        Get
            Return _lastId
        End Get
    End Property

    Public Property ID As Integer
    Public Property Category As String
    Public Property HouseHoldId As Integer
    Public Property Firstname As String
    Public Property Middlename As String
    Public Property Lastname As String
    Public Property Gender As String
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

    Public ReadOnly Property Fullname() As String
        Get
            Return Firstname & " " & Middlename & " " & Lastname
        End Get
    End Property

    Public Property Status As String

    Public Sub Insert()
        Dim sql = "INSERT INTO " & TABLE & "(category, firstname, middlename, lastname, gender, h_id, purok, barangay, city, province, birthdate, phone) " &
                   "VALUES(@category, @firstname, @middlename, @lastname, @gender, @h_id, @purok, @barangay, @city, @province, @birthdate, @phone)"

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
            com.Parameters.AddWithValue("@gender", Gender)
            com.Parameters.AddWithValue("@h_id", HouseHoldId)
            com.Parameters.AddWithValue("@purok", Purok)
            com.Parameters.AddWithValue("@barangay", Barangay)
            com.Parameters.AddWithValue("@city", City)
            com.Parameters.AddWithValue("@province", Province)
            com.Parameters.AddWithValue("@birthdate", Birthdate)
            com.Parameters.AddWithValue("@phone", Phone)

            com.ExecuteNonQuery()

            com = New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT @@IDENTITY FROM Patient"

            Dim adp As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable

            adp.SelectCommand = com
            adp.Fill(dt)

            If dt.Rows.Count > 0 Then
                _lastId = dt.Rows(0)(0)
            End If

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try
    End Sub

    Public Sub Update(searchID As String)
        Dim sql = "UPDATE " & TABLE & " set category = @category, firstname = @firstname, middlename = @middlename, lastname = @lastname, gender = @gender, purok = @purok, barangay = @barangay, city = @city, province = @province, birthdate = @birthdate, phone = @phone" &
                          " WHERE p_id = @p_id"

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
            com.Parameters.AddWithValue("@gender", Gender)
            com.Parameters.AddWithValue("@purok", Purok)
            com.Parameters.AddWithValue("@barangay", Barangay)
            com.Parameters.AddWithValue("@city", City)
            com.Parameters.AddWithValue("@province", Province)
            com.Parameters.AddWithValue("@birthdate", Birthdate)
            com.Parameters.AddWithValue("@phone", Phone)
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
        Dim sql = "DELETE FROM " & TABLE & " WHERE p_id = @ID"

        Dim person As New Patient
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

    Public Shared Function Search(dt As DataTable, category As String, searchPerson As String)
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & "
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id
                    WHERE category = @category AND (firstname & ' ' & middlename & ' ' & lastname) like @search"

        Dim patient As New Patient
        Dim connection As OleDb.OleDbConnection = patient.connection

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

            Console.WriteLine("Category: " & category)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function


    Public Shared Function Search2(dt As DataTable, searchPerson As String, Optional remarks As String = "", Optional findings As String = "", Optional status As String = "")
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & "
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id
                    WHERE remarks like @remarks and (firstname & ' ' & middlename & ' ' & lastname) like @search and findings like @findings and status like @status"

        Console.WriteLine(sql)
        Dim patient As New Patient
        Dim connection As OleDb.OleDbConnection = patient.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
            .Connection = connection,
            .CommandType = CommandType.Text,
            .CommandText = sql
        }

            Console.WriteLine("Remarks: " & remarks)

            com.Parameters.AddWithValue("@remarks", If(remarks = "", "%%", remarks))
            com.Parameters.AddWithValue("@search", "%" & searchPerson & "%")
            com.Parameters.AddWithValue("@findings", If(findings = "", "%%", findings))
            com.Parameters.AddWithValue("@status", If(status = "", "%%", status))

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            dt.Clear()
            show.Fill(dt)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function SearchPositive(dt As DataTable, searchPerson As String)
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & "
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id
                    WHERE remarks = 'Positive' and (firstname & ' ' & middlename & ' ' & lastname) like @search and status <> 'Death'"

        Console.WriteLine(sql)
        Dim patient As New Patient
        Dim connection As OleDb.OleDbConnection = patient.connection

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

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function



    'Public Shared Function GetByID(dt As cmsDataSet.PersonDataTable, category As String, ID As String)
    '    Dim sql = "SELECT p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status 
    '                FROM Person
    '                WHERE p_id = @ID AND category = @category"

    '    Dim person As New Person
    '    Dim connection As OleDb.OleDbConnection = person.connection

    '    Try

    '        connection.Open()
    '        Dim com As New OleDb.OleDbCommand With {
    '            .Connection = connection,
    '            .CommandType = CommandType.Text,
    '            .CommandText = sql
    '        }

    '        com.Parameters.AddWithValue("@category", category)
    '        com.Parameters.AddWithValue("@ID", ID)

    '        Dim show As New OleDb.OleDbDataAdapter
    '        Dim d As New DataTable

    '        show.SelectCommand = com
    '        dt.Clear()
    '        show.Fill(dt)

    '        Console.WriteLine("COUNT: " & dt.Rows.Count)

    '    Catch ex As Exception
    '        Console.WriteLine("Error: " & ex.Message)
    '    End Try

    '    Return dt
    'End Function

    Public Shared Function GetByName(category As String, Name As String) As cmsDataSet.PatientRow
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & "
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id
                    WHERE category = @category AND firstname & ' ' & middlename & ' ' & lastname = @fullname"

        Dim person As New Patient
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
            Dim dt As New cmsDataSet.PatientDataTable
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

    Public Shared Function ListByYear(dt As DataTable, year As String, Optional remarks As String = "", Optional findings As String = "", Optional status As String = "") As cmsDataSet.PatientDataTable
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & "
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id
                    WHERE Year([_date]) = @year AND remarks like @remarks AND findings like @findings AND status like @status"

        Console.WriteLine(sql)
        Dim patient As New Patient
        Dim connection As OleDb.OleDbConnection = patient.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
            .Connection = connection,
            .CommandType = CommandType.Text,
            .CommandText = sql
        }


            com.Parameters.AddWithValue("@year", year)
            com.Parameters.AddWithValue("@remarks", If(remarks = "", "%%", remarks))
            com.Parameters.AddWithValue("@findings", If(findings = "", "%%", findings))
            com.Parameters.AddWithValue("@status", If(status = "", "%%", status))

            Dim show As New OleDb.OleDbDataAdapter
            Dim d As New DataTable

            show.SelectCommand = com
            dt.Clear()
            show.Fill(dt)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function PositiveListByYear(dt As DataTable, year As String) As cmsDataSet.PatientDataTable
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & "
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id
                    WHERE Year([_date]) = @year and remarks = 'Positive' and status <> 'Death'"

        Console.WriteLine(sql)
        Dim patient As New Patient
        Dim connection As OleDb.OleDbConnection = patient.connection

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

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Function List(dt As cmsDataSet.PatientDataTable)
        Dim sql = "SELECT " & SELECT_COLUMNS & "
                    FROM " & TABLE & " 
                    INNER JOIN (
                            SELECT * FROM Patient_status stat WHERE stat.m_id in (SELECT max(m_id) FROM Patient_status group by p_id) 
                    ) as stat ON stat.p_id = Patient.p_id"

        Dim person As New Patient
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
            Console.WriteLine(sql)
        End Try

        Return dt
    End Function

    Public Shared Function ListByCategory(dt As cmsDataSet.PatientDataTable, category As String) As cmsDataSet.PatientDataTable
        Return Search(dt, category, "")
    End Function

    'Public Shared Function ListByRemarks(dt As cmsDataSet.PersonDataTable, remarks As String) As cmsDataSet.PersonDataTable
    '    Dim sql = "SELECT Person.p_id, category, firstname, middlename, lastname, firstname & ' ' & middlename & ' ' & lastname AS fullname, purok, barangay, city, province, 'Barangay ' & barangay & ', Purok ' & purok & ',  ' & city & ',  ' & province AS address, birthdate, phone, illnesses, temperature, remarks, status, DateDiff('yyyy',[birthdate], Date()) as age, [_date] as d 
    '                FROM Person
    '                INNER JOIN [" & remarks & "] ON [" & remarks & "].p_id = Person.p_id
    '                WHERE remarks = @remarks "

    '    Dim person As New Person
    '    Dim connection As OleDb.OleDbConnection = person.connection

    '    Console.WriteLine(sql)

    '    Try

    '        connection.Open()
    '        Dim com As New OleDb.OleDbCommand With {
    '        .Connection = connection,
    '        .CommandType = CommandType.Text,
    '        .CommandText = sql
    '    }

    '        'com.Parameters.AddWithValue("@category", Person.CAT_CARRIER)
    '        com.Parameters.AddWithValue("@remarks", remarks)

    '        Dim show As New OleDb.OleDbDataAdapter
    '        Dim d As New DataTable

    '        show.SelectCommand = com
    '        dt.Clear()
    '        show.Fill(dt)

    '        'Console.WriteLine("COUNT: " & dt.Rows.Count)

    '    Catch ex As Exception
    '        Console.WriteLine("Error: " & ex.Message)
    '    End Try

    '    Return dt
    'End Function



End Class
