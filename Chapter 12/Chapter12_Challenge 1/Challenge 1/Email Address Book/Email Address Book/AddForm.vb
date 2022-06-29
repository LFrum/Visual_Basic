Public Class AddForm

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ' Add the data entered on the form to the collection.
        Dim addressObject As Address

        addressObject = copyData()
        g_addressCollection.Add(addressObject, addressObject.Name)
        MessageBox.Show("New record added.", "Confirmation")
        clearForm()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the AddForm form.
        Me.Close()
    End Sub

    Function copyData() As Address

        ' Return an Address object containing the data
        ' entered on the form.
        Dim tempAddress As New Address()

        ' Store the form data in tempAddress.
        tempAddress.Name = txtName.Text
        tempAddress.Email = txtEmail.Text
        tempAddress.Phone = txtPhone.Text
        tempAddress.Comments = txtComments.Text

        ' Return the tempAddress object.
        Return tempAddress
    End Function

    Sub clearForm()

        ' Clear the form.
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtComments.Clear()

        ' Reset the focus.
        txtName.Focus()
    End Sub
End Class