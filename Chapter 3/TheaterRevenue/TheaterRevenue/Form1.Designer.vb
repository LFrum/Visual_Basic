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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdultPriceTicket = New System.Windows.Forms.TextBox()
        Me.txtAdultTicketsSold = New System.Windows.Forms.TextBox()
        Me.txtChildPriceTicket = New System.Windows.Forms.TextBox()
        Me.txtChildTicketsSold = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAdultGrossRevenue = New System.Windows.Forms.Label()
        Me.lblChildGrossRevenue = New System.Windows.Forms.Label()
        Me.lblTotalGrossRevenue = New System.Windows.Forms.Label()
        Me.lblTotalNetRevenue = New System.Windows.Forms.Label()
        Me.lblChildNetRevenue = New System.Windows.Forms.Label()
        Me.lblAdultNetRevenue = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotalSoldTickets = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultTicketsSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultPriceTicket)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price per Ticket:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildTicketsSold)
        Me.GroupBox2.Controls.Add(Me.txtChildPriceTicket)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 116)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblChildGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblAdultGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 188)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalNetRevenue)
        Me.GroupBox4.Controls.Add(Me.lblChildNetRevenue)
        Me.GroupBox4.Controls.Add(Me.lblAdultNetRevenue)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(529, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(378, 188)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(73, 415)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(279, 48)
        Me.btnCalculate.TabIndex = 23
        Me.btnCalculate.Text = "Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(424, 415)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(175, 48)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(690, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 48)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price per Ticket:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tickets Sold:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tickets Sold:"
        '
        'txtAdultPriceTicket
        '
        Me.txtAdultPriceTicket.Location = New System.Drawing.Point(200, 34)
        Me.txtAdultPriceTicket.Name = "txtAdultPriceTicket"
        Me.txtAdultPriceTicket.Size = New System.Drawing.Size(135, 22)
        Me.txtAdultPriceTicket.TabIndex = 1
        Me.txtAdultPriceTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdultTicketsSold
        '
        Me.txtAdultTicketsSold.Location = New System.Drawing.Point(200, 79)
        Me.txtAdultTicketsSold.Name = "txtAdultTicketsSold"
        Me.txtAdultTicketsSold.Size = New System.Drawing.Size(135, 22)
        Me.txtAdultTicketsSold.TabIndex = 3
        Me.txtAdultTicketsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChildPriceTicket
        '
        Me.txtChildPriceTicket.Location = New System.Drawing.Point(161, 34)
        Me.txtChildPriceTicket.Name = "txtChildPriceTicket"
        Me.txtChildPriceTicket.Size = New System.Drawing.Size(134, 22)
        Me.txtChildPriceTicket.TabIndex = 5
        Me.txtChildPriceTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChildTicketsSold
        '
        Me.txtChildTicketsSold.Location = New System.Drawing.Point(161, 77)
        Me.txtChildTicketsSold.Name = "txtChildTicketsSold"
        Me.txtChildTicketsSold.Size = New System.Drawing.Size(134, 22)
        Me.txtChildTicketsSold.TabIndex = 7
        Me.txtChildTicketsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adult Ticket Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Child Ticket Sales:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 34)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total Gross Revenue " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Ticket Sales:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdultGrossRevenue
        '
        Me.lblAdultGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultGrossRevenue.Location = New System.Drawing.Point(200, 43)
        Me.lblAdultGrossRevenue.Name = "lblAdultGrossRevenue"
        Me.lblAdultGrossRevenue.Size = New System.Drawing.Size(135, 20)
        Me.lblAdultGrossRevenue.TabIndex = 9
        Me.lblAdultGrossRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChildGrossRevenue
        '
        Me.lblChildGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildGrossRevenue.Location = New System.Drawing.Point(200, 86)
        Me.lblChildGrossRevenue.Name = "lblChildGrossRevenue"
        Me.lblChildGrossRevenue.Size = New System.Drawing.Size(135, 20)
        Me.lblChildGrossRevenue.TabIndex = 11
        Me.lblChildGrossRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalGrossRevenue
        '
        Me.lblTotalGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossRevenue.Location = New System.Drawing.Point(200, 140)
        Me.lblTotalGrossRevenue.Name = "lblTotalGrossRevenue"
        Me.lblTotalGrossRevenue.Size = New System.Drawing.Size(135, 20)
        Me.lblTotalGrossRevenue.TabIndex = 13
        Me.lblTotalGrossRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalNetRevenue
        '
        Me.lblTotalNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNetRevenue.Location = New System.Drawing.Point(161, 140)
        Me.lblTotalNetRevenue.Name = "lblTotalNetRevenue"
        Me.lblTotalNetRevenue.Size = New System.Drawing.Size(135, 20)
        Me.lblTotalNetRevenue.TabIndex = 19
        Me.lblTotalNetRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChildNetRevenue
        '
        Me.lblChildNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildNetRevenue.Location = New System.Drawing.Point(161, 85)
        Me.lblChildNetRevenue.Name = "lblChildNetRevenue"
        Me.lblChildNetRevenue.Size = New System.Drawing.Size(135, 20)
        Me.lblChildNetRevenue.TabIndex = 17
        Me.lblChildNetRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdultNetRevenue
        '
        Me.lblAdultNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultNetRevenue.Location = New System.Drawing.Point(161, 42)
        Me.lblAdultNetRevenue.Name = "lblAdultNetRevenue"
        Me.lblAdultNetRevenue.Size = New System.Drawing.Size(135, 20)
        Me.lblAdultNetRevenue.TabIndex = 15
        Me.lblAdultNetRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 34)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Total Net Revenue " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Ticket Sales:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Child Ticket Sales:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Adult Ticket Sales:"
        '
        'lblTotalSoldTickets
        '
        Me.lblTotalSoldTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSoldTickets.Location = New System.Drawing.Point(531, 369)
        Me.lblTotalSoldTickets.Name = "lblTotalSoldTickets"
        Me.lblTotalSoldTickets.Size = New System.Drawing.Size(294, 20)
        Me.lblTotalSoldTickets.TabIndex = 22
        Me.lblTotalSoldTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(217, 369)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(135, 20)
        Me.lblDate.TabIndex = 21
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(106, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Today's Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(941, 492)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotalSoldTickets)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue by Lince Rumainum"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAdultTicketsSold As TextBox
    Friend WithEvents txtAdultPriceTicket As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtChildTicketsSold As TextBox
    Friend WithEvents txtChildPriceTicket As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalGrossRevenue As Label
    Friend WithEvents lblChildGrossRevenue As Label
    Friend WithEvents lblAdultGrossRevenue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalNetRevenue As Label
    Friend WithEvents lblChildNetRevenue As Label
    Friend WithEvents lblAdultNetRevenue As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTotalSoldTickets As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label10 As Label
End Class
