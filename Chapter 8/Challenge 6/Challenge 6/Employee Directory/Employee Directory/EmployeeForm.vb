Public Class EmployeeForm

    Private Sub EmployeeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display the employee information.
        DisplayInformation()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the EmployeeForm form.
        Me.Close()
    End Sub

    ' The DisplayInformation function displays the employee information in the labels.
    Sub DisplayInformation()
        lblName.Text = g_strNames(g_intSelectedItem)                        ' Display the Name.
        lblIdNumber.Text = g_strIdNumbers(g_intSelectedItem)                ' Display the ID Number.
        lblDepartmentName.Text = g_strDepartmentNames(g_intSelectedItem)    ' Display the Departement Name.
        lblTelephoneNumber.Text = g_strTelephoneNumbers(g_intSelectedItem)  ' Display the Telephone Number.
    End Sub
End Class