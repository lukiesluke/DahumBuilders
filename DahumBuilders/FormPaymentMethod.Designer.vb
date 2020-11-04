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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAmountEQ
        '
        Me.txtAmountEQ.Location = New System.Drawing.Point(120, 30)
        Me.txtAmountEQ.Name = "txtAmountEQ"
        Me.txtAmountEQ.Size = New System.Drawing.Size(143, 26)
        Me.txtAmountEQ.TabIndex = 0
        Me.txtAmountEQ.Text = "0"
        Me.txtAmountEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountMA
        '
        Me.txtAmountMA.Location = New System.Drawing.Point(121, 29)
        Me.txtAmountMA.Name = "txtAmountMA"
        Me.txtAmountMA.Size = New System.Drawing.Size(143, 26)
        Me.txtAmountMA.TabIndex = 4
        Me.txtAmountMA.Text = "0"
        Me.txtAmountMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpEquityStart
        '
        Me.dtpEquityStart.CustomFormat = "MM/dd/yyyy"
        Me.dtpEquityStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEquityStart.Location = New System.Drawing.Point(120, 115)
        Me.dtpEquityStart.Name = "dtpEquityStart"
        Me.dtpEquityStart.Size = New System.Drawing.Size(143, 26)
        Me.dtpEquityStart.TabIndex = 2
        '
        'dtpMonthlyStart
        '
        Me.dtpMonthlyStart.CustomFormat = "MM/dd/yyyy"
        Me.dtpMonthlyStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthlyStart.Location = New System.Drawing.Point(121, 116)
        Me.dtpMonthlyStart.Name = "dtpMonthlyStart"
        Me.dtpMonthlyStart.Size = New System.Drawing.Size(143, 26)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 58)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.06369!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.9363!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(797, 315)
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
        Me.Panel1.Location = New System.Drawing.Point(4, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 244)
        Me.Panel1.TabIndex = 0
        '
        'txtEquityTerm
        '
        Me.txtEquityTerm.Location = New System.Drawing.Point(120, 72)
        Me.txtEquityTerm.Name = "txtEquityTerm"
        Me.txtEquityTerm.Size = New System.Drawing.Size(71, 26)
        Me.txtEquityTerm.TabIndex = 1
        Me.txtEquityTerm.Text = "0"
        Me.txtEquityTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Terms"
        '
        'dtpEquityEnd
        '
        Me.dtpEquityEnd.CustomFormat = "MM/dd/yyyy"
        Me.dtpEquityEnd.Enabled = False
        Me.dtpEquityEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEquityEnd.Location = New System.Drawing.Point(120, 162)
        Me.dtpEquityEnd.Name = "dtpEquityEnd"
        Me.dtpEquityEnd.Size = New System.Drawing.Size(143, 26)
        Me.dtpEquityEnd.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "End Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Start Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
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
        Me.Panel2.Location = New System.Drawing.Point(402, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 244)
        Me.Panel2.TabIndex = 1
        '
        'txtMATerm
        '
        Me.txtMATerm.Location = New System.Drawing.Point(121, 74)
        Me.txtMATerm.Name = "txtMATerm"
        Me.txtMATerm.Size = New System.Drawing.Size(71, 26)
        Me.txtMATerm.TabIndex = 5
        Me.txtMATerm.Text = "0"
        Me.txtMATerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Terms"
        '
        'dtpMonthlyEnd
        '
        Me.dtpMonthlyEnd.CustomFormat = "MM/dd/yyyy"
        Me.dtpMonthlyEnd.Enabled = False
        Me.dtpMonthlyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthlyEnd.Location = New System.Drawing.Point(121, 158)
        Me.dtpMonthlyEnd.Name = "dtpMonthlyEnd"
        Me.dtpMonthlyEnd.Size = New System.Drawing.Size(143, 26)
        Me.dtpMonthlyEnd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Start Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Amount"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 56)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monthly Equity"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(402, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(391, 56)
        Me.Panel4.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly Amortization"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(561, 380)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 46)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Save"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(688, 380)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 46)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblProjectDetails
        '
        Me.lblProjectDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectDetails.Location = New System.Drawing.Point(16, 15)
        Me.lblProjectDetails.Name = "lblProjectDetails"
        Me.lblProjectDetails.Size = New System.Drawing.Size(618, 40)
        Me.lblProjectDetails.TabIndex = 10
        Me.lblProjectDetails.Text = "lblProjectDetails"
        Me.lblProjectDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTCP
        '
        Me.lblTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCP.Location = New System.Drawing.Point(640, 15)
        Me.lblTCP.Name = "lblTCP"
        Me.lblTCP.Size = New System.Drawing.Size(169, 40)
        Me.lblTCP.TabIndex = 11
        Me.lblTCP.Text = "lblTCP"
        Me.lblTCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormPaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 441)
        Me.Controls.Add(Me.lblTCP)
        Me.Controls.Add(Me.lblProjectDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
End Class
