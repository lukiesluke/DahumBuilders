﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExpensesEntries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExpensesEntries))
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderOR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderVoucher = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderParticular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBank = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderReference = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbbParticular = New System.Windows.Forms.ComboBox()
        Me.cbbPayment = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVoucher = New System.Windows.Forms.TextBox()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.cbbBankName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chbORFilter = New System.Windows.Forms.CheckBox()
        Me.txtORFilter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderDate, Me.ColumnHeaderOR, Me.ColumnHeaderVoucher, Me.ColumnHeaderName, Me.ColumnHeaderAmount, Me.ColumnHeaderPaymentType, Me.ColumnHeaderParticular, Me.ColumnHeaderBank, Me.ColumnHeaderReference})
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.Location = New System.Drawing.Point(13, 109)
        Me.ListView.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(843, 259)
        Me.ListView.TabIndex = 10
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 0
        '
        'ColumnHeaderDate
        '
        Me.ColumnHeaderDate.Text = "Date"
        Me.ColumnHeaderDate.Width = 80
        '
        'ColumnHeaderOR
        '
        Me.ColumnHeaderOR.Text = "OR Number"
        Me.ColumnHeaderOR.Width = 80
        '
        'ColumnHeaderVoucher
        '
        Me.ColumnHeaderVoucher.Text = "Voucher"
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Name"
        Me.ColumnHeaderName.Width = 200
        '
        'ColumnHeaderAmount
        '
        Me.ColumnHeaderAmount.Text = "Amount"
        Me.ColumnHeaderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAmount.Width = 80
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
        'ColumnHeaderBank
        '
        Me.ColumnHeaderBank.Text = "Bank"
        Me.ColumnHeaderBank.Width = 80
        '
        'ColumnHeaderReference
        '
        Me.ColumnHeaderReference.Text = "Reference"
        Me.ColumnHeaderReference.Width = 80
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(193, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Particular"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(201, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Payment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbParticular
        '
        Me.cbbParticular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbParticular.FormattingEnabled = True
        Me.cbbParticular.Location = New System.Drawing.Point(253, 69)
        Me.cbbParticular.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbbParticular.Name = "cbbParticular"
        Me.cbbParticular.Size = New System.Drawing.Size(156, 21)
        Me.cbbParticular.TabIndex = 5
        '
        'cbbPayment
        '
        Me.cbbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPayment.FormattingEnabled = True
        Me.cbbPayment.Location = New System.Drawing.Point(253, 44)
        Me.cbbPayment.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbbPayment.Name = "cbbPayment"
        Me.cbbPayment.Size = New System.Drawing.Size(156, 21)
        Me.cbbPayment.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Amount Paid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "OR Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "OR Date"
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.CustomFormat = "MM/dd/ yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(94, 11)
        Me.dtpDatePaid.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(96, 22)
        Me.dtpDatePaid.TabIndex = 0
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(94, 82)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(96, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtORNumber
        '
        Me.txtORNumber.Location = New System.Drawing.Point(94, 36)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(96, 20)
        Me.txtORNumber.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Voucher"
        '
        'txtVoucher
        '
        Me.txtVoucher.Location = New System.Drawing.Point(94, 59)
        Me.txtVoucher.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(96, 20)
        Me.txtVoucher.TabIndex = 2
        '
        'lblClientName
        '
        Me.lblClientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClientName.Location = New System.Drawing.Point(253, 12)
        Me.lblClientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(440, 23)
        Me.lblClientName.TabIndex = 30
        Me.lblClientName.Text = "ClientName"
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(199, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(440, 375)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 25)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(551, 375)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(107, 25)
        Me.btCancel.TabIndex = 12
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(420, 71)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Check/Reference No."
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(537, 68)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(156, 20)
        Me.txtReference.TabIndex = 7
        Me.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbbBankName
        '
        Me.cbbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbBankName.FormattingEnabled = True
        Me.cbbBankName.Items.AddRange(New Object() {"Select Bank Name", "RCBC", "PSBank", "BPI", "BDO", "MetroBank", "Security Bank", "Unionbank", "ChinaBank", "Citibank"})
        Me.cbbBankName.Location = New System.Drawing.Point(537, 44)
        Me.cbbBankName.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbBankName.Name = "cbbBankName"
        Me.cbbBankName.Size = New System.Drawing.Size(156, 21)
        Me.cbbBankName.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(470, 47)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Bank Name"
        '
        'chbORFilter
        '
        Me.chbORFilter.AutoSize = True
        Me.chbORFilter.Location = New System.Drawing.Point(798, 45)
        Me.chbORFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.chbORFilter.Name = "chbORFilter"
        Me.chbORFilter.Size = New System.Drawing.Size(67, 17)
        Me.chbORFilter.TabIndex = 9
        Me.chbORFilter.Text = "Filter OR"
        Me.chbORFilter.UseVisualStyleBackColor = True
        '
        'txtORFilter
        '
        Me.txtORFilter.Location = New System.Drawing.Point(704, 44)
        Me.txtORFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtORFilter.Name = "txtORFilter"
        Me.txtORFilter.Size = New System.Drawing.Size(87, 20)
        Me.txtORFilter.TabIndex = 8
        '
        'FormExpensesEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 408)
        Me.Controls.Add(Me.chbORFilter)
        Me.Controls.Add(Me.txtORFilter)
        Me.Controls.Add(Me.cbbBankName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVoucher)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbbParticular)
        Me.Controls.Add(Me.cbbPayment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDatePaid)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtORNumber)
        Me.Controls.Add(Me.ListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormExpensesEntries"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Expenses Entries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderDate As ColumnHeader
    Friend WithEvents ColumnHeaderOR As ColumnHeader
    Friend WithEvents ColumnHeaderName As ColumnHeader
    Friend WithEvents ColumnHeaderAmount As ColumnHeader
    Friend WithEvents ColumnHeaderPaymentType As ColumnHeader
    Friend WithEvents ColumnHeaderParticular As ColumnHeader
    Friend WithEvents ColumnHeaderBank As ColumnHeader
    Friend WithEvents ColumnHeaderReference As ColumnHeader
    Friend WithEvents ColumnHeaderVoucher As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbbParticular As ComboBox
    Friend WithEvents cbbPayment As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDatePaid As DateTimePicker
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtORNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVoucher As TextBox
    Friend WithEvents lblClientName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents cbbBankName As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chbORFilter As CheckBox
    Friend WithEvents txtORFilter As TextBox
End Class