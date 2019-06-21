Public Class BsnAtencion

    Dim daoAtencion As New DaoAtencion

    Function GetDatosAtencion(codAtencion As Integer)
        Return daoAtencion.GetDatosAtencion(codAtencion)
    End Function

    Sub InsertarAtencion(atencion As Atencion)
        daoAtencion.InsertarAtencion(atencion)
    End Sub

    Sub ModificarAtencion(atencion As Atencion)
        daoAtencion.ModificarAtencion(atencion)
    End Sub

    Function GetAtencionesFecha(fecha As String)
        Return daoAtencion.GetAtencionesFecha(fecha)
    End Function

    Sub EliminarAtencionFisico(codAtencion As Integer)
        daoAtencion.EliminarAtencionFisico(codAtencion)
    End Sub

    Sub EliminarAtencionLogico(codAtencion As Integer)
        daoAtencion.EliminarAtencionLogico(codAtencion)
    End Sub

    Function GenerarCodAtencion()
        Return daoAtencion.GenerarCodAtencion
    End Function

    Function GetAtencionesMascota(idFicha As String)
        Return daoAtencion.GetAtencionesMascota(idFicha)
    End Function

    Sub PerderAtenciones(fechaHoy As String)
        daoAtencion.PerderAtenciones(fechaHoy)
    End Sub

    Sub ActualizarAtencionCorreoEnviado(codAtencion As Integer)
        daoAtencion.ActualizarAtencionCorreoEnviado(codAtencion)
    End Sub

End Class
