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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnlike = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chartsigstr = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Charttd = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.chartsigstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charttd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Helvetica Neue", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblname.Location = New System.Drawing.Point(33, 71)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(99, 36)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "name"
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(36, 267)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(39, 13)
        Me.lblheight.TabIndex = 1
        Me.lblheight.Text = "Label2"
        '
        'lblreach
        '
        Me.lblreach.AutoSize = True
        Me.lblreach.Location = New System.Drawing.Point(36, 327)
        Me.lblreach.Name = "lblreach"
        Me.lblreach.Size = New System.Drawing.Size(39, 13)
        Me.lblreach.TabIndex = 2
        Me.lblreach.Text = "Label3"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(36, 394)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(39, 13)
        Me.lbldob.TabIndex = 3
        Me.lbldob.Text = "Label4"
        '
        'lblrecord
        '
        Me.lblrecord.AutoSize = True
        Me.lblrecord.Font = New System.Drawing.Font("Helvetica Neue", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblrecord.Location = New System.Drawing.Point(35, 131)
        Me.lblrecord.Name = "lblrecord"
        Me.lblrecord.Size = New System.Drawing.Size(71, 21)
        Me.lblrecord.TabIndex = 4
        Me.lblrecord.Text = "Label5"
        '
        'lblSigStrLandedPct
        '
        Me.lblSigStrLandedPct.AutoSize = True
        Me.lblSigStrLandedPct.Location = New System.Drawing.Point(213, 118)
        Me.lblSigStrLandedPct.Name = "lblSigStrLandedPct"
        Me.lblSigStrLandedPct.Size = New System.Drawing.Size(39, 13)
        Me.lblSigStrLandedPct.TabIndex = 5
        Me.lblSigStrLandedPct.Text = "Label6"
        '
        'lblSubAvg
        '
        Me.lblSubAvg.AutoSize = True
        Me.lblSubAvg.Location = New System.Drawing.Point(15, 29)
        Me.lblSubAvg.Name = "lblSubAvg"
        Me.lblSubAvg.Size = New System.Drawing.Size(39, 13)
        Me.lblSubAvg.TabIndex = 7
        Me.lblSubAvg.Text = "Label8"
        '
        'lblTdDefPct
        '
        Me.lblTdDefPct.AutoSize = True
        Me.lblTdDefPct.Location = New System.Drawing.Point(213, 29)
        Me.lblTdDefPct.Name = "lblTdDefPct"
        Me.lblTdDefPct.Size = New System.Drawing.Size(39, 13)
        Me.lblTdDefPct.TabIndex = 8
        Me.lblTdDefPct.Text = "Label9"
        '
        'lblweight
        '
        Me.lblweight.AutoSize = True
        Me.lblweight.Location = New System.Drawing.Point(36, 297)
        Me.lblweight.Name = "lblweight"
        Me.lblweight.Size = New System.Drawing.Size(45, 13)
        Me.lblweight.TabIndex = 9
        Me.lblweight.Text = "Label10"
        '
        'lblstance
        '
        Me.lblstance.AutoSize = True
        Me.lblstance.Location = New System.Drawing.Point(36, 361)
        Me.lblstance.Name = "lblstance"
        Me.lblstance.Size = New System.Drawing.Size(45, 13)
        Me.lblstance.TabIndex = 10
        Me.lblstance.Text = "Label11"
        '
        'lblSigStrLandedPerMinute
        '
        Me.lblSigStrLandedPerMinute.AutoSize = True
        Me.lblSigStrLandedPerMinute.Location = New System.Drawing.Point(213, 88)
        Me.lblSigStrLandedPerMinute.Name = "lblSigStrLandedPerMinute"
        Me.lblSigStrLandedPerMinute.Size = New System.Drawing.Size(45, 13)
        Me.lblSigStrLandedPerMinute.TabIndex = 11
        Me.lblSigStrLandedPerMinute.Text = "Label12"
        '
        'lbltdavg
        '
        Me.lbltdavg.AutoSize = True
        Me.lbltdavg.Location = New System.Drawing.Point(213, 59)
        Me.lbltdavg.Name = "lbltdavg"
        Me.lbltdavg.Size = New System.Drawing.Size(45, 13)
        Me.lbltdavg.TabIndex = 13
        Me.lbltdavg.Text = "Label14"
        '
        'lblTdLandPct
        '
        Me.lblTdLandPct.AutoSize = True
        Me.lblTdLandPct.Location = New System.Drawing.Point(36, 238)
        Me.lblTdLandPct.Name = "lblTdLandPct"
        Me.lblTdLandPct.Size = New System.Drawing.Size(45, 13)
        Me.lblTdLandPct.TabIndex = 14
        Me.lblTdLandPct.Text = "Label15"
        '
        'lblSigStrDefPct
        '
        Me.lblSigStrDefPct.AutoSize = True
        Me.lblSigStrDefPct.Location = New System.Drawing.Point(213, 182)
        Me.lblSigStrDefPct.Name = "lblSigStrDefPct"
        Me.lblSigStrDefPct.Size = New System.Drawing.Size(45, 13)
        Me.lblSigStrDefPct.TabIndex = 15
        Me.lblSigStrDefPct.Text = "Label16"
        '
        'lblSigStrAbsPerMinute
        '
        Me.lblSigStrAbsPerMinute.AutoSize = True
        Me.lblSigStrAbsPerMinute.Location = New System.Drawing.Point(213, 148)
        Me.lblSigStrAbsPerMinute.Name = "lblSigStrAbsPerMinute"
        Me.lblSigStrAbsPerMinute.Size = New System.Drawing.Size(45, 13)
        Me.lblSigStrAbsPerMinute.TabIndex = 16
        Me.lblSigStrAbsPerMinute.Text = "Label17"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(705, 17)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(87, 26)
        Me.btnback.TabIndex = 17
        Me.btnback.Text = "back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnlike
        '
        Me.btnlike.Location = New System.Drawing.Point(529, 362)
        Me.btnlike.Name = "btnlike"
        Me.btnlike.Size = New System.Drawing.Size(238, 45)
        Me.btnlike.TabIndex = 18
        Me.btnlike.Text = "like"
        Me.btnlike.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Location = New System.Drawing.Point(-4, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 53)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblSubAvg)
        Me.Panel2.Controls.Add(Me.lblTdDefPct)
        Me.Panel2.Controls.Add(Me.lblSigStrLandedPct)
        Me.Panel2.Controls.Add(Me.lblSigStrAbsPerMinute)
        Me.Panel2.Controls.Add(Me.lblSigStrDefPct)
        Me.Panel2.Controls.Add(Me.lbltdavg)
        Me.Panel2.Controls.Add(Me.lblSigStrLandedPerMinute)
        Me.Panel2.Location = New System.Drawing.Point(21, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 241)
        Me.Panel2.TabIndex = 20
        '
        'chartsigstr
        '
        Me.chartsigstr.BorderlineColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.chartsigstr.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartsigstr.Legends.Add(Legend1)
        Me.chartsigstr.Location = New System.Drawing.Point(503, 227)
        Me.chartsigstr.Name = "chartsigstr"
        Series1.BackSecondaryColor = System.Drawing.Color.White
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.Name = "sig strikes landed"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "sig str taken"
        Me.chartsigstr.Series.Add(Series1)
        Me.chartsigstr.Series.Add(Series2)
        Me.chartsigstr.Size = New System.Drawing.Size(238, 129)
        Me.chartsigstr.TabIndex = 21
        Me.chartsigstr.Text = "Sig strike vs sig abs"
        '
        'Charttd
        '
        ChartArea2.Name = "ChartArea1"
        Me.Charttd.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Charttd.Legends.Add(Legend2)
        Me.Charttd.Location = New System.Drawing.Point(503, 71)
        Me.Charttd.Name = "Charttd"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Takedown accuracy(%)"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Takedown defence accuracy(%)"
        Me.Charttd.Series.Add(Series3)
        Me.Charttd.Series.Add(Series4)
        Me.Charttd.Size = New System.Drawing.Size(222, 132)
        Me.Charttd.TabIndex = 22
        Me.Charttd.Text = "Chart1"
        '
        'current_fighter_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Charttd)
        Me.Controls.Add(Me.chartsigstr)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnlike)
        Me.Controls.Add(Me.lblTdLandPct)
        Me.Controls.Add(Me.lblstance)
        Me.Controls.Add(Me.lblweight)
        Me.Controls.Add(Me.lblrecord)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblreach)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "current_fighter_form"
        Me.Text = "currentfighterform"
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents btnback As Button
    Friend WithEvents btnlike As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chartsigstr As DataVisualization.Charting.Chart
    Friend WithEvents Charttd As DataVisualization.Charting.Chart
End Class
