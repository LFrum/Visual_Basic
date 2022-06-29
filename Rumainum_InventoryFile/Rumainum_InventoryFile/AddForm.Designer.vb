<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.txtInvNumber = New System.Windows.Forms.TextBox()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
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
        Me.btnClose.Location = New System.Drawing.Point(299, 279)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 25)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(149, 279)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.txtInvNumber)
        Me.grpInventory.Controls.Add(Me.txtOnHand)
        Me.grpInventory.Controls.Add(Me.txtRetail)
        Me.grpInventory.Controls.Add(Me.txtCost)
        Me.grpInventory.Controls.Add(Me.txtDescription)
        Me.grpInventory.Controls.Add(Me.Label5)
        Me.grpInventory.Controls.Add(Me.Label4)
        Me.grpInventory.Controls.Add(Me.Label3)
        Me.grpInventory.Controls.Add(Me.Label2)
        Me.grpInventory.Controls.Add(Me.Label1)
        Me.grpInventory.Location = New System.Drawing.Point(12, 21)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(548, 239)
        Me.grpInventory.TabIndex = 8
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Inventory"
        '
        'txtInvNumber
        '
        Me.txtInvNumber.Location = New System.Drawing.Point(137, 37)
        Me.txtInvNumber.Name = "txtInvNumber"
        Me.txtInvNumber.Size = New System.Drawing.Size(72, 22)
        Me.txtInvNumber.TabIndex = 0
        '
        'txtOnHand
        '
        Me.txtOnHand.Location = New System.Drawing.Point(137, 187)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.Size = New System.Drawing.Size(72, 22)
        Me.txtOnHand.TabIndex = 4
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(137, 147)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(93, 22)
        Me.txtRetail.TabIndex = 3
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(137, 113)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(93, 22)
        Me.txtCost.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(137, 75)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(378, 22)
        Me.txtDescription.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OnHand: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Retail: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Number: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 318)
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmAdd"
        Me.Text = "AddForm"
        Me.grpInventory.ResumeLayout(False)
        Me.grpInventory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents txtOnHand As TextBox
    Friend WithEvents txtRetail As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInvNumber As TextBox
End Class
