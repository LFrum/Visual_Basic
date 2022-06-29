<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioBook
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
        Me.grpAudioBook = New System.Windows.Forms.GroupBox()
        Me.lstAudioBook = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddBookToCart = New System.Windows.Forms.Button()
        Me.grpAudioBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAudioBook
        '
        Me.grpAudioBook.Controls.Add(Me.lstAudioBook)
        Me.grpAudioBook.Location = New System.Drawing.Point(12, 12)
        Me.grpAudioBook.Name = "grpAudioBook"
        Me.grpAudioBook.Size = New System.Drawing.Size(316, 135)
        Me.grpAudioBook.TabIndex = 6
        Me.grpAudioBook.TabStop = False
        Me.grpAudioBook.Text = "Select an Audio Book"
        '
        'lstAudioBook
        '
        Me.lstAudioBook.FormattingEnabled = True
        Me.lstAudioBook.ItemHeight = 16
        Me.lstAudioBook.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstAudioBook.Location = New System.Drawing.Point(18, 31)
        Me.lstAudioBook.Name = "lstAudioBook"
        Me.lstAudioBook.Size = New System.Drawing.Size(286, 84)
        Me.lstAudioBook.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(209, 165)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 46)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddBookToCart
        '
        Me.btnAddBookToCart.Location = New System.Drawing.Point(30, 165)
        Me.btnAddBookToCart.Name = "btnAddBookToCart"
        Me.btnAddBookToCart.Size = New System.Drawing.Size(139, 46)
        Me.btnAddBookToCart.TabIndex = 7
        Me.btnAddBookToCart.Text = "Add Book to Cart"
        Me.btnAddBookToCart.UseVisualStyleBackColor = True
        '
        'frmAudioBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 232)
        Me.Controls.Add(Me.grpAudioBook)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddBookToCart)
        Me.Name = "frmAudioBook"
        Me.Text = "Audio Book"
        Me.grpAudioBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAudioBook As GroupBox
    Friend WithEvents lstAudioBook As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddBookToCart As Button
End Class
