Public Class MainForm

    Private Sub btnIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndividual.Click
        ' Create an instance of the IndividualForm form.
        Dim frmIndividual As New IndividualForm

        ' Show the IndividualForm form.
        frmIndividual.ShowDialog()
    End Sub

    Private Sub btnFamily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamily.Click
        ' Create an instance of the FamilyForm form.
        Dim frmFamily As New FamilyForm

        ' Show the FamilyForm form.
        frmFamily.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub
End Class
