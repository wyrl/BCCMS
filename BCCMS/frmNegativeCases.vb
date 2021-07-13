Public Class frmNegativeCases
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub RefreshData()
        Person.ListByRemarks(CmsDataSet.Person, "Negative")
    End Sub
End Class