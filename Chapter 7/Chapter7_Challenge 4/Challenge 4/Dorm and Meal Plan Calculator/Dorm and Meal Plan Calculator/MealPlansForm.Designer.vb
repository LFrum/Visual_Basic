<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealPlansForm
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
        Me.lstMealPlans = New System.Windows.Forms.ListBox()
        Me.btnAddMealPlan = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMealPlans)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Weekly Meal Plan"
        '
        'lstMealPlans
        '
        Me.lstMealPlans.FormattingEnabled = True
        Me.lstMealPlans.Items.AddRange(New Object() {"7 Meals", "14 Meals ", "Unlimited Meals"})
        Me.lstMealPlans.Location = New System.Drawing.Point(15, 28)
        Me.lstMealPlans.Name = "lstMealPlans"
        Me.lstMealPlans.Size = New System.Drawing.Size(120, 56)
        Me.lstMealPlans.TabIndex = 0
        '
        'btnAddMealPlan
        '
        Me.btnAddMealPlan.Location = New System.Drawing.Point(187, 19)
        Me.btnAddMealPlan.Name = "btnAddMealPlan"
        Me.btnAddMealPlan.Size = New System.Drawing.Size(80, 40)
        Me.btnAddMealPlan.TabIndex = 2
        Me.btnAddMealPlan.Text = "&Add Meal Plan"
        Me.btnAddMealPlan.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(187, 65)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MealPlansForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 124)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddMealPlan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MealPlansForm"
        Me.Text = "Meal Plans"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstMealPlans As System.Windows.Forms.ListBox
    Friend WithEvents btnAddMealPlan As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
