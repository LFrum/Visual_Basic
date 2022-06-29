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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lstFloorOccupancyData = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblTotalRoomsOccupied = New System.Windows.Forms.Label()
		Me.lblOverallOccupancyRate = New System.Windows.Forms.Label()
		Me.btnCompleteReport = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lstFloorOccupancyData)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(390, 205)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Floor Occupancy Data"
		'
		'lstFloorOccupancyData
		'
		Me.lstFloorOccupancyData.FormattingEnabled = True
		Me.lstFloorOccupancyData.Location = New System.Drawing.Point(16, 19)
		Me.lstFloorOccupancyData.Name = "lstFloorOccupancyData"
		Me.lstFloorOccupancyData.Size = New System.Drawing.Size(353, 173)
		Me.lstFloorOccupancyData.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(100, 240)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(116, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Total Rooms Occupied"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(92, 270)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(124, 13)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Overall Occupancy Rate"
		'
		'lblTotalRoomsOccupied
		'
		Me.lblTotalRoomsOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotalRoomsOccupied.Location = New System.Drawing.Point(219, 235)
		Me.lblTotalRoomsOccupied.Name = "lblTotalRoomsOccupied"
		Me.lblTotalRoomsOccupied.Size = New System.Drawing.Size(79, 23)
		Me.lblTotalRoomsOccupied.TabIndex = 5
		Me.lblTotalRoomsOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblOverallOccupancyRate
		'
		Me.lblOverallOccupancyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblOverallOccupancyRate.Location = New System.Drawing.Point(219, 265)
		Me.lblOverallOccupancyRate.Name = "lblOverallOccupancyRate"
		Me.lblOverallOccupancyRate.Size = New System.Drawing.Size(79, 23)
		Me.lblOverallOccupancyRate.TabIndex = 7
		Me.lblOverallOccupancyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnCompleteReport
		'
		Me.btnCompleteReport.Location = New System.Drawing.Point(52, 313)
		Me.btnCompleteReport.Name = "btnCompleteReport"
		Me.btnCompleteReport.Size = New System.Drawing.Size(82, 39)
		Me.btnCompleteReport.TabIndex = 0
		Me.btnCompleteReport.Text = "&Complete Report"
		Me.btnCompleteReport.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(159, 313)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(82, 39)
		Me.btnClear.TabIndex = 1
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(269, 313)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(82, 39)
		Me.btnExit.TabIndex = 2
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(426, 371)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCompleteReport)
		Me.Controls.Add(Me.lblOverallOccupancyRate)
		Me.Controls.Add(Me.lblTotalRoomsOccupied)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Hotel Occupancy"
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstFloorOccupancyData As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoomsOccupied As System.Windows.Forms.Label
    Friend WithEvents lblOverallOccupancyRate As System.Windows.Forms.Label
    Friend WithEvents btnCompleteReport As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
