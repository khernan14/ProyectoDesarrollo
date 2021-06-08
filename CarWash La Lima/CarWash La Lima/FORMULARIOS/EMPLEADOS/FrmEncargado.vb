Public Class FrmEncargado
    Private Sub FrmEncargado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaEncargadosServicioDataSet1.VistaNoRepeatDatos' Puede moverla o quitarla según sea necesario.
        Me.VistaNoRepeatDatosTableAdapter.Fill(Me.VistaEncargadosServicioDataSet1.VistaNoRepeatDatos)
        'TODO: esta línea de código carga datos en la tabla 'EncargadoServicioDataSet1.Empleado' Puede moverla o quitarla según sea necesario

    End Sub

    Private Sub dgEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpleados.CellDoubleClick
        Dim frm As FrmFacturar = CType(Owner, FrmFacturar)

        frm.txtIDEncargado.Text = dgEmpleados.CurrentRow.Cells(0).Value.ToString()
        frm.txtEncargadoServicio.Text = dgEmpleados.CurrentRow.Cells(1).Value.ToString() + " " + dgEmpleados.CurrentRow.Cells(2).Value.ToString()
        Me.Close()
    End Sub
End Class