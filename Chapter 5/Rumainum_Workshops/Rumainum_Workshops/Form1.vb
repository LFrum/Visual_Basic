Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Form start position at the center of the screen
        Me.StartPosition = FormStartPosition.CenterScreen

        'Disabled Calculate Total button
        btnCalculateTotal.Enabled = False

        'Clear the Label and List Box
        lblTotalCost.Text = String.Empty
        lstCost.Items.Clear()
    End Sub

    Private Sub btnAddWorkshop_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click
        Dim intDays As Integer 'Number of days 
        Dim decWorkshopPrice As Decimal 'Price of the workshop
        Dim decLodgingFees As Decimal 'Lodging fees per day
        Dim decTotalLodgingFees As Decimal 'Total lodging fees

        'Exception handling
        If lstWorkshop.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Workshop!") 'No workshop is selected
        ElseIf lstLocation.SelectedIndex = -1 Then
            MessageBox.Show("Please select a location!") 'No location is selected
        Else
            'Selecting a workshop
            If lstWorkshop.SelectedIndex = 0 Then 'Handling Stress is selected
                intDays = 3
                decWorkshopPrice = 595
            ElseIf lstWorkshop.SelectedIndex = 1 Then 'Time Management is selected
                intDays = 3
                decWorkshopPrice = 695
            ElseIf lstWorkshop.SelectedIndex = 2 Then 'Supervision Skills is selected
                intDays = 3
                decWorkshopPrice = 995
            ElseIf lstWorkshop.SelectedIndex = 3 Then 'Negotiation is selected
                intDays = 5
                decWorkshopPrice = 1295
            ElseIf lstWorkshop.SelectedIndex = 4 Then 'How to Interview is selected
                intDays = 1
                decWorkshopPrice = 395
            End If

            'Selecting a location
            If lstLocation.SelectedIndex = 0 Then 'Austin is selected
                decLodgingFees = 95
            ElseIf lstLocation.SelectedIndex = 1 Then 'Chicago is selected
                decLodgingFees = 125
            ElseIf lstLocation.SelectedIndex = 2 Then 'Dallas is selected
                decLodgingFees = 110
            ElseIf lstLocation.SelectedIndex = 3 Then 'Orlando is selected
                decLodgingFees = 100
            ElseIf lstLocation.SelectedIndex = 4 Then 'Phoenix is selected
                decLodgingFees = 92
            ElseIf lstLocation.SelectedIndex = 5 Then 'Raleigh is selected
                decLodgingFees = 90
            End If

            'Calculate the total lodging fees
            decTotalLodgingFees = intDays * decLodgingFees

            'Add the prices in the cost of list
            lstCost.Items.Add(decWorkshopPrice.ToString("c"))
            lstCost.Items.Add(decTotalLodgingFees.ToString("c"))

            'Enabled Calculate Total button
            btnCalculateTotal.Enabled = True
        End If
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim intCountListOfCosts As Integer 'Total number in the list of cost
        Dim decTotalWorkshopFees As Decimal = 0 'Total fees for the workshop
        Dim intCount As Integer 'Counter for the for loop

        'Getting the price and fee from the cost list box
        intCountListOfCosts = lstCost.Items.Count()

        'Calculate the total workshop fees
        For intCount = 0 To intCountListOfCosts - 1
            decTotalWorkshopFees += CDec(lstCost.Items(intCount))
        Next

        'Show the total cost of the total workshop fees
        lblTotalCost.Text = decTotalWorkshopFees.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear the Label and List Box
        lblTotalCost.Text = String.Empty
        lstCost.Items.Clear()

        'Deselect any selected items on the lists
        lstWorkshop.SelectedIndex = -1
        lstLocation.SelectedIndex = -1

        'Disabled Calculate Total button
        btnCalculateTotal.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

End Class
