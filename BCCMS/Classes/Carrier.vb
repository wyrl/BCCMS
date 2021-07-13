Public Class Carrier
    Inherits Database

    Public Property ContactTraceID As Integer
    Public Property CarrierID As Integer

    Public Sub Insert()
        Dim sql = "INSERT INTO Carrier(p_id, carrier_id) " &
                          "VALUES(@p_id, @carrier_id)"

        Try
            connection.Open()
            Dim com As New OleDb.OleDbCommand
            com.Connection = connection
            com.CommandType = CommandType.Text
            com.CommandText = sql
            com.Parameters.AddWithValue("@p_id", ContactTraceID)
            com.Parameters.AddWithValue("@carrier_id", CarrierID)
            com.ExecuteNonQuery()

            connection.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.WriteLine(sql)
            connection.Close()
        End Try

    End Sub

End Class
