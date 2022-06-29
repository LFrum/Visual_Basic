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
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnEnterData = New System.Windows.Forms.Button()
		Me.lstGrades = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(145, 103)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 39)
		Me.btnExit.TabIndex = 5
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnEnterData
		'
		Me.btnEnterData.Location = New System.Drawing.Point(39, 103)
		Me.btnEnterData.Name = "btnEnterData"
		Me.btnEnterData.Size = New System.Drawing.Size(100, 39)
		Me.btnEnterData.TabIndex = 4
		Me.btnEnterData.Text = "&Enter Data"
		Me.btnEnterData.UseVisualStyleBackColor = True
		'
		'lstGrades
		'
		Me.lstGrades.FormattingEnabled = True
		Me.lstGrades.Location = New System.Drawing.Point(12, 12)
		Me.lstGrades.Name = "lstGrades"
		Me.lstGrades.Size = New System.Drawing.Size(260, 69)
		Me.lstGrades.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 154)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnEnterData)
		Me.Controls.Add(Me.lstGrades)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Grade Report"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEnterData As System.Windows.Forms.Button
    Friend WithEvents lstGrades As System.Windows.Forms.ListBox

End Class
