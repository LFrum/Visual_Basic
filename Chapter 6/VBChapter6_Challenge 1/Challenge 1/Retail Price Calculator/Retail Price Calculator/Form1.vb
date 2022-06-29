Public Class Form1

    Private Sub btnGetRetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetRetail.Click
        ' Local variable declarations
        Dim dblWholesaleCost As Double      ' To hold the wholesale cost
        Dim dblMarkupPercentage As Double   ' To hold the markup percentage
        Dim dblRetailPrice As Double        ' To hold the retail price

        ' Get the whole sale cost as input from the user.
        ' Verify that the value is numeric and not negative.
        If Double.TryParse(txtWholesaleCost.Text, dblWholesaleCost) And
            IsNumeric(dblWholesaleCost) And dblWholesaleCost > 0.0 Then

            ' Get the markup percentage as input from the user.
            ' Verify that the value is numeric and not negative.
            If Double.TryParse(txtMarkupPercentage.Text, dblMarkupPercentage) And
                IsNumeric(dblMarkupPercentage) And dblMarkupPercentage > 0.0 Then

                ' Call the CalculateRetail function and store its return value.
                dblRetailPrice = CalculateRetail(dblWholesaleCost, dblMarkupPercentage)

                ' Display the retail cost as output to the user.
                lblRetailPrice.Text = dblRetailPrice.ToString("c")
            Else
                ' Display a message to the user indicating that the value for the markup percentage is not valid.
                MessageBox.Show("The markup percentage must be a real number that is greater than zero.", "Invalid Input")
            End If
        Else
            ' Display a message to the user indicating that the value for the wholesale cost is not valid.
            MessageBox.Show("The wholesale cost must be a real number that is greater than zero.", "Invalid Input")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function CalculateRetail(ByVal dblWholeSaleCost As Double, ByVal dblMarkupPercentage As Double) As Double
        ' Calculate and return the retail price.
        Return dblWholeSaleCost + dblWholeSaleCost * dblMarkupPercentage * 0.01
    End Function
End Class
