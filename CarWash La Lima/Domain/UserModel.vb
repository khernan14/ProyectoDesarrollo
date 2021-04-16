
Imports DataAccess
Imports Support

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function Login(user As String, password As String) As Boolean
        Return userDao.Login(user, password)
    End Function

    Public Sub anyMethod(id As Integer)
        If ActiveUser.UsuarioID >= 1 Then
            If userDao.existsUser(ActiveUser.UsuarioID) = True Then
                'Code
            Else
                'Code
            End If
        End If
        If ActiveUser.UsuarioID = Nothing OrElse ActiveUser.UsuarioID = 0 Then
            'Code
        End If
    End Sub

    Public Sub CargoAdmin()
        If ActiveUser.Puesto = Cargos.facturador Then
            'Code
        End If
    End Sub
End Class
