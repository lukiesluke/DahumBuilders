<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddProjectSetting
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
        Me.cbbProjectName = New System.Windows.Forms.ComboBox()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.btnAddLot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSqm = New System.Windows.Forms.TextBox()
        Me.txtTCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProjID = New System.Windows.Forms.Label()
        Me.ListViewProjectLot = New System.Windows.Forms.ListView()
        Me.ColumnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnTCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAutoID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddProject = New System.Windows.Forms.Button()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.txtProjectAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListViewProject = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbProjectName
        '
        Me.cbbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProjectName.FormattingEnabled = True
        Me.cbbProjectName.Location = New System.Drawing.Point(138, 20)
        Me.cbbProjectName.Name = "cbbProjectName"
        Me.cbbProjectName.Size = New System.Drawing.Size(266, 28)
        Me.cbbProjectName.TabIndex = 4
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(138, 57)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(54, 26)
        Me.txtBlock.TabIndex = 5
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(236, 59)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(54, 26)
        Me.txtLot.TabIndex = 6
        '
        'btnAddLot
        '
        Me.btnAddLot.Location = New System.Drawing.Point(422, 88)
        Me.btnAddLot.Name = "btnAddLot"
        Me.btnAddLot.Size = New System.Drawing.Size(109, 39)
        Me.btnAddLot.TabIndex = 9
        Me.btnAddLot.Text = "Add &Lot"
        Me.btnAddLot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Project Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Block"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lot"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SQM"
        '
        'txtSqm
        '
        Me.txtSqm.Location = New System.Drawing.Point(350, 59)
        Me.txtSqm.Name = "txtSqm"
        Me.txtSqm.Size = New System.Drawing.Size(54, 26)
        Me.txtSqm.TabIndex = 7
        '
        'txtTCP
        '
        Me.txtTCP.Location = New System.Drawing.Point(138, 94)
        Me.txtTCP.Name = "txtTCP"
        Me.txtTCP.Size = New System.Drawing.Size(266, 26)
        Me.txtTCP.TabIndex = 8
        Me.txtTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "TCP"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.69034!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.30966!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1408, 657)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblProjID)
        Me.Panel1.Controls.Add(Me.ListViewProjectLot)
        Me.Panel1.Controls.Add(Me.cbbProjectName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtBlock)
        Me.Panel1.Controls.Add(Me.txtTCP)
        Me.Panel1.Controls.Add(Me.txtLot)
        Me.Panel1.Controls.Add(Me.btnAddLot)
        Me.Panel1.Controls.Add(Me.txtSqm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(589, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 594)
        Me.Panel1.TabIndex = 0
        '
        'lblProjID
        '
        Me.lblProjID.AutoSize = True
        Me.lblProjID.Location = New System.Drawing.Point(411, 27)
        Me.lblProjID.Name = "lblProjID"
        Me.lblProjID.Size = New System.Drawing.Size(68, 20)
        Me.lblProjID.TabIndex = 16
        Me.lblProjID.Text = "lblProjID"
        Me.lblProjID.Visible = False
        '
        'ListViewProjectLot
        '
        Me.ListViewProjectLot.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnID, Me.ColumnName, Me.ColumnBlock, Me.ColumnLot, Me.ColumnSQM, Me.ColumnTCP, Me.ColumnStatus, Me.ColumnHeaderAutoID})
        Me.ListViewProjectLot.FullRowSelect = True
        Me.ListViewProjectLot.GridLines = True
        Me.ListViewProjectLot.Location = New System.Drawing.Point(22, 137)
        Me.ListViewProjectLot.Name = "ListViewProjectLot"
        Me.ListViewProjectLot.Size = New System.Drawing.Size(773, 433)
        Me.ListViewProjectLot.TabIndex = 10
        Me.ListViewProjectLot.UseCompatibleStateImageBehavior = False
        Me.ListViewProjectLot.View = System.Windows.Forms.View.Details
        '
        'ColumnID
        '
        Me.ColumnID.Text = "ID"
        Me.ColumnID.Width = 0
        '
        'ColumnName
        '
        Me.ColumnName.Text = "Project Name"
        Me.ColumnName.Width = 120
        '
        'ColumnBlock
        '
        Me.ColumnBlock.Text = "Block"
        Me.ColumnBlock.Width = 40
        '
        'ColumnLot
        '
        Me.ColumnLot.Text = "Lot"
        Me.ColumnLot.Width = 40
        '
        'ColumnSQM
        '
        Me.ColumnSQM.Text = "SQM"
        Me.ColumnSQM.Width = 40
        '
        'ColumnTCP
        '
        Me.ColumnTCP.Text = "TCP"
        Me.ColumnTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnTCP.Width = 100
        '
        'ColumnStatus
        '
        Me.ColumnStatus.Text = "Status"
        Me.ColumnStatus.Width = 80
        '
        'ColumnHeaderAutoID
        '
        Me.ColumnHeaderAutoID.Text = "AutoID"
        Me.ColumnHeaderAutoID.Width = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAddProject)
        Me.Panel2.Controls.Add(Me.txtProjectName)
        Me.Panel2.Controls.Add(Me.txtProjectAddress)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ListViewProject)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 594)
        Me.Panel2.TabIndex = 1
        '
        'btnAddProject
        '
        Me.btnAddProject.Location = New System.Drawing.Point(434, 137)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Size = New System.Drawing.Size(128, 39)
        Me.btnAddProject.TabIndex = 2
        Me.btnAddProject.Text = "&Add Project"
        Me.btnAddProject.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(143, 17)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(419, 26)
        Me.txtProjectName.TabIndex = 0
        '
        'txtProjectAddress
        '
        Me.txtProjectAddress.Location = New System.Drawing.Point(143, 55)
        Me.txtProjectAddress.Multiline = True
        Me.txtProjectAddress.Name = "txtProjectAddress"
        Me.txtProjectAddress.Size = New System.Drawing.Size(419, 76)
        Me.txtProjectAddress.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Project Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
        '
        'ListViewProject
        '
        Me.ListViewProject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderName, Me.ColumnHeaderAddress})
        Me.ListViewProject.FullRowSelect = True
        Me.ListViewProject.GridLines = True
        Me.ListViewProject.Location = New System.Drawing.Point(26, 182)
        Me.ListViewProject.Name = "ListViewProject"
        Me.ListViewProject.Size = New System.Drawing.Size(536, 388)
        Me.ListViewProject.TabIndex = 3
        Me.ListViewProject.UseCompatibleStateImageBehavior = False
        Me.ListViewProject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 0
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Project Name"
        Me.ColumnHeaderName.Width = 150
        '
        'ColumnHeaderAddress
        '
        Me.ColumnHeaderAddress.Text = "Address"
        Me.ColumnHeaderAddress.Width = 170
        '
        'FormAddProjectSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 690)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddProjectSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Project Setting"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbbProjectName As ComboBox
    Friend WithEvents txtBlock As TextBox
    Friend WithEvents txtLot As TextBox
    Friend WithEvents btnAddLot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSqm As TextBox
    Friend WithEvents txtTCP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents txtProjectAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListViewProject As ListView
    Friend WithEvents btnAddProject As Button
    Friend WithEvents ColumnHeaderName As ColumnHeader
    Friend WithEvents ColumnHeaderAddress As ColumnHeader
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ListViewProjectLot As ListView
    Friend WithEvents ColumnID As ColumnHeader
    Friend WithEvents ColumnName As ColumnHeader
    Friend WithEvents ColumnBlock As ColumnHeader
    Friend WithEvents ColumnLot As ColumnHeader
    Friend WithEvents ColumnSQM As ColumnHeader
    Friend WithEvents ColumnTCP As ColumnHeader
    Friend WithEvents ColumnStatus As ColumnHeader
    Friend WithEvents lblProjID As Label
    Friend WithEvents ColumnHeaderAutoID As ColumnHeader
End Class
