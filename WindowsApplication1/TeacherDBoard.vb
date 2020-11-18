Imports System.IO 'Reference library so read and write commands can be used
Public Class TeacherDBoard
    Dim TimetableImage As Bitmap 'Image of timetable for printing purposes
    Private Sub TeacherDBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "TeacherDBoard" 'Current form is TeacherDBoard
        CheckAll() 'Making sure each database exists
        InitialiseDays() 'Call procedure to initialise the Days array
        'Populating each of the day label arrays
        ToLbArray(MondayLessons, lbMonP1, lbMonP2, lbMonP3, lbMonP4, lbMonP5, lbMonP6, lbMonP7) 'Populates MondayLessons array with lesson labels
        ToLbArray(TuesdayLessons, lbTueP1, lbTueP2, lbTueP3, lbTueP4, lbTueP5, lbTueP6, lbTueP7) 'Populates TuesdayLessons array with lesson labels
        ToLbArray(WednesdayLessons, lbWedP1, lbWedP2, lbWedP3, lbWedP4, lbWedP5, lbWedP6, lbWedP7) 'Populates WednesdayLessons array with lesson labels
        ToLbArray(ThursdayLessons, lbThuP1, lbThuP2, lbThuP3, lbThuP4, lbThuP5, lbThuP6, lbThuP7) 'Populates ThursdayLessons array with lesson labels
        ToLbArray(FridayLessons, lbFriP1, lbFriP2, lbFriP3, lbFriP4, lbFriP5, lbFriP6, lbFriP7) 'Populates FridayLessons array with lesson labels
        UpdateTeacherTimetable() 'Call procedure to update the teacher timetable
    End Sub

    Private Sub UpdateTeacherTimetable() 'Declare procedure UpdateTeacherTimetable
        If WhichForm <> "TeacherDBoard" Then 'This makes sure that the procedure only runs when it is called
            Exit Sub
        End If
        UpdateTimetableArray() 'Updates the timetable array
        lbNumLessons.Text = "Number of " & vbNewLine & "Lessons: "
        ClearLessons() 'Initialises each lesson label
        For CurrentIndex = 0 To MaxTeacherIndex 'Loops through each TeacherID in the TeacherIDs array
            If UserID = TeacherIDs(CurrentIndex) Then 'If there is a match
                LessonCount = LessonCount + 1 'Increment number of lessons
                NameTimetable(lbName, "Teachers.txt", UserID) 'Obtains the Teacher's name to display on the timetable
                AssignLessonLabels((CurrentIndex + MaxStudentIndex + 1), chkMonday.Checked, chkTuesday.Checked, chkWednesday.Checked, chkThursday.Checked, chkFriday.Checked) 'Adds the teacher's lessons to the timetable
                lbNumLessons.Text += CStr(LessonCount) 'Concatenate number of lessons to label
                Exit Sub 'Exits procedure
            End If
        Next
    End Sub


    Private Sub chkMonday_CheckedChanged(sender As Object, e As EventArgs) Handles chkMonday.CheckedChanged 'Procedure for when chkMonday.Checked is changed
        DayCheck(chkMonday.Checked, 0, "Monday") 'Call DayCheck procedure, to update the Days array for Monday
        UpdateTeacherTimetable() 'Calls procedure to update the teacher timetable
    End Sub

    Private Sub chkTuesday_CheckedChanged(sender As Object, e As EventArgs) Handles chkTuesday.CheckedChanged 'Procedure for when chkTuesday.Checked is changed
        DayCheck(chkTuesday.Checked, 1, "Tuesday") 'Call DayCheck procedure, to update the Days array for Tuesday
        UpdateTeacherTimetable() 'Calls procedure to update the teacher timetable
    End Sub

    Private Sub chkWednesday_CheckedChanged(sender As Object, e As EventArgs) Handles chkWednesday.CheckedChanged 'Procedure for when chkWednesday.Checked is changed
        DayCheck(chkWednesday.Checked, 2, "Wednesday") 'Call DayCheck procedure, to update the Days array for Wednesday
        UpdateTeacherTimetable() 'Calls procedure to update the teacher timetable
    End Sub

    Private Sub chkThursday_CheckedChanged(sender As Object, e As EventArgs) Handles chkThursday.CheckedChanged 'Procedure for when chkThursday.Checked is changed
        DayCheck(chkThursday.Checked, 3, "Thursday") 'Call DayCheck procedure, to update the Days array for Thursday
        UpdateTeacherTimetable() 'Calls procedure to update the teacher timetable
    End Sub

    Private Sub chkFriday_CheckedChanged(sender As Object, e As EventArgs) Handles chkFriday.CheckedChanged 'Procedure for when chkFriday.Checked is changed
        DayCheck(chkFriday.Checked, 4, "Friday") 'Call DayCheck procedure, to update the Days array for Friday
        UpdateTeacherTimetable() 'Calls procedure to update the teacher timetable
    End Sub

    'Procedures for when a lesson label is double clicked (it would call the procedure to load the lesson details)
    Private Sub lbMonP1_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP1.DoubleClick
        LessonClick(lbMonP1) 'Loads Lesson details for Monday Period 1
    End Sub

    Private Sub lbMonP2_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP2.DoubleClick
        LessonClick(lbMonP2) 'Loads Lesson details for Monday Period 2
    End Sub

    Private Sub lbMonP3_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP3.DoubleClick
        LessonClick(lbMonP3) 'Loads Lesson details for Monday Period 3
    End Sub

    Private Sub lbMonP4_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP4.DoubleClick
        LessonClick(lbMonP4) 'Loads Lesson details for Monday Period 4
    End Sub

    Private Sub lbMonP5_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP5.DoubleClick
        LessonClick(lbMonP5) 'Loads Lesson details for Monday Period 5
    End Sub

    Private Sub lbMonP6_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP6.DoubleClick
        LessonClick(lbMonP6) 'Loads Lesson details for Monday Period 6
    End Sub

    Private Sub lbMonP7_DoubleClick(sender As Object, e As EventArgs) Handles lbMonP7.DoubleClick
        LessonClick(lbMonP7) 'Loads Lesson details for Monday Period 7
    End Sub

    Private Sub lbTueP1_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP1.DoubleClick
        LessonClick(lbTueP1) 'Loads Lesson details for Tuesday Period 1
    End Sub

    Private Sub lbTueP2_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP2.DoubleClick
        LessonClick(lbTueP2) 'Loads Lesson details for Tuesday Period 2
    End Sub

    Private Sub lbTueP3_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP3.DoubleClick
        LessonClick(lbTueP3) 'Loads Lesson details for Tuesday Period 3
    End Sub

    Private Sub lbTueP4_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP4.DoubleClick
        LessonClick(lbTueP4) 'Loads Lesson details for Tuesday Period 4
    End Sub

    Private Sub lbTueP5_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP5.DoubleClick
        LessonClick(lbTueP5) 'Loads Lesson details for Tuesday Period 5
    End Sub

    Private Sub lbTueP6_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP6.DoubleClick
        LessonClick(lbTueP6) 'Loads Lesson details for Tuesday Period 6
    End Sub

    Private Sub lbTueP7_DoubleClick(sender As Object, e As EventArgs) Handles lbTueP7.DoubleClick
        LessonClick(lbTueP7) 'Loads Lesson details for Tuesday Period 7
    End Sub

    Private Sub lbWedP1_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP1.DoubleClick
        LessonClick(lbWedP1) 'Loads Lesson details for Wednesday Period 1
    End Sub

    Private Sub lbWedP2_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP2.DoubleClick
        LessonClick(lbWedP2) 'Loads Lesson details for Wednesday Period 2
    End Sub

    Private Sub lbWedP3_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP3.DoubleClick
        LessonClick(lbWedP3) 'Loads Lesson details for Wednesday Period 3
    End Sub

    Private Sub lbWedP4_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP4.DoubleClick
        LessonClick(lbWedP4) 'Loads Lesson details for Wednesday Period 4
    End Sub

    Private Sub lbWedP5_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP5.DoubleClick
        LessonClick(lbWedP5) 'Loads Lesson details for Wednesday Period 5
    End Sub

    Private Sub lbWedP6_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP6.DoubleClick
        LessonClick(lbWedP6) 'Loads Lesson details for Wednesday Period 6
    End Sub

    Private Sub lbWedP7_DoubleClick(sender As Object, e As EventArgs) Handles lbWedP7.DoubleClick
        LessonClick(lbWedP7) 'Loads Lesson details for Wednesday Period 7
    End Sub

    Private Sub lbThuP1_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP1.DoubleClick
        LessonClick(lbThuP1) 'Loads Lesson details for Thursday Period 1
    End Sub

    Private Sub lbThuP2_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP2.DoubleClick
        LessonClick(lbThuP2) 'Loads Lesson details for Thursday Period 2
    End Sub

    Private Sub lbThuP3_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP3.DoubleClick
        LessonClick(lbThuP3) 'Loads Lesson details for Thursday Period 3
    End Sub

    Private Sub lbThuP4_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP4.DoubleClick
        LessonClick(lbThuP4) 'Loads Lesson details for Thursday Period 4
    End Sub

    Private Sub lbThuP5_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP5.DoubleClick
        LessonClick(lbThuP5) 'Loads Lesson details for Thursday Period 5
    End Sub

    Private Sub lbThuP6_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP6.DoubleClick
        LessonClick(lbThuP6) 'Loads Lesson details for Thursday Period 6
    End Sub

    Private Sub lbThuP7_DoubleClick(sender As Object, e As EventArgs) Handles lbThuP7.DoubleClick
        LessonClick(lbThuP7) 'Loads Lesson details for Thursday Period 7
    End Sub

    Private Sub lbFriP1_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP1.DoubleClick
        LessonClick(lbFriP1) 'Loads Lesson details for Friday Period 1
    End Sub

    Private Sub lbFriP2_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP2.DoubleClick
        LessonClick(lbFriP2) 'Loads Lesson details for Friday Period 2
    End Sub

    Private Sub lbFriP3_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP3.DoubleClick
        LessonClick(lbFriP3) 'Loads Lesson details for Friday Period 3
    End Sub

    Private Sub lbFriP4_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP4.DoubleClick
        LessonClick(lbFriP4) 'Loads Lesson details for Friday Period 4
    End Sub

    Private Sub lbFriP5_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP5.DoubleClick
        LessonClick(lbFriP5) 'Loads Lesson details for Friday Period 5
    End Sub

    Private Sub lbFriP6_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP6.DoubleClick
        LessonClick(lbFriP6) 'Loads Lesson details for Friday Period 6
    End Sub

    Private Sub lbFriP7_DoubleClick(sender As Object, e As EventArgs) Handles lbFriP7.DoubleClick
        LessonClick(lbFriP7) 'Loads Lesson details for Friday Period 7
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click 'Procedure for when print button is clicked
        'Setting up the print dialog
        pdialogTimetable.Document = pdocTimetable
        pdialogTimetable.PrinterSettings = pdocTimetable.PrinterSettings
        pdialogTimetable.AllowSomePages = True
        'Creating a new bitmap image from the tabmenu where the timetable is located
        TimetableImage = New Bitmap(Me.tabMenu.Width, Me.tabMenu.Height)
        tabMenu.DrawToBitmap(TimetableImage, New Rectangle(0, 0, Me.tabMenu.Width, Me.tabMenu.Height))
        previewTimetable.ShowDialog() 'Shows print preview dialog
        pdialogTimetable.ShowDialog() 'Shows print dialog
    End Sub

    Private Sub pdocTimetable_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdocTimetable.PrintPage 'Procedure for PrintPage
        e.Graphics.DrawImage(TimetableImage, 50, 50) 'Draws this bitmap image to the print page
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click 'Procedure for when ChangePass button is clicked
        ChangePassword.Show() 'Shows ChangePassword form
    End Sub
End Class