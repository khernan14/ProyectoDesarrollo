
Imports System.Data.SqlClient
'CONEXION A SQL
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()
        connectionString = "Data Source=LAPTOP-5ILJ3V6O;Initial Catalog=CarWashLaLima;Integrated Security=True"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
