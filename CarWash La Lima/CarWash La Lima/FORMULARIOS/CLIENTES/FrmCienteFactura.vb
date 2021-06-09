Public Class FrmCienteFactura

    Dim obj As New Buscar
    Private Sub FrmEmpleadoFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtBuscar.Visible = True
        txtBuscar.Focus()
        txtBus.Visible = True
        txtBuscar.BackColor = Color.FromArgb(26, 25, 62)
        txtBus.BackColor = Color.FromArgb(26, 25, 62)
        btnBuscar.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        obj.consultaCliente(txtBuscar.Text, txtBuscar.Text, dgClientes)
    End Sub

    Private Sub dgClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellDoubleClick
        Try
            Dim frm As FrmFacturar = CType(Owner, FrmFacturar)

            frm.txtIDCliente.Text = dgClientes.CurrentRow.Cells(0).Value.ToString()
            frm.txtCliente.Text = dgClientes.CurrentRow.Cells(2).Value.ToString() + " " + dgClientes.CurrentRow.Cells(3).Value.ToString()
            frm.txtVehiculo.Text = dgClientes.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class