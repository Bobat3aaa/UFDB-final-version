<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Changepassword
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtnewpassword = New System.Windows.Forms.TextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnchangepass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "enter old password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Enter new password:"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(203, 174)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(251, 29)
        Me.txtpassword.TabIndex = 12
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpassword.Location = New System.Drawing.Point(203, 207)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.Size = New System.Drawing.Size(251, 29)
        Me.txtnewpassword.TabIndex = 11
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(10, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(264, 33)
        Me.lbltitle.TabIndex = 15
        Me.lbltitle.Text = "Change password"
        '
        'btnchangepass
        '
        Me.btnchangepass.Location = New System.Drawing.Point(274, 242)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.Size = New System.Drawing.Size(180, 59)
        Me.btnchangepass.TabIndex = 16
        Me.btnchangepass.Text = "Change password"
        Me.btnchangepass.UseVisualStyleBackColor = True
        '
        'Changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 315)
        Me.Controls.Add(Me.btnchangepass)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Name = "Changepassword"
        Me.Text = "Changepassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtnewpassword As TextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnchangepass As Button
End Class
