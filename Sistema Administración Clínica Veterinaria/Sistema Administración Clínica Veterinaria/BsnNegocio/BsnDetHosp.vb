Public Class BsnDetHosp

    Dim daoDetHosp As New DaoDetHosp

    Sub InsertarDetalleHosp(detHosp As DetHosp)
        daoDetHosp.InsertarDetalleHosp(detHosp)
    End Sub

    Sub ModificarDetalleHosp(detHosp As DetHosp)
        daoDetHosp.ModificarDetalleHosp(detHosp)
    End Sub

    Function ValidarDetalleHosp(detHosp As DetHosp)
        Return daoDetHosp.ValidarDetalleHosp(detHosp)
    End Function

    Sub EliminarDetalleHosp(detHosp As DetHosp)
        daoDetHosp.EliminarDetalleHosp(detHosp)
    End Sub

    Function GetDetallesHosp(idHosp As Integer)
        Return daoDetHosp.GetDetallesHosp(idHosp)
    End Function

    Function GetDatosDetalleHosp(idHosp As Integer, codProducto As Integer)
        Return daoDetHosp.GetDatosDetallesHosp(idHosp, codProducto)
    End Function

End Class
