Public Class FrmTipo
    Private Sub FrmTipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TipoDataSet1.TipoVehiculo' Puede moverla o quitarla según sea necesario.
        Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.TipoVehiculoTableAdapter.InsertarTipo(txtDescripcion.Text)
        Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.TipoVehiculoTableAdapter.ActualizarTipoV(txtDescripcion.Text, Val(txtid.Text))
        Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgTipoV.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgTipoV.CurrentRow.Cells(0).Value

            Me.TipoVehiculoTableAdapter.EliminarTipoV(NumeroDeFilaSeleccionada)
            Me.TipoVehiculoTableAdapter.Fill(Me.TipoDataSet1.TipoVehiculo)

        Else
            MessageBox.Show("Selecciona una fila")
        End If
    End Sub

    Private Sub dgEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTipoV.CellDoubleClick
        Me.txtid.Text = dgTipoV.CurrentRow.Cells(0).Value.ToString()
        Me.txtDescripcion.Text = dgTipoV.CurrentRow.Cells(1).Value.ToString()
    End Sub
End Class