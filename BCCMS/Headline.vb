Public Class Headline
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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
            Case "Quarantine"
                FrmQuarantine1.RefreshData()
            Case "Negative Cases"
                FrmNegativeCases1.RefreshData()
        End Select
    End Sub
End Class
