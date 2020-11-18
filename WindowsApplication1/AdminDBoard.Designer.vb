<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDBoard
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
        Me.lbDashboard = New System.Windows.Forms.Label()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnTeachers = New System.Windows.Forms.Button()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnEnrolments = New System.Windows.Forms.Button()
        Me.btnLessons = New System.Windows.Forms.Button()
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnTimetables = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDashboard
        '
        Me.lbDashboard.AutoSize = True
        Me.lbDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDashboard.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbDashboard.Location = New System.Drawing.Point(145, 9)
        Me.lbDashboard.Name = "lbDashboard"
        Me.lbDashboard.Size = New System.Drawing.Size(270, 55)
        Me.lbDashboard.TabIndex = 7
        Me.lbDashboard.Text = "Dashboard"
        '
        'btnStudents
        '
        Me.btnStudents.BackColor = System.Drawing.Color.MediumBlue
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnStudents.Location = New System.Drawing.Point(52, 115)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(133, 51)
        Me.btnStudents.TabIndex = 8
        Me.btnStudents.Text = "Students"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnTeachers
        '
        Me.btnTeachers.BackColor = System.Drawing.Color.MediumBlue
        Me.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeachers.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnTeachers.Location = New System.Drawing.Point(52, 188)
        Me.btnTeachers.Name = "btnTeachers"
        Me.btnTeachers.Size = New System.Drawing.Size(133, 51)
        Me.btnTeachers.TabIndex = 9
        Me.btnTeachers.Text = "Teachers"
        Me.btnTeachers.UseVisualStyleBackColor = False
        '
        'btnRooms
        '
        Me.btnRooms.BackColor = System.Drawing.Color.MediumBlue
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnRooms.Location = New System.Drawing.Point(52, 267)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(133, 51)
        Me.btnRooms.TabIndex = 10
        Me.btnRooms.Text = "Rooms"
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'btnEnrolments
        '
        Me.btnEnrolments.BackColor = System.Drawing.Color.MediumBlue
        Me.btnEnrolments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrolments.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrolments.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnEnrolments.Location = New System.Drawing.Point(338, 115)
        Me.btnEnrolments.Name = "btnEnrolments"
        Me.btnEnrolments.Size = New System.Drawing.Size(157, 51)
        Me.btnEnrolments.TabIndex = 11
        Me.btnEnrolments.Text = "Enrolments"
        Me.btnEnrolments.UseVisualStyleBackColor = False
        '
        'btnLessons
        '
        Me.btnLessons.BackColor = System.Drawing.Color.MediumBlue
        Me.btnLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLessons.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLessons.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnLessons.Location = New System.Drawing.Point(338, 267)
        Me.btnLessons.Name = "btnLessons"
        Me.btnLessons.Size = New System.Drawing.Size(157, 51)
        Me.btnLessons.TabIndex = 12
        Me.btnLessons.Text = "Lessons"
        Me.btnLessons.UseVisualStyleBackColor = False
        '
        'btnSubjects
        '
        Me.btnSubjects.BackColor = System.Drawing.Color.MediumBlue
        Me.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjects.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSubjects.Location = New System.Drawing.Point(338, 188)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(157, 51)
        Me.btnSubjects.TabIndex = 13
        Me.btnSubjects.Text = "Subjects"
        Me.btnSubjects.UseVisualStyleBackColor = False
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(456, 408)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(112, 23)
        Me.btnChangePass.TabIndex = 14
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnTimetables
        '
        Me.btnTimetables.BackColor = System.Drawing.Color.MediumBlue
        Me.btnTimetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimetables.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimetables.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnTimetables.Location = New System.Drawing.Point(183, 342)
        Me.btnTimetables.Name = "btnTimetables"
        Me.btnTimetables.Size = New System.Drawing.Size(157, 51)
        Me.btnTimetables.TabIndex = 15
        Me.btnTimetables.Text = "Timetables"
        Me.btnTimetables.UseVisualStyleBackColor = False
        '
        'AdminDBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 443)
        Me.Controls.Add(Me.btnTimetables)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.btnSubjects)
        Me.Controls.Add(Me.btnLessons)
        Me.Controls.Add(Me.btnEnrolments)
        Me.Controls.Add(Me.btnRooms)
        Me.Controls.Add(Me.btnTeachers)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.lbDashboard)
        Me.Name = "AdminDBoard"
        Me.Text = "AdminDBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDashboard As Label
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnTeachers As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnEnrolments As Button
    Friend WithEvents btnLessons As Button
    Friend WithEvents btnSubjects As Button
    Friend WithEvents btnChangePass As Button
    Friend WithEvents btnTimetables As Button
End Class
