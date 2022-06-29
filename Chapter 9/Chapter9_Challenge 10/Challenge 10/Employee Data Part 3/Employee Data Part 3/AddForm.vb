Imports System.IO

Public Class AddForm

    ' Class-level declarations
    Public outputFile As StreamWriter   ' The StreamWriter Object

    Private Sub AddForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Make sure a file has been opened and it exists.
        If g_strFilename = String.Empty Then

            ' Set the Save File Dialog filter.
            ofdOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            ofdOpenFile.CheckFileExists = False

            ' Get the filename.
            If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                g_strFilename = ofdOpenFile.FileName

                ' Determine if the file exits.
                If Not File.Exists(g_strFilename) Then

                    ' Open the file to create it.
                    outputFile = System.IO.File.AppendText(g_strFilename)

                    ' Now close the file. It will be reopened when
                    ' the save is actually performed.
                    outputFile.Close()
                End If
            Else
                ' Set the filename to an Empty String.
                g_strFilename = String.Empty

                ' Close the AddForm form.
                Me.Close()
            End If

        ElseIf Not File.Exists(g_strFilename) Then
            ' Display a message to the user indicating that the file does not exit.
            MessageBox.Show("The file " & g_strFilename & " does not exist.", "Error")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Open the file.
        outputFile = File.AppendText(g_strFilename)

        ' Save the record to the file.
        SaveRecord()

        ' Display a message box to the user indicating that the record was saved.
        MessageBox.Show("Record saved.")

        ' Clear the Text on the AddForm form.
        ClearForm()

        ' Close the file.
        outputFile.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text on the AddForm form.
        ClearForm()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the AddForm form.
        Me.Close()
    End Sub

    ' The SaveRecord procedure writes the currently displayed data to the file.
    Sub SaveRecord()
        ' Write the currently displayed data to the file.
        outputFile.WriteLine(txtFirstName.Text)
        outputFile.WriteLine(txtMiddleName.Text)
        outputFile.WriteLine(txtLastName.Text)
        outputFile.WriteLine(txtEmployeeNum.Text)
        outputFile.WriteLine(cboDept.Text)
        outputFile.WriteLine(txtTelephone.Text)
        outputFile.WriteLine(txtExtension.Text)
        outputFile.WriteLine(txtEmail.Text)
    End Sub

    ' The ClearForm procedure clears the Text in the text boxes.
    Sub ClearForm()
        ' Clear the Text in the text boxes.
        txtFirstName.Text = String.Empty
        txtMiddleName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtEmployeeNum.Text = String.Empty
        cboDept.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtExtension.Text = String.Empty
        txtEmail.Text = String.Empty

        ' Give the focus to the txtFirstName text box.
        txtFirstName.Focus()
    End Sub
End Class