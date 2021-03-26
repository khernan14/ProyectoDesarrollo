Public Class FrmUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaNombreCompletoEmpleadoDataSet1.VistaNombreEmpleadoPuesto' Puede moverla o quitarla según sea necesario.
        Me.VistaNombreEmpleadoPuestoTableAdapter.Fill(Me.VistaNombreCompletoEmpleadoDataSet1.VistaNombreEmpleadoPuesto)
        'TODO: esta línea de código carga datos en la tabla 'VistaNombreCompletoEmpleadoDataSet1.VistaNombreEmpleadoPuesto' Puede moverla o quitarla según sea necesario.
        Me.VistaNombreEmpleadoPuestoTableAdapter.Fill(Me.VistaNombreCompletoEmpleadoDataSet1.VistaNombreEmpleadoPuesto)
        'TODO: esta línea de código carga datos en la tabla 'VistaUsuariosDataSet1.VistaUsuarios' Puede moverla o quitarla según sea necesario.
        Me.VistaUsuariosTableAdapter.Fill(Me.VistaUsuariosDataSet1.VistaUsuarios)
        'TODO: esta línea de código carga datos en la tabla 'EmpleadosEUDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.EmpleadosEUDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'UsuariosDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.UsuariosDataSet1.Usuario)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (cmbEmpleadoID.Text = "" Or txtUsuario.Text = "" Or txtContrasenia.Text = "" Or txtEstado.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DateTime1 = New DateTimePicker()
            Me.UsuarioTableAdapter.InsertarUsuario(Val(cmbEmpleadoID.Text), txtUsuario.Text, txtContrasenia.Text, txtEstado.Text, DateTime1.Value)
            Me.VistaUsuariosTableAdapter.Fill(VistaUsuariosDataSet1.VistaUsuarios)
            limpiar()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (cmbEmpleadoID.Text = "" Or txtUsuario.Text = "" Or txtContrasenia.Text = "" Or txtEstado.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.UsuarioTableAdapter.ActualizarUsuarios(Val(cmbEmpleadoID.Text), txtUsuario.Text, txtContrasenia.Text, txtEstado.Text, DateTime1.Value, Val(txtid.Text))
            Me.VistaUsuariosTableAdapter.Fill(Me.VistaUsuariosDataSet1.VistaUsuarios)
            btnGuardar.Enabled = True
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgUsuarios.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgUsuarios.CurrentRow.Cells(0).Value

            Me.UsuarioTableAdapter.EliminarUsuario(NumeroDeFilaSeleccionada)
            Me.VistaUsuariosTableAdapter.Fill(Me.VistaUsuariosDataSet1.VistaUsuarios)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellDoubleClick
        Me.txtid.Text = dgUsuarios.CurrentRow.Cells(0).Value.ToString()
        Me.cmbEmpleadoID.Text = dgUsuarios.CurrentRow.Cells(1).Value.ToString()
        Me.txtUsuario.Text = dgUsuarios.CurrentRow.Cells(2).Value.ToString()
        Me.txtContrasenia.Text = dgUsuarios.CurrentRow.Cells(3).Value.ToString()
        Me.txtEstado.Text = dgUsuarios.CurrentRow.Cells(4).Value.ToString()
        btnGuardar.Enabled = False
    End Sub

    Private Sub limpiar()
        txtid.Clear()
        txtUsuario.Clear()
        txtContrasenia.Clear()
        txtEstado.Clear()
    End Sub

    Private Sub cmbEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEmpleadoID.KeyPress
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

    Private Sub cmbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpleado.SelectedIndexChanged
        For i = 0 To cmbEmpleado.SelectedIndex
            For j = 0 To cmbEmpleadoID.SelectedIndex
                If (cmbEmpleado.SelectedIndex = i) Then
                    cmbEmpleadoID.SelectedIndex = j
                End If
            Next
        Next
    End Sub
End Class