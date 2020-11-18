Imports System.IO 'Reference library so read and write commands can be used
Public Class LessonInfo
    Public LessonRecords() As String 'Stores fields of a lesson record
    Dim SubjectID, RoomID, TeacherID As String 'Foreign keys which can be used to provide more details about the lesson

    Private Sub LessonInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WhichForm = "LessonInfo" 'Current form is LessonInfo
        CheckAll() 'Making sure each database exists
        'Calling procedures to load the label values
        LessonLoad()
        SubjectLoad()
        RoomLoad()
        TeacherLoad()
        StudentListLoad()
    End Sub

    Private Sub LessonLoad() 'Procedure for updating Lessons information
        Dim sr As New StreamReader(Dir$("Lessons.txt"), True) 'Open Lessons.txt file to read Lessons data
        StringLine = sr.ReadLine() 'Read first Lesson record
        LessonRecords = StringLine.Split(",") 'Assigns Lesson record to an array delimited by commas
        While (StringLine <> Nothing) 'Loops while the end of the Lessons file has not been reached
            LessonRecords = StringLine.Split(",") 'Assigns Lesson record to an array delimited by commas
            If LessonRecords(0) = GrabbedID Then 'If there is a match with the LessonID field and the GrabbedID
                'Lessons labels are updated with fields from that Lesson record
                lbLessonID.Text += LessonRecords(0)
                lbDay.Text += LessonRecords(1)
                lbTime.Text += (LessonRecords(2) + ":00") 'Concatenate a string to time so that it's in a presentable format
                lbDuration.Text += LessonRecords(3)
                'Assigns RoomID, SubjectID and TeacherID fields from the Lessons record to respective variables
                RoomID = LessonRecords(4)
                SubjectID = LessonRecords(5)
                TeacherID = LessonRecords(6)
                Exit While 'Exit while loop
            End If
            StringLine = sr.ReadLine() 'Read the next Lessons record
        End While
    End Sub

    Private Sub SubjectLoad() 'Procedure for updating Subjects information
        Dim sr As New StreamReader(Dir$("Subjects.txt"), True) 'Open Subjects.txt file to read Subjects data
        StringLine = sr.ReadLine() 'Read first Subject record
        Dim SubjectRecords() As String = StringLine.Split(",") 'Assigns Subject record to an array delimited by commas
        While (StringLine <> Nothing) 'Loops while the end of the Subjects file has not been reached
            SubjectRecords = StringLine.Split(",") 'Assigns Subject record to an array delimited by commas
            If SubjectRecords(0) = SubjectID Then 'If there is a match with the SubjectID field and the SubjectID variable
                'Subjects labels are updated with fields from that Subject record
                lbSubjectID.Text += SubjectRecords(0)
                lbSubject.Text += (SubjectRecords(2) & " " & SubjectRecords(1))
                lbExam.Text += SubjectRecords(3)
                Exit While 'Exit while loop
            End If
            StringLine = sr.ReadLine() 'Read the next Subjects record
        End While
    End Sub

    Private Sub RoomLoad() 'Procedure for updating Rooms information
        Dim sr As New StreamReader(Dir$("Rooms.txt"), True) 'Open Rooms.txt file to read Rooms data
        StringLine = sr.ReadLine() 'Read first Room record
        Dim RoomRecords() As String = StringLine.Split(",") 'Assigns Room record to an array delimited by commas
        While (StringLine <> Nothing) 'Loops while the end of the Rooms file has not been reached
            RoomRecords = StringLine.Split(",") 'Assigns Room record to an array delimited by commas
            If RoomRecords(0) = RoomID Then 'If there is a match with the RoomID field and the RoomID variable
                'Rooms labels are updated with the fields from that Room record
                lbRoomID.Text += RoomRecords(0)
                lbRoomType.Text += RoomRecords(1)
                lbCapacity.Text += RoomRecords(2)
                lbComputers.Text += RoomRecords(3)
                lbBoards.Text += RoomRecords(4)
                Exit While 'Exit while loop
            End If
            StringLine = sr.ReadLine() 'Read the next Rooms record
        End While
    End Sub

    Private Sub cboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged 'Procedure for when the user selects a Sort
        SortStudentNames(lstStudents, cboSort.SelectedIndex) 'Calls bubble sort algorithm for sorting student names
    End Sub

    Private Sub SortStudentNames(ByRef lstView As ListView, ByRef cboIndex As Integer) 'Procedure for sorting student names
        Dim NameDetails() As String = ToArray(lstView) 'NameDetails is an array containing names from the listview
        Select Case cboIndex 'Checks sort combo box to know which sort to use
            Case 0
                NameDetails = AlphaSort(NameDetails, 0, "A-Z") 'Sorts first name, A-Z
            Case 1
                NameDetails = AlphaSort(NameDetails, 0, "Z-A") 'Sorts first name, Z-A
            Case 2
                NameDetails = AlphaSort(NameDetails, 1, "A-Z") 'Sorts last name, A-Z
            Case 3
                NameDetails = AlphaSort(NameDetails, 1, "Z-A") 'Sorts last name, Z-A
        End Select
        lstView.Items.Clear() 'Clears names listview
        For Index = 0 To (NameDetails.Count - 1) 'Loops through NameDetails array
            'Populates ListView with items from sorted array
            Dim NameItem As New ListViewItem 'The new listview item to be added
            Dim Names() As String = NameDetails(Index).Split(",") 'Splits the first name and last name fields by the comma delimiter and assigns to Names array
            NameItem = New ListViewItem(Names) 'Assigns Names to the NameItem lsitview
            lstView.Items.Add(NameItem) 'Adds NameItem to the listview
        Next
    End Sub

    Function AlphaSort(ByRef Array() As String, ByRef FieldNum As Integer, ByRef Type As String) 'Bubble sort for sorting names
        Dim TempElement As String 'Temporary element used during a swap
        Dim Element, Element1 As String 'The two elements in the array being compared
        Dim Swapped As Boolean 'Whether a swap has taken place
        Swapped = False 'Swapped is initially set to False as nothing has been swapped yet
        For Index = 0 To (Array.Count - 2) 'Looping to the maximum index where the element can be swapped
            Element = Array(Index).Split(",")(FieldNum) 'Assign field of record to Element
            Element1 = Array(Index + 1).Split(",")(FieldNum) 'Assign field of the next consecutive record to Element1
            If AlphaCompare(Type, Element, Element1, 0) = 1 Then 'If the Element has a greater value than Element1
                'Swaps the elements
                Swapped = True 'As elements have been swapped the Swapped variable is now True
                TempElement = Array(Index)
                Array(Index) = Array(Index + 1)
                Array(Index + 1) = TempElement
            End If
        Next
        If Swapped = True Then 'If the elements have been swapped
            Return AlphaSort(Array, FieldNum, Type) 'Function is called again to go through the next pass
        End If
        Return Array 'If the array is completely sorted then it will return the sorted array
    End Function

    Private Sub TeacherLoad() 'Procedure for updating Teachers information
        Dim sr As New StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers.txt file to read Teachers data
        StringLine = sr.ReadLine() 'Read first Teacher record
        While (StringLine <> Nothing) 'Loops while the end of the Teacher record has not been reached
            TeacherRecords = StringLine.Split(",") 'Assigns Teacher record to an array delimited by commas
            If TeacherRecords(0) = TeacherID Then 'If there is a match with the TeacherID field and the TeacherID variable
                'Teacher labels are updated with the fields from that Teacher record
                lbTeacherID.Text += TeacherRecords(0)
                lbTeacher.Text += (TeacherRecords(1) & " " & TeacherRecords(2))
                Exit While 'Exit while loop
            End If
            StringLine = sr.ReadLine() 'Read the next Teacher record
        End While
    End Sub

    Public Sub StudentListLoad() 'Procedure for loading and updating the Student listview
        'Setting up the listview lstStudents so that rows and gridlines can be seen
        lstStudents.View = View.Details
        lstStudents.GridLines = True
        lstStudents.FullRowSelect = True
        'Populating the Student listview
        'Open Students.txt and Enrollments.txt files to display all students for a given lesson
        Dim sr1 As New StreamReader(Dir$("Enrolments.txt"), True)
        Dim StringLine1 As String = sr1.ReadLine() 'Read first record of Enrolments
        Dim EnrolRecords() As String = StringLine1.Split(",") 'Split Enrolments record into array from comma delimiters
        While (StringLine1 <> Nothing) 'Loops while the Enrollments record is not blank (which would be the end of the Enrollments file)
            If EnrolRecords(3) = SubjectID Then 'If the SubjectID field in Enrollments is equal to SubjectID for the lesson
                Dim NameRecords() As String = {"", ""} 'Declare array to store student names
                Dim sr As New StreamReader(Dir$("Students.txt"), True)
                StringLine = sr.ReadLine() 'Read first record of Students
                While (StringLine <> Nothing) 'Loops while Students record is not blank (which would be the end of the Students file)
                    StudentRecords = StringLine.Split(",") 'Split Students record into array from the record's comma delimiters
                    If StudentRecords(0) = EnrolRecords(2) Then 'If there is a match with the StudentID field from the Student record and the Enrollment record
                        NameRecords = {StudentRecords(1), StudentRecords(2)} 'Assign first name and last name of the current student record to array
                        Dim StudentItem As New ListViewItem 'Declare StudentItem as a new listview item
                        StudentItem = New ListViewItem(NameRecords) 'Assign a new listview item, taking in the elements of NameRecords as sub-items, to StudentItem 
                        lstStudents.Items.Add(StudentItem) 'Add student record to student listview
                    End If
                    StringLine = sr.ReadLine() 'Reads the next Students record
                End While
                sr.Close() 'Close Students  StreamReader
            End If
            StringLine1 = sr1.ReadLine() 'Assigns the next Enrollment record to StringLine1
            If StringLine1 <> Nothing Then 'If the Enrollments record is not blank
                EnrolRecords = StringLine1.Split(",") 'Split Enrollments record into array from the record's comma delimiters
            End If
        End While
        sr1.Close() 'Close Enrollments StreamReader
    End Sub

End Class