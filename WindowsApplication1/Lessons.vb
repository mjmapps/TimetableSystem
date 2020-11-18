Imports System.IO 'Reference library so read and write commands can be used
Public Class Lessons
    Public Structure Lessons 'Declaring structure Lessons
        'Declaring members (fields) of structure Lessons
        Public LessonID As String
        Public LessonDay As String
        Public Time As Integer
        Public Duration As String
        Public RoomID As String
        Public SubjectID As String
        Public TeacherID As String
    End Structure
    'Declaring public variables
    Public Lesson As New Lessons 'Declare Lesson as new instance of Lessons
    Public LessonSelect As Boolean 'Determines if a lesson listview item has been selected or not
    'Declaring private string array
    Dim LessonEntry(6) As String 'Stores fields of current record

    Private Sub Lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "Lessons" 'Current form is Lessons
        CheckAll() 'Making sure each database exists
        'Updating the lessons listview as well as the subject, rooms and teachers combo-boxes
        UpdateListView(lstLessons, "Lessons.txt")
        UpdateComboBox(cboSubjectID, "Subjects.txt")
        UpdateComboBox(cboRoomID, "Rooms.txt")
        UpdateComboBox(cboTeacherID, "Teachers.txt")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'Procedure for when Back button is clicked
        Back() 'Calls Back procedure
        Me.Close() 'Close current form
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'Procedure for when Add button is clicked
        'Validation checks
        InvalidCount = 0 'Assigns 0 to InvalidCount to start a new validation check
        LessonsPresenceCheck() 'Checks if there are issues with the lesson combination
        'Assigning inputted values to Lesson fields
        Lesson.LessonDay = cboDay.SelectedItem
        Lesson.Time = spTime.Value
        Lesson.Duration = cboDuration.SelectedItem
        Lesson.RoomID = cboRoomID.SelectedItem
        Lesson.SubjectID = cboSubjectID.SelectedItem
        Lesson.TeacherID = cboTeacherID.SelectedItem
        If LessonSelect = False Then 'If a lesson item hasn't been selected to be edited (so the admin is adding a new record)
            OverlapCheck(Lesson.Time, Lesson.RoomID, Lesson.LessonDay, Lesson.SubjectID, Lesson.TeacherID) 'Checks if the lesson's room, subject or teacher is taken
            'OverlapCheck takes in Lesson.Time, Lesson.RoomID, Lesson.LessonDay, Lesson.SubjectID, Lesson.TeacherID as parameters
        End If
        If InvalidCount > 0 Then 'If one or more of the inputs are detected as invalid...
            Exit Sub 'Exit procedure
        End If
        'Adding the item to lstLessons
        Dim LessonItem As New ListViewItem 'Declare LessonItem as new listview item
        Dim TempID As Integer = 0 'Used to calculate the new LessonID
        If LessonSelect = False Then 'If the admin is adding a new item...
            For Each LessonItem1 As ListViewItem In lstLessons.Items 'Looping through each Lessons listview item
                TempID = LessonItem1.SubItems.Item(0).Text 'Assigns the first field of that Lessons record (the ID) to TempID
            Next 'Repeat for next Lessons item
            TempID = TempID + 1 'Increment TempID by 1
            Lesson.LessonID = CStr(TempID) 'Cast TempID to String type then assign this value to Lesson.LessonID
            LessonEntry(0) = Lesson.LessonID
        Else 'If a selected item is being edited then it the ID field is assigned the same value as the selected item's ID (1 + the index)
            LessonEntry(0) = CStr(lstLessons.FocusedItem.Index + 1)
        End If
        'Assigning lesson fields to LessonEntry array
        LessonEntry(1) = Lesson.LessonDay
        LessonEntry(2) = Lesson.Time
        LessonEntry(3) = Lesson.Duration
        LessonEntry(4) = Lesson.RoomID
        LessonEntry(5) = Lesson.SubjectID
        LessonEntry(6) = Lesson.TeacherID
        LessonItem = New ListViewItem(LessonEntry) 'Assign a new listview item, taking in the elements of LessonEntry as sub-items, to LessonItem
        If LessonSelect = True Then 'If the admin is editing an item...
            lstLessons.Items(lstLessons.FocusedItem.Index) = LessonItem 'Assign the new item to the selected item (and so edits it)
            Exit Sub 'Exit procedure
        End If
        lstLessons.Items.Add(LessonItem) 'Add the new item to the Lessons listview
    End Sub

    Private Sub lstLessons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLessons.SelectedIndexChanged 'Procedure for when selected index of lstLessons is changed
        LessonSelect = False 'LessonSelect is currently False as the selected item has not yet been found
        'Checking for a selected Lessons listview item
        If lstLessons.SelectedItems.Count > 0 Then 'If the number of selected items in Lessons listview is greater than 0...
            For Each LessonItem As ListViewItem In lstLessons.Items 'Loop through each Lessons listview item
                If LessonItem.Index = lstLessons.FocusedItem.Index Then 'If there is a match with the selected index and the current item's index
                    'The selected item has been found
                    LessonSelect = True 'LessonSelect is now true
                    'Assign fields of the selected item to the input boxes (so that the admin can view or edit them)
                    cboDay.SelectedItem = LessonItem.SubItems.Item(1).Text
                    spTime.Value = LessonItem.SubItems.Item(2).Text
                    cboDuration.SelectedItem = LessonItem.SubItems.Item(3).Text
                    cboSubjectID.SelectedItem = LessonItem.SubItems.Item(5).Text
                    cboRoomID.SelectedItem = LessonItem.SubItems.Item(4).Text
                    cboTeacherID.SelectedItem = LessonItem.SubItems.Item(6).Text
                    Exit For 'Exit for loop
                End If
            Next 'Repeat for next Lessons listview item
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Procedure for when Delete button is clicked
        'Deleting an item from lstLessons
        If (lstLessons.Items.Count > 0) And (LessonSelect = True) Then 'If the number of items in lstLessons is greater than 0 and a Lessons listview item has been selected...
            lstLessons.Items.RemoveAt(lstLessons.SelectedIndices(0)) 'Remove the selected item in lstLessons
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        'Saving the current records to the file
        File.Delete("Lessons.txt") 'Delete the file Lessons.txt (Lessons database)
        Dim sw As New StreamWriter(Application.StartupPath & "\Lessons.txt", True) 'Open Lessons StreamWriter
        For Each LessonItem As ListViewItem In lstLessons.Items 'Looping through each Lessons listview item
            'Assigning inputted values to Lesson fields
            Lesson.LessonID = LessonItem.SubItems.Item(0).Text
            Lesson.LessonDay = LessonItem.SubItems.Item(1).Text
            Lesson.Time = LessonItem.SubItems.Item(2).Text
            Lesson.Duration = LessonItem.SubItems.Item(3).Text
            Lesson.SubjectID = LessonItem.SubItems.Item(4).Text
            Lesson.RoomID = LessonItem.SubItems.Item(5).Text
            Lesson.TeacherID = LessonItem.SubItems.Item(6).Text
            'Write fields to a new record
            sw.WriteLine(Lesson.LessonID & "," & Lesson.LessonDay & "," & Lesson.Time & "," & Lesson.Duration & "," & Lesson.SubjectID & "," & Lesson.RoomID & "," & Lesson.TeacherID)
        Next 'Repeat for next Lessons listview item
        sw.Close() 'Close Lessons StreamWriter
        MsgBox("Saved!") 'Message box outputs "Saved!" to the user
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click 'Procedure for when "Get Subject" button is clicked
        GetFrom = "Lessons" 'As SubjectID can be searched from Enrolments and Lessons the Subjects form has to know that it's being opened from Lessons
        GetID = True 'So the Subjects form knows that it's being opened to obtain a subject record
        Subjects.Show() 'Opens Subjects form
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click 'Procedure for when "Get Room" button is clicked
        GetID = True 'So the Rooms form knows that it's being opened to obtain a room record
        Rooms.Show() 'Opens Rooms form
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click 'Procedure for when "Get Teacher" button is clicked
        GetFrom = "Lessons" 'As TeacherID can be searched from Enrolments and Timetables the Teachers form has to know that it's being opened from Lessons
        GetID = True 'So the Teachers form knows that it's being opened to obtain a teacher record
        Teachers.Show() 'Opens Teachers form
    End Sub

    '----------------------SORTING------------------------


    Private Function Partition(Array() As Lessons, Low As Integer, High As Integer, ComparisonType As String) 'Function for partitioning the array
        Dim Pivot As Lessons = Array(High) 'The pivot is set as the rightmost element of the part of the array being partitioned
        Dim IndexSmall As Integer = Low - 1 'The index of an element less than the pivot
        Dim Index As Integer = Low 'Index of the array, initialised as the leftmost element within the partition
        Dim TempElement As Lessons 'Temporary element used for the swap
        For Index = Low To (High - 1) 'Loops through the array
            If Comparison(Array, Pivot, Index, ComparisonType) = 0 Then 'If element is less than pivot then it increments the smaller index by 1 and swaps this smaller element with the current element
                'Although if the array is being sorted in descending order, the element will have to be greater than the pivot
                IndexSmall = IndexSmall + 1
                TempElement = Array(Index)
                Array(Index) = Array(IndexSmall)
                Array(IndexSmall) = TempElement
            End If
        Next
        'If the element is greater than or equal to the pivot (for ascending order) then it swaps that element with the rightmost element
        TempElement = Array(High)
        Array(High) = Array((IndexSmall + 1))
        Array((IndexSmall + 1)) = TempElement
        Return ((IndexSmall + 1)) 'Returns the partitioned index
    End Function

    Private Function QuickSort(Array() As Lessons, Low As Integer, High As Integer, ComparisonType As String) 'Function for quicksort
        Dim PartIndex As Integer 'The pivot after partitioning
        If (Low < High) Then 'If the lowest index is less than the highest index
            PartIndex = Partition(Array, Low, High, ComparisonType) 'Calls partition function and assigns its returned value to a partition index
            QuickSort(Array, Low, (PartIndex - 1), ComparisonType) 'Calls quick sort for the lower list (elements less than the pivot)
            QuickSort(Array, (PartIndex + 1), High, ComparisonType) 'Calls quick sort for the upper list (elements greater than the pivot)
        End If
        Return Array 'Returns the sorted array
    End Function




    Private Function Comparison(Array() As Lessons, Pivot As Lessons, Index As Integer, ComparisonType As String) 'Function for determining the order in which the array should be quicksorted 
        'So it determines how the element and pivot should be compared
        Select Case ComparisonType
            Case "ID Asc" 'Sorting by LessonID in ascending order
                If CInt(Array(Index).LessonID) > CInt(Pivot.LessonID) Then 'If element's LessonID is greater than the pivot's LessonID
                    Return 1
                Else
                    Return 0
                End If
            Case "ID Des" 'Sorting by LessonID in descending order
                If CInt(Array(Index).LessonID) < CInt(Pivot.LessonID) Then 'If element's LessonID is less than the pivot's LessonID
                    Return 1
                Else
                    Return 0
                End If
        End Select
        Return -1
    End Function



    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged 'Procedure for when the user selects a Sort
        MaxIndex = CountRecords("Lessons.txt") - 1 'Number of records in Lessons file - 1
        Dim LessonDetails(0 To MaxIndex) As Lessons 'Declares Lessons array of records (structure Lessons)
        Dim RecordLine As String 'The record that is to be written to the sorted TempFile
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        RecordArray(LessonDetails) 'Assigns enrolment records to LessonDetails array
        'Depending on the selected sort method it calls the QuickSort function with a different CompareType parameter
        If cboSort.SelectedIndex = 0 Then 'If the sort is "LessonID (Ascending)"
            LessonDetails = QuickSort(LessonDetails, 0, MaxIndex, "ID Asc")
        ElseIf cboSort.SelectedIndex = 1 Then 'If the sort is "LessonID (Descending)"
            LessonDetails = QuickSort(LessonDetails, 0, MaxIndex, "ID Des")
        Else
            Exit Sub 'If no sort has been selected then it exits the procedure
        End If
        'Writing the sorted records to TempFile
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Declare sw as new StreamWriter to write to TempFile.txt
        For Index = 0 To MaxIndex 'Writes records to TempFile
            RecordLine = CStr(LessonDetails(Index).LessonID & "," & LessonDetails(Index).LessonDay & "," & LessonDetails(Index).Time & "," & LessonDetails(Index).Duration _
                & "," & LessonDetails(Index).RoomID & "," & LessonDetails(Index).SubjectID & "," & LessonDetails(Index).TeacherID)
            sw.WriteLine(RecordLine)
        Next
        sw.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstLessons, "TempFile.txt") 'Updates the lessons listview such that the items are in the new sorted order

    End Sub

    Private Sub RecordArray(ByRef LessonDetails() As Lessons) 'Procedure for assigning values (records read from file) to an array of records
        Dim LessonRecords() As String 'Stored fields of a lesson record
        Dim Index As Integer = 0 'Index of LessonDetails array
        Dim sr As New System.IO.StreamReader(Dir$("Lessons.txt"), True) 'Opens Lessons database StreamReader
        StringLine = sr.ReadLine() 'Read the first line (record) of the lessons file, assign it to StringLine
        While (StringLine <> Nothing) 'While EOF has not been reached
            'Assigning record fields to StudentDetails array
            LessonRecords = StringLine.Split(",") 'Assigns comma delimited fields to LessonRecords array
            LessonDetails(Index).LessonID = LessonRecords(0)
            LessonDetails(Index).LessonDay = LessonRecords(1)
            LessonDetails(Index).Time = LessonRecords(2)
            LessonDetails(Index).Duration = LessonRecords(3)
            LessonDetails(Index).RoomID = LessonRecords(4)
            LessonDetails(Index).SubjectID = LessonRecords(5)
            LessonDetails(Index).TeacherID = LessonRecords(6)
            Index = Index + 1 'Increment Index by 1
            StringLine = sr.ReadLine() 'Read next record of lessons file
        End While
        sr.Close() 'Closes Lessons StreamReader
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Procedure for when Help button is clicked
        'Briefly explains what the Add, Save and Delete buttons do
        MsgBox("Add - adds a lesson item" & vbNewLine & "Save - saves the lesson records to the database" & vbNewLine &
               "Delete - deletes a lesson item that has been selected (clicked) from the listview" & vbNewLine &
               "To edit a lesson record click on it from the listview, edit the desired details then click Add")
    End Sub

    '-------------VALIDATION------------
    Private Sub LessonsPresenceCheck() 'Procedure for presence checking the combo boxes used for lesson fields
        'Presence checking the combo boxes used as input for Lesson fields
        cboPresenceCheck(cboDay, "day") 'Presence check for cboDay combo box
        cboPresenceCheck(cboDuration, "duration") 'Presence check for cboDuration combo box
        cboPresenceCheck(cboSubjectID, "SubjectID") 'Presence check for cboSubjectID combo box
        cboPresenceCheck(cboRoomID, "RoomID") 'Presence check for cboRoomID combo box
        cboPresenceCheck(cboTeacherID, "TeacherID") 'Presence check for cboTeacherID combo box
    End Sub

    Private Sub OverlapCheck(ByRef Time As String, Room As String, Day As String, Subject As String, Teacher As String) 'Procedure for checking for a lesson overlap
        Dim Subjects(lstLessons.Items.Count) As String 'All of the other subjects with lessons taking place at the same day and time
        Dim Students(CountRecords("Enrolments.txt") - 1) As String 'All of the students enrolled to the subject for this lesson
        Dim SubjectIndex As Integer = 0 'Index of the Subjects array
        Dim StudentIndex As Integer = 0 'Index of the Students array
        Dim Count As Integer = 0 'Number of loops through the enrolments database
        For Each LessonItem As ListViewItem In lstLessons.Items 'Looping through each LessonItem, searching for clashes
            'Collects all the other subjects with lessons at that day and time
            If ((Subjects.Contains(LessonItem.SubItems.Item(5).Text) = False) And (LessonItem.SubItems.Item(5).Text <> Subject) And
                (Day = LessonItem.SubItems.Item(1).Text) And (Time = LessonItem.SubItems.Item(2).Text)) Then
                Subjects(SubjectIndex) = Subject
                SubjectIndex = SubjectIndex + 1
            End If
            'Checks for lesson clashes with the room, subject and teacher
            If ((Time = LessonItem.SubItems.Item(2).Text) And (Day = LessonItem.SubItems.Item(1).Text)) Then 'If there is a match with the Time and Day fields
                If (Room = LessonItem.SubItems.Item(4).Text) Then 'If there is a match with the Room field
                    'Room clash so input is invalid
                    InvalidCount = InvalidCount + 1
                    MsgBox("Room is taken at this time.") 'Outputs to the user that the room is taken at this time
                End If
                If (Subject = LessonItem.SubItems.Item(5).Text) Then 'If there is a match with the Subject field
                    'Subject clash so input is invalid
                    InvalidCount = InvalidCount + 1
                    MsgBox("Subject is taken at this time.") 'Outputs to the user that the subject is taken at this time
                End If
                If (Teacher = LessonItem.SubItems.Item(6).Text) Then 'If there is a match with the Teacher field
                    'Teacher clash so input is invalid
                    InvalidCount = InvalidCount + 1
                    MsgBox("Teacher is taken at this time.") 'Outputs to the user that the teacher is taken at this time
                End If
            End If
        Next
        'Checking if students enrolled to the subject of this lesson are also enrolled to subjects of other lessons taking place at the same time
        Do 'Loops through the Enrolments file twice - once to obtain an array of students and again to check for an overlap
            Dim sr As New System.IO.StreamReader(Dir$("Enrolments.txt")) 'Opens Enrolments StreamReader, reading from Enrolments.txt database
            Dim EnrolRecords() As String 'Stores the fields of an enrolment record
            StringLine = sr.ReadLine() 'Reads first Enrolment record
            While (StringLine <> Nothing) 'Loops through Enrolment records in the database while EOF has not yet been reached
                EnrolRecords = StringLine.Split(",") 'Assign comma delimited fields to EnrolRecords array
                If Count = 0 Then 'If it's the first round then this is going to extract the students from enrolments common to this subject
                    If EnrolRecords(3) = Subject Then 'If there is a match with the SubjectID field
                        Students(StudentIndex) = EnrolRecords(2) 'Adds StudentID to the Students array
                        StudentIndex = StudentIndex + 1 'Increments StudentIndex by 1
                    End If
                Else 'In the second round it's going to check for an overlap between the students of this lesson and the subjects of other lessons taking place at this day and time
                    'If there is a match with StudentID and an element in Students, and a match with SubjectID and an element in Subjects
                    If ((Students.Contains(EnrolRecords(2))) And (Subjects.Contains(EnrolRecords(3)))) Then
                        'Then there is a clash/overlap so this input is invalid
                        InvalidCount = InvalidCount + 1
                        MsgBox("There is an overlap as a student for this subject has another lesson at this day and time.") 'Outputs to the user that there is an overlap
                    End If
                End If
                StringLine = sr.ReadLine() 'Reads the next Enrolment record
            End While
            sr.Close() 'Closes the Enrolments StreamReader
            Count = Count + 1 'Increments Count by 1
        Loop Until Count > 1 'Loops until Count is greater than 1 (so it only loops twice)
    End Sub

End Class