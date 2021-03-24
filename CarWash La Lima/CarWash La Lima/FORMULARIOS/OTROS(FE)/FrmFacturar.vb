Public Class FrmFacturar
    Dim impuesto, subTotal, total As Double
    Dim ultimo As Integer

    Private Sub FrmFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturaIDDataSet1.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.FacturaIDDataSet1.Factura)

        txtISV.Text = 0.15
        ultimo = cmbID.Items.Count - 1
        cmbID.SelectedIndex = ultimo

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
        Dim frm As FrmFacturas = New FrmFacturas
        DateTime2 = New DateTimePicker()
        impuesto = Val(cmbPrecio.Text) * 0.15
        subTotal = impuesto
        txtSubTotal.Text = subTotal
        total = Val(cmbPrecio.Text) + subTotal
        txtTotal.Text = total

        frm.FacturaTableAdapter.InsertFactura(DateTime2.Value, Val(txtSubTotal.Text), Val(txtISV.Text), Val(cmbIDUser.Text))
        frm.FacturaTableAdapter.Fill(frm.FacturaDataSet1.Factura)
        frm.DetalleFacturaTableAdapter.InsertDetalleFactura(Val(cmbID.Text), Val(cmbIDCliente.Text), Val(cmbIDServicio.Text), Val(cmbIDPago.Text))
        frm.DetalleFacturaTableAdapter.Fill(frm.DetalleFacturaDataSet1.DetalleFactura)

    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click

        Dim frm As FrmHistorialFactura = New FrmHistorialFactura
        Dim frm2 As FrmFacturas = New FrmFacturas
        DateTime2 = New DateTimePicker()

        frm.Facturas_HistoricosTableAdapter.InsertFacturasH(Val(cmbID.Text), DateTime2.Value, cmbCliente.Text,
                                                            cmbServicio.Text, cmbPrecio.Text, cmbVehiculo.Text, cmbUsuario.Text, cmbEncargadoServicio.Text,
                                                            cmbPago.Text, Val(txtISV.Text), Val(txtSubTotal.Text), Val(txtTotal.Text))
        frm.Facturas_HistoricosTableAdapter.Fill(frm.FacturaHDataSet1._Facturas_Historicos)

    End Sub

    Private Sub cmbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicio.SelectedIndexChanged

        For i = 0 To cmbServicio.SelectedIndex
            For j = 0 To cmbPrecio.SelectedIndex
                For k = 0 To cmbIDServicio.SelectedIndex
                    If (cmbServicio.SelectedIndex = i) Then
                        cmbPrecio.SelectedIndex = j
                        cmbIDServicio.SelectedIndex = k
                    End If
                Next
            Next
        Next

    End Sub

    Private Sub cmbCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSubTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubTotal.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        For i = 0 To cmbCliente.SelectedIndex
            For j = 0 To cmbIDCliente.SelectedIndex
                If (cmbCliente.SelectedIndex = i) Then
                    cmbIDCliente.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbEncargadoServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEncargadoServicio.SelectedIndexChanged
        For i = 0 To cmbEncargadoServicio.SelectedIndex
            For j = 0 To cmbIDEncargado.SelectedIndex
                If (cmbEncargadoServicio.SelectedIndex = i) Then
                    cmbIDEncargado.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPago.SelectedIndexChanged
        For i = 0 To cmbPago.SelectedIndex
            For j = 0 To cmbIDPago.SelectedIndex
                If (cmbPago.SelectedIndex = i) Then
                    cmbIDPago.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged
        For i = 0 To cmbUsuario.SelectedIndex
            For j = 0 To cmbIDUser.SelectedIndex
                If (cmbUsuario.SelectedIndex = i) Then
                    cmbIDUser.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub txtISV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISV.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class