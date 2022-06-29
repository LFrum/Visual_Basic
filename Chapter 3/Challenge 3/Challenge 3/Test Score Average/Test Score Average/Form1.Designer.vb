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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtTestScore1 = New System.Windows.Forms.TextBox()
		Me.txtTestScore2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtTestScore3 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtTestScore4 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtTestScore5 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblAverage = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(85, 27)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Test Score 1:"
		'
		'txtTestScore1
		'
		Me.txtTestScore1.Location = New System.Drawing.Point(182, 26)
		Me.txtTestScore1.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTestScore1.Name = "txtTestScore1"
		Me.txtTestScore1.Size = New System.Drawing.Size(100, 23)
		Me.txtTestScore1.TabIndex = 1
		'
		'txtTestScore2
		'
		Me.txtTestScore2.Location = New System.Drawing.Point(182, 58)
		Me.txtTestScore2.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTestScore2.Name = "txtTestScore2"
		Me.txtTestScore2.Size = New System.Drawing.Size(100, 23)
		Me.txtTestScore2.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(85, 60)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(93, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Test Score 2:"
		'
		'txtTestScore3
		'
		Me.txtTestScore3.Location = New System.Drawing.Point(182, 90)
		Me.txtTestScore3.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTestScore3.Name = "txtTestScore3"
		Me.txtTestScore3.Size = New System.Drawing.Size(100, 23)
		Me.txtTestScore3.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(85, 92)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(93, 17)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Test Score 3:"
		'
		'txtTestScore4
		'
		Me.txtTestScore4.Location = New System.Drawing.Point(182, 122)
		Me.txtTestScore4.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTestScore4.Name = "txtTestScore4"
		Me.txtTestScore4.Size = New System.Drawing.Size(100, 23)
		Me.txtTestScore4.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(85, 124)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(93, 17)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Test Score 4:"
		'
		'txtTestScore5
		'
		Me.txtTestScore5.Location = New System.Drawing.Point(182, 154)
		Me.txtTestScore5.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTestScore5.Name = "txtTestScore5"
		Me.txtTestScore5.Size = New System.Drawing.Size(100, 23)
		Me.txtTestScore5.TabIndex = 9
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(85, 156)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(93, 17)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Test Score 5:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(115, 197)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 17)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "Average"
		'
		'lblAverage
		'
		Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAverage.Location = New System.Drawing.Point(182, 193)
		Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblAverage.Name = "lblAverage"
		Me.lblAverage.Size = New System.Drawing.Size(100, 28)
		Me.lblAverage.TabIndex = 14
		Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(42, 238)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(71, 32)
		Me.btnCalculate.TabIndex = 10
		Me.btnCalculate.Text = "Calc"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(127, 238)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(85, 32)
		Me.btnClear.TabIndex = 11
		Me.btnClear.Text = "Cl&ear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(225, 238)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(81, 32)
		Me.btnExit.TabIndex = 12
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 298)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(351, 22)
		Me.StatusStrip1.TabIndex = 15
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(351, 320)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.lblAverage)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtTestScore5)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtTestScore4)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtTestScore3)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtTestScore2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtTestScore1)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "Form1"
		Me.Text = "Test Score Average"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTestScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTestScore2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTestScore3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTestScore4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTestScore5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
