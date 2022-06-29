Public Class Form1
    ' Remind students to use a query parameter in the WHERE clause of the 
    ' SELECT statement that fills the grid. 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SalesStaffTableAdapter.Fill(Me.SalesStaffDataSet.SalesStaff, True)
    End Sub

    Private Sub CalcAverageSalary()

        Dim row As SalesStaffDataSet.SalesStaffRow
        Dim decTotal As Decimal

        For Each row In Me.SalesStaffDataSet.SalesStaff.Rows
            decTotal += row.Salary
        Next
        decTotal /= Me.SalesStaffDataSet.SalesStaff.Rows.Count
        lblAverageSalary.Text = decTotal.ToString("C")
    End Sub

    Private Sub radFullTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFullTime.CheckedChanged
        ' Pass True as the query parameter.
        Me.SalesStaffTableAdapter.Fill(Me.SalesStaffDataSet.SalesStaff, True)
        CalcAverageSalary()
    End Sub

    Private Sub radPartTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPartTime.CheckedChanged
        ' Pass False as the query parameter.
        Me.SalesStaffTableAdapter.Fill(Me.SalesStaffDataSet.SalesStaff, False)
        CalcAverageSalary()
    End Sub
End Class
