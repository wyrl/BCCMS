Public Class frmPersonRegister

#Region "Shadow"

    Private aeroEnabled As Boolean
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
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

#End Region

    Public Property Category As String
    Public person As New Person
    Public action As String = "add"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmPatientRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CmsDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.CmsDataSet.Person)
        Draggable1.Start()
        Draggable2.Start()

        If Category = Person.CAT_CARRIER Then
            Label1.Text = "Patient Registration"
            gbPatientInfo.Location = New Point(12, 70)
            gbCarrier.Hide()
            Height = Height - 100
            cbStatus.Items.Add("Fully Recovered")
            rbPUI.Hide()
            rbPUM.Hide()
            cbRemarks.Text = "Positive"
        Else
            Label1.Text = "Contact Trace Registration"
            gbCarrier.Show()
            rbPUI.Show()
            rbPUM.Show()
            lblCase.Show()
            cbRemarks.Text = "Negative"
            Dim dt As cmsDataSet.PersonDataTable = Person.List(CmsDataSet.Person)


            Dim list = New AutoCompleteStringCollection()

            For Each dataRow As cmsDataSet.PersonRow In dt.Rows
                list.Add(dataRow.fullname)
            Next

            txtCarrier.AutoCompleteCustomSource = list

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SetToPerson()

        If Not CheckValid() Then
            Exit Sub
        End If


        If action = "add" Then

            person.Insert()

        Else
            person.Update(person.ID)
        End If
        Dim personRow As cmsDataSet.PersonRow
        Dim details As PersonDetails



        If Category = Person.CAT_CONTACT_TRACE Then
            personRow = Person.GetByName(Person.CAT_CONTACT_TRACE, txtFirstname.Text & " " & txtMiddlename.Text & " " & txtLastname.Text)
            If personRow IsNot Nothing Then
                If rbPUI.Checked Then
                    details = New PersonDetails(PersonDetails.DETAILS_PUI)
                End If

                If rbPUM.Checked Then
                    details = New PersonDetails(PersonDetails.DETAILS_PUM)
                End If

                If details IsNot Nothing Then
                    details.PersonID = personRow.p_id
                    details.Insert()
                End If
            End If
        End If

        If Category = Person.CAT_CARRIER Then
            personRow = Person.GetByName(Person.CAT_CARRIER, txtFirstname.Text & " " & txtMiddlename.Text & " " & txtLastname.Text)
            'Console.WriteLine("ID: " & personRow.p_id)

            If cbStatus.Text = "Fully Recovered" Then
                details = New PersonDetails(PersonDetails.DETAILS_RECOVERED)
                details.PersonID = personRow.p_id
                details.Insert()
            End If

        End If

        If cbRemarks.Text = "Positive" Then
            details = New PersonDetails(PersonDetails.DETAILS_POSITIVE)
            details.PersonID = personRow.p_id
            details.Insert()
        ElseIf cbRemarks.Text = "Negative" Then
            details = New PersonDetails(PersonDetails.DETAILS_NEGATIVE)
            details.PersonID = personRow.p_id
            details.Insert()
        End If

        If personRow IsNot Nothing Then
            Dim quarantine As New Quarantine
            quarantine.PersonID = personRow.p_id
            quarantine.StartDate = Now

            If cbStatus.Text = "Self-Quarantine(7 days)" Then
                quarantine.EndDate = DateAdd("d", 7, quarantine.StartDate)
                quarantine.Save()
            ElseIf cbStatus.Text = "Self-Quarantine(14 days)" Then
                quarantine.EndDate = DateAdd("d", 14, quarantine.StartDate)
                quarantine.Save()
            ElseIf cbStatus.Text = "Quarantine in Isolation Area (1 month)" Then
                quarantine.EndDate = DateAdd("d", 30, quarantine.StartDate)
                quarantine.Save()
            ElseIf cbStatus.Text = "Quarantine in Isolation Area (2 months)" Then
                quarantine.EndDate = DateAdd("d", 60, quarantine.StartDate)
                quarantine.Save()
            ElseIf cbStatus.Text = "Quarantine in Isolation Area (3 months)" Then
                quarantine.EndDate = DateAdd("d", 180, quarantine.StartDate)
                quarantine.Save()
            End If


        End If

            DialogResult = DialogResult.OK
    End Sub

    Private Sub SetToPerson()
        person.Category = Category
        person.Firstname = txtFirstname.Text
        person.Middlename = txtMiddlename.Text
        person.Lastname = txtLastname.Text
        person.Purok = cbPurok.Text
        person.Barangay = cbBarangay.Text
        person.City = txtCity.Text
        person.Province = txtProvince.Text
        DateTime.TryParse(cbMonth.Text & " " & cbDay.Text & " " & cbYear.Text, person.Birthdate)
        person.Phone = txtPhone.Text
        Dim list As New List(Of String)
        For Each item As String In chkIllnesses.CheckedItems
            list.Add(item)
        Next
        person.Illnesses = String.Join(",", list)
        person.Temperature = txtTemperature.Text
        person.Remarks = cbRemarks.Text
        person.Status = cbStatus.Text
    End Sub

    Private Function CheckValid()



        If Category = Person.CAT_CONTACT_TRACE Then
            Dim carrierRow As cmsDataSet.PersonRow = Nothing

            For Each personRow As cmsDataSet.PersonRow In CmsDataSet.Person.Rows
                If personRow.fullname = txtCarrier.Text Then
                    carrierRow = personRow
                End If
            Next

            If carrierRow Is Nothing Then
                MessageBox.Show("Please input an existing Carrier")
                Return False
            End If

            'Console.WriteLine("selected index: " & cbRemarks.SelectedIndex)

            If Not (rbPUI.Checked Or rbPUM.Checked) Then
                MessageBox.Show("Please check PUI or PUM")
                Return False
            End If
        End If


        If cbRemarks.SelectedIndex = -1 Then
            MessageBox.Show("Please select a swab test result.")
            Return False
        End If

        If cbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select a status.")
            Return False
        End If

        Return True
    End Function

    Public Sub SetPerson(dataRow As cmsDataSet.PersonRow)
        person.ID = dataRow.p_id
        person.Category = dataRow.category

        txtFirstname.Text = dataRow.firstname
        txtMiddlename.Text = dataRow.middlename
        txtLastname.Text = dataRow.lastname
        cbPurok.Text = dataRow.purok
        cbBarangay.Text = dataRow.barangay
        txtCity.Text = dataRow.city
        txtProvince.Text = dataRow.province
        'person.Birthdate = dataRow.birthdate
        cbMonth.Text = dataRow.birthdate.ToString("MMMM")
        cbDay.Text = dataRow.birthdate.ToString("dd")
        cbYear.Text = dataRow.birthdate.ToString("yyyy")
        txtPhone.Text = dataRow.phone
        'person.Illnesses = dataRow.illnesses
        For chkIndex As Integer = 0 To chkIllnesses.Items.Count - 1
            If dataRow.illnesses.Contains(chkIllnesses.Items.Item(chkIndex)) Then
                chkIllnesses.SetItemChecked(chkIndex, True)
            End If
        Next
        txtTemperature.Text = dataRow.temperature
        cbRemarks.Text = dataRow.remarks
        cbStatus.Text = dataRow.status

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBarangay.SelectedIndexChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtCarrier_TextChanged(sender As Object, e As EventArgs) Handles txtCarrier.TextChanged

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub
End Class