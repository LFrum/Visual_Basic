Public Class EditForm

    ' Class-level object variable.
    Dim addressObject As Address

    Private Sub EditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display the selected record.

        ' Get a reference to the selected object.
        addressObject = CType(g_addressCollection.Item(g_itemToEdit), Address)

        ' Display the object's data.
        displayRecord(addressObject)
    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        ' Save any changes.
        updateData(addressObject)
        MessageBox.Show("Record updated.", "Confirmation")

        ' Close the EditForm form.
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ' Close the EditForm form.
        Me.Close()
    End Sub

    Sub displayRecord(ByVal a As Address)

        ' Display a record.
        txtName.Text = a.Name
        txtEmail.Text = a.Email
        txtPhone.Text = a.Phone
        txtComments.Text = a.Comments

        ' Set the focus.
        txtName.Focus()

    End Sub

    Sub updateData(ByRef a As Address)

        ' Store the data on the form in the Address object
        ' passed as the argument.
        a.Name = txtName.Text
        a.Email = txtEmail.Text
        a.Phone = txtPhone.Text
        a.Comments = txtComments.Text

    End Sub
End Class