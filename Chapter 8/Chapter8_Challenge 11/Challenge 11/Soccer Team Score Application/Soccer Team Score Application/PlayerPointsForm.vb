Public Class PlayerPointsForm

	Private Sub PlayerPointsForm_Load() Handles MyBase.Load
		' Display the player names and points.

		lstNames.Items.Clear()
		Dim intSum As Integer = 0

		' Display the player names and points
		For intCount = 0 To g_lstNames.Count - 1

			' Add the player name and points to the list box.
			lstNames.Items.Add(g_lstNames(intCount))
			lstPoints.Items.Add(g_lstScores(intCount).ToString)
			intSum += g_lstScores(intCount)

		Next

		lblTotal.Text = "Total team points: " & intSum
	End Sub

	Private Sub btnClose_Click() Handles btnClose.Click

		Me.Close()
	End Sub

End Class