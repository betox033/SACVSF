Imports MySql.Data.MySqlClient

Public Class DaoObservacion

    Protected conexion As New Conexion

    Function GenerarNumeroObservacion()
        Dim numObservacion As Integer = 0
        Try
            Dim ssql As String = "SELECT MAX(num_observacion) AS num_observacion FROM observacion"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            If buffer.HasRows() Then
                numObservacion = buffer.GetInt32("num_observacion")
                numObservacion = numObservacion + 1
            End If
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return numObservacion
    End Function

    Sub InsertarObservacion(observacion As Observacion)
        Dim ssql As String = "insert into observacion(num_observacion,id_ficha,fecha_observacion,descripcion)" &
                             " values (" & observacion.NumObservacion & ",'" & observacion.IdFicha & "','" &
                             observacion.FechaObservacion & "','" & observacion.Descripcion & "')"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub ModificarObservacion(observacion As Observacion)
        Dim ssql As String = "update observacion set fecha_observacion = '" & observacion.FechaObservacion & "'," &
                             "descripcion = '" & observacion.Descripcion & "' " &
                             "where num_observacion = " & observacion.NumObservacion
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Sub EliminarObservacion(numObservacion As Integer)
        Dim ssql As String = "delete from observacion where num_observacion = " & numObservacion
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function GetObservaciones(idFicha As String)
        Dim sql As String
        sql = "select num_observacion,id_ficha,date_format(fecha_observacion,'%d/%m/%Y') as fecha_observacion," &
              "descripcion from observacion where id_ficha = '" & idFicha & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaObservaciones As New List(Of Observacion)
        While buffer.Read()
            Dim observacion As New Observacion
            observacion.NumObservacion = buffer.GetInt32("num_observacion")
            observacion.IdFicha = buffer.GetString("id_ficha")
            observacion.FechaObservacion = buffer.GetString("fecha_observacion")
            observacion.Descripcion = buffer.GetString("descripcion")
            listaObservaciones.Add(observacion)
        End While
        conexion.CerrarConexion()
        Return listaObservaciones
    End Function

    Function GetDatosObservacion(numObservacion As Integer)
        Dim sql As String = "select num_observacion,id_ficha, date_format(fecha_observacion,'%d/%m/%Y') as " &
                            "fecha_observacion,descripcion from observacion where num_observacion = " &
                            numObservacion
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        Dim observacion As New Observacion
        observacion.NumObservacion = buffer.GetInt32("num_observacion")
        observacion.IdFicha = buffer.GetString("id_ficha")
        observacion.FechaObservacion = buffer.GetString("fecha_observacion")
        observacion.Descripcion = buffer.GetString("descripcion")
        conexion.CerrarConexion()
        Return observacion
    End Function
End Class
