Public Class Form1
    ' Class-level constants
    Const intMIN_DAYS As Integer = 1            ' Minimum number of days of the trip is 1.
    Const decMEALS_PER_DAY As Decimal = 37D     ' Reimbursement for meals each day is $37.00
    Const decPARKING_PER_DAY As Decimal = 10D   ' Reimbursement for parking each day is $10.00
    Const decTAXI_PER_DAY As Decimal = 20D      ' Reimbursement for taxi each day is $20.00
    Const decLODGING_PER_DAY As Decimal = 95D   ' Reimbursement for lodging each day is $95.00
    Const decCENTS_PER_MILE As Decimal = 0.27D  ' Reimbursement per mile driven is $0.27

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intDays As Integer = 0              ' To hold the number of days of the trip
        Dim intMiles As Integer = 0             ' To hold the number of miles driven in a private vehicle
        Dim decAirfare As Decimal = 0D          ' To hold the amount of airfare
        Dim decCarRental As Decimal = 0D        ' To hold the amount of car rental fees
        Dim decParking As Decimal = 0D          ' To hold the amount of parking fees
        Dim decTaxi As Decimal = 0D             ' To hold the amount of taxi charges
        Dim decRegistration As Decimal = 0D     ' To hold the conference or seminar registration fees
        Dim decLodging As Decimal = 0D          ' To hold the lodging charges per night
        Dim decMeals As Decimal = 0D            ' To hold the amount charged for meals

        Dim decMilesReimbursed As Decimal       ' To hold the amount reimbursed for miles driven in a private vehicle
        Dim decParkingReimbursed As Decimal     ' To hold the amount reimbursed for parking fees
        Dim decTaxiReimbursed As Decimal        ' To hold the amount reimbursed for taxi charges
        Dim decLodgingReimbursed As Decimal     ' To hold the amount reimbursed for lodging
        Dim decMealsReimbursed As Decimal       ' To hold the amount reimbursed for meals

        Dim decParkingSavings As Decimal        ' To hold the amount saved on parking fees
        Dim decTaxiSavings As Decimal           ' To hold the amount saved on taxi charges
        Dim decLodgingSavings As Decimal        ' To hold the amount saved on lodging
        Dim decMealsSavings As Decimal          ' To hold the amount saved on meals

        Dim decParkingExcess As Decimal         ' To hold the amount exceeded on parking fees
        Dim decTaxiExcess As Decimal            ' To hold the amount exceeded on taxi charges
        Dim decLodgingExcess As Decimal         ' To hold the amount exceeded on lodging
        Dim decMealsExcess As Decimal           ' To hold the amount exceeded on meals

        Dim decExpenses As Decimal = 0D         ' To hold the total expenses incurred
        Dim decReimbursements As Decimal = 0D   ' To hold the total allowable expenses for the trip
        Dim decExceedings As Decimal = 0D       ' To hold the excess that must be paid
        Dim decSavings As Decimal = 0D          ' To hold the amount saved if the expenses were under the total

        ' Get the number of days of the trip as input from the user.
        ' Verify that the value is a number and meets the minimum number required.
        If Integer.TryParse(txtDays.Text, intDays) And intDays >= intMIN_DAYS Then

            ' Get the number of miles driven as input from the user, if any.
            ' Verify that the value is either an empty string or a positive whole number.
            If txtMiles.Text = String.Empty OrElse
                Integer.TryParse(txtMiles.Text, intMiles) And intMiles >= 0 Then

                ' Get the amount of airfare as input from the user, if any.
                ' Verify that the value is either an empty string or a positive real number.
                If txtAirfair.Text = String.Empty OrElse
                    Decimal.TryParse(txtAirfair.Text, decAirfare) And decAirfare >= 0 Then

                    ' Get the amount of car rental fees as input from the user, if any.
                    ' Verify that the value is either an empty string or a positive real number.
                    If txtCarRental.Text = String.Empty OrElse
                        Decimal.TryParse(txtCarRental.Text, decCarRental) And decCarRental >= 0 Then

                        ' Get the amount of parking fees as input from the user, if any.
                        ' Verify that the value is either an empty string or a positive real number.
                        If txtParking.Text = String.Empty OrElse
                            Decimal.TryParse(txtParking.Text, decParking) And decParking >= 0 Then

                            ' Get the amount of taxi charges as input from the user, if any.
                            ' Verify that the value is either an empty string or a positive real number.
                            If txtTaxi.Text = String.Empty OrElse
                                Decimal.TryParse(txtTaxi.Text, decTaxi) And decTaxi >= 0 Then

                                ' Get the amount of registration fees as input from the user, if any.
                                ' Verify that the value is either an empty string or a positive real number.
                                If txtRegistration.Text = String.Empty OrElse
                                    Decimal.TryParse(txtRegistration.Text, decRegistration) And decRegistration >= 0 Then

                                    ' Get the amount of lodging charges as input from the user, if any.
                                    ' Verify that the value is either an empty string or a positive real number.
                                    If txtLodging.Text = String.Empty OrElse
                                        Decimal.TryParse(txtLodging.Text, decLodging) And decLodging >= 0 Then

                                        ' Get the amount for meals as input from the user, if any.
                                        ' Verify that the value is either an empty string or a positive real number.
                                        If txtMeals.Text = String.Empty OrElse
                                        Decimal.TryParse(txtMeals.Text, decMeals) And decMeals >= 0 Then

                                            ' Calculate reimbursement for each reimbursable expense.
                                            decMealsReimbursed = CalcMeals(intDays, decMeals)
                                            decParkingReimbursed = CalcParkingFees(intDays, decParking)
                                            decTaxiReimbursed = CalcTaxiFees(intDays, decTaxi)
                                            decLodgingReimbursed = CalcLodging(intDays, decLodging)
                                            decMilesReimbursed = CalcMileage(intMiles)

                                            ' Calculate savings for each reimbursable expense.
                                            decMealsSavings = CalcMealsSavings(intDays, decMeals)
                                            decParkingSavings = CalcParkingSavings(intDays, decParking)
                                            decTaxiSavings = CalcTaxiSavings(intDays, decTaxi)
                                            decLodgingSavings = CalcLodgingSavings(intDays, decLodging)

                                            ' Calculate excess spending for each reimbursable expense.
                                            decMealsExcess = CalcMealsUnallowed(intDays, decMeals)
                                            decParkingExcess = CalcParkingUnallowed(intDays, decParking)
                                            decTaxiExcess = CalcTaxiUnallowed(intDays, decTaxi)
                                            decLodgingExcess = CalcLodgingUnallowed(intDays, decLodging)

                                            ' Calculate the total of all expenses incurred by the business person.
                                            decExpenses = CalcExpenses(intDays, decAirfare, decCarRental, decParking,
                                                                       decTaxi, decRegistration, decLodging, decMeals)

                                            ' Calculate the total amount to be reimbursed for reimbursable expenses.
                                            decReimbursements = CalcTotalReimbursement(decMealsReimbursed, decMilesReimbursed,
                                                                                       decParkingReimbursed, decTaxiReimbursed,
                                                                                       decLodgingReimbursed)

                                            ' Calculate the total amount of excess spending for reimbursable expenses.
                                            decExceedings = CalcUnallowed(decMealsExcess, decParkingExcess,
                                                                          decTaxiExcess, decLodgingExcess)

                                            ' Calculate the total amount of savings for reimbursable expenses.
                                            decSavings = CalcSaved(decMealsSavings, decParkingSavings,
                                                                   decTaxiSavings, decLodgingSavings)

                                            ' Display the information as output to the user.
                                            lblTotalExpenses.Text = decExpenses.ToString("c")
                                            lblTotalReimbursements.Text = decReimbursements.ToString("c")
                                            lblTotalExceedings.Text = decExceedings.ToString("c")
                                            lblTotalSavings.Text = decSavings.ToString("c")

                                        Else
                                            ' Display a message to the user indicating that the amount for meals is invalid.
                                            MessageBox.Show("The amount for meals must be a positive real number." &
                                                            ControlChars.CrLf &
                                                            "You may leave the field blank to specify a zero amount.",
                                                            "Invalid Input")
                                        End If
                                    Else
                                        ' Display a message to the user indicating that the amount for lodging charges is invalid.
                                        MessageBox.Show("The amount for lodging charges per night must be a positive real number." &
                                                        ControlChars.CrLf &
                                                        "You may leave the field blank to specify a zero amount.",
                                                        "Invalid Input")
                                    End If
                                Else
                                    ' Display a message to the user indicating that the amount of registration fees is invalid.
                                    MessageBox.Show("The amount of registration fees must be a positive real number." &
                                                    ControlChars.CrLf &
                                                    "You may leave the field blank to specify a zero amount.",
                                                    "Invalid Input")
                                End If
                            Else
                                ' Display a message to the user indicating that the amount of taxi charges is invalid.
                                MessageBox.Show("The amount of taxi charges must be a positive real number." &
                                                ControlChars.CrLf &
                                                "You may leave the field blank to specify a zero amount.",
                                                "Invalid Input")
                            End If
                        Else
                            ' Display a message to the user indicating that the amount of parking fees is invalid.
                            MessageBox.Show("The amount of parking fees must be a positive real number." &
                                            ControlChars.CrLf &
                                            "You may leave the field blank to specify a zero amount.",
                                            "Invalid Input")
                        End If
                    Else
                        ' Display a message to the user indicating that the amount of car rental fees is invalid.
                        MessageBox.Show("The amount of car rental fees must be a positive real number." &
                                        ControlChars.CrLf &
                                        "You may leave the field blank to specify a zero amount.",
                                        "Invalid Input")
                    End If
                Else
                    ' Display a message to the user indicating that the amount of airfare is invalid.
                    MessageBox.Show("The amount of airfare must be a positive real number." &
                                    ControlChars.CrLf &
                                    "You may leave the field blank to specify a zero amount.",
                                    "Invalid Input")
                End If
            Else
                ' Display a message to the user indicating that the number of miles driven is invalid.
                MessageBox.Show("The number of miles driven must be a positive whole number." &
                                ControlChars.CrLf &
                                "You may leave the field blank to specify a zero amount.",
                                "Invalid Input")
            End If
        Else
            ' Display a message to the user indicating that the number of days of the trip is invalid.
            MessageBox.Show("The number of days of the trip must be a whole number that is at least " &
                             intMIN_DAYS & ".", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text from the text boxes.
        txtDays.Clear()
        txtMiles.Clear()
        txtAirfair.Clear()
        txtCarRental.Clear()
        txtParking.Clear()
        txtTaxi.Clear()
        txtRegistration.Clear()
        txtLodging.Clear()
        txtMeals.Clear()

        ' Set the Text in the labels to an empty string.
        lblTotalExpenses.Text = String.Empty
        lblTotalReimbursements.Text = String.Empty
        lblTotalExceedings.Text = String.Empty
        lblTotalSavings.Text = String.Empty

        ' Give the Focus to the txtDays text box.
        txtDays.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function CalcMeals(ByVal intDays As Integer, ByVal decMeals As Decimal) As Decimal
        ' This function calculates and returns the amount reimbursed for meals.
        Dim decMealsReimbursed As Decimal = intDays * decMEALS_PER_DAY

        If decMeals < decMealsReimbursed Then
            decMealsReimbursed = decMeals
        End If
        Return decMealsReimbursed
    End Function

    Function CalcMealsSavings(ByVal intDays As Integer, ByVal decMeals As Decimal) As Decimal
        ' This function calculates and returns the amount saved on meals.
        Dim decMealsSavings As Decimal = 0D
        Dim decTotalAllowedForReimbursement = intDays * decMEALS_PER_DAY

        If decMeals < decTotalAllowedForReimbursement Then
            decMealsSavings = decTotalAllowedForReimbursement - decMeals
        End If
        Return decMealsSavings
    End Function

    Function CalcMealsUnallowed(ByVal intDays As Integer, ByVal decMeals As Decimal) As Decimal
        ' This function calculates and returns the amount of excess spending on meals.
        Dim decMealsExcess As Decimal = 0D
        Dim decTotalAllowed = intDays * decMEALS_PER_DAY

        If decMeals > decTotalAllowed Then
            decMealsExcess = decMeals - decTotalAllowed
        End If
        Return decMealsExcess
    End Function

    Function CalcMileage(ByVal intMiles As Integer) As Decimal
        ' This function calculates and returns the amount 
        ' reimbursed for mileage driven in a private vehicle.
        Return intMiles * decCENTS_PER_MILE
    End Function

    Function CalcParkingFees(ByVal intDays As Integer, ByVal decParking As Decimal) As Decimal
        ' This function calculates and returns the amount reimbursed for parking fees.
        Dim decParkingReimbursed As Decimal = intDays * decPARKING_PER_DAY

        If decParking < decParkingReimbursed Then
            decParkingReimbursed = decParking
        End If
        Return decParkingReimbursed
    End Function

    Function CalcParkingSavings(ByVal intDays As Integer, ByVal decParking As Decimal) As Decimal
        ' This function calculates and returns the amount saved on parking fees.
        Dim decParkingSavings As Decimal = 0D
        Dim decTotalAllowedForReimbursement = intDays * decPARKING_PER_DAY

        If decParking < decTotalAllowedForReimbursement Then
            decParkingSavings = decTotalAllowedForReimbursement - decParking
        End If
        Return decParkingSavings
    End Function

    Function CalcParkingUnallowed(ByVal intDays As Integer, ByVal decParking As Decimal) As Decimal
        ' This function calculates and returns the amount of excess spending on parking fees.
        Dim decParkingExcess As Decimal = 0D
        Dim decTotalAllowed = intDays * decPARKING_PER_DAY

        If decParking > decTotalAllowed Then
            decParkingExcess = decParking - decTotalAllowed
        End If
        Return decParkingExcess
    End Function

    Function CalcTaxiFees(ByVal intDays As Integer, ByVal decTaxi As Decimal) As Decimal
        ' This function calculates and returns the amount reimbursed for taxi charges.
        Dim decTaxiReimbursed As Decimal = intDays * decTAXI_PER_DAY

        If decTaxi < decTaxiReimbursed Then
            decTaxiReimbursed = decTaxi
        End If
        Return decTaxiReimbursed
    End Function

    Function CalcTaxiSavings(ByVal intDays As Integer, ByVal decTaxi As Decimal) As Decimal
        ' This function calculates and returns the amount saved on taxi charges.
        Dim decTaxiSavings As Decimal = 0D
        Dim decTotalAllowedForReimbursement = intDays * decTAXI_PER_DAY

        If decTaxi < decTotalAllowedForReimbursement Then
            decTaxiSavings = decTotalAllowedForReimbursement - decTaxi
        End If
        Return decTaxiSavings
    End Function

    Function CalcTaxiUnallowed(ByVal intDays As Integer, ByVal decTaxi As Decimal) As Decimal
        ' This function calculates and returns the amount of excess spending on taxi charges.
        Dim decTaxiExcess As Decimal = 0D
        Dim decTotalAllowed = intDays * decTAXI_PER_DAY

        If decTaxi > decTotalAllowed Then
            decTaxiExcess = decTaxi - decTotalAllowed
        End If
        Return decTaxiExcess
    End Function

    Function CalcLodging(ByVal intDays As Integer, ByVal decLodging As Decimal) As Decimal
        ' This function calculates and returns the amount reimbursed for lodging.
        Dim decLodgingReimbursed As Decimal = intDays * decLODGING_PER_DAY

        If decLodging < decLodgingReimbursed Then
            decLodgingReimbursed = decLodging
        End If
        Return decLodgingReimbursed
    End Function

    Function CalcLodgingSavings(ByVal intDays As Integer, ByVal decLodging As Decimal) As Decimal
        ' This function calculates and returns the amount saved on lodging.
        Dim decLodgingSavings As Decimal = 0D
        Dim decTotalAllowedForReimbursement = intDays * decLODGING_PER_DAY

        If decLodging < decTotalAllowedForReimbursement Then
            decLodgingSavings = decTotalAllowedForReimbursement - decLodging
        End If
        Return decLodgingSavings
    End Function

    Function CalcLodgingUnallowed(ByVal intDays As Integer, ByVal decLodging As Decimal) As Decimal
        ' This function calculates and returns the amount of excess spending on lodging.
        Dim decLodgingExcess As Decimal = 0D
        Dim decTotalAllowed = intDays * decLODGING_PER_DAY

        If decLodging > decTotalAllowed Then
            decLodgingExcess = decLodging - decTotalAllowed
        End If
        Return decLodgingExcess
    End Function

    Function CalcTotalReimbursement(ByVal decMealsReimbursed As Decimal, ByVal decMilesReimbursed As Decimal,
                                    ByVal decParkingReimbursed As Decimal, ByVal decTaxiReimbursed As Decimal,
                                    ByVal decLodgingReimbursed As Decimal) As Decimal
        ' This function calculates and returns the total amount reimbursed.
        Return decMealsReimbursed + decMilesReimbursed + decParkingReimbursed + decTaxiReimbursed + decLodgingReimbursed
    End Function

    Function CalcUnallowed(ByVal decMealsExcess As Decimal, ByVal decParkingExcess As Decimal,
                           ByVal decTaxiExcess As Decimal, ByVal decLodgingExcess As Decimal) As Decimal
        ' This function calculates and returns the total amount of expenses that are not allowable.
        Return decMealsExcess + decParkingExcess + decTaxiExcess + decLodgingExcess
    End Function

    Function CalcSaved(ByVal decMealsSavings As Decimal, ByVal decParkingSavings As Decimal,
                       ByVal decTaxiSavings As Decimal, ByVal decLodgingSavings As Decimal) As Decimal
        ' This function calculates and returns the total amount of expenses under the allowable amount.
        Return decMealsSavings + decParkingSavings + decTaxiSavings + decLodgingSavings
    End Function
    Function CalcExpenses(ByVal intDays As Integer, ByVal decAirfare As Decimal, ByVal decCarRental As Decimal,
                          ByVal decParking As Decimal, ByVal decTaxi As Decimal, ByVal decRegistration As Decimal,
                          ByVal decLodging As Decimal, ByVal decMeals As Decimal) As Decimal
        ' This function calculates and returns the total expenses inurred by the business person.
        Return decAirfare + decCarRental + decParking + decTaxi + decRegistration + decLodging * intDays + decMeals
    End Function
End Class
