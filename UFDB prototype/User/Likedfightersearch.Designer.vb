﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Likedfightersearch
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Silver
        Me.FlowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 181)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(783, 477)
        Me.FlowLayoutPanel1.TabIndex = 54
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Location = New System.Drawing.Point(239, 117)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(105, 28)
        Me.btnclear.TabIndex = 23
        Me.btnclear.Text = "clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Silver
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Location = New System.Drawing.Point(107, 117)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(98, 28)
        Me.btnsearch.TabIndex = 22
        Me.btnsearch.Text = "search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Last name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica Neue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "First name:"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(107, 91)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(237, 20)
        Me.txtlname.TabIndex = 19
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(107, 65)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(237, 20)
        Me.txtfname.TabIndex = 18
        '
        'Likedfightersearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtlname)
        Me.MaximizeBox = False
        Me.Name = "Likedfightersearch"
        Me.Text = "Liked fighters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
End Class
