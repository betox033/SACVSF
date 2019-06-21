Imports MySql.Data.MySqlClient

Public Class DaoRazas

    Protected conexion As New Conexion()

    Function ValidarRaza(nomRaza As String, idEspecie As Integer)
        Dim sql As String : Dim num As Integer = -1
        sql = "select * from raza where id_Especie = " & idEspecie & " and nom_raza = '" & nomRaza & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        If buffer.HasRows Then
            num = buffer.GetInt32("id_raza")
        End If
        conexion.CerrarConexion()
        Return num
    End Function

    Function GetDatosRaza(idRaza As Integer)
        Dim raza As New Raza()
        Dim sql As String
        sql = "SELECT * FROM raza where id_raza = " & idRaza
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        raza.IdRaza = buffer.GetInt32("id_raza")
        raza.IdEspecie = buffer.GetInt32("id_especie")
        raza.NomRaza = buffer.GetString("nom_raza")
        raza.Estado = buffer.GetInt32("estado")
        conexion.CerrarConexion()
        Return raza
    End Function

    Function GetRazas()
        Dim sql As String
        sql = "select * from raza"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaRazas As New List(Of Raza)
        While buffer.Read()
            Dim raza As New Raza
            raza.IdRaza = buffer.GetInt32("id_raza")
            raza.IdEspecie = buffer.GetInt32("id_especie")
            raza.NomRaza = buffer.GetString("nom_raza")
            raza.Estado = buffer.GetInt32("estado")
            listaRazas.Add(raza)
        End While
        conexion.CerrarConexion()
        Return listaRazas
    End Function

    Function GetRazasOrderEspecie()
        Dim sql As String
        sql = "select * from raza,especie where raza.id_especie = especie.id_especie order by especie.nom_especie"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaRazas As New List(Of Raza)
        While buffer.Read()
            Dim raza As New Raza
            raza.IdRaza = buffer.GetInt32("id_raza")
            raza.IdEspecie = buffer.GetInt32("id_especie")
            raza.NomRaza = buffer.GetString("nom_raza")
            raza.Estado = buffer.GetInt32("estado")
            listaRazas.Add(raza)
        End While
        conexion.CerrarConexion()
        Return listaRazas
    End Function



    Function GenerarIdRaza()
        Dim numero As Integer = 0
        Try
            Dim ssql = "SELECT MAX(id_raza) AS id_raza FROM raza"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                numero = buffer.GetInt16("id_raza")
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

    Sub InsertarRaza(raza As Raza)
        Dim ssql As String = ""
        ssql = "insert into raza(id_raza,id_especie,nom_raza,estado) values (" & raza.IdRaza & "," &
               raza.IdEspecie & ",'" & raza.NomRaza & "'," & raza.Estado & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarRaza(raza As Raza)
        Dim ssql As String = ""
        ssql = "update raza set id_especie = " & raza.IdEspecie & ", nom_raza = '" & raza.NomRaza & "'," &
               "estado = " & raza.Estado & " where id_raza = " & raza.IdRaza
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarRazaConEspecie(idEspecie As Integer)
        Dim ssql As String = ""
        ssql = "delete from raza where id_especie = " & idEspecie
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function ValidarRazaconMascota(idRaza As Integer)
        Dim listaMascotas As New List(Of Mascota) : Dim bsnMascota As New BsnMascota
        listaMascotas = bsnMascota.GetMascotas
        Dim contador As Integer = 0
        For Each mascota As Mascota In listaMascotas
            If mascota.IdRaza = idRaza Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    Sub EliminarRaza(idRaza As Integer)
        Dim ssql As String = ""
        ssql = "delete from raza where id_raza = " & idRaza
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub MigracionMascotas(idRazaOriginal As Integer, idRazaNueva As Integer)
        Dim ssql As String = ""
        ssql = "update mascota set id_raza = " & idRazaNueva & " where id_raza = " & idRazaOriginal
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

End Class
