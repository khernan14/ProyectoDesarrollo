
Imports System.Data.SqlClient
Imports Support

Public Class FrmEmpleado

    Dim obj As New Buscar
    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaEmpleadosPuestosDataSet1.VistaEmpleadosPuestos' Puede moverla o quitarla según sea necesario.
        Me.VistaEmpleadosPuestosTableAdapter.Fill(Me.VistaEmpleadosPuestosDataSet1.VistaEmpleadosPuestos)
        'TODO: esta línea de código carga datos en la tabla 'VistaVehiculoDataSet1.VistaVehiculo' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.EmpleadosDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'EmpleadosDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.EmpleadosDataSet1.Empleado)
        permisos()
    End Sub
    Private Sub permisos()
        If ActiveUser.Puesto = Cargos.facturador Then
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim nuevo As FrmNuevoEmpleado = New FrmNuevoEmpleado()
        nuevo.ShowDialog()
        Me.VistaEmpleadosPuestosTableAdapter.Fill(Me.VistaEmpleadosPuestosDataSet1.VistaEmpleadosPuestos)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (dgEmpleados.SelectedRows.Count > 0) Then
            Dim frm As New FrmEditarEmpleado
            frm.txtid.Text = dgEmpleados.CurrentRow.Cells(0).Value.ToString()
            frm.txtnombre.Text = dgEmpleados.CurrentRow.Cells(1).Value.ToString()
            frm.txtapellido.Text = dgEmpleados.CurrentRow.Cells(2).Value.ToString()
            frm.txttelefono.Text = dgEmpleados.CurrentRow.Cells(3).Value.ToString()
            frm.ShowDialog()
        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.VistaEmpleadosPuestosTableAdapter.Fill(Me.VistaEmpleadosPuestosDataSet1.VistaEmpleadosPuestos)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgEmpleados.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgEmpleados.CurrentRow.Cells(0).Value

            Me.EmpleadoTableAdapter.EliminarEmpleado(NumeroDeFilaSeleccionada)
            Me.VistaEmpleadosPuestosTableAdapter.Fill(Me.VistaEmpleadosPuestosDataSet1.VistaEmpleadosPuestos)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtBuscar.Visible = True
        txtBuscar.Focus()
        txtBus.Visible = True
        txtBuscar.BackColor = Color.FromArgb(26, 25, 62)
        txtBus.BackColor = Color.FromArgb(26, 25, 62)
        btnBuscar.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub FrmEmpleado_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        txtBuscar.Visible = False
        txtBus.Visible = False
        btnBuscar.BackColor = Color.FromArgb(34, 33, 74)
    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        obj.consultaEmpleado(txtBuscar.Text, txtBuscar.Text, dgEmpleados)
    End Sub
End Class