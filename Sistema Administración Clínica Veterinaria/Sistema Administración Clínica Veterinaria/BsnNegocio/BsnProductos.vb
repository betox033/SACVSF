Public Class BsnProductos

    Dim daoProductos As New DaoProductos

    Sub EliminarStockMl(codProducto As Integer)
        daoProductos.EliminarStockMl(codProducto)
    End Sub

    Sub InsertarProducto(producto As Producto)
        daoProductos.InsertarProducto(producto)
    End Sub

    Function GetDatosStock(codProducto As Integer)
        Return daoProductos.GetDatosStock(codProducto)
    End Function

    Sub InsertarStock(stock As Stock)
        daoProductos.InsertarStock(stock)
    End Sub

    Sub ModificarStock(stock As Stock)
        daoProductos.ModificarStock(stock)
    End Sub

    Function ValidarStock(codProducto As Integer)
        Return daoProductos.ValidarStock(codProducto)
    End Function

    Sub ModificarProducto(producto As Producto)
        daoProductos.ModificarProducto(producto)
    End Sub

    Function GenerarCodProducto()
        Return daoProductos.GenerarCodProducto()
    End Function

    Function GetProductos(criterio As String)
        Return daoProductos.GetProductos(criterio)
    End Function

    Function GetDatosProducto(codProducto As Integer)
        Return daoProductos.GetDatosProducto(codProducto)
    End Function

    Function GetProductoTipo(tipo_producto As String)
        Return daoProductos.GetProductoTipo(tipo_producto)
    End Function


    Function EliminarProductoLogico(codProducto As Integer)
        daoProductos.EliminarProductoLogico(codProducto)
        Return 0
    End Function

    Function EliminarProductoFisico(codProducto As Integer)
        daoProductos.EliminarProductoFisico(codProducto)
        Return 0
    End Function

    Sub ActualizarProducto(codProducto As Integer, stock As Integer)
        daoProductos.ActualizarStock(codProducto, stock)
    End Sub

End Class
