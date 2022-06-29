<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamePointsForm
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
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.txtPoints = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lstNames = New System.Windows.Forms.ListBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblMessage)
		Me.GroupBox1.Controls.Add(Me.btnOk)
		Me.GroupBox1.Controls.Add(Me.txtPoints)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.lstNames)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(377, 154)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Select a Player from the list"
		'
		'lblMessage
		'
		Me.lblMessage.AutoSize = True
		Me.lblMessage.Location = New System.Drawing.Point(143, 96)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(0, 13)
		Me.lblMessage.TabIndex = 5
		'
		'btnOk
		'
		Me.btnOk.Location = New System.Drawing.Point(251, 51)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(55, 23)
		Me.btnOk.TabIndex = 4
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		'
		'txtPoints
		'
		Me.txtPoints.Location = New System.Drawing.Point(251, 16)
		Me.txtPoints.Name = "txtPoints"
		Me.txtPoints.Size = New System.Drawing.Size(55, 20)
		Me.txtPoints.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(173, 19)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(72, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Points earned"
		'
		'lstNames
		'
		Me.lstNames.FormattingEnabled = True
		Me.lstNames.Location = New System.Drawing.Point(19, 19)
		Me.lstNames.Name = "lstNames"
		Me.lstNames.Size = New System.Drawing.Size(107, 121)
		Me.lstNames.TabIndex = 1
		'
		'btnClose
		'
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Location = New System.Drawing.Point(166, 172)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(79, 26)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "C&lose"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'GamePointsForm
		'
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnClose
		Me.ClientSize = New System.Drawing.Size(412, 205)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "GamePointsForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Game Points"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents btnOk As System.Windows.Forms.Button
	Friend WithEvents txtPoints As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
