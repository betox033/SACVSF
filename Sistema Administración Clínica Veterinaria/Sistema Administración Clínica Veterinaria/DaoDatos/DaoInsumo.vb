Imports MySql.Data.MySqlClient

Public Class DaoInsumo

    Protected conexion As New Conexion

    Sub InsertarInsumo(insumo As Insumo)
        Dim ssql As String = "insert into atencion_producto(cod_atencion,cod_producto,cantidad,precio) values (" &
                             insumo.CodAtencion & "," & insumo.CodProducto & "," & insumo.Cantidad & "," &
                             insumo.Precio & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

End Class
