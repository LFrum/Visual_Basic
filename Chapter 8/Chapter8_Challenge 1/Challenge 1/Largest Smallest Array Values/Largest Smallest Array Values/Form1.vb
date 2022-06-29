Public Class Form1

	' Create a Class-level Integer array to hold 10 values.
	Const intMAX_SUBSCRIPT As Integer = 9
	Dim intValues(intMAX_SUBSCRIPT) As Integer

	Private Sub btnInputValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInputValues.Click
		' Get the values from the user and display them in the listbox.
		GetInputValues(intValues)
	End Sub

	Private Sub btnDisplayMinAndMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayMinAndMax.Click

		' Calculate and display the minimum and maximum values in the label.
		lblResult.Text = "The largest value is " & Largest(intValues).ToString() &
		 " and the smallest value is " & Smallest(intValues).ToString()
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

		' Clear the Items in the list box.
		lstVals.Items.Clear()
		lblResult.Text = String.Empty
		btnInputValues.Focus()
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		' Close the form.
		Me.Close()
	End Sub
	' The GetDisplayValues procedure accepts an Integer array argument.
	' It fills the array with values entered by the user and displays 
	' those values in the lstInputValues list box.

	Sub GetInputValues(ByRef intValues() As Integer)
		Dim intCount As Integer = 0	' Loop counter, set to 0

		' Clear the Items in the list box.
		lstVals.Items.Clear()

		' Display the title string in the list box.
		lstVals.Items.Add("Input Values")

		' Fill the intValues array with values entered by the user.
		Do While intCount < intValues.Length
			Try
				lblResult.Text = String.Empty

				' Get a value from the user.
				intValues(intCount) =
				 CInt(InputBox("Enter a value", "Value " &
				   (intCount + 1).ToString))

				' Add the value to the lstInputValues list box.
				lstVals.Items.Add(intValues(intCount).ToString())

				' Increment a counter
				intCount += 1

			Catch ex As Exception
				' Display an error message for invalid input.
				lblResult.Text = "Please enter a valid integer."
			End Try
		Loop
	End Sub

	' The Largest function accepts an Integer array as an
	' argument and returns the largest value it contains.
	Function Largest(ByVal intValues() As Integer) As Integer
		Dim intCount As Integer		' Loop counter
		Dim intLargest As Integer	' To hold the largest value

		' Get the first value in the array.
		intLargest = intValues(0)

		' Search for the largest value.
		For intCount = 1 To (intValues.Count - 1)
			If intValues(intCount) > intLargest Then
				intLargest = intValues(intCount)
			End If
		Next
		' Return the largest value.
		Return intLargest
	End Function

	' The Smallest function accepts an Integer array as an
	' argument and returns the smallest value it contains.
	Function Smallest(ByVal intValues() As Integer) As Integer
		Dim intCount As Integer		' Loop counter
		Dim intSmallest As Integer	' To hold the smallest value

		' Get the first value in the array.
		intSmallest = intValues(0)

		' Search for the smallest value.
		For intCount = 1 To (intValues.Count - 1)
			If intValues(intCount) < intSmallest Then
				intSmallest = intValues(intCount)
			End If
		Next
		' Return the smallest value.
		Return intSmallest
	End Function
End Class
