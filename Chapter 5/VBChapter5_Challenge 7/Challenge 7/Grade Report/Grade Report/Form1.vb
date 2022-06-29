Public Class Form1

    Private Sub btnEnterData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterData.Click
        ' Named constant declarations
        Const intStudents As Integer = 3
        Const intScores As Integer = 3

        ' Local variable declarations
        Dim intCurrentStudent As Integer    ' Counter variable for students.
        Dim intCurrentScore As Integer      ' Counter variable for test scores.
        Dim strName As String               ' Holds a student name.
        Dim intScore As Integer             ' Holds a test score.
        Dim intTotal As Integer             ' Holds a test score total.
        Dim intAverage As Integer           ' Holds a test score average.
        Dim strGrade As String              ' Holds a letter grade.

        ' Get the names of each student.
        For intCurrentStudent = 1 To intStudents

            strName = InputBox("Enter the name for student " &
                               intCurrentStudent.ToString() &
                               ".", "Student " &
                               intCurrentStudent.ToString() & " Name")

            ' Get the test scores for each student.
            For intCurrentScore = 1 To intScores

                ' Do not continue until the input is valid
                While Not (Integer.TryParse(InputBox("Enter Test Score " &
                                                     intCurrentScore.ToString() & ".",
                                                     "Test Score " & intCurrentScore.ToString()),
                                                 intScore) And intScore >= 0)

                    ' Display an error message if the test score is not valid.
                    MessageBox.Show("Test Score " & intCurrentScore.ToString() &
                                    " must be a postive whole number.", "Invalid Input")
                End While

                ' Keep a running total of the test scores.
                intTotal += intScore
            Next

            ' Calculate the test average.
            intAverage = intTotal \ intScores

            ' Calculate the letter grade.
            Select Case intAverage
                Case Is >= 90
                    strGrade = "A"
                Case 80 To 89
                    strGrade = "B"
                Case 70 To 79
                    strGrade = "C"
                Case 60 To 69
                    strGrade = "D"
                Case Else
                    strGrade = "F"
            End Select

            ' Display the results in the list box.
            lstGrades.Items.Add(strName & " Average: " & intAverage.ToString() & " Grade " & strGrade)

            ' Set the total to zero for the next student.
            intTotal = 0
        Next

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
