<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoVehiculo
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
        Me.pnlTituleBar = New System.Windows.Forms.Panel()
        Me.lblTitleChildForm = New System.Windows.Forms.Label()
        Me.iconCurrentChildForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmbTipoVID = New System.Windows.Forms.ComboBox()
        Me.TipoVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoVehiculoDataSet1 = New CarWash_La_Lima.TipoVehiculoDataSet1()
        Me.cmbColorID = New System.Windows.Forms.ComboBox()
        Me.ColorVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorDataSet1 = New CarWash_La_Lima.ColorDataSet1()
        Me.cmbModeloID = New System.Windows.Forms.ComboBox()
        Me.ModeloVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModeloDataSet1 = New CarWash_La_Lima.ModeloDataSet1()
        Me.ModeloEnCNVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaModelo1 = New CarWash_La_Lima.VistaModelo1()
        Me.cmbMarcaID = New System.Windows.Forms.ComboBox()
        Me.MarcasVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcaDataSet1 = New CarWash_La_Lima.MarcaDataSet1()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.ModeloVehiculoTableAdapter = New CarWash_La_Lima.ModeloDataSet1TableAdapters.ModeloVehiculoTableAdapter()
        Me.MarcasVehiculosTableAdapter = New CarWash_La_Lima.MarcaDataSet1TableAdapters.MarcasVehiculosTableAdapter()
        Me.ColorVehiculoTableAdapter = New CarWash_La_Lima.ColorDataSet1TableAdapters.ColorVehiculoTableAdapter()
        Me.TipoVehiculoTableAdapter = New CarWash_La_Lima.TipoVehiculoDataSet1TableAdapters.TipoVehiculoTableAdapter()
        Me.ModeloEnCNVTableAdapter = New CarWash_La_Lima.VistaModelo1TableAdapters.ModeloEnCNVTableAdapter()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.cmbTipoV = New System.Windows.Forms.ComboBox()
        Me.pnlTituleBar.SuspendLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVehiculoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloEnCNVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaModelo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTituleBar
        '
        Me.pnlTituleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlTituleBar.Controls.Add(Me.lblTitleChildForm)
        Me.pnlTituleBar.Controls.Add(Me.iconCurrentChildForm)
        Me.pnlTituleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTituleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituleBar.Name = "pnlTituleBar"
        Me.pnlTituleBar.Size = New System.Drawing.Size(870, 51)
        Me.pnlTituleBar.TabIndex = 143
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.AutoSize = True
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTitleChildForm.Location = New System.Drawing.Point(74, 25)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(140, 18)
        Me.lblTitleChildForm.TabIndex = 1
        Me.lblTitleChildForm.Text = "NUEVO VEHICULO"
        '
        'iconCurrentChildForm
        '
        Me.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.CarSide
        Me.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconCurrentChildForm.Location = New System.Drawing.Point(36, 19)
        Me.iconCurrentChildForm.Name = "iconCurrentChildForm"
        Me.iconCurrentChildForm.Size = New System.Drawing.Size(32, 32)
        Me.iconCurrentChildForm.TabIndex = 0
        Me.iconCurrentChildForm.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(319, 399)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.btnGuardar.TabIndex = 138
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(447, 399)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 139
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'cmbTipoVID
        '
        Me.cmbTipoVID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TipoVehiculoBindingSource, "TipoVehiculoID", True))
        Me.cmbTipoVID.DataSource = Me.TipoVehiculoBindingSource
        Me.cmbTipoVID.DisplayMember = "TipoVehiculoID"
        Me.cmbTipoVID.FormattingEnabled = True
        Me.cmbTipoVID.Location = New System.Drawing.Point(585, 242)
        Me.cmbTipoVID.Name = "cmbTipoVID"
        Me.cmbTipoVID.Size = New System.Drawing.Size(50, 21)
        Me.cmbTipoVID.TabIndex = 158
        Me.cmbTipoVID.ValueMember = "TipoVehiculoID"
        '
        'TipoVehiculoBindingSource
        '
        Me.TipoVehiculoBindingSource.DataMember = "TipoVehiculo"
        Me.TipoVehiculoBindingSource.DataSource = Me.TipoVehiculoDataSet1
        '
        'TipoVehiculoDataSet1
        '
        Me.TipoVehiculoDataSet1.DataSetName = "TipoVehiculoDataSet1"
        Me.TipoVehiculoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbColorID
        '
        Me.cmbColorID.DataSource = Me.ColorVehiculoBindingSource
        Me.cmbColorID.DisplayMember = "ColorID"
        Me.cmbColorID.FormattingEnabled = True
        Me.cmbColorID.Location = New System.Drawing.Point(585, 201)
        Me.cmbColorID.Name = "cmbColorID"
        Me.cmbColorID.Size = New System.Drawing.Size(50, 21)
        Me.cmbColorID.TabIndex = 157
        Me.cmbColorID.ValueMember = "ColorID"
        '
        'ColorVehiculoBindingSource
        '
        Me.ColorVehiculoBindingSource.DataMember = "ColorVehiculo"
        Me.ColorVehiculoBindingSource.DataSource = Me.ColorDataSet1
        '
        'ColorDataSet1
        '
        Me.ColorDataSet1.DataSetName = "ColorDataSet1"
        Me.ColorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbModeloID
        '
        Me.cmbModeloID.DataSource = Me.ModeloVehiculoBindingSource
        Me.cmbModeloID.DisplayMember = "ModeloID"
        Me.cmbModeloID.FormattingEnabled = True
        Me.cmbModeloID.Location = New System.Drawing.Point(172, 203)
        Me.cmbModeloID.Name = "cmbModeloID"
        Me.cmbModeloID.Size = New System.Drawing.Size(52, 21)
        Me.cmbModeloID.TabIndex = 155
        '
        'ModeloVehiculoBindingSource
        '
        Me.ModeloVehiculoBindingSource.DataMember = "ModeloVehiculo"
        Me.ModeloVehiculoBindingSource.DataSource = Me.ModeloDataSet1
        '
        'ModeloDataSet1
        '
        Me.ModeloDataSet1.DataSetName = "ModeloDataSet1"
        Me.ModeloDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModeloEnCNVBindingSource
        '
        Me.ModeloEnCNVBindingSource.DataMember = "ModeloEnCNV"
        Me.ModeloEnCNVBindingSource.DataSource = Me.VistaModelo1
        '
        'VistaModelo1
        '
        Me.VistaModelo1.DataSetName = "VistaModelo1"
        Me.VistaModelo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbMarcaID
        '
        Me.cmbMarcaID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MarcasVehiculosBindingSource, "MarcaID", True))
        Me.cmbMarcaID.DataSource = Me.MarcasVehiculosBindingSource
        Me.cmbMarcaID.DisplayMember = "MarcaID"
        Me.cmbMarcaID.FormattingEnabled = True
        Me.cmbMarcaID.Location = New System.Drawing.Point(585, 160)
        Me.cmbMarcaID.Name = "cmbMarcaID"
        Me.cmbMarcaID.Size = New System.Drawing.Size(50, 21)
        Me.cmbMarcaID.TabIndex = 154
        Me.cmbMarcaID.ValueMember = "MarcaID"
        '
        'MarcasVehiculosBindingSource
        '
        Me.MarcasVehiculosBindingSource.DataMember = "MarcasVehiculos"
        Me.MarcasVehiculosBindingSource.DataSource = Me.MarcaDataSet1
        '
        'MarcaDataSet1
        '
        Me.MarcaDataSet1.DataSetName = "MarcaDataSet1"
        Me.MarcaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.label13.Location = New System.Drawing.Point(38, 244)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(37, 17)
        Me.label13.TabIndex = 153
        Me.label13.Text = "Año:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(358, 82)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(187, 20)
        Me.label12.TabIndex = 152
        Me.label12.Text = "DATOS DEL VEHICULO"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.label14.Location = New System.Drawing.Point(451, 205)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(45, 17)
        Me.label14.TabIndex = 151
        Me.label14.Text = "Color:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.label7.Location = New System.Drawing.Point(451, 246)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(116, 17)
        Me.label7.TabIndex = 148
        Me.label7.Text = "Tipo de vehículo:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.label8.Location = New System.Drawing.Point(38, 207)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(58, 17)
        Me.label8.TabIndex = 147
        Me.label8.Text = "Modelo:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.label9.Location = New System.Drawing.Point(451, 164)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(51, 17)
        Me.label9.TabIndex = 146
        Me.label9.Text = "Marca:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.label10.Location = New System.Drawing.Point(38, 166)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(121, 17)
        Me.label10.TabIndex = 145
        Me.label10.Text = "Numero de Placa:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(172, 160)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(244, 23)
        Me.txtPlaca.TabIndex = 144
        '
        'txtAnio
        '
        Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(172, 239)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(244, 23)
        Me.txtAnio.TabIndex = 159
        '
        'ModeloVehiculoTableAdapter
        '
        Me.ModeloVehiculoTableAdapter.ClearBeforeFill = True
        '
        'MarcasVehiculosTableAdapter
        '
        Me.MarcasVehiculosTableAdapter.ClearBeforeFill = True
        '
        'ColorVehiculoTableAdapter
        '
        Me.ColorVehiculoTableAdapter.ClearBeforeFill = True
        '
        'TipoVehiculoTableAdapter
        '
        Me.TipoVehiculoTableAdapter.ClearBeforeFill = True
        '
        'ModeloEnCNVTableAdapter
        '
        Me.ModeloEnCNVTableAdapter.ClearBeforeFill = True
        '
        'cmbModelo
        '
        Me.cmbModelo.DataSource = Me.ModeloVehiculoBindingSource
        Me.cmbModelo.DisplayMember = "Modelo"
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(172, 203)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(244, 21)
        Me.cmbModelo.TabIndex = 160
        '
        'cmbMarca
        '
        Me.cmbMarca.DataSource = Me.MarcasVehiculosBindingSource
        Me.cmbMarca.DisplayMember = "Marca"
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(585, 160)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(244, 21)
        Me.cmbMarca.TabIndex = 161
        '
        'cmbColor
        '
        Me.cmbColor.DataSource = Me.ColorVehiculoBindingSource
        Me.cmbColor.DisplayMember = "DescripcionColor"
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(585, 201)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(244, 21)
        Me.cmbColor.TabIndex = 162
        '
        'cmbTipoV
        '
        Me.cmbTipoV.DataSource = Me.TipoVehiculoBindingSource
        Me.cmbTipoV.DisplayMember = "Descripcion"
        Me.cmbTipoV.FormattingEnabled = True
        Me.cmbTipoV.Location = New System.Drawing.Point(585, 242)
        Me.cmbTipoV.Name = "cmbTipoV"
        Me.cmbTipoV.Size = New System.Drawing.Size(244, 21)
        Me.cmbTipoV.TabIndex = 163
        '
        'FrmNuevoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 457)
        Me.Controls.Add(Me.cmbTipoV)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbModelo)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.cmbTipoVID)
        Me.Controls.Add(Me.cmbColorID)
        Me.Controls.Add(Me.cmbModeloID)
        Me.Controls.Add(Me.cmbMarcaID)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.pnlTituleBar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNuevoVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmNuevoVehiculo"
        Me.pnlTituleBar.ResumeLayout(False)
        Me.pnlTituleBar.PerformLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVehiculoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloEnCNVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaModelo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pnlTituleBar As Panel
    Private WithEvents lblTitleChildForm As Label
    Private WithEvents iconCurrentChildForm As FontAwesome.Sharp.IconPictureBox
    Private WithEvents btnGuardar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents cmbTipoVID As ComboBox
    Private WithEvents cmbColorID As ComboBox
    Private WithEvents cmbModeloID As ComboBox
    Private WithEvents cmbMarcaID As ComboBox
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents label14 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents label10 As Label
    Public WithEvents txtPlaca As TextBox
    Public WithEvents txtAnio As TextBox
    Friend WithEvents ModeloDataSet1 As ModeloDataSet1
    Friend WithEvents ModeloVehiculoBindingSource As BindingSource
    Friend WithEvents ModeloVehiculoTableAdapter As ModeloDataSet1TableAdapters.ModeloVehiculoTableAdapter
    Friend WithEvents MarcaDataSet1 As MarcaDataSet1
    Friend WithEvents MarcasVehiculosBindingSource As BindingSource
    Friend WithEvents MarcasVehiculosTableAdapter As MarcaDataSet1TableAdapters.MarcasVehiculosTableAdapter
    Friend WithEvents ColorDataSet1 As ColorDataSet1
    Friend WithEvents ColorVehiculoBindingSource As BindingSource
    Friend WithEvents ColorVehiculoTableAdapter As ColorDataSet1TableAdapters.ColorVehiculoTableAdapter
    Friend WithEvents TipoVehiculoDataSet1 As TipoVehiculoDataSet1
    Friend WithEvents TipoVehiculoBindingSource As BindingSource
    Friend WithEvents TipoVehiculoTableAdapter As TipoVehiculoDataSet1TableAdapters.TipoVehiculoTableAdapter
    Friend WithEvents VistaModelo1 As VistaModelo1
    Friend WithEvents ModeloEnCNVBindingSource As BindingSource
    Friend WithEvents ModeloEnCNVTableAdapter As VistaModelo1TableAdapters.ModeloEnCNVTableAdapter
    Private WithEvents cmbModelo As ComboBox
    Private WithEvents cmbMarca As ComboBox
    Private WithEvents cmbColor As ComboBox
    Private WithEvents cmbTipoV As ComboBox
End Class
