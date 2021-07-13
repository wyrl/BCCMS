<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPUM
    Inherits System.Windows.Forms.UserControl

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
        Me.dgvPUI = New System.Windows.Forms.DataGridView()
        Me.PUMdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmsDataSet = New CMS.cmsDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PUM_detailsTableAdapter = New CMS.cmsDataSetTableAdapters.PUM_detailsTableAdapter()
        Me._date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.illnesses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temperature = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPUI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUMdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPUI
        '
        Me.dgvPUI.AutoGenerateColumns = False
        Me.dgvPUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPUI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._date, Me.fullname, Me.address, Me.phone, Me.illnesses, Me.temperature, Me.remarks, Me.status})
        Me.dgvPUI.DataSource = Me.PUMdetailsBindingSource
        Me.dgvPUI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPUI.Location = New System.Drawing.Point(0, 132)
        Me.dgvPUI.Name = "dgvPUI"
        Me.dgvPUI.Size = New System.Drawing.Size(780, 543)
        Me.dgvPUI.TabIndex = 10
        '
        'PUMdetailsBindingSource
        '
        Me.PUMdetailsBindingSource.DataMember = "PUM_details"
        Me.PUMdetailsBindingSource.DataSource = Me.CmsDataSet
        '
        'CmsDataSet
        '
        Me.CmsDataSet.DataSetName = "cmsDataSet"
        Me.CmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(780, 64)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient Under Monitoring (PUM)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 64)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 68)
        Me.Panel2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(525, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 39)
        Me.TextBox1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.CMS.My.Resources.Resources.outline_search_black_48dp
        Me.PictureBox2.Location = New System.Drawing.Point(481, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PUM_detailsTableAdapter
        '
        Me.PUM_detailsTableAdapter.ClearBeforeFill = True
        '
        '_date
        '
        Me._date.DataPropertyName = "_date"
        Me._date.HeaderText = "Date"
        Me._date.Name = "_date"
        '
        'fullname
        '
        Me.fullname.DataPropertyName = "fullname"
        Me.fullname.HeaderText = "Fullname"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'phone
        '
        Me.phone.DataPropertyName = "phone"
        Me.phone.HeaderText = "Phone"
        Me.phone.Name = "phone"
        '
        'illnesses
        '
        Me.illnesses.DataPropertyName = "illnesses"
        Me.illnesses.HeaderText = "Illnesses"
        Me.illnesses.Name = "illnesses"
        '
        'temperature
        '
        Me.temperature.DataPropertyName = "temperature"
        Me.temperature.HeaderText = "Temperature"
        Me.temperature.Name = "temperature"
        '
        'remarks
        '
        Me.remarks.DataPropertyName = "remarks"
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'frmPUM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.dgvPUI)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPUM"
        Me.Size = New System.Drawing.Size(780, 675)
        CType(Me.dgvPUI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUMdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPUI As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PUMdetailsBindingSource As BindingSource
    Friend WithEvents CmsDataSet As cmsDataSet
    Friend WithEvents PUM_detailsTableAdapter As cmsDataSetTableAdapters.PUM_detailsTableAdapter
    Friend WithEvents _date As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents illnesses As DataGridViewTextBoxColumn
    Friend WithEvents temperature As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
