Public Class Convertir

    Function convertir_dinero(ByVal dinero_numero As Int64)
        Dim resultado As String = ""
        Dim recibir As String = ""
        recibir = Convert.ToString(dinero_numero)
        Dim lg As Int32 = recibir.Length - 1
        Dim ct_punto As Int32 = 0
        While lg >= 0
            resultado = recibir.Chars(lg) & resultado
            ct_punto = ct_punto + 1

            If ct_punto = 3 And lg <> 0 Then
                resultado = "." & resultado
                ct_punto = 0
            End If
            lg = lg - 1
        End While
        resultado = "$" & resultado
        Return resultado
    End Function

    Function dinero_a_numero(dinero)
        Dim numero As Integer
        Dim din As String = dinero
        din = din.Replace(".", "")
        din = din.Replace("$", "")
        numero = Convert.ToInt32(din)
        Return numero
    End Function


    Function dar_vuelta(cadena)
        Dim cad As String = cadena
        Dim resultado As String = ""
        Dim largo As Integer = cad.Length - 1
        Dim caracter As Char = ""
        While largo >= 0
            caracter = cad.Chars(largo)
            resultado = resultado + caracter
            largo = largo - 1
        End While
        Return resultado
    End Function

    Function dar_vuelta_fecha(cadena)
        Dim resultado As String = ""
        Dim cad As String = cadena
        resultado = cad.Chars(8) & cad.Chars(9) & "/" & cad.Chars(5) & cad.Chars(6) & "/" & cad.Chars(0) &
                    cad.Chars(1) & cad.Chars(2) & cad.Chars(3)
        Return resultado
    End Function

    Function invertir_fecha(cadena)
        '/////para convertir a formato YYYY-MM-DD
        Dim resultado As String = ""
        Dim cad As String = cadena
        resultado = cad.Chars(6) & cad.Chars(7) & cad.Chars(8) & cad.Chars(9) & "-" & cad.Chars(3) & cad.Chars(4) &
                    "-" & cad.Chars(0) & cad.Chars(1)
        Return resultado
    End Function

    Function formato_espacios(cadena As String, espacios As Integer)
        Dim texto As String = cadena
        Dim i As Integer = 0
        Dim largo As Integer = espacios
        While i < largo
            texto = texto & " "
            i = i + 1
        End While
        Return texto
    End Function

    Function CorregirDinero(dineroTexto As String)
        Dim valor As String = dineroTexto
        Dim dineroCorregido As String = ""
        Dim num As Integer = 0

        '////////////////////////////////////////////////
        valor = valor.Replace(" ", "")
        valor = valor.Replace("$", "")
        valor = valor.Replace(".", "")
        If valor = "" Then
            num = 0
        Else
            num = Convert.ToInt32(Trim(valor))
        End If
        valor = convertir_dinero(num)
        '/////////////////////////////////////////////////
        dineroCorregido = valor
        Return dineroCorregido
    End Function

End Class
