﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.LightGray
        Me.btnadd.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(208, 150)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(171, 46)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsavefile
        '
        Me.btnsavefile.BackColor = System.Drawing.Color.LightGray
        Me.btnsavefile.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavefile.Location = New System.Drawing.Point(613, 150)
        Me.btnsavefile.Name = "btnsavefile"
        Me.btnsavefile.Size = New System.Drawing.Size(171, 46)
        Me.btnsavefile.TabIndex = 6
        Me.btnsavefile.Text = "Save files"
        Me.btnsavefile.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightGray
        Me.btndelete.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(412, 150)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(171, 46)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
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
        Me.Lbltitle.Font = New System.Drawing.Font("Clash Display", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(6, 9)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(296, 55)
        Me.Lbltitle.TabIndex = 9
        Me.Lbltitle.Text = "User editor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "username:"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(114, 68)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(178, 28)
        Me.txtusername.TabIndex = 15
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(114, 103)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(178, 28)
        Me.txtpassword.TabIndex = 14
        '
        'Txtage
        '
        Me.Txtage.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtage.Location = New System.Drawing.Point(432, 69)
        Me.Txtage.Name = "Txtage"
        Me.Txtage.Size = New System.Drawing.Size(178, 28)
        Me.Txtage.TabIndex = 13
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(432, 103)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(178, 28)
        Me.txtemail.TabIndex = 12
        '
        'Checkadmin
        '
        Me.Checkadmin.AutoSize = True
        Me.Checkadmin.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkadmin.Location = New System.Drawing.Point(636, 69)
        Me.Checkadmin.Name = "Checkadmin"
        Me.Checkadmin.Size = New System.Drawing.Size(76, 22)
        Me.Checkadmin.TabIndex = 21
        Me.Checkadmin.Text = "Admin"
        Me.Checkadmin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 46)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Usereditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 631)
        Me.Controls.Add(Me.Button1)
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
        Me.Text = "Edit users"
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
    Friend WithEvents Button1 As Button
End Class
