Public Class FrmFacturar
    Dim impuesto, subTotal, total As Double

    Private Sub FrmFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtISV.Text = 0.15

        'TODO: esta línea de código carga datos en la tabla 'UsuarioDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter1.Fill(Me.UsuarioDataSet1.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'EncargadoServicioDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.EncargadoServicioDataSet1.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'UsuarioFacturaDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.UsuarioFacturaDataSet1.Usuario)
        'TODO: esta línea de código carga datos en la tabla 'FormaPagoDataSet1.Pago' Puede moverla o quitarla según sea necesario.
        Me.PagoTableAdapter.Fill(Me.FormaPagoDataSet1.Pago)
        'TODO: esta línea de código carga datos en la tabla 'ServiciosDataSet1.Servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.ServiciosDataSet1.Servicio)
        'TODO: esta línea de código carga datos en la tabla 'PlacaVDataSet1.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.PlacaVDataSet1.Vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'ClienteDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ClienteDataSet1.Clientes)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ClientesTableAdapter.FillBy(Me.ClienteDataSet1.Clientes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehiculo.SelectedIndexChanged

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.EmpleadoTableAdapter.FillBy(Me.EncargadoServicioDataSet1.Empleado)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        impuesto = Val(cmbPrecio.Text) * 0.15
        subTotal = impuesto
        txtSubTotal.Text = subTotal
        total = Val(cmbPrecio.Text) + subTotal
        txtTotal.Text = total
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click

        Dim frm As FrmHistorialFactura = New FrmHistorialFactura
        DateTime2 = New DateTimePicker()

        frm.VistaFacturasHistoricosTableAdapter1.InsertarFacturasH(Val(txtFactura.Text), DateTime2.Value, cmbCliente.Text, cmbServicio.Text,
                                                Val(cmbPrecio.Text), cmbVehiculo.Text, cmbUsuario.Text, cmbEncargadoServicio.Text, cmbPago.Text,
                                                Val(txtISV.Text), subTotal, Val(txtTotal.Text))
        frm.VistaFacturasHistoricosTableAdapter1.Fill(frm.VistaFacturasHDataSet1.VistaFacturasHistoricos)

    End Sub

    Private Sub cmbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicio.SelectedIndexChanged

        For i = 0 To cmbServicio.SelectedIndex
            For j = 0 To cmbPrecio.SelectedIndex
                If (cmbServicio.SelectedIndex = i) Then
                    cmbPrecio.SelectedIndex = j
                End If
            Next
        Next

    End Sub
End Class