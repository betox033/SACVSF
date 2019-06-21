Public Class BsnRaza

    Dim daoRaza As New DaoRazas

    Function ValidarRaza(nomRaza As String, idEspecie As Integer)
        Return daoRaza.ValidarRaza(nomRaza, idEspecie)
    End Function

    Function GetDatosRaza(idRaza As Integer)
        Return daoRaza.GetDatosRaza(idRaza)
    End Function

    Function GetRazas()
        Return daoRaza.GetRazas()
    End Function

    Function GetRazasOrderEspecie()
        Return daoRaza.GetRazasOrderEspecie()
    End Function

    Function GeneraridRaza()
        Return daoRaza.GenerarIdRaza()
    End Function

    Sub InsertarRaza(raza As Raza)
        daoRaza.InsertarRaza(raza)
    End Sub

    Sub ModificarRaza(raza As Raza)
        daoRaza.ModificarRaza(raza)
    End Sub

    Sub EliminarRazaConEspecie(idEspecie As Integer)
        daoRaza.EliminarRazaConEspecie(idEspecie)
    End Sub

    Function ValidarRazaConMascota(idRaza As Integer)
        Return daoRaza.ValidarRazaconMascota(idRaza)
    End Function

    Sub EliminarRaza(idRaza As Integer)
        daoRaza.EliminarRaza(idRaza)
    End Sub

    Sub MigracionMascotas(idRazaOriginal As Integer, idRazaNueva As Integer)
        daoRaza.MigracionMascotas(idRazaOriginal, idRazaNueva)
    End Sub

End Class
