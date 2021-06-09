<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.UsuarioIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaUsuariosDataSet1 = New CarWash_La_Lima.VistaUsuariosDataSet1()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosDataSet1 = New CarWash_La_Lima.UsuariosDataSet1()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UsuarioTableAdapter = New CarWash_La_Lima.UsuariosDataSet1TableAdapters.UsuarioTableAdapter()
        Me.VistaNombreEmpleadoPuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaNombreCompletoEmpleadoDataSet1 = New CarWash_La_Lima.VistaNombreCompletoEmpleadoDataSet1()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosEUDataSet1 = New CarWash_La_Lima.EmpleadosEUDataSet1()
        Me.EmpleadoTableAdapter = New CarWash_La_Lima.EmpleadosEUDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.VistaUsuariosTableAdapter = New CarWash_La_Lima.VistaUsuariosDataSet1TableAdapters.VistaUsuariosTableAdapter()
        Me.VistaNombreEmpleadoPuestoTableAdapter = New CarWash_La_Lima.VistaNombreCompletoEmpleadoDataSet1TableAdapters.VistaNombreEmpleadoPuestoTableAdapter()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.txtBus = New System.Windows.Forms.TextBox()
        Me.txtEmpleadoID = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaUsuariosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaNombreEmpleadoPuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaNombreCompletoEmpleadoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosEUDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(36, 134)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(116, 25)
        Me.label1.TabIndex = 30
        Me.label1.Text = "USUARIOS"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Silver
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(1219, 596)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 37)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AutoGenerateColumns = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUsuarios.ColumnHeadersHeight = 30
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioIDDataGridViewTextBoxColumn, Me.NombreEmpleadoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn})
        Me.dgUsuarios.DataSource = Me.VistaUsuariosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgUsuarios.EnableHeadersVisualStyles = False
        Me.dgUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgUsuarios.Location = New System.Drawing.Point(41, 183)
        Me.dgUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgUsuarios.RowHeadersWidth = 51
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(776, 464)
        Me.dgUsuarios.TabIndex = 26
        '
        'UsuarioIDDataGridViewTextBoxColumn
        '
        Me.UsuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID"
        Me.UsuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID"
        Me.UsuarioIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsuarioIDDataGridViewTextBoxColumn.Name = "UsuarioIDDataGridViewTextBoxColumn"
        Me.UsuarioIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreEmpleadoDataGridViewTextBoxColumn
        '
        Me.NombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreEmpleadoDataGridViewTextBoxColumn.Name = "NombreEmpleadoDataGridViewTextBoxColumn"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaCreacionDataGridViewTextBoxColumn.Name = "FechaCreacionDataGridViewTextBoxColumn"
        Me.FechaCreacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VistaUsuariosBindingSource
        '
        Me.VistaUsuariosBindingSource.DataMember = "VistaUsuarios"
        Me.VistaUsuariosBindingSource.DataSource = Me.VistaUsuariosDataSet1
        '
        'VistaUsuariosDataSet1
        '
        Me.VistaUsuariosDataSet1.DataSetName = "VistaUsuariosDataSet1"
        Me.VistaUsuariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.UsuariosDataSet1
        '
        'UsuariosDataSet1
        '
        Me.UsuariosDataSet1.DataSetName = "UsuariosDataSet1"
        Me.UsuariosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(1107, 169)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(83, 25)
        Me.label11.TabIndex = 184
        Me.label11.Text = "DATOS"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(844, 226)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(31, 20)
        Me.label5.TabIndex = 183
        Me.label5.Text = "ID:"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(1027, 223)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(324, 26)
        Me.txtid.TabIndex = 182
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(1059, 596)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(133, 37)
        Me.btnEditar.TabIndex = 181
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(905, 596)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 37)
        Me.btnGuardar.TabIndex = 180
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(844, 389)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 20)
        Me.label4.TabIndex = 179
        Me.label4.Text = "Contraseña:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.label3.Location = New System.Drawing.Point(844, 444)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 20)
        Me.label3.TabIndex = 178
        Me.label3.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(844, 332)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(844, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Empleado:"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(1027, 385)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasenia.MaxLength = 50
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(324, 26)
        Me.txtContrasenia.TabIndex = 175
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(1027, 329)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(324, 26)
        Me.txtUsuario.TabIndex = 174
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(844, 503)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 20)
        Me.Label7.TabIndex = 187
        Me.Label7.Text = "Fecha de Creacion:"
        Me.Label7.Visible = False
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'VistaNombreEmpleadoPuestoBindingSource
        '
        Me.VistaNombreEmpleadoPuestoBindingSource.DataMember = "VistaNombreEmpleadoPuesto"
        Me.VistaNombreEmpleadoPuestoBindingSource.DataSource = Me.VistaNombreCompletoEmpleadoDataSet1
        '
        'VistaNombreCompletoEmpleadoDataSet1
        '
        Me.VistaNombreCompletoEmpleadoDataSet1.DataSetName = "VistaNombreCompletoEmpleadoDataSet1"
        Me.VistaNombreCompletoEmpleadoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.EmpleadosEUDataSet1
        '
        'EmpleadosEUDataSet1
        '
        Me.EmpleadosEUDataSet1.DataSetName = "EmpleadosEUDataSet1"
        Me.EmpleadosEUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'DateTime1
        '
        Me.DateTime1.Enabled = False
        Me.DateTime1.Location = New System.Drawing.Point(1027, 503)
        Me.DateTime1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(324, 22)
        Me.DateTime1.TabIndex = 189
        Me.DateTime1.Visible = False
        '
        'VistaUsuariosTableAdapter
        '
        Me.VistaUsuariosTableAdapter.ClearBeforeFill = True
        '
        'VistaNombreEmpleadoPuestoTableAdapter
        '
        Me.VistaNombreEmpleadoPuestoTableAdapter.ClearBeforeFill = True
        '
        'txtBuscar
        '
        Me.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(395, 138)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(348, 15)
        Me.txtBuscar.TabIndex = 193
        Me.txtBuscar.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscar.IconColor = System.Drawing.Color.DimGray
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscar.IconSize = 20
        Me.btnBuscar.Location = New System.Drawing.Point(756, 127)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 42)
        Me.btnBuscar.TabIndex = 192
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBus
        '
        Me.txtBus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBus.Enabled = False
        Me.txtBus.ForeColor = System.Drawing.Color.White
        Me.txtBus.Location = New System.Drawing.Point(383, 127)
        Me.txtBus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBus.Multiline = True
        Me.txtBus.Name = "txtBus"
        Me.txtBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBus.Size = New System.Drawing.Size(373, 42)
        Me.txtBus.TabIndex = 191
        Me.txtBus.Visible = False
        '
        'txtEmpleadoID
        '
        Me.txtEmpleadoID.Enabled = False
        Me.txtEmpleadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleadoID.Location = New System.Drawing.Point(1027, 277)
        Me.txtEmpleadoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpleadoID.Name = "txtEmpleadoID"
        Me.txtEmpleadoID.ReadOnly = True
        Me.txtEmpleadoID.Size = New System.Drawing.Size(54, 26)
        Me.txtEmpleadoID.TabIndex = 194
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleado.Location = New System.Drawing.Point(1027, 277)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(324, 26)
        Me.txtEmpleado.TabIndex = 195
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(1027, 444)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(325, 24)
        Me.cmbEstado.TabIndex = 196
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnBuscarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(1359, 277)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(50, 26)
        Me.btnBuscarEmpleado.TabIndex = 197
        Me.btnBuscarEmpleado.Text = "•••"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1442, 678)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.txtEmpleadoID)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "USUARIOS"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaUsuariosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaNombreEmpleadoPuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaNombreCompletoEmpleadoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosEUDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnEliminar As Button
    Private WithEvents dgUsuarios As DataGridView
    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Public WithEvents txtid As TextBox
    Private WithEvents btnEditar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label6 As Label
    Public WithEvents txtContrasenia As TextBox
    Public WithEvents txtUsuario As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents UsuariosDataSet1 As UsuariosDataSet1
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As UsuariosDataSet1TableAdapters.UsuarioTableAdapter
    Friend WithEvents EmpleadosEUDataSet1 As EmpleadosEUDataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As EmpleadosEUDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents DateTime1 As DateTimePicker
    Friend WithEvents VistaUsuariosDataSet1 As VistaUsuariosDataSet1
    Friend WithEvents VistaUsuariosBindingSource As BindingSource
    Friend WithEvents VistaUsuariosTableAdapter As VistaUsuariosDataSet1TableAdapters.VistaUsuariosTableAdapter
    Friend WithEvents UsuarioIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VistaNombreCompletoEmpleadoDataSet1 As VistaNombreCompletoEmpleadoDataSet1
    Friend WithEvents VistaNombreEmpleadoPuestoBindingSource As BindingSource
    Friend WithEvents VistaNombreEmpleadoPuestoTableAdapter As VistaNombreCompletoEmpleadoDataSet1TableAdapters.VistaNombreEmpleadoPuestoTableAdapter
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBus As TextBox
    Public WithEvents txtEmpleadoID As TextBox
    Public WithEvents txtEmpleado As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Private WithEvents btnBuscarEmpleado As Button
End Class
