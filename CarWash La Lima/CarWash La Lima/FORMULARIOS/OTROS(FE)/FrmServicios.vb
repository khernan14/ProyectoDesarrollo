Public Class FrmServicios
    Private Sub FrmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosVDataSet1.Servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter1.Fill(Me.ServiciosVDataSet1.Servicio)
        'TODO: esta línea de código carga datos en la tabla 'CarWashLaLimaDataSet1.Servicio' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub limpiar()
        txtid.Clear()
        txtServicio.Clear()
        txtPrecio.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub dgMarcas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServicio.CellDoubleClick
        Me.txtid.Text = dgServicio.CurrentRow.Cells(0).Value.ToString()
        Me.txtServicio.Text = dgServicio.CurrentRow.Cells(1).Value.ToString()
        Me.txtPrecio.Text = dgServicio.CurrentRow.Cells(2).Value.ToString()
        btnGuardar.Enabled = False
    End Sub

End Class