﻿Public Class FrmVehiculo
    Private Sub FrmVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VehiculosDataSet1.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.VehiculosDataSet1.Vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'VistaVehiculoSet1.VistaVehiculo' Puede moverla o quitarla según sea necesario.
        Me.VistaVehiculoTableAdapter.Fill(Me.VistaVehiculoSet1.VistaVehiculo)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim nuevo As FrmNuevoVehiculo = New FrmNuevoVehiculo
        nuevo.ShowDialog()
        Me.VistaVehiculoTableAdapter.Fill(Me.VistaVehiculoSet1.VistaVehiculo)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (dgVehiculos.SelectedRows.Count > 0) Then

            Dim frm As New FrmEditarVehiculo
            Dim frm2 As New FrmModelos
            frm.txtPlaca.Text = dgVehiculos.CurrentRow.Cells(0).Value.ToString()
            frm.txtModelo.Text = dgVehiculos.CurrentRow.Cells(1).Value.ToString()
            'frm.ModeloVehiculoBindingSource.DataSource = dgVehiculos.CurrentRow.Cells(2).Value.ToString()
            frm.txtAnio.Text = dgVehiculos.CurrentRow.Cells(2).Value.ToString()
            frm.txtMarca.Text = dgVehiculos.CurrentRow.Cells(3).Value.ToString()
            frm.ShowDialog()
        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.VehiculoTableAdapter.Fill(Me.VehiculosDataSet1.Vehiculo)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim NumeroDeFilaSeleccionada As String

        If dgVehiculos.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgVehiculos.CurrentRow.Cells(0).Value

            Me.VehiculoTableAdapter.DeleteVehiculo(NumeroDeFilaSeleccionada)
            Me.VistaVehiculoTableAdapter.Fill(Me.VistaVehiculoSet1.VistaVehiculo)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub dgVehiculos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVehiculos.CellDoubleClick
        Dim frm As FrmNuevoCliente = CType(Owner, FrmNuevoCliente)

        frm.txtPlaca.Text = dgVehiculos.CurrentRow.Cells(0).Value.ToString()
        Me.Close()
    End Sub

    Private Sub dgVehiculos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVehiculos.CellContentClick

    End Sub
End Class