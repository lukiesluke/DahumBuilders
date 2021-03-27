﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExpenses))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderMobile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTIN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderUserType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.cbbExpensesType = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtCashoutAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListViewExpenses = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderExpDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderVoucherNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderEmpName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCheckNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIssueTo = New System.Windows.Forms.Label()
        Me.cbbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.lblProjectID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbbBankName = New System.Windows.Forms.ComboBox()
        Me.PanelPayeeName = New System.Windows.Forms.Panel()
        Me.btnSetPayeeName = New System.Windows.Forms.Button()
        Me.btnPayeeCancel = New System.Windows.Forms.Button()
        Me.txtPayeeName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbUserType = New System.Windows.Forms.ComboBox()
        Me.txtVoucherNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeaderTINex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelPayeeName.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderName, Me.ColumnHeaderMobile, Me.ColumnHeaderAddress, Me.ColumnHeaderTIN, Me.ColumnHeaderUserType})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(9, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(931, 382)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 0
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Name"
        Me.ColumnHeaderName.Width = 170
        '
        'ColumnHeaderMobile
        '
        Me.ColumnHeaderMobile.Text = "Mobile"
        Me.ColumnHeaderMobile.Width = 80
        '
        'ColumnHeaderAddress
        '
        Me.ColumnHeaderAddress.Text = "Address"
        Me.ColumnHeaderAddress.Width = 200
        '
        'ColumnHeaderTIN
        '
        Me.ColumnHeaderTIN.Text = "TIN"
        '
        'ColumnHeaderUserType
        '
        Me.ColumnHeaderUserType.Text = "Type"
        Me.ColumnHeaderUserType.Width = 75
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(348, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 32)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dt
        '
        Me.dt.CustomFormat = "MM/dd/yyyy"
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt.Location = New System.Drawing.Point(160, 36)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(120, 26)
        Me.dt.TabIndex = 0
        '
        'cbbExpensesType
        '
        Me.cbbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbExpensesType.FormattingEnabled = True
        Me.cbbExpensesType.Location = New System.Drawing.Point(160, 75)
        Me.cbbExpensesType.Name = "cbbExpensesType"
        Me.cbbExpensesType.Size = New System.Drawing.Size(336, 28)
        Me.cbbExpensesType.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(160, 321)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(336, 136)
        Me.txtDescription.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Description"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(160, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 42)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(334, 464)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 42)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCashoutAmount
        '
        Me.txtCashoutAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCashoutAmount.Location = New System.Drawing.Point(160, 284)
        Me.txtCashoutAmount.Name = "txtCashoutAmount"
        Me.txtCashoutAmount.Size = New System.Drawing.Size(336, 26)
        Me.txtCashoutAmount.TabIndex = 8
        Me.txtCashoutAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cashout Amount"
        '
        'ListViewExpenses
        '
        Me.ListViewExpenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeaderExpDate, Me.ColumnHeaderVoucherNo, Me.ColumnHeaderDescription, Me.ColumnHeaderAmount, Me.ColumnHeaderEmpName, Me.ColumnHeaderType, Me.ColumnHeaderPaymentType, Me.ColumnHeaderCheckNo, Me.ColumnHeaderTINex})
        Me.ListViewExpenses.FullRowSelect = True
        Me.ListViewExpenses.GridLines = True
        Me.ListViewExpenses.Location = New System.Drawing.Point(12, 518)
        Me.ListViewExpenses.Name = "ListViewExpenses"
        Me.ListViewExpenses.Size = New System.Drawing.Size(1444, 233)
        Me.ListViewExpenses.TabIndex = 15
        Me.ListViewExpenses.UseCompatibleStateImageBehavior = False
        Me.ListViewExpenses.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeaderExpDate
        '
        Me.ColumnHeaderExpDate.Text = "Date"
        Me.ColumnHeaderExpDate.Width = 80
        '
        'ColumnHeaderVoucherNo
        '
        Me.ColumnHeaderVoucherNo.Text = "Voucher No."
        Me.ColumnHeaderVoucherNo.Width = 75
        '
        'ColumnHeaderDescription
        '
        Me.ColumnHeaderDescription.Text = "Description"
        Me.ColumnHeaderDescription.Width = 330
        '
        'ColumnHeaderAmount
        '
        Me.ColumnHeaderAmount.Text = "Amount"
        Me.ColumnHeaderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAmount.Width = 80
        '
        'ColumnHeaderEmpName
        '
        Me.ColumnHeaderEmpName.Text = "Name"
        Me.ColumnHeaderEmpName.Width = 130
        '
        'ColumnHeaderType
        '
        Me.ColumnHeaderType.Text = "Type"
        Me.ColumnHeaderType.Width = 100
        '
        'ColumnHeaderPaymentType
        '
        Me.ColumnHeaderPaymentType.Text = "Payment"
        Me.ColumnHeaderPaymentType.Width = 80
        '
        'ColumnHeaderCheckNo
        '
        Me.ColumnHeaderCheckNo.Text = "Check No"
        Me.ColumnHeaderCheckNo.Width = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Payee Name"
        '
        'lblIssueTo
        '
        Me.lblIssueTo.BackColor = System.Drawing.Color.White
        Me.lblIssueTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueTo.Location = New System.Drawing.Point(160, 239)
        Me.lblIssueTo.Name = "lblIssueTo"
        Me.lblIssueTo.Size = New System.Drawing.Size(336, 33)
        Me.lblIssueTo.TabIndex = 7
        Me.lblIssueTo.Text = "Please select name..."
        Me.lblIssueTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbbPaymentType
        '
        Me.cbbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPaymentType.FormattingEnabled = True
        Me.cbbPaymentType.Location = New System.Drawing.Point(160, 113)
        Me.cbbPaymentType.Name = "cbbPaymentType"
        Me.cbbPaymentType.Size = New System.Drawing.Size(336, 28)
        Me.cbbPaymentType.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Payment type"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Location = New System.Drawing.Point(160, 199)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(336, 26)
        Me.txtCheckNo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Check No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(99, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Date"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(66, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 26)
        Me.txtSearch.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Name"
        '
        'lblClientID
        '
        Me.lblClientID.BackColor = System.Drawing.Color.White
        Me.lblClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClientID.Location = New System.Drawing.Point(848, 28)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(94, 27)
        Me.lblClientID.TabIndex = 28
        Me.lblClientID.Text = "lblClientID"
        Me.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjectID
        '
        Me.lblProjectID.AutoSize = True
        Me.lblProjectID.Location = New System.Drawing.Point(52, 366)
        Me.lblProjectID.Name = "lblProjectID"
        Me.lblProjectID.Size = New System.Drawing.Size(90, 20)
        Me.lblProjectID.TabIndex = 18
        Me.lblProjectID.Text = "lblProjectID"
        Me.lblProjectID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Bank Name"
        '
        'cbbBankName
        '
        Me.cbbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbBankName.FormattingEnabled = True
        Me.cbbBankName.Items.AddRange(New Object() {"Select Bank Name", "RCBC", "PSBank", "BPI", "BDO", "MetroBank", "Security Bank", "Unionbank", "ChinaBank", "Citibank"})
        Me.cbbBankName.Location = New System.Drawing.Point(160, 159)
        Me.cbbBankName.Name = "cbbBankName"
        Me.cbbBankName.Size = New System.Drawing.Size(336, 28)
        Me.cbbBankName.TabIndex = 5
        '
        'PanelPayeeName
        '
        Me.PanelPayeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPayeeName.Controls.Add(Me.btnSetPayeeName)
        Me.PanelPayeeName.Controls.Add(Me.btnPayeeCancel)
        Me.PanelPayeeName.Controls.Add(Me.txtPayeeName)
        Me.PanelPayeeName.Controls.Add(Me.Label10)
        Me.PanelPayeeName.Location = New System.Drawing.Point(501, 189)
        Me.PanelPayeeName.Name = "PanelPayeeName"
        Me.PanelPayeeName.Size = New System.Drawing.Size(503, 120)
        Me.PanelPayeeName.TabIndex = 31
        Me.PanelPayeeName.Visible = False
        '
        'btnSetPayeeName
        '
        Me.btnSetPayeeName.Location = New System.Drawing.Point(154, 63)
        Me.btnSetPayeeName.Name = "btnSetPayeeName"
        Me.btnSetPayeeName.Size = New System.Drawing.Size(160, 42)
        Me.btnSetPayeeName.TabIndex = 32
        Me.btnSetPayeeName.Text = "Set Payee Name"
        Me.btnSetPayeeName.UseVisualStyleBackColor = True
        '
        'btnPayeeCancel
        '
        Me.btnPayeeCancel.Location = New System.Drawing.Point(321, 63)
        Me.btnPayeeCancel.Name = "btnPayeeCancel"
        Me.btnPayeeCancel.Size = New System.Drawing.Size(160, 42)
        Me.btnPayeeCancel.TabIndex = 33
        Me.btnPayeeCancel.Text = "&Cancel"
        Me.btnPayeeCancel.UseVisualStyleBackColor = True
        '
        'txtPayeeName
        '
        Me.txtPayeeName.Location = New System.Drawing.Point(128, 18)
        Me.txtPayeeName.Name = "txtPayeeName"
        Me.txtPayeeName.Size = New System.Drawing.Size(354, 26)
        Me.txtPayeeName.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Payee Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbbUserType)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblClientID)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(510, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(948, 469)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee list"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(513, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "User Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbUserType
        '
        Me.cbbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbUserType.FormattingEnabled = True
        Me.cbbUserType.Location = New System.Drawing.Point(603, 23)
        Me.cbbUserType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbbUserType.Name = "cbbUserType"
        Me.cbbUserType.Size = New System.Drawing.Size(170, 28)
        Me.cbbUserType.TabIndex = 29
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Location = New System.Drawing.Point(369, 38)
        Me.txtVoucherNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(127, 26)
        Me.txtVoucherNo.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "No.:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1474, 33)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStripMain"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(140, 29)
        Me.ExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ColumnHeaderTINex
        '
        Me.ColumnHeaderTINex.Text = "TIN"
        Me.ColumnHeaderTINex.Width = 80
        '
        'FormExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 763)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtVoucherNo)
        Me.Controls.Add(Me.PanelPayeeName)
        Me.Controls.Add(Me.cbbBankName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbbPaymentType)
        Me.Controls.Add(Me.lblIssueTo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListViewExpenses)
        Me.Controls.Add(Me.lblProjectID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCashoutAmount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cbbExpensesType)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commission / Expenses"
        Me.PanelPayeeName.ResumeLayout(False)
        Me.PanelPayeeName.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderName As ColumnHeader
    Friend WithEvents ColumnHeaderMobile As ColumnHeader
    Friend WithEvents ColumnHeaderAddress As ColumnHeader
    Friend WithEvents btnSearch As Button
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents cbbExpensesType As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtCashoutAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListViewExpenses As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeaderDescription As ColumnHeader
    Friend WithEvents ColumnHeaderAmount As ColumnHeader
    Friend WithEvents ColumnHeaderType As ColumnHeader
    Friend WithEvents ColumnHeaderExpDate As ColumnHeader
    Friend WithEvents Label6 As Label
    Friend WithEvents lblIssueTo As Label
    Friend WithEvents cbbPaymentType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeaderPaymentType As ColumnHeader
    Friend WithEvents txtCheckNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblClientID As Label
    Friend WithEvents lblProjectID As Label
    Friend WithEvents ColumnHeaderCheckNo As ColumnHeader
    Friend WithEvents ColumnHeaderEmpName As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents cbbBankName As ComboBox
    Friend WithEvents PanelPayeeName As Panel
    Friend WithEvents btnSetPayeeName As Button
    Friend WithEvents btnPayeeCancel As Button
    Friend WithEvents txtPayeeName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVoucherNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ColumnHeaderVoucherNo As ColumnHeader
    Friend WithEvents ColumnHeaderTIN As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents cbbUserType As ComboBox
    Friend WithEvents ColumnHeaderUserType As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeaderTINex As ColumnHeader
End Class
