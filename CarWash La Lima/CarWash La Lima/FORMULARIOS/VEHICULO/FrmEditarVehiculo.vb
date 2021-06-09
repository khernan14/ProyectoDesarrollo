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

        Try
            If (txtPlaca.Text = "" Or txtModelo.Text = "" Or txtMarca.Text = "" Or txtAnio.Text = "") Then
                MessageBox.Show("Por favor, no puede dejar los campos vacios", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim frm As FrmVehiculo = New FrmVehiculo

                frm.VehiculoTableAdapter.ActualizarVehiculo(txtPlaca.Text, Val(txtModeloID.Text), Val(cmbTipoVID.Text), Val(cmbColorID.Text), txtPlaca.Text)
                frm.VehiculoTableAdapter.Fill(frm.VehiculosDataSet1.Vehiculo)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Private Sub cmbModelo_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    For i = 0 To cmbModelo.SelectedIndex
    '        For j = 0 To cmbModeloID.SelectedIndex
    '            If (cmbModelo.SelectedIndex = i) Then
    '                cmbModeloID.SelectedIndex = j
    '            End If
    '        Next
    '    Next
    'End Sub

    'Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    For i = 0 To cmbMarca.SelectedIndex
    '        For j = 0 To cmbMarcaID.SelectedIndex
    '            If (cmbMarca.SelectedIndex = i) Then
    '                cmbMarcaID.SelectedIndex = j
    '            End If
    '        Next
    '    Next
    'End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs)
        For i = 0 To cmbColor.SelectedIndex
            For j = 0 To cmbColorID.SelectedIndex
                If (cmbColor.SelectedIndex = i) Then
                    cmbColorID.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbTipoV_SelectedIndexChanged(sender As Object, e As EventArgs)
        For i = 0 To cmbTipoV.SelectedIndex
            For j = 0 To cmbTipoVID.SelectedIndex
                If (cmbTipoVID.SelectedIndex = i) Then
                    cmbTipoVID.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub btnBuscarModelo_Click(sender As Object, e As EventArgs) Handles btnBuscarModelo.Click
        Dim frm As New FrmModelos
        AddOwnedForm(frm) ' Esto es para indicar que este formularios sera propietario del formulario Clientes
        frm.ShowDialog()
    End Sub
End Class