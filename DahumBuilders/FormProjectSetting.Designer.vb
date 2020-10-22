<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProjectSetting
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
        Me.cbbProjectName = New System.Windows.Forms.ComboBox()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSqm = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbbProjectName
        '
        Me.cbbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProjectName.FormattingEnabled = True
        Me.cbbProjectName.Location = New System.Drawing.Point(142, 41)
        Me.cbbProjectName.Name = "cbbProjectName"
        Me.cbbProjectName.Size = New System.Drawing.Size(298, 28)
        Me.cbbProjectName.TabIndex = 3
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(142, 78)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(100, 26)
        Me.txtBlock.TabIndex = 4
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(142, 112)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(100, 26)
        Me.txtLot.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(142, 181)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(146, 39)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Project Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Block"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lot"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Square Meter"
        '
        'txtSqm
        '
        Me.txtSqm.Location = New System.Drawing.Point(142, 147)
        Me.txtSqm.Name = "txtSqm"
        Me.txtSqm.Size = New System.Drawing.Size(100, 26)
        Me.txtSqm.TabIndex = 11
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(294, 181)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 39)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FormProjectSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 238)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtSqm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtLot)
        Me.Controls.Add(Me.txtBlock)
        Me.Controls.Add(Me.cbbProjectName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProjectSetting"
        Me.Text = "Project Control Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbbProjectName As ComboBox
    Friend WithEvents txtBlock As TextBox
    Friend WithEvents txtLot As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSqm As TextBox
    Friend WithEvents btnCancel As Button
End Class
