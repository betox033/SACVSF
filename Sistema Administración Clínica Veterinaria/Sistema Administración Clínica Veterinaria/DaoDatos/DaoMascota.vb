Imports MySql.Data.MySqlClient

Public Class DaoMascota


    Protected conexion As New Conexion

    Function ValidarMascotaCliente(numCliente As Integer, nombreMascota As String)
        Dim numero As Integer = -1
        Dim sql As String
        sql = "select * from mascota where num_cliente = " & numCliente & " and nombre_mascota = '" & nombreMascota & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        Buffer = Comando.ExecuteReader
        buffer.Read()
        If Buffer.HasRows Then
            numero = buffer.GetInt32("id_ficha")
        End If
        conexion.CerrarConexion()
        Return numero
    End Function

    Function GenerarIdFicha()
        Dim numero As Integer
        Dim ssql As String
        Try
            ssql = "SELECT MAX(id_ficha) AS id_ficha FROM mascota"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            numero = buffer.GetInt16("id_ficha")
            numero = numero + 1
        Catch ex As Exception
            conexion.CerrarConexion()
        End Try
        conexion.CerrarConexion()
        Return numero
    End Function


    Sub EliminarMascota(idFicha As String)
        Dim ssql As String = "delete from mascota where id_ficha = '" & idFicha & "'"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        conexion.CerrarConexion()
    End Sub

    Function ValidarMascota(idFicha As String)
        Dim sql As String
        sql = "select * from mascota where id_ficha = '" & idFicha & "' and estado = 1"
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

    Function ValidarEliminarMascota(tabla As String, idFicha As String)
        Dim sql As String
        sql = "select * from " & tabla & " where id_ficha = '" & idFicha & "'"
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

    Function InsertarMascota(mascota As Mascota)

        Dim ssql = "insert into mascota(id_ficha,nombre_mascota,num_cliente,fecha_nac_mascota,id_raza,sexo
                   ,color,fecha_ingreso,estado,id_chip) values('" & mascota.IdFicha & "','" & mascota.NomMascota & "'," & mascota.IdCliente &
       ",'" & mascota.FechaNacimiento & "'," & mascota.IdRaza & ",'" & mascota.Sexo & "','" & mascota.Color &
       "','" & mascota.FechaIngreso & "',true,'" & mascota.IdChip & "')"
        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        MsgBox("La mascota ha sido agregada correctamente")
        conexion.CerrarConexion()
        Return 0
    End Function

    Function ModificarMascota(mascota As Mascota)
        Dim ssql = "update mascota set nombre_mascota = '" & mascota.NomMascota & "', num_cliente = " & mascota.IdCliente &
                   ", fecha_nac_mascota = '" & mascota.FechaNacimiento &
                   "',id_raza = " & mascota.IdRaza & ", sexo = '" & mascota.Sexo & "',color = '" & mascota.Color &
                   "',id_Chip = '" & mascota.IdChip & "',fecha_ingreso = '" & mascota.FechaIngreso & "' where id_ficha = '" & mascota.IdFicha & "'"

        Dim reader As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        reader = Comando.ExecuteReader
        MsgBox("La mascota ha sido modificada correctamente")
        conexion.CerrarConexion()
        Return 0
    End Function

    Function GetMascotasCliente(num_cliente As Integer)
        Dim sql As String
        sql = "select * from mascota where mascota.num_cliente = " & num_cliente
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaMascotas As New List(Of Mascota)
        While buffer.Read()
            Dim mascota As New Mascota
            mascota.IdFicha = buffer.GetInt32("id_ficha")
            mascota.NomMascota = buffer.GetString("nombre_mascota")
            listaMascotas.Add(mascota)
        End While
        conexion.CerrarConexion()
        Return listaMascotas
    End Function

    Function GetDatosMascota(idFicha As String)
        Dim mascota As New Mascota
        Try
            Dim sql As String = "select id_ficha,nombre_mascota,num_cliente," &
                                "date_format(fecha_nac_mascota,'%d/%m/%Y') as fecha_nac_mascota," &
                                "id_raza,sexo,color," &
                                "date_format(fecha_ingreso,'%d/%m/%Y') as fecha_ingreso," &
                                "estado,id_chip from mascota where id_ficha = '" & idFicha & "'"
            Dim buffer As MySqlDataReader
            Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
            conexion.AbrirConexion()
            buffer = Comando.ExecuteReader
            buffer.Read()
            mascota.IdFicha = buffer.GetString("id_ficha")
            mascota.NomMascota = buffer.GetString("nombre_mascota")
            mascota.IdCliente = buffer.GetInt32("num_cliente")
            mascota.FechaNacimiento = buffer.GetString("fecha_nac_mascota")
            mascota.IdRaza = buffer.GetInt32("id_raza")
            mascota.Sexo = buffer.GetChar("sexo")
            mascota.Color = buffer.GetString("color")
            mascota.FechaIngreso = buffer.GetString("fecha_ingreso")
            mascota.Status = buffer.GetBoolean("estado")
            mascota.IdChip = buffer.GetString("id_chip")
            conexion.CerrarConexion()

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try


        Return Mascota
    End Function

    Function GetMascotasPor(criterio, valor)
        Dim sql As String = "select id_ficha,nombre_mascota,num_cliente," &
                    "date_format(fecha_nac_mascota,'%d/%m/%Y') as fecha_nac_mascota," &
                    "id_raza,sexo,color," &
                    "date_format(fecha_ingreso,'%d/%m/%Y') as fecha_ingreso," &
                    "estado,id_chip from mascota where " & criterio & " = '" & valor & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaMascotas As New List(Of Mascota)
        While buffer.Read()
            Dim mascota As New Mascota
            mascota.IdFicha = buffer.GetString("id_ficha")
            mascota.NomMascota = buffer.GetString("nombre_mascota")
            mascota.IdCliente = buffer.GetInt32("num_cliente")
            mascota.FechaNacimiento = buffer.GetString("fecha_nac_mascota")
            mascota.IdRaza = buffer.GetInt32("id_raza")
            mascota.Sexo = buffer.GetChar("sexo")
            mascota.Color = buffer.GetString("color")
            mascota.FechaIngreso = buffer.GetString("fecha_ingreso")
            mascota.Status = buffer.GetBoolean("estado")
            mascota.IdChip = buffer.GetString("id_chip")
            listaMascotas.Add(mascota)
        End While
        conexion.CerrarConexion()
        Return listaMascotas
    End Function

    Function GetMascotas()
        Dim sql As String = "select id_ficha,nombre_mascota,num_cliente," &
            "date_format(fecha_nac_mascota,'%d/%m/%Y') as fecha_nac_mascota," &
            "id_raza,sexo,color," &
            "date_format(fecha_ingreso,'%d/%m/%Y') as fecha_ingreso," &
            "estado,id_chip from mascota"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim listaMascotas As New List(Of Mascota)
        While buffer.Read()
            Dim mascota As New Mascota
            mascota.IdFicha = buffer.GetString("id_ficha")
            mascota.NomMascota = buffer.GetString("nombre_mascota")
            mascota.IdCliente = buffer.GetInt32("num_cliente")
            mascota.FechaNacimiento = buffer.GetString("fecha_nac_mascota")
            mascota.IdRaza = buffer.GetInt32("id_raza")
            mascota.Sexo = buffer.GetChar("sexo")
            mascota.Color = buffer.GetString("color")
            mascota.FechaIngreso = buffer.GetString("fecha_ingreso")
            mascota.Status = buffer.GetBoolean("estado")
            mascota.IdChip = buffer.GetString("id_chip")
            listaMascotas.Add(mascota)
        End While
        conexion.CerrarConexion()
        Return listaMascotas
    End Function

End Class
