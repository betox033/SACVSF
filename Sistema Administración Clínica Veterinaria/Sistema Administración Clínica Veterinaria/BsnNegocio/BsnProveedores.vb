Public Class BsnProveedores

    Dim daoProveedores As New DaoProveedores

    Sub InsertarProveedor(proveedor As Proveedor)
        daoProveedores.InsertarProveedor(proveedor)
    End Sub

    Sub ModificarProveedor(proveedor As Proveedor)
        daoProveedores.ModificarProveedor(proveedor)
    End Sub

    Function GetProveedores(criterio As String)
        Return daoProveedores.GetProveedores(criterio)
    End Function

    Function GetDatosProveedor(idProveedor As Integer)
        Return daoProveedores.GetDatosProveedor(idProveedor)
    End Function

    Sub EliminarProveedorLogico(codProveedor As Integer)
        daoProveedores.EliminarProveedorLogico(codProveedor)
    End Sub

    Sub EliminarProveedorFisico(codProveedor As Integer)
        daoProveedores.EliminarProveedorFisico(codProveedor)
    End Sub

    Function GenerarCodProveedor()
        Return daoProveedores.GenerarCodProveedor
    End Function


End Class
