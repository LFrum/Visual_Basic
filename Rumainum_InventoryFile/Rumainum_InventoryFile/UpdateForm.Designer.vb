<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblInvoiceNumber = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(316, 283)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(166, 283)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 25)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.txtOnHand)
        Me.grpInventory.Controls.Add(Me.txtRetail)
        Me.grpInventory.Controls.Add(Me.txtCost)
        Me.grpInventory.Controls.Add(Me.txtDescription)
        Me.grpInventory.Controls.Add(Me.lblInvoiceNumber)
        Me.grpInventory.Controls.Add(Me.Label5)
        Me.grpInventory.Controls.Add(Me.Label4)
        Me.grpInventory.Controls.Add(Me.Label3)
        Me.grpInventory.Controls.Add(Me.Label2)
        Me.grpInventory.Controls.Add(Me.Label1)
        Me.grpInventory.Location = New System.Drawing.Point(21, 23)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(561, 244)
        Me.grpInventory.TabIndex = 4
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Inventory"
        '
        'txtOnHand
        '
        Me.txtOnHand.Location = New System.Drawing.Point(145, 187)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.Size = New System.Drawing.Size(72, 22)
        Me.txtOnHand.TabIndex = 3
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(145, 147)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(93, 22)
        Me.txtRetail.TabIndex = 2
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(145, 113)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(93, 22)
        Me.txtCost.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(145, 75)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(378, 22)
        Me.txtDescription.TabIndex = 0
        '
        'lblInvoiceNumber
        '
        Me.lblInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInvoiceNumber.Location = New System.Drawing.Point(145, 38)
        Me.lblInvoiceNumber.Name = "lblInvoiceNumber"
        Me.lblInvoiceNumber.Size = New System.Drawing.Size(60, 25)
        Me.lblInvoiceNumber.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OnHand: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Retail: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Number: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 320)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.grpInventory)
        Me.Name = "frmUpdate"
        Me.Text = "UpdateForm"
        Me.grpInventory.ResumeLayout(False)
        Me.grpInventory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents txtOnHand As TextBox
    Friend WithEvents txtRetail As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblInvoiceNumber As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
