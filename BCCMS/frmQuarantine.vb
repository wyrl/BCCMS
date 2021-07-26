Public Class frmQuarantine
    Private Sub frmQuarantine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RefreshData()
        Quarantine.Search(CmsDataSet.Quarantine1, "")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Quarantine.Search(CmsDataSet.Quarantine1, txtSearch.Text)
    End Sub
End Class