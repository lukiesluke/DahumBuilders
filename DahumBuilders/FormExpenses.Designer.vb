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
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderName, Me.ColumnHeaderMobile, Me.ColumnHeaderAddress, Me.ColumnHeaderTotalDeduction})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(513, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(740, 387)
        Me.ListView1.TabIndex = 11
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
        Me.btnSearch.Location = New System.Drawing.Point(1163, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 32)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dt
        '
        Me.dt.CustomFormat = "MM/dd/yyyy"
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt.Location = New System.Drawing.Point(160, 15)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(139, 26)
        Me.dt.TabIndex = 0
        '
        'cbbExpensesType
        '
        Me.cbbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbExpensesType.FormattingEnabled = True
        Me.cbbExpensesType.Location = New System.Drawing.Point(160, 54)
        Me.cbbExpensesType.Name = "cbbExpensesType"
        Me.cbbExpensesType.Size = New System.Drawing.Size(335, 28)
        Me.cbbExpensesType.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(160, 257)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(335, 137)
        Me.txtDescription.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Description"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(222, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 41)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 41)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCashoutAmount
        '
        Me.txtCashoutAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCashoutAmount.Location = New System.Drawing.Point(160, 220)
        Me.txtCashoutAmount.Name = "txtCashoutAmount"
        Me.txtCashoutAmount.Size = New System.Drawing.Size(335, 26)
        Me.txtCashoutAmount.TabIndex = 7
        Me.txtCashoutAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cashout Amount"
        '
        'ListViewExpenses
        '
        Me.ListViewExpenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeaderExpDate, Me.ColumnHeaderDescription, Me.ColumnHeaderAmount, Me.ColumnHeaderEmpName, Me.ColumnHeaderType, Me.ColumnHeaderPaymentType, Me.ColumnHeaderCheckNo})
        Me.ListViewExpenses.FullRowSelect = True
        Me.ListViewExpenses.GridLines = True
        Me.ListViewExpenses.Location = New System.Drawing.Point(12, 458)
        Me.ListViewExpenses.Name = "ListViewExpenses"
        Me.ListViewExpenses.Size = New System.Drawing.Size(1241, 273)
        Me.ListViewExpenses.TabIndex = 12
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
        Me.ColumnHeaderDescription.Width = 350
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
        Me.Label6.Location = New System.Drawing.Point(12, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Paid to"
        '
        'lblIssueTo
        '
        Me.lblIssueTo.BackColor = System.Drawing.Color.White
        Me.lblIssueTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueTo.Location = New System.Drawing.Point(160, 176)
        Me.lblIssueTo.Name = "lblIssueTo"
        Me.lblIssueTo.Size = New System.Drawing.Size(335, 33)
        Me.lblIssueTo.TabIndex = 6
        Me.lblIssueTo.Text = "Please select name..."
        Me.lblIssueTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbbPaymentType
        '
        Me.cbbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPaymentType.FormattingEnabled = True
        Me.cbbPaymentType.Location = New System.Drawing.Point(160, 93)
        Me.cbbPaymentType.Name = "cbbPaymentType"
        Me.cbbPaymentType.Size = New System.Drawing.Size(335, 28)
        Me.cbbPaymentType.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Payment type"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Location = New System.Drawing.Point(160, 137)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(335, 26)
        Me.txtCheckNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Check No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Date"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(881, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 26)
        Me.txtSearch.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(824, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Name"
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Location = New System.Drawing.Point(721, 15)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(81, 20)
        Me.lblClientID.TabIndex = 28
        Me.lblClientID.Text = "lblClientID"
        Me.lblClientID.Visible = False
        '
        'lblProjectID
        '
        Me.lblProjectID.AutoSize = True
        Me.lblProjectID.Location = New System.Drawing.Point(12, 290)
        Me.lblProjectID.Name = "lblProjectID"
        Me.lblProjectID.Size = New System.Drawing.Size(90, 20)
        Me.lblProjectID.TabIndex = 18
        Me.lblProjectID.Text = "lblProjectID"
        Me.lblProjectID.Visible = False
        '
        'FormExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 772)
        Me.Controls.Add(Me.lblClientID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
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
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commission / Expenses"
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
End Class
