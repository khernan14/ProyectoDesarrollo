Imports System.Data.SqlClient
Imports Support

Public Class CLIENTES

    Dim obj As New Buscar

    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClientesDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)
        permisos()
    End Sub

    Private Sub permisos()
        If ActiveUser.Puesto = Cargos.facturador Then
            btnEliminar.Enabled = False
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'dgClientes.Rows.Add(1, "Kevin Daniel", "Hernandez Martinez", 95183510, "Colonia Montecarlo, Choluteca Honduras", "Toyota"
        SurroundingSub()
        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)
    End Sub

    Private Sub SurroundingSub()
        Dim nuevo As FrmNuevoCliente = New FrmNuevoCliente()
        nuevo.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (dgClientes.SelectedRows.Count > 0) Then
            Dim frm As New FrmEditarCliente
            frm.txtid.Text = dgClientes.CurrentRow.Cells(0).Value.ToString()
            frm.txtnombre.Text = dgClientes.CurrentRow.Cells(2).Value.ToString()
            frm.txtapellido.Text = dgClientes.CurrentRow.Cells(3).Value.ToString()
            frm.txttelefono.Text = dgClientes.CurrentRow.Cells(4).Value.ToString()
            frm.txtdireccion.Text = dgClientes.CurrentRow.Cells(5).Value.ToString()
            frm.ShowDialog()
        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim NumeroDeFilaSeleccionada As Integer

        If dgClientes.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = dgClientes.CurrentRow.Cells(0).Value

            Me.ClientesTableAdapter.DeleteQuery(NumeroDeFilaSeleccionada)
            Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)

        Else
            MessageBox.Show("Por favor, Seleccione una fila", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub dgClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellDoubleClick
        Dim frm As FrmFacturar = CType(Owner, FrmFacturar)

        frm.txtIDCliente.Text = dgClientes.CurrentRow.Cells(0).Value.ToString()
        frm.txtCliente.Text = dgClientes.CurrentRow.Cells(2).Value.ToString() + " " + dgClientes.CurrentRow.Cells(3).Value.ToString()
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtBuscar.Visible = True
        txtBuscar.Focus()
        txtBus.Visible = True
        txtBuscar.BackColor = Color.FromArgb(26, 25, 62)
        txtBus.BackColor = Color.FromArgb(26, 25, 62)
        btnBuscar.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub CLIENTES_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        txtBuscar.Visible = False
        txtBus.Visible = False
        btnBuscar.BackColor = Color.FromArgb(34, 33, 74)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        obj.consultaCliente(txtBuscar.Text, txtBuscar.Text, dgClientes)
    End Sub
End Class