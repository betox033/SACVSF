Imports MySql.Data.MySqlClient

Public Class DaoVacunas

    Protected conexion As New Conexion


    Sub InsertarVacuna(vacuna As Vacuna)
        Dim ssql As String = "insert into vacuna_mascota(num_vacuna,id_ficha,cod_producto,n_ordinal,dosis,fecha_vacuna," &
                             "fecha_prox_vacuna) values (" & vacuna.NumVacuna & ",'" & vacuna.IdFicha & "'," &
                             vacuna.Codproducto & "," & vacuna.NOrdinal & "," & vacuna.Dosis & ",'" &
                             vacuna.FechaVacuna & "','" & vacuna.FechaProxVacuna & "')"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarVacuna(vacuna As Vacuna)
        Dim ssql As String = "update vacuna_mascota set id_ficha = '" & vacuna.IdFicha & "',cod_producto = " &
                             vacuna.Codproducto & ",n_ordinal = " & vacuna.NOrdinal & ",dosis = " & vacuna.Dosis &
                             ",fecha_vacuna = '" & vacuna.FechaVacuna & "',fecha_prox_vacuna = '" &
                             vacuna.FechaProxVacuna & "' where num_vacuna = " & vacuna.NumVacuna
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetVacunas(idFicha As String)
        Dim ssql As String = "SELECT num_vacuna,id_ficha,cod_producto,n_ordinal,dosis," &
                     "date_format(fecha_vacuna,'%Y/%m/%d') as fecha_vacuna," &
                     "date_format(fecha_prox_vacuna,'%Y/%m/%d') as fecha_prox_vacuna,corr_env " &
                     "from vacuna_mascota where id_ficha = '" & idFicha & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaVacunas As New List(Of Vacuna)
        While buffer.Read()
            Dim vacuna As New Vacuna
            vacuna.NumVacuna = buffer.GetInt32("num_vacuna")
            vacuna.IdFicha = buffer.GetString("id_ficha")
            vacuna.Codproducto = buffer.GetInt32("cod_producto")
            vacuna.NOrdinal = buffer.GetInt32("n_ordinal")
            vacuna.Dosis = buffer.GetDouble("dosis")
            Dim convertir As New Convertir
            vacuna.FechaVacuna = convertir.dar_vuelta_fecha(buffer.GetString("fecha_vacuna"))
            vacuna.FechaProxVacuna = convertir.dar_vuelta_fecha(buffer.GetString("fecha_prox_vacuna"))
            vacuna.CorreoEnviado = buffer.GetBoolean("corr_env")
            listaVacunas.Add(vacuna)
        End While
        conexion.CerrarConexion()
        Return listaVacunas
    End Function

    Function GetVacunasFecha(fecha As String)
        Dim ssql As String = "SELECT num_vacuna,id_ficha,cod_producto,n_ordinal,dosis," &
             "date_format(fecha_vacuna,'%Y/%m/%d') as fecha_vacuna," &
             "date_format(fecha_prox_vacuna,'%Y/%m/%d') as fecha_prox_vacuna,corr_env " &
             "from vacuna_mascota where fecha_prox_vacuna = '" & fecha & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaVacunas As New List(Of Vacuna)
        While buffer.Read()
            Dim vacuna As New Vacuna
            vacuna.NumVacuna = buffer.GetInt32("num_vacuna")
            vacuna.IdFicha = buffer.GetString("id_ficha")
            vacuna.Codproducto = buffer.GetInt32("cod_producto")
            vacuna.NOrdinal = buffer.GetInt32("n_ordinal")
            vacuna.Dosis = buffer.GetDouble("dosis")
            Dim convertir As New Convertir
            vacuna.FechaVacuna = convertir.dar_vuelta_fecha(buffer.GetString("fecha_vacuna"))
            vacuna.FechaProxVacuna = convertir.dar_vuelta_fecha(buffer.GetString("fecha_prox_vacuna"))
            vacuna.CorreoEnviado = buffer.GetBoolean("corr_env")
            listaVacunas.Add(vacuna)
        End While
        conexion.CerrarConexion()
        Return listaVacunas
    End Function


    Function GetDatosVacuna(numVacuna As Integer)
        Dim ssql As String = "SELECT num_vacuna,id_ficha,cod_producto,n_ordinal,dosis," &
                             "date_format(fecha_vacuna,'%Y/%m/%d') as fecha_vacuna," &
                             "date_format(fecha_prox_vacuna,'%Y/%m/%d') as fecha_prox_vacuna " &
                             "from vacuna_mascota where num_vacuna = " & numVacuna
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim vacuna As New Vacuna
        buffer.Read()
        vacuna.NumVacuna = buffer.GetInt32("num_vacuna")
        vacuna.IdFicha = buffer.GetString("id_ficha")
        vacuna.Codproducto = buffer.GetInt32("cod_producto")
        vacuna.NOrdinal = buffer.GetInt32("n_ordinal")
        vacuna.Dosis = buffer.GetDouble("dosis")
        Dim convertir As New Convertir
        vacuna.FechaVacuna = convertir.dar_vuelta_fecha(buffer.GetString("fecha_vacuna"))
        vacuna.FechaProxVacuna = convertir.dar_vuelta_fecha(buffer.GetString("fecha_prox_vacuna"))
        conexion.CerrarConexion()
        Return vacuna
    End Function

    Function GenerarNumVacuna()
        Dim numVacuna As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(num_vacuna) AS num_vacuna FROM vacuna_mascota"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                numVacuna = buffer.GetInt32("num_vacuna")
                numVacuna = numVacuna + 1
            End If
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try

        Return numVacuna
    End Function

    Sub EliminarVacuna(numVacuna As Integer)
        Dim ssql As String = "delete from vacuna_mascota where num_vacuna = " & numVacuna
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ActualizarVacunaCorreoEnviado(numVacuna As Integer)
        Dim ssql As String = "update vacuna_mascota set corr_env = true where num_vacuna = " & numVacuna
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

End Class
