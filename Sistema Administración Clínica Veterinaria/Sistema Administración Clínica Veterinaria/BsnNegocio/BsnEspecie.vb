Public Class BsnEspecie

    Protected daoEspecie As New DaoEspecies

    Function IdentificarRazaNull(idEspecie As Integer)
        Return daoEspecie.IdentificarRazaNull(idEspecie)
    End Function

    Function GetEspecies()
        Return daoEspecie.GetEspecies()
    End Function

    Function GetDatosEspecie(idEspecie As Integer)
        Return daoEspecie.GetDatosEspecie(idEspecie)
    End Function

    Function GenerarIdEspecie()
        Return daoEspecie.GenerarIdEspecie()
    End Function

    Sub InsertarEspecie(especie As Especie)
        daoEspecie.InsertarEspecie(especie)
    End Sub

    Sub ModificarEspecie(especie As Especie)
        daoEspecie.ModificarEspecie(especie)
    End Sub

    Sub EliminarEspecie(idEspecie As Integer)
        daoEspecie.EliminarEspecie(idEspecie)
    End Sub

    Function ValidarEspecie(idEspecie As Integer)
        Return daoEspecie.ValidarEspecie(idEspecie)
    End Function

    Sub MigracionMasiva(idEspecieOriginal As Integer, idEspecieNueva As Integer)
        daoEspecie.MigracionMasiva(idEspecieOriginal, idEspecieNueva)
    End Sub
End Class
