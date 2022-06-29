Public Class Form1

	Const dblCHARGE_PER_DAY As Double = 350.0	' The charge per day for the hosptial stay

	Private intLengthOfStay As Integer			' To hold the number of days in the hospital
	Private dblMedicationCharges As Double		' To hold the medication charges
	Private dblSurgicalCharges As Double		' To hold the surgical charges
	Private dblLabFees As Double				' To hold the lab fees
	Private dblPhysicalRehabCharges As Double	' To hold the physical rehabilitation charges

	Private Function ValidateInputFields() As Boolean
		'Use a common pattern for validating input fields: Try to parse the
		'field from a string into a number; then check the number's range.
		'If any validation fails, display a helpful message and return False
		'without checking any other fields.

		lblMessage.Text = String.Empty

		If Not Integer.TryParse(txtLengthOfStay.Text, intLengthOfStay) OrElse
	   intLengthOfStay < 0.0 Then
			lblMessage.Text = "The length of stay must be a positive integer."
			Return False
		End If

		If Not Double.TryParse(txtMedicationCharges.Text, dblMedicationCharges) OrElse
		  dblMedicationCharges < 0.0 Then
			lblMessage.Text = "The medication charges must be a positive real number."
			Return False
		End If

		If Not Double.TryParse(txtSurgicalCharges.Text, dblSurgicalCharges) OrElse
		 dblSurgicalCharges < 0.0 Then
			lblMessage.Text = "The surgical charges must be a positive real number."
			Return False
		End If

		If Not Double.TryParse(txtLabFees.Text, dblLabFees) OrElse
		 dblLabFees < 0.0 Then

			lblMessage.Text = "The lab fees must be a positive real number."
			Return False
		End If

		If Not Double.TryParse(txtPhysicalRehabCharges.Text, dblPhysicalRehabCharges) OrElse
	   dblPhysicalRehabCharges < 0.0 Then
			lblMessage.Text = "The physical rehabilitation charges must " &
			 "be a positive real number."
			Return False
		End If

		'If the following line is reached, all input fields must be valid.
		Return True
	End Function

	Private Sub btnCalculateCharges_Click() Handles btnCalculateCharges.Click
		' Local variable declarations
		Dim dblStayCharges As Double			' To hold the base charges for the hospital stay
		Dim dblMiscCharges As Double			' To hold the total of miscelaneous charges
		Dim dblTotalCharges As Double			' To hold the total charges

		If ValidateInputFields() Then

			'All input fields are assumed to be valid at this point, so now we can
			'calculate and display the charges.

			dblStayCharges = CalcStayCharges(intLengthOfStay, dblCHARGE_PER_DAY)

			dblMiscCharges = CalcMiscCharges(dblMedicationCharges, dblSurgicalCharges,
			 dblLabFees, dblPhysicalRehabCharges)

			dblTotalCharges = CalcTotalCharges(dblStayCharges, dblMiscCharges)

			lblMessage.Text = "Total Cost: " & dblTotalCharges.ToString("c")
		End If

	End Sub

    Private Sub txtClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClearForm.Click
        ' Clear the Text of the text boxes.
        txtLengthOfStay.Clear()
        txtMedicationCharges.Clear()
        txtSurgicalCharges.Clear()
        txtLabFees.Clear()
        txtPhysicalRehabCharges.Clear()

        ' Set the Text of the lblTotalCharges label to an empty string.
		lblMessage.Text = String.Empty

        ' Give the focus to the txtDaysInHospital text box.
        txtLengthOfStay.Focus()
    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function CalcStayCharges(ByVal dblLengthOfStay As Double, ByVal dblChargePerDay As Double) As Double
        ' Calculate and return the base charges for the hospital stay.
        Return dblLengthOfStay * dblChargePerDay
    End Function

    Function CalcMiscCharges(ByVal dblMedicationCharges As Double, ByVal dblSurgicalCharges As Double,
                             ByVal dblLabFees As Double, ByVal dblPhysicalRehabCharges As Double) As Double
        ' Calculate and return the total of the medication, surgical, lab, 
        ' and physical rehabilitation charges.
        Return dblMedicationCharges + dblSurgicalCharges + dblLabFees + dblPhysicalRehabCharges
    End Function

    Function CalcTotalCharges(ByVal dblStayCharges As Double, ByVal dblMiscCharges As Double) As Double
        ' Calculate and return the total charges.
        Return dblStayCharges + dblMiscCharges
    End Function
End Class
