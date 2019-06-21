Imports MySql.Data.MySqlClient

Public Class DaoHospitalizacion

    Protected conexion As New Conexion

    Function GetHospFecha(fechaHoy As Date)
        Dim convertir As New Convertir
        Dim fecha As String = convertir.invertir_fecha(fechaHoy.Date)
        Dim sql As String = "select id_hosp,id_ficha,date_format(fecha_hosp,'%d/%m/%Y') as fecha_hosp," &
                            "date_format(fecha_salida,'%d/%m/%Y') as fecha_salida,descripcion,total,valor_consulta,estado from " &
                            "hospitalizacion where fecha_salida >= '" & fecha & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaHosp As New List(Of Hospitalizacion)
        While buffer.Read()
            Dim hosp As New Hospitalizacion
            hosp.IdHosp = buffer.GetInt32("id_hosp")
            hosp.IdFicha = buffer.GetString("id_ficha")
            hosp.FechaHosp = buffer.GetString("fecha_hosp")
            hosp.FechaSalida = buffer.GetString("fecha_salida")
            hosp.Descripcion = buffer.GetString("descripcion")
            hosp.Total = buffer.GetInt32("total")
            hosp.ValorConsulta = buffer.GetInt32("valor_consulta")
            hosp.Estado = buffer.GetBoolean("estado")
            listaHosp.Add(hosp)
        End While
        conexion.CerrarConexion()
        Return listaHosp
    End Function

    Function GetHospMascota(idFicha As String)
        Dim sql As String = "select id_hosp,id_ficha,date_format(fecha_hosp,'%d/%m/%Y') as fecha_hosp," &
                            "date_format(fecha_salida,'%d/%m/%Y') as fecha_salida,descripcion,total,valor_consulta,estado from " &
                            "hospitalizacion where id_ficha = '" & idFicha & "' order by id_ficha"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaHosp As New List(Of Hospitalizacion)
        While buffer.Read()
            Dim hosp As New Hospitalizacion
            hosp.IdHosp = buffer.GetInt32("id_hosp")
            hosp.IdFicha = buffer.GetString("id_ficha")
            hosp.FechaHosp = buffer.GetString("fecha_hosp")
            hosp.FechaSalida = buffer.GetString("fecha_salida")
            hosp.Descripcion = buffer.GetString("descripcion")
            hosp.Total = buffer.GetInt32("total")
            hosp.ValorConsulta = buffer.GetInt32("valor_consulta")
            hosp.Estado = buffer.GetBoolean("estado")
            listaHosp.Add(hosp)
        End While
        conexion.CerrarConexion()
        Return listaHosp
    End Function

    Function GetDatosHospitalizacion(numHosp As Integer)
        Dim sql As String = "select id_hosp,id_ficha,date_format(fecha_hosp,'%d-%m-%Y') as fecha_hosp," &
                    "date_format(fecha_salida,'%d-%m-%Y') as fecha_salida,descripcion,total,valor_consulta,estado from " &
                    "hospitalizacion where id_hosp = " & numHosp
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim hosp As New Hospitalizacion
        hosp.IdHosp = buffer.GetInt32("id_hosp")
        hosp.IdFicha = buffer.GetString("id_ficha")
        hosp.FechaHosp = buffer.GetString("fecha_hosp")
        hosp.FechaSalida = buffer.GetString("fecha_salida")
        hosp.Descripcion = buffer.GetString("descripcion")
        hosp.Total = buffer.GetInt32("total")
        hosp.ValorConsulta = buffer.GetInt32("valor_consulta")
        hosp.Estado = buffer.GetBoolean("estado")
        conexion.CerrarConexion()
        Return hosp
    End Function

    Sub ModificarHospitalizacion(hosp As Hospitalizacion)
        Dim convertir As New Convertir
        Dim fechaHosp As String = convertir.invertir_fecha(hosp.FechaHosp.Date)
        Dim fechaSalida As String = convertir.invertir_fecha(hosp.FechaSalida.Date)
        Dim ssql As String = ""
        ssql = "update hospitalizacion set id_ficha = '" & hosp.IdFicha & "',fecha_hosp = '" & fechaHosp &
               "',fecha_salida = '" & fechaSalida & "',descripcion = '" & hosp.Descripcion &
               "',total = " & hosp.Total & ",valor_consulta = " & hosp.ValorConsulta & " where id_hosp = " & hosp.IdHosp
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub InsertarHospitalizacion(hosp As Hospitalizacion)
        Dim convertir As New Convertir
        Dim fechaHosp As String = convertir.invertir_fecha(hosp.FechaHosp.Date)
        Dim fechaSalida As String = convertir.invertir_fecha(hosp.FechaSalida.Date)
        Dim ssql As String = ""
        ssql = "insert into hospitalizacion(id_hosp,id_ficha,fecha_hosp,fecha_salida,descripcion,total,valor_consulta) values (" &
               hosp.IdHosp & ",'" & hosp.IdFicha & "','" & fechaHosp & "','" & fechaSalida & "','" &
               hosp.Descripcion & "'," & hosp.Total & "," & hosp.ValorConsulta & ")"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GenerarNumHosp()
        Dim numero As Integer = 0
        Try
            Dim ssql = "SELECT MAX(id_hosp) AS id_hosp FROM hospitalizacion"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                numero = buffer.GetInt16("id_hosp")
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

    Function ValidarPorCriterio(idHosp As Integer, tabla As String)
        Dim sql As String = "select * from " & tabla & " where id_hosp = " & idHosp
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim encontrado As Boolean = False
        If buffer.HasRows() Then
            encontrado = True
        End If
        conexion.CerrarConexion()
        Return encontrado
    End Function

    Sub EliminarHospFisico(idHosp As Integer)
        Dim ssql As String = "delete from hospitalizacion where id_hosp = " & idHosp
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarHospLogico(idHosp As Integer)
        Dim ssql As String = "update hospitalizacion set estado = 0 where id_hosp=" & idHosp
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub


End Class
