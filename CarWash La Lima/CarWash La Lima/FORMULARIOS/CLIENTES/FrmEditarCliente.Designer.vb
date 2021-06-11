<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarCliente))
        Me.pnlTituleBar = New System.Windows.Forms.Panel()
        Me.mzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.lblTitleChildForm = New System.Windows.Forms.Label()
        Me.iconCurrentChildForm = New FontAwesome.Sharp.IconPictureBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.pnlTituleBar.SuspendLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTituleBar
        '
        Me.pnlTituleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pnlTituleBar.Controls.Add(Me.mzButtonWindows2)
        Me.pnlTituleBar.Controls.Add(Me.lblTitleChildForm)
        Me.pnlTituleBar.Controls.Add(Me.iconCurrentChildForm)
        Me.pnlTituleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTituleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituleBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTituleBar.Name = "pnlTituleBar"
        Me.pnlTituleBar.Size = New System.Drawing.Size(1160, 63)
        Me.pnlTituleBar.TabIndex = 106
        '
        'mzButtonWindows2
        '
        Me.mzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mzButtonWindows2.BackgroundImage = CType(resources.GetObject("mzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.mzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.mzButtonWindows2.Location = New System.Drawing.Point(1400, 0)
        Me.mzButtonWindows2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mzButtonWindows2.Name = "mzButtonWindows2"
        Me.mzButtonWindows2.ParentControl = Me
        Me.mzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.mzButtonWindows2.TabIndex = 0
        Me.mzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null
        '
        'lblTitleChildForm
        '
        Me.lblTitleChildForm.AutoSize = True
        Me.lblTitleChildForm.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTitleChildForm.Location = New System.Drawing.Point(99, 31)
        Me.lblTitleChildForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleChildForm.Name = "lblTitleChildForm"
        Me.lblTitleChildForm.Size = New System.Drawing.Size(156, 23)
        Me.lblTitleChildForm.TabIndex = 1
        Me.lblTitleChildForm.Text = "EDITAR CLIENTES"
        '
        'iconCurrentChildForm
        '
        Me.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.UserEdit
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
        Me.label11.Size = New System.Drawing.Size(215, 25)
        Me.label11.TabIndex = 140
        Me.label11.Text = "DATOS DEL CLIENTE"
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
        Me.label5.TabIndex = 139
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
        Me.txtid.TabIndex = 138
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
        Me.btnCancelar.TabIndex = 137
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(425, 471)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(133, 43)
        Me.button1.TabIndex = 136
        Me.button1.Text = "Guardar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.label4.Location = New System.Drawing.Point(301, 393)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 20)
        Me.label4.TabIndex = 135
        Me.label4.Text = "Teléfono:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.label3.Location = New System.Drawing.Point(301, 337)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 20)
        Me.label3.TabIndex = 134
        Me.label3.Text = "Direccion:"
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
        Me.label1.TabIndex = 133
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
        Me.label2.TabIndex = 132
        Me.label2.Text = "Nombres:"
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(424, 389)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttelefono.MaxLength = 8
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(324, 26)
        Me.txttelefono.TabIndex = 131
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(424, 334)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtdireccion.MaxLength = 70
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(324, 26)
        Me.txtdireccion.TabIndex = 130
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(424, 278)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtapellido.MaxLength = 30
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(324, 26)
        Me.txtapellido.TabIndex = 129
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(424, 223)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnombre.MaxLength = 30
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(324, 26)
        Me.txtnombre.TabIndex = 128
        '
        'FrmEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 562)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.pnlTituleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmEditarCliente"
        Me.Text = "FrmEditarCliente"
        Me.pnlTituleBar.ResumeLayout(False)
        Me.pnlTituleBar.PerformLayout()
        CType(Me.iconCurrentChildForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pnlTituleBar As Panel
    Private WithEvents mzButtonWindows2 As BWCMM.MZButtonWindows
    Private WithEvents lblTitleChildForm As Label
    Private WithEvents iconCurrentChildForm As FontAwesome.Sharp.IconPictureBox
    Private WithEvents label11 As Label
    Private WithEvents label5 As Label
    Public WithEvents txtid As TextBox
    Private WithEvents btnCancelar As Button
    Private WithEvents button1 As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Public WithEvents txttelefono As TextBox
    Public WithEvents txtdireccion As TextBox
    Public WithEvents txtapellido As TextBox
    Public WithEvents txtnombre As TextBox
End Class
