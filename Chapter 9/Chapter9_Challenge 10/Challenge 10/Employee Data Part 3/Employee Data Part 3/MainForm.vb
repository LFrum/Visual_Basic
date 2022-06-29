Imports System.IO

Public Class MainForm
    ' Class-level variables
    Public inputFile As StreamReader    ' The StreamReader Object

    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        ' Open the file.
        If OpenInputFile() Then

            ' Read the record from the file and display it.
            If inputFile.Peek <> -1 Then
                ReadNextRecord()
            Else
                ' Display a message to the user indicating that no records exist.
                MessageBox.Show("No records in file.")
            End If
        End If
    End Sub

    Private Sub mnuFilePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFilePrint.Click
        pdPrint.Print()
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        ' Close the MainForm form.
        Me.Close()
    End Sub

    Private Sub mnuEditAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditAddRecord.Click
        Dim frmAdd As New AddForm   ' Create an instance of the AddForm form.

        ' Determine if the file has a name.
        If Not g_strFilename = String.Empty Then

            ' Close the file if it's currently open.
            inputFile.Close()
        End If

        ' Display the AddForm form.
        AddForm.ShowDialog()

        ' Determine if the file has a name.
        If Not g_strFilename = String.Empty Then

            ' Determine if the file exits.
            If File.Exists(g_strFilename) Then

                ' Reopen the file, if one was open.
                inputFile = File.OpenText(g_strFilename)

                ' Read the record from the file and display it.
                ReadNextRecord()
            Else
                ' Display a message to the user indicating that the file does not exist.
                MessageBox.Show("The file " & g_strFilename & " does not exist.", "Error")
            End If
        End If
    End Sub

    Private Sub mnuSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch.Click
        ' Search for a record by employee number.
        Dim searchNum As String = String.Empty  ' The Employee Number, intitalized to an Empty String.

        ' Get the Employee Number to search for as input from the user.
        searchNum = InputBox("Enter the employee number to search for.",
                             "Search By Employee Number")

        ' Determine that the employee number is not an Empty String.
        If Not searchNum = String.Empty Then

            ' Search for the employee data using the Employee Number.
            FindRecordByNum(searchNum.Trim)
        End If
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        ' Display an About window.
        MessageBox.Show("Employee Data Application Version 3.0", "About")
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        ' Determine if the filename contains a value.
        If Not g_strFilename = String.Empty Then

            ' Determine if there is data in the file.
            If inputFile.Peek <> -1 Then

                ' Display the customer data record.
                ReadNextRecord()
            Else
                ' Display a message to the user indicating that no more records exist.
                MessageBox.Show("No more records.")
            End If
        End If

    End Sub

    Private Sub pdPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        ' Print the header.
        e.Graphics.DrawString("Employee Record",
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 10)

        ' Print the date and time.
        e.Graphics.DrawString("Date and Time: " & Now.ToString,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 38)

        ' Print the employee data.
        e.Graphics.DrawString("Last Name: " & lblLastName.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 80)
        e.Graphics.DrawString("First Name: " & lblFirstName.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 94)
        e.Graphics.DrawString("Middle Name: " & lblMiddleName.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 108)
        e.Graphics.DrawString("Employee Number: " & lblEmployeeNum.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 122)
        e.Graphics.DrawString("Department: " & lblDept.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 136)
        e.Graphics.DrawString("Telephone: " & lblTelephone.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 150)
        e.Graphics.DrawString("Extension: " & lblExtension.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 164)
        e.Graphics.DrawString("E-mail address: " & lblEmail.Text,
                              New Font("Courier New", 10, FontStyle.Bold),
                              Brushes.Black, 10, 178)
    End Sub
    ' The OpenInputFile function returns True if a file is opened, otherwise it returns False.
    Function OpenInputFile() As Boolean
        Dim blnStatus As Boolean = False    ' The status flag, initialized to False

        ' Set the Save File Dialog filter.
        ofdOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        ' Get the filename as input from the user.
        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Set the filename.
            g_strFilename = ofdOpenFile.FileName

            ' Open the file.
            inputFile = File.OpenText(g_strFilename)

            ' Set the status flag to True.
            blnStatus = True
        End If

        ' Return the status.
        Return blnStatus
    End Function

    ' The ReadNextRecord procedure reads and displays data from the file.
    Sub ReadNextRecord()

        ' Read the next record and display it.
        lblFirstName.Text = inputFile.ReadLine
        lblMiddleName.Text = inputFile.ReadLine
        lblLastName.Text = inputFile.ReadLine
        lblEmployeeNum.Text = inputFile.ReadLine
        lblDept.Text = inputFile.ReadLine
        lblTelephone.Text = inputFile.ReadLine
        lblExtension.Text = inputFile.ReadLine
        lblEmail.Text = inputFile.ReadLine
    End Sub

    ' The FindRecordByNum procedure searches the file for customer data based on the Employee Number.
    Sub FindRecordByNum(ByVal searchNum As String)
        Dim blnFound As Boolean = False         ' The found flag, intialized to False

        ' Determine if the file has a name.
        If g_strFilename = String.Empty Then

            ' Display a message to the user indicating that no file is open.
            MessageBox.Show("No file open.", "Error")
        Else
            ' Close the file.
            inputFile.Close()

            ' Determine if the file exists.
            If File.Exists(g_strFilename) Then

                ' Open the file.
                inputFile = System.IO.File.OpenText(g_strFilename)

                ' Search the records to the end of the file or until a match is found.
                Do Until (inputFile.Peek = -1) Or blnFound

                    ' Read the next record.
                    ReadNextRecord()

                    ' Is it the one?
                    If searchNum.ToUpper = lblEmployeeNum.Text.ToUpper Then

                        blnFound = True ' Set the found flag to True.
                    End If
                Loop

                ' The customer record was found.
                If blnFound Then

                    ' Display the Customer Record.
                    ReadNextRecord()
                Else
                    ' Display a message to the user indicating that the record was not found.
                    MessageBox.Show(searchNum & " was not found.", "Record Not Found")
                End If
            Else
                ' Display a message to the user indicating that there was an error opening the file.
                MessageBox.Show("Cannot open file.", "Error")
            End If
        End If
    End Sub
End Class
