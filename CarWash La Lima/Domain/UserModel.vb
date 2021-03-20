
Imports DataAccess

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function Login(user As String, password As String) As Boolean
        Return userDao.Login(user, password)
    End Function
End Class
