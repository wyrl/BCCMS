Public Class IsolationFacility
    Inherits Database


    Public Property ID As Integer
    Public Property Area As String


    Public Shared Function GetById(id As Integer) As IsolationFacility
        Dim isoFac As New IsolationFacility


        Dim sql = "SELECT * FROM Isolation_facilities WHERE i_id = @i_id"

        Dim connection As OleDb.OleDbConnection = isoFac.connection

        Try

            connection.Open()
            Dim com As New OleDb.OleDbCommand With {
                .Connection = connection,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            com.Parameters.AddWithValue("@i_id", id)

            Dim show As New OleDb.OleDbDataAdapter

            show.SelectCommand = com
            Dim dt As New cmsDataSet.Isolation_facilitiesDataTable
            dt.Clear()
            show.Fill(dt)

            If dt.Rows.Count > 0 Then
                'Return dt.Rows(0)
                Dim dRow As cmsDataSet.Isolation_facilitiesRow = dt.Rows(0)
                isoFac.ID = dRow.i_id
                isoFac.Area = dRow.area

                Return isoFac
            End If

            'Console.WriteLine("COUNT: " & personRow.Rows.Count)

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try

        Return Nothing

    End Function

End Class
