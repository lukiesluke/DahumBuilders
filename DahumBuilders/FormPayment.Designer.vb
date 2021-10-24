<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPayment))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ORInformation = New System.Windows.Forms.Panel()
        Me.txtTenderedAmount = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPaymentType = New System.Windows.Forms.ComboBox()
        Me.txtOfficialReceipt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelCheck = New System.Windows.Forms.Panel()
        Me.lblCheckNo = New System.Windows.Forms.Label()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.dtpCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDateOrTransfer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelInformation = New System.Windows.Forms.Panel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnClearEntry = New System.Windows.Forms.Button()
        Me.btnShowHistoryTransaction = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListViewUserItem = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjectName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDiscount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPenalty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTotalPaid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderEQ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderMA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuProjectList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentMethodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelLotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchProject = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderOR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderParticular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPanalty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDisc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuTransaction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemTransEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBodyDataEntry = New System.Windows.Forms.Panel()
        Me.PanelHeaderDataEntry = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtARNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ORInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelCheck.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelInformation.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ContextMenuProjectList.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuTransaction.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelBodyDataEntry.SuspendLayout()
        Me.PanelHeaderDataEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.ORInformation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelCheck)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1087, 333)
        Me.SplitContainer1.SplitterDistance = 333
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'ORInformation
        '
        Me.ORInformation.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ORInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ORInformation.Controls.Add(Me.txtARNumber)
        Me.ORInformation.Controls.Add(Me.Label4)
        Me.ORInformation.Controls.Add(Me.txtTenderedAmount)
        Me.ORInformation.Controls.Add(Me.lblChange)
        Me.ORInformation.Controls.Add(Me.Label11)
        Me.ORInformation.Controls.Add(Me.Label10)
        Me.ORInformation.Controls.Add(Me.Label9)
        Me.ORInformation.Controls.Add(Me.lblTotalAmount)
        Me.ORInformation.Controls.Add(Me.Panel1)
        Me.ORInformation.Controls.Add(Me.dtpDatePaid)
        Me.ORInformation.Controls.Add(Me.Label8)
        Me.ORInformation.Controls.Add(Me.cbPaymentType)
        Me.ORInformation.Controls.Add(Me.txtOfficialReceipt)
        Me.ORInformation.Controls.Add(Me.Label5)
        Me.ORInformation.Controls.Add(Me.Label13)
        Me.ORInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.ORInformation.Location = New System.Drawing.Point(0, 0)
        Me.ORInformation.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ORInformation.Name = "ORInformation"
        Me.ORInformation.Size = New System.Drawing.Size(333, 213)
        Me.ORInformation.TabIndex = 1
        '
        'txtTenderedAmount
        '
        Me.txtTenderedAmount.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenderedAmount.Location = New System.Drawing.Point(118, 159)
        Me.txtTenderedAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenderedAmount.MaxLength = 20
        Me.txtTenderedAmount.Name = "txtTenderedAmount"
        Me.txtTenderedAmount.Size = New System.Drawing.Size(156, 22)
        Me.txtTenderedAmount.TabIndex = 5
        Me.txtTenderedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.White
        Me.lblChange.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(121, 178)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(153, 23)
        Me.lblChange.TabIndex = 43
        Me.lblChange.Text = "lblChange"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 182)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 14)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Change"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 161)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 14)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Tendered Amount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(7, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.White
        Me.lblTotalAmount.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.Red
        Me.lblTotalAmount.Location = New System.Drawing.Point(121, 135)
        Me.lblTotalAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(153, 23)
        Me.lblTotalAmount.TabIndex = 1
        Me.lblTotalAmount.Text = "lblTotalAmount"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 22)
        Me.Panel1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Official Receipt Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.CustomFormat = "MM/dd/ yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(118, 32)
        Me.dtpDatePaid.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(156, 22)
        Me.dtpDatePaid.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "OR Date"
        '
        'cbPaymentType
        '
        Me.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymentType.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPaymentType.FormattingEnabled = True
        Me.cbPaymentType.Items.AddRange(New Object() {"CASH", "CHECK", "BANK TRANSFER"})
        Me.cbPaymentType.Location = New System.Drawing.Point(118, 107)
        Me.cbPaymentType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbPaymentType.Name = "cbPaymentType"
        Me.cbPaymentType.Size = New System.Drawing.Size(156, 22)
        Me.cbPaymentType.TabIndex = 4
        '
        'txtOfficialReceipt
        '
        Me.txtOfficialReceipt.BackColor = System.Drawing.Color.MistyRose
        Me.txtOfficialReceipt.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficialReceipt.Location = New System.Drawing.Point(118, 57)
        Me.txtOfficialReceipt.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtOfficialReceipt.MaxLength = 12
        Me.txtOfficialReceipt.Name = "txtOfficialReceipt"
        Me.txtOfficialReceipt.Size = New System.Drawing.Size(156, 22)
        Me.txtOfficialReceipt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Official Receipt #"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 112)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 14)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Payment Type"
        '
        'PanelCheck
        '
        Me.PanelCheck.BackColor = System.Drawing.Color.White
        Me.PanelCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCheck.Controls.Add(Me.lblCheckNo)
        Me.PanelCheck.Controls.Add(Me.txtCheckNo)
        Me.PanelCheck.Controls.Add(Me.Panel4)
        Me.PanelCheck.Controls.Add(Me.txtBankName)
        Me.PanelCheck.Controls.Add(Me.dtpCheckDate)
        Me.PanelCheck.Controls.Add(Me.lblDateOrTransfer)
        Me.PanelCheck.Controls.Add(Me.Label3)
        Me.PanelCheck.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelCheck.Location = New System.Drawing.Point(0, 216)
        Me.PanelCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelCheck.Name = "PanelCheck"
        Me.PanelCheck.Size = New System.Drawing.Size(333, 117)
        Me.PanelCheck.TabIndex = 4
        '
        'lblCheckNo
        '
        Me.lblCheckNo.AutoSize = True
        Me.lblCheckNo.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckNo.Location = New System.Drawing.Point(7, 92)
        Me.lblCheckNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckNo.Name = "lblCheckNo"
        Me.lblCheckNo.Size = New System.Drawing.Size(92, 14)
        Me.lblCheckNo.TabIndex = 40
        Me.lblCheckNo.Text = "Check Number"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.BackColor = System.Drawing.Color.White
        Me.txtCheckNo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNo.Location = New System.Drawing.Point(115, 86)
        Me.txtCheckNo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCheckNo.MaxLength = 30
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(156, 22)
        Me.txtCheckNo.TabIndex = 39
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblInformation)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(331, 22)
        Me.Panel4.TabIndex = 38
        '
        'lblInformation
        '
        Me.lblInformation.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(9, 5)
        Me.lblInformation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(251, 13)
        Me.lblInformation.TabIndex = 39
        Me.lblInformation.Text = "Check Information"
        Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBankName
        '
        Me.txtBankName.BackColor = System.Drawing.Color.White
        Me.txtBankName.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(115, 60)
        Me.txtBankName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtBankName.MaxLength = 12
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(156, 22)
        Me.txtBankName.TabIndex = 36
        '
        'dtpCheckDate
        '
        Me.dtpCheckDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpCheckDate.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckDate.Location = New System.Drawing.Point(115, 34)
        Me.dtpCheckDate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtpCheckDate.Name = "dtpCheckDate"
        Me.dtpCheckDate.Size = New System.Drawing.Size(156, 22)
        Me.dtpCheckDate.TabIndex = 33
        '
        'lblDateOrTransfer
        '
        Me.lblDateOrTransfer.AutoSize = True
        Me.lblDateOrTransfer.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOrTransfer.Location = New System.Drawing.Point(7, 40)
        Me.lblDateOrTransfer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateOrTransfer.Name = "lblDateOrTransfer"
        Me.lblDateOrTransfer.Size = New System.Drawing.Size(72, 14)
        Me.lblDateOrTransfer.TabIndex = 34
        Me.lblDateOrTransfer.Text = "Check Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Bank Name"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(751, 333)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.PanelInformation)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(743, 307)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Transaction Summary"
        '
        'PanelInformation
        '
        Me.PanelInformation.BackColor = System.Drawing.Color.White
        Me.PanelInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInformation.Controls.Add(Me.btnPayment)
        Me.PanelInformation.Controls.Add(Me.btnClearEntry)
        Me.PanelInformation.Controls.Add(Me.btnShowHistoryTransaction)
        Me.PanelInformation.Controls.Add(Me.Panel5)
        Me.PanelInformation.Controls.Add(Me.Button1)
        Me.PanelInformation.Controls.Add(Me.lblContact)
        Me.PanelInformation.Controls.Add(Me.Label2)
        Me.PanelInformation.Controls.Add(Me.btnSearchProject)
        Me.PanelInformation.Controls.Add(Me.lblAddress)
        Me.PanelInformation.Controls.Add(Me.lblName)
        Me.PanelInformation.Controls.Add(Me.Label7)
        Me.PanelInformation.Controls.Add(Me.Label6)
        Me.PanelInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInformation.Location = New System.Drawing.Point(3, 3)
        Me.PanelInformation.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.PanelInformation.Name = "PanelInformation"
        Me.PanelInformation.Size = New System.Drawing.Size(737, 301)
        Me.PanelInformation.TabIndex = 2
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.Lime
        Me.btnPayment.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(556, 67)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(107, 28)
        Me.btnPayment.TabIndex = 1
        Me.btnPayment.Text = "PAY"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnClearEntry
        '
        Me.btnClearEntry.Location = New System.Drawing.Point(445, 12)
        Me.btnClearEntry.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnClearEntry.Name = "btnClearEntry"
        Me.btnClearEntry.Size = New System.Drawing.Size(107, 28)
        Me.btnClearEntry.TabIndex = 53
        Me.btnClearEntry.Text = "Clear OR Entry"
        Me.btnClearEntry.UseVisualStyleBackColor = True
        '
        'btnShowHistoryTransaction
        '
        Me.btnShowHistoryTransaction.Location = New System.Drawing.Point(445, 39)
        Me.btnShowHistoryTransaction.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnShowHistoryTransaction.Name = "btnShowHistoryTransaction"
        Me.btnShowHistoryTransaction.Size = New System.Drawing.Size(107, 28)
        Me.btnShowHistoryTransaction.TabIndex = 52
        Me.btnShowHistoryTransaction.Text = "Transaction History"
        Me.btnShowHistoryTransaction.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListViewUserItem)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 124)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(735, 175)
        Me.Panel5.TabIndex = 51
        '
        'ListViewUserItem
        '
        Me.ListViewUserItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderProjectName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderTCP, Me.ColumnHeaderProjID, Me.ColumnHeaderBalance, Me.ColumnHeaderDiscount, Me.ColumnHeaderPenalty, Me.ColumnHeaderTotalPaid, Me.ColumnHeaderEQ, Me.ColumnHeaderMA})
        Me.ListViewUserItem.ContextMenuStrip = Me.ContextMenuProjectList
        Me.ListViewUserItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewUserItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewUserItem.FullRowSelect = True
        Me.ListViewUserItem.GridLines = True
        Me.ListViewUserItem.Location = New System.Drawing.Point(0, 0)
        Me.ListViewUserItem.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.ListViewUserItem.MultiSelect = False
        Me.ListViewUserItem.Name = "ListViewUserItem"
        Me.ListViewUserItem.Size = New System.Drawing.Size(735, 175)
        Me.ListViewUserItem.TabIndex = 5
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
        Me.ColumnHeaderProjectName.Width = 180
        '
        'ColumnHeaderBlock
        '
        Me.ColumnHeaderBlock.Text = "Block"
        Me.ColumnHeaderBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderBlock.Width = 50
        '
        'ColumnHeaderLot
        '
        Me.ColumnHeaderLot.Text = "Lot"
        Me.ColumnHeaderLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderLot.Width = 50
        '
        'ColumnHeaderSQM
        '
        Me.ColumnHeaderSQM.Text = "sqm"
        Me.ColumnHeaderSQM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderSQM.Width = 50
        '
        'ColumnHeaderTCP
        '
        Me.ColumnHeaderTCP.Text = "TCP"
        Me.ColumnHeaderTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderTCP.Width = 110
        '
        'ColumnHeaderProjID
        '
        Me.ColumnHeaderProjID.Text = "ProjectID"
        Me.ColumnHeaderProjID.Width = 0
        '
        'ColumnHeaderBalance
        '
        Me.ColumnHeaderBalance.Text = "Balance"
        Me.ColumnHeaderBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderBalance.Width = 100
        '
        'ColumnHeaderDiscount
        '
        Me.ColumnHeaderDiscount.Text = "Discount"
        Me.ColumnHeaderDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderDiscount.Width = 80
        '
        'ColumnHeaderPenalty
        '
        Me.ColumnHeaderPenalty.Text = "Penalty"
        Me.ColumnHeaderPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderPenalty.Width = 70
        '
        'ColumnHeaderTotalPaid
        '
        Me.ColumnHeaderTotalPaid.Text = "Paid Amount"
        Me.ColumnHeaderTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderTotalPaid.Width = 100
        '
        'ColumnHeaderEQ
        '
        Me.ColumnHeaderEQ.Text = "EQ"
        Me.ColumnHeaderEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderEQ.Width = 80
        '
        'ColumnHeaderMA
        '
        Me.ColumnHeaderMA.Text = "MA"
        Me.ColumnHeaderMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderMA.Width = 80
        '
        'ContextMenuProjectList
        '
        Me.ContextMenuProjectList.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuProjectList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.PaymentMethodToolStripMenuItem, Me.CancelLotToolStripMenuItem})
        Me.ContextMenuProjectList.Name = "ContextMenuProjectList"
        Me.ContextMenuProjectList.Size = New System.Drawing.Size(167, 70)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'PaymentMethodToolStripMenuItem
        '
        Me.PaymentMethodToolStripMenuItem.Name = "PaymentMethodToolStripMenuItem"
        Me.PaymentMethodToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PaymentMethodToolStripMenuItem.Text = "Payment Method"
        '
        'CancelLotToolStripMenuItem
        '
        Me.CancelLotToolStripMenuItem.Name = "CancelLotToolStripMenuItem"
        Me.CancelLotToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CancelLotToolStripMenuItem.Text = "Cancel Lot"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(556, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Payment Method"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.White
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblContact.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblContact.Location = New System.Drawing.Point(69, 37)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(369, 21)
        Me.lblContact.TabIndex = 49
        Me.lblContact.Text = "09169151625"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Contact#"
        '
        'btnSearchProject
        '
        Me.btnSearchProject.Location = New System.Drawing.Point(445, 66)
        Me.btnSearchProject.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnSearchProject.Name = "btnSearchProject"
        Me.btnSearchProject.Size = New System.Drawing.Size(107, 28)
        Me.btnSearchProject.TabIndex = 4
        Me.btnSearchProject.Text = "&Add Project"
        Me.btnSearchProject.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAddress.Location = New System.Drawing.Point(69, 62)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(369, 32)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Block 44 lot 26 Greengate Phase 1, Malagaang II-A, Imus City"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblName.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(69, 13)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(369, 21)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Luke Washington Ortiz"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 62)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(743, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transaction List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeaderDate, Me.ColumnHeaderOR, Me.ColumnHeaderPaymentType, Me.ColumnHeaderParticular, Me.ColumnHeaderPanalty, Me.ColumnHeaderDisc, Me.ColumnHeaderAmount, Me.ColumnHeaderProject})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuTransaction
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(737, 275)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 23
        '
        'ColumnHeaderDate
        '
        Me.ColumnHeaderDate.Text = "Date"
        Me.ColumnHeaderDate.Width = 124
        '
        'ColumnHeaderOR
        '
        Me.ColumnHeaderOR.Text = "OR Number"
        Me.ColumnHeaderOR.Width = 80
        '
        'ColumnHeaderPaymentType
        '
        Me.ColumnHeaderPaymentType.Text = "Payment"
        Me.ColumnHeaderPaymentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderPaymentType.Width = 70
        '
        'ColumnHeaderParticular
        '
        Me.ColumnHeaderParticular.Text = "Particular"
        Me.ColumnHeaderParticular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderParticular.Width = 70
        '
        'ColumnHeaderPanalty
        '
        Me.ColumnHeaderPanalty.Text = "Penalty"
        Me.ColumnHeaderPanalty.Width = 80
        '
        'ColumnHeaderDisc
        '
        Me.ColumnHeaderDisc.Text = "Discount"
        Me.ColumnHeaderDisc.Width = 80
        '
        'ColumnHeaderAmount
        '
        Me.ColumnHeaderAmount.Text = "Amount"
        Me.ColumnHeaderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAmount.Width = 80
        '
        'ColumnHeaderProject
        '
        Me.ColumnHeaderProject.Text = "Project Description"
        Me.ColumnHeaderProject.Width = 200
        '
        'ContextMenuTransaction
        '
        Me.ContextMenuTransaction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemTransEdit})
        Me.ContextMenuTransaction.Name = "ContextMenuTransaction"
        Me.ContextMenuTransaction.Size = New System.Drawing.Size(95, 26)
        '
        'ToolStripMenuItemTransEdit
        '
        Me.ToolStripMenuItemTransEdit.Name = "ToolStripMenuItemTransEdit"
        Me.ToolStripMenuItemTransEdit.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripMenuItemTransEdit.Text = "&Edit"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 1)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 112)
        Me.DataGridView1.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1087, 24)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionHistoryToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TransactionHistoryToolStripMenuItem
        '
        Me.TransactionHistoryToolStripMenuItem.Name = "TransactionHistoryToolStripMenuItem"
        Me.TransactionHistoryToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TransactionHistoryToolStripMenuItem.Text = "Transaction History"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'PanelBodyDataEntry
        '
        Me.PanelBodyDataEntry.Controls.Add(Me.DataGridView1)
        Me.PanelBodyDataEntry.Controls.Add(Me.PanelHeaderDataEntry)
        Me.PanelBodyDataEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBodyDataEntry.Location = New System.Drawing.Point(0, 357)
        Me.PanelBodyDataEntry.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBodyDataEntry.Name = "PanelBodyDataEntry"
        Me.PanelBodyDataEntry.Size = New System.Drawing.Size(1087, 130)
        Me.PanelBodyDataEntry.TabIndex = 52
        '
        'PanelHeaderDataEntry
        '
        Me.PanelHeaderDataEntry.BackColor = System.Drawing.Color.White
        Me.PanelHeaderDataEntry.Controls.Add(Me.Label12)
        Me.PanelHeaderDataEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderDataEntry.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderDataEntry.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelHeaderDataEntry.Name = "PanelHeaderDataEntry"
        Me.PanelHeaderDataEntry.Size = New System.Drawing.Size(1087, 18)
        Me.PanelHeaderDataEntry.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1087, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Official Receipt Entry"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtARNumber
        '
        Me.txtARNumber.BackColor = System.Drawing.Color.MistyRose
        Me.txtARNumber.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARNumber.Location = New System.Drawing.Point(118, 82)
        Me.txtARNumber.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtARNumber.MaxLength = 12
        Me.txtARNumber.Name = "txtARNumber"
        Me.txtARNumber.Size = New System.Drawing.Size(156, 22)
        Me.txtARNumber.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "AR #"
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 487)
        Me.Controls.Add(Me.PanelBodyDataEntry)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "FormPayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ORInformation.ResumeLayout(False)
        Me.ORInformation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelCheck.ResumeLayout(False)
        Me.PanelCheck.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PanelInformation.ResumeLayout(False)
        Me.PanelInformation.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ContextMenuProjectList.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ContextMenuTransaction.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelBodyDataEntry.ResumeLayout(False)
        Me.PanelHeaderDataEntry.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ORInformation As Panel
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
    Friend WithEvents cbPaymentType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeaderProjID As ColumnHeader
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeaderBalance As ColumnHeader
    Friend WithEvents ColumnHeaderTotalPaid As ColumnHeader
    Friend WithEvents ContextMenuProjectList As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelCheck As Panel
    Friend WithEvents lblDateOrTransfer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpCheckDate As DateTimePicker
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblInformation As Label
    Friend WithEvents lblCheckNo As Label
    Friend WithEvents txtCheckNo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ColumnHeaderDiscount As ColumnHeader
    Friend WithEvents btnShowHistoryTransaction As Button
    Friend WithEvents ColumnHeaderEQ As ColumnHeader
    Friend WithEvents ColumnHeaderMA As ColumnHeader
    Friend WithEvents PaymentMethodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeaderPenalty As ColumnHeader
    Friend WithEvents btnClearEntry As Button
    Friend WithEvents PanelBodyDataEntry As Panel
    Friend WithEvents PanelHeaderDataEntry As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTenderedAmount As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CancelLotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeaderDate As ColumnHeader
    Friend WithEvents ColumnHeaderOR As ColumnHeader
    Friend WithEvents ColumnHeaderPaymentType As ColumnHeader
    Friend WithEvents ColumnHeaderPanalty As ColumnHeader
    Friend WithEvents ColumnHeaderDisc As ColumnHeader
    Friend WithEvents ColumnHeaderParticular As ColumnHeader
    Friend WithEvents ColumnHeaderAmount As ColumnHeader
    Friend WithEvents ColumnHeaderProject As ColumnHeader
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuTransaction As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemTransEdit As ToolStripMenuItem
    Friend WithEvents txtARNumber As TextBox
    Friend WithEvents Label4 As Label
End Class
