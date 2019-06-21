Imports MySql.Data.MySqlClient

Public Class DaoProveedores

    Protected conexion As New Conexion

    Sub InsertarProveedor(proveedor As Proveedor)
        Dim sql As String = "insert into proveedor(cod_proveedor,nom_proveedor,fono_proveedor,dir_proveedor,estado)" &
                            "values (" & proveedor.IdProveedor & ",'" & proveedor.NomProveedor & "','" &
                            proveedor.FonoProveedor & "','" & proveedor.DirProveedor & "'," & proveedor.Estado & ")"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarProveedor(proveedor As Proveedor)
        Dim sql As String = "update proveedor set nom_proveedor = '" & proveedor.NomProveedor & "',fono_proveedor = '" &
                            proveedor.FonoProveedor & "',dir_proveedor = ' " & proveedor.DirProveedor & "' where " &
                            "cod_proveedor = " & proveedor.IdProveedor
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetProveedores(criterio As String)
        Dim sql As String = "select * from proveedor order by " & criterio
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaProveedores As New List(Of Proveedor)
        While buffer.Read()
            Dim proveedor As New Proveedor
            proveedor.IdProveedor = buffer.GetInt32("cod_proveedor")
            proveedor.NomProveedor = buffer.GetString("nom_proveedor")
            proveedor.FonoProveedor = buffer.GetString("fono_proveedor")
            proveedor.DirProveedor = buffer.GetString("dir_proveedor")
            proveedor.Estado = buffer.GetBoolean("estado")
            listaProveedores.Add(proveedor)
        End While
        conexion.CerrarConexion()
        Return listaProveedores
    End Function

    Function GetDatosProveedor(idProveedor As Integer)
        Dim sql As String = "select * from proveedor where cod_proveedor = " & idProveedor
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim proveedor As New Proveedor
        proveedor.IdProveedor = buffer.GetInt32("cod_proveedor")
        proveedor.NomProveedor = buffer.GetString("nom_proveedor")
        proveedor.FonoProveedor = buffer.GetString("fono_proveedor")
        proveedor.DirProveedor = buffer.GetString("dir_proveedor")
        proveedor.Estado = buffer.GetBoolean("estado")
        conexion.CerrarConexion()
        Return proveedor
    End Function

    Function GenerarCodProveedor()
        Dim cod_proveedor As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(cod_proveedor) AS cod_proveedor FROM proveedor"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                cod_proveedor = buffer.GetInt16("cod_proveedor")
                cod_proveedor = cod_proveedor + 1
            End If
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return cod_proveedor
    End Function

    Sub EliminarProveedorLogico(codProveedor As Integer)
        Dim sql As String = "update proveedor set estado = 0 where cod_proveedor = " & codProveedor
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarProveedorFisico(codProveedor As Integer)
        Dim sql As String = "delete from proveedor where cod_proveedor = " & codProveedor
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

End Class
