Imports MySql.Data.MySqlClient

Public Class DaoVenta

    Protected conexion As New Conexion

    Function GenerarCodVenta()
        Dim numero As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(cod_venta) AS cod_venta FROM venta"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            numero = buffer.GetInt32("cod_venta")
            numero = numero + 1
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return numero
    End Function

    Sub InsertarVenta(venta As Venta)
        Dim ssql = "insert into venta(cod_venta,num_cliente,fecha_venta,total) values(" & venta.CodVenta & "," &
                   venta.NumCliente & ",'" & venta.FechaVenta & "'," & venta.Total & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub InsertarDetalleVenta(detVenta As DetalleVenta)
        Dim ssql = "insert into detalle_venta(cod_venta,cod_producto,cantidad,precio_venta) values(" &
                   detVenta.CodVenta & "," & detVenta.CodProducto & "," & detVenta.Cantidad & "," &
                   detVenta.Precio & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub





End Class
