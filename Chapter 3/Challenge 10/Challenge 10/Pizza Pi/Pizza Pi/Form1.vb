Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a named constant to represent the area of a single slice of pizza.
		Const dblSLICE_AREA As Double = 14.125
		lblStatus.Text = String.Empty

		Try
			' Get the diameter of the pizza from the user.
			Dim dblDiameter As Double = CDbl(txtDiameter.Text)

			' Calculate the radius of the pizza.
			Dim dblRadius As Double = dblDiameter * 0.5
			' Calculate the area of the pizza.
			Dim dblArea As Double = Math.PI * dblRadius * dblRadius
			' Calculate the number of slices.
			Dim intSlices As Integer = CInt(dblArea / dblSLICE_AREA)

			' Display the result to the user.
			lblSlices.Text = intSlices.ToString()
		Catch
			lblStatus.Text = "Please input a number"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtDiameter text box.
        txtDiameter.Clear()

        ' Set the Text in the lblSlices label to an empty string.
		lblSlices.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtDiameter.
        txtDiameter.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
