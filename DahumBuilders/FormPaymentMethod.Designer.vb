<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaymentMethod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPaymentMethod))
        Me.txtAmountEQ = New System.Windows.Forms.TextBox()
        Me.txtAmountMA = New System.Windows.Forms.TextBox()
        Me.dtpEquityStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpMonthlyStart = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEquityTerm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpEquityEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMATerm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpMonthlyEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblProjectDetails = New System.Windows.Forms.Label()
        Me.lblTCP = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAmountEQ
        '
        Me.txtAmountEQ.Location = New System.Drawing.Point(80, 19)
        Me.txtAmountEQ.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmountEQ.Name = "txtAmountEQ"
        Me.txtAmountEQ.Size = New System.Drawing.Size(97, 20)
        Me.txtAmountEQ.TabIndex = 0
        Me.txtAmountEQ.Text = "0"
        Me.txtAmountEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountMA
        '
        Me.txtAmountMA.Location = New System.Drawing.Point(81, 19)
        Me.txtAmountMA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAmountMA.Name = "txtAmountMA"
        Me.txtAmountMA.Size = New System.Drawing.Size(97, 20)
        Me.txtAmountMA.TabIndex = 4
        Me.txtAmountMA.Text = "0"
        Me.txtAmountMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpEquityStart
        '
        Me.dtpEquityStart.CustomFormat = "MM/dd/yyyy"
        Me.dtpEquityStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEquityStart.Location = New System.Drawing.Point(80, 75)
        Me.dtpEquityStart.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEquityStart.Name = "dtpEquityStart"
        Me.dtpEquityStart.Size = New System.Drawing.Size(97, 20)
        Me.dtpEquityStart.TabIndex = 2
        '
        'dtpMonthlyStart
        '
        Me.dtpMonthlyStart.CustomFormat = "MM/dd/yyyy"
        Me.dtpMonthlyStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthlyStart.Location = New System.Drawing.Point(81, 75)
        Me.dtpMonthlyStart.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpMonthlyStart.Name = "dtpMonthlyStart"
        Me.dtpMonthlyStart.Size = New System.Drawing.Size(97, 20)
        Me.dtpMonthlyStart.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 38)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.06369!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.9363!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(531, 205)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtEquityTerm)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtpEquityEnd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAmountEQ)
        Me.Panel1.Controls.Add(Me.dtpEquityStart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 158)
        Me.Panel1.TabIndex = 0
        '
        'txtEquityTerm
        '
        Me.txtEquityTerm.Location = New System.Drawing.Point(80, 47)
        Me.txtEquityTerm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEquityTerm.Name = "txtEquityTerm"
        Me.txtEquityTerm.Size = New System.Drawing.Size(49, 20)
        Me.txtEquityTerm.TabIndex = 1
        Me.txtEquityTerm.Text = "0"
        Me.txtEquityTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Terms"
        '
        'dtpEquityEnd
        '
        Me.dtpEquityEnd.CustomFormat = "MM/dd/yyyy"
        Me.dtpEquityEnd.Enabled = False
        Me.dtpEquityEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEquityEnd.Location = New System.Drawing.Point(80, 105)
        Me.dtpEquityEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEquityEnd.Name = "dtpEquityEnd"
        Me.dtpEquityEnd.Size = New System.Drawing.Size(97, 20)
        Me.dtpEquityEnd.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "End Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Amount"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtMATerm)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.dtpMonthlyEnd)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtAmountMA)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.dtpMonthlyStart)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(268, 44)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 158)
        Me.Panel2.TabIndex = 1
        '
        'txtMATerm
        '
        Me.txtMATerm.Location = New System.Drawing.Point(81, 48)
        Me.txtMATerm.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMATerm.Name = "txtMATerm"
        Me.txtMATerm.Size = New System.Drawing.Size(49, 20)
        Me.txtMATerm.TabIndex = 5
        Me.txtMATerm.Text = "0"
        Me.txtMATerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 51)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Terms"
        '
        'dtpMonthlyEnd
        '
        Me.dtpMonthlyEnd.CustomFormat = "MM/dd/yyyy"
        Me.dtpMonthlyEnd.Enabled = False
        Me.dtpMonthlyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthlyEnd.Location = New System.Drawing.Point(81, 103)
        Me.dtpMonthlyEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpMonthlyEnd.Name = "dtpMonthlyEnd"
        Me.dtpMonthlyEnd.Size = New System.Drawing.Size(97, 20)
        Me.dtpMonthlyEnd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Start Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Amount"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 36)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monthly Equity"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(268, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 36)
        Me.Panel4.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly Amortization"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(374, 247)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 30)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(459, 247)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 30)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblProjectDetails
        '
        Me.lblProjectDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectDetails.Location = New System.Drawing.Point(11, 10)
        Me.lblProjectDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProjectDetails.Name = "lblProjectDetails"
        Me.lblProjectDetails.Size = New System.Drawing.Size(412, 26)
        Me.lblProjectDetails.TabIndex = 10
        Me.lblProjectDetails.Text = "lblProjectDetails"
        Me.lblProjectDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTCP
        '
        Me.lblTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCP.Location = New System.Drawing.Point(427, 10)
        Me.lblTCP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTCP.Name = "lblTCP"
        Me.lblTCP.Size = New System.Drawing.Size(113, 26)
        Me.lblTCP.TabIndex = 11
        Me.lblTCP.Text = "lblTCP"
        Me.lblTCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1Id, Me.ColumnHeader1Type, Me.ColumnHeader2DueDate, Me.ColumnHeader3Amount})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(545, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(257, 237)
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1Type
        '
        Me.ColumnHeader1Type.Text = "Type"
        '
        'ColumnHeader2DueDate
        '
        Me.ColumnHeader2DueDate.Text = "Due Date"
        Me.ColumnHeader2DueDate.Width = 80
        '
        'ColumnHeader3Amount
        '
        Me.ColumnHeader3Amount.Text = "Amount"
        Me.ColumnHeader3Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3Amount.Width = 80
        '
        'ColumnHeader1Id
        '
        Me.ColumnHeader1Id.Text = "ID"
        Me.ColumnHeader1Id.Width = 0
        '
        'FormPaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 287)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblTCP)
        Me.Controls.Add(Me.lblProjectDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FormPaymentMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Method Setting"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAmountEQ As TextBox
    Friend WithEvents txtAmountMA As TextBox
    Friend WithEvents dtpEquityStart As DateTimePicker
    Friend WithEvents dtpMonthlyStart As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpEquityEnd As DateTimePicker
    Friend WithEvents dtpMonthlyEnd As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtMATerm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEquityTerm As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblProjectDetails As Label
    Friend WithEvents lblTCP As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1Type As ColumnHeader
    Friend WithEvents ColumnHeader2DueDate As ColumnHeader
    Friend WithEvents ColumnHeader3Amount As ColumnHeader
    Friend WithEvents ColumnHeader1Id As ColumnHeader
End Class
