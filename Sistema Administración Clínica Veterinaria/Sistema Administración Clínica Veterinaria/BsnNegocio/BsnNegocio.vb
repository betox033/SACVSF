Public Class BsnNegocio

    Dim daoDatos As New DaoDatos

    Function ValidarPorNumero(tabla As String, criterio As String, valor As Integer)
        Return daoDatos.ValidarPorNumero(tabla, criterio, valor)
    End Function

    Function ValidarPorTexto(tabla As String, criterio As String, valor As String)
        Return daoDatos.ValidarPorTexto(tabla, criterio, valor)
    End Function

    Function GetHostCorreo(correo As String)
        Dim host As String = ""
        Dim c As String = correo
        Dim i As Integer = c.IndexOf("@")
        host = c.Substring(i + 1, c.Length - (i + 1))
        'corroborar que esta bien escrito el correo
        Return host
    End Function

    Function GenerarNumPDF()
        Return daoDatos.GenerarCodPDF()
    End Function



End Class
