Imports MySql.Data.MySqlClient

Public Class DaoVeterinario

    Protected conexion As New Conexion

    Sub InsertarVeterinario(vet As Veterinario)
        Dim ssql As String = "insert into veterinario(num_veterinario,rut_veterinario,nom_veterinario,fono,estado) value (" &
        vet.NumVeterinario & ",'" & vet.RutVeterinario & "','" & vet.NomVeterinario & "','" & vet.FonoVeterinario & "'," & vet.Estado & ")"
        Dim comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim reader = comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarVeterinario(vet As Veterinario)
        Dim ssql As String = "update veterinario set rut_veterinario = '" & vet.RutVeterinario &
                             "', nom_veterinario = '" & vet.NomVeterinario & "', fono = '" & vet.NomVeterinario &
                             "' where num_veterinario = " & vet.NumVeterinario
        Dim comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        Dim reader = comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GenerarNumVeterinario()
        Dim numero As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(num_veterinario) AS num_veterinario FROM veterinario"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            numero = buffer.GetInt16("num_veterinario")
            numero = numero + 1
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return numero
    End Function

    Function GetVeterinarios(criterio)
        Dim sql As String = "select * from veterinario order by " & criterio
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaVeterinarios As New List(Of Veterinario)
        While buffer.Read()
            Dim veterinario As New Veterinario
            veterinario.NumVeterinario = buffer.GetInt32("num_veterinario")
            veterinario.RutVeterinario = buffer.GetString("rut_veterinario")
            veterinario.NomVeterinario = buffer.GetString("nom_veterinario")
            veterinario.FonoVeterinario = buffer.GetString("fono")
            veterinario.Estado = buffer.GetBoolean("estado")
            listaVeterinarios.Add(veterinario)
        End While
        conexion.CerrarConexion()
        Return listaVeterinarios
    End Function

    Sub EliminarVeterinarioLogico(num_veterinario As Integer)
        Dim sql As String = "update veterinario set estado = 0 where num_veterinario = " & num_veterinario
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarVeterinarioFisico(num_veterinario As Integer)
        Dim sql As String = "delete from veterinario where num_veterinario = " & num_veterinario
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetDatosVeterinario(numVeterinario As Integer)
        Dim sql As String = "select * from veterinario where num_veterinario = " & numVeterinario
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim veterinario As New Veterinario
        veterinario.NumVeterinario = buffer.GetInt32("num_veterinario")
        veterinario.NomVeterinario = buffer.GetString("nom_veterinario")
        veterinario.RutVeterinario = buffer.GetString("rut_veterinario")
        veterinario.FonoVeterinario = buffer.GetString("fono")
        veterinario.Estado = buffer.GetBoolean("estado")
        conexion.CerrarConexion()
        Return veterinario
    End Function

End Class
