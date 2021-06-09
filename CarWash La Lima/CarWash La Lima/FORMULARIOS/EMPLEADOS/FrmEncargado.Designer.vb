<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEncargado
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
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaNoRepeatDatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaEncargadosServicioDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaEncargadosServicioDataSet1 = New CarWash_La_Lima.VistaEncargadosServicioDataSet1()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.VistaNoRepeatDatosTableAdapter = New CarWash_La_Lima.VistaEncargadosServicioDataSet1TableAdapters.VistaNoRepeatDatosTableAdapter()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaNoRepeatDatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEncargadosServicioDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEncargadosServicioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoIDDataGridViewTextBoxColumn, Me.NombreEmpleadoDataGridViewTextBoxColumn, Me.ApellidoEmpleadoDataGridViewTextBoxColumn})
        Me.dgEmpleados.DataSource = Me.VistaNoRepeatDatosBindingSource
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
        Me.dgEmpleados.Location = New System.Drawing.Point(93, 130)
        Me.dgEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEmpleados.MultiSelect = False
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
        Me.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgEmpleados.Size = New System.Drawing.Size(893, 464)
        Me.dgEmpleados.TabIndex = 22
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
        'VistaNoRepeatDatosBindingSource
        '
        Me.VistaNoRepeatDatosBindingSource.DataMember = "VistaNoRepeatDatos"
        Me.VistaNoRepeatDatosBindingSource.DataSource = Me.VistaEncargadosServicioDataSet1BindingSource
        '
        'VistaEncargadosServicioDataSet1BindingSource
        '
        Me.VistaEncargadosServicioDataSet1BindingSource.DataSource = Me.VistaEncargadosServicioDataSet1
        Me.VistaEncargadosServicioDataSet1BindingSource.Position = 0
        '
        'VistaEncargadosServicioDataSet1
        '
        Me.VistaEncargadosServicioDataSet1.DataSetName = "VistaEncargadosServicioDataSet1"
        Me.VistaEncargadosServicioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(88, 84)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(300, 25)
        Me.label1.TabIndex = 26
        Me.label1.Text = "ENCARGADOS DE SERVICIOS"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(89, 109)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(398, 20)
        Me.lblMessage.TabIndex = 220
        Me.lblMessage.Text = "Doble click en una celda para seleccionar un cliente"
        Me.lblMessage.Visible = False
        '
        'VistaNoRepeatDatosTableAdapter
        '
        Me.VistaNoRepeatDatosTableAdapter.ClearBeforeFill = True
        '
        'FrmEncargado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 654)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEncargado"
        Me.Text = "FrmEncargado"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaNoRepeatDatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEncargadosServicioDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEncargadosServicioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dgEmpleados As DataGridView
    Private WithEvents label1 As Label
    Public WithEvents lblMessage As Label
    Friend WithEvents VistaEncargadosServicioDataSet1BindingSource As BindingSource
    Friend WithEvents VistaEncargadosServicioDataSet1 As VistaEncargadosServicioDataSet1
    Friend WithEvents VistaNoRepeatDatosBindingSource As BindingSource
    Friend WithEvents VistaNoRepeatDatosTableAdapter As VistaEncargadosServicioDataSet1TableAdapters.VistaNoRepeatDatosTableAdapter
    Friend WithEvents EmpleadoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
