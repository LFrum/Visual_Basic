Public Class MainForm

    Private Sub btnSelectConferenceOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectConferenceOptions.Click
        ' Create an instance of the OptionsForm.
        Dim frmOptions As New OptionsForm

        ' Display the OptionsForm.
        frmOptions.ShowDialog()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Reset the MainForm form.
        Reset()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub

    Sub Reset()
        ' This procedure resets the MainForm form.

        ' Clear the Text in the text boxes.
        txtAddress.Clear()
        txtCity.Clear()
        txtCompany.Clear()
        txtEmail.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtState.Clear()
        txtZip.Clear()

        ' Set the Text in the label to an empty string.
        lblTotal.Text = String.Empty

        ' Give the focus to the txtName text box.
        txtName.Focus()
    End Sub

    Private Sub MainForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' Display the total registration fees.
        lblTotal.Text = g_decTotal.ToString("c")
    End Sub
End Class
