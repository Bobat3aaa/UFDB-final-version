<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usereditor
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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsavefile = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Datagridview = New System.Windows.Forms.DataGridView()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Txtage = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Checkadmin = New System.Windows.Forms.CheckBox()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(13, 150)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(205, 46)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnsavefile
        '
        Me.btnsavefile.Location = New System.Drawing.Point(579, 150)
        Me.btnsavefile.Name = "btnsavefile"
        Me.btnsavefile.Size = New System.Drawing.Size(205, 46)
        Me.btnsavefile.TabIndex = 6
        Me.btnsavefile.Text = "Save files"
        Me.btnsavefile.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(288, 150)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(205, 46)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Datagridview
        '
        Me.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview.Location = New System.Drawing.Point(12, 211)
        Me.Datagridview.Name = "Datagridview"
        Me.Datagridview.Size = New System.Drawing.Size(772, 408)
        Me.Datagridview.TabIndex = 8
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(6, 9)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(211, 42)
        Me.Lbltitle.TabIndex = 9
        Me.Lbltitle.Text = "User editor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "username:"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(74, 68)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(178, 20)
        Me.txtusername.TabIndex = 15
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(74, 94)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(178, 20)
        Me.txtpassword.TabIndex = 14
        '
        'Txtage
        '
        Me.Txtage.Location = New System.Drawing.Point(385, 68)
        Me.Txtage.Name = "Txtage"
        Me.Txtage.Size = New System.Drawing.Size(178, 20)
        Me.Txtage.TabIndex = 13
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(385, 93)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(178, 20)
        Me.txtemail.TabIndex = 12
        '
        'Checkadmin
        '
        Me.Checkadmin.AutoSize = True
        Me.Checkadmin.Location = New System.Drawing.Point(624, 70)
        Me.Checkadmin.Name = "Checkadmin"
        Me.Checkadmin.Size = New System.Drawing.Size(55, 17)
        Me.Checkadmin.TabIndex = 21
        Me.Checkadmin.Text = "Admin"
        Me.Checkadmin.UseVisualStyleBackColor = True
        '
        'Usereditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 631)
        Me.Controls.Add(Me.Checkadmin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Txtage)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.Datagridview)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsavefile)
        Me.Controls.Add(Me.btndelete)
        Me.Name = "Usereditor"
        Me.Text = "Usereditor"
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btnsavefile As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Datagridview As DataGridView
    Friend WithEvents Lbltitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Txtage As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Checkadmin As CheckBox
End Class
