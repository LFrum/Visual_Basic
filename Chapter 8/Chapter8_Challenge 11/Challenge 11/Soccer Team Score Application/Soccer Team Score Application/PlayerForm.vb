Public Class PlayerForm

	Private Sub PlayerForm_Load() Handles MyBase.Load
		' Clear the Items in the list box.
		lstPlayerNames.Items.Clear()

		' Display the player names.
		For Each player As String In g_lstNames
			lstPlayerNames.Items.Add(player)
		Next
	End Sub

	Private Sub btnClear_Click() Handles btnClear.Click
		' Clear the team.
		ClearTeam()
	End Sub

	' The ClearTeam procedure clears the names and scores of the players.
    Sub ClearTeam()

		lstPlayerNames.Items.Clear()
		g_lstNames.Clear()
		g_lstScores.Clear()

	End Sub

	Private Sub btnAdd_Click() Handles btnAdd.Click

		' Add the name and score (zero for now) to the global lists.
		g_lstNames.Add(txtName.Text)
		g_lstScores.Add(0)

		' Add the name to the list box
		lstPlayerNames.Items.Add(txtName.Text)
		txtName.Clear()
		txtName.Focus()

	End Sub

	Private Sub btnClose_Click() Handles btnClose.Click
		' Close the PlayerForm form.
		Me.Close()
	End Sub

End Class