Imports System.IO

Public Class frmAdd
    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub

    Private Sub GetData(ByVal inv As Inventory)
        inv.InvNumber = txtInvNumber.Text
        inv.Description = txtDescription.Text
        inv.Cost = CDbl(txtCost.Text)
        inv.Retail = CDbl(txtRetail.Text)
        inv.OnHand = CInt(txtOnHand.Text)

        'Write the data to Inventory.txt file
        Dim inventoryFile As StreamWriter
        Dim strFileName As String
        strFileName = "Inventory.txt"
        inventoryFile = File.AppendText("Inventory.txt")

        inventoryFile.WriteLine(inv.InvNumber)
        inventoryFile.WriteLine(inv.Description)
        inventoryFile.WriteLine(inv.Cost)
        inventoryFile.WriteLine(inv.Retail)
        inventoryFile.WriteLine(inv.OnHand)

        inventoryFile.Close()

    End Sub

    Private Sub ClearForm()
        txtInvNumber.Clear()
        txtDescription.Clear()
        txtCost.Clear()
        txtRetail.Clear()
        txtOnHand.Clear()
        'Focus set on InvNumber
        txtInvNumber.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim objInventory As New Inventory

        GetData(objInventory)
        addInventory(objInventory)
        MessageBox.Show("Inventory added.")
        updatelistbox()
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class