<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnContactTracing = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnPatients = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Draggable1 = New Mimobibo.Draggable(Me.components)
        Me.Draggable2 = New Mimobibo.Draggable(Me.components)
        Me.Headline1 = New CMS.Headline()
        Me.PersonManagement1 = New CMS.PatientManagement()
        Me.Reports1 = New CMS.Reports()
        Me.Panel1.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1024, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(367, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " Covid Monitoring System"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(972, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "outline_close_white_48dp.png")
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.White
        Me.pnlSidebar.Controls.Add(Me.PictureBox2)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnContactTracing)
        Me.pnlSidebar.Controls.Add(Me.Button5)
        Me.pnlSidebar.Controls.Add(Me.btnPatients)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.PictureBox1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 64)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.pnlSidebar.Size = New System.Drawing.Size(210, 736)
        Me.pnlSidebar.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(210, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(10, 416)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(20, 10, 3, 3)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnReports.Size = New System.Drawing.Size(190, 66)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnContactTracing
        '
        Me.btnContactTracing.BackColor = System.Drawing.Color.White
        Me.btnContactTracing.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnContactTracing.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactTracing.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnContactTracing.Location = New System.Drawing.Point(10, 350)
        Me.btnContactTracing.Margin = New System.Windows.Forms.Padding(20, 10, 3, 3)
        Me.btnContactTracing.Name = "btnContactTracing"
        Me.btnContactTracing.Size = New System.Drawing.Size(190, 66)
        Me.btnContactTracing.TabIndex = 6
        Me.btnContactTracing.Text = "Contact Tracing"
        Me.btnContactTracing.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(10, 660)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 66)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnPatients
        '
        Me.btnPatients.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPatients.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPatients.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatients.ForeColor = System.Drawing.Color.White
        Me.btnPatients.Location = New System.Drawing.Point(10, 284)
        Me.btnPatients.Margin = New System.Windows.Forms.Padding(20, 10, 3, 3)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(190, 66)
        Me.btnPatients.TabIndex = 3
        Me.btnPatients.Text = "Patients"
        Me.btnPatients.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.White
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDashboard.Location = New System.Drawing.Point(10, 218)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(20, 10, 3, 3)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(190, 66)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Headline"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CMS.My.Resources.Resources.HubPages_1x1_CommunicableDiseases_a9cuob
        Me.PictureBox1.Location = New System.Drawing.Point(10, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        'Headline1
        '
        Me.Headline1.BackColor = System.Drawing.Color.Transparent
        Me.Headline1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Headline1.Location = New System.Drawing.Point(210, 64)
        Me.Headline1.Name = "Headline1"
        Me.Headline1.Size = New System.Drawing.Size(814, 736)
        Me.Headline1.TabIndex = 5
        '
        'PersonManagement1
        '
        Me.PersonManagement1.Category = Nothing
        Me.PersonManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonManagement1.Location = New System.Drawing.Point(210, 64)
        Me.PersonManagement1.Name = "PersonManagement1"
        Me.PersonManagement1.Size = New System.Drawing.Size(814, 736)
        Me.PersonManagement1.TabIndex = 6
        '
        'Reports1
        '
        Me.Reports1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Reports1.Location = New System.Drawing.Point(210, 64)
        Me.Reports1.Name = "Reports1"
        Me.Reports1.Size = New System.Drawing.Size(814, 736)
        Me.Reports1.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 800)
        Me.Controls.Add(Me.Headline1)
        Me.Controls.Add(Me.Reports1)
        Me.Controls.Add(Me.PersonManagement1)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnPatients As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Draggable1 As Mimobibo.Draggable
    Friend WithEvents Draggable2 As Mimobibo.Draggable
    Friend WithEvents btnContactTracing As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Headline1 As Headline
    Friend WithEvents PersonManagement1 As PatientManagement
    Friend WithEvents Reports1 As Reports
End Class
