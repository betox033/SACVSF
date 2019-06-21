Imports MySql.Data.MySqlClient

Public Class DaoCosto

    Protected conexion As New Conexion

    Function GenerarIdCosto()
        Dim numero As Integer = 0
        Try
            Dim ssql = "SELECT MAX(id_costo) AS id_costo FROM atencion_costo"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                numero = buffer.GetInt16("id_costo")
                numero = numero + 1
            Else
                numero = 0
            End If
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return numero
    End Function

    Sub InsertarCosto(costo As Costo)
        Dim ssql As String = "insert into atencion_costo(id_costo,cod_atencion,descripcion,costo) values(" &
                             costo.IdCosto & "," & costo.CodAtencion & ",'" & costo.Descripcion & "'," &
                             costo.Costo & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetCostosAtencion(codAtencion As Integer)
        Dim sql As String
        sql = "select * from atencion_costo where cod_atencion = " & codAtencion
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaCostos As New List(Of Costo)
        While buffer.Read()
            Dim costo As New Costo
            costo.IdCosto = buffer.GetInt32("id_costo")
            costo.CodAtencion = buffer.GetInt32("cod_atencion")
            costo.Descripcion = buffer.GetString("descripcion")
            costo.Costo = buffer.GetInt32("costo")
            listaCostos.Add(costo)
        End While
        conexion.CerrarConexion()
        Return listaCostos
    End Function




End Class
