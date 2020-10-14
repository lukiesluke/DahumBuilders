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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelInformation = New System.Windows.Forms.Panel()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPaymentType = New System.Windows.Forms.ComboBox()
        Me.btnSearchProject = New System.Windows.Forms.Button()
        Me.cbParticular = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaidAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListViewUserItem = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjectName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.txtOfficialReceipt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelInformation.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(11, 10)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1302, 502)
        Me.SplitContainer1.SplitterDistance = 362
        Me.SplitContainer1.TabIndex = 1
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.Color.White
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTotal.Location = New System.Drawing.Point(0, 345)
        Me.PanelTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(362, 29)
        Me.PanelTotal.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.btnPayment)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 374)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(362, 128)
        Me.Panel3.TabIndex = 2
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(21, 62)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(305, 44)
        Me.btnPayment.TabIndex = 1
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(305, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Payment Method"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 265)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 80)
        Me.Panel1.TabIndex = 0
        '
        'PanelInformation
        '
        Me.PanelInformation.BackColor = System.Drawing.Color.White
        Me.PanelInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInformation.Controls.Add(Me.lblContact)
        Me.PanelInformation.Controls.Add(Me.Label2)
        Me.PanelInformation.Controls.Add(Me.cbPaymentType)
        Me.PanelInformation.Controls.Add(Me.btnSearchProject)
        Me.PanelInformation.Controls.Add(Me.cbParticular)
        Me.PanelInformation.Controls.Add(Me.Label1)
        Me.PanelInformation.Controls.Add(Me.txtPaidAmount)
        Me.PanelInformation.Controls.Add(Me.Label9)
        Me.PanelInformation.Controls.Add(Me.ListViewUserItem)
        Me.PanelInformation.Controls.Add(Me.Label8)
        Me.PanelInformation.Controls.Add(Me.dtpDatePaid)
        Me.PanelInformation.Controls.Add(Me.txtOfficialReceipt)
        Me.PanelInformation.Controls.Add(Me.Label5)
        Me.PanelInformation.Controls.Add(Me.lblAddress)
        Me.PanelInformation.Controls.Add(Me.lblName)
        Me.PanelInformation.Controls.Add(Me.Label7)
        Me.PanelInformation.Controls.Add(Me.Label6)
        Me.PanelInformation.Controls.Add(Me.Label13)
        Me.PanelInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInformation.Location = New System.Drawing.Point(0, 0)
        Me.PanelInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelInformation.Name = "PanelInformation"
        Me.PanelInformation.Size = New System.Drawing.Size(936, 502)
        Me.PanelInformation.TabIndex = 2
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.White
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblContact.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblContact.Location = New System.Drawing.Point(92, 42)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(549, 25)
        Me.lblContact.TabIndex = 49
        Me.lblContact.Text = "09169151625"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Contact#"
        '
        'cbPaymentType
        '
        Me.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymentType.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPaymentType.FormattingEnabled = True
        Me.cbPaymentType.Items.AddRange(New Object() {"CASH", "CHECK", "BANK TRANSFER"})
        Me.cbPaymentType.Location = New System.Drawing.Point(574, 284)
        Me.cbPaymentType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPaymentType.Name = "cbPaymentType"
        Me.cbPaymentType.Size = New System.Drawing.Size(215, 25)
        Me.cbPaymentType.TabIndex = 33
        '
        'btnSearchProject
        '
        Me.btnSearchProject.Location = New System.Drawing.Point(646, 86)
        Me.btnSearchProject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchProject.Name = "btnSearchProject"
        Me.btnSearchProject.Size = New System.Drawing.Size(142, 26)
        Me.btnSearchProject.TabIndex = 13
        Me.btnSearchProject.Text = "&Add Project"
        Me.btnSearchProject.UseVisualStyleBackColor = True
        '
        'cbParticular
        '
        Me.cbParticular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParticular.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbParticular.FormattingEnabled = True
        Me.cbParticular.Items.AddRange(New Object() {"Downpayment", "Equity", "Monthly Amortization", "Cash Payment", "Reservation"})
        Me.cbParticular.Location = New System.Drawing.Point(187, 284)
        Me.cbParticular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbParticular.Name = "cbParticular"
        Me.cbParticular.Size = New System.Drawing.Size(215, 25)
        Me.cbParticular.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Particular"
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.BackColor = System.Drawing.Color.MistyRose
        Me.txtPaidAmount.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidAmount.Location = New System.Drawing.Point(574, 320)
        Me.txtPaidAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(215, 25)
        Me.txtPaidAmount.TabIndex = 15
        Me.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(504, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Amount"
        '
        'ListViewUserItem
        '
        Me.ListViewUserItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderProjectName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderTCP, Me.ColumnHeaderProjID})
        Me.ListViewUserItem.FullRowSelect = True
        Me.ListViewUserItem.GridLines = True
        Me.ListViewUserItem.Location = New System.Drawing.Point(14, 117)
        Me.ListViewUserItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewUserItem.Name = "ListViewUserItem"
        Me.ListViewUserItem.Size = New System.Drawing.Size(775, 125)
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
        'ColumnHeaderProjID
        '
        Me.ColumnHeaderProjID.Text = "ProjectID"
        Me.ColumnHeaderProjID.Width = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "OR Date"
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(187, 251)
        Me.dtpDatePaid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(215, 25)
        Me.dtpDatePaid.TabIndex = 10
        '
        'txtOfficialReceipt
        '
        Me.txtOfficialReceipt.BackColor = System.Drawing.Color.MistyRose
        Me.txtOfficialReceipt.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficialReceipt.Location = New System.Drawing.Point(574, 251)
        Me.txtOfficialReceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOfficialReceipt.MaxLength = 12
        Me.txtOfficialReceipt.Name = "txtOfficialReceipt"
        Me.txtOfficialReceipt.Size = New System.Drawing.Size(215, 25)
        Me.txtOfficialReceipt.TabIndex = 9
        Me.txtOfficialReceipt.Text = "800788"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(436, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Official Receipt #"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAddress.Location = New System.Drawing.Point(92, 72)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(549, 39)
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
        Me.lblName.Location = New System.Drawing.Point(92, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(549, 25)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Luke Washington Ortiz"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(457, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Payment Type"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 516)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1302, 202)
        Me.DataGridView1.TabIndex = 50
        '
        'FormPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 755)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormPayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelInformation.ResumeLayout(False)
        Me.PanelInformation.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPaidAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbParticular As ComboBox
    Friend WithEvents PanelTotal As Panel
    Friend WithEvents cbPaymentType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeaderProjID As ColumnHeader
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblContact As Label
End Class
