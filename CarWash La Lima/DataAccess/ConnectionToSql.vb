
Imports System.Data.SqlClient
'CONEXION A SQL
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()
        connectionString = "Data Source=LAPTOP-A12HMMNR\SQLEXPRESS01;Initial Catalog=CarWashLaLima;Integrated Security=True"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
