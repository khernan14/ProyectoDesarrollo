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
        Me.label1 = New System.Windows.Forms.Label()
        Me.circularBar = New CircularProgressBar.CircularProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.mzButtonWindows2 = New BWCMM.MZButtonWindows()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Silver
        Me.label1.Location = New System.Drawing.Point(427, 93)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(377, 77)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Bienvenido"
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
        Me.circularBar.Location = New System.Drawing.Point(541, 303)
        Me.circularBar.MarqueeAnimationSpeed = 2000
        Me.circularBar.Name = "circularBar"
        Me.circularBar.OuterColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.circularBar.OuterMargin = -25
        Me.circularBar.OuterWidth = 26
        Me.circularBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.circularBar.ProgressWidth = 25
        Me.circularBar.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.circularBar.Size = New System.Drawing.Size(150, 150)
        Me.circularBar.StartAngle = 270
        Me.circularBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.circularBar.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.circularBar.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.circularBar.SubscriptText = ""
        Me.circularBar.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.circularBar.SuperscriptMargin = New System.Windows.Forms.Padding(10, 25, 0, 0)
        Me.circularBar.SuperscriptText = "%"
        Me.circularBar.TabIndex = 6
        Me.circularBar.Text = "0"
        Me.circularBar.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.circularBar.Value = 68
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.panelTitleBar.Controls.Add(Me.mzButtonWindows2)
        Me.panelTitleBar.Controls.Add(Me.pictureBox1)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(940, 70)
        Me.panelTitleBar.TabIndex = 7
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(105, 24)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(176, 23)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "CARWASH SYSTEM"
        '
        'mzButtonWindows2
        '
        Me.mzButtonWindows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mzButtonWindows2.BackgroundImage = CType(resources.GetObject("mzButtonWindows2.BackgroundImage"), System.Drawing.Image)
        Me.mzButtonWindows2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mzButtonWindows2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mzButtonWindows2.EstiloButton = BWCMM.MZButtonWindows.EstiloDeButton.Windows
        Me.mzButtonWindows2.Location = New System.Drawing.Point(1120, 0)
        Me.mzButtonWindows2.Name = "mzButtonWindows2"
        Me.mzButtonWindows2.ParentControl = Me
        Me.mzButtonWindows2.Size = New System.Drawing.Size(40, 24)
        Me.mzButtonWindows2.TabIndex = 0
        Me.mzButtonWindows2.TipoButton = BWCMM.MZButtonWindows.ModeButton.Null
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(87, 67)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'FrmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(940, 509)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.circularBar)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLoginCargar"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents circularBar As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Private WithEvents panelTitleBar As Panel
    Private WithEvents mzButtonWindows2 As BWCMM.MZButtonWindows
    Private WithEvents lblFormTitle As Label
End Class
