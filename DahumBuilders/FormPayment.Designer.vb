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
        Me.cbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelInformation = New System.Windows.Forms.Panel()
        Me.PanelEquity = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEquityAmount = New System.Windows.Forms.TextBox()
        Me.lblEquityMonthlyAmortization = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbEquityBalanceMonthToPay = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblEquityBalanceToPay = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblEquityMonthly = New System.Windows.Forms.Label()
        Me.cbEquityMonthsToPay = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PanelDownpayment = New System.Windows.Forms.Panel()
        Me.lblMonthlyAmortization = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMonthsToPay = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBalanceAmountPay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAmountToPay = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblDownpaymentAmount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbDiscountType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDownpaymentType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbParticular = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearchProject = New System.Windows.Forms.Button()
        Me.ListViewUserItem = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjectName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.txtOfficialReceipt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelInformation.SuspendLayout()
        Me.PanelEquity.SuspendLayout()
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
        Me.PanelTotal.Controls.Add(Me.cbPaymentType)
        Me.PanelTotal.Controls.Add(Me.Label13)
        Me.PanelTotal.Controls.Add(Me.btnConfirm)
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTotal.Location = New System.Drawing.Point(0, 431)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(424, 257)
        Me.PanelTotal.TabIndex = 3
        '
        'cbPaymentType
        '
        Me.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymentType.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPaymentType.FormattingEnabled = True
        Me.cbPaymentType.Items.AddRange(New Object() {"CASH", "CHECK", "BANK TRANSFER"})
        Me.cbPaymentType.Location = New System.Drawing.Point(201, 76)
        Me.cbPaymentType.Name = "cbPaymentType"
        Me.cbPaymentType.Size = New System.Drawing.Size(175, 30)
        Me.cbPaymentType.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 22)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Payment Type"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(36, 115)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(343, 48)
        Me.btnConfirm.TabIndex = 34
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
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
        Me.PanelInformation.Controls.Add(Me.PanelEquity)
        Me.PanelInformation.Controls.Add(Me.PanelDownpayment)
        Me.PanelInformation.Controls.Add(Me.cbParticular)
        Me.PanelInformation.Controls.Add(Me.Label1)
        Me.PanelInformation.Controls.Add(Me.txtAmountPaid)
        Me.PanelInformation.Controls.Add(Me.Label9)
        Me.PanelInformation.Controls.Add(Me.btnSearchProject)
        Me.PanelInformation.Controls.Add(Me.ListViewUserItem)
        Me.PanelInformation.Controls.Add(Me.Label8)
        Me.PanelInformation.Controls.Add(Me.dtpDatePaid)
        Me.PanelInformation.Controls.Add(Me.txtOfficialReceipt)
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
        'PanelEquity
        '
        Me.PanelEquity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEquity.Controls.Add(Me.Label21)
        Me.PanelEquity.Controls.Add(Me.txtEquityAmount)
        Me.PanelEquity.Controls.Add(Me.lblEquityMonthlyAmortization)
        Me.PanelEquity.Controls.Add(Me.Label16)
        Me.PanelEquity.Controls.Add(Me.cbEquityBalanceMonthToPay)
        Me.PanelEquity.Controls.Add(Me.Label17)
        Me.PanelEquity.Controls.Add(Me.lblEquityBalanceToPay)
        Me.PanelEquity.Controls.Add(Me.Label19)
        Me.PanelEquity.Controls.Add(Me.lblEquityMonthly)
        Me.PanelEquity.Controls.Add(Me.cbEquityMonthsToPay)
        Me.PanelEquity.Controls.Add(Me.Label24)
        Me.PanelEquity.Controls.Add(Me.Label25)
        Me.PanelEquity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEquity.Location = New System.Drawing.Point(0, 399)
        Me.PanelEquity.Name = "PanelEquity"
        Me.PanelEquity.Size = New System.Drawing.Size(904, 165)
        Me.PanelEquity.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(454, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(148, 22)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Monthly Equity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtEquityAmount
        '
        Me.txtEquityAmount.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquityAmount.Location = New System.Drawing.Point(626, 17)
        Me.txtEquityAmount.Name = "txtEquityAmount"
        Me.txtEquityAmount.Size = New System.Drawing.Size(166, 31)
        Me.txtEquityAmount.TabIndex = 34
        Me.txtEquityAmount.Text = "300000"
        Me.txtEquityAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEquityMonthlyAmortization
        '
        Me.lblEquityMonthlyAmortization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquityMonthlyAmortization.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquityMonthlyAmortization.Location = New System.Drawing.Point(244, 220)
        Me.lblEquityMonthlyAmortization.Name = "lblEquityMonthlyAmortization"
        Me.lblEquityMonthlyAmortization.Size = New System.Drawing.Size(206, 31)
        Me.lblEquityMonthlyAmortization.TabIndex = 31
        Me.lblEquityMonthlyAmortization.Text = "0"
        Me.lblEquityMonthlyAmortization.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(202, 22)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Monthly amortization"
        '
        'cbEquityBalanceMonthToPay
        '
        Me.cbEquityBalanceMonthToPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquityBalanceMonthToPay.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEquityBalanceMonthToPay.FormattingEnabled = True
        Me.cbEquityBalanceMonthToPay.Items.AddRange(New Object() {"0", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "18", "24"})
        Me.cbEquityBalanceMonthToPay.Location = New System.Drawing.Point(244, 177)
        Me.cbEquityBalanceMonthToPay.Name = "cbEquityBalanceMonthToPay"
        Me.cbEquityBalanceMonthToPay.Size = New System.Drawing.Size(206, 30)
        Me.cbEquityBalanceMonthToPay.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(86, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 22)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Months to Pay"
        '
        'lblEquityBalanceToPay
        '
        Me.lblEquityBalanceToPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquityBalanceToPay.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquityBalanceToPay.Location = New System.Drawing.Point(244, 139)
        Me.lblEquityBalanceToPay.Name = "lblEquityBalanceToPay"
        Me.lblEquityBalanceToPay.Size = New System.Drawing.Size(206, 31)
        Me.lblEquityBalanceToPay.TabIndex = 27
        Me.lblEquityBalanceToPay.Text = "0"
        Me.lblEquityBalanceToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(80, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 22)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Balance to Pay"
        '
        'lblEquityMonthly
        '
        Me.lblEquityMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquityMonthly.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquityMonthly.Location = New System.Drawing.Point(626, 104)
        Me.lblEquityMonthly.Name = "lblEquityMonthly"
        Me.lblEquityMonthly.Size = New System.Drawing.Size(166, 31)
        Me.lblEquityMonthly.TabIndex = 25
        Me.lblEquityMonthly.Text = "0"
        Me.lblEquityMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbEquityMonthsToPay
        '
        Me.cbEquityMonthsToPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquityMonthsToPay.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEquityMonthsToPay.FormattingEnabled = True
        Me.cbEquityMonthsToPay.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbEquityMonthsToPay.Location = New System.Drawing.Point(626, 61)
        Me.cbEquityMonthsToPay.Name = "cbEquityMonthsToPay"
        Me.cbEquityMonthsToPay.Size = New System.Drawing.Size(166, 30)
        Me.cbEquityMonthsToPay.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(466, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(136, 22)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Months to Pay"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(458, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(144, 22)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Equity Amount"
        '
        'PanelDownpayment
        '
        Me.PanelDownpayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDownpayment.Controls.Add(Me.lblMonthlyAmortization)
        Me.PanelDownpayment.Controls.Add(Me.Label12)
        Me.PanelDownpayment.Controls.Add(Me.cbMonthsToPay)
        Me.PanelDownpayment.Controls.Add(Me.Label11)
        Me.PanelDownpayment.Controls.Add(Me.lblBalanceAmountPay)
        Me.PanelDownpayment.Controls.Add(Me.Label4)
        Me.PanelDownpayment.Controls.Add(Me.lblAmountToPay)
        Me.PanelDownpayment.Controls.Add(Me.lblDiscountAmount)
        Me.PanelDownpayment.Controls.Add(Me.lblDownpaymentAmount)
        Me.PanelDownpayment.Controls.Add(Me.Label10)
        Me.PanelDownpayment.Controls.Add(Me.cbDiscountType)
        Me.PanelDownpayment.Controls.Add(Me.Label3)
        Me.PanelDownpayment.Controls.Add(Me.cbDownpaymentType)
        Me.PanelDownpayment.Controls.Add(Me.Label2)
        Me.PanelDownpayment.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDownpayment.Location = New System.Drawing.Point(0, 564)
        Me.PanelDownpayment.Name = "PanelDownpayment"
        Me.PanelDownpayment.Size = New System.Drawing.Size(904, 282)
        Me.PanelDownpayment.TabIndex = 18
        '
        'lblMonthlyAmortization
        '
        Me.lblMonthlyAmortization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyAmortization.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyAmortization.Location = New System.Drawing.Point(244, 220)
        Me.lblMonthlyAmortization.Name = "lblMonthlyAmortization"
        Me.lblMonthlyAmortization.Size = New System.Drawing.Size(206, 31)
        Me.lblMonthlyAmortization.TabIndex = 31
        Me.lblMonthlyAmortization.Text = "0"
        Me.lblMonthlyAmortization.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 224)
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
        Me.cbMonthsToPay.Items.AddRange(New Object() {"0", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "18", "24"})
        Me.cbMonthsToPay.Location = New System.Drawing.Point(244, 177)
        Me.cbMonthsToPay.Name = "cbMonthsToPay"
        Me.cbMonthsToPay.Size = New System.Drawing.Size(206, 30)
        Me.cbMonthsToPay.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(86, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 22)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Months to Pay"
        '
        'lblBalanceAmountPay
        '
        Me.lblBalanceAmountPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBalanceAmountPay.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceAmountPay.Location = New System.Drawing.Point(244, 139)
        Me.lblBalanceAmountPay.Name = "lblBalanceAmountPay"
        Me.lblBalanceAmountPay.Size = New System.Drawing.Size(206, 31)
        Me.lblBalanceAmountPay.TabIndex = 27
        Me.lblBalanceAmountPay.Text = "0"
        Me.lblBalanceAmountPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 143)
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
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountAmount.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountAmount.Location = New System.Drawing.Point(626, 61)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(166, 31)
        Me.lblDiscountAmount.TabIndex = 24
        Me.lblDiscountAmount.Text = "0"
        Me.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDownpaymentAmount
        '
        Me.lblDownpaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDownpaymentAmount.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownpaymentAmount.Location = New System.Drawing.Point(626, 17)
        Me.lblDownpaymentAmount.Name = "lblDownpaymentAmount"
        Me.lblDownpaymentAmount.Size = New System.Drawing.Size(166, 31)
        Me.lblDownpaymentAmount.TabIndex = 23
        Me.lblDownpaymentAmount.Text = "0"
        Me.lblDownpaymentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.cbDownpaymentType.Items.AddRange(New Object() {"0", "25", "30", "40", "50", "60", "70", "80", "100"})
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
        'txtAmountPaid
        '
        Me.txtAmountPaid.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(187, 371)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(112, 31)
        Me.txtAmountPaid.TabIndex = 15
        Me.txtAmountPaid.Text = "800788"
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.ListViewUserItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderProjectName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderTCP, Me.ColumnHeaderTotal})
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
        'ColumnHeaderTCP
        '
        Me.ColumnHeaderTCP.Text = "TCP"
        Me.ColumnHeaderTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderTCP.Width = 100
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
        'dtpDatePaid
        '
        Me.dtpDatePaid.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(449, 324)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(241, 31)
        Me.dtpDatePaid.TabIndex = 10
        '
        'txtOfficialReceipt
        '
        Me.txtOfficialReceipt.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficialReceipt.Location = New System.Drawing.Point(187, 327)
        Me.txtOfficialReceipt.Name = "txtOfficialReceipt"
        Me.txtOfficialReceipt.Size = New System.Drawing.Size(112, 31)
        Me.txtOfficialReceipt.TabIndex = 9
        Me.txtOfficialReceipt.Text = "800788"
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
        Me.PanelTotal.ResumeLayout(False)
        Me.PanelTotal.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelInformation.ResumeLayout(False)
        Me.PanelInformation.PerformLayout()
        Me.PanelEquity.ResumeLayout(False)
        Me.PanelEquity.PerformLayout()
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
    Friend WithEvents txtOfficialReceipt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDatePaid As DateTimePicker
    Friend WithEvents ListViewUserItem As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderBlock As ColumnHeader
    Friend WithEvents ColumnHeaderLot As ColumnHeader
    Friend WithEvents ColumnHeaderTCP As ColumnHeader
    Friend WithEvents ColumnHeaderProjectName As ColumnHeader
    Friend WithEvents btnSearchProject As Button
    Friend WithEvents ColumnHeaderSQM As ColumnHeader
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbParticular As ComboBox
    Friend WithEvents PanelDownpayment As Panel
    Friend WithEvents cbDownpaymentType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDiscountType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDownpaymentAmount As Label
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents lblAmountToPay As Label
    Friend WithEvents ColumnHeaderTotal As ColumnHeader
    Friend WithEvents PanelTotal As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBalanceAmountPay As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbMonthsToPay As ComboBox
    Friend WithEvents lblMonthlyAmortization As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbPaymentType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PanelEquity As Panel
    Friend WithEvents lblEquityMonthlyAmortization As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cbEquityBalanceMonthToPay As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblEquityBalanceToPay As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblEquityMonthly As Label
    Friend WithEvents cbEquityMonthsToPay As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtEquityAmount As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnConfirm As Button
End Class
