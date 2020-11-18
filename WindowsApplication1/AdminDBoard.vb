Public Class AdminDBoard
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click 'Procedure for when Students button is clicked
        Students.Show() 'Show Students form
        Me.Close() 'Close current form
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click 'Procedure for when Teachers button is clicked
        Teachers.Show() 'Show Teachers form
        Me.Close() 'Close current form
    End Sub

    Private Sub AdminDBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "AdminDBoard" 'Current form is AdminDBoard
        CheckAll() 'Making sure each database exists
        AccessType = "Admin" 'User has an access level of Admin
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click 'Procedure for when Rooms button is clicked
        Rooms.Show() 'Show Rooms form
        Me.Close() 'Close current form
    End Sub

    Private Sub btnEnrolments_Click(sender As Object, e As EventArgs) Handles btnEnrolments.Click 'Procedure for when Enrolments button is clicked
        Enrolments.Show() 'Show Enrollments form
        Me.Close() 'Close current form
    End Sub

    Private Sub btnLessons_Click(sender As Object, e As EventArgs) Handles btnLessons.Click 'Procedure for when Lessons button is clicked
        Lessons.Show() 'Show Lessons form
        Me.Close() 'Close current form
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click 'Procedure for when Subjects button is clicked
        Subjects.Show() 'Show Subjects form
        Me.Close() 'Close current form
    End Sub

    Private Sub btnTimetables_Click(sender As Object, e As EventArgs) Handles btnTimetables.Click 'Procedure for when Timetables button is clicked
        Timetables.Show() 'Show Timetables form
        Me.Close() 'Close current form
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click 'Procedure for when ChangePass button is clicked
        ChangePassword.Show() 'Shows ChangePassword form
    End Sub

End Class