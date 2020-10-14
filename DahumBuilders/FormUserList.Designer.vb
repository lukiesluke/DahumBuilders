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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.labelRows = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnStatementAccount = New System.Windows.Forms.Button()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.btnProfileInfo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewUser
        '
        Me.ListViewUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderId, Me.ColumnHeaderLastName, Me.ColumnHeaderName, Me.ColumnHeaderMiddleName, Me.ColumnHeaderGender, Me.ColumnHeaderCivilStatus, Me.ColumnHeaderDateOfBirth, Me.ColumnHeaderAddress, Me.ColumnHeaderImageLocation})
        Me.ListViewUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListViewUser.FullRowSelect = True
        Me.ListViewUser.GridLines = True
        Me.ListViewUser.Location = New System.Drawing.Point(0, 49)
        Me.ListViewUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewUser.Name = "ListViewUser"
        Me.ListViewUser.Size = New System.Drawing.Size(677, 448)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(70, 14)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(274, 22)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(544, 10)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 30)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Location = New System.Drawing.Point(362, 14)
        Me.ComboBoxSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(165, 24)
        Me.ComboBoxSearch.TabIndex = 2
        '
        'labelRows
        '
        Me.labelRows.AutoSize = True
        Me.labelRows.Location = New System.Drawing.Point(1127, 513)
        Me.labelRows.Name = "labelRows"
        Me.labelRows.Size = New System.Drawing.Size(46, 17)
        Me.labelRows.TabIndex = 5
        Me.labelRows.Text = "Rows:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.86747!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.13253!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(520, 497)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 68)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 313)
        Me.Panel1.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(111, 176)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(390, 22)
        Me.txtAddress.TabIndex = 20
        '
        'txtCivilStatus
        '
        Me.txtCivilStatus.Location = New System.Drawing.Point(111, 149)
        Me.txtCivilStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.Size = New System.Drawing.Size(192, 22)
        Me.txtCivilStatus.TabIndex = 19
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(111, 122)
        Me.txtDateOfBirth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(192, 22)
        Me.txtDateOfBirth.TabIndex = 18
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(111, 94)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(192, 22)
        Me.txtGender.TabIndex = 17
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(111, 67)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(192, 22)
        Me.txtSurname.TabIndex = 16
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(111, 40)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(192, 22)
        Me.txtMiddleName.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(308, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(111, 13)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 22)
        Me.txtName.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Civil Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 60)
        Me.Panel2.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(512, 60)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Client Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.21951!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.78049!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnPayment, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnStatementAccount, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnUpdateRecord, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnProfileInfo, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 386)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(512, 108)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'btnPayment
        '
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPayment.Location = New System.Drawing.Point(4, 3)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(114, 102)
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
        Me.btnStatementAccount.Location = New System.Drawing.Point(125, 3)
        Me.btnStatementAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStatementAccount.Name = "btnStatementAccount"
        Me.btnStatementAccount.Size = New System.Drawing.Size(108, 102)
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
        Me.btnUpdateRecord.Location = New System.Drawing.Point(240, 3)
        Me.btnUpdateRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(133, 102)
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
        Me.btnProfileInfo.Location = New System.Drawing.Point(380, 3)
        Me.btnProfileInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProfileInfo.Name = "btnProfileInfo"
        Me.btnProfileInfo.Size = New System.Drawing.Size(128, 102)
        Me.btnProfileInfo.TabIndex = 3
        Me.btnProfileInfo.Text = "Profile Info"
        Me.btnProfileInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProfileInfo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.52941!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.47059!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(11, 10)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1209, 501)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.ListViewUser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(529, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(677, 497)
        Me.Panel3.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnSearch)
        Me.Panel4.Controls.Add(Me.ComboBoxSearch)
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(677, 51)
        Me.Panel4.TabIndex = 0
        '
        'FormUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1241, 687)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.labelRows)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimizeBox = False
        Me.Name = "FormUserList"
        Me.ShowIcon = False
        Me.Text = "User List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnStatementAccount As Button
    Friend WithEvents btnUpdateRecord As Button
    Friend WithEvents btnProfileInfo As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
