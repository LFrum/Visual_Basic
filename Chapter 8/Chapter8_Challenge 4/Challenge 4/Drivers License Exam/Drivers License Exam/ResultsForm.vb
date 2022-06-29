Public Class ResultsForm

    Private Sub ResultsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display the results
        DisplayResults()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the ResultsForm form.
        Me.Close()
    End Sub
    ' The DisplayResults procedure displays the results on the ResultsForm form.
    Sub DisplayResults()

        ' Store the results in the results array.
        Dim strResults() As String = GetResults()

        ' Display the results of each answer in the labels.
        lblResult1.Text = strResults(0)
        lblResult2.Text = strResults(1)
        lblResult3.Text = strResults(2)
        lblResult4.Text = strResults(3)
        lblResult5.Text = strResults(4)
        lblResult6.Text = strResults(5)
        lblResult7.Text = strResults(6)
        lblResult8.Text = strResults(7)
        lblResult9.Text = strResults(8)
        lblResult10.Text = strResults(9)
        lblResult11.Text = strResults(10)
        lblResult12.Text = strResults(11)
        lblResult13.Text = strResults(12)
        lblResult14.Text = strResults(13)
        lblResult15.Text = strResults(14)
        lblResult16.Text = strResults(15)
        lblResult17.Text = strResults(16)
        lblResult18.Text = strResults(17)
        lblResult19.Text = strResults(18)
        lblResult20.Text = strResults(19)

        ' Display pass or fail based on the number of correctly answered questions.
        If g_intTotalCorrect >= g_intPASSING_TOTAL Then

            lblResult.Text = "PASS"
        Else
            lblResult.Text = "FAIL"
        End If
    End Sub
End Class