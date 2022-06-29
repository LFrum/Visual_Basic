Imports System.IO
Class MainForm

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try


            ' Create an instance of the Customer class.
            Dim objPerson As New Customer

            ' Assign values to each property.
            With objPerson
                .FirstName = txtFirstName.Text
                .LastName = txtLastName.Text
                .Address = txtAddress.Text
                .City = txtCity.Text
                .State = txtState.Text
                .Zip = txtZip.Text
                .Phone = txtPhone.Text
                .CustomerNumber = CInt(txtCustomerNumber.Text)
                .MailingList = chkMailingList.Checked
                .Comments = txtComments.Text
            End With
            Try
                customers.Add(objPerson, objPerson.CustomerNumber.ToString())
                lstCustomers.Items.Add(objPerson.CustomerNumber.ToString() & " " & objPerson.FirstName & " " & objPerson.LastName)
                blnChange = True
            Catch ex As Exception
                MessageBox.Show(" Do not enter customers with the same customer number ...numbers have to be unique", "Error")
            End Try



        Catch ex As Exception
            MessageBox.Show("Make sure all data is entered before you save data")
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()
        txtCustomerNumber.Clear()
        txtComments.Clear()

        ' Set the chkMailingList Checked property to False.
        chkMailingList.Checked = False

        ' Give the Focus to the txtFirstName text box.
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim searchCust As New Customer
            Dim strSearch As String
            If lstCustomers.SelectedIndex <> -1 Then
                Dim intIndex As Integer = lstCustomers.SelectedItem.ToString().IndexOf(" ")
                strSearch = lstCustomers.SelectedItem.ToString().Substring(0, intIndex)
                searchCust = CType(customers.Item(strSearch), Customer)

                ' Display the information stored in each property.
                With searchCust
                    MessageBox.Show(.FirstName & " " & .LastName &
                                    ControlChars.CrLf &
                                    .Address &
                                    ControlChars.CrLf &
                                    .City & ", " & .State & "  " & .Zip &
                                    ControlChars.CrLf &
                                    .Phone &
                                    ControlChars.CrLf &
                                    "Customer Number: " & .CustomerNumber.ToString() &
                                    ControlChars.CrLf &
                                    "Mailing List: " & .MailingList.ToString() &
                                    ControlChars.CrLf &
                                    .Comments,
                                    "Customer Information")
                End With
            Else
                MessageBox.Show("Select a customer first")

            End If

        Catch ex As Exception
            MessageBox.Show(" Conversion problems")
        End Try
    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            Dim searchCust As New Customer
            Dim strSearch As String
            If lstCustomers.SelectedIndex <> -1 Then
                Dim intIndex As Integer = lstCustomers.SelectedItem.ToString().IndexOf(" ")
                strSearch = lstCustomers.SelectedItem.ToString().Substring(0, intIndex)
                customers.Remove(strSearch)
                lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex)
                blnChange = True
            Else
                MessageBox.Show("Select a customer first")

            End If

        Catch ex As Exception
            MessageBox.Show(" Conversion problems")
        End Try
    End Sub

   

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If blnChange = True Then
            Dim customerFile As StreamWriter 'create file object to associate file with writing 
            customerFile = File.CreateText("Customer.txt") 'open file to overwrite existing contents
            Dim custSearch As Customer
            For intIndex As Integer = 1 To customers.Count ' traverses through each item of collection- collection index starts at 1
                custSearch = CType(customers.Item(intIndex), Customer) ' converts an item of collection (object type) to Customer type

                ' Save the information stored in each member variable of the object to file.
                'Each member variable is also delimited with a ,(comma)
                With custSearch
                    customerFile.WriteLine(.CustomerNumber.ToString() & "," & .FirstName & "," & .LastName & "," & .Address & "," & .City & "," & .State & "," & .Zip & "," &
                                           .Phone & "," & .MailingList.ToString() & "," & .Comments)
                End With
                ' custSearch = Nothing
            Next
            customerFile.Close() 'close the file
        End If

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Reads the file into the collection
        Dim custFile As StreamReader 'creat a file object to associate with reading from file
        ' Create an instance of the Customer class.
        Dim objPerson As New Customer
        Dim strReadString(9) As String ' an array of strings to read from file. Created an array of 10 elements as there are 10 columns in each row

        Try
            custFile = File.OpenText("Customer.txt") ' associate file object to actual data file
            Do While custFile.Peek <> -1 'loop to continue till end of file
                strReadString = custFile.ReadLine.Split(CChar(",")) 'splits the current row read using the Split function
                'here we split the curent row into an array of strings using the delimiter ","(comma)
                MessageBox.Show(strReadString(0)) 'just a check to see if all rows are read into array
                With objPerson 'Reads the elements of the array into the different member variables of the object 
                    .CustomerNumber = CInt(strReadString(0))
                    .FirstName = strReadString(1)
                    .LastName = strReadString(2)
                    .Address = strReadString(3)
                    .City = strReadString(4)
                    .State = strReadString(5)
                    .Zip = strReadString(6)
                    .MailingList = CBool(strReadString(8))
                    .Comments = strReadString(9)
                End With
                customers.Add(objPerson, objPerson.CustomerNumber.ToString()) ' adds the object to the collection
                lstCustomers.Items.Add(objPerson.CustomerNumber.ToString() & " " & objPerson.FirstName & " " & objPerson.LastName) 'Displays Number and name in List box
            Loop
            custFile.Close() 'close the file after reading

        Catch ex As Exception
            MessageBox.Show("File does not exist")
        End Try
    End Sub
End Class
