<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.gBoxLogin = New System.Windows.Forms.GroupBox()
        Me.lblAttempts = New System.Windows.Forms.Label()
        Me.gBoxLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(127, 61)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(74, 25)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "User ID:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(127, 112)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(91, 25)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Password:"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(248, 55)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(226, 31)
        Me.txtUserID.TabIndex = 2
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(248, 106)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(226, 31)
        Me.txtPW.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(270, 234)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(128, 50)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'gBoxLogin
        '
        Me.gBoxLogin.Controls.Add(Me.lblAttempts)
        Me.gBoxLogin.Controls.Add(Me.lblUserID)
        Me.gBoxLogin.Controls.Add(Me.txtUserID)
        Me.gBoxLogin.Controls.Add(Me.txtPW)
        Me.gBoxLogin.Controls.Add(Me.lblPass)
        Me.gBoxLogin.Location = New System.Drawing.Point(49, 41)
        Me.gBoxLogin.Name = "gBoxLogin"
        Me.gBoxLogin.Size = New System.Drawing.Size(569, 195)
        Me.gBoxLogin.TabIndex = 5
        Me.gBoxLogin.TabStop = False
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.Location = New System.Drawing.Point(248, 155)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(0, 25)
        Me.lblAttempts.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 305)
        Me.Controls.Add(Me.gBoxLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "Form1"
        Me.Text = "Login Portal"
        Me.gBoxLogin.ResumeLayout(False)
        Me.gBoxLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUserID As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents gBoxLogin As GroupBox
    Friend WithEvents lblAttempts As Label
End Class
