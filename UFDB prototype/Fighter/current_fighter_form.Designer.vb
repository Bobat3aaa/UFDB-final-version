<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class current_fighter_form
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.lblreach = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblrecord = New System.Windows.Forms.Label()
        Me.lblSigStrLandedPct = New System.Windows.Forms.Label()
        Me.lblSubAvg = New System.Windows.Forms.Label()
        Me.lblTdDefPct = New System.Windows.Forms.Label()
        Me.lblweight = New System.Windows.Forms.Label()
        Me.lblstance = New System.Windows.Forms.Label()
        Me.lblSigStrLandedPerMinute = New System.Windows.Forms.Label()
        Me.lbltdavg = New System.Windows.Forms.Label()
        Me.lblTdLandPct = New System.Windows.Forms.Label()
        Me.lblSigStrDefPct = New System.Windows.Forms.Label()
        Me.lblSigStrAbsPerMinute = New System.Windows.Forms.Label()
        Me.btnlike = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chartsigstr = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Charttd = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2.SuspendLayout()
        CType(Me.chartsigstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charttd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Calibri", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(8, 9)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(138, 59)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "name"
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheight.Location = New System.Drawing.Point(15, 126)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(55, 13)
        Me.lblheight.TabIndex = 1
        Me.lblheight.Text = "Label2"
        '
        'lblreach
        '
        Me.lblreach.AutoSize = True
        Me.lblreach.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreach.Location = New System.Drawing.Point(15, 29)
        Me.lblreach.Name = "lblreach"
        Me.lblreach.Size = New System.Drawing.Size(55, 13)
        Me.lblreach.TabIndex = 2
        Me.lblreach.Text = "Label3"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(15, 314)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(55, 13)
        Me.lbldob.TabIndex = 3
        Me.lbldob.Text = "Label4"
        '
        'lblrecord
        '
        Me.lblrecord.AutoSize = True
        Me.lblrecord.Font = New System.Drawing.Font("Lucida Console", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecord.Location = New System.Drawing.Point(13, 68)
        Me.lblrecord.Name = "lblrecord"
        Me.lblrecord.Size = New System.Drawing.Size(115, 29)
        Me.lblrecord.TabIndex = 4
        Me.lblrecord.Text = "Record"
        '
        'lblSigStrLandedPct
        '
        Me.lblSigStrLandedPct.AutoSize = True
        Me.lblSigStrLandedPct.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigStrLandedPct.Location = New System.Drawing.Point(282, 173)
        Me.lblSigStrLandedPct.Name = "lblSigStrLandedPct"
        Me.lblSigStrLandedPct.Size = New System.Drawing.Size(55, 13)
        Me.lblSigStrLandedPct.TabIndex = 5
        Me.lblSigStrLandedPct.Text = "Label6"
        '
        'lblSubAvg
        '
        Me.lblSubAvg.AutoSize = True
        Me.lblSubAvg.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubAvg.Location = New System.Drawing.Point(15, 220)
        Me.lblSubAvg.Name = "lblSubAvg"
        Me.lblSubAvg.Size = New System.Drawing.Size(55, 13)
        Me.lblSubAvg.TabIndex = 7
        Me.lblSubAvg.Text = "Label8"
        '
        'lblTdDefPct
        '
        Me.lblTdDefPct.AutoSize = True
        Me.lblTdDefPct.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTdDefPct.Location = New System.Drawing.Point(282, 29)
        Me.lblTdDefPct.Name = "lblTdDefPct"
        Me.lblTdDefPct.Size = New System.Drawing.Size(55, 13)
        Me.lblTdDefPct.TabIndex = 8
        Me.lblTdDefPct.Text = "Label9"
        '
        'lblweight
        '
        Me.lblweight.AutoSize = True
        Me.lblweight.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblweight.Location = New System.Drawing.Point(15, 173)
        Me.lblweight.Name = "lblweight"
        Me.lblweight.Size = New System.Drawing.Size(63, 13)
        Me.lblweight.TabIndex = 9
        Me.lblweight.Text = "Label10"
        '
        'lblstance
        '
        Me.lblstance.AutoSize = True
        Me.lblstance.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstance.Location = New System.Drawing.Point(15, 76)
        Me.lblstance.Name = "lblstance"
        Me.lblstance.Size = New System.Drawing.Size(63, 13)
        Me.lblstance.TabIndex = 10
        Me.lblstance.Text = "Label11"
        '
        'lblSigStrLandedPerMinute
        '
        Me.lblSigStrLandedPerMinute.AutoSize = True
        Me.lblSigStrLandedPerMinute.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigStrLandedPerMinute.Location = New System.Drawing.Point(282, 126)
        Me.lblSigStrLandedPerMinute.Name = "lblSigStrLandedPerMinute"
        Me.lblSigStrLandedPerMinute.Size = New System.Drawing.Size(63, 13)
        Me.lblSigStrLandedPerMinute.TabIndex = 11
        Me.lblSigStrLandedPerMinute.Text = "Label12"
        '
        'lbltdavg
        '
        Me.lbltdavg.AutoSize = True
        Me.lbltdavg.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltdavg.Location = New System.Drawing.Point(282, 76)
        Me.lbltdavg.Name = "lbltdavg"
        Me.lbltdavg.Size = New System.Drawing.Size(63, 13)
        Me.lbltdavg.TabIndex = 13
        Me.lbltdavg.Text = "Label14"
        '
        'lblTdLandPct
        '
        Me.lblTdLandPct.AutoSize = True
        Me.lblTdLandPct.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTdLandPct.Location = New System.Drawing.Point(15, 267)
        Me.lblTdLandPct.Name = "lblTdLandPct"
        Me.lblTdLandPct.Size = New System.Drawing.Size(63, 13)
        Me.lblTdLandPct.TabIndex = 14
        Me.lblTdLandPct.Text = "Label15"
        '
        'lblSigStrDefPct
        '
        Me.lblSigStrDefPct.AutoSize = True
        Me.lblSigStrDefPct.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigStrDefPct.Location = New System.Drawing.Point(284, 220)
        Me.lblSigStrDefPct.Name = "lblSigStrDefPct"
        Me.lblSigStrDefPct.Size = New System.Drawing.Size(63, 13)
        Me.lblSigStrDefPct.TabIndex = 15
        Me.lblSigStrDefPct.Text = "Label16"
        '
        'lblSigStrAbsPerMinute
        '
        Me.lblSigStrAbsPerMinute.AutoSize = True
        Me.lblSigStrAbsPerMinute.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigStrAbsPerMinute.Location = New System.Drawing.Point(286, 267)
        Me.lblSigStrAbsPerMinute.Name = "lblSigStrAbsPerMinute"
        Me.lblSigStrAbsPerMinute.Size = New System.Drawing.Size(63, 13)
        Me.lblSigStrAbsPerMinute.TabIndex = 16
        Me.lblSigStrAbsPerMinute.Text = "Label17"
        '
        'btnlike
        '
        Me.btnlike.BackColor = System.Drawing.Color.RosyBrown
        Me.btnlike.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlike.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnlike.Location = New System.Drawing.Point(648, 433)
        Me.btnlike.Name = "btnlike"
        Me.btnlike.Size = New System.Drawing.Size(269, 68)
        Me.btnlike.TabIndex = 18
        Me.btnlike.Text = "like"
        Me.btnlike.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.lblSubAvg)
        Me.Panel2.Controls.Add(Me.lblTdDefPct)
        Me.Panel2.Controls.Add(Me.lblSigStrLandedPct)
        Me.Panel2.Controls.Add(Me.lblTdLandPct)
        Me.Panel2.Controls.Add(Me.lblstance)
        Me.Panel2.Controls.Add(Me.lblSigStrAbsPerMinute)
        Me.Panel2.Controls.Add(Me.lblweight)
        Me.Panel2.Controls.Add(Me.lbltdavg)
        Me.Panel2.Controls.Add(Me.lblSigStrDefPct)
        Me.Panel2.Controls.Add(Me.lbldob)
        Me.Panel2.Controls.Add(Me.lblSigStrLandedPerMinute)
        Me.Panel2.Controls.Add(Me.lblreach)
        Me.Panel2.Controls.Add(Me.lblheight)
        Me.Panel2.Location = New System.Drawing.Point(21, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 394)
        Me.Panel2.TabIndex = 20
        '
        'chartsigstr
        '
        Me.chartsigstr.BackColor = System.Drawing.Color.Silver
        Me.chartsigstr.BorderlineColor = System.Drawing.Color.Black
        Me.chartsigstr.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.Name = "ChartArea1"
        Me.chartsigstr.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartsigstr.Legends.Add(Legend3)
        Me.chartsigstr.Location = New System.Drawing.Point(648, 233)
        Me.chartsigstr.Name = "chartsigstr"
        Series5.BackSecondaryColor = System.Drawing.Color.White
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.Red
        Series5.Legend = "Legend1"
        Series5.Name = "sig strikes landed"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "sig str taken"
        Me.chartsigstr.Series.Add(Series5)
        Me.chartsigstr.Series.Add(Series6)
        Me.chartsigstr.Size = New System.Drawing.Size(269, 185)
        Me.chartsigstr.TabIndex = 21
        Me.chartsigstr.Text = "Sig strike vs sig abs"
        '
        'Charttd
        '
        Me.Charttd.BackColor = System.Drawing.Color.Silver
        Me.Charttd.BorderlineColor = System.Drawing.Color.Black
        Me.Charttd.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea4.Name = "ChartArea1"
        Me.Charttd.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Charttd.Legends.Add(Legend4)
        Me.Charttd.Location = New System.Drawing.Point(648, 12)
        Me.Charttd.Name = "Charttd"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Takedown accuracy(%)"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Takedown defence accuracy(%)"
        Me.Charttd.Series.Add(Series7)
        Me.Charttd.Series.Add(Series8)
        Me.Charttd.Size = New System.Drawing.Size(269, 193)
        Me.Charttd.TabIndex = 22
        Me.Charttd.Text = "Chart1"
        '
        'current_fighter_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(929, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.Charttd)
        Me.Controls.Add(Me.chartsigstr)
        Me.Controls.Add(Me.btnlike)
        Me.Controls.Add(Me.lblrecord)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "current_fighter_form"
        Me.Text = "currentfighterform"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.chartsigstr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charttd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents lblheight As Label
    Friend WithEvents lblreach As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents lblrecord As Label
    Friend WithEvents lblSigStrLandedPct As Label
    Friend WithEvents lblSubAvg As Label
    Friend WithEvents lblTdDefPct As Label
    Friend WithEvents lblweight As Label
    Friend WithEvents lblstance As Label
    Friend WithEvents lblSigStrLandedPerMinute As Label
    Friend WithEvents lbltdavg As Label
    Friend WithEvents lblTdLandPct As Label
    Friend WithEvents lblSigStrDefPct As Label
    Friend WithEvents lblSigStrAbsPerMinute As Label
    Friend WithEvents btnlike As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chartsigstr As DataVisualization.Charting.Chart
    Friend WithEvents Charttd As DataVisualization.Charting.Chart
End Class
