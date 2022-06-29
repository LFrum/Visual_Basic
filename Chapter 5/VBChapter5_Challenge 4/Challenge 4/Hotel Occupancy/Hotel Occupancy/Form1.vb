Public Class Form1

    Private Sub btnCompleteReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompleteReport.Click
        ' Declare named constants for rooms and floors.
        Const intFLOORS As Integer = 8                          ' Number of floors.
        Const intROOMS As Integer = 30                          ' Number of rooms per floor.
        Const intTOTAL_ROOMS As Integer = intFLOORS * intROOMS  ' Total number of rooms on all floors.

        ' Declare local variables.
        Dim intCurrentFloor As Integer              ' To hold the current floor number.
        Dim intRoomsOccupied As Integer             ' To hold the number of rooms occupied for the current floor.
        Dim dblOccupancyRate As Double              ' To hold the occupancy rate for the current floor.
        Dim intTotalRoomsOccupied As Integer = 0    ' To hold the total number of rooms occupied on all floors.
        Dim dblOverallOccupancyRate As Double = 0.0 ' To hold the overall occupancy rate for all rooms on all floors.

        ' Get the number of rooms occupied on each floor as input from the user.
        For intCurrentFloor = 1 To intFLOORS

            ' Do not continue to the next floor unless the value input by the user is a number and is within range.
            While Not (Integer.TryParse(InputBox("Enter the number of rooms occupied.", "Floor " &
                                                 intCurrentFloor.ToString()), intRoomsOccupied) And
                                         intRoomsOccupied >= 0 And intRoomsOccupied <= intROOMS)

                ' Display a message to the user indicating that the input for the current floor is not valid.
                MessageBox.Show("Enter a whole number between 0 and " &
                                intROOMS.ToString() & ".", "Invalid Input")
            End While

            ' Calculate the occupancy rate for the current floor.
            dblOccupancyRate = intRoomsOccupied / intROOMS

            ' Output the data for the current floor to the list box.
            lstFloorOccupancyData.Items.Add("Floor: " & intCurrentFloor.ToString() &
                                            " Rooms Occupied: " & intRoomsOccupied.ToString &
                                            " Occupancy Rate: " & dblOccupancyRate.ToString("p"))

            ' Keep a running total of the rooms occupied for all the floors.
            intTotalRoomsOccupied += intRoomsOccupied

        Next

        ' Calculate the overall occupancy rate for all floors.
        dblOverallOccupancyRate = intTotalRoomsOccupied / intTOTAL_ROOMS

        ' Display the results to the user.
        lblTotalRoomsOccupied.Text = intTotalRoomsOccupied.ToString()
        lblOverallOccupancyRate.Text = dblOverallOccupancyRate.ToString("p")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the list box items.
        lstFloorOccupancyData.Items.Clear()

        ' Set the Text of the labels to an empty string.
        lblTotalRoomsOccupied.Text = String.Empty
        lblOverallOccupancyRate.Text = String.Empty

        ' Give the focus to the btnCompleteReport button.
        btnCompleteReport.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
