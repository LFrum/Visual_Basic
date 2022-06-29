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
        Me.components = New System.ComponentModel.Container()
        Me.cboStartingNumber = New System.Windows.Forms.ComboBox()
        Me.lstOutputData = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboNumberDays = New System.Windows.Forms.ComboBox()
        Me.btnDisplayTable = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAverageDailyIncrease = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboStartingNumber
        '
        Me.cboStartingNumber.FormattingEnabled = True
        Me.cboStartingNumber.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cboStartingNumber.Location = New System.Drawing.Point(55, 38)
        Me.cboStartingNumber.Name = "cboStartingNumber"
        Me.cboStartingNumber.Size = New System.Drawing.Size(52, 21)
        Me.cboStartingNumber.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cboStartingNumber, "Enter the starting number of organisms.")
        '
        'lstOutputData
        '
        Me.lstOutputData.FormattingEnabled = True
        Me.lstOutputData.HorizontalScrollbar = True
        Me.lstOutputData.Location = New System.Drawing.Point(6, 19)
        Me.lstOutputData.Name = "lstOutputData"
        Me.lstOutputData.Size = New System.Drawing.Size(273, 251)
        Me.lstOutputData.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.lstOutputData, "Population data is displayed in this table.")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 33)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clears all data from the form.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstOutputData)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(460, 283)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Organism Population Data"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Closes the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboNumberDays)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(163, 84)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Number of Days to Multiply"
        '
        'cboNumberDays
        '
        Me.cboNumberDays.FormattingEnabled = True
        Me.cboNumberDays.Items.AddRange(New Object() {"10", "20", "40", "60", "80", "100"})
        Me.cboNumberDays.Location = New System.Drawing.Point(55, 37)
        Me.cboNumberDays.Name = "cboNumberDays"
        Me.cboNumberDays.Size = New System.Drawing.Size(51, 21)
        Me.cboNumberDays.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cboNumberDays, "Enter the number of days that the organisms will multiply.")
        '
        'btnDisplayTable
        '
        Me.btnDisplayTable.Location = New System.Drawing.Point(18, 319)
        Me.btnDisplayTable.Name = "btnDisplayTable"
        Me.btnDisplayTable.Size = New System.Drawing.Size(91, 33)
        Me.btnDisplayTable.TabIndex = 5
        Me.btnDisplayTable.Text = "Display Table"
        Me.ToolTip1.SetToolTip(Me.btnDisplayTable, "Displays information in the table.")
        Me.btnDisplayTable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStartingNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(285, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 79)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Starting Number of Organisms"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAverageDailyIncrease)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 76)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Average Daily Increase"
        '
        'txtAverageDailyIncrease
        '
        Me.txtAverageDailyIncrease.Location = New System.Drawing.Point(55, 38)
        Me.txtAverageDailyIncrease.Name = "txtAverageDailyIncrease"
        Me.txtAverageDailyIncrease.Size = New System.Drawing.Size(52, 20)
        Me.txtAverageDailyIncrease.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtAverageDailyIncrease, "Enter the average daily increase percentage.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 364)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayTable)
        Me.Name = "Form1"
        Me.Text = "Population Calculator"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboStartingNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lstOutputData As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNumberDays As System.Windows.Forms.ComboBox
    Friend WithEvents btnDisplayTable As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAverageDailyIncrease As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
