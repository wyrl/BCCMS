Imports Microsoft.Reporting.WinForms

Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = Now.Year - 2 To Now.Year
            cbFrom.Items.Add(i)
        Next

        RefreshData()
    End Sub

    Public Sub RefreshData()
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", BindingSource1))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim param1 As New List(Of ReportParameter)
        Dim title As String = ""
        Dim year As String = cbFrom.Text
        CmsDataSet1.Patient.Clear()

        If cbReport.Text = "Confirmed Cases" Then
            title = "Covid-19 Confirmed Cases in " & year

            Patient.PositiveListByYear(CmsDataSet1.Patient, year)
        ElseIf cbReport.Text = "PUI" Then
            title = "Covid-19 PUI Cases in " & year

            Patient.ListByYear(CmsDataSet1.Patient, year, "", "PUI")
        ElseIf cbReport.Text = "PUM" Then
            title = "Covid-19 PUM Cases in " & year

            Patient.ListByYear(CmsDataSet1.Patient, year, "", "PUM")

        ElseIf cbReport.Text = "Recovered" Then
            title = "Covid-19 Recovered Cases in " & year

            Patient.ListByYear(CmsDataSet1.Patient, year, "", "", "Recovered")
        ElseIf cbReport.Text = "Death" Then
            title = "Covid-19 Death Cases in " & year
            Patient.ListByYear(CmsDataSet1.Patient, year, "", "", "Death")
        End If


        param1.Add(New ReportParameter("title", title, True))
        ReportViewer1.LocalReport.SetParameters(param1)
        ReportViewer1.RefreshReport()
    End Sub
End Class
