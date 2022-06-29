<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFive = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picOne = New System.Windows.Forms.PictureBox()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(96, 91)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFive
        '
        Me.picFive.Image = CType(resources.GetObject("picFive.Image"), System.Drawing.Image)
        Me.picFive.Location = New System.Drawing.Point(207, 11)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(42, 67)
        Me.picFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFive.TabIndex = 10
        Me.picFive.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = CType(resources.GetObject("picFour.Image"), System.Drawing.Image)
        Me.picFour.Location = New System.Drawing.Point(159, 11)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(42, 67)
        Me.picFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFour.TabIndex = 9
        Me.picFour.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = CType(resources.GetObject("picThree.Image"), System.Drawing.Image)
        Me.picThree.Location = New System.Drawing.Point(111, 11)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(42, 67)
        Me.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThree.TabIndex = 8
        Me.picThree.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = CType(resources.GetObject("picTwo.Image"), System.Drawing.Image)
        Me.picTwo.Location = New System.Drawing.Point(63, 11)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(42, 67)
        Me.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTwo.TabIndex = 7
        Me.picTwo.TabStop = False
        '
        'picOne
        '
        Me.picOne.Image = CType(resources.GetObject("picOne.Image"), System.Drawing.Image)
        Me.picOne.Location = New System.Drawing.Point(15, 11)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(42, 67)
        Me.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOne.TabIndex = 6
        Me.picOne.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 124)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Name = "Form1"
        Me.Text = "Clickable Images"
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picFive As System.Windows.Forms.PictureBox
    Friend WithEvents picFour As System.Windows.Forms.PictureBox
    Friend WithEvents picThree As System.Windows.Forms.PictureBox
    Friend WithEvents picTwo As System.Windows.Forms.PictureBox
    Friend WithEvents picOne As System.Windows.Forms.PictureBox

End Class
