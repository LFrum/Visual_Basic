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
		Me.btnCalculateCharges = New System.Windows.Forms.Button()
		Me.txtClearForm = New System.Windows.Forms.Button()
		Me.txtExit = New System.Windows.Forms.Button()
		Me.txtLengthOfStay = New System.Windows.Forms.TextBox()
		Me.txtMedicationCharges = New System.Windows.Forms.TextBox()
		Me.txtSurgicalCharges = New System.Windows.Forms.TextBox()
		Me.txtLabFees = New System.Windows.Forms.TextBox()
		Me.txtPhysicalRehabCharges = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnCalculateCharges
		'
		Me.btnCalculateCharges.Location = New System.Drawing.Point(43, 307)
		Me.btnCalculateCharges.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculateCharges.Name = "btnCalculateCharges"
		Me.btnCalculateCharges.Size = New System.Drawing.Size(107, 49)
		Me.btnCalculateCharges.TabIndex = 1
		Me.btnCalculateCharges.Text = "&Calculate Charges"
		Me.btnCalculateCharges.UseVisualStyleBackColor = True
		'
		'txtClearForm
		'
		Me.txtClearForm.Location = New System.Drawing.Point(176, 308)
		Me.txtClearForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtClearForm.Name = "txtClearForm"
		Me.txtClearForm.Size = New System.Drawing.Size(107, 49)
		Me.txtClearForm.TabIndex = 2
		Me.txtClearForm.Text = "C&lear Form"
		Me.txtClearForm.UseVisualStyleBackColor = True
		'
		'txtExit
		'
		Me.txtExit.Location = New System.Drawing.Point(300, 308)
		Me.txtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtExit.Name = "txtExit"
		Me.txtExit.Size = New System.Drawing.Size(107, 49)
		Me.txtExit.TabIndex = 3
		Me.txtExit.Text = "E&xit"
		Me.txtExit.UseVisualStyleBackColor = True
		'
		'txtLengthOfStay
		'
		Me.txtLengthOfStay.Location = New System.Drawing.Point(194, 30)
		Me.txtLengthOfStay.Margin = New System.Windows.Forms.Padding(4)
		Me.txtLengthOfStay.Name = "txtLengthOfStay"
		Me.txtLengthOfStay.Size = New System.Drawing.Size(132, 23)
		Me.txtLengthOfStay.TabIndex = 0
		'
		'txtMedicationCharges
		'
		Me.txtMedicationCharges.Location = New System.Drawing.Point(194, 62)
		Me.txtMedicationCharges.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMedicationCharges.Name = "txtMedicationCharges"
		Me.txtMedicationCharges.Size = New System.Drawing.Size(132, 23)
		Me.txtMedicationCharges.TabIndex = 1
		'
		'txtSurgicalCharges
		'
		Me.txtSurgicalCharges.Location = New System.Drawing.Point(194, 94)
		Me.txtSurgicalCharges.Margin = New System.Windows.Forms.Padding(4)
		Me.txtSurgicalCharges.Name = "txtSurgicalCharges"
		Me.txtSurgicalCharges.Size = New System.Drawing.Size(132, 23)
		Me.txtSurgicalCharges.TabIndex = 2
		'
		'txtLabFees
		'
		Me.txtLabFees.Location = New System.Drawing.Point(194, 126)
		Me.txtLabFees.Margin = New System.Windows.Forms.Padding(4)
		Me.txtLabFees.Name = "txtLabFees"
		Me.txtLabFees.Size = New System.Drawing.Size(132, 23)
		Me.txtLabFees.TabIndex = 3
		'
		'txtPhysicalRehabCharges
		'
		Me.txtPhysicalRehabCharges.Location = New System.Drawing.Point(194, 158)
		Me.txtPhysicalRehabCharges.Margin = New System.Windows.Forms.Padding(4)
		Me.txtPhysicalRehabCharges.Name = "txtPhysicalRehabCharges"
		Me.txtPhysicalRehabCharges.Size = New System.Drawing.Size(132, 23)
		Me.txtPhysicalRehabCharges.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(31, 35)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(146, 17)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Length of Stay (Days)"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(98, 67)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 17)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Medication"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(61, 99)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(116, 17)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Surgical Charges"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(109, 131)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(67, 17)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Lab Fees"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(115, 163)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(60, 17)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Physical"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Panel1.Controls.Add(Me.txtLengthOfStay)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.txtSurgicalCharges)
		Me.Panel1.Controls.Add(Me.txtMedicationCharges)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.txtLabFees)
		Me.Panel1.Controls.Add(Me.txtPhysicalRehabCharges)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Location = New System.Drawing.Point(31, 26)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(392, 218)
		Me.Panel1.TabIndex = 10
		'
		'lblMessage
		'
		Me.lblMessage.Location = New System.Drawing.Point(28, 258)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(392, 43)
		Me.lblMessage.TabIndex = 11
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(456, 381)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.txtExit)
		Me.Controls.Add(Me.txtClearForm)
		Me.Controls.Add(Me.btnCalculateCharges)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hospital Charges"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents txtClearForm As System.Windows.Forms.Button
	Friend WithEvents txtExit As System.Windows.Forms.Button
	Friend WithEvents txtLengthOfStay As System.Windows.Forms.TextBox
	Friend WithEvents txtMedicationCharges As System.Windows.Forms.TextBox
	Friend WithEvents txtSurgicalCharges As System.Windows.Forms.TextBox
	Friend WithEvents txtLabFees As System.Windows.Forms.TextBox
	Friend WithEvents txtPhysicalRehabCharges As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
