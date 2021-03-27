<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMyOREntries
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderOR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderParticular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.cbbPayment = New System.Windows.Forms.ComboBox()
        Me.cbbParticular = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtORFilter = New System.Windows.Forms.TextBox()
        Me.chbORFilter = New System.Windows.Forms.CheckBox()
        Me.btDeleteOR = New System.Windows.Forms.Button()
        Me.btnVoidOR = New System.Windows.Forms.Button()
        Me.PanelPassword = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btPassCancel = New System.Windows.Forms.Button()
        Me.btnOkayPassword = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PanelPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderDate, Me.ColumnHeaderOR, Me.ColumnHeaderName, Me.ColumnHeaderAmount, Me.ColumnHeaderPaymentType, Me.ColumnHeaderParticular, Me.ColumnHeaderProject})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(11, 93)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(843, 259)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        'ColumnHeaderProject
        '
        Me.ColumnHeaderProject.Text = "Project"
        Me.ColumnHeaderProject.Width = 240
        '
        'txtORNumber
        '
        Me.txtORNumber.Location = New System.Drawing.Point(79, 37)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(96, 20)
        Me.txtORNumber.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(79, 58)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(96, 20)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.CustomFormat = "MM/dd/ yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(79, 14)
        Me.dtpDatePaid.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(96, 22)
        Me.dtpDatePaid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OR Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OR Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount Paid"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(526, 359)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(107, 25)
        Me.btCancel.TabIndex = 8
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(415, 359)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 25)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(189, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(189, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Project"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClientName
        '
        Me.lblClientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClientName.Location = New System.Drawing.Point(243, 12)
        Me.lblClientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(399, 23)
        Me.lblClientName.TabIndex = 11
        Me.lblClientName.Text = "ClientName"
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectName
        '
        Me.lblProjectName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectName.Location = New System.Drawing.Point(243, 40)
        Me.lblProjectName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(399, 23)
        Me.lblProjectName.TabIndex = 12
        Me.lblProjectName.Text = "ProjectName"
        Me.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbbPayment
        '
        Me.cbbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPayment.FormattingEnabled = True
        Me.cbbPayment.Location = New System.Drawing.Point(243, 68)
        Me.cbbPayment.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbbPayment.Name = "cbbPayment"
        Me.cbbPayment.Size = New System.Drawing.Size(156, 21)
        Me.cbbPayment.TabIndex = 13
        '
        'cbbParticular
        '
        Me.cbbParticular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbParticular.FormattingEnabled = True
        Me.cbbParticular.Location = New System.Drawing.Point(487, 68)
        Me.cbbParticular.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbbParticular.Name = "cbbParticular"
        Me.cbbParticular.Size = New System.Drawing.Size(156, 21)
        Me.cbbParticular.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(189, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Payment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(427, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Particular"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtORFilter
        '
        Me.txtORFilter.Location = New System.Drawing.Point(681, 14)
        Me.txtORFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtORFilter.Name = "txtORFilter"
        Me.txtORFilter.Size = New System.Drawing.Size(87, 20)
        Me.txtORFilter.TabIndex = 17
        '
        'chbORFilter
        '
        Me.chbORFilter.AutoSize = True
        Me.chbORFilter.Location = New System.Drawing.Point(775, 15)
        Me.chbORFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbORFilter.Name = "chbORFilter"
        Me.chbORFilter.Size = New System.Drawing.Size(67, 17)
        Me.chbORFilter.TabIndex = 18
        Me.chbORFilter.Text = "Filter OR"
        Me.chbORFilter.UseVisualStyleBackColor = True
        '
        'btDeleteOR
        '
        Me.btDeleteOR.Enabled = False
        Me.btDeleteOR.Location = New System.Drawing.Point(281, 359)
        Me.btDeleteOR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btDeleteOR.Name = "btDeleteOR"
        Me.btDeleteOR.Size = New System.Drawing.Size(107, 25)
        Me.btDeleteOR.TabIndex = 19
        Me.btDeleteOR.Text = "&Delete OR"
        Me.btDeleteOR.UseVisualStyleBackColor = True
        '
        'btnVoidOR
        '
        Me.btnVoidOR.Location = New System.Drawing.Point(169, 359)
        Me.btnVoidOR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVoidOR.Name = "btnVoidOR"
        Me.btnVoidOR.Size = New System.Drawing.Size(107, 25)
        Me.btnVoidOR.TabIndex = 20
        Me.btnVoidOR.Text = "&Void OR"
        Me.btnVoidOR.UseVisualStyleBackColor = True
        Me.btnVoidOR.Visible = False
        '
        'PanelPassword
        '
        Me.PanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPassword.Controls.Add(Me.lblMessage)
        Me.PanelPassword.Controls.Add(Me.btPassCancel)
        Me.PanelPassword.Controls.Add(Me.btnOkayPassword)
        Me.PanelPassword.Controls.Add(Me.Label8)
        Me.PanelPassword.Controls.Add(Me.txtPassword)
        Me.PanelPassword.Location = New System.Drawing.Point(169, 322)
        Me.PanelPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelPassword.Name = "PanelPassword"
        Me.PanelPassword.Size = New System.Drawing.Size(465, 64)
        Me.PanelPassword.TabIndex = 21
        '
        'lblMessage
        '
        Me.lblMessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage.Location = New System.Drawing.Point(5, 44)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(451, 13)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btPassCancel
        '
        Me.btPassCancel.Location = New System.Drawing.Point(334, 12)
        Me.btPassCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btPassCancel.Name = "btPassCancel"
        Me.btPassCancel.Size = New System.Drawing.Size(107, 25)
        Me.btPassCancel.TabIndex = 3
        Me.btPassCancel.Text = "Cancel"
        Me.btPassCancel.UseVisualStyleBackColor = True
        '
        'btnOkayPassword
        '
        Me.btnOkayPassword.Location = New System.Drawing.Point(223, 12)
        Me.btnOkayPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOkayPassword.Name = "btnOkayPassword"
        Me.btnOkayPassword.Size = New System.Drawing.Size(107, 25)
        Me.btnOkayPassword.TabIndex = 2
        Me.btnOkayPassword.Text = "Okay"
        Me.btnOkayPassword.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(95, 16)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(115, 20)
        Me.txtPassword.TabIndex = 0
        '
        'FormMyOREntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 394)
        Me.Controls.Add(Me.PanelPassword)
        Me.Controls.Add(Me.btnVoidOR)
        Me.Controls.Add(Me.btDeleteOR)
        Me.Controls.Add(Me.chbORFilter)
        Me.Controls.Add(Me.txtORFilter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbbParticular)
        Me.Controls.Add(Me.cbbPayment)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDatePaid)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtORNumber)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMyOREntries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OR Entries"
        Me.PanelPassword.ResumeLayout(False)
        Me.PanelPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderDate As ColumnHeader
    Friend WithEvents ColumnHeaderOR As ColumnHeader
    Friend WithEvents ColumnHeaderAmount As ColumnHeader
    Friend WithEvents txtORNumber As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDatePaid As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btCancel As Button
    Friend WithEvents ColumnHeaderProject As ColumnHeader
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ColumnHeaderName As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblClientName As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents ColumnHeaderParticular As ColumnHeader
    Friend WithEvents ColumnHeaderPaymentType As ColumnHeader
    Friend WithEvents cbbPayment As ComboBox
    Friend WithEvents cbbParticular As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtORFilter As TextBox
    Friend WithEvents chbORFilter As CheckBox
    Friend WithEvents btDeleteOR As Button
    Friend WithEvents btnVoidOR As Button
    Friend WithEvents PanelPassword As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btPassCancel As Button
    Friend WithEvents btnOkayPassword As Button
    Friend WithEvents lblMessage As Label
End Class
