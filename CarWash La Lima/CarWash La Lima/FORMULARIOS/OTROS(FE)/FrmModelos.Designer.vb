﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModelos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgModelos = New System.Windows.Forms.DataGridView()
        Me.ModeloIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaMarcaModeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaMarcaModeloDataSet1 = New CarWash_La_Lima.VistaMarcaModeloDataSet1()
        Me.ModeloVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelosVDataSet1 = New CarWash_La_Lima.ModelosVDataSet1()
        Me.cmbMarcaID = New System.Windows.Forms.ComboBox()
        Me.MarcasVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasDataSet1 = New CarWash_La_Lima.MarcasDataSet1()
        Me.MarcasVehiculosTableAdapter = New CarWash_La_Lima.MarcasDataSet1TableAdapters.MarcasVehiculosTableAdapter()
        Me.ModeloVehiculoTableAdapter = New CarWash_La_Lima.ModelosVDataSet1TableAdapters.ModeloVehiculoTableAdapter()
        Me.VistaMarcaModeloTableAdapter = New CarWash_La_Lima.VistaMarcaModeloDataSet1TableAdapters.VistaMarcaModeloTableAdapter()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        CType(Me.dgModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMarcaModeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMarcaModeloDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelosVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(1137, 179)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(83, 25)
        Me.label11.TabIndex = 203
        Me.label11.Text = "DATOS"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(875, 237)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(31, 20)
        Me.label5.TabIndex = 202
        Me.label5.Text = "ID:"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(1057, 234)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(324, 26)
        Me.txtid.TabIndex = 201
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(1089, 606)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(133, 37)
        Me.btnEditar.TabIndex = 200
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
        Me.btnGuardar.Location = New System.Drawing.Point(936, 606)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 37)
        Me.btnGuardar.TabIndex = 199
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(875, 400)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 20)
        Me.label4.TabIndex = 198
        Me.label4.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(875, 343)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 196
        Me.Label2.Text = "Modelo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(875, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Marca:"
        '
        'txtAnio
        '
        Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(1057, 396)
        Me.txtAnio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(324, 26)
        Me.txtAnio.TabIndex = 194
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(1057, 339)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.MaxLength = 50
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(324, 26)
        Me.txtModelo.TabIndex = 193
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(67, 145)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 25)
        Me.label1.TabIndex = 191
        Me.label1.Text = "MODELOS"
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
        Me.btnEliminar.Location = New System.Drawing.Point(1245, 606)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 37)
        Me.btnEliminar.TabIndex = 190
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgModelos
        '
        Me.dgModelos.AutoGenerateColumns = False
        Me.dgModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgModelos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgModelos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgModelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgModelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgModelos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgModelos.ColumnHeadersHeight = 30
        Me.dgModelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModeloIDDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.AnioModeloDataGridViewTextBoxColumn})
        Me.dgModelos.DataSource = Me.VistaMarcaModeloBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgModelos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgModelos.EnableHeadersVisualStyles = False
        Me.dgModelos.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgModelos.Location = New System.Drawing.Point(72, 194)
        Me.dgModelos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgModelos.MultiSelect = False
        Me.dgModelos.Name = "dgModelos"
        Me.dgModelos.ReadOnly = True
        Me.dgModelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgModelos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgModelos.RowHeadersWidth = 51
        Me.dgModelos.Size = New System.Drawing.Size(776, 464)
        Me.dgModelos.TabIndex = 189
        '
        'ModeloIDDataGridViewTextBoxColumn
        '
        Me.ModeloIDDataGridViewTextBoxColumn.DataPropertyName = "ModeloID"
        Me.ModeloIDDataGridViewTextBoxColumn.HeaderText = "ModeloID"
        Me.ModeloIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ModeloIDDataGridViewTextBoxColumn.Name = "ModeloIDDataGridViewTextBoxColumn"
        Me.ModeloIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnioModeloDataGridViewTextBoxColumn
        '
        Me.AnioModeloDataGridViewTextBoxColumn.DataPropertyName = "AnioModelo"
        Me.AnioModeloDataGridViewTextBoxColumn.HeaderText = "AnioModelo"
        Me.AnioModeloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AnioModeloDataGridViewTextBoxColumn.Name = "AnioModeloDataGridViewTextBoxColumn"
        Me.AnioModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VistaMarcaModeloBindingSource
        '
        Me.VistaMarcaModeloBindingSource.DataMember = "VistaMarcaModelo"
        Me.VistaMarcaModeloBindingSource.DataSource = Me.VistaMarcaModeloDataSet1
        '
        'VistaMarcaModeloDataSet1
        '
        Me.VistaMarcaModeloDataSet1.DataSetName = "VistaMarcaModeloDataSet1"
        Me.VistaMarcaModeloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModeloVehiculoBindingSource
        '
        Me.ModeloVehiculoBindingSource.DataMember = "ModeloVehiculo"
        Me.ModeloVehiculoBindingSource.DataSource = Me.ModelosVDataSet1
        '
        'ModelosVDataSet1
        '
        Me.ModelosVDataSet1.DataSetName = "ModelosVDataSet1"
        Me.ModelosVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbMarcaID
        '
        Me.cmbMarcaID.DataSource = Me.MarcasVehiculosBindingSource
        Me.cmbMarcaID.DisplayMember = "MarcaID"
        Me.cmbMarcaID.FormattingEnabled = True
        Me.cmbMarcaID.Location = New System.Drawing.Point(1057, 286)
        Me.cmbMarcaID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMarcaID.Name = "cmbMarcaID"
        Me.cmbMarcaID.Size = New System.Drawing.Size(64, 24)
        Me.cmbMarcaID.TabIndex = 204
        Me.cmbMarcaID.ValueMember = "MarcaID"
        '
        'MarcasVehiculosBindingSource
        '
        Me.MarcasVehiculosBindingSource.DataMember = "MarcasVehiculos"
        Me.MarcasVehiculosBindingSource.DataSource = Me.MarcasDataSet1
        '
        'MarcasDataSet1
        '
        Me.MarcasDataSet1.DataSetName = "MarcasDataSet1"
        Me.MarcasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcasVehiculosTableAdapter
        '
        Me.MarcasVehiculosTableAdapter.ClearBeforeFill = True
        '
        'ModeloVehiculoTableAdapter
        '
        Me.ModeloVehiculoTableAdapter.ClearBeforeFill = True
        '
        'VistaMarcaModeloTableAdapter
        '
        Me.VistaMarcaModeloTableAdapter.ClearBeforeFill = True
        '
        'cmbMarca
        '
        Me.cmbMarca.DataSource = Me.MarcasVehiculosBindingSource
        Me.cmbMarca.DisplayMember = "Marca"
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(1057, 286)
        Me.cmbMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(324, 24)
        Me.cmbMarca.TabIndex = 205
        '
        'FrmModelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1456, 724)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbMarcaID)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgModelos)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MODELOS"
        CType(Me.dgModelos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMarcaModeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMarcaModeloDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelosVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Public WithEvents txtid As TextBox
    Private WithEvents label4 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label6 As Label
    Public WithEvents txtAnio As TextBox
    Public WithEvents txtModelo As TextBox
    Private WithEvents label1 As Label
    Private WithEvents dgModelos As DataGridView
    Friend WithEvents cmbMarcaID As ComboBox
    Friend WithEvents MarcasDataSet1 As MarcasDataSet1
    Friend WithEvents MarcasVehiculosBindingSource As BindingSource
    Friend WithEvents MarcasVehiculosTableAdapter As MarcasDataSet1TableAdapters.MarcasVehiculosTableAdapter
    Friend WithEvents ModelosVDataSet1 As ModelosVDataSet1
    Friend WithEvents ModeloVehiculoBindingSource As BindingSource
    Friend WithEvents ModeloVehiculoTableAdapter As ModelosVDataSet1TableAdapters.ModeloVehiculoTableAdapter
    Friend WithEvents VistaMarcaModeloDataSet1 As VistaMarcaModeloDataSet1
    Friend WithEvents VistaMarcaModeloBindingSource As BindingSource
    Friend WithEvents VistaMarcaModeloTableAdapter As VistaMarcaModeloDataSet1TableAdapters.VistaMarcaModeloTableAdapter
    Friend WithEvents ModeloIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnioModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmbMarca As ComboBox
    Public WithEvents btnEditar As Button
    Public WithEvents btnGuardar As Button
    Public WithEvents btnEliminar As Button
End Class
