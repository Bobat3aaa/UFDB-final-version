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
        Me.components = New System.ComponentModel.Container()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtwinner = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnback2 = New System.Windows.Forms.Button()
        Me.btnnext2 = New System.Windows.Forms.Button()
        Me.btnnext1 = New System.Windows.Forms.Button()
        Me.btnback1 = New System.Windows.Forms.Button()
        Me.txtchance1 = New System.Windows.Forms.TextBox()
        Me.txtchance2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlfighter1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlfighter2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlfighter1.SuspendLayout()
        Me.pnlfighter2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfighter1fname
        '
        Me.txtfighter1fname.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter1fname.Location = New System.Drawing.Point(12, 73)
        Me.txtfighter1fname.Name = "txtfighter1fname"
        Me.txtfighter1fname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter1fname.TabIndex = 0
        '
        'txtfighter2fname
        '
        Me.txtfighter2fname.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter2fname.Location = New System.Drawing.Point(7, 73)
        Me.txtfighter2fname.Name = "txtfighter2fname"
        Me.txtfighter2fname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter2fname.TabIndex = 1
        '
        'lblfighter1
        '
        Me.lblfighter1.AutoSize = True
        Me.lblfighter1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighter1.Location = New System.Drawing.Point(13, 15)
        Me.lblfighter1.Name = "lblfighter1"
        Me.lblfighter1.Size = New System.Drawing.Size(88, 29)
        Me.lblfighter1.TabIndex = 2
        Me.lblfighter1.Text = "fighter 1"
        '
        'lblfighter2
        '
        Me.lblfighter2.AutoSize = True
        Me.lblfighter2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighter2.Location = New System.Drawing.Point(7, 15)
        Me.lblfighter2.Name = "lblfighter2"
        Me.lblfighter2.Size = New System.Drawing.Size(92, 29)
        Me.lblfighter2.TabIndex = 3
        Me.lblfighter2.Text = "fighter 2"
        '
        'txtfighter1lname
        '
        Me.txtfighter1lname.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter1lname.Location = New System.Drawing.Point(12, 120)
        Me.txtfighter1lname.Name = "txtfighter1lname"
        Me.txtfighter1lname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter1lname.TabIndex = 4
        '
        'txtfighter2lname
        '
        Me.txtfighter2lname.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter2lname.Location = New System.Drawing.Point(7, 120)
        Me.txtfighter2lname.Name = "txtfighter2lname"
        Me.txtfighter2lname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter2lname.TabIndex = 5
        '
        'txtfighter1stats
        '
        Me.txtfighter1stats.BackColor = System.Drawing.Color.Silver
        Me.txtfighter1stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfighter1stats.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter1stats.Location = New System.Drawing.Point(12, 151)
        Me.txtfighter1stats.Multiline = True
        Me.txtfighter1stats.Name = "txtfighter1stats"
        Me.txtfighter1stats.Size = New System.Drawing.Size(245, 239)
        Me.txtfighter1stats.TabIndex = 6
        '
        'txtfighter2stats
        '
        Me.txtfighter2stats.BackColor = System.Drawing.Color.Silver
        Me.txtfighter2stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfighter2stats.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter2stats.Location = New System.Drawing.Point(7, 151)
        Me.txtfighter2stats.Multiline = True
        Me.txtfighter2stats.Name = "txtfighter2stats"
        Me.txtfighter2stats.Size = New System.Drawing.Size(245, 239)
        Me.txtfighter2stats.TabIndex = 7
        '
        'btnPredict
        '
        Me.btnPredict.BackColor = System.Drawing.Color.LightCoral
        Me.btnPredict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPredict.Font = New System.Drawing.Font("Lucida Sans Typewriter", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPredict.Location = New System.Drawing.Point(288, 355)
        Me.btnPredict.Name = "btnPredict"
        Me.btnPredict.Size = New System.Drawing.Size(339, 47)
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
        Me.btnsearch1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch1.Location = New System.Drawing.Point(187, 114)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(70, 31)
        Me.btnsearch1.TabIndex = 15
        Me.btnsearch1.Text = "Search"
        Me.btnsearch1.UseVisualStyleBackColor = False
        '
        'btnsearch2
        '
        Me.btnsearch2.BackColor = System.Drawing.Color.Silver
        Me.btnsearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch2.Location = New System.Drawing.Point(182, 114)
        Me.btnsearch2.Name = "btnsearch2"
        Me.btnsearch2.Size = New System.Drawing.Size(70, 31)
        Me.btnsearch2.TabIndex = 16
        Me.btnsearch2.Text = "Search"
        Me.btnsearch2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 72)
        Me.Panel1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(-1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 77)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "UFDB"
        '
        'txtwinner
        '
        Me.txtwinner.Font = New System.Drawing.Font("Lucida Console", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwinner.Location = New System.Drawing.Point(288, 284)
        Me.txtwinner.Name = "txtwinner"
        Me.txtwinner.Size = New System.Drawing.Size(339, 34)
        Me.txtwinner.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Winner"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnback2
        '
        Me.btnback2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback2.Location = New System.Drawing.Point(7, 396)
        Me.btnback2.Name = "btnback2"
        Me.btnback2.Size = New System.Drawing.Size(62, 27)
        Me.btnback2.TabIndex = 26
        Me.btnback2.Text = "Back"
        Me.btnback2.UseVisualStyleBackColor = True
        '
        'btnnext2
        '
        Me.btnnext2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext2.Location = New System.Drawing.Point(190, 396)
        Me.btnnext2.Name = "btnnext2"
        Me.btnnext2.Size = New System.Drawing.Size(62, 27)
        Me.btnnext2.TabIndex = 27
        Me.btnnext2.Text = "next"
        Me.btnnext2.UseVisualStyleBackColor = True
        '
        'btnnext1
        '
        Me.btnnext1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext1.Location = New System.Drawing.Point(195, 400)
        Me.btnnext1.Name = "btnnext1"
        Me.btnnext1.Size = New System.Drawing.Size(62, 27)
        Me.btnnext1.TabIndex = 29
        Me.btnnext1.Text = "next"
        Me.btnnext1.UseVisualStyleBackColor = True
        '
        'btnback1
        '
        Me.btnback1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback1.Location = New System.Drawing.Point(12, 396)
        Me.btnback1.Name = "btnback1"
        Me.btnback1.Size = New System.Drawing.Size(62, 27)
        Me.btnback1.TabIndex = 28
        Me.btnback1.Text = "Back"
        Me.btnback1.UseVisualStyleBackColor = True
        '
        'txtchance1
        '
        Me.txtchance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchance1.Location = New System.Drawing.Point(62, 468)
        Me.txtchance1.Name = "txtchance1"
        Me.txtchance1.Size = New System.Drawing.Size(127, 44)
        Me.txtchance1.TabIndex = 32
        '
        'txtchance2
        '
        Me.txtchance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchance2.Location = New System.Drawing.Point(70, 474)
        Me.txtchance2.Name = "txtchance2"
        Me.txtchance2.Size = New System.Drawing.Size(134, 44)
        Me.txtchance2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 58)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Odds generator"
        '
        'pnlfighter1
        '
        Me.pnlfighter1.BackColor = System.Drawing.Color.DarkGray
        Me.pnlfighter1.Controls.Add(Me.Label8)
        Me.pnlfighter1.Controls.Add(Me.Label5)
        Me.pnlfighter1.Controls.Add(Me.Label7)
        Me.pnlfighter1.Controls.Add(Me.txtchance1)
        Me.pnlfighter1.Controls.Add(Me.lblfighter1)
        Me.pnlfighter1.Controls.Add(Me.txtfighter1fname)
        Me.pnlfighter1.Controls.Add(Me.txtfighter1lname)
        Me.pnlfighter1.Controls.Add(Me.txtfighter1stats)
        Me.pnlfighter1.Controls.Add(Me.btnnext1)
        Me.pnlfighter1.Controls.Add(Me.btnback1)
        Me.pnlfighter1.Controls.Add(Me.btnsearch1)
        Me.pnlfighter1.Location = New System.Drawing.Point(-1, 70)
        Me.pnlfighter1.Name = "pnlfighter1"
        Me.pnlfighter1.Size = New System.Drawing.Size(269, 546)
        Me.pnlfighter1.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "odds"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Last name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "First name"
        '
        'pnlfighter2
        '
        Me.pnlfighter2.BackColor = System.Drawing.Color.DarkGray
        Me.pnlfighter2.Controls.Add(Me.Label9)
        Me.pnlfighter2.Controls.Add(Me.Label4)
        Me.pnlfighter2.Controls.Add(Me.Label3)
        Me.pnlfighter2.Controls.Add(Me.txtchance2)
        Me.pnlfighter2.Controls.Add(Me.txtfighter2stats)
        Me.pnlfighter2.Controls.Add(Me.txtfighter2fname)
        Me.pnlfighter2.Controls.Add(Me.lblfighter2)
        Me.pnlfighter2.Controls.Add(Me.txtfighter2lname)
        Me.pnlfighter2.Controls.Add(Me.btnsearch2)
        Me.pnlfighter2.Controls.Add(Me.btnnext2)
        Me.pnlfighter2.Controls.Add(Me.btnback2)
        Me.pnlfighter2.Location = New System.Drawing.Point(668, 70)
        Me.pnlfighter2.Name = "pnlfighter2"
        Me.pnlfighter2.Size = New System.Drawing.Size(269, 546)
        Me.pnlfighter2.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "odds"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Last name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "First name"
        '
        'oddsgeneratorform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 611)
        Me.Controls.Add(Me.pnlfighter2)
        Me.Controls.Add(Me.pnlfighter1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtwinner)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPredict)
        Me.Name = "oddsgeneratorform"
        Me.Text = "oddsgeneratorform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlfighter1.ResumeLayout(False)
        Me.pnlfighter1.PerformLayout()
        Me.pnlfighter2.ResumeLayout(False)
        Me.pnlfighter2.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtwinner As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnback2 As Button
    Friend WithEvents btnnext2 As Button
    Friend WithEvents btnnext1 As Button
    Friend WithEvents btnback1 As Button
    Friend WithEvents txtchance1 As TextBox
    Friend WithEvents txtchance2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlfighter1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlfighter2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
