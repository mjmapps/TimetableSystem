<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonInfo
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
        Me.tabInfo = New System.Windows.Forms.TabControl()
        Me.tabInformation = New System.Windows.Forms.TabPage()
        Me.lbBoards = New System.Windows.Forms.Label()
        Me.lbComputers = New System.Windows.Forms.Label()
        Me.lbCapacity = New System.Windows.Forms.Label()
        Me.lbRoomType = New System.Windows.Forms.Label()
        Me.lbTeacher = New System.Windows.Forms.Label()
        Me.lbExam = New System.Windows.Forms.Label()
        Me.lbSubject = New System.Windows.Forms.Label()
        Me.lbDuration = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.lbRoomID = New System.Windows.Forms.Label()
        Me.lbTeacherID = New System.Windows.Forms.Label()
        Me.lbSubjectID = New System.Windows.Forms.Label()
        Me.lbLessonID = New System.Windows.Forms.Label()
        Me.tabList = New System.Windows.Forms.TabPage()
        Me.lbSort = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.lstStudents = New System.Windows.Forms.ListView()
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabInfo.SuspendLayout()
        Me.tabInformation.SuspendLayout()
        Me.tabList.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabInfo
        '
        Me.tabInfo.Controls.Add(Me.tabInformation)
        Me.tabInfo.Controls.Add(Me.tabList)
        Me.tabInfo.Location = New System.Drawing.Point(12, 12)
        Me.tabInfo.Name = "tabInfo"
        Me.tabInfo.SelectedIndex = 0
        Me.tabInfo.Size = New System.Drawing.Size(577, 245)
        Me.tabInfo.TabIndex = 0
        '
        'tabInformation
        '
        Me.tabInformation.Controls.Add(Me.lbBoards)
        Me.tabInformation.Controls.Add(Me.lbComputers)
        Me.tabInformation.Controls.Add(Me.lbCapacity)
        Me.tabInformation.Controls.Add(Me.lbRoomType)
        Me.tabInformation.Controls.Add(Me.lbTeacher)
        Me.tabInformation.Controls.Add(Me.lbExam)
        Me.tabInformation.Controls.Add(Me.lbSubject)
        Me.tabInformation.Controls.Add(Me.lbDuration)
        Me.tabInformation.Controls.Add(Me.lbTime)
        Me.tabInformation.Controls.Add(Me.lbDay)
        Me.tabInformation.Controls.Add(Me.lbRoomID)
        Me.tabInformation.Controls.Add(Me.lbTeacherID)
        Me.tabInformation.Controls.Add(Me.lbSubjectID)
        Me.tabInformation.Controls.Add(Me.lbLessonID)
        Me.tabInformation.Location = New System.Drawing.Point(4, 22)
        Me.tabInformation.Name = "tabInformation"
        Me.tabInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInformation.Size = New System.Drawing.Size(569, 219)
        Me.tabInformation.TabIndex = 0
        Me.tabInformation.Text = "Information"
        Me.tabInformation.UseVisualStyleBackColor = True
        '
        'lbBoards
        '
        Me.lbBoards.AutoSize = True
        Me.lbBoards.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbBoards.Location = New System.Drawing.Point(53, 193)
        Me.lbBoards.Name = "lbBoards"
        Me.lbBoards.Size = New System.Drawing.Size(64, 20)
        Me.lbBoards.TabIndex = 14
        Me.lbBoards.Text = "Boards:"
        '
        'lbComputers
        '
        Me.lbComputers.AutoSize = True
        Me.lbComputers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbComputers.Location = New System.Drawing.Point(53, 173)
        Me.lbComputers.Name = "lbComputers"
        Me.lbComputers.Size = New System.Drawing.Size(95, 20)
        Me.lbComputers.TabIndex = 13
        Me.lbComputers.Text = "Computers: "
        '
        'lbCapacity
        '
        Me.lbCapacity.AutoSize = True
        Me.lbCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbCapacity.Location = New System.Drawing.Point(53, 153)
        Me.lbCapacity.Name = "lbCapacity"
        Me.lbCapacity.Size = New System.Drawing.Size(78, 20)
        Me.lbCapacity.TabIndex = 12
        Me.lbCapacity.Text = "Capacity: "
        '
        'lbRoomType
        '
        Me.lbRoomType.AutoSize = True
        Me.lbRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbRoomType.Location = New System.Drawing.Point(53, 133)
        Me.lbRoomType.Name = "lbRoomType"
        Me.lbRoomType.Size = New System.Drawing.Size(51, 20)
        Me.lbRoomType.TabIndex = 11
        Me.lbRoomType.Text = "Type: "
        '
        'lbTeacher
        '
        Me.lbTeacher.AutoSize = True
        Me.lbTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbTeacher.Location = New System.Drawing.Point(285, 133)
        Me.lbTeacher.Name = "lbTeacher"
        Me.lbTeacher.Size = New System.Drawing.Size(75, 20)
        Me.lbTeacher.TabIndex = 10
        Me.lbTeacher.Text = "Teacher: "
        '
        'lbExam
        '
        Me.lbExam.AutoSize = True
        Me.lbExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbExam.Location = New System.Drawing.Point(285, 53)
        Me.lbExam.Name = "lbExam"
        Me.lbExam.Size = New System.Drawing.Size(104, 20)
        Me.lbExam.TabIndex = 9
        Me.lbExam.Text = "Exam Board: "
        '
        'lbSubject
        '
        Me.lbSubject.AutoSize = True
        Me.lbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbSubject.Location = New System.Drawing.Point(285, 33)
        Me.lbSubject.Name = "lbSubject"
        Me.lbSubject.Size = New System.Drawing.Size(71, 20)
        Me.lbSubject.TabIndex = 7
        Me.lbSubject.Text = "Subject: "
        '
        'lbDuration
        '
        Me.lbDuration.AutoSize = True
        Me.lbDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbDuration.Location = New System.Drawing.Point(53, 73)
        Me.lbDuration.Name = "lbDuration"
        Me.lbDuration.Size = New System.Drawing.Size(78, 20)
        Me.lbDuration.TabIndex = 6
        Me.lbDuration.Text = "Duration: "
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbTime.Location = New System.Drawing.Point(53, 53)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(51, 20)
        Me.lbTime.TabIndex = 5
        Me.lbTime.Text = "Time: "
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbDay.Location = New System.Drawing.Point(53, 33)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(45, 20)
        Me.lbDay.TabIndex = 4
        Me.lbDay.Text = "Day: "
        '
        'lbRoomID
        '
        Me.lbRoomID.AutoSize = True
        Me.lbRoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRoomID.Location = New System.Drawing.Point(12, 113)
        Me.lbRoomID.Name = "lbRoomID"
        Me.lbRoomID.Size = New System.Drawing.Size(85, 20)
        Me.lbRoomID.TabIndex = 3
        Me.lbRoomID.Text = "RoomID: "
        '
        'lbTeacherID
        '
        Me.lbTeacherID.AutoSize = True
        Me.lbTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTeacherID.Location = New System.Drawing.Point(242, 113)
        Me.lbTeacherID.Name = "lbTeacherID"
        Me.lbTeacherID.Size = New System.Drawing.Size(103, 20)
        Me.lbTeacherID.TabIndex = 2
        Me.lbTeacherID.Text = "TeacherID: "
        '
        'lbSubjectID
        '
        Me.lbSubjectID.AutoSize = True
        Me.lbSubjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubjectID.Location = New System.Drawing.Point(242, 13)
        Me.lbSubjectID.Name = "lbSubjectID"
        Me.lbSubjectID.Size = New System.Drawing.Size(99, 20)
        Me.lbSubjectID.TabIndex = 1
        Me.lbSubjectID.Text = "SubjectID: "
        '
        'lbLessonID
        '
        Me.lbLessonID.AutoSize = True
        Me.lbLessonID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLessonID.Location = New System.Drawing.Point(12, 13)
        Me.lbLessonID.Name = "lbLessonID"
        Me.lbLessonID.Size = New System.Drawing.Size(96, 20)
        Me.lbLessonID.TabIndex = 0
        Me.lbLessonID.Text = "LessonID: "
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.lbSort)
        Me.tabList.Controls.Add(Me.cboSort)
        Me.tabList.Controls.Add(Me.lstStudents)
        Me.tabList.Location = New System.Drawing.Point(4, 22)
        Me.tabList.Name = "tabList"
        Me.tabList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabList.Size = New System.Drawing.Size(569, 219)
        Me.tabList.TabIndex = 1
        Me.tabList.Text = "Student List"
        Me.tabList.UseVisualStyleBackColor = True
        '
        'lbSort
        '
        Me.lbSort.AutoSize = True
        Me.lbSort.Location = New System.Drawing.Point(442, 12)
        Me.lbSort.Name = "lbSort"
        Me.lbSort.Size = New System.Drawing.Size(26, 13)
        Me.lbSort.TabIndex = 2
        Me.lbSort.Text = "Sort"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"First Name (A-Z)", "First Name (Z-A)", "Last Name (A-Z)", "Last Name (Z-A)"})
        Me.cboSort.Location = New System.Drawing.Point(442, 31)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(121, 21)
        Me.cboSort.TabIndex = 1
        '
        'lstStudents
        '
        Me.lstStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFirstName, Me.colLastName})
        Me.lstStudents.Location = New System.Drawing.Point(6, 6)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(305, 207)
        Me.lstStudents.TabIndex = 0
        Me.lstStudents.UseCompatibleStateImageBehavior = False
        '
        'colFirstName
        '
        Me.colFirstName.Text = "First Name"
        Me.colFirstName.Width = 150
        '
        'colLastName
        '
        Me.colLastName.Text = "Last Name"
        Me.colLastName.Width = 150
        '
        'LessonInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 274)
        Me.Controls.Add(Me.tabInfo)
        Me.Name = "LessonInfo"
        Me.Text = "LessonInfo"
        Me.tabInfo.ResumeLayout(False)
        Me.tabInformation.ResumeLayout(False)
        Me.tabInformation.PerformLayout()
        Me.tabList.ResumeLayout(False)
        Me.tabList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabInfo As TabControl
    Friend WithEvents tabInformation As TabPage
    Friend WithEvents tabList As TabPage
    Friend WithEvents lbRoomID As Label
    Friend WithEvents lbTeacherID As Label
    Friend WithEvents lbSubjectID As Label
    Friend WithEvents lbLessonID As Label
    Friend WithEvents lbDay As Label
    Friend WithEvents lbTime As Label
    Friend WithEvents lbDuration As Label
    Friend WithEvents lbSubject As Label
    Friend WithEvents lbExam As Label
    Friend WithEvents lbTeacher As Label
    Friend WithEvents lbRoomType As Label
    Friend WithEvents lbComputers As Label
    Friend WithEvents lbCapacity As Label
    Friend WithEvents lbBoards As Label
    Friend WithEvents lstStudents As ListView
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colLastName As ColumnHeader
    Friend WithEvents lbSort As Label
    Friend WithEvents cboSort As ComboBox
End Class
