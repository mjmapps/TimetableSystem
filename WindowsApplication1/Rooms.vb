Imports System.IO 'Reference library so read and write commands can be used
Public Class Rooms
    Structure Rooms 'Declaring structure Rooms
        'Declaring members (fields) of structure Rooms
        Public RoomID As String
        Public Type As String
        Public Capacity As Integer
        Public Computers As Integer
        Public Boards As Integer
    End Structure
    'Declaring public variables
    Public Room As New Rooms 'Declare Room as new instance of Rooms
    Public RoomArray((CountRecords("Rooms.txt")) - 1) As String 'Stores RoomIDs
    'Declaring private variables
    Dim RoomSelect As Boolean 'Whether a room listview item has been selected
    Dim RoomEntry(4) As String 'Stores fields of a room record
    Dim SelectedRoom As String 'ID of the selected room listview item
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Procedure for when form is loaded
        WhichForm = "Rooms" 'Current form is Rooms
        'If the form is loaded from a Lessons form to search for a room record 
        If GetID = True Then
            'Makes the save, delete and edit buttons invisible so as the user isn't meant to edit the records when they are simply searching for one
            btnSave.Visible = False
            btnDelete.Visible = False
            btnAdd.Visible = False
            btnBack.Visible = False
        End If
        CheckAll() 'Making sure each database exists
        UpdateListView(lstRooms, "Rooms.txt") 'Updates Rooms listview using Rooms file
        StoreIDArray(RoomArray, lstRooms) 'Updates RoomArray to store IDs of current records
    End Sub

    Private Sub txtRoom_TextChanged(sender As Object, e As EventArgs) Handles txtRoomID.TextChanged 'Procedure for when user inputs a RoomID
        ValidateRoom(txtRoomID.Text) 'Calls procedure to validate the inputted RoomID
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click 'Procedure for when Add button is clicked
        'Validation checks
        InvalidCount = 0 'Assigns 0 to InvalidCount to start a new validation check
        ValidateRoom(txtRoomID.Text) 'Checks if inputted RoomID is valid
        cboPresenceCheck(cboType, "room type") 'Checks if a valid RoomType is inputted
        If InvalidCount > 0 Then 'If InvalidCount is greater than 0...
            Exit Sub 'Exit procedure
        End If
        'Adding the item to lstRooms
        Dim RoomItem As New ListViewItem 'Declare RoomItem as new listview item
        'Assigning room fields to RoomEntry array
        RoomEntry(0) = txtRoomID.Text
        RoomEntry(1) = cboType.SelectedItem
        RoomEntry(2) = spCapacity.Value
        RoomEntry(3) = spComputers.Value
        RoomEntry(4) = spBoards.Value
        RoomItem = New ListViewItem(RoomEntry) 'Assign a new listview item, taking in the elements of RoomEntry as sub-items, to RoomItem
        If RoomSelect = True Then 'If the admin is editing an item...
            RoomArray(lstRooms.FocusedItem.Index) = RoomEntry(0) 'Assigns the edited RoomID to its original element at RoomArray
            lstRooms.Items(lstRooms.FocusedItem.Index) = RoomItem 'Edits the lstRooms item with its new fields
            Exit Sub 'Exit procedure
        End If
        ReDim Preserve RoomArray(lstRooms.Items.Count) 'Resize RoomArray, with the maximum index being equal to the number of items in lstRooms
        RoomArray(lstRooms.Items.Count) = RoomEntry(0) 'Assign the ID field of RoomEntry to RoomArray
        lstRooms.Items.Add(RoomItem) 'Add RoomItem to lstRooms listview
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'Procedure for when Save button is clicked
        File.Delete("Rooms.txt") 'Delete the file Rooms.txt
        Dim sw As New StreamWriter(Application.StartupPath & "\Rooms.txt", True) 'Declare sw variable as new StreamWriter, creating a new blank database (Rooms.txt) to write data 
        For Each RoomItem As ListViewItem In lstRooms.Items 'Looping through each Rooms listview item
            'Assigning the RoomItem fields to Room members
            Room.RoomID = RoomItem.SubItems.Item(0).Text
            Room.Type = RoomItem.SubItems.Item(1).Text
            Room.Capacity = RoomItem.SubItems.Item(2).Text
            Room.Computers = RoomItem.SubItems.Item(3).Text
            Room.Boards = RoomItem.SubItems.Item(4).Text
            'Use sw to write a new line to the database concatenating the Room fields, using "," as a delimiter 
            sw.WriteLine(Room.RoomID & "," & Room.Type & "," & Room.Capacity & "," & Room.Computers & "," & Room.Boards)
        Next 'Repeat for next Rooms listview item
        sw.Close() 'Close sw
        MsgBox("Saved!") 'Message box outputs "Saved!" to the user
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Procedure for when Delete button is clicked
        If (lstRooms.Items.Count > 0) And (RoomSelect = True) Then 'If the number of items in lstRooms is greater than 0 and a room listview item has been selected
            lstRooms.Items.RemoveAt(lstRooms.SelectedIndices(0)) 'Remove the selected item in lstRooms
            'Re-assigns IDs to RoomArray elements based on the new position of the room listview items
            For Each RoomItem As ListViewItem In lstRooms.Items 'Looping through each item (declared as RoomItem) in lstRooms
                RoomArray(RoomItem.Index) = RoomItem.SubItems.Item(0).Text
            Next 'Repeat for next Rooms listview item
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click 'Procedure for when Back button is clicked
        Back() 'Calls Back procedure
        Me.Close() 'Close current form
    End Sub

    Private Sub lstRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRooms.SelectedIndexChanged 'Procedure for when the selected index of lstRooms is changed
        RoomSelect = False 'RoomSelect is currently False as the selected item has not yet been found
        'Checking for a Rooms listview item
        If lstRooms.SelectedItems.Count > 0 Then 'If the number of selected items in lstRooms is greater than 0...
            For Each RoomItem As ListViewItem In lstRooms.Items 'Loop through each Rooms listview item
                If RoomItem.Index = lstRooms.FocusedItem.Index Then 'If there is a match with the selected index and the current item's index
                    'The selected item has been found
                    RoomSelect = True 'RoomSelect is now true
                    'Assign fields of the selected item to the input boxes (so that the admin can view or edit them)
                    SelectedRoom = RoomItem.SubItems.Item(0).Text 'The RoomID that is to be used for a Lesson
                    txtRoomID.Text = SelectedRoom
                    cboType.SelectedItem = RoomItem.SubItems.Item(1).Text
                    spCapacity.Value = RoomItem.SubItems.Item(2).Text
                    spComputers.Value = RoomItem.SubItems.Item(3).Text
                    spBoards.Value = RoomItem.SubItems.Item(4).Text
                    Exit For 'Exit for loop
                End If
            Next 'Repeat for next Rooms listview item
            If GetID = True Then 'If the RoomID is being used for a lesson
                ChangeItem(Lessons.cboRoomID, SelectedRoom) 'Change the Lesson RoomID combo box's item to SelectedRoom
                Me.Close() 'Close Rooms form
            End If
        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged 'Procedure for when the selected index of the Type combo box is changed
        'Changes the minimum number of computers based on the room type
        If cboType.SelectedItem = "Computer Room" Then 'If "Computer Room" has been selected
            spComputers.Minimum = 1 'minimum value for computers spinner is now 1
        Else 'If this isn't a computer room then having computers isn't mandatory
            spComputers.Minimum = 0 'minimum value for computers spinner is now 0
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged 'Procedure for when search text is changed
        SearchID(txtSearch.Text) 'Calls procedure for searching RoomID based on what was inputted in the txtSearch text box
    End Sub

    Private Sub SearchID(Value As String) 'Procedure of a linear search used to search for RoomID
        UpdateListView(lstRooms, "Rooms.txt") 'Updates the Rooms listview
        If (Value <> "") Then 'If the search bar is not blank
            For Each RoomItem As ListViewItem In lstRooms.Items 'Loops through each rooms listview item
                'Only the matching rooms listview item must be displayed
                If ((RoomItem.SubItems.Item(0).Text <> Value)) Then 'If there is not a match it removes the item
                    RoomItem.Remove()
                End If
            Next
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click 'Procedure for when Help button is clicked
        'Briefly explains what the Add, Save and Delete buttons do
        MsgBox("Add - adds a room item" & vbNewLine & "Save - saves the room records to the database" & vbNewLine &
               "Delete - deletes a room item that has been selected (clicked) from the listview" & vbNewLine &
               "To edit a room record click on it from the listview, edit the desired details then click Add")
    End Sub

    '-------------------VALIDATION--------------------
    Private Sub ValidateRoom(RoomID As String) 'Declare procedure to validate the inputted RoomID
        Dim PresenceText, LengthText As String 'Error messages
        PresenceText = PresenceCheck(RoomID, "RoomID") 'Presence check on the RoomID
        LengthText = LengthCheck(RoomID, "RoomID", 10) 'Length check on the RoomID 
        If PresenceText <> "" Then 'If the presence check detected an invalid input...
            MsgBox(PresenceText) 'Outputs the error to the user
            Exit Sub 'Exits the procedure
        ElseIf LengthText <> "" Then 'If the length check detected an invalid input...
            MsgBox(LengthText) 'Outputs the error to the user
            Exit Sub 'Exits the procedure
        End If
        'Checks if there is a duplicate room already entered
        NotValid = False
        If RoomSelect = False Then 'If a room has not been selected to be edited
            For i = 0 To (lstRooms.Items.Count - 1) 'Looping through elements in the room array
                If RoomArray(i) = RoomID Then 'If there is a match then the room is already taken
                    'So RoomID is invalid
                    NotValid = True
                    InvalidCount = InvalidCount + 1
                    MsgBox("RoomID is already taken.") 'Outputs to the user that the room is already taken
                End If
            Next
        End If
        If NotValid = True Then 'If there is an error then change the colour to red
            txtRoomID.BackColor = Color.Red
        Else 'Otherwise keep it as white
            txtRoomID.BackColor = Color.White
        End If
    End Sub
End Class