﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UsuarioTableAdapter = New CarWash_La_Lima.UsuariosDataSet1TableAdapters.UsuarioTableAdapter()
        Me.cmbEmpleadoID = New System.Windows.Forms.ComboBox()
        Me.VistaNombreEmpleadoPuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaNombreCompletoEmpleadoDataSet1 = New CarWash_La_Lima.VistaNombreCompletoEmpleadoDataSet1()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosEUDataSet1 = New CarWash_La_Lima.EmpleadosEUDataSet1()
        Me.EmpleadoTableAdapter = New CarWash_La_Lima.EmpleadosEUDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.VistaUsuariosTableAdapter = New CarWash_La_Lima.VistaUsuariosDataSet1TableAdapters.VistaUsuariosTableAdapter()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.VistaNombreEmpleadoPuestoTableAdapter = New CarWash_La_Lima.VistaNombreCompletoEmpleadoDataSet1TableAdapters.VistaNombreEmpleadoPuestoTableAdapter()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.txtBus = New System.Windows.Forms.TextBox()
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
        Me.label1.Location = New System.Drawing.Point(27, 109)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 20)
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
        Me.btnEliminar.Location = New System.Drawing.Point(914, 484)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgUsuarios.ColumnHeadersHeight = 30
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuarioIDDataGridViewTextBoxColumn, Me.NombreEmpleadoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn})
        Me.dgUsuarios.DataSource = Me.VistaUsuariosBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgUsuarios.EnableHeadersVisualStyles = False
        Me.dgUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgUsuarios.Location = New System.Drawing.Point(31, 149)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(582, 377)
        Me.dgUsuarios.TabIndex = 26
        '
        'UsuarioIDDataGridViewTextBoxColumn
        '
        Me.UsuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID"
        Me.UsuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID"
        Me.UsuarioIDDataGridViewTextBoxColumn.Name = "UsuarioIDDataGridViewTextBoxColumn"
        Me.UsuarioIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreEmpleadoDataGridViewTextBoxColumn
        '
        Me.NombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.Name = "NombreEmpleadoDataGridViewTextBoxColumn"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion"
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
        Me.label11.Location = New System.Drawing.Point(830, 137)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(64, 20)
        Me.label11.TabIndex = 184
        Me.label11.Text = "DATOS"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(633, 184)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(25, 17)
        Me.label5.TabIndex = 183
        Me.label5.Text = "ID:"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(770, 181)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(244, 23)
        Me.txtid.TabIndex = 182
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(794, 484)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
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
        Me.btnGuardar.Location = New System.Drawing.Point(679, 484)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 30)
        Me.btnGuardar.TabIndex = 180
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(633, 316)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(85, 17)
        Me.label4.TabIndex = 179
        Me.label4.Text = "Contraseña:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.label3.Location = New System.Drawing.Point(633, 361)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 17)
        Me.label3.TabIndex = 178
        Me.label3.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(633, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(633, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Empleado:"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(770, 313)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(244, 23)
        Me.txtContrasenia.TabIndex = 175
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(770, 267)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(244, 23)
        Me.txtUsuario.TabIndex = 174
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(770, 355)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(244, 23)
        Me.txtEstado.TabIndex = 173
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(633, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 187
        Me.Label7.Text = "Fecha de Creacion:"
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'cmbEmpleadoID
        '
        Me.cmbEmpleadoID.DataSource = Me.VistaNombreEmpleadoPuestoBindingSource
        Me.cmbEmpleadoID.DisplayMember = "EmpleadoID"
        Me.cmbEmpleadoID.FormattingEnabled = True
        Me.cmbEmpleadoID.Location = New System.Drawing.Point(770, 224)
        Me.cmbEmpleadoID.Name = "cmbEmpleadoID"
        Me.cmbEmpleadoID.Size = New System.Drawing.Size(47, 21)
        Me.cmbEmpleadoID.TabIndex = 188
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
        Me.DateTime1.Location = New System.Drawing.Point(770, 409)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(244, 20)
        Me.DateTime1.TabIndex = 189
        '
        'VistaUsuariosTableAdapter
        '
        Me.VistaUsuariosTableAdapter.ClearBeforeFill = True
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DataSource = Me.VistaNombreEmpleadoPuestoBindingSource
        Me.cmbEmpleado.DisplayMember = "NombreCompleto"
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(770, 224)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(244, 21)
        Me.cmbEmpleado.TabIndex = 190
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
        Me.txtBuscar.Location = New System.Drawing.Point(296, 112)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(261, 13)
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
        Me.btnBuscar.Location = New System.Drawing.Point(567, 103)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(46, 34)
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
        Me.txtBus.Location = New System.Drawing.Point(287, 103)
        Me.txtBus.Multiline = True
        Me.txtBus.Name = "txtBus"
        Me.txtBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBus.Size = New System.Drawing.Size(280, 34)
        Me.txtBus.TabIndex = 191
        Me.txtBus.Visible = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1042, 551)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.cmbEmpleadoID)
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
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Public WithEvents txtEstado As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents UsuariosDataSet1 As UsuariosDataSet1
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As UsuariosDataSet1TableAdapters.UsuarioTableAdapter
    Friend WithEvents cmbEmpleadoID As ComboBox
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
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents VistaNombreCompletoEmpleadoDataSet1 As VistaNombreCompletoEmpleadoDataSet1
    Friend WithEvents VistaNombreEmpleadoPuestoBindingSource As BindingSource
    Friend WithEvents VistaNombreEmpleadoPuestoTableAdapter As VistaNombreCompletoEmpleadoDataSet1TableAdapters.VistaNombreEmpleadoPuestoTableAdapter
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBus As TextBox
End Class
