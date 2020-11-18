Imports System.IO 'Reference library so read and write commands can be used
Public Class Subjects
    Structure Subjects 'Declaring structure Subjects
        'Declaring members (fields) of structure Subjects
        Public SubjectID As Integer
        Public Name As String
        Public Level As String
        Public ExamBoard As String
    End Structure
    'Declaring variables
    Public Subject As New Subjects 'Declare Subject as a new instance of Subjects
    Public SubjectSelect As Boolean 'Whether a subject listview item has been selected
    Dim SubjectEntry(3) As String 'Stores fields of a subject record
    Dim TempSubjectID As String 'Temporarily stores SubjectID to calculate the new SubjectID
    Private Sub Subjectsvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "Subjects" 'Current form is Subjects
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        'If the form is loaded from an Enrolments or Lessons form to search for a subject record 
        If GetID = True Then
            'Makes the save, delete and edit buttons invisible so as the user isn't meant to edit the records when they are simply searching for one
            btnSave.Visible = False
            btnDelete.Visible = False
            btnAdd.Visible = False
        End If
        CheckAll() 'Making sure each database exists
        UpdateListView(lstSubjects, "Subjects.txt") 'Updates Subjects listview using Subjects file
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'Procedure for when Add button is clicked
        'Validation Checks
        InvalidCount = 0 'Assign 0 to InvalidCount to start a new validation check
        SubjectCheck() 'Call procedure to validate the inputted subject name
        DuplicateCheck(txtSubject.Text, cboLevel.SelectedItem) 'Checking for duplicate subjects
        cboPresenceCheck(cboLevel, "level") 'Presence check on the cboLevel combo box
        cboPresenceCheck(cboExamBoard, "subject exam board") 'Presence check on the cboExamBoard combo box
        If InvalidCount > 0 Then 'If InvalidCount is greater than 0...
            Exit Sub 'Exit procedure
        End If
        Dim SubjectItem As New ListViewItem 'Declare SubjectItem as new listview item
        If SubjectSelect = False Then 'If the admin is adding an item and not editing it (so an item won't be selected)
            Subject.SubjectID = 1 'Assign 1 to SubjectID
            For Each SubjectItem1 As ListViewItem In lstSubjects.Items 'Looping through each item (declared as SubjectItem1) in lstSubjects listview
                Subject.SubjectID = SubjectItem1.SubItems.Item(0).Text 'Assigns the SubjectID of that item to the SubjectID member in the structure
            Next 'Repeat for next SubjectItem1
            Subject.SubjectID = Subject.SubjectID + 1 'Increment Subject.SubjectID by 1
        End If
        'Assigning values to fields
        If SubjectSelect = True Then 'If the admin is editing an item then it uses the SubjectID of the selected item
            SubjectEntry(0) = TempSubjectID
        Else
            SubjectEntry(0) = Subject.SubjectID 'Otherwise it uses it uses the above calculated Subject.SubjectID
        End If
        SubjectEntry(1) = txtSubject.Text
        SubjectEntry(2) = cboLevel.SelectedItem
        SubjectEntry(3) = cboExamBoard.SelectedItem '
        SubjectItem = New ListViewItem(SubjectEntry) 'Assign a new listview item, taking in the elements of SubjectEntry, to SubjectItem
        If SubjectSelect = True Then 'If the admin is editing an item...
            lstSubjects.Items(lstSubjects.FocusedItem.Index) = SubjectItem 'Assign SubjectItem to the selected item in lstSubjects
            Exit Sub 'Item is now edited so it exits the procedure
        End If
        lstSubjects.Items.Add(SubjectItem) 'Adds the new SubjectItem to lstSubjects listview
    End Sub

    Private Sub lstSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubjects.SelectedIndexChanged 'Procedure for when selected index in lstSubjects is changed
        SubjectSelect = False 'SubjectSelect is currently False as the selected item has not yet been found
        'Checking for a Subjects listview item
        If lstSubjects.SelectedItems.Count > 0 Then 'If the number of selected items in lstSubjects is greater than 0...
            'A subject item has been selected
            For Each SubjectItem As ListViewItem In lstSubjects.Items 'Loop through each Subjects listview item
                If SubjectItem.Index = lstSubjects.FocusedItem.Index Then 'If there is a match with the selected index and the current item's index
                    'The selected item has been found
                    SubjectSelect = True 'SubjectSelect is now True
                    'Assign fields of the selected item to the input boxes (so that the admin can view or edit them)
                    TempSubjectID = SubjectItem.SubItems.Item(0).Text
                    txtSubject.Text = SubjectItem.SubItems.Item(1).Text
                    cboLevel.SelectedItem = SubjectItem.SubItems.Item(2).Text
                    cboExamBoard.SelectedItem = SubjectItem.SubItems.Item(3).Text
                    Exit For 'Exit for loop
                End If
            Next 'Repeat for next Subjects listview item
            If GetID = True Then 'If the SubjectID is being used for an Enrolment or Lesson
                If GetFrom = "Enrolments" Then 'If the SubjectID is being used for an Enrolment
                    ChangeItem(Enrolments.cboSubjectID, TempSubjectID) 'Changes Enrolment SubjectID combo box's item to TempSubjectID
                Else 'If the SubjectID is being used for a lesson
                    ChangeItem(Lessons.cboSubjectID, TempSubjectID) 'Changes Lesson SubjectID combo box's item to TempSubjectID
                End If
                Me.Close() 'Closes Subjects form
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        File.Delete("Subjects.txt") 'Delete Subjects.txt file
        Dim sw As New StreamWriter(Application.StartupPath & "\Subjects.txt", True) 'Declare sw variable as a new StreamWriter, creating a new blank database (Subjects.txt) to write data
        For Each SubjectItem As ListViewItem In lstSubjects.Items 'Looping through each Subjects listview item
            'Assigning the SubjectItem fields to Subject members
            Subject.SubjectID = SubjectItem.SubItems.Item(0).Text
            Subject.Name = SubjectItem.SubItems.Item(1).Text
            Subject.Level = SubjectItem.SubItems.Item(2).Text
            Subject.ExamBoard = SubjectItem.SubItems.Item(3).Text
            'Use sw to write a new line to the database concatenating Subject.SubjectID, Subject.Name, Subject.Level and Subject.ExamBoard, whilst using "," as a delimiter
            sw.WriteLine(Subject.SubjectID & "," & Subject.Name & "," & Subject.Level & "," & Subject.ExamBoard)
        Next 'Repeat for next SubjectItem
        sw.Close() 'Close sw
        MsgBox("Saved!") 'Message box outputs to the user that the file has been saved
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Procedure for when Delete button is clicked
        If lstSubjects.Items.Count > 0 Then 'If the number of items in lstSubjects is greater than 0...
            lstSubjects.Items.RemoveAt(lstSubjects.SelectedIndices(0)) 'Remove the selected item from lstSubjects listview
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'Procedure for when Back button is clicked
        Back() 'Calls Back procedure
        Me.Close() 'Closes current form
    End Sub

    '----------------------SORTING------------------------

    Private Function Partition(Array() As Subjects, Low As Integer, High As Integer, ComparisonType As String) 'Function for partitioning the array
        Dim Pivot As Subjects = Array(High) 'The pivot is set as the rightmost element of the part of the array being partitioned
        Dim IndexSmall As Integer = Low - 1 'The index of an element less than the pivot
        Dim Index As Integer = Low 'Index of the array, initialised as the leftmost element within the partition
        Dim TempElement As Subjects 'The temporary element used for a swap
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

    Private Function QuickSort(Array() As Subjects, Low As Integer, High As Integer, ComparisonType As String) 'Function for quicksort
        Dim PartIndex As Integer 'The pivot after partitioning
        If (Low < High) Then 'If the lowest index is less than the highest index
            PartIndex = Partition(Array, Low, High, ComparisonType) 'Calls partition function and assigns its returned value to a partition index
            QuickSort(Array, Low, (PartIndex - 1), ComparisonType) 'Calls quick sort for the lower list (elements less than the pivot)
            QuickSort(Array, (PartIndex + 1), High, ComparisonType) 'Calls quick sort for the upper list (elements greater than the pivot)
        End If
        Return Array 'Returns the sorted array
    End Function




    Private Function Comparison(Array() As Subjects, Pivot As Subjects, Index As Integer, ComparisonType As String) 'Function for determining the order in which the array should be quicksorted 
        'So it determines how the element and pivot should be compared
        Select Case ComparisonType
            'For names - compares the ASCII values of the first letters of each name (from element and pivot)
            Case "N Asc" 'Sorting by Name in ascending order
                If WordCompare("A-Z", Array(Index).Name, Pivot.Name) = 1 Then 'If the element's subject name is greater than the pivot's subject name
                    Return 1
                Else
                    Return 0
                End If
            Case "N Des" 'Sorting by Name in descending order
                If WordCompare("Z-A", Array(Index).Name, Pivot.Name) = 1 Then 'If the element's subject name is less than the pivot's subject name
                    Return 1
                Else
                    Return 0
                End If
        End Select
        Return -1
    End Function



    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged 'Procedure for when the user selects a Sort
        MaxIndex = CountRecords("Subjects.txt") - 1 'Number of records in Subjects file - 1
        Dim SubjectDetails(0 To MaxIndex) As Subjects 'Declares Subjects array of records (structure Subjects)
        Dim RecordLine As String 'The record that is to be stored in the sorted TempFile
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        RecordArray(SubjectDetails) 'Assigns subjects records to SubjectDetails array
        'Depending on the selected sort method it calls the QuickSort function with a different CompareType parameter
        If cboSort.SelectedIndex = 0 Then 'If the sort is "Name (Ascending)"
            SubjectDetails = QuickSort(SubjectDetails, 0, MaxIndex, "N Asc")
        ElseIf cboSort.SelectedIndex = 1 Then 'If the sort is "Name (Descending)"
            SubjectDetails = QuickSort(SubjectDetails, 0, MaxIndex, "N Des")
        Else
            Exit Sub 'If no sort has been selected then it exits the procedure
        End If
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Declare sw as new StreamWriter to write to TempFile.txt
        For Index = 0 To MaxIndex 'Writes records to TempFile
            RecordLine = CStr(SubjectDetails(Index).SubjectID & "," & SubjectDetails(Index).Name & "," & SubjectDetails(Index).Level & "," & SubjectDetails(Index).ExamBoard)
            sw.WriteLine(RecordLine)
        Next
        sw.Close()
        UpdateListView(lstSubjects, "TempFile.txt") 'Updates the subjects listview such that the items are in the new sorted order
    End Sub

    Private Sub RecordArray(ByRef SubjectDetails() As Subjects) 'Procedure for assigning values (records read from file) to an array of records
        Dim Index As Integer = 0 'Index of SubjectDetails array
        Dim SubjectRecords() As String 'Array for storing fields of a subject record
        Dim sr As New System.IO.StreamReader(Dir$("Subjects.txt"), True) 'Opens Subjects database StreamReader
        StringLine = sr.ReadLine() 'Read the first line (record) of the subjects file, assign it to StringLine
        While (StringLine <> Nothing) 'While EOF has not been reached
            'Assigning record fields to SubjectDetails array
            SubjectRecords = StringLine.Split(",") 'Assign comma delimited fields to SubjectRecords array
            SubjectDetails(Index).SubjectID = SubjectRecords(0)
            SubjectDetails(Index).Name = SubjectRecords(1)
            SubjectDetails(Index).Level = SubjectRecords(2)
            SubjectDetails(Index).ExamBoard = SubjectRecords(3)
            Index = Index + 1 'Increment Index by 1
            StringLine = sr.ReadLine() 'Read next record of subject file
        End While
        sr.Close()
    End Sub

    '---------------------SEARCHING-----------------------

    Public Function BinarySearch(Array() As Subjects, Value As String, Low As Integer, High As Integer) 'A Binary Search is used to search through the array of records
        Dim Mid As Integer 'The mniddle index of the array
        If Array(Mid).Name = Value Then 'If there is a match it returns the index
            Return Mid
        End If
        If (High < Low) Then 'If the upper value is greater than the lower value
            IndexFound = False 'There is no match
            Return -1
        End If

        Mid = (High + Low) / 2 'Calculates the middle element of the array
        If (WordCompare("Search", Array(Mid).Name, Value) = 1) Then 'If this element is greater than the value being searched for
            Return BinarySearch(Array, Value, Low, Mid - 1) 'Returns a binary search within the lower half before the middle element
        ElseIf (WordCompare("Search", Array(Mid).Name, Value) = 0) Then 'If this element is greater than the value being searched for
            Return BinarySearch(Array, Value, Mid + 1, High) 'Returns a binary search within the upper half after the middle element
        End If

        Return Mid 'If a match has been found then it will return its index
    End Function

    Private Sub SearchName() 'Procedure for searching through name
        UpdateListView(lstSubjects, "Subjects.txt") 'Updates the subjects listview
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        MaxIndex = CountRecords("Subjects.txt") - 1 'Sets the maximum index for SubjectDetails as the number of Subject records minus one
        Dim SubjectDetails(0 To MaxIndex) As Subjects 'Declares an array of records (Subjects Structure) called SubjectDetails
        Dim Index As Integer = 0 'Index used when assigning Matches to FoundIndex
        Dim FoundIndex As Integer 'Index of a matching element
        Dim Mid, FirstFound As Integer 'Mid is the index at the middle of the array, FirstFound is the index of the first match that was found
        Dim MatchIndex As Integer = -1 'The index used when matching indexes are being assigned to Matches array
        Dim Matches(MaxIndex) As Integer 'Array for storing matching indexes
        Dim RecordLine As String 'Stores details of the searched record to be written to TempFile
        Dim SpecialCase As Boolean 'Used when there is a match at Mid = 0 because this would not be detected in the MatchIndex array

        RecordArray(SubjectDetails) 'Assigns subject records to SubjectDetails array
        SubjectDetails = QuickSort(SubjectDetails, 0, MaxIndex, "N Asc") 'Applies a quick sort on the records in ascending order of name
        Mid = BinarySearch(SubjectDetails, txtSearch.Text, 0, MaxIndex) 'Applies a binary search on the now sorted array of records
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
            While (SubjectDetails(Mid).Name = SubjectDetails(Mid - 1).Name) 'While there is another match to the left of the found value
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
            While (SubjectDetails(Mid).Name = SubjectDetails(Mid + 1).Name) 'While there is another match to the right of the found value
                MatchIndex = MatchIndex + 1 'MatchIndex is incremented by 1 to add the new match to the Matches array
                Mid = Mid + 1 'Mid is incremented by 1 to store the next consecutive element/match in the Matches array
                Matches(MatchIndex) = Mid 'This new match is added to the Matches array
                If Mid > (MaxIndex - 1) Then 'If Mid is outside of the range for comparisons 
                    Exit While 'Exits the while loop
                End If
            End While
        End If
        'Creating a new TempFile to write the found records to
        File.Delete("TempFile.txt") 'Delete old TempFile
        Dim st As New StreamWriter(Application.StartupPath & "\TempFile.txt", True) 'Creates a new blank TempFile database called TempFile.txt to write data

        Index = 0 'Assigns 0 to Index so that it points to the start of the Matches array
        'The elements in Matches represent the index at which each match is located
        While ((Matches(Index) <> Nothing) Or (SpecialCase = True)) 'Writes records to TempFile while the end of the Matches array has not been reached
            FoundIndex = Matches(Index)
            RecordLine = SubjectDetails(FoundIndex).SubjectID & "," & SubjectDetails(FoundIndex).Name & "," & SubjectDetails(FoundIndex).Level & "," & SubjectDetails(FoundIndex).ExamBoard
            st.WriteLine(RecordLine)
            Index = Index + 1
            SpecialCase = False 'Deactivates SpecialCase so Matches(Index) can now be 0
        End While
        st.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstSubjects, "TempFile.txt") 'Updates the subjects listview such that the items displayed are the searched results

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged 'Procedure for when user inputs a subject name to search
        SearchName() 'Calls procedure to validate the inputted subject name
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Procedure for when Help button is clicked
        'Briefly explains what the Add, Save and Delete buttons do
        MsgBox("Add - adds a subject item" & vbNewLine & "Save - saves the subject records to the database" & vbNewLine &
               "Delete - deletes a subject item that has been selected (clicked) from the listview" & vbNewLine &
               "To edit a subject record click on it from the listview, edit the desired details then click Add")
    End Sub

    '--------------VALIDATION--------------
    Private Sub SubjectCheck() 'Declare procedure to validate the inputted Subject
        Dim PresenceText, LengthText As String 'Error messages
        NotValid = False
        PresenceText = PresenceCheck(txtSubject.Text, "Subject name")
        LengthText = LengthCheck(txtSubject.Text, "Subject name", 20)
        If PresenceText <> "" Then 'If the presence check detected an invalid input...
            MsgBox(PresenceText) 'Outputs the error to the user
            Exit Sub 'Exits the procedure
        ElseIf LengthText <> "" Then 'If the length check detected an invalid input...
            MsgBox(LengthText) 'Outputs the error to the user
            Exit Sub 'Exits the procedure
        End If
        If NotValid = True Then 'If there is an error then change the colour to red
            txtSubject.BackColor = Color.Red
        Else
            txtSubject.BackColor = Color.White
        End If
    End Sub

    Private Sub DuplicateCheck(ByRef Subject As String, Level As String) 'Procedure for checking for a duplicate subject name
        For Each SubjectItem As ListViewItem In lstSubjects.Items 'Loops through subject listview items
            'If there is a match with the Subject and Level fields, and the an item has not been selected to be edited...
            If (SubjectItem.SubItems.Item(1).Text = Subject) And (SubjectItem.SubItems.Item(2).Text = Level) And (SubjectSelect = False) Then
                'There is a duplicate record so the Subject input is invalid
                NotValid = True
                InvalidCount = InvalidCount + 1
                MsgBox("Subject for that level is already taken") 'Outputs to the user that the subject for that level is already taken
                'If there is an error then change the colour to red
                txtSubject.BackColor = Color.Red
                cboLevel.BackColor = Color.Red
                Exit For 'Exits for loop as a duplicate subject has been detected
            Else 'Otherwise a duplicate has not been found so the input is valid
                NotValid = False
                'Otherwise keep the colour as white
                txtSubject.BackColor = Color.White
                txtSubject.BackColor = Color.White
            End If
        Next
    End Sub
End Class