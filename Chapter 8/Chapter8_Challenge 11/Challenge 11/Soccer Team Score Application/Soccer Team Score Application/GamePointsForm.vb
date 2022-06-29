Public Class GamePointsForm

	Private Sub GamePointsForm_Load() Handles MyBase.Load
		' Clear the Items in the list box.
		lstNames.Items.Clear()

		' Display the player names.
		For Each player As String In g_lstNames
			lstNames.Items.Add(player)
		Next
	End Sub

	Private Sub btnOk_Click() Handles btnOk.Click

		Dim intIndex As Integer			' To hold the selected index
		lblMessage.Text = String.Empty

		' Get the selected index
		intIndex = lstNames.SelectedIndex
		If intIndex = -1 Then
			lblMessage.Text = "Please select a player from the list box"
			Return
		End If

		Dim score As Integer

		If Integer.TryParse(txtPoints.Text, score) And score >= 0 Then
			g_lstScores(intIndex) = score
			lblMessage.Text = g_lstNames(intIndex) & " scored " & score & " points."
			txtPoints.Clear()
		Else
			' Display a message box to the user indicating that the score was invalid.
			lblMessage.Text = "Enter a number that is greater than or equal to zero."
		End If

	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
		' Close the GamePointsForm form.
		Me.Close()
	End Sub

End Class