Public Class FrmHistorialFactura
    Private Sub FrmEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturaHDataSet1._Facturas_Historicos' Puede moverla o quitarla según sea necesario.
        Me.Facturas_HistoricosTableAdapter1.Fill(Me.FacturaHDataSet1._Facturas_Historicos)
        'TODO: esta línea de código carga datos en la tabla 'VistaFacturasHDataSet1.VistaFacturasHistoricos' Puede moverla o quitarla según sea necesario.
        Me.VistaFacturasHistoricosTableAdapter1.Fill(Me.VistaFacturasHDataSet1.VistaFacturasHistoricos)
        'TODO: esta línea de código carga datos en la tabla 'VistaFacturasHistoricosDataSet1.VistaFacturasHistoricos' Puede moverla o quitarla según sea necesario.
        Me.VistaFacturasHistoricosTableAdapter.Fill(Me.VistaFacturasHistoricosDataSet1.VistaFacturasHistoricos)
        'TODO: esta línea de código carga datos en la tabla 'FacturaHistoricosDataSet1._Facturas_Historicos' Puede moverla o quitarla según sea necesario.
        Me.Facturas_HistoricosTableAdapter.Fill(Me.FacturaHistoricosDataSet1._Facturas_Historicos)

    End Sub
End Class