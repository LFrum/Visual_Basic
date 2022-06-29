Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decRate As Decimal
        Dim intMinutes As Integer
        Dim decTotalCost As Decimal
        Dim strEmail As String
        Dim strConfirmEmail As String
        Dim strRateChosen As String = "daytime rate"
        Dim blnInputOk As Boolean = True

        'Constants for rate category
        Const decDAYTIME_RATE As Decimal = 0.07
        Const decEVENING_RATE As Decimal = 0.12
        Const decOFFPEAK_RATE As Decimal = 0.05

        'Start with default white background text color
        txtEmail.BackColor = Color.White
        txtConfirmEmail.BackColor = Color.White
        txtMinutes.BackColor = Color.White

        'Start with empty labels
        lblDisplayInfo.Text = String.Empty

        'Convert email input to lower case
        strEmail = txtEmail.Text.ToUpper()
        strConfirmEmail = txtConfirmEmail.Text.ToUpper()

        'Validate and convert the number of minutes used
        If Integer.TryParse(txtMinutes.Text, intMinutes) = False Then
            blnInputOk = False
            MessageBox.Show("Error: Number of minutes must be numeric")
            txtMinutes.Focus()
            txtMinutes.BackColor = Color.Yellow
        End If
        'Validate the number of minutes used is greater than 0
        If intMinutes < 1 Or intMinutes > 20000 Then
            blnInputOk = False
            MessageBox.Show("Error: Number of minutes must be > 0 and < 20000")
            txtMinutes.Focus()
            txtMinutes.BackColor = Color.Yellow
        End If

        'Validate the e-mail entered correctly with "@" or "."
        If strEmail.IndexOf("@") = -1 Or strEmail.IndexOf(".") = -1 Then
            blnInputOk = False
            MessageBox.Show("Error: Invalid e-mail input! Check for @ or .")
            txtEmail.Focus()
            txtEmail.BackColor = Color.Yellow
        End If

        'Validate the e-mail entered correctly with "@" or "."
        If strConfirmEmail.IndexOf("@") = -1 Or strConfirmEmail.IndexOf(".") = -1 Then
            blnInputOk = False
            MessageBox.Show("Error: Invalid e-mail confirmation input! Check for @ or .")
            txtConfirmEmail.Focus()
            txtConfirmEmail.BackColor = Color.Yellow
        End If

        'Compare the e-mails
        If strEmail.Trim() <> strConfirmEmail.Trim() Then
            blnInputOk = False
            txtEmail.Focus()
            MessageBox.Show("Error: E-mail inputs does not match!")
        End If

        If blnInputOk = True Then
            'Determine the rate charges
            If radDaytime.Checked = True Then
                decRate = decDAYTIME_RATE
                strRateChosen = "daytime rate"
            ElseIf radEvening.Checked = True Then
                decRate = decEVENING_RATE
                strRateChosen = "evening rate"
            ElseIf radOffPeak.Checked = True Then
                decRate = decOFFPEAK_RATE
                strRateChosen = "off-peak rate"
            End If

            'Calculate the total rate charges
            decTotalCost = CDec(decRate * intMinutes)

            'Display e-mail input
            lblDisplayInfo.Text = "The rate category selected: " + strRateChosen +
            ". The minutes used: " + intMinutes.ToString("n0") + " minutes. The total bill: " + decTotalCost.ToString("c") + "." +
            ControlChars.CrLf + "The bill will be sent to the email address: " + strEmail + "."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all input & output 
        txtEmail.Clear()
        txtConfirmEmail.Clear()
        txtMinutes.Clear()

        lblDisplayInfo.Text = String.Empty

        'Reset text background color
        txtEmail.BackColor = Color.White
        txtConfirmEmail.BackColor = Color.White
        txtMinutes.BackColor = Color.White
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class