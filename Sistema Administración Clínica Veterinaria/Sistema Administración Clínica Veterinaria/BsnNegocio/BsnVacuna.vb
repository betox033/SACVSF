Public Class BsnVacuna

    Dim daoVacunas As New DaoVacunas

    Sub InsertarVacuna(vacuna As Vacuna)
        daoVacunas.InsertarVacuna(vacuna)
    End Sub

    Function GenerarNumVacuna()
        Return daoVacunas.GenerarNumVacuna
    End Function

    Function GetDatosVacuna(numVacuna As Integer)
        Return daoVacunas.GetDatosVacuna(numVacuna)
    End Function

    Function GetVacunas(idFicha As String)
        Return daoVacunas.GetVacunas(idFicha)
    End Function

    Function GetVacunasFecha(fecha As String)
        Return daoVacunas.GetVacunasFecha(fecha)
    End Function

    Sub EliminarVacuna(numVacuna As Integer)
        daoVacunas.EliminarVacuna(numVacuna)
    End Sub

    Sub ModificarVacuna(vacuna As Vacuna)
        daoVacunas.ModificarVacuna(vacuna)
    End Sub

    Sub ActualizarVacunaCorreoEnviado(numVacuna As Integer)
        daoVacunas.ActualizarVacunaCorreoEnviado(numVacuna)
    End Sub




End Class
