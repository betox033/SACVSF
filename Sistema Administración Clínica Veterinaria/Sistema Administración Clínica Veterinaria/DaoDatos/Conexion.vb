Imports MySql.Data.MySqlClient

Public Class Conexion

    Protected conexion As New MySqlConnection
    Protected StringConexion As String = "server=localhost;database=base_clinica;user id=root;password='12345';SslMode=0"

    Public Sub AbrirConexion()
        conexion.ConnectionString = StringConexion
        conexion.Open()
    End Sub

    Public Sub CerrarConexion()
        conexion.Close()
    End Sub

    Public Function GetConexion()
        conexion.ConnectionString = StringConexion
        Return conexion
    End Function

End Class
