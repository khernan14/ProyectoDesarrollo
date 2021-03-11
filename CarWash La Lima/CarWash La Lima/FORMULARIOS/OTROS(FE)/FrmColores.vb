Public Class FrmColores
    Private Sub FrmColores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ColorVDataSet1.ColorVehiculo' Puede moverla o quitarla según sea necesario.
        Me.ColorVehiculoTableAdapter.Fill(Me.ColorVDataSet1.ColorVehiculo)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If (txtDescripcion.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.ColorVehiculoTableAdapter.InsertarColor(txtDescripcion.Text)
            Me.ColorVehiculoTableAdapter.Fill(Me.ColorVDataSet1.ColorVehiculo)
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim NumeroDeFilaSeleccionada As Integer

        If dgColores.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgColores.CurrentRow.Cells(0).Value

            Me.ColorVehiculoTableAdapter.BorrarColor(NumeroDeFilaSeleccionada)
            Me.ColorVehiculoTableAdapter.Fill(Me.ColorVDataSet1.ColorVehiculo)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (txtDescripcion.Text = "") Then
            MessageBox.Show("Por favor, debe dar doble click sobre la fila a editar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.ColorVehiculoTableAdapter.ActualizarColor(txtDescripcion.Text, Val(txtid.Text))
            Me.ColorVehiculoTableAdapter.Fill(Me.ColorVDataSet1.ColorVehiculo)
            btnGuardar.Enabled = True
            limpiar()
        End If
    End Sub

    Private Sub dgColores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgColores.CellDoubleClick
        Me.txtid.Text = dgColores.CurrentRow.Cells(0).Value.ToString()
        Me.txtDescripcion.Text = dgColores.CurrentRow.Cells(1).Value.ToString()
        btnGuardar.Enabled = False
    End Sub

    '-----------------------------------------------------------------------------'
    Private Sub limpiar()
        txtid.Clear()
        txtDescripcion.Clear()
    End Sub
End Class