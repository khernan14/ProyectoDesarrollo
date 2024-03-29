﻿Imports Support

Public Class FrmModelos
    Private Sub FrmModelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaMarcaModeloDataSet1.VistaMarcaModelo' Puede moverla o quitarla según sea necesario.
        Me.VistaMarcaModeloTableAdapter.Fill(Me.VistaMarcaModeloDataSet1.VistaMarcaModelo)
        'TODO: esta línea de código carga datos en la tabla 'ModelosVDataSet1.ModeloVehiculo' Puede moverla o quitarla según sea necesario.
        Me.ModeloVehiculoTableAdapter.Fill(Me.ModelosVDataSet1.ModeloVehiculo)
        'TODO: esta línea de código carga datos en la tabla 'MarcasDataSet1.MarcasVehiculos' Puede moverla o quitarla según sea necesario.
        Me.MarcasVehiculosTableAdapter.Fill(Me.MarcasDataSet1.MarcasVehiculos)
        permisos()
        cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub permisos()
        If ActiveUser.Puesto = Cargos.facturador Then
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (txtModelo.Text = "" Or txtAnio.Text = "" Or cmbMarcaID.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.ModeloVehiculoTableAdapter.InsertarModelo(Val(cmbMarcaID.Text), txtModelo.Text, Val(txtAnio.Text))
            Me.VistaMarcaModeloTableAdapter.Fill(Me.VistaMarcaModeloDataSet1.VistaMarcaModelo)
            limpiar()
        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (txtModelo.Text = "" Or txtAnio.Text = "" Or cmbMarcaID.Text = "") Then
            MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.ModeloVehiculoTableAdapter.ActualizarModelo(Val(cmbMarcaID.Text), txtModelo.Text, Val(txtAnio.Text), Val(txtid.Text))
            Me.VistaMarcaModeloTableAdapter.Fill(Me.VistaMarcaModeloDataSet1.VistaMarcaModelo)
            btnGuardar.Enabled = True
            limpiar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If dgModelos.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgModelos.CurrentRow.Cells(0).Value

            Me.ModeloVehiculoTableAdapter.EliminarModelo(NumeroDeFilaSeleccionada)
            Me.VistaMarcaModeloTableAdapter.Fill(Me.VistaMarcaModeloDataSet1.VistaMarcaModelo)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgModelos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgModelos.CellDoubleClick
        Me.txtid.Text = dgModelos.CurrentRow.Cells(0).Value.ToString()
        Me.cmbMarcaID.Text = dgModelos.CurrentRow.Cells(1).Value.ToString()
        Me.txtModelo.Text = dgModelos.CurrentRow.Cells(2).Value.ToString()
        Me.txtAnio.Text = dgModelos.CurrentRow.Cells(3).Value.ToString()
        btnGuardar.Enabled = False
    End Sub

    Private Sub limpiar()
        txtid.Clear()
        txtModelo.Clear()
        txtModelo.Clear()
        txtAnio.Clear()
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarcaID.SelectedIndexChanged

    End Sub

    Private Sub txtAnio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Por favor, este campo solo acepta numeros", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
        For i = 0 To cmbMarca.SelectedIndex
            For j = 0 To cmbMarcaID.SelectedIndex
                If (cmbMarca.SelectedIndex = i) Then
                    cmbMarcaID.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub dgModelos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgModelos.CellContentClick
        Try
            Dim frm As FrmEditarVehiculo = CType(Owner, FrmEditarVehiculo)

            frm.txtModeloID.Text = dgModelos.CurrentRow.Cells(0).Value.ToString()
            frm.txtModelo.Text = dgModelos.CurrentRow.Cells(2).Value.ToString()
            frm.txtAnio.Text = dgModelos.CurrentRow.Cells(3).Value.ToString()
            frm.txtMarca.Text = dgModelos.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class