
Partial Class Update
    Inherits System.Web.UI.Page

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Response.Redirect("Default.aspx")
    End Sub

End Class
