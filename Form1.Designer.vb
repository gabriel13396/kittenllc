<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnViewInfo = New System.Windows.Forms.Button()
        Me.lstboxPotential = New System.Windows.Forms.ListBox()
        Me.lstboxInterviewees = New System.Windows.Forms.ListBox()
        Me.lstboxAll = New System.Windows.Forms.ListBox()
        Me.btnSendInterview = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.txtGrad = New System.Windows.Forms.TextBox()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnViewInfo
        '
        Me.btnViewInfo.Location = New System.Drawing.Point(565, 392)
        Me.btnViewInfo.Name = "btnViewInfo"
        Me.btnViewInfo.Size = New System.Drawing.Size(96, 46)
        Me.btnViewInfo.TabIndex = 0
        Me.btnViewInfo.Text = "View Potential Candidate Info"
        Me.btnViewInfo.UseVisualStyleBackColor = True
        '
        'lstboxPotential
        '
        Me.lstboxPotential.FormattingEnabled = True
        Me.lstboxPotential.Location = New System.Drawing.Point(565, 115)
        Me.lstboxPotential.Name = "lstboxPotential"
        Me.lstboxPotential.Size = New System.Drawing.Size(214, 251)
        Me.lstboxPotential.TabIndex = 1
        '
        'lstboxInterviewees
        '
        Me.lstboxInterviewees.FormattingEnabled = True
        Me.lstboxInterviewees.Location = New System.Drawing.Point(813, 115)
        Me.lstboxInterviewees.Name = "lstboxInterviewees"
        Me.lstboxInterviewees.Size = New System.Drawing.Size(213, 251)
        Me.lstboxInterviewees.TabIndex = 2
        '
        'lstboxAll
        '
        Me.lstboxAll.FormattingEnabled = True
        Me.lstboxAll.Location = New System.Drawing.Point(313, 115)
        Me.lstboxAll.Name = "lstboxAll"
        Me.lstboxAll.Size = New System.Drawing.Size(217, 251)
        Me.lstboxAll.TabIndex = 3
        '
        'btnSendInterview
        '
        Me.btnSendInterview.Location = New System.Drawing.Point(684, 392)
        Me.btnSendInterview.Name = "btnSendInterview"
        Me.btnSendInterview.Size = New System.Drawing.Size(95, 46)
        Me.btnSendInterview.TabIndex = 4
        Me.btnSendInterview.Text = "Send to Interviewees List"
        Me.btnSendInterview.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(95, 346)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(118, 27)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Set and Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(100, 136)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(100, 20)
        Me.txtGPA.TabIndex = 6
        '
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(100, 189)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(100, 20)
        Me.txtRank.TabIndex = 7
        '
        'txtGrad
        '
        Me.txtGrad.Location = New System.Drawing.Point(100, 246)
        Me.txtGrad.Name = "txtGrad"
        Me.txtGrad.Size = New System.Drawing.Size(100, 20)
        Me.txtGrad.TabIndex = 8
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(95, 12)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(118, 39)
        Me.btnFile.TabIndex = 9
        Me.btnFile.Text = "Load New File"
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(100, 303)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(100, 20)
        Me.txtMajor.TabIndex = 10
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(1045, 86)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Minimim Requirements"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Min GPA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Min Class Rank"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Graduation Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Major"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "All Candidates"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(590, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Potential Candidates"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(871, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Interviewees"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1110, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 21)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Average GPA per Major"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(513, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(320, 33)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Kitten LLC Talent Acquisition"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1369, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.txtGrad)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnSendInterview)
        Me.Controls.Add(Me.lstboxAll)
        Me.Controls.Add(Me.lstboxInterviewees)
        Me.Controls.Add(Me.lstboxPotential)
        Me.Controls.Add(Me.btnViewInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewInfo As Button
    Friend WithEvents lstboxPotential As ListBox
    Friend WithEvents lstboxInterviewees As ListBox
    Friend WithEvents lstboxAll As ListBox
    Friend WithEvents btnSendInterview As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtRank As TextBox
    Friend WithEvents txtGrad As TextBox
    Friend WithEvents btnFile As Button
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
