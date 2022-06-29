Public Class MainForm

    Private Sub MainForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' Clear the Items in the list box.
        lstPlayerNames.Items.Clear()

		' Display the player names.
		For Each player As String In g_lstNames
			lstPlayerNames.Items.Add(player)
		Next
	End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub

    Private Sub mnuPlayersUpdateNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlayersUpdateNames.Click
        ' Display the PlayerForm form.
        Dim frmPlayer As New PlayerForm
        frmPlayer.ShowDialog()
    End Sub

    Private Sub mnuGameUpdateGamePoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGameUpdateGamePoints.Click
        ' Display the GamePointsForm form.
        Dim frmGamePoints As New GamePointsForm
        frmGamePoints.ShowDialog()
    End Sub

    Private Sub mnuGameDisplayPlayerPoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGameDisplayPlayerPoints.Click
        ' Display the PlayerPointsForm form.
        Dim frmPlayerPoints As New PlayerPointsForm
        frmPlayerPoints.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        ' Display the About message box.
        MessageBox.Show("Soccer Team Score Application", "About")
    End Sub
End Class
