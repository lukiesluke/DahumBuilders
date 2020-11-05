<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesReport
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
        Me.ListViewReport = New System.Windows.Forms.ListView()
        Me.ColumnHeaderOR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderParticular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPayment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListViewReport
        '
        Me.ListViewReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderOR, Me.ColumnHeaderName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderAmount, Me.ColumnHeaderParticular, Me.ColumnHeaderPayment})
        Me.ListViewReport.FullRowSelect = True
        Me.ListViewReport.GridLines = True
        Me.ListViewReport.Location = New System.Drawing.Point(28, 33)
        Me.ListViewReport.Name = "ListViewReport"
        Me.ListViewReport.Size = New System.Drawing.Size(1234, 548)
        Me.ListViewReport.TabIndex = 0
        Me.ListViewReport.UseCompatibleStateImageBehavior = False
        Me.ListViewReport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderOR
        '
        Me.ColumnHeaderOR.Text = "O.R No."
        Me.ColumnHeaderOR.Width = 80
        '
        'ColumnHeaderName
        '
        Me.ColumnHeaderName.Text = "Member Name"
        Me.ColumnHeaderName.Width = 150
        '
        'ColumnHeaderBlock
        '
        Me.ColumnHeaderBlock.Text = "Block"
        Me.ColumnHeaderBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeaderLot
        '
        Me.ColumnHeaderLot.Text = "Lot"
        Me.ColumnHeaderLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeaderSQM
        '
        Me.ColumnHeaderSQM.Text = "SQM"
        Me.ColumnHeaderSQM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeaderAmount
        '
        Me.ColumnHeaderAmount.Text = "Amount"
        Me.ColumnHeaderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderAmount.Width = 100
        '
        'ColumnHeaderParticular
        '
        Me.ColumnHeaderParticular.Text = "Particular"
        Me.ColumnHeaderParticular.Width = 120
        '
        'ColumnHeaderPayment
        '
        Me.ColumnHeaderPayment.Text = "Payment Type"
        Me.ColumnHeaderPayment.Width = 80
        '
        'FormSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 616)
        Me.Controls.Add(Me.ListViewReport)
        Me.Name = "FormSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewReport As ListView
    Friend WithEvents ColumnHeaderOR As ColumnHeader
    Friend WithEvents ColumnHeaderName As ColumnHeader
    Friend WithEvents ColumnHeaderBlock As ColumnHeader
    Friend WithEvents ColumnHeaderLot As ColumnHeader
    Friend WithEvents ColumnHeaderSQM As ColumnHeader
    Friend WithEvents ColumnHeaderAmount As ColumnHeader
    Friend WithEvents ColumnHeaderParticular As ColumnHeader
    Friend WithEvents ColumnHeaderPayment As ColumnHeader
End Class
