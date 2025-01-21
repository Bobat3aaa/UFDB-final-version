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
        Me.cmbselectview.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbselectview.FormattingEnabled = True
        Me.cmbselectview.Items.AddRange(New Object() {"Fighter", "Fight"})
        Me.cmbselectview.Location = New System.Drawing.Point(580, 98)
        Me.cmbselectview.Name = "cmbselectview"
        Me.cmbselectview.Size = New System.Drawing.Size(204, 32)
        Me.cmbselectview.TabIndex = 1
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(367, 136)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(205, 46)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsavefile
        '
        Me.btnsavefile.Location = New System.Drawing.Point(578, 136)
        Me.btnsavefile.Name = "btnsavefile"
        Me.btnsavefile.Size = New System.Drawing.Size(205, 46)
        Me.btnsavefile.TabIndex = 3
        Me.btnsavefile.Text = "Save files"
        Me.btnsavefile.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(367, 84)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(205, 46)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Databaseeditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 631)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsavefile)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cmbselectview)
        Me.Controls.Add(Me.Datagridview)
        Me.Name = "Databaseeditor"
        Me.Text = "Databaseeditor"
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Datagridview As DataGridView
    Friend WithEvents cmbselectview As ComboBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsavefile As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
