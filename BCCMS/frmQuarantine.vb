Public Class frmQuarantine
    Private Sub frmQuarantine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RefreshData()
        Quarantine.Search(CmsDataSet.Quarantine, "")
    End Sub
End Class