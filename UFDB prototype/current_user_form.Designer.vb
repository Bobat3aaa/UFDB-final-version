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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnlikedfighters = New System.Windows.Forms.Button()
        Me.btnrankings = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(12, 22)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(118, 25)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(713, 12)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 1
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnlikedfighters
        '
        Me.btnlikedfighters.Location = New System.Drawing.Point(12, 104)
        Me.btnlikedfighters.Name = "btnlikedfighters"
        Me.btnlikedfighters.Size = New System.Drawing.Size(118, 248)
        Me.btnlikedfighters.TabIndex = 2
        Me.btnlikedfighters.Text = "liked fighters"
        Me.btnlikedfighters.UseVisualStyleBackColor = True
        '
        'btnrankings
        '
        Me.btnrankings.Location = New System.Drawing.Point(168, 104)
        Me.btnrankings.Name = "btnrankings"
        Me.btnrankings.Size = New System.Drawing.Size(118, 248)
        Me.btnrankings.TabIndex = 3
        Me.btnrankings.Text = "Rankings"
        Me.btnrankings.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(532, 101)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(118, 248)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "delete account"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(656, 101)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(118, 248)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'current_user_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnrankings)
        Me.Controls.Add(Me.btnlikedfighters)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "current_user_form"
        Me.Text = "current_user_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btnlikedfighters As Button
    Friend WithEvents btnrankings As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnlogout As Button
End Class
