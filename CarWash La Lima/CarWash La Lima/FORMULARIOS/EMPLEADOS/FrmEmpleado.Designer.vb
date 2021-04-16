<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaEmpleadosPuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaEmpleadosPuestosDataSet1 = New CarWash_La_Lima.VistaEmpleadosPuestosDataSet1()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosDataSet1 = New CarWash_La_Lima.EmpleadosDataSet1()
        Me.EmpleadosDataSet = New CarWash_La_Lima.EmpleadosDataSet()
        Me.EmpleadosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New CarWash_La_Lima.EmpleadosDataSet1TableAdapters.EmpleadoTableAdapter()
        Me.VistaEmpleadosPuestosTableAdapter = New CarWash_La_Lima.VistaEmpleadosPuestosDataSet1TableAdapters.VistaEmpleadosPuestosTableAdapter()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.txtBus = New System.Windows.Forms.TextBox()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleadosPuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleadosPuestosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(24, 93)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(209, 20)
        Me.label1.TabIndex = 25
        Me.label1.Text = "LISTADO DE EMPLEADOS"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Silver
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(738, 149)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 30)
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Silver
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(738, 221)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 23
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Silver
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(738, 185)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 22
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'dgEmpleados
        '
        Me.dgEmpleados.AutoGenerateColumns = False
        Me.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEmpleados.ColumnHeadersHeight = 30
        Me.dgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoIDDataGridViewTextBoxColumn, Me.NombreEmpleadoDataGridViewTextBoxColumn, Me.ApellidoEmpleadoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DescripcionPuestoDataGridViewTextBoxColumn})
        Me.dgEmpleados.DataSource = Me.VistaEmpleadosPuestosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgEmpleados.EnableHeadersVisualStyles = False
        Me.dgEmpleados.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgEmpleados.Location = New System.Drawing.Point(28, 133)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.ReadOnly = True
        Me.dgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpleados.Size = New System.Drawing.Size(670, 377)
        Me.dgEmpleados.TabIndex = 21
        '
        'EmpleadoIDDataGridViewTextBoxColumn
        '
        Me.EmpleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID"
        Me.EmpleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID"
        Me.EmpleadoIDDataGridViewTextBoxColumn.Name = "EmpleadoIDDataGridViewTextBoxColumn"
        Me.EmpleadoIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreEmpleadoDataGridViewTextBoxColumn
        '
        Me.NombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.Name = "NombreEmpleadoDataGridViewTextBoxColumn"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoEmpleadoDataGridViewTextBoxColumn
        '
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoEmpleado"
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.HeaderText = "ApellidoEmpleado"
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.Name = "ApellidoEmpleadoDataGridViewTextBoxColumn"
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionPuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPuestoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionPuesto"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.HeaderText = "DescripcionPuesto"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.Name = "DescripcionPuestoDataGridViewTextBoxColumn"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VistaEmpleadosPuestosBindingSource
        '
        Me.VistaEmpleadosPuestosBindingSource.DataMember = "VistaEmpleadosPuestos"
        Me.VistaEmpleadosPuestosBindingSource.DataSource = Me.VistaEmpleadosPuestosDataSet1
        '
        'VistaEmpleadosPuestosDataSet1
        '
        Me.VistaEmpleadosPuestosDataSet1.DataSetName = "VistaEmpleadosPuestosDataSet1"
        Me.VistaEmpleadosPuestosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.EmpleadosDataSet1
        '
        'EmpleadosDataSet1
        '
        Me.EmpleadosDataSet1.DataSetName = "EmpleadosDataSet1"
        Me.EmpleadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosDataSet
        '
        Me.EmpleadosDataSet.DataSetName = "EmpleadosDataSet"
        Me.EmpleadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosDataSetBindingSource
        '
        Me.EmpleadosDataSetBindingSource.DataSource = Me.EmpleadosDataSet
        Me.EmpleadosDataSetBindingSource.Position = 0
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'VistaEmpleadosPuestosTableAdapter
        '
        Me.VistaEmpleadosPuestosTableAdapter.ClearBeforeFill = True
        '
        'txtBuscar
        '
        Me.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(381, 96)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(261, 13)
        Me.txtBuscar.TabIndex = 30
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
        Me.btnBuscar.Location = New System.Drawing.Point(652, 87)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(46, 34)
        Me.btnBuscar.TabIndex = 29
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBus
        '
        Me.txtBus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBus.Enabled = False
        Me.txtBus.ForeColor = System.Drawing.Color.White
        Me.txtBus.Location = New System.Drawing.Point(372, 87)
        Me.txtBus.Multiline = True
        Me.txtBus.Name = "txtBus"
        Me.txtBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBus.Size = New System.Drawing.Size(280, 34)
        Me.txtBus.TabIndex = 28
        Me.txtBus.Visible = False
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 510)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.dgEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EMPLEADOS"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleadosPuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleadosPuestosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents dgEmpleados As DataGridView
    Friend WithEvents EmpleadosDataSet As EmpleadosDataSet
    Friend WithEvents EmpleadosDataSetBindingSource As BindingSource
    Friend WithEvents EmpleadosDataSet1 As EmpleadosDataSet1
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As EmpleadosDataSet1TableAdapters.EmpleadoTableAdapter
    Friend WithEvents VistaEmpleadosPuestosDataSet1 As VistaEmpleadosPuestosDataSet1
    Friend WithEvents VistaEmpleadosPuestosBindingSource As BindingSource
    Friend WithEvents VistaEmpleadosPuestosTableAdapter As VistaEmpleadosPuestosDataSet1TableAdapters.VistaEmpleadosPuestosTableAdapter
    Friend WithEvents EmpleadoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBus As TextBox
    Public WithEvents btnNuevo As Button
    Public WithEvents btnEliminar As Button
    Public WithEvents btnEditar As Button
End Class
