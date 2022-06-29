Public Class Form1
    Private Sub btnShowAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswer.Click
        'Display the answer.
        lblAnswer.Text = "18 + 64 = 82"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
