Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Constant to hold the number of test scores.
        Const intNUM_SCORES As Integer = 5I
		lblStatus.Text = String.Empty

		Try
			' Get the test scores from the Text Boxes.
			Dim intTestScore1 As Integer = CInt(txtTestScore1.Text)
			Dim intTestScore2 As Integer = CInt(txtTestScore2.Text)
			Dim intTestScore3 As Integer = CInt(txtTestScore3.Text)
			Dim intTestScore4 As Integer = CInt(txtTestScore4.Text)
			Dim intTestScore5 As Integer = CInt(txtTestScore5.Text)

			' Get the sum of all the test scores.
			Dim intSum As Integer = intTestScore1 + intTestScore2 + intTestScore3 +
			 intTestScore4 + intTestScore5

			' Calculate the average test score.
			Dim dblAverage As Double = CDbl(intSum / intNUM_SCORES)

			' Display the average test score in lblAverage.
			lblAverage.Text = dblAverage.ToString("n")
		Catch
			lblStatus.Text = "Please enter integer values"
		End Try
	End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text Boxes and lblAverage
        txtTestScore1.Clear()
        txtTestScore2.Clear()
        txtTestScore3.Clear()
        txtTestScore4.Clear()
        txtTestScore5.Clear()
        lblAverage.Text = String.Empty
		lblStatus.Text = String.Empty

        ' Give the focus to txtTestScore1.
        txtTestScore1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
