Public Class FrmEditarEmpleado
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim frm As New FrmEmpleado
        frm.EmpleadoTableAdapter.ActualizarEmpleado(txtnombre.Text, txtapellido.Text, Val(txttelefono.Text), Val(cmbPuesto.Text), Val(txtid.Text))
        frm.EmpleadoTableAdapter.Fill(frm.EmpleadosDataSet1.Empleado)
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmEditarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Puesto2DataSet1.Puesto' Puede moverla o quitarla según sea necesario.
        Me.PuestoTableAdapter.Fill(Me.Puesto2DataSet1.Puesto)

    End Sub
End Class