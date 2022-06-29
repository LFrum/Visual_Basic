Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Form start position at the center of the screen
        Me.StartPosition = FormStartPosition.CenterScreen

        'Clear the text boxes and labels
        ClearOther()
        ClearFees()

        'Unchecked the check boxes
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim decTotalServiceCharges As Decimal
        Dim decPartsPrices As Decimal
        Dim decLaborHours As Decimal
        Dim decOtherCharges As Decimal
        Dim decPartsTaxCharges As Decimal
        Dim decTotalPartCharges As Decimal = 0
        Dim decTotalServiceAndLaborFees As Decimal
        Dim decTotalFees As Decimal

        'Calculate the service charges
        decTotalServiceCharges = OilLubeCharges() + FlushCharges() + MiscCharges()

        If txtParts.Text = String.Empty Then
            decPartsPrices = 0
        ElseIf txtLabor.Text = String.Empty Then
            decLaborHours = 0
        ElseIf IsNumeric(txtParts.Text) And IsNumeric(txtLabor.Text) Then
            decPartsPrices = CDec(txtParts.Text)
            decLaborHours = CDec(txtLabor.Text)
        Else
            MessageBox.Show("Input needs to be numeric characters only")
        End If

        If decPartsPrices < 0 Then
            MessageBox.Show("Price of parts needs to be greater than 0!")
        ElseIf decLaborHours < 0 Then
            MessageBox.Show("The hour of labor needs to be greater than 0!")
        Else
            'Total of parts and labor charges
            decOtherCharges = OtherCharges(decPartsPrices, decLaborHours)
            'Total tax on parts
            decPartsTaxCharges = TaxCharges(decPartsPrices)
            'Total of parts charges only
            decTotalPartCharges = decPartsPrices + decPartsTaxCharges
            'Total fees of all charges
            decTotalFees = TotalCharges(decTotalServiceCharges, decOtherCharges)
        End If

        'Calculate all services and labor without the parts charges
        decTotalServiceAndLaborFees = decTotalServiceCharges + decOtherCharges - decTotalPartCharges

        'Show all the charges in each of their label text boxes
        lblServicesLabor.Text = decTotalServiceAndLaborFees.ToString("c")
        lblParts.Text = decTotalPartCharges.ToString("c")
        lblTax.Text = decPartsTaxCharges.ToString("c")
        lblTotalFees.Text = decTotalFees.ToString("c")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text boxes and labels
        ClearOther()
        ClearFees()

        'Unchecked the check boxes
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    'Function
    Function OilLubeCharges() As Decimal
        'Returns the total charges for an oil change and/or a lube job, if any.
        Const decOIL_CHANGE_CHARGE As Decimal = 26D
        Const decLUBE_JOB_CHARGE As Decimal = 18D
        Dim decOilLubeCharges As Decimal = 0

        'Add charges that are checked to the lube charges
        If chkOilChange.Checked = True Then
            decOilLubeCharges += decOIL_CHANGE_CHARGE
        End If

        If chkLubeJob.Checked = True Then
            decOilLubeCharges += decLUBE_JOB_CHARGE
        End If

        Return decOilLubeCharges
    End Function

    Function FlushCharges() As Decimal
        'Returns the total charges for a radiator flush and/or a transmission flush, if any.
        Const decRADIATOR_FLUSH_CHARGE As Decimal = 30D
        Const decTRANSMISSION_FLUSH_CHARGE As Decimal = 80D
        Dim decFlushCharges As Decimal = 0

        'Add charges that are checked to the flush charges
        If chkRadiatorFlush.Checked = True Then
            decFlushCharges += decRADIATOR_FLUSH_CHARGE
        End If

        If chkTransmissionFlush.Checked = True Then
            decFlushCharges += decTRANSMISSION_FLUSH_CHARGE
        End If

        Return decFlushCharges
    End Function

    Function MiscCharges() As Decimal
        'Returns the total charges for an inspection, muffler replacement, and/or a tire rotation, if any.
        Const decINSPECION_CHARGE As Decimal = 15D
        Const decREPLACE_MUFFLER_CHARGE As Decimal = 100D
        Const decTIRE_ROTATION_CHARGE As Decimal = 20D
        Dim decMiscCharges As Decimal = 0

        'Add charges that are checked to the flush charges
        If chkInspection.Checked = True Then
            decMiscCharges += decINSPECION_CHARGE
        End If

        If chkReplaceMuffler.Checked = True Then
            decMiscCharges += decREPLACE_MUFFLER_CHARGE
        End If

        If chkTireRotation.Checked = True Then
            decMiscCharges += decTIRE_ROTATION_CHARGE
        End If

        Return decMiscCharges
    End Function

    Function OtherCharges(ByVal decPartPrice As Decimal, ByVal decLaborHour As Decimal) As Decimal
        'Returns the total charges for other services (parts and labor), if any.
        Const intLABOR_RATE As Decimal = 20D 'Labor rate per hour
        Dim decOtherCharges As Decimal = 0
        Dim decPartTaxCharge As Decimal

        'Get the value of tax on the parts
        decPartTaxCharge = TaxCharges(decPartPrice)
        'Calculate total of other charges
        decOtherCharges = decPartPrice + decPartTaxCharge + (intLABOR_RATE * decLaborHour)

        Return decOtherCharges
    End Function

    Function TaxCharges(ByVal decPartPrice As Decimal) As Decimal
        'Returns the amount of sales tax, if any. Sales tax is 6%, and is only charged on parts.
        'If the customer purchased services only, no sales tax is charged.
        Const decSALES_TAX As Decimal = 0.06D
        Dim decTaxCharges As Decimal

        decTaxCharges = decPartPrice * decSALES_TAX

        Return decTaxCharges
    End Function

    Function TotalCharges(ByVal decServiceCharges As Decimal, ByVal decPartCharges As Decimal) As Decimal
        'Returns the total charges.
        Dim decTotalCharges As Decimal = decServiceCharges + decPartCharges

        Return decTotalCharges
    End Function

    Sub ClearOilLube()
        'This procedure clears the check boxes for oil change and lube job.
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    Sub ClearFlushes()
        'This procedure clears the check boxes for radiator flush and transmission flush.
        chkRadiatorFlush.Checked = False
        chkTransmissionFlush.Checked = False
    End Sub

    Sub ClearMisc()
        'This procedure clears the check boxes for inspection, muffler replacement and tire rotation.
        chkInspection.Checked = False
        chkReplaceMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    Sub ClearOther()
        'This procedure clears the text boxes for parts and labor.
        txtParts.Clear()
        txtLabor.Clear()
    End Sub

    Sub ClearFees()
        'This procedure clears the labels that display the labels in the section marked Summary
        lblServicesLabor.Text = String.Empty
        lblParts.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalFees.Text = String.Empty
    End Sub
End Class
