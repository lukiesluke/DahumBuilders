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
        Me.CrystalReportViewerExpenses.Size = New System.Drawing.Size(1194, 590)
        Me.CrystalReportViewerExpenses.TabIndex = 0
        Me.CrystalReportViewerExpenses.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormCRptExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 590)
        Me.Controls.Add(Me.CrystalReportViewerExpenses)
        Me.Name = "FormCRptExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCRptExpenses"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewerExpenses As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
