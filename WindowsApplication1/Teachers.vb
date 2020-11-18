Imports System.IO 'Reference library so read and write commands can be used
Public Class Teachers
    Structure Teachers 'Declaring structure Teachers
        'Declaring members (fields) of structure Teachers
        Public TeacherID As Integer
        Public FirstName As String
        Public LastName As String
        Public DateOfBirth As String
        Public Username As String
        Public Password As String
    End Structure
    'Declaring variables
    Public Teacher As New Teachers 'Declare Teacher as a new instance of Teachers
    Public TeacherRecords() As String 'Array that stores fields in a teacher record
    Dim Found As Boolean = False 'If a selected teacher record has been found
    Dim WarningLabel As String = "" 'Result of validation checks
    Dim TeacherSelect As Boolean 'Determines if a teacher listview item has been selected or not
    Dim MaxDate As Date = (Today().AddYears(-90)) 'Realistically a teacher won't be older than 90 years

    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "Teachers" 'Current form is Teachers

        'If the form is loaded from a Lessons form to search for a teacher record 
        If GetID = True Then
            'Makes the save, delete and edit buttons invisible so as the user isn't meant to edit the records when they are simply searching for one
            btnSave.Visible = False
            btnDelete.Visible = False
            btnEdit.Visible = False
            btnBack.Visible = False
        End If

        CheckAll() 'Making sure each database exists
        UpdateListView(lstTeachers, "Teachers.txt")
    End Sub

    Public Sub ValidateTeacher() 'Declare procedure ValidateTeacher
        'InvalidCount is set to 0 for a fresh validation check
        InvalidCount = 0 'Assign 0 to InvalidCount
        'Assigning text box values to variables
        Teacher.FirstName = txtFirstName.Text
        Teacher.LastName = txtLastName.Text
        Teacher.DateOfBirth = txtDOB.Text
        Teacher.Username = txtUsername.Text
        Teacher.Password = txtPassword.Text
        'Validation - the warning labels will change if an input is found to be invalid
        lbFirstNameWarning.Text = ValidateName(Teacher.FirstName) 'Validates the first name
        lbLastNameWarning.Text = ValidateName(Teacher.LastName) 'Validates the last name
        lbDOBWarning.Text = ValidateDate(Teacher.DateOfBirth, MaxDate) 'Validates the date of birth
        lbUsernameWarning.Text = ValidateUser(Teacher.Username) 'Validates the username
        lbPasswordWarning.Text = ValidatePass(Teacher.Password) 'Validates the password
        lbConfirmPassWarning.Text = ValidatePassConfirm(Teacher.Password, txtPassConfirm.Text) 'Password verification
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        SaveCheck = True 'Record is being saved
        ValidateTeacher() 'Validates the user input
        SaveCheck = False 'Assign False to SaveCheck as the validation is complete
        If InvalidCount > 0 Then 'If one or more of the inputs are detected as invalid...
            MsgBox("Please enter the details correctly.") 'Message box outputs to the user a prompt to enter the details correctly
        Else 'Otherwise, where all the user inputs would be valid
            Dim sr As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers StreamReader to read from Teachers.txt database
            StringLine = sr.ReadLine() 'Read the first teacher record from the Teachers database
            Teacher.TeacherID = 0 'TeacherID is initially 0
            While (StringLine <> Nothing) 'Looping through the teacher records while EOF has not yet been reached.
                TeacherRecords = StringLine.Split(",") 'Split the teacher into elements delimited by each "," and assign this to TeacherRecords array
                Teacher.TeacherID = TeacherRecords(0) 'Assign the TeacherID field of TeacherRecords to Teacher.TeacherID
                StringLine = sr.ReadLine() 'Reads the next teacher record
            End While 'End while loop
            Teacher.TeacherID = Teacher.TeacherID + 1 'Increment Teacher.TeacherID by 1, so it's one more than the ID of the last record
            sr.Close() 'Close Teachers StreamReader
            Dim sw As New System.IO.StreamWriter(Dir$("Teachers.txt"), True) 'Opens Teachers StreamWriter to write to Teachers.txt database
            'Use sw to write a new line to the database concatenating Teacher Fields and delimiting them with ","
            sw.WriteLine(Teacher.TeacherID & "," & Teacher.FirstName & "," & Teacher.LastName & "," & Teacher.DateOfBirth & "," & Teacher.Username & "," & Teacher.Password)
            sw.Close() 'Close Teachers StreamWriter
            MsgBox("saved") 'Message box outputs to the user that the file has been saved
            UpdateListView(lstTeachers, "Teachers.txt") 'Updates the teachers listview with the new data
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged 'Procedure for when the text value of txtFirstName text box is changed
        Teacher.FirstName = txtFirstName.Text 'Assign input to FirstName field of Teachers structure
        lbFirstNameWarning.Text = ValidateName(Teacher.FirstName) 'Validates this first name input
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged 'Procedure for when the text value of txtLastName text box is changed
        Teacher.LastName = txtLastName.Text 'Assign input to FirstName field of Teachers structure
        lbLastNameWarning.Text = ValidateName(Teacher.LastName) 'Validates this last name input
    End Sub

    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged 'Procedure for when the text value of txtDOB text box is changed
        Teacher.DateOfBirth = txtDOB.Text 'Assign input to DateOfBirth field of Teachers structure
        lbDOBWarning.Text = ValidateDate(Teacher.DateOfBirth, MaxDate) 'Validates this date of birth input
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged 'Procedure for when text value of txtUsername text box is changed
        Teacher.Username = txtUsername.Text 'Assign input to Username field of Teachers structure
        lbUsernameWarning.Text = ValidateUser(Teacher.Username) 'Validates this username input
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged 'Procedure for when text value of txtPassword text box is changed
        Teacher.Password = txtPassword.Text 'Assign input to Password field of Teachers structure
        lbPasswordWarning.Text = ValidatePass(Teacher.Password) 'Validates this password input
    End Sub

    Private Sub txtPassConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtPassConfirm.TextChanged 'Procedure for when text value of txtPassConfirm text box is changed
        lbConfirmPassWarning.Text = ValidatePassConfirm(Teacher.Password, txtPassConfirm.Text) 'Verifies that this input is the same as the password input
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click 'Procedure for when Edit button is clicked
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        'Validation
        ValidateTeacher() 'Validates the user input
        If InvalidCount > 0 Then 'If one or more of the inputs are detected as invalid...
            MsgBox("Please enter the details correctly.") 'Message box prompts user to enter details correctly
        Else 'Otherwise, when all of the user inputs have been detected as valid
            Dim sr As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers StreamReader to read from Teachers.txt (Teachers database)
            Dim st As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Opens TempFile StreamWriter to write to TempFile.txt (Temporay database)
            StringLine = sr.ReadLine() 'Read the first teacher record of the teachers database
            While (StringLine <> Nothing)
                TeacherRecords = StringLine.Split(",") 'Split comma delimited fields into TeacherRecords array
                If (TeacherRecords(0) = SelectedItem) Then 'If a match is found...
                    'Display the teacher record to the user
                    Teacher.TeacherID = TeacherRecords(0)
                    Teacher.FirstName = txtFirstName.Text
                    Teacher.LastName = txtLastName.Text
                    Teacher.DateOfBirth = txtDOB.Text
                    Teacher.Username = txtUsername.Text
                    Teacher.Password = txtPassword.Text
                    'Write a new teacher record to TempFile.txt, delimiting the fields with ","
                    st.WriteLine(Teacher.TeacherID & "," & Teacher.FirstName & "," & Teacher.LastName & "," & Teacher.DateOfBirth & "," & Teacher.Username & "," & Teacher.Password)
                Else
                    'Use st to write old record to a new line on the file
                    st.WriteLine(StringLine)
                End If
                StringLine = sr.ReadLine() 'Assign the next line of the file, using sr, to StringLine
            End While
            sr.Close() 'Close Teachers StreamReader
            st.Close() 'Close TempFile StreamWriter
            File.Delete("Teachers.txt") 'Delete Teachers.txt file (old teachers database)
            File.Move("TempFile.txt", "Teachers.txt") 'Rename TempFile.txt to Teachers.txt (which becomes the new, edited teachers database)
            MsgBox("record edited!") 'Message box outputs to the user that the record has been edited
            UpdateListView(lstTeachers, "Teachers.txt") 'Updates the teachers listview with the new data
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Procedure for when Delete button is clicked
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        Dim sr As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers StreamReader to read from Teachers.txt (Teachers database)
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Opens TempFile StreamWriter to write to TempFile.txt (Temporary database)
        StringLine = sr.ReadLine() 'Read the first teacher record
        While (StringLine <> Nothing) 'Looping through teacher records while EOF has not yet been reached
            TeacherRecords = StringLine.Split(",") 'Split comma delimited fields into TeacherRecords array
            'The selected record to be deleted won't be copied to TempFile while the other records will
            If (TeacherRecords(0) <> SelectedItem) Then 'If the TeacherID field is not equal to the ID of the selected item to be detected
                sw.WriteLine(StringLine) 'Writes that record to TempFile
            End If
            StringLine = sr.ReadLine() 'Reads the next teacher record
        End While
        sr.Close() 'Close Teachers StreamReader
        sw.Close() 'Close TempFIle StreamWriter
        File.Delete("Teachers.txt") 'Delete Teachers.txt file (old teachers database)
        File.Move("TempFile.txt", "Teachers.txt") 'Rename TempFile.txt to Teachers.txt (which becomes the new teachers database)
        MsgBox("record deleted!") 'Message box outputs that the record has been deleted
        UpdateListView(lstTeachers, "Teachers.txt") 'Updates the teachers listview with the new data
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'Procedure for when Back button is clicked
        Back() 'Call Back procedure
        Me.Close() 'Close current form
    End Sub

    Private Sub lstTeachers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeachers.SelectedIndexChanged 'Procedure for when selected index of lstTeachers listview has changed
        TeacherSelect = False 'TeacherSelect is currently False as the selected item has not yet been found
        'Checking for a selected Teachers listview item
        If lstTeachers.SelectedItems.Count > 0 Then 'If the number of selected items in Teachers listview is greater than 0...
            'A teachers listview item has been selected
            For Each TeacherItem As ListViewItem In lstTeachers.Items 'Loop through each Teachers listview item
                If TeacherItem.Index = lstTeachers.FocusedItem.Index Then 'If there is a match with the selected index and the current item's index
                    Found = True 'The selected item has been found
                    TeacherSelect = True 'An item has been selected so TeacherSelect is now True
                    'Assign fields of the selected item to the input boxes (so that the admin can view or delete them)
                    SelectedItem = TeacherItem.SubItems.Item(0).Text
                    txtFirstName.Text = TeacherItem.SubItems.Item(1).Text
                    txtLastName.Text = TeacherItem.SubItems.Item(2).Text
                    txtDOB.Text = TeacherItem.SubItems.Item(3).Text
                    txtUsername.Text = TeacherItem.SubItems.Item(4).Text
                    txtPassword.Text = TeacherItem.SubItems.Item(5).Text
                    txtPassConfirm.Text = TeacherItem.SubItems.Item(5).Text
                    Exit For 'Exit for loop
                End If
            Next 'Repeat for next Teachers listview item
            'Getting a TeacherID for a lesson
            If GetID = True Then 'If the TeacherID is being used for a lesson or timetable
                If GetFrom = "Lessons" Then 'If the TeacherID is being used for a lesson
                    ChangeItem(Lessons.cboTeacherID, SelectedItem) 'Change the Lesson TeacherID combo box's item to SelectedItem
                Else 'If the TeacherID is being used for a timetable
                    ChangeItem(Timetables.cboTeacherID, SelectedItem) 'Change the Timetable TeacherID combo box's item to SelectedItem
                End If
                Me.Close() 'Close Teachers form
            End If
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged 'Procedure for when user inputs a name to search
        SearchName() 'Calls procedure to validate the inputted FirstName or LastName
    End Sub


    '---------------------SEARCHING-----------------------

    Public Function BinarySearch(Array() As Teachers, Value As String, Low As Integer, High As Integer) 'A Binary Search is used to search through the array of records
        Dim Mid As Integer 'The middle index of the array
        If Array(Mid).FirstName = Value Then 'If there is a match it returns the index
            Return Mid
        End If
        If (High < Low) Then 'If the upper value is greater than the lower value
            IndexFound = False 'There is no match
            Return -1
        End If
        Mid = (High + Low) / 2 'Calculates the middle element of the array
        If rbFirstName.Checked = True Then
            If (WordCompare("Search", Array(Mid).FirstName, Value) = 1) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Low, Mid - 1) 'Returns a binary search within the lower half before the middle element
            ElseIf (WordCompare("Search", Array(Mid).FirstName, Value) = 0) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Mid + 1, High) 'Returns a binary search within the upper half after the middle element
            End If
        Else
            If (WordCompare("Search", Array(Mid).LastName, Value) = 1) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Low, Mid - 1) 'Returns a binary search within the lower half before the middle element
            ElseIf (WordCompare("Search", Array(Mid).LastName, Value) = 0) Then 'If this element is greater than the value being searched for
                Return BinarySearch(Array, Value, Mid + 1, High) 'Returns a binary search within the upper half after the middle element
            End If
        End If

        Return Mid 'If a match has been found then it will return its index
    End Function



    Private Sub SearchName() 'Procedure for searching through first name or last name
        UpdateListView(lstTeachers, "Teachers.txt") 'Update the teachers listview
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        MaxIndex = CountRecords("Teachers.txt") - 1 'Assign MaxIndex to the numer of Teacher records minus one
        Dim TeacherDetails(0 To MaxIndex) As Teachers 'Declare an array of records (Teachers Structure) called TeacherDetails
        Dim Index As Integer = 0 'Index used when assigning Matches to FoundIndex
        Dim FoundIndex As Integer 'Index of a matching element
        Dim Mid, FirstFound As Integer 'Mid is the index at the middle of the array, FirstFound is the index of the first match that was found
        Dim MatchIndex As Integer = -1 'The index used when matching indexes are being assigned to Matches array
        Dim Matches(MaxIndex) As Integer 'Array for storing matching indexes
        Dim RecordLine As String 'Stores details of the searched record to be written to TempFile
        Dim SpecialCase As Boolean 'When there is a match at Mid = 0 because this would not be detected in the MatchIndex array

        RecordArray(TeacherDetails) 'Assigns teacher records to TeacherDetails array
        'Searching for First Name
        If rbFirstName.Checked = True Then 'If the user is searching for a first name
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "FN Asc") 'Applies a quick sort on the records in ascending order of first name
            Mid = BinarySearch(TeacherDetails, txtSearch.Text, 0, MaxIndex) 'Applies a binary search on the now sorted array of records
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
                While (TeacherDetails(Mid).FirstName = TeacherDetails(Mid - 1).FirstName) 'While there is another match to the left of the found value
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
                While (TeacherDetails(Mid).FirstName = TeacherDetails(Mid + 1).FirstName) 'While there is another match to the right of the found value
                    MatchIndex = MatchIndex + 1 'MatchIndex is incremented by 1 to add the new match to the Matches array
                    Mid = Mid + 1 'Mid is incremented by 1 to store the next consecutive element/match in the Matches array
                    Matches(MatchIndex) = Mid 'This new match is added to the Matches array
                    If Mid > (MaxIndex - 1) Then 'If Mid is outside of the range for comparisons 
                        Exit While 'Exits the while loop
                    End If
                End While
            End If
            'Searching for Last Name
        ElseIf rbLastName.Checked = True Then 'If the user is searching for a last name
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "LN Asc") 'Applies a quick sort on the records in ascending order of last name
            Mid = BinarySearch(TeacherDetails, txtSearch.Text, 0, MaxIndex) 'Applies a binary search on the now sorted array of records
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
                While (TeacherDetails(Mid).LastName = TeacherDetails(Mid - 1).LastName) 'While there is another match to the left of the found value
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
                While (TeacherDetails(Mid).LastName = TeacherDetails(Mid + 1).LastName) 'While there is another match to the right of the found value 
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
            RecordLine = TeacherDetails(FoundIndex).TeacherID & "," & TeacherDetails(FoundIndex).FirstName & "," & TeacherDetails(FoundIndex).LastName & "," & TeacherDetails(FoundIndex).DateOfBirth _
                & "," & TeacherDetails(FoundIndex).Username & "," & TeacherDetails(FoundIndex).Password
            st.WriteLine(RecordLine)
            Index = Index + 1
            SpecialCase = False 'Deactivates SpecialCase so Matches(Index) can now be 0
        End While
        st.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstTeachers, "TempFile.txt") 'Updates the teachers listview such that the items displayed are the searched results

    End Sub



    '----------------------SORTING------------------------

    Private Function Partition(Array() As Teachers, Low As Integer, High As Integer, ComparisonType As String) 'Function for partitioning the array
        Dim Pivot As Teachers = Array(High) 'The pivot is set as the rightmost element of the part of the array being partitioned
        Dim IndexSmall As Integer = Low - 1 'The index of an element less than the pivot
        Dim Index As Integer = Low 'Index of the array, intiialised as the leftmost element within the partition
        Dim TempElement As Teachers 'The temporary element used for a swap
        'IndexSmall is the index of an element less than the pivot 
        For Index = Low To (High - 1) 'Loops through the elements of array
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

    Private Function QuickSort(Array() As Teachers, Low As Integer, High As Integer, ComparisonType As String) 'Function for quicksort
        Dim PartIndex As Integer 'The pivot after partitioning
        If (Low < High) Then 'If the lowest index is less than the highest index
            PartIndex = Partition(Array, Low, High, ComparisonType) 'Calls partition function and assigns its returned value to a partition index
            QuickSort(Array, Low, (PartIndex - 1), ComparisonType) 'Calls quick sort for the lower list (elements less than the pivot)
            QuickSort(Array, (PartIndex + 1), High, ComparisonType) 'Calls quick sort for the upper list (elements greater than the pivot)
        End If
        Return Array 'Returns the sorted array
    End Function




    Private Function Comparison(Array() As Teachers, Pivot As Teachers, Index As Integer, ComparisonType As String) 'Function for determining the order in which the array should be quicksorted 
        'So it determines how the element and pivot should be compared
        Select Case ComparisonType
            Case "ID Asc" 'Sorting by TeacherID in ascending order
                If CInt(Array(Index).TeacherID) > CInt(Pivot.TeacherID) Then 'If the element's TeacherID is greater than the pivot's TeacherID
                    Return 1
                Else
                    Return 0
                End If
            Case "ID Des" 'Sorting by TeacherID in descending order
                If CInt(Array(Index).TeacherID) < CInt(Pivot.TeacherID) Then 'If the element's TeacherID is less than the pivot's TeacherID
                    Return 1
                Else
                    Return 0
                End If
            'For names - compares the ASCII values of the first letters of each name (from element and pivot)
            Case "FN Asc" 'Sorting by FirstName in ascending order
                If WordCompare("A-Z", Array(Index).FirstName, Pivot.FirstName) = 1 Then 'If the element's FirstName is greater than the pivot's FirstName
                    Return 1
                Else
                    Return 0
                End If
            Case "FN Des" 'Sorting by FirstName in descending order
                If WordCompare("Z-A", Array(Index).FirstName, Pivot.FirstName) = 1 Then 'If the element's FirstName is less than the pivot's FirstName
                    Return 1
                Else
                    Return 0
                End If
            Case "LN Asc" 'Sorting by LastName in ascending order
                If WordCompare("A-Z", Array(Index).LastName, Pivot.LastName) = 1 Then 'If the element's LastName is greater than the pivot's LastName
                    Return 1
                Else
                    Return 0
                End If
            Case "LN Des" 'Sorting by LastName in descending order
                If WordCompare("Z-A", Array(Index).LastName, Pivot.LastName) = 1 Then 'If the element's LastName is less than the pivot's LastName
                    Return 1
                Else
                    Return 0
                End If
            'Sorting by Date Of Birth
            Case "DOB Asc" 'Sorting by DateOfBirth in ascending order
                If CDate(Array(Index).DateOfBirth) > CDate(Pivot.DateOfBirth) Then 'If the element's DateOfBirth is greater than the pivot's DateOfBirth
                    Return 1
                Else
                    Return 0
                End If
            Case "DOB Des" 'Sorting by DateOfBirth in descending order
                If CDate(Array(Index).DateOfBirth) < CDate(Pivot.DateOfBirth) Then 'If the element's DateOfBirth is less than the pivot's DateOfBirth
                    Return 1
                Else
                    Return 0
                End If

        End Select
        Return -1
    End Function



    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged 'Procedure for when the user selects a Sort
        MaxIndex = CountRecords("Teachers.txt") - 1 'Number of records in Teachers file - 1
        Dim TeacherDetails(0 To MaxIndex) As Teachers 'Declares an array of records (Teachers Structure) called TeacherDetails
        Dim RecordLine As String 'The record that is to be written to the sorted TempFile
        'Unchecks radiobuttons
        rbFirstName.Checked = False
        rbLastName.Checked = False
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        RecordArray(TeacherDetails) 'Assigns teacher records to TeacherDetails array
        'Depending on the selected sort method it calls the QuickSort function with a different CompareType parameter
        If cboSort.SelectedIndex = 0 Then 'If the sort is "TeacherID (Ascending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "ID Asc")
        ElseIf cboSort.SelectedIndex = 1 Then 'If the sort is "TeacherID (Descending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "ID Des")
        ElseIf cboSort.SelectedIndex = 2 Then 'If the sort is "FirstName (Ascending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "FN Asc")
        ElseIf cboSort.SelectedIndex = 3 Then 'If the sort is "FirstName (Descending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "FN Des")
        ElseIf cboSort.SelectedIndex = 4 Then 'If the sort is "LastName (Ascending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "LN Asc")
        ElseIf cboSort.SelectedIndex = 5 Then 'If the sort is LastName (Descending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "LN Des")
        ElseIf cboSort.SelectedIndex = 6 Then 'If the sort is DateOfBirth (Ascending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "DOB Asc")
        ElseIf cboSort.SelectedIndex = 7 Then 'If the sort is DateOfBirth (Descending)"
            TeacherDetails = QuickSort(TeacherDetails, 0, MaxIndex, "DOB Des")
        Else
            Exit Sub 'If no sort has been selected then it exits the procedure
        End If
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Declare sw as new StreamWriter to write to TempFile.txt
        For Index = 0 To MaxIndex 'Writes records to TempFile
            RecordLine = TeacherDetails(Index).TeacherID & "," & TeacherDetails(Index).FirstName & "," & TeacherDetails(Index).LastName & "," & TeacherDetails(Index).DateOfBirth _
                & "," & TeacherDetails(Index).Username & "," & TeacherDetails(Index).Password
            sw.WriteLine(RecordLine)
        Next
        sw.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstTeachers, "TempFile.txt") 'Updates the teachers listview such that the items are in the new sorted order

    End Sub

    Private Sub RecordArray(ByRef TeacherDetails() As Teachers) 'Procedure for assigning values (records read from file) to an array of records
        Dim Index As Integer = 0 'Index of TeacherDetails array
        Dim sr As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers database StreamReader
        StringLine = sr.ReadLine() 'Read the first line (record) of the teachers file, assign it to StringLine
        While (StringLine <> Nothing) 'While EOF has not been reached
            'Assigning record fields to TeacherDetails array
            TeacherRecords = StringLine.Split(",") 'Assign comma deliited fields to TeacherRecords array
            TeacherDetails(Index).TeacherID = TeacherRecords(0)
            TeacherDetails(Index).FirstName = TeacherRecords(1)
            TeacherDetails(Index).LastName = TeacherRecords(2)
            TeacherDetails(Index).DateOfBirth = TeacherRecords(3)
            TeacherDetails(Index).Username = TeacherRecords(4)
            TeacherDetails(Index).Password = TeacherRecords(5)
            Index = Index + 1 'Increment Index by 1
            StringLine = sr.ReadLine() 'Read next record of teacher file
        End While
        sr.Close() 'Closes Teachers StreamReader
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Procedure for when Help button is clicked
        'Briefly explains what the Save, Edit and Delete buttons do
        MsgBox("Save - saves a teacher record" & vbNewLine & "Edit - edits the teacher record selected from the listview, and saves the edited database" & vbNewLine &
               "Delete - deletes a teacher record that has been selected (clicked) from the listview")
    End Sub
End Class