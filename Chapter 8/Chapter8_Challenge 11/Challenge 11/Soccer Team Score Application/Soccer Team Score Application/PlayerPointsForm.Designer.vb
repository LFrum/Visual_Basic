<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerPointsForm
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
		Me.lstNames = New System.Windows.Forms.ListBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lstPoints = New System.Windows.Forms.ListBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lstNames)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(161, 149)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Name"
		'
		'lstNames
		'
		Me.lstNames.FormattingEnabled = True
		Me.lstNames.Location = New System.Drawing.Point(17, 19)
		Me.lstNames.Name = "lstNames"
		Me.lstNames.Size = New System.Drawing.Size(126, 121)
		Me.lstNames.TabIndex = 0
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(132, 206)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(80, 29)
		Me.btnClose.TabIndex = 2
		Me.btnClose.Text = "C&lose"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lstPoints)
		Me.GroupBox2.Location = New System.Drawing.Point(179, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(161, 149)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Points"
		'
		'lstPoints
		'
		Me.lstPoints.FormattingEnabled = True
		Me.lstPoints.Location = New System.Drawing.Point(17, 19)
		Me.lstPoints.Name = "lstPoints"
		Me.lstPoints.Size = New System.Drawing.Size(126, 121)
		Me.lstPoints.TabIndex = 0
		'
		'lblTotal
		'
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Location = New System.Drawing.Point(29, 173)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(293, 19)
		Me.lblTotal.TabIndex = 3
		'
		'PlayerPointsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(349, 247)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "PlayerPointsForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Player Points"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents lstPoints As System.Windows.Forms.ListBox
	Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
