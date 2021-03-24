<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProjectPriceList
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSQM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbbProjectName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTcp = New System.Windows.Forms.TextBox()
        Me.txtSQM = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelUpdate = New System.Windows.Forms.Panel()
        Me.ID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUpProjectName = New System.Windows.Forms.Label()
        Me.lblUpdateID = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUpdateTCP = New System.Windows.Forms.TextBox()
        Me.txtUpdateSQM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbbLotType = New System.Windows.Forms.ComboBox()
        Me.cbbLotTypeUpdate = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColumnHeaderLotType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelUpdate.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderSQM, Me.ColumnHeaderTCP, Me.ColumnHeaderLotType})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(10, 35)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(512, 324)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 70
        '
        'ColumnHeaderSQM
        '
        Me.ColumnHeaderSQM.Text = "SQM"
        Me.ColumnHeaderSQM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeaderSQM.Width = 70
        '
        'ColumnHeaderTCP
        '
        Me.ColumnHeaderTCP.Text = "TCP"
        Me.ColumnHeaderTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderTCP.Width = 100
        '
        'cbbProjectName
        '
        Me.cbbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbProjectName.FormattingEnabled = True
        Me.cbbProjectName.Location = New System.Drawing.Point(54, 10)
        Me.cbbProjectName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbbProjectName.Name = "cbbProjectName"
        Me.cbbProjectName.Size = New System.Drawing.Size(324, 21)
        Me.cbbProjectName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Project"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(73, 104)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(181, 21)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 56)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "TCP"
        '
        'txtTcp
        '
        Me.txtTcp.Location = New System.Drawing.Point(73, 54)
        Me.txtTcp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTcp.Name = "txtTcp"
        Me.txtTcp.Size = New System.Drawing.Size(123, 20)
        Me.txtTcp.TabIndex = 24
        Me.txtTcp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSQM
        '
        Me.txtSQM.Location = New System.Drawing.Point(73, 30)
        Me.txtSQM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSQM.Name = "txtSQM"
        Me.txtSQM.Size = New System.Drawing.Size(58, 20)
        Me.txtSQM.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "SQM"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(73, 12)
        Me.lblProjectName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(78, 13)
        Me.lblProjectName.TabIndex = 28
        Me.lblProjectName.Text = "lblProjectName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Name:"
        '
        'PanelUpdate
        '
        Me.PanelUpdate.BackColor = System.Drawing.Color.White
        Me.PanelUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUpdate.Controls.Add(Me.Label7)
        Me.PanelUpdate.Controls.Add(Me.cbbLotTypeUpdate)
        Me.PanelUpdate.Controls.Add(Me.ID)
        Me.PanelUpdate.Controls.Add(Me.Label6)
        Me.PanelUpdate.Controls.Add(Me.lblUpProjectName)
        Me.PanelUpdate.Controls.Add(Me.lblUpdateID)
        Me.PanelUpdate.Controls.Add(Me.btnUpdate)
        Me.PanelUpdate.Controls.Add(Me.Label3)
        Me.PanelUpdate.Controls.Add(Me.txtUpdateTCP)
        Me.PanelUpdate.Controls.Add(Me.txtUpdateSQM)
        Me.PanelUpdate.Controls.Add(Me.Label4)
        Me.PanelUpdate.Location = New System.Drawing.Point(526, 199)
        Me.PanelUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelUpdate.Name = "PanelUpdate"
        Me.PanelUpdate.Size = New System.Drawing.Size(270, 160)
        Me.PanelUpdate.TabIndex = 30
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(43, 10)
        Me.ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 36
        Me.ID.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Name:"
        '
        'lblUpProjectName
        '
        Me.lblUpProjectName.AutoSize = True
        Me.lblUpProjectName.Location = New System.Drawing.Point(70, 27)
        Me.lblUpProjectName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUpProjectName.Name = "lblUpProjectName"
        Me.lblUpProjectName.Size = New System.Drawing.Size(92, 13)
        Me.lblUpProjectName.TabIndex = 34
        Me.lblUpProjectName.Text = "lblUpProjectName"
        '
        'lblUpdateID
        '
        Me.lblUpdateID.AutoSize = True
        Me.lblUpdateID.Location = New System.Drawing.Point(70, 10)
        Me.lblUpdateID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUpdateID.Name = "lblUpdateID"
        Me.lblUpdateID.Size = New System.Drawing.Size(63, 13)
        Me.lblUpdateID.TabIndex = 33
        Me.lblUpdateID.Text = "lblUpdateID"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(70, 118)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(181, 21)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "TCP"
        '
        'txtUpdateTCP
        '
        Me.txtUpdateTCP.Location = New System.Drawing.Point(70, 68)
        Me.txtUpdateTCP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUpdateTCP.Name = "txtUpdateTCP"
        Me.txtUpdateTCP.Size = New System.Drawing.Size(123, 20)
        Me.txtUpdateTCP.TabIndex = 29
        Me.txtUpdateTCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUpdateSQM
        '
        Me.txtUpdateSQM.Location = New System.Drawing.Point(70, 45)
        Me.txtUpdateSQM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUpdateSQM.Name = "txtUpdateSQM"
        Me.txtUpdateSQM.Size = New System.Drawing.Size(58, 20)
        Me.txtUpdateSQM.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "SQM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbbLotType)
        Me.Panel1.Controls.Add(Me.txtTcp)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSQM)
        Me.Panel1.Controls.Add(Me.lblProjectName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Location = New System.Drawing.Point(526, 35)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 160)
        Me.Panel1.TabIndex = 31
        '
        'cbbLotType
        '
        Me.cbbLotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLotType.FormattingEnabled = True
        Me.cbbLotType.Location = New System.Drawing.Point(73, 78)
        Me.cbbLotType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbLotType.Name = "cbbLotType"
        Me.cbbLotType.Size = New System.Drawing.Size(181, 21)
        Me.cbbLotType.TabIndex = 30
        '
        'cbbLotTypeUpdate
        '
        Me.cbbLotTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLotTypeUpdate.FormattingEnabled = True
        Me.cbbLotTypeUpdate.Location = New System.Drawing.Point(70, 92)
        Me.cbbLotTypeUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbLotTypeUpdate.Name = "cbbLotTypeUpdate"
        Me.cbbLotTypeUpdate.Size = New System.Drawing.Size(181, 21)
        Me.cbbLotTypeUpdate.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Type"
        '
        'ColumnHeaderLotType
        '
        Me.ColumnHeaderLotType.Text = "Lot Type"
        Me.ColumnHeaderLotType.Width = 150
        '
        'FormProjectPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 374)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbbProjectName)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProjectPriceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Price List"
        Me.PanelUpdate.ResumeLayout(False)
        Me.PanelUpdate.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderSQM As ColumnHeader
    Friend WithEvents ColumnHeaderTCP As ColumnHeader
    Friend WithEvents cbbProjectName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTcp As TextBox
    Friend WithEvents txtSQM As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblProjectName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelUpdate As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUpdateTCP As TextBox
    Friend WithEvents txtUpdateSQM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblUpProjectName As Label
    Friend WithEvents lblUpdateID As Label
    Friend WithEvents ID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cbbLotTypeUpdate As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbLotType As ComboBox
    Friend WithEvents ColumnHeaderLotType As ColumnHeader
End Class
