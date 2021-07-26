Public Class frmPositiveCases
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub RefreshData()
        'Person.ListByRemarks(CmsDataSet.Person, "Negative")
        'Patient.Search2(CmsDataSet.Patient, txtSearch.Text, "Positive")
        Patient.SearchPositive(CmsDataSet.Patient, txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshData()
    End Sub
End Class