<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.MzButtonWindows1 = New BWCMM.MZButtonWindows()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnMostrarOcultar = New FontAwesome.Sharp.IconButton()
        Me.btnOcultar = New FontAwesome.Sharp.IconButton()
        Me.btnErrorMessage = New FontAwesome.Sharp.IconButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.MzButtonWindows1)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(430, 40)
        Me.BarraTitulo.TabIndex = 0
        '
        'MzButtonWindows1
        '
        Me.MzButtonWindows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MzButtonWindows1.BackgroundImage = CType(resources.GetObject("MzButtonWindows1.BackgroundImage"), System.Drawing.Image)
        Me.MzButtonWindows1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MzButtonWindows1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MzButtonWindows1.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.MzButtonWindows1.Location = New System.Drawing.Point(390, 0)
        Me.MzButtonWindows1.Name = "MzButtonWindows1"
        Me.MzButtonWindows1.ParentControl = Me
        Me.MzButtonWindows1.Size = New System.Drawing.Size(40, 24)
        Me.MzButtonWindows1.TabIndex = 0
        Me.MzButtonWindows1.TipoButton = BWCMM.MZButtonWindows.ModeButton.Close
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 665)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 15)
        Me.Panel1.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.LightGray
        Me.btnLogin.Location = New System.Drawing.Point(46, 552)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 50)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "ACCEDER"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(78, 394)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(238, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "CONTRASEÑA"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsuario.Location = New System.Drawing.Point(83, 329)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(238, 20)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = "USUARIO"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(430, 680)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DimGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 80
        Me.LineShape2.X2 = 340
        Me.LineShape2.Y1 = 351
        Me.LineShape2.Y2 = 351
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DimGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 77
        Me.LineShape1.X2 = 340
        Me.LineShape1.Y1 = 416
        Me.LineShape1.Y2 = 416
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.DimGray
        Me.label1.Location = New System.Drawing.Point(172, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(101, 32)
        Me.label1.TabIndex = 10
        Me.label1.Text = "LOGIN"
        '
        'btnMostrarOcultar
        '
        Me.btnMostrarOcultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnMostrarOcultar.FlatAppearance.BorderSize = 0
        Me.btnMostrarOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarOcultar.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnMostrarOcultar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMostrarOcultar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMostrarOcultar.IconSize = 26
        Me.btnMostrarOcultar.Location = New System.Drawing.Point(317, 391)
        Me.btnMostrarOcultar.Name = "btnMostrarOcultar"
        Me.btnMostrarOcultar.Size = New System.Drawing.Size(24, 23)
        Me.btnMostrarOcultar.TabIndex = 3
        Me.btnMostrarOcultar.UseVisualStyleBackColor = False
        '
        'btnOcultar
        '
        Me.btnOcultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnOcultar.FlatAppearance.BorderSize = 0
        Me.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnOcultar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnOcultar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOcultar.IconSize = 26
        Me.btnOcultar.Location = New System.Drawing.Point(317, 391)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(24, 23)
        Me.btnOcultar.TabIndex = 13
        Me.btnOcultar.UseVisualStyleBackColor = False
        '
        'btnErrorMessage
        '
        Me.btnErrorMessage.FlatAppearance.BorderSize = 0
        Me.btnErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnErrorMessage.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnErrorMessage.ForeColor = System.Drawing.Color.White
        Me.btnErrorMessage.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.btnErrorMessage.IconColor = System.Drawing.Color.Red
        Me.btnErrorMessage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnErrorMessage.IconSize = 22
        Me.btnErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnErrorMessage.Location = New System.Drawing.Point(77, 432)
        Me.btnErrorMessage.Name = "btnErrorMessage"
        Me.btnErrorMessage.Size = New System.Drawing.Size(278, 30)
        Me.btnErrorMessage.TabIndex = 16
        Me.btnErrorMessage.Text = "Error Message"
        Me.btnErrorMessage.UseVisualStyleBackColor = True
        Me.btnErrorMessage.Visible = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.CarWash_La_Lima.My.Resources.Resources._23667483
        Me.pictureBox1.Location = New System.Drawing.Point(111, 113)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(210, 164)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 17
        Me.pictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 680)
        Me.Controls.Add(Me.btnMostrarOcultar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnErrorMessage)
        Me.Controls.Add(Me.btnOcultar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Opacity = 0.9R
        Me.Text = "FrmLogin"
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MzButtonWindows1 As BWCMM.MZButtonWindows
    Private WithEvents label1 As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtUsuario As TextBox
    Private WithEvents btnLogin As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Private WithEvents btnOcultar As FontAwesome.Sharp.IconButton
    Private WithEvents btnMostrarOcultar As FontAwesome.Sharp.IconButton
    Private WithEvents btnErrorMessage As FontAwesome.Sharp.IconButton
    Private WithEvents pictureBox1 As PictureBox
End Class
