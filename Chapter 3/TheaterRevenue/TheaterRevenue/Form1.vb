'Lince Rumainum
'Visual Basic
'HW Chapter 3

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtmSystemTime As Date
        dtmSystemTime = Today

        lblDate.Text = dtmSystemTime.ToString("d")
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAdultTicketPrice, decChildTicketPrice As Decimal
        Dim intAdultTicketsSold, intChildTicketsSold, intTotalCount As Integer
        Dim decAdultGrossSales, decChildGrossSales, decTotalGrossSales As Decimal
        Dim decAdultNetSales, decChildNetSales, decTotalNetSales As Decimal
        Dim dtmSystemTime As Date

        '20% of the ticket sales that the theater keeps
        Const sngTHEATER_PERCENTAGE As Single = 0.2

        Try
            decAdultTicketPrice = CDec(txtAdultPriceTicket.Text)
            intAdultTicketsSold = CInt(txtAdultTicketsSold.Text)

            decChildTicketPrice = CDec(txtChildPriceTicket.Text)
            intChildTicketsSold = CInt(txtChildTicketsSold.Text)

            decAdultGrossSales = decAdultTicketPrice * intAdultTicketsSold
            decChildGrossSales = decChildTicketPrice * intChildTicketsSold
            decTotalGrossSales = decAdultGrossSales + decChildGrossSales

            decAdultNetSales = decAdultGrossSales * CDec(sngTHEATER_PERCENTAGE)
            decChildNetSales = decChildGrossSales * CDec(sngTHEATER_PERCENTAGE)
            decTotalNetSales = decAdultNetSales + decChildNetSales

            lblAdultGrossRevenue.Text = decAdultGrossSales.ToString("c")
            lblChildGrossRevenue.Text = decChildGrossSales.ToString("c")
            lblTotalGrossRevenue.Text = decTotalGrossSales.ToString("c")

            lblAdultNetRevenue.Text = decAdultNetSales.ToString("c")
            lblChildNetRevenue.Text = decChildNetSales.ToString("c")
            lblTotalNetRevenue.Text = decTotalNetSales.ToString("c")

            intTotalCount = intAdultTicketsSold + intChildTicketsSold

            lblTotalSoldTickets.Text = "Total Tickets Sold Today: " & intTotalCount & " tickets"
            dtmSystemTime = Today

            lblDate.Text = dtmSystemTime.ToString("d")
        Catch ex As Exception
            'Error message
            MessageBox.Show("All input must e valid numeric values.")
        End Try

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all input & output 
        txtAdultPriceTicket.Clear()
        txtAdultTicketsSold.Clear()

        txtChildPriceTicket.Clear()
        txtChildTicketsSold.Clear()

        lblAdultGrossRevenue.Text = String.Empty
        lblChildGrossRevenue.Text = String.Empty
        lblTotalGrossRevenue.Text = String.Empty

        lblAdultNetRevenue.Text = String.Empty
        lblChildNetRevenue.Text = String.Empty
        lblTotalNetRevenue.Text = String.Empty

        lblTotalSoldTickets.Text = String.Empty
        lblDate.Text = String.Empty

        'Give the focus to Adult Price per Ticket text box
        txtAdultPriceTicket.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub txtAdultPriceTicket_GotFocus(sender As Object, e As EventArgs) Handles txtAdultPriceTicket.GotFocus
        'Changes background to yellow when cursor is in textbox
        txtAdultPriceTicket.BackColor = Color.Yellow
    End Sub

    Private Sub txtAdultPriceTicket_LostFocus(sender As Object, e As EventArgs) Handles txtAdultPriceTicket.LostFocus
        'Changes background back to white when cursor is NOT in textbox
        txtAdultPriceTicket.BackColor = Color.White
    End Sub

    Private Sub txtAdultTicketsSold_GotFocus(sender As Object, e As EventArgs) Handles txtAdultTicketsSold.GotFocus
        'Changes background to yellow when cursor is in textbox
        txtAdultTicketsSold.BackColor = Color.Yellow
    End Sub

    Private Sub txtAdultTicketsSold_LostFocus(sender As Object, e As EventArgs) Handles txtAdultTicketsSold.LostFocus
        'Changes background back to white when cursor is NOT in textbox
        txtAdultTicketsSold.BackColor = Color.White
    End Sub

    Private Sub txtChildPriceTicket_GotFocus(sender As Object, e As EventArgs) Handles txtChildPriceTicket.GotFocus
        'Changes background to yellow when cursor is in textbox
        txtChildPriceTicket.BackColor = Color.Yellow
    End Sub

    Private Sub txtChildPriceTicket_LostFocus(sender As Object, e As EventArgs) Handles txtChildPriceTicket.LostFocus
        'Changes background back to white when cursor is NOT in textbox
        txtChildPriceTicket.BackColor = Color.White
    End Sub

    Private Sub txtChildTicketsSold_GotFocus(sender As Object, e As EventArgs) Handles txtChildTicketsSold.GotFocus
        'Changes background to yellow when cursor is in textbox
        txtChildTicketsSold.BackColor = Color.Yellow
    End Sub

    Private Sub txtChildTicketsSold_LostFocus(sender As Object, e As EventArgs) Handles txtChildTicketsSold.LostFocus
        'Changes background back to white when cursor is NOT in textbox
        txtChildTicketsSold.BackColor = Color.White
    End Sub
End Class
