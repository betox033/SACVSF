Public Class BsnInsumo

    Dim daoInsumo As New DaoInsumo

    Sub InsertarInsumo(insumo As Insumo)
        daoInsumo.InsertarInsumo(insumo)
    End Sub

End Class
