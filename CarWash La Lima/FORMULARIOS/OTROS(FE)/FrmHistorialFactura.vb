Public Class FrmHistorialFactura
    Private Sub FrmEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturaHDataSet1._Facturas_Historicos' Puede moverla o quitarla según sea necesario.
        Me.Facturas_HistoricosTableAdapter.Fill(Me.FacturaHDataSet1._Facturas_Historicos)
        'TODO: esta línea de código carga datos en la tabla 'FacturaHDataSet1._Facturas_Historicos' Puede moverla o quitarla según sea necesario.
    End Sub
End Class