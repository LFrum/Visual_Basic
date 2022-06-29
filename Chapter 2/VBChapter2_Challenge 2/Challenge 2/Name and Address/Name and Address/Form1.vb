Public Class Form1
    Private Sub btnShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInfo.Click
        ' Show the info.
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
