<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usereditor
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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsavefile = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Datagridview = New System.Windows.Forms.DataGridView()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(13, 150)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(205, 46)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnsavefile
        '
        Me.btnsavefile.Location = New System.Drawing.Point(579, 150)
        Me.btnsavefile.Name = "btnsavefile"
        Me.btnsavefile.Size = New System.Drawing.Size(205, 46)
        Me.btnsavefile.TabIndex = 6
        Me.btnsavefile.Text = "Save files"
        Me.btnsavefile.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(303, 150)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(205, 46)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Datagridview
        '
        Me.Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagridview.Location = New System.Drawing.Point(12, 211)
        Me.Datagridview.Name = "Datagridview"
        Me.Datagridview.Size = New System.Drawing.Size(772, 408)
        Me.Datagridview.TabIndex = 8
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(6, 9)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(211, 42)
        Me.Lbltitle.TabIndex = 9
        Me.Lbltitle.Text = "User editor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Usereditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 631)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.Datagridview)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsavefile)
        Me.Controls.Add(Me.btndelete)
        Me.Name = "Usereditor"
        Me.Text = "Usereditor"
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btnsavefile As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Datagridview As DataGridView
    Friend WithEvents Lbltitle As Label
    Friend WithEvents Button1 As Button
End Class
