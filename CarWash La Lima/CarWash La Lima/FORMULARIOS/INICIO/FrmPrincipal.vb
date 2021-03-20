Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Support

Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultar()
        'lblName.Text = ActiveUser.NombreEmpleado + ", " + ActiveUser.ApellidoEmpleado
        lblUsers.Text = ActiveUser.Usuario
        'lblCargo.Text = ActiveUser.Puesto
    End Sub

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        panelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            iconCurrentForm.IconChar = currentBtn.IconChar
            iconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        iconCurrentForm.IconChar = IconChar.Home
        iconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "INICIO"
    End Sub
    'Events'
    'Reset'
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    'Menu buttons Cliks'
    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FrmFacturar)
    End Sub
    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New CLIENTES)
    End Sub
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New FrmVehiculo)
    End Sub
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FrmEmpleado)
    End Sub
    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New FrmHistorialFactura)
    End Sub
    'Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
    '    ActivateButton(sender, RGBColors.color6)
    '    OpenChildForm(New FormSetting)
    'End Sub
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Esta seguro que desea cerrar la aplicacion?", "Advertencia", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Remove transparent border in maximized state'
    Private Sub FrmPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub ocultar()
        pnlSubMenu.Visible = False
    End Sub

    Private Sub mostrar(subMenu As Panel)
        If (subMenu.Visible = False) Then
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        mostrar(pnlSubMenu)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        OpenChildForm(New FrmUsuarios)
        ocultar()
    End Sub

    Private Sub btnModelos_Click(sender As Object, e As EventArgs) Handles btnModelos.Click
        OpenChildForm(New FrmModelos)
        ocultar()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        OpenChildForm(New FrmColores)
        ocultar()
    End Sub

    Private Sub btnTipoV_Click(sender As Object, e As EventArgs) Handles btnTipoV.Click
        OpenChildForm(New FrmTipo)
        ocultar()
    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        OpenChildForm(New FrmMarcas)
        ocultar()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("¿Desea cerrar sesion?", "Advertencia", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class

'............................................'
Public Structure RGBColors
    Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
    Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
    Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
    Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
    Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
    Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
End Structure