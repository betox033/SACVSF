Public Class BsnMascota

    Dim daoMascota As New DaoMascota

    Function ValidarMascotaCliente(numCliente As Integer, nombreMascota As String)
        Return daoMascota.ValidarMascotaCliente(numCliente, nombreMascota)
    End Function

    Function GenerarIdFicha()
        Return daoMascota.GenerarIdFicha()
    End Function

    Sub EliminarMascota(idFicha As String)
        daoMascota.EliminarMascota(idFicha)
    End Sub

    Function InsertarMascota(mascota As Mascota)
        daoMascota.InsertarMascota(mascota)
        Return 0
    End Function

    Function ModificarMascota(mascota As Mascota)
        daoMascota.ModificarMascota(mascota)
        Return 0
    End Function

    Function GetMascotasCliente(num_cliente As Integer)
        Return daoMascota.GetMascotasCliente(num_cliente)
    End Function

    Function GetDatosMascota(idFicha As String)
        Return daoMascota.GetDatosMascota(idFicha)
    End Function

    Function ValidarMascota(idFicha As String)
        Return daoMascota.ValidarMascota(idFicha)
    End Function

    Function GetMascotasPor(criterio As String, valor As String)
        Return daoMascota.GetMascotasPor(criterio, valor)
    End Function

    Function GetMascotas()
        Return daoMascota.GetMascotas()
    End Function

    Function ValidarEliminarMascota(tabla As String, idFicha As String)
        Return daoMascota.ValidarEliminarMascota(tabla, idFicha)
    End Function

End Class
