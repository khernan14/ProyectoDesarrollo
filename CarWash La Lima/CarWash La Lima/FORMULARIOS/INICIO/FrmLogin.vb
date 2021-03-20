Imports System.Runtime.InteropServices
Imports Domain

Public Class FrmLogin

    Private Sub btnMostrarOcultar_Click(sender As Object, e As EventArgs) Handles btnMostrarOcultar.Click
        Dim text As String = txtPassword.Text
        txtPassword.UseSystemPasswordChar = False
        txtPassword.Text = text
        btnMostrarOcultar.Visible = False
        btnOcultar.Visible = True
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        Dim text As String = txtPassword.Text
        txtPassword.UseSystemPasswordChar = True
        txtPassword.Text = text
        btnMostrarOcultar.Visible = True
        btnOcultar.Visible = False
    End Sub

    Private Sub txtUsuario_Enter_1(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If txtUsuario.Text = "USUARIO" Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "USUARIO"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "CONTRASEÑA" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.LightGray
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "CONTRASEÑA"
            txtPassword.ForeColor = Color.DimGray
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    'Esto es para poder mover el formulario por toda la pantalla'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    End Sub

    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userModel As New UserModel()

        If txtUsuario.Text <> "USUARIO" Then
            If txtPassword.Text <> "CONTRASEÑA" Then
                Dim validarInicio = userModel.Login(txtUsuario.Text, txtPassword.Text)
                If validarInicio = True Then
                    Dim frm As New FrmPrincipal()
                    frm.Show()
                    AddHandler frm.FormClosed, AddressOf Me.Logout
                    Me.Hide()
                Else
                    msgError("Usuario o Contraseña incorrectos.")
                    txtPassword.Text = "CONTRASEÑA"
                    txtPassword.UseSystemPasswordChar = False
                    txtPassword.ForeColor = Color.DimGray

                    txtUsuario.Text = "USUARIO"
                    txtUsuario.ForeColor = Color.DimGray
                End If
            Else
                msgError("Ingrese una contraseña")
            End If
        Else
            msgError("Ingrese nombre de usuario")
        End If

    End Sub

    Private Sub msgError(ByVal msg As String)
        btnErrorMessage.Text = " " & msg
        btnErrorMessage.Visible = True
    End Sub

    Private Sub Logout(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        txtPassword.Text = "CONTRASEÑA"
        txtPassword.UseSystemPasswordChar = False
        txtUsuario.Text = "USUARIO"
        btnErrorMessage.Visible = False
        Me.Show()
    End Sub

End Class