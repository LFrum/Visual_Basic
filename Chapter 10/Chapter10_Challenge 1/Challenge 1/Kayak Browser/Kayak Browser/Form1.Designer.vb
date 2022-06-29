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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKayakTypes = New System.Windows.Forms.ListBox()
        Me.lblKayakDescription = New System.Windows.Forms.Label()
        Me.KayaksDataSet = New Kayak_Browser.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Kayak_Browser.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a kayak type to view a description"
        '
        'lstKayakTypes
        '
        Me.lstKayakTypes.DataSource = Me.KayakTypesBindingSource
        Me.lstKayakTypes.DisplayMember = "Name"
        Me.lstKayakTypes.FormattingEnabled = True
        Me.lstKayakTypes.Location = New System.Drawing.Point(22, 39)
        Me.lstKayakTypes.Name = "lstKayakTypes"
        Me.lstKayakTypes.Size = New System.Drawing.Size(186, 121)
        Me.lstKayakTypes.TabIndex = 1
        Me.lstKayakTypes.ValueMember = "Name"
        '
        'lblKayakDescription
        '
        Me.lblKayakDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKayakDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.lblKayakDescription.Location = New System.Drawing.Point(228, 39)
        Me.lblKayakDescription.Name = "lblKayakDescription"
        Me.lblKayakDescription.Size = New System.Drawing.Size(344, 121)
        Me.lblKayakDescription.TabIndex = 2
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 172)
        Me.Controls.Add(Me.lblKayakDescription)
        Me.Controls.Add(Me.lstKayakTypes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kayak Browser"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstKayakTypes As System.Windows.Forms.ListBox
    Friend WithEvents lblKayakDescription As System.Windows.Forms.Label
    Friend WithEvents KayaksDataSet As Kayak_Browser.KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KayakTypesTableAdapter As Kayak_Browser.KayaksDataSetTableAdapters.KayakTypesTableAdapter

End Class
