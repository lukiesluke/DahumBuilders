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
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbProjectName = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chkAvailable = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewProject
        '
        Me.ListViewProject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderProjectName, Me.ColumnHeaderBlock, Me.ColumnHeaderLot, Me.ColumnHeaderSQM, Me.ColumnHeaderPrice, Me.ColumnHeaderAssignUser})
        Me.ListViewProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewProject.FullRowSelect = True
        Me.ListViewProject.GridLines = True
        Me.ListViewProject.Location = New System.Drawing.Point(3, 68)
        Me.ListViewProject.Name = "ListViewProject"
        Me.ListViewProject.Size = New System.Drawing.Size(1065, 418)
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
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListViewProject, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.3995!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.60049!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1071, 489)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAvailable)
        Me.Panel1.Controls.Add(Me.txtBlock)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbbProjectName)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 59)
        Me.Panel1.TabIndex = 1
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(526, 18)
        Me.txtBlock.MaxLength = 5
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(112, 26)
        Me.txtBlock.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Block"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
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
        Me.cbbProjectName.Size = New System.Drawing.Size(338, 28)
        Me.cbbProjectName.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(897, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(151, 38)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chkAvailable
        '
        Me.chkAvailable.AutoSize = True
        Me.chkAvailable.Location = New System.Drawing.Point(655, 18)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Size = New System.Drawing.Size(177, 24)
        Me.chkAvailable.TabIndex = 6
        Me.chkAvailable.Text = "Show Available Only"
        Me.chkAvailable.UseVisualStyleBackColor = True
        '
        'FormProjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 564)
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
End Class
