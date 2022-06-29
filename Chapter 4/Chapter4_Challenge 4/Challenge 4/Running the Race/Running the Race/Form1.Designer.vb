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
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnCalculateResults = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtFinishingTimeRunner3 = New System.Windows.Forms.TextBox()
		Me.txtNameRunner3 = New System.Windows.Forms.TextBox()
		Me.txtFinishingTimeRunner2 = New System.Windows.Forms.TextBox()
		Me.txtNameRunner2 = New System.Windows.Forms.TextBox()
		Me.txtFinishingTimeRunner1 = New System.Windows.Forms.TextBox()
		Me.txtNameRunner1 = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.lblNameThirdPlace = New System.Windows.Forms.Label()
		Me.lblNameSecondPlace = New System.Windows.Forms.Label()
		Me.lblNameFirstPlace = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(111, 317)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 37)
		Me.btnClear.TabIndex = 7
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnCalculateResults
		'
		Me.btnCalculateResults.Location = New System.Drawing.Point(30, 317)
		Me.btnCalculateResults.Name = "btnCalculateResults"
		Me.btnCalculateResults.Size = New System.Drawing.Size(75, 37)
		Me.btnCalculateResults.TabIndex = 6
		Me.btnCalculateResults.Text = "&Calculate Results"
		Me.btnCalculateResults.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(193, 57)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(74, 26)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( in seconds )"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(112, 64)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Name"
		'
		'txtFinishingTimeRunner3
		'
		Me.txtFinishingTimeRunner3.Location = New System.Drawing.Point(200, 145)
		Me.txtFinishingTimeRunner3.Name = "txtFinishingTimeRunner3"
		Me.txtFinishingTimeRunner3.Size = New System.Drawing.Size(60, 20)
		Me.txtFinishingTimeRunner3.TabIndex = 5
		'
		'txtNameRunner3
		'
		Me.txtNameRunner3.Location = New System.Drawing.Point(78, 145)
		Me.txtNameRunner3.Name = "txtNameRunner3"
		Me.txtNameRunner3.Size = New System.Drawing.Size(100, 20)
		Me.txtNameRunner3.TabIndex = 4
		'
		'txtFinishingTimeRunner2
		'
		Me.txtFinishingTimeRunner2.Location = New System.Drawing.Point(200, 119)
		Me.txtFinishingTimeRunner2.Name = "txtFinishingTimeRunner2"
		Me.txtFinishingTimeRunner2.Size = New System.Drawing.Size(60, 20)
		Me.txtFinishingTimeRunner2.TabIndex = 3
		'
		'txtNameRunner2
		'
		Me.txtNameRunner2.Location = New System.Drawing.Point(78, 119)
		Me.txtNameRunner2.Name = "txtNameRunner2"
		Me.txtNameRunner2.Size = New System.Drawing.Size(100, 20)
		Me.txtNameRunner2.TabIndex = 2
		'
		'txtFinishingTimeRunner1
		'
		Me.txtFinishingTimeRunner1.Location = New System.Drawing.Point(200, 93)
		Me.txtFinishingTimeRunner1.Name = "txtFinishingTimeRunner1"
		Me.txtFinishingTimeRunner1.Size = New System.Drawing.Size(60, 20)
		Me.txtFinishingTimeRunner1.TabIndex = 1
		'
		'txtNameRunner1
		'
		Me.txtNameRunner1.Location = New System.Drawing.Point(78, 93)
		Me.txtNameRunner1.Name = "txtNameRunner1"
		Me.txtNameRunner1.Size = New System.Drawing.Size(100, 20)
		Me.txtNameRunner1.TabIndex = 0
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.lblNameThirdPlace)
		Me.GroupBox1.Controls.Add(Me.lblNameSecondPlace)
		Me.GroupBox1.Controls.Add(Me.lblNameFirstPlace)
		Me.GroupBox1.Location = New System.Drawing.Point(26, 182)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(239, 115)
		Me.GroupBox1.TabIndex = 15
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Race Results"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(40, 82)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(55, 13)
		Me.Label9.TabIndex = 4
		Me.Label9.Text = "3rd Place:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(37, 50)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(58, 13)
		Me.Label8.TabIndex = 2
		Me.Label8.Text = "2nd Place:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(41, 21)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(54, 13)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "1st Place:"
		'
		'lblNameThirdPlace
		'
		Me.lblNameThirdPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNameThirdPlace.Location = New System.Drawing.Point(102, 78)
		Me.lblNameThirdPlace.Name = "lblNameThirdPlace"
		Me.lblNameThirdPlace.Size = New System.Drawing.Size(100, 20)
		Me.lblNameThirdPlace.TabIndex = 5
		Me.lblNameThirdPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblNameSecondPlace
		'
		Me.lblNameSecondPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNameSecondPlace.Location = New System.Drawing.Point(102, 46)
		Me.lblNameSecondPlace.Name = "lblNameSecondPlace"
		Me.lblNameSecondPlace.Size = New System.Drawing.Size(100, 20)
		Me.lblNameSecondPlace.TabIndex = 3
		Me.lblNameSecondPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblNameFirstPlace
		'
		Me.lblNameFirstPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNameFirstPlace.Location = New System.Drawing.Point(102, 17)
		Me.lblNameFirstPlace.Name = "lblNameFirstPlace"
		Me.lblNameFirstPlace.Size = New System.Drawing.Size(100, 20)
		Me.lblNameFirstPlace.TabIndex = 1
		Me.lblNameFirstPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(18, 149)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(54, 13)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "Runner 3:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(18, 123)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(54, 13)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Runner 2:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(18, 96)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 13)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Runner 1:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(32, 11)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(233, 40)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "Enter the three runners' names " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and finishing times."
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(192, 317)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 37)
		Me.btnExit.TabIndex = 8
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 364)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculateResults)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtFinishingTimeRunner3)
		Me.Controls.Add(Me.txtNameRunner3)
		Me.Controls.Add(Me.txtFinishingTimeRunner2)
		Me.Controls.Add(Me.txtNameRunner2)
		Me.Controls.Add(Me.txtFinishingTimeRunner1)
		Me.Controls.Add(Me.txtNameRunner1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnExit)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Race Results"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculateResults As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFinishingTimeRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNameRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishingTimeRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNameRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishingTimeRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNameRunner1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNameThirdPlace As System.Windows.Forms.Label
    Friend WithEvents lblNameSecondPlace As System.Windows.Forms.Label
    Friend WithEvents lblNameFirstPlace As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
