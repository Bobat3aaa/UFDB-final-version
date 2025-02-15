<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Databaseeditor
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
        Me.Datagridview = New System.Windows.Forms.DataGridView()
        Me.cmbselectview = New System.Windows.Forms.ComboBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsavefile = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.lblchoose = New System.Windows.Forms.Label()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datagridview
        '
        Me.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview.Location = New System.Drawing.Point(12, 211)
        Me.Datagridview.Name = "Datagridview"
        Me.Datagridview.Size = New System.Drawing.Size(772, 408)
        Me.Datagridview.TabIndex = 0
        '
        'cmbselectview
        '
        Me.cmbselectview.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbselectview.FormattingEnabled = True
        Me.cmbselectview.Items.AddRange(New Object() {"Fighter", "Fight"})
        Me.cmbselectview.Location = New System.Drawing.Point(578, 98)
        Me.cmbselectview.Name = "cmbselectview"
        Me.cmbselectview.Size = New System.Drawing.Size(204, 32)
        Me.cmbselectview.TabIndex = 1
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightGray
        Me.btndelete.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(302, 145)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(205, 46)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsavefile
        '
        Me.btnsavefile.BackColor = System.Drawing.Color.LightGray
        Me.btnsavefile.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavefile.Location = New System.Drawing.Point(578, 145)
        Me.btnsavefile.Name = "btnsavefile"
        Me.btnsavefile.Size = New System.Drawing.Size(205, 46)
        Me.btnsavefile.TabIndex = 3
        Me.btnsavefile.Text = "Save files"
        Me.btnsavefile.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.LightGray
        Me.btnadd.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(12, 145)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(205, 46)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(12, 19)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(367, 58)
        Me.Lbltitle.TabIndex = 5
        Me.Lbltitle.Text = "Database editor"
        '
        'lblchoose
        '
        Me.lblchoose.AutoSize = True
        Me.lblchoose.Font = New System.Drawing.Font("Bahnschrift Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchoose.Location = New System.Drawing.Point(574, 75)
        Me.lblchoose.Name = "lblchoose"
        Me.lblchoose.Size = New System.Drawing.Size(121, 23)
        Me.lblchoose.TabIndex = 6
        Me.lblchoose.Text = "Choose view:"
        '
        'Databaseeditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 631)
        Me.Controls.Add(Me.lblchoose)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsavefile)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cmbselectview)
        Me.Controls.Add(Me.Datagridview)
        Me.Name = "Databaseeditor"
        Me.Text = "Edit database"
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datagridview As DataGridView
    Friend WithEvents cmbselectview As ComboBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsavefile As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Lbltitle As Label
    Friend WithEvents lblchoose As Label
End Class
