<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicios
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgServicio = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.ServiciosVDataSet1 = New CarWash_La_Lima.ServiciosVDataSet1()
        Me.ServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioTableAdapter1 = New CarWash_La_Lima.ServiciosVDataSet1TableAdapters.ServicioTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(1143, 117)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(83, 25)
        Me.label11.TabIndex = 223
        Me.label11.Text = "DATOS"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(880, 175)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(31, 20)
        Me.label5.TabIndex = 222
        Me.label5.Text = "ID:"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(1063, 172)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(324, 26)
        Me.txtid.TabIndex = 221
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(880, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Servicio"
        '
        'txtServicio
        '
        Me.txtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicio.Location = New System.Drawing.Point(1063, 222)
        Me.txtServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(324, 26)
        Me.txtServicio.TabIndex = 217
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(72, 83)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(121, 25)
        Me.label1.TabIndex = 216
        Me.label1.Text = "SERVICIOS"
        '
        'dgServicio
        '
        Me.dgServicio.AutoGenerateColumns = False
        Me.dgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgServicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgServicio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgServicio.ColumnHeadersHeight = 30
        Me.dgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgServicio.DataSource = Me.ServicioBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgServicio.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgServicio.EnableHeadersVisualStyles = False
        Me.dgServicio.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgServicio.Location = New System.Drawing.Point(77, 132)
        Me.dgServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dgServicio.Name = "dgServicio"
        Me.dgServicio.ReadOnly = True
        Me.dgServicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgServicio.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgServicio.RowHeadersWidth = 51
        Me.dgServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgServicio.Size = New System.Drawing.Size(776, 464)
        Me.dgServicio.TabIndex = 214
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(880, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(1063, 279)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(324, 26)
        Me.txtPrecio.TabIndex = 224
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(941, 544)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 37)
        Me.btnGuardar.TabIndex = 219
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(1255, 544)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 37)
        Me.btnEliminar.TabIndex = 215
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(1101, 544)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(133, 37)
        Me.btnEditar.TabIndex = 220
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'ServiciosVDataSet1
        '
        Me.ServiciosVDataSet1.DataSetName = "ServiciosVDataSet1"
        Me.ServiciosVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicioBindingSource1
        '
        Me.ServicioBindingSource1.DataMember = "Servicio"
        Me.ServicioBindingSource1.DataSource = Me.ServiciosVDataSet1
        '
        'ServicioTableAdapter1
        '
        Me.ServicioTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ServicioID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ServicioID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DescripcionServicio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DescripcionServicio"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PrecioServicio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PrecioServicio"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'ServicioBindingSource
        '
        'Me.ServicioBindingSource.DataMember = "Servicio"
        '
        'FrmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1460, 678)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgServicio)
        Me.Name = "FrmServicios"
        Me.Text = "FrmServicios"
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Public WithEvents txtid As TextBox
    Private WithEvents Label6 As Label
    Public WithEvents txtServicio As TextBox
    Private WithEvents label1 As Label
    Private WithEvents dgServicio As DataGridView
    'Friend WithEvents CarWashLaLimaDataSet1 As CarWashLaLimaDataSet1
    'Friend WithEvents ServicioBindingSource As BindingSource
    'Friend WithEvents ServicioTableAdapter As CarWashLaLimaDataSet1TableAdapters.ServicioTableAdapter
    Friend WithEvents ServicioIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents Label2 As Label
    Public WithEvents txtPrecio As TextBox
    Public WithEvents btnGuardar As Button
    Public WithEvents btnEliminar As Button
    Public WithEvents btnEditar As Button
    Friend WithEvents ServiciosVDataSet1 As ServiciosVDataSet1
    Friend WithEvents ServicioBindingSource1 As BindingSource
    Friend WithEvents ServicioTableAdapter1 As ServiciosVDataSet1TableAdapters.ServicioTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
