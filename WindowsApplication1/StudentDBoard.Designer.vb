<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDBoard))
        Me.tabMenu = New System.Windows.Forms.TabControl()
        Me.tabTimetable = New System.Windows.Forms.TabPage()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbPeriod7 = New System.Windows.Forms.Label()
        Me.lbPeriod6 = New System.Windows.Forms.Label()
        Me.lbPeriod5 = New System.Windows.Forms.Label()
        Me.lbPeriod4 = New System.Windows.Forms.Label()
        Me.lbPeriod3 = New System.Windows.Forms.Label()
        Me.lbPeriod2 = New System.Windows.Forms.Label()
        Me.lbPeriod1 = New System.Windows.Forms.Label()
        Me.lbFriday = New System.Windows.Forms.Label()
        Me.lbThursday = New System.Windows.Forms.Label()
        Me.lbWednesday = New System.Windows.Forms.Label()
        Me.lbTuesday = New System.Windows.Forms.Label()
        Me.lbMonday = New System.Windows.Forms.Label()
        Me.tlpTimetable = New System.Windows.Forms.TableLayoutPanel()
        Me.lbFriP7 = New System.Windows.Forms.Label()
        Me.lbFriP6 = New System.Windows.Forms.Label()
        Me.lbFriP5 = New System.Windows.Forms.Label()
        Me.lbFriP4 = New System.Windows.Forms.Label()
        Me.lbFriP3 = New System.Windows.Forms.Label()
        Me.lbFriP2 = New System.Windows.Forms.Label()
        Me.lbFriP1 = New System.Windows.Forms.Label()
        Me.lbThuP7 = New System.Windows.Forms.Label()
        Me.lbThuP6 = New System.Windows.Forms.Label()
        Me.lbThuP5 = New System.Windows.Forms.Label()
        Me.lbThuP4 = New System.Windows.Forms.Label()
        Me.lbThuP3 = New System.Windows.Forms.Label()
        Me.lbThuP2 = New System.Windows.Forms.Label()
        Me.lbThuP1 = New System.Windows.Forms.Label()
        Me.lbWedP7 = New System.Windows.Forms.Label()
        Me.lbWedP6 = New System.Windows.Forms.Label()
        Me.lbWedP5 = New System.Windows.Forms.Label()
        Me.lbWedP4 = New System.Windows.Forms.Label()
        Me.lbWedP3 = New System.Windows.Forms.Label()
        Me.lbWedP2 = New System.Windows.Forms.Label()
        Me.lbWedP1 = New System.Windows.Forms.Label()
        Me.lbTueP7 = New System.Windows.Forms.Label()
        Me.lbTueP5 = New System.Windows.Forms.Label()
        Me.lbTueP4 = New System.Windows.Forms.Label()
        Me.lbTueP3 = New System.Windows.Forms.Label()
        Me.lbTueP2 = New System.Windows.Forms.Label()
        Me.lbTueP1 = New System.Windows.Forms.Label()
        Me.lbMonP5 = New System.Windows.Forms.Label()
        Me.lbMonP4 = New System.Windows.Forms.Label()
        Me.lbMonP1 = New System.Windows.Forms.Label()
        Me.lbMonP2 = New System.Windows.Forms.Label()
        Me.lbMonP3 = New System.Windows.Forms.Label()
        Me.lbMonP6 = New System.Windows.Forms.Label()
        Me.lbMonP7 = New System.Windows.Forms.Label()
        Me.lbTueP6 = New System.Windows.Forms.Label()
        Me.lbFilter = New System.Windows.Forms.Label()
        Me.chkFriday = New System.Windows.Forms.CheckBox()
        Me.chkThursday = New System.Windows.Forms.CheckBox()
        Me.chkWednesday = New System.Windows.Forms.CheckBox()
        Me.chkTuesday = New System.Windows.Forms.CheckBox()
        Me.chkMonday = New System.Windows.Forms.CheckBox()
        Me.lbDashboard = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pdocTimetable = New System.Drawing.Printing.PrintDocument()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.pdialogTimetable = New System.Windows.Forms.PrintDialog()
        Me.previewTimetable = New System.Windows.Forms.PrintPreviewDialog()
        Me.lbNumLessons = New System.Windows.Forms.Label()
        Me.tabMenu.SuspendLayout()
        Me.tabTimetable.SuspendLayout()
        Me.tlpTimetable.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMenu
        '
        Me.tabMenu.Controls.Add(Me.tabTimetable)
        Me.tabMenu.Location = New System.Drawing.Point(12, 67)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(715, 405)
        Me.tabMenu.TabIndex = 8
        '
        'tabTimetable
        '
        Me.tabTimetable.Controls.Add(Me.lbNumLessons)
        Me.tabTimetable.Controls.Add(Me.lbName)
        Me.tabTimetable.Controls.Add(Me.lbPeriod7)
        Me.tabTimetable.Controls.Add(Me.lbPeriod6)
        Me.tabTimetable.Controls.Add(Me.lbPeriod5)
        Me.tabTimetable.Controls.Add(Me.lbPeriod4)
        Me.tabTimetable.Controls.Add(Me.lbPeriod3)
        Me.tabTimetable.Controls.Add(Me.lbPeriod2)
        Me.tabTimetable.Controls.Add(Me.lbPeriod1)
        Me.tabTimetable.Controls.Add(Me.lbFriday)
        Me.tabTimetable.Controls.Add(Me.lbThursday)
        Me.tabTimetable.Controls.Add(Me.lbWednesday)
        Me.tabTimetable.Controls.Add(Me.lbTuesday)
        Me.tabTimetable.Controls.Add(Me.lbMonday)
        Me.tabTimetable.Controls.Add(Me.tlpTimetable)
        Me.tabTimetable.Controls.Add(Me.lbFilter)
        Me.tabTimetable.Controls.Add(Me.chkFriday)
        Me.tabTimetable.Controls.Add(Me.chkThursday)
        Me.tabTimetable.Controls.Add(Me.chkWednesday)
        Me.tabTimetable.Controls.Add(Me.chkTuesday)
        Me.tabTimetable.Controls.Add(Me.chkMonday)
        Me.tabTimetable.Location = New System.Drawing.Point(4, 22)
        Me.tabTimetable.Name = "tabTimetable"
        Me.tabTimetable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTimetable.Size = New System.Drawing.Size(707, 379)
        Me.tabTimetable.TabIndex = 0
        Me.tabTimetable.Text = "Timetable"
        Me.tabTimetable.UseVisualStyleBackColor = True
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(302, 10)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(0, 13)
        Me.lbName.TabIndex = 22
        '
        'lbPeriod7
        '
        Me.lbPeriod7.AutoSize = True
        Me.lbPeriod7.Location = New System.Drawing.Point(542, 43)
        Me.lbPeriod7.Name = "lbPeriod7"
        Me.lbPeriod7.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod7.TabIndex = 21
        Me.lbPeriod7.Text = "Period 7"
        '
        'lbPeriod6
        '
        Me.lbPeriod6.AutoSize = True
        Me.lbPeriod6.Location = New System.Drawing.Point(466, 43)
        Me.lbPeriod6.Name = "lbPeriod6"
        Me.lbPeriod6.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod6.TabIndex = 20
        Me.lbPeriod6.Text = "Period 6"
        '
        'lbPeriod5
        '
        Me.lbPeriod5.AutoSize = True
        Me.lbPeriod5.Location = New System.Drawing.Point(387, 43)
        Me.lbPeriod5.Name = "lbPeriod5"
        Me.lbPeriod5.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod5.TabIndex = 19
        Me.lbPeriod5.Text = "Period 5"
        '
        'lbPeriod4
        '
        Me.lbPeriod4.AutoSize = True
        Me.lbPeriod4.Location = New System.Drawing.Point(314, 43)
        Me.lbPeriod4.Name = "lbPeriod4"
        Me.lbPeriod4.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod4.TabIndex = 18
        Me.lbPeriod4.Text = "Period 4"
        '
        'lbPeriod3
        '
        Me.lbPeriod3.AutoSize = True
        Me.lbPeriod3.Location = New System.Drawing.Point(239, 43)
        Me.lbPeriod3.Name = "lbPeriod3"
        Me.lbPeriod3.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod3.TabIndex = 17
        Me.lbPeriod3.Text = "Period 3"
        '
        'lbPeriod2
        '
        Me.lbPeriod2.AutoSize = True
        Me.lbPeriod2.Location = New System.Drawing.Point(161, 43)
        Me.lbPeriod2.Name = "lbPeriod2"
        Me.lbPeriod2.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod2.TabIndex = 16
        Me.lbPeriod2.Text = "Period 2"
        '
        'lbPeriod1
        '
        Me.lbPeriod1.AutoSize = True
        Me.lbPeriod1.Location = New System.Drawing.Point(86, 43)
        Me.lbPeriod1.Name = "lbPeriod1"
        Me.lbPeriod1.Size = New System.Drawing.Size(46, 13)
        Me.lbPeriod1.TabIndex = 15
        Me.lbPeriod1.Text = "Period 1"
        '
        'lbFriday
        '
        Me.lbFriday.AutoSize = True
        Me.lbFriday.Location = New System.Drawing.Point(37, 307)
        Me.lbFriday.Name = "lbFriday"
        Me.lbFriday.Size = New System.Drawing.Size(35, 13)
        Me.lbFriday.TabIndex = 14
        Me.lbFriday.Text = "Friday"
        '
        'lbThursday
        '
        Me.lbThursday.AutoSize = True
        Me.lbThursday.Location = New System.Drawing.Point(21, 252)
        Me.lbThursday.Name = "lbThursday"
        Me.lbThursday.Size = New System.Drawing.Size(51, 13)
        Me.lbThursday.TabIndex = 13
        Me.lbThursday.Text = "Thursday"
        '
        'lbWednesday
        '
        Me.lbWednesday.AutoSize = True
        Me.lbWednesday.Location = New System.Drawing.Point(8, 196)
        Me.lbWednesday.Name = "lbWednesday"
        Me.lbWednesday.Size = New System.Drawing.Size(64, 13)
        Me.lbWednesday.TabIndex = 12
        Me.lbWednesday.Text = "Wednseday"
        '
        'lbTuesday
        '
        Me.lbTuesday.AutoSize = True
        Me.lbTuesday.Location = New System.Drawing.Point(24, 140)
        Me.lbTuesday.Name = "lbTuesday"
        Me.lbTuesday.Size = New System.Drawing.Size(48, 13)
        Me.lbTuesday.TabIndex = 11
        Me.lbTuesday.Text = "Tuesday"
        '
        'lbMonday
        '
        Me.lbMonday.AutoSize = True
        Me.lbMonday.Location = New System.Drawing.Point(27, 86)
        Me.lbMonday.Name = "lbMonday"
        Me.lbMonday.Size = New System.Drawing.Size(45, 13)
        Me.lbMonday.TabIndex = 10
        Me.lbMonday.Text = "Monday"
        '
        'tlpTimetable
        '
        Me.tlpTimetable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpTimetable.ColumnCount = 7
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlpTimetable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlpTimetable.Controls.Add(Me.lbFriP7, 6, 4)
        Me.tlpTimetable.Controls.Add(Me.lbFriP6, 5, 4)
        Me.tlpTimetable.Controls.Add(Me.lbFriP5, 4, 4)
        Me.tlpTimetable.Controls.Add(Me.lbFriP4, 3, 4)
        Me.tlpTimetable.Controls.Add(Me.lbFriP3, 2, 4)
        Me.tlpTimetable.Controls.Add(Me.lbFriP2, 1, 4)
        Me.tlpTimetable.Controls.Add(Me.lbFriP1, 0, 4)
        Me.tlpTimetable.Controls.Add(Me.lbThuP7, 6, 3)
        Me.tlpTimetable.Controls.Add(Me.lbThuP6, 5, 3)
        Me.tlpTimetable.Controls.Add(Me.lbThuP5, 4, 3)
        Me.tlpTimetable.Controls.Add(Me.lbThuP4, 3, 3)
        Me.tlpTimetable.Controls.Add(Me.lbThuP3, 2, 3)
        Me.tlpTimetable.Controls.Add(Me.lbThuP2, 1, 3)
        Me.tlpTimetable.Controls.Add(Me.lbThuP1, 0, 3)
        Me.tlpTimetable.Controls.Add(Me.lbWedP7, 6, 2)
        Me.tlpTimetable.Controls.Add(Me.lbWedP6, 5, 2)
        Me.tlpTimetable.Controls.Add(Me.lbWedP5, 4, 2)
        Me.tlpTimetable.Controls.Add(Me.lbWedP4, 3, 2)
        Me.tlpTimetable.Controls.Add(Me.lbWedP3, 2, 2)
        Me.tlpTimetable.Controls.Add(Me.lbWedP2, 1, 2)
        Me.tlpTimetable.Controls.Add(Me.lbWedP1, 0, 2)
        Me.tlpTimetable.Controls.Add(Me.lbTueP7, 6, 1)
        Me.tlpTimetable.Controls.Add(Me.lbTueP5, 4, 1)
        Me.tlpTimetable.Controls.Add(Me.lbTueP4, 3, 1)
        Me.tlpTimetable.Controls.Add(Me.lbTueP3, 2, 1)
        Me.tlpTimetable.Controls.Add(Me.lbTueP2, 1, 1)
        Me.tlpTimetable.Controls.Add(Me.lbTueP1, 0, 1)
        Me.tlpTimetable.Controls.Add(Me.lbMonP5, 4, 0)
        Me.tlpTimetable.Controls.Add(Me.lbMonP4, 3, 0)
        Me.tlpTimetable.Controls.Add(Me.lbMonP1, 0, 0)
        Me.tlpTimetable.Controls.Add(Me.lbMonP2, 1, 0)
        Me.tlpTimetable.Controls.Add(Me.lbMonP3, 2, 0)
        Me.tlpTimetable.Controls.Add(Me.lbMonP6, 5, 0)
        Me.tlpTimetable.Controls.Add(Me.lbMonP7, 6, 0)
        Me.tlpTimetable.Controls.Add(Me.lbTueP6, 5, 1)
        Me.tlpTimetable.Location = New System.Drawing.Point(72, 59)
        Me.tlpTimetable.Name = "tlpTimetable"
        Me.tlpTimetable.Padding = New System.Windows.Forms.Padding(1)
        Me.tlpTimetable.RowCount = 5
        Me.tlpTimetable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpTimetable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpTimetable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpTimetable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpTimetable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpTimetable.Size = New System.Drawing.Size(533, 284)
        Me.tlpTimetable.TabIndex = 9
        '
        'lbFriP7
        '
        Me.lbFriP7.AutoSize = True
        Me.lbFriP7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP7.Location = New System.Drawing.Point(455, 226)
        Me.lbFriP7.Name = "lbFriP7"
        Me.lbFriP7.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP7.TabIndex = 22
        Me.lbFriP7.Text = "-"
        '
        'lbFriP6
        '
        Me.lbFriP6.AutoSize = True
        Me.lbFriP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP6.Location = New System.Drawing.Point(380, 226)
        Me.lbFriP6.Name = "lbFriP6"
        Me.lbFriP6.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP6.TabIndex = 22
        Me.lbFriP6.Text = "-"
        '
        'lbFriP5
        '
        Me.lbFriP5.AutoSize = True
        Me.lbFriP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP5.Location = New System.Drawing.Point(305, 226)
        Me.lbFriP5.Name = "lbFriP5"
        Me.lbFriP5.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP5.TabIndex = 22
        Me.lbFriP5.Text = "-"
        '
        'lbFriP4
        '
        Me.lbFriP4.AutoSize = True
        Me.lbFriP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP4.Location = New System.Drawing.Point(230, 226)
        Me.lbFriP4.Name = "lbFriP4"
        Me.lbFriP4.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP4.TabIndex = 22
        Me.lbFriP4.Text = "-"
        '
        'lbFriP3
        '
        Me.lbFriP3.AutoSize = True
        Me.lbFriP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP3.Location = New System.Drawing.Point(155, 226)
        Me.lbFriP3.Name = "lbFriP3"
        Me.lbFriP3.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP3.TabIndex = 22
        Me.lbFriP3.Text = "-"
        '
        'lbFriP2
        '
        Me.lbFriP2.AutoSize = True
        Me.lbFriP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP2.Location = New System.Drawing.Point(80, 226)
        Me.lbFriP2.Name = "lbFriP2"
        Me.lbFriP2.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP2.TabIndex = 22
        Me.lbFriP2.Text = "-"
        '
        'lbFriP1
        '
        Me.lbFriP1.AutoSize = True
        Me.lbFriP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbFriP1.Location = New System.Drawing.Point(5, 226)
        Me.lbFriP1.Name = "lbFriP1"
        Me.lbFriP1.Size = New System.Drawing.Size(10, 13)
        Me.lbFriP1.TabIndex = 22
        Me.lbFriP1.Text = "-"
        '
        'lbThuP7
        '
        Me.lbThuP7.AutoSize = True
        Me.lbThuP7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP7.Location = New System.Drawing.Point(455, 170)
        Me.lbThuP7.Name = "lbThuP7"
        Me.lbThuP7.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP7.TabIndex = 22
        Me.lbThuP7.Text = "-"
        '
        'lbThuP6
        '
        Me.lbThuP6.AutoSize = True
        Me.lbThuP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP6.Location = New System.Drawing.Point(380, 170)
        Me.lbThuP6.Name = "lbThuP6"
        Me.lbThuP6.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP6.TabIndex = 22
        Me.lbThuP6.Text = "-"
        '
        'lbThuP5
        '
        Me.lbThuP5.AutoSize = True
        Me.lbThuP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP5.Location = New System.Drawing.Point(305, 170)
        Me.lbThuP5.Name = "lbThuP5"
        Me.lbThuP5.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP5.TabIndex = 22
        Me.lbThuP5.Text = "-"
        '
        'lbThuP4
        '
        Me.lbThuP4.AutoSize = True
        Me.lbThuP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP4.Location = New System.Drawing.Point(230, 170)
        Me.lbThuP4.Name = "lbThuP4"
        Me.lbThuP4.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP4.TabIndex = 22
        Me.lbThuP4.Text = "-"
        '
        'lbThuP3
        '
        Me.lbThuP3.AutoSize = True
        Me.lbThuP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP3.Location = New System.Drawing.Point(155, 170)
        Me.lbThuP3.Name = "lbThuP3"
        Me.lbThuP3.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP3.TabIndex = 22
        Me.lbThuP3.Text = "-"
        '
        'lbThuP2
        '
        Me.lbThuP2.AutoSize = True
        Me.lbThuP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP2.Location = New System.Drawing.Point(80, 170)
        Me.lbThuP2.Name = "lbThuP2"
        Me.lbThuP2.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP2.TabIndex = 22
        Me.lbThuP2.Text = "-"
        '
        'lbThuP1
        '
        Me.lbThuP1.AutoSize = True
        Me.lbThuP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbThuP1.Location = New System.Drawing.Point(5, 170)
        Me.lbThuP1.Name = "lbThuP1"
        Me.lbThuP1.Size = New System.Drawing.Size(10, 13)
        Me.lbThuP1.TabIndex = 22
        Me.lbThuP1.Text = "-"
        '
        'lbWedP7
        '
        Me.lbWedP7.AutoSize = True
        Me.lbWedP7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP7.Location = New System.Drawing.Point(455, 114)
        Me.lbWedP7.Name = "lbWedP7"
        Me.lbWedP7.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP7.TabIndex = 22
        Me.lbWedP7.Text = "-"
        '
        'lbWedP6
        '
        Me.lbWedP6.AutoSize = True
        Me.lbWedP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP6.Location = New System.Drawing.Point(380, 114)
        Me.lbWedP6.Name = "lbWedP6"
        Me.lbWedP6.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP6.TabIndex = 22
        Me.lbWedP6.Text = "-"
        '
        'lbWedP5
        '
        Me.lbWedP5.AutoSize = True
        Me.lbWedP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP5.Location = New System.Drawing.Point(305, 114)
        Me.lbWedP5.Name = "lbWedP5"
        Me.lbWedP5.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP5.TabIndex = 22
        Me.lbWedP5.Text = "-"
        '
        'lbWedP4
        '
        Me.lbWedP4.AutoSize = True
        Me.lbWedP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP4.Location = New System.Drawing.Point(230, 114)
        Me.lbWedP4.Name = "lbWedP4"
        Me.lbWedP4.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP4.TabIndex = 22
        Me.lbWedP4.Text = "-"
        '
        'lbWedP3
        '
        Me.lbWedP3.AutoSize = True
        Me.lbWedP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP3.Location = New System.Drawing.Point(155, 114)
        Me.lbWedP3.Name = "lbWedP3"
        Me.lbWedP3.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP3.TabIndex = 22
        Me.lbWedP3.Text = "-"
        '
        'lbWedP2
        '
        Me.lbWedP2.AutoSize = True
        Me.lbWedP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP2.Location = New System.Drawing.Point(80, 114)
        Me.lbWedP2.Name = "lbWedP2"
        Me.lbWedP2.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP2.TabIndex = 22
        Me.lbWedP2.Text = "-"
        '
        'lbWedP1
        '
        Me.lbWedP1.AutoSize = True
        Me.lbWedP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbWedP1.Location = New System.Drawing.Point(5, 114)
        Me.lbWedP1.Name = "lbWedP1"
        Me.lbWedP1.Size = New System.Drawing.Size(10, 13)
        Me.lbWedP1.TabIndex = 22
        Me.lbWedP1.Text = "-"
        '
        'lbTueP7
        '
        Me.lbTueP7.AutoSize = True
        Me.lbTueP7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP7.Location = New System.Drawing.Point(455, 58)
        Me.lbTueP7.Name = "lbTueP7"
        Me.lbTueP7.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP7.TabIndex = 22
        Me.lbTueP7.Text = "-"
        '
        'lbTueP5
        '
        Me.lbTueP5.AutoSize = True
        Me.lbTueP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP5.Location = New System.Drawing.Point(305, 58)
        Me.lbTueP5.Name = "lbTueP5"
        Me.lbTueP5.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP5.TabIndex = 22
        Me.lbTueP5.Text = "-"
        '
        'lbTueP4
        '
        Me.lbTueP4.AutoSize = True
        Me.lbTueP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP4.Location = New System.Drawing.Point(230, 58)
        Me.lbTueP4.Name = "lbTueP4"
        Me.lbTueP4.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP4.TabIndex = 22
        Me.lbTueP4.Text = "-"
        '
        'lbTueP3
        '
        Me.lbTueP3.AutoSize = True
        Me.lbTueP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP3.Location = New System.Drawing.Point(155, 58)
        Me.lbTueP3.Name = "lbTueP3"
        Me.lbTueP3.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP3.TabIndex = 24
        Me.lbTueP3.Text = "-"
        '
        'lbTueP2
        '
        Me.lbTueP2.AutoSize = True
        Me.lbTueP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP2.Location = New System.Drawing.Point(80, 58)
        Me.lbTueP2.Name = "lbTueP2"
        Me.lbTueP2.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP2.TabIndex = 22
        Me.lbTueP2.Text = "-"
        '
        'lbTueP1
        '
        Me.lbTueP1.AutoSize = True
        Me.lbTueP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP1.Location = New System.Drawing.Point(5, 58)
        Me.lbTueP1.Name = "lbTueP1"
        Me.lbTueP1.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP1.TabIndex = 22
        Me.lbTueP1.Text = "-"
        '
        'lbMonP5
        '
        Me.lbMonP5.AutoSize = True
        Me.lbMonP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP5.Location = New System.Drawing.Point(305, 2)
        Me.lbMonP5.Name = "lbMonP5"
        Me.lbMonP5.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP5.TabIndex = 22
        Me.lbMonP5.Text = "-"
        '
        'lbMonP4
        '
        Me.lbMonP4.AutoSize = True
        Me.lbMonP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP4.Location = New System.Drawing.Point(230, 2)
        Me.lbMonP4.Name = "lbMonP4"
        Me.lbMonP4.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP4.TabIndex = 3
        Me.lbMonP4.Text = "-"
        '
        'lbMonP1
        '
        Me.lbMonP1.AutoSize = True
        Me.lbMonP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP1.Location = New System.Drawing.Point(5, 2)
        Me.lbMonP1.Name = "lbMonP1"
        Me.lbMonP1.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP1.TabIndex = 0
        Me.lbMonP1.Text = "-"
        '
        'lbMonP2
        '
        Me.lbMonP2.AutoSize = True
        Me.lbMonP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP2.Location = New System.Drawing.Point(80, 2)
        Me.lbMonP2.Name = "lbMonP2"
        Me.lbMonP2.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP2.TabIndex = 1
        Me.lbMonP2.Text = "-"
        '
        'lbMonP3
        '
        Me.lbMonP3.AutoSize = True
        Me.lbMonP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP3.Location = New System.Drawing.Point(155, 2)
        Me.lbMonP3.Name = "lbMonP3"
        Me.lbMonP3.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP3.TabIndex = 2
        Me.lbMonP3.Text = "-"
        '
        'lbMonP6
        '
        Me.lbMonP6.AutoSize = True
        Me.lbMonP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP6.Location = New System.Drawing.Point(380, 2)
        Me.lbMonP6.Name = "lbMonP6"
        Me.lbMonP6.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP6.TabIndex = 22
        Me.lbMonP6.Text = "-"
        '
        'lbMonP7
        '
        Me.lbMonP7.AutoSize = True
        Me.lbMonP7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbMonP7.Location = New System.Drawing.Point(455, 2)
        Me.lbMonP7.Name = "lbMonP7"
        Me.lbMonP7.Size = New System.Drawing.Size(10, 13)
        Me.lbMonP7.TabIndex = 23
        Me.lbMonP7.Text = "-"
        '
        'lbTueP6
        '
        Me.lbTueP6.AutoSize = True
        Me.lbTueP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.lbTueP6.Location = New System.Drawing.Point(380, 58)
        Me.lbTueP6.Name = "lbTueP6"
        Me.lbTueP6.Size = New System.Drawing.Size(10, 13)
        Me.lbTueP6.TabIndex = 22
        Me.lbTueP6.Text = "-"
        '
        'lbFilter
        '
        Me.lbFilter.AutoSize = True
        Me.lbFilter.Location = New System.Drawing.Point(608, 10)
        Me.lbFilter.Name = "lbFilter"
        Me.lbFilter.Size = New System.Drawing.Size(29, 13)
        Me.lbFilter.TabIndex = 8
        Me.lbFilter.Text = "Filter"
        '
        'chkFriday
        '
        Me.chkFriday.AutoSize = True
        Me.chkFriday.Checked = True
        Me.chkFriday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFriday.Location = New System.Drawing.Point(611, 118)
        Me.chkFriday.Name = "chkFriday"
        Me.chkFriday.Size = New System.Drawing.Size(54, 17)
        Me.chkFriday.TabIndex = 7
        Me.chkFriday.Text = "Friday"
        Me.chkFriday.UseVisualStyleBackColor = True
        '
        'chkThursday
        '
        Me.chkThursday.AutoSize = True
        Me.chkThursday.Checked = True
        Me.chkThursday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkThursday.Location = New System.Drawing.Point(611, 95)
        Me.chkThursday.Name = "chkThursday"
        Me.chkThursday.Size = New System.Drawing.Size(70, 17)
        Me.chkThursday.TabIndex = 6
        Me.chkThursday.Text = "Thursday"
        Me.chkThursday.UseVisualStyleBackColor = True
        '
        'chkWednesday
        '
        Me.chkWednesday.AutoSize = True
        Me.chkWednesday.Checked = True
        Me.chkWednesday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWednesday.Location = New System.Drawing.Point(611, 72)
        Me.chkWednesday.Name = "chkWednesday"
        Me.chkWednesday.Size = New System.Drawing.Size(83, 17)
        Me.chkWednesday.TabIndex = 5
        Me.chkWednesday.Text = "Wednesday"
        Me.chkWednesday.UseVisualStyleBackColor = True
        '
        'chkTuesday
        '
        Me.chkTuesday.AutoSize = True
        Me.chkTuesday.Checked = True
        Me.chkTuesday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTuesday.Location = New System.Drawing.Point(611, 49)
        Me.chkTuesday.Name = "chkTuesday"
        Me.chkTuesday.Size = New System.Drawing.Size(67, 17)
        Me.chkTuesday.TabIndex = 4
        Me.chkTuesday.Text = "Tuesday"
        Me.chkTuesday.UseVisualStyleBackColor = True
        '
        'chkMonday
        '
        Me.chkMonday.AutoSize = True
        Me.chkMonday.Checked = True
        Me.chkMonday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMonday.Location = New System.Drawing.Point(611, 26)
        Me.chkMonday.Name = "chkMonday"
        Me.chkMonday.Size = New System.Drawing.Size(64, 17)
        Me.chkMonday.TabIndex = 3
        Me.chkMonday.Text = "Monday"
        Me.chkMonday.UseVisualStyleBackColor = True
        '
        'lbDashboard
        '
        Me.lbDashboard.AutoSize = True
        Me.lbDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDashboard.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbDashboard.Location = New System.Drawing.Point(223, 9)
        Me.lbDashboard.Name = "lbDashboard"
        Me.lbDashboard.Size = New System.Drawing.Size(270, 55)
        Me.lbDashboard.TabIndex = 9
        Me.lbDashboard.Text = "Dashboard"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(321, 478)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 23)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'pdocTimetable
        '
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(611, 478)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(112, 23)
        Me.btnChangePass.TabIndex = 15
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'pdialogTimetable
        '
        Me.pdialogTimetable.Document = Me.pdocTimetable
        Me.pdialogTimetable.UseEXDialog = True
        '
        'previewTimetable
        '
        Me.previewTimetable.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.previewTimetable.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.previewTimetable.ClientSize = New System.Drawing.Size(400, 300)
        Me.previewTimetable.Document = Me.pdocTimetable
        Me.previewTimetable.Enabled = True
        Me.previewTimetable.Icon = CType(resources.GetObject("previewTimetable.Icon"), System.Drawing.Icon)
        Me.previewTimetable.Name = "previewTimetable"
        Me.previewTimetable.Visible = False
        '
        'lbNumLessons
        '
        Me.lbNumLessons.AutoSize = True
        Me.lbNumLessons.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbNumLessons.Location = New System.Drawing.Point(611, 140)
        Me.lbNumLessons.Name = "lbNumLessons"
        Me.lbNumLessons.Size = New System.Drawing.Size(56, 26)
        Me.lbNumLessons.TabIndex = 24
        Me.lbNumLessons.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lessons:"
        '
        'StudentDBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 510)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lbDashboard)
        Me.Controls.Add(Me.tabMenu)
        Me.Name = "StudentDBoard"
        Me.Text = "StudentDBoard"
        Me.tabMenu.ResumeLayout(False)
        Me.tabTimetable.ResumeLayout(False)
        Me.tabTimetable.PerformLayout()
        Me.tlpTimetable.ResumeLayout(False)
        Me.tlpTimetable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabMenu As TabControl
    Friend WithEvents tabTimetable As TabPage
    Friend WithEvents chkFriday As CheckBox
    Friend WithEvents chkThursday As CheckBox
    Friend WithEvents chkWednesday As CheckBox
    Friend WithEvents chkTuesday As CheckBox
    Friend WithEvents chkMonday As CheckBox
    Friend WithEvents lbDashboard As Label
    Friend WithEvents lbFilter As Label
    Friend WithEvents lbPeriod7 As Label
    Friend WithEvents lbPeriod6 As Label
    Friend WithEvents lbPeriod5 As Label
    Friend WithEvents lbPeriod4 As Label
    Friend WithEvents lbPeriod3 As Label
    Friend WithEvents lbPeriod2 As Label
    Friend WithEvents lbPeriod1 As Label
    Friend WithEvents lbFriday As Label
    Friend WithEvents lbThursday As Label
    Friend WithEvents lbWednesday As Label
    Friend WithEvents lbTuesday As Label
    Friend WithEvents lbMonday As Label
    Friend WithEvents tlpTimetable As TableLayoutPanel
    Friend WithEvents lbMonP1 As Label
    Friend WithEvents lbMonP2 As Label
    Friend WithEvents lbMonP5 As Label
    Friend WithEvents lbMonP4 As Label
    Friend WithEvents lbMonP3 As Label
    Friend WithEvents lbMonP6 As Label
    Friend WithEvents lbFriP7 As Label
    Friend WithEvents lbFriP6 As Label
    Friend WithEvents lbFriP5 As Label
    Friend WithEvents lbFriP4 As Label
    Friend WithEvents lbFriP3 As Label
    Friend WithEvents lbFriP2 As Label
    Friend WithEvents lbFriP1 As Label
    Friend WithEvents lbThuP7 As Label
    Friend WithEvents lbThuP6 As Label
    Friend WithEvents lbThuP5 As Label
    Friend WithEvents lbThuP4 As Label
    Friend WithEvents lbThuP3 As Label
    Friend WithEvents lbThuP2 As Label
    Friend WithEvents lbThuP1 As Label
    Friend WithEvents lbWedP7 As Label
    Friend WithEvents lbWedP6 As Label
    Friend WithEvents lbWedP5 As Label
    Friend WithEvents lbWedP4 As Label
    Friend WithEvents lbWedP3 As Label
    Friend WithEvents lbWedP2 As Label
    Friend WithEvents lbWedP1 As Label
    Friend WithEvents lbTueP7 As Label
    Friend WithEvents lbTueP5 As Label
    Friend WithEvents lbTueP4 As Label
    Friend WithEvents lbTueP3 As Label
    Friend WithEvents lbTueP2 As Label
    Friend WithEvents lbTueP1 As Label
    Friend WithEvents lbMonP7 As Label
    Friend WithEvents lbTueP6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents pdocTimetable As Printing.PrintDocument
    Friend WithEvents lbName As Label
    Friend WithEvents btnChangePass As Button
    Friend WithEvents pdialogTimetable As PrintDialog
    Friend WithEvents previewTimetable As PrintPreviewDialog
    Friend WithEvents lbNumLessons As Label
End Class
