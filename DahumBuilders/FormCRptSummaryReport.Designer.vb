<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCRptSummaryReport
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
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        Me.CrystalReportViewerSummary = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelMain.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.PanelBody)
        Me.PanelMain.Controls.Add(Me.PanelHeader)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1321, 643)
        Me.PanelMain.TabIndex = 0
        '
        'PanelHeader
        '
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1321, 68)
        Me.PanelHeader.TabIndex = 0
        '
        'PanelBody
        '
        Me.PanelBody.Controls.Add(Me.CrystalReportViewerSummary)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 68)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1321, 575)
        Me.PanelBody.TabIndex = 1
        '
        'CrystalReportViewerSummary
        '
        Me.CrystalReportViewerSummary.ActiveViewIndex = -1
        Me.CrystalReportViewerSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerSummary.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerSummary.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerSummary.Name = "CrystalReportViewerSummary"
        Me.CrystalReportViewerSummary.Size = New System.Drawing.Size(1321, 575)
        Me.CrystalReportViewerSummary.TabIndex = 0
        '
        'FormCRptSummaryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 643)
        Me.Controls.Add(Me.PanelMain)
        Me.Name = "FormCRptSummaryReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Report"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelBody As Panel
    Friend WithEvents CrystalReportViewerSummary As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
