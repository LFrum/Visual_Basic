Imports System.IO
Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Read the input file
        ReadCollectionFromFile()
        UpdateListBox()
    End Sub

    ' The ClearForm procedure clears the form.
    Private Sub ClearForm()
        lblFirstName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblIdNumber.Text = String.Empty
        lblTestAverage.Text = String.Empty
        lblGrade.Text = String.Empty
    End Sub

    ' The UpdateListBox procedure updates the
    ' contents of the list box.
    Private Sub UpdateListBox()
        ' Clear the list box.
        lstIdNumbers.Items.Clear()

        ' Load the ID numbers in the collection
        ' into the list box.
        Dim s As Student
        For Each s In studentCollection
            lstIdNumbers.Items.Add(s.IdNumber)
        Next

        ' Select the first item in the list.
        If lstIdNumbers.Items.Count > 0 Then
            lstIdNumbers.SelectedIndex = 0
        Else
            ClearForm()
        End If
    End Sub

    ' The DisplayData procedure displays the data contained
    ' in the Student object parameter.
    Private Sub DisplayData(ByVal s As Student)
        lblLastName.Text = s.LastName
        lblFirstName.Text = s.FirstName
        lblIdNumber.Text = s.IdNumber
        lblTestAverage.Text = s.TestAverage.ToString()
        lblGrade.Text = s.Grade
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Create an instance of the AddForm form.
        Dim frmAdd As New AddForm

        ' Display the form.
        frmAdd.ShowDialog()

        ' Update the contents of the list box.
        UpdateListBox()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim intIndex As Integer

        ' Make sure an item is selected.
        If lstIdNumbers.SelectedIndex <> -1 Then
            ' Confirm that the user wants to remove the item.
            If MessageBox.Show("Are you sure?", "Confirm Deletion",
            MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then

                ' Retrieve the student's data from the collection.
                intIndex = lstIdNumbers.SelectedIndex

                Try
                    ' Remove the selected item from the collection.
                    studentCollection.Remove(
                    lstIdNumbers.SelectedItem.ToString())

                    ' Update the list box.
                    UpdateListBox()
                Catch ex As Exception
                    ' Error message
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub lstIdNumbers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstIdNumbers.SelectedIndexChanged
        Dim objStudent As Student

        ' See if an item is selected.
        If lstIdNumbers.SelectedIndex <> -1 Then
            ' Retrieve the student's data from the collection.
            Try
                objStudent = CType(studentCollection.Item(
               lstIdNumbers.SelectedItem), Student)

                ' Display the student data.
                DisplayData(objStudent)
            Catch ex As Exception
                ' Error message
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Save the file and close the form.
        SaveCollectionToFile()
        Me.Close()
    End Sub

    ' The ReadCollectionFromFile procedure reads 
    ' the student collection from a file.
    Sub ReadCollectionFromFile()
        ' Exit this method if no input file is found
        If Not File.Exists("students.txt") Then
            Return
        End If
        ' At this point, we know the file exists.
        Dim studentFile As StreamReader = File.OpenText("students.txt")
        Do
            Dim S As New Student
            With studentFile
                S.IdNumber = .ReadLine()
                S.FirstName = .ReadLine()
                S.LastName = .ReadLine()
                ' If the test average cannot be converted, break
                ' out of the loop and stop reading the file.
                If Not Double.TryParse(.ReadLine(), S.TestAverage) Then
                    Exit Do
                End If
                studentCollection.Add(S, S.IdNumber)
            End With

        Loop Until (studentFile.Peek = -1)
        studentFile.Close()
    End Sub

    ' The SaveCollectionToFile procedure saves
    ' the student collection to a file.
    Private Sub SaveCollectionToFile()
        'Don't save an empty collection
        If studentCollection.Count = 0 Then Return
        Dim studentFile As StreamWriter = File.CreateText("students.txt")
        For Each item As Student In studentCollection
            With studentFile
                .WriteLine(item.IdNumber)
                .WriteLine(item.FirstName)
                .WriteLine(item.LastName)
                .WriteLine(item.TestAverage)
            End With
        Next
        studentFile.Close()
    End Sub
End Class