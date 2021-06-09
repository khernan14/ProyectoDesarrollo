<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColores
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgColores = New System.Windows.Forms.DataGridView()
        Me.ColorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorVDataSet1 = New CarWash_La_Lima.ColorVDataSet1()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.ColorVehiculoTableAdapter = New CarWash_La_Lima.ColorVDataSet1TableAdapters.ColorVehiculoTableAdapter()
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(1121, 140)
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
        Me.label5.Location = New System.Drawing.Point(858, 198)
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
        Me.txtid.Location = New System.Drawing.Point(1041, 195)
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
        Me.btnEditar.Location = New System.Drawing.Point(1077, 567)
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
        Me.btnGuardar.Location = New System.Drawing.Point(919, 567)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 37)
        Me.btnGuardar.TabIndex = 199
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(858, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Descripcion:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(50, 106)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(110, 25)
        Me.label1.TabIndex = 191
        Me.label1.Text = "COLORES"
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
        Me.btnEliminar.Location = New System.Drawing.Point(1233, 567)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 37)
        Me.btnEliminar.TabIndex = 190
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgColores
        '
        Me.dgColores.AutoGenerateColumns = False
        Me.dgColores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgColores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgColores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgColores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgColores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgColores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgColores.ColumnHeadersHeight = 30
        Me.dgColores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColorIDDataGridViewTextBoxColumn, Me.DescripcionColorDataGridViewTextBoxColumn})
        Me.dgColores.DataSource = Me.ColorVehiculoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgColores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgColores.EnableHeadersVisualStyles = False
        Me.dgColores.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgColores.Location = New System.Drawing.Point(55, 155)
        Me.dgColores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgColores.Name = "dgColores"
        Me.dgColores.ReadOnly = True
        Me.dgColores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgColores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgColores.RowHeadersWidth = 51
        Me.dgColores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgColores.Size = New System.Drawing.Size(776, 464)
        Me.dgColores.TabIndex = 189
        '
        'ColorIDDataGridViewTextBoxColumn
        '
        Me.ColorIDDataGridViewTextBoxColumn.DataPropertyName = "ColorID"
        Me.ColorIDDataGridViewTextBoxColumn.HeaderText = "ColorID"
        Me.ColorIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColorIDDataGridViewTextBoxColumn.Name = "ColorIDDataGridViewTextBoxColumn"
        Me.ColorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionColorDataGridViewTextBoxColumn
        '
        Me.DescripcionColorDataGridViewTextBoxColumn.DataPropertyName = "DescripcionColor"
        Me.DescripcionColorDataGridViewTextBoxColumn.HeaderText = "DescripcionColor"
        Me.DescripcionColorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionColorDataGridViewTextBoxColumn.Name = "DescripcionColorDataGridViewTextBoxColumn"
        Me.DescripcionColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorVehiculoBindingSource
        '
        Me.ColorVehiculoBindingSource.DataMember = "ColorVehiculo"
        Me.ColorVehiculoBindingSource.DataSource = Me.ColorVDataSet1
        '
        'ColorVDataSet1
        '
        Me.ColorVDataSet1.DataSetName = "ColorVDataSet1"
        Me.ColorVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(1041, 245)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(324, 26)
        Me.txtDescripcion.TabIndex = 193
        '
        'ColorVehiculoTableAdapter
        '
        Me.ColorVehiculoTableAdapter.ClearBeforeFill = True
        '
        'FrmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1427, 691)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgColores)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmColores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "COLORES"
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Public WithEvents txtid As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents label1 As Label
    Private WithEvents dgColores As DataGridView
    Public WithEvents txtDescripcion As TextBox
    Friend WithEvents ColorVDataSet1 As ColorVDataSet1
    Friend WithEvents ColorVehiculoBindingSource As BindingSource
    Friend WithEvents ColorVehiculoTableAdapter As ColorVDataSet1TableAdapters.ColorVehiculoTableAdapter
    Friend WithEvents ColorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents btnEditar As Button
    Public WithEvents btnGuardar As Button
    Public WithEvents btnEliminar As Button
End Class
