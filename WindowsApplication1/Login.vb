Imports System.IO 'Reference library so read and write commands can be used
Public Class Login
    'Declaring private variables
    Dim LoginType As String = "" 'Whether the student has selected to log in as a student or teacher
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click 'Procedure for when Login button is clicked
        GetID = False 'Initialises GetID as False so the forms display the correct buttons
        'Declaring private variables for this specific procedure
        Dim Username As String = txtUser.Text 'Inputted username
        Dim Password As String = txtPass.Text 'Inputted password
        Dim StringLine As String 'Stores the string value of a record
        Dim Found As Boolean = False 'Whether the user record has been found when logging in
        UserID = "" 'UserID is initally blank
        If ((rbStudent.Checked) Or (rbTeacher.Checked)) = False Then 'If neither of the radiobuttons are checked
            MsgBox("Please select whether you want to log in as a student or teacher.") 'Message box outputs to the user prompting to select one
            Exit Sub 'Exit procedure
        End If
        'TESTING CORRECTION - Presence checks
        If txtUser.Text = Nothing Then 'If username is blank then it prompts the user to enter a username
            MsgBox("Please enter a username.")
        End If
        If txtPass.Text = Nothing Then 'If password is blank then it prompts the suer to enter a password
            MsgBox("Please enter a password.")
        End If
        '----------------
        'Check for students
        If LoginType = "Student" Then 'If the user has selected to log in as a student
            Dim ReadStudent As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Open Students StreamReader
            StringLine = ReadStudent.ReadLine() 'Assign the first record of the Students database to StringLine
            Dim StudentRecords() As String 'Declare a String Array to store the fields of a Student record
            While (StringLine <> Nothing) And (Found = False) 'Looping while end of the file has not been reached and a match has not been found
                StudentRecords = StringLine.Split(",") 'split StringLine into elements delimited by each "," and assign these to the StudentRecords array
                If (Username = StudentRecords(5)) And (Password = StudentRecords(6)) Then 'If there is a match with the username and password for that record...
                    Found = True 'Found is True
                    'Assign values for the user as they have now logged in
                    UserID = StudentRecords(0) 'Assign The Student record's StudentID to the UserID
                    AccessType = "Student" 'User has the access level of a Student
                    ReadStudent.Close() 'Close Students StreamReader
                    Back() 'Call Back procedure
                    Exit Sub 'Exit procedure
                End If
                StringLine = ReadStudent.ReadLine() 'Assigns the next record of the Students file to StringLine
            End While 'End while loop
            ReadStudent.Close() 'Close Students StreamReader
        Else 'Otherwise...
            'Check for admin
            If txtUser.Text = "admin" Then 'If the user is logging in as an admin
                Dim ReadAdmin As New System.IO.StreamReader(Dir$("Admin.txt"), True) 'Open Admin StreamReader
                'Assigns the second line (password) of the Admin database to StringLine
                StringLine = ReadAdmin.ReadLine()
                StringLine = ReadAdmin.ReadLine()
                If txtPass.Text = StringLine Then 'If there is a match with the inputted password and the record
                    Found = True 'Found is True
                    UserID = "0" 'UserID is 0 (only one admin)
                    AccessType = "Admin" 'User has the access level of an admin
                    ReadAdmin.Close() 'Close Admin StreamReader
                    Back() 'Call Back procedure
                    Exit Sub 'Exit procedure
                End If
                ReadAdmin.Close() 'Close Admin StreamReader
            End If
            'Check for teacher
            Dim ReadTeacher As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Open Teachers StreamReader
            StringLine = ReadTeacher.ReadLine() 'Assign the first record of the Teachers database to StringLine
            While (StringLine <> Nothing) And (Found = False) 'Looping while the end of the file has not been reached and a match has not been found
                Dim TeacherRecords() As String 'Declare a String array to store the fields of a Teacher record
                TeacherRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to the TeacherRecords array
                If (Username = TeacherRecords(4)) And (Password = TeacherRecords(5)) Then 'If there is a match with the username and password for that record...
                    Found = True 'Found is True
                    UserID = TeacherRecords(0) 'Assign Teachers.TeacherRecords(0) to UserID
                    AccessType = "Teacher" 'Assign "Teacher" to AccessType
                    ReadTeacher.Close() 'Close Teachers StreamReader
                    Back() 'Call Back procedure
                    Exit Sub 'Exit procedure
                End If
                StringLine = ReadTeacher.ReadLine() 'Assigns the record of the Teachers file to StringLine
            End While 'End while loop
            ReadTeacher.Close() 'Close Teachers StreamReader
        End If
        'At this point it has to be incorrect as there are no matches within students, teachers nor the admin
        MsgBox("Incorrect username or password") 'Message box outputs to the user that username or password is incorrect
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure when form is loaded
        WhichForm = "Login" 'Current form is Login
        CheckAll() 'Making sure each database exists
    End Sub

    Private Sub rbStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rbStudent.CheckedChanged 'Procedure for when Student radiobutton is checked or unchecked
        If rbStudent.Checked = True Then 'If Student has been checked...
            LoginType = "Student" 'User is logging in as a Student
        Else 'Otherwise (it hasn't been checked)...
            LoginType = "" 'LoginType is blank as the user is not logging in as a student
        End If
    End Sub

    Private Sub rbTeacher_CheckedChanged(sender As Object, e As EventArgs) Handles rbTeacher.CheckedChanged 'Procedure for when Teacher radiobutton is checked or unchecked
        If rbTeacher.Checked = True Then 'If Teacher has been checked...
            LoginType = "Teacher" 'User is logging in as a Teacher
        Else 'Otherwise (it hasn't been checked)...
            LoginType = "" 'LoginType is blank as the user is not logging in as a teacher
        End If
    End Sub
End Class