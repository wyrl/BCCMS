Imports Microsoft.Reporting.WinForms

Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = Now.Year - 2 To Now.Year
            cbFrom.Items.Add(i)
        Next

        RefreshData()
    End Sub

    Public Sub RefreshData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbReport.Text = "COVID19 Positive" Then
            Dim positive As New PersonDetails(PersonDetails.DETAILS_POSITIVE)

            positive.ListByYear(cmsDataSet.Positive, cbFrom.Text)


            Dim param1 As New List(Of ReportParameter)
            param1.Add(New ReportParameter("title", "Covid-19 Confirmed Cases in " & cbFrom.Text, True))
            ReportViewer1.LocalReport.SetParameters(param1)
            ReportViewer1.RefreshReport()

        ElseIf cbReport.Text = "PUI" Then
            Dim detail As New PersonDetails(PersonDetails.DETAILS_PUI)

            detail.ListByYear(cmsDataSet.Positive, cbFrom.Text)


            Dim param1 As New List(Of ReportParameter)
            param1.Add(New ReportParameter("title", "Covid-19 Cases as PUI in " & cbFrom.Text, True))
            ReportViewer1.LocalReport.SetParameters(param1)
            ReportViewer1.RefreshReport()
        ElseIf cbReport.Text = "PUM" Then
            Dim detail As New PersonDetails(PersonDetails.DETAILS_PUM)

            detail.ListByYear(cmsDataSet.Positive, cbFrom.Text)


            Dim param1 As New List(Of ReportParameter)
            param1.Add(New ReportParameter("title", "Covid-19 Cases as PUM in " & cbFrom.Text, True))
            ReportViewer1.LocalReport.SetParameters(param1)
            ReportViewer1.RefreshReport()

        ElseIf cbReport.Text = "COVID19 Negative" Then

        End If
    End Sub
End Class
