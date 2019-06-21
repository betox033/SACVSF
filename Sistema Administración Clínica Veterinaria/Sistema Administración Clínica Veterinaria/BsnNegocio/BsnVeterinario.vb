Public Class BsnVeterinario

    Dim daoVeterinario As New DaoVeterinario

    Sub InsertarVeterinario(vet As Veterinario)
        daoVeterinario.InsertarVeterinario(vet)
    End Sub

    Sub ModificarVeterinario(vet As Veterinario)
        daoVeterinario.ModificarVeterinario(vet)
    End Sub

    Function GenerarNumVeterinario()
        Return daoVeterinario.GenerarNumVeterinario()
    End Function

    Function GetVeterinarios(criterio As String)
        Return daoVeterinario.GetVeterinarios(criterio)
    End Function

    Sub EliminarVeterinarioLogico(num_veterinario As Integer)
        daoVeterinario.EliminarVeterinarioLogico(num_veterinario)
    End Sub

    Sub EliminarVeterinarioFisico(num_veterinario As Integer)
        daoVeterinario.EliminarVeterinarioFisico(num_veterinario)
    End Sub

    Function GetDatosVeterinario(numVeterinario As Integer)
        Return daoVeterinario.GetDatosVeterinario(numVeterinario)
    End Function


End Class
