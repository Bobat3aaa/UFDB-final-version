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
        Me.btnsort = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txteventnum = New System.Windows.Forms.TextBox()
        Me.txtfighter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.btnsearchfighter = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsort
        '
        Me.btnsort.Location = New System.Drawing.Point(612, 103)
        Me.btnsort.Name = "btnsort"
        Me.btnsort.Size = New System.Drawing.Size(142, 77)
        Me.btnsort.TabIndex = 0
        Me.btnsort.Text = "sort"
        Me.btnsort.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 216)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(776, 222)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txteventnum
        '
        Me.txteventnum.Location = New System.Drawing.Point(48, 132)
        Me.txteventnum.Name = "txteventnum"
        Me.txteventnum.Size = New System.Drawing.Size(248, 20)
        Me.txteventnum.TabIndex = 2
        '
        'txtfighter
        '
        Me.txtfighter.Location = New System.Drawing.Point(48, 106)
        Me.txtfighter.Name = "txtfighter"
        Me.txtfighter.Size = New System.Drawing.Size(248, 20)
        Me.txtfighter.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "fighter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "event:"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Silver
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Location = New System.Drawing.Point(48, 158)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(85, 20)
        Me.btnsearch.TabIndex = 6
        Me.btnsearch.Text = "search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Location = New System.Drawing.Point(211, 160)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(85, 20)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Btnback)
        Me.Panel1.Location = New System.Drawing.Point(-4, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 68)
        Me.Panel1.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica Neue", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 54)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fights"
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
        'btnsearchfighter
        '
        Me.btnsearchfighter.Location = New System.Drawing.Point(312, 105)
        Me.btnsearchfighter.Name = "btnsearchfighter"
        Me.btnsearchfighter.Size = New System.Drawing.Size(141, 20)
        Me.btnsearchfighter.TabIndex = 21
        Me.btnsearchfighter.Text = "Search fighter"
        Me.btnsearchfighter.UseVisualStyleBackColor = True
        '
        'fight_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsearchfighter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfighter)
        Me.Controls.Add(Me.txteventnum)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnsort)
        Me.Name = "fight_form"
        Me.Text = "fight_form"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsort As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfighter As TextBox
    Friend WithEvents txteventnum As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnback As Button
    Friend WithEvents btnsearchfighter As Button
End Class
