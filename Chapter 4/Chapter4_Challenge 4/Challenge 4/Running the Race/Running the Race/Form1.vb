Public Class Form1

    Private Sub btnCalculateResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateResults.Click
        ' Declare variables to store the user input.
        Dim strNameRunner1 As String = String.Empty     ' Stores user input from txtNameRunner1
        Dim strNameRunner2 As String = String.Empty     ' Stores user input from txtNameRunner2
        Dim strNameRunner3 As String = String.Empty     ' Stores user input from txtNameRunner3
        Dim intFinishingTimeRunner1 As Integer = 0      ' Stores user input from txtFinishingTimeRunner1
        Dim intFinishingTimeRunner2 As Integer = 0      ' Stores user input from txtFinishingTimeRunner2
        Dim intFinishingTimeRunner3 As Integer = 0      ' Stores user input from txtFinishingTimeRunner3

        ' Get the name for Runner 1 as input from the user.
        If txtNameRunner1.Text <> String.Empty Then
            strNameRunner1 = txtNameRunner1.Text

            ' Get the finishing time for Runner 1 as input from the user.
            If Integer.TryParse(txtFinishingTimeRunner1.Text, intFinishingTimeRunner1) And
                IsNumeric(intFinishingTimeRunner1) And intFinishingTimeRunner1 > 0 Then

                ' Get the name for Runner 2 as input from the user.
                If txtNameRunner2.Text <> String.Empty Then
                    strNameRunner2 = txtNameRunner2.Text

                    ' Get the finishing time for Runner 2 as input from the user.
                    If Integer.TryParse(txtFinishingTimeRunner2.Text, intFinishingTimeRunner2) And
                        IsNumeric(intFinishingTimeRunner2) And intFinishingTimeRunner2 > 0 Then

                        ' Get the name for Runner 3 as input from the user.
                        If txtNameRunner3.Text <> String.Empty Then
                            strNameRunner3 = txtNameRunner3.Text

                            ' Get the finishing time for Runner 3 as input from the user.
                            If Integer.TryParse(txtFinishingTimeRunner3.Text, intFinishingTimeRunner3) And
                                IsNumeric(intFinishingTimeRunner3) And intFinishingTimeRunner3 > 0 Then

                                ' Determine the results of the race based on finishing times.
                                ' Runner 1 qualifies for 1st place.
                                If intFinishingTimeRunner1 < intFinishingTimeRunner2 And
                                    intFinishingTimeRunner1 < intFinishingTimeRunner3 Then
                                    lblNameFirstPlace.Text = strNameRunner1

                                    ' Runner 2 qualifies for 2nd place.
                                    ' Runner 3 qualifies for 3rd Place.
                                    If intFinishingTimeRunner2 < intFinishingTimeRunner3 Then
                                        lblNameSecondPlace.Text = strNameRunner2
                                        lblNameThirdPlace.Text = strNameRunner3

                                        ' Runner 3 qualifies for 2nd place.
                                        ' Runner 2 qualifies for 3rd Place.
                                    ElseIf intFinishingTimeRunner3 < intFinishingTimeRunner2 Then
                                        lblNameSecondPlace.Text = strNameRunner3
                                        lblNameThirdPlace.Text = strNameRunner2
                                    End If

                                    ' Runner 2 qualifies for 1st place.
                                ElseIf intFinishingTimeRunner2 < intFinishingTimeRunner1 And
                                    intFinishingTimeRunner2 < intFinishingTimeRunner3 Then
                                    lblNameFirstPlace.Text = strNameRunner2

                                    ' Runner 1 qualifies for 2nd place.
                                    ' Runner 3 qualifies for 3rd place.
                                    If intFinishingTimeRunner1 < intFinishingTimeRunner3 Then
                                        lblNameSecondPlace.Text = strNameRunner1
                                        lblNameThirdPlace.Text = strNameRunner3

                                        ' Runner 3 qualifies for 2nd place.
                                        ' Runner 1 qualifies for 3rd place.
                                    ElseIf intFinishingTimeRunner3 < intFinishingTimeRunner2 Then
                                        lblNameSecondPlace.Text = strNameRunner3
                                        lblNameThirdPlace.Text = strNameRunner1
                                    End If

                                    ' Runner 3 qualifies for 1st place.
                                ElseIf intFinishingTimeRunner3 < intFinishingTimeRunner1 And
                                    intFinishingTimeRunner3 < intFinishingTimeRunner2 Then
                                    lblNameFirstPlace.Text = strNameRunner3

                                    ' Runner 1 qualifies for 2nd place.
                                    ' Runner 2 qualifies for 3rd place.
                                    If intFinishingTimeRunner1 < intFinishingTimeRunner2 Then
                                        lblNameSecondPlace.Text = strNameRunner1
                                        lblNameThirdPlace.Text = strNameRunner2

                                        ' Runner 2 qualifies for 2nd place.
                                        ' Runner 1 qualifies for 3rd place.
                                    ElseIf intFinishingTimeRunner2 < intFinishingTimeRunner1 Then
                                        lblNameSecondPlace.Text = strNameRunner2
                                        lblNameThirdPlace.Text = strNameRunner1
                                    End If
                                End If
                            Else
                                ' Display an error message indicating that Runner 3 has an invalid finishing time.
                                MessageBox.Show("The Finishing Time for Runner 3 must be both numeric and postive.", "Invalid Input")
                            End If
                        Else
                            ' Display an error message indicating that Runner 3 has an invalid name.
                            MessageBox.Show("The Name for Runner 3 cannot be blank.", "Invalid Input")
                        End If
                    Else
                        ' Display an error message indicating that Runner 2 has an invalid finishing time.
                        MessageBox.Show("The Finishing Time for Runner 2 must be both numeric and postive.", "Invalid Input")
                    End If
                Else
                    ' Display an error message indicating that Runner 2 has an invalid name.
                    MessageBox.Show("The Name for Runner 2 cannot be blank.", "Invalid Input")
                End If
            Else
                ' Display an error message indicating that Runner 1 has an invalid finishing time.
                MessageBox.Show("The Finishing Time for Runner 1 must be both numeric and postive.", "Invalid Input")
            End If
        Else
            ' Display an error message indicating that Runner 1 has an invalid name.
            MessageBox.Show("The Name for Runner 1 cannot be blank.", "Invalid Input")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtNameRunner1.Clear()
        txtNameRunner2.Clear()
        txtNameRunner3.Clear()
        txtFinishingTimeRunner1.Clear()
        txtFinishingTimeRunner2.Clear()
        txtFinishingTimeRunner3.Clear()

        ' Set the Text in the calculated labels to an empty string.
        lblNameFirstPlace.Text = String.Empty
        lblNameSecondPlace.Text = String.Empty
        lblNameThirdPlace.Text = String.Empty

        ' Give the focus to txtNameRunner1.
        txtNameRunner1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
