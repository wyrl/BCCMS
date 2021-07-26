Public Class frmPUI
    Public Sub RefreshData()
        Patient.Search2(CmsDataSet.Patient, txtSearch.Text, "", "PUI")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshData()
    End Sub
End Class
