Imports System.IO

Public Class frmUpdate

    'Get data from the update form
    Private Sub GetData(ByVal objUpdateInventory As Inventory)
        Try
            objFileInventory.Description = txtDescription.Text
            objFileInventory.Cost = CDbl(txtCost.Text)
            objFileInventory.Retail = CDbl(txtRetail.Text)
            objFileInventory.OnHand = CInt(txtOnHand.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid data!")
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim objUpdateInventory As New Inventory

        GetData(objUpdateInventory)
        MessageBox.Show("Inventory updated.")
        'updatelistbox()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class

