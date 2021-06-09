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
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteDataSet1 = New CarWash_La_Lima.ClienteDataSet1()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlacaVDataSet1 = New CarWash_La_Lima.PlacaVDataSet1()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosDataSet1 = New CarWash_La_Lima.ServiciosDataSet1()
        Me.VistaNoRepeatDatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaEncargadosServicioDataSet11 = New CarWash_La_Lima.VistaEncargadosServicioDataSet1()
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cmbIDPago = New System.Windows.Forms.ComboBox()
        Me.cmbIDUser = New System.Windows.Forms.ComboBox()
        Me.cmbID = New System.Windows.Forms.ComboBox()
        Me.FacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDFacturaDataSet1 = New CarWash_La_Lima.IDFacturaDataSet1()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaEmpleadosPuestosDataSet1 = New CarWash_La_Lima.VistaEmpleadosPuestosDataSet1()
        Me.VistaEncargadosServicioDataSet1 = New CarWash_La_Lima.VistaEncargadosServicioDataSet1()
        Me.VistaNoRepeatDatosTableAdapter = New CarWash_La_Lima.VistaEncargadosServicioDataSet1TableAdapters.VistaNoRepeatDatosTableAdapter()
        Me.FacturaTableAdapter = New CarWash_La_Lima.IDFacturaDataSet1TableAdapters.FacturaTableAdapter()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtVehiculo = New System.Windows.Forms.TextBox()
        Me.txtIDServicio = New System.Windows.Forms.TextBox()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.txtPrecioServicio = New System.Windows.Forms.TextBox()
        Me.txtEncargadoServicio = New System.Windows.Forms.TextBox()
        Me.txtIDEncargado = New System.Windows.Forms.TextBox()
        Me.btnBuscarEncargado = New System.Windows.Forms.Button()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlacaVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaNoRepeatDatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEncargadosServicioDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncargadoServicioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPagoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioFacturaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFacturaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleadosPuestosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEncargadosServicioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.AutoSize = True
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTitleChildForm.Location = New System.Drawing.Point(47, 66)
        Me.lblTitleChildForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(105, 23)
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
        Me.btnCancelar.Location = New System.Drawing.Point(677, 481)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(133, 43)
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
        Me.btnFacturar.Location = New System.Drawing.Point(511, 481)
        Me.btnFacturar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(133, 43)
        Me.btnFacturar.TabIndex = 86
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(33, 144)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(195, 20)
        Me.label5.TabIndex = 128
        Me.label5.Text = "NUMERO DE FACTURA"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(33, 306)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 20)
        Me.label4.TabIndex = 126
        Me.label4.Text = "SERVICIO"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(33, 250)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 20)
        Me.label1.TabIndex = 124
        Me.label1.Text = "VEHICULO"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.label2.Location = New System.Drawing.Point(33, 194)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 20)
        Me.label2.TabIndex = 123
        Me.label2.Text = "CLIENTE"
        '
        'txtFactura
        '
        Me.txtFactura.Enabled = False
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(343, 140)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(324, 26)
        Me.txtFactura.TabIndex = 127
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
        'VistaNoRepeatDatosBindingSource
        '
        Me.VistaNoRepeatDatosBindingSource.DataMember = "VistaNoRepeatDatos"
        Me.VistaNoRepeatDatosBindingSource.DataSource = Me.VistaEncargadosServicioDataSet11
        '
        'VistaEncargadosServicioDataSet11
        '
        Me.VistaEncargadosServicioDataSet11.DataSetName = "VistaEncargadosServicioDataSet1"
        Me.VistaEncargadosServicioDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label6.Location = New System.Drawing.Point(33, 361)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 20)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "ENCARGADO DEL SERVICIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(837, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "FECHA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(837, 199)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "SUB TOTAL"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(1036, 198)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(324, 22)
        Me.txtSubTotal.TabIndex = 138
        '
        'txtISV
        '
        Me.txtISV.Enabled = False
        Me.txtISV.Location = New System.Drawing.Point(1036, 254)
        Me.txtISV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(324, 22)
        Me.txtISV.TabIndex = 140
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(837, 255)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "ISV"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DataSource = Me.UsuarioBindingSource1
        Me.cmbUsuario.DisplayMember = "Usuario"
        Me.cmbUsuario.Enabled = False
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(1036, 309)
        Me.cmbUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(324, 24)
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
        Me.Label10.Location = New System.Drawing.Point(837, 309)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "USUARIO"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(1036, 361)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(324, 22)
        Me.txtTotal.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(837, 362)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
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
        Me.DateTime2.Enabled = False
        Me.DateTime2.Location = New System.Drawing.Point(1036, 139)
        Me.DateTime2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTime2.MinDate = New Date(2021, 6, 24, 23, 59, 59, 0)
        Me.DateTime2.Name = "DateTime2"
        Me.DateTime2.Size = New System.Drawing.Size(324, 22)
        Me.DateTime2.TabIndex = 146
        Me.DateTime2.Value = New Date(2021, 6, 24, 23, 59, 59, 0)
        '
        'cmbPago
        '
        Me.cmbPago.DataSource = Me.PagoBindingSource
        Me.cmbPago.DisplayMember = "FormaPago"
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Location = New System.Drawing.Point(343, 412)
        Me.cmbPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(324, 24)
        Me.cmbPago.TabIndex = 148
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(33, 414)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 20)
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
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.White
        Me.btnCalcular.Location = New System.Drawing.Point(343, 481)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(133, 43)
        Me.btnCalcular.TabIndex = 150
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'cmbIDPago
        '
        Me.cmbIDPago.DataSource = Me.PagoBindingSource
        Me.cmbIDPago.DisplayMember = "PagoID"
        Me.cmbIDPago.FormattingEnabled = True
        Me.cmbIDPago.Location = New System.Drawing.Point(343, 412)
        Me.cmbIDPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbIDPago.Name = "cmbIDPago"
        Me.cmbIDPago.Size = New System.Drawing.Size(63, 24)
        Me.cmbIDPago.TabIndex = 154
        '
        'cmbIDUser
        '
        Me.cmbIDUser.DataSource = Me.UsuarioBindingSource1
        Me.cmbIDUser.DisplayMember = "UsuarioID"
        Me.cmbIDUser.Enabled = False
        Me.cmbIDUser.FormattingEnabled = True
        Me.cmbIDUser.Location = New System.Drawing.Point(1036, 309)
        Me.cmbIDUser.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbIDUser.Name = "cmbIDUser"
        Me.cmbIDUser.Size = New System.Drawing.Size(63, 24)
        Me.cmbIDUser.TabIndex = 155
        '
        'cmbID
        '
        Me.cmbID.DataSource = Me.FacturaBindingSource1
        Me.cmbID.DisplayMember = "FacturaID"
        Me.cmbID.FormattingEnabled = True
        Me.cmbID.Location = New System.Drawing.Point(1036, 409)
        Me.cmbID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbID.Name = "cmbID"
        Me.cmbID.Size = New System.Drawing.Size(63, 24)
        Me.cmbID.TabIndex = 156
        Me.cmbID.Visible = False
        '
        'FacturaBindingSource1
        '
        Me.FacturaBindingSource1.DataMember = "Factura"
        Me.FacturaBindingSource1.DataSource = Me.IDFacturaDataSet1
        '
        'IDFacturaDataSet1
        '
        Me.IDFacturaDataSet1.DataSetName = "IDFacturaDataSet1"
        Me.IDFacturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        '
        'VistaEmpleadosPuestosDataSet1
        '
        Me.VistaEmpleadosPuestosDataSet1.DataSetName = "VistaEmpleadosPuestosDataSet1"
        Me.VistaEmpleadosPuestosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaEncargadosServicioDataSet1
        '
        Me.VistaEncargadosServicioDataSet1.DataSetName = "VistaEncargadosServicioDataSet1"
        Me.VistaEncargadosServicioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaNoRepeatDatosTableAdapter
        '
        Me.VistaNoRepeatDatosTableAdapter.ClearBeforeFill = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(343, 193)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(324, 25)
        Me.txtCliente.TabIndex = 157
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCliente.Location = New System.Drawing.Point(677, 194)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(50, 24)
        Me.btnBuscarCliente.TabIndex = 158
        Me.btnBuscarCliente.Text = "•••"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(343, 193)
        Me.txtIDCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDCliente.Multiline = True
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(63, 25)
        Me.txtIDCliente.TabIndex = 159
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(677, 303)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 24)
        Me.Button1.TabIndex = 160
        Me.Button1.Text = "•••"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(343, 249)
        Me.txtVehiculo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVehiculo.MaxLength = 50
        Me.txtVehiculo.Multiline = True
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.ReadOnly = True
        Me.txtVehiculo.Size = New System.Drawing.Size(324, 25)
        Me.txtVehiculo.TabIndex = 161
        '
        'txtIDServicio
        '
        Me.txtIDServicio.Location = New System.Drawing.Point(343, 301)
        Me.txtIDServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDServicio.Multiline = True
        Me.txtIDServicio.Name = "txtIDServicio"
        Me.txtIDServicio.ReadOnly = True
        Me.txtIDServicio.Size = New System.Drawing.Size(63, 25)
        Me.txtIDServicio.TabIndex = 162
        '
        'txtServicio
        '
        Me.txtServicio.Location = New System.Drawing.Point(343, 301)
        Me.txtServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServicio.Multiline = True
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.ReadOnly = True
        Me.txtServicio.Size = New System.Drawing.Size(221, 25)
        Me.txtServicio.TabIndex = 163
        '
        'txtPrecioServicio
        '
        Me.txtPrecioServicio.Location = New System.Drawing.Point(572, 301)
        Me.txtPrecioServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioServicio.Multiline = True
        Me.txtPrecioServicio.Name = "txtPrecioServicio"
        Me.txtPrecioServicio.ReadOnly = True
        Me.txtPrecioServicio.Size = New System.Drawing.Size(97, 25)
        Me.txtPrecioServicio.TabIndex = 164
        '
        'txtEncargadoServicio
        '
        Me.txtEncargadoServicio.Location = New System.Drawing.Point(343, 356)
        Me.txtEncargadoServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEncargadoServicio.Multiline = True
        Me.txtEncargadoServicio.Name = "txtEncargadoServicio"
        Me.txtEncargadoServicio.ReadOnly = True
        Me.txtEncargadoServicio.Size = New System.Drawing.Size(326, 25)
        Me.txtEncargadoServicio.TabIndex = 166
        '
        'txtIDEncargado
        '
        Me.txtIDEncargado.Location = New System.Drawing.Point(343, 356)
        Me.txtIDEncargado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDEncargado.Multiline = True
        Me.txtIDEncargado.Name = "txtIDEncargado"
        Me.txtIDEncargado.ReadOnly = True
        Me.txtIDEncargado.Size = New System.Drawing.Size(63, 25)
        Me.txtIDEncargado.TabIndex = 165
        '
        'btnBuscarEncargado
        '
        Me.btnBuscarEncargado.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnBuscarEncargado.FlatAppearance.BorderSize = 0
        Me.btnBuscarEncargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEncargado.ForeColor = System.Drawing.Color.White
        Me.btnBuscarEncargado.Location = New System.Drawing.Point(677, 357)
        Me.btnBuscarEncargado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarEncargado.Name = "btnBuscarEncargado"
        Me.btnBuscarEncargado.Size = New System.Drawing.Size(50, 24)
        Me.btnBuscarEncargado.TabIndex = 167
        Me.btnBuscarEncargado.Text = "•••"
        Me.btnBuscarEncargado.UseVisualStyleBackColor = False
        '
        'FrmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1444, 566)
        Me.Controls.Add(Me.btnBuscarEncargado)
        Me.Controls.Add(Me.txtEncargadoServicio)
        Me.Controls.Add(Me.txtIDEncargado)
        Me.Controls.Add(Me.txtPrecioServicio)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.txtIDServicio)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cmbID)
        Me.Controls.Add(Me.btnCalcular)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.cmbIDUser)
        Me.Controls.Add(Me.cmbIDPago)
        Me.Controls.Add(Me.txtIDCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFacturar"
        Me.Text = "FACTURAR"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlacaVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaNoRepeatDatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEncargadosServicioDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncargadoServicioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPagoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioFacturaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFacturaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleadosPuestosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEncargadosServicioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents Label6 As Label
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
    Private WithEvents btnCalcular As Button
    Friend WithEvents cmbIDPago As ComboBox
    Friend WithEvents cmbIDUser As ComboBox
    Friend WithEvents cmbID As ComboBox
    'Friend WithEvents FacturaIDDataSet1 As FacturaIDDataSet1
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents VistaEmpleadosPuestosDataSet1 As VistaEmpleadosPuestosDataSet1
    Friend WithEvents VistaEncargadosServicioDataSet11 As VistaEncargadosServicioDataSet1
    Friend WithEvents VistaNoRepeatDatosBindingSource As BindingSource
    Friend WithEvents VistaNoRepeatDatosTableAdapter As VistaEncargadosServicioDataSet1TableAdapters.VistaNoRepeatDatosTableAdapter
    Friend WithEvents VistaEncargadosServicioDataSet1 As VistaEncargadosServicioDataSet1
    Friend WithEvents IDFacturaDataSet1 As IDFacturaDataSet1
    Friend WithEvents FacturaBindingSource1 As BindingSource
    Friend WithEvents FacturaTableAdapter As IDFacturaDataSet1TableAdapters.FacturaTableAdapter
    Private WithEvents btnBuscarCliente As Button
    Public WithEvents txtCliente As TextBox
    Public WithEvents txtIDCliente As TextBox
    Private WithEvents Button1 As Button
    Public WithEvents txtVehiculo As TextBox
    Public WithEvents txtIDServicio As TextBox
    Public WithEvents txtServicio As TextBox
    Public WithEvents txtPrecioServicio As TextBox
    Public WithEvents txtEncargadoServicio As TextBox
    Public WithEvents txtIDEncargado As TextBox
    Private WithEvents btnBuscarEncargado As Button
End Class
