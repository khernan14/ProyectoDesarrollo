Public Class FrmModelosNv
    Private Sub FrmModelosNv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaMarcaModeloDataSet1.VistaMarcaModelo' Puede moverla o quitarla según sea necesario.
        Me.VistaMarcaModeloTableAdapter.Fill(Me.VistaMarcaModeloDataSet1.VistaMarcaModelo)

    End Sub

    Private Sub dgModelos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgModelos.CellDoubleClick
        Try
            Dim frm As FrmNuevoVehiculo = CType(Owner, FrmNuevoVehiculo)

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