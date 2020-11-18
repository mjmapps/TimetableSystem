<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.lbSchool = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.rbTeacher = New System.Windows.Forms.RadioButton()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.gbType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbSchool
        '
        Me.lbSchool.AutoSize = True
        Me.lbSchool.BackColor = System.Drawing.Color.Transparent
        Me.lbSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSchool.ForeColor = System.Drawing.Color.AliceBlue
        Me.lbSchool.Location = New System.Drawing.Point(51, 21)
        Me.lbSchool.Name = "lbSchool"
        Me.lbSchool.Size = New System.Drawing.Size(396, 55)
        Me.lbSchool.TabIndex = 0
        Me.lbSchool.Text = "Quantum School"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(124, 132)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(237, 20)
        Me.txtUser.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(124, 168)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(237, 20)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnLogin.Location = New System.Drawing.Point(197, 206)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Location = New System.Drawing.Point(121, 116)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(55, 13)
        Me.lbUsername.TabIndex = 4
        Me.lbUsername.Text = "Username"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(121, 152)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(53, 13)
        Me.lbPassword.TabIndex = 5
        Me.lbPassword.Text = "Password"
        '
        'gbType
        '
        Me.gbType.BackColor = System.Drawing.Color.MistyRose
        Me.gbType.Controls.Add(Me.rbTeacher)
        Me.gbType.Controls.Add(Me.rbStudent)
        Me.gbType.Location = New System.Drawing.Point(155, 79)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(179, 34)
        Me.gbType.TabIndex = 6
        Me.gbType.TabStop = False
        '
        'rbTeacher
        '
        Me.rbTeacher.AutoSize = True
        Me.rbTeacher.Location = New System.Drawing.Point(103, 11)
        Me.rbTeacher.Name = "rbTeacher"
        Me.rbTeacher.Size = New System.Drawing.Size(65, 17)
        Me.rbTeacher.TabIndex = 1
        Me.rbTeacher.TabStop = True
        Me.rbTeacher.Text = "Teacher"
        Me.rbTeacher.UseVisualStyleBackColor = True
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Location = New System.Drawing.Point(7, 12)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(62, 17)
        Me.rbStudent.TabIndex = 0
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "Student"
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo1
        Me.ClientSize = New System.Drawing.Size(485, 325)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lbSchool)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.gbType.ResumeLayout(False)
        Me.gbType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbSchool As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lbUsername As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents gbType As GroupBox
    Friend WithEvents rbTeacher As RadioButton
    Friend WithEvents rbStudent As RadioButton
End Class
