<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddBookToCart = New System.Windows.Forms.Button()
        Me.grpPrintBooks = New System.Windows.Forms.GroupBox()
        Me.lstPrintBook = New System.Windows.Forms.ListBox()
        Me.grpPrintBooks.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(250, 145)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 48)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddBookToCart
        '
        Me.btnAddBookToCart.Location = New System.Drawing.Point(28, 145)
        Me.btnAddBookToCart.Name = "btnAddBookToCart"
        Me.btnAddBookToCart.Size = New System.Drawing.Size(151, 48)
        Me.btnAddBookToCart.TabIndex = 4
        Me.btnAddBookToCart.Text = "Add Book to Cart"
        Me.btnAddBookToCart.UseVisualStyleBackColor = True
        '
        'grpPrintBooks
        '
        Me.grpPrintBooks.Controls.Add(Me.lstPrintBook)
        Me.grpPrintBooks.Location = New System.Drawing.Point(12, 12)
        Me.grpPrintBooks.Name = "grpPrintBooks"
        Me.grpPrintBooks.Size = New System.Drawing.Size(367, 127)
        Me.grpPrintBooks.TabIndex = 3
        Me.grpPrintBooks.TabStop = False
        Me.grpPrintBooks.Text = "Select a Print Book"
        '
        'lstPrintBook
        '
        Me.lstPrintBook.FormattingEnabled = True
        Me.lstPrintBook.ItemHeight = 16
        Me.lstPrintBook.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrintBook.Location = New System.Drawing.Point(16, 26)
        Me.lstPrintBook.Name = "lstPrintBook"
        Me.lstPrintBook.Size = New System.Drawing.Size(315, 84)
        Me.lstPrintBook.TabIndex = 0
        '
        'frmPrintBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 216)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddBookToCart)
        Me.Controls.Add(Me.grpPrintBooks)
        Me.Name = "frmPrintBook"
        Me.Text = "Print Book"
        Me.grpPrintBooks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddBookToCart As Button
    Friend WithEvents grpPrintBooks As GroupBox
    Friend WithEvents lstPrintBook As ListBox
End Class
