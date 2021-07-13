<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuarantine
    Inherits System.Windows.Forms.UserControl

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CmsDataSet = New CMS.cmsDataSet()
        Me.QuarantineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuarantineTableAdapter = New CMS.cmsDataSetTableAdapters.QuarantineTableAdapter()
        Me.dgvPUI = New System.Windows.Forms.DataGridView()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarantineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPUI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 64)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(210, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Person's Under Quarantine (PUQ)"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 68)
        Me.Panel2.TabIndex = 14
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
        'CmsDataSet
        '
        Me.CmsDataSet.DataSetName = "cmsDataSet"
        Me.CmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuarantineBindingSource
        '
        Me.QuarantineBindingSource.DataMember = "Quarantine"
        Me.QuarantineBindingSource.DataSource = Me.CmsDataSet
        '
        'QuarantineTableAdapter
        '
        Me.QuarantineTableAdapter.ClearBeforeFill = True
        '
        'dgvPUI
        '
        Me.dgvPUI.AutoGenerateColumns = False
        Me.dgvPUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPUI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullnameDataGridViewTextBoxColumn, Me.DaysDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.EnddateDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.dgvPUI.DataSource = Me.QuarantineBindingSource
        Me.dgvPUI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPUI.Location = New System.Drawing.Point(0, 132)
        Me.dgvPUI.Name = "dgvPUI"
        Me.dgvPUI.Size = New System.Drawing.Size(780, 543)
        Me.dgvPUI.TabIndex = 15
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "Fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.Width = 150
        '
        'DaysDataGridViewTextBoxColumn
        '
        Me.DaysDataGridViewTextBoxColumn.DataPropertyName = "days"
        Me.DaysDataGridViewTextBoxColumn.HeaderText = "Days"
        Me.DaysDataGridViewTextBoxColumn.Name = "DaysDataGridViewTextBoxColumn"
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        Me.StartdateDataGridViewTextBoxColumn.Width = 150
        '
        'EnddateDataGridViewTextBoxColumn
        '
        Me.EnddateDataGridViewTextBoxColumn.DataPropertyName = "end_date"
        Me.EnddateDataGridViewTextBoxColumn.HeaderText = "End Date"
        Me.EnddateDataGridViewTextBoxColumn.Name = "EnddateDataGridViewTextBoxColumn"
        Me.EnddateDataGridViewTextBoxColumn.Width = 150
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'frmQuarantine
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.dgvPUI)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmQuarantine"
        Me.Size = New System.Drawing.Size(780, 675)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarantineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents QuarantineBindingSource As BindingSource
    Friend WithEvents CmsDataSet As cmsDataSet
    Friend WithEvents QuarantineTableAdapter As cmsDataSetTableAdapters.QuarantineTableAdapter
    Friend WithEvents dgvPUI As DataGridView
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
