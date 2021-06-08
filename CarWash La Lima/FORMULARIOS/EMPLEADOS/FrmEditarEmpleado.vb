Public Class FrmEditarEmpleado
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim frm As New FrmEmpleado
        frm.EmpleadoTableAdapter.ActualizarEmpleado(txtnombre.Text, txtapellido.Text, Val(txttelefono.Text), Val(cmbPuestoID.Text), Val(txtid.Text))
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

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
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

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
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

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
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

    Private Sub cmbPuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPuestoID.KeyPress
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

    Private Sub cmbPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPuesto.SelectedIndexChanged
        For i = 0 To cmbPuesto.SelectedIndex
            For j = 0 To cmbPuestoID.SelectedIndex
                If (cmbPuesto.SelectedIndex = i) Then
                    cmbPuestoID.SelectedIndex = j
                End If
            Next
        Next
    End Sub
End Class