Imports MySql.Data.MySqlClient

Public Class DaoProductos

    Protected conexion As New Conexion

    Function GenerarCodProducto()
        Dim numero As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(cod_producto) AS cod_producto FROM producto"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            numero = buffer.GetInt16("cod_producto")
            numero = numero + 1
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return numero
    End Function

    Function GetDatosStock(codProducto As Integer)
        Dim sql As String = "select * from stock where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim stock As New Stock
        If buffer.HasRows Then
            stock.Codproducto = buffer.GetInt32("cod_producto")
            stock.CantTotal = buffer.GetDouble("cantidad_total")
            stock.CantActual = buffer.GetDouble("cantidad_actual")
            stock.NumFrascos = buffer.GetInt32("frascos")
        End If
        conexion.CerrarConexion()
        Return stock
    End Function

    Sub InsertarStock(stock As Stock)
        Dim ssql As String
        ssql = "insert into stock(cod_producto,frascos,cantidad_total,cantidad_actual) values(" & stock.Codproducto &
               "," & stock.NumFrascos & "," & stock.CantTotal & "," & stock.CantActual & ")"
        Dim comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim reader = comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarStock(stock As Stock)
        Dim ssql As String
        ssql = "update stock set frascos = " & stock.NumFrascos & ",cantidad_total = " & stock.CantTotal &
               ",cantidad_actual = " & stock.CantActual & " where cod_producto = " & stock.Codproducto
        Dim comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim reader = comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function ValidarStock(codProducto As Integer)
        Dim numero As Integer = -1
        Dim sql As String = "select * from stock where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        If buffer.HasRows() Then
            numero = buffer.GetInt32("cod_producto")
        End If
        conexion.CerrarConexion()
        Return numero
    End Function

    Function GetProductos(criterio As String)
        Dim sql As String = "select * from producto order by " & criterio
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaProductos As New List(Of Producto)
        While buffer.Read()
            Dim producto As New Producto
            producto.CodProducto = buffer.GetInt32("cod_producto")
            producto.NomProducto = buffer.GetString("nom_producto")
            producto.TipoProducto = buffer.GetChar("tipo_producto")
            producto.CodProveedor = buffer.GetInt32("cod_proveedor")
            producto.Precio = buffer.GetInt32("precio")
            producto.StockCritico = buffer.GetInt32("stock_critico")
            producto.Stock = buffer.GetInt32("stock")
            producto.Unidad = buffer.GetString("unidad")
            producto.Estado = buffer.GetString("estado")
            listaProductos.Add(producto)
        End While
        conexion.CerrarConexion()
        Return listaProductos
    End Function

    Function GetDatosProducto(codProducto As Integer)
        Dim sql As String = "select * from producto where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim producto As New Producto
        producto.CodProducto = buffer.GetInt32("cod_producto")
        producto.NomProducto = buffer.GetString("nom_producto")
        producto.TipoProducto = buffer.GetChar("tipo_producto")
        producto.CodProveedor = buffer.GetInt32("cod_proveedor")
        producto.Precio = buffer.GetInt32("precio")
        producto.StockCritico = buffer.GetInt32("stock_critico")
        producto.Stock = buffer.GetInt32("stock")
        producto.Unidad = buffer.GetString("unidad")
        producto.Estado = buffer.GetString("estado")
        conexion.CerrarConexion()
        Return producto
    End Function



    Function GetProductoTipo(tipo_producto As String)
        Dim sql As String = "select * from producto where tipo_producto = '" & tipo_producto & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaInsumos As New List(Of Producto)
        While buffer.Read()
            Dim producto As New Producto
            producto.CodProducto = buffer.GetInt32("cod_producto")
            producto.NomProducto = buffer.GetString("nom_producto")
            producto.TipoProducto = buffer.GetChar("tipo_producto")
            producto.CodProveedor = buffer.GetInt32("cod_proveedor")
            producto.Precio = buffer.GetInt32("precio")
            producto.StockCritico = buffer.GetInt32("stock_critico")
            producto.Stock = buffer.GetInt32("stock")
            producto.Unidad = buffer.GetString("unidad")
            producto.Estado = buffer.GetString("estado")
            listaInsumos.Add(producto)
        End While
        conexion.CerrarConexion()
        Return listaInsumos
    End Function

    Function EliminarProductoLogico(codProducto As Integer)
        Dim sql As String = "update producto set estado = 0 where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
        Return 0
    End Function

    Sub EliminarStockMl(codProducto As Integer)
        Dim sql As String = "delete from stock where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function EliminarProductoFisico(codProducto As Integer)
        Dim sql As String = "delete from producto where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
        Return 0
    End Function

    Sub ActualizarStock(codProducto As Integer, stock As Integer)
        Dim sql As String = "update producto set stock = " & stock & " where cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub InsertarProducto(producto As Producto)
        Dim ssql As String
        ssql = "insert into producto(cod_producto,nom_producto,tipo_producto,cod_proveedor,precio,stock_critico,
                        stock,unidad,estado) values(" & producto.CodProducto & ",'" & producto.NomProducto &
                        "','" & producto.TipoProducto & "'," & producto.CodProveedor & "," & producto.Precio &
                        "," & producto.StockCritico & "," & producto.Stock & ",'" & producto.Unidad & "',true)"
        Dim comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim reader = comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarProducto(producto As Producto)
        Dim ssql As String
        ssql = "update producto set nom_producto = '" & producto.NomProducto & "', tipo_producto = '" &
               producto.TipoProducto & "', cod_proveedor = " & producto.CodProveedor & ", precio = " &
               producto.Precio & ", stock_critico = " & producto.StockCritico & ",stock = " & producto.Stock &
               ", unidad = '" & producto.Unidad & "' where cod_producto = " & producto.CodProducto
        Dim comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim reader = comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub


End Class
