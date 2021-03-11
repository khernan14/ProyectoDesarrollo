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
        Dim frm As New CLIENTES
        frm.ClientesTableAdapter.InsertQuery(txtPlaca.Text, txtnombre.Text, txtapellido.Text, Val(txttelefono.Text), txtdireccion.Text)
        frm.ClientesTableAdapter.Fill(frm.ClientesDataSet.Clientes)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PlacaDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.PlacaDataSet.Vehiculo)

    End Sub
End Class