<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HouseholdRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtHouseholdNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cbPurok = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbBarangay = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFamilyName = New System.Windows.Forms.TextBox()
        Me.CmsDataSet1 = New CMS.cmsDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Draggable1 = New Mimobibo.Draggable(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.CmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(681, 64)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(681, 64)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Household Register"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageIndex = 0
        Me.Button1.Location = New System.Drawing.Point(629, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(28, 94)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(196, 30)
        Me.Label43.TabIndex = 50
        Me.Label43.Text = "Household number:"
        '
        'txtHouseholdNum
        '
        Me.txtHouseholdNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtHouseholdNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtHouseholdNum.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseholdNum.Location = New System.Drawing.Point(33, 127)
        Me.txtHouseholdNum.Name = "txtHouseholdNum"
        Me.txtHouseholdNum.Size = New System.Drawing.Size(294, 35)
        Me.txtHouseholdNum.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(221, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 21)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Barangay"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(342, 227)
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(152, 38)
        Me.txtCity.TabIndex = 53
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(31, 183)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 30)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Address:"
        '
        'txtProvince
        '
        Me.txtProvince.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(499, 228)
        Me.txtProvince.Multiline = True
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(143, 38)
        Me.txtProvince.TabIndex = 54
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(395, 269)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 21)
        Me.Label30.TabIndex = 58
        Me.Label30.Text = "City"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(81, 268)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(51, 21)
        Me.Label37.TabIndex = 60
        Me.Label37.Text = "Purok"
        '
        'cbPurok
        '
        Me.cbPurok.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPurok.FormattingEnabled = True
        Me.cbPurok.Location = New System.Drawing.Point(33, 227)
        Me.cbPurok.Name = "cbPurok"
        Me.cbPurok.Size = New System.Drawing.Size(150, 38)
        Me.cbPurok.TabIndex = 51
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(536, 269)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 21)
        Me.Label31.TabIndex = 59
        Me.Label31.Text = "Province"
        '
        'cbBarangay
        '
        Me.cbBarangay.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBarangay.FormattingEnabled = True
        Me.cbBarangay.Items.AddRange(New Object() {"Quisol", ""})
        Me.cbBarangay.Location = New System.Drawing.Point(188, 227)
        Me.cbBarangay.Name = "cbBarangay"
        Me.cbBarangay.Size = New System.Drawing.Size(150, 38)
        Me.cbBarangay.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 30)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Family Name:"
        '
        'txtFamilyName
        '
        Me.txtFamilyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFamilyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFamilyName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamilyName.Location = New System.Drawing.Point(347, 127)
        Me.txtFamilyName.Name = "txtFamilyName"
        Me.txtFamilyName.Size = New System.Drawing.Size(294, 35)
        Me.txtFamilyName.TabIndex = 62
        '
        'CmsDataSet1
        '
        Me.CmsDataSet1.DataSetName = "cmsDataSet"
        Me.CmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(508, 337)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 49)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(370, 337)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 49)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Draggable1
        '
        Me.Draggable1.TargetControl = Me.Label1
        Me.Draggable1.WindowForm = Me
        '
        'HouseholdRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 430)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFamilyName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.cbPurok)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cbBarangay)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.txtHouseholdNum)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HouseholdRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HouseholdRegister"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents cbPurok As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cbBarangay As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFamilyName As TextBox
    Friend WithEvents CmsDataSet1 As cmsDataSet
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Public WithEvents txtHouseholdNum As TextBox
    Friend WithEvents Draggable1 As Mimobibo.Draggable
End Class
