Imports System.IO

Public Class Form1
    ' Class-level constant for the file name.
    Const strFILENAME As String = "Videos.txt"
    Structure VideoData
        Dim videoName As String     ' To hold the video name
        Dim yearProduced As String  ' To hold the year produced
        Dim runningTime As String   ' To hold the running time
        Dim rating As String        ' To hold the rating
    End Structure

    Private Sub mnuFileSaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSaveRecord.Click
        If txtName.Text = "" Then
            MessageBox.Show("Data is not complete and so cannot be saved to file")
        Else

            ' Add the new record to the file.
            Dim video As New VideoData

            video.videoName = txtName.Text
            video.yearProduced = txtYear.Text
            video.runningTime = txtRunningTime.Text
            video.rating = txtRating.Text

            ' Write the record.
            WriteRecordToFile(video)
        End If
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch.Click
        ' Search for a video by name.
        Dim strName As String = InputBox("Enter the name of the video.", "Search")
        FindRecord(strName.Trim())
    End Sub

    Private Sub mnuReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReport.Click
        ' Call the Print method to start printing.
        pdPrint.Print()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        ' Display an About box.
        MessageBox.Show("Video Collection version 1.0", "About")
    End Sub

    ' The ClearForm procedure Clears the Text in the text boxes and resets the Focus.
    Sub ClearForm()
        ' Clear the form.
        txtName.Clear()
        txtYear.Clear()
        txtRunningTime.Clear()
        txtRating.Clear()

        ' Reset the focus.
        txtName.Focus()
    End Sub

    ' The WriteRecordToFile procedure writes the video data to the file.
    Sub WriteRecordToFile(ByRef video As VideoData)

        ' Save the record to the file.
        Dim videoFile As System.IO.StreamWriter

        If System.IO.File.Exists(strFilename) Then
            ' Open the file.
            videoFile = System.IO.File.AppendText(strFilename)
        Else
            ' The file does not exist, so create it.
            videoFile = System.IO.File.CreateText(strFilename)
        End If

        ' Write the record.
        videoFile.WriteLine(video.videoName)
        videoFile.WriteLine(video.yearProduced)
        videoFile.WriteLine(video.runningTime)
        videoFile.WriteLine(video.rating)

        ' Close the file.
        videoFile.Close()

        ' Clear the form.
        ClearForm()
    End Sub
    ' The FindRecord procecure searches the file for the video name.
    Sub FindRecord(ByVal strName As String)

        ' Search for a record in the file.
        Dim video As New VideoData
        Dim blnFound As Boolean = False
        Dim videoFile As System.IO.StreamReader

        If System.IO.File.Exists(strFilename) Then
            ' Open the file.
            videoFile = System.IO.File.OpenText(strFilename)

            ' Search the records.
            Do Until (videoFile.Peek = -1) Or blnFound

                ' Read the next record.
                video.videoName = videoFile.ReadLine
                video.yearProduced = videoFile.ReadLine
                video.runningTime = videoFile.ReadLine
                video.rating = videoFile.ReadLine

                ' Is it the one?
                If strName.ToUpper = video.videoName.ToUpper Then
                    blnFound = True
                End If
            Loop

            ' Close the file.
            videoFile.Close()

            If blnFound Then

                ' The name was found.
                txtName.Text = video.videoName
                txtYear.Text = video.yearProduced
                txtRunningTime.Text = video.runningTime
                txtRating.Text = video.rating
            Else
                ' The name was not found
                MessageBox.Show(strName & " was not found.", "Record Not Found")
            End If
        Else
            ' Error opening file.
            MessageBox.Show("Cannot open file.", "Error")
        End If

    End Sub

    Private Sub pdPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        ' This procedure prints the video report.
        Dim vertPos As Integer
        Dim formatStr As String = "{0,30}{1,15}{2,15}{3,10}"
        Dim video As VideoData
        Dim videoFile As System.IO.StreamReader

        If System.IO.File.Exists(strFILENAME) Then
            ' Open the file.
            videoFile = System.IO.File.OpenText(strFILENAME)


            ' Print the report header.
            e.Graphics.DrawString("Video List",
                                  New Font("Courier New", 10, FontStyle.Bold),
                                  Brushes.Black, 150, 10)

            ' Print the date and time.
            e.Graphics.DrawString("Date and Time: " & Now.ToString,
                                  New Font("Courier New", 10, FontStyle.Bold),
                                  Brushes.Black, 10, 38)

            ' Print the column headings.
            e.Graphics.DrawString(String.Format(formatStr,
                                                "Video Name", "Year Produced",
                                                "Running Time", "Rating"),
                                            New Font("Courier New", 10, FontStyle.Bold),
                                            Brushes.Black, 10, 66)

            ' Set the vertical position for the first item.
            vertPos = 80

            ' Read the records.
            Do Until (videoFile.Peek = -1)

                video.videoName = videoFile.ReadLine
                video.yearProduced = videoFile.ReadLine
                video.runningTime = videoFile.ReadLine
                video.rating = videoFile.ReadLine

                ' Print the record.
                e.Graphics.DrawString(String.Format(formatStr,
                                                    video.videoName, video.yearProduced,
                                                    video.runningTime, video.rating),
                                                New Font("Courier New", 10, FontStyle.Bold),
                                                Brushes.Black, 10, vertPos)
                ' Update the vertical position.
                vertPos += 14
            Loop

            ' Close the file.
            videoFile.Close()
        Else
            ' Error opening file.
            MessageBox.Show("Cannot open file.", "Error")
        End If
    End Sub
End Class
