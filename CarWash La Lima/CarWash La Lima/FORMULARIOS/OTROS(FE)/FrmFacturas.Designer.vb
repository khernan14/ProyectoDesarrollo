﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturas
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
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDataSet1 = New CarWash_La_Lima.FacturaDataSet1()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleFacturaDataSet1 = New CarWash_La_Lima.DetalleFacturaDataSet1()
        Me.FacturaTableAdapter = New CarWash_La_Lima.FacturaDataSet1TableAdapters.FacturaTableAdapter()
        Me.DetalleFacturaTableAdapter = New CarWash_La_Lima.DetalleFacturaDataSet1TableAdapters.DetalleFacturaTableAdapter()
        Me.PagoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleFacturaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.UsuarioIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFactura = New System.Windows.Forms.DataGridView()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.FacturaDataSet1
        '
        'FacturaDataSet1
        '
        Me.FacturaDataSet1.DataSetName = "FacturaDataSet1"
        Me.FacturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "DetalleFactura"
        Me.DetalleFacturaBindingSource.DataSource = Me.DetalleFacturaDataSet1
        '
        'DetalleFacturaDataSet1
        '
        Me.DetalleFacturaDataSet1.DataSetName = "DetalleFacturaDataSet1"
        Me.DetalleFacturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'DetalleFacturaTableAdapter
        '
        Me.DetalleFacturaTableAdapter.ClearBeforeFill = True
        '
        'PagoIDDataGridViewTextBoxColumn
        '
        Me.PagoIDDataGridViewTextBoxColumn.DataPropertyName = "PagoID"
        Me.PagoIDDataGridViewTextBoxColumn.HeaderText = "PagoID"
        Me.PagoIDDataGridViewTextBoxColumn.Name = "PagoIDDataGridViewTextBoxColumn"
        '
        'ServicioIDDataGridViewTextBoxColumn
        '
        Me.ServicioIDDataGridViewTextBoxColumn.DataPropertyName = "ServicioID"
        Me.ServicioIDDataGridViewTextBoxColumn.HeaderText = "ServicioID"
        Me.ServicioIDDataGridViewTextBoxColumn.Name = "ServicioIDDataGridViewTextBoxColumn"
        '
        'ClienteIDDataGridViewTextBoxColumn
        '
        Me.ClienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID"
        Me.ClienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID"
        Me.ClienteIDDataGridViewTextBoxColumn.Name = "ClienteIDDataGridViewTextBoxColumn"
        '
        'DetalleFacturaIDDataGridViewTextBoxColumn
        '
        Me.DetalleFacturaIDDataGridViewTextBoxColumn.DataPropertyName = "DetalleFacturaID"
        Me.DetalleFacturaIDDataGridViewTextBoxColumn.HeaderText = "DetalleFacturaID"
        Me.DetalleFacturaIDDataGridViewTextBoxColumn.Name = "DetalleFacturaIDDataGridViewTextBoxColumn"
        Me.DetalleFacturaIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaIDDataGridViewTextBoxColumn1
        '
        Me.FacturaIDDataGridViewTextBoxColumn1.DataPropertyName = "FacturaID"
        Me.FacturaIDDataGridViewTextBoxColumn1.HeaderText = "FacturaID"
        Me.FacturaIDDataGridViewTextBoxColumn1.Name = "FacturaIDDataGridViewTextBoxColumn1"
        '
        'dgDetalleFactura
        '
        Me.dgDetalleFactura.AutoGenerateColumns = False
        Me.dgDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaIDDataGridViewTextBoxColumn1, Me.DetalleFacturaIDDataGridViewTextBoxColumn, Me.ClienteIDDataGridViewTextBoxColumn, Me.ServicioIDDataGridViewTextBoxColumn, Me.PagoIDDataGridViewTextBoxColumn})
        Me.dgDetalleFactura.DataSource = Me.DetalleFacturaBindingSource
        Me.dgDetalleFactura.Location = New System.Drawing.Point(12, 300)
        Me.dgDetalleFactura.Name = "dgDetalleFactura"
        Me.dgDetalleFactura.Size = New System.Drawing.Size(552, 179)
        Me.dgDetalleFactura.TabIndex = 1
        '
        'UsuarioIDDataGridViewTextBoxColumn
        '
        Me.UsuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID"
        Me.UsuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID"
        Me.UsuarioIDDataGridViewTextBoxColumn.Name = "UsuarioIDDataGridViewTextBoxColumn"
        '
        'ISVDataGridViewTextBoxColumn
        '
        Me.ISVDataGridViewTextBoxColumn.DataPropertyName = "ISV"
        Me.ISVDataGridViewTextBoxColumn.HeaderText = "ISV"
        Me.ISVDataGridViewTextBoxColumn.Name = "ISVDataGridViewTextBoxColumn"
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'FacturaIDDataGridViewTextBoxColumn
        '
        Me.FacturaIDDataGridViewTextBoxColumn.DataPropertyName = "FacturaID"
        Me.FacturaIDDataGridViewTextBoxColumn.HeaderText = "FacturaID"
        Me.FacturaIDDataGridViewTextBoxColumn.Name = "FacturaIDDataGridViewTextBoxColumn"
        Me.FacturaIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dgFactura
        '
        Me.dgFactura.AutoGenerateColumns = False
        Me.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaIDDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.ISVDataGridViewTextBoxColumn, Me.UsuarioIDDataGridViewTextBoxColumn})
        Me.dgFactura.DataSource = Me.FacturaBindingSource
        Me.dgFactura.Location = New System.Drawing.Point(12, 46)
        Me.dgFactura.Name = "dgFactura"
        Me.dgFactura.Size = New System.Drawing.Size(552, 179)
        Me.dgFactura.TabIndex = 0
        '
        'FrmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 506)
        Me.Controls.Add(Me.dgDetalleFactura)
        Me.Controls.Add(Me.dgFactura)
        Me.Name = "FrmFacturas"
        Me.Text = "FrmFacturas"
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FacturaDataSet1 As FacturaDataSet1
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As FacturaDataSet1TableAdapters.FacturaTableAdapter
    Friend WithEvents DetalleFacturaDataSet1 As DetalleFacturaDataSet1
    Friend WithEvents DetalleFacturaBindingSource As BindingSource
    Friend WithEvents DetalleFacturaTableAdapter As DetalleFacturaDataSet1TableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents PagoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicioIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleFacturaIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgDetalleFactura As DataGridView
    Friend WithEvents UsuarioIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgFactura As DataGridView
End Class
