Imports MySql.Data.MySqlClient

Public Class DaoAjuste

    Protected conexion As New Conexion

    Sub InsertarAjuste(ajuste As Ajuste)
        Dim ssql As String = ""
        ssql = "insert into ajuste_inventario(cod_producto,fecha_hora,tipo_ajuste,cantidad) values(" & ajuste.Codproducto &
               ",'" & ajuste.FechaHora & "','" & ajuste.TipoAjuste & "'," & ajuste.Cantidad & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub
End Class
