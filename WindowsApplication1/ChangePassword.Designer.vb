<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbPassConfirmWarning = New System.Windows.Forms.Label()
        Me.lbPasswordWarning = New System.Windows.Forms.Label()
        Me.lbPassConfirm = New System.Windows.Forms.Label()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.txtPassConfirm = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbPassConfirmWarning
        '
        Me.lbPassConfirmWarning.AutoSize = True
        Me.lbPassConfirmWarning.ForeColor = System.Drawing.Color.Red
        Me.lbPassConfirmWarning.Location = New System.Drawing.Point(125, 82)
        Me.lbPassConfirmWarning.Name = "lbPassConfirmWarning"
        Me.lbPassConfirmWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbPassConfirmWarning.TabIndex = 39
        '
        'lbPasswordWarning
        '
        Me.lbPasswordWarning.AutoSize = True
        Me.lbPasswordWarning.ForeColor = System.Drawing.Color.Red
        Me.lbPasswordWarning.Location = New System.Drawing.Point(125, 32)
        Me.lbPasswordWarning.Name = "lbPasswordWarning"
        Me.lbPasswordWarning.Size = New System.Drawing.Size(0, 13)
        Me.lbPasswordWarning.TabIndex = 38
        '
        'lbPassConfirm
        '
        Me.lbPassConfirm.AutoSize = True
        Me.lbPassConfirm.Location = New System.Drawing.Point(16, 59)
        Me.lbPassConfirm.Name = "lbPassConfirm"
        Me.lbPassConfirm.Size = New System.Drawing.Size(94, 13)
        Me.lbPassConfirm.TabIndex = 37
        Me.lbPassConfirm.Text = "Confirm Password:"
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Location = New System.Drawing.Point(16, 13)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(53, 13)
        Me.lbPassword.TabIndex = 36
        Me.lbPassword.Text = "Password"
        '
        'txtPassConfirm
        '
        Me.txtPassConfirm.Location = New System.Drawing.Point(19, 75)
        Me.txtPassConfirm.Name = "txtPassConfirm"
        Me.txtPassConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtPassConfirm.TabIndex = 35
        Me.txtPassConfirm.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(19, 29)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 34
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(128, 159)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 194)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbPassConfirmWarning)
        Me.Controls.Add(Me.lbPasswordWarning)
        Me.Controls.Add(Me.lbPassConfirm)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.txtPassConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPassConfirmWarning As Label
    Friend WithEvents lbPasswordWarning As Label
    Friend WithEvents lbPassConfirm As Label
    Friend WithEvents lbPassword As Label
    Friend WithEvents txtPassConfirm As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSave As Button
End Class
