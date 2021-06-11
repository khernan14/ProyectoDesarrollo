
Imports System.Data
Imports System.Data.SqlClient
Imports Support

Public Class UserDao
    Inherits ConnectionToSql

    Public Function Login(user As String, password As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT a.UsuarioID, a.Usuario, a.Contraseña, b.NombreEmpleado As Nombre, b.ApellidoEmpleado As Apellido,
                                        c.DescripcionPuesto As Puesto
                                        FROM [dbo].[Usuario] a join [dbo].[Empleado] b
                                        on
                                        a.EmpleadoID = b.EmpleadoID join [dbo].[Puesto] c
                                        on
                                        b.PuestoId = c.PuestoID 
                                        WHERE a.Usuario = @user COLLATE SQL_Latin1_General_CP1_CS_AS and a.Contraseña = @password COLLATE SQL_Latin1_General_CP1_CS_AS"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@password", password)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.Usuario = reader.GetString(1)
                        ActiveUser.NombreEmpleado = reader.GetString(3)
                        ActiveUser.ApellidoEmpleado = reader.GetString(4)
                        ActiveUser.Puesto = reader.GetString(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function existsUser(id As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT *
                                        FROM [dbo].[Usuario]
                                        WHERE Usuario = @user"
                command.Parameters.AddWithValue("@user", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Sub CargoAdmin()
        If ActiveUser.Puesto = Cargos.facturador Then
            'Code
        End If
    End Sub
End Class
