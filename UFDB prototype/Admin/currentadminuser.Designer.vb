<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class currentadminuser
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
        Me.btnviewdatabase = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnuserdetails = New System.Windows.Forms.Button()
        Me.panelmain = New System.Windows.Forms.Panel()
        Me.pnltab = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btneditusers = New System.Windows.Forms.Button()
        Me.lblhome = New System.Windows.Forms.Label()
        Me.btnnewranking = New System.Windows.Forms.Button()
        Me.btnranking = New System.Windows.Forms.Button()
        Me.btnlikedfighters = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnltab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnviewdatabase
        '
        Me.btnviewdatabase.BackColor = System.Drawing.Color.White
        Me.btnviewdatabase.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewdatabase.Location = New System.Drawing.Point(36, 344)
        Me.btnviewdatabase.Name = "btnviewdatabase"
        Me.btnviewdatabase.Size = New System.Drawing.Size(162, 62)
        Me.btnviewdatabase.TabIndex = 34
        Me.btnviewdatabase.Text = "Edit fights/fighter"
        Me.btnviewdatabase.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.White
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(36, 587)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(162, 62)
        Me.btnlogout.TabIndex = 32
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnuserdetails
        '
        Me.btnuserdetails.BackColor = System.Drawing.Color.White
        Me.btnuserdetails.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuserdetails.Location = New System.Drawing.Point(36, 425)
        Me.btnuserdetails.Name = "btnuserdetails"
        Me.btnuserdetails.Size = New System.Drawing.Size(162, 62)
        Me.btnuserdetails.TabIndex = 31
        Me.btnuserdetails.Text = "User Details"
        Me.btnuserdetails.UseVisualStyleBackColor = False
        '
        'panelmain
        '
        Me.panelmain.AutoSize = True
        Me.panelmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelmain.Location = New System.Drawing.Point(236, 72)
        Me.panelmain.Name = "panelmain"
        Me.panelmain.Size = New System.Drawing.Size(812, 670)
        Me.panelmain.TabIndex = 29
        '
        'pnltab
        '
        Me.pnltab.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnltab.Controls.Add(Me.lblhome)
        Me.pnltab.Location = New System.Drawing.Point(1, 0)
        Me.pnltab.Name = "pnltab"
        Me.pnltab.Size = New System.Drawing.Size(1047, 72)
        Me.pnltab.TabIndex = 28
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.White
        Me.btnrefresh.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(36, 506)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(162, 62)
        Me.btnrefresh.TabIndex = 35
        Me.btnrefresh.Text = "Refresh API"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btneditusers
        '
        Me.btneditusers.BackColor = System.Drawing.Color.White
        Me.btneditusers.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditusers.Location = New System.Drawing.Point(36, 263)
        Me.btneditusers.Name = "btneditusers"
        Me.btneditusers.Size = New System.Drawing.Size(162, 62)
        Me.btneditusers.TabIndex = 36
        Me.btneditusers.Text = "Edit users"
        Me.btneditusers.UseVisualStyleBackColor = False
        '
        'lblhome
        '
        Me.lblhome.AutoSize = True
        Me.lblhome.Font = New System.Drawing.Font("Bahnschrift", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhome.ForeColor = System.Drawing.Color.Red
        Me.lblhome.Location = New System.Drawing.Point(-1, 0)
        Me.lblhome.Name = "lblhome"
        Me.lblhome.Size = New System.Drawing.Size(193, 77)
        Me.lblhome.TabIndex = 37
        Me.lblhome.Text = "UFDB"
        '
        'btnnewranking
        '
        Me.btnnewranking.BackColor = System.Drawing.Color.White
        Me.btnnewranking.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewranking.Location = New System.Drawing.Point(36, 182)
        Me.btnnewranking.Name = "btnnewranking"
        Me.btnnewranking.Size = New System.Drawing.Size(162, 62)
        Me.btnnewranking.TabIndex = 39
        Me.btnnewranking.Text = "Make new ranking"
        Me.btnnewranking.UseVisualStyleBackColor = False
        '
        'btnranking
        '
        Me.btnranking.BackColor = System.Drawing.Color.White
        Me.btnranking.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnranking.Location = New System.Drawing.Point(36, 101)
        Me.btnranking.Name = "btnranking"
        Me.btnranking.Size = New System.Drawing.Size(162, 62)
        Me.btnranking.TabIndex = 38
        Me.btnranking.Text = "See rankings"
        Me.btnranking.UseVisualStyleBackColor = False
        '
        'btnlikedfighters
        '
        Me.btnlikedfighters.BackColor = System.Drawing.Color.White
        Me.btnlikedfighters.Font = New System.Drawing.Font("Clash Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlikedfighters.Location = New System.Drawing.Point(36, 20)
        Me.btnlikedfighters.Name = "btnlikedfighters"
        Me.btnlikedfighters.Size = New System.Drawing.Size(162, 62)
        Me.btnlikedfighters.TabIndex = 37
        Me.btnlikedfighters.Text = "Liked Fighters"
        Me.btnlikedfighters.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.btnnewranking)
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btneditusers)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnviewdatabase)
        Me.Panel1.Controls.Add(Me.btnuserdetails)
        Me.Panel1.Controls.Add(Me.btnlikedfighters)
        Me.Panel1.Controls.Add(Me.btnranking)
        Me.Panel1.Location = New System.Drawing.Point(1, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 686)
        Me.Panel1.TabIndex = 40
        '
        'currentadminuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmain)
        Me.Controls.Add(Me.pnltab)
        Me.Name = "currentadminuser"
        Me.Text = "currentadminuser"
        Me.pnltab.ResumeLayout(False)
        Me.pnltab.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnviewdatabase As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnuserdetails As Button
    Friend WithEvents panelmain As Panel
    Friend WithEvents pnltab As Panel
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btneditusers As Button
    Friend WithEvents lblhome As Label
    Friend WithEvents btnnewranking As Button
    Friend WithEvents btnranking As Button
    Friend WithEvents btnlikedfighters As Button
    Friend WithEvents Panel1 As Panel
End Class
