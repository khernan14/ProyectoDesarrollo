Imports Support

Public Class FrmMarcas
    Private Sub FrmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MarcasVDataSet1.MarcasVehiculos' Puede moverla o quitarla según sea necesario.
        Me.MarcasVehiculosTableAdapter.Fill(Me.MarcasVDataSet1.MarcasVehiculos)
        permisos()
    End Sub
    Private Sub permisos()
        If ActiveUser.Puesto = Cargos.facturador Then
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (txtMarca.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.MarcasVehiculosTableAdapter.InsertarMarca(txtMarca.Text)
            Me.MarcasVehiculosTableAdapter.Fill(Me.MarcasVDataSet1.MarcasVehiculos)
            limpiar()
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (txtMarca.Text = "") Then
            MessageBox.Show("Por favor, debe dar doble click sobre la fila a editar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.MarcasVehiculosTableAdapter.ActualizarMarcaV(txtMarca.Text, Val(txtid.Text))
            Me.MarcasVehiculosTableAdapter.Fill(Me.MarcasVDataSet1.MarcasVehiculos)
            btnGuardar.Enabled = True
            limpiar()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgMarcas.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgMarcas.CurrentRow.Cells(0).Value

            Me.MarcasVehiculosTableAdapter.EliminarMarca(NumeroDeFilaSeleccionada)
            Me.MarcasVehiculosTableAdapter.Fill(Me.MarcasVDataSet1.MarcasVehiculos)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub dgMarcas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMarcas.CellDoubleClick
        Me.txtid.Text = dgMarcas.CurrentRow.Cells(0).Value.ToString()
        Me.txtMarca.Text = dgMarcas.CurrentRow.Cells(1).Value.ToString()
        btnGuardar.Enabled = False
    End Sub

    '-------------------------------------------------------------------------------------'
    Private Sub limpiar()
        txtid.Clear()
        txtMarca.Clear()
    End Sub

    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
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