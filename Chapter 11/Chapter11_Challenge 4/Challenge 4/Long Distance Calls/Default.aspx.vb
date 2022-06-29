
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Give the focus to txtMinutes
        txtMinutes.Focus()
    End Sub

    Protected Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the long distance rates.
        Const dblRATE_DAYTIME As Double = 0.07  ' $0.07 per minute for the daytime rate.
        Const dblRATE_EVENING As Double = 0.12  ' $0.12 per minute for the evening rate.
        Const dblRATE_OFF_PEAK As Double = 0.05 ' $0.05 per minute for the off-peak rate.

        ' Declare a variable to hold the minutes of the call.
        Dim dblMinutes As Double

        ' Declare a variable to hold the selected rate of the call.
        Dim dblRate As Double

        ' Declare a variable to hold the total charge of the call.
        Dim dblTotalCharge As Double

        ' Get the number of minutes of the call as input from the user.
        If Double.TryParse(txtMinutes.Text, dblMinutes) And
            IsNumeric(txtMinutes.Text) And dblMinutes > 0.0 Then

            ' Determine which rate was selected by the user.
            If radCategories.SelectedIndex = 0 Then
                dblRate = dblRATE_DAYTIME   ' The daytime rate was selected.
            ElseIf radCategories.SelectedIndex = 1 Then
                dblRate = dblRATE_EVENING   ' The evening rate was selected.
            ElseIf radCategories.SelectedIndex = 2 Then
                dblRate = dblRATE_OFF_PEAK  ' The off-peak rate was selected.
            End If

            ' Calcuate the total charge by multiplying the minutes by the rate.
            dblTotalCharge = dblMinutes * dblRate

            ' Display the result to the user in the lblTotalCharge label.
            lblTotalCharge.Text = dblTotalCharge.ToString("c")
        Else
            ' Display a message to the user indicating the input entered for the minutes is invalid.
            lblMessage.Text = "Minutes must be a number greater than zero."
        End If
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Reset the radio button list to the first selection.
        radCategories.SelectedIndex = 0

        ' Clear the Text in the txtMinutes text box.
        txtMinutes.Text = String.Empty

        ' Set the Text in the lblTotalCharge label to an empty string.
        lblTotalCharge.Text = String.Empty

        ' Clear the message.
        lblMessage.Text = String.Empty

        ' Give the focus to txtMinutes.
        txtMinutes.Focus()
    End Sub
End Class
