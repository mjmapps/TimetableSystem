Imports System.IO
Public Class ChangePassword
    Dim NotValid As Boolean 'Determines if the input is valid or not

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        CheckAll() 'Checks if all the databases exist, if not then it creates the database
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        InvalidCount = 0
        'Validating inputs
        lbPasswordWarning.Text = ValidatePass(txtPassword.Text) 'Validating the inputted password
        lbPassConfirmWarning.Text = ValidatePassConfirm(txtPassword.Text, txtPassConfirm.Text) 'Verifying the password with the confirmed password input
        If InvalidCount > 0 Then 'If one or more inputs have been detected as invalid then it exits the procedure
            Exit Sub
        End If
        If WhichForm = "Students" Then 'If a student is changing their password
            Dim sr As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Opens Students StreamReader to read from Students.txt (Students database)
            Dim st As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Opens TempFile StreamWriter to write to TempFile.txt (Temporary database)
            StringLine = sr.ReadLine() 'Read the first student record of the students database
            While (StringLine <> Nothing) 'Looping through student records while EOF has not yet been reached
                StudentRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to StudentRecords array
                If (StudentRecords(0) = UserID) Then 'If a match is found... (the user's record)
                    StudentRecords(6) = txtPassword.Text 'Changes the Password field to the inputted password
                    'Write a new record to TempFile.txt, delimiting the fields with ","
                    st.WriteLine(StudentRecords(0) & "," & StudentRecords(1) & "," & StudentRecords(2) & "," & StudentRecords(3) & "," & StudentRecords(4) & "," & StudentRecords(5) & "," & StudentRecords(6))
                Else 'Otherwise, in which case the record is supposed to stay the same,
                    st.WriteLine(StringLine) 'Writes the original record to the temporary database
                End If
                StringLine = sr.ReadLine() 'Reads the next Student record
            End While
            sr.Close() 'Close Students StreamReader
            st.Close() 'Close TempFile SteamWriter
            File.Delete("Students.txt") 'Deletes Students.txt file (old students database)
            File.Move("TempFile.txt", "Students.txt") 'Rename TempFile.txt to Students.txt (which becomes the new, edited students database)
        ElseIf WhichForm = "TeacherDBoard" Then 'If a teacher is changing their password
            Dim sr As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers StreamReader to read from Teachers.txt (Teachers database)
            Dim st As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Opens TempFile StreamWriter to write to TempFile.txt (Temporay database)
            StringLine = sr.ReadLine() 'Read the first teacher record of the teachers database
            While (StringLine <> Nothing)
                TeacherRecords = StringLine.Split(",") 'Split comma delimited fields into TeacherRecords array
                If (TeacherRecords(0) = UserID) Then 'If a match is found... (the user's record)
                    TeacherRecords(5) = txtPassword.Text 'Changes the Password field to the inputted password
                    'Write a new teacher record to TempFile.txt, delimiting the fields with ","
                    st.WriteLine(TeacherRecords(0) & "," & TeacherRecords(1) & "," & TeacherRecords(2) & "," & TeacherRecords(3) & "," & TeacherRecords(4) & "," & TeacherRecords(5))
                Else
                    'Use st to write record to a new line on the file
                    st.WriteLine(StringLine)
                End If
                StringLine = sr.ReadLine() 'Assign the next line of the file, using sr, to StringLine
            End While
            sr.Close() 'Close Teachers StreamReader
            st.Close() 'Close TempFile StreamWriter
            File.Delete("Teachers.txt") 'Delete Teachers.txt file (old teachers database)
            File.Move("TempFile.txt", "Teachers.txt") 'Rename TempFile.txt to Teachers.txt (which becomes the new, edited teachers database)
        ElseIf WhichForm = "AdminDBoard" Then 'If the admin is changing their password
            File.Delete("Admin.txt") 'Deletes old Admin.txt file (Admin database)
            CheckDatabase("Admin.txt") 'Creates new Admin.txt file (Admin database)
            Dim sw As New System.IO.StreamWriter(Dir$("Admin.txt")) 'Opens Admin StreamWriter to write to Admin.txt (Admin database)
            sw.WriteLine("admin") 'Writes username "admin" to database
            sw.WriteLine(txtPassword.Text) 'Write password to database (on a new line)
            sw.Close() 'Closes Admin StreamWriter
        End If
        MsgBox("Password changed!") 'Message box outputs to the user that the password has been changed
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged 'Procedure for when txtPassword text box input is changed
        lbPasswordWarning.Text = ValidatePass(txtPassword.Text) 'Validating the inputted password
    End Sub

    Private Sub txtPassConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtPassConfirm.TextChanged 'Procedure for when txtPassConfirm text box input is changed
        lbPassConfirmWarning.Text = ValidatePassConfirm(txtPassword.Text, txtPassConfirm.Text) 'Verifying the password with the confirmed password input
    End Sub
End Class