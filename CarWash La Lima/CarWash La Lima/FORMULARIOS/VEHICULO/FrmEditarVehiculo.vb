Public Class FrmEditarVehiculo
    Private Sub FrmEditarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MarcasEditarDataSet1.MarcasVehiculos' Puede moverla o quitarla según sea necesario.
        Me.MarcasVehiculosTableAdapter.Fill(Me.MarcasEditarDataSet1.MarcasVehiculos)
        'TODO: esta línea de código carga datos en la tabla 'TipoEditorDataSet1.TipoVehiculo' Puede moverla o quitarla según sea necesario.
        Me.TipoVehiculoTableAdapter.Fill(Me.TipoEditorDataSet1.TipoVehiculo)
        'TODO: esta línea de código carga datos en la tabla 'ColorEditarDataSet1.ColorVehiculo' Puede moverla o quitarla según sea necesario.
        Me.ColorVehiculoTableAdapter.Fill(Me.ColorEditarDataSet1.ColorVehiculo)
        'TODO: esta línea de código carga datos en la tabla 'ModeloEditarDataSet1.ModeloVehiculo' Puede moverla o quitarla según sea necesario.
        Me.ModeloVehiculoTableAdapter.Fill(Me.ModeloEditarDataSet1.ModeloVehiculo)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim frm As FrmVehiculo = New FrmVehiculo

        frm.VehiculoTableAdapter.ActualizarVehiculo(txtPlaca.Text, Val(cmbModelo.Text), Val(cmbTipoV.Text), Val(cmbColor.Text), txtPlaca.Text)
        frm.VehiculoTableAdapter.Fill(frm.VehiculosDataSet1.Vehiculo)
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class