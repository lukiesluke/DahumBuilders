<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProjectList
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
        Me.ListViewProject = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderProjectName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderAssignUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAvailable = New System.Windows.Forms.CheckBox()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbProjectName = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProjectSQM = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblProjectTCP = New System.Windows.Forms.Label()
        Me.lblProjectBlock = New System.Windows.Forms.Label()
        Me.lblProjectLot = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProjectAssignedToUser = New System.Windows.Forms.Label()
        Me.lblProjectItemID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewProject
        '
        Me.ListViewProject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderProjectName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderPrice, Me.ColumnHeaderAssignUser})
        Me.ListViewProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewProject.FullRowSelect = True
        Me.ListViewProject.GridLines = True
        Me.ListViewProject.Location = New System.Drawing.Point(3, 100)
        Me.ListViewProject.Name = "ListViewProject"
        Me.ListViewProject.Size = New System.Drawing.Size(815, 386)
        Me.ListViewProject.TabIndex = 0
        Me.ListViewProject.UseCompatibleStateImageBehavior = False
        Me.ListViewProject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 0
        '
        'ColumnHeaderProjectName
        '
        Me.ColumnHeaderProjectName.Text = "Project Name"
        Me.ColumnHeaderProjectName.Width = 120
        '
        'ColumnHeaderBlock
        '
        Me.ColumnHeaderBlock.Text = "Block"
        Me.ColumnHeaderBlock.Width = 70
        '
        'ColumnHeaderLot
        '
        Me.ColumnHeaderLot.Text = "Lot"
        Me.ColumnHeaderLot.Width = 50
        '
        'ColumnHeaderSQM
        '
        Me.ColumnHeaderSQM.Text = "SQM"
        Me.ColumnHeaderSQM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderSQM.Width = 50
        '
        'ColumnHeaderPrice
        '
        Me.ColumnHeaderPrice.Text = "Price"
        Me.ColumnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderPrice.Width = 80
        '
        'ColumnHeaderAssignUser
        '
        Me.ColumnHeaderAssignUser.Text = "Assigned"
        Me.ColumnHeaderAssignUser.Width = 150
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 445.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListViewProject, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0409!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.9591!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1266, 489)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkAvailable)
        Me.Panel1.Controls.Add(Me.txtBlock)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbbProjectName)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 91)
        Me.Panel1.TabIndex = 1
        '
        'chkAvailable
        '
        Me.chkAvailable.AutoSize = True
        Me.chkAvailable.Location = New System.Drawing.Point(236, 54)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Size = New System.Drawing.Size(177, 24)
        Me.chkAvailable.TabIndex = 6
        Me.chkAvailable.Text = "Show Available Only"
        Me.chkAvailable.UseVisualStyleBackColor = True
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(128, 52)
        Me.txtBlock.MaxLength = 5
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(94, 26)
        Me.txtBlock.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Block"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Project Name"
        '
        'cbbProjectName
        '
        Me.cbbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProjectName.FormattingEnabled = True
        Me.cbbProjectName.Location = New System.Drawing.Point(128, 16)
        Me.cbbProjectName.Name = "cbbProjectName"
        Me.cbbProjectName.Size = New System.Drawing.Size(290, 28)
        Me.cbbProjectName.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(434, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 66)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAssign)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(824, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(439, 386)
        Me.Panel2.TabIndex = 2
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(21, 275)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(402, 43)
        Me.btnAssign.TabIndex = 6
        Me.btnAssign.Text = "&Assign"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblProjectSQM)
        Me.GroupBox1.Controls.Add(Me.lblProjectName)
        Me.GroupBox1.Controls.Add(Me.lblProjectTCP)
        Me.GroupBox1.Controls.Add(Me.lblProjectBlock)
        Me.GroupBox1.Controls.Add(Me.lblProjectLot)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblProjectAssignedToUser)
        Me.GroupBox1.Controls.Add(Me.lblProjectItemID)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 254)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lot Information"
        '
        'lblProjectSQM
        '
        Me.lblProjectSQM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectSQM.Location = New System.Drawing.Point(70, 144)
        Me.lblProjectSQM.Name = "lblProjectSQM"
        Me.lblProjectSQM.Size = New System.Drawing.Size(315, 29)
        Me.lblProjectSQM.TabIndex = 12
        Me.lblProjectSQM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectName
        '
        Me.lblProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectName.Location = New System.Drawing.Point(70, 48)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(315, 29)
        Me.lblProjectName.TabIndex = 1
        Me.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectTCP
        '
        Me.lblProjectTCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectTCP.Location = New System.Drawing.Point(70, 177)
        Me.lblProjectTCP.Name = "lblProjectTCP"
        Me.lblProjectTCP.Size = New System.Drawing.Size(315, 29)
        Me.lblProjectTCP.TabIndex = 4
        Me.lblProjectTCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjectBlock
        '
        Me.lblProjectBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectBlock.Location = New System.Drawing.Point(70, 80)
        Me.lblProjectBlock.Name = "lblProjectBlock"
        Me.lblProjectBlock.Size = New System.Drawing.Size(315, 29)
        Me.lblProjectBlock.TabIndex = 2
        Me.lblProjectBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectLot
        '
        Me.lblProjectLot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjectLot.Location = New System.Drawing.Point(70, 112)
        Me.lblProjectLot.Name = "lblProjectLot"
        Me.lblProjectLot.Size = New System.Drawing.Size(315, 29)
        Me.lblProjectLot.TabIndex = 3
        Me.lblProjectLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "SQM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "TCP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lot"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Block"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name"
        '
        'lblProjectAssignedToUser
        '
        Me.lblProjectAssignedToUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectAssignedToUser.Location = New System.Drawing.Point(30, 219)
        Me.lblProjectAssignedToUser.Name = "lblProjectAssignedToUser"
        Me.lblProjectAssignedToUser.Size = New System.Drawing.Size(355, 20)
        Me.lblProjectAssignedToUser.TabIndex = 6
        Me.lblProjectAssignedToUser.Text = "lblProjectAssignedToUser"
        Me.lblProjectAssignedToUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjectItemID
        '
        Me.lblProjectItemID.Location = New System.Drawing.Point(263, 25)
        Me.lblProjectItemID.Name = "lblProjectItemID"
        Me.lblProjectItemID.Size = New System.Drawing.Size(122, 20)
        Me.lblProjectItemID.TabIndex = 5
        Me.lblProjectItemID.Text = "000000"
        Me.lblProjectItemID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(21, 324)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(402, 31)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormProjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 564)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProjectList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project List"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewProject As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderProjectName As ColumnHeader
    Friend WithEvents ColumnHeaderBlock As ColumnHeader
    Friend WithEvents ColumnHeaderLot As ColumnHeader
    Friend WithEvents ColumnHeaderAssignUser As ColumnHeader
    Friend WithEvents ColumnHeaderSQM As ColumnHeader
    Friend WithEvents ColumnHeaderPrice As ColumnHeader
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents cbbProjectName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBlock As TextBox
    Friend WithEvents chkAvailable As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblProjectLot As Label
    Friend WithEvents lblProjectBlock As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents lblProjectTCP As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAssign As Button
    Friend WithEvents lblProjectItemID As Label
    Friend WithEvents lblProjectAssignedToUser As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProjectSQM As Label
    Friend WithEvents Label7 As Label
End Class
