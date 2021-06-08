<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogout
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.circularBar = New CircularProgressBar.CircularProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Silver
        Me.label1.Location = New System.Drawing.Point(137, 114)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(303, 36)
        Me.label1.TabIndex = 8
        Me.label1.Text = "CERRANDO SESION..."
        '
        'timer1
        '
        Me.timer1.Interval = 50
        '
        'timer2
        '
        Me.timer2.Interval = 50
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
        Me.circularBar.Location = New System.Drawing.Point(208, 133)
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
        Me.circularBar.TabIndex = 9
        Me.circularBar.Text = "0"
        Me.circularBar.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.circularBar.Value = 68
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 329)
        Me.Panel1.TabIndex = 10
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.LightGray
        Me.lblMessage.Location = New System.Drawing.Point(12, 301)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(20, 18)
        Me.lblMessage.TabIndex = 22
        Me.lblMessage.Text = "..."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 328)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.circularBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents timer1 As Timer
    Private WithEvents timer2 As Timer
    Private WithEvents circularBar As CircularProgressBar.CircularProgressBar
    Friend WithEvents Panel1 As Panel
    Private WithEvents lblMessage As Label
End Class
