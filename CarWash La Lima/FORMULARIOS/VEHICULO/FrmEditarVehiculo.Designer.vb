<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarVehiculo
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmbTipoVID = New System.Windows.Forms.ComboBox()
        Me.TipoVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoEditorDataSet1 = New CarWash_La_Lima.TipoEditorDataSet1()
        Me.cmbColorID = New System.Windows.Forms.ComboBox()
        Me.ColorVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorEditarDataSet1 = New CarWash_La_Lima.ColorEditarDataSet1()
        Me.cmbModeloID = New System.Windows.Forms.ComboBox()
        Me.ModeloVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModeloEditarDataSet1 = New CarWash_La_Lima.ModeloEditarDataSet1()
        Me.cmbMarcaID = New System.Windows.Forms.ComboBox()
        Me.MarcasVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasEditarDataSet1 = New CarWash_La_Lima.MarcasEditarDataSet1()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.ModeloVehiculoTableAdapter = New CarWash_La_Lima.ModeloEditarDataSet1TableAdapters.ModeloVehiculoTableAdapter()
        Me.ColorVehiculoTableAdapter = New CarWash_La_Lima.ColorEditarDataSet1TableAdapters.ColorVehiculoTableAdapter()
        Me.TipoVehiculoTableAdapter = New CarWash_La_Lima.TipoEditorDataSet1TableAdapters.TipoVehiculoTableAdapter()
        Me.MarcasVehiculosTableAdapter = New CarWash_La_Lima.MarcasEditarDataSet1TableAdapters.MarcasVehiculosTableAdapter()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.cmbTipoV = New System.Windows.Forms.ComboBox()
        Me.pnlTituleBar.SuspendLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoEditorDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEditarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloEditarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasEditarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlTituleBar.TabIndex = 162
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.AutoSize = True
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTitleChildForm.Location = New System.Drawing.Point(74, 25)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(136, 18)
        Me.lblTitleChildForm.TabIndex = 1
        Me.lblTitleChildForm.Text = "EDITAR VEHICULO"
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
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(446, 401)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 161
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(318, 401)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.btnGuardar.TabIndex = 160
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'cmbTipoVID
        '
        Me.cmbTipoVID.DataSource = Me.TipoVehiculoBindingSource
        Me.cmbTipoVID.DisplayMember = "TipoVehiculoID"
        Me.cmbTipoVID.FormattingEnabled = True
        Me.cmbTipoVID.Location = New System.Drawing.Point(379, 300)
        Me.cmbTipoVID.Name = "cmbTipoVID"
        Me.cmbTipoVID.Size = New System.Drawing.Size(51, 21)
        Me.cmbTipoVID.TabIndex = 184
        '
        'TipoVehiculoBindingSource
        '
        Me.TipoVehiculoBindingSource.DataMember = "TipoVehiculo"
        Me.TipoVehiculoBindingSource.DataSource = Me.TipoEditorDataSet1
        '
        'TipoEditorDataSet1
        '
        Me.TipoEditorDataSet1.DataSetName = "TipoEditorDataSet1"
        Me.TipoEditorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbColorID
        '
        Me.cmbColorID.DataSource = Me.ColorVehiculoBindingSource
        Me.cmbColorID.DisplayMember = "ColorID"
        Me.cmbColorID.FormattingEnabled = True
        Me.cmbColorID.Location = New System.Drawing.Point(379, 258)
        Me.cmbColorID.Name = "cmbColorID"
        Me.cmbColorID.Size = New System.Drawing.Size(51, 21)
        Me.cmbColorID.TabIndex = 183
        '
        'ColorVehiculoBindingSource
        '
        Me.ColorVehiculoBindingSource.DataMember = "ColorVehiculo"
        Me.ColorVehiculoBindingSource.DataSource = Me.ColorEditarDataSet1
        '
        'ColorEditarDataSet1
        '
        Me.ColorEditarDataSet1.DataSetName = "ColorEditarDataSet1"
        Me.ColorEditarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbModeloID
        '
        Me.cmbModeloID.DataSource = Me.ModeloVehiculoBindingSource
        Me.cmbModeloID.DisplayMember = "ModeloID"
        Me.cmbModeloID.FormattingEnabled = True
        Me.cmbModeloID.Location = New System.Drawing.Point(379, 175)
        Me.cmbModeloID.Name = "cmbModeloID"
        Me.cmbModeloID.Size = New System.Drawing.Size(51, 21)
        Me.cmbModeloID.TabIndex = 182
        Me.cmbModeloID.ValueMember = "MarcaID"
        '
        'ModeloVehiculoBindingSource
        '
        Me.ModeloVehiculoBindingSource.DataMember = "ModeloVehiculo"
        Me.ModeloVehiculoBindingSource.DataSource = Me.ModeloEditarDataSet1
        '
        'ModeloEditarDataSet1
        '
        Me.ModeloEditarDataSet1.DataSetName = "ModeloEditarDataSet1"
        Me.ModeloEditarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbMarcaID
        '
        Me.cmbMarcaID.DataSource = Me.MarcasVehiculosBindingSource
        Me.cmbMarcaID.DisplayMember = "MarcaID"
        Me.cmbMarcaID.FormattingEnabled = True
        Me.cmbMarcaID.Location = New System.Drawing.Point(379, 218)
        Me.cmbMarcaID.Name = "cmbMarcaID"
        Me.cmbMarcaID.Size = New System.Drawing.Size(51, 21)
        Me.cmbMarcaID.TabIndex = 181
        '
        'MarcasVehiculosBindingSource
        '
        Me.MarcasVehiculosBindingSource.DataMember = "MarcasVehiculos"
        Me.MarcasVehiculosBindingSource.DataSource = Me.MarcasEditarDataSet1
        '
        'MarcasEditarDataSet1
        '
        Me.MarcasEditarDataSet1.DataSetName = "MarcasEditarDataSet1"
        Me.MarcasEditarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(375, 83)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(187, 20)
        Me.label12.TabIndex = 179
        Me.label12.Text = "DATOS DEL VEHICULO"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.label14.Location = New System.Drawing.Point(245, 262)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(45, 17)
        Me.label14.TabIndex = 178
        Me.label14.Text = "Color:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.label7.Location = New System.Drawing.Point(245, 304)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(116, 17)
        Me.label7.TabIndex = 177
        Me.label7.Text = "Tipo de vehículo:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.label8.Location = New System.Drawing.Point(245, 179)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(58, 17)
        Me.label8.TabIndex = 176
        Me.label8.Text = "Modelo:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.label9.Location = New System.Drawing.Point(245, 222)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(51, 17)
        Me.label9.TabIndex = 175
        Me.label9.Text = "Marca:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.label10.Location = New System.Drawing.Point(245, 142)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(121, 17)
        Me.label10.TabIndex = 174
        Me.label10.Text = "Numero de Placa:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(379, 136)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(244, 23)
        Me.txtPlaca.TabIndex = 173
        '
        'ModeloVehiculoTableAdapter
        '
        Me.ModeloVehiculoTableAdapter.ClearBeforeFill = True
        '
        'ColorVehiculoTableAdapter
        '
        Me.ColorVehiculoTableAdapter.ClearBeforeFill = True
        '
        'TipoVehiculoTableAdapter
        '
        Me.TipoVehiculoTableAdapter.ClearBeforeFill = True
        '
        'MarcasVehiculosTableAdapter
        '
        Me.MarcasVehiculosTableAdapter.ClearBeforeFill = True
        '
        'cmbModelo
        '
        Me.cmbModelo.DataSource = Me.ModeloVehiculoBindingSource
        Me.cmbModelo.DisplayMember = "Modelo"
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(379, 175)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(244, 21)
        Me.cmbModelo.TabIndex = 185
        '
        'cmbMarca
        '
        Me.cmbMarca.DataSource = Me.MarcasVehiculosBindingSource
        Me.cmbMarca.DisplayMember = "Marca"
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(379, 218)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(244, 21)
        Me.cmbMarca.TabIndex = 186
        '
        'cmbColor
        '
        Me.cmbColor.DataSource = Me.ColorVehiculoBindingSource
        Me.cmbColor.DisplayMember = "DescripcionColor"
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(379, 258)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(244, 21)
        Me.cmbColor.TabIndex = 187
        '
        'cmbTipoV
        '
        Me.cmbTipoV.DataSource = Me.TipoVehiculoBindingSource
        Me.cmbTipoV.DisplayMember = "Descripcion"
        Me.cmbTipoV.FormattingEnabled = True
        Me.cmbTipoV.Location = New System.Drawing.Point(379, 300)
        Me.cmbTipoV.Name = "cmbTipoV"
        Me.cmbTipoV.Size = New System.Drawing.Size(244, 21)
        Me.cmbTipoV.TabIndex = 188
        '
        'FrmEditarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 457)
        Me.Controls.Add(Me.cmbTipoV)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbModelo)
        Me.Controls.Add(Me.cmbTipoVID)
        Me.Controls.Add(Me.cmbColorID)
        Me.Controls.Add(Me.cmbModeloID)
        Me.Controls.Add(Me.cmbMarcaID)
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
        Me.Name = "FrmEditarVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmEditarVehiculo"
        Me.pnlTituleBar.ResumeLayout(False)
        Me.pnlTituleBar.PerformLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoEditorDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEditarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloEditarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasEditarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pnlTituleBar As Panel
    Private WithEvents lblTitleChildForm As Label
    Private WithEvents iconCurrentChildForm As FontAwesome.Sharp.IconPictureBox
    Private WithEvents btnCancelar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents cmbTipoVID As ComboBox
    Private WithEvents cmbColorID As ComboBox
    Private WithEvents cmbModeloID As ComboBox
    Private WithEvents cmbMarcaID As ComboBox
    Private WithEvents label12 As Label
    Private WithEvents label14 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents label10 As Label
    Public WithEvents txtPlaca As TextBox
    Friend WithEvents ModeloEditarDataSet1 As ModeloEditarDataSet1
    Friend WithEvents ModeloVehiculoBindingSource As BindingSource
    Friend WithEvents ModeloVehiculoTableAdapter As ModeloEditarDataSet1TableAdapters.ModeloVehiculoTableAdapter
    Friend WithEvents ColorEditarDataSet1 As ColorEditarDataSet1
    Friend WithEvents ColorVehiculoBindingSource As BindingSource
    Friend WithEvents ColorVehiculoTableAdapter As ColorEditarDataSet1TableAdapters.ColorVehiculoTableAdapter
    Friend WithEvents TipoEditorDataSet1 As TipoEditorDataSet1
    Friend WithEvents TipoVehiculoBindingSource As BindingSource
    Friend WithEvents TipoVehiculoTableAdapter As TipoEditorDataSet1TableAdapters.TipoVehiculoTableAdapter
    Friend WithEvents MarcasEditarDataSet1 As MarcasEditarDataSet1
    Friend WithEvents MarcasVehiculosBindingSource As BindingSource
    Friend WithEvents MarcasVehiculosTableAdapter As MarcasEditarDataSet1TableAdapters.MarcasVehiculosTableAdapter
    Private WithEvents cmbModelo As ComboBox
    Private WithEvents cmbMarca As ComboBox
    Private WithEvents cmbColor As ComboBox
    Private WithEvents cmbTipoV As ComboBox
End Class
