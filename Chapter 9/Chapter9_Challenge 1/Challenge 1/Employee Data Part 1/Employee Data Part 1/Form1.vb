Imports System.IO
Public Class Form1
    ' Class-level declarations
    Dim strFilename As String   ' To hold the filename
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get the name of the file to use.
        strFilename = InputBox("Enter the name of the file.", "Input Needed")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Save the data to the file.
        Dim outputFile As System.IO.StreamWriter

        ' Open the file.
        outputFile = System.IO.File.AppendText(strFilename)

        ' Write the data.
        outputFile.WriteLine(txtFirstName.Text)
        outputFile.WriteLine(txtMiddleName.Text)
        outputFile.WriteLine(txtLastName.Text)
        outputFile.WriteLine(txtEmployeeNum.Text)
        outputFile.WriteLine(cboDept.Text)
        outputFile.WriteLine(txtTelephone.Text)
        outputFile.WriteLine(txtExtension.Text)
        outputFile.WriteLine(txtEmail.Text)

        ' Close the file.
        outputFile.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the form.
        txtFirstName.Text = String.Empty
        txtMiddleName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtEmployeeNum.Text = String.Empty
        cboDept.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtExtension.Text = String.Empty
        txtEmail.Text = String.Empty

        ' Reset the focus
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
