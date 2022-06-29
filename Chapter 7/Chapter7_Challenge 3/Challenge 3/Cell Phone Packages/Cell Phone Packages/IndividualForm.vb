Public Class IndividualForm

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Display the totals.
        lblPhoneSubtotal.Text = CalcPhoneSubtotal.ToString("c")
        lblTax.Text = CalcTax.ToString("c")
        lblPhoneTotal.Text = CalcPhoneTotal.ToString("c")
        lblOptions.Text = CalcOptions.ToString("c")
        lblPackageCharge.Text = CalcPackage.ToString("c")
        lblTotalMonthlyCharge.Text = CalcTotal.ToString("c")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the IndividualForm form.
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

    Function CalcPhoneSubtotal() As Decimal
        ' This function calculates and returns the phone subtotal.
        Dim decPhoneSubtotal As Decimal = 0D
        Return GetPhonePrice()
    End Function

    Function CalcTax() As Decimal
        ' This function calculates and returns the phone tax.
        Return CalcPhoneSubtotal() * g_decPHONE_TAX
    End Function

    Function CalcPhoneTotal() As Decimal
        ' This function calculates and returns the phone total.
        Return CalcPhoneSubtotal() + CalcTax()
    End Function

    Function CalcOptions() As Decimal
        ' This function calculates and returns the options total.
        Return GetOptionsPrice()
    End Function

    Function CalcPackage() As Decimal
        ' This function calculates and returns the package total.
        Return GetPackagePrice()
    End Function

    Function CalcTotal() As Decimal
        ' This function calculates and returns the grand total.
        Return CalcPhoneTotal() + CalcOptions() + CalcPackage()
    End Function
End Class