Imports System.IO
Module Procedures
    'Declaring public variables
    Public AccessType As String = "" 'User access level
    Public UserID As String = "" 'The ID of the user's record
    Public StringLine As String 'Stores a record that has been read by a file StreamReader
    Public StudentRecords() As String 'Stores the fields of a student record
    Public TeacherRecords() As String 'Stores the fields of a teacher record
    Public Days(4) As String 'Array that stores the days of the week (used in lessons)
    Public GrabbedID As String = "" 'The ID of a foreign key used to create an enrolment or lesson record
    Public GetID As Boolean 'Whether the form is being used to obtain an ID or not
    Public GetFrom As String 'What form the ID is being used as a foreign key for
    Public IndexFound As Boolean 'Whether a match has been found in a binary search
    Public MaxIndex As Integer 'The maximum index of an array
    'Variables for the Timetable
    Public LessonCount As Integer = 0 'The number of lessons in a timetable
    Public UserCount As Integer = (CountRecords("Students.txt") + CountRecords("Teachers.txt")) 'Total of student and teacher records
    'x = days of the week, y = period of the day, z = userID
    Public TimetableArray(4, 6, (UserCount - 1)) As String 'Array for storing all lessons for each timetable
    Public NewIndex As Integer 'Stores the new maximum index of an array
    Public CurrentDay As Integer 'Day element when adding a lesson to the timetable array
    Public CurrentID As Integer 'UserID element when adding a lesson to the timetable array
    Public IDIndex As Integer 'Index of UserID element when adding a lesson to the timetable array
    Public MaxStudentIndex As Integer = (CountRecords("Students.txt") - 1) 'Index of the last student record of the student database
    Public MaxTeacherIndex As Integer = (CountRecords("Teachers.txt") - 1) 'Index of the last teacher record of the teacher database
    Public StudentIDs(MaxStudentIndex) As String 'Array of StudentIDs
    Public TeacherIDs(MaxTeacherIndex) As String 'Array of TeacherIDs
    'Array of labels for lessons of each day of the week
    Public MondayLessons(6) As Label
    Public TuesdayLessons(6) As Label
    Public WednesdayLessons(6) As Label
    Public ThursdayLessons(6) As Label
    Public FridayLessons(6) As Label

    Public Sub Back() 'Declare Back Procedure
        GetID = False 'Initialises GetID as the previous form is closed
        Select Case AccessType 'Case statement for the value of AccessType
            Case "Admin" 'If the value is "Admin"...
                AdminDBoard.Show() 'Show AdminDBoard form
            Case "Teacher" 'If the value is "Teacher"...
                TeacherDBoard.Show() 'Show TeacherDBoard form
            Case "Student" 'If the value is "Student"...
                StudentDBoard.Show() 'Show StudentDBoard form
        End Select
        Login.Close() 'Closes the Login form 
    End Sub

    Public Sub DayCheck(ByVal Checked As Boolean, ByVal Index As Integer, ByVal Day As String) 'Updates Days array based on checkboxes
        If Checked = True Then 'If Checked is True...
            Days(Index) = Day 'Assign value of Day to Days(Index)
        Else 'Otherwise (Checked is False)...
            Days(Index) = "" 'Assign blank value to Days(Index)
        End If
    End Sub

    Public Sub InitialiseDays() 'Declare InitialiseDays procedure
        'Populating array Days with strings for each consecutive day of the week
        Days(0) = "Monday" 'Assign "Monday" to Days(0)
        Days(1) = "Tuesday" 'Assign "Tuesday" to Days(1)
        Days(2) = "Wednesday" 'Assign "Wednesday" to Days(2)
        Days(3) = "Thursday" 'Assign "Thursday" to Days(3)
        Days(4) = "Friday" 'Assign "Friday" to Days(4)
    End Sub

    Function AlphaCompare(ByRef Type As String, ByRef Element As String, ByRef Element1 As String, ByRef Start As Integer) 'Procedure for comparing the ASCII values of letters of two elements
        'Uses Substring to collect a specific character from each Element string
        Dim FirstLetter As Char = Element.Substring(Start, 1) 'The first letter of the first element
        Dim FirstLetter1 As Char = Element1.Substring(Start, 1) 'The first letter of the next consecutive element that is being compared
        Dim LetterVal As Integer = Convert.ToByte(FirstLetter) 'The ASCII value of the first letter of the first element
        Dim LetterVal1 As Integer = Convert.ToByte(FirstLetter1) 'The ASCII value of the first letter of the next consecutive element that is being compared
        'Comparing ASCII values from letters of each element
        If (Type = "A-Z") Or (Type = "Search") Then 'If you want to sort from A to Z
            If LetterVal > LetterVal1 Then 'If one letter has a higher ASCII value than the letter of the other element
                Return 1 'Returns 1 because they need to be swapped
            ElseIf LetterVal = LetterVal1 Then 'If the letters have the same ASCII value
                Return 2 'Returns 2 to run through the function again for the next letter
            Else
                Return 0 'Returns 0 because they don't need to be swapped
            End If
        Else 'If you want to sort from Z-A
            If LetterVal < LetterVal1 Then 'If one letter has a lower ASCII value than the letter of the other element
                Return 1 'Returns 1 because they need to be swapped
            ElseIf LetterVal = LetterVal1 Then 'If the letters have the same ASCII value
                Return 2 'Returns 2 to run through the function again for the next letter
            Else
                Return 0 'Returns 0 because they don't need to be swapped
            End If
        End If
    End Function

    Function WordCompare(ByRef Type As String, ByRef Element As String, ByRef Element1 As String) 'Procedure for comparing the ASCII values of two elements
        Dim Result As Integer = 2 'The result of the comparsion
        Dim Start As Integer = 0 'The starting character of an element to be used during a substring
        If (Type = "Search") And (Element = Element1) Then 'if there is a binary search and the two words are the same then it returns 3
            Return 3
        End If

        'If a value of 1 is being returned, the two elements need to be swapped
        'If a value of 0 is returned, the two elements dont need to be swapped
        While (Result = 2) And (Start < Len(Element)) And (Start < Len(Element1)) 'While the two letters are the same and the end of the string element has not yet been reached
            Result = AlphaCompare(Type, Element, Element1, Start) 'Calls AlphaCompare function 
            Start = Start + 1 'Increments Start by 1
        End While
        If Result = 2 Then 'If the two letters are the same but we have reached the end of one element
            If Start = Len(Element) Then 'If that one element is the one that's supposed to have a lower value than the element it's being compared with
                If ((Type = "A-Z") Or (Type = "Search")) Then 'If they are being sorted in ascending order or used for a binary search
                    Return 0 'They do not need to be swapped
                Else 'If they are being sorted in descending order
                    Return 1 'They do need to be swapped
                End If
            ElseIf Start = Len(Element1) Then 'If the one element that has reached its end is the supposedly higher element
                If ((Type = "A-Z") Or (Type = "Search")) Then 'If they are being sorted in ascending order or used for a binary search
                    Return 1 'They need to be swapped
                Else 'If they are being sorted in descending order
                    Return 0 'They don't need to be swapped
                End If
            End If
        End If
        Return Result 'Returns the result
    End Function


    Function ToArray(ByRef lstView As ListView) 'Function for sending listview items to an array (for full names)
        Dim NameArray((lstView.Items.Count) - 1) As String 'String array for storing names
        Dim NameIndex As Integer = 0 'The index of the current NameArray element (during the following loop)
        Dim FullName As String = "" 'The full name of the student
        For Each NameItem As ListViewItem In lstView.Items 'Loops through listview items
            'Assigns listview item fields to FullName, and then FullName to the current element at NameArray
            FullName = NameItem.SubItems.Item(0).Text & "," & NameItem.SubItems.Item(1).Text
            NameArray(NameIndex) = FullName
            NameIndex = NameIndex + 1 'Increments NameIndex by 1
        Next
        Return NameArray 'Once all of the names have been stored in the array it returns this array
    End Function

    Public Sub UpdateListView(ByRef lstView As ListView, ByVal fileDir As String) 'Procedure for updating a listview
        'Setting up the listview so that rows and gridlines can be seen
        lstView.View = View.Details
        lstView.GridLines = True
        lstView.FullRowSelect = True
        'Populating listview with items
        Dim sr As New System.IO.StreamReader(Dir$(fileDir), True) 'Opens file StreamReader
        Dim FileRecords() As String 'Declare FileRecords as String Array to store record fields
        lstView.Items.Clear() 'Clear the items in the listview
        StringLine = sr.ReadLine() 'Read the first line (record) of the file, assign it to StringLine
        While (StringLine <> Nothing) 'Looping while the record is not blank (end of file has not been reached)
            FileRecords = StringLine.Split(",") 'Split the record into an array from the record's comma delimiters
            Dim NewItem As New ListViewItem 'Declare NewItem as a new listview item
            NewItem = New ListViewItem(FileRecords) 'Assign a new listview item, taking in the elements of FileRecords as sub-items, to NewItem 
            lstView.Items.Add(NewItem) 'Add NewlItem to the listview
            If WhichForm = "Enrolments" Then 'If the Enrolments form is being used
                EnrolOverlap(FileRecords(2), FileRecords(3)) 'Checks if there is an overlap with the student and subject being enrolled
            End If
            StringLine = sr.ReadLine() 'Assigns the next record to StringLine
        End While
        sr.Close() 'Close file StreamReader
    End Sub

    Public Sub UpdateComboBox(ByRef cBox As ComboBox, ByVal fileDir As String) 'Procedure for updating a combo-box
        'Populating combo-box with items
        Dim sr As New StreamReader(Dir$(fileDir), True) 'Opens file StreamReader
        Dim FileRecords() As String 'Declare FileRecords as String Array
        StringLine = sr.ReadLine() 'Read the first record of the file, assign it to StringLine
        While (StringLine <> Nothing) 'Looping while the record is not blank (end of file has not been reached)
            FileRecords = StringLine.Split(",") 'Split StringLine into an array from the record's comma delimiters
            cBox.Items.Add(FileRecords(0)) 'Add first field (record ID) of the file record to the combo-box
            StringLine = sr.ReadLine() 'Assigns the next record to StringLine
        End While
        sr.Close() 'Close file StreamReader
    End Sub

    Public Function CountRecords(ByVal fileDir As String) 'Procedure for counting the number of records stored in a file
        Dim sr As New StreamReader(Dir$(fileDir)) 'Declares file StreamReader
        Dim Count As Integer = 0 'Count is the number of records in the file
        StringLine = sr.ReadLine() 'Reads first record of the file
        While (StringLine <> Nothing) 'While EOF has not been reached
            Count = Count + 1 'Increment Count by 1
            StringLine = sr.ReadLine() 'Read next record of the file
        End While
        sr.Close() 'Close file StreamReader
        Return Count 'Returns Count: the number of records in the file
    End Function

    Public Sub ClearTempFile() 'Procedure for clearing the TempFile (of its old temporarily stored records)
        File.Delete("TempFile.txt") 'Deletes the old TempFile, if it exists
        Dim st As New StreamWriter(Application.StartupPath & "\TempFile.txt", True) 'Declare st variable as a new StreamWriter, creating a new database (TempFile.txt) to write data to
        st.Close() 'Close st (TempFile StreamWriter) 
    End Sub

    Public Sub ChangeItem(ByRef cboID As ComboBox, ByVal SelectedItem As String) 'Procedure for changing the selected item of a combo box after an ID has been collected
        cboID.SelectedItem = CStr(SelectedItem) 'Changes selected item of combo box to the ID of the selected record
        GetID = False 'As the ID has been attained
    End Sub



    'Procedure for checking the time of the lesson
    Public Sub CheckLessonTime(ByRef LessonRecords() As String, ByRef Subject As String, ByRef lbP1 As Label, ByRef lbP2 As Label,
                               ByRef lbP3 As Label, ByRef lbP4 As Label, ByRef lbP5 As Label, ByRef lbP6 As Label, ByRef lbP7 As Label)
        'Adds the lesson to the Timetables array
        If LessonRecords(2) = "9" Then '09:00 -> Period 1
            AddLessonElement(LessonRecords, Subject, 0)
        ElseIf LessonRecords(2) = "10" Then '10:00 -> Period 2
            AddLessonElement(LessonRecords, Subject, 1)
        ElseIf LessonRecords(2) = "11" Then '11:00 -> Period 3
            AddLessonElement(LessonRecords, Subject, 2)
        ElseIf LessonRecords(2) = "12" Then '12:00 -> Period 4
            AddLessonElement(LessonRecords, Subject, 3)
        ElseIf LessonRecords(2) = "13" Then '13:00 -> Period 5
            AddLessonElement(LessonRecords, Subject, 4)
        ElseIf LessonRecords(2) = "14" Then '14:00 -> Period 6
            AddLessonElement(LessonRecords, Subject, 5)
        ElseIf LessonRecords(2) = "15" Then '15:00 -> Period 7
            AddLessonElement(LessonRecords, Subject, 6)
        End If
    End Sub

    Public Sub AddLessonElement(ByRef LessonRecords() As String, ByRef Subject As String, ByRef Period As Integer)
        TimetableArray(CurrentDay, Period, CurrentID) = LessonRecords(0) & " " & Subject & vbNewLine & LessonRecords(4)
    End Sub

    Public Sub AddLesson(ByRef LessonRecords() As String, ByRef Subject As String, ByRef lbLesson As Label) 'Procedure for adding the lesson to its correct lesson label on the timetable
        lbLesson.Text = LessonRecords(0) & " " & Subject & vbNewLine & LessonRecords(4) 'Concatenates the LessonID, subject name and RoomID
    End Sub

    Public Function GetSubject(ByRef Subjects() As String, ByRef SubjectID As String) 'Function for getting the subject ID
        Dim SubjectName As String = "" 'Stores the name of the subject
        If Subjects.Count = 0 Then 'If no subjects are common then it returns nothing
            Return Nothing
        End If
        For Index = 0 To (Subjects.Count - 1) 'Loops through the subjects array
            If Subjects(Index) = SubjectID Then 'If there is a match then it calls the function to get the subject name from its ID
                Return GetSubjectName(SubjectID)
            End If
        Next
        Return SubjectName 'Returns the name of the subject
    End Function

    Public Function GetSubjectName(ByVal SubjectID As String) 'Function for getting the name of the Subject given its SubjectID
        Dim sr As New System.IO.StreamReader(Dir$("Subjects.txt")) 'Declare sr variable as a new StreamReader, to read from Subjects.txt
        Dim SubjectRecords() As String 'Array for storing the fields of a subject record
        Dim SubjectName As String = "" 'Stores the name of the subject
        'Reading subject records in Subjects file
        StringLine = sr.ReadLine() 'Read first record of the Subjects file
        While (StringLine <> Nothing) 'Loops through subject records while EOF has not yet been reached
            SubjectRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to SubjectRecords
            If SubjectRecords(0) = SubjectID Then 'If there is a match then it assigns the name field to SubjectName
                SubjectName = SubjectRecords(1)
            End If
            StringLine = sr.ReadLine() 'Reads the next subject record
        End While
        Return SubjectName 'Returns SubjectName
    End Function

    Public Sub LessonClick(ByRef lbLesson As Label) 'Procedure for when a lesson label is clicked
        Dim Count As Integer = 1 'Counts the string length of the LessonID
        GrabbedID = "" 'Initialises GrabbedID
        If lbLesson.Text = "" Then 'If there is no lesson it exits the procedure
            Exit Sub
        End If
        'If there is a lesson then it grabs the lesson ID (given at the start of the label) and opens the LessonInfo form
        For Each Character As Char In lbLesson.Text 'Loops through each character in the lesson label
            If IsNumeric(Character) = True Then 'If the character is a number then it's part of the LessonID 
                GrabbedID += Character 'Appends the number to GrabbedID
            Else 'If the character is no longer numeric then it has reached the end of the LessonID
                Exit For 'So it exits the for loop
            End If
        Next
        LessonInfo.Show() 'Opens LessonInfo form
    End Sub

    Public Sub NameTimetable(ByRef lbName As Label, ByVal fileDir As String, ByVal RecordID As Integer) 'Procedure for getting the correct name of the person the timetable belongs to
        'Writing name to timetable (lbName)
        Dim sr As New System.IO.StreamReader(Dir$(fileDir)) 'Declare sr variable as a new StreamReader, to read from file directory (Students.txt or Teachers.txt)
        StringLine = sr.ReadLine() 'Read first record of the file
        If fileDir = "Students.txt" Then 'If the user is a student then it reads the student file
            While (StringLine <> Nothing) 'Loops through student records while EOF has not yet been reached
                StudentRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to StudentRecords
                If StudentRecords(0) = RecordID Then 'If there is a match
                    lbName.Text = StudentRecords(0) & " " & StudentRecords(1) & " " & StudentRecords(2) 'Concatenates the StudentID, first name and last name to the label text
                    Exit While 'Exits while loop
                End If
                StringLine = sr.ReadLine() 'Reads next student record
            End While
        Else 'The user is a teacher then it reads the teacher file
            While (StringLine <> Nothing) 'Loops through teacher records while EOF has not yet been reached
                TeacherRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to TeacherRecords
                If TeacherRecords(0) = RecordID Then 'If there is a match
                    lbName.Text = TeacherRecords(0) & " " & TeacherRecords(1) & " " & TeacherRecords(2) 'Concatenates the TeacherID, first name and last name to the label text
                    Exit While 'Exits while loop
                End If
                StringLine = sr.ReadLine() 'Reads next teacher record
            End While
        End If
        sr.Close() 'Closes the StreamReader
    End Sub

    Public Sub CheckDatabase(ByVal fileDir As String)
        If Dir$(fileDir) = "" Then 'Check current project directory for the database
            Dim sw As New StreamWriter(Application.StartupPath & "\" & fileDir, True) 'Creates a new database (in the form of a text file) to write data using StreamWriter
            sw.Close() 'Close StreamWriter
            MsgBox("A new database has been created", vbExclamation, "Warning!") 'Message box outputs to the user that a new database has been created
        End If
    End Sub

    Public Sub CheckAll()
        'Checks current project directory for the following databases:
        CheckDatabase("Enrolments.txt") 'Enrolments database
        CheckDatabase("Lessons.txt") 'Lessons database
        CheckDatabase("Rooms.txt") 'Rooms databaase
        CheckDatabase("Students.txt") 'Students database
        CheckDatabase("Subjects.txt") 'Subjects database
        CheckDatabase("Teachers.txt") 'Teachers database
        CheckDatabase("Admin.txt") 'Admin login details
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
    End Sub

    Public Sub StoreIDArray(ByRef IDArray() As String, ByVal lstView As ListView) 'Procedure for updating the ID array to store IDs for current records
        Dim Index As Integer = 0 'Index of the IDArray (during the loop)
        For Each ListItem As ListViewItem In lstView.Items 'Loops through each item in the listview
            IDArray(Index) = ListItem.SubItems.Item(0).Text 'Assigns the ID field of the item to the IDArray element
            Index = Index + 1 'Increments Index by 1
        Next
    End Sub

    'Timetables

    Public Function GetIDs(FileDir As String, Array() As String) 'Function for populating ID array
        Dim sr As New System.IO.StreamReader(FileDir) 'StreamReader to read from the specified file database
        Dim Index As Integer = 0 'To start at the first element of the array
        StringLine = sr.ReadLine() 'Reads the first record of the database
        Dim FileRecords() As String 'Declares an array to store the fields of a file
        While StringLine <> Nothing 'Loops while end of file has not been reached
            FileRecords = StringLine.Split(",") 'Splits the record into comma delimited fields
            Array(Index) = FileRecords(0) 'Assigns the ID to the array at the current index element
            StringLine = sr.ReadLine() 'Reads the next record of the database
            Index = Index + 1 'Increments the index by 1 for the next element of the array
        End While
        Return Array 'Returns the ID array
    End Function

    Private Sub CheckLesson(LessonRecords() As String, Subject As String) 'Procedure for checking the day of the lesson
        'This determines what day on which the lesson occurs, and so what labels to then pick from depending on the lesson time
        If LessonRecords(1) = "Monday" Then 'Selects a period from 1 to 7 on Monday
            CurrentDay = 0
            CheckLessonTime(LessonRecords, Subject, MondayLessons(0), MondayLessons(1), MondayLessons(2), MondayLessons(3), MondayLessons(4), MondayLessons(5), MondayLessons(6))
        ElseIf LessonRecords(1) = "Tuesday" Then 'Selects a period from 1 to 7 on Tuesday
            CurrentDay = 1
            CheckLessonTime(LessonRecords, Subject, TuesdayLessons(0), TuesdayLessons(1), TuesdayLessons(2), TuesdayLessons(3), TuesdayLessons(4), TuesdayLessons(5), TuesdayLessons(6))
        ElseIf LessonRecords(1) = "Wednesday" Then 'Selects a period from 1 to 7 on Wednesday
            CurrentDay = 2
            CheckLessonTime(LessonRecords, Subject, WednesdayLessons(0), WednesdayLessons(1), WednesdayLessons(2), WednesdayLessons(3), WednesdayLessons(4), WednesdayLessons(5), WednesdayLessons(6))
        ElseIf LessonRecords(1) = "Thursday" Then 'Selects a period from 1 to 7 on Thursday
            CurrentDay = 3
            CheckLessonTime(LessonRecords, Subject, ThursdayLessons(0), ThursdayLessons(1), ThursdayLessons(2), ThursdayLessons(3), ThursdayLessons(4), ThursdayLessons(5), ThursdayLessons(6))
        ElseIf LessonRecords(1) = "Friday" Then 'Selects a period from 1 to 7 on Friday
            CurrentDay = 4
            CheckLessonTime(LessonRecords, Subject, FridayLessons(0), FridayLessons(1), FridayLessons(2), FridayLessons(3), FridayLessons(4), FridayLessons(5), FridayLessons(6))
        End If
    End Sub

    Public Sub UpdateTimetableArray() 'Procedure for updating the timetable array
        If (WhichForm <> "StudentDBoard") And (WhichForm <> "TeacherDBoard") And (WhichForm <> "Timetables") Then 'This makes sure that the procedure only runs when it is called
            Exit Sub
        End If
        IDIndex = 0 'Initialises IDIndex as 0
        StudentIDs = GetIDs("Students.txt", StudentIDs) 'Populates StudentIDs array
        For CurrentID = 0 To MaxStudentIndex 'Adding student elements to timetable array
            Dim Subjects(1) As String 'Array for storing SubjectIDs corresponding to subjects the student is taking
            'Populating Subjects array
            Dim sr As New System.IO.StreamReader(Dir$("Enrolments.txt")) 'Opens Enrolments StreamReader to read from Enrolments database
            StringLine = sr.ReadLine() 'Reads the first Enrolments record
            Dim EnrolRecords() As String 'Declare EnrolRecords as String Array
            While (StringLine <> Nothing) 'Looping through Enrolments records while EOF has not yet been reached
                EnrolRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to EnrolRecords array
                If EnrolRecords(2) = StudentIDs(IDIndex) And (Subjects.Contains(EnrolRecords(3)) = False) Then 'If there is a match with the StudentID field and the UserID
                    If Subjects.Count = 0 Then 'If there are no elements in the Subjects array
                        NewIndex = 1 'Assign 1 to NewIndex
                    Else 'Otherwise...
                        NewIndex = Subjects.Count 'Assign the number of Subjects to NewIndex
                    End If
                    ReDim Preserve Subjects(NewIndex) 'Resize Subjects so that its length is equal to NewIndex + 1
                    Subjects(NewIndex) = EnrolRecords(3) 'Assign the subjectID field of the enrolment record to Subjects(NewIndex)
                End If
                StringLine = sr.ReadLine() 'Reads the next Enrolments record
            End While 'End while loop
            sr.Close() 'Close Enrolments StreamReader
            'Populating timetable with lessons
            Dim sr1 As New System.IO.StreamReader(Dir$("Lessons.txt"), True) 'Opens Lessons StreamReader to read from Lessons database
            Dim LessonRecords() As String 'Declare LessonRecords as String Array
            Dim LessonSubject As String 'Subject name for the lesson
            StringLine = sr1.ReadLine() 'Reads the first Lessons record
            While (StringLine <> Nothing) 'Looping through Lessons database while EOF has not been reached
                LessonRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to LessonRecords
                'If Subjects contains an element equal to the SubjectID field and Days contains an element equal to the Day field...
                If Subjects.Contains(LessonRecords(5)) And Days.Contains(LessonRecords(1)) Then
                    'Checks lesson details to add a lesson to the timetable array
                    LessonSubject = GetSubject(Subjects, LessonRecords(5))
                    CheckLesson(LessonRecords, LessonSubject)
                End If
                StringLine = sr1.ReadLine() 'Reads the next Lessons record
            End While 'End while loop
            sr1.Close() 'Close Lessons StreamReader
            IDIndex = IDIndex + 1
        Next
        TeacherIDs = GetIDs("Teachers.txt", TeacherIDs) 'Populates TeacherIDs array
        IDIndex = 0 'Initialises IDIndex as 0 again (for the TeacherIDs array)
        For CurrentID = (MaxStudentIndex + 1) To (UserCount - 1) 'Adding teacher elements to timetable array
            ClearLessons() 'Clears the lesson labels so that the updated ones can be added
            Dim LessonSubject As String 'The lesson's subject name
            Dim sr As New System.IO.StreamReader(Dir$("Lessons.txt"), True) 'Opens Lessons StreamReader to read records from Lessons.txt (Lessons database)
            Dim LessonRecords() As String 'Declare LessonRecords as String Array
            StringLine = sr.ReadLine() 'Reads the first Lessons record
            LessonRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to LessonRecords
            While (StringLine <> Nothing) 'Looping through Lessons records while EOF has not yet been reached
                LessonRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to LessonRecords
                'If the TeacherID field is equal to UserID and Days contains an element equal to the Day field...
                If (LessonRecords(6) = TeacherIDs(IDIndex)) And Days.Contains(LessonRecords(1)) Then
                    LessonSubject = GetSubjectName(LessonRecords(5))
                    CheckLesson(LessonRecords, LessonSubject)
                End If
                StringLine = sr.ReadLine() 'Assign the next line of the database, using sr, to StringLine
            End While
            sr.Close() 'Closes Lessons StreamReader
            IDIndex = IDIndex + 1
        Next
    End Sub

    'Populating an array of labels with labels
    Public Sub ToLbArray(Array() As Label, lbP1 As Label, lbP2 As Label, lbP3 As Label, lbP4 As Label, lbP5 As Label, lbP6 As Label, lbP7 As Label)
        'Assigning each label to an element in the array of labels (where the array represents a day of the week, each label represents lesson period)
        Array(0) = lbP1 'Period 1
        Array(1) = lbP2 'Period 2
        Array(2) = lbP3 'Period 3
        Array(3) = lbP4 'Period 4
        Array(4) = lbP5 'Period 5
        Array(5) = lbP6 'Period 6
        Array(6) = lbP7 'Period 7
    End Sub

    Public Sub ClearDayLessons(LabelArray() As Label) 'Clearing all of the lessons for a day
        If (WhichForm <> "StudentDBoard") And (WhichForm <> "TeacherDBoard") And (WhichForm <> "Timetables") Then 'This makes sure that the procedure only runs when it is called
            Exit Sub
        End If
        For Index = 0 To 6 'Looping through the array of labels
            LabelArray(Index).Text = "" 'initialises the label text for a new timetable to be displayed
        Next
    End Sub

    Public Sub ClearLessons() 'Clears the lessons for the entire timetable for a new one to be displayed
        ClearDayLessons(MondayLessons)
        ClearDayLessons(TuesdayLessons)
        ClearDayLessons(WednesdayLessons)
        ClearDayLessons(ThursdayLessons)
        ClearDayLessons(FridayLessons)
    End Sub

    Public Sub AssignLessonLabels(ByVal CurrentIndex As Integer, MonCheck As Boolean, TueCheck As Boolean, WedCheck As Boolean,
                                   ThurCheck As Boolean, FriCheck As Boolean) 'Procedure for assigning lesson details to their respective labels
        'Depends on which filters are checked
        'It assigns each TimetableArray element for (for the correct day, period and ID) to the correct label 
        LessonCount = 0 'Initialise number of lessons in the timetable
        If MonCheck = True Then 'If Monday is checked then it displays the details for Monday's lessons
            For LabelIndex = 0 To 6 'Loops through the labels
                MondayLessons(LabelIndex).Text = TimetableArray(0, LabelIndex, CurrentIndex)
                If MondayLessons(LabelIndex).Text <> "" Then 'If this label isnt blank then it increments the lesson count by 1
                    LessonCount = LessonCount + 1 'Increments number of lessons by 1
                End If
            Next
        End If

        If TueCheck = True Then 'If Tuesday is checked then it displays the details for Tueday's lessons
            For LabelIndex = 0 To 6 'Loops through the labels
                TuesdayLessons(LabelIndex).Text = TimetableArray(1, LabelIndex, CurrentIndex)
                If TuesdayLessons(LabelIndex).Text <> "" Then 'If this label isnt blank then it increments the lesson count by 1
                    LessonCount = LessonCount + 1 'Increments number of lessons by 1
                End If
            Next
        End If

        If WedCheck = True Then 'If Wednesday is checked then it displays the details for Wednesday's lessons
            For LabelIndex = 0 To 6 'Loops through the labels
                WednesdayLessons(LabelIndex).Text = TimetableArray(2, LabelIndex, CurrentIndex)
                If WednesdayLessons(LabelIndex).Text <> "" Then 'If this label isnt blank then it increments the lesson count by 1
                    LessonCount = LessonCount + 1 'Increments number of lessons by 1
                End If
            Next
        End If

        If ThurCheck = True Then 'If Thursday is checked then it displays the details for Thursday's lessons
            For LabelIndex = 0 To 6 'Loops through the labels
                ThursdayLessons(LabelIndex).Text = TimetableArray(3, LabelIndex, CurrentIndex)
                If ThursdayLessons(LabelIndex).Text <> "" Then 'If this label isnt blank then it increments the lesson count by 1
                    LessonCount = LessonCount + 1 'Increments number of lessons by 1
                End If
            Next
        End If

        If FriCheck = True Then  'If Friday is checked then it displays the details for Friday's lessons
            For LabelIndex = 0 To 6 'Loops through the labels
                FridayLessons(LabelIndex).Text = TimetableArray(4, LabelIndex, CurrentIndex)
                If FridayLessons(LabelIndex).Text <> "" Then 'If this label isnt blank then it increments the lesson count by 1
                    LessonCount = LessonCount + 1 'Increments number of lessons by 1
                End If
            Next
        End If
    End Sub

End Module
