Module GradeExamModule
    ' Global constants
    Public Const g_intPASSING_TOTAL As Integer = 15     ' A student must correctly answer 15 questions to pass.
    Public Const g_strMIN_LETTER As String = "A"        ' Letter minimum is "A"
    Public Const g_strMAX_LETTER As String = "D"        ' Letter maximum is "D"
    Public Const g_intARRAY_SIZE As Integer = 19        ' The Upper Subscript is 19 (for a total of 20 questions)

    ' Global variables.
    Public g_intTotalCorrect As Integer = 0             ' To hold the total of correctly answered questions.
    Public g_strAnswers(g_intARRAY_SIZE) As String      ' To hold the answers input by the user.

    ' This array holds the correct answers.
    Public g_strCorrectAnswers() As String = {"B", "D", "A", "A", "C",
                                              "A", "B", "A", "C", "D",
                                              "B", "C", "D", "A", "D",
                                              "C", "C", "B", "D", "A"}

    ' The GetResults function scores the exam and returns
    ' an array of Strings containting the results of the exam.
    Public Function GetResults() As String()
        Dim intCount As Integer = 0 ' Counter variable, initalized to 0
        g_intTotalCorrect = 0       ' Number of correctly answered questions, set to 0

        Dim strResults(g_intARRAY_SIZE) As String   ' To hold the results

        ' Step though the answers and store the results in the results array.
        For intCount = 0 To g_intARRAY_SIZE
            ' Determine if the answers is correct or incorrect.
            If g_strAnswers(intCount) = g_strCorrectAnswers(intCount) Then

                ' The answer was correctly answered
                strResults(intCount) = "CORRECT"
                ' Increment the number of correctly answered questions
                g_intTotalCorrect += 1

            Else
                ' The answer was incorrectly answered.
                strResults(intCount) = "INCORRECT"
            End If
        Next

        ' Return the array containing the results.
        Return strResults
    End Function
End Module
