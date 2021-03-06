<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCRptExpenses
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
        Me.CrystalReportViewerExpenses = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelBaseLayout = New System.Windows.Forms.Panel()
        Me.PanelReportView = New System.Windows.Forms.Panel()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PanelBaseLayout.SuspendLayout()
        Me.PanelReportView.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewerExpenses
        '
        Me.CrystalReportViewerExpenses.ActiveViewIndex = -1
        Me.CrystalReportViewerExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerExpenses.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerExpenses.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerExpenses.Name = "CrystalReportViewerExpenses"
        Me.CrystalReportViewerExpenses.Size = New System.Drawing.Size(1216, 573)
        Me.CrystalReportViewerExpenses.TabIndex = 0
        Me.CrystalReportViewerExpenses.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PanelBaseLayout
        '
        Me.PanelBaseLayout.Controls.Add(Me.PanelReportView)
        Me.PanelBaseLayout.Controls.Add(Me.PanelSearch)
        Me.PanelBaseLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBaseLayout.Location = New System.Drawing.Point(0, 0)
        Me.PanelBaseLayout.Name = "PanelBaseLayout"
        Me.PanelBaseLayout.Size = New System.Drawing.Size(1216, 667)
        Me.PanelBaseLayout.TabIndex = 1
        '
        'PanelReportView
        '
        Me.PanelReportView.Controls.Add(Me.CrystalReportViewerExpenses)
        Me.PanelReportView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelReportView.Location = New System.Drawing.Point(0, 94)
        Me.PanelReportView.Name = "PanelReportView"
        Me.PanelReportView.Size = New System.Drawing.Size(1216, 573)
        Me.PanelReportView.TabIndex = 1
        '
        'PanelSearch
        '
        Me.PanelSearch.Controls.Add(Me.dtpTo)
        Me.PanelSearch.Controls.Add(Me.Label3)
        Me.PanelSearch.Controls.Add(Me.dtpFrom)
        Me.PanelSearch.Controls.Add(Me.Label2)
        Me.PanelSearch.Controls.Add(Me.btnSearch)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 0)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(1216, 94)
        Me.PanelSearch.TabIndex = 12
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(655, 31)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(139, 26)
        Me.dtpTo.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(477, 31)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(139, 26)
        Me.dtpFrom.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(622, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(800, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 47)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "S&earch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FormCRptExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 667)
        Me.Controls.Add(Me.PanelBaseLayout)
        Me.Name = "FormCRptExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expenses Report"
        Me.PanelBaseLayout.ResumeLayout(False)
        Me.PanelReportView.ResumeLayout(False)
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerExpenses As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PanelBaseLayout As Panel
    Friend WithEvents PanelReportView As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents PanelSearch As Panel
End Class
