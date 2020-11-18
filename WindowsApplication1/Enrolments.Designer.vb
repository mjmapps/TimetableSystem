<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enrolments
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
        Me.lstEnrolments = New System.Windows.Forms.ListView()
        Me.colEnrolID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEnrolDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSubjectID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboStudentID = New System.Windows.Forms.ComboBox()
        Me.cboSubjectID = New System.Windows.Forms.ComboBox()
        Me.lbStudentID = New System.Windows.Forms.Label()
        Me.lbLessonID = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.lbSort = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.helpEnrol = New System.Windows.Forms.HelpProvider()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstEnrolments
        '
        Me.lstEnrolments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colEnrolID, Me.colEnrolDate, Me.colStudentID, Me.colSubjectID})
        Me.lstEnrolments.Location = New System.Drawing.Point(12, 12)
        Me.lstEnrolments.Name = "lstEnrolments"
        Me.lstEnrolments.Size = New System.Drawing.Size(266, 241)
        Me.lstEnrolments.TabIndex = 2
        Me.lstEnrolments.UseCompatibleStateImageBehavior = False
        '
        'colEnrolID
        '
        Me.colEnrolID.Text = "EnrolID"
        '
        'colEnrolDate
        '
        Me.colEnrolDate.Text = "EnrolDate"
        Me.colEnrolDate.Width = 80
        '
        'colStudentID
        '
        Me.colStudentID.Text = "StudentID"
        '
        'colSubjectID
        '
        Me.colSubjectID.Text = "SubjectID"
        '
        'cboStudentID
        '
        Me.cboStudentID.FormattingEnabled = True
        Me.cboStudentID.Location = New System.Drawing.Point(296, 28)
        Me.cboStudentID.Name = "cboStudentID"
        Me.cboStudentID.Size = New System.Drawing.Size(121, 21)
        Me.cboStudentID.TabIndex = 3
        '
        'cboSubjectID
        '
        Me.cboSubjectID.FormattingEnabled = True
        Me.cboSubjectID.Location = New System.Drawing.Point(423, 28)
        Me.cboSubjectID.Name = "cboSubjectID"
        Me.cboSubjectID.Size = New System.Drawing.Size(121, 21)
        Me.cboSubjectID.TabIndex = 4
        '
        'lbStudentID
        '
        Me.lbStudentID.AutoSize = True
        Me.lbStudentID.Location = New System.Drawing.Point(293, 12)
        Me.lbStudentID.Name = "lbStudentID"
        Me.lbStudentID.Size = New System.Drawing.Size(55, 13)
        Me.lbStudentID.TabIndex = 5
        Me.lbStudentID.Text = "StudentID"
        '
        'lbLessonID
        '
        Me.lbLessonID.AutoSize = True
        Me.lbLessonID.Location = New System.Drawing.Point(420, 12)
        Me.lbLessonID.Name = "lbLessonID"
        Me.lbLessonID.Size = New System.Drawing.Size(54, 13)
        Me.lbLessonID.TabIndex = 6
        Me.lbLessonID.Text = "SubjectID"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MediumBlue
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.Location = New System.Drawing.Point(364, 229)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 53)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumBlue
        Me.btnSave.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Location = New System.Drawing.Point(426, 229)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 53)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(488, 229)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 53)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 259)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(321, 64)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnStudent.TabIndex = 43
        Me.btnStudent.Text = "Get Student"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnSubject
        '
        Me.btnSubject.Location = New System.Drawing.Point(445, 64)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(75, 23)
        Me.btnSubject.TabIndex = 44
        Me.btnSubject.Text = "Get Subject"
        Me.btnSubject.UseVisualStyleBackColor = True
        '
        'lbSort
        '
        Me.lbSort.AutoSize = True
        Me.lbSort.Location = New System.Drawing.Point(306, 105)
        Me.lbSort.Name = "lbSort"
        Me.lbSort.Size = New System.Drawing.Size(26, 13)
        Me.lbSort.TabIndex = 50
        Me.lbSort.Text = "Sort"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"EnroID (Ascending)", "EnrolID (Descending)", "Date (Ascending)", "Date (Descending)"})
        Me.cboSort.Location = New System.Drawing.Point(309, 121)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(165, 21)
        Me.cboSort.TabIndex = 49
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(222, 261)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 21)
        Me.btnHelp.TabIndex = 51
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Enrolments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 286)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lbSort)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.btnSubject)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbLessonID)
        Me.Controls.Add(Me.lbStudentID)
        Me.Controls.Add(Me.cboSubjectID)
        Me.Controls.Add(Me.cboStudentID)
        Me.Controls.Add(Me.lstEnrolments)
        Me.Name = "Enrolments"
        Me.Text = " Enrolments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstEnrolments As ListView
    Friend WithEvents colEnrolID As ColumnHeader
    Friend WithEvents colEnrolDate As ColumnHeader
    Friend WithEvents colStudentID As ColumnHeader
    Friend WithEvents colSubjectID As ColumnHeader
    Friend WithEvents cboStudentID As ComboBox
    Friend WithEvents cboSubjectID As ComboBox
    Friend WithEvents lbStudentID As Label
    Friend WithEvents lbLessonID As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnSubject As Button
    Friend WithEvents lbSort As Label
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents helpEnrol As HelpProvider
    Friend WithEvents btnHelp As Button
End Class
