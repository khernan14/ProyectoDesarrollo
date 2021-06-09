Imports System.Data.SqlClient
Imports Support

Public Class FrmUsuarios

    Dim obj As New Buscar

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
        permisos()
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub permisos()
        If ActiveUser.Puesto = Cargos.facturador Then
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (txtEmpleado.Text = "" Or txtUsuario.Text = "" Or txtContrasenia.Text = "" Or cmbEstado.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DateTime1 = New DateTimePicker()
            Me.UsuarioTableAdapter.InsertarUsuario(Val(txtEmpleadoID.Text), txtUsuario.Text, txtContrasenia.Text, cmbEstado.Text, DateTime1.Value)
            Me.VistaUsuariosTableAdapter.Fill(VistaUsuariosDataSet1.VistaUsuarios)
            limpiar()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (txtEmpleado.Text = "" Or txtUsuario.Text = "" Or txtContrasenia.Text = "" Or cmbEstado.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.UsuarioTableAdapter.ActualizarUsuarios(Val(txtid.Text), txtUsuario.Text, txtContrasenia.Text, cmbEstado.Text, DateTime1.Value, Val(txtid.Text))
            Me.VistaUsuariosTableAdapter.Fill(Me.VistaUsuariosDataSet1.VistaUsuarios)
            btnGuardar.Enabled = True
            limpiar()
            btnBuscarEmpleado.Enabled = True
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
        Me.txtEmpleado.Text = dgUsuarios.CurrentRow.Cells(1).Value.ToString()
        Me.txtUsuario.Text = dgUsuarios.CurrentRow.Cells(2).Value.ToString()
        Me.txtContrasenia.Text = dgUsuarios.CurrentRow.Cells(3).Value.ToString()
        Me.cmbEstado.Text = dgUsuarios.CurrentRow.Cells(4).Value.ToString()
        btnGuardar.Enabled = False
        btnBuscarEmpleado.Enabled = False
    End Sub

    Private Sub limpiar()
        txtEmpleado.Clear()
        txtid.Clear()
        txtUsuario.Clear()
        txtContrasenia.Clear()
        cmbEstado.Text = ""
    End Sub

    Private Sub cmbEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasenia.KeyPress
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

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        obj.consultaUsuario(txtBuscar.Text, dgUsuarios)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtBuscar.Visible = True
        txtBuscar.Focus()
        txtBus.Visible = True
        txtBuscar.BackColor = Color.FromArgb(26, 25, 62)
        txtBus.BackColor = Color.FromArgb(26, 25, 62)
        btnBuscar.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub FrmUsuarios_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        txtBuscar.Visible = False
        txtBus.Visible = False
        btnBuscar.BackColor = Color.FromArgb(34, 33, 74)
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Dim frm As New FrmEmpleadoUsuario
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
End Class