Public Class frmMain
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        'Reset the forms and charges
        ResetForm()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            Select Case lstProductsSelected.SelectedItem.ToString()
                Case strIDidItYourWayPrint
                    g_decSubTotal -= g_decI_DID_IT_YOUR_WAY_PRINT
                Case strTheHistoryOfScotlandPrint
                    g_decSubTotal -= g_decTHE_HISTORY_OF_SCOTLAND_PRINT
                Case strLearnCalculusInOneDayPrint
                    g_decSubTotal -= g_decLEARN_CALCULUS_IN_ONE_DAY_PRINT
                Case strFeelTheStressPrint
                    g_decSubTotal -= g_decFEEL_THE_STRESS_PRINT
                Case strLearnCalculusInOneDayAudio
                    g_decSubTotal -= g_decLEARN_CALCULUS_IN_ONE_DAY_AUDIO
                Case strRelaxationTechniquesAudio
                    g_decSubTotal -= g_decRELAXATION_TECHNIQUES_AUDIO
                Case strTheHistoryOfScotlandAudio
                    g_decSubTotal -= g_decTHE_HISTORY_OF_SCOTLAND_AUDIO
                Case strTheScienceOfBodyLanguageAudio
                    g_decSubTotal -= g_decTHE_SCIENCE_OF_BODY_LANGUAGE_AUDIO
            End Select

            g_decShipping -= g_decSHIPPING_CHARGE
            UpdateDisplayTotalCharges()

            lstProductsSelected.Items.Remove(lstProductsSelected.SelectedItem)
        Catch
            MessageBox.Show("Please select an item!")
        End Try
    End Sub

    Private Sub mnuProductsPrintBooks_Click(sender As Object, e As EventArgs) Handles mnuProductsPrintBooks.Click
        ' Create an instance of the PrintBookForm.
        Dim frmPrintBook As New frmPrintBook

        ' Display the PrintBookForm.
        frmPrintBook.ShowDialog()
    End Sub

    Private Sub mnuProductsAudioBooks_Click(sender As Object, e As EventArgs) Handles mnuProductsAudioBooks.Click
        ' Create an instance of the AudioBookForm.
        Dim frmAudioBook As New frmAudioBook

        ' Display the AudioBookForm.
        frmAudioBook.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Create an instance of the ShoppingCartAboutForm.
        Dim frmShoppingCartAbout As New frmAbout

        ' Display the ShoppingCartAboutForm.
        frmShoppingCartAbout.Show()
    End Sub

    ' The ResetForm procedure clears the Text and Selected Items from
    ' the MainForm form and resets the charges for the semester.
    Private Sub ResetForm()

        ' Clear the the Products from the list box.
        lstProductsSelected.Items.Clear()

        ' Set the Text in the labels to an empty string.
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Reset the charges.
        ResetCharges()
    End Sub

End Class