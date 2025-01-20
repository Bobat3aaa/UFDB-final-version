<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userdetails
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
        Me.lblusertitle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnchangedetails = New System.Windows.Forms.Button()
        Me.btndeleteaccount = New System.Windows.Forms.Button()
        Me.btnchangepassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblusertitle
        '
        Me.lblusertitle.AutoSize = True
        Me.lblusertitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusertitle.Location = New System.Drawing.Point(12, 19)
        Me.lblusertitle.Name = "lblusertitle"
        Me.lblusertitle.Size = New System.Drawing.Size(247, 55)
        Me.lblusertitle.TabIndex = 0
        Me.lblusertitle.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "username:"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(140, 155)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(178, 29)
        Me.txtage.TabIndex = 14
        '
        'Txtemail
        '
        Me.Txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtemail.Location = New System.Drawing.Point(140, 198)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(178, 29)
        Me.Txtemail.TabIndex = 13
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(140, 110)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(178, 29)
        Me.txtusername.TabIndex = 11
        '
        'btnchangedetails
        '
        Me.btnchangedetails.Location = New System.Drawing.Point(439, 96)
        Me.btnchangedetails.Name = "btnchangedetails"
        Me.btnchangedetails.Size = New System.Drawing.Size(320, 62)
        Me.btnchangedetails.TabIndex = 21
        Me.btnchangedetails.Text = "Change details"
        Me.btnchangedetails.UseVisualStyleBackColor = True
        '
        'btndeleteaccount
        '
        Me.btndeleteaccount.Location = New System.Drawing.Point(439, 233)
        Me.btndeleteaccount.Name = "btndeleteaccount"
        Me.btndeleteaccount.Size = New System.Drawing.Size(320, 62)
        Me.btndeleteaccount.TabIndex = 22
        Me.btndeleteaccount.Text = "Delete account"
        Me.btndeleteaccount.UseVisualStyleBackColor = True
        '
        'btnchangepassword
        '
        Me.btnchangepassword.Location = New System.Drawing.Point(439, 165)
        Me.btnchangepassword.Name = "btnchangepassword"
        Me.btnchangepassword.Size = New System.Drawing.Size(320, 62)
        Me.btnchangepassword.TabIndex = 23
        Me.btnchangepassword.Text = "Change password"
        Me.btnchangepassword.UseVisualStyleBackColor = True
        '
        'Userdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnchangepassword)
        Me.Controls.Add(Me.btndeleteaccount)
        Me.Controls.Add(Me.btnchangedetails)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Txtemail)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusertitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Userdetails"
        Me.Text = "Userdetailsform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblusertitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Txtemail As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnchangedetails As Button
    Friend WithEvents btndeleteaccount As Button
    Friend WithEvents btnchangepassword As Button
End Class
