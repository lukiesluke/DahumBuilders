<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCRptSalesReport
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
        Me.CrystalReportViewerSales = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewerSales
        '
        Me.CrystalReportViewerSales.ActiveViewIndex = -1
        Me.CrystalReportViewerSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerSales.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerSales.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerSales.Name = "CrystalReportViewerSales"
        Me.CrystalReportViewerSales.Size = New System.Drawing.Size(1289, 540)
        Me.CrystalReportViewerSales.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 616)
        Me.Panel1.TabIndex = 2
        '
        'PanelHeader
        '
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1289, 76)
        Me.PanelHeader.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CrystalReportViewerSales)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1289, 540)
        Me.Panel2.TabIndex = 3
        '
        'FormCRptSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 616)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCRptSalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerSales As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel2 As Panel
End Class
