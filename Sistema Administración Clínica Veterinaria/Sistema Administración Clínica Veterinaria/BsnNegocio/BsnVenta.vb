Public Class BsnVenta

    Dim daoVenta As New DaoVenta

    Function GenerarCodVenta()
        Return daoVenta.GenerarCodVenta
    End Function

    Sub InsertarVenta(venta As Venta)
        daoVenta.InsertarVenta(venta)
    End Sub

    Sub InsertarDetalleVenta(detVenta As DetalleVenta)
        daoVenta.InsertarDetalleVenta(detVenta)
    End Sub

End Class
