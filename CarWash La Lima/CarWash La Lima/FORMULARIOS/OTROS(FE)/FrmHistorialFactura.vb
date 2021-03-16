Public Class FrmHistorialFactura
    Private Sub FrmEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturaHistoricosDataSet1._Facturas_Historicos' Puede moverla o quitarla según sea necesario.
        Me.Facturas_HistoricosTableAdapter.Fill(Me.FacturaHistoricosDataSet1._Facturas_Historicos)

    End Sub
End Class