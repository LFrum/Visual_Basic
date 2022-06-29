<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembership = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipListAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipFileMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipAddNewMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsAllMembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(49, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 115)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(14, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 80)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kyoshi Karate School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Management System 1.0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMembership, Me.mnuPayments})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuMembership
        '
        Me.mnuMembership.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMembershipListAll, Me.mnuMembershipFileMember, Me.mnuMembershipAddNewMember})
        Me.mnuMembership.Name = "mnuMembership"
        Me.mnuMembership.Size = New System.Drawing.Size(104, 24)
        Me.mnuMembership.Text = "&Membership"
        '
        'mnuMembershipListAll
        '
        Me.mnuMembershipListAll.Name = "mnuMembershipListAll"
        Me.mnuMembershipListAll.Size = New System.Drawing.Size(206, 26)
        Me.mnuMembershipListAll.Text = "&List all"
        '
        'mnuMembershipFileMember
        '
        Me.mnuMembershipFileMember.Name = "mnuMembershipFileMember"
        Me.mnuMembershipFileMember.Size = New System.Drawing.Size(206, 26)
        Me.mnuMembershipFileMember.Text = "F&ile Member"
        '
        'mnuMembershipAddNewMember
        '
        Me.mnuMembershipAddNewMember.Name = "mnuMembershipAddNewMember"
        Me.mnuMembershipAddNewMember.Size = New System.Drawing.Size(206, 26)
        Me.mnuMembershipAddNewMember.Text = "Add &New Member"
        '
        'mnuPayments
        '
        Me.mnuPayments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentsAllMembers})
        Me.mnuPayments.Name = "mnuPayments"
        Me.mnuPayments.Size = New System.Drawing.Size(84, 24)
        Me.mnuPayments.Text = "&Payments"
        '
        'mnuPaymentsAllMembers
        '
        Me.mnuPaymentsAllMembers.Name = "mnuPaymentsAllMembers"
        Me.mnuPaymentsAllMembers.Size = New System.Drawing.Size(168, 26)
        Me.mnuPaymentsAllMembers.Text = "All Mem&bers"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 273)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate Queries by Lince Rumainum"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuMembership As ToolStripMenuItem
    Friend WithEvents mnuMembershipListAll As ToolStripMenuItem
    Friend WithEvents mnuMembershipFileMember As ToolStripMenuItem
    Friend WithEvents mnuMembershipAddNewMember As ToolStripMenuItem
    Friend WithEvents mnuPayments As ToolStripMenuItem
    Friend WithEvents mnuPaymentsAllMembers As ToolStripMenuItem

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMembershipListAll_Click(sender As Object, e As EventArgs) Handles mnuMembershipListAll.Click
        'Create an instance of AllMebmersForm
        Dim frmAllMembers As New AllMembersForm

        'Display the form.
        frmAllMembers.ShowDialog()
    End Sub
End Class
