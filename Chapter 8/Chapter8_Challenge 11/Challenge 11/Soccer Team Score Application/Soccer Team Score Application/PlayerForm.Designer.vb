<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerForm
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
		Me.btnClose = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lstPlayerNames = New System.Windows.Forms.ListBox()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(196, 74)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(68, 27)
		Me.btnClear.TabIndex = 0
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(125, 254)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(74, 28)
		Me.btnClose.TabIndex = 2
		Me.btnClose.Text = "C&lose"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.btnAdd)
		Me.GroupBox1.Controls.Add(Me.txtName)
		Me.GroupBox1.Controls.Add(Me.lstPlayerNames)
		Me.GroupBox1.Controls.Add(Me.btnClear)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(283, 236)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Player Names"
		'
		'lstPlayerNames
		'
		Me.lstPlayerNames.FormattingEnabled = True
		Me.lstPlayerNames.Location = New System.Drawing.Point(17, 28)
		Me.lstPlayerNames.Name = "lstPlayerNames"
		Me.lstPlayerNames.Size = New System.Drawing.Size(160, 134)
		Me.lstPlayerNames.TabIndex = 0
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(17, 195)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(160, 20)
		Me.txtName.TabIndex = 3
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(192, 192)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(68, 23)
		Me.btnAdd.TabIndex = 4
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(17, 176)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(64, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "New Player:"
		'
		'PlayerForm
		'
		Me.AcceptButton = Me.btnAdd
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnClose
		Me.ClientSize = New System.Drawing.Size(316, 296)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnClose)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "PlayerForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Players"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents lstPlayerNames As System.Windows.Forms.ListBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnAdd As System.Windows.Forms.Button
	Friend WithEvents txtName As System.Windows.Forms.TextBox
End Class
