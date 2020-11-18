Module Validation
    'Declaring public variables to be used in validation methods
    Public NotValid As Boolean 'Whether the input is valid or not
    Public InvalidCount As Integer = 0 'The number of invalid inputs that have been detected
    Public SelectedItem As Integer 'The index of a selected listview item
    Public SaveCheck As Boolean 'Whether a record is being saved or not
    Public WhichForm As String = "" 'The form which the user is currently in

    Public Function PresenceCheck(ByVal Input As String, ByVal Field As String) 'Function for performing a presence check on an inputted string
        Dim PresenceText As String = "" 'Initialise the result (error message) as blank
        If Input = "" Then 'If the user input is invalid
            NotValid = True 'The input is not valid
            InvalidCount = InvalidCount + 1 'Increments InvalidCount by 1
            PresenceText = (Field & " cannot be left blank.") 'Error message is that the input cannot be left blank
        End If
        Return PresenceText 'Returns the error message
    End Function

    Public Function LengthCheck(ByVal Input As String, ByVal Field As String, ByVal MaxLength As Integer) 'Function for performing a length check on an inputted string
        Dim LengthText As String = "" 'Initialise the result (error message) as blank
        If Len(Input) > MaxLength Then 'If the length of input is greater than the maximum length...
            'Then the input is invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            LengthText = (Field & " can't be above " & MaxLength & " characters.") 'Error message is that the input can't be longer than its maximum length
        End If
        Return LengthText
    End Function

    Public Sub cboPresenceCheck(ByVal cboBox As ComboBox, ByVal BoxName As String) 'Procedure for a presence check on a combo box
        If cboBox.SelectedItem = Nothing Then 'If no combo box items were selected
            'Then the input is invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            MsgBox("Please select a " & BoxName) 'Prompts the user to select an item from the combo box
            cboBox.BackColor = Color.Red 'Changes the background colour to red
        Else 'If a combo box item was selected then the input is valid
            NotValid = False
            cboBox.BackColor = Color.White 'Changes the background colour to white
        End If
    End Sub

    Public Function ValidateName(ByVal Name As String) 'Procedure for validating a name
        'Declare variables
        Dim PresenceText, LengthText, FormatText, FinalLabel As String 'Stores error messages
        NotValid = False 'Assign False to NotValid
        PresenceText = PresenceCheck(Name, "Name") 'Presence check on the name
        'TEST CORRECTION PRESENCE CHECK
        If PresenceText <> "" Then 'If the presence check detected an error then it returns that error
            Return PresenceText
        End If
        '---------------------
        'Format check for name
        If Name.Count <> Name.Count(Function(C) Char.IsLetter(C)) Then 'If the name does not consist of only letters
            'Then the inputted name is invalid so the FormatText error message prompts the user to only use English letters
            NotValid = True
            InvalidCount = InvalidCount + 1
            FormatText = "Please use English letters only."
        Else
            FormatText = ""
        End If
        LengthText = LengthCheck(Name, "Name", 15) 'Length check on the name
        FinalLabel = (FormatText & vbNewLine & LengthText) 'Concatenate all warnings and assign to FinalLabel
        Return FinalLabel 'Returns the error messages
    End Function

    Public Function ValidateDate(ByVal InputDate As String, ByVal MinDate As Date) 'Function for validating the date of birth
        'Declaring variables
        Dim ValidText As String = "" 'Error message
        Dim DateCheck As Boolean = IsDate(InputDate) 'If the input date is of type Date
        NotValid = False
        ValidText = PresenceCheck(InputDate, "Date") 'Presence check on the inputted date
        If ValidText <> "" Then 'If the presence check detected an invalid input then it returns the error message
            Return ValidText
        End If
        'Type check on the date
        If (DateCheck = False) Then 'If the inputted date is not in the correct format of DD/MM/YY then it is detected as invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            ValidText = "Date is not in the format DD/MM/YY" 'Prompts the user to enter the date in the correct format
            'Range check on the date
        ElseIf ((InputDate < MinDate) Or (InputDate > Today())) Then 'If the date is before the minimum date or after today then it isn't valid
            NotValid = True
            InvalidCount = InvalidCount + 1
            ValidText = "Date of Birth is outside of valid range." 'Tells the user that the date of birth is outside of its valid range
        End If
        Return ValidText
    End Function

    Function ValidateUser(ByVal Username As String) 'Function for validating the username
        'Declaring error message variables
        Dim PresenceText, LengthText, FinalLabel As String 'Error messages
        Dim DupText As String = "" 'Duplicate error message
        NotValid = False
        PresenceText = PresenceCheck(Username, "Username") 'Presence check on the username
        LengthText = LengthCheck(Username, "Username", 15) 'Length check on the username
        'Checks if there are duplicate usernames
        If WhichForm = "Students" Then 'For the Students form
            Dim sr As New System.IO.StreamReader(Dir$("Students.txt"), True) 'Opens Students StreamReader
            Dim StudentItem As Integer = 0 'Compared with the selected item index
            StringLine = sr.ReadLine() 'Reads the first student record
            'Loops through student records in the database while EOF has not been reached
            'Also loops while either the selected item has not been found (if the record is being edited) or if a new record is being saved
            While (StringLine <> Nothing) And ((SelectedItem <> StudentItem) Or (SaveCheck = True))
                StudentRecords = StringLine.Split(",") 'Split comma delimited fields into StudentRecords array
                StudentItem = StudentRecords(0) 'Assign the StudentID field of StudentRecords to StudentItem
                'If the usernames match and either the selected item's ID and this StudentItem's ID don't match or a new record is being saved 
                If (StudentRecords(5) = Username) And ((SelectedItem <> StudentItem) Or (SaveCheck = True)) Then
                    'The user is trying to store a duplicated username which is invalid
                    NotValid = True
                    InvalidCount = InvalidCount + 1
                    DupText = "Username is already taken." 'Outputs to the user that this username is already taken
                End If
                StringLine = sr.ReadLine() 'Reads the next student record
            End While
            sr.Close() 'Closes Studen
        ElseIf WhichForm = "Teachers" Then 'For the Teachers form
            Dim sr As New System.IO.StreamReader(Dir$("Teachers.txt"), True) 'Opens Teachers StreamReader
            Dim TeacherItem As Integer = 0 'Compared with the selected item index
            StringLine = sr.ReadLine() 'Reads the first teacher record
            'Loops through teacher records in the database while EOF has not been reached
            'Also loops while either the selected item has not been found (if the record is being edited) or if a new record is being saved
            While (StringLine <> Nothing) And ((SelectedItem <> TeacherItem) Or (SaveCheck = True))
                TeacherRecords = StringLine.Split(",") 'Split comma delimited fields into TeacherRecords array
                TeacherItem = TeacherRecords(0) 'Assign the TeacherID field of TeacherRecords to TeacherItem
                'If the usernames match and either the selected item's ID and this TeacherItem's ID don't match or a new record is being saved
                If (TeacherRecords(4) = Username) And ((SelectedItem <> TeacherItem) Or (SaveCheck = True)) Then
                    'Then the user is trying to store a duplicated username which is invalid
                    NotValid = True
                    InvalidCount = InvalidCount + 1
                    DupText = "Username is already taken." 'Outputs to the user that this username is already taken
                End If
                StringLine = sr.ReadLine() 'Reads the next teacher record
            End While
            sr.Close() 'Closes Teachers StreamReader
        End If
        FinalLabel = (PresenceText & vbNewLine & LengthText & vbNewLine & DupText) 'Assigns the combined error messages to FinalLabel
        Return FinalLabel 'Returns the error messages as FinalLabel
    End Function

    Function ValidatePass(ByVal Password As String) 'Function for validating the password
        'Declare variables
        Dim PresenceText, LengthText, NumText, CaseText, FinalWarning As String 'Error messages
        Dim NumCount As Integer = 0 'Number of numbers in the string
        Dim UpperCount As Integer = 0 'Number of uppercase characters in the string
        Dim LowerCount As Integer = 0 'Number of lowercase characters in the string
        'Initialise variables
        NumText = ""
        CaseText = ""
        NotValid = False
        Dim Characters = Password.ToCharArray() 'Declare characters as an array of characters split from Password
        PresenceText = PresenceCheck(Password, "Password") 'Presence check on the password input
        If PresenceText <> "" Then 'If the presence check detected an invalid input (password was not present)
            Return PresenceText 'Then it returns the error message
        End If
        LengthText = LengthCheck(Password, "Password", 15) 'Length check on the password input
        'Checking the strength of the password
        'Checks if password has at least 1 number for security strength
        For i = 0 To (Len(Password) - 1)
            If IsNumeric(Characters(i)) = True Then 'For every number in the password, NumCount is incremented by 1
                NumCount = NumCount + 1
            ElseIf Char.IsUpper(Characters(i)) = True Then 'For every uppercase character in the password, UpperCount is incremented by 1
                UpperCount = UpperCount + 1
            ElseIf Char.IsLower(Characters(i)) = True Then 'For every lowercase character in the password, LowerCount is incremented by 1
                LowerCount = LowerCount + 1
            End If
        Next
        'A strong password must contain numbers as well as a combination of lowercase and uppercase characters
        'So for this password to be valid NumCount, UpperCount and LowerCount must all be greater than 0
        If NumCount = 0 Then 'If there are no numbers then the password is invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            NumText = "Password requires at least 1 number" 'Prompts the user that the password requires at least 1 number
        End If
        If (UpperCount = 0) Or (LowerCount = 0) Then 'If there are no uppercase characters or no lowercase characters then the password is invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            'Prompts the user that the password requires a combination of uppercase and lowercase characters
            CaseText = "Password requires a combination of uppercase and lowercase characters" '
        End If
        FinalWarning = (LengthText & vbNewLine & NumText & vbNewLine & CaseText) 'Concatenates error messages and assigns to FinalWarning
        Return FinalWarning 'Returns the error messages as FinalWarning
    End Function

    Function ValidatePassConfirm(ByVal Pass1 As String, ByVal Pass2 As String) 'Function for verifying the confirmed password
        Dim WarningText As String = "" 'Error message
        NotValid = False
        If Pass1 <> Pass2 Then 'If Pass1 and Pass2 are not equal to each other...
            'Then the confirmed password is invalid
            NotValid = True
            InvalidCount = InvalidCount + 1
            WarningText = "Passwords do not match." 'Outputs to the user that the passwords do not match
        End If
        Return WarningText
    End Function

    Public Sub EnrolOverlap(ByVal Student As String, ByVal Subject As String) 'Procedure that checks for an overlap in an enrolment
        For Each EnrolItem As ListViewItem In Enrolments.lstEnrolments.Items 'Loops through enrolment listview items
            If (Student = EnrolItem.SubItems.Item(2).Text) Then 'If there is a match with the StudentID field
                'If there is a match with the SubjectID field then the student is already enrolled for this subject
                If (Subject = EnrolItem.SubItems.Item(3).Text) And (Enrolments.AddStatus = True) And (Enrolments.EnrolSelect = False) Then 'When adding an enrolment listview item
                    InvalidCount = InvalidCount + 1
                    MsgBox("Student is already enrolled for this subject.") 'Outputs to the user that the student is already enrolled for this subject
                Else
                    'Checking if there is a clash between subjects
                    Dim LessonRecords() As String 'Stores fields of lesson record
                    Dim sr As New System.IO.StreamReader(Dir$("Lessons.txt"), True) 'Opens Lessons StreamReader sr to read from Lessons.txt database
                    StringLine = sr.ReadLine() 'Reads first Lesson record from the databaase
                    While (StringLine <> Nothing) 'Loops through Lesson records while EOF has not yet been reached
                        LessonRecords = StringLine.Split(",") 'Splits comma delimited fields and assigns to LessonRecords array
                        If LessonRecords(5) = EnrolItem.SubItems.Item(3).Text Then 'If there is a match with the SubjectID field
                            Dim sr1 As New System.IO.StreamReader(Dir$("Lessons.txt"), True) 'Opens another Lessons StreamReader, sr1
                            Dim StringLine1 As String = sr1.ReadLine() 'Reads first lesson from lesson database using parallel streamreader
                            Dim LessonRecords1() As String 'Stores fields of other sr1 lesson record
                            While (StringLine1 <> Nothing) 'Loops through Lesson records (with sr1) while EOF has not been reached
                                LessonRecords1 = StringLine1.Split(",") 'Assigns comma delimited fields to LessonRecords1 array
                                'If there are two different lessons are at the same day, time, one of which the student has already enrolled for, and the other the student is trying to enrol for, then there will be a clash
                                If (LessonRecords(0) <> LessonRecords1(0)) And (LessonRecords(1) = LessonRecords1(1)) And (LessonRecords(2) = LessonRecords1(2)) And (LessonRecords1(5) = Subject) Then
                                    'Clash so input is invalid
                                    InvalidCount = InvalidCount + 1
                                    MsgBox("There is a clash between the subjects.") 'Outputs to the user that there is a clash between the subjects
                                End If
                                StringLine1 = sr1.ReadLine() 'Reads next lesson record using sr1
                            End While
                            sr1.Close() 'Closes sr1 Lessons StreamReader
                        End If
                        StringLine = sr.ReadLine() 'Reads next lesson record using sr
                    End While
                    sr.Close() 'Closes sr Lessons StreamReader
                End If
            End If
        Next
    End Sub

End Module
