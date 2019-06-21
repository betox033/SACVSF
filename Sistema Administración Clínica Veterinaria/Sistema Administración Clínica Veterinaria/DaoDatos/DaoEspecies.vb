Imports MySql.Data.MySqlClient

Public Class DaoEspecies

    Protected conexion As New Conexion

    Function IdentificarRazaNull(idEspecie As Integer)
        Dim id_raza As Integer
        Dim ssql As String = "select min(id_raza) as id_raza from raza where id_especie = " & idEspecie
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader()
        buffer.Read()
        id_raza = buffer.GetInt32("id_raza")
        conexion.CerrarConexion()
        Return id_raza
    End Function

    Function GetEspecies()
        Dim sql As String
        sql = "select * from especie"
        Dim buffer As MySqlDataReader

        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaEspecies As New List(Of Especie)
        While buffer.Read()
            Dim especie As New Especie
            especie.IdEspecie = buffer.GetInt32("id_especie")
            especie.NomEspecie = buffer.GetString("nom_especie")
            especie.Estado = buffer.GetInt32("estado")
            listaEspecies.Add(especie)
        End While
        conexion.CerrarConexion()
        Return listaEspecies
    End Function

    Function GetDatosEspecie(idEspecie As Integer)
        Dim especie As New Especie()
        Dim sql As String
        sql = "SELECT * FROM especie where id_especie = " & idEspecie
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        especie.IdEspecie = buffer.GetInt32("id_especie")
        especie.NomEspecie = buffer.GetString("nom_especie")
        especie.Estado = buffer.GetInt32("estado")
        conexion.CerrarConexion()
        Return especie
    End Function

    Function GenerarIdEspecie()
        Dim numero As Integer = 0
        Try
            Dim ssql = "SELECT MAX(id_especie) AS id_especie FROM especie"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                numero = buffer.GetInt16("id_especie")
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

    Sub InsertarEspecie(especie As Especie)
        Dim ssql As String = ""
        ssql = "insert into especie(id_especie,nom_especie,estado) values(" & especie.IdEspecie & ",'" &
               especie.NomEspecie & "'," & especie.Estado & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarEspecie(especie As Especie)
        Dim ssql As String = ""
        ssql = "update especie set nom_especie = '" & especie.NomEspecie & "' where id_especie = " &
               especie.IdEspecie
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarEspecie(idEspecie As Integer)
        Dim ssql As String = ""
        ssql = "delete from especie where id_especie = " & idEspecie
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function ValidarEspecie(idEspecie As Integer)
        Dim listaRazas As New List(Of Raza) : Dim bsnRaza As New BsnRaza
        listaRazas = bsnRaza.GetRazas : Dim contador As Integer = 0
        Dim idAux As Integer = 0
        '//////validacion normal//////
        For Each raza As Raza In listaRazas
            If raza.IdEspecie = idEspecie And raza.Estado <> 3 Then
                contador = contador + 1
            End If
            If raza.IdEspecie = idEspecie And raza.Estado = 3 Then
                idAux = raza.IdRaza
                Dim hola As Boolean = True
            End If
        Next
        '//////validación para el N.D
        Dim listaMascotas As New List(Of Mascota) : Dim bsnMascota As New BsnMascota
        listaMascotas = bsnMascota.GetMascotas
        For Each mascota As Mascota In listaMascotas
            If mascota.IdRaza = idAux Then
                contador = contador + 1
            End If
        Next
        Return contador
    End Function

    Sub MigracionMasiva(idEspecieOriginal As Integer, idEspecieNueva As Integer)
        Dim ssql As String = ""
        ssql = "update raza set id_especie = " & idEspecieNueva & " where id_especie = " & idEspecieOriginal &
               " and estado <> 3"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub


End Class
