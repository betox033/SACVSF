Public Class BsnCosto

    Dim daoCosto As New DaoCosto

    Function GenerarIdCosto()
        Return daoCosto.GenerarIdCosto()
    End Function

    Sub InsertarCosto(costo As Costo)
        daoCosto.InsertarCosto(costo)
    End Sub

    Function GetCostosAtencion(codAtencion As Integer)
        Return daoCosto.GetCostosAtencion(codAtencion)
    End Function


End Class
