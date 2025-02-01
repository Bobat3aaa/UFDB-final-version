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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtchance1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtchance2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfighter1fname
        '
        Me.txtfighter1fname.Location = New System.Drawing.Point(12, 121)
        Me.txtfighter1fname.Name = "txtfighter1fname"
        Me.txtfighter1fname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter1fname.TabIndex = 0
        '
        'txtfighter2fname
        '
        Me.txtfighter2fname.Location = New System.Drawing.Point(665, 121)
        Me.txtfighter2fname.Name = "txtfighter2fname"
        Me.txtfighter2fname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter2fname.TabIndex = 1
        '
        'lblfighter1
        '
        Me.lblfighter1.AutoSize = True
        Me.lblfighter1.Location = New System.Drawing.Point(9, 105)
        Me.lblfighter1.Name = "lblfighter1"
        Me.lblfighter1.Size = New System.Drawing.Size(48, 13)
        Me.lblfighter1.TabIndex = 2
        Me.lblfighter1.Text = "fighter 1:"
        '
        'lblfighter2
        '
        Me.lblfighter2.AutoSize = True
        Me.lblfighter2.Location = New System.Drawing.Point(662, 105)
        Me.lblfighter2.Name = "lblfighter2"
        Me.lblfighter2.Size = New System.Drawing.Size(48, 13)
        Me.lblfighter2.TabIndex = 3
        Me.lblfighter2.Text = "fighter 2:"
        '
        'txtfighter1lname
        '
        Me.txtfighter1lname.Location = New System.Drawing.Point(12, 147)
        Me.txtfighter1lname.Name = "txtfighter1lname"
        Me.txtfighter1lname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter1lname.TabIndex = 4
        '
        'txtfighter2lname
        '
        Me.txtfighter2lname.Location = New System.Drawing.Point(665, 147)
        Me.txtfighter2lname.Name = "txtfighter2lname"
        Me.txtfighter2lname.Size = New System.Drawing.Size(160, 20)
        Me.txtfighter2lname.TabIndex = 5
        '
        'txtfighter1stats
        '
        Me.txtfighter1stats.BackColor = System.Drawing.Color.Silver
        Me.txtfighter1stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfighter1stats.Location = New System.Drawing.Point(12, 186)
        Me.txtfighter1stats.Multiline = True
        Me.txtfighter1stats.Name = "txtfighter1stats"
        Me.txtfighter1stats.Size = New System.Drawing.Size(245, 239)
        Me.txtfighter1stats.TabIndex = 6
        '
        'txtfighter2stats
        '
        Me.txtfighter2stats.BackColor = System.Drawing.Color.Silver
        Me.txtfighter2stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfighter2stats.Location = New System.Drawing.Point(665, 186)
        Me.txtfighter2stats.Multiline = True
        Me.txtfighter2stats.Name = "txtfighter2stats"
        Me.txtfighter2stats.Size = New System.Drawing.Size(245, 239)
        Me.txtfighter2stats.TabIndex = 7
        '
        'btnPredict
        '
        Me.btnPredict.BackColor = System.Drawing.Color.Silver
        Me.btnPredict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPredict.Location = New System.Drawing.Point(288, 459)
        Me.btnPredict.Name = "btnPredict"
        Me.btnPredict.Size = New System.Drawing.Size(319, 38)
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
        Me.btnsearch1.Location = New System.Drawing.Point(190, 144)
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
        Me.btnsearch2.Location = New System.Drawing.Point(848, 144)
        Me.btnsearch2.Name = "btnsearch2"
        Me.btnsearch2.Size = New System.Drawing.Size(60, 23)
        Me.btnsearch2.TabIndex = 16
        Me.btnsearch2.Text = "Search fighter"
        Me.btnsearch2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 72)
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
        'txtwinner
        '
        Me.txtwinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwinner.Location = New System.Drawing.Point(294, 136)
        Me.txtwinner.Name = "txtwinner"
        Me.txtwinner.Size = New System.Drawing.Size(339, 29)
        Me.txtwinner.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
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
        Me.btnback2.Location = New System.Drawing.Point(665, 431)
        Me.btnback2.Name = "btnback2"
        Me.btnback2.Size = New System.Drawing.Size(62, 27)
        Me.btnback2.TabIndex = 26
        Me.btnback2.Text = "Back"
        Me.btnback2.UseVisualStyleBackColor = True
        '
        'btnnext2
        '
        Me.btnnext2.Location = New System.Drawing.Point(848, 431)
        Me.btnnext2.Name = "btnnext2"
        Me.btnnext2.Size = New System.Drawing.Size(62, 27)
        Me.btnnext2.TabIndex = 27
        Me.btnnext2.Text = "next"
        Me.btnnext2.UseVisualStyleBackColor = True
        '
        'btnnext1
        '
        Me.btnnext1.Location = New System.Drawing.Point(195, 431)
        Me.btnnext1.Name = "btnnext1"
        Me.btnnext1.Size = New System.Drawing.Size(62, 27)
        Me.btnnext1.TabIndex = 29
        Me.btnnext1.Text = "next"
        Me.btnnext1.UseVisualStyleBackColor = True
        '
        'btnback1
        '
        Me.btnback1.Location = New System.Drawing.Point(12, 431)
        Me.btnback1.Name = "btnback1"
        Me.btnback1.Size = New System.Drawing.Size(62, 27)
        Me.btnback1.TabIndex = 28
        Me.btnback1.Text = "Back"
        Me.btnback1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtchance1)
        Me.Panel2.Location = New System.Drawing.Point(294, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 122)
        Me.Panel2.TabIndex = 30
        '
        'txtchance1
        '
        Me.txtchance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchance1.Location = New System.Drawing.Point(32, 63)
        Me.txtchance1.Name = "txtchance1"
        Me.txtchance1.Size = New System.Drawing.Size(65, 44)
        Me.txtchance1.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtchance2)
        Me.Panel3.Location = New System.Drawing.Point(507, 186)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(126, 122)
        Me.Panel3.TabIndex = 31
        '
        'txtchance2
        '
        Me.txtchance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchance2.Location = New System.Drawing.Point(35, 63)
        Me.txtchance2.Name = "txtchance2"
        Me.txtchance2.Size = New System.Drawing.Size(65, 44)
        Me.txtchance2.TabIndex = 33
        '
        'oddsgeneratorform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 551)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnnext1)
        Me.Controls.Add(Me.btnback1)
        Me.Controls.Add(Me.btnnext2)
        Me.Controls.Add(Me.btnback2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtwinner)
        Me.Controls.Add(Me.Panel1)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtwinner As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnback2 As Button
    Friend WithEvents btnnext2 As Button
    Friend WithEvents btnnext1 As Button
    Friend WithEvents btnback1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtchance1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtchance2 As TextBox
End Class
