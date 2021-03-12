Public Class FrmEditarCliente
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim frm As New CLIENTES
        frm.ClientesTableAdapter.UpdateQuery(txtnombre.Text, txtapellido.Text, Val(txttelefono.Text), txtdireccion.Text, Val(txtid.Text))
        frm.ClientesTableAdapter.Fill(frm.ClientesDataSet.Clientes)
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class