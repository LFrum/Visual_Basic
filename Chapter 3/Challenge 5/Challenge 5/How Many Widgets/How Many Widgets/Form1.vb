Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a constant for the weight of a single widget.
		Const dblSINGLE_WIDGET_WEIGHT As Double = 9.2

		Try
			lblStatus.Text = String.Empty

			' Get the weight of the pallet as input from the user.
			Dim dblPalletWeight As Double = CDbl(txtPalletWeight.Text)

			' Get the weight of the pallet and widgets as input from the user.
			Dim dblPalletAndWidgetsWeight As Double = CDbl(txtPalletAndWidgetsWeight.Text)

			' Calculate the total weight of all the widgets minus the weight of the pallet.
			Dim dblTotalWidgetWeight = dblPalletAndWidgetsWeight - dblPalletWeight

			' Calculate the number of widgets by dividing the total weight of all the 
			' widgets by the weight of a single widget.
			Dim intNumWidgets As Integer = CInt(dblTotalWidgetWeight / dblSINGLE_WIDGET_WEIGHT)

			' Display the number of widgets to the user.
			lblNumWidgets.Text = intNumWidgets.ToString
		Catch
			lblStatus.Text = "Input values must be numeric"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the text boxes.
        txtPalletWeight.Clear()
        txtPalletAndWidgetsWeight.Clear()

        ' Empty the text for lblNumWidgets.
		lblNumWidgets.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtPallet.
        txtPalletWeight.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
