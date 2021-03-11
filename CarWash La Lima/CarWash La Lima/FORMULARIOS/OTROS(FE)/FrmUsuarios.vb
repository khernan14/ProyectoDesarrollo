Public Class FrmUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EmpleadosEUDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.EmpleadosEUDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'UsuariosDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.UsuariosDataSet1.Usuario)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        DateTime1 = New DateTimePicker()
        Me.UsuarioTableAdapter.InsertarUsuario(Val(cmbEmpleado.Text), txtUsuario.Text, txtContrasenia.Text, txtEstado.Text, DateTime1.Value)
        Me.UsuarioTableAdapter.Fill(UsuariosDataSet1.Usuario)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Me.UsuarioTableAdapter.ActualizarUsuarios(Val(cmbEmpleado.Text), txtUsuario.Text, txtContrasenia.Text, txtEstado.Text, DateTime1.Value, Val(txtid.Text))
        Me.UsuarioTableAdapter.Fill(Me.UsuariosDataSet1.Usuario)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgUsuarios.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgUsuarios.CurrentRow.Cells(0).Value

            Me.UsuarioTableAdapter.EliminarUsuario(NumeroDeFilaSeleccionada)
            Me.UsuarioTableAdapter.Fill(Me.UsuariosDataSet1.Usuario)

        Else
            MessageBox.Show("Selecciona una fila")
        End If
    End Sub

    Private Sub dgUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellDoubleClick
        Me.txtid.Text = dgUsuarios.CurrentRow.Cells(0).Value.ToString()
        Me.cmbEmpleado.Text = dgUsuarios.CurrentRow.Cells(1).Value.ToString()
        Me.txtUsuario.Text = dgUsuarios.CurrentRow.Cells(2).Value.ToString()
        Me.txtContrasenia.Text = dgUsuarios.CurrentRow.Cells(3).Value.ToString()
        Me.txtEstado.Text = dgUsuarios.CurrentRow.Cells(4).Value.ToString()
    End Sub
End Class