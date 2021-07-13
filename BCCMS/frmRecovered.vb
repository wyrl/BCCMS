Public Class frmRecovered
    Public Sub RefreshData()
        Dim details As New PersonDetails(PersonDetails.DETAILS_RECOVERED)

        CmsDataSet.Recovered.Clear()
        details.List(CmsDataSet.Recovered)
    End Sub
End Class