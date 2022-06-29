Module ShoppingCartModule
    ' Global constants for Print Books Price
    Public Const g_decI_DID_IT_YOUR_WAY_PRINT As Decimal = 11.95D
    Public strIDidItYourWayPrint As String = "I Did It Your Way (Print)"
    Public Const g_decTHE_HISTORY_OF_SCOTLAND_PRINT As Decimal = 14.5D
    Public strTheHistoryOfScotlandPrint As String = "The History Of Scotland (Print)"
    Public Const g_decLEARN_CALCULUS_IN_ONE_DAY_PRINT As Decimal = 29.95D
    Public strLearnCalculusInOneDayPrint As String = "Learn Calculus In One Day (Print)"
    Public Const g_decFEEL_THE_STRESS_PRINT As Decimal = 18.5D
    Public strFeelTheStressPrint As String = "Feel the Stress (Print)"

    ' Global constants for Audio Books Price
    Public Const g_decLEARN_CALCULUS_IN_ONE_DAY_AUDIO As Decimal = 29.95D
    Public strLearnCalculusInOneDayAudio As String = "Learn Calculus In One Day (Audio)"
    Public Const g_decRELAXATION_TECHNIQUES_AUDIO As Decimal = 11.5D
    Public strRelaxationTechniquesAudio As String = "Relaxation Techniques (Audio)"
    Public Const g_decTHE_HISTORY_OF_SCOTLAND_AUDIO As Decimal = 14.5D
    Public strTheHistoryOfScotlandAudio As String = "The History Of Scotland (Audio)"
    Public Const g_decTHE_SCIENCE_OF_BODY_LANGUAGE_AUDIO As Decimal = 12.95D
    Public strTheScienceOfBodyLanguageAudio As String = "The Science of Body Language (Audio)"


    Public Const g_decBOOK_TAX As Decimal = 0.06D '6% Tax of the subtotal of the books
    Public Const g_decSHIPPING_CHARGE As Decimal = 2D '$2 charge for each book added to cart

    ' Global variables
    Public g_decSubTotal As Decimal = 0D   ' To hold the charge for the books
    Public g_decShipping As Decimal = 0D   ' To hold the charge for the each book's shipping charge

    Public g_decTax As Decimal

    ' The CalcTotalCharges function calculates and returns the total charges for the books.
    Public Function CalcTotalCharges() As Decimal
        ' Return the total charges for the books.
        Return g_decSubTotal + g_decTax + g_decShipping
    End Function

    ' The ResetCharges procedure resets the dormitory and meal plan charges.
    Public Sub ResetCharges()
        ' Reset the dormitory and meal plan charges.
        g_decSubTotal = 0D
        g_decShipping = 0D
        g_decTax = 0D
    End Sub

    ' The UpdateDisplayTotalCharges procedure updates and 
    ' displays the total charges for the semester.
    Public Sub UpdateDisplayTotalCharges()
        g_decTax = g_decSubTotal * g_decBOOK_TAX 'Calculate the total tax

        ' Update and display the total charges, if any.
        ' Verify that charges are greater than or equal zero.
        'If CalcTotalCharges() >= 0D Then
        frmMain.lblSubtotal.Text = g_decSubTotal.ToString("c")
        frmMain.lblTax.Text = g_decTax.ToString("c")
        frmMain.lblShipping.Text = g_decShipping.ToString("c")
        frmMain.lblTotal.Text = CalcTotalCharges.ToString("c")
        'End If
    End Sub
End Module
