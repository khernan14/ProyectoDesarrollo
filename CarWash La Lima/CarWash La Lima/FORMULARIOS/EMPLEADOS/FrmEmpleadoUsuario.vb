Public Class FrmEmpleadoUsuario

    Dim obj As New Buscar

    Private Sub FrmEmpleadoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaEmpleadosPuestoUsuario._VistaEmpleadosPuestoUsuario' Puede moverla o quitarla según sea necesario.
        Me.VistaEmpleadosPuestoUsuarioTableAdapter.Fill(Me.VistaEmpleadosPuestoUsuario._VistaEmpleadosPuestoUsuario)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtBuscar.Visible = True
        txtBuscar.Focus()
        txtBus.Visible = True
        txtBuscar.BackColor = Color.FromArgb(26, 25, 62)
        txtBus.BackColor = Color.FromArgb(26, 25, 62)
        btnBuscar.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub FrmEmpleado_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        txtBuscar.Visible = False
        txtBus.Visible = False
        btnBuscar.BackColor = Color.FromArgb(34, 33, 74)
    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        obj.consultaEmpleado(txtBuscar.Text, txtBuscar.Text, dgEmpleados)
    End Sub

    Private Sub dgEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpleados.CellDoubleClick
        Dim frm As FrmUsuarios = CType(Owner, FrmUsuarios)
        frm.txtEmpleado.Text = dgEmpleados.CurrentRow.Cells(1).Value.ToString() + " " + dgEmpleados.CurrentRow.Cells(2).Value.ToString()
        frm.txtEmpleadoID.Text = dgEmpleados.CurrentRow.Cells(0).Value.ToString()
        Me.Close()
    End Sub
End Class