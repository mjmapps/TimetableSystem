<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        Me.lstRooms = New System.Windows.Forms.ListView()
        Me.colRoomID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCapacity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colComputers = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBoards = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.lbRoomID = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.spCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lbCapacity = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.spComputers = New System.Windows.Forms.NumericUpDown()
        Me.lbComputers = New System.Windows.Forms.Label()
        Me.lbBoards = New System.Windows.Forms.Label()
        Me.spBoards = New System.Windows.Forms.NumericUpDown()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.spCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spComputers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spBoards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstRooms
        '
        Me.lstRooms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRoomID, Me.colType, Me.colCapacity, Me.colComputers, Me.colBoards})
        Me.lstRooms.Location = New System.Drawing.Point(12, 12)
        Me.lstRooms.Name = "lstRooms"
        Me.lstRooms.Size = New System.Drawing.Size(406, 171)
        Me.lstRooms.TabIndex = 0
        Me.lstRooms.UseCompatibleStateImageBehavior = False
        '
        'colRoomID
        '
        Me.colRoomID.Text = "RoomID"
        Me.colRoomID.Width = 100
        '
        'colType
        '
        Me.colType.Text = "Type"
        Me.colType.Width = 100
        '
        'colCapacity
        '
        Me.colCapacity.Text = "Capacity"
        '
        'colComputers
        '
        Me.colComputers.Text = "Computers"
        Me.colComputers.Width = 80
        '
        'colBoards
        '
        Me.colBoards.Text = "Boards"
        '
        'txtRoomID
        '
        Me.txtRoomID.Location = New System.Drawing.Point(84, 200)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(61, 20)
        Me.txtRoomID.TabIndex = 1
        '
        'lbRoomID
        '
        Me.lbRoomID.AutoSize = True
        Me.lbRoomID.Location = New System.Drawing.Point(81, 187)
        Me.lbRoomID.Name = "lbRoomID"
        Me.lbRoomID.Size = New System.Drawing.Size(46, 13)
        Me.lbRoomID.TabIndex = 3
        Me.lbRoomID.Text = "RoomID"
        '
        'lbType
        '
        Me.lbType.AutoSize = True
        Me.lbType.Location = New System.Drawing.Point(151, 186)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(31, 13)
        Me.lbType.TabIndex = 4
        Me.lbType.Text = "Type"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MediumBlue
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.Location = New System.Drawing.Point(424, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 53)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumBlue
        Me.btnSave.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Location = New System.Drawing.Point(424, 71)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 53)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(424, 130)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 53)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'spCapacity
        '
        Me.spCapacity.Location = New System.Drawing.Point(262, 201)
        Me.spCapacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spCapacity.Name = "spCapacity"
        Me.spCapacity.Size = New System.Drawing.Size(66, 20)
        Me.spCapacity.TabIndex = 8
        Me.spCapacity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbCapacity
        '
        Me.lbCapacity.AutoSize = True
        Me.lbCapacity.Location = New System.Drawing.Point(259, 187)
        Me.lbCapacity.Name = "lbCapacity"
        Me.lbCapacity.Size = New System.Drawing.Size(48, 13)
        Me.lbCapacity.TabIndex = 9
        Me.lbCapacity.Text = "Capacity"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 228)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 41
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Classroom", "Computer Room", "Hall", "Study Area", "Library"})
        Me.cboType.Location = New System.Drawing.Point(154, 200)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(99, 21)
        Me.cboType.TabIndex = 2
        '
        'spComputers
        '
        Me.spComputers.Location = New System.Drawing.Point(337, 201)
        Me.spComputers.Name = "spComputers"
        Me.spComputers.Size = New System.Drawing.Size(66, 20)
        Me.spComputers.TabIndex = 42
        '
        'lbComputers
        '
        Me.lbComputers.AutoSize = True
        Me.lbComputers.Location = New System.Drawing.Point(334, 187)
        Me.lbComputers.Name = "lbComputers"
        Me.lbComputers.Size = New System.Drawing.Size(57, 13)
        Me.lbComputers.TabIndex = 44
        Me.lbComputers.Text = "Computers"
        '
        'lbBoards
        '
        Me.lbBoards.AutoSize = True
        Me.lbBoards.Location = New System.Drawing.Point(411, 187)
        Me.lbBoards.Name = "lbBoards"
        Me.lbBoards.Size = New System.Drawing.Size(40, 13)
        Me.lbBoards.TabIndex = 45
        Me.lbBoards.Text = "Boards"
        '
        'spBoards
        '
        Me.spBoards.Location = New System.Drawing.Point(414, 201)
        Me.spBoards.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.spBoards.Name = "spBoards"
        Me.spBoards.Size = New System.Drawing.Size(66, 20)
        Me.spBoards.TabIndex = 43
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(178, 230)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(75, 20)
        Me.txtSearch.TabIndex = 46
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(93, 234)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(83, 13)
        Me.lbSearch.TabIndex = 47
        Me.lbSearch.Text = "Search RoomID"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(424, 229)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 21)
        Me.btnHelp.TabIndex = 54
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 255)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbBoards)
        Me.Controls.Add(Me.lbComputers)
        Me.Controls.Add(Me.spBoards)
        Me.Controls.Add(Me.spComputers)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lbCapacity)
        Me.Controls.Add(Me.spCapacity)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.lbRoomID)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtRoomID)
        Me.Controls.Add(Me.lstRooms)
        Me.Name = "Rooms"
        Me.Text = "Rooms"
        CType(Me.spCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spComputers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spBoards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRooms As ListView
    Friend WithEvents colRoomID As ColumnHeader
    Friend WithEvents colType As ColumnHeader
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents lbRoomID As Label
    Friend WithEvents lbType As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents spCapacity As NumericUpDown
    Friend WithEvents lbCapacity As Label
    Friend WithEvents colCapacity As ColumnHeader
    Friend WithEvents btnBack As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents colComputers As ColumnHeader
    Friend WithEvents colBoards As ColumnHeader
    Friend WithEvents spComputers As NumericUpDown
    Friend WithEvents lbComputers As Label
    Friend WithEvents lbBoards As Label
    Friend WithEvents spBoards As NumericUpDown
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lbSearch As Label
    Friend WithEvents btnHelp As Button
End Class
