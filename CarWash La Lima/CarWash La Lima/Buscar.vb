
Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Buscar
    Public cnn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Sub New()
        Try
            cnn = New SqlConnection("Data Source=LAPTOP-A12HMMNR\SQLEXPRESS01;Initial Catalog=CarWashLaLima;Integrated Security=True")
            cnn.Open()
        Catch ex As Exception
            MessageBox.Show("Error en la conexion", ex.ToString)
        End Try
    End Sub

    Sub consultaCliente(ByVal nombre As String, ByVal apellido As String, ByVal dgClientes As DataGridView)

        Try
            adaptador = New SqlDataAdapter("Select * From Clientes Where NombreCliente like '" & "%" + nombre + "%" & "' or ApellidoCliente like '" & "%" + apellido + "%" & "'", cnn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgClientes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta", ex.ToString)
        End Try

    End Sub

    Sub consultaClienteComboBox(ByVal nombre As String, ByVal apellido As String, ByVal cmbClientes As ComboBox)

        Try
            adaptador = New SqlDataAdapter("Select * From Clientes Where NombreCliente like '" & "%" + nombre + "%" & "' or ApellidoCliente like '" & "%" + apellido + "%" & "'", cnn)
            dt = New DataTable
            adaptador.Fill(dt)
            cmbClientes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta", ex.ToString)
        End Try

    End Sub

    ' Buscar Empleados
    Sub consultaEmpleado(ByVal nombre As String, ByVal apellido As String, ByVal dgEmpleados As DataGridView)

        Try
            adaptador = New SqlDataAdapter("Select * From Empleado Where NombreEmpleado like '" & "%" + nombre + "%" & "' or ApellidoEmpleado like '" & "%" + apellido + "%" & "'", cnn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgEmpleados.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta", ex.ToString)
        End Try

    End Sub

    ' Buscar Usuarios
    Sub consultaUsuario(ByVal nombre As String, ByVal dgEmpleados As DataGridView)

        Try
            adaptador = New SqlDataAdapter("Select *
                                            From [dbo].[Usuario] a join [dbo].[Empleado] b
                                            on
                                            a.EmpleadoID = b.EmpleadoID
                                            where b.NombreEmpleado like '" & "%" + nombre + "%" & "'", cnn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgEmpleados.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al realizar la consulta", ex.ToString)
        End Try

    End Sub

End Class
