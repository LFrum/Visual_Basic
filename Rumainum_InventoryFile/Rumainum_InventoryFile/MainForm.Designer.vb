<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.lblRetail = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblInvoiceNumber = New System.Windows.Forms.Label()
        Me.lstInvNumber = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.lblOnHand)
        Me.grpInventory.Controls.Add(Me.lblRetail)
        Me.grpInventory.Controls.Add(Me.lblCost)
        Me.grpInventory.Controls.Add(Me.lblDescription)
        Me.grpInventory.Controls.Add(Me.lblInvoiceNumber)
        Me.grpInventory.Controls.Add(Me.lstInvNumber)
        Me.grpInventory.Controls.Add(Me.Label5)
        Me.grpInventory.Controls.Add(Me.Label4)
        Me.grpInventory.Controls.Add(Me.Label3)
        Me.grpInventory.Controls.Add(Me.Label2)
        Me.grpInventory.Controls.Add(Me.Label1)
        Me.grpInventory.Location = New System.Drawing.Point(10, 12)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(740, 278)
        Me.grpInventory.TabIndex = 0
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Inventory"
        '
        'lblOnHand
        '
        Me.lblOnHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOnHand.Location = New System.Drawing.Point(371, 195)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(60, 25)
        Me.lblOnHand.TabIndex = 9
        '
        'lblRetail
        '
        Me.lblRetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetail.Location = New System.Drawing.Point(371, 155)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(80, 25)
        Me.lblRetail.TabIndex = 8
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCost.Location = New System.Drawing.Point(371, 115)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(80, 25)
        Me.lblCost.TabIndex = 7
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(371, 75)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(360, 25)
        Me.lblDescription.TabIndex = 6
        '
        'lblInvoiceNumber
        '
        Me.lblInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInvoiceNumber.Location = New System.Drawing.Point(371, 35)
        Me.lblInvoiceNumber.Name = "lblInvoiceNumber"
        Me.lblInvoiceNumber.Size = New System.Drawing.Size(83, 25)
        Me.lblInvoiceNumber.TabIndex = 5
        '
        'lstInvNumber
        '
        Me.lstInvNumber.FormattingEnabled = True
        Me.lstInvNumber.ItemHeight = 16
        Me.lstInvNumber.Location = New System.Drawing.Point(17, 31)
        Me.lstInvNumber.Name = "lstInvNumber"
        Me.lstInvNumber.Size = New System.Drawing.Size(166, 228)
        Me.lstInvNumber.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(240, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OnHand: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(240, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Retail: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(240, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(240, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Number: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(170, 305)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add new inventory")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(330, 305)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 25)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "&Update"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Update existing inventory")
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(490, 305)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 25)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "&Display"
        Me.ToolTip1.SetToolTip(Me.btnDisplay, "Display the existing inventory")
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(10, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save the new updated data ")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(650, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the inventory file")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 352)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpInventory)
        Me.Name = "frmMain"
        Me.Text = "Inventory File by Lince Rumainum"
        Me.grpInventory.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents lblOnHand As Label
    Friend WithEvents lblRetail As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblInvoiceNumber As Label
    Friend WithEvents lstInvNumber As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
