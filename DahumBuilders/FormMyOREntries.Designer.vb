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
        Me.ColumnHeaderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderDate, Me.ColumnHeaderOR, Me.ColumnHeaderAmount, Me.ColumnHeaderDescription})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(16, 143)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(873, 396)
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
        Me.ColumnHeaderDate.Width = 100
        '
        'ColumnHeaderOR
        '
        Me.ColumnHeaderOR.Text = "OR Number"
        Me.ColumnHeaderOR.Width = 100
        '
        'ColumnHeaderAmount
        '
        Me.ColumnHeaderAmount.Text = "Amount"
        Me.ColumnHeaderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAmount.Width = 100
        '
        'ColumnHeaderDescription
        '
        Me.ColumnHeaderDescription.Text = "Description"
        Me.ColumnHeaderDescription.Width = 250
        '
        'txtORNumber
        '
        Me.txtORNumber.Location = New System.Drawing.Point(118, 58)
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
        Me.dtpDatePaid.CustomFormat = "dd/MM/ yyyy"
        Me.dtpDatePaid.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDatePaid.Location = New System.Drawing.Point(118, 24)
        Me.dtpDatePaid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(142, 29)
        Me.dtpDatePaid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OR Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OR Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount Paid"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(729, 545)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(161, 38)
        Me.btCancel.TabIndex = 8
        Me.btCancel.Text = "&Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(562, 546)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(161, 38)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'FormMyOREntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 596)
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
    Friend WithEvents ColumnHeaderDescription As ColumnHeader
    Friend WithEvents btnUpdate As Button
End Class
