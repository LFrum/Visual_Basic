Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare named constants for the monthly charge and check fees.
        Const dblMONTHLY_CHARGE As Double = 10.0    ' $10.00 monthly charge
        Const dblTEN_CENTS As Double = 0.1          ' $0.10 each for less than 20 checks
        Const dblEIGHT_CENTS As Double = 0.08       ' $0.08 each for 20 through 39 checks
        Const dblSIX_CENTS As Double = 0.06         ' $0.06 each for 40 through 59 checks
        Const dblFOUR_CENTS As Double = 0.04        ' $0.04 each for 60 or more checks

        ' Declare a variable to hold the number of checks written.
        Dim intNumChecks As Integer
        ' Declare a variable to hold the check fees.
        Dim dblCheckFees As Double
        ' Declare a variable to hold the total fees.
        Dim dblTotalFees As Double

        ' Get the number of checks written as input from the user.
        If Integer.TryParse(txtNumChecks.Text, intNumChecks) And
            IsNumeric(txtNumChecks.Text) And intNumChecks >= 0 Then

            ' Determine the check fees based on the number of checks written.
            Select Case intNumChecks
                Case Is < 20
                    ' Check fees are $0.10 per check.
                    dblCheckFees = dblTEN_CENTS
                Case 20 To 39
                    ' Check fees are $0.08 per check.
                    dblCheckFees = dblEIGHT_CENTS
                Case 40 To 59
                    ' Check fees are $0.06 per check.
                    dblCheckFees = dblSIX_CENTS
                Case Is > 59
                    ' Check fees are $0.04 per check.
                    dblCheckFees = dblFOUR_CENTS
            End Select

            ' Calculate the total fees.
            dblTotalFees = intNumChecks * dblCheckFees + dblMONTHLY_CHARGE

            ' Display the total fees as output to the user.
            lblTotalFees.Text = dblTotalFees.ToString("c")

        Else
            ' Display a message box to the user indicating that the input for the number of checks is invalid.
            MessageBox.Show("Number of Checks - The value must be a positive whole number.", "Invalid Input")
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in txtNumChecks.
        txtNumChecks.Clear()

        ' Set the Text in lblTotalFees to an empty string.
        lblTotalFees.Text = String.Empty

        ' Give the focus to txtNumChecks.
        txtNumChecks.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
