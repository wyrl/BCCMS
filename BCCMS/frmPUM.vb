Public Class frmPUM
    Private Sub frmPUM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RefreshData()
        Dim details As New PersonDetails(PersonDetails.DETAILS_PUM)

        CmsDataSet.PUM_details.Clear()
        details.List(CmsDataSet.PUM_details)
    End Sub
End Class