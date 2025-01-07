<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Txtage = New System.Windows.Forms.TextBox()
        Me.txtpasswordagain = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.lblpasswordcheck = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(109, 164)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(178, 20)
        Me.txtusername.TabIndex = 0
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(109, 270)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(178, 20)
        Me.txtemail.TabIndex = 1
        '
        'Txtage
        '
        Me.Txtage.Location = New System.Drawing.Point(109, 244)
        Me.Txtage.Name = "Txtage"
        Me.Txtage.Size = New System.Drawing.Size(178, 20)
        Me.Txtage.TabIndex = 2
        '
        'txtpasswordagain
        '
        Me.txtpasswordagain.Location = New System.Drawing.Point(109, 218)
        Me.txtpasswordagain.Name = "txtpasswordagain"
        Me.txtpasswordagain.Size = New System.Drawing.Size(178, 20)
        Me.txtpasswordagain.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(109, 190)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(178, 20)
        Me.txtpassword.TabIndex = 4
        '
        'Btnregister
        '
        Me.Btnregister.Location = New System.Drawing.Point(123, 314)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(75, 23)
        Me.Btnregister.TabIndex = 5
        Me.Btnregister.Text = "register"
        Me.Btnregister.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "reenter password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Btnback)
        Me.Panel1.Location = New System.Drawing.Point(-4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 74)
        Me.Panel1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 55)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Register"
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.Color.Silver
        Me.Btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnback.Location = New System.Drawing.Point(655, 23)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(133, 33)
        Me.Btnback.TabIndex = 2
        Me.Btnback.Text = "back"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'lblpasswordcheck
        '
        Me.lblpasswordcheck.AutoSize = True
        Me.lblpasswordcheck.Location = New System.Drawing.Point(540, 164)
        Me.lblpasswordcheck.Name = "lblpasswordcheck"
        Me.lblpasswordcheck.Size = New System.Drawing.Size(108, 65)
        Me.lblpasswordcheck.TabIndex = 22
        Me.lblpasswordcheck.Text = "Password must have:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8-32 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 special characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 capital letters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 " &
    "number"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblpasswordcheck)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnregister)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtpasswordagain)
        Me.Controls.Add(Me.Txtage)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtusername)
        Me.Name = "register"
        Me.Text = "register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Txtage As TextBox
    Friend WithEvents txtpasswordagain As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Btnregister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Btnback As Button
    Friend WithEvents lblpasswordcheck As Label
End Class
