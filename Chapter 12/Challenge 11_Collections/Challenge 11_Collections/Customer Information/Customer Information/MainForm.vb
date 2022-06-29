Public Class MainForm

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try


            ' Create an instance of the Customer class.
            Dim objPerson As New Customer

            ' Assign values to each property.
            With objPerson
                .FirstName = txtFirstName.Text
                .LastName = txtLastName.Text
                .Address = txtAddress.Text
                .City = txtCity.Text
                .State = txtState.Text
                .Zip = txtZip.Text
                .Phone = txtPhone.Text
                .CustomerNumber = CInt(txtCustomerNumber.Text)
                .MailingList = chkMailingList.Checked
                .Comments = txtComments.Text
            End With
            Try
                customers.Add(objPerson, objPerson.CustomerNumber.ToString())
                lstCustomers.Items.Add(objPerson.CustomerNumber.ToString() & " " & objPerson.FirstName & " " & objPerson.LastName)
            Catch ex As Exception
                MessageBox.Show(" Do not enter customers with the same customer number ...numbers have to be unique", "Error")
            End Try
         


        Catch ex As Exception
            MessageBox.Show("Make sure all data is entered before you save data")
        End Try
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
        txtCustomerNumber.Clear()
        txtComments.Clear()

        ' Set the chkMailingList Checked property to False.
        chkMailingList.Checked = False

        ' Give the Focus to the txtFirstName text box.
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

   
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim searchCust As New Customer
            Dim strSearch As String
            If lstCustomers.SelectedIndex <> -1 Then
                Dim intIndex As Integer = lstCustomers.SelectedItem.ToString().IndexOf(" ")
                strSearch = lstCustomers.SelectedItem.ToString().Substring(0, intIndex)
                searchCust = CType(customers.Item(strSearch), Customer)

                ' Display the information stored in each property.
                With searchCust
                    MessageBox.Show(.FirstName & " " & .LastName &
                                    ControlChars.CrLf &
                                    .Address &
                                    ControlChars.CrLf &
                                    .City & ", " & .State & "  " & .Zip &
                                    ControlChars.CrLf &
                                    .Phone &
                                    ControlChars.CrLf &
                                    "Customer Number: " & .CustomerNumber.ToString() &
                                    ControlChars.CrLf &
                                    "Mailing List: " & .MailingList.ToString() &
                                    ControlChars.CrLf &
                                    .Comments,
                                    "Customer Information")
                End With
            Else
                MessageBox.Show("Select a customer first")

            End If

        Catch ex As Exception
            MessageBox.Show(" Conversion problems")
        End Try
    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            Dim searchCust As New Customer
            Dim strSearch As String
            If lstCustomers.SelectedIndex <> -1 Then
                Dim intIndex As Integer = lstCustomers.SelectedItem.ToString().IndexOf(" ")
                strSearch = lstCustomers.SelectedItem.ToString().Substring(0, intIndex)
                customers.Remove(strSearch)
                lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex)
            Else
                MessageBox.Show("Select a customer first")

            End If

        Catch ex As Exception
            MessageBox.Show(" Conversion problems")
        End Try
    End Sub
End Class
