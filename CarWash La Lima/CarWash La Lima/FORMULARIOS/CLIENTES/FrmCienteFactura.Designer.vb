<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCienteFactura
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtBus = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.ClienteIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet = New CarWash_La_Lima.ClientesDataSet()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.ClientesTableAdapter = New CarWash_La_Lima.ClientesDataSetTableAdapters.ClientesTableAdapter()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(588, 114)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(348, 15)
        Me.txtBuscar.TabIndex = 31
        Me.txtBuscar.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(133, 127)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(398, 20)
        Me.lblMessage.TabIndex = 30
        Me.lblMessage.Text = "Doble click en una celda para seleccionar un cliente"
        Me.lblMessage.Visible = False
        '
        'txtBus
        '
        Me.txtBus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBus.Enabled = False
        Me.txtBus.ForeColor = System.Drawing.Color.White
        Me.txtBus.Location = New System.Drawing.Point(576, 103)
        Me.txtBus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBus.Multiline = True
        Me.txtBus.Name = "txtBus"
        Me.txtBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBus.Size = New System.Drawing.Size(373, 42)
        Me.txtBus.TabIndex = 28
        Me.txtBus.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(133, 103)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(234, 25)
        Me.label1.TabIndex = 27
        Me.label1.Text = "LISTADO DE CLIENTES"
        '
        'dgClientes
        '
        Me.dgClientes.AutoGenerateColumns = False
        Me.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgClientes.ColumnHeadersHeight = 30
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteIDDataGridViewTextBoxColumn, Me.NumPlacaDataGridViewTextBoxColumn, Me.NombreClienteDataGridViewTextBoxColumn, Me.ApellidoClienteDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.dgClientes.DataSource = Me.ClientesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgClientes.EnableHeadersVisualStyles = False
        Me.dgClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dgClientes.Location = New System.Drawing.Point(117, 156)
        Me.dgClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgClientes.RowHeadersWidth = 51
        Me.dgClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgClientes.Size = New System.Drawing.Size(893, 464)
        Me.dgClientes.TabIndex = 26
        '
        'ClienteIDDataGridViewTextBoxColumn
        '
        Me.ClienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID"
        Me.ClienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID"
        Me.ClienteIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClienteIDDataGridViewTextBoxColumn.Name = "ClienteIDDataGridViewTextBoxColumn"
        Me.ClienteIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumPlacaDataGridViewTextBoxColumn
        '
        Me.NumPlacaDataGridViewTextBoxColumn.DataPropertyName = "NumPlaca"
        Me.NumPlacaDataGridViewTextBoxColumn.HeaderText = "NumPlaca"
        Me.NumPlacaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumPlacaDataGridViewTextBoxColumn.Name = "NumPlacaDataGridViewTextBoxColumn"
        Me.NumPlacaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente"
        Me.NombreClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        Me.NombreClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoClienteDataGridViewTextBoxColumn
        '
        Me.ApellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "ApellidoCliente"
        Me.ApellidoClienteDataGridViewTextBoxColumn.HeaderText = "ApellidoCliente"
        Me.ApellidoClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoClienteDataGridViewTextBoxColumn.Name = "ApellidoClienteDataGridViewTextBoxColumn"
        Me.ApellidoClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ClientesDataSetBindingSource
        '
        'ClientesDataSetBindingSource
        '
        Me.ClientesDataSetBindingSource.DataSource = Me.ClientesDataSet
        Me.ClientesDataSetBindingSource.Position = 0
        '
        'ClientesDataSet
        '
        Me.ClientesDataSet.DataSetName = "ClientesDataSet"
        Me.ClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnBuscar.Location = New System.Drawing.Point(949, 103)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 42)
        Me.btnBuscar.TabIndex = 29
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FrmCienteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1127, 723)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCienteFactura"
        Me.Text = "FrmEmpleadoFactura"
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Public WithEvents lblMessage As Label
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBus As TextBox
    Private WithEvents label1 As Label
    Private WithEvents dgClientes As DataGridView
    Friend WithEvents ClientesDataSetBindingSource As BindingSource
    Friend WithEvents ClientesDataSet As ClientesDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ClientesDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClienteIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumPlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
