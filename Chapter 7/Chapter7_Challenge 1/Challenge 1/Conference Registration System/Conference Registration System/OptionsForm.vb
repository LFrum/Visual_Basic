Public Class OptionsForm
    ' Class-level constants
    Const decREGISTRATION As Decimal = 895D         ' The regular registration fee
    Const decOPTIONAL_DINNER As Decimal = 30D       ' The optional dinner fee
    Const decOPTIONAL_ECOMMERSE As Decimal = 295D   ' The optional E-commerse workshop fee
    Const decOPTIONAL_WEB As Decimal = 295D         ' The optional web workshop fee
    Const decOPTIONAL_VB As Decimal = 395D          ' The optional VB workshop fee
    Const decOPTIONAL_NETWORK As Decimal = 395D     ' The optional network workshop fee
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Reset the OptionsForm form.
        Reset()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the OptionsForm form.
        Me.Close()
    End Sub

    Sub Reset()
        ' The procedure resets the OptionsForm form.

        ' Uncheck the check boxes.
        chkOptionalDinner.Checked = False
        chkRegistration.Checked = False

        ' Clear the selected items in the list box.
        lstOptionalWorkshops.ClearSelected()

        ' Give the focus to the chkRegistration check box.
        chkRegistration.Focus()
    End Sub

    Private Sub OptionsForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Determine if the user has not selected regular conference registration.
        If Not chkRegistration.Checked Then

            ' Determine if the user has selected any of the optional events.
            If chkOptionalDinner.Checked Or Not lstOptionalWorkshops.SelectedIndex = -1 Then

                ' Display a message box to the user indicating that regular conference registration
                ' must be selected before any optional event can be registered.
                MessageBox.Show("Optional events are only availble with conference registration.",
                                "Conference Registration Needed")

                ' Cancel the OptionsForm form's Close event.
                e.Cancel = True
            End If

            ' Calculate the totals.
        Else
            ' Apply the fee for regular registration.
            If chkRegistration.Checked Then
                g_decTotal += decREGISTRATION
            End If
            ' Apply the fee for the optional dinner.
            If chkOptionalDinner.Checked Then
                g_decTotal += decOPTIONAL_DINNER
            End If

            ' Apply the fee for one of the optional workshops.
            Select Case lstOptionalWorkshops.SelectedIndex
                Case 0
                    g_decTotal += decOPTIONAL_ECOMMERSE
                Case 1
                    g_decTotal += decOPTIONAL_WEB
                Case 2
                    g_decTotal += decOPTIONAL_VB
                Case 3
                    g_decTotal += decOPTIONAL_NETWORK
            End Select
        End If

    End Sub

    Private Sub OptionsForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' Set the total to zero.
        g_decTotal = 0D
    End Sub
End Class