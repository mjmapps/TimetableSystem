<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teachers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPassConfirm = New System.Windows.Forms.TextBox()
        Me.lbFirstName = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lbDOB = New System.Windows.Forms.Label()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.lbConfirmPass = New System.Windows.Forms.Label()
        Me.lbFirstNameWarning = New System.Windows.Forms.Label()
        Me.lbLastNameWarning = New System.Windows.Forms.Label()
        Me.lbDOBWarning = New System.Windows.Forms.Label()
        Me.lbUsernameWarning = New System.Windows.Forms.Label()
        Me.lbPasswordWarning = New System.Windows.Forms.Label()
        Me.lbConfirmPassWarning = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstTeachers = New System.Windows.Forms.ListView()
        Me.colTeacherID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDateOfBirth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.rbLastName = New System.Windows.Forms.RadioButton()
        Me.rbFirstName = New System.Windows.Forms.RadioButton()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lbSort = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.gbSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(23, 35)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(23, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(23, 129)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 20)
        Me.txtDOB.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(456, 35)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 18
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(456, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 19
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtPassConfirm
        '
        Me.txtPassConfirm.Location = New System.Drawing.Point(456, 129)
        Me.txtPassConfirm.Name = "txtPassConfirm"
        Me.txtPassConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtPassConfirm.TabIndex = 20
        Me.txtPassConfirm.UseSystemPasswordChar = True
        '
        'lbFirstName
        '
        Me.lbFirstName.AutoSize = True
        Me.lbFirstName.Location = New System.Drawing.Point(20, 19)
        Me.lbFirstName.Name = "lbFirstName"
        Me.lbFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lbFirstName.TabIndex = 21
        Me.lbFirstName.Text = "First Name:"
        '
        'lbLastName
        '
        Me.lbLastName.AutoSize = True
        Me.lbLastName.Location = New System.Drawing.Point(20, 67)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(61, 13)
        Me.lbLastName.TabIndex = 22
        Me.lbLastName.Text = "Last Name:"
        '
        'lbDOB
        '
        Me.lbDOB.AutoSize = True
        Me.lbDOB.Location = New System.Drawing.Point(20, 113)
        Me.lbDOB.Name = "lbDOB"
        Me.lbDOB.Size = New System.Drawing.Size(69, 13)
        Me.lbDOB.TabIndex = 23
        Me.lbDOB.Text = "Date of Birth:"
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(453, 19)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(58, 13)
        Me.lbUsername.TabIndex = 25
        Me.lbUsername.Text = "Username:"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(453, 67)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(53, 13)
        Me.lbPassword.TabIndex = 26
        Me.lbPassword.Text = "Password"
        '
        'lbConfirmPass
        '
        Me.lbConfirmPass.AutoSize = True
        Me.lbConfirmPass.Location = New System.Drawing.Point(453, 113)
        Me.lbConfirmPass.Name = "lbConfirmPass"
        Me.lbConfirmPass.Size = New System.Drawing.Size(94, 13)
        Me.lbConfirmPass.TabIndex = 27
        Me.lbConfirmPass.Text = "Confirm Password:"
        '
        'lbFirstNameWarning
        '
        Me.lbFirstNameWarning.AutoSize = True
        Me.lbFirstNameWarning.ForeColor = System.Drawing.Color.Red
        Me.lbFirstNameWarning.Location = New System.Drawing.Point(130, 19)
        Me.lbFirstNameWarning.Name = "lbFirstNameWarning"
        Me.lbFirstNameWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbFirstNameWarning.TabIndex = 28
        '
        'lbLastNameWarning
        '
        Me.lbLastNameWarning.AutoSize = True
        Me.lbLastNameWarning.ForeColor = System.Drawing.Color.Red
        Me.lbLastNameWarning.Location = New System.Drawing.Point(130, 83)
        Me.lbLastNameWarning.Name = "lbLastNameWarning"
        Me.lbLastNameWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbLastNameWarning.TabIndex = 29
        '
        'lbDOBWarning
        '
        Me.lbDOBWarning.AutoSize = True
        Me.lbDOBWarning.ForeColor = System.Drawing.Color.Red
        Me.lbDOBWarning.Location = New System.Drawing.Point(130, 136)
        Me.lbDOBWarning.Name = "lbDOBWarning"
        Me.lbDOBWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbDOBWarning.TabIndex = 30
        '
        'lbUsernameWarning
        '
        Me.lbUsernameWarning.AutoSize = True
        Me.lbUsernameWarning.ForeColor = System.Drawing.Color.Red
        Me.lbUsernameWarning.Location = New System.Drawing.Point(562, 19)
        Me.lbUsernameWarning.Name = "lbUsernameWarning"
        Me.lbUsernameWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbUsernameWarning.TabIndex = 31
        '
        'lbPasswordWarning
        '
        Me.lbPasswordWarning.AutoSize = True
        Me.lbPasswordWarning.ForeColor = System.Drawing.Color.Red
        Me.lbPasswordWarning.Location = New System.Drawing.Point(562, 86)
        Me.lbPasswordWarning.Name = "lbPasswordWarning"
        Me.lbPasswordWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbPasswordWarning.TabIndex = 32
        '
        'lbConfirmPassWarning
        '
        Me.lbConfirmPassWarning.AutoSize = True
        Me.lbConfirmPassWarning.ForeColor = System.Drawing.Color.Red
        Me.lbConfirmPassWarning.Location = New System.Drawing.Point(562, 136)
        Me.lbConfirmPassWarning.Name = "lbConfirmPassWarning"
        Me.lbConfirmPassWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbConfirmPassWarning.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumBlue
        Me.btnSave.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Location = New System.Drawing.Point(300, 201)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 69)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save Teacher"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumBlue
        Me.btnEdit.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnEdit.Location = New System.Drawing.Point(381, 201)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 69)
        Me.btnEdit.TabIndex = 35
        Me.btnEdit.Text = "Edit Teacher"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(462, 201)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 69)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete Teacher"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(23, 531)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstTeachers
        '
        Me.lstTeachers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTeacherID, Me.colFirstName, Me.colLastName, Me.colDateOfBirth, Me.colUsername, Me.colPassword})
        Me.lstTeachers.Location = New System.Drawing.Point(72, 295)
        Me.lstTeachers.Name = "lstTeachers"
        Me.lstTeachers.Size = New System.Drawing.Size(605, 230)
        Me.lstTeachers.TabIndex = 43
        Me.lstTeachers.UseCompatibleStateImageBehavior = False
        '
        'colTeacherID
        '
        Me.colTeacherID.Text = "TeacherID"
        Me.colTeacherID.Width = 100
        '
        'colFirstName
        '
        Me.colFirstName.Text = "FirstName"
        Me.colFirstName.Width = 100
        '
        'colLastName
        '
        Me.colLastName.Text = "LastName"
        Me.colLastName.Width = 100
        '
        'colDateOfBirth
        '
        Me.colDateOfBirth.Text = "DateOfBirth"
        Me.colDateOfBirth.Width = 100
        '
        'colUsername
        '
        Me.colUsername.Text = "Username"
        Me.colUsername.Width = 100
        '
        'colPassword
        '
        Me.colPassword.Text = "Password"
        Me.colPassword.Width = 100
        '
        'gbSearch
        '
        Me.gbSearch.BackColor = System.Drawing.Color.Transparent
        Me.gbSearch.Controls.Add(Me.rbLastName)
        Me.gbSearch.Controls.Add(Me.rbFirstName)
        Me.gbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSearch.Location = New System.Drawing.Point(588, 219)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(148, 30)
        Me.gbSearch.TabIndex = 46
        Me.gbSearch.TabStop = False
        '
        'rbLastName
        '
        Me.rbLastName.AutoSize = True
        Me.rbLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.rbLastName.Location = New System.Drawing.Point(74, 9)
        Me.rbLastName.Name = "rbLastName"
        Me.rbLastName.Size = New System.Drawing.Size(72, 17)
        Me.rbLastName.TabIndex = 1
        Me.rbLastName.TabStop = True
        Me.rbLastName.Text = "LastName"
        Me.rbLastName.UseVisualStyleBackColor = True
        '
        'rbFirstName
        '
        Me.rbFirstName.AutoSize = True
        Me.rbFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.rbFirstName.Location = New System.Drawing.Point(6, 9)
        Me.rbFirstName.Name = "rbFirstName"
        Me.rbFirstName.Size = New System.Drawing.Size(71, 17)
        Me.rbFirstName.TabIndex = 0
        Me.rbFirstName.TabStop = True
        Me.rbFirstName.Text = "FirstName"
        Me.rbFirstName.UseVisualStyleBackColor = True
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(547, 236)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(41, 13)
        Me.lbSearch.TabIndex = 50
        Me.lbSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(547, 252)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 20)
        Me.txtSearch.TabIndex = 49
        '
        'lbSort
        '
        Me.lbSort.AutoSize = True
        Me.lbSort.Location = New System.Drawing.Point(547, 159)
        Me.lbSort.Name = "lbSort"
        Me.lbSort.Size = New System.Drawing.Size(26, 13)
        Me.lbSort.TabIndex = 48
        Me.lbSort.Text = "Sort"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"TeacherID (Ascending)", "TeacherID (Descending)", "FirstName (Ascending)", "FirstName (Descending)", "LastName (Ascending)", "LastName(Descending)", "DateOfBirth(Ascending)", "DateOfBirth(Descending)"})
        Me.cboSort.Location = New System.Drawing.Point(550, 175)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(165, 21)
        Me.cboSort.TabIndex = 47
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(710, 533)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 21)
        Me.btnHelp.TabIndex = 56
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 565)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbSort)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.lstTeachers)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbConfirmPassWarning)
        Me.Controls.Add(Me.lbPasswordWarning)
        Me.Controls.Add(Me.lbUsernameWarning)
        Me.Controls.Add(Me.lbDOBWarning)
        Me.Controls.Add(Me.lbLastNameWarning)
        Me.Controls.Add(Me.lbFirstNameWarning)
        Me.Controls.Add(Me.lbConfirmPass)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsername)
        Me.Controls.Add(Me.lbDOB)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lbFirstName)
        Me.Controls.Add(Me.txtPassConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Teachers"
        Me.Text = "Teachers"
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPassConfirm As TextBox
    Friend WithEvents lbFirstName As Label
    Friend WithEvents lbLastName As Label
    Friend WithEvents lbDOB As Label
    Friend WithEvents lbUsername As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents lbConfirmPass As Label
    Friend WithEvents lbFirstNameWarning As Label
    Friend WithEvents lbLastNameWarning As Label
    Friend WithEvents lbDOBWarning As Label
    Friend WithEvents lbUsernameWarning As Label
    Friend WithEvents lbPasswordWarning As Label
    Friend WithEvents lbConfirmPassWarning As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lstTeachers As ListView
    Friend WithEvents colTeacherID As ColumnHeader
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colLastName As ColumnHeader
    Friend WithEvents colDateOfBirth As ColumnHeader
    Friend WithEvents colUsername As ColumnHeader
    Friend WithEvents colPassword As ColumnHeader
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents rbLastName As RadioButton
    Friend WithEvents rbFirstName As RadioButton
    Friend WithEvents lbSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lbSort As Label
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents btnHelp As Button
End Class
