<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginCargar
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.circularBar = New CircularProgressBar.CircularProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Silver
        Me.label1.Location = New System.Drawing.Point(209, 257)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(377, 77)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Bienvenido"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.CarWash_La_Lima.My.Resources.Resources._23667483
        Me.pictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(760, 138)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
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
        Me.circularBar.Location = New System.Drawing.Point(29, 266)
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
        'FrmLoginCargar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.circularBar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLoginCargar"
        Me.Text = "FrmLoginCargar"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents circularBar As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
