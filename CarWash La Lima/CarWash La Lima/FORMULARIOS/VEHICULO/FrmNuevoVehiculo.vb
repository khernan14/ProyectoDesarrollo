Public Class FrmNuevoVehiculo
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim frm As FrmVehiculo = New FrmVehiculo

        frm.VehiculoTableAdapter.InsertarVehiculo(txtPlaca.Text, Val(cmbModeloID.Text), Val(cmbTipoVID.Text), Val(cmbColorID.Text))
        frm.VehiculoTableAdapter.Fill(frm.VehiculosDataSet1.Vehiculo)
        Me.Close()

    End Sub

    Private Sub FrmNuevoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VistaModelo1.ModeloEnCNV' Puede moverla o quitarla según sea necesario.
        Me.ModeloEnCNVTableAdapter.Fill(Me.VistaModelo1.ModeloEnCNV)
        'TODO: esta línea de código carga datos en la tabla 'TipoVehiculoDataSet1.TipoVehiculo' Puede moverla o quitarla según sea necesario.
        Me.TipoVehiculoTableAdapter.Fill(Me.TipoVehiculoDataSet1.TipoVehiculo)
        'TODO: esta línea de código carga datos en la tabla 'ColorDataSet1.ColorVehiculo' Puede moverla o quitarla según sea necesario.
        Me.ColorVehiculoTableAdapter.Fill(Me.ColorDataSet1.ColorVehiculo)
        'TODO: esta línea de código carga datos en la tabla 'MarcaDataSet1.MarcasVehiculos' Puede moverla o quitarla según sea necesario.
        Me.MarcasVehiculosTableAdapter.Fill(Me.MarcaDataSet1.MarcasVehiculos)
        'TODO: esta línea de código carga datos en la tabla 'ModeloDataSet1.ModeloVehiculo' Puede moverla o quitarla según sea necesario.
        Me.ModeloVehiculoTableAdapter.Fill(Me.ModeloDataSet1.ModeloVehiculo)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ModeloVehiculoTableAdapter.FillBy(Me.ModeloDataSet1.ModeloVehiculo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub cmbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModelo.SelectedIndexChanged
        For i = 0 To cmbModelo.SelectedIndex
            For j = 0 To cmbModeloID.SelectedIndex
                If (cmbModelo.SelectedIndex = i) Then
                    cmbModeloID.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
        For i = 0 To cmbMarca.SelectedIndex
            For j = 0 To cmbMarcaID.SelectedIndex
                If (cmbMarca.SelectedIndex = i) Then
                    cmbMarcaID.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged
        For i = 0 To cmbColor.SelectedIndex
            For j = 0 To cmbColorID.SelectedIndex
                If (cmbColor.SelectedIndex = i) Then
                    cmbColorID.SelectedIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub cmbTipoV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoV.SelectedIndexChanged
        For i = 0 To cmbTipoV.SelectedIndex
            For j = 0 To cmbTipoVID.SelectedIndex
                If (cmbTipoV.SelectedIndex = i) Then
                    cmbTipoVID.SelectedIndex = j
                End If
            Next
        Next
    End Sub
End Class