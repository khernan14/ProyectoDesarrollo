<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWelcome))
        Me.circularBar = New CircularProgressBar.CircularProgressBar()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'circularBar
        '
        Me.circularBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.circularBar.AnimationSpeed = 350
        Me.circularBar.BackColor = System.Drawing.Color.Transparent
        Me.circularBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Bold)
        Me.circularBar.ForeColor = System.Drawing.Color.Silver
        Me.circularBar.InnerColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.circularBar.InnerMargin = 2
        Me.circularBar.InnerWidth = -1
        Me.circularBar.Location = New System.Drawing.Point(535, 343)
        Me.circularBar.MarqueeAnimationSpeed = 2000
        Me.circularBar.Name = "circularBar"
        Me.circularBar.OuterColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circularBar.OuterMargin = -25
        Me.circularBar.OuterWidth = 26
        Me.circularBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.circularBar.ProgressWidth = 25
        Me.circularBar.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.circularBar.Size = New System.Drawing.Size(172, 164)
        Me.circularBar.StartAngle = 270
        Me.circularBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.circularBar.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.circularBar.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.circularBar.SubscriptText = ""
        Me.circularBar.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.circularBar.SuperscriptMargin = New System.Windows.Forms.Padding(10, 25, 0, 0)
        Me.circularBar.SuperscriptText = "%"
        Me.circularBar.TabIndex = 8
        Me.circularBar.Text = "0"
        Me.circularBar.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.circularBar.Value = 68
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Silver
        Me.label1.Location = New System.Drawing.Point(444, 109)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(377, 77)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Bienvenido"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.pictureBox1)
        Me.panelTitleBar.Controls.Add(Me.mzButtonWindows2)
        Me.panelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(944, 76)
        Me.panelTitleBar.TabIndex = 9
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.CarWash_La_Lima.My.Resources.Resources._23667483
        Me.pictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(128, 70)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 18
        Me.pictureBox1.TabStop = False
        '
        'mzButtonWindows2
        '
        Me.mzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mzButtonWindows2.BackgroundImage = CType(resources.GetObject("mzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.mzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.mzButtonWindows2.Location = New System.Drawing.Point(1124, 0)
        Me.mzButtonWindows2.Name = "mzButtonWindows2"
        Me.mzButtonWindows2.ParentControl = Me
        Me.mzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.mzButtonWindows2.TabIndex = 0
        Me.mzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(137, 21)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(253, 35)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "CARWASH SYSTEM"
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.LightGray
        Me.lblName.Location = New System.Drawing.Point(458, 226)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(31, 29)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "..."
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timer1
        '
        Me.timer1.Interval = 60
        '
        'timer2
        '
        Me.timer2.Interval = 60
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.LightGray
        Me.lblMessage.Location = New System.Drawing.Point(12, 528)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(21, 20)
        Me.lblMessage.TabIndex = 21
        Me.lblMessage.Text = "..."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CarWash_La_Lima.My.Resources.Resources.CARWASH
        Me.PictureBox2.Location = New System.Drawing.Point(0, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(390, 476)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'FrmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(944, 557)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.circularBar)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmWelcome"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents circularBar As CircularProgressBar.CircularProgressBar
    Private WithEvents label1 As Label
    Private WithEvents panelTitleBar As Panel
    Private WithEvents mzButtonWindows2 As BWCMM.MZButtonWindows
    Private WithEvents lblFormTitle As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents lblName As Label
    Private WithEvents timer1 As Timer
    Private WithEvents timer2 As Timer
    Private WithEvents lblMessage As Label
End Class
