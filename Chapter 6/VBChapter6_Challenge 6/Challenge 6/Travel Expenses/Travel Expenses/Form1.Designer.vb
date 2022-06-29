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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalSavings = New System.Windows.Forms.Label()
        Me.lblTotalExceedings = New System.Windows.Forms.Label()
        Me.lblTotalReimbursements = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAirfair = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.txtRegistration = New System.Windows.Forms.TextBox()
        Me.txtTaxi = New System.Windows.Forms.TextBox()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.txtCarRental = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Airfare     $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Car Rental Fees     $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Parking Fees     $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Taxi Charges     $"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Registration Fees     $"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Lodging per Night     $"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalSavings)
        Me.GroupBox1.Controls.Add(Me.lblTotalExceedings)
        Me.GroupBox1.Controls.Add(Me.lblTotalReimbursements)
        Me.GroupBox1.Controls.Add(Me.lblTotalExpenses)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(260, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 203)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'lblTotalSavings
        '
        Me.lblTotalSavings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSavings.Location = New System.Drawing.Point(127, 130)
        Me.lblTotalSavings.Name = "lblTotalSavings"
        Me.lblTotalSavings.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalSavings.TabIndex = 7
        Me.lblTotalSavings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalExceedings
        '
        Me.lblTotalExceedings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalExceedings.Location = New System.Drawing.Point(127, 104)
        Me.lblTotalExceedings.Name = "lblTotalExceedings"
        Me.lblTotalExceedings.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalExceedings.TabIndex = 5
        Me.lblTotalExceedings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalReimbursements
        '
        Me.lblTotalReimbursements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalReimbursements.Location = New System.Drawing.Point(127, 78)
        Me.lblTotalReimbursements.Name = "lblTotalReimbursements"
        Me.lblTotalReimbursements.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalReimbursements.TabIndex = 3
        Me.lblTotalReimbursements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalExpenses.Location = New System.Drawing.Point(127, 52)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalExpenses.TabIndex = 1
        Me.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Savings:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Exceedings:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Reimbursements:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Expenses:"
        '
        'txtAirfair
        '
        Me.txtAirfair.Location = New System.Drawing.Point(137, 68)
        Me.txtAirfair.Name = "txtAirfair"
        Me.txtAirfair.Size = New System.Drawing.Size(80, 20)
        Me.txtAirfair.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtMiles)
        Me.GroupBox2.Controls.Add(Me.txtMeals)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtDays)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtLodging)
        Me.GroupBox2.Controls.Add(Me.txtRegistration)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTaxi)
        Me.GroupBox2.Controls.Add(Me.txtParking)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCarRental)
        Me.GroupBox2.Controls.Add(Me.txtAirfair)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 260)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Private Vehicle Miles"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(137, 42)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(80, 20)
        Me.txtMiles.TabIndex = 3
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(137, 224)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(80, 20)
        Me.txtMeals.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(75, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Meals     $"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(137, 16)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(80, 20)
        Me.txtDays.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Travel Days"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(137, 198)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(80, 20)
        Me.txtLodging.TabIndex = 15
        '
        'txtRegistration
        '
        Me.txtRegistration.Location = New System.Drawing.Point(137, 172)
        Me.txtRegistration.Name = "txtRegistration"
        Me.txtRegistration.Size = New System.Drawing.Size(80, 20)
        Me.txtRegistration.TabIndex = 13
        '
        'txtTaxi
        '
        Me.txtTaxi.Location = New System.Drawing.Point(137, 146)
        Me.txtTaxi.Name = "txtTaxi"
        Me.txtTaxi.Size = New System.Drawing.Size(80, 20)
        Me.txtTaxi.TabIndex = 11
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(137, 120)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(80, 20)
        Me.txtParking.TabIndex = 9
        '
        'txtCarRental
        '
        Me.txtCarRental.Location = New System.Drawing.Point(137, 94)
        Me.txtCarRental.Name = "txtCarRental"
        Me.txtCarRental.Size = New System.Drawing.Size(80, 20)
        Me.txtCarRental.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(263, 238)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 39)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(344, 238)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 39)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 238)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 294)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Travel Expenses Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalSavings As System.Windows.Forms.Label
    Friend WithEvents lblTotalExceedings As System.Windows.Forms.Label
    Friend WithEvents lblTotalReimbursements As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAirfair As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLodging As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistration As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxi As System.Windows.Forms.TextBox
    Friend WithEvents txtParking As System.Windows.Forms.TextBox
    Friend WithEvents txtCarRental As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtMeals As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox

End Class
