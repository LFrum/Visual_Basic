Public Class MainForm

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Create an instance of the Person class.
        Dim objPerson As New Person

        ' Assign values to each property.
        With objPerson
            .FirstName = txtFirstName.Text
            .LastName = txtLastName.Text
            .Address = txtAddress.Text
            .City = txtCity.Text
            .State = txtState.Text
            .Zip = txtZip.Text
            .Phone = txtPhone.Text
        End With

        ' Display the information stored in each property.
        With objPerson
            MessageBox.Show(.FirstName & " " & .LastName &
                            ControlChars.CrLf &
                            .Address &
                            ControlChars.CrLf &
                            .City & ", " & .State & "  " & .Zip &
                            ControlChars.CrLf &
                            .Phone,
                            "Customer Information")
        End With
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()

        ' Give the Focus to the txtFirstName text box.
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
