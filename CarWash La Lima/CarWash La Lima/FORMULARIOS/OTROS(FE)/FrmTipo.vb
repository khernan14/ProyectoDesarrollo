Imports Support

Public Class FrmTipo
    Private Sub FrmTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TipoDataSet1.TipoVehiculo' Puede moverla o quitarla según sea necesario.
        Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)
        permisos()
    End Sub
    Private Sub permisos()
        If ActiveUser.Puesto = Cargos.facturador Then
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If (txtDescripcion.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.TipoVehiculoTableAdapter.InsertarTipo(txtDescripcion.Text)
            Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)
            limpiar()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (txtDescripcion.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.TipoVehiculoTableAdapter.ActualizarTipoV(txtDescripcion.Text, Val(txtid.Text))
            Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)
            btnGuardar.Enabled = True
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgTipoV.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgTipoV.CurrentRow.Cells(0).Value

            Me.TipoVehiculoTableAdapter.EliminarTipoV(NumeroDeFilaSeleccionada)
            Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTipoV.CellDoubleClick
        Me.txtid.Text = dgTipoV.CurrentRow.Cells(0).Value.ToString()
        Me.txtDescripcion.Text = dgTipoV.CurrentRow.Cells(1).Value.ToString()
        btnGuardar.Enabled = False
    End Sub

    Private Sub limpiar()
        txtid.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
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
End Class