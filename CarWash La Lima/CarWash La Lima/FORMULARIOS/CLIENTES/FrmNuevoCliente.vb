Imports System.Runtime.InteropServices

Public Class FrmNuevoCliente
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pnlTituleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTituleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If (txtPlaca.Text = "" Or txtnombre.Text = "" Or txtapellido.Text = "" Or txttelefono.Text = "") Then
                MessageBox.Show("No puede dejar campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim frm As New CLIENTES
                frm.ClientesTableAdapter.InsertQuery(txtPlaca.Text, txtnombre.Text, txtapellido.Text, Val(txttelefono.Text), txtdireccion.Text)
                frm.ClientesTableAdapter.Fill(frm.ClientesDataSet.Clientes)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlacaDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.PlacaDataSet.Vehiculo)

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim frm As New FrmVehiculo
        AddOwnedForm(frm) ' Esto es para indicar que este formularios sera propietario del formulario Clientes
        frm.ShowDialog()
        frm.btnEditar.Visible = False
        frm.btnEliminar.Visible = False
    End Sub
End Class