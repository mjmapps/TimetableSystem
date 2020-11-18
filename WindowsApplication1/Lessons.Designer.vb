<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lessons
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstLessons = New System.Windows.Forms.ListView()
        Me.colLessonID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSubjectID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTeacherID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSubjectID = New System.Windows.Forms.ComboBox()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.lbDuration = New System.Windows.Forms.Label()
        Me.lbSubjectID = New System.Windows.Forms.Label()
        Me.cboRoomID = New System.Windows.Forms.ComboBox()
        Me.cboTeacherID = New System.Windows.Forms.ComboBox()
        Me.lbRoomID = New System.Windows.Forms.Label()
        Me.lbTeacherID = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.spTime = New System.Windows.Forms.NumericUpDown()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.lbSort = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.spTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstLessons
        '
        Me.lstLessons.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLessonID, Me.colDay, Me.colTime, Me.colDuration, Me.colRoomID, Me.colSubjectID, Me.colTeacherID})
        Me.lstLessons.Location = New System.Drawing.Point(12, 9)
        Me.lstLessons.Name = "lstLessons"
        Me.lstLessons.Size = New System.Drawing.Size(430, 241)
        Me.lstLessons.TabIndex = 1
        Me.lstLessons.UseCompatibleStateImageBehavior = False
        '
        'colLessonID
        '
        Me.colLessonID.Text = "LessonID"
        '
        'colDay
        '
        Me.colDay.Text = "Day"
        '
        'colTime
        '
        Me.colTime.Text = "Time"
        '
        'colDuration
        '
        Me.colDuration.Text = "Duration"
        '
        'colRoomID
        '
        Me.colRoomID.Text = "RoomID"
        '
        'colSubjectID
        '
        Me.colSubjectID.Text = "SubjectID"
        Me.colSubjectID.Width = 65
        '
        'colTeacherID
        '
        Me.colTeacherID.Text = "TeacherID"
        '
        'cboSubjectID
        '
        Me.cboSubjectID.FormattingEnabled = True
        Me.cboSubjectID.Location = New System.Drawing.Point(459, 149)
        Me.cboSubjectID.Name = "cboSubjectID"
        Me.cboSubjectID.Size = New System.Drawing.Size(121, 21)
        Me.cboSubjectID.TabIndex = 2
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Location = New System.Drawing.Point(456, 9)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(26, 13)
        Me.lbDay.TabIndex = 5
        Me.lbDay.Text = "Day"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Location = New System.Drawing.Point(456, 48)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(30, 13)
        Me.lbTime.TabIndex = 7
        Me.lbTime.Text = "Time"
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"45m", "60m"})
        Me.cboDuration.Location = New System.Drawing.Point(459, 109)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(55, 21)
        Me.cboDuration.TabIndex = 8
        '
        'lbDuration
        '
        Me.lbDuration.AutoSize = True
        Me.lbDuration.Location = New System.Drawing.Point(456, 93)
        Me.lbDuration.Name = "lbDuration"
        Me.lbDuration.Size = New System.Drawing.Size(47, 13)
        Me.lbDuration.TabIndex = 9
        Me.lbDuration.Text = "Duration"
        '
        'lbSubjectID
        '
        Me.lbSubjectID.AutoSize = True
        Me.lbSubjectID.Location = New System.Drawing.Point(456, 133)
        Me.lbSubjectID.Name = "lbSubjectID"
        Me.lbSubjectID.Size = New System.Drawing.Size(54, 13)
        Me.lbSubjectID.TabIndex = 10
        Me.lbSubjectID.Text = "SubjectID"
        '
        'cboRoomID
        '
        Me.cboRoomID.FormattingEnabled = True
        Me.cboRoomID.Location = New System.Drawing.Point(459, 189)
        Me.cboRoomID.Name = "cboRoomID"
        Me.cboRoomID.Size = New System.Drawing.Size(121, 21)
        Me.cboRoomID.TabIndex = 11
        '
        'cboTeacherID
        '
        Me.cboTeacherID.FormattingEnabled = True
        Me.cboTeacherID.Location = New System.Drawing.Point(459, 229)
        Me.cboTeacherID.Name = "cboTeacherID"
        Me.cboTeacherID.Size = New System.Drawing.Size(121, 21)
        Me.cboTeacherID.TabIndex = 12
        '
        'lbRoomID
        '
        Me.lbRoomID.AutoSize = True
        Me.lbRoomID.Location = New System.Drawing.Point(456, 173)
        Me.lbRoomID.Name = "lbRoomID"
        Me.lbRoomID.Size = New System.Drawing.Size(46, 13)
        Me.lbRoomID.TabIndex = 13
        Me.lbRoomID.Text = "RoomID"
        '
        'lbTeacherID
        '
        Me.lbTeacherID.AutoSize = True
        Me.lbTeacherID.Location = New System.Drawing.Point(456, 213)
        Me.lbTeacherID.Name = "lbTeacherID"
        Me.lbTeacherID.Size = New System.Drawing.Size(58, 13)
        Me.lbTeacherID.TabIndex = 14
        Me.lbTeacherID.Text = "TeacherID"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 315)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 41
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MediumBlue
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.Location = New System.Drawing.Point(12, 256)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 53)
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumBlue
        Me.btnSave.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Location = New System.Drawing.Point(74, 256)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 53)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(136, 256)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 53)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cboDay
        '
        Me.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cboDay.Location = New System.Drawing.Point(459, 24)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(121, 21)
        Me.cboDay.TabIndex = 45
        '
        'spTime
        '
        Me.spTime.Location = New System.Drawing.Point(459, 64)
        Me.spTime.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.spTime.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.spTime.Name = "spTime"
        Me.spTime.Size = New System.Drawing.Size(66, 20)
        Me.spTime.TabIndex = 46
        Me.spTime.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'btnSubject
        '
        Me.btnSubject.Location = New System.Drawing.Point(592, 149)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(75, 23)
        Me.btnSubject.TabIndex = 47
        Me.btnSubject.Text = "Get Subject"
        Me.btnSubject.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(592, 189)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnRoom.TabIndex = 48
        Me.btnRoom.Text = "Get Room"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(592, 229)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(75, 23)
        Me.btnTeacher.TabIndex = 49
        Me.btnTeacher.Text = "Get Teacher"
        Me.btnTeacher.UseVisualStyleBackColor = True
        '
        'lbSort
        '
        Me.lbSort.AutoSize = True
        Me.lbSort.Location = New System.Drawing.Point(456, 272)
        Me.lbSort.Name = "lbSort"
        Me.lbSort.Size = New System.Drawing.Size(26, 13)
        Me.lbSort.TabIndex = 52
        Me.lbSort.Text = "Sort"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"LessonID (Ascending)", "LessonID (Descending)"})
        Me.cboSort.Location = New System.Drawing.Point(459, 288)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(165, 21)
        Me.cboSort.TabIndex = 51
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(386, 317)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 21)
        Me.btnHelp.TabIndex = 53
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Lessons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 348)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lbSort)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnSubject)
        Me.Controls.Add(Me.spTime)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lbTeacherID)
        Me.Controls.Add(Me.lbRoomID)
        Me.Controls.Add(Me.cboTeacherID)
        Me.Controls.Add(Me.cboRoomID)
        Me.Controls.Add(Me.lbSubjectID)
        Me.Controls.Add(Me.lbDuration)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.cboSubjectID)
        Me.Controls.Add(Me.lstLessons)
        Me.Name = "Lessons"
        Me.Text = "Lessons"
        CType(Me.spTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLessons As ListView
    Friend WithEvents colLessonID As ColumnHeader
    Friend WithEvents colDay As ColumnHeader
    Friend WithEvents colTime As ColumnHeader
    Friend WithEvents colDuration As ColumnHeader
    Friend WithEvents colRoomID As ColumnHeader
    Friend WithEvents colSubjectID As ColumnHeader
    Friend WithEvents colTeacherID As ColumnHeader
    Friend WithEvents cboSubjectID As ComboBox
    Friend WithEvents lbDay As Label
    Friend WithEvents lbTime As Label
    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents lbDuration As Label
    Friend WithEvents lbSubjectID As Label
    Friend WithEvents cboRoomID As ComboBox
    Friend WithEvents cboTeacherID As ComboBox
    Friend WithEvents lbRoomID As Label
    Friend WithEvents lbTeacherID As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents spTime As NumericUpDown
    Friend WithEvents btnSubject As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents lbSort As Label
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents btnHelp As Button
End Class
