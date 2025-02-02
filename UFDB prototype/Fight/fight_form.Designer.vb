<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fight_form
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txteventnum = New System.Windows.Forms.TextBox()
        Me.txtfighter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Label()
        Me.cmbsort = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmbweightclass = New System.Windows.Forms.ComboBox()
        Me.pnlcurrentfight = New System.Windows.Forms.Panel()
        Me.cmblocation = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblsorted = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(8, 269)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(630, 308)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txteventnum
        '
        Me.txteventnum.Font = New System.Drawing.Font("Supreme", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteventnum.Location = New System.Drawing.Point(83, 173)
        Me.txteventnum.Name = "txteventnum"
        Me.txteventnum.Size = New System.Drawing.Size(248, 25)
        Me.txteventnum.TabIndex = 2
        '
        'txtfighter
        '
        Me.txtfighter.Font = New System.Drawing.Font("Supreme", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfighter.Location = New System.Drawing.Point(83, 147)
        Me.txtfighter.Name = "txtfighter"
        Me.txtfighter.Size = New System.Drawing.Size(248, 25)
        Me.txtfighter.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "fighter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "event:"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Silver
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(226, 204)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(105, 28)
        Me.btnsearch.TabIndex = 6
        Me.btnsearch.Text = "search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(83, 204)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(105, 28)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Location = New System.Drawing.Point(-4, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1585, 68)
        Me.Panel1.TabIndex = 20
        '
        'Home
        '
        Me.Home.AutoSize = True
        Me.Home.Font = New System.Drawing.Font("Helvetica Neue", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Home.ForeColor = System.Drawing.Color.Red
        Me.Home.Location = New System.Drawing.Point(172, 12)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(0, 54)
        Me.Home.TabIndex = 24
        '
        'cmbsort
        '
        Me.cmbsort.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsort.FormattingEnabled = True
        Me.cmbsort.Items.AddRange(New Object() {"Descending", "Ascending"})
        Me.cmbsort.Location = New System.Drawing.Point(533, 205)
        Me.cmbsort.Name = "cmbsort"
        Me.cmbsort.Size = New System.Drawing.Size(105, 27)
        Me.cmbsort.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(361, 204)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 28)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Value = New Date(2025, 1, 8, 17, 21, 6, 0)
        '
        'cmbweightclass
        '
        Me.cmbweightclass.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbweightclass.FormattingEnabled = True
        Me.cmbweightclass.Items.AddRange(New Object() {"All", "Women's Strawweight", "Women's Flyweight", "Women's Bantamweight", "Women's Featherweight", "Flyweight", "Bantamweight", "Featherweight", "Lightweight", "Welterweight", "Light Heavyweight", "Heavyweight"})
        Me.cmbweightclass.Location = New System.Drawing.Point(533, 149)
        Me.cmbweightclass.Name = "cmbweightclass"
        Me.cmbweightclass.Size = New System.Drawing.Size(100, 27)
        Me.cmbweightclass.TabIndex = 24
        '
        'pnlcurrentfight
        '
        Me.pnlcurrentfight.Location = New System.Drawing.Point(644, 69)
        Me.pnlcurrentfight.Name = "pnlcurrentfight"
        Me.pnlcurrentfight.Size = New System.Drawing.Size(929, 513)
        Me.pnlcurrentfight.TabIndex = 25
        '
        'cmblocation
        '
        Me.cmblocation.Font = New System.Drawing.Font("Supreme", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblocation.FormattingEnabled = True
        Me.cmblocation.Location = New System.Drawing.Point(360, 149)
        Me.cmblocation.Name = "cmblocation"
        Me.cmblocation.Size = New System.Drawing.Size(154, 27)
        Me.cmblocation.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Clash Display", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 46)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Fights"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Clash Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Location:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Clash Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(530, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Weightclass:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Clash Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(530, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Sort:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Clash Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Clash Display", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Sorted by:"
        '
        'lblsorted
        '
        Me.lblsorted.AutoSize = True
        Me.lblsorted.Font = New System.Drawing.Font("Supreme", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsorted.Location = New System.Drawing.Point(90, 250)
        Me.lblsorted.Name = "lblsorted"
        Me.lblsorted.Size = New System.Drawing.Size(56, 16)
        Me.lblsorted.TabIndex = 51
        Me.lblsorted.Text = "Nothing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Halenoir-Black", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(-1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 77)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "UFDB"
        '
        'fight_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 589)
        Me.Controls.Add(Me.lblsorted)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmblocation)
        Me.Controls.Add(Me.pnlcurrentfight)
        Me.Controls.Add(Me.cmbweightclass)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbsort)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfighter)
        Me.Controls.Add(Me.txteventnum)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "fight_form"
        Me.Text = "fight_form"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfighter As TextBox
    Friend WithEvents txteventnum As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbsort As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Home As Label
    Friend WithEvents cmbweightclass As ComboBox
    Friend WithEvents pnlcurrentfight As Panel
    Friend WithEvents cmblocation As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblsorted As Label
    Friend WithEvents Label4 As Label
End Class
