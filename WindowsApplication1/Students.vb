Imports System.IO 'Reference library so read and write commands can be used
Public Class Students
    Structure Students 'Declaring structure Students
        'Declaring members (fields) of structure Students
        Public StudentID As Integer
        Public FirstName As String
        Public LastName As String
        Public DateOfBirth As String
        Public StudentType As String
        Public Username As String
        Public Password As String
    End Structure
    Public Student As New Students 'Declare Student as a new instance of Students
    'Declaring private variables
    Dim StudentRecords() As String 'StudentRecords as String Array to store the fields of a student record
    Dim Found As Boolean = False 'If a selected student record has been found
    Dim WarningLabel As String = "" 'Result of validation
    Dim StudentSelect As Boolean 'Whether a student listview item has been selected
    Dim MaxDate As Date = (Today().AddYears(-20)) 'Maximum date of birth for a student - they cannot be over 20 years old


    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "Students" 'Current form is Students

        'If the form is loaded from an Enrolments form to search for a student record 
        If GetID = True Then
            'Makes the save, delete and edit buttons invisible so as the user isn't meant to edit the records when they are simply searching for one
            btnSave.Visible = False
            btnDelete.Visible = False
            btnEdit.Visible = False
            btnBack.Visible = False
        End If

        CheckAll() 'Making sure each database exists
        UpdateListView(lstStudents, "Students.txt") 'Updates Students listview using Students file
    End Sub


    Public Sub ValidateStudent() 'Declare procedure ValidateStudent
        'InvalidCount is set to 0 for a fresh validation check
        InvalidCount = 0 'Assign 0 to InvalidCount
        'Assigning text box values to student fields
        Student.FirstName = txtFirstName.Text
        Student.LastName = txtLastName.Text
        Student.DateOfBirth = txtDOB.Text
        Student.Username = txtUsername.Text
        Student.Password = txtPassword.Text
        'Validation - the warning labels will change if an input is found to be invalid
        lbCourseWarning.Text = ValidateCourse() 'Validates the course choice
        lbFirstNameWarning.Text = ValidateName(Student.FirstName) 'Validates the first name
        lbLastNameWarning.Text = ValidateName(Student.LastName) 'Validates the last name
        lbDOBWarning.Text = ValidateDate(Student.DateOfBirth, MaxDate) 'Validates the date of birth
        lbUsernameWarning.Text = ValidateUser(Student.Username) 'Validates the username
        lbPasswordWarning.Text = ValidatePass(Student.Password) 'Validates the password
        lbConfirmPassWarning.Text = ValidatePassConfirm(Student.Password, txtPassConfirm.Text) 'Password verification
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        SaveCheck = True 'Record is being saved
        ValidateStudent() 'Validates the user input
        SaveCheck = False 'Assign False to SaveCheck as the validation is complete
        If InvalidCount > 0 Then 'If one or more of the inputs are detected as invalid...
            MsgBox("Please enter the details correctly.") 'Message box outputs to the user a prompt to enter the details correctly
        Else 'Otherwise, when all the user inputs would be valid
            Dim sr As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Opens Students StreamReader to read from Students.txt
            StringLine = sr.ReadLine() 'Read the first student record from the Students database
            Student.StudentID = 0 'StudentID is initially 0
            While (StringLine <> Nothing) 'Looping through the student records while EOF has not yet been reached
                StudentRecords = StringLine.Split(",") 'Split the student record into elements delimited by each "," and assign this to StudentRecords array
                Student.StudentID = StudentRecords(0) 'Assign the StudentID field of StudentRecords to the StudentID member of the structure
                StringLine = sr.ReadLine() 'Reads the next student record
            End While 'End while loop
            Student.StudentID = Student.StudentID + 1 'Increment Student.StudentID by 1, so it's one more than the ID of the last record
            sr.Close() 'Close Students StreamReader
            Dim sw As New System.IO.StreamWriter(Dir$("Students.txt"), True) 'Opens Students StreamWriter to write to Students.txt
            'Use sw to write a new line to the database concatenating Student Fields and delimiting them with ","
            sw.WriteLine(Student.StudentID & "," & Student.FirstName & "," & Student.LastName & "," & Student.DateOfBirth & "," & Student.StudentType & "," & Student.Username & "," & Student.Password)
            sw.Close() 'Close Students StreamWriter
            MsgBox("saved") 'Message box outputs to the user that the file has been saved
            UpdateListView(lstStudents, "Students.txt") 'Updates the students listview with the new data
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged 'Procedure for when the text value of txtFirstName text box is changed
        Student.FirstName = txtFirstName.Text 'Assign input to FirstName field of Students structure
        lbFirstNameWarning.Text = ValidateName(Student.FirstName) 'Validates this first name input
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged 'Procedure for when the text value of txtLastName text box is changed
        Student.LastName = txtLastName.Text 'Assign input to LastName field of Students structure
        lbLastNameWarning.Text = ValidateName(Student.LastName) 'Validates this last name input
    End Sub

    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged 'Procedure for when the text value of txtDOB text box is changed
        Student.DateOfBirth = txtDOB.Text 'Assign input to DateOfBirth field of Students structure
        lbDOBWarning.Text = ValidateDate(Student.DateOfBirth, MaxDate) 'Validates this date of birth input
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged 'Procedure for when text value of txtUsername text box is changed
        Student.Username = txtUsername.Text 'Assign input to Username field of Students structure
        lbUsernameWarning.Text = ValidateUser(Student.Username) 'Validates this username input
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged 'Procedure for when text value of txtPassword text box is changed
        Student.Password = txtPassword.Text 'Assign input to Password field of Students structure
        lbPasswordWarning.Text = ValidatePass(Student.Password) 'Validates this password input
    End Sub

    Private Sub txtPassConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtPassConfirm.TextChanged 'Procedure for when text value of txtPassConfirm text box is changed
        lbConfirmPassWarning.Text = ValidatePassConfirm(Student.Password, txtPassConfirm.Text) 'Verifies that this input is the same as the password input
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click 'Procedure for when Edit button is clicked
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        ValidateStudent() 'Validates the user input
        If InvalidCount > 0 Then 'If one or more of the inputs are detected as invalid...
            MsgBox("Please enter the details correctly.") 'Message box prompts user to enter details correctly
        Else 'Otherwise, when all the user inputs have been detected as valid
            Dim sr As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Opens Students StreamReader to read from Students.txt (Students database)
            Dim st As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Opens TempFile StreamWriter to write to TempFile.txt (Temporary database)
            StringLine = sr.ReadLine() 'Read the first student record of the students database
            While (StringLine <> Nothing) 'Looping through student records while EOF has not yet been reached
                StudentRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to StudentRecords array
                If (StudentRecords(0) = SelectedItem) Then 'If a match is found...
                    'Display record to the user
                    Student.StudentID = StudentRecords(0)
                    Student.FirstName = txtFirstName.Text
                    Student.LastName = txtLastName.Text
                    Student.DateOfBirth = txtDOB.Text
                    Student.Username = txtUsername.Text
                    Student.Password = txtPassword.Text
                    'Write a new record to TempFile.txt, delimiting the fields with ","
                    st.WriteLine(Student.StudentID & "," & Student.FirstName & "," & Student.LastName & "," & Student.DateOfBirth & "," & Student.StudentType & "," & Student.Username & "," & Student.Password)
                Else 'Otherwise, in which case the record is supposed to stay the same,
                    st.WriteLine(StringLine) 'Writes the original record to the temporary database
                End If
                StringLine = sr.ReadLine() 'Reads the next Student record
            End While
            sr.Close() 'Close Students StreamReader
            st.Close() 'Close TempFile SteamWriter
            File.Delete("Students.txt") 'Deletes Students.txt file (old students database)
            File.Move("TempFile.txt", "Students.txt") 'Rename TempFile.txt to Students.txt (which becomes the new, edited students database)
            MsgBox("record edited!") 'Message box outputs to the user that the record has been edited
            UpdateListView(lstStudents, "Students.txt") 'Updates the students listview with the new data
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Procedure for when Delete button is clicked
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        Dim sr As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Opens Students StreamReader to read from Students.txt (Students database)
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Opens TempFile StreamWriter to write to TempFile.txt (Temporary database)
        StringLine = sr.ReadLine() 'Read the first student record
        While (StringLine <> Nothing) 'Looping through student records while EOF has not yet been reached
            StudentRecords = StringLine.Split(",") 'Split StringLine into elements delimited by each "," and assign this to StudentRecords array
            'The selected record to be deleted won't be copied to TempFile while the other records will
            If (StudentRecords(0) <> SelectedItem) Then 'If the StudentID field is not equal to the ID of the selected item to be deleted 
                sw.WriteLine(StringLine) 'Writes that record to TempFile
            End If
            StringLine = sr.ReadLine() 'Reads the next student record
        End While
        sr.Close() 'Close Students StreamReader
        sw.Close() 'Close TempFile StreamWriter
        File.Delete("Students.txt") 'Delete Students.txt file (old students database)
        File.Move("TempFile.txt", "Students.txt") 'Rename TempFile.txt to Students.txt (which becomes the new students database)
        MsgBox("record deleted!") 'Message box outputs that the record has been deleted
        UpdateListView(lstStudents, "Students.txt") 'Updates the students listview with the new data
    End Sub

    'Procedures for when radiobuttons have been either checked or unchecked
    Private Sub rbGCSE_CheckedChanged(sender As Object, e As EventArgs) Handles rbGCSE.CheckedChanged 'Procedure for when rbGCSE.Checked is changed
        If rbGCSE.Checked = True Then 'If the rbGCSE radiobutton has been checked
            Student.StudentType = "GCSE" 'Assign "GCSE" to StudentType field
        End If
    End Sub

    Private Sub rbALevel_CheckedChanged(sender As Object, e As EventArgs) Handles rbALevel.CheckedChanged 'Procedure for when rbALevel.Checked is changed
        If rbALevel.Checked = True Then 'If rbALevel radiobutton has been checked
            Student.StudentType = "A Level" 'Assign "A Level" to StudentType field
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'Procedure for when Back button is clicked
        Back() 'Call Back procedure
        Me.Close() 'Close current form
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged 'Procedure for when selected index of lstStudents listview has changed
        StudentSelect = False 'StudentSelect is currently False as the selected item has not yet been found
        'Checking for a selected Students listview item
        If lstStudents.SelectedItems.Count > 0 Then 'If the number of selected items in Students listview is greater than 0...
            'A students listview item has been selected
            For Each StudentItem As ListViewItem In lstStudents.Items 'Loop through each Students listview item
                If StudentItem.Index = lstStudents.FocusedItem.Index Then 'If there is a match with the selected index and the current item's index
                    Found = True 'The selected item has been found
                    StudentSelect = True 'An item has been selected so StudentSelect is now True
                    If StudentItem.SubItems.Item(4).Text = "GCSE" Then 'If the StudentType field is equal to GCSE...
                        rbGCSE.Checked = True 'Check the GCSE radiobutton
                    Else 'Otherwise (for A Level students)...
                        rbALevel.Checked = True 'Check the A Level radiobutton
                    End If
                    'Assign fields of the selected item to the input boxes (so that the admin can view or delete them)
                    SelectedItem = StudentItem.SubItems.Item(0).Text
                    txtFirstName.Text = StudentItem.SubItems.Item(1).Text
                    txtLastName.Text = StudentItem.SubItems.Item(2).Text
                    txtDOB.Text = StudentItem.SubItems.Item(3).Text
                    txtUsername.Text = StudentItem.SubItems.Item(5).Text
                    txtPassword.Text = StudentItem.SubItems.Item(6).Text
                    txtPassConfirm.Text = StudentItem.SubItems.Item(6).Text
                    Exit For 'Exit for loop
                End If
            Next 'Repeat for next Students listview item
            'Getting a StudentID for an enrolment
            If GetID = True Then 'If the StudentID is being used for an enrolment or timetable
                If GetFrom = "Enrolments" Then 'If the StudentID is being used for an enrolment
                    ChangeItem(Enrolments.cboStudentID, SelectedItem) 'Change the Enrolment Student ID combo box's item to SelectedItem
                Else 'If the StudentID is being used for a timetable
                    ChangeItem(Timetables.cboStudentID, SelectedItem) 'Change the Timetable Student ID combo box's item to SelectedItem
                End If
                Me.Close() 'Close Students form
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged 'Procedure for when user inputs a name to search
        SearchName() 'Calls procedure to validate the inputted FirstName or LastName
    End Sub

    '---------------------SEARCHING-----------------------

    Public Function BinarySearch(Array() As Students, Value As String, Low As Integer, High As Integer) 'A Binary Search is used to search through the array of records
        Dim Mid As Integer 'The middle index of the array
        If Array(Mid).FirstName = Value Then 'If there is a match it returns the index
            Return Mid
        End If
        If (High < Low) Then 'If the upper value is greater than the lower value
            IndexFound = False 'There is no match so it returns -1
            Return -1
        End If
        Mid = (High + Low) / 2 'Calculates the middle index of the array
        If rbFirstName.Checked = True Then 'If the student checked the FirstName radiobutton (sorting by first name)
            If (WordCompare("Search", Array(Mid).FirstName, Value) = 1) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Low, Mid - 1) 'Returns a binary search within the lower half before the middle element
            ElseIf (WordCompare("Search", Array(Mid).FirstName, Value) = 0) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Mid + 1, High) 'Returns a binary search within the upper half after the middle element
            End If
        Else 'If the user checked the LastName radiobutton (sorting by last name)
            If (WordCompare("Search", Array(Mid).LastName, Value) = 1) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Low, Mid - 1) 'Returns a binary search within the lower half before the middle element
            ElseIf (WordCompare("Search", Array(Mid).LastName, Value) = 0) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Mid + 1, High) 'Returns a binary search within the upper half after the middle element
            End If
        End If
        Return Mid 'If a match has been found then it will return its index
    End Function



    Private Sub SearchName() 'Procedure for searching through first name or last name
        UpdateListView(lstStudents, "Students.txt") 'Updates the students listview
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        MaxIndex = CountRecords("Students.txt") - 1 'Sets the maximum index for StudentDetails as the number of Student records minus one
        Dim StudentDetails(0 To MaxIndex) As Students 'Declares an array of records (Students Structure) called StudentDetails
        Dim Index As Integer = 0 'Index used when assigning Matches to FoundIndex
        Dim FoundIndex As Integer 'Index of a matching element
        Dim Mid, FirstFound As Integer 'Mid is the index at the middle of the array, FirstFound is the index of the first match that was found
        Dim MatchIndex As Integer = -1 'The index used when matching indexes are being assigned to Matches array
        Dim Matches(MaxIndex) As Integer 'Array for storing matching indexes
        Dim RecordLine As String 'Stores details of the searched record to be written to TempFile
        Dim SpecialCase As Boolean 'Used when there is a match at Mid = 0 because this would not be detected in the MatchIndex array

        RecordArray(StudentDetails) 'Assigns student records to StudentDetails array
        'Searching for first name
        If rbFirstName.Checked = True Then 'If the user is searching for a first name
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "FN Asc") 'Applies a quick sort on the records in ascending order of first name
            Mid = BinarySearch(StudentDetails, txtSearch.Text, 0, MaxIndex) 'Applies a binary search on the now sorted array of records
            If Mid = -1 Then 'If a match wasn't found 
                Exit Sub 'It exits the procedure
            End If
            FirstFound = Mid 'The first found match is kept aside
            If Mid = 0 Then 'If a match is found when Mid = 0 then the special case is activated
                SpecialCase = True
            End If
            MatchIndex = MatchIndex + 1 'Increment MatchIndex by 1 so that it points to a real element
            Matches(MatchIndex) = Mid 'Assigns Mid to this Match element, so the new match is added to the Matches array
            'Checks for duplicate values equal to the search value
            If Mid >= 1 Then 'This is done to keep the indexes within range
                While (StudentDetails(Mid).FirstName = StudentDetails(Mid - 1).FirstName) 'While there is another match to the left of the found value
                    MatchIndex = MatchIndex + 1 'MatchIndex is incremented by 1 to add the new match to the Matches array
                    Mid = Mid - 1 'Mid is decremented by 1 to store the previous consecutive element (match) in the Matches array
                    Matches(MatchIndex) = Mid 'This new match is added to the Matches array
                    If Mid = 0 Then SpecialCase = True 'If a match is found when Mid = 0 then the special case is activated
                    If Mid < 1 Then 'If Mid is less than 1 then the indexes 0 and -1 can't be compared as -1 is out of the range
                        Exit While 'Exits the while loop
                    End If
                End While
            End If
            Mid = FirstFound 'Assigns Mid to the first found match - now to check if there are any other matches to the right of this match
            If Mid <= (MaxIndex - 1) Then 'Makes sure that Mid is within the suitable range for comparisons to be made
                While (StudentDetails(Mid).FirstName = StudentDetails(Mid + 1).FirstName) 'While there is another match to the right of the found value
                    MatchIndex = MatchIndex + 1 'MatchIndex is incremented by 1 to add the new match to the Matches array
                    Mid = Mid + 1 'Mid is incremented by 1 to store the next consecutive element/match in the Matches array
                    Matches(MatchIndex) = Mid 'This new match is added to the Matches array
                    If Mid > (MaxIndex - 1) Then 'If Mid is outside of the range for comparisons 
                        Exit While 'Exits the while loop
                    End If
                End While
            End If
            'Searching for last name
        ElseIf rbLastName.Checked = True Then 'If the user is searching for a last name
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "LN Asc") 'Applies a quick sort on the records in ascending order of last name
            Mid = BinarySearch(StudentDetails, txtSearch.Text, 0, MaxIndex) 'Applies a binary search on the now sorted array of records
            If Mid = -1 Then 'If a match wasn't found 
                Exit Sub 'It exits the procedure
            End If
            FirstFound = Mid 'The first found match is kept aside
            If Mid = 0 Then 'If a match is found when Mid = 0 then the special case is activated
                SpecialCase = True
            End If
            MatchIndex = MatchIndex + 1 'Incrememnt MatchIndex by 1 so that it points to a real element
            Matches(MatchIndex) = Mid 'Assigns Mid to this Match element, so the new match is added to the Matches array
            'Checks for duplicate values equal to the search value
            If Mid >= 1 Then 'This is done to keep the indexes within range
                While (StudentDetails(Mid).LastName = StudentDetails(Mid - 1).LastName) 'While there is another match to the left of the found value
                    MatchIndex = MatchIndex + 1 'MatchIndex is incremented by 1 to add the new match to the Matches array
                    Mid = Mid - 1 'Mid is decremented by 1 to store the previous consecutive element (match) in the Matches array
                    Matches(MatchIndex) = Mid 'This new match is added to the Matches array
                    If Mid = 0 Then SpecialCase = True 'If a match is found when Mid = 0 then the special case is activated
                    If Mid < 1 Then 'If Mid is less than 1 then the indexes 0 and -1 can't be compared as -1 is out of the range
                        Exit While 'Exits the while loop
                    End If
                End While
            End If
            Mid = FirstFound 'Assigns Mid to the first found match - now to check if there are any other matches to the right of this match
            If Mid <= (MaxIndex - 1) Then 'Makes sure that Mid is within the suitable range for comparisons to be made
                While (StudentDetails(Mid).LastName = StudentDetails(Mid + 1).LastName) 'While there is another match to the right of the found value 
                    MatchIndex = MatchIndex + 1 'MatchIndex is incremented by 1 to add the new match to the Matches array
                    Mid = Mid + 1 'Mid is incremented by 1 to store the next consecutive element (match) in the Matches array
                    Matches(MatchIndex) = Mid 'This new match is added to the Matches array
                    If Mid > (MaxIndex - 1) Then 'If Mid is outside of the range for comparisons
                        Exit While 'Exits the while loop
                    End If
                End While
            End If
        Else 'If neither of the radiobuttons are checked
            Exit Sub 'Exits the procedure
        End If
        'Creating a new TempFile to write the found records to
        File.Delete("TempFile.txt") 'Delete old TempFile
        Dim st As New StreamWriter(Application.StartupPath & "\TempFile.txt", True) 'Creates a new blank TempFile database called TempFile.txt to write data

        Index = 0 'Assigns 0 to Index so that it points to the start of the Matches array
        'The elements in Matches represent the index at which each match is located
        While ((Matches(Index) <> Nothing) Or (SpecialCase = True)) 'Writes records to TempFile while the end of the Matches array has not been reached
            FoundIndex = Matches(Index)
            RecordLine = StudentDetails(FoundIndex).StudentID & "," & StudentDetails(FoundIndex).FirstName & "," & StudentDetails(FoundIndex).LastName & "," & StudentDetails(FoundIndex).DateOfBirth & "," &
                StudentDetails(FoundIndex).StudentType & "," & StudentDetails(FoundIndex).Username & "," & StudentDetails(FoundIndex).Password
            st.WriteLine(RecordLine)
            Index = Index + 1
            SpecialCase = False 'Deactivates SpecialCase so Matches(Index) can now be 0
        End While
        st.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstStudents, "TempFile.txt") 'Updates the students listview such that the items displayed are the searched results

    End Sub



    '----------------------SORTING------------------------

    Private Function Partition(Array() As Students, Low As Integer, High As Integer, ComparisonType As String) 'Function for partitioning the array
        Dim Pivot As Students = Array(High) 'The pivot is set as the rightmost element of the part of the array being partitioned
        Dim IndexSmall As Integer = Low - 1 'The index of an element less than the pivot
        Dim Index As Integer = Low 'Index of the array, initialised as the leftmost element within the partition
        Dim TempElement As Students 'The temporary element used for a swap
        For Index = Low To (High - 1) 'Loops through elements of array
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

    Private Function QuickSort(Array() As Students, Low As Integer, High As Integer, ComparisonType As String) 'Function for quicksort
        Dim PartIndex As Integer 'The pivot after partitioning
        If (Low < High) Then 'If the lowest index is less than the highest index
            PartIndex = Partition(Array, Low, High, ComparisonType) 'Calls partition function and assigns its returned value to a partition index
            QuickSort(Array, Low, (PartIndex - 1), ComparisonType) 'Calls quick sort for the lower list (elements less than the pivot)
            QuickSort(Array, (PartIndex + 1), High, ComparisonType) 'Calls quick sort for the upper list (elements greater than the pivot)
        End If
        Return Array 'Returns the sorted array
    End Function




    Private Function Comparison(Array() As Students, Pivot As Students, Index As Integer, ComparisonType As String) 'Function for determining the order in which the array should be quicksorted 
        'So it determines how the element and pivot should be compared
        Select Case ComparisonType
            Case "ID Asc" 'Sorting by StudentID in ascending order
                If CInt(Array(Index).StudentID) > CInt(Pivot.StudentID) Then 'If the element's StudentID is greater than the pivot's StudentID
                    Return 1
                Else
                    Return 0
                End If
            Case "ID Des" 'Sorting by StudentID in descending order
                If CInt(Array(Index).StudentID) < CInt(Pivot.StudentID) Then 'If the element's StudentID is less than the pivot's StudentID
                    Return 1
                Else
                    Return 0
                End If
            'For names - compares the ASCII values of the first letters of each name (from element and pivot)
            Case "FN Asc" 'Sorting by FirstName in ascending order
                If WordCompare("A-Z", Array(Index).FirstName, Pivot.FirstName) = 1 Then 'If the element's first name is greater than the pivot's first name
                    Return 1
                Else
                    Return 0
                End If
            Case "FN Des" 'Sorting by FirstName in descending order
                If WordCompare("Z-A", Array(Index).FirstName, Pivot.FirstName) = 1 Then 'If the element's first name is less than the pivot's first name
                    Return 1
                Else
                    Return 0
                End If
            Case "LN Asc" 'Sorting by LastName in ascending order
                If WordCompare("A-Z", Array(Index).LastName, Pivot.LastName) = 1 Then 'If the element's last name is less than the pivot's last name
                    Return 1
                Else
                    Return 0
                End If
            Case "LN Des" 'Sorting by LastName in descending order
                If WordCompare("Z-A", Array(Index).LastName, Pivot.LastName) = 1 Then 'If the element's last name is less than the pivot's last name
                    Return 1
                Else
                    Return 0
                End If
            'Sorting by Date Of Birth
            Case "DOB Asc" 'Sorting by DateOfBirth in ascending order
                If CDate(Array(Index).DateOfBirth) > CDate(Pivot.DateOfBirth) Then 'If the element's date of birth is greater than the pivot's date of birth
                    Return 1
                Else
                    Return 0
                End If
            Case "DOB Des" 'Sorting by DateOfBirth in descending order
                If CDate(Array(Index).DateOfBirth) < CDate(Pivot.DateOfBirth) Then 'If the element's date of birth is less than the pivot's date of birth
                    Return 1
                Else
                    Return 0
                End If

        End Select
        Return -1
    End Function



    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged 'Procedure for when the user selects a Sort
        MaxIndex = CountRecords("Students.txt") - 1 'Number of records in Students file - 1
        Dim StudentDetails(0 To MaxIndex) As Students 'Declares Students array of records (structure Students)
        Dim RecordLine As String 'The record that is to be written to the sorted TempFile
        'Unchecks radiobuttons
        rbFirstName.Checked = False
        rbLastName.Checked = False
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        RecordArray(StudentDetails) 'Assigns student records to StudentDetails array
        'Depending on the selected sort method it calls the QuickSort function with a different CompareType parameter
        If cboSort.SelectedIndex = 0 Then 'If the sort is "StudentID (Ascending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "ID Asc")
        ElseIf cboSort.SelectedIndex = 1 Then 'If the sort is "StudentID (Descending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "ID Des")
        ElseIf cboSort.SelectedIndex = 2 Then 'If the sort is "FirstName (Ascending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "FN Asc")
        ElseIf cboSort.SelectedIndex = 3 Then 'If the sort is "FirstName (Descending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "FN Des")
        ElseIf cboSort.SelectedIndex = 4 Then 'If the sort is "LastName (Ascending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "LN Asc")
        ElseIf cboSort.SelectedIndex = 5 Then 'If the sort is LastName (Descending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "LN Des")
        ElseIf cboSort.SelectedIndex = 6 Then 'If the sort is DateOfBirth (Ascending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "DOB Asc")
        ElseIf cboSort.SelectedIndex = 7 Then 'If the sort is DateOfBirth (Descending)"
            StudentDetails = QuickSort(StudentDetails, 0, MaxIndex, "DOB Des")
        Else
            Exit Sub 'If no sort has been selected then it exits the procedure
        End If
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Declare sw as new StreamWriter to write to TempFile.txt
        For Index = 0 To MaxIndex 'Writes records to TempFile
            RecordLine = CStr(StudentDetails(Index).StudentID & "," & StudentDetails(Index).FirstName & "," & StudentDetails(Index).LastName & "," & StudentDetails(Index).DateOfBirth & "," &
                StudentDetails(Index).StudentType & "," & StudentDetails(Index).Username & "," & StudentDetails(Index).Password)
            sw.WriteLine(RecordLine)
        Next
        sw.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstStudents, "TempFile.txt") 'Updates the students listview such that the items are in the new sorted order
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Procedure for when Help button is clicked
        'Briefly explains what the Save, Edit and Delete buttons do
        MsgBox("Save - saves a student record" & vbNewLine & "Edit - edits the student record selected from the listview, and saves the edited database" & vbNewLine &
               "Delete - deletes a student record that has been selected (clicked) from the listview")
    End Sub

    Private Sub RecordArray(ByRef StudentDetails() As Students) 'Procedure for assigning values (records read from file) to an array of records
        Dim Index As Integer = 0 'Index of StudentDetails array
        Dim sr As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Opens Students database StreamReader
        StringLine = sr.ReadLine() 'Read the first line (record) of the students file, assign it to StringLine
        While (StringLine <> Nothing) 'While EOF has not been reached
            'Assigning record fields to StudentDetails array
            StudentRecords = StringLine.Split(",") 'Assigns comma delimited fields to StudentRecords array
            StudentDetails(Index).StudentID = StudentRecords(0)
            StudentDetails(Index).FirstName = StudentRecords(1)
            StudentDetails(Index).LastName = StudentRecords(2)
            StudentDetails(Index).DateOfBirth = StudentRecords(3)
            StudentDetails(Index).StudentType = StudentRecords(4)
            StudentDetails(Index).Username = StudentRecords(5)
            StudentDetails(Index).Password = StudentRecords(6)
            Index = Index + 1 'Increment Index by 1
            StringLine = sr.ReadLine() 'Read next record of student file
        End While
        sr.Close() 'Closes Students StreamReader
    End Sub

    '------------------VALIDATION---------------------
    Function ValidateCourse() 'Function for validating the course choice
        'Declaring variables
        Dim CourseCheck As Boolean 'Whether one of the courses have been chosen or not
        Dim CourseWarning As String = "" 'Error message
        'If either of the radiobuttons are checked CourseCheck would be True, if neither have been selected then CourseCheck would be False
        CourseCheck = ((rbALevel.Checked) Or (rbGCSE.Checked))
        'Checking if either of the radiobuttons have been checked
        If CourseCheck = False Then 'If neither of the radiobuttons are checked then the course choice is invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            CourseWarning = "Please select a course." 'Prompts the user to select a course
        End If
        Return CourseWarning 'Returns the error message
    End Function


End Class