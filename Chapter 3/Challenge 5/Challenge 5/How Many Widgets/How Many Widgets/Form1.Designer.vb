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
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.lblNumWidgets = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPalletAndWidgetsWeight = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtPalletWeight = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(190, 124)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 33)
		Me.btnExit.TabIndex = 13
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(109, 124)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 33)
		Me.btnClear.TabIndex = 12
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(28, 124)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(75, 33)
		Me.btnCalculate.TabIndex = 11
		Me.btnCalculate.Text = "&Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'lblNumWidgets
		'
		Me.lblNumWidgets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNumWidgets.Location = New System.Drawing.Point(150, 85)
		Me.lblNumWidgets.Name = "lblNumWidgets"
		Me.lblNumWidgets.Size = New System.Drawing.Size(50, 20)
		Me.lblNumWidgets.TabIndex = 17
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(43, 89)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(101, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "Number of Widgets:"
		'
		'txtPalletAndWidgetsWeight
		'
		Me.txtPalletAndWidgetsWeight.Location = New System.Drawing.Point(150, 47)
		Me.txtPalletAndWidgetsWeight.Name = "txtPalletAndWidgetsWeight"
		Me.txtPalletAndWidgetsWeight.Size = New System.Drawing.Size(100, 20)
		Me.txtPalletAndWidgetsWeight.TabIndex = 10
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(20, 51)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(124, 13)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Pallet && Widgets Weight:"
		'
		'txtPalletWeight
		'
		Me.txtPalletWeight.Location = New System.Drawing.Point(150, 18)
		Me.txtPalletWeight.Name = "txtPalletWeight"
		Me.txtPalletWeight.Size = New System.Drawing.Size(100, 20)
		Me.txtPalletWeight.TabIndex = 9
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(71, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 13)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "Pallet Weight:"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 169)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(315, 22)
		Me.StatusStrip1.TabIndex = 18
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(315, 191)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.lblNumWidgets)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtPalletAndWidgetsWeight)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtPalletWeight)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Yukon Widget Company"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblNumWidgets As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPalletAndWidgetsWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPalletWeight As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
