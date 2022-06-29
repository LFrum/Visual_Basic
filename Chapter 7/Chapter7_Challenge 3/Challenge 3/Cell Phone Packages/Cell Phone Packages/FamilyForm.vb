Public Class FamilyForm

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Local variables
        Dim intPhones As Integer = 0    ' To hold the number of phones.

        ' Get the number of phones as input from the user.
        ' Verify that the value is a positive whole number.
        If Integer.TryParse(txtPhones.Text, intPhones) And intPhones > 0 Then

            ' Display the totals.
            lblPhoneSubtotal.Text = CalcPhoneSubtotal(intPhones).ToString("c")
            lblTax.Text = CalcTax(intPhones).ToString("c")
            lblPhoneTotal.Text = CalcPhoneTotal(intPhones).ToString("c")
            lblOptions.Text = CalcOptions.ToString("c")
            lblPackageCharge.Text = CalcPackage.ToString("c")
            lblTotalMonthlyCharge.Text = CalcTotal(intPhones).ToString("c")
        Else
            ' Display a message to the user indicating that the value for the number of phones is invalid.
            MessageBox.Show("The number of phones must be a positive whole number.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the FamilyForm form.
        Me.Close()
    End Sub

    Function GetPhonePrice() As Decimal
        ' This function determines and returns the selected phone price.
        Dim decPhonePrice As Decimal = 0D

        If radModel100.Checked Then
            decPhonePrice = g_decPHONE_100
        End If

        If radModel110.Checked Then
            decPhonePrice = g_decPHONE_110
        End If

        If radModel200.Checked Then
            decPhonePrice = g_decPHONE_200
        End If

        Return decPhonePrice
    End Function

    Function GetPackagePrice() As Decimal
        ' This function determines and returns the selected package price.
        Dim decPackagePrice As Decimal = 0D

        If rad800MinutesPerMonth.Checked Then
            decPackagePrice = g_decPACKAGE_800
        End If

        If rad1500MinutesPerMonth.Checked Then
            decPackagePrice = g_decPACKAGE_1500
        End If

        If radUnlimitedMinutesPerMonth.Checked Then
            decPackagePrice = g_decPACKAGE_UNLIMITED
        End If

        Return decPackagePrice
    End Function

    Function GetOptionsPrice() As Decimal
        ' This function determines and returns the selected options price.
        Dim decOptionsPrice As Decimal = 0D

        If chkEmail.Checked Then
            decOptionsPrice += g_decOPTION_EMAIL
        End If

        If chkTextMessaging.Checked Then
            decOptionsPrice += g_decOPTION_TEXT
        End If

        Return decOptionsPrice
    End Function

    Function CalcPhoneSubtotal(ByVal intPhones As Integer) As Decimal
        ' This function calculates and returns the phone subtotal based on the number of phones.
        Dim decPhoneSubtotal As Decimal = 0D
        Return GetPhonePrice() * intPhones
    End Function

    Function CalcTax(ByVal intPhones As Integer) As Decimal
        ' This function calculates and returns the phone tax based on the number of phones.
        Return CalcPhoneSubtotal(intPhones) * g_decPHONE_TAX
    End Function

    Function CalcPhoneTotal(ByVal intPhones As Integer) As Decimal
        ' This function calculates and returns the phone total based on the number of phones.
        Return CalcPhoneSubtotal(intPhones) + CalcTax(intPhones)
    End Function

    Function CalcOptions() As Decimal
        ' This function calculates and returns the options total.
        Return GetOptionsPrice()
    End Function

    Function CalcPackage() As Decimal
        ' This function calculates and returns the package total.
        Return GetPackagePrice()
    End Function

    Function CalcTotal(ByVal intPhones As Integer) As Decimal
        ' This function calculates and returns the grand total based on the number of phones.
        Return CalcPhoneTotal(intPhones) + CalcOptions() + CalcPackage()
    End Function
End Class