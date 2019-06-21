Public Class BsnObservacion

    Dim daoObservacion As New DaoObservacion

    Function GenerarNumeroObservacion()
        Return daoObservacion.GenerarNumeroObservacion
    End Function

    Sub InsertarObservacion(observacion As Observacion)
        daoObservacion.InsertarObservacion(observacion)
    End Sub

    Sub ModificarObservacion(observacion As Observacion)
        daoObservacion.ModificarObservacion(observacion)
    End Sub

    Sub EliminarObservacion(numObservacion As Integer)
        daoObservacion.EliminarObservacion(numObservacion)
    End Sub


    Function GetObservaciones(idFicha As String)
        Return daoObservacion.GetObservaciones(idFicha)
    End Function

    Function GetDatosObservacion(numObservacion As Integer)
        Return daoObservacion.GetDatosObservacion(numObservacion)
    End Function

End Class
