Public Class frmPrintBook
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddBookToCart_Click(sender As Object, e As EventArgs) Handles btnAddBookToCart.Click
        Dim intIndex As Integer
        intIndex = lstPrintBook.SelectedIndex

        ' Determine which print book was selected from the lstPrintBook list box.
        Select Case intIndex
            Case 0
                g_decSubTotal += g_decI_DID_IT_YOUR_WAY_PRINT       ' Apply the charge for I Did It Your Way
                frmMain.lstProductsSelected.Items.Add(strIDidItYourWayPrint)
            Case 1
                g_decSubTotal += g_decTHE_HISTORY_OF_SCOTLAND_PRINT  ' Apply the charge for The History of Scotland
                frmMain.lstProductsSelected.Items.Add(strTheHistoryOfScotlandPrint)
            Case 2
                g_decSubTotal += g_decLEARN_CALCULUS_IN_ONE_DAY_PRINT    ' Apply the charge for Learn Calculus in One Day
                frmMain.lstProductsSelected.Items.Add(strLearnCalculusInOneDayPrint)
            Case 3
                g_decSubTotal += g_decFEEL_THE_STRESS_PRINT           ' Apply the charge for Feel The Stress
                frmMain.lstProductsSelected.Items.Add(strFeelTheStressPrint)
            Case Else
                ' Display a message to the user indicating that an print book selection is needed.
                MessageBox.Show("Select a print book from the list.", "Selection Needed")
        End Select

        g_decShipping += g_decSHIPPING_CHARGE
        CalcTotalCharges()
        UpdateDisplayTotalCharges()
    End Sub
End Class