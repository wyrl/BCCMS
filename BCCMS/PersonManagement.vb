Public Class PersonManagement

    'Public Property Title As String
    Private _category As String
    Public Property Category() As String
        Get
            Return _category
        End Get

        Set(value As String)
            _category = value

            If Category = Person.CAT_CARRIER Then
                Label1.Text = "Patient's Record"
                btnAddPerson.Text = "Add Patient"
            Else
                Label1.Text = "Contact Tracing Record"
                btnAddPerson.Text = "Contact Trace"
            End If

        End Set
    End Property


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPerson.Click
        Dim patientRegister As New frmPersonRegister
        patientRegister.Category = Category
        Dim result = patientRegister.ShowDialog()
        If result = MsgBoxResult.Ok Then
            RefreshData()
        End If
    End Sub

    Private Sub Patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim patient As New Person

        'patient.Firstname = "Maria"
        'patient.Lastname = "Esparas"
        'patient.PatientCase = "Person Under Investigation"
        'patient.Age = 17
        'patient.ContactNumber = "09123456789"
        'patient.Remarks = "Negative"

        'PatientBindingSource.Add(patient)




    End Sub

    Public Sub RefreshData()

        Person.Search(CmsDataSet.Person, Category, txtSearch.Text)
        'Person.ListByCategory(CmsDataSet.Person, "Carrier")
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvPatients.Rows.Count > 0 Then
            Dim dataRowView As DataRowView = PersonBindingSource.Current
            Dim dataRow As cmsDataSet.PersonRow = dataRowView.Row

            'Console.WriteLine(dataRow.lastname)

            Dim personRegister As New frmPersonRegister
            personRegister.Category = Category
            personRegister.action = "edit"
            Console.WriteLine("Status: " & dataRow.status)
            personRegister.SetPerson(dataRow)
            personRegister.ShowDialog()

            RefreshData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvPatients.Rows.Count > 0 Then
            Dim result = MessageBox.Show("Are you sure do you want to delete?", "Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim dataRowView As DataRowView = PersonBindingSource.Current
                Dim dataRow As cmsDataSet.PersonRow = dataRowView.Row

                Person.Delete(dataRow.p_id)
            End If

            RefreshData()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshData()
    End Sub
End Class
