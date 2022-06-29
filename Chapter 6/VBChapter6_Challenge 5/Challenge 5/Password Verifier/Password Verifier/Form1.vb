Public Class Form1

    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        ' This procedure determines if the password entered by the user is valid.

        If IsValid(txtPassword.Text) Then
            ' Display a message to the user indicating the password is valid.
            MessageBox.Show("The password is valid.", "Password Verification")
        Else
            ' Display a message to the user indicating the password is invald.
            MessageBox.Show("The password is invalid.", "Password Verification")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text box and give it the focus.
        txtPassword.Clear()
        txtPassword.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Function IsValid(ByVal strPassword As String) As Boolean
        ' This function accepts a string as an argument.
        ' It returns True if the string meets the password criteria,
        ' otherwise it returns False.

        Dim blnStatus As Boolean = False    ' Flag for the status.

        ' Determine if the length of the string is valid, and 
        ' that it contains at least one alphabetic character.
        If strPassword.Length >= 6 And Not IsNumeric(strPassword) Then

            ' Search each character in the string for a numeric digit.
            For intIndex = 0 To strPassword.Length - 1

                ' Determine if the current character is a numeric digit.
                If IsNumeric(strPassword.Substring(intIndex, 1)) Then

                    ' The string has met the password criteria.
                    blnStatus = True
                End If
            Next
        End If

        ' Return the status.
        Return blnStatus
    End Function
End Class
