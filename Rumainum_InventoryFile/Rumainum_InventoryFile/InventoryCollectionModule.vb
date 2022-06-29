Module InventoryCollectionModule
    'Create a collection to hold Inventory object
    Public inventoryCollection As New Collection
    Public objFileInventory As New Inventory

    'AddInvoice procedure adds the object refrenced by inv to the collection
    'It uses the Invoice number as the key

    Public Sub addInventory(ByVal inv As Inventory)
        Try
            inventoryCollection.Add(inv, inv.InvNumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub updatelistbox()
        'Clear the list box
        frmMain.lstInvNumber.Items.Clear()

        'Load the Invoice number in the collection into the list box
        Dim inv As New Inventory
        For Each inv In inventoryCollection
            frmMain.lstInvNumber.Items.Add(inv.InvNumber)
        Next

    End Sub
End Module
