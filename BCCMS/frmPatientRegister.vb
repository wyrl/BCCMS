Public Class frmPatientRegister

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
    Public patient As New Patient
    Public patientStatus As New PatientStatus
    Public action As String = "add"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmPatientRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CmsDataSet1.Isolation_facilities' table. You can move, or remove it, as needed.
        Me.Isolation_facilitiesTableAdapter.Fill(Me.CmsDataSet1.Isolation_facilities)
        'TODO: This line of code loads data into the 'CmsDataSet1.Household' table. You can move, or remove it, as needed.
        Me.HouseholdTableAdapter.Fill(Me.CmsDataSet1.Household)
        'TODO: This line of code loads data into the 'CmsDataSet.Person' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter1.Fill(CmsDataSet1.Patient)
        Draggable1.Start()
        Draggable2.Start()

        If Category = Patient.CAT_CARRIER Then
            Label1.Text = "Patient Registration"
            gbPatientInfo.Location = New Point(12, 70)
            gbCarrier.Hide()
            Height = Height - 100
            'cbStatus.Items.Add("Fully Recovered")
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
            Dim dt As cmsDataSet.PatientDataTable = Patient.List(CmsDataSet1.Patient)


            Dim list = New AutoCompleteStringCollection()

            For Each dataRow As cmsDataSet.PatientRow In dt.Rows
                list.Add(dataRow.fullname)
            Next

            txtCarrier.AutoCompleteCustomSource = list

        End If

        Dim hh_dt As New cmsDataSet.HouseholdDataTable
        Dim hh_list = New AutoCompleteStringCollection()
        HouseholdTableAdapter.Fill(hh_dt)
        For Each dataRow As cmsDataSet.HouseholdRow In hh_dt.Rows
            hh_list.Add(dataRow.hh_num)
        Next

        txtHouseHold.AutoCompleteCustomSource = hh_list

        'cbStatus.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not CheckValid() Then
            Exit Sub
        End If


        SetToPatient()

        If action = "add" Then
            patient.Insert()
        Else
            patient.Update(patient.ID)
        End If

        SetToPatientStatus()
        patientStatus.Insert()





        Dim patientRow As cmsDataSet.PatientRow



        If Category = Patient.CAT_CONTACT_TRACE Then
            patientRow = Patient.GetByName(Patient.CAT_CARRIER, txtCarrier.Text)

            If patientRow IsNot Nothing Then
                Dim carrier As New Carrier
                carrier.CarrierID = patientRow.p_id
                carrier.ContactTraceID = patient.LastId
                carrier.Insert()
            End If


        End If

        'If cbRemarks.Text = "Positive" Then
        '    details = New PersonDetails(PersonDetails.DETAILS_POSITIVE)
        '    details.PersonID = personRow.p_id
        '    details.Insert()
        'ElseIf cbRemarks.Text = "Negative" Then
        '    details = New PersonDetails(PersonDetails.DETAILS_NEGATIVE)
        '    details.PersonID = personRow.p_id
        '    details.Insert()
        'End If

        If PatientStatus.LastId <> -1 Then
            Dim quarantine As New Quarantine
            quarantine.MId = PatientStatus.LastId
            quarantine.IId = patientStatus.IsolationFacilityId
            quarantine.Remarks = cbStatus.Text
            quarantine.StartDate = Now

            If cbStatus.Text = "Self-Quarantine(7 days)" Then
                quarantine.EndDate = DateAdd("d", 7, quarantine.StartDate)
                quarantine.Insert()
            ElseIf cbStatus.Text = "Self-Quarantine(14 days)" Then
                quarantine.EndDate = DateAdd("d", 14, quarantine.StartDate)
                quarantine.Insert()
            ElseIf cbStatus.Text = "Quarantine in Isolation Area (1 month)" Then
                quarantine.EndDate = DateAdd("d", 30, quarantine.StartDate)
                quarantine.Insert()
            ElseIf cbStatus.Text = "Quarantine in Isolation Area (2 months)" Then
                quarantine.EndDate = DateAdd("d", 60, quarantine.StartDate)
                quarantine.Insert()
            ElseIf cbStatus.Text = "Quarantine in Isolation Area (3 months)" Then
                quarantine.EndDate = DateAdd("d", 180, quarantine.StartDate)
                quarantine.Insert()
            End If




        End If

        DialogResult = DialogResult.OK
    End Sub

    Private Sub SetToPatient()
        patient.Category = Category
        patient.Firstname = txtFirstname.Text
        patient.Middlename = txtMiddlename.Text
        patient.Lastname = txtLastname.Text
        patient.Gender = cbGender.Text
        Dim drv As DataRowView = HouseholdBindingSource.Current
        Dim hhRow As cmsDataSet.HouseholdRow = drv.Row
        patient.HouseHoldId = hhRow.h_id
        patient.Purok = cbPurok.Text
        patient.Barangay = cbBarangay.Text
        patient.City = txtCity.Text
        patient.Province = txtProvince.Text
        Date.TryParse(cbMonth.Text & " " & cbDay.Text & " " & cbYear.Text, patient.Birthdate)
        patient.Phone = txtPhone.Text

    End Sub

    Private Sub SetToPatientStatus()
        If action = "add" Then
            patientStatus.PatientId = patient.LastId
        Else
            patientStatus.PatientId = patient.ID
        End If

        Dim drv As DataRowView = IsolationfacilitiesBindingSource.Current
        Dim ifRow As cmsDataSet.Isolation_facilitiesRow = drv.Row

        patientStatus.NurseId = -1
        patientStatus.IsolationFacilityId = ifRow.i_id
        patientStatus.Findings = ""
        patientStatus.Status = cbStatus.Text
        patientStatus.Remarks = cbRemarks.Text
        patientStatus.Findings = "None"

        If rbPUI.Checked Then
            patientStatus.Findings = "PUI"
        ElseIf rbPUM.Checked Then
            patientStatus.Findings = "PUM"
        End If

        Dim list As New List(Of String)
        For Each item As String In chkIllnesses.CheckedItems
            list.Add(item)
        Next

        patientStatus.Illnesses = String.Join(",", list)
        patientStatus.Temperature = txtTemperature.Text

    End Sub

    Private Function CheckValid()
        If txtHouseHold.Text.Trim() = "" Then
            MessageBox.Show("Please enter a household number")
            Return False
        ElseIf Household.GetByNumber(txtHouseHold.Text) Is Nothing Then
            Dim result As DialogResult = MessageBox.Show("Household number hasn't been registered. Do you want to register household?", "Household", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                HouseholdRegister()
            End If

            Return False
        End If


        If Category = Patient.CAT_CONTACT_TRACE Then
            Dim carrierRow As cmsDataSet.PatientRow = Nothing

            For Each personRow As cmsDataSet.PatientRow In CmsDataSet1.Patient.Rows
                If personRow.fullname = txtCarrier.Text Then
                    carrierRow = personRow
                End If
            Next

            'If carrierRow Is Nothing Then
            '    MessageBox.Show("Please input an existing Carrier")
            '    Return False
            'End If

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
            MessageBox.Show("Please select a Quarantine.")
            Return False
        End If



        Return True
    End Function

    Public Sub SetPerson(dataRow As cmsDataSet.PatientRow)
        patient.ID = dataRow.p_id
        patient.Category = dataRow.category

        txtFirstname.Text = dataRow.firstname
        txtMiddlename.Text = If(Not dataRow.IsmiddlenameNull, dataRow.middlename, "")
        txtLastname.Text = dataRow.lastname
        cbGender.Text = dataRow.gender
        txtHouseHold.Text = Household.GetById(dataRow.h_id).HHNumber
        cbIsolationFacility.Text = IsolationFacility.GetById(dataRow.i_id).Area
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
        txtTemperature.Text = dataRow.temp
        cbRemarks.Text = dataRow.remarks
        cbStatus.Text = dataRow.status


        If dataRow.findings = "PUI" Then
            rbPUI.Checked = True
        ElseIf dataRow.findings = "PUM" Then
            rbPUM.Checked = True
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        HouseholdRegister()
    End Sub


    Private Sub HouseholdRegister()
        Dim householdRegister As New HouseholdRegister()
        householdRegister.txtHouseholdNum.Text = txtHouseHold.Text

        Dim result As DialogResult = householdRegister.ShowDialog()

        If result = DialogResult.OK Then
            txtHouseHold.Text = householdRegister.txtHouseholdNum.Text
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class