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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelmain = New System.Windows.Forms.Panel()
        Me.btnlikedfighters = New System.Windows.Forms.Button()
        Me.btnuserdetails = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnranking = New System.Windows.Forms.Button()
        Me.btnnewranking = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica Neue", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 54)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "UFDB"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 72)
        Me.Panel2.TabIndex = 21
        '
        'panelmain
        '
        Me.panelmain.AutoSize = True
        Me.panelmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmain.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelmain.Location = New System.Drawing.Point(1013, 0)
        Me.panelmain.Name = "panelmain"
        Me.panelmain.Size = New System.Drawing.Size(2, 711)
        Me.panelmain.TabIndex = 22
        '
        'btnlikedfighters
        '
        Me.btnlikedfighters.Location = New System.Drawing.Point(15, 87)
        Me.btnlikedfighters.Name = "btnlikedfighters"
        Me.btnlikedfighters.Size = New System.Drawing.Size(122, 38)
        Me.btnlikedfighters.TabIndex = 23
        Me.btnlikedfighters.Text = "Liked Fighters"
        Me.btnlikedfighters.UseVisualStyleBackColor = True
        '
        'btnuserdetails
        '
        Me.btnuserdetails.Location = New System.Drawing.Point(15, 421)
        Me.btnuserdetails.Name = "btnuserdetails"
        Me.btnuserdetails.Size = New System.Drawing.Size(122, 38)
        Me.btnuserdetails.TabIndex = 24
        Me.btnuserdetails.Text = "User Details"
        Me.btnuserdetails.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(12, 560)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(122, 38)
        Me.btnlogout.TabIndex = 25
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnranking
        '
        Me.btnranking.Location = New System.Drawing.Point(15, 184)
        Me.btnranking.Name = "btnranking"
        Me.btnranking.Size = New System.Drawing.Size(122, 38)
        Me.btnranking.TabIndex = 26
        Me.btnranking.Text = "See rankings"
        Me.btnranking.UseVisualStyleBackColor = True
        '
        'btnnewranking
        '
        Me.btnnewranking.Location = New System.Drawing.Point(15, 296)
        Me.btnnewranking.Name = "btnnewranking"
        Me.btnnewranking.Size = New System.Drawing.Size(122, 38)
        Me.btnnewranking.TabIndex = 27
        Me.btnnewranking.Text = "Make new ranking"
        Me.btnnewranking.UseVisualStyleBackColor = True
        '
        'current_user_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1015, 711)
        Me.Controls.Add(Me.btnnewranking)
        Me.Controls.Add(Me.btnranking)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnuserdetails)
        Me.Controls.Add(Me.btnlikedfighters)
        Me.Controls.Add(Me.panelmain)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "current_user_form"
        Me.Text = "current_user_form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelmain As Panel
    Friend WithEvents btnlikedfighters As Button
    Friend WithEvents btnuserdetails As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnranking As Button
    Friend WithEvents btnnewranking As Button
End Class
