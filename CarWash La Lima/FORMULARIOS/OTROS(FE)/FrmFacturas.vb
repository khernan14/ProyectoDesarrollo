Public Class FrmFacturas
    Private Sub FrmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DetalleFacturaDataSet1.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.DetalleFacturaDataSet1.DetalleFactura)
        'TODO: esta línea de código carga datos en la tabla 'FacturaDataSet1.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.FacturaDataSet1.Factura)

    End Sub
End Class