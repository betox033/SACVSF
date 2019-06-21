Imports MySql.Data.MySqlClient

Public Class DaoDatos

    Protected conexion As New Conexion

    Function ValidarPorNumero(tabla As String, criterio As String, valor As Integer)
        Dim sql As String = "select * from " & tabla & " where " & criterio & " = " & valor
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim encontrado As Integer = -1
        If buffer.HasRows() Then
            buffer.Read()
            encontrado = buffer.GetValue(0)
        End If
        conexion.CerrarConexion()
        Return encontrado
    End Function

    Function ValidarPorTexto(tabla As String, criterio As String, valor As String)
        Dim sql As String = "select * from " & tabla & " where " & criterio & " = '" & valor & "'"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(sql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        Dim encontrado As Integer = -1
        If buffer.HasRows() Then
            buffer.Read()
            encontrado = buffer.GetValue(0)
        End If
        conexion.CerrarConexion()
        Return encontrado
    End Function

    Function GenerarCodPDF()
        Dim numero As Integer = 0
        Dim ssql = "SELECT MAX(num_pdf) AS num_pdf FROM configuracion"
        Dim buffer As MySqlDataReader
        Dim Comando = New MySqlCommand(ssql, conexion.GetConexion)
        conexion.AbrirConexion()
        buffer = Comando.ExecuteReader
        buffer.Read()
        numero = buffer.GetInt32("num_pdf")
        numero = numero + 1
        conexion.CerrarConexion()
        Return numero
    End Function




End Class
