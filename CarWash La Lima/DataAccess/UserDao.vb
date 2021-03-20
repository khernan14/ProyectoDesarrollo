
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
                command.CommandText = "SELECT * FROM Usuario WHERE Usuario = @user and Contraseña = @password"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@password", password)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function
End Class
