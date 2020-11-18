<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subjects
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
        Me.lstSubjects = New System.Windows.Forms.ListView()
        Me.colSubjectID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLevel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colExamBoard = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.lbSubject = New System.Windows.Forms.Label()
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.lbExamBoard = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboExamBoard = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.lbSort = New System.Windows.Forms.Label()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSubjects
        '
        Me.lstSubjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSubjectID, Me.colName, Me.colLevel, Me.colExamBoard})
        Me.lstSubjects.Location = New System.Drawing.Point(12, 57)
        Me.lstSubjects.Name = "lstSubjects"
        Me.lstSubjects.Size = New System.Drawing.Size(365, 186)
        Me.lstSubjects.TabIndex = 1
        Me.lstSubjects.UseCompatibleStateImageBehavior = False
        '
        'colSubjectID
        '
        Me.colSubjectID.Text = "SubjectID"
        Me.colSubjectID.Width = 100
        '
        'colName
        '
        Me.colName.Text = "Subject"
        Me.colName.Width = 100
        '
        'colLevel
        '
        Me.colLevel.Text = "Level"
        '
        'colExamBoard
        '
        Me.colExamBoard.Text = "Exam Board"
        Me.colExamBoard.Width = 100
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(12, 31)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(97, 20)
        Me.txtSubject.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MediumBlue
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.Location = New System.Drawing.Point(90, 248)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 53)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"GCSE", "A Level"})
        Me.cboLevel.Location = New System.Drawing.Point(115, 29)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(77, 21)
        Me.cboLevel.TabIndex = 11
        '
        'lbSubject
        '
        Me.lbSubject.AutoSize = True
        Me.lbSubject.Location = New System.Drawing.Point(12, 13)
        Me.lbSubject.Name = "lbSubject"
        Me.lbSubject.Size = New System.Drawing.Size(43, 13)
        Me.lbSubject.TabIndex = 12
        Me.lbSubject.Text = "Subject"
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.Location = New System.Drawing.Point(112, 13)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(33, 13)
        Me.lbLevel.TabIndex = 13
        Me.lbLevel.Text = "Level"
        '
        'lbExamBoard
        '
        Me.lbExamBoard.AutoSize = True
        Me.lbExamBoard.Location = New System.Drawing.Point(195, 13)
        Me.lbExamBoard.Name = "lbExamBoard"
        Me.lbExamBoard.Size = New System.Drawing.Size(64, 13)
        Me.lbExamBoard.TabIndex = 14
        Me.lbExamBoard.Text = "Exam Board"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumBlue
        Me.btnSave.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Location = New System.Drawing.Point(152, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 53)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumBlue
        Me.btnDelete.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(214, 248)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 53)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cboExamBoard
        '
        Me.cboExamBoard.FormattingEnabled = True
        Me.cboExamBoard.Items.AddRange(New Object() {"Eduqas", "AQA", "OCR", "Edexcel"})
        Me.cboExamBoard.Location = New System.Drawing.Point(198, 29)
        Me.cboExamBoard.Name = "cboExamBoard"
        Me.cboExamBoard.Size = New System.Drawing.Size(86, 21)
        Me.cboExamBoard.TabIndex = 17
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(9, 279)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"Name (Ascending)", "Name (Descending)"})
        Me.cboSort.Location = New System.Drawing.Point(290, 29)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(107, 21)
        Me.cboSort.TabIndex = 43
        '
        'lbSort
        '
        Me.lbSort.AutoSize = True
        Me.lbSort.Location = New System.Drawing.Point(287, 13)
        Me.lbSort.Name = "lbSort"
        Me.lbSort.Size = New System.Drawing.Size(26, 13)
        Me.lbSort.TabIndex = 44
        Me.lbSort.Text = "Sort"
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(276, 263)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(41, 13)
        Me.lbSearch.TabIndex = 47
        Me.lbSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(276, 279)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtSearch.TabIndex = 46
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(15, 252)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 21)
        Me.btnHelp.TabIndex = 56
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 313)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbSort)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cboExamBoard)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbExamBoard)
        Me.Controls.Add(Me.lbLevel)
        Me.Controls.Add(Me.lbSubject)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lstSubjects)
        Me.Name = "Subjects"
        Me.Text = "Subjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSubjects As ListView
    Friend WithEvents colSubjectID As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colLevel As ColumnHeader
    Friend WithEvents colExamBoard As ColumnHeader
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents lbSubject As Label
    Friend WithEvents lbLevel As Label
    Friend WithEvents lbExamBoard As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboExamBoard As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents lbSort As Label
    Friend WithEvents lbSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnHelp As Button
End Class
