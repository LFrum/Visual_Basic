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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvKayakRentalPrices = New System.Windows.Forms.DataGridView()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New Kayak_Rental_Prices.KayaksDataSet()
        Me.KayakTypesTableAdapter = New Kayak_Rental_Prices.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.Weekly_Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Daily_Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hourly_Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvKayakRentalPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKayakRentalPrices
        '
        Me.dgvKayakRentalPrices.AllowUserToAddRows = False
        Me.dgvKayakRentalPrices.AllowUserToDeleteRows = False
        Me.dgvKayakRentalPrices.AutoGenerateColumns = False
        Me.dgvKayakRentalPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKayakRentalPrices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.Hourly_Rate, Me.Daily_Rate, Me.Weekly_Rate})
        Me.dgvKayakRentalPrices.DataSource = Me.KayakTypesBindingSource
        Me.dgvKayakRentalPrices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKayakRentalPrices.Location = New System.Drawing.Point(0, 0)
        Me.dgvKayakRentalPrices.Name = "dgvKayakRentalPrices"
        Me.dgvKayakRentalPrices.ReadOnly = True
        Me.dgvKayakRentalPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvKayakRentalPrices.Size = New System.Drawing.Size(464, 262)
        Me.dgvKayakRentalPrices.TabIndex = 0
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'Weekly_Rate
        '
        Me.Weekly_Rate.DataPropertyName = "Weekly_Rate"
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Weekly_Rate.DefaultCellStyle = DataGridViewCellStyle9
        Me.Weekly_Rate.HeaderText = "Weekly Rate"
        Me.Weekly_Rate.Name = "Weekly_Rate"
        Me.Weekly_Rate.ReadOnly = True
        '
        'Daily_Rate
        '
        Me.Daily_Rate.DataPropertyName = "Daily_Rate"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Daily_Rate.DefaultCellStyle = DataGridViewCellStyle8
        Me.Daily_Rate.HeaderText = "Daily Rate"
        Me.Daily_Rate.Name = "Daily_Rate"
        Me.Daily_Rate.ReadOnly = True
        '
        'Hourly_Rate
        '
        Me.Hourly_Rate.DataPropertyName = "Hourly_Rate"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Hourly_Rate.DefaultCellStyle = DataGridViewCellStyle7
        Me.Hourly_Rate.HeaderText = "Hourly Rate"
        Me.Hourly_Rate.Name = "Hourly_Rate"
        Me.Hourly_Rate.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 262)
        Me.Controls.Add(Me.dgvKayakRentalPrices)
        Me.Name = "Form1"
        Me.Text = "Kayak Rental Prices"
        CType(Me.dgvKayakRentalPrices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvKayakRentalPrices As System.Windows.Forms.DataGridView
    Friend WithEvents KayaksDataSet As Kayak_Rental_Prices.KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KayakTypesTableAdapter As Kayak_Rental_Prices.KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hourly_Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Daily_Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Weekly_Rate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
