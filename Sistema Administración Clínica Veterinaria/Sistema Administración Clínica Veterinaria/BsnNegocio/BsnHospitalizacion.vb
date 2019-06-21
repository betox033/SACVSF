Public Class BsnHospitalizacion

    Dim daoHosp As New DaoHospitalizacion

    Function GetHospFecha(fechaHoy As Date)
        Return daoHosp.GetHospFecha(fechaHoy)
    End Function

    Function GetHospMascota(idFicha As String)
        Return daoHosp.GetHospMascota(idFicha)
    End Function

    Function GetDatosHospitalizacion(numHosp As Integer)
        Return daoHosp.GetDatosHospitalizacion(numHosp)
    End Function

    Sub ModificarHospitalizacion(hosp As Hospitalizacion)
        daoHosp.ModificarHospitalizacion(hosp)
    End Sub

    Sub InsertarHospitalizacion(hosp As Hospitalizacion)
        daoHosp.InsertarHospitalizacion(hosp)
    End Sub

    Function GenerarNumHosp()
        Return daoHosp.GenerarNumHosp()
    End Function

    Function ValidarHospitalizacion(idHosp As Integer, tabla As String)
        Return daoHosp.ValidarPorCriterio(idHosp, tabla)
    End Function

    Sub EliminarHospFisico(idHosp As Integer)
        daoHosp.EliminarHospFisico(idHosp)
    End Sub

    Sub EliminarHospLogico(idHosp As Integer)
        daoHosp.EliminarHospLogico(idHosp)
    End Sub



End Class
