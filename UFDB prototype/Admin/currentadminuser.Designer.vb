<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currentadminuser
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
        Me.btnviewdatabase = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnuserdetails = New System.Windows.Forms.Button()
        Me.panelmain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btneditusers = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnviewdatabase
        '
        Me.btnviewdatabase.Location = New System.Drawing.Point(13, 127)
        Me.btnviewdatabase.Name = "btnviewdatabase"
        Me.btnviewdatabase.Size = New System.Drawing.Size(122, 38)
        Me.btnviewdatabase.TabIndex = 34
        Me.btnviewdatabase.Text = "Edit fights/fighter"
        Me.btnviewdatabase.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(14, 259)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(122, 38)
        Me.btnlogout.TabIndex = 32
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnuserdetails
        '
        Me.btnuserdetails.Location = New System.Drawing.Point(12, 171)
        Me.btnuserdetails.Name = "btnuserdetails"
        Me.btnuserdetails.Size = New System.Drawing.Size(122, 38)
        Me.btnuserdetails.TabIndex = 31
        Me.btnuserdetails.Text = "User Details"
        Me.btnuserdetails.UseVisualStyleBackColor = True
        '
        'panelmain
        '
        Me.panelmain.AutoSize = True
        Me.panelmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmain.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelmain.Location = New System.Drawing.Point(1046, 0)
        Me.panelmain.Name = "panelmain"
        Me.panelmain.Size = New System.Drawing.Size(2, 741)
        Me.panelmain.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 72)
        Me.Panel2.TabIndex = 28
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(12, 215)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(122, 38)
        Me.btnrefresh.TabIndex = 35
        Me.btnrefresh.Text = "Refresh API"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btneditusers
        '
        Me.btneditusers.Location = New System.Drawing.Point(14, 83)
        Me.btneditusers.Name = "btneditusers"
        Me.btneditusers.Size = New System.Drawing.Size(122, 38)
        Me.btneditusers.TabIndex = 36
        Me.btneditusers.Text = "Edit users"
        Me.btneditusers.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Halenoir-Black", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(-1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 77)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "UFDB"
        '
        'currentadminuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 741)
        Me.Controls.Add(Me.btneditusers)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnviewdatabase)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnuserdetails)
        Me.Controls.Add(Me.panelmain)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "currentadminuser"
        Me.Text = "currentadminuser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnviewdatabase As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnuserdetails As Button
    Friend WithEvents panelmain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btneditusers As Button
    Friend WithEvents Label6 As Label
End Class
