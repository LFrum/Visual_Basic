Public Class Form1
    Private Sub btnVirginia_Click(sender As Object, e As EventArgs) Handles btnVirginia.Click
        ' Display Capital & State Abbreviation
        lblStateInfo.Text = "Richmond, VA"
        ' Display State Flag
        picStateFlag.Image = Image.FromFile("C:\Users\Lince\Documents\Spring 2017\Visual Basic\Chapter 2\StateAbbreviation\StateAbbreviation\Resources\VirginiaFlag.gif")
    End Sub

    Private Sub btnNorthCarolina_Click(sender As Object, e As EventArgs) Handles btnNorthCarolina.Click
        ' Display Capital & State Abbreviation
        lblStateInfo.Text = "Raleigh, NC"
        ' Display State Flag
        picStateFlag.Image = Image.FromFile("C:\Users\Lince\Documents\Spring 2017\Visual Basic\Chapter 2\StateAbbreviation\StateAbbreviation\Resources\NorthCarolinaFlag.gif")
    End Sub

    Private Sub btnSouthCarolina_Click(sender As Object, e As EventArgs) Handles btnSouthCarolina.Click
        ' Display Capital & State Abbreviation
        lblStateInfo.Text = "Columbia, SC"
        ' Display State Flag
        picStateFlag.Image = Image.FromFile("C:\Users\Lince\Documents\Spring 2017\Visual Basic\Chapter 2\StateAbbreviation\StateAbbreviation\Resources\SouthCarolinaFlag.gif")
    End Sub

    Private Sub btnGeorgia_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        ' Display Capital & State Abbreviation
        lblStateInfo.Text = "Atlanta, GA"
        ' Display State Flag
        picStateFlag.Image = Image.FromFile("C:\Users\Lince\Documents\Spring 2017\Visual Basic\Chapter 2\StateAbbreviation\StateAbbreviation\Resources\GeorgiaFlag.gif")
    End Sub

    Private Sub btnAlabama_Click(sender As Object, e As EventArgs) Handles btnAlabama.Click
        ' Display Capital & State Abbreviation
        lblStateInfo.Text = "Montgomery, AL"
        ' Display State Flag
        picStateFlag.Image = Image.FromFile("C:\Users\Lince\Documents\Spring 2017\Visual Basic\Chapter 2\StateAbbreviation\StateAbbreviation\Resources\AlabamaFlag.gif")
    End Sub

    Private Sub btnFlorida_Click(sender As Object, e As EventArgs) Handles btnFlorida.Click
        ' Display Capital & State Abbreviation
        lblStateInfo.Text = "Tallahassee, FL"
        ' Display State Flag
        picStateFlag.Image = Image.FromFile("C:\Users\Lince\Documents\Spring 2017\Visual Basic\Chapter 2\StateAbbreviation\StateAbbreviation\Resources\FloridaFlag.gif")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Capital & State Abbreviation
        lblStateInfo.Text = " "
        ' Clear State Flag
        picStateFlag.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the current form
        Me.Close()
    End Sub
End Class