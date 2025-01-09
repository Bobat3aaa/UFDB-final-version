<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FighterForm
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
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbweightclass = New System.Windows.Forms.ComboBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbstance = New System.Windows.Forms.ComboBox()
        Me.cmbliked = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblsorted = New System.Windows.Forms.Label()
        Me.cmbwins = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(80, 104)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(237, 20)
        Me.txtfname.TabIndex = 1
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(80, 130)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(237, 20)
        Me.txtlname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last name:"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Silver
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Location = New System.Drawing.Point(80, 156)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(98, 28)
        Me.btnsearch.TabIndex = 7
        Me.btnsearch.Text = "search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(8, 257)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(772, 320)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'cmbweightclass
        '
        Me.cmbweightclass.FormattingEnabled = True
        Me.cmbweightclass.Items.AddRange(New Object() {"All", "115 lbs.", "125 lbs.", "135 lbs.", "145 lbs.", "155 lbs.", "170 lbs.", "185 lbs.", "205 lbs.", "265 lbs.", ""})
        Me.cmbweightclass.Location = New System.Drawing.Point(368, 103)
        Me.cmbweightclass.Name = "cmbweightclass"
        Me.cmbweightclass.Size = New System.Drawing.Size(121, 21)
        Me.cmbweightclass.TabIndex = 16
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Location = New System.Drawing.Point(212, 156)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(105, 28)
        Me.btnclear.TabIndex = 17
        Me.btnclear.Text = "clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Weight class:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Location = New System.Drawing.Point(-4, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 69)
        Me.Panel1.TabIndex = 19
        '
        'Home
        '
        Me.Home.AutoSize = True
        Me.Home.Font = New System.Drawing.Font("Helvetica Neue", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Home.ForeColor = System.Drawing.Color.Red
        Me.Home.Location = New System.Drawing.Point(3, 12)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(157, 54)
        Me.Home.TabIndex = 6
        Me.Home.Text = "UFDB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(514, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Stance:"
        '
        'cmbstance
        '
        Me.cmbstance.FormattingEnabled = True
        Me.cmbstance.Items.AddRange(New Object() {"All", "Orthodox", "Southpaw", "Switch"})
        Me.cmbstance.Location = New System.Drawing.Point(517, 103)
        Me.cmbstance.Name = "cmbstance"
        Me.cmbstance.Size = New System.Drawing.Size(121, 21)
        Me.cmbstance.TabIndex = 24
        '
        'cmbliked
        '
        Me.cmbliked.FormattingEnabled = True
        Me.cmbliked.Items.AddRange(New Object() {"All", "115 lbs.", "125 lbs.", "135 lbs.", "145 lbs.", "155 lbs.", "170 lbs.", "185 lbs.", "205 lbs.", "265 lbs.", ""})
        Me.cmbliked.Location = New System.Drawing.Point(663, 103)
        Me.cmbliked.Name = "cmbliked"
        Me.cmbliked.Size = New System.Drawing.Size(121, 21)
        Me.cmbliked.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(660, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Liked?:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 14)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Sort:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(514, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 14)
        Me.Label8.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Sorted by:"
        '
        'lblsorted
        '
        Me.lblsorted.AutoSize = True
        Me.lblsorted.Location = New System.Drawing.Point(86, 240)
        Me.lblsorted.Name = "lblsorted"
        Me.lblsorted.Size = New System.Drawing.Size(44, 13)
        Me.lblsorted.TabIndex = 38
        Me.lblsorted.Text = "Nothing"
        '
        'cmbwins
        '
        Me.cmbwins.FormattingEnabled = True
        Me.cmbwins.Items.AddRange(New Object() {"N/A", "Wins desc", "Wins asc", "loss desc", "loss asc"})
        Me.cmbwins.Location = New System.Drawing.Point(369, 163)
        Me.cmbwins.Name = "cmbwins"
        Me.cmbwins.Size = New System.Drawing.Size(126, 21)
        Me.cmbwins.TabIndex = 42
        '
        'FighterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 589)
        Me.Controls.Add(Me.cmbwins)
        Me.Controls.Add(Me.lblsorted)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbliked)
        Me.Controls.Add(Me.cmbstance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.cmbweightclass)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Name = "FighterForm"
        Me.Text = "FighterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents cmbweightclass As ComboBox
    Friend WithEvents btnclear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Home As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbstance As ComboBox
    Friend WithEvents cmbliked As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents lblsorted As Label
    Friend WithEvents cmbwins As ComboBox
End Class
