Imports System.IO
Public Class Form1
    ' Class-level declarations
    Dim strFilename As String               ' To hold the filename
    Dim intRecordNum As Integer = 1         ' Record number
    Dim inputFile As System.IO.StreamReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Get the name of the file to use.
        strFilename = InputBox("Enter the name of the file.", "Input Needed")

        ' Open the file.
        If File.Exists(strFilename) Then
            inputFile = File.OpenText(strFilename)
        Else
            MessageBox.Show("File not found.", "Error")
            Me.Close()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ' Read the next record.
        If inputFile.Peek <> -1 Then
            lblRecordNum.Text = intRecordNum.ToString
            lblFirstName.Text = inputFile.ReadLine
            lblMiddleName.Text = inputFile.ReadLine
            lblLastName.Text = inputFile.ReadLine
            lblEmployeeNum.Text = inputFile.ReadLine
            lblDept.Text = inputFile.ReadLine
            lblTelephone.Text = inputFile.ReadLine
            lblExtension.Text = inputFile.ReadLine
            lblEmail.Text = inputFile.ReadLine
            intRecordNum += 1
        Else
            MessageBox.Show("End of file.")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the form.
        lblFirstName.Text = String.Empty
        lblMiddleName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblEmployeeNum.Text = String.Empty
        lblDept.Text = String.Empty
        lblTelephone.Text = String.Empty
        lblExtension.Text = String.Empty
        lblEmail.Text = String.Empty

        ' Reset the focus
        lblFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            inputFile.Close()
        Catch
        End Try
    End Sub
End Class
