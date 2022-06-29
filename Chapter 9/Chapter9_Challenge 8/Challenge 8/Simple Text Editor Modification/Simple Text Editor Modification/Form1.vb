Imports System.IO

Public Class Form1

    Private strFilename As String = String.Empty ' Document filename
    Dim blnIsChanged As Boolean = False          ' File change flag

    Sub ClearDocument()
        ' Clear the contents of the text box.
        txtDocument.Clear()

        ' Clear the document name.
        strFilename = String.Empty

        ' Set isChanged to False.
        blnIsChanged = False
    End Sub

    ' The OpenDocument procedure opens a file and loads it
    ' into the TextBox for editing.

    Sub OpenDocument()
        Dim inputFile As StreamReader ' Object variable

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Retrieve the selected filename.
            strFilename = ofdOpenFile.FileName

            Try
                ' Open the file.
                inputFile = File.OpenText(strFilename)

                ' Read the file's contents into the TextBox.
                txtDocument.Text = inputFile.ReadToEnd

                ' Close the file.
                inputFile.Close()

                ' Update the isChanged variable.
                blnIsChanged = False
            Catch
                ' Error message for file open error.
                MessageBox.Show("Error opening the file.")
            End Try
        End If
    End Sub

    ' The SaveDocument procedure saves the current document.

    Sub SaveDocument()
        Dim outputFile As StreamWriter ' Object variable

        Try
            ' Create the file.
            outputFile = File.CreateText(strFilename)

            ' Write the TextBox to the file.
            outputFile.Write(txtDocument.Text)

            ' Close the file.
            outputFile.Close()

            ' Update the isChanged variable.
            blnIsChanged = False
        Catch
            ' Error message for file creation error.
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub

    Private Sub txtDocument_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocument.TextChanged
        ' Indicate the text has changed.
        blnIsChanged = True
    End Sub

    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing the document.
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            ' Document has not changed, so clear it.
            ClearDocument()
        End If
    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing and replacing.
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            ' Document has not changed, so replace it.
            ClearDocument()
            OpenDocument()
        End If
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        ' Does the current document have a filename?
        If strFilename = String.Empty Then
            ' The document has not been saved, so
            ' use Save As dialog box.
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFilename = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            ' Save the document with the current filename.
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSaveAs.Click
        ' Save the current document under a new filename.
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        ' Display an about box.
        MessageBox.Show("Simple Text Editor version 2.0")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' If the document has not been changed, confirm
        ' before exiting.
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Do you wish to discard your changes?",
                               "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub pdPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        ' Print the contents of the text box.
        e.Graphics.DrawString(txtDocument.Text,
                              New Font("MS Sans Serif", 12, FontStyle.Regular),
                              Brushes.Black, 10, 10)
    End Sub

    Private Sub mnuFilePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFilePrint.Click
        ' Print the current document.
        pdPrint.Print()
    End Sub

    Private Sub mnuViewFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewFont.Click
        ' Show the font dialog.
        If fdFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Change the text font.
            txtDocument.Font = fdFont.Font
        End If
    End Sub

    Private Sub mnuViewColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewColor.Click
        ' Set the default color to the current foreground color.
        cdColor.Color = txtDocument.ForeColor

        ' Show the color dialog.
        If cdColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Change the text color.
            txtDocument.ForeColor = cdColor.Color
        End If
    End Sub
End Class