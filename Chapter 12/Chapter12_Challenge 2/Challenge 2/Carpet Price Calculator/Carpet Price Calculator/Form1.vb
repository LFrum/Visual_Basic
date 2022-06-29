Public Class Form1

    ' Class-level declarations
    Dim carpetSold As New Carpet
    Dim floorSpace As New Rectangle

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Copy the data into the object properties.
        CopyCarpetData()
        CopyRoomData()

        ' Display the area and price.
        lblArea.Text = floorSpace.Area.ToString()
        lblTotal.Text = (floorSpace.Area * carpetSold.Price).ToString("C")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the Text in the text boxes.
        txtColor.Clear()
        txtStyle.Clear()
        txtPrice.Clear()
        txtWidth.Clear()
        txtLength.Clear()

        ' Set the Text in the labels to an empty string.
        lblArea.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Give the Focus to the txtColor text box.
        txtColor.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Sub CopyCarpetData()
        Try
            carpetSold.Color = txtColor.Text
            carpetSold.Style = txtStyle.Text
            carpetSold.Price = CDec(txtPrice.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Sub CopyRoomData()
        Try
            floorSpace.Length = CSng(txtLength.Text)
            floorSpace.Width = CSng(txtWidth.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class
