Public Class FrmServiciosFactura
    Private Sub dgServicio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServicio.CellDoubleClick
        Dim frm As FrmFacturar = CType(Owner, FrmFacturar)

        frm.txtIDServicio.Text = dgServicio.CurrentRow.Cells(0).Value.ToString()
        frm.txtServicio.Text = dgServicio.CurrentRow.Cells(1).Value.ToString()
        frm.txtPrecioServicio.Text = dgServicio.CurrentRow.Cells(2).Value.ToString()
        Me.Close()
    End Sub

    Private Sub FrmServiciosFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosVDataSet1.Servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.ServiciosVDataSet1.Servicio)

    End Sub

    Private Sub dgServicio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgServicio.CellContentClick

    End Sub
End Class