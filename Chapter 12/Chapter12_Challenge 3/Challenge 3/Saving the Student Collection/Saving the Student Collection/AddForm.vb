Public Class AddForm
    ' The GetData procedure gets data from the form
    ' and stores it in the Student object parameter.
    Private Sub GetData(ByVal s As Student)
        s.LastName = txtLastName.Text
        s.FirstName = txtFirstName.Text
        s.IdNumber = txtIdNumber.Text
        s.TestAverage = CSng(txtTestAverage.Text)
    End Sub

    ' The ClearForm procedure clears the form.
    Private Sub ClearForm()
        ' Clear the text boxes.
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtIdNumber.Text = String.Empty
        txtTestAverage.Text = String.Empty
        lblGrade.Text = String.Empty

        ' Reset the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Create an instance of the Student class.
        Dim objStudent As New Student

        ' Get data from the form.
        GetData(objStudent)

        ' Display the student's grade.
        lblGrade.Text = objStudent.Grade

        ' Save the student's record.
        AddRecord(objStudent)

        ' Confirm that the record was saved.
        MessageBox.Show("Record added.")

        ' Clear the form.
        ClearForm()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class