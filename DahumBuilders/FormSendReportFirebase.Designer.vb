<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSendReportFirebase
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
        Me.btnSendReport = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSendReport
        '
        Me.btnSendReport.Location = New System.Drawing.Point(227, 58)
        Me.btnSendReport.Name = "btnSendReport"
        Me.btnSendReport.Size = New System.Drawing.Size(140, 49)
        Me.btnSendReport.TabIndex = 0
        Me.btnSendReport.Text = "Send Report"
        Me.btnSendReport.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(12, 121)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(567, 23)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "lblStatus"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormSendReportFirebase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 170)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSendReport)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSendReportFirebase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Report to Live Database "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSendReport As Button
    Friend WithEvents lblStatus As Label
End Class
