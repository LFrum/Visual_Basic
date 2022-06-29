Public Class frmAddContact
    Private Sub mnuFileAddToContactList_Click(sender As Object, e As EventArgs) Handles mnuFileAddToContactList.Click
        'The new maximum index for the arrays
        Dim NewMaxIndex = g_intNumberOfElement

        'Resizing the array
        ReDim Preserve strPeople(g_intNumberOfElement)
        ReDim Preserve strPhoneNumber(g_intNumberOfElement)

        g_intNumberOfElement += 1

        'Put info in the arrays
        strPeople(NewMaxIndex) = txtContactsName.Text
        strPhoneNumber(NewMaxIndex) = txtContactsPhoneNumber.Text

        frmMain.cboContactList.Items.Add(strPeople(NewMaxIndex))
        g_intNumberOfElement += 1
    End Sub

    Private Sub mnuFileClear_Click(sender As Object, e As EventArgs) Handles mnuFileClear.Click
        'Clear textboxes
        txtContactsName.Clear()
        txtContactsPhoneNumber.Clear()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
End Class