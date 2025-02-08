<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class current_user_form
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblhome = New System.Windows.Forms.Label()
        Me.panelmain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnmakeranking = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnuserdetails = New System.Windows.Forms.Button()
        Me.btnlikedfighters = New System.Windows.Forms.Button()
        Me.btnseerankings = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblhome)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1049, 72)
        Me.Panel2.TabIndex = 21
        '
        'lblhome
        '
        Me.lblhome.AutoSize = True
        Me.lblhome.Font = New System.Drawing.Font("Bahnschrift", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhome.ForeColor = System.Drawing.Color.Red
        Me.lblhome.Location = New System.Drawing.Point(-1, 0)
        Me.lblhome.Name = "lblhome"
        Me.lblhome.Size = New System.Drawing.Size(193, 77)
        Me.lblhome.TabIndex = 38
        Me.lblhome.Text = "UFDB"
        '
        'panelmain
        '
        Me.panelmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmain.Location = New System.Drawing.Point(238, 73)
        Me.panelmain.Name = "panelmain"
        Me.panelmain.Size = New System.Drawing.Size(812, 670)
        Me.panelmain.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.btnmakeranking)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnuserdetails)
        Me.Panel1.Controls.Add(Me.btnlikedfighters)
        Me.Panel1.Controls.Add(Me.btnseerankings)
        Me.Panel1.Location = New System.Drawing.Point(1, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 683)
        Me.Panel1.TabIndex = 45
        '
        'btnmakeranking
        '
        Me.btnmakeranking.BackColor = System.Drawing.Color.White
        Me.btnmakeranking.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmakeranking.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmakeranking.Location = New System.Drawing.Point(30, 292)
        Me.btnmakeranking.Name = "btnmakeranking"
        Me.btnmakeranking.Size = New System.Drawing.Size(179, 75)
        Me.btnmakeranking.TabIndex = 39
        Me.btnmakeranking.Text = "Make new ranking"
        Me.btnmakeranking.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.White
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(30, 582)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(179, 75)
        Me.btnlogout.TabIndex = 32
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnuserdetails
        '
        Me.btnuserdetails.BackColor = System.Drawing.Color.White
        Me.btnuserdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnuserdetails.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuserdetails.Location = New System.Drawing.Point(30, 437)
        Me.btnuserdetails.Name = "btnuserdetails"
        Me.btnuserdetails.Size = New System.Drawing.Size(179, 75)
        Me.btnuserdetails.TabIndex = 31
        Me.btnuserdetails.Text = "User Details"
        Me.btnuserdetails.UseVisualStyleBackColor = False
        '
        'btnlikedfighters
        '
        Me.btnlikedfighters.BackColor = System.Drawing.Color.White
        Me.btnlikedfighters.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlikedfighters.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlikedfighters.Location = New System.Drawing.Point(30, 7)
        Me.btnlikedfighters.Name = "btnlikedfighters"
        Me.btnlikedfighters.Size = New System.Drawing.Size(179, 75)
        Me.btnlikedfighters.TabIndex = 37
        Me.btnlikedfighters.Text = "Liked Fighters"
        Me.btnlikedfighters.UseVisualStyleBackColor = False
        '
        'btnseerankings
        '
        Me.btnseerankings.BackColor = System.Drawing.Color.White
        Me.btnseerankings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnseerankings.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseerankings.Location = New System.Drawing.Point(30, 150)
        Me.btnseerankings.Name = "btnseerankings"
        Me.btnseerankings.Size = New System.Drawing.Size(179, 75)
        Me.btnseerankings.TabIndex = 38
        Me.btnseerankings.Text = "See rankings"
        Me.btnseerankings.UseVisualStyleBackColor = False
        '
        'current_user_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1049, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelmain)
        Me.Name = "current_user_form"
        Me.Text = "current_user_form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelmain As Panel
    Friend WithEvents lblhome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnmakeranking As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnuserdetails As Button
    Friend WithEvents btnlikedfighters As Button
    Friend WithEvents btnseerankings As Button
End Class
