<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currentpredictionform
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
        Me.lblfighter1 = New System.Windows.Forms.Label()
        Me.lblfighter1name = New System.Windows.Forms.Label()
        Me.lblfighter2name = New System.Windows.Forms.Label()
        Me.lblfighter1odds = New System.Windows.Forms.Label()
        Me.lblfighter2odds = New System.Windows.Forms.Label()
        Me.btnpredict = New System.Windows.Forms.Button()
        Me.txtfighter1stats = New System.Windows.Forms.TextBox()
        Me.txtfighter2stats = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblfighter1
        '
        Me.lblfighter1.AutoSize = True
        Me.lblfighter1.Location = New System.Drawing.Point(375, 33)
        Me.lblfighter1.Name = "lblfighter1"
        Me.lblfighter1.Size = New System.Drawing.Size(0, 13)
        Me.lblfighter1.TabIndex = 0
        '
        'lblfighter1name
        '
        Me.lblfighter1name.AutoSize = True
        Me.lblfighter1name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighter1name.Location = New System.Drawing.Point(44, 106)
        Me.lblfighter1name.Name = "lblfighter1name"
        Me.lblfighter1name.Size = New System.Drawing.Size(125, 20)
        Me.lblfighter1name.TabIndex = 1
        Me.lblfighter1name.Text = "fighter 1 name"
        '
        'lblfighter2name
        '
        Me.lblfighter2name.AutoSize = True
        Me.lblfighter2name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighter2name.Location = New System.Drawing.Point(638, 106)
        Me.lblfighter2name.Name = "lblfighter2name"
        Me.lblfighter2name.Size = New System.Drawing.Size(125, 20)
        Me.lblfighter2name.TabIndex = 2
        Me.lblfighter2name.Text = "fighter 2 name"
        '
        'lblfighter1odds
        '
        Me.lblfighter1odds.AutoSize = True
        Me.lblfighter1odds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighter1odds.Location = New System.Drawing.Point(13, 138)
        Me.lblfighter1odds.Name = "lblfighter1odds"
        Me.lblfighter1odds.Size = New System.Drawing.Size(156, 20)
        Me.lblfighter1odds.TabIndex = 3
        Me.lblfighter1odds.Text = "Chance of winning"
        '
        'lblfighter2odds
        '
        Me.lblfighter2odds.AutoSize = True
        Me.lblfighter2odds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfighter2odds.Location = New System.Drawing.Point(607, 138)
        Me.lblfighter2odds.Name = "lblfighter2odds"
        Me.lblfighter2odds.Size = New System.Drawing.Size(156, 20)
        Me.lblfighter2odds.TabIndex = 4
        Me.lblfighter2odds.Text = "Chance of winning"
        '
        'btnpredict
        '
        Me.btnpredict.Location = New System.Drawing.Point(331, 305)
        Me.btnpredict.Name = "btnpredict"
        Me.btnpredict.Size = New System.Drawing.Size(133, 68)
        Me.btnpredict.TabIndex = 5
        Me.btnpredict.Text = "Predict another fight"
        Me.btnpredict.UseVisualStyleBackColor = True
        '
        'txtfighter1stats
        '
        Me.txtfighter1stats.Location = New System.Drawing.Point(17, 177)
        Me.txtfighter1stats.Multiline = True
        Me.txtfighter1stats.Name = "txtfighter1stats"
        Me.txtfighter1stats.Size = New System.Drawing.Size(152, 152)
        Me.txtfighter1stats.TabIndex = 6
        '
        'txtfighter2stats
        '
        Me.txtfighter2stats.Location = New System.Drawing.Point(611, 177)
        Me.txtfighter2stats.Multiline = True
        Me.txtfighter2stats.Name = "txtfighter2stats"
        Me.txtfighter2stats.Size = New System.Drawing.Size(152, 152)
        Me.txtfighter2stats.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Btnback)
        Me.Panel1.Location = New System.Drawing.Point(-4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 73)
        Me.Panel1.TabIndex = 23
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
        'currentpredictionform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtfighter2stats)
        Me.Controls.Add(Me.txtfighter1stats)
        Me.Controls.Add(Me.btnpredict)
        Me.Controls.Add(Me.lblfighter2odds)
        Me.Controls.Add(Me.lblfighter1odds)
        Me.Controls.Add(Me.lblfighter2name)
        Me.Controls.Add(Me.lblfighter1name)
        Me.Controls.Add(Me.lblfighter1)
        Me.Name = "currentpredictionform"
        Me.Text = "currentpredictionform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblfighter1 As Label
    Friend WithEvents lblfighter1name As Label
    Friend WithEvents lblfighter2name As Label
    Friend WithEvents lblfighter1odds As Label
    Friend WithEvents lblfighter2odds As Label
    Friend WithEvents btnpredict As Button
    Friend WithEvents txtfighter1stats As TextBox
    Friend WithEvents txtfighter2stats As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Btnback As Button
End Class
