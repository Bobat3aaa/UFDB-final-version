<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APIrefresh
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
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.lblfights = New System.Windows.Forms.Label()
        Me.lblfighters = New System.Windows.Forms.Label()
        Me.lblfightercount = New System.Windows.Forms.Label()
        Me.lblfightcount = New System.Windows.Forms.Label()
        Me.btnrefreshapi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(12, 9)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(280, 58)
        Me.Lbltitle.TabIndex = 10
        Me.Lbltitle.Text = "Refresh API"
        '
        'lblfights
        '
        Me.lblfights.AutoSize = True
        Me.lblfights.Font = New System.Drawing.Font("Bahnschrift Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfights.Location = New System.Drawing.Point(16, 100)
        Me.lblfights.Name = "lblfights"
        Me.lblfights.Size = New System.Drawing.Size(226, 33)
        Me.lblfights.TabIndex = 22
        Me.lblfights.Text = "Number of fights:"
        '
        'lblfighters
        '
        Me.lblfighters.AutoSize = True
        Me.lblfighters.Font = New System.Drawing.Font("Bahnschrift Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighters.Location = New System.Drawing.Point(16, 67)
        Me.lblfighters.Name = "lblfighters"
        Me.lblfighters.Size = New System.Drawing.Size(252, 33)
        Me.lblfighters.TabIndex = 21
        Me.lblfighters.Text = "Number of fighters:"
        '
        'lblfightercount
        '
        Me.lblfightercount.AutoSize = True
        Me.lblfightercount.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfightercount.Location = New System.Drawing.Point(274, 73)
        Me.lblfightercount.Name = "lblfightercount"
        Me.lblfightercount.Size = New System.Drawing.Size(29, 27)
        Me.lblfightercount.TabIndex = 23
        Me.lblfightercount.Text = "0"
        '
        'lblfightcount
        '
        Me.lblfightcount.AutoSize = True
        Me.lblfightcount.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfightcount.Location = New System.Drawing.Point(274, 106)
        Me.lblfightcount.Name = "lblfightcount"
        Me.lblfightcount.Size = New System.Drawing.Size(29, 27)
        Me.lblfightcount.TabIndex = 24
        Me.lblfightcount.Text = "0"
        '
        'btnrefreshapi
        '
        Me.btnrefreshapi.BackColor = System.Drawing.Color.RosyBrown
        Me.btnrefreshapi.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefreshapi.Location = New System.Drawing.Point(523, 67)
        Me.btnrefreshapi.Name = "btnrefreshapi"
        Me.btnrefreshapi.Size = New System.Drawing.Size(265, 65)
        Me.btnrefreshapi.TabIndex = 25
        Me.btnrefreshapi.Text = "Refresh API"
        Me.btnrefreshapi.UseVisualStyleBackColor = False
        '
        'APIrefresh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnrefreshapi)
        Me.Controls.Add(Me.lblfightcount)
        Me.Controls.Add(Me.lblfightercount)
        Me.Controls.Add(Me.lblfights)
        Me.Controls.Add(Me.lblfighters)
        Me.Controls.Add(Me.Lbltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "APIrefresh"
        Me.Text = "APIrefresh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbltitle As Label
    Friend WithEvents lblfights As Label
    Friend WithEvents lblfighters As Label
    Friend WithEvents lblfightercount As Label
    Friend WithEvents lblfightcount As Label
    Friend WithEvents btnrefreshapi As Button
End Class
