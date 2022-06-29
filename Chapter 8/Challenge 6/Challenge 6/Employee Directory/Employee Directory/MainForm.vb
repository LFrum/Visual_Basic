Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display the employee names in the listbox.
        DisplayEmployeeNames()
    End Sub
    Private Sub lstNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNames.SelectedIndexChanged
        ' Store the selected index of the employee name.
        g_intSelectedItem = lstNames.SelectedIndex()

        ' Display the EmployeeForm form.
        DisplayEmployeeForm()
    End Sub

    ' The DisplayEmployeeNames procedure displays the employee name in the listbox.
    Sub DisplayEmployeeNames()
        Dim intIndex As Integer = 0 ' Counter variable.

        ' Add each employee name in the array to the lstNames listbox.
        For intIndex = 0 To g_strNames.Length
            lstNames.Items.Add(g_strNames(intIndex))
        Next
    End Sub

    ' The DisplayEmployeeForm procedure displays the EmployeeForm form.
    Sub DisplayEmployeeForm()
        ' Create an instance of the EmployeeForm form.
        Dim frmEmployee As New EmployeeForm

        ' Display the EmployeeForm form.
        frmEmployee.ShowDialog()
    End Sub
End Class
