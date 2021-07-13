Public Class Login
    Inherits Database


    Public Shared Function Check(username As String, password As String)

        Dim sql = "SELECT * FROM Login WHERE username = @username AND password = @password"

        Dim person As New Login
        Dim connection As OleDb.OleDbConnection = person.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@username", username)
            com.Parameters.AddWithValue("@password", password)

            Dim show As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable

            show.SelectCommand = com
            show.Fill(dt)

            Return dt.Rows.Count > 0

            'Console.WriteLine("COUNT: " & dt.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return False

    End Function

End Class
