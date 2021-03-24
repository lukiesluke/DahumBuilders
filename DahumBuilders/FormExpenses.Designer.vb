<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ColumnHeaderTotalDeduction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.txtVoucherNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ColumnHeaderVoucherNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelPayeeName.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderName, Me.ColumnHeaderMobile, Me.ColumnHeaderAddress, Me.ColumnHeaderTotalDeduction})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 41)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(489, 250)
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
        'ColumnHeaderTotalDeduction
        '
        Me.ColumnHeaderTotalDeduction.Text = "Total Deduction"
        Me.ColumnHeaderTotalDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderTotalDeduction.Width = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(232, 16)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 21)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dt
        '
        Me.dt.CustomFormat = "MM/dd/yyyy"
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt.Location = New System.Drawing.Point(107, 10)
        Me.dt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(81, 20)
        Me.dt.TabIndex = 0
        '
        'cbbExpensesType
        '
        Me.cbbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbExpensesType.FormattingEnabled = True
        Me.cbbExpensesType.Location = New System.Drawing.Point(107, 35)
        Me.cbbExpensesType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbbExpensesType.Name = "cbbExpensesType"
        Me.cbbExpensesType.Size = New System.Drawing.Size(225, 21)
        Me.cbbExpensesType.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(107, 195)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(225, 90)
        Me.txtDescription.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Description"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(107, 288)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 27)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(223, 288)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 27)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCashoutAmount
        '
        Me.txtCashoutAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCashoutAmount.Location = New System.Drawing.Point(107, 171)
        Me.txtCashoutAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCashoutAmount.Name = "txtCashoutAmount"
        Me.txtCashoutAmount.Size = New System.Drawing.Size(225, 20)
        Me.txtCashoutAmount.TabIndex = 8
        Me.txtCashoutAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cashout Amount"
        '
        'ListViewExpenses
        '
        Me.ListViewExpenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeaderExpDate, Me.ColumnHeaderVoucherNo, Me.ColumnHeaderDescription, Me.ColumnHeaderAmount, Me.ColumnHeaderEmpName, Me.ColumnHeaderType, Me.ColumnHeaderPaymentType, Me.ColumnHeaderCheckNo})
        Me.ListViewExpenses.FullRowSelect = True
        Me.ListViewExpenses.GridLines = True
        Me.ListViewExpenses.Location = New System.Drawing.Point(8, 323)
        Me.ListViewExpenses.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListViewExpenses.Name = "ListViewExpenses"
        Me.ListViewExpenses.Size = New System.Drawing.Size(829, 153)
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
        Me.Label6.Location = New System.Drawing.Point(28, 147)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Payee Name"
        '
        'lblIssueTo
        '
        Me.lblIssueTo.BackColor = System.Drawing.Color.White
        Me.lblIssueTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueTo.Location = New System.Drawing.Point(107, 142)
        Me.lblIssueTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIssueTo.Name = "lblIssueTo"
        Me.lblIssueTo.Size = New System.Drawing.Size(225, 22)
        Me.lblIssueTo.TabIndex = 7
        Me.lblIssueTo.Text = "Please select name..."
        Me.lblIssueTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbbPaymentType
        '
        Me.cbbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPaymentType.FormattingEnabled = True
        Me.cbbPaymentType.Location = New System.Drawing.Point(107, 60)
        Me.cbbPaymentType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbbPaymentType.Name = "cbbPaymentType"
        Me.cbbPaymentType.Size = New System.Drawing.Size(225, 21)
        Me.cbbPaymentType.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Payment type"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Location = New System.Drawing.Point(107, 116)
        Me.txtCheckNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(225, 20)
        Me.txtCheckNo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Check No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Date"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(44, 18)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 20)
        Me.txtSearch.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Name"
        '
        'lblClientID
        '
        Me.lblClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClientID.Location = New System.Drawing.Point(431, 18)
        Me.lblClientID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(63, 18)
        Me.lblClientID.TabIndex = 28
        Me.lblClientID.Text = "lblClientID"
        Me.lblClientID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjectID
        '
        Me.lblProjectID.AutoSize = True
        Me.lblProjectID.Location = New System.Drawing.Point(35, 224)
        Me.lblProjectID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProjectID.Name = "lblProjectID"
        Me.lblProjectID.Size = New System.Drawing.Size(61, 13)
        Me.lblProjectID.TabIndex = 18
        Me.lblProjectID.Text = "lblProjectID"
        Me.lblProjectID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 92)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Bank Name"
        '
        'cbbBankName
        '
        Me.cbbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbBankName.FormattingEnabled = True
        Me.cbbBankName.Items.AddRange(New Object() {"Select Bank Name", "RCBC", "PSBank", "BPI", "BDO", "MetroBank", "Security Bank", "Unionbank", "ChinaBank", "Citibank"})
        Me.cbbBankName.Location = New System.Drawing.Point(107, 90)
        Me.cbbBankName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbbBankName.Name = "cbbBankName"
        Me.cbbBankName.Size = New System.Drawing.Size(225, 21)
        Me.cbbBankName.TabIndex = 5
        '
        'PanelPayeeName
        '
        Me.PanelPayeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPayeeName.Controls.Add(Me.btnSetPayeeName)
        Me.PanelPayeeName.Controls.Add(Me.btnPayeeCancel)
        Me.PanelPayeeName.Controls.Add(Me.txtPayeeName)
        Me.PanelPayeeName.Controls.Add(Me.Label10)
        Me.PanelPayeeName.Location = New System.Drawing.Point(334, 109)
        Me.PanelPayeeName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelPayeeName.Name = "PanelPayeeName"
        Me.PanelPayeeName.Size = New System.Drawing.Size(336, 79)
        Me.PanelPayeeName.TabIndex = 31
        Me.PanelPayeeName.Visible = False
        '
        'btnSetPayeeName
        '
        Me.btnSetPayeeName.Location = New System.Drawing.Point(103, 41)
        Me.btnSetPayeeName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSetPayeeName.Name = "btnSetPayeeName"
        Me.btnSetPayeeName.Size = New System.Drawing.Size(107, 27)
        Me.btnSetPayeeName.TabIndex = 32
        Me.btnSetPayeeName.Text = "Set Payee Name"
        Me.btnSetPayeeName.UseVisualStyleBackColor = True
        '
        'btnPayeeCancel
        '
        Me.btnPayeeCancel.Location = New System.Drawing.Point(214, 41)
        Me.btnPayeeCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPayeeCancel.Name = "btnPayeeCancel"
        Me.btnPayeeCancel.Size = New System.Drawing.Size(107, 27)
        Me.btnPayeeCancel.TabIndex = 33
        Me.btnPayeeCancel.Text = "&Cancel"
        Me.btnPayeeCancel.UseVisualStyleBackColor = True
        '
        'txtPayeeName
        '
        Me.txtPayeeName.Location = New System.Drawing.Point(85, 12)
        Me.txtPayeeName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPayeeName.Name = "txtPayeeName"
        Me.txtPayeeName.Size = New System.Drawing.Size(237, 20)
        Me.txtPayeeName.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Payee Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblClientID)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(340, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(499, 305)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee list"
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Location = New System.Drawing.Point(246, 11)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(86, 20)
        Me.txtVoucherNo.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "No.:"
        '
        'ColumnHeaderVoucherNo
        '
        Me.ColumnHeaderVoucherNo.Text = "Voucher No."
        Me.ColumnHeaderVoucherNo.Width = 75
        '
        'FormExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 487)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "FormExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commission / Expenses"
        Me.PanelPayeeName.ResumeLayout(False)
        Me.PanelPayeeName.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents ColumnHeaderTotalDeduction As ColumnHeader
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
End Class
