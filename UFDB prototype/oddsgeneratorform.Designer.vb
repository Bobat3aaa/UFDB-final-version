<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oddsgeneratorform
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
        Me.txtfighter1fname = New System.Windows.Forms.TextBox()
        Me.txtfighter2fname = New System.Windows.Forms.TextBox()
        Me.lblfighter1 = New System.Windows.Forms.Label()
        Me.lblfighter2 = New System.Windows.Forms.Label()
        Me.txtfighter1lname = New System.Windows.Forms.TextBox()
        Me.txtfighter2lname = New System.Windows.Forms.TextBox()
        Me.txtfighter1stats = New System.Windows.Forms.TextBox()
        Me.txtfighter2stats = New System.Windows.Forms.TextBox()
        Me.btnPredict = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.btnsearch1 = New System.Windows.Forms.Button()
        Me.btnsearch2 = New System.Windows.Forms.Button()
        Me.btnclear2 = New System.Windows.Forms.Button()
        Me.btnclear1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfighter1fname
        '
        Me.txtfighter1fname.Location = New System.Drawing.Point(57, 121)
        Me.txtfighter1fname.Name = "txtfighter1fname"
        Me.txtfighter1fname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter1fname.TabIndex = 0
        '
        'txtfighter2fname
        '
        Me.txtfighter2fname.Location = New System.Drawing.Point(575, 121)
        Me.txtfighter2fname.Name = "txtfighter2fname"
        Me.txtfighter2fname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter2fname.TabIndex = 1
        '
        'lblfighter1
        '
        Me.lblfighter1.AutoSize = True
        Me.lblfighter1.Location = New System.Drawing.Point(54, 105)
        Me.lblfighter1.Name = "lblfighter1"
        Me.lblfighter1.Size = New System.Drawing.Size(48, 13)
        Me.lblfighter1.TabIndex = 2
        Me.lblfighter1.Text = "fighter 1:"
        '
        'lblfighter2
        '
        Me.lblfighter2.AutoSize = True
        Me.lblfighter2.Location = New System.Drawing.Point(572, 105)
        Me.lblfighter2.Name = "lblfighter2"
        Me.lblfighter2.Size = New System.Drawing.Size(48, 13)
        Me.lblfighter2.TabIndex = 3
        Me.lblfighter2.Text = "fighter 2:"
        '
        'txtfighter1lname
        '
        Me.txtfighter1lname.Location = New System.Drawing.Point(57, 147)
        Me.txtfighter1lname.Name = "txtfighter1lname"
        Me.txtfighter1lname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter1lname.TabIndex = 4
        '
        'txtfighter2lname
        '
        Me.txtfighter2lname.Location = New System.Drawing.Point(575, 147)
        Me.txtfighter2lname.Name = "txtfighter2lname"
        Me.txtfighter2lname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter2lname.TabIndex = 5
        '
        'txtfighter1stats
        '
        Me.txtfighter1stats.BackColor = System.Drawing.Color.Silver
        Me.txtfighter1stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfighter1stats.Location = New System.Drawing.Point(57, 184)
        Me.txtfighter1stats.Multiline = True
        Me.txtfighter1stats.Name = "txtfighter1stats"
        Me.txtfighter1stats.Size = New System.Drawing.Size(160, 112)
        Me.txtfighter1stats.TabIndex = 6
        '
        'txtfighter2stats
        '
        Me.txtfighter2stats.BackColor = System.Drawing.Color.Silver
        Me.txtfighter2stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfighter2stats.Location = New System.Drawing.Point(575, 184)
        Me.txtfighter2stats.Multiline = True
        Me.txtfighter2stats.Name = "txtfighter2stats"
        Me.txtfighter2stats.Size = New System.Drawing.Size(160, 112)
        Me.txtfighter2stats.TabIndex = 7
        '
        'btnPredict
        '
        Me.btnPredict.BackColor = System.Drawing.Color.Silver
        Me.btnPredict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPredict.Location = New System.Drawing.Point(326, 184)
        Me.btnPredict.Name = "btnPredict"
        Me.btnPredict.Size = New System.Drawing.Size(139, 70)
        Me.btnPredict.TabIndex = 12
        Me.btnPredict.Text = "predict"
        Me.btnPredict.UseVisualStyleBackColor = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'btnsearch1
        '
        Me.btnsearch1.BackColor = System.Drawing.Color.Silver
        Me.btnsearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch1.Location = New System.Drawing.Point(154, 302)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(63, 23)
        Me.btnsearch1.TabIndex = 15
        Me.btnsearch1.Text = "Search fighter"
        Me.btnsearch1.UseVisualStyleBackColor = False
        '
        'btnsearch2
        '
        Me.btnsearch2.BackColor = System.Drawing.Color.Silver
        Me.btnsearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch2.Location = New System.Drawing.Point(675, 302)
        Me.btnsearch2.Name = "btnsearch2"
        Me.btnsearch2.Size = New System.Drawing.Size(60, 23)
        Me.btnsearch2.TabIndex = 16
        Me.btnsearch2.Text = "Search fighter"
        Me.btnsearch2.UseVisualStyleBackColor = False
        '
        'btnclear2
        '
        Me.btnclear2.BackColor = System.Drawing.Color.Silver
        Me.btnclear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear2.Location = New System.Drawing.Point(575, 302)
        Me.btnclear2.Name = "btnclear2"
        Me.btnclear2.Size = New System.Drawing.Size(63, 23)
        Me.btnclear2.TabIndex = 17
        Me.btnclear2.Text = "Clear"
        Me.btnclear2.UseVisualStyleBackColor = False
        '
        'btnclear1
        '
        Me.btnclear1.BackColor = System.Drawing.Color.Silver
        Me.btnclear1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear1.Location = New System.Drawing.Point(57, 302)
        Me.btnclear1.Name = "btnclear1"
        Me.btnclear1.Size = New System.Drawing.Size(63, 23)
        Me.btnclear1.TabIndex = 18
        Me.btnclear1.Text = "Clear"
        Me.btnclear1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Btnback)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 72)
        Me.Panel1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica Neue", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(382, 54)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Odds generator"
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
        'oddsgeneratorform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclear1)
        Me.Controls.Add(Me.btnclear2)
        Me.Controls.Add(Me.btnsearch2)
        Me.Controls.Add(Me.btnsearch1)
        Me.Controls.Add(Me.btnPredict)
        Me.Controls.Add(Me.txtfighter2stats)
        Me.Controls.Add(Me.txtfighter1stats)
        Me.Controls.Add(Me.txtfighter2lname)
        Me.Controls.Add(Me.txtfighter1lname)
        Me.Controls.Add(Me.lblfighter2)
        Me.Controls.Add(Me.lblfighter1)
        Me.Controls.Add(Me.txtfighter2fname)
        Me.Controls.Add(Me.txtfighter1fname)
        Me.Name = "oddsgeneratorform"
        Me.Text = "oddsgeneratorform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfighter1fname As TextBox
    Friend WithEvents txtfighter2fname As TextBox
    Friend WithEvents lblfighter1 As Label
    Friend WithEvents lblfighter2 As Label
    Friend WithEvents txtfighter1lname As TextBox
    Friend WithEvents txtfighter2lname As TextBox
    Friend WithEvents txtfighter1stats As TextBox
    Friend WithEvents txtfighter2stats As TextBox
    Friend WithEvents btnPredict As Button
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents btnsearch1 As Button
    Friend WithEvents btnsearch2 As Button
    Friend WithEvents btnclear2 As Button
    Friend WithEvents btnclear1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Btnback As Button
End Class
