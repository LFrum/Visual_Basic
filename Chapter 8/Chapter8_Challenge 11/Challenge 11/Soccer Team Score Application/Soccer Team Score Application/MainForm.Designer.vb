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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lstPlayerNames = New System.Windows.Forms.ListBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPlayers = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPlayersUpdateNames = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuGame = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuGameUpdateGamePoints = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuGameDisplayPlayerPoints = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupBox1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.lstPlayerNames)
		Me.GroupBox1.Location = New System.Drawing.Point(21, 34)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(317, 155)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Player Names"
		'
		'lstPlayerNames
		'
		Me.lstPlayerNames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lstPlayerNames.FormattingEnabled = True
		Me.lstPlayerNames.ItemHeight = 16
		Me.lstPlayerNames.Location = New System.Drawing.Point(37, 23)
		Me.lstPlayerNames.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.lstPlayerNames.Name = "lstPlayerNames"
		Me.lstPlayerNames.Size = New System.Drawing.Size(250, 116)
		Me.lstPlayerNames.TabIndex = 0
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuPlayers, Me.mnuGame, Me.mnuHelp})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(351, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(37, 20)
		Me.mnuFile.Text = "&File"
		'
		'mnuFileExit
		'
		Me.mnuFileExit.Name = "mnuFileExit"
		Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.mnuFileExit.Size = New System.Drawing.Size(133, 22)
		Me.mnuFileExit.Text = "E&xit"
		'
		'mnuPlayers
		'
		Me.mnuPlayers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlayersUpdateNames})
		Me.mnuPlayers.Name = "mnuPlayers"
		Me.mnuPlayers.Size = New System.Drawing.Size(49, 20)
		Me.mnuPlayers.Text = "Team"
		'
		'mnuPlayersUpdateNames
		'
		Me.mnuPlayersUpdateNames.Name = "mnuPlayersUpdateNames"
		Me.mnuPlayersUpdateNames.Size = New System.Drawing.Size(179, 22)
		Me.mnuPlayersUpdateNames.Text = "Add/Modify players"
		'
		'mnuGame
		'
		Me.mnuGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGameUpdateGamePoints, Me.mnuGameDisplayPlayerPoints})
		Me.mnuGame.Name = "mnuGame"
		Me.mnuGame.Size = New System.Drawing.Size(50, 20)
		Me.mnuGame.Text = "&Game"
		'
		'mnuGameUpdateGamePoints
		'
		Me.mnuGameUpdateGamePoints.Name = "mnuGameUpdateGamePoints"
		Me.mnuGameUpdateGamePoints.Size = New System.Drawing.Size(183, 22)
		Me.mnuGameUpdateGamePoints.Text = "Update &Game Points"
		'
		'mnuGameDisplayPlayerPoints
		'
		Me.mnuGameDisplayPlayerPoints.Name = "mnuGameDisplayPlayerPoints"
		Me.mnuGameDisplayPlayerPoints.Size = New System.Drawing.Size(183, 22)
		Me.mnuGameDisplayPlayerPoints.Text = "Display &Player Points"
		'
		'mnuHelp
		'
		Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
		Me.mnuHelp.Text = "&Help"
		'
		'mnuHelpAbout
		'
		Me.mnuHelpAbout.Name = "mnuHelpAbout"
		Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
		Me.mnuHelpAbout.Text = "&About"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(351, 202)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Soccer Team Scores"
		Me.GroupBox1.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstPlayerNames As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlayers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlayersUpdateNames As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGameUpdateGamePoints As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGameDisplayPlayerPoints As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem

End Class
