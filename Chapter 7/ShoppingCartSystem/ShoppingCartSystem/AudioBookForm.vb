Public Class frmAudioBook
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddBookToCart_Click(sender As Object, e As EventArgs) Handles btnAddBookToCart.Click
        Dim intIndex As Integer
        intIndex = lstAudioBook.SelectedIndex

        ' Determine which print book was selected from the lstPrintBook list box.
        Select Case intIndex
            Case 0
                g_decSubTotal += g_decLEARN_CALCULUS_IN_ONE_DAY_AUDIO       ' Apply the charge for I Did It Your Way
                frmMain.lstProductsSelected.Items.Add(strLearnCalculusInOneDayAudio)
            Case 1
                g_decSubTotal += g_decRELAXATION_TECHNIQUES_AUDIO  ' Apply the charge for The History of Scotland
                frmMain.lstProductsSelected.Items.Add(strRelaxationTechniquesAudio)
            Case 2
                g_decSubTotal += g_decTHE_HISTORY_OF_SCOTLAND_AUDIO    ' Apply the charge for Learn Calculus in One Day
                frmMain.lstProductsSelected.Items.Add(strTheHistoryOfScotlandAudio)
            Case 3
                g_decSubTotal += g_decTHE_SCIENCE_OF_BODY_LANGUAGE_AUDIO         ' Apply the charge for Feel The Stress
                frmMain.lstProductsSelected.Items.Add(strTheScienceOfBodyLanguageAudio)
            Case Else
                ' Display a message to the user indicating that an audio book selection is needed.
                MessageBox.Show("Select a audio book from the list.", "Selection Needed")
        End Select

        g_decShipping += g_decSHIPPING_CHARGE
        CalcTotalCharges()
        UpdateDisplayTotalCharges()
    End Sub

End Class