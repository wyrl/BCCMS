Public Class frmMain
    Private aeroEnabled As Boolean
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Debug.WriteLine("AeroEnabled: " & aeroEnabled)
            Dim cp As CreateParams = MyBase.CreateParams
            If Not aeroEnabled Then
                cp.ClassStyle = cp.ClassStyle Or NativeConstants.CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case NativeConstants.WM_NCPAINT
                Dim val = 2
                If aeroEnabled Then
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, val, 4)
                    Dim bla As New NativeStructs.MARGINS()
                    With bla
                        .bottomHeight = 1
                        .leftWidth = 1
                        .rightWidth = 1
                        .topHeight = 1
                    End With
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, bla)
                End If
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub
    Private Sub CheckAeroEnabled()
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
            aeroEnabled = (enabled = 1)
        Else
            aeroEnabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Logout()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Draggable1.Start()
        Draggable2.Start()

        ChangeButtonColor(btnDashboard)
        ChangeContent(Headline1)

    End Sub

    Private Sub Logout()
        Dim result = MessageBox.Show("Are you sure do you want to logout?", "Logout", MessageBoxButtons.YesNo)

        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Logout()
    End Sub

    Private Sub ChangeButtonColor(ByVal btn As Button)
        For Each ctrl As Control In pnlSidebar.Controls
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.White
                ctrl.ForeColor = SystemColors.ControlText
            End If
        Next


        btn.BackColor = Theme.PrimaryColor
        btn.ForeColor = Color.White


    End Sub

    Private Sub ChangeContent(ByVal userControl As UserControl)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is UserControl Then
                ctrl.Hide()
            End If
        Next

        userControl.Show()
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        ChangeButtonColor(btnDashboard)
        ChangeContent(Headline1)
    End Sub

    Private Sub btnPatients_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPatients.Click
        ChangeButtonColor(btnPatients)
        ChangeContent(PersonManagement1)
        PersonManagement1.Category = Person.CAT_CARRIER
        PersonManagement1.RefreshData()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ChangeButtonColor(btnReports)
        ChangeContent(Reports1)
    End Sub

    Private Sub btnContactTracing_Click(sender As Object, e As EventArgs) Handles btnContactTracing.Click
        ChangeButtonColor(btnContactTracing)
        PersonManagement1.Category = Person.CAT_CONTACT_TRACE
        ChangeContent(PersonManagement1)
        PersonManagement1.RefreshData()
    End Sub


End Class