<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarEmpleado
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
        Me.cmbPuestoID = New System.Windows.Forms.ComboBox()
        Me.PuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Puesto2DataSet1 = New CarWash_La_Lima.Puesto2DataSet1()
        Me.pnlTituleBar = New System.Windows.Forms.Panel()
        Me.lblTitleChildForm = New System.Windows.Forms.Label()
        Me.iconCurrentChildForm = New FontAwesome.Sharp.IconPictureBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.PuestoDataSet1 = New CarWash_La_Lima.PuestoDataSet1()
        Me.PuestoDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuestoTableAdapter = New CarWash_La_Lima.Puesto2DataSet1TableAdapters.PuestoTableAdapter()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Puesto2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTituleBar.SuspendLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbPuestoID
        '
        Me.cmbPuestoID.DataSource = Me.PuestoBindingSource
        Me.cmbPuestoID.DisplayMember = "PuestoID"
        Me.cmbPuestoID.FormattingEnabled = True
        Me.cmbPuestoID.Location = New System.Drawing.Point(424, 393)
        Me.cmbPuestoID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPuestoID.Name = "cmbPuestoID"
        Me.cmbPuestoID.Size = New System.Drawing.Size(60, 24)
        Me.cmbPuestoID.TabIndex = 158
        Me.cmbPuestoID.ValueMember = "DescripcionPuesto"
        '
        'PuestoBindingSource
        '
        Me.PuestoBindingSource.DataMember = "Puesto"
        Me.PuestoBindingSource.DataSource = Me.Puesto2DataSet1
        '
        'Puesto2DataSet1
        '
        Me.Puesto2DataSet1.DataSetName = "Puesto2DataSet1"
        Me.Puesto2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlTituleBar
        '
        Me.pnlTituleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlTituleBar.Controls.Add(Me.lblTitleChildForm)
        Me.pnlTituleBar.Controls.Add(Me.iconCurrentChildForm)
        Me.pnlTituleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTituleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituleBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTituleBar.Name = "pnlTituleBar"
        Me.pnlTituleBar.Size = New System.Drawing.Size(1160, 63)
        Me.pnlTituleBar.TabIndex = 157
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.AutoSize = True
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTitleChildForm.Location = New System.Drawing.Point(99, 31)
        Me.lblTitleChildForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(175, 23)
        Me.lblTitleChildForm.TabIndex = 1
        Me.lblTitleChildForm.Text = "EDITAR EMPLEADO"
        '
        'iconCurrentChildForm
        '
        Me.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconCurrentChildForm.IconSize = 39
        Me.iconCurrentChildForm.Location = New System.Drawing.Point(48, 23)
        Me.iconCurrentChildForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconCurrentChildForm.Name = "iconCurrentChildForm"
        Me.iconCurrentChildForm.Size = New System.Drawing.Size(43, 39)
        Me.iconCurrentChildForm.TabIndex = 0
        Me.iconCurrentChildForm.TabStop = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(449, 113)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(242, 25)
        Me.label11.TabIndex = 156
        Me.label11.Text = "DATOS DEL EMPLEADO"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.label5.Location = New System.Drawing.Point(301, 176)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(31, 20)
        Me.label5.TabIndex = 155
        Me.label5.Text = "ID:"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(424, 172)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(324, 26)
        Me.txtid.TabIndex = 154
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(596, 471)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(133, 43)
        Me.btnCancelar.TabIndex = 153
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
        Me.btnGuardar.Location = New System.Drawing.Point(425, 471)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 43)
        Me.btnGuardar.TabIndex = 152
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(301, 338)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 20)
        Me.label4.TabIndex = 151
        Me.label4.Text = "Teléfono:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.label3.Location = New System.Drawing.Point(301, 394)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 20)
        Me.label3.TabIndex = 150
        Me.label3.Text = "Puesto"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(301, 282)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 20)
        Me.label1.TabIndex = 149
        Me.label1.Text = "Apellidos:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.label2.Location = New System.Drawing.Point(301, 226)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 20)
        Me.label2.TabIndex = 148
        Me.label2.Text = "Nombres:"
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(424, 335)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(324, 26)
        Me.txttelefono.TabIndex = 147
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(424, 278)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtapellido.MaxLength = 50
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(324, 26)
        Me.txtapellido.TabIndex = 146
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(424, 223)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(324, 26)
        Me.txtnombre.TabIndex = 145
        '
        'PuestoDataSet1
        '
        Me.PuestoDataSet1.DataSetName = "PuestoDataSet1"
        Me.PuestoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuestoDataSet1BindingSource
        '
        Me.PuestoDataSet1BindingSource.DataSource = Me.PuestoDataSet1
        Me.PuestoDataSet1BindingSource.Position = 0
        '
        'PuestoTableAdapter
        '
        Me.PuestoTableAdapter.ClearBeforeFill = True
        '
        'cmbPuesto
        '
        Me.cmbPuesto.DataSource = Me.PuestoBindingSource
        Me.cmbPuesto.DisplayMember = "DescripcionPuesto"
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Location = New System.Drawing.Point(424, 393)
        Me.cmbPuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(324, 24)
        Me.cmbPuesto.TabIndex = 174
        '
        'FrmEditarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 562)
        Me.Controls.Add(Me.cmbPuesto)
        Me.Controls.Add(Me.cmbPuestoID)
        Me.Controls.Add(Me.pnlTituleBar)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmEditarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmEditarEmpleado"
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Puesto2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTituleBar.ResumeLayout(False)
        Me.pnlTituleBar.PerformLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPuestoID As ComboBox
    Private WithEvents pnlTituleBar As Panel
    Private WithEvents lblTitleChildForm As Label
    Private WithEvents iconCurrentChildForm As FontAwesome.Sharp.IconPictureBox
    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Public WithEvents txtid As TextBox
    Private WithEvents btnCancelar As Button
    Private WithEvents btnGuardar As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Public WithEvents txttelefono As TextBox
    Public WithEvents txtapellido As TextBox
    Public WithEvents txtnombre As TextBox
    Friend WithEvents PuestoDataSet1BindingSource As BindingSource
    Friend WithEvents PuestoDataSet1 As PuestoDataSet1
    Friend WithEvents Puesto2DataSet1 As Puesto2DataSet1
    Friend WithEvents PuestoBindingSource As BindingSource
    Friend WithEvents PuestoTableAdapter As Puesto2DataSet1TableAdapters.PuestoTableAdapter
    Friend WithEvents cmbPuesto As ComboBox
End Class
