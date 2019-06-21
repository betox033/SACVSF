Imports MySql.Data.MySqlClient

Public Class DaoAtencion

    Protected conexion As New Conexion

    Function GetDatosAtencion(codAtencion As Integer)
        Dim sql As String = "select cod_atencion,id_ficha,num_veterinario," &
                            "date_format(fecha_atencion,'%d/%m/%Y') as fecha_atencion," &
                            "tipo_atencion,peso,altura,temperatura,descripcion,costo,estado,corr_env " &
                            "from atencion where cod_atencion = " & codAtencion
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim atencion As New Atencion
        atencion.CodAtencion = buffer.GetInt32("cod_atencion")
        atencion.IdFicha = buffer.GetString("id_ficha")
        atencion.NumVeterinario = buffer.GetInt32("num_veterinario")
        atencion.FechaAtencion = buffer.GetString("fecha_atencion")
        atencion.TipoAtencion = buffer.GetChar("tipo_atencion")
        atencion.Peso = buffer.GetString("peso")
        atencion.Altura = buffer.GetString("altura")
        atencion.Temperatura = buffer.GetString("temperatura")
        atencion.Descripcion = buffer.GetString("descripcion")
        atencion.Costo = buffer.GetInt32("costo")
        atencion.Estado = buffer.GetBoolean("estado")
        atencion.CorreoEnviado = buffer.GetBoolean("corr_env")
        conexion.CerrarConexion()
        Return atencion
    End Function

    Sub InsertarAtencion(atencion As Atencion)
        Dim ssql As String = "insert into atencion(cod_atencion,id_ficha,num_veterinario,fecha_atencion,tipo_atencion, " &
                   "peso,altura,temperatura,descripcion,costo,estado) values(" & atencion.CodAtencion & ",'" &
                   atencion.IdFicha & "'," & atencion.NumVeterinario & ",'" & atencion.FechaAtencion & "','" & atencion.TipoAtencion & "'," & atencion.Peso & "," & atencion.Altura & "," & atencion.Temperatura & ",'" & atencion.Descripcion & "'," & atencion.Costo & ",true)"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarAtencion(atencion As Atencion)
        Dim convertir As New Convertir
        Dim fechaAtencion As String = convertir.invertir_fecha(atencion.FechaAtencion)

        Dim ssql As String = "update atencion set id_ficha = '" & atencion.IdFicha & "',num_veterinario = " &
                             atencion.NumVeterinario & ",fecha_atencion = '" & atencion.FechaAtencion & "'," &
                             "tipo_atencion = '" & atencion.TipoAtencion & "',peso = " & atencion.Peso & "," &
                             "altura = " & atencion.Altura & ",temperatura = " & atencion.Temperatura & "," &
                             "descripcion = '" & atencion.Descripcion & "'" &
                             " where cod_atencion = " & atencion.CodAtencion
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub


    Sub EliminarAtencionFisico(codAtencion As Integer)
        Dim ssql As String = "delete from atencion where cod_atencion = " & codAtencion
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarAtencionLogico(codAtencion As Integer)
        Dim ssql As String = "update atencion set estado=0 where codAtencion = " & codAtencion
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetAtencionesFecha(fecha As String)
        Dim sql As String = "select cod_atencion,id_ficha,num_veterinario," &
                    "date_format(fecha_atencion,'%d/%m/%Y') as fecha_atencion," &
                    "tipo_atencion,peso,altura,temperatura,descripcion,costo,estado,corr_env " &
                    "from atencion where fecha_atencion = '" & fecha & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim lstAtencionesAgendadas As New List(Of Atencion)
        While buffer.Read()
            Dim atencion As New Atencion
            atencion.CodAtencion = buffer.GetInt32("cod_atencion")
            atencion.IdFicha = buffer.GetString("id_ficha")
            atencion.NumVeterinario = buffer.GetInt32("num_veterinario")
            atencion.FechaAtencion = buffer.GetString("fecha_atencion")
            atencion.TipoAtencion = buffer.GetChar("tipo_atencion")
            atencion.Peso = buffer.GetString("peso")
            atencion.Altura = buffer.GetString("altura")
            atencion.Temperatura = buffer.GetString("temperatura")
            atencion.Descripcion = buffer.GetString("descripcion")
            atencion.Costo = buffer.GetInt32("costo")
            atencion.Estado = buffer.GetBoolean("estado")
            atencion.CorreoEnviado = buffer.GetBoolean("corr_env")
            lstAtencionesAgendadas.Add(atencion)
        End While
        conexion.CerrarConexion()
        Return lstAtencionesAgendadas
    End Function

    Function GetAtencionesMascota(idFicha As String)
        Dim sql As String = "select cod_atencion,id_ficha,num_veterinario," &
            "date_format(fecha_atencion,'%Y/%m/%d') as fecha_atencion," &
            "tipo_atencion,peso,altura,temperatura,descripcion,costo,estado " &
            "from atencion where id_ficha = '" & idFicha & "' order by fecha_atencion asc"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim lstAtencionesAgendadas As New List(Of Atencion) : Dim convertir As New Convertir
        While buffer.Read()
            Dim atencion As New Atencion
            atencion.CodAtencion = buffer.GetInt32("cod_atencion")
            atencion.IdFicha = buffer.GetString("id_ficha")
            atencion.NumVeterinario = buffer.GetInt32("num_veterinario")
            atencion.FechaAtencion = buffer.GetString("fecha_atencion")
            atencion.FechaAtencion = convertir.dar_vuelta_fecha(atencion.FechaAtencion)
            atencion.TipoAtencion = buffer.GetChar("tipo_atencion")
            atencion.Peso = buffer.GetString("peso")
            atencion.Altura = buffer.GetString("altura")
            atencion.Temperatura = buffer.GetString("temperatura")
            atencion.Descripcion = buffer.GetString("descripcion")
            atencion.Costo = buffer.GetInt32("costo")
            atencion.Estado = buffer.GetBoolean("estado")
            lstAtencionesAgendadas.Add(atencion)
        End While
        conexion.CerrarConexion()
        Return lstAtencionesAgendadas
    End Function



    Function GenerarCodAtencion()
        Dim cod_atencion As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(cod_atencion) AS cod_atencion FROM atencion"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            cod_atencion = buffer.GetInt16("cod_atencion")
            cod_atencion = cod_atencion + 1
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return cod_atencion
    End Function

    Sub PerderAtenciones(fechaHoy As String)
        Dim ssql As String = "update atencion set tipo_atencion = 'P' where atencion.tipo_atencion = 'A' and " &
                             "atencion.fecha_atencion < '" & fechaHoy & "'"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ActualizarAtencionCorreoEnviado(codAtencion As Integer)
        Dim ssql As String = "update atencion set corr_env = true where cod_atencion = " & codAtencion
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub






End Class
