Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create the collection object.
        g_addressCollection = New Collection()
    End Sub

    Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' Update the display.
        Dim i As Integer            ' Loop counter
        Dim tempAddress As Address  ' To hold Address objects

        ' Clear the list box.
        lstNames.Items.Clear()

        ' Add the items in the collection to the list box.
        For i = 1 To g_addressCollection.Count
            tempAddress = CType(g_addressCollection.Item(i), Address)
            lstNames.Items.Add(tempAddress.Name)
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Display an instance of the AddForm form.
        Dim frmAdd As New AddForm

        frmAdd.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        ' Display an instance of the EditForm form.
        Dim frmEdit As New EditForm()

        If lstNames.SelectedItem Is Nothing Then
            MessageBox.Show("Select an item to edit.", "Selection Needed")
        Else
            ' Get the name that is to be edited and store it in
            ' g_itemToEdit. 
            g_itemToEdit = lstNames.SelectedItem.ToString()

            ' Display the EditForm form.
            frmEdit.ShowDialog()
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim selectedName As String  ' To hold index of selected name.

        Try
            ' Get the selected value.
            selectedName = lstNames.SelectedItem.ToString()

            ' Remove the selected name from the list box and the collection.
            If MessageBox.Show("Are you sure?",
                               "Confirm Deletion",
                               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                lstNames.Items.Remove(selectedName)
                g_addressCollection.Remove(selectedName)
            End If

        Catch ex As NullReferenceException
            MessageBox.Show("Select an item to remove.", "Selection Needed")
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub
End Class
