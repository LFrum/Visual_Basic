Public Class MainForm

    Private Sub btnScoreExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreExam.Click
        StoreAnswers()  ' Store the answers in the global answers array

        ' Determine if the answers are valid
        If IsValid() Then

            ' Display the ResultsForm form
            DisplayResults()

        Else
            ' Display a message to the user indicating that input was invalid.
            MessageBox.Show("Fill in the answers using the letters A, B, C, or D.", "Check Your Answers")
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtAnswer1.Clear()
        txtAnswer2.Clear()
        txtAnswer3.Clear()
        txtAnswer4.Clear()
        txtAnswer5.Clear()
        txtAnswer6.Clear()
        txtAnswer7.Clear()
        txtAnswer8.Clear()
        txtAnswer9.Clear()
        txtAnswer10.Clear()
        txtAnswer11.Clear()
        txtAnswer12.Clear()
        txtAnswer13.Clear()
        txtAnswer14.Clear()
        txtAnswer15.Clear()
        txtAnswer16.Clear()
        txtAnswer17.Clear()
        txtAnswer18.Clear()
        txtAnswer19.Clear()
        txtAnswer20.Clear()

        ' Give the Focus to the txtAnswer1 text box.
        txtAnswer1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub

    Sub DisplayResults()
        ' Create an instance of the ResultsForm form.
        Dim frmResults As New ResultsForm

        ' Display the ResultsForm form.
        frmResults.ShowDialog()
    End Sub

    ' The IsValid function returns True if the answers input 
    ' by the user are valid, otherwise it returns False.
    Function IsValid() As Boolean
        Dim blnStatus As Boolean = False    ' The status, initialized to False
        Dim intCount As Integer = 0         ' Counter variable, intitalized to 0
        Dim intTotal As Integer = 0         ' Running total, initialized to 0

        ' Step through the global answers array
        ' Determine if each value in the array is valid.
        For intCount = 0 To g_intARRAY_SIZE

            ' Verify that the value is not empty and not a number
            ' and that the value is a letter A, B, C, or D.
            If Not g_strAnswers(intCount) = String.Empty And Not IsNumeric(g_strAnswers(intCount)) And
                g_strAnswers(intCount) >= g_strMIN_LETTER And g_strAnswers(intCount) <= g_strMAX_LETTER Then

                intTotal += 1   ' Increment the running total.
            End If
        Next

        ' Determine if the running total is equal to the number of answers.
        If intTotal = g_intARRAY_SIZE + 1 Then
            blnStatus = True    ' Set status to True.
        End If

        ' Return the status.
        Return blnStatus
    End Function
    ' The StoreAnswers procedure stores the user input in the global answers array.
    Sub StoreAnswers()
        ' Populate the global array with user input.
        g_strAnswers(0) = txtAnswer1.Text.ToUpper()
        g_strAnswers(1) = txtAnswer2.Text.ToUpper()
        g_strAnswers(2) = txtAnswer3.Text.ToUpper()
        g_strAnswers(3) = txtAnswer4.Text.ToUpper()
        g_strAnswers(4) = txtAnswer5.Text.ToUpper()
        g_strAnswers(5) = txtAnswer6.Text.ToUpper()
        g_strAnswers(6) = txtAnswer7.Text.ToUpper()
        g_strAnswers(7) = txtAnswer8.Text.ToUpper()
        g_strAnswers(8) = txtAnswer9.Text.ToUpper()
        g_strAnswers(9) = txtAnswer10.Text.ToUpper()
        g_strAnswers(10) = txtAnswer11.Text.ToUpper()
        g_strAnswers(11) = txtAnswer12.Text.ToUpper()
        g_strAnswers(12) = txtAnswer13.Text.ToUpper()
        g_strAnswers(13) = txtAnswer14.Text.ToUpper()
        g_strAnswers(14) = txtAnswer15.Text.ToUpper()
        g_strAnswers(15) = txtAnswer16.Text.ToUpper()
        g_strAnswers(16) = txtAnswer17.Text.ToUpper()
        g_strAnswers(17) = txtAnswer18.Text.ToUpper()
        g_strAnswers(18) = txtAnswer19.Text.ToUpper()
        g_strAnswers(19) = txtAnswer20.Text.ToUpper()
    End Sub
End Class
