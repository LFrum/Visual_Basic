Public Class Form1

    Private Sub btnRollDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollDice.Click
        Dim rand As New Random ' Random number generator 
        Dim intDie1 As Integer ' To indicate the side to show for the first die.
        Dim intDie2 As Integer ' To indicate the side to show for the second die.

        ' Hide all the sides of both dice.
        picDie1Side1.Visible = False
        picDie1Side2.Visible = False
        picDie1Side3.Visible = False
        picDie1Side4.Visible = False
        picDie1Side5.Visible = False
        picDie1Side6.Visible = False
        picDie2Side1.Visible = False
        picDie2Side2.Visible = False
        picDie2Side3.Visible = False
        picDie2Side4.Visible = False
        picDie2Side5.Visible = False
        picDie2Side6.Visible = False

        ' Get a random number in the range 1 through 6.
        intDie1 = 1 + rand.Next(5)  ' For the first die
        intDie2 = 1 + rand.Next(5)  ' For the second die

        ' Use the random number to determine the 
        ' side to show for the first die.
        Select Case intDie1
            Case 1
                picDie1Side1.Visible = True ' Show side 1
            Case 2
                picDie1Side2.Visible = True ' Show side 2
            Case 3
                picDie1Side3.Visible = True ' Show side 3
            Case 4
                picDie1Side4.Visible = True ' Show side 4
            Case 5
                picDie1Side5.Visible = True ' Show side 5
            Case 6
                picDie1Side6.Visible = True ' Show side 6
        End Select

        ' Use the random number to determine the 
        ' side to show for the second die.
        Select Case intDie2
            Case 1
                picDie2Side1.Visible = True ' Show side 1
            Case 2
                picDie2Side2.Visible = True ' Show side 2
            Case 3
                picDie2Side3.Visible = True ' Show side 3
            Case 4
                picDie2Side4.Visible = True ' Show side 4
            Case 5
                picDie2Side5.Visible = True ' Show side 5
            Case 6
                picDie2Side6.Visible = True ' Show side 6
        End Select
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
