Public Class BsnCliente

    Dim daoCliente As New DaoClientes

    Function GenerarNumCliente()
        Return daoCliente.GenerarNumCliente()
    End Function

    Function GetClientesFiltro(filtro As String)
        Return daoCliente.GetClientesFiltro(filtro)
    End Function

    Function InsertarCliente(cliente As Cliente)
        daoCliente.InsertarCliente(cliente)
        Return 0
    End Function

    Function ModificarCliente(cliente As Cliente)
        daoCliente.ModificarCliente(cliente)
        Return 0
    End Function

    Function GetClientes()
        Return daoCliente.GetClientes()
    End Function

    Function ValidarPorCriterio(idCliente As Integer, tabla As String)
        Return daoCliente.ValidarPorCriterio(idCliente, tabla)
    End Function

    Function EliminarClienteFisico(idCliente As Integer)
        daoCliente.EliminarClienteFisico(idCliente)
        Return 0
    End Function

    Function EliminarClienteLogico(idCliente As Integer)
        daoCliente.EliminarClienteLogico(idCliente)
        Return 0
    End Function

    Function GetDatosCliente(idCliente As Integer)
        Return daoCliente.GetDatosCliente(idCliente)
    End Function

    Function GetDatosClientePor(criterio As String, valor As String)
        Return daoCliente.GetDatosClientePor(criterio, valor)
    End Function


End Class
