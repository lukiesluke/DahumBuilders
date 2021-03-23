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
        Me.ListView1.Location = New System.Drawing.Point(16, 143)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1263, 396)
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
        Me.txtORNumber.Location = New System.Drawing.Point(118, 57)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(142, 26)
        Me.txtORNumber.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(118, 90)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(142, 26)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.CustomFormat = "MM/dd/ yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(118, 21)
        Me.dtpDatePaid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(142, 29)
        Me.dtpDatePaid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OR Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OR Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount Paid"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(789, 553)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(161, 38)
        Me.btCancel.TabIndex = 8
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(622, 553)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(161, 38)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(284, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 35)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(284, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 35)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Project"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClientName
        '
        Me.lblClientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClientName.Location = New System.Drawing.Point(365, 18)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(598, 35)
        Me.lblClientName.TabIndex = 11
        Me.lblClientName.Text = "ClientName"
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectName
        '
        Me.lblProjectName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectName.Location = New System.Drawing.Point(365, 61)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(598, 35)
        Me.lblProjectName.TabIndex = 12
        Me.lblProjectName.Text = "ProjectName"
        Me.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbbPayment
        '
        Me.cbbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPayment.FormattingEnabled = True
        Me.cbbPayment.Location = New System.Drawing.Point(365, 104)
        Me.cbbPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbbPayment.Name = "cbbPayment"
        Me.cbbPayment.Size = New System.Drawing.Size(232, 28)
        Me.cbbPayment.TabIndex = 13
        '
        'cbbParticular
        '
        Me.cbbParticular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbParticular.FormattingEnabled = True
        Me.cbbParticular.Location = New System.Drawing.Point(731, 104)
        Me.cbbParticular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbbParticular.Name = "cbbParticular"
        Me.cbbParticular.Size = New System.Drawing.Size(232, 28)
        Me.cbbParticular.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(284, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 35)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Payment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(641, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 35)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Particular"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtORFilter
        '
        Me.txtORFilter.Location = New System.Drawing.Point(1022, 21)
        Me.txtORFilter.Name = "txtORFilter"
        Me.txtORFilter.Size = New System.Drawing.Size(129, 26)
        Me.txtORFilter.TabIndex = 17
        '
        'chbORFilter
        '
        Me.chbORFilter.AutoSize = True
        Me.chbORFilter.Location = New System.Drawing.Point(1163, 23)
        Me.chbORFilter.Name = "chbORFilter"
        Me.chbORFilter.Size = New System.Drawing.Size(98, 24)
        Me.chbORFilter.TabIndex = 18
        Me.chbORFilter.Text = "Filter OR"
        Me.chbORFilter.UseVisualStyleBackColor = True
        '
        'btDeleteOR
        '
        Me.btDeleteOR.Enabled = False
        Me.btDeleteOR.Location = New System.Drawing.Point(421, 553)
        Me.btDeleteOR.Name = "btDeleteOR"
        Me.btDeleteOR.Size = New System.Drawing.Size(161, 38)
        Me.btDeleteOR.TabIndex = 19
        Me.btDeleteOR.Text = "&Delete OR"
        Me.btDeleteOR.UseVisualStyleBackColor = True
        '
        'btnVoidOR
        '
        Me.btnVoidOR.Location = New System.Drawing.Point(254, 553)
        Me.btnVoidOR.Name = "btnVoidOR"
        Me.btnVoidOR.Size = New System.Drawing.Size(161, 38)
        Me.btnVoidOR.TabIndex = 20
        Me.btnVoidOR.Text = "&Void OR"
        Me.btnVoidOR.UseVisualStyleBackColor = True
        '
        'PanelPassword
        '
        Me.PanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPassword.Controls.Add(Me.lblMessage)
        Me.PanelPassword.Controls.Add(Me.btPassCancel)
        Me.PanelPassword.Controls.Add(Me.btnOkayPassword)
        Me.PanelPassword.Controls.Add(Me.Label8)
        Me.PanelPassword.Controls.Add(Me.txtPassword)
        Me.PanelPassword.Location = New System.Drawing.Point(254, 496)
        Me.PanelPassword.Name = "PanelPassword"
        Me.PanelPassword.Size = New System.Drawing.Size(696, 98)
        Me.PanelPassword.TabIndex = 21
        '
        'lblMessage
        '
        Me.lblMessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage.Location = New System.Drawing.Point(7, 68)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(677, 20)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btPassCancel
        '
        Me.btPassCancel.Location = New System.Drawing.Point(501, 18)
        Me.btPassCancel.Name = "btPassCancel"
        Me.btPassCancel.Size = New System.Drawing.Size(161, 38)
        Me.btPassCancel.TabIndex = 3
        Me.btPassCancel.Text = "Cancel"
        Me.btPassCancel.UseVisualStyleBackColor = True
        '
        'btnOkayPassword
        '
        Me.btnOkayPassword.Location = New System.Drawing.Point(334, 18)
        Me.btnOkayPassword.Name = "btnOkayPassword"
        Me.btnOkayPassword.Size = New System.Drawing.Size(161, 38)
        Me.btnOkayPassword.TabIndex = 2
        Me.btnOkayPassword.Text = "Okay"
        Me.btnOkayPassword.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(142, 24)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(171, 26)
        Me.txtPassword.TabIndex = 0
        '
        'FormMyOREntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 606)
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
