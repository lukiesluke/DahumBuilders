<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategorySetting
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEmpType = New System.Windows.Forms.TabPage()
        Me.lblAddEmp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelEmp = New System.Windows.Forms.Button()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNameEmp = New System.Windows.Forms.TextBox()
        Me.btnUpdateEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.ListViewEmpType = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuEmpType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPageExpType = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblExpID = New System.Windows.Forms.Label()
        Me.lblAddExp = New System.Windows.Forms.Label()
        Me.btnCancelExp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameExp = New System.Windows.Forms.TextBox()
        Me.btnUpdateExp = New System.Windows.Forms.Button()
        Me.btnAddExp = New System.Windows.Forms.Button()
        Me.ListViewExpType = New System.Windows.Forms.ListView()
        Me.ColumnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNameType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnShortName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuExpType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditExpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPageEmpType.SuspendLayout()
        Me.ContextMenuEmpType.SuspendLayout()
        Me.TabPageExpType.SuspendLayout()
        Me.ContextMenuExpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageEmpType)
        Me.TabControl1.Controls.Add(Me.TabPageExpType)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(350, 336)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageEmpType
        '
        Me.TabPageEmpType.Controls.Add(Me.lblAddEmp)
        Me.TabPageEmpType.Controls.Add(Me.Label3)
        Me.TabPageEmpType.Controls.Add(Me.btnCancelEmp)
        Me.TabPageEmpType.Controls.Add(Me.lblEmpID)
        Me.TabPageEmpType.Controls.Add(Me.Label2)
        Me.TabPageEmpType.Controls.Add(Me.txtNameEmp)
        Me.TabPageEmpType.Controls.Add(Me.btnUpdateEmp)
        Me.TabPageEmpType.Controls.Add(Me.btnAddEmp)
        Me.TabPageEmpType.Controls.Add(Me.ListViewEmpType)
        Me.TabPageEmpType.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmpType.Name = "TabPageEmpType"
        Me.TabPageEmpType.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmpType.Size = New System.Drawing.Size(342, 310)
        Me.TabPageEmpType.TabIndex = 0
        Me.TabPageEmpType.Text = "Employee Type"
        Me.TabPageEmpType.UseVisualStyleBackColor = True
        '
        'lblAddEmp
        '
        Me.lblAddEmp.AutoSize = True
        Me.lblAddEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmp.ForeColor = System.Drawing.Color.Green
        Me.lblAddEmp.Location = New System.Drawing.Point(256, 4)
        Me.lblAddEmp.Name = "lblAddEmp"
        Me.lblAddEmp.Size = New System.Drawing.Size(24, 25)
        Me.lblAddEmp.TabIndex = 13
        Me.lblAddEmp.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID"
        '
        'btnCancelEmp
        '
        Me.btnCancelEmp.Location = New System.Drawing.Point(261, 33)
        Me.btnCancelEmp.Name = "btnCancelEmp"
        Me.btnCancelEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelEmp.TabIndex = 11
        Me.btnCancelEmp.Text = "&Cancel"
        Me.btnCancelEmp.UseVisualStyleBackColor = True
        '
        'lblEmpID
        '
        Me.lblEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEmpID.Location = New System.Drawing.Point(43, 34)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(74, 13)
        Me.lblEmpID.TabIndex = 10
        Me.lblEmpID.Text = "lblEmpID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'txtNameEmp
        '
        Me.txtNameEmp.Location = New System.Drawing.Point(46, 7)
        Me.txtNameEmp.Name = "txtNameEmp"
        Me.txtNameEmp.Size = New System.Drawing.Size(209, 20)
        Me.txtNameEmp.TabIndex = 8
        '
        'btnUpdateEmp
        '
        Me.btnUpdateEmp.Location = New System.Drawing.Point(261, 5)
        Me.btnUpdateEmp.Name = "btnUpdateEmp"
        Me.btnUpdateEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateEmp.TabIndex = 7
        Me.btnUpdateEmp.Text = "&Update"
        Me.btnUpdateEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(261, 4)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnAddEmp.TabIndex = 6
        Me.btnAddEmp.Text = "&Add"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'ListViewEmpType
        '
        Me.ListViewEmpType.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderType})
        Me.ListViewEmpType.ContextMenuStrip = Me.ContextMenuEmpType
        Me.ListViewEmpType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListViewEmpType.FullRowSelect = True
        Me.ListViewEmpType.GridLines = True
        Me.ListViewEmpType.Location = New System.Drawing.Point(3, 63)
        Me.ListViewEmpType.Name = "ListViewEmpType"
        Me.ListViewEmpType.Size = New System.Drawing.Size(336, 244)
        Me.ListViewEmpType.TabIndex = 5
        Me.ListViewEmpType.UseCompatibleStateImageBehavior = False
        Me.ListViewEmpType.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 0
        '
        'ColumnHeaderType
        '
        Me.ColumnHeaderType.Text = "Type"
        Me.ColumnHeaderType.Width = 250
        '
        'ContextMenuEmpType
        '
        Me.ContextMenuEmpType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuEmpType.Name = "ContextMenuEmpType"
        Me.ContextMenuEmpType.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'TabPageExpType
        '
        Me.TabPageExpType.Controls.Add(Me.Label5)
        Me.TabPageExpType.Controls.Add(Me.txtShortName)
        Me.TabPageExpType.Controls.Add(Me.Label4)
        Me.TabPageExpType.Controls.Add(Me.lblExpID)
        Me.TabPageExpType.Controls.Add(Me.lblAddExp)
        Me.TabPageExpType.Controls.Add(Me.btnCancelExp)
        Me.TabPageExpType.Controls.Add(Me.Label1)
        Me.TabPageExpType.Controls.Add(Me.txtNameExp)
        Me.TabPageExpType.Controls.Add(Me.btnUpdateExp)
        Me.TabPageExpType.Controls.Add(Me.btnAddExp)
        Me.TabPageExpType.Controls.Add(Me.ListViewExpType)
        Me.TabPageExpType.Location = New System.Drawing.Point(4, 22)
        Me.TabPageExpType.Name = "TabPageExpType"
        Me.TabPageExpType.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageExpType.Size = New System.Drawing.Size(342, 310)
        Me.TabPageExpType.TabIndex = 1
        Me.TabPageExpType.Text = "Expenses Type"
        Me.TabPageExpType.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Short Name"
        '
        'txtShortName
        '
        Me.txtShortName.Location = New System.Drawing.Point(79, 34)
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(169, 20)
        Me.txtShortName.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ID"
        '
        'lblExpID
        '
        Me.lblExpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblExpID.Location = New System.Drawing.Point(79, 62)
        Me.lblExpID.Name = "lblExpID"
        Me.lblExpID.Size = New System.Drawing.Size(74, 13)
        Me.lblExpID.TabIndex = 16
        Me.lblExpID.Text = "lblExpID"
        '
        'lblAddExp
        '
        Me.lblAddExp.AutoSize = True
        Me.lblAddExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddExp.ForeColor = System.Drawing.Color.Green
        Me.lblAddExp.Location = New System.Drawing.Point(249, 6)
        Me.lblAddExp.Name = "lblAddExp"
        Me.lblAddExp.Size = New System.Drawing.Size(24, 25)
        Me.lblAddExp.TabIndex = 15
        Me.lblAddExp.Text = "+"
        '
        'btnCancelExp
        '
        Me.btnCancelExp.Location = New System.Drawing.Point(254, 34)
        Me.btnCancelExp.Name = "btnCancelExp"
        Me.btnCancelExp.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelExp.TabIndex = 14
        Me.btnCancelExp.Text = "&Cancel"
        Me.btnCancelExp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'txtNameExp
        '
        Me.txtNameExp.Location = New System.Drawing.Point(79, 8)
        Me.txtNameExp.Name = "txtNameExp"
        Me.txtNameExp.Size = New System.Drawing.Size(169, 20)
        Me.txtNameExp.TabIndex = 3
        '
        'btnUpdateExp
        '
        Me.btnUpdateExp.Location = New System.Drawing.Point(254, 6)
        Me.btnUpdateExp.Name = "btnUpdateExp"
        Me.btnUpdateExp.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateExp.TabIndex = 2
        Me.btnUpdateExp.Text = "&Update"
        Me.btnUpdateExp.UseVisualStyleBackColor = True
        '
        'btnAddExp
        '
        Me.btnAddExp.Location = New System.Drawing.Point(254, 6)
        Me.btnAddExp.Name = "btnAddExp"
        Me.btnAddExp.Size = New System.Drawing.Size(75, 23)
        Me.btnAddExp.TabIndex = 1
        Me.btnAddExp.Text = "&Add"
        Me.btnAddExp.UseVisualStyleBackColor = True
        '
        'ListViewExpType
        '
        Me.ListViewExpType.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnID, Me.ColumnNameType, Me.ColumnShortName})
        Me.ListViewExpType.ContextMenuStrip = Me.ContextMenuExpType
        Me.ListViewExpType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListViewExpType.FullRowSelect = True
        Me.ListViewExpType.GridLines = True
        Me.ListViewExpType.Location = New System.Drawing.Point(3, 78)
        Me.ListViewExpType.Name = "ListViewExpType"
        Me.ListViewExpType.Size = New System.Drawing.Size(336, 229)
        Me.ListViewExpType.TabIndex = 0
        Me.ListViewExpType.UseCompatibleStateImageBehavior = False
        Me.ListViewExpType.View = System.Windows.Forms.View.Details
        '
        'ColumnID
        '
        Me.ColumnID.Text = "ID"
        Me.ColumnID.Width = 0
        '
        'ColumnNameType
        '
        Me.ColumnNameType.Text = "Name Type"
        Me.ColumnNameType.Width = 130
        '
        'ColumnShortName
        '
        Me.ColumnShortName.Text = "Short Name"
        Me.ColumnShortName.Width = 130
        '
        'ContextMenuExpType
        '
        Me.ContextMenuExpType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditExpToolStripMenuItem1})
        Me.ContextMenuExpType.Name = "ContextMenuExpType"
        Me.ContextMenuExpType.Size = New System.Drawing.Size(95, 26)
        '
        'EditExpToolStripMenuItem1
        '
        Me.EditExpToolStripMenuItem1.Name = "EditExpToolStripMenuItem1"
        Me.EditExpToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EditExpToolStripMenuItem1.Text = "&Edit"
        '
        'FormCategorySetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 360)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormCategorySetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Setting"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageEmpType.ResumeLayout(False)
        Me.TabPageEmpType.PerformLayout()
        Me.ContextMenuEmpType.ResumeLayout(False)
        Me.TabPageExpType.ResumeLayout(False)
        Me.TabPageExpType.PerformLayout()
        Me.ContextMenuExpType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageEmpType As TabPage
    Friend WithEvents TabPageExpType As TabPage
    Friend WithEvents btnAddExp As Button
    Friend WithEvents ListViewExpType As ListView
    Friend WithEvents btnUpdateExp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNameEmp As TextBox
    Friend WithEvents btnUpdateEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents ListViewEmpType As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNameExp As TextBox
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderType As ColumnHeader
    Friend WithEvents lblEmpID As Label
    Friend WithEvents ContextMenuEmpType As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCancelEmp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAddEmp As Label
    Friend WithEvents lblAddExp As Label
    Friend WithEvents btnCancelExp As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblExpID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtShortName As TextBox
    Friend WithEvents ColumnID As ColumnHeader
    Friend WithEvents ColumnNameType As ColumnHeader
    Friend WithEvents ColumnShortName As ColumnHeader
    Friend WithEvents ContextMenuExpType As ContextMenuStrip
    Friend WithEvents EditExpToolStripMenuItem1 As ToolStripMenuItem
End Class
