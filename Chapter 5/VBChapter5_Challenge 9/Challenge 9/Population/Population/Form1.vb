Public Class Form1

    Private Sub btnDisplayTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayTable.Click
        Dim intStartingPopulation As Integer    ' The starting number of organisms
        Dim dblAverageDailyIncrease As Double   ' The average daily increase percentage
        Dim intNumberOfDays As Integer          ' The number of days to multiply

        ' Get the starting number of organisms as input from the user.
        If Integer.TryParse(cboStartingNumber.Text, intStartingPopulation) And
            intStartingPopulation >= 2 Then

            ' Get the average daily increase percentage as input from the user.
            If Double.TryParse(txtAverageDailyIncrease.Text, dblAverageDailyIncrease) And
                dblAverageDailyIncrease >= 0.0 Then

                ' Get the number of days to multiply as input from the user.
                If Integer.TryParse(cboNumberDays.Text, intNumberOfDays) And
                    intNumberOfDays >= 0 Then

                    ' Initialize the population with the starting number of organisms.
                    Dim dblPopulation As Double = intStartingPopulation

                    ' Clear the list box before entering the loop.
                    lstOutputData.Items.Clear()

                    ' Determine the approximate population for the number of days to mulitply.
                    For intDay = 1 To intNumberOfDays

                        ' Display the approximate population for the current day in the list box.
                        lstOutputData.Items.Add("Day ...... " & intDay.ToString() & ControlChars.Tab &
                                                "Population ...... " & dblPopulation.ToString("n0"))

                        ' Calculate the approximate population for the next day.
                        dblPopulation += dblPopulation * dblAverageDailyIncrease * 0.01

                    Next
                Else
                    ' Display the error message for the number of days.
                    MessageBox.Show("The number of days to multiply must be a positive whole number.", "Invalid Input")
                End If
            Else
                ' Display the error message for the average daily increase.
                MessageBox.Show("The average daily increase must be a positive real number.", "Invalid Input")
            End If
        Else
            ' Display the error message for the starting number of organisms.
            MessageBox.Show("The starting number of organisms must be a whole number of two or greater.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Items from the list box.
        lstOutputData.Items.Clear()

        ' Reset the Text in the combo boxes.
        cboStartingNumber.ResetText()
        cboNumberDays.ResetText()

        ' Clear the Text from the text box.
        txtAverageDailyIncrease.Clear()

        ' Give the focus to the cboStartingNumber combo box.
        cboStartingNumber.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
