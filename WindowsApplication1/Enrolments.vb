Imports System.IO 'Reference library so read and write commands can be used
Public Class Enrolments
    Structure Enrolments 'Declaring structure Enrollments
        'Declaring members (fields) of structure Enrolments
        Public EnrolID As Integer
        Public EnrolDate As Date
        Public StudentID As String
        Public SubjectID As String
    End Structure
    'Declaring public variables
    Public Enrolment As New Enrolments 'Declare Enrolment as a new instance of Enrolments
    Public EnrolSelect As Boolean 'Variable for checking if an enrolment listview item has been selected
    Public TempEnrolID As String 'Stores the ID of a selected enrolment listview item
    Public AddStatus As Boolean 'Whether an enrolments listview item is being added or not
    'Declaring private string array
    Dim EnrolEntry(3) As String 'stores fields of current record

    Private Sub Enrolments_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "Enrolments"  'Current form is Enrollments
        'Making sure each database exists
        CheckAll()
        'Updating enrolments listview, as well as students and subjects combo-boxes
        UpdateListView(lstEnrolments, "Enrolments.txt")
        UpdateComboBox(cboStudentID, "Students.txt")
        UpdateComboBox(cboSubjectID, "Subjects.txt")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'Procedure for when Back button is clicked
        Back() 'Calls Back procedure
        Me.Close() 'Close current form
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'Procedure for when Add button is clicked
        'Validation checks
        InvalidCount = 0 'Assigns 0 to InvalidCount to start a new validation check
        EnrolmentPresenceCheck() 'Checks whether StudentID and SubjectID has been selected
        AddStatus = True
        EnrolOverlap(cboStudentID.SelectedItem, cboSubjectID.SelectedItem) 'Checks for overlap with selected StudentID and SubjectID
        AddStatus = False
        Enrolment.EnrolDate = Today() 'Assign current date to Enrolment.EnrollDate
        'Assigning selected combo-box items to StudentID and SubjectID within Enrollment
        Enrolment.StudentID = cboStudentID.SelectedItem
        Enrolment.SubjectID = cboSubjectID.SelectedItem
        If InvalidCount > 0 Then 'If InvalidCount is greater than 0...
            Exit Sub 'Exit procedure
        End If
        'Adding the item to lstEnrolments
        Dim EnrolItem As New ListViewItem
        Dim TempID As Integer = 0
        If EnrolSelect = False Then 'If none of the Enrolment listview items are selected
            TempID = lstEnrolments.Items.Count + 1 'Assigns one above the number of items in Enrolments listview to TempID
            Enrolment.EnrolID = CStr(TempID) 'Cast TempID to String type and then assign this value to Enrolment.EnrolID
        End If
        'Assigning Enrolment values to EnrolEntry array so they can form an item
        If EnrolSelect = True Then 'If an item has been selected to be edited then it will assign that item's ID to the EnrolEntry array
            EnrolEntry(0) = TempEnrolID
        Else
            EnrolEntry(0) = Enrolment.EnrolID
        End If
        'Assigns the rest of the inputted fields to EnrolEntry
        EnrolEntry(1) = Enrolment.EnrolDate
        EnrolEntry(2) = Enrolment.StudentID
        EnrolEntry(3) = Enrolment.SubjectID
        EnrolItem = New ListViewItem(EnrolEntry) 'Assign a new listview item, taking in the elements of EnrolEntry as sub-items, to EnrolItem 
        If EnrolSelect = True Then 'If an Enrolment listview item has been selected to be edited
            'Edits the selected item
            lstEnrolments.Items(lstEnrolments.FocusedItem.Index) = EnrolItem 'Assigns the new details to the Enrolments listview item so that it is now edited
            Exit Sub 'Exit procedure
        End If
        lstEnrolments.Items.Add(EnrolItem) 'Add EnrolItem to Enrolments listview
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        'Saving the current records to the file
        File.Delete("Enrolments.txt") 'Delete the file Enrollments.txt (Enrolments database)
        Dim sw As New StreamWriter(Application.StartupPath & "\Enrolments.txt", True) 'Open Enrollments StreamWriter
        For Each EnrolItem As ListViewItem In lstEnrolments.Items 'Looping through each Enrolments listview item
            'Assigning inputted values to Enrollment fields
            Enrolment.EnrolID = EnrolItem.SubItems.Item(0).Text
            Enrolment.EnrolDate = EnrolItem.SubItems.Item(1).Text
            Enrolment.StudentID = EnrolItem.SubItems.Item(2).Text
            Enrolment.SubjectID = EnrolItem.SubItems.Item(3).Text
            sw.WriteLine(Enrolment.EnrolID & "," & Enrolment.EnrolDate & "," & Enrolment.StudentID & "," & Enrolment.SubjectID) 'Write fields to a new record
        Next 'Repeat for next Enrollments listview item
        sw.Close() 'Close Enrollments StreamReader
        MsgBox("Saved!") 'Message box outputs "Saved!" to user
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Procedure for when Delete button is clicked
        'Deleting an item from lstEnrolments
        If (lstEnrolments.Items.Count > 0) And (EnrolSelect = True) Then 'If the number of items in Enrolments listview is greater than 0 and an Enrolments listview item has been selected
            lstEnrolments.Items.RemoveAt(lstEnrolments.SelectedIndices(0)) 'Remove the selected item in Enrolments listview
        End If
    End Sub

    Private Sub lstEnrollments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEnrolments.SelectedIndexChanged 'Procedure for when the selected index of lstEnrolments is changed
        EnrolSelect = False 'EnrolSelect is currently False as the selected item has not yet been found
        If lstEnrolments.SelectedItems.Count > 0 Then 'If the number of selected items in Enrolments listview is greater than 0...
            For Each EnrolItem As ListViewItem In lstEnrolments.Items 'Loop through each Enrolments listview item
                If EnrolItem.Index = lstEnrolments.FocusedItem.Index Then 'If the current index is equal to the selected index 
                    'The selected item has been found
                    EnrolSelect = True 'EnrolSelect is now True
                    'Assign listview item fields to StudentID and SubjectID combo-boxes
                    TempEnrolID = EnrolItem.SubItems.Item(0).Text
                    cboStudentID.SelectedItem = EnrolItem.SubItems.Item(2).Text
                    cboSubjectID.SelectedItem = EnrolItem.SubItems.Item(3).Text
                    Exit For 'Exit for loop
                End If
            Next 'Repeat for next Enrolments listview item
        End If
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click 'Procedure for when "Get Student" button is clicked
        GetFrom = "Enrolments" 'As StudentID can be searched from Enrolments and Timetables the Subjects form has to know that it's being opened from Enrolments
        GetID = True 'So the Students form knows that it's being opened to obtain a student record
        Students.Show() 'Opens Students form
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click 'Procedure for when "Get Subject" button is clicked
        GetFrom = "Enrolments" 'As SubjectID can be searched from Enrolments and Lessons the Subjects form has to know that it's being opened from Enrolments
        GetID = True 'So the Subjects form knows that it's being opened to obtain a subject record
        Subjects.Show() 'Opens Subjects form
    End Sub



    '----------------------SORTING------------------------


    Private Function Partition(Array() As Enrolments, Low As Integer, High As Integer, ComparisonType As String) 'Function for partitioning the array
        Dim Pivot As Enrolments = Array(High) 'The rightmost element within the partition
        Dim IndexSmall As Integer = Low - 1 'The index of an element less than the pivot
        Dim Index As Integer = Low 'Index of the array, initialised as the leftmost element within the partition
        Dim TempElement As Enrolments 'The temporary element used for a swap
        For Index = Low To (High - 1) 'Loops through the array
            If Comparison(Array, Pivot, Index, ComparisonType) = 0 Then 'If the comparison returns 0 then it increments the smaller index by 1 and swaps this smaller element with the current element
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

    Private Function QuickSort(Array() As Enrolments, Low As Integer, High As Integer, ComparisonType As String) 'Function for quicksort
        Dim PartIndex As Integer 'The pivot after the partitioning
        If (Low < High) Then 'If the lowest index is less than the highest index
            PartIndex = Partition(Array, Low, High, ComparisonType) 'Calls partition function and assigns its returned value to a partition index
            QuickSort(Array, Low, (PartIndex - 1), ComparisonType) 'Calls quick sort for the lower list (elements less than the pivot)
            QuickSort(Array, (PartIndex + 1), High, ComparisonType) 'Calls quick sort for the upper list (elements greater than the pivot)
        End If
        Return Array 'Returns the sorted array
    End Function




    Private Function Comparison(Array() As Enrolments, Pivot As Enrolments, Index As Integer, ComparisonType As String) 'Function for determining the order in which the array should be quicksorted 
        'So it determines how the element and pivot should be compared 
        Select Case ComparisonType
            Case "ID Asc" 'Sorting by EnrolID in ascending order
                If CInt(Array(Index).EnrolID) > CInt(Pivot.EnrolID) Then 'If the element's EnrolID is greater than the pivot's EnrolID
                    Return 1
                Else
                    Return 0
                End If
            Case "ID Des" 'Sorting by EnrolID in descending order
                If CInt(Array(Index).EnrolID) < CInt(Pivot.EnrolID) Then 'If the element's EnrolID is less than the pivot's EnrolID
                    Return 1
                Else
                    Return 0
                End If
            'Sorting by Date Of Birth
            Case "Date Asc" 'Sorting by EnrolDate in ascending order
                If CDate(Array(Index).EnrolDate) > CDate(Pivot.EnrolDate) Then 'If the element's EnrolDate is greater than the pivot's EnrolDate
                    Return 1
                Else
                    Return 0
                End If
            Case "Date Des" 'Sorting by EnrolDate in descending order
                If CDate(Array(Index).EnrolDate) < CDate(Pivot.EnrolDate) Then 'If the element's EnrolDate less than the pivot's EnrolDate
                    Return 1
                Else
                    Return 0
                End If
        End Select
        Return -1
    End Function



    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged 'Procedure for when the user selects a Sort
        MaxIndex = CountRecords("Enrolments.txt") - 1 'Number of records in Enrolments file - 1
        Dim EnrolDetails(0 To MaxIndex) As Enrolments 'Declares Enrolments array of records (structure Enrolments)
        Dim RecordLine As String 'The record that is to be written to the sorted TempFile
        ClearTempFile() 'Clearing TempFile so old records don't interfere with the new ones being copied to it
        RecordArray(EnrolDetails) 'Assigns enrolment records to EnrolDetails array
        'Depending on the selected sort method it calls the QuickSort function with a different CompareType parameter
        If cboSort.SelectedIndex = 0 Then 'If the sort is "EnrolID (Ascending)"
            EnrolDetails = QuickSort(EnrolDetails, 0, MaxIndex, "ID Asc")
        ElseIf cboSort.SelectedIndex = 1 Then 'If the sort is "EnrolID (Descending)"
            EnrolDetails = QuickSort(EnrolDetails, 0, MaxIndex, "ID Des")
        ElseIf cboSort.SelectedIndex = 2 Then 'If the sort is EnrolDate (Ascending)"
            EnrolDetails = QuickSort(EnrolDetails, 0, MaxIndex, "Date Asc")
        ElseIf cboSort.SelectedIndex = 3 Then 'If the sort is EnrolDate (Descending)"
            EnrolDetails = QuickSort(EnrolDetails, 0, MaxIndex, "Date Des")
        Else
            Exit Sub 'If no sort has been selected then it exits the procedure
        End If
        'Writing the sorted database to TempFile
        Dim sw As New System.IO.StreamWriter(Dir$("TempFile.txt"), True) 'Declare sw as new StreamWriter to write to TempFile.txt
        For Index = 0 To MaxIndex 'Writes records to TempFile
            RecordLine = CStr(EnrolDetails(Index).EnrolID & "," & EnrolDetails(Index).EnrolDate & "," & EnrolDetails(Index).StudentID & "," & EnrolDetails(Index).SubjectID)
            sw.WriteLine(RecordLine)
        Next
        sw.Close() 'Closes TempFile StreamWriter
        UpdateListView(lstEnrolments, "TempFile.txt") 'Updates the enrolments listview such that the items are in the new sorted order
    End Sub

    Private Sub RecordArray(ByRef EnrolDetails() As Enrolments) 'Procedure for assigning values (records read from file) to an array of records
        Dim EnrolRecords() As String 'Stored fields of an enrolment record
        Dim Index As Integer = 0 'Index of EnrolDetails array
        Dim sr As New System.IO.StreamReader(Dir$("Enrolments.txt"), True) 'Opens Enrolments database StreamReader
        StringLine = sr.ReadLine() 'Read the first line (record) of the enrolments file, assign it to StringLine
        While (StringLine <> Nothing) 'While EOF has not been reached
            EnrolRecords = StringLine.Split(",") 'Assigns comma delimited fields to EnrolRecords array
            'Assigning record fields to StudentDetails array
            EnrolDetails(Index).EnrolID = EnrolRecords(0)
            EnrolDetails(Index).EnrolDate = EnrolRecords(1)
            EnrolDetails(Index).StudentID = EnrolRecords(2)
            EnrolDetails(Index).SubjectID = EnrolRecords(3)
            Index = Index + 1 'Increment Index by 1
            StringLine = sr.ReadLine() 'Read next record of enrolments file
        End While
        sr.Close() 'Closes Enrolments StreamReader
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Procedure for when Help button is clicked
        'Briefly explains what the Add, Save and Delete buttons do
        MsgBox("Add - adds an enrolment item" & vbNewLine & "Save - saves the enrolment records to the database" & vbNewLine &
               "Delete - deletes an enrolment item that has been selected (clicked) from the listview" & vbNewLine &
               "To edit an enrolment record click on it from the listview, edit the desired details then click Add")
    End Sub

    '---------------VALIDATION---------------
    Public Sub EnrolmentPresenceCheck() 'Procedure for performing a presence check on the student and subject combo boxes
        'This checks whether the StudentID and SubjectID have been selected
        cboPresenceCheck(cboStudentID, "StudentID") 'Presence check for cboStudentID combo box
        cboPresenceCheck(cboSubjectID, "SubjectID") 'Presence check for cboSubjectID combo box
    End Sub

End Class
