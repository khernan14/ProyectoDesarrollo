<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHistorialFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgHistoricos = New System.Windows.Forms.DataGridView()
        Me.VistaFacturasHistoricosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaFacturasHistoricosDataSet1 = New CarWash_La_Lima.VistaFacturasHistoricosDataSet1()
        Me.VistaFacturasHistoricosTableAdapter = New CarWash_La_Lima.VistaFacturasHistoricosDataSet1TableAdapters.VistaFacturasHistoricosTableAdapter()
        Me.FacturasHistoricosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaHistoricosDataSet1 = New CarWash_La_Lima.FacturaHistoricosDataSet1()
        Me.Facturas_HistoricosTableAdapter = New CarWash_La_Lima.FacturaHistoricosDataSet1TableAdapters.Facturas_HistoricosTableAdapter()
        Me.VistaFacturasHDataSet1 = New CarWash_La_Lima.VistaFacturasHDataSet1()
        Me.VistaFacturasHistoricosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaFacturasHistoricosTableAdapter1 = New CarWash_La_Lima.VistaFacturasHDataSet1TableAdapters.VistaFacturasHistoricosTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeFacturacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EncargadoServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgHistoricos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturasHistoricosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturasHistoricosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasHistoricosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaHistoricosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturasHDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaFacturasHistoricosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHistoricos
        '
        Me.dgHistoricos.AutoGenerateColumns = False
        Me.dgHistoricos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgHistoricos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgHistoricos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgHistoricos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgHistoricos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgHistoricos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgHistoricos.ColumnHeadersHeight = 30
        Me.dgHistoricos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FacturaIDDataGridViewTextBoxColumn, Me.FechaDeFacturacionDataGridViewTextBoxColumn, Me.NombreClienteDataGridViewTextBoxColumn, Me.DescripcionServicioDataGridViewTextBoxColumn, Me.PrecioServicioDataGridViewTextBoxColumn, Me.NumPlacaDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.EncargadoServicioDataGridViewTextBoxColumn, Me.FormaPagoDataGridViewTextBoxColumn, Me.ISVDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn})
        Me.dgHistoricos.DataSource = Me.VistaFacturasHistoricosBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgHistoricos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgHistoricos.EnableHeadersVisualStyles = False
        Me.dgHistoricos.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgHistoricos.Location = New System.Drawing.Point(27, 54)
        Me.dgHistoricos.Name = "dgHistoricos"
        Me.dgHistoricos.ReadOnly = True
        Me.dgHistoricos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgHistoricos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgHistoricos.Size = New System.Drawing.Size(821, 377)
        Me.dgHistoricos.TabIndex = 27
        '
        'VistaFacturasHistoricosBindingSource
        '
        Me.VistaFacturasHistoricosBindingSource.DataMember = "VistaFacturasHistoricos"
        Me.VistaFacturasHistoricosBindingSource.DataSource = Me.VistaFacturasHistoricosDataSet1
        '
        'VistaFacturasHistoricosDataSet1
        '
        Me.VistaFacturasHistoricosDataSet1.DataSetName = "VistaFacturasHistoricosDataSet1"
        Me.VistaFacturasHistoricosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaFacturasHistoricosTableAdapter
        '
        Me.VistaFacturasHistoricosTableAdapter.ClearBeforeFill = True
        '
        'FacturasHistoricosBindingSource
        '
        Me.FacturasHistoricosBindingSource.DataMember = "Facturas-Historicos"
        Me.FacturasHistoricosBindingSource.DataSource = Me.FacturaHistoricosDataSet1
        '
        'FacturaHistoricosDataSet1
        '
        Me.FacturaHistoricosDataSet1.DataSetName = "FacturaHistoricosDataSet1"
        Me.FacturaHistoricosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Facturas_HistoricosTableAdapter
        '
        Me.Facturas_HistoricosTableAdapter.ClearBeforeFill = True
        '
        'VistaFacturasHDataSet1
        '
        Me.VistaFacturasHDataSet1.DataSetName = "VistaFacturasHDataSet1"
        Me.VistaFacturasHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaFacturasHistoricosBindingSource1
        '
        Me.VistaFacturasHistoricosBindingSource1.DataMember = "VistaFacturasHistoricos"
        Me.VistaFacturasHistoricosBindingSource1.DataSource = Me.VistaFacturasHDataSet1
        '
        'VistaFacturasHistoricosTableAdapter1
        '
        Me.VistaFacturasHistoricosTableAdapter1.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaIDDataGridViewTextBoxColumn
        '
        Me.FacturaIDDataGridViewTextBoxColumn.DataPropertyName = "FacturaID"
        Me.FacturaIDDataGridViewTextBoxColumn.HeaderText = "FacturaID"
        Me.FacturaIDDataGridViewTextBoxColumn.Name = "FacturaIDDataGridViewTextBoxColumn"
        Me.FacturaIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDeFacturacionDataGridViewTextBoxColumn
        '
        Me.FechaDeFacturacionDataGridViewTextBoxColumn.DataPropertyName = "FechaDeFacturacion"
        Me.FechaDeFacturacionDataGridViewTextBoxColumn.HeaderText = "FechaDeFacturacion"
        Me.FechaDeFacturacionDataGridViewTextBoxColumn.Name = "FechaDeFacturacionDataGridViewTextBoxColumn"
        Me.FechaDeFacturacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        Me.NombreClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionServicioDataGridViewTextBoxColumn
        '
        Me.DescripcionServicioDataGridViewTextBoxColumn.DataPropertyName = "DescripcionServicio"
        Me.DescripcionServicioDataGridViewTextBoxColumn.HeaderText = "DescripcionServicio"
        Me.DescripcionServicioDataGridViewTextBoxColumn.Name = "DescripcionServicioDataGridViewTextBoxColumn"
        Me.DescripcionServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioServicioDataGridViewTextBoxColumn
        '
        Me.PrecioServicioDataGridViewTextBoxColumn.DataPropertyName = "PrecioServicio"
        Me.PrecioServicioDataGridViewTextBoxColumn.HeaderText = "PrecioServicio"
        Me.PrecioServicioDataGridViewTextBoxColumn.Name = "PrecioServicioDataGridViewTextBoxColumn"
        Me.PrecioServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumPlacaDataGridViewTextBoxColumn
        '
        Me.NumPlacaDataGridViewTextBoxColumn.DataPropertyName = "NumPlaca"
        Me.NumPlacaDataGridViewTextBoxColumn.HeaderText = "NumPlaca"
        Me.NumPlacaDataGridViewTextBoxColumn.Name = "NumPlacaDataGridViewTextBoxColumn"
        Me.NumPlacaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EncargadoServicioDataGridViewTextBoxColumn
        '
        Me.EncargadoServicioDataGridViewTextBoxColumn.DataPropertyName = "EncargadoServicio"
        Me.EncargadoServicioDataGridViewTextBoxColumn.HeaderText = "EncargadoServicio"
        Me.EncargadoServicioDataGridViewTextBoxColumn.Name = "EncargadoServicioDataGridViewTextBoxColumn"
        Me.EncargadoServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormaPagoDataGridViewTextBoxColumn
        '
        Me.FormaPagoDataGridViewTextBoxColumn.DataPropertyName = "FormaPago"
        Me.FormaPagoDataGridViewTextBoxColumn.HeaderText = "FormaPago"
        Me.FormaPagoDataGridViewTextBoxColumn.Name = "FormaPagoDataGridViewTextBoxColumn"
        Me.FormaPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISVDataGridViewTextBoxColumn
        '
        Me.ISVDataGridViewTextBoxColumn.DataPropertyName = "ISV"
        Me.ISVDataGridViewTextBoxColumn.HeaderText = "ISV"
        Me.ISVDataGridViewTextBoxColumn.Name = "ISVDataGridViewTextBoxColumn"
        Me.ISVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmHistorialFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 457)
        Me.Controls.Add(Me.dgHistoricos)
        Me.Name = "FrmHistorialFactura"
        Me.Text = "HISTORIAL DE LAVADOS"
        CType(Me.dgHistoricos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturasHistoricosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturasHistoricosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasHistoricosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaHistoricosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturasHDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaFacturasHistoricosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dgHistoricos As DataGridView
    Friend WithEvents FacturaHistoricosDataSet1 As FacturaHistoricosDataSet1
    Friend WithEvents FacturasHistoricosBindingSource As BindingSource
    Friend WithEvents Facturas_HistoricosTableAdapter As FacturaHistoricosDataSet1TableAdapters.Facturas_HistoricosTableAdapter
    Friend WithEvents VistaFacturasHistoricosDataSet1 As VistaFacturasHistoricosDataSet1
    Friend WithEvents VistaFacturasHistoricosBindingSource As BindingSource
    Friend WithEvents VistaFacturasHistoricosTableAdapter As VistaFacturasHistoricosDataSet1TableAdapters.VistaFacturasHistoricosTableAdapter
    Friend WithEvents VistaFacturasHDataSet1 As VistaFacturasHDataSet1
    Friend WithEvents VistaFacturasHistoricosBindingSource1 As BindingSource
    Friend WithEvents VistaFacturasHistoricosTableAdapter1 As VistaFacturasHDataSet1TableAdapters.VistaFacturasHistoricosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeFacturacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumPlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EncargadoServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
