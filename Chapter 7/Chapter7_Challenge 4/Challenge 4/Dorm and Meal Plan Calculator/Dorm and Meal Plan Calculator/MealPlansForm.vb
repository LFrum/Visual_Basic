Public Class MealPlansForm

    Private Sub btnAddMealPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMealPlan.Click
        ' Get the selected meal plan from the user.
        GetSelectedMealPlan()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the MealPlansForm form.
        Me.Close()
    End Sub

    ' The GetSelectedMealPlan procedure sets the charge for the selected meal plan.
    Sub GetSelectedMealPlan()

        ' Determine which meal plan was selected from the lstMealPlans list box.
        Select Case lstMealPlans.SelectedIndex
            Case 0
                g_decMealPlan = g_decMEAL_PLAN_7            ' Apply the 7 meals per week charge.
            Case 1
                g_decMealPlan = g_decMEAL_PLAN_14           ' Apply the 14 meals per week charge.
            Case 2
                g_decMealPlan = g_decMEAL_PLAN_UNLIMITED    ' Apply the unlimited meals charge.
            Case Else
                ' Display a message to the user indicating that a meal plan selection is needed.
                MessageBox.Show("Select a meal plan from the list.", "Selection Needed")
        End Select
    End Sub
End Class