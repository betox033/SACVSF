Imports MySql.Data.MySqlClient

Public Class DaoDetHosp

    Protected conexion As New Conexion

    Sub InsertarDetalleHosp(detHosp As DetHosp)
        Dim ssql As String = ""
        ssql = "insert into hosp_producto(id_hosp,cod_producto,periodicidad,dosis,cantidad,precio) values(" & detHosp.IdHosp &
               "," & detHosp.CodProducto & "," & detHosp.Periodicidad & "," & detHosp.Dosis & "," & detHosp.Cantidad &
               "," & detHosp.Precio & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarDetalleHosp(detHosp As DetHosp)
        Dim ssql As String = ""
        ssql = "update hosp_producto set periodicidad = " & detHosp.Periodicidad & ",dosis= " & detHosp.Dosis &
               ",cantidad = " & detHosp.Cantidad & " ,precio = " & detHosp.Precio & " where id_hosp = " &
               detHosp.IdHosp & " and cod_producto = " & detHosp.CodProducto
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function ValidarDetalleHosp(detHosp As DetHosp)
        Dim sql As String = ""
        sql = "select * from hosp_producto where id_hosp = " & detHosp.IdHosp & " and cod_producto = " &
              detHosp.CodProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim encontrado As Boolean = False
        If buffer.HasRows Then
            encontrado = True
        End If
        conexion.CerrarConexion()
        Return encontrado
    End Function

    Sub EliminarDetalleHosp(detHosp As DetHosp)
        Dim ssql As String = ""
        ssql = "delete from hosp_producto where id_hosp = " & detHosp.IdHosp & " and cod_producto = " & detHosp.CodProducto
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetDetallesHosp(idHosp As Integer)
        Dim sql As String = ""
        sql = "select * from hosp_producto where id_hosp = " & idHosp
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaDetallesHosp As New List(Of DetHosp)
        While buffer.Read()
            Dim detHosp As New DetHosp
            detHosp.IdHosp = buffer.GetInt32("id_hosp")
            detHosp.CodProducto = buffer.GetInt32("cod_producto")
            detHosp.Periodicidad = buffer.GetInt32("periodicidad")
            detHosp.Dosis = buffer.GetDouble("dosis")
            detHosp.Cantidad = buffer.GetDouble("cantidad")
            detHosp.Precio = buffer.GetInt32("precio")
            listaDetallesHosp.Add(detHosp)
        End While
        conexion.CerrarConexion()
        Return listaDetallesHosp
    End Function

    Function GetDatosDetallesHosp(idHosp As Integer, codProducto As Integer)
        Dim sql As String = ""
        sql = "select * from hosp_producto where id_hosp = " & idHosp & " and cod_producto = " & codProducto
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim detHosp As New DetHosp
        detHosp.IdHosp = buffer.GetInt32("id_hosp")
        detHosp.CodProducto = buffer.GetInt32("cod_producto")
        detHosp.Periodicidad = buffer.GetInt32("periodicidad")
        detHosp.Dosis = buffer.GetDouble("dosis")
        detHosp.Cantidad = buffer.GetDouble("cantidad")
        detHosp.Precio = buffer.GetInt32("precio")
        conexion.CerrarConexion()
        Return detHosp
    End Function

End Class
