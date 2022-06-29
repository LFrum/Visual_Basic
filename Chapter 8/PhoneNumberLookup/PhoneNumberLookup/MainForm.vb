Public Class frmMain
    Dim intCount As Integer 'Loop Counter

    Private Sub mnuFileAddNewContact_Click(sender As Object, e As EventArgs) Handles mnuFileAddNewContact.Click
        'Open the AddContactForm
        frmAddContact.ShowDialog()
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        'Reset the search result label
        lblSearchResult.Text = String.Empty
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close the Form
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'Show About Box
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuFileSearch_Click(sender As Object, e As EventArgs) Handles mnuFileSearch.Click
        Dim intCount As Integer

        Dim boolFound As Boolean = False

        For intCount = 0 To (g_intNumberOfElement - 1)
            If cboContactList.Text = cboContactList.Items(intCount).ToString() Then
                boolFound = True
            End If
        Next

        If boolFound = False Then
            lblSearchResult.Text = "Search Not Found"
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intCount = 0 To (strPeople.Length - 1)
            cboContactList.Items.Add(strPeople(intCount))
        Next

    End Sub

    Private Sub cboContactList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContactList.SelectedIndexChanged
        lblSearchResult.Text = "Contact's Name: " & strPeople(cboContactList.SelectedIndex) & vbCrLf &
                                "Contact's Phone Number: " & strPhoneNumber(cboContactList.SelectedIndex) & vbCrLf
    End Sub
End Class
