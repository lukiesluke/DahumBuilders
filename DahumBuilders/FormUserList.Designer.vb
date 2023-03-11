<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserList))
        Me.ListViewUser = New System.Windows.Forms.ListView()
        Me.ColumnHeaderId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderMiddleName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderGender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCivilStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDateOfBirth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderImageLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderMobile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderUserType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAgentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAgentContact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.labelRows = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMobileContact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCivilStatus = New System.Windows.Forms.TextBox()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1UserId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1Mobile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1PName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2BlockLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuDue = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbUserType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbbProjectList = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnStatementAccount = New System.Windows.Forms.Button()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.btnProfileInfo = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColumnHeaderPartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuUser.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.ContextMenuDue.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewUser
        '
        Me.ListViewUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderId, Me.ColumnHeaderLastName, Me.ColumnHeaderName, Me.ColumnHeaderMiddleName, Me.ColumnHeaderGender, Me.ColumnHeaderCivilStatus, Me.ColumnHeaderDateOfBirth, Me.ColumnHeaderAddress, Me.ColumnHeaderImageLocation, Me.ColumnHeaderMobile, Me.ColumnHeaderUserType, Me.ColumnHeaderAgentName, Me.ColumnHeaderAgentContact})
        Me.ListViewUser.ContextMenuStrip = Me.ContextMenuUser
        Me.ListViewUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListViewUser.FullRowSelect = True
        Me.ListViewUser.GridLines = True
        Me.ListViewUser.Location = New System.Drawing.Point(399, 64)
        Me.ListViewUser.Margin = New System.Windows.Forms.Padding(20, 1, 53, 13)
        Me.ListViewUser.Name = "ListViewUser"
        Me.ListViewUser.Size = New System.Drawing.Size(681, 294)
        Me.ListViewUser.TabIndex = 4
        Me.ListViewUser.UseCompatibleStateImageBehavior = False
        Me.ListViewUser.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderId
        '
        Me.ColumnHeaderId.Text = "ID"
        Me.ColumnHeaderId.Width = 0
        '
        'ColumnHeaderLastName
        '
        Me.ColumnHeaderLastName.Text = "Surname"
        Me.ColumnHeaderLastName.Width = 110
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Name"
        Me.ColumnHeaderName.Width = 100
        '
        'ColumnHeaderMiddleName
        '
        Me.ColumnHeaderMiddleName.Text = "Middle Name"
        Me.ColumnHeaderMiddleName.Width = 110
        '
        'ColumnHeaderGender
        '
        Me.ColumnHeaderGender.Text = "Gender"
        Me.ColumnHeaderGender.Width = 70
        '
        'ColumnHeaderCivilStatus
        '
        Me.ColumnHeaderCivilStatus.Text = "Civil Status"
        Me.ColumnHeaderCivilStatus.Width = 90
        '
        'ColumnHeaderDateOfBirth
        '
        Me.ColumnHeaderDateOfBirth.DisplayIndex = 7
        Me.ColumnHeaderDateOfBirth.Text = "Birth Date"
        Me.ColumnHeaderDateOfBirth.Width = 100
        '
        'ColumnHeaderAddress
        '
        Me.ColumnHeaderAddress.DisplayIndex = 6
        Me.ColumnHeaderAddress.Text = "Address"
        Me.ColumnHeaderAddress.Width = 150
        '
        'ColumnHeaderImageLocation
        '
        Me.ColumnHeaderImageLocation.Text = "Image Location"
        Me.ColumnHeaderImageLocation.Width = 0
        '
        'ColumnHeaderMobile
        '
        Me.ColumnHeaderMobile.Text = "Mobile"
        Me.ColumnHeaderMobile.Width = 80
        '
        'ColumnHeaderUserType
        '
        Me.ColumnHeaderUserType.Text = "Type"
        '
        'ColumnHeaderAgentName
        '
        Me.ColumnHeaderAgentName.Text = "Agent Name"
        Me.ColumnHeaderAgentName.Width = 120
        '
        'ColumnHeaderAgentContact
        '
        Me.ColumnHeaderAgentContact.Text = "Agent Mobile"
        Me.ColumnHeaderAgentContact.Width = 80
        '
        'ContextMenuUser
        '
        Me.ContextMenuUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteUserToolStripMenuItem})
        Me.ContextMenuUser.Name = "ContextMenuUser"
        Me.ContextMenuUser.Size = New System.Drawing.Size(134, 26)
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteUserToolStripMenuItem.Text = "&Delete User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(66, 11)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(156, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(352, 8)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 25)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Location = New System.Drawing.Point(225, 11)
        Me.ComboBoxSearch.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(125, 21)
        Me.ComboBoxSearch.TabIndex = 2
        '
        'labelRows
        '
        Me.labelRows.Location = New System.Drawing.Point(435, 16)
        Me.labelRows.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelRows.Name = "labelRows"
        Me.labelRows.Size = New System.Drawing.Size(71, 13)
        Me.labelRows.TabIndex = 5
        Me.labelRows.Text = "Rows:"
        Me.labelRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtMobileContact)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtCivilStatus)
        Me.Panel1.Controls.Add(Me.txtDateOfBirth)
        Me.Panel1.Controls.Add(Me.txtGender)
        Me.Panel1.Controls.Add(Me.txtSurname)
        Me.Panel1.Controls.Add(Me.txtMiddleName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 199)
        Me.Panel1.TabIndex = 7
        '
        'txtMobileContact
        '
        Me.txtMobileContact.Location = New System.Drawing.Point(83, 165)
        Me.txtMobileContact.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtMobileContact.Name = "txtMobileContact"
        Me.txtMobileContact.Size = New System.Drawing.Size(293, 20)
        Me.txtMobileContact.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 167)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Mobile"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(83, 143)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(293, 20)
        Me.txtAddress.TabIndex = 20
        '
        'txtCivilStatus
        '
        Me.txtCivilStatus.Location = New System.Drawing.Point(83, 121)
        Me.txtCivilStatus.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.Size = New System.Drawing.Size(145, 20)
        Me.txtCivilStatus.TabIndex = 19
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(83, 99)
        Me.txtDateOfBirth.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(145, 20)
        Me.txtDateOfBirth.TabIndex = 18
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(83, 77)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(145, 20)
        Me.txtGender.TabIndex = 17
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(83, 55)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(145, 20)
        Me.txtSurname.TabIndex = 16
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(83, 32)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(145, 20)
        Me.txtMiddleName.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(231, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(83, 10)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(145, 20)
        Me.txtName.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Civil Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListView1)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.ListViewUser)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1080, 487)
        Me.Panel5.TabIndex = 8
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1Id, Me.ColumnHeader1UserId, Me.ColumnHeader1Name, Me.ColumnHeader1Mobile, Me.ColumnHeaderPartNo, Me.ColumnHeader1Type, Me.ColumnHeader2DueDate, Me.ColumnHeader3Amount, Me.ColumnHeader1PName, Me.ColumnHeader2BlockLot})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuDue
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(399, 392)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(681, 95)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1Id
        '
        Me.ColumnHeader1Id.Text = "ID"
        Me.ColumnHeader1Id.Width = 0
        '
        'ColumnHeader1UserId
        '
        Me.ColumnHeader1UserId.Text = "UserID"
        Me.ColumnHeader1UserId.Width = 0
        '
        'ColumnHeader1Name
        '
        Me.ColumnHeader1Name.Text = "Name"
        Me.ColumnHeader1Name.Width = 150
        '
        'ColumnHeader1Mobile
        '
        Me.ColumnHeader1Mobile.Text = "Mobile"
        Me.ColumnHeader1Mobile.Width = 80
        '
        'ColumnHeader1Type
        '
        Me.ColumnHeader1Type.Text = "Type"
        '
        'ColumnHeader2DueDate
        '
        Me.ColumnHeader2DueDate.Text = "Due Date"
        Me.ColumnHeader2DueDate.Width = 80
        '
        'ColumnHeader3Amount
        '
        Me.ColumnHeader3Amount.Text = "Due Amount"
        Me.ColumnHeader3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3Amount.Width = 80
        '
        'ColumnHeader1PName
        '
        Me.ColumnHeader1PName.Text = "Project Name"
        Me.ColumnHeader1PName.Width = 150
        '
        'ColumnHeader2BlockLot
        '
        Me.ColumnHeader2BlockLot.Text = "Block and Lot"
        Me.ColumnHeader2BlockLot.Width = 120
        '
        'ContextMenuDue
        '
        Me.ContextMenuDue.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem})
        Me.ContextMenuDue.Name = "ContextMenuDue"
        Me.ContextMenuDue.Size = New System.Drawing.Size(100, 26)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(399, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(681, 34)
        Me.Panel2.TabIndex = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(116, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Due Date Collections"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Controls.Add(Me.cbbUserType)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.cbbProjectList)
        Me.Panel8.Controls.Add(Me.ComboBoxSearch)
        Me.Panel8.Controls.Add(Me.labelRows)
        Me.Panel8.Controls.Add(Me.btnSearch)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.txtSearch)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(399, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(681, 64)
        Me.Panel8.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(229, 38)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "User Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbUserType
        '
        Me.cbbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbUserType.FormattingEnabled = True
        Me.cbbUserType.Location = New System.Drawing.Point(289, 36)
        Me.cbbUserType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbbUserType.Name = "cbbUserType"
        Me.cbbUserType.Size = New System.Drawing.Size(142, 21)
        Me.cbbUserType.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Project"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbProjectList
        '
        Me.cbbProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProjectList.FormattingEnabled = True
        Me.cbbProjectList.Location = New System.Drawing.Point(66, 36)
        Me.cbbProjectList.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbbProjectList.Name = "cbbProjectList"
        Me.cbbProjectList.Size = New System.Drawing.Size(156, 21)
        Me.cbbProjectList.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(399, 487)
        Me.Panel6.TabIndex = 8
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.21951!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.78049!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnPayment, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnStatementAccount, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnUpdateRecord, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnProfileInfo, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 268)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(393, 90)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'btnPayment
        '
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPayment.Location = New System.Drawing.Point(3, 2)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(88, 86)
        Me.btnPayment.TabIndex = 0
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnStatementAccount
        '
        Me.btnStatementAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStatementAccount.Image = CType(resources.GetObject("btnStatementAccount.Image"), System.Drawing.Image)
        Me.btnStatementAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStatementAccount.Location = New System.Drawing.Point(96, 2)
        Me.btnStatementAccount.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnStatementAccount.Name = "btnStatementAccount"
        Me.btnStatementAccount.Size = New System.Drawing.Size(84, 86)
        Me.btnStatementAccount.TabIndex = 1
        Me.btnStatementAccount.Text = "SOA"
        Me.btnStatementAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStatementAccount.UseVisualStyleBackColor = True
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUpdateRecord.Image = CType(resources.GetObject("btnUpdateRecord.Image"), System.Drawing.Image)
        Me.btnUpdateRecord.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdateRecord.Location = New System.Drawing.Point(185, 2)
        Me.btnUpdateRecord.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(95, 86)
        Me.btnUpdateRecord.TabIndex = 2
        Me.btnUpdateRecord.Text = "Update Record"
        Me.btnUpdateRecord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateRecord.UseVisualStyleBackColor = True
        '
        'btnProfileInfo
        '
        Me.btnProfileInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProfileInfo.Image = Global.DahumBuilders.My.Resources.Resources.profiles_a_icon
        Me.btnProfileInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProfileInfo.Location = New System.Drawing.Point(285, 2)
        Me.btnProfileInfo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnProfileInfo.Name = "btnProfileInfo"
        Me.btnProfileInfo.Size = New System.Drawing.Size(105, 86)
        Me.btnProfileInfo.TabIndex = 3
        Me.btnProfileInfo.Text = "Profile Info"
        Me.btnProfileInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProfileInfo.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(399, 64)
        Me.Panel7.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(10, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Client Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColumnHeaderPartNo
        '
        Me.ColumnHeaderPartNo.Text = "Part No."
        '
        'FormUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 487)
        Me.Controls.Add(Me.Panel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MinimizeBox = False
        Me.Name = "FormUserList"
        Me.ShowIcon = False
        Me.Text = "User List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuUser.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ContextMenuDue.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewUser As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents ColumnHeaderId As ColumnHeader
    Friend WithEvents ColumnHeaderLastName As ColumnHeader
    Friend WithEvents ColumnHeaderName As ColumnHeader
    Friend WithEvents ColumnHeaderMiddleName As ColumnHeader
    Friend WithEvents ComboBoxSearch As ComboBox
    Friend WithEvents labelRows As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeaderGender As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCivilStatus As TextBox
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents ColumnHeaderCivilStatus As ColumnHeader
    Friend WithEvents ColumnHeaderAddress As ColumnHeader
    Friend WithEvents ColumnHeaderDateOfBirth As ColumnHeader
    Friend WithEvents ColumnHeaderImageLocation As ColumnHeader
    Friend WithEvents ColumnHeaderMobile As ColumnHeader
    Friend WithEvents txtMobileContact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnStatementAccount As Button
    Friend WithEvents btnUpdateRecord As Button
    Friend WithEvents btnProfileInfo As Button
    Friend WithEvents cbbProjectList As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ColumnHeaderUserType As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents cbbUserType As ComboBox
    Friend WithEvents ColumnHeaderAgentName As ColumnHeader
    Friend WithEvents ColumnHeaderAgentContact As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1Id As ColumnHeader
    Friend WithEvents ColumnHeader1Type As ColumnHeader
    Friend WithEvents ColumnHeader2DueDate As ColumnHeader
    Friend WithEvents ColumnHeader3Amount As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ColumnHeader1Name As ColumnHeader
    Friend WithEvents ColumnHeader1Mobile As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeader1PName As ColumnHeader
    Friend WithEvents ColumnHeader2BlockLot As ColumnHeader
    Friend WithEvents btnRefresh As Button
    Friend WithEvents ColumnHeader1UserId As ColumnHeader
    Friend WithEvents ContextMenuDue As ContextMenuStrip
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuUser As ContextMenuStrip
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeaderPartNo As ColumnHeader
End Class
