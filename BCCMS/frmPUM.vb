Public Class frmPUM
    Private Sub frmPUM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RefreshData()
        Patient.Search2(CmsDataSet.Patient, txtSearch.Text, "", "PUM")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshData()
    End Sub
End Class