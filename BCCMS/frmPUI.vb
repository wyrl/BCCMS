Public Class frmPUI
    Public Sub RefreshData()
        Dim pui As New PersonDetails(PersonDetails.DETAILS_PUI)

        CmsDataSet.PUI_details.Clear()
        pui.List(CmsDataSet.PUI_details)


    End Sub
End Class
