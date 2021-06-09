<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleadoUsuario
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
        Me.txtBus = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.VistaEmpleadosPuestoUsuario = New CarWash_La_Lima.VistaEmpleadosPuestoUsuario()
        Me.VistaEmpleadosPuestoUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaEmpleadosPuestoUsuarioTableAdapter = New CarWash_La_Lima.VistaEmpleadosPuestoUsuarioTableAdapters.VistaEmpleadosPuestoUsuarioTableAdapter()
        Me.EmpleadoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleadosPuestoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEmpleadosPuestoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.ForeColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(617, 101)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBuscar.Size = New System.Drawing.Size(348, 15)
        Me.txtBuscar.TabIndex = 35
        Me.txtBuscar.Visible = False
        '
        'txtBus
        '
        Me.txtBus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBus.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtBus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBus.Enabled = False
        Me.txtBus.ForeColor = System.Drawing.Color.White
        Me.txtBus.Location = New System.Drawing.Point(605, 90)
        Me.txtBus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBus.Multiline = True
        Me.txtBus.Name = "txtBus"
        Me.txtBus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBus.Size = New System.Drawing.Size(373, 42)
        Me.txtBus.TabIndex = 33
        Me.txtBus.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(141, 97)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(261, 25)
        Me.label1.TabIndex = 32
        Me.label1.Text = "LISTADO DE EMPLEADOS"
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
        Me.dgEmpleados.DataSource = Me.VistaEmpleadosPuestoUsuarioBindingSource
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
        Me.dgEmpleados.Location = New System.Drawing.Point(146, 147)
        Me.dgEmpleados.Margin = New System.Windows.Forms.Padding(4)
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
        Me.dgEmpleados.RowHeadersWidth = 51
        Me.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpleados.Size = New System.Drawing.Size(893, 464)
        Me.dgEmpleados.TabIndex = 31
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
        Me.btnBuscar.Location = New System.Drawing.Point(978, 90)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 42)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'VistaEmpleadosPuestoUsuario
        '
        Me.VistaEmpleadosPuestoUsuario.DataSetName = "VistaEmpleadosPuestoUsuario"
        Me.VistaEmpleadosPuestoUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaEmpleadosPuestoUsuarioBindingSource
        '
        Me.VistaEmpleadosPuestoUsuarioBindingSource.DataMember = "VistaEmpleadosPuestoUsuario"
        Me.VistaEmpleadosPuestoUsuarioBindingSource.DataSource = Me.VistaEmpleadosPuestoUsuario
        '
        'VistaEmpleadosPuestoUsuarioTableAdapter
        '
        Me.VistaEmpleadosPuestoUsuarioTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoIDDataGridViewTextBoxColumn
        '
        Me.EmpleadoIDDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoID"
        Me.EmpleadoIDDataGridViewTextBoxColumn.HeaderText = "EmpleadoID"
        Me.EmpleadoIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpleadoIDDataGridViewTextBoxColumn.Name = "EmpleadoIDDataGridViewTextBoxColumn"
        Me.EmpleadoIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreEmpleadoDataGridViewTextBoxColumn
        '
        Me.NombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreEmpleadoDataGridViewTextBoxColumn.Name = "NombreEmpleadoDataGridViewTextBoxColumn"
        Me.NombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoEmpleadoDataGridViewTextBoxColumn
        '
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoEmpleado"
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.HeaderText = "ApellidoEmpleado"
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.Name = "ApellidoEmpleadoDataGridViewTextBoxColumn"
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionPuestoDataGridViewTextBoxColumn
        '
        Me.DescripcionPuestoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionPuesto"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.HeaderText = "DescripcionPuesto"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionPuestoDataGridViewTextBoxColumn.Name = "DescripcionPuestoDataGridViewTextBoxColumn"
        Me.DescripcionPuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmEmpleadoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1180, 701)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmpleadoUsuario"
        Me.Text = "FrmEmpleadoUsuario"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleadosPuestoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEmpleadosPuestoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBus As TextBox
    Private WithEvents label1 As Label
    Private WithEvents dgEmpleados As DataGridView
    Friend WithEvents VistaEmpleadosPuestoUsuario As VistaEmpleadosPuestoUsuario
    Friend WithEvents VistaEmpleadosPuestoUsuarioBindingSource As BindingSource
    Friend WithEvents VistaEmpleadosPuestoUsuarioTableAdapter As VistaEmpleadosPuestoUsuarioTableAdapters.VistaEmpleadosPuestoUsuarioTableAdapter
    Friend WithEvents EmpleadoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
