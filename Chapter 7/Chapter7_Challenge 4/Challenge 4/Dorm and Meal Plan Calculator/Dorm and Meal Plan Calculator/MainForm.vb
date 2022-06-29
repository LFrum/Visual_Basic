Public Class MainForm

    Private Sub btnAddDormitory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDormitory.Click
        ' Get the selected dormitory from the user.
        GetSelectedDormitory()

        ' Update and display the total charges.
        UpdateDisplayTotalCharges()
    End Sub

    Private Sub btnViewMealPlans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewMealPlans.Click
        ' Display the MealPlansForm.
        DisplayMealPlans()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Reset the form and charges.
        ResetForm()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub

    Private Sub MainForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'When the MainForm form is activated, update and display the total charges, if any.
        UpdateDisplayTotalCharges()
    End Sub

    ' The GetSelectedDormitory procedure sets the charge for the selected dormitory.
    Sub GetSelectedDormitory()

        ' Determine which dormitory was selected from the lstDormitories list box.
        Select Case lstDormitories.SelectedIndex
            Case 0
                g_decDormitory = g_decDORM_ALLEN_HALL       ' Apply the charge for Allen Hall
            Case 1
                g_decDormitory = g_decDORM_PIKE_HALL        ' Apply the charge for Pike Hall
            Case 2
                g_decDormitory = g_decDORM_FARTHING_HALL    ' Apply the charge for Farthing Hall
            Case 3
                g_decDormitory = g_decDORM_UNIVERSITY_SUITE ' Apply the charge for a university suite.
            Case Else
                ' Display a message to the user indicating that a dormitory selection is needed.
                MessageBox.Show("Select a dormitory from the list.", "Selection Needed")
        End Select
    End Sub

    ' The DisplayMealPlans procedure displays the MealPlanForm form.
    Sub DisplayMealPlans()

        ' Create an instance of the MealPlansForm.
        Dim frmMealPlans As New MealPlansForm

        ' Display the MealPlanForm.
        frmMealPlans.ShowDialog()
    End Sub

    ' The UpdateDisplayTotalCharges procedure updates and 
    ' displays the total charges for the semester.
    Sub UpdateDisplayTotalCharges()

        ' Update and display the total charges, if any.
        ' Verify that charges are greater than zero.
        If CalcTotalCharges() > 0D Then
            lblDormintory.Text = g_decDormitory.ToString("c")
            lblMealPlan.Text = g_decMealPlan.ToString("c")
            lblTotal.Text = CalcTotalCharges.ToString("c")
        End If
    End Sub

    ' The ResetForm procedure clears the Text and Selected Items from
    ' the MainForm form and resets the charges for the semester.
    Sub ResetForm()

        ' Clear the Selected Items from the list box.
        lstDormitories.ClearSelected()

        ' Set the Text in the labels to an empty string.
        lblDormintory.Text = String.Empty
        lblMealPlan.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Reset the charges.
        ResetCharges()
    End Sub
End Class
