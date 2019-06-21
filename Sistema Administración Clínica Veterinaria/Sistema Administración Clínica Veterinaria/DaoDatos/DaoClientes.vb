Imports MySql.Data.MySqlClient

Public Class DaoClientes

    Protected conexion As New Conexion()

    Function GenerarNumCliente()
        Dim numero As Integer
        Try
            Dim ssql As String = "SELECT MAX(num_cliente) AS num_cliente FROM cliente"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader : buffer.Read()
            If buffer.HasRows() Then
                numero = buffer.GetInt16("num_cliente") : numero = numero + 1
            Else
                numero = 0
            End If
            conexion.CerrarConexion()
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        Return numero
    End Function


    Function GetClientesFiltro(filtro As String)
        Dim sql As String
        sql = "select * from cliente where cliente.nombre like '" & filtro & "%'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaClientes As New List(Of Cliente)
        While buffer.Read()
            Dim cliente As New Cliente
            cliente.NumCliente = buffer.GetInt32("num_cliente")
            cliente.Nombre = buffer.GetString("nombre")
            listaClientes.Add(cliente)
        End While
        conexion.CerrarConexion()
        Return listaClientes
    End Function

    Function InsertarCliente(cliente As Cliente)
        Dim ssql = "insert into cliente(num_cliente,rut,nombre,direccion_cliente,fono_cliente,correo,estado) values (" &
                       cliente.NumCliente & ",'" & cliente.Rut & "','" & cliente.Nombre & "','" &
                       cliente.DireccionCliente & "','" & cliente.FonoCliente & "','" & cliente.Correo & "',true)"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        MsgBox("El cliente ha sido agregado correctamente.")
        conexion.CerrarConexion()
        Return 0
    End Function

    Function ModificarCliente(cliente As Cliente)
        Dim ssql = "update cliente set rut = '" & cliente.Rut & "', nombre = '" & cliente.Nombre &
                   "',direccion_cliente = '" & cliente.DireccionCliente & "', fono_cliente = '" &
                   cliente.FonoCliente & "',correo = '" & cliente.Correo & "' " &
                   "where num_cliente = " & cliente.NumCliente
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        MsgBox("El cliente ha sido modificado correctamente.")
        conexion.CerrarConexion()
        Return 0
    End Function

    Function GetClientes()
        Dim sql As String = "select * from cliente"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader

        Dim listaClientes As New List(Of Cliente)
        While buffer.Read()
            Dim cliente As New Cliente
            cliente.NumCliente = buffer.GetInt32("num_cliente")
            cliente.Rut = buffer.GetString("rut")
            cliente.Nombre = buffer.GetString("nombre")
            cliente.FonoCliente = buffer.GetString("fono_cliente")
            cliente.DireccionCliente = buffer.GetString("direccion_cliente")
            cliente.Correo = buffer.GetString("correo")
            cliente.Estado = buffer.GetBoolean("estado")
            listaClientes.Add(cliente)
        End While
        conexion.CerrarConexion()
        Return listaClientes
    End Function

    Function ValidarPorCriterio(idCliente As Integer, tabla As String)
        Dim sql As String = "select * from " & tabla & " where num_cliente = " & idCliente
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

    Function EliminarClienteFisico(idCliente As Integer)
        Dim sql As String = "delete from cliente where num_cliente = " & idCliente
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
        Return 0
    End Function

    Function EliminarClienteLogico(idCliente As Integer)
        Dim sql As String = "update cliente set estado = 0 where num_cliente = " & idCliente
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        conexion.CerrarConexion()
        Return 0
    End Function

    Function GetDatosCliente(idCliente As Integer)
        Dim cliente As New Cliente
        Dim sql As String = "select * from cliente where num_cliente = " & idCliente
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        cliente.NumCliente = buffer.GetInt32("num_cliente")
        cliente.Rut = buffer.GetString("rut")
        cliente.Nombre = buffer.GetString("nombre")
        cliente.DireccionCliente = buffer.GetString("direccion_cliente")
        cliente.FonoCliente = buffer.GetString("fono_cliente")
        cliente.Correo = buffer.GetString("correo")
        conexion.CerrarConexion()
        Return cliente
    End Function

    Function GetDatosClientePor(criterio As String, valor As String)
        Dim cliente As New Cliente
        Dim sql As String = "select * from cliente where " & criterio & "='" & valor & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        cliente.NumCliente = buffer.GetInt32("num_cliente")
        cliente.Rut = buffer.GetString("rut")
        cliente.Nombre = buffer.GetString("nombre")
        cliente.DireccionCliente = buffer.GetString("direccion_cliente")
        cliente.FonoCliente = buffer.GetString("fono_cliente")
        cliente.Correo = buffer.GetString("correo")
        conexion.CerrarConexion()
        Return cliente

    End Function



End Class
