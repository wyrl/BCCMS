Public Class Household
    Inherits Database

    Public Property ID As Integer
    Public Property HHNumber As String
    Public Property FamilyName As String
    Public Property Purok As String
    Public Property Barangay As String
    Public Property City As String
    Public Property Province As String

    Public Function Insert()
        Dim sql = "INSERT INTO Household(hh_num, family_name, purok, barangay, city, province) " &
                   "VALUES(@hh_num, @family_name, @purok, @barangay, @city, @province)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@hh_num", HHNumber)
            com.Parameters.AddWithValue("@family_name", FamilyName)
            com.Parameters.AddWithValue("@purok", Purok)
            com.Parameters.AddWithValue("@barangay", Barangay)
            com.Parameters.AddWithValue("@city", City)
            com.Parameters.AddWithValue("@province", Province)

            com.ExecuteNonQuery()

            connection.Close()

            Return True

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try

        Return False
    End Function

    Public Shared Function GetById(id As Integer) As Household
        Dim sql = "SELECT * FROM Household WHERE h_id = @h_id"

        Dim hh As New Household
        Dim connection As OleDb.OleDbConnection = hh.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@h_id", id)

            Dim show As New OleDb.OleDbDataAdapter

            show.SelectCommand = com
            Dim dt As New cmsDataSet.HouseholdDataTable
            dt.Clear()
            show.Fill(dt)

            If dt.Rows.Count > 0 Then
                'Return dt.Rows(0)
                Dim dRow As cmsDataSet.HouseholdRow = dt.Rows(0)
                hh.ID = dRow.h_id
                hh.HHNumber = dRow.hh_num
                hh.FamilyName = If(Not dRow.Isfamily_nameNull, dRow.family_name, "")
                hh.Purok = If(Not dRow.IspurokNull, dRow.purok, "")
                hh.Barangay = If(Not dRow.IsbarangayNull, dRow.barangay, "")
                hh.City = If(Not dRow.IscityNull, dRow.city, "")
                hh.Province = If(Not dRow.IsprovinceNull, dRow.province, "")

                Return hh
            End If

            'Console.WriteLine("COUNT: " & personRow.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function GetByNumber(number As String) As Household
        Dim sql = "SELECT * FROM Household WHERE hh_num = @hh_num"

        Dim hh As New Household
        Dim connection As OleDb.OleDbConnection = hh.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@hh_num", number)

            Dim show As New OleDb.OleDbDataAdapter

            show.SelectCommand = com
            Dim dt As New cmsDataSet.HouseholdDataTable
            dt.Clear()
            show.Fill(dt)

            If dt.Rows.Count > 0 Then
                'Return dt.Rows(0)
                Dim dRow As cmsDataSet.HouseholdRow = dt.Rows(0)
                hh.ID = dRow.h_id
                hh.HHNumber = dRow.hh_num
                hh.FamilyName = If(Not dRow.Isfamily_nameNull, dRow.family_name, "")
                hh.Purok = If(Not dRow.IspurokNull, dRow.purok, "")
                hh.Barangay = If(Not dRow.IsbarangayNull, dRow.barangay, "")
                hh.City = If(Not dRow.IscityNull, dRow.city, "")
                hh.Province = If(Not dRow.IsprovinceNull, dRow.province, "")

                Return hh
            End If

            'Console.WriteLine("COUNT: " & personRow.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return Nothing
    End Function
End Class
