<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturar
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
        Me.lblTitleChildForm = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteDataSet1 = New CarWash_La_Lima.ClienteDataSet1()
        Me.cmbVehiculo = New System.Windows.Forms.ComboBox()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlacaVDataSet1 = New CarWash_La_Lima.PlacaVDataSet1()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosDataSet1 = New CarWash_La_Lima.ServiciosDataSet1()
        Me.cmbEncargadoServicio = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncargadoServicioDataSet1 = New CarWash_La_Lima.EncargadoServicioDataSet1()
        Me.PagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaPagoDataSet1 = New CarWash_La_Lima.FormaPagoDataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.UsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioDataSet1 = New CarWash_La_Lima.UsuarioDataSet1()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioFacturaDataSet1 = New CarWash_La_Lima.UsuarioFacturaDataSet1()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New CarWash_La_Lima.ClienteDataSet1TableAdapters.ClientesTableAdapter()
        Me.VehiculoTableAdapter = New CarWash_La_Lima.PlacaVDataSet1TableAdapters.VehiculoTableAdapter()
        Me.ServicioTableAdapter = New CarWash_La_Lima.ServiciosDataSet1TableAdapters.ServicioTableAdapter()
        Me.PagoTableAdapter = New CarWash_La_Lima.FormaPagoDataSet1TableAdapters.PagoTableAdapter()
        Me.UsuarioTableAdapter = New CarWash_La_Lima.UsuarioFacturaDataSet1TableAdapters.UsuarioTableAdapter()
        Me.DateTime2 = New System.Windows.Forms.DateTimePicker()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmpleadoTableAdapter = New CarWash_La_Lima.EncargadoServicioDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.UsuarioTableAdapter1 = New CarWash_La_Lima.UsuarioDataSet1TableAdapters.UsuarioTableAdapter()
        Me.cmbPrecio = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cmbIDCliente = New System.Windows.Forms.ComboBox()
        Me.cmbIDServicio = New System.Windows.Forms.ComboBox()
        Me.cmbIDEncargado = New System.Windows.Forms.ComboBox()
        Me.cmbIDPago = New System.Windows.Forms.ComboBox()
        Me.cmbIDUser = New System.Windows.Forms.ComboBox()
        Me.cmbID = New System.Windows.Forms.ComboBox()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaIDDataSet1 = New CarWash_La_Lima.FacturaIDDataSet1()
        Me.FacturaTableAdapter = New CarWash_La_Lima.FacturaIDDataSet1TableAdapters.FacturaTableAdapter()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlacaVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncargadoServicioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPagoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioFacturaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaIDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.AutoSize = True
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTitleChildForm.Location = New System.Drawing.Point(35, 54)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(83, 18)
        Me.lblTitleChildForm.TabIndex = 1
        Me.lblTitleChildForm.Text = "FACTURAR"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(491, 391)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 87
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnFacturar
        '
        Me.btnFacturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnFacturar.FlatAppearance.BorderSize = 0
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.ForeColor = System.Drawing.Color.White
        Me.btnFacturar.Location = New System.Drawing.Point(367, 391)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(100, 35)
        Me.btnFacturar.TabIndex = 86
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(25, 117)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(160, 17)
        Me.label5.TabIndex = 128
        Me.label5.Text = "NUMERO DE FACTURA"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(25, 249)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 17)
        Me.label4.TabIndex = 126
        Me.label4.Text = "SERVICIO"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(25, 203)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 17)
        Me.label1.TabIndex = 124
        Me.label1.Text = "VEHICULO"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.label2.Location = New System.Drawing.Point(25, 158)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 17)
        Me.label2.TabIndex = 123
        Me.label2.Text = "CLIENTE"
        '
        'txtFactura
        '
        Me.txtFactura.Enabled = False
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(241, 114)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(244, 23)
        Me.txtFactura.TabIndex = 127
        '
        'cmbCliente
        '
        Me.cmbCliente.DataSource = Me.ClientesBindingSource
        Me.cmbCliente.DisplayMember = "NombreCliente"
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(295, 157)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(190, 21)
        Me.cmbCliente.TabIndex = 129
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ClienteDataSet1
        '
        'ClienteDataSet1
        '
        Me.ClienteDataSet1.DataSetName = "ClienteDataSet1"
        Me.ClienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbVehiculo
        '
        Me.cmbVehiculo.DataSource = Me.VehiculoBindingSource
        Me.cmbVehiculo.DisplayMember = "NumPlaca"
        Me.cmbVehiculo.FormattingEnabled = True
        Me.cmbVehiculo.Location = New System.Drawing.Point(241, 202)
        Me.cmbVehiculo.Name = "cmbVehiculo"
        Me.cmbVehiculo.Size = New System.Drawing.Size(244, 21)
        Me.cmbVehiculo.TabIndex = 130
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.PlacaVDataSet1
        '
        'PlacaVDataSet1
        '
        Me.PlacaVDataSet1.DataSetName = "PlacaVDataSet1"
        Me.PlacaVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbServicio
        '
        Me.cmbServicio.DataSource = Me.ServicioBindingSource
        Me.cmbServicio.DisplayMember = "DescripcionServicio"
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(295, 248)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(106, 21)
        Me.cmbServicio.TabIndex = 132
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "Servicio"
        Me.ServicioBindingSource.DataSource = Me.ServiciosDataSet1
        '
        'ServiciosDataSet1
        '
        Me.ServiciosDataSet1.DataSetName = "ServiciosDataSet1"
        Me.ServiciosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbEncargadoServicio
        '
        Me.cmbEncargadoServicio.DataSource = Me.EmpleadoBindingSource
        Me.cmbEncargadoServicio.DisplayMember = "NombreEmpleado"
        Me.cmbEncargadoServicio.FormattingEnabled = True
        Me.cmbEncargadoServicio.Location = New System.Drawing.Point(295, 292)
        Me.cmbEncargadoServicio.Name = "cmbEncargadoServicio"
        Me.cmbEncargadoServicio.Size = New System.Drawing.Size(190, 21)
        Me.cmbEncargadoServicio.TabIndex = 134
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.EncargadoServicioDataSet1
        '
        'EncargadoServicioDataSet1
        '
        Me.EncargadoServicioDataSet1.DataSetName = "EncargadoServicioDataSet1"
        Me.EncargadoServicioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagoBindingSource
        '
        Me.PagoBindingSource.DataMember = "Pago"
        Me.PagoBindingSource.DataSource = Me.FormaPagoDataSet1
        '
        'FormaPagoDataSet1
        '
        Me.FormaPagoDataSet1.DataSetName = "FormaPagoDataSet1"
        Me.FormaPagoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(25, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 17)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "ENCARGADO DEL SERVICIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(508, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "FECHA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(508, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "SUB TOTAL"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(657, 161)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(244, 20)
        Me.txtSubTotal.TabIndex = 138
        '
        'txtISV
        '
        Me.txtISV.Enabled = False
        Me.txtISV.Location = New System.Drawing.Point(657, 206)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(244, 20)
        Me.txtISV.TabIndex = 140
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(508, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "ISV"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DataSource = Me.UsuarioBindingSource1
        Me.cmbUsuario.DisplayMember = "Usuario"
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(711, 251)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(190, 21)
        Me.cmbUsuario.TabIndex = 143
        '
        'UsuarioBindingSource1
        '
        Me.UsuarioBindingSource1.DataMember = "Usuario"
        Me.UsuarioBindingSource1.DataSource = Me.UsuarioDataSet1
        '
        'UsuarioDataSet1
        '
        Me.UsuarioDataSet1.DataSetName = "UsuarioDataSet1"
        Me.UsuarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.UsuarioFacturaDataSet1
        '
        'UsuarioFacturaDataSet1
        '
        Me.UsuarioFacturaDataSet1.DataSetName = "UsuarioFacturaDataSet1"
        Me.UsuarioFacturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(508, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "USUARIO"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(657, 293)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(244, 20)
        Me.txtTotal.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(508, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "TOTAL"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'PagoTableAdapter
        '
        Me.PagoTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'DateTime2
        '
        Me.DateTime2.Location = New System.Drawing.Point(657, 113)
        Me.DateTime2.Name = "DateTime2"
        Me.DateTime2.Size = New System.Drawing.Size(244, 20)
        Me.DateTime2.TabIndex = 146
        '
        'cmbPago
        '
        Me.cmbPago.DataSource = Me.PagoBindingSource
        Me.cmbPago.DisplayMember = "FormaPago"
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Location = New System.Drawing.Point(295, 335)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(190, 21)
        Me.cmbPago.TabIndex = 148
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(25, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "FORMA DE PAGO"
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter1
        '
        Me.UsuarioTableAdapter1.ClearBeforeFill = True
        '
        'cmbPrecio
        '
        Me.cmbPrecio.DataSource = Me.ServicioBindingSource
        Me.cmbPrecio.DisplayMember = "PrecioServicio"
        Me.cmbPrecio.Enabled = False
        Me.cmbPrecio.FormattingEnabled = True
        Me.cmbPrecio.Location = New System.Drawing.Point(407, 248)
        Me.cmbPrecio.Name = "cmbPrecio"
        Me.cmbPrecio.Size = New System.Drawing.Size(78, 21)
        Me.cmbPrecio.TabIndex = 149
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.White
        Me.btnCalcular.Location = New System.Drawing.Point(241, 391)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 35)
        Me.btnCalcular.TabIndex = 150
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'cmbIDCliente
        '
        Me.cmbIDCliente.DataSource = Me.ClientesBindingSource
        Me.cmbIDCliente.DisplayMember = "ClienteID"
        Me.cmbIDCliente.Enabled = False
        Me.cmbIDCliente.FormattingEnabled = True
        Me.cmbIDCliente.Location = New System.Drawing.Point(241, 157)
        Me.cmbIDCliente.Name = "cmbIDCliente"
        Me.cmbIDCliente.Size = New System.Drawing.Size(48, 21)
        Me.cmbIDCliente.TabIndex = 151
        '
        'cmbIDServicio
        '
        Me.cmbIDServicio.DataSource = Me.ServicioBindingSource
        Me.cmbIDServicio.DisplayMember = "ServicioID"
        Me.cmbIDServicio.Enabled = False
        Me.cmbIDServicio.FormattingEnabled = True
        Me.cmbIDServicio.Location = New System.Drawing.Point(241, 248)
        Me.cmbIDServicio.Name = "cmbIDServicio"
        Me.cmbIDServicio.Size = New System.Drawing.Size(48, 21)
        Me.cmbIDServicio.TabIndex = 152
        '
        'cmbIDEncargado
        '
        Me.cmbIDEncargado.DataSource = Me.EmpleadoBindingSource
        Me.cmbIDEncargado.DisplayMember = "EmpleadoID"
        Me.cmbIDEncargado.Enabled = False
        Me.cmbIDEncargado.FormattingEnabled = True
        Me.cmbIDEncargado.Location = New System.Drawing.Point(241, 292)
        Me.cmbIDEncargado.Name = "cmbIDEncargado"
        Me.cmbIDEncargado.Size = New System.Drawing.Size(48, 21)
        Me.cmbIDEncargado.TabIndex = 153
        '
        'cmbIDPago
        '
        Me.cmbIDPago.DataSource = Me.PagoBindingSource
        Me.cmbIDPago.DisplayMember = "PagoID"
        Me.cmbIDPago.Enabled = False
        Me.cmbIDPago.FormattingEnabled = True
        Me.cmbIDPago.Location = New System.Drawing.Point(241, 335)
        Me.cmbIDPago.Name = "cmbIDPago"
        Me.cmbIDPago.Size = New System.Drawing.Size(48, 21)
        Me.cmbIDPago.TabIndex = 154
        '
        'cmbIDUser
        '
        Me.cmbIDUser.DataSource = Me.UsuarioBindingSource1
        Me.cmbIDUser.DisplayMember = "UsuarioID"
        Me.cmbIDUser.Enabled = False
        Me.cmbIDUser.FormattingEnabled = True
        Me.cmbIDUser.Location = New System.Drawing.Point(657, 251)
        Me.cmbIDUser.Name = "cmbIDUser"
        Me.cmbIDUser.Size = New System.Drawing.Size(48, 21)
        Me.cmbIDUser.TabIndex = 155
        '
        'cmbID
        '
        Me.cmbID.DataSource = Me.FacturaBindingSource
        Me.cmbID.DisplayMember = "FacturaID"
        Me.cmbID.FormattingEnabled = True
        Me.cmbID.Location = New System.Drawing.Point(657, 332)
        Me.cmbID.Name = "cmbID"
        Me.cmbID.Size = New System.Drawing.Size(48, 21)
        Me.cmbID.TabIndex = 156
        Me.cmbID.Visible = False
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.FacturaIDDataSet1
        '
        'FacturaIDDataSet1
        '
        Me.FacturaIDDataSet1.DataSetName = "FacturaIDDataSet1"
        Me.FacturaIDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'FrmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 457)
        Me.Controls.Add(Me.cmbID)
        Me.Controls.Add(Me.cmbIDUser)
        Me.Controls.Add(Me.cmbIDPago)
        Me.Controls.Add(Me.cmbIDEncargado)
        Me.Controls.Add(Me.cmbIDServicio)
        Me.Controls.Add(Me.cmbIDCliente)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cmbPrecio)
        Me.Controls.Add(Me.cmbPago)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTime2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTitleChildForm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtISV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbEncargadoServicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbServicio)
        Me.Controls.Add(Me.cmbVehiculo)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnFacturar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFacturar"
        Me.Text = "FACTURAR"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlacaVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncargadoServicioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPagoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioFacturaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaIDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnCancelar As Button
    Private WithEvents btnFacturar As Button
    Private WithEvents lblTitleChildForm As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Friend WithEvents cmbUsuario As ComboBox
    Private WithEvents Label10 As Label
    Friend WithEvents txtISV As TextBox
    Private WithEvents Label9 As Label
    Friend WithEvents txtSubTotal As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents cmbEncargadoServicio As ComboBox
    Private WithEvents Label6 As Label
    Friend WithEvents cmbServicio As ComboBox
    Friend WithEvents cmbVehiculo As ComboBox
    Friend WithEvents cmbCliente As ComboBox
    Public WithEvents txtFactura As TextBox
    Friend WithEvents txtTotal As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents ClienteDataSet1 As ClienteDataSet1
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ClienteDataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents PlacaVDataSet1 As PlacaVDataSet1
    Friend WithEvents VehiculoBindingSource As BindingSource
    Friend WithEvents VehiculoTableAdapter As PlacaVDataSet1TableAdapters.VehiculoTableAdapter
    Friend WithEvents ServiciosDataSet1 As ServiciosDataSet1
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As ServiciosDataSet1TableAdapters.ServicioTableAdapter
    Friend WithEvents FormaPagoDataSet1 As FormaPagoDataSet1
    Friend WithEvents PagoBindingSource As BindingSource
    Friend WithEvents PagoTableAdapter As FormaPagoDataSet1TableAdapters.PagoTableAdapter
    Friend WithEvents UsuarioFacturaDataSet1 As UsuarioFacturaDataSet1
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As UsuarioFacturaDataSet1TableAdapters.UsuarioTableAdapter
    Friend WithEvents DateTime2 As DateTimePicker
    Friend WithEvents cmbPago As ComboBox
    Private WithEvents Label11 As Label
    Friend WithEvents EncargadoServicioDataSet1 As EncargadoServicioDataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As EncargadoServicioDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents UsuarioDataSet1 As UsuarioDataSet1
    Friend WithEvents UsuarioBindingSource1 As BindingSource
    Friend WithEvents UsuarioTableAdapter1 As UsuarioDataSet1TableAdapters.UsuarioTableAdapter
    Friend WithEvents cmbPrecio As ComboBox
    Private WithEvents btnCalcular As Button
    Friend WithEvents cmbIDCliente As ComboBox
    Friend WithEvents cmbIDServicio As ComboBox
    Friend WithEvents cmbIDEncargado As ComboBox
    Friend WithEvents cmbIDPago As ComboBox
    Friend WithEvents cmbIDUser As ComboBox
    Friend WithEvents cmbID As ComboBox
    Friend WithEvents FacturaIDDataSet1 As FacturaIDDataSet1
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As FacturaIDDataSet1TableAdapters.FacturaTableAdapter
End Class
