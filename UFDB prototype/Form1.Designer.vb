<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btnfighter = New System.Windows.Forms.Button()
        Me.fights = New System.Windows.Forms.Button()
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.btnodds = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblhome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnfighter
        '
        Me.Btnfighter.BackColor = System.Drawing.Color.Silver
        Me.Btnfighter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnfighter.Font = New System.Drawing.Font("Clash Display", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfighter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Btnfighter.Location = New System.Drawing.Point(12, 193)
        Me.Btnfighter.Name = "Btnfighter"
        Me.Btnfighter.Size = New System.Drawing.Size(166, 236)
        Me.Btnfighter.TabIndex = 0
        Me.Btnfighter.Text = "fighter"
        Me.Btnfighter.UseVisualStyleBackColor = False
        '
        'fights
        '
        Me.fights.BackColor = System.Drawing.Color.Silver
        Me.fights.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.fights.Font = New System.Drawing.Font("Clash Display", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.fights.Location = New System.Drawing.Point(286, 193)
        Me.fights.Name = "fights"
        Me.fights.Size = New System.Drawing.Size(166, 236)
        Me.fights.TabIndex = 1
        Me.fights.Text = "fights"
        Me.fights.UseVisualStyleBackColor = False
        '
        'Btnregister
        '
        Me.Btnregister.BackColor = System.Drawing.Color.Silver
        Me.Btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnregister.Font = New System.Drawing.Font("Clash Display", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregister.Location = New System.Drawing.Point(874, 14)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(133, 45)
        Me.Btnregister.TabIndex = 2
        Me.Btnregister.Text = "register"
        Me.Btnregister.UseVisualStyleBackColor = False
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.Silver
        Me.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnlogin.Font = New System.Drawing.Font("Clash Display", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Btnlogin.Location = New System.Drawing.Point(841, 193)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(166, 236)
        Me.Btnlogin.TabIndex = 3
        Me.Btnlogin.Text = "User"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'btnodds
        '
        Me.btnodds.BackColor = System.Drawing.Color.Silver
        Me.btnodds.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnodds.Font = New System.Drawing.Font("Clash Display", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnodds.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnodds.Location = New System.Drawing.Point(557, 193)
        Me.btnodds.Name = "btnodds"
        Me.btnodds.Size = New System.Drawing.Size(166, 236)
        Me.btnodds.TabIndex = 4
        Me.btnodds.Text = "Fantasy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fight"
        Me.btnodds.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblhome)
        Me.Panel1.Controls.Add(Me.Btnregister)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 71)
        Me.Panel1.TabIndex = 5
        '
        'lblhome
        '
        Me.lblhome.AutoSize = True
        Me.lblhome.Font = New System.Drawing.Font("Halenoir-Black", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhome.ForeColor = System.Drawing.Color.Red
        Me.lblhome.Location = New System.Drawing.Point(-1, 0)
        Me.lblhome.Name = "lblhome"
        Me.lblhome.Size = New System.Drawing.Size(207, 77)
        Me.lblhome.TabIndex = 6
        Me.lblhome.Text = "UFDB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Clash Display", 47.99999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 73)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Home"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 472)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnodds)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.fights)
        Me.Controls.Add(Me.Btnfighter)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnfighter As Button
    Friend WithEvents fights As Button
    Friend WithEvents Btnregister As Button
    Friend WithEvents Btnlogin As Button
    Friend WithEvents btnodds As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblhome As Label
    Friend WithEvents Label2 As Label
End Class
