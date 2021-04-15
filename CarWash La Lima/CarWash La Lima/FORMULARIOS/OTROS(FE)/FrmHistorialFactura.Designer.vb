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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasHistoricosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaHDataSet1 = New CarWash_La_Lima.FacturaHDataSet1()
        Me.Facturas_HistoricosTableAdapter = New CarWash_La_Lima.FacturaHDataSet1TableAdapters.Facturas_HistoricosTableAdapter()
        CType(Me.dgHistoricos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasHistoricosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaHDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHistoricos
        '
        Me.dgHistoricos.AllowUserToOrderColumns = True
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
        Me.dgHistoricos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FacturaIDDataGridViewTextBoxColumn, Me.FechaFacturaDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.ServicioDataGridViewTextBoxColumn, Me.PrecioServicioDataGridViewTextBoxColumn, Me.NumPlacaDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.EmpleadoDataGridViewTextBoxColumn, Me.FormaPagoDataGridViewTextBoxColumn, Me.ISVDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.TotalPagoDataGridViewTextBoxColumn})
        Me.dgHistoricos.DataSource = Me.FacturasHistoricosBindingSource
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
        Me.dgHistoricos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgHistoricos.Size = New System.Drawing.Size(821, 377)
        Me.dgHistoricos.TabIndex = 27
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
        'FechaFacturaDataGridViewTextBoxColumn
        '
        Me.FechaFacturaDataGridViewTextBoxColumn.DataPropertyName = "FechaFactura"
        Me.FechaFacturaDataGridViewTextBoxColumn.HeaderText = "FechaFactura"
        Me.FechaFacturaDataGridViewTextBoxColumn.Name = "FechaFacturaDataGridViewTextBoxColumn"
        Me.FechaFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServicioDataGridViewTextBoxColumn
        '
        Me.ServicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.Name = "ServicioDataGridViewTextBoxColumn"
        Me.ServicioDataGridViewTextBoxColumn.ReadOnly = True
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
        'EmpleadoDataGridViewTextBoxColumn
        '
        Me.EmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.HeaderText = "Empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.Name = "EmpleadoDataGridViewTextBoxColumn"
        Me.EmpleadoDataGridViewTextBoxColumn.ReadOnly = True
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
        'TotalPagoDataGridViewTextBoxColumn
        '
        Me.TotalPagoDataGridViewTextBoxColumn.DataPropertyName = "TotalPago"
        Me.TotalPagoDataGridViewTextBoxColumn.HeaderText = "TotalPago"
        Me.TotalPagoDataGridViewTextBoxColumn.Name = "TotalPagoDataGridViewTextBoxColumn"
        Me.TotalPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturasHistoricosBindingSource
        '
        Me.FacturasHistoricosBindingSource.DataMember = "Facturas-Historicos"
        Me.FacturasHistoricosBindingSource.DataSource = Me.FacturaHDataSet1
        '
        'FacturaHDataSet1
        '
        Me.FacturaHDataSet1.DataSetName = "FacturaHDataSet1"
        Me.FacturaHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Facturas_HistoricosTableAdapter
        '
        Me.Facturas_HistoricosTableAdapter.ClearBeforeFill = True
        '
        'FrmHistorialFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 457)
        Me.Controls.Add(Me.dgHistoricos)
        Me.Name = "FrmHistorialFactura"
        Me.Text = "HISTORIAL"
        CType(Me.dgHistoricos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasHistoricosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaHDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dgHistoricos As DataGridView
    Friend WithEvents FacturaHDataSet1 As FacturaHDataSet1
    Friend WithEvents FacturasHistoricosBindingSource As BindingSource
    Friend WithEvents Facturas_HistoricosTableAdapter As FacturaHDataSet1TableAdapters.Facturas_HistoricosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumPlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
