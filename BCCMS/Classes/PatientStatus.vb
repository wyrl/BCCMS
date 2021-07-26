Public Class PatientStatus
    Inherits Database
    Private Shared ReadOnly TABLE = "Patient_status"
    Private Shared _lastId As Integer

    Public Shared ReadOnly Property LastId() As Integer
        Get
            Return _lastId
        End Get
    End Property


    Public Property MId As Integer
    Public Property PatientId As Integer
    Public Property NurseId As Integer
    Public Property IsolationFacilityId As Integer
    Public Property _Date As Date
    Public Property Findings As String
    Public Property Status As String
    Public Property Illnesses As String
    Public Property Remarks As String
    Public Property Temperature As String

    Public Sub Insert()
        Dim sql = "INSERT INTO " & TABLE & "(p_id, n_id, i_id, [_date], findings, status, illnesses, remarks, temp) " &
                   "VALUES(@p_id, @n_id, @i_id, @_date, @findings, @status, @illnesses, @remarks, @temp)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@p_id", PatientId)
            com.Parameters.AddWithValue("@n_id", NurseId)
            com.Parameters.AddWithValue("@i_id", IsolationFacilityId)
            com.Parameters.AddWithValue("@_date", Now.ToString("yyyy-MM-dd"))
            com.Parameters.AddWithValue("@findings", Findings)
            com.Parameters.AddWithValue("@status", Status)
            com.Parameters.AddWithValue("@illnesses", Illnesses)
            com.Parameters.AddWithValue("@remarks", Remarks)
            com.Parameters.AddWithValue("@temp", Temperature)
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
End Class
