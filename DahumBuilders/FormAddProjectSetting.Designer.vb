<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddProjectSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddProjectSetting))
        Me.cbbProjectName = New System.Windows.Forms.ComboBox()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.btnAddLot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbbLotType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtBlockFilter = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbSQM = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelLotUpdate = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbbLotTypeUpdate = New System.Windows.Forms.ComboBox()
        Me.cbSQMUpdate = New System.Windows.Forms.ComboBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.btnUpdateLot = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBlockUp = New System.Windows.Forms.TextBox()
        Me.txtTcpUp = New System.Windows.Forms.TextBox()
        Me.txtLotUp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListViewProjectLot = New System.Windows.Forms.ListView()
        Me.ColumnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLotType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnTCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAutoID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderClient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblProjID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelProjectNameUpdate = New System.Windows.Forms.Panel()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtAddressUpdate = New System.Windows.Forms.TextBox()
        Me.txtProjectNameUpdate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnUpdateProjectName = New System.Windows.Forms.Button()
        Me.ListViewProject = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddProject = New System.Windows.Forms.Button()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.txtProjectAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelLotUpdate.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelProjectNameUpdate.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbProjectName
        '
        Me.cbbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProjectName.FormattingEnabled = True
        Me.cbbProjectName.Location = New System.Drawing.Point(92, 13)
        Me.cbbProjectName.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbProjectName.Name = "cbbProjectName"
        Me.cbbProjectName.Size = New System.Drawing.Size(181, 21)
        Me.cbbProjectName.TabIndex = 8
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(92, 39)
        Me.txtBlock.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(37, 20)
        Me.txtBlock.TabIndex = 9
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(157, 39)
        Me.txtLot.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(37, 20)
        Me.txtLot.TabIndex = 10
        '
        'btnAddLot
        '
        Me.btnAddLot.Location = New System.Drawing.Point(200, 90)
        Me.btnAddLot.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddLot.Name = "btnAddLot"
        Me.btnAddLot.Size = New System.Drawing.Size(73, 25)
        Me.btnAddLot.TabIndex = 14
        Me.btnAddLot.Text = "Add &Lot"
        Me.btnAddLot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Project Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Block"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lot"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SQM"
        '
        'txtTCP
        '
        Me.txtTCP.Location = New System.Drawing.Point(92, 90)
        Me.txtTCP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTCP.Name = "txtTCP"
        Me.txtTCP.Size = New System.Drawing.Size(103, 20)
        Me.txtTCP.TabIndex = 13
        Me.txtTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "TCP"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.64357!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.35644!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 390.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1111, 427)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cbbLotType)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cbSQM)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lblProjID)
        Me.Panel1.Controls.Add(Me.cbbProjectName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtBlock)
        Me.Panel1.Controls.Add(Me.txtTCP)
        Me.Panel1.Controls.Add(Me.txtLot)
        Me.Panel1.Controls.Add(Me.btnAddLot)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(398, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 386)
        Me.Panel1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(39, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Lot Type"
        '
        'cbbLotType
        '
        Me.cbbLotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLotType.FormattingEnabled = True
        Me.cbbLotType.Location = New System.Drawing.Point(92, 63)
        Me.cbbLotType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbLotType.Name = "cbbLotType"
        Me.cbbLotType.Size = New System.Drawing.Size(181, 21)
        Me.cbbLotType.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.txtBlockFilter)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(286, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(191, 73)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Block"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(100, 23)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(73, 25)
        Me.btnFilter.TabIndex = 16
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtBlockFilter
        '
        Me.txtBlockFilter.Location = New System.Drawing.Point(46, 25)
        Me.txtBlockFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBlockFilter.Name = "txtBlockFilter"
        Me.txtBlockFilter.Size = New System.Drawing.Size(50, 20)
        Me.txtBlockFilter.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 29)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Block"
        '
        'cbSQM
        '
        Me.cbSQM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSQM.FormattingEnabled = True
        Me.cbSQM.Location = New System.Drawing.Point(228, 38)
        Me.cbSQM.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSQM.Name = "cbSQM"
        Me.cbSQM.Size = New System.Drawing.Size(45, 21)
        Me.cbSQM.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.PanelLotUpdate)
        Me.Panel6.Controls.Add(Me.ListViewProjectLot)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 117)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(709, 267)
        Me.Panel6.TabIndex = 17
        '
        'PanelLotUpdate
        '
        Me.PanelLotUpdate.BackColor = System.Drawing.Color.White
        Me.PanelLotUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLotUpdate.Controls.Add(Me.Label18)
        Me.PanelLotUpdate.Controls.Add(Me.cbbLotTypeUpdate)
        Me.PanelLotUpdate.Controls.Add(Me.cbSQMUpdate)
        Me.PanelLotUpdate.Controls.Add(Me.lblClose)
        Me.PanelLotUpdate.Controls.Add(Me.btnUpdateLot)
        Me.PanelLotUpdate.Controls.Add(Me.Label13)
        Me.PanelLotUpdate.Controls.Add(Me.Label10)
        Me.PanelLotUpdate.Controls.Add(Me.txtBlockUp)
        Me.PanelLotUpdate.Controls.Add(Me.txtTcpUp)
        Me.PanelLotUpdate.Controls.Add(Me.txtLotUp)
        Me.PanelLotUpdate.Controls.Add(Me.Label11)
        Me.PanelLotUpdate.Controls.Add(Me.Label12)
        Me.PanelLotUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelLotUpdate.Location = New System.Drawing.Point(0, 131)
        Me.PanelLotUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLotUpdate.Name = "PanelLotUpdate"
        Me.PanelLotUpdate.Size = New System.Drawing.Size(705, 132)
        Me.PanelLotUpdate.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Lot Type"
        '
        'cbbLotTypeUpdate
        '
        Me.cbbLotTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLotTypeUpdate.FormattingEnabled = True
        Me.cbbLotTypeUpdate.Location = New System.Drawing.Point(57, 40)
        Me.cbbLotTypeUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbLotTypeUpdate.Name = "cbbLotTypeUpdate"
        Me.cbbLotTypeUpdate.Size = New System.Drawing.Size(217, 21)
        Me.cbbLotTypeUpdate.TabIndex = 21
        '
        'cbSQMUpdate
        '
        Me.cbSQMUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSQMUpdate.FormattingEnabled = True
        Me.cbSQMUpdate.Location = New System.Drawing.Point(229, 14)
        Me.cbSQMUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSQMUpdate.Name = "cbSQMUpdate"
        Me.cbSQMUpdate.Size = New System.Drawing.Size(45, 21)
        Me.cbSQMUpdate.TabIndex = 20
        '
        'lblClose
        '
        Me.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClose.Location = New System.Drawing.Point(647, 7)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(48, 20)
        Me.lblClose.TabIndex = 24
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdateLot
        '
        Me.btnUpdateLot.Location = New System.Drawing.Point(194, 65)
        Me.btnUpdateLot.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateLot.Name = "btnUpdateLot"
        Me.btnUpdateLot.Size = New System.Drawing.Size(80, 27)
        Me.btnUpdateLot.TabIndex = 23
        Me.btnUpdateLot.Text = "Update"
        Me.btnUpdateLot.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(194, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "SQM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "TCP"
        '
        'txtBlockUp
        '
        Me.txtBlockUp.Location = New System.Drawing.Point(57, 14)
        Me.txtBlockUp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBlockUp.Name = "txtBlockUp"
        Me.txtBlockUp.Size = New System.Drawing.Size(37, 20)
        Me.txtBlockUp.TabIndex = 18
        '
        'txtTcpUp
        '
        Me.txtTcpUp.Location = New System.Drawing.Point(59, 69)
        Me.txtTcpUp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTcpUp.Name = "txtTcpUp"
        Me.txtTcpUp.Size = New System.Drawing.Size(123, 20)
        Me.txtTcpUp.TabIndex = 22
        Me.txtTcpUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLotUp
        '
        Me.txtLotUp.Location = New System.Drawing.Point(129, 14)
        Me.txtLotUp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLotUp.Name = "txtLotUp"
        Me.txtLotUp.Size = New System.Drawing.Size(37, 20)
        Me.txtLotUp.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 17)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Block"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(103, 17)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Lot"
        '
        'ListViewProjectLot
        '
        Me.ListViewProjectLot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewProjectLot.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnID, Me.ColumnName, Me.ColumnBlock, Me.ColumnLot, Me.ColumnSQM, Me.ColumnHeaderLotType, Me.ColumnTCP, Me.ColumnStatus, Me.ColumnHeaderAutoID, Me.ColumnHeaderProjID, Me.ColumnHeaderClient, Me.ColumnHeaderRemark})
        Me.ListViewProjectLot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewProjectLot.FullRowSelect = True
        Me.ListViewProjectLot.GridLines = True
        Me.ListViewProjectLot.Location = New System.Drawing.Point(0, 0)
        Me.ListViewProjectLot.Margin = New System.Windows.Forms.Padding(2)
        Me.ListViewProjectLot.Name = "ListViewProjectLot"
        Me.ListViewProjectLot.Size = New System.Drawing.Size(705, 263)
        Me.ListViewProjectLot.TabIndex = 17
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
        Me.ColumnBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnBlock.Width = 40
        '
        'ColumnLot
        '
        Me.ColumnLot.Text = "Lot"
        Me.ColumnLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnLot.Width = 40
        '
        'ColumnSQM
        '
        Me.ColumnSQM.Text = "SQM"
        Me.ColumnSQM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnSQM.Width = 40
        '
        'ColumnHeaderLotType
        '
        Me.ColumnHeaderLotType.Text = "Lot Type"
        Me.ColumnHeaderLotType.Width = 140
        '
        'ColumnTCP
        '
        Me.ColumnTCP.Text = "TCP"
        Me.ColumnTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnTCP.Width = 80
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
        'ColumnHeaderProjID
        '
        Me.ColumnHeaderProjID.Text = "ProjectID"
        Me.ColumnHeaderProjID.Width = 0
        '
        'ColumnHeaderClient
        '
        Me.ColumnHeaderClient.Text = "Client Name"
        Me.ColumnHeaderClient.Width = 100
        '
        'ColumnHeaderRemark
        '
        Me.ColumnHeaderRemark.Text = "Remark"
        Me.ColumnHeaderRemark.Width = 200
        '
        'lblProjID
        '
        Me.lblProjID.AutoSize = True
        Me.lblProjID.Location = New System.Drawing.Point(294, 92)
        Me.lblProjID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProjID.Name = "lblProjID"
        Me.lblProjID.Size = New System.Drawing.Size(46, 13)
        Me.lblProjID.TabIndex = 16
        Me.lblProjID.Text = "lblProjID"
        Me.lblProjID.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnAddProject)
        Me.Panel2.Controls.Add(Me.txtProjectName)
        Me.Panel2.Controls.Add(Me.txtProjectAddress)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 39)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 386)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.PanelProjectNameUpdate)
        Me.Panel5.Controls.Add(Me.ListViewProject)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 117)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(390, 267)
        Me.Panel5.TabIndex = 13
        '
        'PanelProjectNameUpdate
        '
        Me.PanelProjectNameUpdate.BackColor = System.Drawing.Color.White
        Me.PanelProjectNameUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProjectNameUpdate.Controls.Add(Me.lblProjectName)
        Me.PanelProjectNameUpdate.Controls.Add(Me.lblID)
        Me.PanelProjectNameUpdate.Controls.Add(Me.txtAddressUpdate)
        Me.PanelProjectNameUpdate.Controls.Add(Me.txtProjectNameUpdate)
        Me.PanelProjectNameUpdate.Controls.Add(Me.Label15)
        Me.PanelProjectNameUpdate.Controls.Add(Me.Label16)
        Me.PanelProjectNameUpdate.Controls.Add(Me.btnUpdateProjectName)
        Me.PanelProjectNameUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProjectNameUpdate.Location = New System.Drawing.Point(0, 131)
        Me.PanelProjectNameUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelProjectNameUpdate.Name = "PanelProjectNameUpdate"
        Me.PanelProjectNameUpdate.Size = New System.Drawing.Size(386, 132)
        Me.PanelProjectNameUpdate.TabIndex = 4
        '
        'lblProjectName
        '
        Me.lblProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectName.Location = New System.Drawing.Point(329, 5)
        Me.lblProjectName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(48, 20)
        Me.lblProjectName.TabIndex = 4
        Me.lblProjectName.Text = "X"
        Me.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(15, 76)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 13)
        Me.lblID.TabIndex = 29
        Me.lblID.Text = "lblID"
        Me.lblID.Visible = False
        '
        'txtAddressUpdate
        '
        Me.txtAddressUpdate.Location = New System.Drawing.Point(85, 51)
        Me.txtAddressUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddressUpdate.Multiline = True
        Me.txtAddressUpdate.Name = "txtAddressUpdate"
        Me.txtAddressUpdate.Size = New System.Drawing.Size(293, 40)
        Me.txtAddressUpdate.TabIndex = 6
        '
        'txtProjectNameUpdate
        '
        Me.txtProjectNameUpdate.Location = New System.Drawing.Point(85, 29)
        Me.txtProjectNameUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProjectNameUpdate.Name = "txtProjectNameUpdate"
        Me.txtProjectNameUpdate.Size = New System.Drawing.Size(293, 20)
        Me.txtProjectNameUpdate.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Project Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 53)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Address"
        '
        'btnUpdateProjectName
        '
        Me.btnUpdateProjectName.Location = New System.Drawing.Point(295, 97)
        Me.btnUpdateProjectName.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateProjectName.Name = "btnUpdateProjectName"
        Me.btnUpdateProjectName.Size = New System.Drawing.Size(82, 27)
        Me.btnUpdateProjectName.TabIndex = 7
        Me.btnUpdateProjectName.Text = "Update"
        Me.btnUpdateProjectName.UseVisualStyleBackColor = True
        '
        'ListViewProject
        '
        Me.ListViewProject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewProject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderName, Me.ColumnHeaderAddress, Me.ColumnHeader1})
        Me.ListViewProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewProject.FullRowSelect = True
        Me.ListViewProject.GridLines = True
        Me.ListViewProject.Location = New System.Drawing.Point(0, 0)
        Me.ListViewProject.Margin = New System.Windows.Forms.Padding(2)
        Me.ListViewProject.Name = "ListViewProject"
        Me.ListViewProject.Size = New System.Drawing.Size(386, 263)
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
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Lot"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 40
        '
        'btnAddProject
        '
        Me.btnAddProject.Location = New System.Drawing.Point(296, 90)
        Me.btnAddProject.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Size = New System.Drawing.Size(85, 25)
        Me.btnAddProject.TabIndex = 2
        Me.btnAddProject.Text = "&Add Project"
        Me.btnAddProject.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(95, 11)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(286, 20)
        Me.txtProjectName.TabIndex = 0
        '
        'txtProjectAddress
        '
        Me.txtProjectAddress.Location = New System.Drawing.Point(95, 36)
        Me.txtProjectAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProjectAddress.Multiline = True
        Me.txtProjectAddress.Name = "txtProjectAddress"
        Me.txtProjectAddress.Size = New System.Drawing.Size(286, 51)
        Me.txtProjectAddress.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Project Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 33)
        Me.Panel3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 8)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Project Name Setting"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(398, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(711, 33)
        Me.Panel4.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Project Lot Setting"
        '
        'FormAddProjectSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 448)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddProjectSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Project Setting"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.PanelLotUpdate.ResumeLayout(False)
        Me.PanelLotUpdate.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.PanelProjectNameUpdate.ResumeLayout(False)
        Me.PanelProjectNameUpdate.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelLotUpdate As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBlockUp As TextBox
    Friend WithEvents txtTcpUp As TextBox
    Friend WithEvents txtLotUp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnUpdateLot As Button
    Friend WithEvents lblClose As Label
    Friend WithEvents ColumnHeaderProjID As ColumnHeader
    Friend WithEvents ColumnHeaderClient As ColumnHeader
    Friend WithEvents cbSQM As ComboBox
    Friend WithEvents cbSQMUpdate As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtBlockFilter As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelProjectNameUpdate As Panel
    Friend WithEvents btnUpdateProjectName As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAddressUpdate As TextBox
    Friend WithEvents txtProjectNameUpdate As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents ColumnHeaderRemark As ColumnHeader
    Friend WithEvents Label17 As Label
    Friend WithEvents cbbLotType As ComboBox
    Friend WithEvents ColumnHeaderLotType As ColumnHeader
    Friend WithEvents Label18 As Label
    Friend WithEvents cbbLotTypeUpdate As ComboBox
End Class
