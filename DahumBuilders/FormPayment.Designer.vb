<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelInformation = New System.Windows.Forms.Panel()
        Me.PanelDownpayment = New System.Windows.Forms.Panel()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMonthsToPay = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAmountToPay = New System.Windows.Forms.Label()
        Me.lblAmountDiscount = New System.Windows.Forms.Label()
        Me.lblAmountDownpayment = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbDiscountType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDownpaymentType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbParticular = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearchProject = New System.Windows.Forms.Button()
        Me.ListViewUserItem = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjectName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelInformation.SuspendLayout()
        Me.PanelDownpayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelTotal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelInformation)
        Me.SplitContainer1.Size = New System.Drawing.Size(1334, 848)
        Me.SplitContainer1.SplitterDistance = 424
        Me.SplitContainer1.TabIndex = 1
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.Color.White
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTotal.Location = New System.Drawing.Point(0, 431)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(424, 257)
        Me.PanelTotal.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.btnPayment)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 688)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(424, 160)
        Me.Panel3.TabIndex = 2
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(36, 78)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(343, 55)
        Me.btnPayment.TabIndex = 1
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(36, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(343, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Payment Method"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 331)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 100)
        Me.Panel1.TabIndex = 0
        '
        'PanelInformation
        '
        Me.PanelInformation.BackColor = System.Drawing.Color.White
        Me.PanelInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInformation.Controls.Add(Me.PanelDownpayment)
        Me.PanelInformation.Controls.Add(Me.cbParticular)
        Me.PanelInformation.Controls.Add(Me.Label1)
        Me.PanelInformation.Controls.Add(Me.TextBox2)
        Me.PanelInformation.Controls.Add(Me.Label9)
        Me.PanelInformation.Controls.Add(Me.btnSearchProject)
        Me.PanelInformation.Controls.Add(Me.ListViewUserItem)
        Me.PanelInformation.Controls.Add(Me.Label8)
        Me.PanelInformation.Controls.Add(Me.DateTimePicker1)
        Me.PanelInformation.Controls.Add(Me.TextBox1)
        Me.PanelInformation.Controls.Add(Me.Label5)
        Me.PanelInformation.Controls.Add(Me.lblAddress)
        Me.PanelInformation.Controls.Add(Me.lblName)
        Me.PanelInformation.Controls.Add(Me.Label7)
        Me.PanelInformation.Controls.Add(Me.Label6)
        Me.PanelInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInformation.Location = New System.Drawing.Point(0, 0)
        Me.PanelInformation.Name = "PanelInformation"
        Me.PanelInformation.Size = New System.Drawing.Size(906, 848)
        Me.PanelInformation.TabIndex = 2
        '
        'PanelDownpayment
        '
        Me.PanelDownpayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDownpayment.Controls.Add(Me.ComboBox1)
        Me.PanelDownpayment.Controls.Add(Me.Label13)
        Me.PanelDownpayment.Controls.Add(Me.lblMonthly)
        Me.PanelDownpayment.Controls.Add(Me.Label12)
        Me.PanelDownpayment.Controls.Add(Me.cbMonthsToPay)
        Me.PanelDownpayment.Controls.Add(Me.Label11)
        Me.PanelDownpayment.Controls.Add(Me.lblBalance)
        Me.PanelDownpayment.Controls.Add(Me.Label4)
        Me.PanelDownpayment.Controls.Add(Me.lblAmountToPay)
        Me.PanelDownpayment.Controls.Add(Me.lblAmountDiscount)
        Me.PanelDownpayment.Controls.Add(Me.lblAmountDownpayment)
        Me.PanelDownpayment.Controls.Add(Me.Label10)
        Me.PanelDownpayment.Controls.Add(Me.cbDiscountType)
        Me.PanelDownpayment.Controls.Add(Me.Label3)
        Me.PanelDownpayment.Controls.Add(Me.cbDownpaymentType)
        Me.PanelDownpayment.Controls.Add(Me.Label2)
        Me.PanelDownpayment.Location = New System.Drawing.Point(16, 412)
        Me.PanelDownpayment.Name = "PanelDownpayment"
        Me.PanelDownpayment.Size = New System.Drawing.Size(871, 397)
        Me.PanelDownpayment.TabIndex = 18
        '
        'lblMonthly
        '
        Me.lblMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthly.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.Location = New System.Drawing.Point(244, 212)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(206, 31)
        Me.lblMonthly.TabIndex = 31
        Me.lblMonthly.Text = "0"
        Me.lblMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 22)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Monthly amortization"
        '
        'cbMonthsToPay
        '
        Me.cbMonthsToPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonthsToPay.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonthsToPay.FormattingEnabled = True
        Me.cbMonthsToPay.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "18", "24"})
        Me.cbMonthsToPay.Location = New System.Drawing.Point(244, 169)
        Me.cbMonthsToPay.Name = "cbMonthsToPay"
        Me.cbMonthsToPay.Size = New System.Drawing.Size(206, 30)
        Me.cbMonthsToPay.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(86, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 22)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Months to Pay"
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalance.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(244, 131)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(206, 31)
        Me.lblBalance.TabIndex = 27
        Me.lblBalance.Text = "0"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Balance to Pay"
        '
        'lblAmountToPay
        '
        Me.lblAmountToPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountToPay.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountToPay.Location = New System.Drawing.Point(626, 104)
        Me.lblAmountToPay.Name = "lblAmountToPay"
        Me.lblAmountToPay.Size = New System.Drawing.Size(166, 31)
        Me.lblAmountToPay.TabIndex = 25
        Me.lblAmountToPay.Text = "0"
        Me.lblAmountToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountDiscount
        '
        Me.lblAmountDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountDiscount.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDiscount.Location = New System.Drawing.Point(626, 61)
        Me.lblAmountDiscount.Name = "lblAmountDiscount"
        Me.lblAmountDiscount.Size = New System.Drawing.Size(166, 31)
        Me.lblAmountDiscount.TabIndex = 24
        Me.lblAmountDiscount.Text = "0"
        Me.lblAmountDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountDownpayment
        '
        Me.lblAmountDownpayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountDownpayment.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDownpayment.Location = New System.Drawing.Point(626, 17)
        Me.lblAmountDownpayment.Name = "lblAmountDownpayment"
        Me.lblAmountDownpayment.Size = New System.Drawing.Size(166, 31)
        Me.lblAmountDownpayment.TabIndex = 23
        Me.lblAmountDownpayment.Text = "0"
        Me.lblAmountDownpayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(462, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 22)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Amount to Pay"
        '
        'cbDiscountType
        '
        Me.cbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiscountType.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDiscountType.FormattingEnabled = True
        Me.cbDiscountType.Items.AddRange(New Object() {"0", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cbDiscountType.Location = New System.Drawing.Point(432, 61)
        Me.cbDiscountType.Name = "cbDiscountType"
        Me.cbDiscountType.Size = New System.Drawing.Size(170, 30)
        Me.cbDiscountType.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Discount"
        '
        'cbDownpaymentType
        '
        Me.cbDownpaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDownpaymentType.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDownpaymentType.FormattingEnabled = True
        Me.cbDownpaymentType.Items.AddRange(New Object() {"25", "50"})
        Me.cbDownpaymentType.Location = New System.Drawing.Point(432, 17)
        Me.cbDownpaymentType.Name = "cbDownpaymentType"
        Me.cbDownpaymentType.Size = New System.Drawing.Size(170, 30)
        Me.cbDownpaymentType.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Downpayment type"
        '
        'cbParticular
        '
        Me.cbParticular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParticular.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParticular.FormattingEnabled = True
        Me.cbParticular.Items.AddRange(New Object() {"Downpayment", "Equity", "Monthly Amortization"})
        Me.cbParticular.Location = New System.Drawing.Point(449, 369)
        Me.cbParticular.Name = "cbParticular"
        Me.cbParticular.Size = New System.Drawing.Size(241, 30)
        Me.cbParticular.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Particular"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(187, 371)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 31)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "800788"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(101, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Amount"
        '
        'btnSearchProject
        '
        Me.btnSearchProject.Location = New System.Drawing.Point(727, 320)
        Me.btnSearchProject.Name = "btnSearchProject"
        Me.btnSearchProject.Size = New System.Drawing.Size(160, 45)
        Me.btnSearchProject.TabIndex = 13
        Me.btnSearchProject.Text = "Search Project"
        Me.btnSearchProject.UseVisualStyleBackColor = True
        '
        'ListViewUserItem
        '
        Me.ListViewUserItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderProjectName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderPrice, Me.ColumnHeaderTotal})
        Me.ListViewUserItem.FullRowSelect = True
        Me.ListViewUserItem.GridLines = True
        Me.ListViewUserItem.Location = New System.Drawing.Point(16, 145)
        Me.ListViewUserItem.Name = "ListViewUserItem"
        Me.ListViewUserItem.Size = New System.Drawing.Size(871, 169)
        Me.ListViewUserItem.TabIndex = 12
        Me.ListViewUserItem.UseCompatibleStateImageBehavior = False
        Me.ListViewUserItem.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 0
        '
        'ColumnHeaderProjectName
        '
        Me.ColumnHeaderProjectName.Text = "Project Name"
        Me.ColumnHeaderProjectName.Width = 150
        '
        'ColumnHeaderBlock
        '
        Me.ColumnHeaderBlock.Text = "Block"
        Me.ColumnHeaderBlock.Width = 50
        '
        'ColumnHeaderLot
        '
        Me.ColumnHeaderLot.Text = "Lot"
        Me.ColumnHeaderLot.Width = 50
        '
        'ColumnHeaderSQM
        '
        Me.ColumnHeaderSQM.Text = "sqm"
        Me.ColumnHeaderSQM.Width = 50
        '
        'ColumnHeaderPrice
        '
        Me.ColumnHeaderPrice.Text = "Price"
        Me.ColumnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderPrice.Width = 100
        '
        'ColumnHeaderTotal
        '
        Me.ColumnHeaderTotal.Text = "Total"
        Me.ColumnHeaderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderTotal.Width = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(378, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(449, 324)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 31)
        Me.DateTimePicker1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(187, 327)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 31)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "800788"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Official Receipt #"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAddress.Location = New System.Drawing.Point(106, 51)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(781, 79)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Block 44 lot 26 Greengate Phase 1, Malagaang II-A, Imus City"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblName.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(106, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(781, 31)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Luke Washington Ortiz"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(83, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 22)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Payment Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CASH", "CHECK", "BANK TRANSFER"})
        Me.ComboBox1.Location = New System.Drawing.Point(244, 254)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 30)
        Me.ComboBox1.TabIndex = 33
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 890)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelInformation.ResumeLayout(False)
        Me.PanelInformation.PerformLayout()
        Me.PanelDownpayment.ResumeLayout(False)
        Me.PanelDownpayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents PanelInformation As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListViewUserItem As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderBlock As ColumnHeader
    Friend WithEvents ColumnHeaderLot As ColumnHeader
    Friend WithEvents ColumnHeaderPrice As ColumnHeader
    Friend WithEvents ColumnHeaderProjectName As ColumnHeader
    Friend WithEvents btnSearchProject As Button
    Friend WithEvents ColumnHeaderSQM As ColumnHeader
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbParticular As ComboBox
    Friend WithEvents PanelDownpayment As Panel
    Friend WithEvents cbDownpaymentType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDiscountType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAmountDownpayment As Label
    Friend WithEvents lblAmountDiscount As Label
    Friend WithEvents lblAmountToPay As Label
    Friend WithEvents ColumnHeaderTotal As ColumnHeader
    Friend WithEvents PanelTotal As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbMonthsToPay As ComboBox
    Friend WithEvents lblMonthly As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
End Class
