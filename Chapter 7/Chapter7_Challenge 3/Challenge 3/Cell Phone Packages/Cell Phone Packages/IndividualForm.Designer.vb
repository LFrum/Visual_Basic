<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPhoneSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblPackageCharge = New System.Windows.Forms.Label()
        Me.lblTotalMonthlyCharge = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTextMessaging = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radUnlimitedMinutesPerMonth = New System.Windows.Forms.RadioButton()
        Me.rad1500MinutesPerMonth = New System.Windows.Forms.RadioButton()
        Me.rad800MinutesPerMonth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 250)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 40)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 204)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 40)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPhoneSubtotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblPhoneTotal)
        Me.GroupBox4.Controls.Add(Me.lblOptions)
        Me.GroupBox4.Controls.Add(Me.lblPackageCharge)
        Me.GroupBox4.Controls.Add(Me.lblTotalMonthlyCharge)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(132, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(190, 170)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totals"
        '
        'lblPhoneSubtotal
        '
        Me.lblPhoneSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneSubtotal.Location = New System.Drawing.Point(120, 18)
        Me.lblPhoneSubtotal.Name = "lblPhoneSubtotal"
        Me.lblPhoneSubtotal.Size = New System.Drawing.Size(64, 20)
        Me.lblPhoneSubtotal.TabIndex = 11
        Me.lblPhoneSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(120, 41)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(64, 20)
        Me.lblTax.TabIndex = 10
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Location = New System.Drawing.Point(120, 64)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(64, 20)
        Me.lblPhoneTotal.TabIndex = 9
        Me.lblPhoneTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(120, 87)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions.TabIndex = 8
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPackageCharge
        '
        Me.lblPackageCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageCharge.Location = New System.Drawing.Point(120, 110)
        Me.lblPackageCharge.Name = "lblPackageCharge"
        Me.lblPackageCharge.Size = New System.Drawing.Size(64, 20)
        Me.lblPackageCharge.TabIndex = 7
        Me.lblPackageCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalMonthlyCharge
        '
        Me.lblTotalMonthlyCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMonthlyCharge.Location = New System.Drawing.Point(120, 133)
        Me.lblTotalMonthlyCharge.Name = "lblTotalMonthlyCharge"
        Me.lblTotalMonthlyCharge.Size = New System.Drawing.Size(64, 20)
        Me.lblTotalMonthlyCharge.TabIndex = 6
        Me.lblTotalMonthlyCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Monthly Charge"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Package Charge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Options"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phone Subtotal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTextMessaging)
        Me.GroupBox3.Controls.Add(Me.chkEmail)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(114, 74)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Options"
        '
        'chkTextMessaging
        '
        Me.chkTextMessaging.AutoSize = True
        Me.chkTextMessaging.Location = New System.Drawing.Point(7, 43)
        Me.chkTextMessaging.Name = "chkTextMessaging"
        Me.chkTextMessaging.Size = New System.Drawing.Size(101, 17)
        Me.chkTextMessaging.TabIndex = 1
        Me.chkTextMessaging.Text = "Text Messaging"
        Me.chkTextMessaging.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(7, 20)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(51, 17)
        Me.chkEmail.TabIndex = 0
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUnlimitedMinutesPerMonth)
        Me.GroupBox2.Controls.Add(Me.rad1500MinutesPerMonth)
        Me.GroupBox2.Controls.Add(Me.rad800MinutesPerMonth)
        Me.GroupBox2.Location = New System.Drawing.Point(132, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Package"
        '
        'radUnlimitedMinutesPerMonth
        '
        Me.radUnlimitedMinutesPerMonth.AutoSize = True
        Me.radUnlimitedMinutesPerMonth.Location = New System.Drawing.Point(6, 66)
        Me.radUnlimitedMinutesPerMonth.Name = "radUnlimitedMinutesPerMonth"
        Me.radUnlimitedMinutesPerMonth.Size = New System.Drawing.Size(159, 17)
        Me.radUnlimitedMinutesPerMonth.TabIndex = 3
        Me.radUnlimitedMinutesPerMonth.TabStop = True
        Me.radUnlimitedMinutesPerMonth.Text = "Unlimited Minutes per Month"
        Me.radUnlimitedMinutesPerMonth.UseVisualStyleBackColor = True
        '
        'rad1500MinutesPerMonth
        '
        Me.rad1500MinutesPerMonth.AutoSize = True
        Me.rad1500MinutesPerMonth.Location = New System.Drawing.Point(6, 43)
        Me.rad1500MinutesPerMonth.Name = "rad1500MinutesPerMonth"
        Me.rad1500MinutesPerMonth.Size = New System.Drawing.Size(140, 17)
        Me.rad1500MinutesPerMonth.TabIndex = 2
        Me.rad1500MinutesPerMonth.TabStop = True
        Me.rad1500MinutesPerMonth.Text = "1500 Minutes per Month"
        Me.rad1500MinutesPerMonth.UseVisualStyleBackColor = True
        '
        'rad800MinutesPerMonth
        '
        Me.rad800MinutesPerMonth.AutoSize = True
        Me.rad800MinutesPerMonth.Checked = True
        Me.rad800MinutesPerMonth.Location = New System.Drawing.Point(6, 19)
        Me.rad800MinutesPerMonth.Name = "rad800MinutesPerMonth"
        Me.rad800MinutesPerMonth.Size = New System.Drawing.Size(134, 17)
        Me.rad800MinutesPerMonth.TabIndex = 1
        Me.rad800MinutesPerMonth.TabStop = True
        Me.rad800MinutesPerMonth.Text = "800 Mintues per Month"
        Me.rad800MinutesPerMonth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radModel200)
        Me.GroupBox1.Controls.Add(Me.radModel110)
        Me.GroupBox1.Controls.Add(Me.radModel100)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.AutoSize = True
        Me.radModel200.Location = New System.Drawing.Point(7, 66)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.Size = New System.Drawing.Size(75, 17)
        Me.radModel200.TabIndex = 2
        Me.radModel200.TabStop = True
        Me.radModel200.Text = "Model 200"
        Me.radModel200.UseVisualStyleBackColor = True
        '
        'radModel110
        '
        Me.radModel110.AutoSize = True
        Me.radModel110.Location = New System.Drawing.Point(7, 43)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.Size = New System.Drawing.Size(75, 17)
        Me.radModel110.TabIndex = 1
        Me.radModel110.TabStop = True
        Me.radModel110.Text = "Model 110"
        Me.radModel110.UseVisualStyleBackColor = True
        '
        'radModel100
        '
        Me.radModel100.AutoSize = True
        Me.radModel100.Checked = True
        Me.radModel100.Location = New System.Drawing.Point(7, 20)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.Size = New System.Drawing.Size(75, 17)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = True
        '
        'IndividualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 304)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IndividualForm"
        Me.Text = "Individual Plan"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPhoneSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblPhoneTotal As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblPackageCharge As System.Windows.Forms.Label
    Friend WithEvents lblTotalMonthlyCharge As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTextMessaging As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radUnlimitedMinutesPerMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rad1500MinutesPerMonth As System.Windows.Forms.RadioButton
    Friend WithEvents rad800MinutesPerMonth As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radModel200 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel110 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel100 As System.Windows.Forms.RadioButton
End Class
