<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModelosNv
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
        Me.dgModelos = New System.Windows.Forms.DataGridView()
        Me.ModeloIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VistaMarcaModeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaMarcaModeloDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaMarcaModeloDataSet1 = New CarWash_La_Lima.VistaMarcaModeloDataSet1()
        Me.VistaMarcaModeloTableAdapter = New CarWash_La_Lima.VistaMarcaModeloDataSet1TableAdapters.VistaMarcaModeloTableAdapter()
        CType(Me.dgModelos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMarcaModeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMarcaModeloDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaMarcaModeloDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(84, 75)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 25)
        Me.label1.TabIndex = 193
        Me.label1.Text = "MODELOS"
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
        Me.dgModelos.Location = New System.Drawing.Point(89, 124)
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
        Me.dgModelos.TabIndex = 192
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
        Me.VistaMarcaModeloBindingSource.DataSource = Me.VistaMarcaModeloDataSet1BindingSource
        '
        'VistaMarcaModeloDataSet1BindingSource
        '
        Me.VistaMarcaModeloDataSet1BindingSource.DataSource = Me.VistaMarcaModeloDataSet1
        Me.VistaMarcaModeloDataSet1BindingSource.Position = 0
        '
        'VistaMarcaModeloDataSet1
        '
        Me.VistaMarcaModeloDataSet1.DataSetName = "VistaMarcaModeloDataSet1"
        Me.VistaMarcaModeloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaMarcaModeloTableAdapter
        '
        Me.VistaMarcaModeloTableAdapter.ClearBeforeFill = True
        '
        'FrmModelosNv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(911, 657)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dgModelos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModelosNv"
        Me.Text = "FrmModelosNv"
        CType(Me.dgModelos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMarcaModeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMarcaModeloDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaMarcaModeloDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents dgModelos As DataGridView
    Friend WithEvents VistaMarcaModeloDataSet1BindingSource As BindingSource
    Friend WithEvents VistaMarcaModeloDataSet1 As VistaMarcaModeloDataSet1
    Friend WithEvents VistaMarcaModeloBindingSource As BindingSource
    Friend WithEvents VistaMarcaModeloTableAdapter As VistaMarcaModeloDataSet1TableAdapters.VistaMarcaModeloTableAdapter
    Friend WithEvents ModeloIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnioModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
