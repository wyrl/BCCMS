Public Class frmNegativeCases
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub RefreshData()
        'Person.ListByRemarks(CmsDataSet.Person, "Negative")
        Patient.Search2(CmsDataSet.Patient, txtSearch.Text, "Negative")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshData()
    End Sub
End Class