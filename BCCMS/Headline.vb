Imports System.Windows.Forms.DataVisualization.Charting

Public Class Headline
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Sub DashboardRefreshData()
        Dim dt As New DataTable
        Patient.SearchPositive(dt, "")
        lblCovid.Text = dt.Rows.Count & " Case" & If(dt.Rows.Count > 1, "s", "")

        dt = New DataTable
        Patient.Search2(dt, "", "", "PUI")
        lblPUI.Text = dt.Rows.Count & " Case" & If(dt.Rows.Count > 1, "s", "")

        dt = New DataTable
        Patient.Search2(dt, "", "", "PUM")
        lblPUM.Text = dt.Rows.Count & " Case" & If(dt.Rows.Count > 1, "s", "")

        dt = New DataTable
        Patient.Search2(dt, "", "", "", "Recovered")
        lblRecovered.Text = dt.Rows.Count & " Case" & If(dt.Rows.Count > 1, "s", "")

        dt = New DataTable
        Patient.Search2(dt, "", "", "", "Death")
        lblDeath.Text = dt.Rows.Count & " Case" & If(dt.Rows.Count > 1, "s", "")


        dt = New cmsDataSet.PatientDataTable
        Patient.ListByYear(dt, Now.Year)
        Dim monthlyCases As New MonthlyCases(dt)

        'Chart1.Series.Item(0).Points
        For Each dp As DataPoint In Chart1.Series.Item(0).Points
            Dim m As String = dp.AxisLabel
            Dim count As Integer = monthlyCases.GetCases(m.Substring(0, 3)).Count

            dp.YValues(0) = Convert.ToDouble(count)

        Next


    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        Dim selectedTab As String = TabControl1.SelectedTab.Text

        Select Case selectedTab
            Case "PUI"
                FrmPUI1.RefreshData()
            Case "PUM"
                FrmPUM1.RefreshData()
            Case "Recovered"
                FrmRecovered1.RefreshData()
            Case "Death"
                FrmRecovered1.RefreshData()
            Case "Quarantine"
                FrmQuarantine1.RefreshData()
            Case "Positive"
                FrmPositiveCases1.RefreshData()
            Case "Negative"
                FrmNegativeCases1.RefreshData()
            Case Else
                DashboardRefreshData()

        End Select
    End Sub
End Class
