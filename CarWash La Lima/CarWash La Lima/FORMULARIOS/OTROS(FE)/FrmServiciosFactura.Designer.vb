<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServiciosFactura
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
        Me.dgServicio = New System.Windows.Forms.DataGridView()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.ServiciosVDataSet1 = New CarWash_La_Lima.ServiciosVDataSet1()
        Me.ServiciosVDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioTableAdapter = New CarWash_La_Lima.ServiciosVDataSet1TableAdapters.ServicioTableAdapter()
        Me.ServicioIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosVDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(132, 101)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(121, 25)
        Me.label1.TabIndex = 218
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
        Me.dgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicioIDDataGridViewTextBoxColumn, Me.DescripcionServicioDataGridViewTextBoxColumn, Me.PrecioServicioDataGridViewTextBoxColumn})
        Me.dgServicio.DataSource = Me.ServicioBindingSource
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
        Me.dgServicio.Location = New System.Drawing.Point(137, 150)
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
        Me.dgServicio.TabIndex = 217
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(133, 126)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(398, 20)
        Me.lblMessage.TabIndex = 219
        Me.lblMessage.Text = "Doble click en una celda para seleccionar un cliente"
        Me.lblMessage.Visible = False
        '
        'ServiciosVDataSet1
        '
        Me.ServiciosVDataSet1.DataSetName = "ServiciosVDataSet1"
        Me.ServiciosVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosVDataSet1BindingSource
        '
        Me.ServiciosVDataSet1BindingSource.DataSource = Me.ServiciosVDataSet1
        Me.ServiciosVDataSet1BindingSource.Position = 0
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "Servicio"
        Me.ServicioBindingSource.DataSource = Me.ServiciosVDataSet1BindingSource
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'ServicioIDDataGridViewTextBoxColumn
        '
        Me.ServicioIDDataGridViewTextBoxColumn.DataPropertyName = "ServicioID"
        Me.ServicioIDDataGridViewTextBoxColumn.HeaderText = "ServicioID"
        Me.ServicioIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ServicioIDDataGridViewTextBoxColumn.Name = "ServicioIDDataGridViewTextBoxColumn"
        Me.ServicioIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionServicioDataGridViewTextBoxColumn
        '
        Me.DescripcionServicioDataGridViewTextBoxColumn.DataPropertyName = "DescripcionServicio"
        Me.DescripcionServicioDataGridViewTextBoxColumn.HeaderText = "DescripcionServicio"
        Me.DescripcionServicioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionServicioDataGridViewTextBoxColumn.Name = "DescripcionServicioDataGridViewTextBoxColumn"
        Me.DescripcionServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioServicioDataGridViewTextBoxColumn
        '
        Me.PrecioServicioDataGridViewTextBoxColumn.DataPropertyName = "PrecioServicio"
        Me.PrecioServicioDataGridViewTextBoxColumn.HeaderText = "PrecioServicio"
        Me.PrecioServicioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioServicioDataGridViewTextBoxColumn.Name = "PrecioServicioDataGridViewTextBoxColumn"
        Me.PrecioServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmServiciosFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1045, 714)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgServicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmServiciosFactura"
        Me.Text = "FrmServiciosFactura"
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosVDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents dgServicio As DataGridView
    Public WithEvents lblMessage As Label
    Friend WithEvents ServiciosVDataSet1BindingSource As BindingSource
    Friend WithEvents ServiciosVDataSet1 As ServiciosVDataSet1
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As ServiciosVDataSet1TableAdapters.ServicioTableAdapter
    Friend WithEvents ServicioIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
