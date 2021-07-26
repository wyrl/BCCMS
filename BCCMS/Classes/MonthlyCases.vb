Public Class MonthlyCases
    Public Shared ReadOnly months() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
    Dim monthlyDic As New Dictionary(Of String, List(Of cmsDataSet.PatientRow))
    Private dt As cmsDataSet.PatientDataTable

    Public Sub New(dt As cmsDataSet.PatientDataTable)
        Me.dt = dt
        init()
    End Sub

    Public Sub init()
        For Each month As String In months
            monthlyDic.Add(month, New List(Of cmsDataSet.PatientRow))
        Next


        For Each row As cmsDataSet.PatientRow In dt
            'Dim month = row._date.Month
            'Console.WriteLine("Date: " & row._date.ToShortDateString())
            'Console.WriteLine("Month Number: " & )

            monthlyDic.Item(months(row._date.Month - 1)).Add(row)



        Next
    End Sub

    Public Function GetCases(month As String) As List(Of cmsDataSet.PatientRow)
        Return monthlyDic.Item(month)
    End Function



End Class
