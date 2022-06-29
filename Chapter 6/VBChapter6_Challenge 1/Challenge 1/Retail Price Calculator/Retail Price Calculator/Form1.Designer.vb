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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
		Me.txtMarkupPercentage = New System.Windows.Forms.TextBox()
		Me.lblRetailPrice = New System.Windows.Forms.Label()
		Me.btnGetRetail = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(48, 23)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 16)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Wholesale Cost of Item"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(131, 57)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 16)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Markup %"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(121, 90)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(77, 16)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Retail Price"
		'
		'txtWholesaleCost
		'
		Me.txtWholesaleCost.Location = New System.Drawing.Point(211, 20)
		Me.txtWholesaleCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtWholesaleCost.Name = "txtWholesaleCost"
		Me.txtWholesaleCost.Size = New System.Drawing.Size(79, 22)
		Me.txtWholesaleCost.TabIndex = 0
		'
		'txtMarkupPercentage
		'
		Me.txtMarkupPercentage.Location = New System.Drawing.Point(211, 53)
		Me.txtMarkupPercentage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtMarkupPercentage.Name = "txtMarkupPercentage"
		Me.txtMarkupPercentage.Size = New System.Drawing.Size(79, 22)
		Me.txtMarkupPercentage.TabIndex = 1
		'
		'lblRetailPrice
		'
		Me.lblRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRetailPrice.Location = New System.Drawing.Point(211, 90)
		Me.lblRetailPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblRetailPrice.Name = "lblRetailPrice"
		Me.lblRetailPrice.Size = New System.Drawing.Size(80, 25)
		Me.lblRetailPrice.TabIndex = 7
		Me.lblRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnGetRetail
		'
		Me.btnGetRetail.Location = New System.Drawing.Point(51, 148)
		Me.btnGetRetail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnGetRetail.Name = "btnGetRetail"
		Me.btnGetRetail.Size = New System.Drawing.Size(115, 39)
		Me.btnGetRetail.TabIndex = 2
		Me.btnGetRetail.Text = "&Get Retail"
		Me.btnGetRetail.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(175, 148)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(115, 39)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(339, 202)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnGetRetail)
		Me.Controls.Add(Me.lblRetailPrice)
		Me.Controls.Add(Me.txtMarkupPercentage)
		Me.Controls.Add(Me.txtWholesaleCost)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Retail Price Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWholesaleCost As System.Windows.Forms.TextBox
    Friend WithEvents txtMarkupPercentage As System.Windows.Forms.TextBox
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents btnGetRetail As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
