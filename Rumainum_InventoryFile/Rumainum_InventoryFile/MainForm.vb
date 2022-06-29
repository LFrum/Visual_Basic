Imports System.IO

Public Class frmMain
    Dim blnIsChanged As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
        'Load data from Invetory.txt into collection inventory
        Try
            Dim inventoryFile As StreamReader
            inventoryFile = File.OpenText("Inventory.txt")

            Do Until inventoryFile.EndOfStream
                Dim inv As New Inventory

                inv.InvNumber = inventoryFile.ReadLine()
                inv.Description = inventoryFile.ReadLine()
                inv.Cost = CDbl(inventoryFile.ReadLine())
                inv.Retail = CDbl(inventoryFile.ReadLine())
                inv.OnHand = CInt(inventoryFile.ReadLine())

                inventoryCollection.Add(inv, inv.InvNumber)
                lstInvNumber.Items.Add(inv.InvNumber)
            Loop
            inventoryFile.Close()
        Catch ex As Exception
            MessageBox.Show("File is not found")
        End Try
    End Sub
    'Clear all data in main form
    Private Sub ClearForm()
        lblInvoiceNumber.Text = String.Empty
        lblDescription.Text = String.Empty
        lblCost.Text = String.Empty
        lblRetail.Text = String.Empty
        lblOnHand.Text = String.Empty
    End Sub
    'Display the data into main form
    Private Sub DisplayData(ByVal inv As Inventory)
        lblInvoiceNumber.Text = inv.InvNumber
        lblDescription.Text = inv.Description
        lblCost.Text = inv.Cost.ToString()
        lblRetail.Text = inv.Retail.ToString()
        lblOnHand.Text = inv.OnHand.ToString()
    End Sub
    'Open AddForm and Update list box in MainForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAdd As New frmAdd
        frmAdd.ShowDialog()
        updatelistbox()
        blnIsChanged = True
    End Sub
    'Getting the invoice number from the user
    Private Function UserInvNumber() As String
        Dim strInvNumber As String
        strInvNumber = InputBox("What Invoice Number you want to update/display?", "Enter Invoice Number", " ")

        If strInvNumber = " " Then
            MessageBox.Show("You must enter an invoice number to continue.")
        End If

        Return strInvNumber
    End Function

    'Open UpdateForm and Update list box in MainForm
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frmUpdate As New frmUpdate

        Dim strInvNumber As String

        strInvNumber = UserInvNumber()

        If strInvNumber = "" Then
            Exit Sub
        ElseIf strInvNumber <> String.Empty Then
            ' Find the item in the list and store the index to the item.
            Dim index As Integer = lstInvNumber.FindString(strInvNumber)
            ' Determine if a valid index is returned. Select the item if it is valid.
            If index <> -1 Then
                Try
                    objFileInventory = CType(inventoryCollection.Item(lstInvNumber.Items(index)), Inventory)
                    frmUpdate.lblInvoiceNumber.Text = objFileInventory.InvNumber
                    frmUpdate.txtDescription.Text = objFileInventory.Description
                    frmUpdate.txtCost.Text = objFileInventory.Cost.ToString()
                    frmUpdate.txtRetail.Text = objFileInventory.Retail.ToString()
                    frmUpdate.txtOnHand.Text = objFileInventory.OnHand.ToString()
                    'Open UpdateForm
                    frmUpdate.ShowDialog()
                    blnIsChanged = True
                Catch ex As Exception
                    MessageBox.Show("Inventory Number is invalid!")
                End Try
            End If
        End If

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strInvNumber As String

        strInvNumber = UserInvNumber()

        If strInvNumber = "" Then
            Exit Sub
        ElseIf strInvNumber <> String.Empty Then
            ' Find the item in the list and store the index to the item.
            Dim index As Integer = lstInvNumber.FindString(strInvNumber)
            ' Determine if a valid index is returned. Select the item if it is valid.
            If index <> -1 Then
                Try
                    lstInvNumber.SetSelected(index, True)
                    objFileInventory = CType(inventoryCollection.Item(lstInvNumber.Items(index)), Inventory)
                    'Display the invetory data
                    DisplayData(objFileInventory)
                Catch ex As Exception
                    MessageBox.Show("Inventory Number is invalid!")
                End Try
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If blnIsChanged = True Then
            MessageBox.Show("The inventory has been changed since it last saved but no worries, it will save first and then exit the application :)")
            saveFile()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveFile()
        'Reset the boolean back to false
        blnIsChanged = False
    End Sub

    Public Sub saveFile()
        Dim outputFile As StreamWriter
        Dim intNumberOfData As Integer
        Dim intCounter As Integer
        Dim objOutputInvetoryFile As New Inventory

        'Re-write the inventory.txt file
        outputFile = File.CreateText("Inventory.txt")
        intNumberOfData = lstInvNumber.Items.Count

        For intCounter = 0 To intNumberOfData - 1
            objOutputInvetoryFile = CType(inventoryCollection.Item(lstInvNumber.Items.Item(intCounter)), Inventory)
            outputFile.WriteLine(objOutputInvetoryFile.InvNumber)
            outputFile.WriteLine(objOutputInvetoryFile.Description)
            outputFile.WriteLine(objOutputInvetoryFile.Cost.ToString())
            outputFile.WriteLine(objOutputInvetoryFile.Retail.ToString())
            outputFile.WriteLine(objOutputInvetoryFile.OnHand.ToString())
        Next
    End Sub
End Class