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
		Me.btnInputValues = New System.Windows.Forms.Button()
		Me.btnDisplayMinAndMax = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.lstVals = New System.Windows.Forms.ListBox()
		Me.lblResult = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnInputValues
		'
		Me.btnInputValues.Location = New System.Drawing.Point(13, 14)
		Me.btnInputValues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnInputValues.Name = "btnInputValues"
		Me.btnInputValues.Size = New System.Drawing.Size(204, 28)
		Me.btnInputValues.TabIndex = 0
		Me.btnInputValues.Text = "Step 1: Input the Integers"
		Me.btnInputValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnInputValues.UseVisualStyleBackColor = True
		'
		'btnDisplayMinAndMax
		'
		Me.btnDisplayMinAndMax.Location = New System.Drawing.Point(13, 59)
		Me.btnDisplayMinAndMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnDisplayMinAndMax.Name = "btnDisplayMinAndMax"
		Me.btnDisplayMinAndMax.Size = New System.Drawing.Size(204, 29)
		Me.btnDisplayMinAndMax.TabIndex = 1
		Me.btnDisplayMinAndMax.Text = "Step 2: Display Min and Max"
		Me.btnDisplayMinAndMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnDisplayMinAndMax.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(13, 109)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(60, 28)
		Me.btnClear.TabIndex = 2
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'lstVals
		'
		Me.lstVals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstVals.FormattingEnabled = True
		Me.lstVals.ItemHeight = 16
		Me.lstVals.Location = New System.Drawing.Point(240, 14)
		Me.lstVals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lstVals.Name = "lstVals"
		Me.lstVals.Size = New System.Drawing.Size(125, 132)
		Me.lstVals.TabIndex = 4
		'
		'lblResult
		'
		Me.lblResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblResult.Location = New System.Drawing.Point(13, 172)
		Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(352, 29)
		Me.lblResult.TabIndex = 6
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(378, 211)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.lstVals)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnDisplayMinAndMax)
		Me.Controls.Add(Me.btnInputValues)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Largest / Smallest Values"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnInputValues As System.Windows.Forms.Button
	Friend WithEvents btnDisplayMinAndMax As System.Windows.Forms.Button
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents lstVals As System.Windows.Forms.ListBox
	Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
