Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare a named constant for the force of gravity.
        Const dblGRAVITY As Double = 9.8        ' Earth's gravity is 9.8 newtons per kilogram.

        ' Declare named constants for the weight limits.
        Const dblTOO_HEAVY As Double = 1000.0   ' More than 1,000 newtons is too heavy.
        Const dblTOO_LIGHT As Double = 10.0     ' Less than 10 newtons is too light.

        ' Declare a variable to hold the mass of the object.
        Dim dblMass As Double

        ' Declare a variable to hold the weight of the object.
        Dim dblWeight As Double

        ' Get the mass of the object in kilograms as input from the user.
        If Double.TryParse(txtMass.Text, dblMass) And
            IsNumeric(txtMass.Text) And dblMass > 0.0 Then

            ' Calculate the weight of the object.
            ' Formula: Weight = Mass x Gravity
            dblWeight = dblMass * dblGRAVITY

            ' Display the result in the lblWeight label as output to the user.
            lblWeight.Text = dblWeight.ToString("n2")

            ' Determine if the weight of the object is too heavy or too light.
            Select Case dblWeight
                Case Is > dblTOO_HEAVY  ' The weight of the object is too heavy.

                    ' Display a message to the user indicating that the object is too heavy.
                    MessageBox.Show("The object is too heavy.", "Object Weight")

                Case Is < dblTOO_LIGHT  ' The weight of the object is too light.

                    ' Display a message to the user indicating that the object is too light.
                    MessageBox.Show("The object is too light.", "Object Weight")
            End Select
        Else
            ' Display a message to the user indicating that the input for weight is invalid.
            MessageBox.Show("Weight - The value must be a real number that is greater than zero.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the txtMass text box.
        txtMass.Clear()

        ' Set the Text in the lblWeight label to an empty string.
        lblWeight.Text = String.Empty

        ' Give the focus to the txtMass text box.
        txtMass.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
