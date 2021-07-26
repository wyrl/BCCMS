<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientRegister))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPurok = New System.Windows.Forms.ComboBox()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbBarangay = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbRemarks = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkIllnesses = New System.Windows.Forms.CheckedListBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.txtCarrier = New System.Windows.Forms.TextBox()
        Me.gbPatientInfo = New System.Windows.Forms.GroupBox()
        Me.cbIsolationFacility = New System.Windows.Forms.ComboBox()
        Me.IsolationfacilitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmsDataSet1 = New CMS.cmsDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHouseHold = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCase = New System.Windows.Forms.Label()
        Me.rbPUM = New System.Windows.Forms.RadioButton()
        Me.rbPUI = New System.Windows.Forms.RadioButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.HouseholdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbCarrier = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Draggable1 = New Mimobibo.Draggable(Me.components)
        Me.Draggable2 = New Mimobibo.Draggable(Me.components)
        Me.PatientTableAdapter1 = New CMS.cmsDataSetTableAdapters.PatientTableAdapter()
        Me.HouseholdTableAdapter = New CMS.cmsDataSetTableAdapters.HouseholdTableAdapter()
        Me.Isolation_facilitiesTableAdapter = New CMS.cmsDataSetTableAdapters.Isolation_facilitiesTableAdapter()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbPatientInfo.SuspendLayout()
        CType(Me.IsolationfacilitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseholdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCarrier.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 64)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(282, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient Registration"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(792, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "outline_close_white_48dp.png")
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(155, 127)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(201, 35)
        Me.txtFirstname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(358, 127)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(201, 35)
        Me.txtMiddlename.TabIndex = 3
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(563, 127)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(201, 35)
        Me.txtLastname.TabIndex = 4
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(621, 207)
        Me.txtProvince.Multiline = True
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(143, 38)
        Me.txtProvince.TabIndex = 8
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(464, 206)
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(152, 38)
        Me.txtCity.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(343, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 21)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Barangay"
        '
        'cbPurok
        '
        Me.cbPurok.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPurok.FormattingEnabled = True
        Me.cbPurok.Location = New System.Drawing.Point(155, 206)
        Me.cbPurok.Name = "cbPurok"
        Me.cbPurok.Size = New System.Drawing.Size(150, 38)
        Me.cbPurok.TabIndex = 5
        '
        'cbMonth
        '
        Me.cbMonth.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(155, 290)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(160, 38)
        Me.cbMonth.TabIndex = 9
        '
        'cbDay
        '
        Me.cbDay.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbDay.Location = New System.Drawing.Point(321, 289)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(61, 38)
        Me.cbDay.TabIndex = 10
        '
        'cbYear
        '
        Me.cbYear.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cbYear.Location = New System.Drawing.Point(386, 289)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(110, 38)
        Me.cbYear.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(502, 578)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 49)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(640, 578)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 49)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(204, 331)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 21)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Month"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(335, 331)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 21)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Day"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(420, 331)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 21)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Year"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(189, 248)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 21)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Purok"
        '
        'cbBarangay
        '
        Me.cbBarangay.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBarangay.FormattingEnabled = True
        Me.cbBarangay.Items.AddRange(New Object() {"Quisol", ""})
        Me.cbBarangay.Location = New System.Drawing.Point(310, 206)
        Me.cbBarangay.Name = "cbBarangay"
        Me.cbBarangay.Size = New System.Drawing.Size(150, 38)
        Me.cbBarangay.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(597, 289)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(167, 38)
        Me.txtPhone.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(647, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 21)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Phone #"
        '
        'cbRemarks
        '
        Me.cbRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRemarks.DropDownWidth = 300
        Me.cbRemarks.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRemarks.FormattingEnabled = True
        Me.cbRemarks.Items.AddRange(New Object() {"Positive", "Negative"})
        Me.cbRemarks.Location = New System.Drawing.Point(149, 378)
        Me.cbRemarks.Name = "cbRemarks"
        Me.cbRemarks.Size = New System.Drawing.Size(192, 38)
        Me.cbRemarks.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(47, 457)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 30)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Ilnesses:"
        '
        'chkIllnesses
        '
        Me.chkIllnesses.CheckOnClick = True
        Me.chkIllnesses.ColumnWidth = 200
        Me.chkIllnesses.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIllnesses.FormattingEnabled = True
        Me.chkIllnesses.Items.AddRange(New Object() {"Cold", "Fever", "Cough", "Headache", "Stomache", "Heartache", "Dizziness", "Shortness of Breathing", "Backache"})
        Me.chkIllnesses.Location = New System.Drawing.Point(149, 457)
        Me.chkIllnesses.MultiColumn = True
        Me.chkIllnesses.Name = "chkIllnesses"
        Me.chkIllnesses.Size = New System.Drawing.Size(615, 100)
        Me.chkIllnesses.TabIndex = 16
        '
        'txtTemperature
        '
        Me.txtTemperature.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.Location = New System.Drawing.Point(551, 378)
        Me.txtTemperature.Multiline = True
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(213, 38)
        Me.txtTemperature.TabIndex = 15
        '
        'txtCarrier
        '
        Me.txtCarrier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCarrier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCarrier.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarrier.Location = New System.Drawing.Point(155, 34)
        Me.txtCarrier.Name = "txtCarrier"
        Me.txtCarrier.Size = New System.Drawing.Size(410, 35)
        Me.txtCarrier.TabIndex = 41
        '
        'gbPatientInfo
        '
        Me.gbPatientInfo.Controls.Add(Me.Label10)
        Me.gbPatientInfo.Controls.Add(Me.cbStatus)
        Me.gbPatientInfo.Controls.Add(Me.cbIsolationFacility)
        Me.gbPatientInfo.Controls.Add(Me.Label8)
        Me.gbPatientInfo.Controls.Add(Me.txtHouseHold)
        Me.gbPatientInfo.Controls.Add(Me.Label7)
        Me.gbPatientInfo.Controls.Add(Me.Label6)
        Me.gbPatientInfo.Controls.Add(Me.LinkLabel1)
        Me.gbPatientInfo.Controls.Add(Me.Label5)
        Me.gbPatientInfo.Controls.Add(Me.Label2)
        Me.gbPatientInfo.Controls.Add(Me.cbGender)
        Me.gbPatientInfo.Controls.Add(Me.Label4)
        Me.gbPatientInfo.Controls.Add(Me.lblCase)
        Me.gbPatientInfo.Controls.Add(Me.rbPUM)
        Me.gbPatientInfo.Controls.Add(Me.rbPUI)
        Me.gbPatientInfo.Controls.Add(Me.txtFirstname)
        Me.gbPatientInfo.Controls.Add(Me.Label3)
        Me.gbPatientInfo.Controls.Add(Me.Label23)
        Me.gbPatientInfo.Controls.Add(Me.txtMiddlename)
        Me.gbPatientInfo.Controls.Add(Me.txtTemperature)
        Me.gbPatientInfo.Controls.Add(Me.txtLastname)
        Me.gbPatientInfo.Controls.Add(Me.Label26)
        Me.gbPatientInfo.Controls.Add(Me.chkIllnesses)
        Me.gbPatientInfo.Controls.Add(Me.Label41)
        Me.gbPatientInfo.Controls.Add(Me.Label20)
        Me.gbPatientInfo.Controls.Add(Me.Label9)
        Me.gbPatientInfo.Controls.Add(Me.Label27)
        Me.gbPatientInfo.Controls.Add(Me.Label28)
        Me.gbPatientInfo.Controls.Add(Me.cbRemarks)
        Me.gbPatientInfo.Controls.Add(Me.txtCity)
        Me.gbPatientInfo.Controls.Add(Me.Label29)
        Me.gbPatientInfo.Controls.Add(Me.txtProvince)
        Me.gbPatientInfo.Controls.Add(Me.Label30)
        Me.gbPatientInfo.Controls.Add(Me.Label17)
        Me.gbPatientInfo.Controls.Add(Me.Label37)
        Me.gbPatientInfo.Controls.Add(Me.txtPhone)
        Me.gbPatientInfo.Controls.Add(Me.cbPurok)
        Me.gbPatientInfo.Controls.Add(Me.Label31)
        Me.gbPatientInfo.Controls.Add(Me.Label16)
        Me.gbPatientInfo.Controls.Add(Me.Label36)
        Me.gbPatientInfo.Controls.Add(Me.cbBarangay)
        Me.gbPatientInfo.Controls.Add(Me.cbMonth)
        Me.gbPatientInfo.Controls.Add(Me.Label35)
        Me.gbPatientInfo.Controls.Add(Me.Label15)
        Me.gbPatientInfo.Controls.Add(Me.cbDay)
        Me.gbPatientInfo.Controls.Add(Me.Label34)
        Me.gbPatientInfo.Controls.Add(Me.Label14)
        Me.gbPatientInfo.Controls.Add(Me.cbYear)
        Me.gbPatientInfo.Controls.Add(Me.Label13)
        Me.gbPatientInfo.Controls.Add(Me.btnCancel)
        Me.gbPatientInfo.Controls.Add(Me.btnSave)
        Me.gbPatientInfo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPatientInfo.Location = New System.Drawing.Point(12, 171)
        Me.gbPatientInfo.Name = "gbPatientInfo"
        Me.gbPatientInfo.Size = New System.Drawing.Size(808, 671)
        Me.gbPatientInfo.TabIndex = 48
        Me.gbPatientInfo.TabStop = False
        Me.gbPatientInfo.Text = "Patient Info"
        '
        'cbIsolationFacility
        '
        Me.cbIsolationFacility.DataSource = Me.IsolationfacilitiesBindingSource
        Me.cbIsolationFacility.DisplayMember = "area"
        Me.cbIsolationFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIsolationFacility.DropDownWidth = 500
        Me.cbIsolationFacility.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIsolationFacility.FormattingEnabled = True
        Me.cbIsolationFacility.Location = New System.Drawing.Point(474, 55)
        Me.cbIsolationFacility.Name = "cbIsolationFacility"
        Me.cbIsolationFacility.Size = New System.Drawing.Size(290, 38)
        Me.cbIsolationFacility.TabIndex = 69
        Me.cbIsolationFacility.ValueMember = "i_id"
        '
        'IsolationfacilitiesBindingSource
        '
        Me.IsolationfacilitiesBindingSource.DataMember = "Isolation_facilities"
        Me.IsolationfacilitiesBindingSource.DataSource = Me.CmsDataSet1
        '
        'CmsDataSet1
        '
        Me.CmsDataSet1.DataSetName = "cmsDataSet"
        Me.CmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(469, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 30)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Isolation Facility:"
        '
        'txtHouseHold
        '
        Me.txtHouseHold.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtHouseHold.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtHouseHold.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseHold.Location = New System.Drawing.Point(155, 58)
        Me.txtHouseHold.Name = "txtHouseHold"
        Me.txtHouseHold.Size = New System.Drawing.Size(263, 35)
        Me.txtHouseHold.TabIndex = 64
        Me.txtHouseHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(150, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 30)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Household #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(309, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "to register."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(275, 95)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 20)
        Me.LinkLabel1.TabIndex = 61
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "If not exists, click"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Gender"
        '
        'cbGender
        '
        Me.cbGender.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(502, 289)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(89, 38)
        Me.cbGender.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 21)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Swab Test Result"
        '
        'lblCase
        '
        Me.lblCase.AutoSize = True
        Me.lblCase.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCase.Location = New System.Drawing.Point(75, 583)
        Me.lblCase.Name = "lblCase"
        Me.lblCase.Size = New System.Drawing.Size(62, 30)
        Me.lblCase.TabIndex = 45
        Me.lblCase.Text = "Case:"
        Me.lblCase.Visible = False
        '
        'rbPUM
        '
        Me.rbPUM.AutoSize = True
        Me.rbPUM.Location = New System.Drawing.Point(262, 585)
        Me.rbPUM.Name = "rbPUM"
        Me.rbPUM.Size = New System.Drawing.Size(76, 34)
        Me.rbPUM.TabIndex = 42
        Me.rbPUM.TabStop = True
        Me.rbPUM.Text = "PUM"
        Me.rbPUM.UseVisualStyleBackColor = True
        '
        'rbPUI
        '
        Me.rbPUI.AutoSize = True
        Me.rbPUI.Location = New System.Drawing.Point(166, 585)
        Me.rbPUI.Name = "rbPUI"
        Me.rbPUI.Size = New System.Drawing.Size(63, 34)
        Me.rbPUI.TabIndex = 41
        Me.rbPUI.TabStop = True
        Me.rbPUI.Text = "PUI"
        Me.rbPUI.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(212, 165)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 21)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Firstname"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(412, 165)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 21)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Middlename"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(617, 419)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(97, 21)
        Me.Label41.TabIndex = 39
        Me.Label41.Text = "Temperature"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(625, 165)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 21)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Lastname"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(343, 248)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 21)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "Barangay"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(57, 209)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 30)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Address:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(517, 248)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 21)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = "City"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(189, 248)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(51, 21)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = "Purok"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(658, 248)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 21)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Province"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(420, 331)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 21)
        Me.Label36.TabIndex = 29
        Me.Label36.Text = "Year"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(335, 331)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 21)
        Me.Label35.TabIndex = 28
        Me.Label35.Text = "Day"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(204, 331)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 21)
        Me.Label34.TabIndex = 27
        Me.Label34.Text = "Month"
        '
        'HouseholdBindingSource
        '
        Me.HouseholdBindingSource.DataMember = "Household"
        Me.HouseholdBindingSource.DataSource = Me.CmsDataSet1
        '
        'gbCarrier
        '
        Me.gbCarrier.Controls.Add(Me.Label43)
        Me.gbCarrier.Controls.Add(Me.txtCarrier)
        Me.gbCarrier.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCarrier.Location = New System.Drawing.Point(12, 70)
        Me.gbCarrier.Name = "gbCarrier"
        Me.gbCarrier.Size = New System.Drawing.Size(808, 85)
        Me.gbCarrier.TabIndex = 49
        Me.gbCarrier.TabStop = False
        Me.gbCarrier.Text = "Carrier"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(75, 36)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(74, 30)
        Me.Label43.TabIndex = 48
        Me.Label43.Text = "Name:"
        '
        'Draggable1
        '
        Me.Draggable1.TargetControl = Me.Panel1
        Me.Draggable1.WindowForm = Me
        '
        'Draggable2
        '
        Me.Draggable2.TargetControl = Me.Label1
        Me.Draggable2.WindowForm = Me
        '
        'PatientTableAdapter1
        '
        Me.PatientTableAdapter1.ClearBeforeFill = True
        '
        'HouseholdTableAdapter
        '
        Me.HouseholdTableAdapter.ClearBeforeFill = True
        '
        'Isolation_facilitiesTableAdapter
        '
        Me.Isolation_facilitiesTableAdapter.ClearBeforeFill = True
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.DropDownWidth = 500
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Self-Quarantine(7 days)", "Self-Quarantine(14 days)", "Quarantine in Isolation Area (1 month)", "Quarantine in Isolation Area (2 months)", "Quarantine in Isolation Area (3 months)", "Extended quarantine until further notice", "Recovered", "Death"})
        Me.cbStatus.Location = New System.Drawing.Point(345, 378)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(201, 38)
        Me.cbStatus.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(420, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 21)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Status"
        '
        'frmPatientRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 865)
        Me.Controls.Add(Me.gbCarrier)
        Me.Controls.Add(Me.gbPatientInfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPatientRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PatientRegister"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbPatientInfo.ResumeLayout(False)
        Me.gbPatientInfo.PerformLayout()
        CType(Me.IsolationfacilitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseholdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCarrier.ResumeLayout(False)
        Me.gbCarrier.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Draggable1 As Mimobibo.Draggable
    Friend WithEvents Draggable2 As Mimobibo.Draggable
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents cbPurok As System.Windows.Forms.ComboBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cbBarangay As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cbRemarks As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents chkIllnesses As CheckedListBox
    Friend WithEvents txtCarrier As TextBox
    Friend WithEvents gbCarrier As GroupBox
    Friend WithEvents Label43 As Label
    Friend WithEvents gbPatientInfo As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents rbPUM As RadioButton
    Friend WithEvents rbPUI As RadioButton
    Friend WithEvents lblCase As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents PatientTableAdapter1 As cmsDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents CmsDataSet1 As cmsDataSet
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents HouseholdBindingSource As BindingSource
    Friend WithEvents HouseholdTableAdapter As cmsDataSetTableAdapters.HouseholdTableAdapter
    Friend WithEvents txtHouseHold As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbIsolationFacility As ComboBox
    Friend WithEvents IsolationfacilitiesBindingSource As BindingSource
    Friend WithEvents Isolation_facilitiesTableAdapter As cmsDataSetTableAdapters.Isolation_facilitiesTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents cbStatus As ComboBox
End Class
